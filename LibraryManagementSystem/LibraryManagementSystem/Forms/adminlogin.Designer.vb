<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtBox_account = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBox_password = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PBar2 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBox_account
        '
        Me.txtBox_account.Location = New System.Drawing.Point(158, 69)
        Me.txtBox_account.Name = "txtBox_account"
        Me.txtBox_account.Size = New System.Drawing.Size(156, 20)
        Me.txtBox_account.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label1.Location = New System.Drawing.Point(155, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label2.Location = New System.Drawing.Point(155, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'txtBox_password
        '
        Me.txtBox_password.Location = New System.Drawing.Point(158, 131)
        Me.txtBox_password.Name = "txtBox_password"
        Me.txtBox_password.Size = New System.Drawing.Size(156, 20)
        Me.txtBox_password.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(158, 157)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Return"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(239, 157)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 6
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label3.Location = New System.Drawing.Point(127, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 133)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PBar2
        '
        Me.PBar2.Location = New System.Drawing.Point(12, 199)
        Me.PBar2.Name = "PBar2"
        Me.PBar2.Size = New System.Drawing.Size(304, 23)
        Me.PBar2.TabIndex = 8
        '
        'Timer1
        '
        '
        'adminlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(349, 245)
        Me.Controls.Add(Me.PBar2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtBox_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBox_account)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "adminlogin"
        Me.Text = "adminlogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtBox_account As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBox_password As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
