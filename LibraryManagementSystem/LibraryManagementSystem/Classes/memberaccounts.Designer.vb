<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memberaccounts
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lvAccounts = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fullname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Account = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(185, 401)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(280, 20)
        Me.txtSearch.TabIndex = 1
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(471, 399)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(552, 399)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fullname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(15, 43)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(156, 20)
        Me.txtFullname.TabIndex = 7
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(15, 103)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(156, 20)
        Me.txtAccount.TabIndex = 8
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(15, 167)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(156, 20)
        Me.txtPassword.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(15, 211)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(96, 211)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lvAccounts
        '
        Me.lvAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Fullname, Me.Account, Me.Password, Me.Status})
        Me.lvAccounts.FullRowSelect = True
        Me.lvAccounts.GridLines = True
        Me.lvAccounts.Location = New System.Drawing.Point(185, 12)
        Me.lvAccounts.Name = "lvAccounts"
        Me.lvAccounts.Size = New System.Drawing.Size(442, 372)
        Me.lvAccounts.TabIndex = 12
        Me.lvAccounts.UseCompatibleStateImageBehavior = False
        Me.lvAccounts.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'Fullname
        '
        Me.Fullname.Text = "Fullname"
        '
        'Account
        '
        Me.Account.Text = "Account"
        '
        'Password
        '
        Me.Password.Text = "Password"
        '
        'Status
        '
        Me.Status.Text = "Status"
        '
        'memberaccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 456)
        Me.Controls.Add(Me.lvAccounts)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "memberaccounts"
        Me.Text = "memberaccounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lvAccounts As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fullname As System.Windows.Forms.ColumnHeader
    Friend WithEvents Account As System.Windows.Forms.ColumnHeader
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
End Class
