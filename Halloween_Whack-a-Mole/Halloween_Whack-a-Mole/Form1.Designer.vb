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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Pumpkin1 = New PictureBox()
        PumpkinMover = New Timer(components)
        Label1 = New Label()
        Pumpkin2 = New PictureBox()
        Pumpkin3 = New PictureBox()
        Pumpkin4 = New PictureBox()
        Pumpkin5 = New PictureBox()
        Label2 = New Label()
        Button1 = New Button()
        CType(Pumpkin1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Pumpkin2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Pumpkin3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Pumpkin4, ComponentModel.ISupportInitialize).BeginInit()
        CType(Pumpkin5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Pumpkin1
        ' 
        Pumpkin1.BackColor = Color.Transparent
        Pumpkin1.BackgroundImage = CType(resources.GetObject("Pumpkin1.BackgroundImage"), Image)
        Pumpkin1.BackgroundImageLayout = ImageLayout.Stretch
        Pumpkin1.Location = New Point(70, 72)
        Pumpkin1.Name = "Pumpkin1"
        Pumpkin1.Size = New Size(75, 75)
        Pumpkin1.TabIndex = 0
        Pumpkin1.TabStop = False
        ' 
        ' PumpkinMover
        ' 
        PumpkinMover.Interval = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(369, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 41)
        Label1.TabIndex = 1
        Label1.Text = "Score: 0"
        ' 
        ' Pumpkin2
        ' 
        Pumpkin2.BackColor = Color.Transparent
        Pumpkin2.BackgroundImage = CType(resources.GetObject("Pumpkin2.BackgroundImage"), Image)
        Pumpkin2.BackgroundImageLayout = ImageLayout.Stretch
        Pumpkin2.Location = New Point(194, 114)
        Pumpkin2.Name = "Pumpkin2"
        Pumpkin2.Size = New Size(75, 75)
        Pumpkin2.TabIndex = 2
        Pumpkin2.TabStop = False
        ' 
        ' Pumpkin3
        ' 
        Pumpkin3.BackColor = Color.Transparent
        Pumpkin3.BackgroundImage = CType(resources.GetObject("Pumpkin3.BackgroundImage"), Image)
        Pumpkin3.BackgroundImageLayout = ImageLayout.Stretch
        Pumpkin3.Location = New Point(307, 140)
        Pumpkin3.Name = "Pumpkin3"
        Pumpkin3.Size = New Size(75, 75)
        Pumpkin3.TabIndex = 3
        Pumpkin3.TabStop = False
        ' 
        ' Pumpkin4
        ' 
        Pumpkin4.BackColor = Color.Transparent
        Pumpkin4.BackgroundImage = CType(resources.GetObject("Pumpkin4.BackgroundImage"), Image)
        Pumpkin4.BackgroundImageLayout = ImageLayout.Stretch
        Pumpkin4.Location = New Point(50, 191)
        Pumpkin4.Name = "Pumpkin4"
        Pumpkin4.Size = New Size(75, 75)
        Pumpkin4.TabIndex = 4
        Pumpkin4.TabStop = False
        ' 
        ' Pumpkin5
        ' 
        Pumpkin5.BackColor = Color.Transparent
        Pumpkin5.BackgroundImage = CType(resources.GetObject("Pumpkin5.BackgroundImage"), Image)
        Pumpkin5.BackgroundImageLayout = ImageLayout.Stretch
        Pumpkin5.Location = New Point(407, 223)
        Pumpkin5.Name = "Pumpkin5"
        Pumpkin5.Size = New Size(75, 75)
        Pumpkin5.TabIndex = 5
        Pumpkin5.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Blue
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(151, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 41)
        Label2.TabIndex = 6
        Label2.Text = "Game Over"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        Label2.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(166, 319)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 53)
        Button1.TabIndex = 7
        Button1.Text = "Restart"
        Button1.UseVisualStyleBackColor = True
        Button1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(523, 499)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Pumpkin5)
        Controls.Add(Pumpkin4)
        Controls.Add(Pumpkin3)
        Controls.Add(Pumpkin1)
        Controls.Add(Label1)
        Controls.Add(Pumpkin2)
        Name = "Form1"
        Text = "Halloween Whack-a-Mole"
        CType(Pumpkin1, ComponentModel.ISupportInitialize).EndInit()
        CType(Pumpkin2, ComponentModel.ISupportInitialize).EndInit()
        CType(Pumpkin3, ComponentModel.ISupportInitialize).EndInit()
        CType(Pumpkin4, ComponentModel.ISupportInitialize).EndInit()
        CType(Pumpkin5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Pumpkin1 As PictureBox
    Friend WithEvents PumpkinMover As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Pumpkin2 As PictureBox
    Friend WithEvents Pumpkin3 As PictureBox
    Friend WithEvents Pumpkin4 As PictureBox
    Friend WithEvents Pumpkin5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
