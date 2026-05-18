Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class User

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadRoles()
        LoadUsers()
        SetupGrid()
    End Sub

    Private Sub LoadRoles()
        cmbRole.Items.Clear()
        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Staff")
        cmbRole.SelectedIndex = 0
    End Sub

    Private Sub SetupGrid()
        dgvusers.AutoGenerateColumns = True
        dgvusers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvusers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub LoadUsers()
        Try
            Dim con As New SqlConnection(My.Settings.cafeDBConnectionString)
            Dim cmd As New SqlCommand("SELECT Username, Role, Status FROM Users", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            ' Convert Status to readable text
            For Each row As DataRow In dt.Rows
                row("Status") = If(CBool(row("Status")), True, False)
            Next

            dgvusers.DataSource = dt
            dgvusers.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        txtUsername.Text = ""
        txtPassword.Text = ""
        cmbRole.SelectedIndex = 0
    End Sub

    ' ---------------- ADD USER ----------------
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        ' Validate username
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse txtUsername.Text.Length < 4 OrElse Not Regex.IsMatch(txtUsername.Text, "^[a-zA-Z0-9]+$") Then
            MessageBox.Show("Username must be at least 4 characters and contain only letters/numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate password
        If String.IsNullOrWhiteSpace(txtPassword.Text) OrElse txtPassword.Text.Length < 6 OrElse
           Not Regex.IsMatch(txtPassword.Text, "(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{6,}") Then
            MessageBox.Show("Password must be strong: include uppercase, lowercase, digit, and special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check duplicate username
        Dim con As New SqlConnection(My.Settings.cafeDBConnectionString)
        Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@Username", con)
        checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        con.Open()
        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
        con.Close()

        If count > 0 Then
            MessageBox.Show("Username already exists. Please choose a different one.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Insert new user
        Try
            Dim cmd As New SqlCommand("INSERT INTO Users (Username, Password, Role, Status) VALUES (@Username, @Password, @Role, @Status)", con)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Status", True)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUsers()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' ---------------- UPDATE USER ----------------
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        If dgvusers.SelectedRows.Count > 0 Then
            Dim selectedUsername As String = dgvusers.SelectedRows(0).Cells("Username").Value.ToString()

            ' Validate password
            If String.IsNullOrWhiteSpace(txtPassword.Text) OrElse txtPassword.Text.Length < 6 OrElse
               Not Regex.IsMatch(txtPassword.Text, "(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{6,}") Then
                MessageBox.Show("Password must be strong: include uppercase, lowercase, digit, and special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                Dim con As New SqlConnection(My.Settings.cafeDBConnectionString)
                Dim cmd As New SqlCommand("UPDATE Users SET Password=@Password, Role=@Role WHERE Username=@Username", con)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Username", selectedUsername)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadUsers()
                ClearFields()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a user to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ---------------- DELETE USER ----------------
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If dgvusers.SelectedRows.Count > 0 Then
            Dim selectedUsername As String = dgvusers.SelectedRows(0).Cells("Username").Value.ToString()
            Try
                Dim con As New SqlConnection(My.Settings.cafeDBConnectionString)
                Dim cmd As New SqlCommand("DELETE FROM Users WHERE Username=@Username", con)
                cmd.Parameters.AddWithValue("@Username", selectedUsername)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("User deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadUsers()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ---------------- ACTIVATE / DEACTIVATE ----------------
    Private Sub btnActivate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnActivate.Click
        UpdateStatus(True)
    End Sub

    Private Sub btnDeactivate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeactivate.Click
        UpdateStatus(False)
    End Sub

    Private Sub UpdateStatus(ByVal status As Boolean)
        If dgvusers.SelectedRows.Count > 0 Then
            Dim selectedUsername As String = dgvusers.SelectedRows(0).Cells("Username").Value.ToString()
            Try
                Dim con As New SqlConnection(My.Settings.cafeDBConnectionString)
                Dim cmd As New SqlCommand("UPDATE Users SET Status=@Status WHERE Username=@Username", con)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@Username", selectedUsername)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("User status updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadUsers()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a user to change status.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
