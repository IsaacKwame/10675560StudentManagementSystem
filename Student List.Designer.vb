<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_List
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidenceStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HallOfResidenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_Management_SystemDataSet = New _10675560StudentManagementSystem.Student_Management_SystemDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsByClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsByResidentialStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentTableAdapter = New _10675560StudentManagementSystem.Student_Management_SystemDataSetTableAdapters.StudentTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.ResidenceStatusDataGridViewTextBoxColumn, Me.HallOfResidenceDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.MobileNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.Location = New System.Drawing.Point(0, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(840, 423)
        Me.DataGridView1.TabIndex = 0
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'ResidenceStatusDataGridViewTextBoxColumn
        '
        Me.ResidenceStatusDataGridViewTextBoxColumn.DataPropertyName = "Residence Status"
        Me.ResidenceStatusDataGridViewTextBoxColumn.HeaderText = "Residence Status"
        Me.ResidenceStatusDataGridViewTextBoxColumn.Name = "ResidenceStatusDataGridViewTextBoxColumn"
        '
        'HallOfResidenceDataGridViewTextBoxColumn
        '
        Me.HallOfResidenceDataGridViewTextBoxColumn.DataPropertyName = "Hall of Residence"
        Me.HallOfResidenceDataGridViewTextBoxColumn.HeaderText = "Hall of Residence"
        Me.HallOfResidenceDataGridViewTextBoxColumn.Name = "HallOfResidenceDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'MobileNumberDataGridViewTextBoxColumn
        '
        Me.MobileNumberDataGridViewTextBoxColumn.DataPropertyName = "mobileNumber"
        Me.MobileNumberDataGridViewTextBoxColumn.HeaderText = "mobileNumber"
        Me.MobileNumberDataGridViewTextBoxColumn.Name = "MobileNumberDataGridViewTextBoxColumn"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Student_Management_SystemDataSet
        '
        'Student_Management_SystemDataSet
        '
        Me.Student_Management_SystemDataSet.DataSetName = "Student_Management_SystemDataSet"
        Me.Student_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(841, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewStudentToolStripMenuItem, Me.PrintListToolStripMenuItem})
        Me.EditToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "File"
        '
        'AddNewStudentToolStripMenuItem
        '
        Me.AddNewStudentToolStripMenuItem.Name = "AddNewStudentToolStripMenuItem"
        Me.AddNewStudentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewStudentToolStripMenuItem.Text = "Add New Student"
        '
        'PrintListToolStripMenuItem
        '
        Me.PrintListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllStudentsToolStripMenuItem, Me.StudentsByClassToolStripMenuItem, Me.StudentsByResidentialStatusToolStripMenuItem})
        Me.PrintListToolStripMenuItem.Name = "PrintListToolStripMenuItem"
        Me.PrintListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintListToolStripMenuItem.Text = "Reports"
        '
        'AllStudentsToolStripMenuItem
        '
        Me.AllStudentsToolStripMenuItem.Name = "AllStudentsToolStripMenuItem"
        Me.AllStudentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AllStudentsToolStripMenuItem.Text = "All Students"
        '
        'StudentsByClassToolStripMenuItem
        '
        Me.StudentsByClassToolStripMenuItem.Name = "StudentsByClassToolStripMenuItem"
        Me.StudentsByClassToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StudentsByClassToolStripMenuItem.Text = "Students by Class"
        '
        'StudentsByResidentialStatusToolStripMenuItem
        '
        Me.StudentsByResidentialStatusToolStripMenuItem.Name = "StudentsByResidentialStatusToolStripMenuItem"
        Me.StudentsByResidentialStatusToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StudentsByResidentialStatusToolStripMenuItem.Text = "Students by Hostel"
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(765, 1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Student_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 450)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Student_List"
        Me.Text = "Student_List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Student_Management_SystemDataSet As Student_Management_SystemDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As Student_Management_SystemDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResidenceStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HallOfResidenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobileNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllStudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentsByClassToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentsByResidentialStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSave As Button
End Class
