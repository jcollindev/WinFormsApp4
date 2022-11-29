Imports System.Data.OleDb
Public Class logins
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP\OneDrive\Desktop\loginss\Database2.accdb")
    Dim dr As OleDbDataReader


    Private Sub logins_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM Table1 WHERE username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "' ", conn)
            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
                Form1.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect password or username")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class