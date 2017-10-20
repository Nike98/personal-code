Imports System.Console

Module Module1

    Sub Main()
        Dim n, p, r, sum As Integer

        Write(" Enter the Number : ")
        n = CInt(ReadLine())
        p = 1
        sum = 0

        While p <= n \ 2
            r = n Mod p
            If r = 0 Then
                sum += p
            End If
            p += 1
        End While
        If sum = n Then
            WriteLine(vbCrLf & " " + n.ToString + " is a Perfect Number")
        Else
            WriteLine(vbCrLf & " " + n.ToString + " is not a Perfect Number")
        End If

        ReadLine()
    End Sub

End Module
