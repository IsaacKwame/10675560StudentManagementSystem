Imports System.Data.SqlClient
Public Class login
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please make an input in all fields.", MsgBoxStyle.Critical)
        Else
            qry = "select * from Login where Username ='" & txtUsername.Text & "' and Password='" & txtPassword.Text & "'"
            connection_open()
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("Login Successfull", MsgBoxStyle.Information, "Login Form")
                Me.Hide()
                connection_close()
                Welcome.Show()
            Else
                MsgBox("Invalid Username/Password", MsgBoxStyle.Critical, "Login Failure")
                connection_close()
            End If


        End If
    End Sub



    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class