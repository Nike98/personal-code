'
' =========================================================================
' =========================================================================
'
'         If an Array contains 20 numbers, Create an Application 
'          to copy the numbers which are Prime in array.
'
' =========================================================================
' =========================================================================
'


Module Module2

    Sub Main()

        Dim i, j, arr(), size, count As Integer                                     ' Declaring the Integer Elements

        Dim primeArr(), pSize As Integer

        Console.Write(" Enter the Size of the Array : ")                            ' Getting the Size of the Array entered by the User
        size = CInt(Console.ReadLine())
        Console.WriteLine(vbCrLf)

        ReDim arr(size)                                                             ' Initializing the Size of the Array to the Integer Value Array (arr)
        ReDim primeArr(size)                                                        ' Initializing the Size of the Prime Array to the Integer size

        Console.WriteLine(" Enter the Elements of the Array : ")

        For i = 0 To size - 1 Step 1

            arr(i) = CInt(Console.ReadLine())                                       ' Getting the Array values scanned

        Next

        For i = 0 To size - 1 Step 1

            count = 0

            For j = 1 To arr(i) Step 1

                If arr(i) Mod j = 0 Then

                    count += 1                                                      ' Deriving the Prime Values from the Array

                End If

            Next

            If count = 2 Then
                primeArr(pSize) = arr(i)                                            ' Storing the Prime values in the Prime Array
                pSize += 1
            End If

        Next
        For i = 0 To pSize - 1
            Console.WriteLine(primeArr(i))                                          ' Displaying the Elements in the Prime Array
        Next
        Console.ReadLine()
    End Sub

End Module
