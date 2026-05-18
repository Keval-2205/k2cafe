Imports System.Data.SqlClient

Public Class OrderForm

    ' ---------------- FORM LOAD ----------------
    Private Sub OrderForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadMenuItems()
        ClearOrder()

        ' Ensure DataGridView has correct columns
        dgvOrder.Columns.Clear()
        dgvOrder.Columns.Add("colItem", "Item")
        dgvOrder.Columns.Add("colQty", "Qty")
        dgvOrder.Columns.Add("colPrice", "Price")
        dgvOrder.Columns.Add("colTotal", "Total")
    End Sub
    Private Sub LoadCategories()
        cmbCategory.Items.Clear()
        Try
            Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
                Dim cmd As New SqlCommand("SELECT DISTINCT Category FROM Menu WHERE Status = 1", con)
                con.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbCategory.Items.Add(reader("Category").ToString())
                End While
            End Using

            If cmbCategory.Items.Count > 0 Then
                cmbCategory.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' ---------------- LOAD MENU ITEMS INTO COMBOBOX ----------------
    Private Sub LoadMenuItems()
        cmbSelectItem.Items.Clear()
        Try
            Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
                Dim cmd As New SqlCommand("SELECT Product_Name FROM Menu WHERE Status = 1", con)
                con.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbSelectItem.Items.Add(reader("Product_Name").ToString())
                End While
            End Using

            If cmbSelectItem.Items.Count > 0 Then
                cmbSelectItem.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading menu items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------------- ADD ITEM TO ORDER GRID ----------------
    Private Sub btnAddItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnadditem.Click
        If cmbSelectItem.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim qty As Integer = Convert.ToInt32(numQuantity.Value)
        If qty <= 0 Then
            MessageBox.Show("Quantity must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim productName As String = cmbSelectItem.SelectedItem.ToString()
            Dim price As Decimal

            ' Get price from Menu table
            Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
                Dim cmd As New SqlCommand("SELECT Price FROM Menu WHERE Product_Name=@ProductName", con)
                cmd.Parameters.AddWithValue("@ProductName", productName)
                con.Open()
                price = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using

            Dim total As Decimal = qty * price

            ' ✅ Add row to DataGridView
            dgvOrder.Rows.Add(productName, qty, price, total)

            CalculateTotals()

        Catch ex As Exception
            MessageBox.Show("Error adding item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------------- REMOVE ITEM ----------------
    Private Sub btnRemoveItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveItem.Click
        If dgvOrder.SelectedCells.Count > 0 Then
            Dim rowIndex As Integer = dgvOrder.SelectedCells(0).RowIndex
            If rowIndex >= 0 AndAlso rowIndex < dgvOrder.Rows.Count Then
                dgvOrder.Rows.RemoveAt(rowIndex)
                CalculateTotals()
            End If
        Else
            MessageBox.Show("Please select an item to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    ' ---------------- CLEAR ORDER ----------------
    Private Sub btnClearOrder_Click(ByVal sender As Object, ByVal e As EventArgs)
        ClearOrder()
    End Sub

    Private Sub ClearOrder()
        dgvOrder.Rows.Clear()
        txtDiscount.Text = "0"
        txtGST.Text = "0"
        lblTotalAmount.Text = "Total Amount: 0.00"
    End Sub

    ' ---------------- CALCULATE TOTALS ----------------
    Private Sub CalculateTotals()
        Dim subtotal As Decimal = 0
        For Each row As DataGridViewRow In dgvOrder.Rows
            subtotal += Convert.ToDecimal(row.Cells("colTotal").Value)
        Next

        Dim discountPercent As Decimal = 0
        Decimal.TryParse(txtDiscount.Text, discountPercent)

        Dim gstPercent As Decimal = 0
        Decimal.TryParse(txtGST.Text, gstPercent)

        Dim discountAmount As Decimal = (subtotal * discountPercent) / 100
        Dim gstAmount As Decimal = ((subtotal - discountAmount) * gstPercent) / 100

        Dim finalTotal As Decimal = subtotal - discountAmount + gstAmount

        lblTotalAmount.Text = "Total Amount: " & finalTotal.ToString("0.00")
    End Sub

    Private Sub btnPlaceOrder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPlaceOrder.Click
        If dgvOrder.Rows.Count = 0 Then
            MessageBox.Show("No items in the order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim paymentMethod As String = ""
        If rbCash.Checked Then paymentMethod = "Cash"
        If rbCard.Checked Then paymentMethod = "Card"
        If rbUPI.Checked Then paymentMethod = "UPI"

        If paymentMethod = "" Then
            MessageBox.Show("Please select a payment method.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim orderID As Integer
            Dim discountPercent As Decimal = Convert.ToDecimal(txtDiscount.Text)
            Dim gstPercent As Decimal = Convert.ToDecimal(txtGST.Text)
            Dim totalAmount As Decimal = Decimal.Parse(lblTotalAmount.Text.Replace("Total Amount: ", ""))

            Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
                con.Open()

                ' Insert into Orders table
                Dim cmdOrder As New SqlCommand("INSERT INTO Orders (OrderDate, TotalAmount, Discount, GST, PaymentMethod) " &
                                               "OUTPUT INSERTED.OrderID " &
                                               "VALUES (@OrderDate, @TotalAmount, @Discount, @GST, @PaymentMethod)", con)

                cmdOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now)
                cmdOrder.Parameters.AddWithValue("@TotalAmount", totalAmount)
                cmdOrder.Parameters.AddWithValue("@Discount", discountPercent)
                cmdOrder.Parameters.AddWithValue("@GST", gstPercent)
                cmdOrder.Parameters.AddWithValue("@PaymentMethod", paymentMethod)

                orderID = Convert.ToInt32(cmdOrder.ExecuteScalar())

                ' Insert into OrderDetails table
                For Each row As DataGridViewRow In dgvOrder.Rows
                    If row.IsNewRow Then Continue For ' Skip blank row

                    ' Null checks for each cell
                    If row.Cells("colItem").Value Is Nothing OrElse
                       row.Cells("colQty").Value Is Nothing OrElse
                       row.Cells("colPrice").Value Is Nothing OrElse
                       row.Cells("colTotal").Value Is Nothing Then
                        Continue For
                    End If

                    Dim cmdDetail As New SqlCommand("INSERT INTO OrderDetails (OrderID, ProductName, Quantity, Price, Total) " &
                                                    "VALUES (@OrderID, @ProductName, @Quantity, @Price, @Total)", con)

                    cmdDetail.Parameters.AddWithValue("@OrderID", orderID)
                    cmdDetail.Parameters.AddWithValue("@ProductName", row.Cells("colItem").Value.ToString())
                    cmdDetail.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells("colQty").Value))
                    cmdDetail.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells("colPrice").Value))
                    cmdDetail.Parameters.AddWithValue("@Total", Convert.ToDecimal(row.Cells("colTotal").Value))

                    cmdDetail.ExecuteNonQuery()
                Next
            End Using

            MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearOrder()

            Dim billingForm As New BillingForm(orderID, discountPercent, gstPercent)
            billingForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error placing order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' ---------------- CANCEL ORDER ----------------
    Private Sub btnCancelOrder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelOrder.Click
        ClearOrder()
    End Sub
    Private Sub txtDiscount_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDiscount.TextChanged
        CalculateTotals()
    End Sub

    Private Sub txtGST_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtGST.TextChanged
        CalculateTotals()
    End Sub

End Class

