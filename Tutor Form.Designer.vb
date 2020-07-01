<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tutor_Form
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbTID = New System.Windows.Forms.ComboBox()
        Me.cmbTFname = New System.Windows.Forms.ComboBox()
        Me.cmbTMname = New System.Windows.Forms.ComboBox()
        Me.cmbTLname = New System.Windows.Forms.ComboBox()
        Me.cmbCID = New System.Windows.Forms.ComboBox()
        Me.cmbCCID = New System.Windows.Forms.ComboBox()
        Me.cmbCname = New System.Windows.Forms.ComboBox()
        Me.cmbTTID = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(798, 419)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(790, 393)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tutor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(790, 393)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Courses"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCID)
        Me.GroupBox1.Controls.Add(Me.cmbTLname)
        Me.GroupBox1.Controls.Add(Me.cmbTMname)
        Me.GroupBox1.Controls.Add(Me.cmbTFname)
        Me.GroupBox1.Controls.Add(Me.cmbTID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(116, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 249)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tutor Info"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tutor ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Course ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Course ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbTTID)
        Me.GroupBox2.Controls.Add(Me.cmbCname)
        Me.GroupBox2.Controls.Add(Me.cmbCCID)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(184, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 195)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Courses"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Course Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Tutor ID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.NewToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'cmbTID
        '
        Me.cmbTID.FormattingEnabled = True
        Me.cmbTID.Location = New System.Drawing.Point(184, 38)
        Me.cmbTID.Name = "cmbTID"
        Me.cmbTID.Size = New System.Drawing.Size(290, 21)
        Me.cmbTID.TabIndex = 2
        '
        'cmbTFname
        '
        Me.cmbTFname.FormattingEnabled = True
        Me.cmbTFname.Location = New System.Drawing.Point(184, 77)
        Me.cmbTFname.Name = "cmbTFname"
        Me.cmbTFname.Size = New System.Drawing.Size(290, 21)
        Me.cmbTFname.TabIndex = 2
        '
        'cmbTMname
        '
        Me.cmbTMname.FormattingEnabled = True
        Me.cmbTMname.Location = New System.Drawing.Point(184, 122)
        Me.cmbTMname.Name = "cmbTMname"
        Me.cmbTMname.Size = New System.Drawing.Size(290, 21)
        Me.cmbTMname.TabIndex = 2
        '
        'cmbTLname
        '
        Me.cmbTLname.FormattingEnabled = True
        Me.cmbTLname.Location = New System.Drawing.Point(184, 163)
        Me.cmbTLname.Name = "cmbTLname"
        Me.cmbTLname.Size = New System.Drawing.Size(290, 21)
        Me.cmbTLname.TabIndex = 2
        '
        'cmbCID
        '
        Me.cmbCID.FormattingEnabled = True
        Me.cmbCID.Location = New System.Drawing.Point(184, 203)
        Me.cmbCID.Name = "cmbCID"
        Me.cmbCID.Size = New System.Drawing.Size(290, 21)
        Me.cmbCID.TabIndex = 2
        '
        'cmbCCID
        '
        Me.cmbCCID.FormattingEnabled = True
        Me.cmbCCID.Location = New System.Drawing.Point(144, 44)
        Me.cmbCCID.Name = "cmbCCID"
        Me.cmbCCID.Size = New System.Drawing.Size(254, 21)
        Me.cmbCCID.TabIndex = 2
        '
        'cmbCname
        '
        Me.cmbCname.FormattingEnabled = True
        Me.cmbCname.Location = New System.Drawing.Point(144, 85)
        Me.cmbCname.Name = "cmbCname"
        Me.cmbCname.Size = New System.Drawing.Size(254, 21)
        Me.cmbCname.TabIndex = 2
        '
        'cmbTTID
        '
        Me.cmbTTID.FormattingEnabled = True
        Me.cmbTTID.Location = New System.Drawing.Point(144, 128)
        Me.cmbTTID.Name = "cmbTTID"
        Me.cmbTTID.Size = New System.Drawing.Size(254, 21)
        Me.cmbTTID.TabIndex = 2
        '
        'Tutor_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Tutor_Form"
        Me.Text = "Tutor_Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbCID As ComboBox
    Friend WithEvents cmbTLname As ComboBox
    Friend WithEvents cmbTMname As ComboBox
    Friend WithEvents cmbTFname As ComboBox
    Friend WithEvents cmbTID As ComboBox
    Friend WithEvents cmbTTID As ComboBox
    Friend WithEvents cmbCname As ComboBox
    Friend WithEvents cmbCCID As ComboBox
End Class
