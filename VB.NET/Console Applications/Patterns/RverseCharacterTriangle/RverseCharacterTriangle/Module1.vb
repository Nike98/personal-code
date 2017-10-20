Imports System.Console

Module Module1

    Sub Main()
        Dim line, row, col As Integer
        Dim c As Integer = 1

        Write(" Enter the Number of Lines : ")
        line = CInt(ReadLine())
        Write(vbCrLf)

        For row = line To 1 Step -1
            For col = 1 To row Step 1
                Write(" " & c)
                c += 1
            Next
            Write(vbCrLf)
            c = 1
        Next

        ReadLine()
    End Sub

End Module
