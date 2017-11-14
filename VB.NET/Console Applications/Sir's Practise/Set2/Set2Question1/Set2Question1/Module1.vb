' ===============================================================================================================================
' ===============================================================================================================================
'
'                                                       EXPLAINATION
'
'                           This program demonstrates the use of Exception Handling in Vb.NET
'               Exceptions are unusual and undeseied conditions acquired at the Run - time of a program or Application
'                 These conditions or also sometimes termed as Runtime bugs are dealed using Exception Handling Only
'
'                    Exception Handling includes the Trying or Implementation of some blocks of code,
'                                If this code dosen't work then an Error is Thrown,
'                           This Error is Caught and the Erroe Message is Displayed to the User
'
' ===============================================================================================================================
' ===============================================================================================================================


Imports System.Console

Module Module1

    Sub Main()
        Dim a As Integer = 25

        Try
            WriteLine(0 / 25)                                                       ' Trying to run a particular line or block(s) of code

            Throw New System.Exception(" This operation cannot be performed as one of the inputs is 0")     ' If it dosen't work so an Exception is thrown using the Throw Statement

        Catch ex As Exception
            WriteLine(ex.Message)                       ' The Catch Meathod takes in the Mesaage as a new Exception object and displays it
        End Try

        ReadLine()

    End Sub


End Module
