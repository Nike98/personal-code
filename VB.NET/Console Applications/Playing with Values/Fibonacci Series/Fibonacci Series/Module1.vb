Imports System.Console

Module Module1

    Sub Main()
        Dim num, first, second, i, sum As Integer
        sum = 0
        first = 0
        second = 1

        Write(" Enter the digit : ")
        num = CInt(ReadLine())
        Write(vbCrLf & vbCrLf)

        For i = 1 To num Step 1
            WriteLine(" " & first)

            sum = first + second
            first = second
            second = sum
        Next

        ReadLine()
    End Sub

End Module
