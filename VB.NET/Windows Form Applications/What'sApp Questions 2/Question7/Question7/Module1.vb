'
' =========================================================================
' =========================================================================
'
'                 Create an Application to Append the 
'                   content of one file to another.
'
' =========================================================================
' =========================================================================
'

Imports System.Console
Imports System.IO


Module Module1

    Sub Main()

        AppendContent("D:\TextData", "D:\TextByStreamWriter")

        ReadLine()

    End Sub

    Function AppendContent(ByVal f1 As String, ByVal f2 As String)

        Try

            Dim str As String = Nothing

            Using sReader As StreamReader = New StreamReader(New FileStream(f1, FileMode.Open, FileAccess.Read))

                str = sReader.ReadToEnd

            End Using

            Using fAppend As StreamWriter = New StreamWriter(New FileStream(f2, FileMode.Append))

                fAppend.WriteLine(str)

            End Using

            WriteLine(" Content of ' " & f1 & " ' copied to ' " & f2 & " '")

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.GetType.ToString)

        End Try

        Return 0

    End Function

End Module
