Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "Waldir" And TextBox2.Text = "123" Then
            Form2.Show()
            Hide()

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub
End Class
