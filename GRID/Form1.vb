Public Class Form1
    Dim RowIndex As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddRow(GRID1)
    End Sub
    Sub AddRow(GRID As DataGridView)
        Dim StringRow As String()

        StringRow = New String() {TextBox1.Text, TextBox2.Text}
        GRID.Rows.Add(StringRow)

        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub GRID1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRID1.CellClick
        If e.RowIndex < 0 Then Exit Sub
        TextBox1.Text = GRID1.Rows(e.RowIndex).Cells("Column1").Value
        TextBox2.Text = GRID1.Rows(e.RowIndex).Cells("Column2").Value
    End Sub

    Private Sub GRID1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRID1.CellContentClick

    End Sub

    Private Sub GRID1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GRID1.CellMouseClick
        If e.Button = MouseButtons.Right Then
            RowIndex = e.RowIndex
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub DeleteRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRowToolStripMenuItem.Click
        If RowIndex >= 0 Then
            GRID1.Rows.RemoveAt(RowIndex)
        End If
    End Sub
End Class
