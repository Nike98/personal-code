Imports System.Console

Module Module1

    Sub Main()
        Dim num, sum As Integer
        sum = 0

        Write(" Enter the Number : ")
        num = CInt(ReadLine())

        While num <> 0
            sum = sum + num Mod 10
            num /= 10
        End While

        WriteLine(vbCrLf & " The sum of the Entered Digits = " & sum)

        ReadLine()
    End Sub

End Module
