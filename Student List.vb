Public Class Student_List
    Private Sub Student_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_Management_SystemDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Student_Management_SystemDataSet.Student)


    End Sub


    Private Sub PrintListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintListToolStripMenuItem.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.StudentTableAdapter.Update(Me.Student_Management_SystemDataSet.Student)
    End Sub

    Private Sub AddNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStudentToolStripMenuItem.Click
        Student_Details.Show()
    End Sub

    Private Sub AllStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllStudentsToolStripMenuItem.Click

    End Sub
End Class