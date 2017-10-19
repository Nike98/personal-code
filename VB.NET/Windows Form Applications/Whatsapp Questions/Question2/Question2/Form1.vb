
' ===========================================================================================================
' ===========================================================================================================
'
'                    Design a windows Form Application that accepts color from the TextBox,
'                   Add that color in the ComboBox ( Check for Duplication ), when you click 
'                                   on a perticular color in the ComboBox.
'                                    Change the Form color accordingly.
'
' ===========================================================================================================
' ===========================================================================================================

Public Class Form1

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        If Not ComboBoxColors.Items.Contains(TextBoxInput.Text.ToUpper) Then

            ComboBoxColors.Items.Add(TextBoxInput.Text.ToUpper)
            LabelMsg.Text = "Color " & TextBoxInput.Text.ToUpper & " is Added in the List."
            TextBoxInput.Text = ""
            TextBoxInput.Focus()

        Else

            LabelMsg.Text = " The Color of this Name already Exists"

        End If

    End Sub

    Private Sub ComboBoxColors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxColors.SelectedIndexChanged

        Try

            Dim SelectedColor As String = ComboBoxColors.SelectedItem
            Dim C As Color

            C = Color.FromName(SelectedColor)
            Me.BackColor = C

        Catch ex As Exception

            MsgBox("Color does not Exist.", MsgBoxStyle.RetryCancel)

        End Try

    End Sub

End Class
