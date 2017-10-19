Imports System.Console

Module Module1

    Sub Main()
        Dim arr(50) As Integer
        Dim i, size As Integer
        Dim sum As Integer = 0

        Write(" Enter the Size of the Array : ")
        size = CInt(ReadLine())

        WriteLine(vbCrLf & " Enter the Elements of the Array : ")

        For i = 1 To size Step 1
            arr(i) = CInt(ReadLine())
            sum += arr(i)
        Next

        WriteLine(vbCrLf & " The sum of the Elements of the Array is = " & sum)

        Console.Write(Constants.vbLf & "Press ENTER to quit...")

        ReadLine()
    End Sub

End Module
