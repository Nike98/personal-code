Imports System.Console

Module Module1

    Sub Main()
        Dim val1, val2, val3, res As Integer

        Write(" Enter the 1st Number : ")
        val1 = CInt(ReadLine())

        Write(vbCrLf & " Enter the 2nd Number : ")
        val2 = CInt(ReadLine())

        Write(vbCrLf & " Enter the 3rd Number : ")
        val3 = CInt(ReadLine())

        res = Add3(val1, val2, val3)

        Write(vbCrLf & " The Sum = " & res)

        ReadLine()
    End Sub

    Function Add3(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Return a + b + c
    End Function
End Module
