Module Module1

    Sub Main()
        Dim obj As ChildClass = New ChildClass()
        obj.Print()
        Console.ReadKey()
    End Sub

End Module

Class ParentClass
    Public a_Parent As Integer
    Protected b_Parent As Integer
    Private c_Parent As Integer

    Public Sub New()
        a_Parent = 10
        b_Parent = 2
        c_Parent = 77
    End Sub

    Public Sub PrintPub_Parent()
        Console.WriteLine("Value of a_Parent = {0}, b_Parent = {1}, c_Parent = {2}", a_Parent, b_Parent, c_Parent)
    End Sub

    Protected Sub PrintPro_Parent()
        Console.WriteLine("Value of a_Parent = {0}, b_Parent = {1}, c_Parent = {2}", a_Parent, b_Parent, c_Parent)
    End Sub

    Private Sub PrintPri_Parent()
        Console.WriteLine("Value of a_Parent = {0}, b_Parent = {1}, c_Parent = {2}", a_Parent, b_Parent, c_Parent)
    End Sub
End Class

Class ChildClass
    Inherits ParentClass

    Private x_Child As Integer
    Protected y_Child As Int16
    Public z_Child As Integer

    Public Sub Print()
        Console.WriteLine("Value of x_Child = {0}", x_Child)

        Console.WriteLine("Value of a_Parent = {0}", a_Parent)
        Console.WriteLine("Value of b_Parent = {0}", b_Parent)
        'Console.WriteLine("Value of c_Parent = {0}", c_Parent)
        PrintPub_Parent()
        PrintPro_Parent()
        'PrintPri_Parent()
    End Sub
End Class

