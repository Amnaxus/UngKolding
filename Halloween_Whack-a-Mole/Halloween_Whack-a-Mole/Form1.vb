Public Class Form1
    Dim Speed As Double
    Dim Score As Integer
    Dim Pumpkins(4) As PictureBox
    Dim r As Random = New Random
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Speed = 1
        Pumpkins(0) = Pumpkin1
        Pumpkins(1) = Pumpkin2
        Pumpkins(2) = Pumpkin3
        Pumpkins(3) = Pumpkin4
        Pumpkins(4) = Pumpkin5
        For x As Integer = 0 To 4
            Whack(Pumpkins(x))
        Next
        PumpkinMover.Start()
    End Sub

    Private Sub Whack(sender As Object)
        sender.top = -1 * r.Next(75, 300)
        sender.left = r.Next(0, 445)
    End Sub

    Private Sub Speedster(score As Integer)
        If score Mod 10 = 0 Then
            Speed = Speed + 1
        End If
    End Sub

    Private Sub Endgame()
        PumpkinMover.Stop()
        Label2.Text = "Game Over" & Environment.NewLine & "Score: " & Score
        Label2.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub PumpkinMover_Tick(sender As Object, e As EventArgs) Handles PumpkinMover.Tick

        For x As Integer = 0 To 4
            Pumpkins(x).Top += Speed
            If Pumpkins(x).Top >= Me.Height Then
                'Pumpkins(x).Top = 0
                Endgame()
            End If
        Next


    End Sub

    Private Sub Pumpkin1_Click(sender As Object, e As EventArgs) Handles Pumpkin1.Click
        Whack(Pumpkin1)
        Score += 1
        Speedster(Score)
        Label1.Text = "Score: " & Score
    End Sub

    Private Sub Pumpkin2_Click(sender As Object, e As EventArgs) Handles Pumpkin2.Click
        Whack(Pumpkin2)
        Score += 1
        Speedster(Score)
        Label1.Text = "Score: " & Score
    End Sub

    Private Sub Pumpkin3_Click(sender As Object, e As EventArgs) Handles Pumpkin3.Click
        Whack(Pumpkin3)
        Score += 1
        Speedster(Score)
        Label1.Text = "Score: " & Score
    End Sub

    Private Sub Pumpkin4_Click(sender As Object, e As EventArgs) Handles Pumpkin4.Click
        Whack(Pumpkin4)
        Score += 1
        Speedster(Score)
        Label1.Text = "Score: " & Score
    End Sub

    Private Sub Pumpkin5_Click(sender As Object, e As EventArgs) Handles Pumpkin5.Click
        Whack(Pumpkin5)
        Score += 1
        Speedster(Score)
        Label1.Text = "Score: " & Score
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(sender, e)
    End Sub
End Class
