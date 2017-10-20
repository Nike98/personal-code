Imports System.Console

Module Module1

    Sub Main()
        Dim inp As Integer

        Write(" Enter the Number : ")
        inp = Convert.ToInt32(ReadLine())

        Dim binVal = Convert.ToString(inp, 2)

        Write(vbCrLf & " The Binary Value = " & binVal)

        ReadLine()
    End Sub

End Module
