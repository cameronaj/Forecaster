<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmForecaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForecaster))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.ViewByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Last2WeeksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Last4WeeksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Last8WeeksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Last12WeeksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByAllDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForecastAccuracyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NaiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExponentialSmoothingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovingWeighedAverageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefeashDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSavedDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.chtPredictionChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvSalesData = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SWeekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Naive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpoSmoothing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovingWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New Forecaster.DataSet1()
        Me.chkRecordedSales = New System.Windows.Forms.CheckBox()
        Me.chkNaive = New System.Windows.Forms.CheckBox()
        Me.chkMovingWeight = New System.Windows.Forms.CheckBox()
        Me.chkExpoSmoothing = New System.Windows.Forms.CheckBox()
        Me.mnuMainMenu.SuspendLayout()
        CType(Me.chtPredictionChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSalesData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewByToolStripMenuItem, Me.ForecastAccuracyToolStripMenuItem, Me.AddSalesToolStripMenuItem, Me.ImportFromExcelToolStripMenuItem, Me.RefeashDataToolStripMenuItem, Me.DataOptionsToolStripMenuItem})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuMainMenu.Size = New System.Drawing.Size(982, 24)
        Me.mnuMainMenu.TabIndex = 0
        Me.mnuMainMenu.Text = "MainMenu"
        '
        'ViewByToolStripMenuItem
        '
        Me.ViewByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Last2WeeksToolStripMenuItem, Me.Last4WeeksToolStripMenuItem, Me.Last8WeeksToolStripMenuItem, Me.Last12WeeksToolStripMenuItem, Me.ByAllDataToolStripMenuItem})
        Me.ViewByToolStripMenuItem.Name = "ViewByToolStripMenuItem"
        Me.ViewByToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewByToolStripMenuItem.Text = "View"
        '
        'Last2WeeksToolStripMenuItem
        '
        Me.Last2WeeksToolStripMenuItem.Checked = True
        Me.Last2WeeksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Last2WeeksToolStripMenuItem.Name = "Last2WeeksToolStripMenuItem"
        Me.Last2WeeksToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.Last2WeeksToolStripMenuItem.Text = "Last 2 Weeks"
        '
        'Last4WeeksToolStripMenuItem
        '
        Me.Last4WeeksToolStripMenuItem.Name = "Last4WeeksToolStripMenuItem"
        Me.Last4WeeksToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.Last4WeeksToolStripMenuItem.Text = "Last 4 Weeks"
        '
        'Last8WeeksToolStripMenuItem
        '
        Me.Last8WeeksToolStripMenuItem.Name = "Last8WeeksToolStripMenuItem"
        Me.Last8WeeksToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.Last8WeeksToolStripMenuItem.Text = "Last 8 Weeks"
        '
        'Last12WeeksToolStripMenuItem
        '
        Me.Last12WeeksToolStripMenuItem.Name = "Last12WeeksToolStripMenuItem"
        Me.Last12WeeksToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.Last12WeeksToolStripMenuItem.Text = "Last 12 Weeks"
        '
        'ByAllDataToolStripMenuItem
        '
        Me.ByAllDataToolStripMenuItem.Name = "ByAllDataToolStripMenuItem"
        Me.ByAllDataToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ByAllDataToolStripMenuItem.Text = "All Data"
        '
        'ForecastAccuracyToolStripMenuItem
        '
        Me.ForecastAccuracyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NaiveToolStripMenuItem, Me.ExponentialSmoothingToolStripMenuItem, Me.MovingWeighedAverageToolStripMenuItem})
        Me.ForecastAccuracyToolStripMenuItem.Name = "ForecastAccuracyToolStripMenuItem"
        Me.ForecastAccuracyToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.ForecastAccuracyToolStripMenuItem.Text = "Forecast Accuracy"
        '
        'NaiveToolStripMenuItem
        '
        Me.NaiveToolStripMenuItem.Enabled = False
        Me.NaiveToolStripMenuItem.Name = "NaiveToolStripMenuItem"
        Me.NaiveToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.NaiveToolStripMenuItem.Text = "Naive"
        '
        'ExponentialSmoothingToolStripMenuItem
        '
        Me.ExponentialSmoothingToolStripMenuItem.Enabled = False
        Me.ExponentialSmoothingToolStripMenuItem.Name = "ExponentialSmoothingToolStripMenuItem"
        Me.ExponentialSmoothingToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ExponentialSmoothingToolStripMenuItem.Text = "Exponential Smoothing"
        '
        'MovingWeighedAverageToolStripMenuItem
        '
        Me.MovingWeighedAverageToolStripMenuItem.Enabled = False
        Me.MovingWeighedAverageToolStripMenuItem.Name = "MovingWeighedAverageToolStripMenuItem"
        Me.MovingWeighedAverageToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MovingWeighedAverageToolStripMenuItem.Text = "Moving Weighed Average"
        '
        'AddSalesToolStripMenuItem
        '
        Me.AddSalesToolStripMenuItem.Name = "AddSalesToolStripMenuItem"
        Me.AddSalesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.AddSalesToolStripMenuItem.Text = "Add Sales"
        '
        'ImportFromExcelToolStripMenuItem
        '
        Me.ImportFromExcelToolStripMenuItem.Name = "ImportFromExcelToolStripMenuItem"
        Me.ImportFromExcelToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.ImportFromExcelToolStripMenuItem.Text = "Import from Excel"
        '
        'RefeashDataToolStripMenuItem
        '
        Me.RefeashDataToolStripMenuItem.Name = "RefeashDataToolStripMenuItem"
        Me.RefeashDataToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.RefeashDataToolStripMenuItem.Text = "Refresh Data"
        '
        'DataOptionsToolStripMenuItem
        '
        Me.DataOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearSavedDataToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.DataOptionsToolStripMenuItem.Name = "DataOptionsToolStripMenuItem"
        Me.DataOptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.DataOptionsToolStripMenuItem.Text = "Options"
        '
        'ClearSavedDataToolStripMenuItem
        '
        Me.ClearSavedDataToolStripMenuItem.Name = "ClearSavedDataToolStripMenuItem"
        Me.ClearSavedDataToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ClearSavedDataToolStripMenuItem.Text = "Clear Saved Data"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ID, sYear, sWeek, sDay, sAmount, Naive, MovingWeight, ExpoSmoothing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM " & _
    "    Sales"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Andrew\Documents\GitHub\For" & _
    "ecaster\Forecaster\Forecaster\ForecasterDB.mdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `Sales` (`sYear`, `sWeek`, `sDay`, `sAmount`, `Naive`, `MovingWeight`" & _
    ", `ExpoSmoothing`) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("sYear", System.Data.OleDb.OleDbType.[Integer], 0, "sYear"), New System.Data.OleDb.OleDbParameter("sWeek", System.Data.OleDb.OleDbType.[Integer], 0, "sWeek"), New System.Data.OleDb.OleDbParameter("sDay", System.Data.OleDb.OleDbType.VarWChar, 0, "sDay"), New System.Data.OleDb.OleDbParameter("sAmount", System.Data.OleDb.OleDbType.Currency, 0, "sAmount"), New System.Data.OleDb.OleDbParameter("Naive", System.Data.OleDb.OleDbType.Currency, 0, "Naive"), New System.Data.OleDb.OleDbParameter("MovingWeight", System.Data.OleDb.OleDbType.Currency, 0, "MovingWeight"), New System.Data.OleDb.OleDbParameter("ExpoSmoothing", System.Data.OleDb.OleDbType.Currency, 0, "ExpoSmoothing")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("sYear", System.Data.OleDb.OleDbType.[Integer], 0, "sYear"), New System.Data.OleDb.OleDbParameter("sWeek", System.Data.OleDb.OleDbType.[Integer], 0, "sWeek"), New System.Data.OleDb.OleDbParameter("sDay", System.Data.OleDb.OleDbType.VarWChar, 0, "sDay"), New System.Data.OleDb.OleDbParameter("sAmount", System.Data.OleDb.OleDbType.Currency, 0, "sAmount"), New System.Data.OleDb.OleDbParameter("Naive", System.Data.OleDb.OleDbType.Currency, 0, "Naive"), New System.Data.OleDb.OleDbParameter("MovingWeight", System.Data.OleDb.OleDbType.Currency, 0, "MovingWeight"), New System.Data.OleDb.OleDbParameter("ExpoSmoothing", System.Data.OleDb.OleDbType.Currency, 0, "ExpoSmoothing"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sDay", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sDay", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sAmount", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sAmount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Naive", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Naive", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Naive", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Naive", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MovingWeight", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MovingWeight", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MovingWeight", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MovingWeight", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ExpoSmoothing", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ExpoSmoothing", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ExpoSmoothing", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExpoSmoothing", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sDay", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sDay", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sAmount", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sAmount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Naive", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Naive", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Naive", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Naive", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MovingWeight", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MovingWeight", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MovingWeight", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MovingWeight", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ExpoSmoothing", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ExpoSmoothing", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ExpoSmoothing", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExpoSmoothing", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Sales", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("sYear", "sYear"), New System.Data.Common.DataColumnMapping("sWeek", "sWeek"), New System.Data.Common.DataColumnMapping("sDay", "sDay"), New System.Data.Common.DataColumnMapping("sAmount", "sAmount"), New System.Data.Common.DataColumnMapping("Naive", "Naive"), New System.Data.Common.DataColumnMapping("MovingWeight", "MovingWeight"), New System.Data.Common.DataColumnMapping("ExpoSmoothing", "ExpoSmoothing")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'chtPredictionChart
        '
        Me.chtPredictionChart.Anchor = System.Windows.Forms.AnchorStyles.Left
        ChartArea2.Name = "ChartArea1"
        Me.chtPredictionChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chtPredictionChart.Legends.Add(Legend2)
        Me.chtPredictionChart.Location = New System.Drawing.Point(0, 34)
        Me.chtPredictionChart.Margin = New System.Windows.Forms.Padding(0)
        Me.chtPredictionChart.Name = "chtPredictionChart"
        Me.chtPredictionChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series5.BorderWidth = 5
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Color = System.Drawing.Color.Purple
        Series5.Legend = "Legend1"
        Series5.MarkerColor = System.Drawing.Color.White
        Series5.MarkerSize = 1
        Series5.Name = "Niave"
        Series5.SmartLabelStyle.MaxMovingDistance = 75.0R
        Series6.BorderWidth = 4
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Color = System.Drawing.Color.Crimson
        Series6.Legend = "Legend1"
        Series6.MarkerBorderWidth = 4
        Series6.MarkerColor = System.Drawing.Color.Gold
        Series6.MarkerSize = 10
        Series6.MarkerStep = 2
        Series6.Name = "ES"
        Series7.BorderWidth = 3
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series7.Color = System.Drawing.Color.RoyalBlue
        Series7.Legend = "Legend1"
        Series7.MarkerBorderWidth = 4
        Series7.MarkerColor = System.Drawing.Color.Gold
        Series7.MarkerSize = 10
        Series7.MarkerStep = 2
        Series7.Name = "MVA"
        Series8.BorderWidth = 2
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Color = System.Drawing.Color.Lime
        Series8.Legend = "Legend1"
        Series8.MarkerBorderWidth = 4
        Series8.MarkerColor = System.Drawing.Color.Gold
        Series8.MarkerSize = 10
        Series8.MarkerStep = 2
        Series8.Name = "Sales"
        Series8.YValuesPerPoint = 4
        Me.chtPredictionChart.Series.Add(Series5)
        Me.chtPredictionChart.Series.Add(Series6)
        Me.chtPredictionChart.Series.Add(Series7)
        Me.chtPredictionChart.Series.Add(Series8)
        Me.chtPredictionChart.Size = New System.Drawing.Size(539, 589)
        Me.chtPredictionChart.TabIndex = 1
        Me.chtPredictionChart.Text = " "
        '
        'dgvSalesData
        '
        Me.dgvSalesData.AllowUserToAddRows = False
        Me.dgvSalesData.AllowUserToDeleteRows = False
        Me.dgvSalesData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvSalesData.AutoGenerateColumns = False
        Me.dgvSalesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.SYearDataGridViewTextBoxColumn, Me.SWeekDataGridViewTextBoxColumn, Me.SDayDataGridViewTextBoxColumn, Me.SAmountDataGridViewTextBoxColumn, Me.Naive, Me.ExpoSmoothing, Me.MovingWeight})
        Me.dgvSalesData.DataSource = Me.SalesBindingSource
        Me.dgvSalesData.Location = New System.Drawing.Point(542, 32)
        Me.dgvSalesData.Margin = New System.Windows.Forms.Padding(2, 10, 2, 2)
        Me.dgvSalesData.Name = "dgvSalesData"
        Me.dgvSalesData.ReadOnly = True
        Me.dgvSalesData.RowTemplate.Height = 24
        Me.dgvSalesData.Size = New System.Drawing.Size(441, 622)
        Me.dgvSalesData.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'SYearDataGridViewTextBoxColumn
        '
        Me.SYearDataGridViewTextBoxColumn.DataPropertyName = "sYear"
        Me.SYearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.SYearDataGridViewTextBoxColumn.Name = "SYearDataGridViewTextBoxColumn"
        Me.SYearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SWeekDataGridViewTextBoxColumn
        '
        Me.SWeekDataGridViewTextBoxColumn.DataPropertyName = "sWeek"
        Me.SWeekDataGridViewTextBoxColumn.HeaderText = "Week"
        Me.SWeekDataGridViewTextBoxColumn.Name = "SWeekDataGridViewTextBoxColumn"
        Me.SWeekDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SDayDataGridViewTextBoxColumn
        '
        Me.SDayDataGridViewTextBoxColumn.DataPropertyName = "sDay"
        Me.SDayDataGridViewTextBoxColumn.HeaderText = "Day"
        Me.SDayDataGridViewTextBoxColumn.Name = "SDayDataGridViewTextBoxColumn"
        Me.SDayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SAmountDataGridViewTextBoxColumn
        '
        Me.SAmountDataGridViewTextBoxColumn.DataPropertyName = "sAmount"
        Me.SAmountDataGridViewTextBoxColumn.HeaderText = "Amount in Sales"
        Me.SAmountDataGridViewTextBoxColumn.Name = "SAmountDataGridViewTextBoxColumn"
        Me.SAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Naive
        '
        Me.Naive.DataPropertyName = "Naive"
        Me.Naive.HeaderText = "Naive"
        Me.Naive.Name = "Naive"
        Me.Naive.ReadOnly = True
        '
        'ExpoSmoothing
        '
        Me.ExpoSmoothing.DataPropertyName = "ExpoSmoothing"
        Me.ExpoSmoothing.HeaderText = "ExpoSmoothing"
        Me.ExpoSmoothing.Name = "ExpoSmoothing"
        Me.ExpoSmoothing.ReadOnly = True
        '
        'MovingWeight
        '
        Me.MovingWeight.DataPropertyName = "MovingWeight"
        Me.MovingWeight.HeaderText = "MovingWeight"
        Me.MovingWeight.Name = "MovingWeight"
        Me.MovingWeight.ReadOnly = True
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkRecordedSales
        '
        Me.chkRecordedSales.AutoSize = True
        Me.chkRecordedSales.Checked = True
        Me.chkRecordedSales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecordedSales.Location = New System.Drawing.Point(29, 34)
        Me.chkRecordedSales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkRecordedSales.Name = "chkRecordedSales"
        Me.chkRecordedSales.Size = New System.Drawing.Size(102, 17)
        Me.chkRecordedSales.TabIndex = 3
        Me.chkRecordedSales.Text = "Recorded Sales"
        Me.chkRecordedSales.UseVisualStyleBackColor = True
        '
        'chkNaive
        '
        Me.chkNaive.AutoSize = True
        Me.chkNaive.Checked = True
        Me.chkNaive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNaive.Location = New System.Drawing.Point(132, 34)
        Me.chkNaive.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkNaive.Name = "chkNaive"
        Me.chkNaive.Size = New System.Drawing.Size(54, 17)
        Me.chkNaive.TabIndex = 4
        Me.chkNaive.Text = "Niave"
        Me.chkNaive.UseVisualStyleBackColor = True
        '
        'chkMovingWeight
        '
        Me.chkMovingWeight.AutoSize = True
        Me.chkMovingWeight.Checked = True
        Me.chkMovingWeight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMovingWeight.Location = New System.Drawing.Point(321, 34)
        Me.chkMovingWeight.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkMovingWeight.Name = "chkMovingWeight"
        Me.chkMovingWeight.Size = New System.Drawing.Size(153, 17)
        Me.chkMovingWeight.TabIndex = 5
        Me.chkMovingWeight.Text = "Moving Weighted Average"
        Me.chkMovingWeight.UseVisualStyleBackColor = True
        '
        'chkExpoSmoothing
        '
        Me.chkExpoSmoothing.AutoSize = True
        Me.chkExpoSmoothing.Checked = True
        Me.chkExpoSmoothing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExpoSmoothing.Location = New System.Drawing.Point(186, 34)
        Me.chkExpoSmoothing.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkExpoSmoothing.Name = "chkExpoSmoothing"
        Me.chkExpoSmoothing.Size = New System.Drawing.Size(134, 17)
        Me.chkExpoSmoothing.TabIndex = 6
        Me.chkExpoSmoothing.Text = "Exponential Smoothing"
        Me.chkExpoSmoothing.UseVisualStyleBackColor = True
        '
        'frmForecaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 652)
        Me.Controls.Add(Me.chkExpoSmoothing)
        Me.Controls.Add(Me.chkMovingWeight)
        Me.Controls.Add(Me.chkNaive)
        Me.Controls.Add(Me.chkRecordedSales)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.Controls.Add(Me.chtPredictionChart)
        Me.Controls.Add(Me.dgvSalesData)
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmForecaster"
        Me.Text = "Forecaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        CType(Me.chtPredictionChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSalesData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMainMenu As MenuStrip
    Friend WithEvents DataOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearSavedDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents chtPredictionChart As DataVisualization.Charting.Chart
    Friend WithEvents dgvSalesData As DataGridView
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents AddSalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents SYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SWeekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Naive As DataGridViewTextBoxColumn
    Friend WithEvents ExpoSmoothing As DataGridViewTextBoxColumn
    Friend WithEvents MovingWeight As DataGridViewTextBoxColumn
    Friend WithEvents chkRecordedSales As CheckBox
    Friend WithEvents chkNaive As CheckBox
    Friend WithEvents chkMovingWeight As CheckBox
    Friend WithEvents chkExpoSmoothing As CheckBox
    Friend WithEvents ViewByToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByAllDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Last4WeeksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Last8WeeksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Last12WeeksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Last2WeeksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForecastAccuracyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NaiveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExponentialSmoothingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovingWeighedAverageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefeashDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportFromExcelToolStripMenuItem As ToolStripMenuItem
End Class
