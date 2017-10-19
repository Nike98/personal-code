Imports System.Console

Module Module1

    Sub Main()
        Dim num, remainder, temp, revnum As Integer
        revnum = 0

        Write(" Enter the number : ")
        num = CInt(ReadLine())

        temp = num

        While temp <> 0
            remainder = temp Mod 10
            revnum = revnum * 10 + remainder
            temp /= 10
        End While

        WriteLine(vbCrLf & " The Reversed Number = " & revnum)

        ReadLine()
    End Sub

End Module
