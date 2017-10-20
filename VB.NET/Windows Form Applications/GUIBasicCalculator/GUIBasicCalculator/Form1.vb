Public Class Form1

    ' Initialization of basic and common varialbles
    Dim num1 As Integer
    Dim num2 As Integer
    Dim operation As String


    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        'To clear the Display box of 0
        If TxtDisplay.Text = "0" Then
            TxtDisplay.Clear()
        End If

        ' To input the Number the button face shows
        TxtDisplay.AppendText("0")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' To clear the Display box of 0
        If TxtDisplay.Text = "0" Then
            TxtDisplay.Clear()
        End If

        ' To input the Number the button face shows
        TxtDisplay.AppendText("1")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' To clear the Display box of 0
        If TxtDisplay.Text = "0" Then
            TxtDisplay.Clear()
        End If

        ' To input the Number the button face shows
        TxtDisplay.AppendText("2")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' To clear the Display box of 0
        If TxtDisplay.Text = "0" Then
            TxtDisplay.Clear()
        End If

        ' To input the Number the button face shows
        TxtDisplay.AppendText("3")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' To clear the Display box of 0
        If TxtDisplay.Text = "0" Then
            TxtDisplay.Clear()
        End If

        ' To input the Number the button face shows
        TxtDisplay.AppendText("4")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ' To clear the Display box of 0
        If TxtDisplay.Text = "0" Then
            TxtDisplay.Clear()
        End If

        ' To input the Number the button face shows
        TxtDisplay.AppendText("5")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        ' To clear the Display box of 0
        If TxtDisplay.Text = "0" Then
            TxtDisplay.Clear()
        End If

        ' To input the Number the button face shows
        TxtDisplay.AppendText("6")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        ' To clear the Display box of 0
        If TxtDisplay.Text = "0" Then
            TxtDisplay.Clear()
        End If

        ' To input the Number the button face shows
        TxtDisplay.AppendText("7")

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        ' To clear the Display box of 0
        If TxtDisplay.Text = "0" Then
            TxtDisplay.Clear()
        End If

        ' To input the Number the button face shows
        TxtDisplay.AppendText("8")

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        ' To clear the Display box of 0
        If TxtDisplay.Text = "0" Then
            TxtDisplay.Clear()
        End If

        ' To input the Number the button face shows
        TxtDisplay.AppendText("9")

    End Sub

    Private Sub ButtonAddition_Click(sender As Object, e As EventArgs) Handles ButtonAddition.Click

        ' Get the Number to Display Addition
        num1 = Convert.ToInt32(TxtDisplay.Text)

        ' Setting the operation to be performed by the Button Face
        operation = "add"

        ' Clearing the Text Box
        TxtDisplay.Text = "0"

    End Sub

    Private Sub ButtonSubtraction_Click(sender As Object, e As EventArgs) Handles ButtonSubtraction.Click

        ' Get the Number to Display Addition
        num1 = Convert.ToInt32(TxtDisplay.Text)

        ' Setting the operation to be performed by the Button Face
        operation = "subtract"

        ' Clearing the Text Box
        TxtDisplay.Text = "0"

    End Sub

    Private Sub ButtonMulti_Click(sender As Object, e As EventArgs) Handles ButtonMulti.Click

        ' Get the Number to Display Addition
        num1 = Convert.ToInt32(TxtDisplay.Text)

        ' Setting the operation to be performed by the Button Face
        operation = "multiply"

        ' Clearing the Text Box
        TxtDisplay.Text = "0"

    End Sub

    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click

        ' Get the Number to Display Addition
        num1 = Convert.ToInt32(TxtDisplay.Text)

        ' Setting the operation to be performed by the Button Face
        operation = "divide"

        ' Clearing the Text Box
        TxtDisplay.Text = "0"

    End Sub

    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        Try

            ' Getting the value of the second number
            num2 = Convert.ToInt32(TxtDisplay.Text)

            If operation = "add" Then

                ' Setting the Operation to work
                TxtDisplay.Text = num1 + num2

            ElseIf operation = "subtract" Then

                ' Setting the Operation to work
                TxtDisplay.Text = num1 - num2

            ElseIf operation = "multiply" Then

                ' Setting the Operation to work
                TxtDisplay.Text = num1 * num2

            ElseIf operation = "divide" Then

                If num1 = 0 Or num2 = 0 Then

                    Throw New Exception("No input be Zero")
                Else

                    ' Setting the Operation to work
                    TxtDisplay.Text = num1 / num2

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
End Class
