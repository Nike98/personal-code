Imports System.Console

Module Module1

    Sub Main()
        Dim obj As New ParenClass
        WriteLine(obj.A)
        WriteLine(obj.G_ab)
        WriteLine("===========")
        obj.A = 10
        WriteLine(obj.A)
        WriteLine(obj.G_ab)

        WriteLine("===========")
        obj.S_ab(11)
        WriteLine(obj.A)
        WriteLine(obj.G_ab)
        WriteLine("=======")
        Dim obj2 As New ParenClass(7)
        WriteLine(obj2.A)
        WriteLine(obj2.G_ab)
        ReadKey()
    End Sub

End Module

Class ParenClass
    Private ab As Integer = 88
    Public Sub New() 'constructor
        ab = 99
    End Sub

    Public Sub New(value As Integer) 'constructor
        ab = value
    End Sub

    Public Sub S_ab(ByVal value As Integer) 'mutator
        ab = value
    End Sub

    Public Function G_ab() As Integer ''accessor method
        Return ab
    End Function

    Public Property A() As Integer 'named property
        Get
            Return ab
        End Get
        Set(value As Integer)
            ab = value
        End Set
    End Property

End Class