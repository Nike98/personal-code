Module Module1

    Sub Main()
        Dim counter As Integer
        Dim studentName() As String
        ReDim studentName(3)

        Console.WriteLine(" Enter the student names : ")

        For counter = 0 To 2
            Console.Write(" Student " & (counter + 1) & " : ")
            studentName(counter) = Console.ReadLine()
        Next counter

        ReDim Preserve studentName(5)

        For counter = 3 To 4
            Console.Write(" Student " & (counter + 1) & " : ")
            studentName(counter) = Console.ReadLine()
        Next counter

        Console.WriteLine(" The Student Names are : ")

        For counter = 0 To 4
            Console.WriteLine(studentName(counter))
        Next counter

        Console.Write("press ENTER to Exit .....")
        Console.ReadLine()
    End Sub

End Module
