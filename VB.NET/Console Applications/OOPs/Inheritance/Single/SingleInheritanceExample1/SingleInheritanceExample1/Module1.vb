Imports System.Console

Module Module1

    Sub Main()
        Dim obj As ChildClass = New ChildClass

        obj.Print()

        ReadLine()

    End Sub

End Module

Class ParentClass
    Public val_a As Integer
    Protected val_b As Integer
    Private val_c As Integer

    Public Sub New()
        val_a = 20
        val_b = 65
        val_c = 80
    End Sub

    Public Sub PrintPub_Parent()
        WriteLine(" The value of val_a = {0} , The value of val_b = {1} , The value of val_c = {2} ", val_a, val_b, val_c)
    End Sub

    Protected Sub PrintPro_Parent()
        WriteLine(" The value of val_a = {0} , The value of val_b = {1} , The value of val_c = {2} ", val_a, val_b, val_c)
    End Sub

    Private Sub PrintPri_Parent()
        WriteLine(" The value of val_a = {0} , The value of val_b = {1} , The value of val_c = {2} ", val_a, val_b, val_c)
    End Sub
End Class

Class ChildClass
    Inherits ParentClass

    Private x_child As Integer
    Protected y_child As Integer
    Public z_child As Integer

    Public Sub Print()
        WriteLine(" The value of x_child = " & x_child)

        WriteLine(" The value of val_a = " & val_a)
        WriteLine(" The value of val_b = " & val_b & vbCrLf)

        PrintPub_Parent()
        PrintPro_Parent()
    End Sub
End Class
