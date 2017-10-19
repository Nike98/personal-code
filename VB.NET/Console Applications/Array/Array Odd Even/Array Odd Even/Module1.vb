' input an array of 10 elements, store even and odd number in different arrays and display contents of all the arrays.

Module Module1

    Sub Main()
        Dim arr(10) As Integer
        Dim odd_arr(10) As Integer
        Dim even_arr(10) As Integer
        Dim odd_flag, even_flag As Integer
        Dim i As Integer

        Console.WriteLine(" ********** Enter ten numbers **********")

        For i = 0 To 9 Step 1
            arr(i) = CInt(Console.ReadLine())
        Next

        Console.WriteLine(" ********** You have entered **********")

        For i = 0 To 9 Step 1
            Console.Write(" " & arr(i) & vbCrLf)
        Next

        For i = 0 To 9 Step 1
            If arr(i) Mod 2 = 0 Then
                ReDim Preserve even_arr(even_flag)
                even_arr(even_flag) = arr(i)
                even_flag = even_flag + 1
            Else
                ReDim Preserve odd_arr(odd_flag)
                odd_arr(odd_flag) = arr(i)
                odd_flag = odd_flag + 1
            End If
        Next

        Console.WriteLine(" ********** Odd Array **********")

        For i = 0 To odd_arr.Length - 1 Step 1
            Console.Write(" " & odd_arr(i).ToString & vbCrLf)
        Next

        Console.WriteLine(vbCrLf & " ********** Even Array ***********")

        For i = 0 To even_arr.Length - 1 Step 1
            Console.Write(" " & even_arr(i).ToString & vbCrLf)
        Next

        Console.ReadKey()
    End Sub

End Module
