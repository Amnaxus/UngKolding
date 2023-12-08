Public Class Form1
    Dim rnd As New Random
    Dim n As Integer = rnd.Next(0, 705)
    Dim speed As Integer = 3

    Sub checker()
        If Math.Abs(knap.Left - n) <= 5 Then
            n = rnd.Next(0, 705)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        checker()
        If knap.Left - n > 0 Then
            knap.Left -= speed
        ElseIf knap.Left - n < 0 Then
            knap.Left += speed
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub knap_Click(sender As Object, e As EventArgs) Handles knap.Click
        knap.BackColor = Color.Black
    End Sub
End Class
