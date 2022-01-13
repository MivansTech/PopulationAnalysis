<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.lblClose = New System.Windows.Forms.LinkLabel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtSchoolAttended = New System.Windows.Forms.TextBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PASDataSet = New PopulationSystem.PASDataSet()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblDateRegistered = New System.Windows.Forms.Label()
        Me.lblNoOfStaff = New System.Windows.Forms.Label()
        Me.lblDeptHead = New System.Windows.Forms.Label()
        Me.lblDepartmentName = New System.Windows.Forms.Label()
        Me.lblStaffConsole = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtOthername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtxtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.cboResultObtain = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboHighQualification = New System.Windows.Forms.ComboBox()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateObtained = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProfessionalQualification = New System.Windows.Forms.TextBox()
        Me.txtOtherqualification = New System.Windows.Forms.TextBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StaffTableAdapter = New PopulationSystem.PASDataSetTableAdapters.StaffTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OthernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HighQualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolAttendedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultObtainedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateobtainedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfessionalqualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherqualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Red
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblClose.LinkColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(145, 2)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(52, 18)
        Me.lblClose.TabIndex = 12
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "&Close"
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(78, 51)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 22)
        Me.txtSearch.TabIndex = 23
        '
        'txtSchoolAttended
        '
        Me.txtSchoolAttended.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "School_Attended", True))
        Me.txtSchoolAttended.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchoolAttended.Location = New System.Drawing.Point(445, 272)
        Me.txtSchoolAttended.Name = "txtSchoolAttended"
        Me.txtSchoolAttended.Size = New System.Drawing.Size(200, 22)
        Me.txtSchoolAttended.TabIndex = 12
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.PASDataSet
        '
        'PASDataSet
        '
        Me.PASDataSet.DataSetName = "PASDataSet"
        Me.PASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpStart
        '
        Me.dtpStart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "start_date", True))
        Me.dtpStart.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Location = New System.Drawing.Point(441, 131)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 22)
        Me.dtpStart.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.lblClose)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnCreate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(724, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 616)
        Me.Panel1.TabIndex = 21
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.PopulationSystem.My.Resources.Resources.remove
        Me.btnDelete.Location = New System.Drawing.Point(-6, 217)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(194, 73)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 454)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 13
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Global.PopulationSystem.My.Resources.Resources.hr
        Me.btnUpdate.Location = New System.Drawing.Point(-6, 138)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(194, 73)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.PopulationSystem.My.Resources.Resources.printer44
        Me.Button4.Location = New System.Drawing.Point(-6, 287)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(194, 73)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "&Print"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Image = Global.PopulationSystem.My.Resources.Resources.Actions_document_edit_icon
        Me.btnCreate.Location = New System.Drawing.Point(-6, 59)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(194, 73)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Create Department"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "address", True))
        Me.txtAddress.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(235, 357)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 22)
        Me.txtAddress.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Email", True))
        Me.txtEmail.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(235, 409)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 22)
        Me.txtEmail.TabIndex = 16
        '
        'lblDateRegistered
        '
        Me.lblDateRegistered.AutoSize = True
        Me.lblDateRegistered.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateRegistered.ForeColor = System.Drawing.Color.Teal
        Me.lblDateRegistered.Location = New System.Drawing.Point(232, 437)
        Me.lblDateRegistered.Name = "lblDateRegistered"
        Me.lblDateRegistered.Size = New System.Drawing.Size(100, 15)
        Me.lblDateRegistered.TabIndex = 20
        Me.lblDateRegistered.Text = "Phone Number"
        '
        'lblNoOfStaff
        '
        Me.lblNoOfStaff.AutoSize = True
        Me.lblNoOfStaff.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfStaff.ForeColor = System.Drawing.Color.Teal
        Me.lblNoOfStaff.Location = New System.Drawing.Point(232, 393)
        Me.lblNoOfStaff.Name = "lblNoOfStaff"
        Me.lblNoOfStaff.Size = New System.Drawing.Size(41, 15)
        Me.lblNoOfStaff.TabIndex = 19
        Me.lblNoOfStaff.Text = "Email"
        '
        'lblDeptHead
        '
        Me.lblDeptHead.AutoSize = True
        Me.lblDeptHead.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptHead.ForeColor = System.Drawing.Color.Teal
        Me.lblDeptHead.Location = New System.Drawing.Point(232, 341)
        Me.lblDeptHead.Name = "lblDeptHead"
        Me.lblDeptHead.Size = New System.Drawing.Size(59, 15)
        Me.lblDeptHead.TabIndex = 17
        Me.lblDeptHead.Text = "Address"
        '
        'lblDepartmentName
        '
        Me.lblDepartmentName.AutoSize = True
        Me.lblDepartmentName.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartmentName.ForeColor = System.Drawing.Color.Teal
        Me.lblDepartmentName.Location = New System.Drawing.Point(232, 294)
        Me.lblDepartmentName.Name = "lblDepartmentName"
        Me.lblDepartmentName.Size = New System.Drawing.Size(28, 15)
        Me.lblDepartmentName.TabIndex = 15
        Me.lblDepartmentName.Text = "Sex"
        '
        'lblStaffConsole
        '
        Me.lblStaffConsole.AutoSize = True
        Me.lblStaffConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStaffConsole.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffConsole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStaffConsole.Location = New System.Drawing.Point(309, 5)
        Me.lblStaffConsole.Name = "lblStaffConsole"
        Me.lblStaffConsole.Size = New System.Drawing.Size(157, 24)
        Me.lblStaffConsole.TabIndex = 13
        Me.lblStaffConsole.Text = "Staff Console"
        '
        'txtSurname
        '
        Me.txtSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "surname", True))
        Me.txtSurname.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(235, 134)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(200, 22)
        Me.txtSurname.TabIndex = 24
        '
        'dtpDOB
        '
        Me.dtpDOB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "dob", True))
        Me.dtpDOB.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Location = New System.Drawing.Point(235, 272)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 22)
        Me.dtpDOB.TabIndex = 29
        '
        'txtFname
        '
        Me.txtFname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "firstname", True))
        Me.txtFname.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(235, 185)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(200, 22)
        Me.txtFname.TabIndex = 25
        '
        'txtOthername
        '
        Me.txtOthername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "othername", True))
        Me.txtOthername.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthername.Location = New System.Drawing.Point(235, 233)
        Me.txtOthername.Name = "txtOthername"
        Me.txtOthername.Size = New System.Drawing.Size(200, 22)
        Me.txtOthername.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(232, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Date of Birth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(232, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Other Names"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(232, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Firstname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(232, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Surname"
        '
        'mtxtPhoneNumber
        '
        Me.mtxtPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "phone", True))
        Me.mtxtPhoneNumber.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtPhoneNumber.Location = New System.Drawing.Point(235, 453)
        Me.mtxtPhoneNumber.Mask = "(234) 000-0000000"
        Me.mtxtPhoneNumber.Name = "mtxtPhoneNumber"
        Me.mtxtPhoneNumber.Size = New System.Drawing.Size(200, 22)
        Me.mtxtPhoneNumber.TabIndex = 32
        '
        'cboSex
        '
        Me.cboSex.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "sex", True))
        Me.cboSex.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"Male ", "Female", "Other"})
        Me.cboSex.Location = New System.Drawing.Point(235, 310)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(200, 23)
        Me.cboSex.TabIndex = 34
        '
        'cboResultObtain
        '
        Me.cboResultObtain.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Result_Obtained", True))
        Me.cboResultObtain.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboResultObtain.FormattingEnabled = True
        Me.cboResultObtain.Items.AddRange(New Object() {"First class Upper", "First Class Lower", "Second Class Upper", "Second Class Lower", "Pass", "Distinction", "Upper Credit", "Lower Credit", "Pass diploma", "Certificate of Appreciation"})
        Me.cboResultObtain.Location = New System.Drawing.Point(445, 310)
        Me.cboResultObtain.Name = "cboResultObtain"
        Me.cboResultObtain.Size = New System.Drawing.Size(200, 23)
        Me.cboResultObtain.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(485, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Start Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(485, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "End Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(485, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Higher Qualification"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(485, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 15)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "School Attended"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(485, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 15)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Result Obtained"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(485, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 15)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Date Obtained"
        '
        'cboHighQualification
        '
        Me.cboHighQualification.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "High_Qualification", True))
        Me.cboHighQualification.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHighQualification.FormattingEnabled = True
        Me.cboHighQualification.Items.AddRange(New Object() {"Masters Degree", "Bachelor Degree", "Higher National Diploma", "National Diploma", "Nigeria Certificate in Education", "Senior School Certificate Examination", "First School Leaving Certificate"})
        Me.cboHighQualification.Location = New System.Drawing.Point(444, 233)
        Me.cboHighQualification.Name = "cboHighQualification"
        Me.cboHighQualification.Size = New System.Drawing.Size(200, 23)
        Me.cboHighQualification.TabIndex = 42
        '
        'dtpEnd
        '
        Me.dtpEnd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "End_date", True))
        Me.dtpEnd.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Location = New System.Drawing.Point(442, 182)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 22)
        Me.dtpEnd.TabIndex = 43
        '
        'dtpDateObtained
        '
        Me.dtpDateObtained.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Date_obtained", True))
        Me.dtpDateObtained.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateObtained.Location = New System.Drawing.Point(447, 357)
        Me.dtpDateObtained.Name = "dtpDateObtained"
        Me.dtpDateObtained.Size = New System.Drawing.Size(200, 22)
        Me.dtpDateObtained.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(485, 394)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 15)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Professional Qualification"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(485, 437)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 15)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Other Qualification"
        '
        'txtProfessionalQualification
        '
        Me.txtProfessionalQualification.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "professional_qualification", True))
        Me.txtProfessionalQualification.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfessionalQualification.Location = New System.Drawing.Point(446, 409)
        Me.txtProfessionalQualification.Name = "txtProfessionalQualification"
        Me.txtProfessionalQualification.Size = New System.Drawing.Size(200, 22)
        Me.txtProfessionalQualification.TabIndex = 47
        '
        'txtOtherqualification
        '
        Me.txtOtherqualification.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "other_qualification", True))
        Me.txtOtherqualification.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherqualification.Location = New System.Drawing.Point(444, 453)
        Me.txtOtherqualification.Name = "txtOtherqualification"
        Me.txtOtherqualification.Size = New System.Drawing.Size(200, 22)
        Me.txtOtherqualification.TabIndex = 48
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Teal
        Me.RectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.RectangleShape1.BorderWidth = 3
        Me.RectangleShape1.FillColor = System.Drawing.Color.White
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(63, 129)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(162, 274)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(924, 616)
        Me.ShapeContainer1.TabIndex = 95
        Me.ShapeContainer1.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.Image = Global.PopulationSystem.My.Resources.Resources.led_unlocked
        Me.btnUpload.Location = New System.Drawing.Point(72, 351)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(146, 50)
        Me.btnUpload.TabIndex = 94
        Me.btnUpload.Text = "Upload Photo"
        Me.btnUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Honeydew
        Me.PictureBox1.BackgroundImage = Global.PopulationSystem.My.Resources.Resources.avatar
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StaffBindingSource, "photo", True))
        Me.PictureBox1.Location = New System.Drawing.Point(72, 134)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.PopulationSystem.My.Resources.Resources.orange_bullet
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(176, 51)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(42, 22)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.OthernameDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.StartdateDataGridViewTextBoxColumn, Me.EnddateDataGridViewTextBoxColumn, Me.HighQualificationDataGridViewTextBoxColumn, Me.SchoolAttendedDataGridViewTextBoxColumn, Me.ResultObtainedDataGridViewTextBoxColumn, Me.DateobtainedDataGridViewTextBoxColumn, Me.ProfessionalqualificationDataGridViewTextBoxColumn, Me.OtherqualificationDataGridViewTextBoxColumn, Me.PhotoDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.StaffBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 496)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(724, 120)
        Me.DataGridView1.TabIndex = 96
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'OthernameDataGridViewTextBoxColumn
        '
        Me.OthernameDataGridViewTextBoxColumn.DataPropertyName = "othername"
        Me.OthernameDataGridViewTextBoxColumn.HeaderText = "othername"
        Me.OthernameDataGridViewTextBoxColumn.Name = "OthernameDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'StartdateDataGridViewTextBoxColumn
        '
        Me.StartdateDataGridViewTextBoxColumn.DataPropertyName = "start_date"
        Me.StartdateDataGridViewTextBoxColumn.HeaderText = "start_date"
        Me.StartdateDataGridViewTextBoxColumn.Name = "StartdateDataGridViewTextBoxColumn"
        '
        'EnddateDataGridViewTextBoxColumn
        '
        Me.EnddateDataGridViewTextBoxColumn.DataPropertyName = "End_date"
        Me.EnddateDataGridViewTextBoxColumn.HeaderText = "End_date"
        Me.EnddateDataGridViewTextBoxColumn.Name = "EnddateDataGridViewTextBoxColumn"
        '
        'HighQualificationDataGridViewTextBoxColumn
        '
        Me.HighQualificationDataGridViewTextBoxColumn.DataPropertyName = "High_Qualification"
        Me.HighQualificationDataGridViewTextBoxColumn.HeaderText = "High_Qualification"
        Me.HighQualificationDataGridViewTextBoxColumn.Name = "HighQualificationDataGridViewTextBoxColumn"
        '
        'SchoolAttendedDataGridViewTextBoxColumn
        '
        Me.SchoolAttendedDataGridViewTextBoxColumn.DataPropertyName = "School_Attended"
        Me.SchoolAttendedDataGridViewTextBoxColumn.HeaderText = "School_Attended"
        Me.SchoolAttendedDataGridViewTextBoxColumn.Name = "SchoolAttendedDataGridViewTextBoxColumn"
        '
        'ResultObtainedDataGridViewTextBoxColumn
        '
        Me.ResultObtainedDataGridViewTextBoxColumn.DataPropertyName = "Result_Obtained"
        Me.ResultObtainedDataGridViewTextBoxColumn.HeaderText = "Result_Obtained"
        Me.ResultObtainedDataGridViewTextBoxColumn.Name = "ResultObtainedDataGridViewTextBoxColumn"
        '
        'DateobtainedDataGridViewTextBoxColumn
        '
        Me.DateobtainedDataGridViewTextBoxColumn.DataPropertyName = "Date_obtained"
        Me.DateobtainedDataGridViewTextBoxColumn.HeaderText = "Date_obtained"
        Me.DateobtainedDataGridViewTextBoxColumn.Name = "DateobtainedDataGridViewTextBoxColumn"
        '
        'ProfessionalqualificationDataGridViewTextBoxColumn
        '
        Me.ProfessionalqualificationDataGridViewTextBoxColumn.DataPropertyName = "professional_qualification"
        Me.ProfessionalqualificationDataGridViewTextBoxColumn.HeaderText = "professional_qualification"
        Me.ProfessionalqualificationDataGridViewTextBoxColumn.Name = "ProfessionalqualificationDataGridViewTextBoxColumn"
        '
        'OtherqualificationDataGridViewTextBoxColumn
        '
        Me.OtherqualificationDataGridViewTextBoxColumn.DataPropertyName = "other_qualification"
        Me.OtherqualificationDataGridViewTextBoxColumn.HeaderText = "other_qualification"
        Me.OtherqualificationDataGridViewTextBoxColumn.Name = "OtherqualificationDataGridViewTextBoxColumn"
        '
        'PhotoDataGridViewImageColumn
        '
        Me.PhotoDataGridViewImageColumn.DataPropertyName = "photo"
        Me.PhotoDataGridViewImageColumn.HeaderText = "photo"
        Me.PhotoDataGridViewImageColumn.Name = "PhotoDataGridViewImageColumn"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(924, 616)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtOtherqualification)
        Me.Controls.Add(Me.txtProfessionalQualification)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpDateObtained)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.cboHighQualification)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboResultObtain)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.mtxtPhoneNumber)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtOthername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSchoolAttended)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblDateRegistered)
        Me.Controls.Add(Me.lblNoOfStaff)
        Me.Controls.Add(Me.lblDeptHead)
        Me.Controls.Add(Me.lblDepartmentName)
        Me.Controls.Add(Me.lblStaffConsole)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStaff"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSchoolAttended As System.Windows.Forms.TextBox
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblDateRegistered As System.Windows.Forms.Label
    Friend WithEvents lblNoOfStaff As System.Windows.Forms.Label
    Friend WithEvents lblDeptHead As System.Windows.Forms.Label
    Friend WithEvents lblDepartmentName As System.Windows.Forms.Label
    Friend WithEvents lblStaffConsole As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtOthername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents mtxtPhoneNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents cboResultObtain As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboHighQualification As System.Windows.Forms.ComboBox
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateObtained As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtProfessionalQualification As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherqualification As System.Windows.Forms.TextBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PASDataSet As PopulationSystem.PASDataSet
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As PopulationSystem.PASDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OthernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnddateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HighQualificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolAttendedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResultObtainedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateobtainedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfessionalqualificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherqualificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class
