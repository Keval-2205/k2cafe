<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingForm
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
        Me.grpbilling = New System.Windows.Forms.GroupBox()
        Me.txtcashier = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtorderid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grporder = New System.Windows.Forms.GroupBox()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.dgvOrderSummary = New System.Windows.Forms.DataGridView()
        Me.grppayment = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBalanceDue = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoUPI = New System.Windows.Forms.RadioButton()
        Me.rdoCard = New System.Windows.Forms.RadioButton()
        Me.rdoCash = New System.Windows.Forms.RadioButton()
        Me.btnPrintBill = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgvbill = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpaid = New System.Windows.Forms.TextBox()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlheader.SuspendLayout()
        Me.grpbilling.SuspendLayout()
        Me.grporder.SuspendLayout()
        CType(Me.dgvOrderSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grppayment.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvbill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlheader.Controls.Add(Me.Label1)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1084, 55)
        Me.pnlheader.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Billing And Payment"
        '
        'grpbilling
        '
        Me.grpbilling.Controls.Add(Me.txtcashier)
        Me.grpbilling.Controls.Add(Me.Label4)
        Me.grpbilling.Controls.Add(Me.txtdate)
        Me.grpbilling.Controls.Add(Me.Label3)
        Me.grpbilling.Controls.Add(Me.txtorderid)
        Me.grpbilling.Controls.Add(Me.Label2)
        Me.grpbilling.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbilling.Location = New System.Drawing.Point(30, 70)
        Me.grpbilling.Name = "grpbilling"
        Me.grpbilling.Size = New System.Drawing.Size(1040, 100)
        Me.grpbilling.TabIndex = 1
        Me.grpbilling.TabStop = False
        Me.grpbilling.Text = "Billing Details"
        '
        'txtcashier
        '
        Me.txtcashier.Location = New System.Drawing.Point(762, 44)
        Me.txtcashier.Name = "txtcashier"
        Me.txtcashier.ReadOnly = True
        Me.txtcashier.Size = New System.Drawing.Size(150, 25)
        Me.txtcashier.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(679, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cashier:"
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(464, 44)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.ReadOnly = True
        Me.txtdate.Size = New System.Drawing.Size(200, 25)
        Me.txtdate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(395, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date:"
        '
        'txtorderid
        '
        Me.txtorderid.Location = New System.Drawing.Point(223, 44)
        Me.txtorderid.Name = "txtorderid"
        Me.txtorderid.ReadOnly = True
        Me.txtorderid.Size = New System.Drawing.Size(120, 25)
        Me.txtorderid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Order ID:"
        '
        'grporder
        '
        Me.grporder.Controls.Add(Me.lblFinalTotal)
        Me.grporder.Controls.Add(Me.Label12)
        Me.grporder.Controls.Add(Me.Label11)
        Me.grporder.Controls.Add(Me.Label10)
        Me.grporder.Controls.Add(Me.lblGST)
        Me.grporder.Controls.Add(Me.lblDiscount)
        Me.grporder.Controls.Add(Me.lblSubtotal)
        Me.grporder.Controls.Add(Me.dgvOrderSummary)
        Me.grporder.Location = New System.Drawing.Point(30, 190)
        Me.grporder.Name = "grporder"
        Me.grporder.Size = New System.Drawing.Size(700, 350)
        Me.grporder.TabIndex = 2
        Me.grporder.TabStop = False
        Me.grporder.Text = "Order Summary"
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTotal.Location = New System.Drawing.Point(484, 312)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(18, 20)
        Me.lblFinalTotal.TabIndex = 8
        Me.lblFinalTotal.Text = "$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(540, 293)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(540, 267)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(560, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 5
        '
        'lblGST
        '
        Me.lblGST.AutoSize = True
        Me.lblGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblGST.Location = New System.Drawing.Point(482, 293)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(31, 15)
        Me.lblGST.TabIndex = 3
        Me.lblGST.Text = "GST"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblDiscount.Location = New System.Drawing.Point(481, 270)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(55, 15)
        Me.lblDiscount.TabIndex = 2
        Me.lblDiscount.Text = "Discount"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(479, 246)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(52, 15)
        Me.lblSubtotal.TabIndex = 1
        Me.lblSubtotal.Text = "Subtotal"
        '
        'dgvOrderSummary
        '
        Me.dgvOrderSummary.AllowUserToAddRows = False
        Me.dgvOrderSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colItem, Me.colQty, Me.colPrice, Me.colTotal})
        Me.dgvOrderSummary.Location = New System.Drawing.Point(0, 19)
        Me.dgvOrderSummary.Name = "dgvOrderSummary"
        Me.dgvOrderSummary.ReadOnly = True
        Me.dgvOrderSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderSummary.Size = New System.Drawing.Size(700, 218)
        Me.dgvOrderSummary.TabIndex = 0
        '
        'grppayment
        '
        Me.grppayment.Controls.Add(Me.GroupBox3)
        Me.grppayment.Controls.Add(Me.GroupBox2)
        Me.grppayment.Controls.Add(Me.GroupBox1)
        Me.grppayment.Location = New System.Drawing.Point(750, 190)
        Me.grppayment.Name = "grppayment"
        Me.grppayment.Size = New System.Drawing.Size(320, 350)
        Me.grppayment.TabIndex = 3
        Me.grppayment.TabStop = False
        Me.grppayment.Text = "Payment"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBalanceDue)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 235)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(297, 71)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Balance Due"
        '
        'txtBalanceDue
        '
        Me.txtBalanceDue.Location = New System.Drawing.Point(37, 29)
        Me.txtBalanceDue.Name = "txtBalanceDue"
        Me.txtBalanceDue.ReadOnly = True
        Me.txtBalanceDue.Size = New System.Drawing.Size(227, 20)
        Me.txtBalanceDue.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAmountPaid)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 78)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Amount Paid"
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Location = New System.Drawing.Point(37, 32)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(227, 20)
        Me.txtAmountPaid.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoUPI)
        Me.GroupBox1.Controls.Add(Me.rdoCard)
        Me.GroupBox1.Controls.Add(Me.rdoCash)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 116)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Mode"
        '
        'rdoUPI
        '
        Me.rdoUPI.AutoSize = True
        Me.rdoUPI.Location = New System.Drawing.Point(14, 86)
        Me.rdoUPI.Name = "rdoUPI"
        Me.rdoUPI.Size = New System.Drawing.Size(43, 17)
        Me.rdoUPI.TabIndex = 7
        Me.rdoUPI.TabStop = True
        Me.rdoUPI.Text = "UPI"
        Me.rdoUPI.UseVisualStyleBackColor = True
        '
        'rdoCard
        '
        Me.rdoCard.AutoSize = True
        Me.rdoCard.Location = New System.Drawing.Point(14, 56)
        Me.rdoCard.Name = "rdoCard"
        Me.rdoCard.Size = New System.Drawing.Size(77, 17)
        Me.rdoCard.TabIndex = 6
        Me.rdoCard.TabStop = True
        Me.rdoCard.Text = "Credit Card"
        Me.rdoCard.UseVisualStyleBackColor = True
        '
        'rdoCash
        '
        Me.rdoCash.AutoSize = True
        Me.rdoCash.Location = New System.Drawing.Point(14, 26)
        Me.rdoCash.Name = "rdoCash"
        Me.rdoCash.Size = New System.Drawing.Size(49, 17)
        Me.rdoCash.TabIndex = 5
        Me.rdoCash.Text = "Cash"
        Me.rdoCash.UseVisualStyleBackColor = True
        '
        'btnPrintBill
        '
        Me.btnPrintBill.BackColor = System.Drawing.Color.DarkOrange
        Me.btnPrintBill.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintBill.ForeColor = System.Drawing.Color.White
        Me.btnPrintBill.Location = New System.Drawing.Point(303, 575)
        Me.btnPrintBill.Name = "btnPrintBill"
        Me.btnPrintBill.Size = New System.Drawing.Size(160, 45)
        Me.btnPrintBill.TabIndex = 4
        Me.btnPrintBill.Text = "Print Bill"
        Me.btnPrintBill.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.IndianRed
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(534, 575)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(160, 45)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'dgvbill
        '
        Me.dgvbill.AllowUserToAddRows = False
        Me.dgvbill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbill.Location = New System.Drawing.Point(0, 19)
        Me.dgvbill.Name = "dgvbill"
        Me.dgvbill.ReadOnly = True
        Me.dgvbill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvbill.Size = New System.Drawing.Size(700, 218)
        Me.dgvbill.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(479, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Subtotal"
        '
        'txtpaid
        '
        Me.txtpaid.Location = New System.Drawing.Point(37, 32)
        Me.txtpaid.Name = "txtpaid"
        Me.txtpaid.Size = New System.Drawing.Size(227, 20)
        Me.txtpaid.TabIndex = 0
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'colItem
        '
        Me.colItem.HeaderText = "Item"
        Me.colItem.Name = "colItem"
        Me.colItem.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        '
        'colPrice
        '
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrintBill)
        Me.Controls.Add(Me.grppayment)
        Me.Controls.Add(Me.grporder)
        Me.Controls.Add(Me.grpbilling)
        Me.Controls.Add(Me.pnlheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BillingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing & Payment"
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.grpbilling.ResumeLayout(False)
        Me.grpbilling.PerformLayout()
        Me.grporder.ResumeLayout(False)
        Me.grporder.PerformLayout()
        CType(Me.dgvOrderSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grppayment.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvbill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpbilling As System.Windows.Forms.GroupBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtorderid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcashier As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grporder As System.Windows.Forms.GroupBox
    Friend WithEvents dgvOrderSummary As System.Windows.Forms.DataGridView
    Friend WithEvents grppayment As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoUPI As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCard As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCash As System.Windows.Forms.RadioButton
    Friend WithEvents lblFinalTotal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBalanceDue As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintBill As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dgvbill As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpaid As System.Windows.Forms.TextBox
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
