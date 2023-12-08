Public Class Form2
    Public PlayerChoise As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayerChoise = 1
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PlayerChoise = 2
        Form1.Show()
        Me.Hide()
    End Sub


End Class