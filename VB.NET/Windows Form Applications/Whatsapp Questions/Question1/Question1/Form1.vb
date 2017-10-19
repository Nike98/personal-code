'
' ===========================================================================================================
' ===========================================================================================================
'
'                   Take L1 & L2 and 4 Buttons viz. Add, AddAll, Delete, DeleteAll.
'                       When Add is Clicked, item from L1 should egt added to L2.
'                   When Delete is clicked, selected item from L2 should get Deleted.
'           Similarly when AddAll / DeleteAll, are clicked, it should addall / deleteall elements.
'
' ===========================================================================================================
' ===========================================================================================================

Public Class Form1

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        L2.Items.Add(L1.SelectedItem)

    End Sub

    Private Sub BtnAddAll_Click(sender As Object, e As EventArgs) Handles BtnAddAll.Click

        L2.Items.Clear()

        L2.Items.AddRange(L1.Items)

    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click

        L2.Items.Remove(L2.SelectedItem)

    End Sub

    Private Sub ButtonDelAll_Click(sender As Object, e As EventArgs) Handles ButtonDelAll.Click

        L2.Items.Clear()

    End Sub
End Class
