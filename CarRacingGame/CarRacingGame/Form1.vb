Public Class Form1
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
        RacerMover1.Start()
        RacerMover2.Start()
        RacerMover3.Start()
    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

        If score > 10 And score < 30 Then
            speed = 5
        End If
        If score > 30 And score < 50 Then
            speed = 6
        End If
        If score > 50 And score < 70 Then
            speed = 7
        End If
        If score > 70 And score < 90 Then
            speed = 8
        End If
        If score > 90 And score < 110 Then
            speed = 9
        End If
        If score > 110 Then
            speed = 10
        End If

        Label1.Text = "Speed " & speed
        If Car.Bounds.IntersectsWith(Racer1.Bounds) Then
            endgame()
        End If
        If Car.Bounds.IntersectsWith(Racer2.Bounds) Then
            endgame()
        End If
        If Car.Bounds.IntersectsWith(Racer3.Bounds) Then
            endgame()
        End If
    End Sub

    Private Sub endgame()
        Button1.Visible = True
        Label3.Visible = True
        RoadMover.Stop()
        RacerMover1.Stop()
        RacerMover2.Stop()
        RacerMover3.Stop()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            RightSide.Start()
        End If

        If e.KeyCode = Keys.Left Then
            LeftSide.Start()
        End If
    End Sub

    Private Sub RightSide_Tick(sender As Object, e As EventArgs) Handles RightSide.Tick
        If Car.Left < 283 Then
            Car.Left += 5
        End If
    End Sub

    Private Sub LeftSide_Tick(sender As Object, e As EventArgs) Handles LeftSide.Tick
        If Car.Left > 0 Then
            Car.Left -= 5
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightSide.Stop()
        LeftSide.Stop()
    End Sub

    Private Sub RacerMover1_Tick(sender As Object, e As EventArgs) Handles RacerMover1.Tick
        Racer1.Top += speed / 2
        If Racer1.Top >= Me.Height Then
            Randomize()
            score += 1
            Label2.Text = "Score " & score
            Racer1.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + Racer1.Height)
            Racer1.Left = CInt(Math.Ceiling(Rnd() * 75))
        End If
    End Sub

    Private Sub RacerMover2_Tick(sender As Object, e As EventArgs) Handles RacerMover2.Tick
        Racer2.Top += speed / 3
        If Racer2.Top >= Me.Height Then
            Randomize()
            score += 1
            Label2.Text = "Score " & score
            Racer2.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + Racer2.Height)
            Racer2.Left = CInt(Math.Ceiling(Rnd() * 75)) + 100
        End If
    End Sub

    Private Sub RacerMover3_Tick(sender As Object, e As EventArgs) Handles RacerMover3.Tick
        Racer3.Top += speed * 2 / 3
        If Racer3.Top >= Me.Height Then
            Randomize()
            score += 1
            Label2.Text = "Score " & score
            Racer3.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + Racer3.Height)
            Racer3.Left = CInt(Math.Ceiling(Rnd() * 75)) + 200
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(sender, e)
    End Sub
End Class
