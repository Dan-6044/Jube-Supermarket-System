Imports System.Data.OleDb

Public Class Cashier_login
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danwa\Documents\sale_database.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter username")
            TextBox1.Focus()
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Please enter password")
            TextBox2.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            Cashier_window.ShowDialog()
        Else
            MessageBox.Show("incorrect username or password")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'Display plain text if and only if check box is checked.
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        create_account.ShowDialog()
    End Sub

    Private Function cmd() As Object
        Throw New NotImplementedException
    End Function

End Class