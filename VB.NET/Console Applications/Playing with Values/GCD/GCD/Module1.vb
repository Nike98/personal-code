Imports System.Console

Module Module1

    Sub Main()
        Dim n1, n2, hcf As Integer

        Write(" Enter the 1st Number : ")
        n1 = CInt(ReadLine())

        Write(vbCrLf & " Enter the 2nd Number : ")
        n2 = CInt(ReadLine())

        If n2 > n1 Then
            Dim temp As Integer = n2
            n2 = n1
            n1 = temp
        End If

        Dim i As Integer

        For i = 1 To n2 Step 1
            If n1 Mod i = 0 And n2 Mod i = 0 Then
                hcf = i
            End If
        Next

        WriteLine(vbCrLf & " HCF = " & hcf)

        ReadLine()

    End Sub

End Module
