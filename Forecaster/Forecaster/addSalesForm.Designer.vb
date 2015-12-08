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
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmtM = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmtT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAmtW = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAmtR = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAmtF = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAmtS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAmtU = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
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
        Me.lblWeekNum.Location = New System.Drawing.Point(339, 9)
        Me.lblWeekNum.Name = "lblWeekNum"
        Me.lblWeekNum.Size = New System.Drawing.Size(86, 25)
        Me.lblWeekNum.TabIndex = 0
        Me.lblWeekNum.Text = "Week #"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(24, 137)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(56, 17)
        Me.lblAmount.TabIndex = 2
        Me.lblAmount.Text = "Amount"
        '
        'txtAmtM
        '
        Me.txtAmtM.Location = New System.Drawing.Point(27, 156)
        Me.txtAmtM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmtM.Name = "txtAmtM"
        Me.txtAmtM.Size = New System.Drawing.Size(100, 22)
        Me.txtAmtM.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(412, 216)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(133, 43)
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
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Andrew\Documents\GitHub\For" &
    "ecaster\Forecaster\Forecaster\ForecasterDB.mdb"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Monday"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tuesday"
        '
        'txtAmtT
        '
        Me.txtAmtT.Location = New System.Drawing.Point(163, 156)
        Me.txtAmtT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmtT.Name = "txtAmtT"
        Me.txtAmtT.Size = New System.Drawing.Size(100, 22)
        Me.txtAmtT.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(290, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Wednesday"
        '
        'txtAmtW
        '
        Me.txtAmtW.Location = New System.Drawing.Point(295, 156)
        Me.txtAmtW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmtW.Name = "txtAmtW"
        Me.txtAmtW.Size = New System.Drawing.Size(100, 22)
        Me.txtAmtW.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(426, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Thursday"
        '
        'txtAmtR
        '
        Me.txtAmtR.Location = New System.Drawing.Point(427, 156)
        Me.txtAmtR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmtR.Name = "txtAmtR"
        Me.txtAmtR.Size = New System.Drawing.Size(100, 22)
        Me.txtAmtR.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(424, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(573, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Friday"
        '
        'txtAmtF
        '
        Me.txtAmtF.Location = New System.Drawing.Point(557, 156)
        Me.txtAmtF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmtF.Name = "txtAmtF"
        Me.txtAmtF.Size = New System.Drawing.Size(100, 22)
        Me.txtAmtF.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(554, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Amount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(691, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Saturday"
        '
        'txtAmtS
        '
        Me.txtAmtS.Location = New System.Drawing.Point(689, 156)
        Me.txtAmtS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmtS.Name = "txtAmtS"
        Me.txtAmtS.Size = New System.Drawing.Size(100, 22)
        Me.txtAmtS.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(686, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(822, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 25)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Sunday"
        '
        'txtAmtU
        '
        Me.txtAmtU.Location = New System.Drawing.Point(814, 156)
        Me.txtAmtU.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmtU.Name = "txtAmtU"
        Me.txtAmtU.Size = New System.Drawing.Size(100, 22)
        Me.txtAmtU.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(811, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Amount"
        '
        'txtStartYear
        '
        Me.txtStartYear.Location = New System.Drawing.Point(314, 42)
        Me.txtStartYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStartYear.Name = "txtStartYear"
        Me.txtStartYear.Size = New System.Drawing.Size(100, 22)
        Me.txtStartYear.TabIndex = 26
        Me.txtStartYear.Visible = False
        '
        'lblStartYear
        '
        Me.lblStartYear.AutoSize = True
        Me.lblStartYear.Location = New System.Drawing.Point(242, 45)
        Me.lblStartYear.Name = "lblStartYear"
        Me.lblStartYear.Size = New System.Drawing.Size(72, 17)
        Me.lblStartYear.TabIndex = 27
        Me.lblStartYear.Text = "Start Year"
        Me.lblStartYear.Visible = False
        '
        'lblStartWeek
        '
        Me.lblStartWeek.AutoSize = True
        Me.lblStartWeek.Location = New System.Drawing.Point(428, 45)
        Me.lblStartWeek.Name = "lblStartWeek"
        Me.lblStartWeek.Size = New System.Drawing.Size(78, 17)
        Me.lblStartWeek.TabIndex = 29
        Me.lblStartWeek.Text = "Start Week"
        Me.lblStartWeek.Visible = False
        '
        'txtStartWeek
        '
        Me.txtStartWeek.Location = New System.Drawing.Point(509, 42)
        Me.txtStartWeek.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStartWeek.Name = "txtStartWeek"
        Me.txtStartWeek.Size = New System.Drawing.Size(100, 22)
        Me.txtStartWeek.TabIndex = 28
        Me.txtStartWeek.Visible = False
        '
        'btnSetStart
        '
        Me.btnSetStart.Location = New System.Drawing.Point(612, 36)
        Me.btnSetStart.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSetStart.Name = "btnSetStart"
        Me.btnSetStart.Size = New System.Drawing.Size(133, 30)
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
        Me.lblDateM.Location = New System.Drawing.Point(37, 84)
        Me.lblDateM.Name = "lblDateM"
        Me.lblDateM.Size = New System.Drawing.Size(73, 19)
        Me.lblDateM.TabIndex = 31
        Me.lblDateM.Text = "00/00/0000"
        '
        'lblDateT
        '
        Me.lblDateT.AutoSize = True
        Me.lblDateT.BackColor = System.Drawing.Color.Transparent
        Me.lblDateT.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateT.Location = New System.Drawing.Point(173, 84)
        Me.lblDateT.Name = "lblDateT"
        Me.lblDateT.Size = New System.Drawing.Size(73, 19)
        Me.lblDateT.TabIndex = 32
        Me.lblDateT.Text = "00/00/0000"
        '
        'lblDateW
        '
        Me.lblDateW.AutoSize = True
        Me.lblDateW.BackColor = System.Drawing.Color.Transparent
        Me.lblDateW.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateW.Location = New System.Drawing.Point(292, 84)
        Me.lblDateW.Name = "lblDateW"
        Me.lblDateW.Size = New System.Drawing.Size(73, 19)
        Me.lblDateW.TabIndex = 33
        Me.lblDateW.Text = "00/00/0000"
        '
        'lblDateR
        '
        Me.lblDateR.AutoSize = True
        Me.lblDateR.BackColor = System.Drawing.Color.Transparent
        Me.lblDateR.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateR.Location = New System.Drawing.Point(428, 84)
        Me.lblDateR.Name = "lblDateR"
        Me.lblDateR.Size = New System.Drawing.Size(73, 19)
        Me.lblDateR.TabIndex = 34
        Me.lblDateR.Text = "00/00/0000"
        '
        'lblDateF
        '
        Me.lblDateF.AutoSize = True
        Me.lblDateF.BackColor = System.Drawing.Color.Transparent
        Me.lblDateF.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateF.Location = New System.Drawing.Point(575, 84)
        Me.lblDateF.Name = "lblDateF"
        Me.lblDateF.Size = New System.Drawing.Size(73, 19)
        Me.lblDateF.TabIndex = 35
        Me.lblDateF.Text = "00/00/0000"
        '
        'lblDateS
        '
        Me.lblDateS.AutoSize = True
        Me.lblDateS.BackColor = System.Drawing.Color.Transparent
        Me.lblDateS.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateS.Location = New System.Drawing.Point(693, 84)
        Me.lblDateS.Name = "lblDateS"
        Me.lblDateS.Size = New System.Drawing.Size(73, 19)
        Me.lblDateS.TabIndex = 36
        Me.lblDateS.Text = "00/00/0000"
        '
        'lblDateU
        '
        Me.lblDateU.AutoSize = True
        Me.lblDateU.BackColor = System.Drawing.Color.Transparent
        Me.lblDateU.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateU.Location = New System.Drawing.Point(824, 84)
        Me.lblDateU.Name = "lblDateU"
        Me.lblDateU.Size = New System.Drawing.Size(73, 19)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 318)
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
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAmtU)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAmtS)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAmtF)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAmtR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAmtW)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAmtT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAmtM)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblWeekNum)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmAddSales"
        Me.Text = "Add Sales"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWeekNum As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmtM As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmtT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAmtW As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAmtR As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAmtF As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAmtS As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAmtU As TextBox
    Friend WithEvents Label13 As Label
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
