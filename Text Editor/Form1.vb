Imports System.IO
Public Class Form1
    Dim path As String = Nothing
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fo As New OpenFileDialog
        fo.Filter = "Text Files|*.txt"
        fo.FilterIndex = 1
        fo.ShowDialog()
        If (fo.FileName = Nothing) Then
            MsgBox("No file selected.")
        Else
            path = fo.FileName
            Using sr As New StreamReader(fo.FileName)
                RichTextBox1.Text = sr.ReadToEnd()
            End Using
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Not path = Nothing) Then
            Using sw As New StreamWriter(path)
                sw.Write(RichTextBox1.Text)
            End Using
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fs As New SaveFileDialog
        fs.Filter = "Text Files|*.txt"
        fs.FilterIndex = 1
        fs.ShowDialog()
        If (Not fs.FileName = Nothing) Then
            Using sw As New StreamWriter(fs.FileName)
                sw.Write(RichTextBox1.Text)
            End Using
        End If
    End Sub
End Class
