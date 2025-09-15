Public Class Form5
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.phonepe.com/business-solutions/offline-merchant/")
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.indiatoday.in/information/story/how-to-pay-someone-on-google-pay-using-qr-code-1725287-2020-09-25")
    End Sub
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("https://pureoxygenlabs.com/how-to-create-a-qr-codes-that-deep-link-to-your-mobile-app/")
    End Sub
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://business.paytm.com/retail")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Your Order Has Been Succesfully Completed!!!")
        Form4.Show()
    End Sub
End Class