Imports System.Data.SqlClient

Public Class SalesReports

    ' ---------------- FORM LOAD ----------------
    Private Sub SalesReport_Load(ByVal sender As Object, ByVal e As EventArgs)
        dtfrom.Value = Date.Today
        dtto.Value = Date.Today
        LoadSalesSummary()
    End Sub

    ' ---------------- SEARCH BUTTON ----------------
    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        LoadSalesSummary()
    End Sub

    ' ---------------- REFRESH BUTTON ----------------
    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        dtFrom.Value = Date.Today
        dtTo.Value = Date.Today
        LoadSalesSummary()
    End Sub

    ' ---------------- LOAD SALES SUMMARY ----------------
    Private Sub LoadSalesSummary()
        dgvSales.Rows.Clear()

        Dim totalSales As Decimal = 0
        Dim totalOrders As Integer = 0
        Dim cashCount As Integer = 0
        Dim upiCount As Integer = 0
        Dim cardCount As Integer = 0

        Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
            con.Open()

            Dim cmd As New SqlCommand("SELECT OrderID, OrderDate, TotalAmount, PaymentMethod, Cashier FROM Orders WHERE OrderDate BETWEEN @From AND @To ORDER BY OrderDate DESC", con)
            cmd.Parameters.AddWithValue("@From", dtFrom.Value.Date)
            cmd.Parameters.AddWithValue("@To", dtTo.Value.Date.AddDays(1).AddSeconds(-1))

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim rowIndex As Integer = 1
            While reader.Read()
                Dim orderID As Integer = Convert.ToInt32(reader("OrderID"))
                Dim orderDate As DateTime = Convert.ToDateTime(reader("OrderDate"))
                Dim amount As Decimal = Convert.ToDecimal(reader("TotalAmount"))
                Dim method As String = reader("PaymentMethod").ToString()
                Dim cashier As String = reader("Cashier").ToString()

                dgvSales.Rows.Add(rowIndex, orderID, orderDate.ToString("dd-MM-yyyy hh:mm tt"), amount.ToString("0.00"), method, cashier)

                totalSales += amount
                totalOrders += 1

                Select Case method
                    Case "Cash"
                        cashCount += 1
                    Case "UPI"
                        upiCount += 1
                    Case "Credit Card"
                        cardCount += 1
                End Select

                rowIndex += 1
            End While
            reader.Close()
        End Using

        ' Update summary labels
        lblTotalSales.Text = "₹" & totalSales.ToString("0.00")
        lblTotalOrders.Text = totalOrders.ToString()
        lblCash.Text = cashCount.ToString()
        lblUPI.Text = upiCount.ToString()
        lblCard.Text = cardCount.ToString()
        lblMonthlySales.Text = "₹" & GetMonthlySales().ToString("0.00")
    End Sub

    ' ---------------- GET MONTHLY SALES ----------------
    Private Function GetMonthlySales() As Decimal
        Dim monthlyTotal As Decimal = 0
        Using con As New SqlConnection(My.Settings.cafeDBConnectionString)
            con.Open()

            Dim firstDay As Date = New Date(Date.Today.Year, Date.Today.Month, 1)
            Dim lastDay As Date = firstDay.AddMonths(1).AddDays(-1)

            Dim cmd As New SqlCommand("SELECT SUM(TotalAmount) FROM Orders WHERE OrderDate BETWEEN @Start AND @End", con)
            cmd.Parameters.AddWithValue("@Start", firstDay)
            cmd.Parameters.AddWithValue("@End", lastDay.AddDays(1).AddSeconds(-1))

            Dim result = cmd.ExecuteScalar()
            If Not IsDBNull(result) Then
                monthlyTotal = Convert.ToDecimal(result)
            End If
        End Using
        Return monthlyTotal
    End Function

End Class
