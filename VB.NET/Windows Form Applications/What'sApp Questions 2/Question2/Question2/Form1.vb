'
' =============================================================================
' =============================================================================
' 
'        Create a GUI Application to Copy the contents of one Text File 
'              to another Checking if the Original file exists.
'
' =============================================================================
' =============================================================================

Imports System.IO


Public Class Frm1

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub BtnCpy_Click(sender As Object, e As EventArgs) Handles BtnCpy.Click

        CopyFileContents("D:\TextData", "D:\TextByStreamWriter")

    End Sub

    Public Sub CopyFileContents(ByVal f1 As String, f2 As String)

        Dim str As String = Nothing

        Try

            ' Reading the 1st File
            Dim str1 As String = Nothing
            Using fReader1 As StreamReader = New StreamReader(New FileStream(f1, FileMode.Open, FileAccess.Read))

                str1 = fReader1.ReadToEnd

            End Using

            ' Reading the 2nd File
            Dim str2 As String
            Using fReader2 As StreamReader = New StreamReader(New FileStream(f2, FileMode.Open, FileAccess.Read))

                str2 = fReader2.ReadToEnd

            End Using

            ' Comparing Both of thm for Similarities
            If StrComp(str1, str2) = 0 Then

                MsgBox("Both the Files have the Same Content", MsgBoxStyle.Critical, " Duplication Message")

            Else

                Dim fStr As FileStream = Nothing
                Dim streamWrite As StreamWriter = Nothing

                fStr = New FileStream(f2, FileMode.Append, FileAccess.Write)
                streamWrite = New StreamWriter(fStr)

                streamWrite.WriteLine(str2)

                MsgBox("Data Written to Other Text File", MsgBoxStyle.Exclamation, "Append Done")

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.GetType.ToString)

        End Try

    End Sub

End Class
