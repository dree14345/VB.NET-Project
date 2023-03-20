Public Class dashboard

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub dashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)
        If MsgBox("Would you want to logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Dispose()
            Form1.Show()
        End If
    End Sub


    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        Me.Dispose()
        Dim memberaccounts As New memberaccounts()
        memberaccounts.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class