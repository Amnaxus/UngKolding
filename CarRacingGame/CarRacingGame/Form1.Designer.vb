<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Racer1 = New PictureBox()
        Racer2 = New PictureBox()
        Racer3 = New PictureBox()
        Car = New PictureBox()
        RoadMover = New Timer(components)
        RightSide = New Timer(components)
        LeftSide = New Timer(components)
        RacerMover1 = New Timer(components)
        RacerMover2 = New Timer(components)
        RacerMover3 = New Timer(components)
        Label3 = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(Racer1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Racer2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Racer3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Car, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.Location = New Point(102, -53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(12, 126)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ButtonHighlight
        PictureBox2.Location = New Point(216, -53)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(12, 126)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ButtonHighlight
        PictureBox3.Location = New Point(216, 99)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(12, 126)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.ButtonHighlight
        PictureBox4.Location = New Point(102, 99)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(12, 126)
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.ButtonHighlight
        PictureBox5.Location = New Point(216, 261)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(12, 126)
        PictureBox5.TabIndex = 5
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.ButtonHighlight
        PictureBox6.Location = New Point(102, 261)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(12, 126)
        PictureBox6.TabIndex = 4
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = SystemColors.ButtonHighlight
        PictureBox7.Location = New Point(216, 413)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(12, 126)
        PictureBox7.TabIndex = 7
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.ButtonHighlight
        PictureBox8.Location = New Point(102, 413)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(12, 126)
        PictureBox8.TabIndex = 6
        PictureBox8.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(2, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 25)
        Label1.TabIndex = 8
        Label1.Text = "Speed 0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(234, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 25)
        Label2.TabIndex = 9
        Label2.Text = "Score 0"
        ' 
        ' Racer1
        ' 
        Racer1.Image = My.Resources.Resources._1
        Racer1.Location = New Point(12, 175)
        Racer1.Name = "Racer1"
        Racer1.Size = New Size(40, 81)
        Racer1.SizeMode = PictureBoxSizeMode.Zoom
        Racer1.TabIndex = 10
        Racer1.TabStop = False
        ' 
        ' Racer2
        ' 
        Racer2.Image = My.Resources.Resources._7
        Racer2.Location = New Point(161, 89)
        Racer2.Name = "Racer2"
        Racer2.Size = New Size(35, 70)
        Racer2.SizeMode = PictureBoxSizeMode.Zoom
        Racer2.TabIndex = 11
        Racer2.TabStop = False
        ' 
        ' Racer3
        ' 
        Racer3.Image = My.Resources.Resources._8
        Racer3.Location = New Point(257, 225)
        Racer3.Name = "Racer3"
        Racer3.Size = New Size(45, 69)
        Racer3.SizeMode = PictureBoxSizeMode.Zoom
        Racer3.TabIndex = 12
        Racer3.TabStop = False
        ' 
        ' Car
        ' 
        Car.Image = My.Resources.Resources._9
        Car.Location = New Point(133, 356)
        Car.Name = "Car"
        Car.Size = New Size(44, 85)
        Car.SizeMode = PictureBoxSizeMode.Zoom
        Car.TabIndex = 13
        Car.TabStop = False
        ' 
        ' RoadMover
        ' 
        RoadMover.Enabled = True
        RoadMover.Interval = 10
        ' 
        ' RightSide
        ' 
        RightSide.Interval = 10
        ' 
        ' LeftSide
        ' 
        LeftSide.Interval = 10
        ' 
        ' RacerMover1
        ' 
        RacerMover1.Interval = 10
        ' 
        ' RacerMover2
        ' 
        RacerMover2.Interval = 10
        ' 
        ' RacerMover3
        ' 
        RacerMover3.Interval = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Firebrick
        Label3.Location = New Point(20, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(294, 65)
        Label3.TabIndex = 14
        Label3.Text = "GAMEOVER"
        Label3.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.YellowGreen
        Button1.Location = New Point(71, 233)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 61)
        Button1.TabIndex = 15
        Button1.Text = "REPLAY"
        Button1.UseVisualStyleBackColor = False
        Button1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(332, 453)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Car)
        Controls.Add(Racer3)
        Controls.Add(Racer2)
        Controls.Add(Racer1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        MaximumSize = New Size(350, 500)
        MinimumSize = New Size(350, 500)
        Name = "Form1"
        Text = "Car Racing Game"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(Racer1, ComponentModel.ISupportInitialize).EndInit()
        CType(Racer2, ComponentModel.ISupportInitialize).EndInit()
        CType(Racer3, ComponentModel.ISupportInitialize).EndInit()
        CType(Car, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Racer1 As PictureBox
    Friend WithEvents Racer2 As PictureBox
    Friend WithEvents Racer3 As PictureBox
    Friend WithEvents Car As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents RacerMover1 As Timer
    Friend WithEvents RacerMover2 As Timer
    Friend WithEvents RacerMover3 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
