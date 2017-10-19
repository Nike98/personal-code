Public Class FrmAreaTriangleInput

    Private Sub BtnArTriangle_Click(sender As Object, e As EventArgs) Handles BtnArTriangle.Click

        Dim base, height, area As Double

        base = TxtTriBase.Text
        height = TxtTriHeight.Text

        area = (0.5 * base) / height

        ResultForm.LblResult.Text = "Area of the Triangle is : " & area.ToString

        ResultForm.Show()

        Me.Hide()

    End Sub

End Class