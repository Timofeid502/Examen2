﻿Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, resultado As Double
        a = TextBox1.Text
        b = TextBox2.Text
        resultado = a / b
        TextBox3.Text = resultado
        If TextBox1.Text = 0 Then
            MsgBox("Dejen de chingar")
        ElseIf TextBox2.Text = 0 Then
            TextBox3.Text = "Syntax error"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Hide()
    End Sub
End Class