' This program is made to display the use of Partial Implementation of an Abstract Class 
' HINT : By declaring the derived class also abstract, we can avoid the implementation of all or certain abstract meathods

Imports System.Console

Public MustInherit Class One                ' Abstract Class

    Public MustOverride Sub Add(ByVal A As Integer, ByVal b As Integer)                 ' Abstract Meathod
    Public MustOverride Sub Subtract(ByVal a As Integer, ByVal b As Integer)               ' Abstract Meathod

End Class

Public MustInherit Class Two                ' Partial Abstarct Class
    Inherits One
    Public Overrides Sub Add(A As Integer, b As Integer)
        WriteLine(" Sum = " & A + b)
    End Sub
End Class

Public Class Three
    Inherits Two

    Public Overrides Sub Subtract(a As Integer, b As Integer)
        WriteLine(" Difference = " & a - b)
    End Sub
End Class

Module Module1

    Sub Main()
        Dim a As New Three

        a.Add(25, 2)
        a.Subtract(2, 3)

        ReadLine()

    End Sub

End Module
