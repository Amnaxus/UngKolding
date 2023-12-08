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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Label1 = New Label()
        Button10 = New Button()
        Button11 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(168, 107)
        Button1.Name = "Button1"
        Button1.Size = New Size(70, 70)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(259, 107)
        Button2.Name = "Button2"
        Button2.Size = New Size(70, 70)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(350, 107)
        Button3.Name = "Button3"
        Button3.Size = New Size(70, 70)
        Button3.TabIndex = 2
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(168, 198)
        Button4.Name = "Button4"
        Button4.Size = New Size(70, 70)
        Button4.TabIndex = 5
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(259, 198)
        Button5.Name = "Button5"
        Button5.Size = New Size(70, 70)
        Button5.TabIndex = 4
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(350, 198)
        Button6.Name = "Button6"
        Button6.Size = New Size(70, 70)
        Button6.TabIndex = 3
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(168, 289)
        Button7.Name = "Button7"
        Button7.Size = New Size(70, 70)
        Button7.TabIndex = 8
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.Location = New Point(259, 289)
        Button8.Name = "Button8"
        Button8.Size = New Size(70, 70)
        Button8.TabIndex = 7
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button9.Location = New Point(350, 289)
        Button9.Name = "Button9"
        Button9.Size = New Size(70, 70)
        Button9.TabIndex = 6
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(200, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 60)
        Label1.TabIndex = 9
        Label1.Text = "Turn: X"
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(500, 405)
        Button10.Name = "Button10"
        Button10.Size = New Size(100, 37)
        Button10.TabIndex = 10
        Button10.Text = "Close"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(25, 405)
        Button11.Name = "Button11"
        Button11.Size = New Size(100, 37)
        Button11.TabIndex = 11
        Button11.Text = "Reconfigure"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(619, 467)
        Controls.Add(Button11)
        Controls.Add(Button10)
        Controls.Add(Label1)
        Controls.Add(Button7)
        Controls.Add(Button8)
        Controls.Add(Button9)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Tic Tac Toe"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
End Class
