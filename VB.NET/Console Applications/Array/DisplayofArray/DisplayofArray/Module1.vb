Module Module1

    Sub Main()
        Dim arr(10) As Integer
        Dim i As Integer

        Console.WriteLine(" Enter the Elements of the Array : ")

        For i = 1 To 10 Step 1
            arr(i) = CInt(Console.ReadLine())
        Next

        Console.WriteLine(vbCrLf & " The Elements you have Entered Are : ")

        For i = 1 To 10 Step 1
            Console.WriteLine(" " & arr(i))
        Next

        Console.ReadLine()
    End Sub

End Module
