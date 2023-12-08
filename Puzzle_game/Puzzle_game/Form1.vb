Imports System.CodeDom.Compiler

Public Class Form1
    Dim fields(8) As PictureBox


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fields(0) = PictureBox1
        fields(1) = PictureBox2
        fields(2) = PictureBox3
        fields(3) = PictureBox4
        fields(4) = PictureBox5
        fields(5) = PictureBox6
        fields(6) = PictureBox7
        fields(7) = PictureBox8
        fields(8) = PictureBox9
        'Shuffle(fields)

        fields(1).BackgroundImage = My.Resources.Pumpkin2
        fields(2).BackgroundImage = My.Resources.Pumpkin3
        fields(3).BackgroundImage = My.Resources.Pumpkin4
        fields(4).BackgroundImage = My.Resources.Pumpkin5
        fields(5).BackgroundImage = My.Resources.Pumpkin6
        fields(6).BackgroundImage = My.Resources.Pumpkin7
        fields(7).BackgroundImage = My.Resources.Pumpkin8
        fields(8).BackgroundImage = My.Resources.Pumpkin9
        Shuffle()


    End Sub

    Sub Shuffle()
        Dim rnd As New Random
        Dim temp As Integer

        For j As Integer = 1 To 100
            For i As Integer = 0 To 8
                If fields(i).BackgroundImage Is Nothing Then
                    Select Case i
                        Case 0
                            temp = rnd.Next(0, 2)
                            If temp = 0 Then
                                PictureBox2_Click(Nothing, Nothing)
                            Else
                                PictureBox4_Click(Nothing, Nothing)
                            End If
                        Case 1
                            temp = rnd.Next(0, 3)
                            If temp = 0 Then
                                PictureBox1_Click(Nothing, Nothing)
                            ElseIf temp = 1 Then
                                PictureBox3_Click(Nothing, Nothing)
                            Else
                                PictureBox5_Click(Nothing, Nothing)
                            End If
                        Case 2
                            temp = rnd.Next(0, 2)
                            If temp = 0 Then
                                PictureBox2_Click(Nothing, Nothing)
                            Else
                                PictureBox6_Click(Nothing, Nothing)
                            End If
                        Case 3
                            temp = rnd.Next(0, 3)
                            If temp = 0 Then
                                PictureBox1_Click(Nothing, Nothing)
                            ElseIf temp = 1 Then
                                PictureBox5_Click(Nothing, Nothing)
                            Else
                                PictureBox7_Click(Nothing, Nothing)
                            End If
                        Case 4
                            temp = rnd.Next(0, 4)
                            If temp = 0 Then
                                PictureBox2_Click(Nothing, Nothing)
                            ElseIf temp = 1 Then
                                PictureBox4_Click(Nothing, Nothing)
                            ElseIf temp = 2 Then
                                PictureBox6_Click(Nothing, Nothing)
                            Else
                                PictureBox8_Click(Nothing, Nothing)
                            End If
                        Case 5
                            temp = rnd.Next(0, 3)
                            If temp = 0 Then
                                PictureBox3_Click(Nothing, Nothing)
                            ElseIf temp = 1 Then
                                PictureBox5_Click(Nothing, Nothing)
                            Else
                                PictureBox9_Click(Nothing, Nothing)
                            End If
                        Case 6
                            temp = rnd.Next(0, 2)
                            If temp = 0 Then
                                PictureBox4_Click(Nothing, Nothing)
                            Else
                                PictureBox8_Click(Nothing, Nothing)
                            End If
                        Case 7
                            temp = rnd.Next(0, 3)
                            If temp = 0 Then
                                PictureBox5_Click(Nothing, Nothing)
                            ElseIf temp = 1 Then
                                PictureBox7_Click(Nothing, Nothing)
                            Else
                                PictureBox9_Click(Nothing, Nothing)
                            End If
                        Case 8
                            temp = rnd.Next(0, 2)
                            If temp = 0 Then
                                PictureBox6_Click(Nothing, Nothing)
                            Else
                                PictureBox8_Click(Nothing, Nothing)
                            End If
                    End Select
                    Exit For
                End If
            Next i
        Next j

    End Sub

    Sub ImgSwap(ByRef Img1 As PictureBox, ByRef Img2 As PictureBox)
        If Img2.BackgroundImage Is Nothing Then
            Img2.BackgroundImage = Img1.BackgroundImage
            Img1.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        '24
        ImgSwap(PictureBox1, PictureBox2)
        ImgSwap(PictureBox1, PictureBox4)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        '135
        ImgSwap(PictureBox2, PictureBox1)
        ImgSwap(PictureBox2, PictureBox3)
        ImgSwap(PictureBox2, PictureBox5)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        '26
        ImgSwap(PictureBox3, PictureBox2)
        ImgSwap(PictureBox3, PictureBox6)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        '157
        ImgSwap(PictureBox4, PictureBox1)
        ImgSwap(PictureBox4, PictureBox5)
        ImgSwap(PictureBox4, PictureBox7)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        '2468
        ImgSwap(PictureBox5, PictureBox2)
        ImgSwap(PictureBox5, PictureBox4)
        ImgSwap(PictureBox5, PictureBox6)
        ImgSwap(PictureBox5, PictureBox8)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        '359
        ImgSwap(PictureBox6, PictureBox3)
        ImgSwap(PictureBox6, PictureBox5)
        ImgSwap(PictureBox6, PictureBox9)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        '48
        ImgSwap(PictureBox7, PictureBox4)
        ImgSwap(PictureBox7, PictureBox8)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        '579
        ImgSwap(PictureBox8, PictureBox5)
        ImgSwap(PictureBox8, PictureBox7)
        ImgSwap(PictureBox8, PictureBox9)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        '68
        ImgSwap(PictureBox9, PictureBox6)
        ImgSwap(PictureBox9, PictureBox8)
    End Sub
End Class
