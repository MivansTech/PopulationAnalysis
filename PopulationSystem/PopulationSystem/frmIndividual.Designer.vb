<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndividual
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboNationality = New System.Windows.Forms.ComboBox()
        Me.IndividualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PASDataSet = New PopulationSystem.PASDataSet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboStateOfBirth = New System.Windows.Forms.ComboBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.mtxtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.lblClose = New System.Windows.Forms.LinkLabel()
        Me.txtOtherName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblDateRegistered = New System.Windows.Forms.Label()
        Me.lblNoOfStaff = New System.Windows.Forms.Label()
        Me.lblDeptHead = New System.Windows.Forms.Label()
        Me.lblDepartmentName = New System.Windows.Forms.Label()
        Me.lblaPersonConsole = New System.Windows.Forms.Label()
        Me.cboResidential = New System.Windows.Forms.ComboBox()
        Me.cboOccupation = New System.Windows.Forms.ComboBox()
        Me.cboLGAbirth = New System.Windows.Forms.ComboBox()
        Me.cboDisable = New System.Windows.Forms.ComboBox()
        Me.IndividualTableAdapter = New PopulationSystem.PASDataSetTableAdapters.IndividualTableAdapter()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IndividualIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OthernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LgaOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidentialStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidentialLGADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidentialAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OccupationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisabledDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.IndividualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(445, 197)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 15)
        Me.Label12.TabIndex = 82
        '
        'cboNationality
        '
        Me.cboNationality.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "Nationality", True))
        Me.cboNationality.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNationality.FormattingEnabled = True
        Me.cboNationality.Items.AddRange(New Object() {"Nigerian"})
        Me.cboNationality.Location = New System.Drawing.Point(444, 166)
        Me.cboNationality.Name = "cboNationality"
        Me.cboNationality.Size = New System.Drawing.Size(200, 23)
        Me.cboNationality.TabIndex = 78
        '
        'IndividualBindingSource
        '
        Me.IndividualBindingSource.DataMember = "Individual"
        Me.IndividualBindingSource.DataSource = Me.PASDataSet
        '
        'PASDataSet
        '
        Me.PASDataSet.DataSetName = "PASDataSet"
        Me.PASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(445, 360)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 15)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Disabled?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(441, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "State of Birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(440, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Occupation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(441, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Nationality"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(442, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 15)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Residential L.G.A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(446, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "L.G.A of Birth"
        '
        'cboStateOfBirth
        '
        Me.cboStateOfBirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "stateOfBirth", True))
        Me.cboStateOfBirth.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStateOfBirth.FormattingEnabled = True
        Me.cboStateOfBirth.Items.AddRange(New Object() {"Abia", "Adamawa", "Akwa Ibom", "Anambra", "Bayelsa", "Bauchi", "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Edo", "Ekiti", "Enugu", "Gombe", "Kaduna", "Kano", "Kebbi", "Lagos", "Ogun", "Ondo", "Osun", "Plateau", "Other"})
        Me.cboStateOfBirth.Location = New System.Drawing.Point(444, 213)
        Me.cboStateOfBirth.Name = "cboStateOfBirth"
        Me.cboStateOfBirth.Size = New System.Drawing.Size(200, 23)
        Me.cboStateOfBirth.TabIndex = 71
        '
        'cboSex
        '
        Me.cboSex.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "sex", True))
        Me.cboSex.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cboSex.Location = New System.Drawing.Point(204, 291)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(200, 23)
        Me.cboSex.TabIndex = 70
        '
        'mtxtPhoneNumber
        '
        Me.mtxtPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "phone", True))
        Me.mtxtPhoneNumber.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtPhoneNumber.Location = New System.Drawing.Point(203, 331)
        Me.mtxtPhoneNumber.Mask = "(234) 000-0000000"
        Me.mtxtPhoneNumber.Name = "mtxtPhoneNumber"
        Me.mtxtPhoneNumber.Size = New System.Drawing.Size(200, 22)
        Me.mtxtPhoneNumber.TabIndex = 69
        '
        'txtSurname
        '
        Me.txtSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "surname", True))
        Me.txtSurname.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(204, 115)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(200, 22)
        Me.txtSurname.TabIndex = 61
        '
        'dtpDOB
        '
        Me.dtpDOB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "dob", True))
        Me.dtpDOB.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Location = New System.Drawing.Point(203, 254)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 22)
        Me.dtpDOB.TabIndex = 66
        '
        'txtfname
        '
        Me.txtfname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "firstname", True))
        Me.txtfname.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(204, 166)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(200, 22)
        Me.txtfname.TabIndex = 62
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
        'txtOtherName
        '
        Me.txtOtherName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "othername", True))
        Me.txtOtherName.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherName.Location = New System.Drawing.Point(204, 214)
        Me.txtOtherName.Name = "txtOtherName"
        Me.txtOtherName.Size = New System.Drawing.Size(200, 22)
        Me.txtOtherName.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(201, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Date of Birth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(201, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Other Names"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(201, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Firstname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(201, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Surname"
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(5, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 22)
        Me.txtSearch.TabIndex = 60
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.lblClose)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnCreate)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(648, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 528)
        Me.Panel1.TabIndex = 58
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 366)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 13
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Global.PopulationSystem.My.Resources.Resources.hr
        Me.btnUpdate.Location = New System.Drawing.Point(3, 129)
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
        Me.Button4.Location = New System.Drawing.Point(3, 282)
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
        Me.btnCreate.Location = New System.Drawing.Point(3, 50)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(194, 73)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Create Department"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.PopulationSystem.My.Resources.Resources.remove
        Me.btnDelete.Location = New System.Drawing.Point(3, 204)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(194, 73)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.PopulationSystem.My.Resources.Resources.orange_bullet
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(103, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(42, 22)
        Me.btnSearch.TabIndex = 59
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "Residential_Address", True))
        Me.txtAddress.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(445, 331)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 22)
        Me.txtAddress.TabIndex = 51
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "email", True))
        Me.txtEmail.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(203, 376)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 22)
        Me.txtEmail.TabIndex = 53
        '
        'lblDateRegistered
        '
        Me.lblDateRegistered.AutoSize = True
        Me.lblDateRegistered.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateRegistered.ForeColor = System.Drawing.Color.Teal
        Me.lblDateRegistered.Location = New System.Drawing.Point(200, 315)
        Me.lblDateRegistered.Name = "lblDateRegistered"
        Me.lblDateRegistered.Size = New System.Drawing.Size(100, 15)
        Me.lblDateRegistered.TabIndex = 57
        Me.lblDateRegistered.Text = "Phone Number"
        '
        'lblNoOfStaff
        '
        Me.lblNoOfStaff.AutoSize = True
        Me.lblNoOfStaff.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfStaff.ForeColor = System.Drawing.Color.Teal
        Me.lblNoOfStaff.Location = New System.Drawing.Point(200, 360)
        Me.lblNoOfStaff.Name = "lblNoOfStaff"
        Me.lblNoOfStaff.Size = New System.Drawing.Size(41, 15)
        Me.lblNoOfStaff.TabIndex = 56
        Me.lblNoOfStaff.Text = "Email"
        '
        'lblDeptHead
        '
        Me.lblDeptHead.AutoSize = True
        Me.lblDeptHead.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptHead.ForeColor = System.Drawing.Color.Teal
        Me.lblDeptHead.Location = New System.Drawing.Point(442, 315)
        Me.lblDeptHead.Name = "lblDeptHead"
        Me.lblDeptHead.Size = New System.Drawing.Size(133, 15)
        Me.lblDeptHead.TabIndex = 54
        Me.lblDeptHead.Text = "Residential Address"
        '
        'lblDepartmentName
        '
        Me.lblDepartmentName.AutoSize = True
        Me.lblDepartmentName.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartmentName.ForeColor = System.Drawing.Color.Teal
        Me.lblDepartmentName.Location = New System.Drawing.Point(201, 275)
        Me.lblDepartmentName.Name = "lblDepartmentName"
        Me.lblDepartmentName.Size = New System.Drawing.Size(28, 15)
        Me.lblDepartmentName.TabIndex = 52
        Me.lblDepartmentName.Text = "Sex"
        '
        'lblaPersonConsole
        '
        Me.lblaPersonConsole.AutoSize = True
        Me.lblaPersonConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblaPersonConsole.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaPersonConsole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblaPersonConsole.Location = New System.Drawing.Point(300, 15)
        Me.lblaPersonConsole.Name = "lblaPersonConsole"
        Me.lblaPersonConsole.Size = New System.Drawing.Size(182, 24)
        Me.lblaPersonConsole.TabIndex = 50
        Me.lblaPersonConsole.Text = "Person Console"
        '
        'cboResidential
        '
        Me.cboResidential.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "Residential_LGA", True))
        Me.cboResidential.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboResidential.FormattingEnabled = True
        Me.cboResidential.Location = New System.Drawing.Point(445, 291)
        Me.cboResidential.Name = "cboResidential"
        Me.cboResidential.Size = New System.Drawing.Size(200, 23)
        Me.cboResidential.TabIndex = 85
        '
        'cboOccupation
        '
        Me.cboOccupation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "occupation", True))
        Me.cboOccupation.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOccupation.FormattingEnabled = True
        Me.cboOccupation.Items.AddRange(New Object() {"Civil Servant", "Enterpreneure", "Military ", "Student"})
        Me.cboOccupation.Location = New System.Drawing.Point(444, 115)
        Me.cboOccupation.Name = "cboOccupation"
        Me.cboOccupation.Size = New System.Drawing.Size(199, 23)
        Me.cboOccupation.TabIndex = 86
        '
        'cboLGAbirth
        '
        Me.cboLGAbirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "LgaOfBirth", True))
        Me.cboLGAbirth.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLGAbirth.FormattingEnabled = True
        Me.cboLGAbirth.Location = New System.Drawing.Point(446, 254)
        Me.cboLGAbirth.Name = "cboLGAbirth"
        Me.cboLGAbirth.Size = New System.Drawing.Size(197, 23)
        Me.cboLGAbirth.TabIndex = 87
        '
        'cboDisable
        '
        Me.cboDisable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "disabled", True))
        Me.cboDisable.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDisable.FormattingEnabled = True
        Me.cboDisable.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboDisable.Location = New System.Drawing.Point(444, 376)
        Me.cboDisable.Name = "cboDisable"
        Me.cboDisable.Size = New System.Drawing.Size(201, 23)
        Me.cboDisable.TabIndex = 88
        '
        'IndividualTableAdapter
        '
        Me.IndividualTableAdapter.ClearBeforeFill = True
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IndividualBindingSource, "Individual_ID", True))
        Me.txtID.Location = New System.Drawing.Point(204, 76)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 89
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndividualIDDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.OthernameDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.StateOfBirthDataGridViewTextBoxColumn, Me.LgaOfBirthDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.ResidentialStateDataGridViewTextBoxColumn, Me.ResidentialLGADataGridViewTextBoxColumn, Me.ResidentialAddressDataGridViewTextBoxColumn, Me.OccupationDataGridViewTextBoxColumn, Me.DisabledDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.IndividualBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 417)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(648, 111)
        Me.DataGridView1.TabIndex = 90
        '
        'IndividualIDDataGridViewTextBoxColumn
        '
        Me.IndividualIDDataGridViewTextBoxColumn.DataPropertyName = "Individual_ID"
        Me.IndividualIDDataGridViewTextBoxColumn.HeaderText = "Individual_ID"
        Me.IndividualIDDataGridViewTextBoxColumn.Name = "IndividualIDDataGridViewTextBoxColumn"
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
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'StateOfBirthDataGridViewTextBoxColumn
        '
        Me.StateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "stateOfBirth"
        Me.StateOfBirthDataGridViewTextBoxColumn.HeaderText = "stateOfBirth"
        Me.StateOfBirthDataGridViewTextBoxColumn.Name = "StateOfBirthDataGridViewTextBoxColumn"
        '
        'LgaOfBirthDataGridViewTextBoxColumn
        '
        Me.LgaOfBirthDataGridViewTextBoxColumn.DataPropertyName = "LgaOfBirth"
        Me.LgaOfBirthDataGridViewTextBoxColumn.HeaderText = "LgaOfBirth"
        Me.LgaOfBirthDataGridViewTextBoxColumn.Name = "LgaOfBirthDataGridViewTextBoxColumn"
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        '
        'ResidentialStateDataGridViewTextBoxColumn
        '
        Me.ResidentialStateDataGridViewTextBoxColumn.DataPropertyName = "Residential_State"
        Me.ResidentialStateDataGridViewTextBoxColumn.HeaderText = "Residential_State"
        Me.ResidentialStateDataGridViewTextBoxColumn.Name = "ResidentialStateDataGridViewTextBoxColumn"
        '
        'ResidentialLGADataGridViewTextBoxColumn
        '
        Me.ResidentialLGADataGridViewTextBoxColumn.DataPropertyName = "Residential_LGA"
        Me.ResidentialLGADataGridViewTextBoxColumn.HeaderText = "Residential_LGA"
        Me.ResidentialLGADataGridViewTextBoxColumn.Name = "ResidentialLGADataGridViewTextBoxColumn"
        '
        'ResidentialAddressDataGridViewTextBoxColumn
        '
        Me.ResidentialAddressDataGridViewTextBoxColumn.DataPropertyName = "Residential_Address"
        Me.ResidentialAddressDataGridViewTextBoxColumn.HeaderText = "Residential_Address"
        Me.ResidentialAddressDataGridViewTextBoxColumn.Name = "ResidentialAddressDataGridViewTextBoxColumn"
        '
        'OccupationDataGridViewTextBoxColumn
        '
        Me.OccupationDataGridViewTextBoxColumn.DataPropertyName = "occupation"
        Me.OccupationDataGridViewTextBoxColumn.HeaderText = "occupation"
        Me.OccupationDataGridViewTextBoxColumn.Name = "OccupationDataGridViewTextBoxColumn"
        '
        'DisabledDataGridViewTextBoxColumn
        '
        Me.DisabledDataGridViewTextBoxColumn.DataPropertyName = "disabled"
        Me.DisabledDataGridViewTextBoxColumn.HeaderText = "disabled"
        Me.DisabledDataGridViewTextBoxColumn.Name = "DisabledDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(848, 528)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cboDisable)
        Me.Controls.Add(Me.cboLGAbirth)
        Me.Controls.Add(Me.cboOccupation)
        Me.Controls.Add(Me.cboResidential)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboNationality)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboStateOfBirth)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.mtxtPhoneNumber)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtOtherName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblDateRegistered)
        Me.Controls.Add(Me.lblNoOfStaff)
        Me.Controls.Add(Me.lblDeptHead)
        Me.Controls.Add(Me.lblDepartmentName)
        Me.Controls.Add(Me.lblaPersonConsole)
        Me.ForeColor = System.Drawing.Color.Teal
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIndividual"
        Me.Text = "frmIndividual"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IndividualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboNationality As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboStateOfBirth As System.Windows.Forms.ComboBox
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents mtxtPhoneNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents txtOtherName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblDateRegistered As System.Windows.Forms.Label
    Friend WithEvents lblNoOfStaff As System.Windows.Forms.Label
    Friend WithEvents lblDeptHead As System.Windows.Forms.Label
    Friend WithEvents lblDepartmentName As System.Windows.Forms.Label
    Friend WithEvents lblaPersonConsole As System.Windows.Forms.Label
    Friend WithEvents cboResidential As System.Windows.Forms.ComboBox
    Friend WithEvents cboOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents cboLGAbirth As System.Windows.Forms.ComboBox
    Friend WithEvents cboDisable As System.Windows.Forms.ComboBox
    Friend WithEvents PASDataSet As PopulationSystem.PASDataSet
    Friend WithEvents IndividualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IndividualTableAdapter As PopulationSystem.PASDataSetTableAdapters.IndividualTableAdapter
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IndividualIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OthernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LgaOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResidentialStateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResidentialLGADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResidentialAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OccupationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisabledDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
