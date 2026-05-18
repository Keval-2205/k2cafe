<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReports
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
        Me.grpfilter = New System.Windows.Forms.GroupBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.dtto = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpsales = New System.Windows.Forms.GroupBox()
        Me.dgvsales = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Order_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ammount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paymentmode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cashier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCard = New System.Windows.Forms.Label()
        Me.lblUPI = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalOrders = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblMonthlySales = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlheader.SuspendLayout()
        Me.grpfilter.SuspendLayout()
        Me.grpsales.SuspendLayout()
        CType(Me.dgvsales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Reports"
        '
        'grpfilter
        '
        Me.grpfilter.Controls.Add(Me.btnsearch)
        Me.grpfilter.Controls.Add(Me.dtto)
        Me.grpfilter.Controls.Add(Me.Label3)
        Me.grpfilter.Controls.Add(Me.dtfrom)
        Me.grpfilter.Controls.Add(Me.Label2)
        Me.grpfilter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpfilter.Location = New System.Drawing.Point(30, 70)
        Me.grpfilter.Name = "grpfilter"
        Me.grpfilter.Size = New System.Drawing.Size(1040, 80)
        Me.grpfilter.TabIndex = 1
        Me.grpfilter.TabStop = False
        Me.grpfilter.Text = "Filter Sales"
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.SeaGreen
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Location = New System.Drawing.Point(520, 28)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(140, 35)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'dtto
        '
        Me.dtto.Location = New System.Drawing.Point(332, 30)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(160, 25)
        Me.dtto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To Date"
        '
        'dtfrom
        '
        Me.dtfrom.Location = New System.Drawing.Point(80, 30)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(160, 25)
        Me.dtfrom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "From"
        '
        'grpsales
        '
        Me.grpsales.Controls.Add(Me.dgvsales)
        Me.grpsales.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpsales.Location = New System.Drawing.Point(30, 170)
        Me.grpsales.Name = "grpsales"
        Me.grpsales.Size = New System.Drawing.Size(720, 420)
        Me.grpsales.TabIndex = 2
        Me.grpsales.TabStop = False
        Me.grpsales.Text = "Sales Summary"
        '
        'dgvsales
        '
        Me.dgvsales.AllowUserToAddRows = False
        Me.dgvsales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Order_ID, Me.coldate, Me.ammount, Me.Paymentmode, Me.Cashier})
        Me.dgvsales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvsales.Location = New System.Drawing.Point(3, 21)
        Me.dgvsales.Name = "dgvsales"
        Me.dgvsales.ReadOnly = True
        Me.dgvsales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsales.Size = New System.Drawing.Size(714, 396)
        Me.dgvsales.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Order_ID
        '
        Me.Order_ID.HeaderText = "Order ID"
        Me.Order_ID.Name = "Order_ID"
        Me.Order_ID.ReadOnly = True
        '
        'coldate
        '
        Me.coldate.HeaderText = "Date"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = True
        '
        'ammount
        '
        Me.ammount.HeaderText = "Amount"
        Me.ammount.Name = "ammount"
        Me.ammount.ReadOnly = True
        '
        'Paymentmode
        '
        Me.Paymentmode.HeaderText = "Payment Mode"
        Me.Paymentmode.Name = "Paymentmode"
        Me.Paymentmode.ReadOnly = True
        '
        'Cashier
        '
        Me.Cashier.HeaderText = "Cashier"
        Me.Cashier.Name = "Cashier"
        Me.Cashier.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.lblTotalSales)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(780, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 100)
        Me.Panel1.TabIndex = 3
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTotalSales.Location = New System.Drawing.Point(18, 41)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(55, 30)
        Me.lblTotalSales.TabIndex = 1
        Me.lblTotalSales.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Sales"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblCard)
        Me.Panel2.Controls.Add(Me.lblUPI)
        Me.Panel2.Controls.Add(Me.lblCash)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblTotalOrders)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(780, 280)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(320, 170)
        Me.Panel2.TabIndex = 4
        '
        'lblCard
        '
        Me.lblCard.AutoSize = True
        Me.lblCard.Location = New System.Drawing.Point(124, 124)
        Me.lblCard.Name = "lblCard"
        Me.lblCard.Size = New System.Drawing.Size(13, 13)
        Me.lblCard.TabIndex = 7
        Me.lblCard.Text = "0"
        '
        'lblUPI
        '
        Me.lblUPI.AutoSize = True
        Me.lblUPI.Location = New System.Drawing.Point(124, 89)
        Me.lblUPI.Name = "lblUPI"
        Me.lblUPI.Size = New System.Drawing.Size(13, 13)
        Me.lblUPI.TabIndex = 6
        Me.lblUPI.Text = "0"
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Location = New System.Drawing.Point(124, 54)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(13, 13)
        Me.lblCash.TabIndex = 5
        Me.lblCash.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Credit Card"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "UPI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Cash"
        '
        'lblTotalOrders
        '
        Me.lblTotalOrders.AutoSize = True
        Me.lblTotalOrders.Location = New System.Drawing.Point(124, 20)
        Me.lblTotalOrders.Name = "lblTotalOrders"
        Me.lblTotalOrders.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalOrders.TabIndex = 1
        Me.lblTotalOrders.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Orders:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblMonthlySales)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(780, 470)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 100)
        Me.Panel3.TabIndex = 5
        '
        'lblMonthlySales
        '
        Me.lblMonthlySales.AutoSize = True
        Me.lblMonthlySales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlySales.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMonthlySales.Location = New System.Drawing.Point(135, 37)
        Me.lblMonthlySales.Name = "lblMonthlySales"
        Me.lblMonthlySales.Size = New System.Drawing.Size(58, 25)
        Me.lblMonthlySales.TabIndex = 1
        Me.lblMonthlySales.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Total Sales(Monthly)"
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.SteelBlue
        Me.btnrefresh.ForeColor = System.Drawing.Color.White
        Me.btnrefresh.Location = New System.Drawing.Point(30, 610)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(120, 35)
        Me.btnrefresh.TabIndex = 6
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label15.Location = New System.Drawing.Point(135, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 25)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "0.00"
        '
        'SalesReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpsales)
        Me.Controls.Add(Me.grpfilter)
        Me.Controls.Add(Me.pnlheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SalesReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Reports"
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.grpfilter.ResumeLayout(False)
        Me.grpfilter.PerformLayout()
        Me.grpsales.ResumeLayout(False)
        CType(Me.dgvsales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpfilter As System.Windows.Forms.GroupBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpsales As System.Windows.Forms.GroupBox
    Friend WithEvents dgvsales As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Order_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ammount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paymentmode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cashier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalSales As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblCard As System.Windows.Forms.Label
    Friend WithEvents lblUPI As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTotalOrders As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblMonthlySales As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
