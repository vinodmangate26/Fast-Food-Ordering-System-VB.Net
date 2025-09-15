Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "") Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Your Name")
        End If

        If (TextBox2.Text = "") Then
            ErrorProvider1.SetError(TextBox2, "Please Enter Your Address")
        End If

        If (TextBox3.Text = "") Then
            ErrorProvider1.SetError(TextBox3, "Please Enter Your Number")

        Else
            MsgBox("Your Order Placed Sucessfully")
            Form4.Show()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox1.Text = "") Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Your Name")
        End If

        If (TextBox2.Text = "") Then
            ErrorProvider1.SetError(TextBox2, "Please Enter Your Address")
        End If

        If (TextBox3.Text = "") Then
            ErrorProvider1.SetError(TextBox3, "Please Enter Your Number")

        Else
            MsgBox("Your Order Placed Sucessfully")
            Form5.Show()
        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 21
            Dim s As Integer
            s = i
            s = Convert.ToString(ComboBox1.Items.Add(i))
        Next i
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Button2.Show()
        Button3.Hide()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Button2.Hide()
        Button3.Show()
    End Sub
End Class