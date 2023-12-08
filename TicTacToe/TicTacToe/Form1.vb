Imports System.IO
Imports System.Reflection.Emit

Public Class Form1
    Public PlayerChoise As Integer = Form2.PlayerChoise
    Dim rnd As New Random

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Sub Reset()
        If PlayerChoise = 2 Then
            Button1.BackColor = Color.White
            Button1.Text = ""
            Button2.BackColor = Color.White
            Button2.Text = ""
            Button3.BackColor = Color.White
            Button3.Text = ""
            Button4.BackColor = Color.White
            Button4.Text = ""
            Button5.BackColor = Color.White
            Button5.Text = ""
            Button6.BackColor = Color.White
            Button6.Text = ""
            Button7.BackColor = Color.White
            Button7.Text = ""
            Button8.BackColor = Color.White
            Button8.Text = ""
            Button9.BackColor = Color.White
            Button9.Text = ""
        Else
            Me.Controls.Clear()
            Me.InitializeComponent()
        End If
    End Sub
    Sub CheckForWin()
        'Checking for X win
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Black
            MessageBox.Show("X wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Black
            MessageBox.Show("X wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            Button7.BackColor = Color.Black
            Button8.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MessageBox.Show("X wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            Button1.BackColor = Color.Black
            Button4.BackColor = Color.Black
            Button7.BackColor = Color.Black
            MessageBox.Show("X wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            Button2.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button8.BackColor = Color.Black
            MessageBox.Show("X wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            Button3.BackColor = Color.Black
            Button6.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MessageBox.Show("X wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            Button1.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MessageBox.Show("X wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            Button3.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button7.BackColor = Color.Black
            MessageBox.Show("X wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If

        'Checking for O win
        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Black
            MessageBox.Show("O wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Black
            MessageBox.Show("O wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            Button7.BackColor = Color.Black
            Button8.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MessageBox.Show("O wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            Button1.BackColor = Color.Black
            Button4.BackColor = Color.Black
            Button7.BackColor = Color.Black
            MessageBox.Show("O wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            Button2.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button8.BackColor = Color.Black
            MessageBox.Show("O wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            Button3.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MessageBox.Show("O wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            Button1.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MessageBox.Show("O wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            Button3.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button7.BackColor = Color.Black
            MessageBox.Show("O wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        If Button1.Text <> "" And Button2.Text <> "" And Button3.Text <> "" And Button4.Text <> "" And Button5.Text <> "" And Button6.Text <> "" And Button7.Text <> "" And Button8.Text <> "" And Button9.Text <> "" Then
            MessageBox.Show("No winners, try again!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        End If
        'github test change
        If PlayerChoise = 1 And Strings.Right(Label1.Text, 1) = "O" Then
            Threading.Thread.Sleep(500)
            Application.DoEvents()
            Dim onwards As Integer = 0
            Do Until onwards >= 1
                Select Case rnd.Next(1, 10)
                    Case 1
                        If Button1.Text = "" Then
                            Button1.PerformClick()
                            Exit Do
                        End If
                    Case 2
                        If Button2.Text = "" Then
                            Button2.PerformClick()
                            Exit Do
                        End If
                    Case 3
                        If Button3.Text = "" Then
                            Button3.PerformClick()
                            Exit Do
                        End If
                    Case 4
                        If Button4.Text = "" Then
                            Button4.PerformClick()
                            Exit Do
                        End If
                    Case 5
                        If Button5.Text = "" Then
                            Button5.PerformClick()
                            Exit Do
                        End If
                    Case 6
                        If Button6.Text = "" Then
                            Button6.PerformClick()
                            Exit Do
                        End If
                    Case 7
                        If Button7.Text = "" Then
                            Button7.PerformClick()
                            Exit Do
                        End If
                    Case 8
                        If Button8.Text = "" Then
                            Button8.PerformClick()
                            Exit Do
                        End If
                    Case 9
                        If Button9.Text = "" Then
                            Button9.PerformClick()
                            Exit Do
                        End If
                End Select
                onwards += 1
            Loop
            CheckForWin()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "" Then
            Button1.Text = Strings.Right(Label1.Text, 1)
            If Strings.Right(Label1.Text, 1) = "X" Then
                Label1.Text = "Turn: O"
            ElseIf Strings.Right(Label1.Text, 1) = "O" Then
                Label1.Text = "Turn: X"
            End If
            CheckForWin()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "" Then
            Button2.Text = Strings.Right(Label1.Text, 1)
            If Strings.Right(Label1.Text, 1) = "X" Then
                Label1.Text = "Turn: O"
            ElseIf Strings.Right(Label1.Text, 1) = "O" Then
                Label1.Text = "Turn: X"
            End If
            CheckForWin()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "" Then
            Button3.Text = Strings.Right(Label1.Text, 1)
            If Strings.Right(Label1.Text, 1) = "X" Then
                Label1.Text = "Turn: O"
            ElseIf Strings.Right(Label1.Text, 1) = "O" Then
                Label1.Text = "Turn: X"
            End If
            CheckForWin()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "" Then
            Button4.Text = Strings.Right(Label1.Text, 1)
            If Strings.Right(Label1.Text, 1) = "X" Then
                Label1.Text = "Turn: O"
            ElseIf Strings.Right(Label1.Text, 1) = "O" Then
                Label1.Text = "Turn: X"
            End If
            CheckForWin()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "" Then
            Button5.Text = Strings.Right(Label1.Text, 1)
            If Strings.Right(Label1.Text, 1) = "X" Then
                Label1.Text = "Turn: O"
            ElseIf Strings.Right(Label1.Text, 1) = "O" Then
                Label1.Text = "Turn: X"
            End If
            CheckForWin()
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.Text = "" Then
            Button6.Text = Strings.Right(Label1.Text, 1)
            If Strings.Right(Label1.Text, 1) = "X" Then
                Label1.Text = "Turn: O"
            ElseIf Strings.Right(Label1.Text, 1) = "O" Then
                Label1.Text = "Turn: X"
            End If
            CheckForWin()
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Text = "" Then
            Button7.Text = Strings.Right(Label1.Text, 1)
            If Strings.Right(Label1.Text, 1) = "X" Then
                Label1.Text = "Turn: O"
            ElseIf Strings.Right(Label1.Text, 1) = "O" Then
                Label1.Text = "Turn: X"
            End If
            CheckForWin()
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text = "" Then
            Button8.Text = Strings.Right(Label1.Text, 1)
            If Strings.Right(Label1.Text, 1) = "X" Then
                Label1.Text = "Turn: O"
            ElseIf Strings.Right(Label1.Text, 1) = "O" Then
                Label1.Text = "Turn: X"
            End If
            CheckForWin()
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.Text = "" Then
            Button9.Text = Strings.Right(Label1.Text, 1)
            If Strings.Right(Label1.Text, 1) = "X" Then
                Label1.Text = "Turn: O"
            ElseIf Strings.Right(Label1.Text, 1) = "O" Then
                Label1.Text = "Turn: X"
            End If
            CheckForWin()
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
        Form2.Show()
    End Sub


End Class


