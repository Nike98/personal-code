' This Mdule is to demonstrate the Inheritance of an Abstract Class from Another Non Abstract Class

Imports System.Console

Public Class Student
    Protected RollNo As Integer
    Protected Name As String
    Protected Fee As Integer

    Sub New()
        RollNo = 1
        Name = " Nikhil "
        Fee = 80000
    End Sub

    Sub Display()
        WriteLine(" Name = " & Name)
        WriteLine(" Roll No = " & RollNo)
    End Sub
End Class

Public MustInherit Class College
    Inherits Student
    MustOverride Sub ShowFees()
End Class

Public Class Ibsar
    Inherits College
    Public Overrides Sub ShowFees()
        WriteLine(" Fees = " & Fee)
    End Sub
End Class

Module Module1

    Sub Main()
        Dim i As New Ibsar

        i.ShowFees()
        i.Display()

        ReadLine()

    End Sub

End Module
