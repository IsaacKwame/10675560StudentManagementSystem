<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Report_by_Class
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Student_Management_SystemDataSet = New _10675560StudentManagementSystem.Student_Management_SystemDataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New _10675560StudentManagementSystem.Student_Management_SystemDataSetTableAdapters.StudentTableAdapter()
        Me.StudentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(540, 450)
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
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        Me.MiddleNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn1, Me.FirstNameDataGridViewTextBoxColumn1, Me.MiddleNameDataGridViewTextBoxColumn1, Me.LastNameDataGridViewTextBoxColumn1, Me.ClassDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.StudentBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(540, 450)
        Me.DataGridView2.TabIndex = 1
        '
        'Student_Management_SystemDataSet
        '
        Me.Student_Management_SystemDataSet.DataSetName = "Student_Management_SystemDataSet"
        Me.Student_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Student_Management_SystemDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudentIDDataGridViewTextBoxColumn1
        '
        Me.StudentIDDataGridViewTextBoxColumn1.DataPropertyName = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn1.HeaderText = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn1.Name = "StudentIDDataGridViewTextBoxColumn1"
        Me.StudentIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn1
        '
        Me.FirstNameDataGridViewTextBoxColumn1.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn1.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn1.Name = "FirstNameDataGridViewTextBoxColumn1"
        Me.FirstNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'MiddleNameDataGridViewTextBoxColumn1
        '
        Me.MiddleNameDataGridViewTextBoxColumn1.DataPropertyName = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn1.HeaderText = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn1.Name = "MiddleNameDataGridViewTextBoxColumn1"
        Me.MiddleNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn1
        '
        Me.LastNameDataGridViewTextBoxColumn1.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn1.Name = "LastNameDataGridViewTextBoxColumn1"
        Me.LastNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        Me.ClassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Student_Report_by_Class
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 450)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Student_Report_by_Class"
        Me.Text = "Student_Report_by_Class"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Student_Management_SystemDataSet As Student_Management_SystemDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As Student_Management_SystemDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
