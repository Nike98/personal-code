Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num, i, f As Integer
        f = 1

        num = CInt(TextBox1.Text)

        If num > 1 Then
            For i = num To 1 Step -1
                f *= i
            Next

            MsgBox("The Factorial of the Entered Number = " & f, MsgBoxStyle.Information)

        Else
            MsgBox("The Factoial of values less than 1 or 1 is not possible", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
