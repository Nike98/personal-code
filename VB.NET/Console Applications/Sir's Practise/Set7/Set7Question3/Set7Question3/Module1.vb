'
' #############################################################################
' #############################################################################
'
'           WAP to display all perfect numbers between 1 to 1000
' 
'           A Perfect Number is a number which is 
'           the proper sum Of  it's proper Divisors
'
'           Eg: 
'               6 = 1 + 2 + 3
'               28 = 1 + 2 + 3 + 4 + 5 + 6 + 7
'
' #############################################################################
' #############################################################################
'

Imports System.Console

Module Module1

    Sub Main()

        Dim min, max, p, r, sum As Integer

        'Write(" Enter the Number : ")
        max = 1000
        min = 1

        WriteLine(" The Perfect Numbers Are : " & vbCrLf)

        While min <= max

            p = 1
            sum = 0

            While p < min

                r = min Mod p

                If r = 0 Then
                    sum += p
                End If

                p += 1

            End While

            If sum = min Then
                WriteLine(" " & min.ToString)
            End If

            min += 1

        End While

        ReadLine()

    End Sub

End Module
