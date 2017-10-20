' This program won't display anything but this is the implementation of Abstract Class with a Non Abstract Meathod

Imports System.Console


MustInherit Class Class1
    Sub Display()
        WriteLine(" This is the Abstract Class with a non Abstract Meathod.....")
    End Sub
End Class

Module Module1

    Sub Main()
        Dim obj As Class1

        obj.Display()

        ReadLine()
    End Sub

End Module
