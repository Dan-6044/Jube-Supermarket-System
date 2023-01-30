Public Class Manager_Login

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
        If TextBox1.Text = "manager" And TextBox2.Text = "manager" Then
            Manager_window.ShowDialog()
        Else
            MessageBox.Show("incorrect username or password")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        create_account.ShowDialog()
    End Sub
End Class