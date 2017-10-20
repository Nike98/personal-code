Imports System.Console

Module Module1

    Sub Main()
        Dim choice As Integer

        Write(" 1....")
        Write(vbCrLf & " 2.....")
        Write(vbCrLf & " 3.....")
        Write(vbCrLf & " 4.....")
        Write(vbCrLf & " 5.....Exit" & vbCrLf)
        Write(vbCrLf & " Enter your Choice : ")

        Select Case choice
            Case 1
                WriteLine(vbCrLf & " YOU HAVE SELECTED FOR CASE 1")

            Case 2
                WriteLine(vbCrLf & " YOU HAVE SELECTED FOR CASE 2")

            Case 3
                WriteLine(vbCrLf & " YOU HAVE SELECTED FOR CASE 3")

            Case 4
                WriteLine(vbCrLf & " YOU HAVE SELECTED FOR CASE 4")

            Case Else
                WriteLine(vbCrLf & " YOU HAVE SELECTED FOR EXITING THE PROGRAM")

        End Select

        ReadLine()

    End Sub

End Module
