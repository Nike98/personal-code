Public Class FrmAreaCircleInput

    Private Sub BtnArCircle_Click(sender As Object, e As EventArgs) Handles BtnArCircle.Click

        Dim radius, area As Double

        radius = CDbl(TxtArCirInput.Text)

        area = 3.142857 * radius * radius

        ResultForm.LblResult.Text = "Area of the Circle is : " & area.ToString

        ResultForm.Show()

        Me.Hide()

    End Sub

End Class