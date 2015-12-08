Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports Forecaster


Public Class frmForecaster

    Private isLoaded As Boolean = False

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub frmForecaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OleDbDataAdapter1.Fill(DataSet11)
        chtPredictionChart.ChartAreas("ChartArea1").AxisX.Interval = 1
        chtPredictionChart.ChartAreas("ChartArea1").AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet
        chtPredictionChart.ChartAreas("ChartArea1").AxisY.Title = "Amount of Sales"
        chtPredictionChart.ChartAreas("ChartArea1").AxisX.Title = "Day of Week"
        loadChart(100)
        isLoaded = True
    End Sub

    Private Sub AddSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSalesToolStripMenuItem.Click
        Dim mySecondForm As Form
        mySecondForm = New frmAddSales
        mySecondForm.Show()

    End Sub

    Private Sub ClearSavedDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSavedDataToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to clear your sales data?", "WARNING!", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim confirm As Integer = MessageBox.Show("Your data will be gone forever, are you absolutely sure?", "FINAL WARNING!", MessageBoxButtons.YesNo)
            If confirm = DialogResult.Yes Then
                OleDbConnection1.Open()
                OleDbDataAdapter1.DeleteCommand.Connection = OleDbConnection1
                OleDbDataAdapter1.DeleteCommand.CommandText = "DELETE FROM Sales"
                Dim rows = OleDbDataAdapter1.DeleteCommand.ExecuteNonQuery()
                If rows > 0 Then
                    MsgBox("Your data has been deleted.")
                End If
            End If
        End If
    End Sub

    Private Sub chkChartDisplay_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecordedSales.CheckedChanged, chkNaive.CheckedChanged, chkMovingWeight.CheckedChanged, chkExpoSmoothing.CheckedChanged
        If isLoaded Then
            chtPredictionChart.Series("Sales").Enabled = chkRecordedSales.Checked
            chtPredictionChart.Series("ES").Enabled = chkExpoSmoothing.Checked
            chtPredictionChart.Series("MVA").Enabled = chkMovingWeight.Checked
            chtPredictionChart.Series("Niave").Enabled = chkNaive.Checked
        End If
    End Sub

    Private Sub loadChart(limit As Integer)

        Dim count = DataSet11.Sales.Rows.Count
        Dim stopPoint = count - limit
        If count > 0 Then
            chtPredictionChart.Series("Niave").Points.Clear()
            chtPredictionChart.Series("ES").Points.Clear()
            chtPredictionChart.Series("MVA").Points.Clear()
            chtPredictionChart.Series("Sales").Points.Clear()
            If limit = -1 Or stopPoint < 0 Then
                stopPoint = 0
            End If
            For i As Integer = stopPoint To count - 1
                chtPredictionChart.Series("Niave").Points.AddXY(DataSet11.Sales.Rows.Item(i)("sDay").ToString, DataSet11.Sales.Rows.Item(i)("Naive").ToString)
                chtPredictionChart.Series("ES").Points.AddXY(DataSet11.Sales.Rows.Item(i)("sDay").ToString, DataSet11.Sales.Rows.Item(i)("ExpoSmoothing").ToString)
                chtPredictionChart.Series("MVA").Points.AddXY(DataSet11.Sales.Rows.Item(i)("sDay").ToString, DataSet11.Sales.Rows.Item(i)("MovingWeight").ToString)
                chtPredictionChart.Series("Sales").Points.AddXY(DataSet11.Sales.Rows.Item(i)("sDay").ToString, DataSet11.Sales.Rows.Item(i)("sAmount").ToString)
            Next
        End If
    End Sub

    Private Sub Last2WeeksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Last2WeeksToolStripMenuItem.Click
        toggleOptionsToFalse()
        Last2WeeksToolStripMenuItem.Checked = True
        loadChart(14)
    End Sub

    Private Sub Last4WeeksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Last4WeeksToolStripMenuItem.Click
        toggleOptionsToFalse()
        Last4WeeksToolStripMenuItem.Checked = True
        loadChart(28)
    End Sub

    Private Sub Last8WeeksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Last8WeeksToolStripMenuItem.Click
        toggleOptionsToFalse()
        Last8WeeksToolStripMenuItem.Checked = True
        loadChart(56)
    End Sub

    Private Sub Last12WeeksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Last12WeeksToolStripMenuItem.Click
        toggleOptionsToFalse()
        Last12WeeksToolStripMenuItem.Checked = True
        loadChart(84)
    End Sub

    Private Sub ByAllDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByAllDataToolStripMenuItem.Click
        toggleOptionsToFalse()
        ByAllDataToolStripMenuItem.Checked = True
        loadChart(-1)
    End Sub

    Private Sub toggleOptionsToFalse()
        Last2WeeksToolStripMenuItem.Checked = False
        Last4WeeksToolStripMenuItem.Checked = False
        Last8WeeksToolStripMenuItem.Checked = False
        Last12WeeksToolStripMenuItem.Checked = False
        ByAllDataToolStripMenuItem.Checked = False
    End Sub
End Class
