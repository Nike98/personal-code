Public Class FrmOption

    Private Sub RadBtnCheckChanged(sender As Object, e As EventArgs) Handles RadArCir.CheckedChanged, RadArTriangle.CheckedChanged, RadVolCube.CheckedChanged

        If RadArCir.Checked Then

            FrmAreaCircleInput.Show()

        Else

            FrmAreaCircleInput.Hide()

        End If

        If RadArTriangle.Checked Then

            FrmAreaTriangleInput.Show()

        Else

            FrmAreaTriangleInput.Hide()

        End If

        If RadVolCube.Checked Then

            FrmVolumeCubeInput.Show()

        Else

            FrmVolumeCubeInput.Hide()

        End If

    End Sub

    Private Sub FrmOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RadArCir.Checked = False
        RadArTriangle.Checked = False
        RadVolCube.Checked = False

    End Sub

End Class
