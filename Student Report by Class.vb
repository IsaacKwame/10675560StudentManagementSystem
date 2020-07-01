Public Class Student_Report_by_Class
    Private Sub Student_Report_by_Class_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_Management_SystemDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Student_Management_SystemDataSet.Student)
        'TODO: This line of code loads data into the 'Student_Management_SystemDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Student_Management_SystemDataSet.Student)

    End Sub
End Class