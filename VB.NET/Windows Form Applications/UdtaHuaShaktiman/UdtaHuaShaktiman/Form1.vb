Public Class Frm1

    Private Sub BtnTaher_Click(sender As Object, e As EventArgs) Handles BtnTaher.Click

        TmrTaher.Start()

    End Sub

    Private Sub TmrTaher_Tick(sender As Object, e As EventArgs) Handles TmrTaher.Tick

        Dim myX As Point = New Point(Me.Size.Width)

        If TaherShah.Location.X = 600 Then

            TaherShah.Location = New Point(0, 0)

        Else

            TaherShah.Location = New Point(TaherShah.Location.X + 20, TaherShah.Location.Y)

        End If

    End Sub

    Private Sub BtnShakti_Click(sender As Object, e As EventArgs) Handles BtnShakti.Click

        TmrShakti.Start()

    End Sub

    Private Sub TmrShakti_Tick(sender As Object, e As EventArgs) Handles TmrShakti.Tick

        If Shaktimaan.Left < 600 Then

            Shaktimaan.Left = Shaktimaan.Left + 20

        Else

            Shaktimaan.Left = 0

        End If

    End Sub

    Private Sub StopBtn_Click(sender As Object, e As EventArgs) Handles StopBtn.Click

        TmrTaher.Stop()
        TmrShakti.Stop()

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click

        Me.Close()

    End Sub

End Class
