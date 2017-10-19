Module Module1

    Sub Main()
        Dim i, j, flag As Integer

        For i = 1 To 100 Step 1
            For j = 2 To i - 1 Step 1
                If i Mod j = 0 Then
                    flag = 0
                    Exit For
                Else
                    flag = 1
                End If
            Next
            If flag Then
                System.Console.Write(" " & i & vbCrLf)
            End If
        Next
        Console.ReadLine()
    End Sub

End Module
