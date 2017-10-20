Module Module1

    Sub Main()
        Dim inp1, inp2, i, j, flag As Integer

        Console.Write(" Enter the starting point : ")
        inp1 = Convert.ToInt32(Console.ReadLine())

        Console.Write(vbCrLf & " Enter the ending point : ")
        inp2 = Convert.ToInt32(Console.ReadLine())

        For i = inp1 To inp2 Step 1
            For j = 2 To i - 1 Step 1

                If i Mod j = 0 Then
                    flag = 0 'not prime
                    Exit For
                Else
                    flag = 1 'prime
                End If
            Next
            If flag Then
                System.Console.Write(" " & i & vbCrLf)
            End If
        Next
        Console.ReadLine()
    End Sub

End Module
