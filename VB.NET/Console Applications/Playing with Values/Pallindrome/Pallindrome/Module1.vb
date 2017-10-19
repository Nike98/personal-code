Imports System.Console

Module Module1

    Sub Main()
        Dim num, remainder, temp, reverseInt As Integer
        reverseInt = 0

        Write(" Enter the Number : ")
        num = CInt(ReadLine())

        temp = num

        While temp <> 0
            remainder = temp Mod 10
            reverseInt = reverseInt * 10 + remainder
            temp /= 10
        End While

        If num = reverseInt Then
            WriteLine(vbCrLf & " The number is a Pallindrome Number")
        Else
            WriteLine(vbCrLf & " The number is NOT a Pallindrome Number")
        End If

        ReadLine()
    End Sub

End Module
