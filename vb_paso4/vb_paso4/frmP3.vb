Public Class frmP3
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmP2.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub frmP3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmP4.Show()
        Me.Hide()
    End Sub

End Class