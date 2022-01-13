<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIndex))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CencusReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LGAReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoratesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLGA = New System.Windows.Forms.Button()
        Me.btnDepartment = New System.Windows.Forms.Button()
        Me.btnIndividual = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.picAdmin = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tlsDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsDateShow = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsTimeShow = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 123)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(324, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 63)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Adamawa State, Nigeria"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(853, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Yola"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PopulationSystem.My.Resources.Resources.ooo_3491
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(848, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DirectoratesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(948, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateReportToolStripMenuItem, Me.CloseToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'GenerateReportToolStripMenuItem
        '
        Me.GenerateReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffReportToolStripMenuItem, Me.CencusReportToolStripMenuItem, Me.DepartmentReportToolStripMenuItem, Me.LGAReportToolStripMenuItem})
        Me.GenerateReportToolStripMenuItem.Name = "GenerateReportToolStripMenuItem"
        Me.GenerateReportToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GenerateReportToolStripMenuItem.Text = "Generate Report"
        '
        'StaffReportToolStripMenuItem
        '
        Me.StaffReportToolStripMenuItem.Name = "StaffReportToolStripMenuItem"
        Me.StaffReportToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.StaffReportToolStripMenuItem.Text = "Staff Report"
        '
        'CencusReportToolStripMenuItem
        '
        Me.CencusReportToolStripMenuItem.Name = "CencusReportToolStripMenuItem"
        Me.CencusReportToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CencusReportToolStripMenuItem.Text = "Cencus Report"
        '
        'DepartmentReportToolStripMenuItem
        '
        Me.DepartmentReportToolStripMenuItem.Name = "DepartmentReportToolStripMenuItem"
        Me.DepartmentReportToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DepartmentReportToolStripMenuItem.Text = "Department Report"
        '
        'LGAReportToolStripMenuItem
        '
        Me.LGAReportToolStripMenuItem.Name = "LGAReportToolStripMenuItem"
        Me.LGAReportToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LGAReportToolStripMenuItem.Text = "L.G.A Report"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CloseToolStripMenuItem.Text = "Close "
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'DirectoratesToolStripMenuItem
        '
        Me.DirectoratesToolStripMenuItem.Name = "DirectoratesToolStripMenuItem"
        Me.DirectoratesToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DirectoratesToolStripMenuItem.Text = "Directorates"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnLGA)
        Me.Panel2.Controls.Add(Me.btnDepartment)
        Me.Panel2.Controls.Add(Me.btnIndividual)
        Me.Panel2.Controls.Add(Me.btnStaff)
        Me.Panel2.Controls.Add(Me.picAdmin)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 456)
        Me.Panel2.TabIndex = 1
        '
        'btnLGA
        '
        Me.btnLGA.BackColor = System.Drawing.Color.White
        Me.btnLGA.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLGA.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnLGA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnLGA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnLGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLGA.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLGA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLGA.Image = CType(resources.GetObject("btnLGA.Image"), System.Drawing.Image)
        Me.btnLGA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLGA.Location = New System.Drawing.Point(0, 350)
        Me.btnLGA.Name = "btnLGA"
        Me.btnLGA.Size = New System.Drawing.Size(200, 85)
        Me.btnLGA.TabIndex = 6
        Me.btnLGA.Text = "LGA Console"
        Me.btnLGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLGA.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLGA.UseVisualStyleBackColor = False
        '
        'btnDepartment
        '
        Me.btnDepartment.BackColor = System.Drawing.Color.White
        Me.btnDepartment.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDepartment.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepartment.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDepartment.Image = CType(resources.GetObject("btnDepartment.Image"), System.Drawing.Image)
        Me.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDepartment.Location = New System.Drawing.Point(0, 265)
        Me.btnDepartment.Name = "btnDepartment"
        Me.btnDepartment.Size = New System.Drawing.Size(200, 85)
        Me.btnDepartment.TabIndex = 5
        Me.btnDepartment.Text = "Department Console"
        Me.btnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDepartment.UseVisualStyleBackColor = False
        '
        'btnIndividual
        '
        Me.btnIndividual.BackColor = System.Drawing.Color.White
        Me.btnIndividual.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnIndividual.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnIndividual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnIndividual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIndividual.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIndividual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIndividual.Image = CType(resources.GetObject("btnIndividual.Image"), System.Drawing.Image)
        Me.btnIndividual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIndividual.Location = New System.Drawing.Point(0, 180)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(200, 85)
        Me.btnIndividual.TabIndex = 4
        Me.btnIndividual.Text = "Person Register Console"
        Me.btnIndividual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIndividual.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnIndividual.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.White
        Me.btnStaff.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStaff.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaff.Image = CType(resources.GetObject("btnStaff.Image"), System.Drawing.Image)
        Me.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStaff.Location = New System.Drawing.Point(0, 95)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(200, 85)
        Me.btnStaff.TabIndex = 3
        Me.btnStaff.Text = "Staff Console"
        Me.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'picAdmin
        '
        Me.picAdmin.BackColor = System.Drawing.Color.White
        Me.picAdmin.BackgroundImage = Global.PopulationSystem.My.Resources.Resources.hiclipart_com_2_
        Me.picAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.picAdmin.Location = New System.Drawing.Point(0, 0)
        Me.picAdmin.Name = "picAdmin"
        Me.picAdmin.Size = New System.Drawing.Size(200, 57)
        Me.picAdmin.TabIndex = 2
        Me.picAdmin.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'pnlContent
        '
        Me.pnlContent.BackgroundImage = Global.PopulationSystem.My.Resources.Resources.background_images_for_student_registration_form_1
        Me.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlContent.Controls.Add(Me.StatusStrip1)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(200, 123)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(748, 456)
        Me.pnlContent.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsDate, Me.tlsDateShow, Me.tlsTime, Me.tlsTimeShow})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 434)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(748, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tlsDate
        '
        Me.tlsDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlsDate.ForeColor = System.Drawing.Color.Teal
        Me.tlsDate.Name = "tlsDate"
        Me.tlsDate.Size = New System.Drawing.Size(41, 17)
        Me.tlsDate.Text = "Date-"
        '
        'tlsDateShow
        '
        Me.tlsDateShow.Name = "tlsDateShow"
        Me.tlsDateShow.Size = New System.Drawing.Size(31, 17)
        Me.tlsDateShow.Text = "Date"
        '
        'tlsTime
        '
        Me.tlsTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlsTime.ForeColor = System.Drawing.Color.Teal
        Me.tlsTime.Name = "tlsTime"
        Me.tlsTime.Size = New System.Drawing.Size(40, 17)
        Me.tlsTime.Text = "Time-"
        '
        'tlsTimeShow
        '
        Me.tlsTimeShow.Name = "tlsTimeShow"
        Me.tlsTimeShow.Size = New System.Drawing.Size(33, 17)
        Me.tlsTimeShow.Text = "Time"
        '
        'frmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 579)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmIndex"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents picAdmin As System.Windows.Forms.PictureBox
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tlsDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tlsDateShow As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tlsTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tlsTimeShow As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnLGA As System.Windows.Forms.Button
    Friend WithEvents btnDepartment As System.Windows.Forms.Button
    Friend WithEvents btnIndividual As System.Windows.Forms.Button
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CencusReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LGAReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectoratesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
