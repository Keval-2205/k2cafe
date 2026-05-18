<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.grpproduct = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.cmbcategory = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtproductname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvmenu = New System.Windows.Forms.DataGridView()
        Me.btnActivateItem = New System.Windows.Forms.Button()
        Me.btnDeactivateItem = New System.Windows.Forms.Button()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.pnlheader.SuspendLayout()
        Me.grpproduct.SuspendLayout()
        CType(Me.dgvmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlheader.Controls.Add(Me.Label1)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(994, 60)
        Me.pnlheader.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Management"
        '
        'grpproduct
        '
        Me.grpproduct.Controls.Add(Me.btndelete)
        Me.grpproduct.Controls.Add(Me.btnupdate)
        Me.grpproduct.Controls.Add(Me.btnsave)
        Me.grpproduct.Controls.Add(Me.cmbcategory)
        Me.grpproduct.Controls.Add(Me.Label4)
        Me.grpproduct.Controls.Add(Me.txtprice)
        Me.grpproduct.Controls.Add(Me.txtproductname)
        Me.grpproduct.Controls.Add(Me.Label3)
        Me.grpproduct.Controls.Add(Me.Label2)
        Me.grpproduct.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpproduct.Location = New System.Drawing.Point(50, 80)
        Me.grpproduct.Name = "grpproduct"
        Me.grpproduct.Size = New System.Drawing.Size(900, 170)
        Me.grpproduct.TabIndex = 1
        Me.grpproduct.TabStop = False
        Me.grpproduct.Text = "Add / Edit Menu Item"
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.IndianRed
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(422, 124)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(140, 40)
        Me.btndelete.TabIndex = 7
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.SteelBlue
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(276, 124)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(140, 40)
        Me.btnupdate.TabIndex = 6
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(130, 124)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(140, 40)
        Me.btnsave.TabIndex = 2
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'cmbcategory
        '
        Me.cmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Location = New System.Drawing.Point(160, 80)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(300, 28)
        Me.cmbcategory.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Category"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(570, 35)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(120, 27)
        Me.txtprice.TabIndex = 3
        '
        'txtproductname
        '
        Me.txtproductname.Location = New System.Drawing.Point(160, 35)
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.Size = New System.Drawing.Size(300, 27)
        Me.txtproductname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(500, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Price "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product Name"
        '
        'dgvmenu
        '
        Me.dgvmenu.AllowUserToAddRows = False
        Me.dgvmenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmenu.Location = New System.Drawing.Point(0, 250)
        Me.dgvmenu.Name = "dgvmenu"
        Me.dgvmenu.ReadOnly = True
        Me.dgvmenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmenu.Size = New System.Drawing.Size(994, 313)
        Me.dgvmenu.TabIndex = 2
        '
        'btnActivateItem
        '
        Me.btnActivateItem.BackColor = System.Drawing.Color.SteelBlue
        Me.btnActivateItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivateItem.ForeColor = System.Drawing.Color.White
        Me.btnActivateItem.Location = New System.Drawing.Point(25, 570)
        Me.btnActivateItem.Name = "btnActivateItem"
        Me.btnActivateItem.Size = New System.Drawing.Size(130, 35)
        Me.btnActivateItem.TabIndex = 3
        Me.btnActivateItem.Text = "Active"
        Me.btnActivateItem.UseVisualStyleBackColor = False
        '
        'btnDeactivateItem
        '
        Me.btnDeactivateItem.BackColor = System.Drawing.Color.IndianRed
        Me.btnDeactivateItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeactivateItem.ForeColor = System.Drawing.Color.White
        Me.btnDeactivateItem.Location = New System.Drawing.Point(161, 570)
        Me.btnDeactivateItem.Name = "btnDeactivateItem"
        Me.btnDeactivateItem.Size = New System.Drawing.Size(130, 35)
        Me.btnDeactivateItem.TabIndex = 5
        Me.btnDeactivateItem.Text = "Deactive"
        Me.btnDeactivateItem.UseVisualStyleBackColor = False
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItems.Location = New System.Drawing.Point(830, 588)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(96, 17)
        Me.lblTotalItems.TabIndex = 7
        Me.lblTotalItems.Text = "Total Items : 0"
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.Location = New System.Drawing.Point(830, 588)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(96, 17)
        Me.lblcount.TabIndex = 7
        Me.lblcount.Text = "Total Items : 0"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(994, 621)
        Me.Controls.Add(Me.lblTotalItems)
        Me.Controls.Add(Me.btnDeactivateItem)
        Me.Controls.Add(Me.btnActivateItem)
        Me.Controls.Add(Me.dgvmenu)
        Me.Controls.Add(Me.grpproduct)
        Me.Controls.Add(Me.pnlheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Management"
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.grpproduct.ResumeLayout(False)
        Me.grpproduct.PerformLayout()
        CType(Me.dgvmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpproduct As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents cmbcategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtproductname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvmenu As System.Windows.Forms.DataGridView
    Friend WithEvents btnActivateItem As System.Windows.Forms.Button
    Friend WithEvents btnDeactivateItem As System.Windows.Forms.Button
    Friend WithEvents lblTotalItems As System.Windows.Forms.Label
    Friend WithEvents lblcount As System.Windows.Forms.Label
End Class
