Imports System.Console

Module Module1

    Sub Main()
        Dim arr(50) As Integer
        Dim i, max, min, size As Integer

        Write(" Enter the Size of the Array : ")
        size = CInt(ReadLine())

        WriteLine(vbCrLf & " Enter the elements of the Array : ")

        For i = 1 To size Step 1
            arr(i) = CInt(ReadLine())
        Next

        max = arr(1)
        min = arr(1)

        For i = 1 To size Step 1
            If arr(i) > max Then
                max = arr(i)
            End If

            If arr(i) < min Then
                min = arr(i)
            End If
        Next

        WriteLine(vbCrLf & " The Maximum Value in the Array is = " & max)
        WriteLine(" The Minimum Value in the Array is = " & min)

        Console.Write(Constants.vbLf & "Press ENTER to quit...")

        ReadLine()
    End Sub

End Module
