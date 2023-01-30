Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox2.Text = "Cashier" Then
            Cashier_login.ShowDialog()
        ElseIf ComboBox2.Text = "Manager" Then
            Manager_Login.ShowDialog()
        ElseIf ComboBox2.Text = "Customer" Then
            Customer_Login.ShowDialog()
        Else
            MessageBox.Show("Select Your Occupation")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
