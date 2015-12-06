Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmForecaster

    Private isLoaded As Boolean = False

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub frmForecaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class
