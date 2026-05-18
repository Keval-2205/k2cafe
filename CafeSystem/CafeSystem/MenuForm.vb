Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class MenuForm

    ' ---------------- FORM LOAD ----------------
    Private Sub Menu_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadMenuItems()
    End Sub

    ' ---------------- LOAD CATEGORIES ----------------
    Private Sub LoadCategories()
        cmbcategory.Items.Clear()

        Try
            Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
                Dim cmd As New SqlCommand("SELECT DISTINCT Category FROM Menu WHERE Category IS NOT NULL AND Category <> ''", con)
                con.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    cmbcategory.Items.Add(reader("Category").ToString())
                End While
            End Using

            If cmbcategory.Items.Count > 0 Then
                cmbcategory.SelectedIndex = 0
            Else
                MessageBox.Show("No categories found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------------- LOAD MENU ITEMS ----------------
    Private Sub LoadMenuItems()
        dgvmenu.DataSource = Nothing
        Try
            Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
                Dim cmd As New SqlCommand("SELECT ID, Product_Name, Category, Price, Status FROM Menu", con)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' Convert Status to readable text
                For Each row As DataRow In dt.Rows
                    row("Status") = If(CBool(row("Status")), True, False)
                Next

                dgvmenu.DataSource = dt
                dgvmenu.Refresh()

                lblTotalItems.Text = "Total Items: " & dt.Rows.Count.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading menu items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------------- CLEAR FIELDS ----------------
    Private Sub ClearFields()
        txtproductname.Text = ""
        txtprice.Text = ""
        If cmbcategory.Items.Count > 0 Then
            cmbcategory.SelectedIndex = 0
        End If
    End Sub

    ' ---------------- VALIDATION ----------------
    Private Function ValidateFields() As Boolean
        ' Product name validation
        If String.IsNullOrWhiteSpace(txtproductname.Text) OrElse txtproductname.Text.Length < 3 Then
            MessageBox.Show("Product name must be at least 3 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Price validation
        Dim priceValue As Decimal
        If Not Decimal.TryParse(txtprice.Text, priceValue) OrElse priceValue <= 0 Then
            MessageBox.Show("Price must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' ---------------- SAVE NEW ITEM ----------------
    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsave.Click
        If Not ValidateFields() Then Exit Sub

        Try
            Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
                ' Check for duplicate product name
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Menu WHERE Product_Name=@ProductName", con)
                checkCmd.Parameters.AddWithValue("@ProductName", txtproductname.Text)
                con.Open()
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                con.Close()

                If count > 0 Then
                    MessageBox.Show("Product already exists. Please choose a different name.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' Insert new item
                Dim cmd As New SqlCommand("INSERT INTO Menu (Product_Name, Category, Price, Status) VALUES (@ProductName, @Category, @Price, @Status)", con)
                cmd.Parameters.AddWithValue("@ProductName", txtproductname.Text)
                cmd.Parameters.AddWithValue("@Category", cmbcategory.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Price", Decimal.Parse(txtprice.Text))
                cmd.Parameters.AddWithValue("@Status", True)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Menu item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadMenuItems()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error adding menu item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------------- UPDATE ITEM ----------------
    Private Sub btnupdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnupdate.Click
        If dgvmenu.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidateFields() Then Exit Sub

        Dim selectedID As Integer = Convert.ToInt32(dgvmenu.SelectedRows(0).Cells("ID").Value)

        Try
            Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
                Dim cmd As New SqlCommand("UPDATE Menu SET Product_Name=@ProductName, Category=@Category, Price=@Price WHERE ID=@ID", con)
                cmd.Parameters.AddWithValue("@ProductName", txtproductname.Text)
                cmd.Parameters.AddWithValue("@Category", cmbcategory.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Price", Decimal.Parse(txtprice.Text))
                cmd.Parameters.AddWithValue("@ID", selectedID)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Menu item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadMenuItems()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error updating menu item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------------- DELETE ITEM ----------------
    Private Sub btndelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btndelete.Click
        If dgvmenu.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedID As Integer = Convert.ToInt32(dgvmenu.SelectedRows(0).Cells("ID").Value)

        If MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
                Dim cmd As New SqlCommand("DELETE FROM Menu WHERE ID=@ID", con)
                cmd.Parameters.AddWithValue("@ID", selectedID)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Menu item deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadMenuItems()

        Catch ex As Exception
            MessageBox.Show("Error deleting menu item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnActivateItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnActivateItem.Click
        If dgvmenu.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = Convert.ToInt32(dgvmenu.SelectedRows(0).Cells("ID").Value)
            UpdateItemStatus(selectedID, True)
        Else
            MessageBox.Show("Please select an item to activate.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDeactivateItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeactivateItem.Click
        If dgvmenu.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = Convert.ToInt32(dgvmenu.SelectedRows(0).Cells("ID").Value)
            UpdateItemStatus(selectedID, False)
        Else
            MessageBox.Show("Please select an item to deactivate.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub UpdateItemStatus(ByVal itemID As Integer, ByVal status As Boolean)
        Try
            Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
                Dim cmd As New SqlCommand("UPDATE Menu SET Status=@Status WHERE ID=@ID", con)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@ID", itemID)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Item status updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadMenuItems()

        Catch ex As Exception
            MessageBox.Show("Error updating item status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
