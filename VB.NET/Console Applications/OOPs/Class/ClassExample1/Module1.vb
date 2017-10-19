Imports System.Console

Module Module1
    Class A
        Private val1 As Integer
        Public Sub Display()
            Dim input As Integer

            input = val1

            Write(" Enter the Input : ")
            input = CInt(ReadLine())
            WriteLine(vbCrLf & " Tu kya Hai ?????????")

            WriteLine(vbCrLf & " The value of the Integer = " & input)
            Write(vbCrLf & " Tu Chutiya tha, hai aur rahega !!!!!!!")
        End Sub
    End Class
    Sub Main()
        Dim obj As A = New A

        obj.Display()

        ReadLine()
    End Sub

End Module
