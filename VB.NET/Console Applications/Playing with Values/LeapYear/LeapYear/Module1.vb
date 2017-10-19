Imports System.Console

Module Module1

    Sub Main()
        Dim year, checkVal As Integer

        Write(" Enter the Year : ")
        year = CInt(ReadLine())

        checkVal = year.ToString.Length

        Try
            If checkVal = 4 Then
                If year Mod 4 = 0 Then
                    WriteLine(vbCrLf & " The year " & year & " is a Leap Year")
                Else
                    WriteLine(vbCrLf & " The year " & year & " is not a Leap Year")
                End If
            Else
                Throw New System.Exception(vbCrLf & " The input should be of 4 digits only")
            End If

        Catch ex As Exception
            WriteLine(ex.Message)
        End Try

        ReadLine()

    End Sub

End Module
