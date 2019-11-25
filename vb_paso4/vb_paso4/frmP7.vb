Public Class frmP7
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmP6.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub frmP7_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmP8.Show()
        Me.Hide()
    End Sub

End Class