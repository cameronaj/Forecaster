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
        End If
        isLoaded = True
    End Sub

    Private Sub dgvSalesData_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesData.CellValueChanged
        If isLoaded Then
            Dim test
            Try
                Dim value As Integer = CInt(dgvSalesData.CurrentCell.FormattedValue.ToString)
                DataSet11.Tables(0).Rows(e.RowIndex).Item(e.ColumnIndex) = value
                test = OleDbDataAdapter1.Update(DataSet11)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MessageBox.Show("Number of rows updated = " & test)
        End If
    End Sub
End Class
