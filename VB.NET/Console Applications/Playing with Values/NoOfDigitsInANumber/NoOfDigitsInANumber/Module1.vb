Imports System.Console

Module Module1

    Sub Main()
        Dim input As Integer

        Write(" Enter the Number : ")
        input = CInt(ReadLine())

        WriteLine(vbCrLf & " The Number of Digits = " & input.ToString.Length)

        ReadLine()
    End Sub
End Module
