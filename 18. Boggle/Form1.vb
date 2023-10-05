Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, n As Integer
        For i = 1 To 25
            n = Int(26 * Rnd()) + 65

            Dim FoundControls As Control() = Me.Controls.
                Find("label" & i, True) 'Find the label with the
            'name "label#" - where # is the current index
            If FoundControls.Count > 0 Then
                FoundControls(0).Text = Chr(n) 'change itd text
            End If
        Next
    End Sub
End Class
