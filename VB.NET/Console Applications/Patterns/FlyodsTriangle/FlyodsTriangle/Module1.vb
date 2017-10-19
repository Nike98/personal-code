Imports System.Console

Module Module1

    Sub Main()
        Dim row, col, line, num As Integer
        num = 1

        Write(" Enter the Number of Lines : ")
        line = CInt(ReadLine())
        Write(vbCrLf)

        For row = 1 To line Step 1
            For col = 1 To row Step 1
                Write(" " & num)
                num += 1
            Next
            Write(vbCrLf)
        Next

        ReadLine()
    End Sub

End Module
