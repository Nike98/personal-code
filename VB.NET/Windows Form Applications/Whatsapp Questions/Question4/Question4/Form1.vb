' ===========================================================================================================
' ===========================================================================================================
'
'                    Create a Window that has Text Object Label as " Hello World ".
'           The window has a Button which says " Change Me ". When the Button is Clicked Once,
'                           the Text of the Label changes to " GoodBye ".
'
' ===========================================================================================================
' ===========================================================================================================


Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = "GoodBye !!!"

    End Sub

End Class
