Imports System.Console

Module AbstractExample1

    Sub Main()
        Dim obj As Class1
        Dim obj1 As New Class2

        obj = obj1
        obj.Display()
        obj.Disp()

        ReadLine()
    End Sub

End Module

Public MustInherit Class Class1
    Public n As Integer

    Sub Display()
        WriteLine("Inside Abstract Class1 Constructor....")
        Write(vbCrLf & " Enter a Number : ")
        n = CInt(ReadLine())
    End Sub
    MustOverride Sub Disp()
End Class

Public Class Class2 : Inherits Class1

    Public Overrides Sub Disp()
        WriteLine(vbCrLf & " n = " & n)
    End Sub
End Class

