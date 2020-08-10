Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kotakList.Items.Add("012345678901234567890")
        kotakList.Items.Add("X" & vbTab & "X")
        kotakList.Items.Add("XXXXXXXXXXXX" & vbTab & "X")
        kotakList.Items.Add(vbTab & vbTab & "X")
    End Sub
End Class
