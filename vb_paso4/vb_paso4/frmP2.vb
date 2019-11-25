Public Class frmP2
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmP1.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub frmP2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmP3.Show()
        Me.Hide()
    End Sub

End Class