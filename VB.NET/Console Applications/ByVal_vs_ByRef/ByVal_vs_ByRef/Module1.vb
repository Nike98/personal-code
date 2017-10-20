'
'
' This program demonstrates the Difference between ByVal and ByRef meathod of calling Variables
'
' ======================================================================
' ======================================================================
'
'                            OBSERVATION
'
'            When changed a value using BVal meathod
'
' ----- The change is not reflected anywhere in the program 
'       This means we cannot change the value of a variable
'       in a function which has ByVAl type parameters.....
'
'                       +++++ Whereas ++++
'
'            When changed a value using ByRef meathod
'
' ----- The change is reflected throughout the program,
'       There is even no alteration of the value if called directly.
'
'
' ======================================================================
' ======================================================================

Imports System.Console

Module Module1

    Sub Main()
        Dim a As Integer = 5

        VB(a)
        WriteLine(" ByVal = " & a)

        VB1(a)
        WriteLine(" ByRef = " & a)

        ReadLine()

    End Sub


    ' Creating a Function Sub with ByVal Parameters

    Sub VB(ByVal a As Integer)

        a = 25

    End Sub

    ' Creating another Sub function with ByRef Parameters

    Sub VB1(ByRef a As Integer)

        a = 30

    End Sub



End Module
