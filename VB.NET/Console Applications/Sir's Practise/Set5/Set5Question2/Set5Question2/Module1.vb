'
'==========================================================================
'==========================================================================
'
'         Write a console application to demonstrate the use 
'             of Throw Statement in Exception Handling.
'
'         Here, in this program the use of Throw Statement is 
'         going to be used when the user Enters 2 inputs and
'                       one of them is 0.
'
'==========================================================================
'==========================================================================
'

Imports System.Console

Module Module1

    Sub Main()

        Dim inp1, inp2 As Integer

        Write(" Enter the 1st Number : ")
        inp1 = CInt(ReadLine())

        Write(" Enter the 2nd Number : ")
        inp2 = CInt(ReadLine())

        Try

            If inp1 = 0 Or inp2 = 0 Then

                Throw New System.Exception(vbCrLf & " Attempt of Division by Zero .... ")

            Else

                Write(vbCrLf & " The Division = " & inp1 / inp2)

            End If

        Catch ex As Exception

            WriteLine(ex.Message)

        End Try

        ReadLine()

    End Sub

End Module
