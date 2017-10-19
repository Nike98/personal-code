Imports System.Console

Module Module1

    Public Class Car1
        Private mBodyColor As ConsoleColor
        Public Property BodyColor() As ConsoleColor

            Get
                'Do some work
                Return mBodyColor
            End Get
            Set(ByVal Value As ConsoleColor)
                mBodyColor = Value
                'Do some validation and any other relevant work
            End Set
        End Property
    End Class

    Public Class Car4
        Private mBodyColor As ConsoleColor
        Public Function GetBodyColor() As ConsoleColor
            'Do some work
            Return mBodyColor
        End Function

        Private Sub SetBodyColor(ByVal Value As ConsoleColor)
            mBodyColor = Value
            'Do some work
        End Sub
    End Class

End Module
