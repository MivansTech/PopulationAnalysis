<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalGovt
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
        Me.lblClose = New System.Windows.Forms.LinkLabel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtLGAName = New System.Windows.Forms.TextBox()
        Me.LGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PASDataSet = New PopulationSystem.PASDataSet()
        Me.dtpDateRegistered = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtzone = New System.Windows.Forms.TextBox()
        Me.lblDateRegistered = New System.Windows.Forms.Label()
        Me.lblNoOfStaff = New System.Windows.Forms.Label()
        Me.lblDeptHead = New System.Windows.Forms.Label()
        Me.lblDepartmentName = New System.Windows.Forms.Label()
        Me.lblLGAConsole = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.LGATableAdapter = New PopulationSystem.PASDataSetTableAdapters.LGATableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LGAIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LGANameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateregisteredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.LGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.txtSearch.Location = New System.Drawing.Point(50, 352)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 22)
        Me.txtSearch.TabIndex = 23
        '
        'txtLGAName
        '
        Me.txtLGAName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LGABindingSource, "LGA_Name", True))
        Me.txtLGAName.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLGAName.Location = New System.Drawing.Point(269, 144)
        Me.txtLGAName.Name = "txtLGAName"
        Me.txtLGAName.Size = New System.Drawing.Size(200, 22)
        Me.txtLGAName.TabIndex = 12
        '
        'LGABindingSource
        '
        Me.LGABindingSource.DataMember = "LGA"
        Me.LGABindingSource.DataSource = Me.PASDataSet
        '
        'PASDataSet
        '
        Me.PASDataSet.DataSetName = "PASDataSet"
        Me.PASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpDateRegistered
        '
        Me.dtpDateRegistered.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LGABindingSource, "Date_registered", True))
        Me.dtpDateRegistered.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateRegistered.Location = New System.Drawing.Point(269, 288)
        Me.dtpDateRegistered.Name = "dtpDateRegistered"
        Me.dtpDateRegistered.Size = New System.Drawing.Size(200, 22)
        Me.dtpDateRegistered.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblClose)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnCreate)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(681, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 403)
        Me.Panel1.TabIndex = 21
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.PopulationSystem.My.Resources.Resources.orange_bullet
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(148, 352)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(42, 22)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSearch.UseVisualStyleBackColor = True
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
        Me.btnCreate.Text = "Create L.G.A"
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
        'txtzone
        '
        Me.txtzone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LGABindingSource, "zone", True))
        Me.txtzone.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtzone.Location = New System.Drawing.Point(269, 195)
        Me.txtzone.Name = "txtzone"
        Me.txtzone.Size = New System.Drawing.Size(200, 22)
        Me.txtzone.TabIndex = 14
        '
        'lblDateRegistered
        '
        Me.lblDateRegistered.AutoSize = True
        Me.lblDateRegistered.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateRegistered.ForeColor = System.Drawing.Color.Teal
        Me.lblDateRegistered.Location = New System.Drawing.Point(266, 272)
        Me.lblDateRegistered.Name = "lblDateRegistered"
        Me.lblDateRegistered.Size = New System.Drawing.Size(134, 15)
        Me.lblDateRegistered.TabIndex = 20
        Me.lblDateRegistered.Text = "Date of Registration"
        '
        'lblNoOfStaff
        '
        Me.lblNoOfStaff.AutoSize = True
        Me.lblNoOfStaff.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfStaff.ForeColor = System.Drawing.Color.Teal
        Me.lblNoOfStaff.Location = New System.Drawing.Point(266, 227)
        Me.lblNoOfStaff.Name = "lblNoOfStaff"
        Me.lblNoOfStaff.Size = New System.Drawing.Size(38, 15)
        Me.lblNoOfStaff.TabIndex = 19
        Me.lblNoOfStaff.Text = "State"
        '
        'lblDeptHead
        '
        Me.lblDeptHead.AutoSize = True
        Me.lblDeptHead.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptHead.ForeColor = System.Drawing.Color.Teal
        Me.lblDeptHead.Location = New System.Drawing.Point(266, 179)
        Me.lblDeptHead.Name = "lblDeptHead"
        Me.lblDeptHead.Size = New System.Drawing.Size(75, 15)
        Me.lblDeptHead.TabIndex = 17
        Me.lblDeptHead.Text = "L.G.A Zone"
        '
        'lblDepartmentName
        '
        Me.lblDepartmentName.AutoSize = True
        Me.lblDepartmentName.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartmentName.ForeColor = System.Drawing.Color.Teal
        Me.lblDepartmentName.Location = New System.Drawing.Point(266, 128)
        Me.lblDepartmentName.Name = "lblDepartmentName"
        Me.lblDepartmentName.Size = New System.Drawing.Size(79, 15)
        Me.lblDepartmentName.TabIndex = 15
        Me.lblDepartmentName.Text = "L.G.A Name"
        '
        'lblLGAConsole
        '
        Me.lblLGAConsole.AutoSize = True
        Me.lblLGAConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLGAConsole.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLGAConsole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLGAConsole.Location = New System.Drawing.Point(187, 9)
        Me.lblLGAConsole.Name = "lblLGAConsole"
        Me.lblLGAConsole.Size = New System.Drawing.Size(366, 24)
        Me.lblLGAConsole.TabIndex = 13
        Me.lblLGAConsole.Text = "Local Government Area Console"
        '
        'cboState
        '
        Me.cboState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LGABindingSource, "State", True))
        Me.cboState.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"Adamawa"})
        Me.cboState.Location = New System.Drawing.Point(269, 242)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(200, 23)
        Me.cboState.TabIndex = 24
        '
        'LGATableAdapter
        '
        Me.LGATableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LGAIDDataGridViewTextBoxColumn, Me.LGANameDataGridViewTextBoxColumn, Me.ZoneDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.DateregisteredDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LGABindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 321)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(681, 82)
        Me.DataGridView1.TabIndex = 25
        '
        'LGAIDDataGridViewTextBoxColumn
        '
        Me.LGAIDDataGridViewTextBoxColumn.DataPropertyName = "LGA_ID"
        Me.LGAIDDataGridViewTextBoxColumn.HeaderText = "LGA_ID"
        Me.LGAIDDataGridViewTextBoxColumn.Name = "LGAIDDataGridViewTextBoxColumn"
        '
        'LGANameDataGridViewTextBoxColumn
        '
        Me.LGANameDataGridViewTextBoxColumn.DataPropertyName = "LGA_Name"
        Me.LGANameDataGridViewTextBoxColumn.HeaderText = "LGA_Name"
        Me.LGANameDataGridViewTextBoxColumn.Name = "LGANameDataGridViewTextBoxColumn"
        '
        'ZoneDataGridViewTextBoxColumn
        '
        Me.ZoneDataGridViewTextBoxColumn.DataPropertyName = "zone"
        Me.ZoneDataGridViewTextBoxColumn.HeaderText = "zone"
        Me.ZoneDataGridViewTextBoxColumn.Name = "ZoneDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'DateregisteredDataGridViewTextBoxColumn
        '
        Me.DateregisteredDataGridViewTextBoxColumn.DataPropertyName = "Date_registered"
        Me.DateregisteredDataGridViewTextBoxColumn.HeaderText = "Date_registered"
        Me.DateregisteredDataGridViewTextBoxColumn.Name = "DateregisteredDataGridViewTextBoxColumn"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmLocalGovt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(881, 403)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.txtLGAName)
        Me.Controls.Add(Me.dtpDateRegistered)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtzone)
        Me.Controls.Add(Me.lblDateRegistered)
        Me.Controls.Add(Me.lblNoOfStaff)
        Me.Controls.Add(Me.lblDeptHead)
        Me.Controls.Add(Me.lblDepartmentName)
        Me.Controls.Add(Me.lblLGAConsole)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLocalGovt"
        Me.Text = "frmLocalGovt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtLGAName As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateRegistered As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtzone As System.Windows.Forms.TextBox
    Friend WithEvents lblDateRegistered As System.Windows.Forms.Label
    Friend WithEvents lblNoOfStaff As System.Windows.Forms.Label
    Friend WithEvents lblDeptHead As System.Windows.Forms.Label
    Friend WithEvents lblDepartmentName As System.Windows.Forms.Label
    Friend WithEvents lblLGAConsole As System.Windows.Forms.Label
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents PASDataSet As PopulationSystem.PASDataSet
    Friend WithEvents LGABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LGATableAdapter As PopulationSystem.PASDataSetTableAdapters.LGATableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LGAIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LGANameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateregisteredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
