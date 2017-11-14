'
' =========================================================================
' =========================================================================
'
'           Write a program to Create a Text File at runtime having 
'          text " Hello Student " And then Read the File and Display 
'               the content Of the file In a RichTextBox.
'
' =========================================================================
' =========================================================================


Imports System.IO
Imports System.Text


Public Class Frm1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim line As String = Nothing
        Dim fs As FileStream = Nothing
        Dim fs1 As FileStream = Nothing
        Dim streamWrite As StreamWriter = Nothing
        Dim streamReader As StreamReader = Nothing
        Try
            fs = New FileStream("D:\Student.txt", FileMode.Create, FileAccess.Write)
            streamWrite = New StreamWriter(fs)

            streamWrite.WriteLine("Hello Student!!")
            streamWrite.Close()
            'MsgBox("Data written to file", MsgBoxStyle.Information, "Save")

            fs1 = New FileStream("D:\Student.txt", FileMode.Open, FileAccess.Read)
            streamReader = New StreamReader(fs1)
            line = streamReader.ReadLine
            streamReader.Close()
            RichTextBox1.Text = line

        Catch ex As IOException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.GetType.ToString)
        End Try


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Me.Dispose()
        Me.Close()

    End Sub

End Class
