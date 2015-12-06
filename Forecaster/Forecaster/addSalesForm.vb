Public Class frmAddSales

    Private Sub frmAddSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mskDate.Text = Date.Now.Month.ToString.PadLeft(2, "0") & Date.Now.Day.ToString.PadLeft(2, "0") & Date.Now.Year

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim test As Integer = 0
        Dim saledate As Date = mskDate.Text
        Dim saleyear As Integer = saledate.Year
        Dim week_of_year As Double = Math.Ceiling(Convert.ToDouble(saledate.DayOfYear) / 7)
        Dim saleday As String = saledate.DayOfWeek.ToString.Substring(0, 1)
        If saledate.DayOfWeek.ToString.Equals("Sunday") Then
            saleday = "U"
        End If
        If saledate.DayOfWeek.ToString.Equals("Thursday") Then
            saleday = "R"
        End If
        Dim amount As Integer = CInt(txtAmount.Text)

        Try
            OleDbConnection1.Open()

            Dim exists As Integer = 0
            OleDbDataAdapter1.SelectCommand.Connection = OleDbConnection1
            OleDbDataAdapter1.SelectCommand.CommandText = "SELECT ID FROM Sales WHERE sYear = " & saleyear & " And sWeek = " & week_of_year & " And sDay = '" & saleday & "'"
            exists = OleDbDataAdapter1.SelectCommand.ExecuteNonQuery()
            If exists > 0 Then
                OleDbDataAdapter1.UpdateCommand.Connection = OleDbConnection1
                OleDbDataAdapter1.UpdateCommand.CommandText = "UPDATE Sales SET sAmount = " & amount & " WHERE sYear = " & saleyear & " AND sWeek = " & week_of_year & " AND sDay = '" & saleday & "'"
                test = OleDbDataAdapter1.UpdateCommand.ExecuteNonQuery()
            Else
                OleDbDataAdapter1.InsertCommand.Connection = OleDbConnection1
                OleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO Sales (sYear, sWeek, sDay, sAmount) VALUES (" & saleyear & ", " & week_of_year & ", '" & saleday & "', " & amount & ")"
                test = OleDbDataAdapter1.InsertCommand.ExecuteNonQuery()
            End If
            OleDbConnection1.Close()
        Catch ex As Exception
            MessageBox.Show("error has occured; " & ex.Message)
        End Try
        If test > 0 Then
            MessageBox.Show("Your change was saved.")
        Else
            MessageBox.Show("Your changes were not saved. (an error has occured)")
        End If

    End Sub


End Class