Imports System.Console

Module Module1

    Sub Main()
        Dim num, power As Integer

        Write(" Enter the Number : ")
        num = CInt(ReadLine())

        Write(vbCrLf & " Enter the Power to be raised : ")
        power = CInt(ReadLine())

        WriteLine(vbCrLf & " The Answer = " & num ^ power)

        ReadLine()

    End Sub

End Module
