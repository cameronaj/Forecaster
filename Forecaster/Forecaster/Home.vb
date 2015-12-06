Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports Forecaster


Public Class frmForecaster

    Private isLoaded As Boolean = False

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub frmForecaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Adjusts sizes of objects upon load to fit the screen accordingly.
        chtPredictionChart.Width = Me.Width - 20
        chtPredictionChart.Height = Me.Height / 2
        dgvSalesData.Height = Me.Height - mnuMainMenu.Height - chtPredictionChart.Height - 20 'Sets the height 10px below the chart.
        dgvSalesData.Width = Me.Width
        'End of adjustments made to objects.

        OleDbDataAdapter1.Fill(DataSet11)
        If DataSet11.Sales.Rows.Count > 0 Then
            For i As Integer = 0 To DataSet11.Sales.Rows.Count - 1
                chtPredictionChart.Series("Sales").Points.AddXY(DataSet11.Sales.Rows.Item(i)("sDay").ToString, DataSet11.Sales.Rows.Item(i)("sAmount").ToString)
            Next
            chtPredictionChart.ChartAreas("ChartArea1").AxisY.Title = "Amount of Sales"
            chtPredictionChart.ChartAreas("ChartArea1").AxisX.Title = "Day of Week"
        End If
        isLoaded = True
    End Sub

    Private Sub dgvSalesData_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesData.CellValueChanged
        If isLoaded Then
            Dim test As Integer = 0
            Try
                Dim value As Integer = CInt(dgvSalesData.CurrentCell.FormattedValue.ToString)
                Dim id As Integer = CInt(dgvSalesData.CurrentRow.Cells.Item(0).FormattedValue.ToString)
                OleDbDataAdapter1.UpdateCommand.CommandText = "UPDATE Sales SET sAmount = " & value & " WHERE ID = " & id
                OleDbConnection1.Open()
                OleDbDataAdapter1.UpdateCommand.Connection = OleDbConnection1
                test = OleDbDataAdapter1.UpdateCommand.ExecuteNonQuery()
                OleDbConnection1.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            If test > 0 Then
                MessageBox.Show("Your change was saved.")
            Else
                MessageBox.Show("Your changes were not saved. (an error has occured)")
            End If
        End If
    End Sub

    Private Sub Test(sender As Object, e As EventArgs)
        Predictions.NaivePrediction()
    End Sub

    Private Sub AddSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSalesToolStripMenuItem.Click
        Dim mySecondForm As Form
        mySecondForm = New frmAddSales
        mySecondForm.Show()

    End Sub

    Private Sub ExponentialSmoothing()
        Dim Test As Integer


        For i As Integer = 0 To DataSet11.Sales.Rows.Count - 1
            If DataSet11.Sales.Rows.Item(i)("sWeek") < 2 Then
                DataSet11.Sales.Rows.Item(i)("ExpoSmoothing") = DataSet11.Sales.Rows.Item(i)("sAmount")
            Else
                DataSet11.Sales.Rows.Item(i)("ExpoSmoothing") = DataSet11.Sales.Rows.Item(i - 7)("ExpoSmoothing") + 0.01 * (DataSet11.Sales.Rows.Item(i - 7)("sAmount") - DataSet11.Sales.Rows.Item(i - 7)("ExpoSmoothing"))
            End If
        Next
        OleDbConnection1.Open()
          OleDbDataAdapter1.UpdateCommand.Connection = OleDbConnection1
        Test = OleDbDataAdapter1.Update(DataSet11)
        OleDbConnection1.Close()


    End Sub

End Class
