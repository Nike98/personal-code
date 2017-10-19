Imports System.Console

Module Module1

    Sub Main()
        Dim decVal, quotient As Long
        Dim binVal(100), i, j As Integer
        i = 1

        Write(" Enter the Decimal Value : ")
        decVal = CLng(ReadLine())

        quotient = decVal

        While quotient <> 0
            binVal(i + 1) = quotient Mod 2
            quotient = quotient / 2
        End While

        Write(" The Binary Value = " & decVal)

        For j = i - 1 To 0 Step -1
            Write("" & binVal(j))
        Next

        ReadLine()
    End Sub

End Module
