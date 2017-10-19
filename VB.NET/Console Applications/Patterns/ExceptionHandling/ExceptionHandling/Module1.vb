Imports System.Console

Module Module1

    Sub Main()
        Dim input As Integer

        Write("Enter the Number: ")
        input = CInt(ReadLine())
        Try
            If input >= 100 And input <= 105 Then
                Throw New System.Exception("No should not be between 100-105")
            End If
            Console.WriteLine("Input: " & input)

        Catch ex As Exception
            WriteLine(ex.Message)
        Finally
            WriteLine("Finally program done!!")
        End Try

        ReadLine()
    End Sub

End Module
