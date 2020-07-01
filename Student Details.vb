

Public Class Student_Details
    'Student Table data adapter
    Dim studentAdapter As Student_Management_SystemDataSetTableAdapters.StudentTableAdapter = New Student_Management_SystemDataSetTableAdapters.StudentTableAdapter()
    'Student Table dataset
    Dim studentDataset As Student_Management_SystemDataSet = New Student_Management_SystemDataSet()
    'Variable for storing student data collected
    Dim studentRow As Student_Management_SystemDataSet.StudentRow
    'Guardian Table data adapter
    Dim guardianAdapter As Student_Management_SystemDataSetTableAdapters.GuardianTableAdapter = New Student_Management_SystemDataSetTableAdapters.GuardianTableAdapter()
    'Guardian Table dataset
    Dim guardianDataset As Student_Management_SystemDataSet = New Student_Management_SystemDataSet()
    'Variable for storing data collected
    Dim guardianRow As Student_Management_SystemDataSet.GuardianRow

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim fname = txtSFname.Text
            studentRow = studentDataset.Student.NewStudentRow

            'Taking inputs from various textboxes
            studentRow.First_Name = txtSFname.Text
            studentRow.Middle_Name = txtSMname.Text
            studentRow.Middle_Name = txtSMname.Text
            studentRow.Date_of_Birth = txtSDob.Value.Date
            studentRow.Residence_Status = cmbSRstatus.Text
            studentRow._Class = txtSClass.Text
            studentRow.mobileNumber = txtSMnum.Text
            studentRow.schoolEmail = txtSemail.Text
            studentRow.personalEmail = txtSPemail.Text
            studentRow.emergencyContact = txtSEcontact.Text

            'UPDATING THE STUDENT TABLE IN THE DB
            studentDataset.Student.AddStudentRow(studentRow)
            studentAdapter.Update(studentDataset.Student)

            MessageBox.Show(fname & ", you have successfully been registered", "Registration Successful", MessageBoxButtons.OK)

            clearAllFields()

        Catch ex As Exception
            MessageBox.Show("Please verify the correctness of your inputs", ex.Message.ToString)
        End Try

    End Sub

    Private Sub Student_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_Management_SystemDataSet.Report' table. You can move, or remove it, as needed.
        Me.ReportTableAdapter.Fill(Me.Student_Management_SystemDataSet.Report)


    End Sub

    Private Sub clearAllFields()
        txtSClass.Clear()
        txtSEcontact.Clear()
        txtSemail.Clear()
        txtSFname.Clear()
        txtSMname.Clear()
        txtSLname.Clear()
        txtSMnum.Clear()
        txtSPemail.Clear()
        txtStuID.Clear()
        cmbSRstatus.Items.Clear()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop the registration process?", "Student Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            Student_List.Show()

            Me.Close()



        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnGSave_Click(sender As Object, e As EventArgs) Handles btnGSave.Click
        Try
            Dim GFname = txtGFname.Text

            guardianRow = studentDataset.Guardian.NewRow


            'Accepting inputs from the text boxes
            guardianRow.gFirstName = txtGFname.Text
            guardianRow.gMiddleName = txtGMname.Text
            guardianRow.gMiddleName = txtGLname.Text
            guardianRow.gOccupation = txtGocc.Text
            guardianRow.gMobileNumber = txtGMnum.Text
            guardianRow.gEmail = txtGemail.Text

            'Updating the Guardian rable in the db
            guardianDataset.Guardian.AddGuardianRow(guardianRow)
            guardianAdapter.Update(guardianDataset.Guardian)

            'Saving data into database
            MessageBox.Show(GFname & ", has been sucessfully added", "Guardian addition successful", MessageBoxButtons.OK)


        Catch ex As Exception
            MessageBox.Show("Please verify correctness of all inputs", ex.Message.ToString)
        End Try
    End Sub
End Class

