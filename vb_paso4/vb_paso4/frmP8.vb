﻿Public Class frmP8
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmP7.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub frmP8_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmP9.Show()
        Me.Hide()
    End Sub

End Class