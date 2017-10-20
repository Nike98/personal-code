Public Class Form1

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Timer1.Start()

        Timer2.Stop()
        Timer3.Stop()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        OvalShape1.FillStyle = PowerPacks.FillStyle.Solid
        OvalShape1.FillColor = Color.Red
        Timer2.Start()
        OvalShape2.FillStyle = PowerPacks.FillStyle.Transparent
        OvalShape3.FillStyle = PowerPacks.FillStyle.Transparent
        Timer1.Stop()
        Timer3.Stop()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        OvalShape2.FillStyle = PowerPacks.FillStyle.Solid
        OvalShape2.FillColor = Color.Yellow
        Timer3.Start()
        OvalShape1.FillStyle = PowerPacks.FillStyle.Transparent

        OvalShape3.FillStyle = PowerPacks.FillStyle.Transparent
        Timer2.Stop()
        Timer1.Stop()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        OvalShape3.FillStyle = PowerPacks.FillStyle.Solid
        OvalShape3.FillColor = Color.Green
        Timer1.Start()
        OvalShape1.FillStyle = PowerPacks.FillStyle.Transparent
        OvalShape2.FillStyle = PowerPacks.FillStyle.Transparent
        Timer3.Stop()
        Timer2.Stop()
    End Sub
End Class
