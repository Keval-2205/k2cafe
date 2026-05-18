<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.grpneworder = New System.Windows.Forms.GroupBox()
        Me.btnadditem = New System.Windows.Forms.Button()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSelectItem = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpsummery = New System.Windows.Forms.GroupBox()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbUPI = New System.Windows.Forms.RadioButton()
        Me.rbCard = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.pnlheader.SuspendLayout()
        Me.grpneworder.SuspendLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpsummery.SuspendLayout()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlheader.Controls.Add(Me.lbltitle)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(984, 50)
        Me.pnlheader.TabIndex = 0
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(15, 13)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(179, 25)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Oder Management"
        '
        'grpneworder
        '
        Me.grpneworder.Controls.Add(Me.cmbCategory)
        Me.grpneworder.Controls.Add(Me.Label3)
        Me.grpneworder.Controls.Add(Me.btnadditem)
        Me.grpneworder.Controls.Add(Me.numQuantity)
        Me.grpneworder.Controls.Add(Me.Label2)
        Me.grpneworder.Controls.Add(Me.cmbSelectItem)
        Me.grpneworder.Controls.Add(Me.Label1)
        Me.grpneworder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpneworder.Location = New System.Drawing.Point(40, 70)
        Me.grpneworder.Name = "grpneworder"
        Me.grpneworder.Size = New System.Drawing.Size(920, 120)
        Me.grpneworder.TabIndex = 1
        Me.grpneworder.TabStop = False
        Me.grpneworder.Text = "New Order"
        '
        'btnadditem
        '
        Me.btnadditem.BackColor = System.Drawing.Color.SeaGreen
        Me.btnadditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadditem.ForeColor = System.Drawing.Color.White
        Me.btnadditem.Location = New System.Drawing.Point(747, 41)
        Me.btnadditem.Name = "btnadditem"
        Me.btnadditem.Size = New System.Drawing.Size(140, 40)
        Me.btnadditem.TabIndex = 2
        Me.btnadditem.Text = "Add Item"
        Me.btnadditem.UseVisualStyleBackColor = False
        '
        'numQuantity
        '
        Me.numQuantity.Location = New System.Drawing.Point(565, 36)
        Me.numQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(120, 25)
        Me.numQuantity.TabIndex = 3
        Me.numQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(492, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity:"
        '
        'cmbSelectItem
        '
        Me.cmbSelectItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectItem.FormattingEnabled = True
        Me.cmbSelectItem.Location = New System.Drawing.Point(170, 72)
        Me.cmbSelectItem.Name = "cmbSelectItem"
        Me.cmbSelectItem.Size = New System.Drawing.Size(220, 25)
        Me.cmbSelectItem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Item:"
        '
        'grpsummery
        '
        Me.grpsummery.Controls.Add(Me.dgvOrder)
        Me.grpsummery.Controls.Add(Me.btnCancelOrder)
        Me.grpsummery.Controls.Add(Me.btnPlaceOrder)
        Me.grpsummery.Controls.Add(Me.btnRemoveItem)
        Me.grpsummery.Controls.Add(Me.GroupBox1)
        Me.grpsummery.Controls.Add(Me.lblTotalAmount)
        Me.grpsummery.Controls.Add(Me.txtGST)
        Me.grpsummery.Controls.Add(Me.CheckBox2)
        Me.grpsummery.Controls.Add(Me.txtDiscount)
        Me.grpsummery.Controls.Add(Me.CheckBox1)
        Me.grpsummery.Location = New System.Drawing.Point(40, 210)
        Me.grpsummery.Name = "grpsummery"
        Me.grpsummery.Size = New System.Drawing.Size(920, 316)
        Me.grpsummery.TabIndex = 2
        Me.grpsummery.TabStop = False
        Me.grpsummery.Text = "Order Summery"
        '
        'dgvOrder
        '
        Me.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPrice, Me.colQty, Me.colTotal, Me.colItem})
        Me.dgvOrder.Location = New System.Drawing.Point(23, 37)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.Size = New System.Drawing.Size(569, 221)
        Me.dgvOrder.TabIndex = 12
        '
        'colPrice
        '
        Me.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        '
        'colTotal
        '
        Me.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'colItem
        '
        Me.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colItem.HeaderText = "Item"
        Me.colItem.Name = "colItem"
        Me.colItem.ReadOnly = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.BackColor = System.Drawing.Color.DarkRed
        Me.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelOrder.ForeColor = System.Drawing.Color.White
        Me.btnCancelOrder.Location = New System.Drawing.Point(526, 261)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(137, 49)
        Me.btnCancelOrder.TabIndex = 11
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = False
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.BackColor = System.Drawing.Color.DarkOrange
        Me.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaceOrder.ForeColor = System.Drawing.Color.White
        Me.btnPlaceOrder.Location = New System.Drawing.Point(383, 261)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(137, 49)
        Me.btnPlaceOrder.TabIndex = 10
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = False
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.IndianRed
        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.btnRemoveItem.Location = New System.Drawing.Point(227, 264)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(145, 46)
        Me.btnRemoveItem.TabIndex = 8
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbUPI)
        Me.GroupBox1.Controls.Add(Me.rbCard)
        Me.GroupBox1.Controls.Add(Me.rbCash)
        Me.GroupBox1.Location = New System.Drawing.Point(621, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 80)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Method"
        '
        'rbUPI
        '
        Me.rbUPI.AutoSize = True
        Me.rbUPI.Location = New System.Drawing.Point(175, 38)
        Me.rbUPI.Name = "rbUPI"
        Me.rbUPI.Size = New System.Drawing.Size(43, 17)
        Me.rbUPI.TabIndex = 2
        Me.rbUPI.TabStop = True
        Me.rbUPI.Text = "UPI"
        Me.rbUPI.UseVisualStyleBackColor = True
        '
        'rbCard
        '
        Me.rbCard.AutoSize = True
        Me.rbCard.Location = New System.Drawing.Point(92, 38)
        Me.rbCard.Name = "rbCard"
        Me.rbCard.Size = New System.Drawing.Size(77, 17)
        Me.rbCard.TabIndex = 1
        Me.rbCard.TabStop = True
        Me.rbCard.Text = "Credit Card"
        Me.rbCard.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Location = New System.Drawing.Point(29, 38)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(49, 17)
        Me.rbCash.TabIndex = 0
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "Cash"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(671, 102)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(49, 24)
        Me.lblTotalAmount.TabIndex = 6
        Me.lblTotalAmount.Text = "0.00"
        '
        'txtGST
        '
        Me.txtGST.Location = New System.Drawing.Point(754, 60)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(100, 20)
        Me.txtGST.TabIndex = 4
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(654, 62)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "GST(%)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(754, 27)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(654, 27)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Discount(%)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.DarkRed
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(753, 246)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(137, 49)
        Me.btncancel.TabIndex = 11
        Me.btncancel.Text = "Cancel Order"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(170, 39)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(220, 25)
        Me.cmbCategory.TabIndex = 5
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.grpsummery)
        Me.Controls.Add(Me.grpneworder)
        Me.Controls.Add(Me.pnlheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "OrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Management"
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.grpneworder.ResumeLayout(False)
        Me.grpneworder.PerformLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpsummery.ResumeLayout(False)
        Me.grpsummery.PerformLayout()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents grpneworder As System.Windows.Forms.GroupBox
    Friend WithEvents btnadditem As System.Windows.Forms.Button
    Friend WithEvents numQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSelectItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpsummery As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelOrder As System.Windows.Forms.Button
    Friend WithEvents btnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbUPI As System.Windows.Forms.RadioButton
    Friend WithEvents rbCard As System.Windows.Forms.RadioButton
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents txtGST As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents dgvOrder As System.Windows.Forms.DataGridView
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
End Class
