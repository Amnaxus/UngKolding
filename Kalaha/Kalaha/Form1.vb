Public Class Form1
    Dim wells(13) As Label
    Dim handful As Integer
    Dim pocket As Integer
    Dim player As Integer = 1
    Dim target As Point 'denotes the intended location of the button. For a label, that is the midpoint + (-50, -50) because of the button size (100,100)
    Dim specRule1_13(1) As Label
    Dim specRule2_12(1) As Label
    Dim specRule3_11(1) As Label
    Dim specRule4_10(1) As Label
    Dim specRule5_9(1) As Label
    Dim specRule6_8(1) As Label
    Dim ending As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If player Mod 2 = 1 Then
            Button1.Location = New Point(98, 422)
        Else
            Button1.Location = New Point(989, 39)
        End If
        target = New Point(Button1.Left + Button1.Width / 2, Button1.Top + Button1.Height / 2)
        wells(0) = Label1
        wells(1) = Label2
        wells(2) = Label3
        wells(3) = Label4
        wells(4) = Label5
        wells(5) = Label6
        wells(6) = Label7
        wells(7) = Label8
        wells(8) = Label9
        wells(9) = Label10
        wells(10) = Label11
        wells(11) = Label12
        wells(12) = Label13
        wells(13) = Label14
        'special rules are designed so player 1's well (player mod 2) is assigned index 1 for special rule
        'player 2's well is then given index 0 (player mod 2)
        specRule1_13(1) = Label1
        specRule1_13(0) = Label13
        specRule2_12(1) = Label2
        specRule2_12(0) = Label12
        specRule3_11(1) = Label3
        specRule3_11(0) = Label11
        specRule4_10(1) = Label4
        specRule4_10(0) = Label10
        specRule5_9(1) = Label5
        specRule5_9(0) = Label9
        specRule6_8(1) = Label6
        specRule6_8(0) = Label8
    End Sub
    Private Sub MovePellets(pocket As Integer)
        handful = wells(pocket - 1).Text
        target = New Point(wells((pocket - 1) Mod 14).Left + wells((pocket - 1) Mod 14).Width / 2 - 50, wells((pocket - 1) Mod 14).Top + wells((pocket - 1) Mod 14).Height / 2 - 50)
        MoveHand()
        Button1.Text = handful
        wells(pocket - 1).Text = "0"

        For i As Integer = 0 To handful - 1
            'if player 1 gets to pocket 14, or player 2 gets to pocket 7, then should not put one in.
            If player Mod 2 = 1 And (pocket + i + 1) Mod 14 = 0 Then
                pocket += 1
            ElseIf player Mod 2 = 0 And (pocket + i + 1) Mod 14 = 7 Then
                pocket += 1
            End If
            target = New Point(wells((pocket + i) Mod 14).Left + wells((pocket + i) Mod 14).Width / 2 - 50, wells((pocket + i) Mod 14).Top + wells((pocket + i) Mod 14).Height / 2 - 50)
            MoveHand()
            Button1.Text -= 1 '= handful - 1 - i
            wells((pocket + i) Mod 14).Text += 1

            If i = handful - 1 Then 'last dropped pellet
                If wells((pocket + i) Mod 14).Text = 1 Then 'last dropped pellet into an empty well
                    If (pocket + i) Mod 14 < 6 And player Mod 2 = 1 Then 'last dropped on player 1 side at player 1 turn
                        Select Case (pocket + i + 1) Mod 14 'modifying identifier to match label index
                            Case 1
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label1.Left + Label1.Width / 2 - 50, Label1.Top + Label1.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label1.Text
                                Label1.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label13.Left + Label13.Width / 2 - 50, Label13.Top + Label13.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label13.Text
                                Label13.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                            Case 2
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label2.Left + Label2.Width / 2 - 50, Label2.Top + Label2.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label2.Text
                                Label2.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label12.Left + Label12.Width / 2 - 50, Label12.Top + Label12.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label12.Text
                                Label12.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                            Case 3
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label3.Left + Label3.Width / 2 - 50, Label3.Top + Label3.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label3.Text
                                Label3.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label11.Left + Label11.Width / 2 - 50, Label11.Top + Label11.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label11.Text
                                Label11.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                            Case 4
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label4.Left + Label4.Width / 2 - 50, Label4.Top + Label4.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label4.Text
                                Label4.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label10.Left + Label10.Width / 2 - 50, Label10.Top + Label10.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label10.Text
                                Label10.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                            Case 5
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label5.Left + Label5.Width / 2 - 50, Label5.Top + Label5.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label5.Text
                                Label5.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label9.Left + Label9.Width / 2 - 50, Label9.Top + Label9.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label9.Text
                                Label9.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                            Case 6
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label6.Left + Label6.Width / 2 - 50, Label6.Top + Label6.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label6.Text
                                Label6.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label8.Left + Label8.Width / 2 - 50, Label8.Top + Label8.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label8.Text
                                Label8.Text = "0"
                                target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                                MoveHand()
                                Label7.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                        End Select
                    ElseIf (pocket + i) Mod 14 < 13 And player Mod 2 = 0 Then
                        Select Case (pocket + i + 1) Mod 14 'modifying identifier to match label index
                            Case 8
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label8.Left + Label8.Width / 2 - 50, Label8.Top + Label8.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label8.Text
                                Label8.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label6.Left + Label6.Width / 2 - 50, Label6.Top + Label6.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label6.Text
                                Label6.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                            Case 9
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label9.Left + Label9.Width / 2 - 50, Label9.Top + Label9.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label9.Text
                                Label9.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label5.Left + Label5.Width / 2 - 50, Label5.Top + Label5.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label5.Text
                                Label5.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                            Case 10
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label10.Left + Label10.Width / 2 - 50, Label10.Top + Label10.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label10.Text
                                Label10.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label4.Left + Label4.Width / 2 - 50, Label4.Top + Label4.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label4.Text
                                Label4.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                            Case 11
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label11.Left + Label11.Width / 2 - 50, Label11.Top + Label11.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label11.Text
                                Label11.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label3.Left + Label3.Width / 2 - 50, Label3.Top + Label3.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label3.Text
                                Label3.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                            Case 12
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label12.Left + Label12.Width / 2 - 50, Label12.Top + Label12.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label12.Text
                                Label12.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label2.Left + Label2.Width / 2 - 50, Label2.Top + Label2.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label2.Text
                                Label2.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                            Case 13
                                target = New Point(531, 226)
                                MoveHand()
                                target = New Point(Label13.Left + Label13.Width / 2 - 50, Label13.Top + Label13.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label13.Text
                                Label13.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                                target = New Point(Label1.Left + Label1.Width / 2 - 50, Label1.Top + Label1.Height / 2 - 50)
                                MoveHand()
                                Button1.Text = Label1.Text
                                Label1.Text = "0"
                                target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                                MoveHand()
                                Label14.Text += Convert.ToInt32(Button1.Text)
                                Button1.Text = "0"
                        End Select
                    End If
                End If
            End If
        Next i

        'check for a player having cleared their board
        If Convert.ToInt32(Label1.Text) + Convert.ToInt32(Label2.Text) + Convert.ToInt32(Label3.Text) + Convert.ToInt32(Label4.Text) + Convert.ToInt32(Label5.Text) + Convert.ToInt32(Label6.Text) = 0 Then
            'player 1 as winner
            For n As Integer = 7 To 12
                If wells(n).Text <> 0 Then
                    target = New Point(wells(n).Left + wells(n).Width / 2 - 50, wells(n).Top + wells(n).Height / 2 - 50)
                    MoveHand()
                    Button1.Text = wells(n).Text
                    wells(n).Text = "0"
                    target = New Point(Label7.Left + Label7.Width / 2 - 50, Label7.Top + Label7.Height / 2 - 50)
                    MoveHand()
                    Label7.Text += Convert.ToInt32(Button1.Text)
                    Button1.Text = "0"
                End If
            Next
            ending = 1
        ElseIf Convert.ToInt32(Label8.Text) + Convert.ToInt32(Label9.Text) + Convert.ToInt32(Label10.Text) + Convert.ToInt32(Label11.Text) + Convert.ToInt32(Label12.Text) + Convert.ToInt32(Label13.Text) = 0 Then
            'player 2 as winner
            For n As Integer = 0 To 5
                If wells(n).Text <> 0 Then
                    target = New Point(wells(n).Left + wells(n).Width / 2 - 50, wells(n).Top + wells(n).Height / 2 - 50)
                    MoveHand()
                    Button1.Text = wells(n).Text
                    wells(n).Text = "0"
                    target = New Point(Label14.Left + Label14.Width / 2 - 50, Label14.Top + Label14.Height / 2 - 50)
                    MoveHand()
                    Label14.Text += Convert.ToInt32(Button1.Text)
                    Button1.Text = "0"
                End If
            Next
            ending = 1
            target = New Point(531, 226)
            MoveHand()
        End If

        'check if the game is over, or if a new turn should be issued
        If ending = 1 Then 'game is over
            target = New Point(531, 226)
            MoveHand()
            Button1.Text = ""
            If Convert.ToInt32(Label7.Text) > Convert.ToInt32(Label14.Text) Then
                MessageBox.Show("Player 1 is the winner!")
            ElseIf Convert.ToInt32(Label14.Text) > Convert.ToInt32(Label7.Text) Then
                MessageBox.Show("Player 2 is the winner!")
            Else
                MessageBox.Show("The two players tied!")
            End If
        Else 'game continues
            'if player 1 ends in pocket 7 or player 2 ends in pocket 14, they get an extra turn
            If (pocket + handful) Mod 14 = 7 And player Mod 2 = 1 Then
                'nothing
            ElseIf (pocket + handful) Mod 14 = 0 And player Mod 2 = 0 Then
                'nothing
            Else
                player += 1
            End If

            'move hand to the side of the player, whos turn it is
            If player Mod 2 = 1 Then
                target = New Point(98, 422)
                MoveHand()
                Button1.Text = ""
                '98, 442
            ElseIf player Mod 2 = 0 Then
                target = New Point(989, 39)
                MoveHand()
                Button1.Text = ""
                '989,39
            Else
                target = New Point(531, 226)
                MoveHand()
                Button1.Text = ""
                '531, 226
            End If
        End If


    End Sub

    Sub MoveHand()
        Do While Math.Abs(target.X - Button1.Left) > 5 Or Math.Abs(target.Y - Button1.Top) > 5
            Button1.Location = New Point(Button1.Left + (target.X - Button1.Left) / 5, Button1.Top + (target.Y - Button1.Top) / 5)
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Loop
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        pocket = 1
        If Label1.Text <> "0" And player Mod 2 = 1 Then
            MovePellets(pocket)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        pocket = 2
        If Label2.Text <> "0" And player Mod 2 = 1 Then
            MovePellets(pocket)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        pocket = 3
        If Label3.Text <> "0" And player Mod 2 = 1 Then
            MovePellets(pocket)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        pocket = 4
        If Label4.Text <> "0" And player Mod 2 = 1 Then
            MovePellets(pocket)
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        pocket = 5
        If Label5.Text <> "0" And player Mod 2 = 1 Then
            MovePellets(pocket)
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        pocket = 6
        If Label6.Text <> "0" And player Mod 2 = 1 Then
            MovePellets(pocket)
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        pocket = 8
        If Label8.Text <> "0" And player Mod 2 = 0 Then
            MovePellets(pocket)
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        pocket = 9
        If Label9.Text <> "0" And player Mod 2 = 0 Then
            MovePellets(pocket)
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        pocket = 10
        If Label10.Text <> "0" And player Mod 2 = 0 Then
            MovePellets(pocket)
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        pocket = 11
        If Label11.Text <> "0" And player Mod 2 = 0 Then
            MovePellets(pocket)
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        pocket = 12
        If Label12.Text <> "0" And player Mod 2 = 0 Then
            MovePellets(pocket)
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        pocket = 13
        If Label13.Text <> "0" And player Mod 2 = 0 Then
            MovePellets(pocket)
        End If
    End Sub
End Class
