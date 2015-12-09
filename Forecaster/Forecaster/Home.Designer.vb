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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.DataOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSavedDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Last2WeeksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Last4WeeksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Last8WeeksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Last12WeeksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByAllDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForecastAccuracyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NaiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExponentialSmoothingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovingWeighedAverageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefeashDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ImportFromExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuMainMenu.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.mnuMainMenu.Size = New System.Drawing.Size(1310, 28)
        Me.mnuMainMenu.TabIndex = 0
        Me.mnuMainMenu.Text = "MainMenu"
        '
        'DataOptionsToolStripMenuItem
        '
        Me.DataOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearSavedDataToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.DataOptionsToolStripMenuItem.Name = "DataOptionsToolStripMenuItem"
        Me.DataOptionsToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.DataOptionsToolStripMenuItem.Text = "Options"
        '
        'ClearSavedDataToolStripMenuItem
        '
        Me.ClearSavedDataToolStripMenuItem.Name = "ClearSavedDataToolStripMenuItem"
        Me.ClearSavedDataToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.ClearSavedDataToolStripMenuItem.Text = "Clear Saved Data"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ViewByToolStripMenuItem
        '
        Me.ViewByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Last2WeeksToolStripMenuItem, Me.Last4WeeksToolStripMenuItem, Me.Last8WeeksToolStripMenuItem, Me.Last12WeeksToolStripMenuItem, Me.ByAllDataToolStripMenuItem})
        Me.ViewByToolStripMenuItem.Name = "ViewByToolStripMenuItem"
        Me.ViewByToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewByToolStripMenuItem.Text = "View"
        '
        'Last2WeeksToolStripMenuItem
        '
        Me.Last2WeeksToolStripMenuItem.Checked = True
        Me.Last2WeeksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Last2WeeksToolStripMenuItem.Name = "Last2WeeksToolStripMenuItem"
        Me.Last2WeeksToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.Last2WeeksToolStripMenuItem.Text = "Last 2 Weeks"
        '
        'Last4WeeksToolStripMenuItem
        '
        Me.Last4WeeksToolStripMenuItem.Name = "Last4WeeksToolStripMenuItem"
        Me.Last4WeeksToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.Last4WeeksToolStripMenuItem.Text = "Last 4 Weeks"
        '
        'Last8WeeksToolStripMenuItem
        '
        Me.Last8WeeksToolStripMenuItem.Name = "Last8WeeksToolStripMenuItem"
        Me.Last8WeeksToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.Last8WeeksToolStripMenuItem.Text = "Last 8 Weeks"
        '
        'Last12WeeksToolStripMenuItem
        '
        Me.Last12WeeksToolStripMenuItem.Name = "Last12WeeksToolStripMenuItem"
        Me.Last12WeeksToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.Last12WeeksToolStripMenuItem.Text = "Last 12 Weeks"
        '
        'ByAllDataToolStripMenuItem
        '
        Me.ByAllDataToolStripMenuItem.Name = "ByAllDataToolStripMenuItem"
        Me.ByAllDataToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.ByAllDataToolStripMenuItem.Text = "All Data"
        '
        'AddSalesToolStripMenuItem
        '
        Me.AddSalesToolStripMenuItem.Name = "AddSalesToolStripMenuItem"
        Me.AddSalesToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.AddSalesToolStripMenuItem.Text = "Add Sales"
        '
        'ForecastAccuracyToolStripMenuItem
        '
        Me.ForecastAccuracyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NaiveToolStripMenuItem, Me.ExponentialSmoothingToolStripMenuItem, Me.MovingWeighedAverageToolStripMenuItem})
        Me.ForecastAccuracyToolStripMenuItem.Name = "ForecastAccuracyToolStripMenuItem"
        Me.ForecastAccuracyToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.ForecastAccuracyToolStripMenuItem.Text = "Forecast Accuracy"
        '
        'NaiveToolStripMenuItem
        '
        Me.NaiveToolStripMenuItem.Enabled = False
        Me.NaiveToolStripMenuItem.Name = "NaiveToolStripMenuItem"
        Me.NaiveToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.NaiveToolStripMenuItem.Text = "Naive"
        '
        'ExponentialSmoothingToolStripMenuItem
        '
        Me.ExponentialSmoothingToolStripMenuItem.Enabled = False
        Me.ExponentialSmoothingToolStripMenuItem.Name = "ExponentialSmoothingToolStripMenuItem"
        Me.ExponentialSmoothingToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.ExponentialSmoothingToolStripMenuItem.Text = "Exponential Smoothing"
        '
        'MovingWeighedAverageToolStripMenuItem
        '
        Me.MovingWeighedAverageToolStripMenuItem.Enabled = False
        Me.MovingWeighedAverageToolStripMenuItem.Name = "MovingWeighedAverageToolStripMenuItem"
        Me.MovingWeighedAverageToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.MovingWeighedAverageToolStripMenuItem.Text = "Moving Weighed Average"
        '
        'RefeashDataToolStripMenuItem
        '
        Me.RefeashDataToolStripMenuItem.Name = "RefeashDataToolStripMenuItem"
        Me.RefeashDataToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.RefeashDataToolStripMenuItem.Text = "Refresh Data"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ID, sYear, sWeek, sDay, sAmount, Naive, MovingWeight, ExpoSmoothing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM " &
    "    Sales"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Andrew\Documents\GitHub\For" &
    "ecaster\Forecaster\Forecaster\ForecasterDB.mdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `Sales` (`sYear`, `sWeek`, `sDay`, `sAmount`, `Naive`, `MovingWeight`" &
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
        ChartArea3.Name = "ChartArea1"
        Me.chtPredictionChart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chtPredictionChart.Legends.Add(Legend3)
        Me.chtPredictionChart.Location = New System.Drawing.Point(0, 42)
        Me.chtPredictionChart.Margin = New System.Windows.Forms.Padding(0)
        Me.chtPredictionChart.Name = "chtPredictionChart"
        Me.chtPredictionChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series9.BorderWidth = 5
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series9.Color = System.Drawing.Color.Purple
        Series9.Legend = "Legend1"
        Series9.MarkerColor = System.Drawing.Color.White
        Series9.MarkerSize = 1
        Series9.Name = "Niave"
        Series9.SmartLabelStyle.MaxMovingDistance = 75.0R
        Series10.BorderWidth = 4
        Series10.ChartArea = "ChartArea1"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series10.Color = System.Drawing.Color.Crimson
        Series10.Legend = "Legend1"
        Series10.MarkerBorderWidth = 4
        Series10.MarkerColor = System.Drawing.Color.Gold
        Series10.MarkerSize = 10
        Series10.MarkerStep = 2
        Series10.Name = "ES"
        Series11.BorderWidth = 3
        Series11.ChartArea = "ChartArea1"
        Series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series11.Color = System.Drawing.Color.RoyalBlue
        Series11.Legend = "Legend1"
        Series11.MarkerBorderWidth = 4
        Series11.MarkerColor = System.Drawing.Color.Gold
        Series11.MarkerSize = 10
        Series11.MarkerStep = 2
        Series11.Name = "MVA"
        Series12.BorderWidth = 2
        Series12.ChartArea = "ChartArea1"
        Series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series12.Color = System.Drawing.Color.Lime
        Series12.Legend = "Legend1"
        Series12.MarkerBorderWidth = 4
        Series12.MarkerColor = System.Drawing.Color.Gold
        Series12.MarkerSize = 10
        Series12.MarkerStep = 2
        Series12.Name = "Sales"
        Series12.YValuesPerPoint = 4
        Me.chtPredictionChart.Series.Add(Series9)
        Me.chtPredictionChart.Series.Add(Series10)
        Me.chtPredictionChart.Series.Add(Series11)
        Me.chtPredictionChart.Series.Add(Series12)
        Me.chtPredictionChart.Size = New System.Drawing.Size(719, 725)
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
        Me.dgvSalesData.Location = New System.Drawing.Point(722, 40)
        Me.dgvSalesData.Margin = New System.Windows.Forms.Padding(3, 12, 3, 2)
        Me.dgvSalesData.Name = "dgvSalesData"
        Me.dgvSalesData.ReadOnly = True
        Me.dgvSalesData.RowTemplate.Height = 24
        Me.dgvSalesData.Size = New System.Drawing.Size(588, 765)
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
        Me.chkRecordedSales.Location = New System.Drawing.Point(39, 42)
        Me.chkRecordedSales.Name = "chkRecordedSales"
        Me.chkRecordedSales.Size = New System.Drawing.Size(131, 21)
        Me.chkRecordedSales.TabIndex = 3
        Me.chkRecordedSales.Text = "Recorded Sales"
        Me.chkRecordedSales.UseVisualStyleBackColor = True
        '
        'chkNaive
        '
        Me.chkNaive.AutoSize = True
        Me.chkNaive.Checked = True
        Me.chkNaive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNaive.Location = New System.Drawing.Point(176, 42)
        Me.chkNaive.Name = "chkNaive"
        Me.chkNaive.Size = New System.Drawing.Size(66, 21)
        Me.chkNaive.TabIndex = 4
        Me.chkNaive.Text = "Niave"
        Me.chkNaive.UseVisualStyleBackColor = True
        '
        'chkMovingWeight
        '
        Me.chkMovingWeight.AutoSize = True
        Me.chkMovingWeight.Checked = True
        Me.chkMovingWeight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMovingWeight.Location = New System.Drawing.Point(428, 42)
        Me.chkMovingWeight.Name = "chkMovingWeight"
        Me.chkMovingWeight.Size = New System.Drawing.Size(196, 21)
        Me.chkMovingWeight.TabIndex = 5
        Me.chkMovingWeight.Text = "Moving Weighted Average"
        Me.chkMovingWeight.UseVisualStyleBackColor = True
        '
        'chkExpoSmoothing
        '
        Me.chkExpoSmoothing.AutoSize = True
        Me.chkExpoSmoothing.Checked = True
        Me.chkExpoSmoothing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExpoSmoothing.Location = New System.Drawing.Point(248, 42)
        Me.chkExpoSmoothing.Name = "chkExpoSmoothing"
        Me.chkExpoSmoothing.Size = New System.Drawing.Size(174, 21)
        Me.chkExpoSmoothing.TabIndex = 6
        Me.chkExpoSmoothing.Text = "Exponential Smoothing"
        Me.chkExpoSmoothing.UseVisualStyleBackColor = True
        '
        'ImportFromExcelToolStripMenuItem
        '
        Me.ImportFromExcelToolStripMenuItem.Name = "ImportFromExcelToolStripMenuItem"
        Me.ImportFromExcelToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.ImportFromExcelToolStripMenuItem.Text = "Import from Excel"
        '
        'frmForecaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 803)
        Me.Controls.Add(Me.chkExpoSmoothing)
        Me.Controls.Add(Me.chkMovingWeight)
        Me.Controls.Add(Me.chkNaive)
        Me.Controls.Add(Me.chkRecordedSales)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.Controls.Add(Me.chtPredictionChart)
        Me.Controls.Add(Me.dgvSalesData)
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
