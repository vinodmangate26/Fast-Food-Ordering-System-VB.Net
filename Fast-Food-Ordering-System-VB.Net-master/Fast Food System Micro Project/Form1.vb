Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Username")
        End If

        If (TextBox2.Text = "") Then
            ErrorProvider1.SetError(TextBox2, "Please Enter Password")

        Else

            MsgBox("You are Login Sucessfully")
            Form2.Show()
        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
    End Sub
End Class


