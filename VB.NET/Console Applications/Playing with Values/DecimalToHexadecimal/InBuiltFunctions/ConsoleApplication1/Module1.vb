Imports System.Console

Module Module1

    Sub Main()
        Dim inp As Integer
        Dim hexVal As String

        Write(" Enter the Number : ")
        inp = CInt(ReadLine())

        hexVal = Hex(inp)

        Write(vbCrLf & " The Hexadecimal value = " & hexVal)

        ReadLine()
    End Sub

End Module
