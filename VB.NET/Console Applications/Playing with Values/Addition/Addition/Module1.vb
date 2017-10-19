Module Module1

    Sub Main()
        Dim a, b, result As Integer

        Console.Write(" Enter the 1st number : ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.Write(vbCrLf & " Enter the 2nd number : ")
        b = Convert.ToInt32(Console.ReadLine())

        result = a + b

        Console.WriteLine(vbCrLf & " The sum of the numbers is : " & result)
        Console.ReadLine()
    End Sub

End Module
