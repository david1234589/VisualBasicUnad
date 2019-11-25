Public Class frmP0
    Private Sub frmP0_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_dir As String = Application.ExecutablePath
        Dim directory() As String
        Dim finalDir As String = ""

        directory = current_dir.Split("\")
        For dir As Integer = 0 To directory.Length - 4

            finalDir += directory(dir) + "\"

        Next

        finalDir += "src\vid\BDR2.mp4"

        AxWindowsMediaPlayer1.URL = finalDir
    End Sub

    Private Sub frmP0_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        frmInit.Show()
        Me.Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        frmP1.Show()
        Me.Hide()
    End Sub
End Class