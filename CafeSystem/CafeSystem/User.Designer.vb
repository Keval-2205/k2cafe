<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpadduser = New System.Windows.Forms.GroupBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.cmbrole = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpusers = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvusers = New System.Windows.Forms.DataGridView()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnactivate = New System.Windows.Forms.Button()
        Me.btndeactivate = New System.Windows.Forms.Button()
        Me.pnlheader.SuspendLayout()
        Me.grpadduser.SuspendLayout()
        Me.grpusers.SuspendLayout()
        CType(Me.dgvusers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlheader.Controls.Add(Me.Label1)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(984, 60)
        Me.pnlheader.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Management"
        '
        'grpadduser
        '
        Me.grpadduser.Controls.Add(Me.btnclear)
        Me.grpadduser.Controls.Add(Me.btnadd)
        Me.grpadduser.Controls.Add(Me.cmbrole)
        Me.grpadduser.Controls.Add(Me.Label4)
        Me.grpadduser.Controls.Add(Me.txtpassword)
        Me.grpadduser.Controls.Add(Me.Label3)
        Me.grpadduser.Controls.Add(Me.txtusername)
        Me.grpadduser.Controls.Add(Me.Label2)
        Me.grpadduser.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpadduser.Location = New System.Drawing.Point(50, 90)
        Me.grpadduser.Name = "grpadduser"
        Me.grpadduser.Size = New System.Drawing.Size(900, 180)
        Me.grpadduser.TabIndex = 1
        Me.grpadduser.TabStop = False
        Me.grpadduser.Text = "Add New User"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.LightGray
        Me.btnclear.Location = New System.Drawing.Point(500, 95)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(150, 40)
        Me.btnclear.TabIndex = 9
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.SeaGreen
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(500, 45)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(150, 40)
        Me.btnadd.TabIndex = 8
        Me.btnadd.Text = "Add User"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'cmbrole
        '
        Me.cmbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbrole.FormattingEnabled = True
        Me.cmbrole.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.cmbrole.Location = New System.Drawing.Point(180, 115)
        Me.cmbrole.Name = "cmbrole"
        Me.cmbrole.Size = New System.Drawing.Size(250, 28)
        Me.cmbrole.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Role"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(180, 75)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(250, 27)
        Me.txtpassword.TabIndex = 5
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(180, 35)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(250, 27)
        Me.txtusername.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'grpusers
        '
        Me.grpusers.Controls.Add(Me.Label5)
        Me.grpusers.Controls.Add(Me.dgvusers)
        Me.grpusers.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpusers.Location = New System.Drawing.Point(50, 290)
        Me.grpusers.Name = "grpusers"
        Me.grpusers.Size = New System.Drawing.Size(900, 260)
        Me.grpusers.TabIndex = 2
        Me.grpusers.TabStop = False
        Me.grpusers.Text = "User List"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(760, 560)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Total Users: 0"
        '
        'dgvusers
        '
        Me.dgvusers.AllowUserToAddRows = False
        Me.dgvusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvusers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvusers.Location = New System.Drawing.Point(3, 23)
        Me.dgvusers.Name = "dgvusers"
        Me.dgvusers.ReadOnly = True
        Me.dgvusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvusers.Size = New System.Drawing.Size(894, 234)
        Me.dgvusers.TabIndex = 0
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.SteelBlue
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(139, 559)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(150, 40)
        Me.btnupdate.TabIndex = 1
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.IndianRed
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(305, 559)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(150, 40)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnactivate
        '
        Me.btnactivate.BackColor = System.Drawing.Color.SeaGreen
        Me.btnactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactivate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactivate.Location = New System.Drawing.Point(471, 559)
        Me.btnactivate.Name = "btnactivate"
        Me.btnactivate.Size = New System.Drawing.Size(150, 40)
        Me.btnactivate.TabIndex = 4
        Me.btnactivate.Text = "Activate"
        Me.btnactivate.UseVisualStyleBackColor = False
        '
        'btndeactivate
        '
        Me.btndeactivate.BackColor = System.Drawing.Color.DarkOrange
        Me.btndeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeactivate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeactivate.Location = New System.Drawing.Point(639, 559)
        Me.btndeactivate.Name = "btndeactivate"
        Me.btndeactivate.Size = New System.Drawing.Size(150, 40)
        Me.btndeactivate.TabIndex = 5
        Me.btndeactivate.Text = "Deactivate"
        Me.btndeactivate.UseVisualStyleBackColor = False
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.btndeactivate)
        Me.Controls.Add(Me.btnactivate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.grpusers)
        Me.Controls.Add(Me.grpadduser)
        Me.Controls.Add(Me.pnlheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Management"
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.grpadduser.ResumeLayout(False)
        Me.grpadduser.PerformLayout()
        Me.grpusers.ResumeLayout(False)
        Me.grpusers.PerformLayout()
        CType(Me.dgvusers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpadduser As System.Windows.Forms.GroupBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents cmbrole As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpusers As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvusers As System.Windows.Forms.DataGridView
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnactivate As System.Windows.Forms.Button
    Friend WithEvents btndeactivate As System.Windows.Forms.Button
End Class
