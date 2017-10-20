Imports System.Console

Module Module1

    Sub Main()
        Dim val1, val2, val3 As Integer

        Write(" Enter the 1st value : ")
        val1 = CInt(ReadLine())

        Write(vbCrLf & " Enter the 2nd value : ")
        val2 = CInt(ReadLine())

        Write(vbCrLf & " Enter the 3rd value : ")
        val3 = CInt(ReadLine())

        If (val1 <> val2 And val3) Then
            If (val1 > val2) And (val1 > val3) Then
                WriteLine(vbCrLf & " " & val1 & " is the Maximum value")
            ElseIf (val2 > val1) And (val2 > val3) Then
                WriteLine(vbCrLf & " " & val2 & " is the Maximum value")
            Else
                WriteLine(vbCrLf & " " & val3 & " is the Maximum value")
            End If

            If (val1 < val2) And (val1 < val3) Then
                WriteLine(vbCrLf & " " & val1 & " is the Minimum value")
            ElseIf (val2 < val1) And (val2 < val3) Then
                WriteLine(vbCrLf & " " & val2 & " is the Minimum value")
            Else
                WriteLine(vbCrLf & " " & val3 & " is the Minimum value")
            End If
        Else
            WriteLine(vbCrLf & " All the Inputs are EQUAL")
        End If

        ReadLine()
    End Sub

End Module
