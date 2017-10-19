Imports System.Console

Module Module1

    Sub Main()
        Dim line, row, col, c As Integer
        c = 65

        Write(" Enter the Number of lines : ")
        line = CInt(ReadLine())
        Write(vbCrLf)

        For row = line To 1 Step -1
            For col = 1 To row Step 1
                Write(" " & Convert.ToChar(c))
                c += 1
            Next
            Write(vbCrLf)
            c = 65
        Next

        ReadLine()
    End Sub

End Module
