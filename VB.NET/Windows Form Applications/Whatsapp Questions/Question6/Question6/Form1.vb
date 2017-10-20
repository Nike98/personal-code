Public Class Frm1

    Private Sub LstB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstB1.SelectedIndexChanged

        BtnAdd.Text = LstB1.SelectedItem

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        LstB2.Items.Add(LstB1.SelectedItem)

    End Sub
End Class
