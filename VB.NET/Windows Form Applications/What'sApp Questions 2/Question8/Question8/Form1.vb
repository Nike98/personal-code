'
' #################################################################################################
' #################################################################################################
'
'             Create a Class Student
'             Data Members : StudentId, Name, Qualification, Percentage.
'
'             Meathods : 
'
'             GetData() - Will read information from the User and write it in a Text File
'             ShowData() - Will Display information on the Screen
'
'       Write a Windows Application. Make use of FileStream Classes for the operations.
'
'
'       For doing this:
'           1. SplitContainer is used to create two disected panels.
'           2. The 1st Panel includes the Area where the user inputs all the data.
'           3. The 2nd Panel includes a RichTextBox which Display the Data on Button click.
'           4. An Exit Button is placed outside the Main SplitContainer for the user to Exit.
'
' #################################################################################################
' #################################################################################################
'

Imports System.IO

Public Class Student

    Public Sub ClearTextBox(ByVal f As Form)

        ' Sub Procedure to clear the Form of all the Data 
        ' This procedure can be used in multiple buttons....
        For Each Ctrl In f.Controls

            ' Clear the TextBox
            If TypeOf Ctrl Is TextBox Then

                Ctrl.text = ""

            End If

        Next

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        ClearTextBox(Me)

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Public Sub GetData()

        ' Initialize the Variable which will contain the data and call the Readers
        Dim data As String = txbId.Text & " : " & txbName.Text & " : " & txbQualification.Text & " : " & txbPercentage.Text & "%"
        Dim dataStream As FileStream = Nothing
        Dim dataWriter As StreamWriter = Nothing

        Try

            ' Specify the Path where the File should be created
            ' Define the modes in which the File should operate
            dataStream = New FileStream("D:\StudentRecords.txt", FileMode.Append, FileAccess.Write)
            dataWriter = New StreamWriter(dataStream)

            ' Write the data to the File
            dataWriter.WriteLine(data)

            MsgBox(" Data Written to File", MsgBoxStyle.Information, " Save Dialog")

            ' Clear the TextBoxes after Saving Everything
            ClearTextBox(Me)

            ' Select the 1st TextBox i.e. Student Id
            txbId.Select()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.GetType.ToString)

        End Try

        dataWriter.Close()

    End Sub

    Public Sub ShowData()

        ' Declare the variables to fetch the Data from the Text file
        Dim fReader As FileStream = Nothing
        Dim dataReader As StreamReader = Nothing

        Try

            ' Define the path of the File and Set the File Modes
            fReader = New FileStream("D:\StudentRecords.txt", FileMode.Open, FileAccess.Read)
            dataReader = New StreamReader(fReader)

            ' Display all of it in the RichTextBox
            rtbMain.Text = dataReader.ReadToEnd

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.GetType.ToString)

        End Try

        dataReader.Close()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        ' Calling the Sub Procedure GetData to work
        GetData()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        ' Calling the Sub Procedure ShowData to work
        ShowData()

    End Sub
End Class
