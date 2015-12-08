Public Class frmAddSales

    Private isEmptyDB As Boolean = False
    Private year As Integer
    Private week As Integer

    Private Sub frmAddSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OleDbConnection1.Open()
        OleDbDataAdapter1.SelectCommand.Connection = OleDbConnection1
        OleDbDataAdapter1.SelectCommand.CommandText = "SELECT LAST(sYear) FROM Sales"
        Dim latestyear = OleDbDataAdapter1.SelectCommand.ExecuteScalar()
        OleDbDataAdapter1.SelectCommand.CommandText = "SELECT LAST(sWeek) FROM Sales"
        Dim latestweek = OleDbDataAdapter1.SelectCommand.ExecuteScalar()
        If IsDBNull(latestyear) Then
            isEmptyDB = True
            lblWeekNum.Text = "Select a starting year!"
            lblStartYear.Visible = True
            lblStartWeek.Visible = True
            txtStartWeek.Visible = True
            txtStartYear.Visible = True
            btnSetStart.Visible = True
            txtAmtM.Enabled = False
            txtAmtT.Enabled = False
            txtAmtW.Enabled = False
            txtAmtR.Enabled = False
            txtAmtF.Enabled = False
            txtAmtS.Enabled = False
            txtAmtU.Enabled = False
            btnAdd.Enabled = False
        Else
            lblWeekNum.Text = "Input for " & latestyear & " Week " & latestweek
            year = latestyear
            week = latestweek
            setDates(latestyear, latestweek)
        End If

        OleDbConnection1.Close()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim weekData(6) As String
        weekData(0) = txtAmtM.Text
        weekData(1) = txtAmtT.Text
        weekData(2) = txtAmtW.Text
        weekData(3) = txtAmtR.Text
        weekData(4) = txtAmtF.Text
        weekData(5) = txtAmtS.Text
        weekData(6) = txtAmtU.Text
        'Check for invalid data
        For i As Integer = 0 To weekData.Length - 1
            If String.IsNullOrEmpty(weekData(i)) Or Not IsNumeric(weekData(i)) Then
                MsgBox("All Amounts must be entered and must be numeric.")
                Exit Sub
            End If
        Next
        Dim test As Integer = 0
        OleDbConnection1.Open()
        OleDbDataAdapter1.InsertCommand.Connection = OleDbConnection1
        OleDbDataAdapter1.UpdateCommand.Connection = OleDbConnection1
        'Add new data to database
        For i As Integer = 0 To weekData.Length - 1
            If isEmptyDB Then
                OleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO Sales (sYear, sWeek, sDay, sAmount, Naive, MovingWeight, ExpoSmoothing) 
                    VALUES (" & year & ", " & week & ", '" & getDayChar(i) & "', " & weekData(i) & ", " & weekData(i) & ", 0, " & weekData(i) & " )"
                test += OleDbDataAdapter1.InsertCommand.ExecuteNonQuery()
            Else
                OleDbDataAdapter1.UpdateCommand.CommandText = "UPDATE Sales SET sAmount = " & weekData(i) & " WHERE sYear = " & year & " AND sWeek = " & week & " AND sDay = '" & getDayChar(i) & "'"
                test += OleDbDataAdapter1.UpdateCommand.ExecuteNonQuery()
            End If
        Next
        For i As Integer = 0 To weekData.Length - 1
            OleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO Sales (sYear, sWeek, sDay, Naive, MovingWeight, ExpoSmoothing) 
                    VALUES (" & year & ", " & week + 1 & ", '" & getDayChar(i) & "', " & weekData(i) & ", " & WeightedMoving(weekData(i), i) & ", " & ExponentialSmoothing(weekData(i), i) & " )"
            test += OleDbDataAdapter1.InsertCommand.ExecuteNonQuery()
        Next
        OleDbConnection1.Close()
        MsgBox(test & " Records were succesfully saved.")

    End Sub

    Private Sub btnSetStart_Click(sender As Object, e As EventArgs) Handles btnSetStart.Click
        If Not String.IsNullOrEmpty(txtStartWeek.Text) And Not String.IsNullOrEmpty(txtStartYear.Text) Then
            If IsNumeric(txtStartWeek.Text) And IsNumeric(txtStartYear.Text) Then
                If CInt(txtStartYear.Text) <= Now().Year And CInt(txtStartWeek.Text) <= Math.Ceiling(Convert.ToDouble(Now().DayOfYear) / 7) Then
                    lblWeekNum.Text = "Input for " & txtStartYear.Text & " Week " & txtStartWeek.Text
                    lblStartYear.Visible = False
                    lblStartWeek.Visible = False
                    txtStartWeek.Visible = False
                    txtStartYear.Visible = False
                    btnSetStart.Visible = False
                    txtAmtM.Enabled = True
                    txtAmtT.Enabled = True
                    txtAmtW.Enabled = True
                    txtAmtR.Enabled = True
                    txtAmtF.Enabled = True
                    txtAmtS.Enabled = True
                    txtAmtU.Enabled = True
                    btnAdd.Enabled = True
                    year = txtStartYear.Text
                    week = txtStartWeek.Text
                    setDates(txtStartYear.Text, txtStartWeek.Text)
                End If
            End If
        End If
    End Sub

    Private Sub setDates(year As Integer, week As Integer)
        Dim dayOfYear As Integer = week * 7
        Dim baseDate As New DateTime(year, 1, 1)
        While baseDate.DayOfWeek.ToString <> "Monday"
            baseDate = baseDate.AddDays(-1)
        End While
        Dim actualDate = baseDate.AddDays(dayOfYear - 1)
        lblDateU.Text = actualDate.ToShortDateString
        actualDate = actualDate.AddDays(-1)
        lblDateS.Text = actualDate.ToShortDateString
        actualDate = actualDate.AddDays(-1)
        lblDateF.Text = actualDate.ToShortDateString
        actualDate = actualDate.AddDays(-1)
        lblDateR.Text = actualDate.ToShortDateString
        actualDate = actualDate.AddDays(-1)
        lblDateW.Text = actualDate.ToShortDateString
        actualDate = actualDate.AddDays(-1)
        lblDateT.Text = actualDate.ToShortDateString
        actualDate = actualDate.AddDays(-1)
        lblDateM.Text = actualDate.ToShortDateString
    End Sub

    Private Function ExponentialSmoothing(amount As Double, i As Integer) As Double
        Dim expoVal As Double, expoCurrent As Double
        OleDbDataAdapter1.SelectCommand.Connection = OleDbConnection1
        OleDbDataAdapter1.SelectCommand.CommandText = "SELECT ExpoSmoothing FROM Sales WHERE sYear = " & year & " AND sWeek = " & week & " AND sDay = '" & getDayChar(i) & "'"
        expoVal = OleDbDataAdapter1.SelectCommand.ExecuteScalar()

        expoCurrent = expoVal + 0.01 * (amount - expoVal)
        Return expoCurrent
    End Function

    Private Function WeightedMoving(amount As Double, i As Integer) As Double
        OleDbDataAdapter1.SelectCommand.Connection = OleDbConnection1
        Dim startDate = getDate(i).AddDays(-70)
        Dim startweek = Math.Ceiling(Convert.ToDouble(startDate.DayOfYear) / 7)
        OleDbDataAdapter1.SelectCommand.CommandText = "SELECT sAmount FROM Sales WHERE sYear = " & startDate.Year & " AND sWeek = " & startweek & " AND sDay = '" & getDayChar(i) & "'"

        Dim val = OleDbDataAdapter1.SelectCommand.ExecuteScalar()
        Dim N = 2
        If IsDBNull(val) Then
            Return 0
        Else
            For x As Integer = -63 To 0 Step 7
                Dim incrementDate = getDate(i).AddDays(x)
                Dim incrementWeek = Math.Ceiling(Convert.ToDouble(incrementDate.DayOfYear) / 7)
                OleDbDataAdapter1.SelectCommand.CommandText = "SELECT sAmount FROM Sales WHERE sYear = " & incrementDate & " AND sWeek = " & incrementWeek & " AND sDay = '" & getDayChar(i) & "'"
                val += OleDbDataAdapter1.SelectCommand.ExecuteScalar() * N
                N += 1
            Next
            Return (val / (10 * 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2))
        End If
    End Function

    Private Function getDayChar(day As Integer) As String
        Dim temp As String = ""
        Select Case (day)
            Case 0 : temp = "M"
            Case 1 : temp = "T"
            Case 2 : temp = "W"
            Case 3 : temp = "R"
            Case 4 : temp = "F"
            Case 5 : temp = "S"
            Case 6 : temp = "U"
        End Select
        Return temp
    End Function

    Private Function getDate(index As Integer) As DateTime
        Select Case (index)
            Case 0 : Return lblDateM.Text
            Case 1 : Return lblDateT.Text
            Case 2 : Return lblDateW.Text
            Case 3 : Return lblDateR.Text
            Case 4 : Return lblDateF.Text
            Case 5 : Return lblDateS.Text
            Case 6 : Return lblDateU.Text
        End Select
        Return lblDateM.Text
    End Function

    Private Sub frmAddSales_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim weekData(6) As String
        weekData(0) = txtAmtM.Text
        weekData(1) = txtAmtT.Text
        weekData(2) = txtAmtW.Text
        weekData(3) = txtAmtR.Text
        weekData(4) = txtAmtF.Text
        weekData(5) = txtAmtS.Text
        weekData(6) = txtAmtU.Text
        'Check for invalid data
        For i As Integer = 0 To weekData.Length - 1
            If Not String.IsNullOrEmpty(weekData(i)) And IsNumeric(weekData(i)) Then
                Dim result = MessageBox.Show("You have unsaved data that will be lost if you close now.", "Unsaved Changes", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    Exit For
                ElseIf result = DialogResult.Cancel Then
                    e.Cancel = True
                    Exit Sub
                End If
            End If
        Next
    End Sub
End Class