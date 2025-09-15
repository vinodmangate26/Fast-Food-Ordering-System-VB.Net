Imports System.Text.RegularExpressions

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Item Added Sucessfully")
        Form3.Show()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 1 To 10
            Dim s As Integer
            s = i
            s = Convert.ToString(ComboBox1.Items.Add(i))
            s = Convert.ToString(ComboBox2.Items.Add(i))
            s = Convert.ToString(ComboBox3.Items.Add(i))
            s = Convert.ToString(ComboBox4.Items.Add(i))
            s = Convert.ToString(ComboBox5.Items.Add(i))
            s = Convert.ToString(ComboBox6.Items.Add(i))
            s = Convert.ToString(ComboBox7.Items.Add(i))
            s = Convert.ToString(ComboBox8.Items.Add(i))
            s = Convert.ToString(ComboBox9.Items.Add(i))
            s = Convert.ToString(ComboBox10.Items.Add(i))
            s = Convert.ToString(ComboBox11.Items.Add(i))
            s = Convert.ToString(ComboBox12.Items.Add(i))
            s = Convert.ToString(ComboBox13.Items.Add(i))
            s = Convert.ToString(ComboBox14.Items.Add(i))
            s = Convert.ToString(ComboBox15.Items.Add(i))
            s = Convert.ToString(ComboBox16.Items.Add(i))
            s = Convert.ToString(ComboBox17.Items.Add(i))
            s = Convert.ToString(ComboBox18.Items.Add(i))
            s = Convert.ToString(ComboBox19.Items.Add(i))
            s = Convert.ToString(ComboBox20.Items.Add(i))
            s = Convert.ToString(ComboBox21.Items.Add(i))

        Next i
    End Sub
End Class