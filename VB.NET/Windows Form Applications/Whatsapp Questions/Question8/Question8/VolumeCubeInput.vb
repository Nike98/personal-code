Public Class FrmVolumeCubeInput

    Private Sub TxtCubeInput_TextChanged(sender As Object, e As EventArgs) Handles TxtCubeInput.TextChanged

        Dim side, volume As Double

        side = TxtCubeInput.Text

        volume = Math.Pow(side, 3)

        ResultForm.LblResult.Text = "Volume of the Cube is : " & volume.ToString

        ResultForm.Show()

        Me.Hide()

    End Sub

End Class