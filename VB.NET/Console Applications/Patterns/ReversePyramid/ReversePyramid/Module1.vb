Imports System.Console

Module Module1

    Sub Main()
        Dim row, col, space, line As Integer

        Write(" Enter the number of Lines : ")
        line = CInt(ReadLine())
        Write(vbCrLf)

        For row = line To 1 Step -1
            For space = line To row - 1 Step -1
                Write(" ")
            Next
            For col = 1 To row * 2 - 1 Step 1
                Write("*")
            Next
            Write(vbCrLf)
        Next
        ReadLine()
    End Sub

End Module
