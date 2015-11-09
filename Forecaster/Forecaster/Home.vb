Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmForecaster
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub frmForecaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim accessdb As String = My.Application.Info.DirectoryPath & "\ForecastDB.accdb"
        'Dim s As New Series
        'Dim str As String
        'Dim command As OleDbCommand
        'Dim Conn As OleDbConnection = New OleDbConnection
        'Conn.ConnectionString = "Data Source =" & accessdb & ";"
        'Conn.Open()
        'Str = "SELECT * FROM Sales"
        'Command = New OleDbCommand(Str, Conn)
        'Dim rows = command.ExecuteReader
        'MsgBox(rows)
        's.ChartType = SeriesChartType.Line

        'Dim temp As New OleDbDataAdapter
        'temp.SelectCommand = command

    End Sub
End Class
