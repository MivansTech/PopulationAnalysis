﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartment
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
        Me.lblDeptConsole = New System.Windows.Forms.Label()
        Me.lblDepartmentName = New System.Windows.Forms.Label()
        Me.lblDeptHead = New System.Windows.Forms.Label()
        Me.lblNoOfStaff = New System.Windows.Forms.Label()
        Me.lblDateRegistered = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblClose = New System.Windows.Forms.LinkLabel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtDeptName = New System.Windows.Forms.TextBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PASDataSet = New PopulationSystem.PASDataSet()
        Me.txtHOD = New System.Windows.Forms.TextBox()
        Me.txtNoStaff = New System.Windows.Forms.TextBox()
        Me.dtpDateRegistered = New System.Windows.Forms.DateTimePicker()
        Me.DepartmentTableAdapter = New PopulationSystem.PASDataSetTableAdapters.DepartmentTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DeptIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoStaffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateregisteredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDeptConsole
        '
        Me.lblDeptConsole.AutoSize = True
        Me.lblDeptConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDeptConsole.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptConsole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDeptConsole.Location = New System.Drawing.Point(262, 30)
        Me.lblDeptConsole.Name = "lblDeptConsole"
        Me.lblDeptConsole.Size = New System.Drawing.Size(238, 24)
        Me.lblDeptConsole.TabIndex = 0
        Me.lblDeptConsole.Text = "Department Console"
        '
        'lblDepartmentName
        '
        Me.lblDepartmentName.AutoSize = True
        Me.lblDepartmentName.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartmentName.Location = New System.Drawing.Point(276, 129)
        Me.lblDepartmentName.Name = "lblDepartmentName"
        Me.lblDepartmentName.Size = New System.Drawing.Size(121, 15)
        Me.lblDepartmentName.TabIndex = 1
        Me.lblDepartmentName.Text = "Department Name"
        '
        'lblDeptHead
        '
        Me.lblDeptHead.AutoSize = True
        Me.lblDeptHead.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptHead.Location = New System.Drawing.Point(276, 180)
        Me.lblDeptHead.Name = "lblDeptHead"
        Me.lblDeptHead.Size = New System.Drawing.Size(135, 15)
        Me.lblDeptHead.TabIndex = 2
        Me.lblDeptHead.Text = "Head of Department"
        '
        'lblNoOfStaff
        '
        Me.lblNoOfStaff.AutoSize = True
        Me.lblNoOfStaff.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfStaff.Location = New System.Drawing.Point(276, 228)
        Me.lblNoOfStaff.Name = "lblNoOfStaff"
        Me.lblNoOfStaff.Size = New System.Drawing.Size(78, 15)
        Me.lblNoOfStaff.TabIndex = 3
        Me.lblNoOfStaff.Text = "No. of Staff"
        '
        'lblDateRegistered
        '
        Me.lblDateRegistered.AutoSize = True
        Me.lblDateRegistered.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateRegistered.Location = New System.Drawing.Point(276, 273)
        Me.lblDateRegistered.Name = "lblDateRegistered"
        Me.lblDateRegistered.Size = New System.Drawing.Size(134, 15)
        Me.lblDateRegistered.TabIndex = 4
        Me.lblDateRegistered.Text = "Date of Registration"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.lblClose)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnCreate)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(600, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 700)
        Me.Panel1.TabIndex = 5
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(25, 361)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 22)
        Me.txtSearch.TabIndex = 11
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
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.PopulationSystem.My.Resources.Resources.orange_bullet
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(129, 361)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(42, 22)
        Me.btnSearch.TabIndex = 10
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
        Me.btnUpdate.TabStop = False
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
        Me.Button4.TabStop = False
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
        Me.btnCreate.Location = New System.Drawing.Point(6, 50)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(194, 73)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.TabStop = False
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
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtDeptName
        '
        Me.txtDeptName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartmentBindingSource, "Dept_Name", True))
        Me.txtDeptName.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeptName.Location = New System.Drawing.Point(279, 145)
        Me.txtDeptName.Name = "txtDeptName"
        Me.txtDeptName.Size = New System.Drawing.Size(200, 22)
        Me.txtDeptName.TabIndex = 0
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.PASDataSet
        '
        'PASDataSet
        '
        Me.PASDataSet.DataSetName = "PASDataSet"
        Me.PASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtHOD
        '
        Me.txtHOD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartmentBindingSource, "HOD", True))
        Me.txtHOD.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHOD.Location = New System.Drawing.Point(279, 196)
        Me.txtHOD.Name = "txtHOD"
        Me.txtHOD.Size = New System.Drawing.Size(200, 22)
        Me.txtHOD.TabIndex = 1
        '
        'txtNoStaff
        '
        Me.txtNoStaff.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartmentBindingSource, "No_Staff", True))
        Me.txtNoStaff.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoStaff.Location = New System.Drawing.Point(279, 244)
        Me.txtNoStaff.Name = "txtNoStaff"
        Me.txtNoStaff.Size = New System.Drawing.Size(200, 22)
        Me.txtNoStaff.TabIndex = 2
        '
        'dtpDateRegistered
        '
        Me.dtpDateRegistered.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartmentBindingSource, "Date_registered", True))
        Me.dtpDateRegistered.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateRegistered.Location = New System.Drawing.Point(279, 289)
        Me.dtpDateRegistered.Name = "dtpDateRegistered"
        Me.dtpDateRegistered.Size = New System.Drawing.Size(200, 22)
        Me.dtpDateRegistered.TabIndex = 3
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeptIDDataGridViewTextBoxColumn, Me.DeptNameDataGridViewTextBoxColumn, Me.HODDataGridViewTextBoxColumn, Me.NoStaffDataGridViewTextBoxColumn, Me.DateregisteredDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DepartmentBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 550)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(600, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'DeptIDDataGridViewTextBoxColumn
        '
        Me.DeptIDDataGridViewTextBoxColumn.DataPropertyName = "Dept_ID"
        Me.DeptIDDataGridViewTextBoxColumn.HeaderText = "Dept_ID"
        Me.DeptIDDataGridViewTextBoxColumn.Name = "DeptIDDataGridViewTextBoxColumn"
        '
        'DeptNameDataGridViewTextBoxColumn
        '
        Me.DeptNameDataGridViewTextBoxColumn.DataPropertyName = "Dept_Name"
        Me.DeptNameDataGridViewTextBoxColumn.HeaderText = "Dept_Name"
        Me.DeptNameDataGridViewTextBoxColumn.Name = "DeptNameDataGridViewTextBoxColumn"
        '
        'HODDataGridViewTextBoxColumn
        '
        Me.HODDataGridViewTextBoxColumn.DataPropertyName = "HOD"
        Me.HODDataGridViewTextBoxColumn.HeaderText = "HOD"
        Me.HODDataGridViewTextBoxColumn.Name = "HODDataGridViewTextBoxColumn"
        '
        'NoStaffDataGridViewTextBoxColumn
        '
        Me.NoStaffDataGridViewTextBoxColumn.DataPropertyName = "No_Staff"
        Me.NoStaffDataGridViewTextBoxColumn.HeaderText = "No_Staff"
        Me.NoStaffDataGridViewTextBoxColumn.Name = "NoStaffDataGridViewTextBoxColumn"
        '
        'DateregisteredDataGridViewTextBoxColumn
        '
        Me.DateregisteredDataGridViewTextBoxColumn.DataPropertyName = "Date_registered"
        Me.DateregisteredDataGridViewTextBoxColumn.HeaderText = "Date_registered"
        Me.DateregisteredDataGridViewTextBoxColumn.Name = "DateregisteredDataGridViewTextBoxColumn"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'frmDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 700)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtDeptName)
        Me.Controls.Add(Me.dtpDateRegistered)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtHOD)
        Me.Controls.Add(Me.txtNoStaff)
        Me.Controls.Add(Me.lblDateRegistered)
        Me.Controls.Add(Me.lblNoOfStaff)
        Me.Controls.Add(Me.lblDeptHead)
        Me.Controls.Add(Me.lblDepartmentName)
        Me.Controls.Add(Me.lblDeptConsole)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Teal
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(800, 700)
        Me.Name = "frmDepartment"
        Me.Opacity = 0.7R
        Me.Text = "Department"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDeptConsole As System.Windows.Forms.Label
    Friend WithEvents lblDepartmentName As System.Windows.Forms.Label
    Friend WithEvents lblDeptHead As System.Windows.Forms.Label
    Friend WithEvents lblNoOfStaff As System.Windows.Forms.Label
    Friend WithEvents lblDateRegistered As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDeptName As System.Windows.Forms.TextBox
    Friend WithEvents txtHOD As System.Windows.Forms.TextBox
    Friend WithEvents txtNoStaff As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateRegistered As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents PASDataSet As PopulationSystem.PASDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As PopulationSystem.PASDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DeptIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoStaffDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateregisteredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
