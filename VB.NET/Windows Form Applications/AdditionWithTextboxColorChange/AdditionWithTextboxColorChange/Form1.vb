Public Class Form1
    Private Sub Add(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer

        a = CInt(TxtB1.Text)
        b = CInt(TxtB2.Text)

        MsgBox("The Sum of " & a & " and " & b & " is = " & a + b, MsgBoxStyle.Exclamation, "Sum")
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        Me.BackColor = Color.Coral
    End Sub
End Class
