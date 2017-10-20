Module Module1

    Sub Main()
        Dim og_num, num, digit, sum As Integer

        Console.Write(" Enter a positive integer : ")
        og_num = Convert.ToInt32(Console.ReadLine())

        sum = 0

        num = og_num

        While num <> 0
            digit = num Mod 10
            sum += Math.Pow(digit, 3)
            num \= 10
        End While

        If sum = og_num Then
            Console.Write(vbCrLf & " It is an Armstrong Number")
        Else
            Console.Write(vbCrLf & " it is not an Armstrong Number")
        End If

        Console.ReadLine()
    End Sub

End Module
