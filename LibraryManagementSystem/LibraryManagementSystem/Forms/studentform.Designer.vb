<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentform
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtaccount = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PBar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(168, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Tomato
        Me.Label2.Location = New System.Drawing.Point(168, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(171, 122)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(181, 20)
        Me.txtpassword.TabIndex = 4
        '
        'txtaccount
        '
        Me.txtaccount.Location = New System.Drawing.Point(171, 60)
        Me.txtaccount.Name = "txtaccount"
        Me.txtaccount.Size = New System.Drawing.Size(181, 20)
        Me.txtaccount.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(171, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Return"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Tomato
        Me.btnlogin.ForeColor = System.Drawing.Color.Black
        Me.btnlogin.Location = New System.Drawing.Point(277, 148)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 7
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibraryManagementSystem.My.Resources.Resources.no_photo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PBar
        '
        Me.PBar.Location = New System.Drawing.Point(12, 193)
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(340, 23)
        Me.PBar.TabIndex = 8
        '
        'Timer1
        '
        '
        'studentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(389, 228)
        Me.Controls.Add(Me.PBar)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtaccount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "studentform"
        Me.Text = "studentform"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtaccount As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents PBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
