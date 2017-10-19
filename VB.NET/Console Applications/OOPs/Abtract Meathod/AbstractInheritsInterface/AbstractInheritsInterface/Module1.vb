' This Program Demontrates the use of an Abstract Class to Inherit an Interface

Imports System.Console

Public Interface MyMath
    Sub Add(ByVal a As Integer, ByVal b As Integer)
    Sub Substract(ByVal a As Integer, ByVal b As Integer)
End Interface

' Abstract Class which Inherits the above Interface

Public MustInherit Class mClass
    Implements MyMath
    MustOverride Sub Divide(ByVal a As Integer, ByVal b As Integer)

    Public Sub Add(a As Integer, b As Integer) Implements MyMath.Add
        WriteLine(" Sum = " & a + b)
    End Sub

    Public Sub Substract(a As Integer, b As Integer) Implements MyMath.Substract
        WriteLine(" Substraction = " & a - b)
    End Sub
End Class

Public Class UseClass
    Inherits mClass

    Public Overrides Sub Divide(a As Integer, b As Integer)
        WriteLine(" Division = " & a / b)
    End Sub
End Class

Module Module1

    Sub Main()
        Dim a As New UseClass

        a.Substract(20, 5)
        a.Add(20, 8)
        a.Divide(62, 8)

        ReadLine()

    End Sub

End Module
