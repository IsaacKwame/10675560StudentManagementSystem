<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Details
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbSRstatus = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSDob = New System.Windows.Forms.DateTimePicker()
        Me.txtSLname = New System.Windows.Forms.TextBox()
        Me.txtSMname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSFname = New System.Windows.Forms.TextBox()
        Me.txtStuID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSEcontact = New System.Windows.Forms.TextBox()
        Me.txtSPemail = New System.Windows.Forms.TextBox()
        Me.txtSemail = New System.Windows.Forms.TextBox()
        Me.txtSMnum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditPicture = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSClass = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnGcancel = New System.Windows.Forms.Button()
        Me.btnGSave = New System.Windows.Forms.Button()
        Me.txtGemail = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtGMnum = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtGocc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtGLname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtGMname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtGFname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RepIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_Management_SystemDataSet = New _10675560StudentManagementSystem.Student_Management_SystemDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportTableAdapter = New _10675560StudentManagementSystem.Student_Management_SystemDataSetTableAdapters.ReportTableAdapter()
        Me.GuardianTableAdapter1 = New _10675560StudentManagementSystem.Student_Management_SystemDataSetTableAdapters.GuardianTableAdapter()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbTTID = New System.Windows.Forms.ComboBox()
        Me.cmbCname = New System.Windows.Forms.ComboBox()
        Me.cmbCCID = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(-3, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1143, 459)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.cmbSRstatus)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnEditPicture)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.txtSClass)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1135, 433)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(810, 357)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(676, 357)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmbSRstatus
        '
        Me.cmbSRstatus.FormattingEnabled = True
        Me.cmbSRstatus.Items.AddRange(New Object() {"Boarder", "Day Student"})
        Me.cmbSRstatus.Location = New System.Drawing.Point(299, 249)
        Me.cmbSRstatus.Name = "cmbSRstatus"
        Me.cmbSRstatus.Size = New System.Drawing.Size(227, 21)
        Me.cmbSRstatus.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(225, 284)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Class"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(207, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Residential Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSDob)
        Me.GroupBox2.Controls.Add(Me.txtSLname)
        Me.GroupBox2.Controls.Add(Me.txtSMname)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtSFname)
        Me.GroupBox2.Controls.Add(Me.txtStuID)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(228, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 167)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bio"
        '
        'txtSDob
        '
        Me.txtSDob.Location = New System.Drawing.Point(89, 136)
        Me.txtSDob.Name = "txtSDob"
        Me.txtSDob.Size = New System.Drawing.Size(200, 20)
        Me.txtSDob.TabIndex = 2
        '
        'txtSLname
        '
        Me.txtSLname.Location = New System.Drawing.Point(89, 106)
        Me.txtSLname.Name = "txtSLname"
        Me.txtSLname.Size = New System.Drawing.Size(200, 20)
        Me.txtSLname.TabIndex = 1
        '
        'txtSMname
        '
        Me.txtSMname.Location = New System.Drawing.Point(89, 80)
        Me.txtSMname.Name = "txtSMname"
        Me.txtSMname.Size = New System.Drawing.Size(200, 20)
        Me.txtSMname.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Date of Birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Last Name"
        '
        'txtSFname
        '
        Me.txtSFname.Location = New System.Drawing.Point(89, 54)
        Me.txtSFname.Name = "txtSFname"
        Me.txtSFname.Size = New System.Drawing.Size(200, 20)
        Me.txtSFname.TabIndex = 1
        '
        'txtStuID
        '
        Me.txtStuID.Location = New System.Drawing.Point(89, 25)
        Me.txtStuID.Name = "txtStuID"
        Me.txtStuID.Size = New System.Drawing.Size(227, 20)
        Me.txtStuID.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Middle Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Student ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSEcontact)
        Me.GroupBox1.Controls.Add(Me.txtSPemail)
        Me.GroupBox1.Controls.Add(Me.txtSemail)
        Me.GroupBox1.Controls.Add(Me.txtSMnum)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(676, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 178)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Information"
        '
        'txtSEcontact
        '
        Me.txtSEcontact.Location = New System.Drawing.Point(134, 135)
        Me.txtSEcontact.Name = "txtSEcontact"
        Me.txtSEcontact.Size = New System.Drawing.Size(163, 20)
        Me.txtSEcontact.TabIndex = 1
        '
        'txtSPemail
        '
        Me.txtSPemail.Location = New System.Drawing.Point(134, 100)
        Me.txtSPemail.Name = "txtSPemail"
        Me.txtSPemail.Size = New System.Drawing.Size(163, 20)
        Me.txtSPemail.TabIndex = 1
        '
        'txtSemail
        '
        Me.txtSemail.Location = New System.Drawing.Point(134, 61)
        Me.txtSemail.Name = "txtSemail"
        Me.txtSemail.Size = New System.Drawing.Size(163, 20)
        Me.txtSemail.TabIndex = 1
        '
        'txtSMnum
        '
        Me.txtSMnum.Location = New System.Drawing.Point(134, 29)
        Me.txtSMnum.Name = "txtSMnum"
        Me.txtSMnum.Size = New System.Drawing.Size(163, 20)
        Me.txtSMnum.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Emergency Contact"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Personal Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "School Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mobile Number"
        '
        'btnEditPicture
        '
        Me.btnEditPicture.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditPicture.ForeColor = System.Drawing.Color.White
        Me.btnEditPicture.Location = New System.Drawing.Point(11, 244)
        Me.btnEditPicture.Name = "btnEditPicture"
        Me.btnEditPicture.Size = New System.Drawing.Size(150, 23)
        Me.btnEditPicture.TabIndex = 1
        Me.btnEditPicture.Text = "Edit Picture"
        Me.btnEditPicture.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(11, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtSClass
        '
        Me.txtSClass.Location = New System.Drawing.Point(299, 277)
        Me.txtSClass.Name = "txtSClass"
        Me.txtSClass.Size = New System.Drawing.Size(227, 20)
        Me.txtSClass.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnGcancel)
        Me.TabPage2.Controls.Add(Me.btnGSave)
        Me.TabPage2.Controls.Add(Me.txtGemail)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.txtGMnum)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtGocc)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtGLname)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txtGMname)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtGFname)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1135, 433)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Guardian Info"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnGcancel
        '
        Me.btnGcancel.Location = New System.Drawing.Point(215, 297)
        Me.btnGcancel.Name = "btnGcancel"
        Me.btnGcancel.Size = New System.Drawing.Size(75, 23)
        Me.btnGcancel.TabIndex = 3
        Me.btnGcancel.Text = "Cancel"
        Me.btnGcancel.UseVisualStyleBackColor = True
        '
        'btnGSave
        '
        Me.btnGSave.Location = New System.Drawing.Point(105, 297)
        Me.btnGSave.Name = "btnGSave"
        Me.btnGSave.Size = New System.Drawing.Size(75, 23)
        Me.btnGSave.TabIndex = 2
        Me.btnGSave.Text = "Save"
        Me.btnGSave.UseVisualStyleBackColor = True
        '
        'txtGemail
        '
        Me.txtGemail.Location = New System.Drawing.Point(105, 229)
        Me.txtGemail.Name = "txtGemail"
        Me.txtGemail.Size = New System.Drawing.Size(185, 20)
        Me.txtGemail.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 236)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Email"
        '
        'txtGMnum
        '
        Me.txtGMnum.Location = New System.Drawing.Point(105, 191)
        Me.txtGMnum.Name = "txtGMnum"
        Me.txtGMnum.Size = New System.Drawing.Size(185, 20)
        Me.txtGMnum.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Mobile Number"
        '
        'txtGocc
        '
        Me.txtGocc.Location = New System.Drawing.Point(105, 154)
        Me.txtGocc.Name = "txtGocc"
        Me.txtGocc.Size = New System.Drawing.Size(185, 20)
        Me.txtGocc.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Occupation"
        '
        'txtGLname
        '
        Me.txtGLname.Location = New System.Drawing.Point(105, 111)
        Me.txtGLname.Name = "txtGLname"
        Me.txtGLname.Size = New System.Drawing.Size(185, 20)
        Me.txtGLname.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Last Name"
        '
        'txtGMname
        '
        Me.txtGMname.Location = New System.Drawing.Point(105, 70)
        Me.txtGMname.Name = "txtGMname"
        Me.txtGMname.Size = New System.Drawing.Size(185, 20)
        Me.txtGMname.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Middle Name"
        '
        'txtGFname
        '
        Me.txtGFname.Location = New System.Drawing.Point(105, 30)
        Me.txtGFname.Name = "txtGFname"
        Me.txtGFname.Size = New System.Drawing.Size(185, 20)
        Me.txtGFname.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "First Name"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1135, 433)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Report Card"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepIDDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.CourseIDDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReportBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1135, 433)
        Me.DataGridView1.TabIndex = 0
        '
        'RepIDDataGridViewTextBoxColumn
        '
        Me.RepIDDataGridViewTextBoxColumn.DataPropertyName = "repID"
        Me.RepIDDataGridViewTextBoxColumn.HeaderText = "repID"
        Me.RepIDDataGridViewTextBoxColumn.Name = "RepIDDataGridViewTextBoxColumn"
        Me.RepIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "studentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'CourseIDDataGridViewTextBoxColumn
        '
        Me.CourseIDDataGridViewTextBoxColumn.DataPropertyName = "courseID"
        Me.CourseIDDataGridViewTextBoxColumn.HeaderText = "courseID"
        Me.CourseIDDataGridViewTextBoxColumn.Name = "CourseIDDataGridViewTextBoxColumn"
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        '
        'ReportBindingSource
        '
        Me.ReportBindingSource.DataMember = "Report"
        Me.ReportBindingSource.DataSource = Me.Student_Management_SystemDataSet
        '
        'Student_Management_SystemDataSet
        '
        Me.Student_Management_SystemDataSet.DataSetName = "Student_Management_SystemDataSet"
        Me.Student_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1140, 74)
        Me.Panel1.TabIndex = 1
        '
        'ReportTableAdapter
        '
        Me.ReportTableAdapter.ClearBeforeFill = True
        '
        'GuardianTableAdapter1
        '
        Me.GuardianTableAdapter1.ClearBeforeFill = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1135, 433)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Course Registration"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.cmbTTID)
        Me.GroupBox3.Controls.Add(Me.cmbCname)
        Me.GroupBox3.Controls.Add(Me.cmbCCID)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Location = New System.Drawing.Point(297, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(423, 195)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Courses"
        '
        'cmbTTID
        '
        Me.cmbTTID.FormattingEnabled = True
        Me.cmbTTID.Location = New System.Drawing.Point(144, 128)
        Me.cmbTTID.Name = "cmbTTID"
        Me.cmbTTID.Size = New System.Drawing.Size(254, 21)
        Me.cmbTTID.TabIndex = 2
        '
        'cmbCname
        '
        Me.cmbCname.FormattingEnabled = True
        Me.cmbCname.Location = New System.Drawing.Point(144, 85)
        Me.cmbCname.Name = "cmbCname"
        Me.cmbCname.Size = New System.Drawing.Size(254, 21)
        Me.cmbCname.TabIndex = 2
        '
        'cmbCCID
        '
        Me.cmbCCID.FormattingEnabled = True
        Me.cmbCCID.Location = New System.Drawing.Point(144, 44)
        Me.cmbCCID.Name = "cmbCCID"
        Me.cmbCCID.Size = New System.Drawing.Size(254, 21)
        Me.cmbCCID.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(38, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Tutor ID"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(38, 93)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Course Name"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(38, 52)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Course ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(323, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Student_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 535)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Student_Details"
        Me.Text = "Student_Details"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnEditPicture As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSEcontact As TextBox
    Friend WithEvents txtSPemail As TextBox
    Friend WithEvents txtSemail As TextBox
    Friend WithEvents txtSMnum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSLname As TextBox
    Friend WithEvents txtSMname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSFname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSClass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSDob As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbSRstatus As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStuID As TextBox
    Friend WithEvents txtGemail As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtGMnum As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtGocc As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtGLname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtGMname As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtGFname As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnGcancel As Button
    Friend WithEvents btnGSave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Student_Management_SystemDataSet As Student_Management_SystemDataSet
    Friend WithEvents ReportBindingSource As BindingSource
    Friend WithEvents ReportTableAdapter As Student_Management_SystemDataSetTableAdapters.ReportTableAdapter
    Friend WithEvents RepIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianTableAdapter1 As Student_Management_SystemDataSetTableAdapters.GuardianTableAdapter
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbTTID As ComboBox
    Friend WithEvents cmbCname As ComboBox
    Friend WithEvents cmbCCID As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
End Class
