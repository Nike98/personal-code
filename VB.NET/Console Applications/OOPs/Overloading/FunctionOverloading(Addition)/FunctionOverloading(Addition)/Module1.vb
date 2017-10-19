Imports System.Console

Public Class Shape
    Public Sub Area(ByVal side As Integer)
        Dim arSquare As Integer

        arSquare = side * side
        Write(" The Area of Square = " & arSquare)
    End Sub

    Public Sub Area(ByVal radius As Double)
        Dim arCircle As Integer

        arCircle = 3.147 * Math.Pow(radius, 2)
        Write(vbCrLf & " The Area of the Circle = " & arCircle)
    End Sub

    Public Sub Area(ByVal length As Integer, ByVal breadth As Integer)
        Dim arRectangle As Integer

        arRectangle = length * breadth
        Write(vbCrLf & " The Area of the Rectangle = " & arRectangle)
    End Sub
End Class

Module Module1

    Sub Main()
        Dim obj As New Shape

        obj.Area(5)
        obj.Area(5.5)
        obj.Area(10, 20)

        ReadLine()

    End Sub

End Module
