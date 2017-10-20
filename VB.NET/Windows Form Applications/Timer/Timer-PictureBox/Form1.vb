Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim myX As Point = New Point(Me.Size.Width)
        If PictureBox1.Location.X = 400 Then
            PictureBox1.Location = New Point(0, 0)
        Else
            PictureBox1.Location = New Point(PictureBox1.Location.X + 10, PictureBox1.Location.Y)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If PictureBox2.Left < 400 Then
            PictureBox2.Left = PictureBox2.Left + 10
        Else
            PictureBox2.Left = 0
        End If
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
