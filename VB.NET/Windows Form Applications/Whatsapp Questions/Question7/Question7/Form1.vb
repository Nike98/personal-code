Public Class Form1

    Dim num, remainder, temp, reverseInt As Integer

    Private Sub TxtB1_TextChanged(sender As Object, e As EventArgs) Handles TxtB1.TextChanged

        If IsNumeric(TxtB1.Text) Then

            num = TxtB1.Text

        Else

            TxtB1.Text = ""

        End If

    End Sub

    Private Sub BtnValidate_Click(sender As Object, e As EventArgs) Handles BtnValidate.Click

        reverseInt = 0

        temp = num

        While temp <> 0

            remainder = temp Mod 10
            reverseInt = reverseInt * 10 + remainder
            temp /= 10

        End While

        If num = reverseInt Then

            LblOutput.Text = "The Number is a Pallindrome Number"

        Else

            LblOutput.Text = "The Number is Not a Pallindrome Number"

        End If

    End Sub

End Class
