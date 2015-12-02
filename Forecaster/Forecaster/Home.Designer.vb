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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.DataOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSavedDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSavedDataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSavedDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New Forecaster.DataSet1()
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
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataOptionsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(862, 28)
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
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
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
        Me.WeekToolStripMenuItem.Size = New System.Drawing.Size(127, 26)
        Me.WeekToolStripMenuItem.Text = "Week"
        '
        'MonthToolStripMenuItem
        '
        Me.MonthToolStripMenuItem.Name = "MonthToolStripMenuItem"
        Me.MonthToolStripMenuItem.Size = New System.Drawing.Size(127, 26)
        Me.MonthToolStripMenuItem.Text = "Month"
        '
        'YearToolStripMenuItem
        '
        Me.YearToolStripMenuItem.Name = "YearToolStripMenuItem"
        Me.YearToolStripMenuItem.Size = New System.Drawing.Size(127, 26)
        Me.YearToolStripMenuItem.Text = "Year"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ID, sYear, sWeek, sDay, sAmount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     Sales"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ForecasterDB.mdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `Sales` (`sYear`, `sWeek`, `sDay`, `sAmount`) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("sYear", System.Data.OleDb.OleDbType.[Integer], 0, "sYear"), New System.Data.OleDb.OleDbParameter("sWeek", System.Data.OleDb.OleDbType.[Integer], 0, "sWeek"), New System.Data.OleDb.OleDbParameter("sDay", System.Data.OleDb.OleDbType.VarWChar, 0, "sDay"), New System.Data.OleDb.OleDbParameter("sAmount", System.Data.OleDb.OleDbType.Currency, 0, "sAmount")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("sYear", System.Data.OleDb.OleDbType.[Integer], 0, "sYear"), New System.Data.OleDb.OleDbParameter("sWeek", System.Data.OleDb.OleDbType.[Integer], 0, "sWeek"), New System.Data.OleDb.OleDbParameter("sDay", System.Data.OleDb.OleDbType.VarWChar, 0, "sDay"), New System.Data.OleDb.OleDbParameter("sAmount", System.Data.OleDb.OleDbType.Currency, 0, "sAmount"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sDay", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sDay", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sAmount", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sAmount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sDay", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sDay", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sAmount", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sAmount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Sales", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("sYear", "sYear"), New System.Data.Common.DataColumnMapping("sWeek", "sWeek"), New System.Data.Common.DataColumnMapping("sDay", "sDay"), New System.Data.Common.DataColumnMapping("sAmount", "sAmount")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'chtPredictionChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtPredictionChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtPredictionChart.Legends.Add(Legend1)
        Me.chtPredictionChart.Location = New System.Drawing.Point(12, 31)
        Me.chtPredictionChart.Name = "chtPredictionChart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Sales"
        Me.chtPredictionChart.Series.Add(Series1)
        Me.chtPredictionChart.Size = New System.Drawing.Size(601, 336)
        Me.chtPredictionChart.TabIndex = 1
        Me.chtPredictionChart.Text = "Prediction Chart"
        '
        'dgvSalesData
        '
        Me.dgvSalesData.AutoGenerateColumns = False
        Me.dgvSalesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.SYearDataGridViewTextBoxColumn, Me.SWeekDataGridViewTextBoxColumn, Me.SDayDataGridViewTextBoxColumn, Me.SAmountDataGridViewTextBoxColumn})
        Me.dgvSalesData.DataSource = Me.SalesBindingSource
        Me.dgvSalesData.Location = New System.Drawing.Point(12, 373)
        Me.dgvSalesData.Name = "dgvSalesData"
        Me.dgvSalesData.RowTemplate.Height = 24
        Me.dgvSalesData.Size = New System.Drawing.Size(838, 194)
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
        'frmForecaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 593)
        Me.Controls.Add(Me.dgvSalesData)
        Me.Controls.Add(Me.chtPredictionChart)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Name = "frmForecaster"
        Me.Text = "Forecaster"
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
    Friend WithEvents EditSavedDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeekToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditSavedDataToolStripMenuItem1 As ToolStripMenuItem
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
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents SYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SWeekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
