<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class booklist
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.BookID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PubDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Publisher = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Genre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Language = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totCopies = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.remCopies = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BookID, Me.Author, Me.PubDate, Me.Publisher, Me.Genre, Me.Language, Me.totCopies, Me.remCopies})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(611, 397)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'BookID
        '
        Me.BookID.Text = "BookID"
        '
        'Author
        '
        Me.Author.Text = "Author"
        '
        'PubDate
        '
        Me.PubDate.Text = "Date of Publication"
        '
        'Publisher
        '
        Me.Publisher.Text = "Publisher"
        '
        'Genre
        '
        Me.Genre.Text = "Genre"
        '
        'Language
        '
        Me.Language.Text = "Language"
        '
        'totCopies
        '
        Me.totCopies.Text = "Total Copies Issued"
        '
        'remCopies
        '
        Me.remCopies.Text = "Remaining Copies"
        '
        'booklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 421)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "booklist"
        Me.Text = "booklist"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents BookID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Author As System.Windows.Forms.ColumnHeader
    Friend WithEvents PubDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Publisher As System.Windows.Forms.ColumnHeader
    Friend WithEvents Genre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Language As System.Windows.Forms.ColumnHeader
    Friend WithEvents totCopies As System.Windows.Forms.ColumnHeader
    Friend WithEvents remCopies As System.Windows.Forms.ColumnHeader
End Class
