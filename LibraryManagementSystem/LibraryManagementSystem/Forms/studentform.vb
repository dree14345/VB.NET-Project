Public Class studentform
    Dim userrecord As New userrecord()
    Private Sub studentform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection()
    End Sub

    Private Sub txtaccount_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtaccount.KeyUp
        If e.KeyCode = Keys.Escape Then
            Button1_Click(sender, e)
        ElseIf e.KeyCode = Keys.Enter Then
            btnlogin_Click(sender, e)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtaccount.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If PBar.Value < 100 Then
            PBar.Value = PBar.Value + 1
        Else
            Me.Dispose()
            userrecord.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        If Trim(txtaccount.Text) = "" Then
            MsgBox("Type Username.", MsgBoxStyle.Information)
        ElseIf Trim(txtpassword.Text) = "" Then
            MsgBox("Type password.", MsgBoxStyle.Information)
        Else
            OpenRecord("Select * from system_user Where account = '" _
                       & txtaccount.Text & "' And password = '" _
                       & txtpassword.Text & "'")

            If rs.RecordCount = 1 Then
                Timer1.Enabled = True
                OpenRecord("update system_user set status = current_time() where account like '" _
                           & txtaccount.Text & "' And password = '" _
                           & txtpassword.Text & "'")
            Else
                MsgBox("Invalid Account! Please try again.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If MsgBox("Would you like to return?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Dispose()
            Form1.Show()
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As KeyEventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub txtpassword_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyUp
        If e.KeyCode = Keys.Escape Then
            Button1_Click(sender, e)
        ElseIf e.KeyCode = Keys.Enter Then
            btnlogin_Click(sender, e)
        End If
    End Sub

    Private Sub PBar_Click(sender As System.Object, e As System.EventArgs) Handles PBar.Click

    End Sub
End Class