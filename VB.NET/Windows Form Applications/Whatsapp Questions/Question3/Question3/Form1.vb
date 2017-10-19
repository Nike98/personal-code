' ===========================================================================================================
' ===========================================================================================================
'
'                   Write a GUI Application which will show different colours in the list.
'                        When User will click on " SELECT " Button, then set the 
'                      backgroung colour of the application with the selected colour.
'
'                                               DIFFERENCE
'
'               1. Here there are Different buttons for the Name of colours written on them.
'               2. The Event of colour change occurs when the User Hovers Over the Button.
'
' ===========================================================================================================
' ===========================================================================================================


Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button1.MouseHover

        Me.BackColor = Color.Red

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button2.MouseHover

        Me.BackColor = Color.Green

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button3.MouseHover

        Me.BackColor = Color.Blue

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, Button4.MouseHover

        Me.BackColor = Color.Black

    End Sub

End Class
