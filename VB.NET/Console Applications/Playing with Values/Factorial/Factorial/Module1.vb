'This Console Application will take an input only up till 20 as fact is set to an Unsigned Long

Imports System.Console

Module Module1

    Sub Main()
        Dim num, i As Integer
        Dim fact As ULong
        fact = 1

        Write(" Enter the Digit : ")
        num = CInt(ReadLine())

        If num < 0 Then
            WriteLine(vbCrLf & " Factorial of negative number is not possible")

        ElseIf num = 0 Or num = 1 Then
            WriteLine(vbCrLf & " Factorial of " + num.ToString() + " is 1")

        Else
            For i = 1 To num Step 1
                fact *= i
            Next

            WriteLine(vbCrLf & " The Factorial = " & fact)
        End If

        ReadLine()
    End Sub

End Module
