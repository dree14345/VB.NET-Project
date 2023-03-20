Public Class booklist
    Dim Item As ListViewItem
    Dim I As Integer
    Public Sub getAllBooks(ByVal Str As String)
        ListView1.Items.Clear()

        OpenRecord("Select * from book Where author like '" & Str & "%'")
        With rs
            While Not .EOF
                lvi = ListView1.Items.Add(.Fields("book_id").Value)
                lvi.SubItems.Add(.Fields("author").Value)
                lvi.SubItems.Add(.Fields("publication_date").Value.ToString)
                lvi.SubItems.Add(.Fields("publisher").Value)
                lvi.SubItems.Add(.Fields("genre").Value)
                lvi.SubItems.Add(.Fields("language").Value)
                lvi.SubItems.Add(.Fields("total_copies").Value)
                lvi.SubItems.Add(.Fields("available_copies").Value)
                .MoveNext()
            End While
        End With
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
    End Sub

    Private Sub ListView1_ItemActivate(sender As System.Object, e As System.EventArgs) Handles ListView1.ItemActivate
        Dim book As New BookInfo()
        book.Show()
    End Sub

    Private Sub booklist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection()
        getAllBooks("")
    End Sub
End Class