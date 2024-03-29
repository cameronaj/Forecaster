﻿Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports Forecaster


Public Class frmForecaster

    Private isLoaded As Boolean = False
    Private viewNum As Integer = 14
    Private k As Integer = 0
    Private temp As New PictureBox

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub frmForecaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\ForecasterDB.mdb;Persist Security Info=True"
        connString = connString.Replace("\bin", "")
        connString = connString.Replace("\Debug", "")
        temp.Location = New Point(-25, Me.Height - 65)
        Dim str = My.Application.Info.DirectoryPath
        str = str.Replace("\bin", "")
        str = str.Replace("\Debug", "")
        str = str & "\My Project\tmp0.1.jpg"
        temp.Image = Image.FromFile(str)
        temp.Height = 25
        temp.Width = 18
        Controls.Add(temp)
        temp.BringToFront()
        OleDbConnection1.ConnectionString = connString
        chtPredictionChart.Width = Me.Width / (3 / 2)
        dgvSalesData.Left = Me.Width / (3 / 2)
        dgvSalesData.Width = Me.Width / 3
        chtPredictionChart.Height = Me.Height - mnuMainMenu.Height - 25
        dgvSalesData.Height = Me.Height - mnuMainMenu.Height - 40
        dgvSalesData.Top = mnuMainMenu.Height
        chtPredictionChart.Top = mnuMainMenu.Height
        chkExpoSmoothing.Top = mnuMainMenu.Height
        chkMovingWeight.Top = mnuMainMenu.Height
        chkNaive.Top = mnuMainMenu.Height
        chkRecordedSales.Top = mnuMainMenu.Height

        populateDataSet()

        chtPredictionChart.ChartAreas("ChartArea1").AxisX.Interval = 1
        chtPredictionChart.ChartAreas("ChartArea1").AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet
        chtPredictionChart.ChartAreas("ChartArea1").AxisY.Title = "Amount of Sales"
        chtPredictionChart.ChartAreas("ChartArea1").AxisX.Title = "Day of Week"
        loadChart()
        isLoaded = True
    End Sub

    Private Sub AddSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSalesToolStripMenuItem.Click
        tm.Enabled = True
        Dim dataEntryForm = New frmAddSales
        dataEntryForm.Show()
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
                OleDbConnection1.Close()
                If rows > 0 Then
                    MsgBox("Your data has been deleted.")
                    populateDataSet()
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

    Private Sub loadChart()
        Dim count = DataSet11.Sales.Rows.Count
        Dim stopPoint = count - viewNum
        If count > 0 Then
            chtPredictionChart.Series("Niave").Points.Clear()
            chtPredictionChart.Series("ES").Points.Clear()
            chtPredictionChart.Series("MVA").Points.Clear()
            chtPredictionChart.Series("Sales").Points.Clear()
            If viewNum = -1 Or stopPoint < 0 Then
                stopPoint = 0
            End If
            For i As Integer = stopPoint To count - 1
                Dim row = DataSet11.Sales.Rows.Item(i)
                chtPredictionChart.Series("Niave").Points.AddXY(row("sWeek").ToString & row("sDay").ToString, row("Naive").ToString)
                chtPredictionChart.Series("ES").Points.AddXY(row("sWeek").ToString & row("sDay").ToString, row("ExpoSmoothing").ToString)
                chtPredictionChart.Series("MVA").Points.AddXY(row("sWeek").ToString & row("sDay").ToString, row("MovingWeight").ToString)
                chtPredictionChart.Series("Sales").Points.AddXY(row("sWeek").ToString & row("sDay").ToString, row("sAmount").ToString)
            Next
        End If
    End Sub

    Private Sub Last2WeeksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Last2WeeksToolStripMenuItem.Click
        toggleOptionsToFalse()
        Last2WeeksToolStripMenuItem.Checked = True
        viewNum = 14
        loadChart()
    End Sub

    Private Sub Last4WeeksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Last4WeeksToolStripMenuItem.Click
        toggleOptionsToFalse()
        Last4WeeksToolStripMenuItem.Checked = True
        viewNum = 28
        loadChart()
    End Sub

    Private Sub Last8WeeksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Last8WeeksToolStripMenuItem.Click
        toggleOptionsToFalse()
        Last8WeeksToolStripMenuItem.Checked = True
        viewNum = 56
        loadChart()
    End Sub

    Private Sub Last12WeeksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Last12WeeksToolStripMenuItem.Click
        toggleOptionsToFalse()
        Last12WeeksToolStripMenuItem.Checked = True
        viewNum = 84
        loadChart()
    End Sub

    Private Sub ByAllDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByAllDataToolStripMenuItem.Click
        toggleOptionsToFalse()
        ByAllDataToolStripMenuItem.Checked = True
        viewNum = -1
        loadChart()
    End Sub

    Private Sub toggleOptionsToFalse()
        Last2WeeksToolStripMenuItem.Checked = False
        Last4WeeksToolStripMenuItem.Checked = False
        Last8WeeksToolStripMenuItem.Checked = False
        Last12WeeksToolStripMenuItem.Checked = False
        ByAllDataToolStripMenuItem.Checked = False
    End Sub

    Private Sub ForecastAccuracyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForecastAccuracyToolStripMenuItem.Click
        Dim amount, naive, es, mva
        OleDbConnection1.Open()
        OleDbDataAdapter1.SelectCommand.Connection = OleDbConnection1
        OleDbDataAdapter1.SelectCommand.CommandText = "SELECT AVG(sAmount) FROM Sales WHERE sAmount > 0 AND Naive > 0"
        amount = OleDbDataAdapter1.SelectCommand.ExecuteScalar()
        OleDbDataAdapter1.SelectCommand.CommandText = "SELECT AVG(Naive) FROM Sales WHERE Naive > 0 AND sAmount > 0"
        naive = OleDbDataAdapter1.SelectCommand.ExecuteScalar()
        If IsDBNull(naive) Then
            NaiveToolStripMenuItem.Text = "Not Enough Data For Naive"
        Else
            NaiveToolStripMenuItem.Text = "Naive Accuracy: " & 100 - Math.Round(((Math.Abs(naive - amount) / amount) * 100), 2) & "%"
        End If
        OleDbDataAdapter1.SelectCommand.CommandText = "SELECT AVG(sAmount) FROM Sales WHERE sAmount > 0 AND ExpoSmoothing > 0"
        amount = OleDbDataAdapter1.SelectCommand.ExecuteScalar()
        OleDbDataAdapter1.SelectCommand.CommandText = "SELECT AVG(ExpoSmoothing) FROM Sales WHERE ExpoSmoothing > 0 AND sAmount > 0"
        es = OleDbDataAdapter1.SelectCommand.ExecuteScalar()
        If IsDBNull(es) Then
            ExponentialSmoothingToolStripMenuItem.Text = "Not Enough Data For Exponential Smoothing"
        Else
            ExponentialSmoothingToolStripMenuItem.Text = "Exponential Smoothing Accuracy: " & 100 - Math.Round(((Math.Abs(es - amount) / amount) * 100), 2) & "%"
        End If
        OleDbDataAdapter1.SelectCommand.CommandText = "SELECT AVG(sAmount) FROM Sales WHERE sAmount > 0 AND MovingWeight > 0"
        amount = OleDbDataAdapter1.SelectCommand.ExecuteScalar()
        OleDbDataAdapter1.SelectCommand.CommandText = "SELECT AVG(MovingWeight) FROM Sales WHERE MovingWeight > 0 AND sAmount > 0"
        mva = OleDbDataAdapter1.SelectCommand.ExecuteScalar()
        If IsDBNull(mva) Then
            MovingWeighedAverageToolStripMenuItem.Text = "Not Enough Data For Moving Weighted Average"
        Else
            MovingWeighedAverageToolStripMenuItem.Text = "Moving Weighted Average Accuracy: " & 100 - Math.Round(((Math.Abs(mva - amount) / amount) * 100), 2) & "%"
        End If
        OleDbConnection1.Close()
    End Sub

    Public Sub populateDataSet()
        dgvSalesData.DataSource = Nothing
        OleDbConnection1.Open()
        OleDbDataAdapter1.Fill(DataSet11)
        dgvSalesData.DataSource = SalesBindingSource
        dgvSalesData.Refresh()
        OleDbConnection1.Close()
        loadChart()
    End Sub

    Private Sub RefeashDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefeashDataToolStripMenuItem.Click
        populateDataSet()
    End Sub

    Private Sub ImportFromExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportFromExcelToolStripMenuItem.Click
        Using FileDialog As New OpenFileDialog
            FileDialog.Title = "Select your Excel file"
            FileDialog.Filter = "Microsoft Excel|*.xl*|All Files|*.*"
            If FileDialog.ShowDialog() = DialogResult.OK Then
                Using FileProcess As Process = Process.Start(FileDialog.FileName)
                    FileProcess.WaitForExit()
                End Using
            End If
        End Using
    End Sub

    Private Sub tm_Tick(sender As Object, e As EventArgs) Handles tm.Tick
        temp.BringToFront()
        temp.Location = New Point(temp.Location.X + 25, temp.Location.Y)
        If temp.Location.X > Me.Width Then
            tm.Enabled = False
            temp.Location = New Point(-18, temp.Location.Y)
        End If
    End Sub

    Private Sub dgvSalesData_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSalesData.KeyDown
        If e.KeyCode = Keys.Up And (k = 0 Or k = 1) Then
            k = k + 1
        ElseIf e.KeyCode = Keys.Down And (k = 2 Or k = 3) Then
            k = k + 1
        ElseIf e.KeyCode = Keys.Left And (k = 4 Or k = 6) Then
            k = k + 1
        ElseIf e.KeyCode = Keys.Right And (k = 5 Or k = 7) Then
            k = k + 1
        ElseIf e.KeyCode = Keys.A And k = 9 Then
            k = k + 1
        ElseIf e.KeyCode = Keys.B And k = 8 Then
            k = k + 1
        ElseIf e.KeyCode = Keys.Enter And k = 10 Then
            k = 0
            tmK.Enabled = Not tmK.Enabled
        Else
            k = 0
        End If
    End Sub

    Private Sub tmK_Tick(sender As Object, e As EventArgs) Handles tmK.Tick
        dgvSalesData.BackgroundColor = Color.FromArgb((Rnd() * 254) + 1, (Rnd() * 254) + 1, (Rnd() * 254) + 1)
        chtPredictionChart.BackColor = Color.FromArgb((Rnd() * 254) + 1, (Rnd() * 254) + 1, (Rnd() * 254) + 1)
    End Sub
End Class
