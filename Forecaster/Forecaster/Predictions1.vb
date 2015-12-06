
Class Predictions
    Shared Sub ExponentialSmoothingPrediction()

    End Sub
    Shared Sub WeightedMovingPrediction(Date)
        Dim F As Integer = 0
        Dim N As Integer = 10 'Number of Weeks
        Dim D As Integer = 0
        Do
            D = !!!!!Day!!!!! * N
            F = F + D
            N = N - 1
        Loop Until N > 1
        F = F / (10 * 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1)
    End Sub
End Class
