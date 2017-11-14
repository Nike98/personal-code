' Imput an Array of 10 elements
' Store the Even Numbers in Even Array and Odd Numbers in Odd Array
' Display the contents of all the Arrays........

Imports System.Console

Module Module1

    Sub Main()

        Dim arr(10), i, oddArr(10), evenArr(10), line As Integer
        Dim even_flag, odd_flag As Integer


        ' Getting the Number of values the User wants to enter
        Write(" Enter the Number of Inputs : ")
        line = CInt(ReadLine())

        For i = 1 To line Step 1

            ' Getting the Inputs of the Array Values the User wants to enter
            Write(" Enter the value of arr[" & i & "] : ")
            arr(i) = CInt(ReadLine())
            Write(vbCrLf)

        Next

        For i = 1 To line Step 1

            If arr(i) Mod 2 = 0 Then

                ' Saving the Even Elemets in the Even Array
                ' Using ReDim and Preserve Keywords we Preserve the previous value and take in the new value
                ReDim Preserve evenArr(even_flag)
                evenArr(even_flag) = arr(i)
                even_flag += 1

            End If

            If arr(i) Mod 2 <> 0 Then

                'Saving the Odd Elemets in the Odd Array
                ' Using ReDim and Preserve Keywords we Preserve the previous value and take in the new value
                ReDim Preserve oddArr(odd_flag)
                oddArr(odd_flag) = arr(i)
                odd_flag += 1

            End If

        Next

        ' Displaying all the Even Elements
        ' Saved in the Even Array

        WriteLine(vbCrLf & " The Even Elements Of The Array Are ..............")

        For i = 0 To evenArr.Length - 1 Step 1

            WriteLine(" " & evenArr(i).ToString)

        Next

        ' Displaying all the Odd Elements
        ' Saved in the Odd Array

        WriteLine(vbCrLf & " The Even Elements Of The Array Are ..............")

        For i = 0 To oddArr.Length - 1 Step 1

            WriteLine(" " & oddArr(i).ToString)

        Next

        ReadLine()

    End Sub

End Module
