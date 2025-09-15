Public Class Form4
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox1.Text = "") Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Feedback")
        Else
            MsgBox("Thank You for Your Feedback....,Visit Again... Have A Nice Day")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Close()
        Form2.Close()
        Form3.Close()
        Form5.Close()
        Me.Close()
    End Sub
End Class