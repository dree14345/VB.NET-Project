Public Class adminlogin
    Dim dashboard As New dashboard()
    Private Sub adminlogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        If Trim(txtBox_account.Text) = "" Then
            MsgBox("Type Username.", MsgBoxStyle.Information)
        ElseIf Trim(txtBox_password.Text) = "" Then
            MsgBox("Type password.", MsgBoxStyle.Information)
        Else
            OpenRecord("Select * from admin_credentials Where account = '" _
                       & txtBox_account.Text & "' And password = '" _
                       & txtBox_password.Text & "'")

            If rs.RecordCount = 1 Then
                Timer1.Enabled = True
            Else
                MsgBox("Invalid Account! Please try again.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If PBar2.Value < 100 Then
            PBar2.Value = PBar2.Value + 1
        Else
            Me.Dispose()
            dashboard.Show()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Would you like to return?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Dispose()
            Form1.Show()
        End If
    End Sub

    Private Sub txtBox_account_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBox_account.KeyUp
        If e.KeyCode = Keys.Escape Then
            Button1_Click(sender, e)
        ElseIf e.KeyCode = Keys.Enter Then
            btnlogin_Click(sender, e)
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As KeyEventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub Button1_Click(sender As Object, e As KeyEventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub txtBox_password_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBox_password.KeyUp
        If e.KeyCode = Keys.Escape Then
            Button1_Click(sender, e)
        ElseIf e.KeyCode = Keys.Enter Then
            btnlogin_Click(sender, e)
        End If
    End Sub
End Class