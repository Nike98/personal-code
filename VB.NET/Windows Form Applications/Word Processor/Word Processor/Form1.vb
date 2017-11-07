Public Class FrmMain

    ' Create a Variable to Save the File Name as String
    Dim filename As String = ""

    ' Create a Variable to Save the Current State of the Document 
    ' This includes that the Document is Saved or Not So would be Boolean
    Dim StateUnsaved As Boolean

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Set the Default state of the Document to be Saved
        StateUnsaved = False

    End Sub

    Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        ' Resize the Content Box as the Size of the Document or Form Increases or Decreases
        rtbContent.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height - MainMenu.Height - TsMain.Height - 10)

    End Sub

    Private Sub rtbContent_TextChanged(sender As Object, e As EventArgs) Handles rtbContent.TextChanged, rtbContent.SizeChanged, rtbContent.StyleChanged

        ' Change the State of the Document to Unsaved when any Event has occured
        StateUnsaved = True

    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click

        ' To Cut the Selected Text in the RichTextBox
        rtbContent.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click

        ' To Copy the Selected Text in the RichTextBox
        rtbContent.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click

        ' To Paste a particular preselcted Text into the RichTextBox
        rtbContent.Paste()

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click

        ' To Select All the Content in the RichTextBox
        rtbContent.SelectAll()

    End Sub

    ' To TOggle Between Different Font Styles
    Public Sub ToggleStyle(NewStyle As FontStyle)


        ' Steps : 
        '   1. Save the Current Font Style to a variable
        '   2. Check what you want to Toggle ?
        '   3. Check if the Style is Off...
        '   4. Add the Style
        '   5. Turn it Off
        '   6. Repeat it.....


        Dim currentStyle As FontStyle = rtbContent.SelectionFont.Style

        If NewStyle = FontStyle.Bold Then

            If rtbContent.SelectionFont.Bold = False Then

                currentStyle += FontStyle.Bold

            Else

                currentStyle -= FontStyle.Bold

            End If

        ElseIf NewStyle = FontStyle.Italic Then

            If rtbContent.SelectionFont.Italic = False Then

                currentStyle += FontStyle.Italic

            Else

                currentStyle -= FontStyle.Italic

            End If

        ElseIf NewStyle = FontStyle.Underline Then

            If rtbContent.SelectionFont.Underline = False Then

                currentStyle += FontStyle.Underline

            Else

                currentStyle -= FontStyle.Underline

            End If

        ElseIf NewStyle = FontStyle.Strikeout Then

            If rtbContent.SelectionFont.Strikeout = False Then

                currentStyle += FontStyle.Strikeout

            Else

                currentStyle -= FontStyle.Strikeout

            End If
        End If

        ' Replace the current font with New Style
        rtbContent.SelectionFont = New Font(rtbContent.SelectionFont, currentStyle)

    End Sub

    Private Sub tsbBold_Click(sender As Object, e As EventArgs) Handles tsbBold.Click

        ToggleStyle(FontStyle.Bold)                     ' Setting the Style to Bold

    End Sub

    Private Sub tsbItalic_Click(sender As Object, e As EventArgs) Handles tsbItalic.Click

        ToggleStyle(FontStyle.Italic)                   ' Setting the Style to Italic

    End Sub

    Private Sub tsbUnderline_Click(sender As Object, e As EventArgs) Handles tsbUnderline.Click

        ToggleStyle(FontStyle.Underline)                ' Setting the Style to Underline

    End Sub

    Private Sub tsbStrike_Click(sender As Object, e As EventArgs) Handles tsbStrike.Click

        ToggleStyle(FontStyle.Strikeout)                ' Setting the Style to Strikeout

    End Sub

    Private Sub tscbFontSize_TextChanged(sender As Object, e As EventArgs) Handles tscbFontSize.TextChanged

        ' Convert the number to Single DataType
        Dim newSize As Single = Convert.ToSingle(tscbFontSize.Text)

        ' Apply the new Size to the Text Document
        rtbContent.SelectionFont = New Font(rtbContent.SelectionFont.FontFamily, newSize)

    End Sub

    Private Sub PictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureToolStripMenuItem.Click

        ' Set the File filter
        OpenDiag.Filter = "Image Files | *.jpg;*.png;*.tiff;*.gif;*.bmp"

        ' Check if the User presses the OK Button
        If OpenDiag.ShowDialog = DialogResult.OK Then

            ' Load the Picture
            Dim img As Image = Image.FromFile(OpenDiag.FileName)

            ' Copy the Image into the Clipboard
            Clipboard.SetImage(img)

            ' Paste the Image into the RichTextBox
            rtbContent.Paste()

        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

        ' Open the Save File Dialog
        If SaveFileDiag.ShowDialog = DialogResult.OK Then

            ' Save the File
            rtbContent.SaveFile(SaveFileDiag.FileName)

            ' Set the Document to be Saved
            StateUnsaved = False

            ' Remember the File Name
            filename = SaveFileDiag.FileName

            ' Set the Form's Title as the Filname
            Me.Text = "Word Processor - " & IO.Path.GetFileName(filename)

        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        ' Check if the File has been Saved
        If filename = "" Then

            ' Call the Save As Button
            SaveAsToolStripMenuItem_Click(Nothing, Nothing)         ' As giving 2 parameters is neccessary as per the previous Sub Function has

        Else

            ' Save the File
            rtbContent.SaveFile(filename)
            StateUnsaved = False

        End If

    End Sub

    Public Sub CheckStateUnsaved()

        ' Check that the File is Saved or Not
        If StateUnsaved = True Then

            If MessageBox.Show("There are some Unsaved changes you made in the Document. Do you want to Save them ? ", "Save The Unsaved !", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                SaveToolStripMenuItem_Click(Nothing, Nothing)

            End If

        End If

    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click

        ' First thing is to check that the File is Saved or Not
        CheckStateUnsaved()

        ' Close the Form
        Me.Close()

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        ' Check if the Current Document is Saved
        CheckStateUnsaved()

        ' Setup the New Text Box
        ' Set everything to be Default and Normal
        filename = ""
        StateUnsaved = False
        Me.Text = "Word Processor"
        rtbContent.ResetText()

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        ' Check if the Current Document is Saved
        CheckStateUnsaved()

        ' Change the OpenFileDialog File Filter
        OpenDiag.Filter = "Rich Text File Document | *.rtf"

        ' Show the OpenFileDialog
        rtbContent.LoadFile(OpenDiag.FileName)

        ' State the Default state of the File to be Saved
        StateUnsaved = False

        ' Set the Filename as the Selected Filename and Display it on the top
        filename = OpenDiag.FileName
        Me.Text = "Word Processor - " & IO.Path.GetFileName(filename)

    End Sub

    Private Sub tsbNew_Click(sender As Object, e As EventArgs) Handles tsbNew.Click

        NewToolStripMenuItem_Click(Nothing, Nothing)

    End Sub

    Private Sub tsbOpen_Click(sender As Object, e As EventArgs) Handles tsbOpen.Click

        OpenToolStripMenuItem_Click(Nothing, Nothing)

    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click

        SaveToolStripMenuItem_Click(Nothing, Nothing)

    End Sub

End Class
