'
' =============================================================================
' =============================================================================
'
'               Write a Function in VB.NET to copy the Elements
'                        of one Text File to another.
' 
' =============================================================================
' =============================================================================

Imports System.IO
Imports System.Console


Module Module1

    Sub Main()

        CopyFileContent("D:\TextData", "D:\TextByStreamWriter")

        ReadLine()

    End Sub

    Function CopyFileContent(ByVal f1 As String, ByVal f2 As String)

        Dim str As String = Nothing

        Using sReader As StreamReader = New StreamReader(New FileStream(f1, FileMode.Open, FileAccess.Read))
            str = sReader.ReadToEnd
        End Using

        Using sWriter As StreamWriter = New StreamWriter(New FileStream(f2, FileMode.Open, FileAccess.Write))

            sWriter.WriteLine(str)

        End Using

        WriteLine(" Content of ' " & f1 & " ' copied to ' " & f2 & " '")

        Return 0

    End Function

End Module
