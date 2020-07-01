Public Class Tutor_Form
    'Tutor Data Adapter
    Dim tutorAdapter As Student_Management_SystemDataSetTableAdapters.TutorTableAdapter = New Student_Management_SystemDataSetTableAdapters.TutorTableAdapter()
    'Tutor Table dataset
    Dim tutorDataset = New Student_Management_SystemDataSet()

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class