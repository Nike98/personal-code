' This program is to show the use of Abstract Class with a Non Abstract Meadthod 
' This Program displays the Area of a Triangle

Imports System.Console

Module Module1

    Public MustInherit Class Shape              'abstract class
        Public Sub Area(ByVal Length As Integer, ByVal Breadth As Integer)
            WriteLine(" Area : " & 1 / 2 * Length * Breadth)
        End Sub
    End Class

    Class Triangle
        Inherits Shape
    End Class

    Sub Main()
        Dim obj As New Triangle

        obj.Area(10, 8)

        ReadLine()

    End Sub

End Module
