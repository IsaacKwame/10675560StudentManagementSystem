<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Report_List
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
        Me.Student_Management_SystemDataSet = New _10675560StudentManagementSystem.Student_Management_SystemDataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New _10675560StudentManagementSystem.Student_Management_SystemDataSetTableAdapters.StudentTableAdapter()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidenceStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HallOfResidenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.ResidenceStatusDataGridViewTextBoxColumn, Me.HallOfResidenceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 450)
        Me.DataGridView1.TabIndex = 0
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
        'Student_Report_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Student_Report_List"
        Me.Text = "Student_Report_List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
End Class
