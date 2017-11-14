'
' =========================================================================
' =========================================================================
'
'       Create a Console Application which will Read a Text File
'
' =========================================================================
' =========================================================================
'

Imports System.Console
Imports System.IO


Module Module1

    Sub Main()

        Try

            ' Getting the File path by the User

            Dim path As String

            Write(" Enter the File Path : ")
            path = ReadLine()
            WriteLine(vbCrLf)

            ' Reading the File and Storing the data in a String variable

            Using sReader As New StreamReader(path)

                Dim data As String
                data = sReader.ReadToEnd

                ' Displaying the Data on the Console

                WriteLine(" The File Data includes ......." & vbCrLf)
                WriteLine(data)

            End Using

        Catch ex As Exception

            MsgBox("No Such file or directory exists. The Path is not specified properly", MsgBoxStyle.Critical)

        End Try

        ReadLine()

    End Sub

End Module
