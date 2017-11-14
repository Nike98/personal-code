'
' =========================================================================
' =========================================================================
'
'         Create an Abstract Class which Implements an Interface
'
' =========================================================================
' =========================================================================
'

Imports System.Console


Public Interface Math

    Sub Add(ByVal a As Integer, ByVal b As Integer)
    Sub Subtract(ByVal a As Integer, ByVal b As Integer)

End Interface


Public MustInherit Class MathAbstract

    Implements Math

    Public Sub Add(a As Integer, b As Integer) Implements Math.Add

        WriteLine(" Sum = " & a + b)

    End Sub

    Public Sub Subtract(a As Integer, b As Integer) Implements Math.Subtract

        WriteLine(" Substraction = " & a - b)

    End Sub

    Public MustOverride Sub Divide(ByVal a As Integer, ByVal b As Integer)

End Class


Public Class ActualClass

    Inherits MathAbstract

    Public Overrides Sub Divide(a As Integer, b As Integer)

        WriteLine(" Division = " & a / b)

    End Sub

End Class


Module Module1

    Sub Main()

        Dim obj As New ActualClass

        obj.Add(15, 8)
        obj.Divide(39, 3)
        obj.Subtract(15, 2)

        ReadLine()

    End Sub

End Module
