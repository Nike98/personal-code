Imports System.Console

Module Module1

    Sub Main()
        Dim n1, n2, hcf, temp, lcm As Integer

        Write(" Enter the 1st number : ")
        n1 = CInt(ReadLine())

        Write(vbCrLf & " Enter the 2nd number : ")
        n2 = CInt(ReadLine())

        hcf = n1
        temp = n2

        While hcf <> temp
            If hcf > temp Then
                hcf -= temp
            Else
                temp -= hcf
            End If
        End While

        lcm = (n1 * n2) \ hcf

        WriteLine(vbCrLf & " The LCM = " & lcm)

        ReadLine()
    End Sub

End Module
