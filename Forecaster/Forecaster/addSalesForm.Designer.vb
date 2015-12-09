<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSales))
        Me.lblWeekNum = New System.Windows.Forms.Label()
        Me.lblAmountMonday = New System.Windows.Forms.Label()
        Me.txtAmtM = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.lblTitleMonday = New System.Windows.Forms.Label()
        Me.lblTitleTuesday = New System.Windows.Forms.Label()
        Me.txtAmtT = New System.Windows.Forms.TextBox()
        Me.lblAmountTuesday = New System.Windows.Forms.Label()
        Me.lblTitleWednesday = New System.Windows.Forms.Label()
        Me.txtAmtW = New System.Windows.Forms.TextBox()
        Me.lblAmountWednesday = New System.Windows.Forms.Label()
        Me.lblTitleThursday = New System.Windows.Forms.Label()
        Me.txtAmtR = New System.Windows.Forms.TextBox()
        Me.lblAmountThursday = New System.Windows.Forms.Label()
        Me.lblTitleFriday = New System.Windows.Forms.Label()
        Me.txtAmtF = New System.Windows.Forms.TextBox()
        Me.lblAmountFriday = New System.Windows.Forms.Label()
        Me.lblTitleSaturday = New System.Windows.Forms.Label()
        Me.txtAmtS = New System.Windows.Forms.TextBox()
        Me.lblAmountSaturday = New System.Windows.Forms.Label()
        Me.lblTitleSunday = New System.Windows.Forms.Label()
        Me.txtAmtU = New System.Windows.Forms.TextBox()
        Me.lblAmountSunday = New System.Windows.Forms.Label()
        Me.txtStartYear = New System.Windows.Forms.TextBox()
        Me.lblStartYear = New System.Windows.Forms.Label()
        Me.lblStartWeek = New System.Windows.Forms.Label()
        Me.txtStartWeek = New System.Windows.Forms.TextBox()
        Me.btnSetStart = New System.Windows.Forms.Button()
        Me.lblDateM = New System.Windows.Forms.Label()
        Me.lblDateT = New System.Windows.Forms.Label()
        Me.lblDateW = New System.Windows.Forms.Label()
        Me.lblDateR = New System.Windows.Forms.Label()
        Me.lblDateF = New System.Windows.Forms.Label()
        Me.lblDateS = New System.Windows.Forms.Label()
        Me.lblDateU = New System.Windows.Forms.Label()
        Me.DataSet11 = New Forecaster.DataSet1()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWeekNum
        '
        Me.lblWeekNum.AutoSize = True
        Me.lblWeekNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeekNum.Location = New System.Drawing.Point(254, 7)
        Me.lblWeekNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWeekNum.Name = "lblWeekNum"
        Me.lblWeekNum.Size = New System.Drawing.Size(69, 20)
        Me.lblWeekNum.TabIndex = 0
        Me.lblWeekNum.Text = "Week #"
        '
        'lblAmountMonday
        '
        Me.lblAmountMonday.AutoSize = True
        Me.lblAmountMonday.Location = New System.Drawing.Point(18, 111)
        Me.lblAmountMonday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmountMonday.Name = "lblAmountMonday"
        Me.lblAmountMonday.Size = New System.Drawing.Size(43, 13)
        Me.lblAmountMonday.TabIndex = 2
        Me.lblAmountMonday.Text = "Amount"
        '
        'txtAmtM
        '
        Me.txtAmtM.Location = New System.Drawing.Point(20, 127)
        Me.txtAmtM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAmtM.Name = "txtAmtM"
        Me.txtAmtM.Size = New System.Drawing.Size(76, 20)
        Me.txtAmtM.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(309, 176)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 35)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add Records"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Sales", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("sYear", "sYear"), New System.Data.Common.DataColumnMapping("sWeek", "sWeek"), New System.Data.Common.DataColumnMapping("sDay", "sDay"), New System.Data.Common.DataColumnMapping("sAmount", "sAmount")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sDay", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sDay", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sAmount", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sAmount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `Sales` (`sYear`, `sWeek`, `sDay`, `sAmount`) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("sYear", System.Data.OleDb.OleDbType.[Integer], 0, "sYear"), New System.Data.OleDb.OleDbParameter("sWeek", System.Data.OleDb.OleDbType.[Integer], 0, "sWeek"), New System.Data.OleDb.OleDbParameter("sDay", System.Data.OleDb.OleDbType.VarWChar, 0, "sDay"), New System.Data.OleDb.OleDbParameter("sAmount", System.Data.OleDb.OleDbType.Currency, 0, "sAmount")})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ID, sYear, sWeek, sDay, sAmount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     Sales"
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("sYear", System.Data.OleDb.OleDbType.[Integer], 0, "sYear"), New System.Data.OleDb.OleDbParameter("sWeek", System.Data.OleDb.OleDbType.[Integer], 0, "sWeek"), New System.Data.OleDb.OleDbParameter("sDay", System.Data.OleDb.OleDbType.VarWChar, 0, "sDay"), New System.Data.OleDb.OleDbParameter("sAmount", System.Data.OleDb.OleDbType.Currency, 0, "sAmount"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sYear", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYear", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sWeek", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sWeek", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sDay", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sDay", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDay", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_sAmount", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_sAmount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAmount", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Andrew\Documents\GitHub\For" & _
    "ecaster\Forecaster\Forecaster\ForecasterDB.mdb"
        '
        'lblTitleMonday
        '
        Me.lblTitleMonday.AutoSize = True
        Me.lblTitleMonday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleMonday.Location = New System.Drawing.Point(26, 81)
        Me.lblTitleMonday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitleMonday.Name = "lblTitleMonday"
        Me.lblTitleMonday.Size = New System.Drawing.Size(65, 20)
        Me.lblTitleMonday.TabIndex = 7
        Me.lblTitleMonday.Text = "Monday"
        '
        'lblTitleTuesday
        '
        Me.lblTitleTuesday.AutoSize = True
        Me.lblTitleTuesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTuesday.Location = New System.Drawing.Point(128, 81)
        Me.lblTitleTuesday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitleTuesday.Name = "lblTitleTuesday"
        Me.lblTitleTuesday.Size = New System.Drawing.Size(69, 20)
        Me.lblTitleTuesday.TabIndex = 10
        Me.lblTitleTuesday.Text = "Tuesday"
        '
        'txtAmtT
        '
        Me.txtAmtT.Location = New System.Drawing.Point(122, 127)
        Me.txtAmtT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAmtT.Name = "txtAmtT"
        Me.txtAmtT.Size = New System.Drawing.Size(76, 20)
        Me.txtAmtT.TabIndex = 1
        '
        'lblAmountTuesday
        '
        Me.lblAmountTuesday.AutoSize = True
        Me.lblAmountTuesday.Location = New System.Drawing.Point(120, 111)
        Me.lblAmountTuesday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmountTuesday.Name = "lblAmountTuesday"
        Me.lblAmountTuesday.Size = New System.Drawing.Size(43, 13)
        Me.lblAmountTuesday.TabIndex = 8
        Me.lblAmountTuesday.Text = "Amount"
        '
        'lblTitleWednesday
        '
        Me.lblTitleWednesday.AutoSize = True
        Me.lblTitleWednesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleWednesday.Location = New System.Drawing.Point(218, 81)
        Me.lblTitleWednesday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitleWednesday.Name = "lblTitleWednesday"
        Me.lblTitleWednesday.Size = New System.Drawing.Size(93, 20)
        Me.lblTitleWednesday.TabIndex = 13
        Me.lblTitleWednesday.Text = "Wednesday"
        '
        'txtAmtW
        '
        Me.txtAmtW.Location = New System.Drawing.Point(221, 127)
        Me.txtAmtW.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAmtW.Name = "txtAmtW"
        Me.txtAmtW.Size = New System.Drawing.Size(76, 20)
        Me.txtAmtW.TabIndex = 2
        '
        'lblAmountWednesday
        '
        Me.lblAmountWednesday.AutoSize = True
        Me.lblAmountWednesday.Location = New System.Drawing.Point(219, 111)
        Me.lblAmountWednesday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmountWednesday.Name = "lblAmountWednesday"
        Me.lblAmountWednesday.Size = New System.Drawing.Size(43, 13)
        Me.lblAmountWednesday.TabIndex = 11
        Me.lblAmountWednesday.Text = "Amount"
        '
        'lblTitleThursday
        '
        Me.lblTitleThursday.AutoSize = True
        Me.lblTitleThursday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleThursday.Location = New System.Drawing.Point(320, 81)
        Me.lblTitleThursday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitleThursday.Name = "lblTitleThursday"
        Me.lblTitleThursday.Size = New System.Drawing.Size(74, 20)
        Me.lblTitleThursday.TabIndex = 16
        Me.lblTitleThursday.Text = "Thursday"
        '
        'txtAmtR
        '
        Me.txtAmtR.Location = New System.Drawing.Point(320, 127)
        Me.txtAmtR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAmtR.Name = "txtAmtR"
        Me.txtAmtR.Size = New System.Drawing.Size(76, 20)
        Me.txtAmtR.TabIndex = 3
        '
        'lblAmountThursday
        '
        Me.lblAmountThursday.AutoSize = True
        Me.lblAmountThursday.Location = New System.Drawing.Point(318, 111)
        Me.lblAmountThursday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmountThursday.Name = "lblAmountThursday"
        Me.lblAmountThursday.Size = New System.Drawing.Size(43, 13)
        Me.lblAmountThursday.TabIndex = 14
        Me.lblAmountThursday.Text = "Amount"
        '
        'lblTitleFriday
        '
        Me.lblTitleFriday.AutoSize = True
        Me.lblTitleFriday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleFriday.Location = New System.Drawing.Point(430, 81)
        Me.lblTitleFriday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitleFriday.Name = "lblTitleFriday"
        Me.lblTitleFriday.Size = New System.Drawing.Size(52, 20)
        Me.lblTitleFriday.TabIndex = 19
        Me.lblTitleFriday.Text = "Friday"
        '
        'txtAmtF
        '
        Me.txtAmtF.Location = New System.Drawing.Point(418, 127)
        Me.txtAmtF.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAmtF.Name = "txtAmtF"
        Me.txtAmtF.Size = New System.Drawing.Size(76, 20)
        Me.txtAmtF.TabIndex = 4
        '
        'lblAmountFriday
        '
        Me.lblAmountFriday.AutoSize = True
        Me.lblAmountFriday.Location = New System.Drawing.Point(416, 111)
        Me.lblAmountFriday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmountFriday.Name = "lblAmountFriday"
        Me.lblAmountFriday.Size = New System.Drawing.Size(43, 13)
        Me.lblAmountFriday.TabIndex = 17
        Me.lblAmountFriday.Text = "Amount"
        '
        'lblTitleSaturday
        '
        Me.lblTitleSaturday.AutoSize = True
        Me.lblTitleSaturday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleSaturday.Location = New System.Drawing.Point(518, 81)
        Me.lblTitleSaturday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitleSaturday.Name = "lblTitleSaturday"
        Me.lblTitleSaturday.Size = New System.Drawing.Size(73, 20)
        Me.lblTitleSaturday.TabIndex = 22
        Me.lblTitleSaturday.Text = "Saturday"
        '
        'txtAmtS
        '
        Me.txtAmtS.Location = New System.Drawing.Point(517, 127)
        Me.txtAmtS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAmtS.Name = "txtAmtS"
        Me.txtAmtS.Size = New System.Drawing.Size(76, 20)
        Me.txtAmtS.TabIndex = 5
        '
        'lblAmountSaturday
        '
        Me.lblAmountSaturday.AutoSize = True
        Me.lblAmountSaturday.Location = New System.Drawing.Point(514, 111)
        Me.lblAmountSaturday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmountSaturday.Name = "lblAmountSaturday"
        Me.lblAmountSaturday.Size = New System.Drawing.Size(43, 13)
        Me.lblAmountSaturday.TabIndex = 20
        Me.lblAmountSaturday.Text = "Amount"
        '
        'lblTitleSunday
        '
        Me.lblTitleSunday.AutoSize = True
        Me.lblTitleSunday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleSunday.Location = New System.Drawing.Point(616, 81)
        Me.lblTitleSunday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitleSunday.Name = "lblTitleSunday"
        Me.lblTitleSunday.Size = New System.Drawing.Size(63, 20)
        Me.lblTitleSunday.TabIndex = 25
        Me.lblTitleSunday.Text = "Sunday"
        '
        'txtAmtU
        '
        Me.txtAmtU.Location = New System.Drawing.Point(610, 127)
        Me.txtAmtU.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAmtU.Name = "txtAmtU"
        Me.txtAmtU.Size = New System.Drawing.Size(76, 20)
        Me.txtAmtU.TabIndex = 6
        '
        'lblAmountSunday
        '
        Me.lblAmountSunday.AutoSize = True
        Me.lblAmountSunday.Location = New System.Drawing.Point(608, 111)
        Me.lblAmountSunday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmountSunday.Name = "lblAmountSunday"
        Me.lblAmountSunday.Size = New System.Drawing.Size(43, 13)
        Me.lblAmountSunday.TabIndex = 23
        Me.lblAmountSunday.Text = "Amount"
        '
        'txtStartYear
        '
        Me.txtStartYear.Location = New System.Drawing.Point(236, 34)
        Me.txtStartYear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtStartYear.Name = "txtStartYear"
        Me.txtStartYear.Size = New System.Drawing.Size(76, 20)
        Me.txtStartYear.TabIndex = 26
        Me.txtStartYear.Visible = False
        '
        'lblStartYear
        '
        Me.lblStartYear.AutoSize = True
        Me.lblStartYear.Location = New System.Drawing.Point(182, 37)
        Me.lblStartYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStartYear.Name = "lblStartYear"
        Me.lblStartYear.Size = New System.Drawing.Size(54, 13)
        Me.lblStartYear.TabIndex = 27
        Me.lblStartYear.Text = "Start Year"
        Me.lblStartYear.Visible = False
        '
        'lblStartWeek
        '
        Me.lblStartWeek.AutoSize = True
        Me.lblStartWeek.Location = New System.Drawing.Point(321, 37)
        Me.lblStartWeek.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStartWeek.Name = "lblStartWeek"
        Me.lblStartWeek.Size = New System.Drawing.Size(61, 13)
        Me.lblStartWeek.TabIndex = 29
        Me.lblStartWeek.Text = "Start Week"
        Me.lblStartWeek.Visible = False
        '
        'txtStartWeek
        '
        Me.txtStartWeek.Location = New System.Drawing.Point(382, 34)
        Me.txtStartWeek.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtStartWeek.Name = "txtStartWeek"
        Me.txtStartWeek.Size = New System.Drawing.Size(76, 20)
        Me.txtStartWeek.TabIndex = 28
        Me.txtStartWeek.Visible = False
        '
        'btnSetStart
        '
        Me.btnSetStart.Location = New System.Drawing.Point(459, 29)
        Me.btnSetStart.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSetStart.Name = "btnSetStart"
        Me.btnSetStart.Size = New System.Drawing.Size(100, 24)
        Me.btnSetStart.TabIndex = 30
        Me.btnSetStart.Text = "Set Start Date"
        Me.btnSetStart.UseVisualStyleBackColor = True
        Me.btnSetStart.Visible = False
        '
        'lblDateM
        '
        Me.lblDateM.AutoSize = True
        Me.lblDateM.BackColor = System.Drawing.Color.Transparent
        Me.lblDateM.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateM.Location = New System.Drawing.Point(28, 68)
        Me.lblDateM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateM.Name = "lblDateM"
        Me.lblDateM.Size = New System.Drawing.Size(64, 16)
        Me.lblDateM.TabIndex = 31
        Me.lblDateM.Text = "00/00/0000"
        '
        'lblDateT
        '
        Me.lblDateT.AutoSize = True
        Me.lblDateT.BackColor = System.Drawing.Color.Transparent
        Me.lblDateT.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateT.Location = New System.Drawing.Point(130, 68)
        Me.lblDateT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateT.Name = "lblDateT"
        Me.lblDateT.Size = New System.Drawing.Size(64, 16)
        Me.lblDateT.TabIndex = 32
        Me.lblDateT.Text = "00/00/0000"
        '
        'lblDateW
        '
        Me.lblDateW.AutoSize = True
        Me.lblDateW.BackColor = System.Drawing.Color.Transparent
        Me.lblDateW.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateW.Location = New System.Drawing.Point(219, 68)
        Me.lblDateW.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateW.Name = "lblDateW"
        Me.lblDateW.Size = New System.Drawing.Size(64, 16)
        Me.lblDateW.TabIndex = 33
        Me.lblDateW.Text = "00/00/0000"
        '
        'lblDateR
        '
        Me.lblDateR.AutoSize = True
        Me.lblDateR.BackColor = System.Drawing.Color.Transparent
        Me.lblDateR.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateR.Location = New System.Drawing.Point(321, 68)
        Me.lblDateR.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateR.Name = "lblDateR"
        Me.lblDateR.Size = New System.Drawing.Size(64, 16)
        Me.lblDateR.TabIndex = 34
        Me.lblDateR.Text = "00/00/0000"
        '
        'lblDateF
        '
        Me.lblDateF.AutoSize = True
        Me.lblDateF.BackColor = System.Drawing.Color.Transparent
        Me.lblDateF.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateF.Location = New System.Drawing.Point(431, 68)
        Me.lblDateF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateF.Name = "lblDateF"
        Me.lblDateF.Size = New System.Drawing.Size(64, 16)
        Me.lblDateF.TabIndex = 35
        Me.lblDateF.Text = "00/00/0000"
        '
        'lblDateS
        '
        Me.lblDateS.AutoSize = True
        Me.lblDateS.BackColor = System.Drawing.Color.Transparent
        Me.lblDateS.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateS.Location = New System.Drawing.Point(520, 68)
        Me.lblDateS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateS.Name = "lblDateS"
        Me.lblDateS.Size = New System.Drawing.Size(64, 16)
        Me.lblDateS.TabIndex = 36
        Me.lblDateS.Text = "00/00/0000"
        '
        'lblDateU
        '
        Me.lblDateU.AutoSize = True
        Me.lblDateU.BackColor = System.Drawing.Color.Transparent
        Me.lblDateU.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateU.Location = New System.Drawing.Point(618, 68)
        Me.lblDateU.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateU.Name = "lblDateU"
        Me.lblDateU.Size = New System.Drawing.Size(64, 16)
        Me.lblDateU.TabIndex = 37
        Me.lblDateU.Text = "00/00/0000"
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmAddSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 258)
        Me.Controls.Add(Me.lblDateU)
        Me.Controls.Add(Me.lblDateS)
        Me.Controls.Add(Me.lblDateF)
        Me.Controls.Add(Me.lblDateR)
        Me.Controls.Add(Me.lblDateW)
        Me.Controls.Add(Me.lblDateT)
        Me.Controls.Add(Me.lblDateM)
        Me.Controls.Add(Me.btnSetStart)
        Me.Controls.Add(Me.lblStartWeek)
        Me.Controls.Add(Me.txtStartWeek)
        Me.Controls.Add(Me.lblStartYear)
        Me.Controls.Add(Me.txtStartYear)
        Me.Controls.Add(Me.lblTitleSunday)
        Me.Controls.Add(Me.txtAmtU)
        Me.Controls.Add(Me.lblAmountSunday)
        Me.Controls.Add(Me.lblTitleSaturday)
        Me.Controls.Add(Me.txtAmtS)
        Me.Controls.Add(Me.lblAmountSaturday)
        Me.Controls.Add(Me.lblTitleFriday)
        Me.Controls.Add(Me.txtAmtF)
        Me.Controls.Add(Me.lblAmountFriday)
        Me.Controls.Add(Me.lblTitleThursday)
        Me.Controls.Add(Me.txtAmtR)
        Me.Controls.Add(Me.lblAmountThursday)
        Me.Controls.Add(Me.lblTitleWednesday)
        Me.Controls.Add(Me.txtAmtW)
        Me.Controls.Add(Me.lblAmountWednesday)
        Me.Controls.Add(Me.lblTitleTuesday)
        Me.Controls.Add(Me.txtAmtT)
        Me.Controls.Add(Me.lblAmountTuesday)
        Me.Controls.Add(Me.lblTitleMonday)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAmtM)
        Me.Controls.Add(Me.lblAmountMonday)
        Me.Controls.Add(Me.lblWeekNum)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmAddSales"
        Me.Text = "Add Sales"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWeekNum As Label
    Friend WithEvents lblAmountMonday As Label
    Friend WithEvents txtAmtM As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents lblTitleMonday As Label
    Friend WithEvents lblTitleTuesday As Label
    Friend WithEvents txtAmtT As TextBox
    Friend WithEvents lblAmountTuesday As Label
    Friend WithEvents lblTitleWednesday As Label
    Friend WithEvents txtAmtW As TextBox
    Friend WithEvents lblAmountWednesday As Label
    Friend WithEvents lblTitleThursday As Label
    Friend WithEvents txtAmtR As TextBox
    Friend WithEvents lblAmountThursday As Label
    Friend WithEvents lblTitleFriday As Label
    Friend WithEvents txtAmtF As TextBox
    Friend WithEvents lblAmountFriday As Label
    Friend WithEvents lblTitleSaturday As Label
    Friend WithEvents txtAmtS As TextBox
    Friend WithEvents lblAmountSaturday As Label
    Friend WithEvents lblTitleSunday As Label
    Friend WithEvents txtAmtU As TextBox
    Friend WithEvents lblAmountSunday As Label
    Friend WithEvents txtStartYear As TextBox
    Friend WithEvents lblStartYear As Label
    Friend WithEvents lblStartWeek As Label
    Friend WithEvents txtStartWeek As TextBox
    Friend WithEvents btnSetStart As Button
    Friend WithEvents lblDateM As Label
    Friend WithEvents lblDateT As Label
    Friend WithEvents lblDateW As Label
    Friend WithEvents lblDateR As Label
    Friend WithEvents lblDateF As Label
    Friend WithEvents lblDateS As Label
    Friend WithEvents lblDateU As Label
End Class
