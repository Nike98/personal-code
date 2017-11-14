
' =================================================================================================
' =================================================================================================
'
'                   Create an Array of 10 Elements and do the following :
'
'                           a. Sort the Array in Ascending Order
'                           b. Print the Sum of All the Elements
'
' =================================================================================================
' =================================================================================================

Imports System.Console

Module Module1

    Function Sum(ByVal a() As Integer)

        Dim s As Integer = 0
        Dim i As Integer

        For i = 0 To 9 Step 1

            s += a(i)

        Next

        Return s

    End Function

    Function Sortarray(ByVal a() As Integer)

        Dim i, j, temp As Integer

        For i = 0 To 9 Step 1

            For j = i + 1 To 9 Step 1

                If a(i) > a(j) Then

                    temp = a(i)
                    a(i) = a(j)
                    a(j) = temp

                End If

            Next j

        Next i

        Return a(i)

    End Function

    Sub Main()

        Dim arr(10), i, ArrSum, ArrSort As Integer

        WriteLine(" Enter the Values in the Array : " & vbCrLf)

        For i = 0 To 9 Step 1

            arr(i) = CInt(ReadLine())

        Next

        ArrSort = Sortarray(arr)



        ArrSum = Sum(arr)

        WriteLine(vbCrLf & " The Sum of the Array = " & ArrSum)

        ReadLine()

    End Sub

End Module
