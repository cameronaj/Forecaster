<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForecaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.DataOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSavedDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSavedDataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSavedDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chtForecast = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.mnuMainMenu.SuspendLayout()
        CType(Me.chtForecast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataOptionsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(500, 28)
        Me.mnuMainMenu.TabIndex = 0
        Me.mnuMainMenu.Text = "MainMenu"
        '
        'DataOptionsToolStripMenuItem
        '
        Me.DataOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditSavedDataToolStripMenuItem, Me.EditSavedDataToolStripMenuItem1, Me.ClearSavedDataToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.DataOptionsToolStripMenuItem.Name = "DataOptionsToolStripMenuItem"
        Me.DataOptionsToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.DataOptionsToolStripMenuItem.Text = "Options"
        '
        'EditSavedDataToolStripMenuItem
        '
        Me.EditSavedDataToolStripMenuItem.Name = "EditSavedDataToolStripMenuItem"
        Me.EditSavedDataToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.EditSavedDataToolStripMenuItem.Text = "Add Data"
        '
        'EditSavedDataToolStripMenuItem1
        '
        Me.EditSavedDataToolStripMenuItem1.Name = "EditSavedDataToolStripMenuItem1"
        Me.EditSavedDataToolStripMenuItem1.Size = New System.Drawing.Size(198, 26)
        Me.EditSavedDataToolStripMenuItem1.Text = "Edit Saved Data"
        '
        'ClearSavedDataToolStripMenuItem
        '
        Me.ClearSavedDataToolStripMenuItem.Name = "ClearSavedDataToolStripMenuItem"
        Me.ClearSavedDataToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.ClearSavedDataToolStripMenuItem.Text = "Clear Saved Data"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WeekToolStripMenuItem, Me.MonthToolStripMenuItem, Me.YearToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'WeekToolStripMenuItem
        '
        Me.WeekToolStripMenuItem.Name = "WeekToolStripMenuItem"
        Me.WeekToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.WeekToolStripMenuItem.Text = "Week"
        '
        'MonthToolStripMenuItem
        '
        Me.MonthToolStripMenuItem.Name = "MonthToolStripMenuItem"
        Me.MonthToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.MonthToolStripMenuItem.Text = "Month"
        '
        'YearToolStripMenuItem
        '
        Me.YearToolStripMenuItem.Name = "YearToolStripMenuItem"
        Me.YearToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.YearToolStripMenuItem.Text = "Year"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'chtForecast
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtForecast.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtForecast.Legends.Add(Legend1)
        Me.chtForecast.Location = New System.Drawing.Point(24, 43)
        Me.chtForecast.Name = "chtForecast"
        Me.chtForecast.Size = New System.Drawing.Size(432, 312)
        Me.chtForecast.TabIndex = 1
        Me.chtForecast.Text = "Chart1"
        Title1.Name = "chtTitle"
        Title1.Text = "Week Forecast"
        Me.chtForecast.Titles.Add(Title1)
        '
        'frmForecaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 379)
        Me.Controls.Add(Me.chtForecast)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Name = "frmForecaster"
        Me.Text = "Forecaster"
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        CType(Me.chtForecast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMainMenu As MenuStrip
    Friend WithEvents DataOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditSavedDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeekToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditSavedDataToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearSavedDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chtForecast As DataVisualization.Charting.Chart
End Class
