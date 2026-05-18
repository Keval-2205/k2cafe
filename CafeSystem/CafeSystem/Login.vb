Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class Login

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click


        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Please enter Username and Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim con As New SqlConnection(My.Settings.cafeDBConnectionString)

        Dim cmd As New SqlCommand("SELECT Role FROM Users WHERE Username=@u AND Password=@p AND Status=1", con)

        cmd.Parameters.AddWithValue("@u", txtusername.Text)
        cmd.Parameters.AddWithValue("@p", txtpassword.Text)

        Try
            con.Open()

            Dim role As Object = cmd.ExecuteScalar()

            If role IsNot Nothing Then
                DashboardForm.UserRole = role.ToString()
                DashboardForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub RoundControl(ByVal ctrl As Control, ByVal radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        ctrl.Region = New Region(path)
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RoundControl(Panel1, 30)

    End Sub
End Class
