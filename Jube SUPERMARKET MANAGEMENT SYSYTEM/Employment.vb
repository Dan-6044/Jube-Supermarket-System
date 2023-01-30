Imports System.Data.OleDb
Public Class Employment
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danwa\Documents\sale_database.accdb")
    Dim i As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = "INSERT INTO Employee ([FirstName],[LastName],[Occupation]) values ('" & TextBox1.Text & "', '" & TextBox3.Text & "','" & TextBox4.Text & "');"
            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Employee added successfully!")
            Else
                MsgBox("No record has been inserted successfully!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox4.Clear()
        TextBox3.Clear()
    End Sub
End Class