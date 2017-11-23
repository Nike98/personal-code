'
' #############################################################################
' #############################################################################
'
'                       Common Example of a Nested Class
'
' #############################################################################
' #############################################################################
'

Imports System.Console


Public Class BaseClass

    Public Sub New()

        WriteLine(" This is the Constructor of the BaseClass")

    End Sub

    Public Class InnerClass

        Public Sub New()

            WriteLine(" This is the Constructor of the InnerClass")

        End Sub

    End Class

End Class

Module Module1

    Sub Main()

        ' Calling the BaseClass through an object
        Dim obj As New BaseClass

        ' Calling the InnerClass through a new object as it should be called differently
        Dim objInner As New BaseClass.InnerClass

        ReadLine()

    End Sub

End Module
