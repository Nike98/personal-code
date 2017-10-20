Imports System.Console

Module Module1

    Sub Main()
        Dim arrInp(10), size, i, j, arrFact As Integer

        Write(" Enter the Size of the Array (Not more than 10) : ")
        size = CInt(ReadLine())
        Write(vbCrLf)

        For i = 1 To size Step 1
            Write(" Enter the " & i & " value of the Array : ")
            arrInp(i) = CInt(ReadLine())
        Next

        For i = 1 To size Step 1
            arrFact = arrInp(i)
            For j = arrInp(i) - 1 To 1 Step -1
                arrFact *= j
            Next

            Write(vbCrLf & " The Factorial of the " & i & " value is = " & arrFact)

        Next

        ReadLine()

    End Sub

End Module
