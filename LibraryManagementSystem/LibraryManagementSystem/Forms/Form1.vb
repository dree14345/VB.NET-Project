Public Class Form1
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Dim adminlogin As New adminlogin()
        adminlogin.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click_1(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim studentform As New studentform()
        studentform.Show()
    End Sub
End Class
