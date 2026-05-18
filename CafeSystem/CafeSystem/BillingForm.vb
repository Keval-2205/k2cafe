Imports System.Data.SqlClient

Public Class BillingForm
    Private orderID As Integer
    Private discountPercent As Decimal
    Private gstPercent As Decimal
    Public totalAmount As Decimal

    ' Constructor to receive OrderID
    Public Sub New(ByVal orderID As Integer, ByVal discountPercent As Decimal, ByVal gstPercent As Decimal)
        InitializeComponent()
        Me.orderID = orderID
        Me.discountPercent = discountPercent
        Me.gstPercent = gstPercent
    End Sub


    ' ---------------- FORM LOAD ----------------
    Private Sub Billing_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadOrderDetails()

        lblDiscount.Text = "Discount: " & discountPercent & "%"
        lblGST.Text = "GST: " & gstPercent & "%"
        CalculateTotals()
    End Sub

    ' ---------------- LOAD ORDER DETAILS ----------------
    Private Sub LoadOrderDetails()
        dgvOrderSummary.Rows.Clear()

        ' Ensure columns exist before adding rows
        If dgvOrderSummary.Columns.Count = 0 Then
            dgvOrderSummary.Columns.Add("colID", "ID")
            dgvOrderSummary.Columns.Add("colItem", "Item")
            dgvOrderSummary.Columns.Add("colQty", "Qty")
            dgvOrderSummary.Columns.Add("colPrice", "Price")
            dgvOrderSummary.Columns.Add("colTotal", "Total")
        End If

        dgvOrderSummary.AutoGenerateColumns = False

        Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
            con.Open()

            ' Load order header
            Dim cmdOrder As New SqlCommand("SELECT OrderDate, TotalAmount, Discount, GST, PaymentMethod FROM Orders WHERE OrderID=@OrderID", con)
            cmdOrder.Parameters.AddWithValue("@OrderID", orderID)
            Dim reader As SqlDataReader = cmdOrder.ExecuteReader()
            If reader.Read() Then
                txtOrderID.Text = orderID.ToString()
                txtDate.Text = Convert.ToDateTime(reader("OrderDate")).ToString("dd-MM-yyyy hh:mm tt")
                txtCashier.Text = "Admin" ' Or use logged-in user
                totalAmount = Convert.ToDecimal(reader("TotalAmount"))

                ' Optional: display discount and GST if labels exist
                If lblDiscount IsNot Nothing Then
                    lblDiscount.Text = "Discount: %" & Convert.ToDecimal(reader("Discount")).ToString("0.00")
                End If
                If lblGST IsNot Nothing Then
                    lblGST.Text = "GST: %" & Convert.ToDecimal(reader("GST")).ToString("0.00")
                End If
                Dim method As String = reader("PaymentMethod").ToString()
                If method = "Cash" Then
                    rdoCash.Checked = True
                ElseIf method = "Credit Card" Then
                    rdoCard.Checked = True
                ElseIf method = "UPI" Then
                    rdoUPI.Checked = True
                End If
                rdoCash.Enabled = False
                rdoCard.Enabled = False
                rdoUPI.Enabled = False


            End If
            reader.Close()

            ' Load order items
            Dim cmdItems As New SqlCommand("SELECT ProductName, Quantity, Price, Total FROM OrderDetails WHERE OrderID=@OrderID", con)
            cmdItems.Parameters.AddWithValue("@OrderID", orderID)
            Dim itemReader As SqlDataReader = cmdItems.ExecuteReader()
            Dim rowIndex As Integer = 1
            While itemReader.Read()
                dgvOrderSummary.Rows.Add(rowIndex,
                                 itemReader("ProductName").ToString(),
                                 Convert.ToInt32(itemReader("Quantity")),
                                 Convert.ToDecimal(itemReader("Price")),
                                 Convert.ToDecimal(itemReader("Total")))
                rowIndex += 1
            End While
            itemReader.Close()
        End Using
    End Sub


    ' ---------------- CALCULATE TOTALS ----------------
    Private Sub CalculateTotals()
        Dim subtotal As Decimal = 0

        For Each row As DataGridViewRow In dgvOrderSummary.Rows
            If row.IsNewRow Then Continue For
            subtotal += Convert.ToDecimal(row.Cells("colTotal").Value)
        Next

        Dim discountAmount As Decimal = (subtotal * discountPercent) / 100
        Dim gstAmount As Decimal = ((subtotal - discountAmount) * gstPercent) / 100

        Dim finalTotal As Decimal = subtotal - discountAmount + gstAmount

        lblSubtotal.Text = "Subtotal: ₹" & subtotal.ToString("0.00")
        lblFinalTotal.Text = "Total: ₹" & finalTotal.ToString("0.00")

        totalAmount = finalTotal
    End Sub




    ' ---------------- HANDLE AMOUNT PAID ----------------
    Private Sub txtAmountPaid_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtAmountPaid.TextChanged
        Dim paid As Decimal = 0
        Decimal.TryParse(txtAmountPaid.Text, paid)
        Dim balance As Decimal = paid - totalAmount
        txtBalanceDue.Text = "Balance Due ₹: " & balance.ToString("0.00")
    End Sub

    ' ---------------- PRINT BILL ----------------
    Private Sub btnPrintBill_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintBill.Click
        MessageBox.Show("Bill printed successfully!", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        DashboardForm.Show() ' Or return to dashboard
    End Sub

    ' ---------------- CANCEL BILLING ----------------
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Cancel billing and return to dashboard?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            DashboardForm.Show()
        End If
    End Sub
End Class
