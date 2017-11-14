'
'==========================================================================
'==========================================================================
'
'           Create a Property Roll_no of class Student. Assign the
'                 value for the property and display it.
'
'==========================================================================
'==========================================================================

Imports System.Console

Class Student

    Private Roll_no As Integer = 10

    Public Sub New()                    ' Constructor

        Roll_no = 11

    End Sub

    Public Property Changer() As Integer

        Get

            Return Roll_no

        End Get

        Set(value As Integer)

            Roll_no = value

        End Set

    End Property

End Class

Module Module1

    Sub Main()

        Dim obj As New Student

        WriteLine(" ")

        ReadLine()

    End Sub

End Module
