<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.btnreports = New System.Windows.Forms.Button()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnorder = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.pnlmain = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlheader.SuspendLayout()
        Me.pnlmain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlheader.Controls.Add(Me.lblwelcome)
        Me.pnlheader.Controls.Add(Me.lbltitle)
        Me.pnlheader.Location = New System.Drawing.Point(89, 56)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1181, 80)
        Me.pnlheader.TabIndex = 0
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.White
        Me.btnlogout.Location = New System.Drawing.Point(701, 346)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(20)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(260, 120)
        Me.btnlogout.TabIndex = 5
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'lblwelcome
        '
        Me.lblwelcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblwelcome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.ForeColor = System.Drawing.Color.White
        Me.lblwelcome.Location = New System.Drawing.Point(1000, 29)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(137, 21)
        Me.lblwelcome.TabIndex = 1
        Me.lblwelcome.Text = "Welcome,Admin"
        '
        'btnreports
        '
        Me.btnreports.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnreports.FlatAppearance.BorderSize = 0
        Me.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreports.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreports.ForeColor = System.Drawing.Color.White
        Me.btnreports.Location = New System.Drawing.Point(221, 346)
        Me.btnreports.Margin = New System.Windows.Forms.Padding(20)
        Me.btnreports.Name = "btnreports"
        Me.btnreports.Size = New System.Drawing.Size(260, 120)
        Me.btnreports.TabIndex = 4
        Me.btnreports.Text = "Sales Reports"
        Me.btnreports.UseVisualStyleBackColor = False
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(38, 22)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(105, 32)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = " K² Cafe"
        '
        'btnorder
        '
        Me.btnorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnorder.FlatAppearance.BorderSize = 0
        Me.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnorder.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorder.ForeColor = System.Drawing.Color.White
        Me.btnorder.Location = New System.Drawing.Point(461, 113)
        Me.btnorder.Margin = New System.Windows.Forms.Padding(20)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(260, 120)
        Me.btnorder.TabIndex = 2
        Me.btnorder.Text = "New Order"
        Me.btnorder.UseVisualStyleBackColor = False
        '
        'btnuser
        '
        Me.btnuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnuser.FlatAppearance.BorderSize = 0
        Me.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnuser.ForeColor = System.Drawing.Color.White
        Me.btnuser.Location = New System.Drawing.Point(101, 113)
        Me.btnuser.Margin = New System.Windows.Forms.Padding(80, 20, 20, 20)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(260, 120)
        Me.btnuser.TabIndex = 0
        Me.btnuser.Text = "User Management"
        Me.btnuser.UseVisualStyleBackColor = False
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnmenu.FlatAppearance.BorderSize = 0
        Me.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.ForeColor = System.Drawing.Color.White
        Me.btnmenu.Location = New System.Drawing.Point(821, 113)
        Me.btnmenu.Margin = New System.Windows.Forms.Padding(20)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(260, 120)
        Me.btnmenu.TabIndex = 1
        Me.btnmenu.Text = "Menu"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'pnlmain
        '
        Me.pnlmain.BackColor = System.Drawing.Color.Transparent
        Me.pnlmain.Controls.Add(Me.Panel1)
        Me.pnlmain.Controls.Add(Me.pnlheader)
        Me.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlmain.Location = New System.Drawing.Point(0, 0)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(1360, 739)
        Me.pnlmain.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnuser)
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.btnmenu)
        Me.Panel1.Controls.Add(Me.btnreports)
        Me.Panel1.Controls.Add(Me.btnorder)
        Me.Panel1.Location = New System.Drawing.Point(89, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1181, 579)
        Me.Panel1.TabIndex = 0
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1360, 739)
        Me.Controls.Add(Me.pnlmain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DashboardForm"
        Me.Text = "Cafe Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.pnlmain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents lblwelcome As System.Windows.Forms.Label
    Friend WithEvents pnlmain As System.Windows.Forms.Panel
    Friend WithEvents btnuser As System.Windows.Forms.Button
    Friend WithEvents btnorder As System.Windows.Forms.Button
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btnreports As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
