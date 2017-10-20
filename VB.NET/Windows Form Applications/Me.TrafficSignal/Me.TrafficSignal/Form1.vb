Public Class Frm1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        OvalShapeRed.FillStyle = PowerPacks.FillStyle.Solid
        OvalShapeRed.FillColor = Color.Red

        Me.Timer2.Start()

        OvalShapeYellow.FillStyle = PowerPacks.FillStyle.Transparent
        OvalShapeGreen.FillStyle = PowerPacks.FillStyle.Transparent

        Me.Timer1.Stop()
        Me.Timer3.Stop()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        OvalShapeYellow.FillStyle = PowerPacks.FillStyle.Solid
        OvalShapeYellow.FillColor = Color.Yellow

        Me.Timer3.Start()

        OvalShapeRed.FillStyle = PowerPacks.FillStyle.Transparent
        OvalShapeGreen.FillStyle = PowerPacks.FillStyle.Transparent

        Me.Timer1.Stop()
        Me.Timer2.Stop()

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        OvalShapeGreen.FillStyle = PowerPacks.FillStyle.Solid
        OvalShapeGreen.FillColor = Color.Green

        Me.Timer1.Start()

        OvalShapeRed.FillStyle = PowerPacks.FillStyle.Transparent
        OvalShapeYellow.FillStyle = PowerPacks.FillStyle.Transparent

        Me.Timer2.Stop()
        Me.Timer3.Stop()

    End Sub

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click

        Me.Timer1.Start()
        Me.Timer2.Stop()
        Me.Timer3.Stop()

    End Sub

End Class
