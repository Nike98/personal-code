'
' =========================================================================
' =========================================================================
'
'         If an Array contains 20 numbers, Create an Application 
'          to copy the numbers which are Prime in a Text File.
'
' =========================================================================
' =========================================================================
'

Imports System.IO


Module Module1

    Sub Main()

        Dim i, j, arr(), size, count As Integer                                     ' Initializing the Iteger Elements

        Dim primeTxt As New StreamWriter("D:\PrimeNos.txt")                         ' Initializing and Creating the Text File in which the Prime Numbers are to be Printed

        Console.Write(" Enter the Size of the Array : ")                            ' Entering the Size of the Array by the User
        size = CInt(Console.ReadLine())
        Console.WriteLine(vbCrLf)

        ReDim arr(size)                                                             ' Initializing the Size of the Array to the Integer Value Array (arr)

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

                Console.Write(arr(i) & vbTab)
                primeTxt.WriteLine(arr(i))                                          ' Printing the Array values to the Text File

            End If

        Next

        primeTxt.Close()
        Console.ReadKey()
    End Sub

End Module
