
Class Predictions
    Shared Sub ExponentialSmoothingPrediction()

    End Sub
    Shared Sub WeightedMovingPrediction()
        Dim F As Integer = 0 'Forecast.
        Dim D As Integer = 0 'Placeholder variable for current the day's sales.
        Dim N As Integer = 10 'Number of weeks to be used in the moving prediction method.
        Dim wmDay As String = "" 'Day of the week being used.
        Dim wmWeek As Integer = ""
        Dim wmYear As Integer = ""

        OleDbConnection1.Open()
        OleDbDataAdapter1.SelectCommand.Connection = OleDbConnection1

        Do
            OleDbDataAdapter1.SelectCommand.CommandText = "SELECT sAmount WHERE sYear = " & wmYear & " sWeek = " & wmWeek & " AND sDay = " & wmDay
            D = OleDbDataAdapter1.SelectCommand.ExecuteScalar() * N
            F = F + D
            wmWeek = wmWeek - 1
            If wmWeek < 0 Then
                wmWeek = 53
                wmYear = wmYear - 1
            End If
            N = N - 1
        Loop Until N < 1

        F = F / (10 * 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1)

        OleDbConnection1.Close()

        Return F

    End Sub
End Class
