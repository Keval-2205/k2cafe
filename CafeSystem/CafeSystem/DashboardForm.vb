Imports System.Drawing.Drawing2D

Public Class DashboardForm
    Public UserRole As String

    Private Sub DashboardForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        lblwelcome.Text = "Welcome, " & UserRole
        ApplyRolePermissions()
        RoundBottomCorners(Panel1, 30)
        RoundTopCorners(pnlheader, 30)
        RoundControl(btnlogout, 18)
        RoundControl(btnmenu, 18)
        RoundControl(btnorder, 18)
        RoundControl(btnreports, 18)
        RoundControl(btnuser, 18)


    End Sub

    ' ---------------- ROLE-BASED ACCESS ----------------
    Private Sub ApplyRolePermissions()
        If UserRole = "Admin" Then
            ' Full access
            btnuser.Enabled = True
            btnmenu.Enabled = True
            btnorder.Enabled = True
            btnreports.Enabled = True

        ElseIf UserRole = "Staff" Then
            ' Limited access
            btnuser.Enabled = False
            btnmenu.Enabled = False
            'btnreports.Enabled = False

            btnuser.BackColor = Color.LightGray
            btnmenu.BackColor = Color.LightGray
            btnreports.BackColor = Color.LightGray

            btnorder.Enabled = True
        End If
    End Sub

    ' ---------------- BUTTON EVENTS ----------------
    Private Sub btnuser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnuser.Click
        If Not btnuser.Enabled Then
            MessageBox.Show("Access Denied", "Permission", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        User.Show()

    End Sub

    Private Sub btnmenu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnmenu.Click
        If Not btnmenu.Enabled Then
            MessageBox.Show("Access Denied", "Permission", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        MenuForm.Show()
    End Sub

    Private Sub btnorder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnorder.Click
        OrderForm.Show()
    End Sub

    Private Sub btnreports_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnreports.Click
        If Not btnreports.Enabled Then
            MessageBox.Show("Access Denied", "Permission", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        SalesReports.Show()

    End Sub

    Private Sub btnlogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnlogout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

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
    Private Sub RoundBottomCorners(ByVal ctrl As Control, ByVal radius As Integer)
        Dim path As New GraphicsPath()

        path.StartFigure()

        ' Top-left (square)
        path.AddLine(0, 0, ctrl.Width, 0)

        ' Top-right (square)
        path.AddLine(ctrl.Width, 0, ctrl.Width, ctrl.Height - radius)

        ' Bottom-right (rounded)
        path.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90)

        ' Bottom-left (rounded)
        path.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90)

        path.CloseFigure()
        ctrl.Region = New Region(path)
    End Sub
    Private Sub RoundTopCorners(ByVal ctrl As Control, ByVal radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()

        ' Top-left (rounded)
        path.AddArc(0, 0, radius, radius, 180, 90)

        ' Top-right (rounded)
        path.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90)

        ' Right side (square)
        path.AddLine(ctrl.Width, radius, ctrl.Width, ctrl.Height)

        ' Bottom side (square)
        path.AddLine(ctrl.Width, ctrl.Height, 0, ctrl.Height)

        ' Left side (square)
        path.AddLine(0, ctrl.Height, 0, radius)

        path.CloseFigure()
        ctrl.Region = New Region(path)
    End Sub


End Class
