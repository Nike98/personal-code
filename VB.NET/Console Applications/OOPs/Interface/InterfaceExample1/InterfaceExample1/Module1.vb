Imports System.Console


Interface MyMathInterface
    Sub Add()
    Function Subtract(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
End Interface

Class ImpClass
    Implements MyMathInterface

    Public Sub Add() Implements MyMathInterface.Add
        WriteLine(10 + 20)
    End Sub

    Public Function Subtract(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer Implements MyMathInterface.Subtract
        Return a - b - c
    End Function
End Class
Module Module1

    Sub Main()
        Dim obj As ImpClass = New ImpClass

        obj.Add()

        WriteLine(" " & obj.Subtract(50, 5, 2))

        ReadLine()
    End Sub

End Module
