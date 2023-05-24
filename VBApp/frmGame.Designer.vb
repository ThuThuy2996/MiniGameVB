<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Sum = New System.Windows.Forms.Label()
        Me.lbl_Notic = New System.Windows.Forms.Label()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.ptbD = New System.Windows.Forms.PictureBox()
        Me.btn_Spin = New System.Windows.Forms.Button()
        Me.ptbC = New System.Windows.Forms.PictureBox()
        Me.ptbB = New System.Windows.Forms.PictureBox()
        Me.ptbA = New System.Windows.Forms.PictureBox()
        CType(Me.ptbD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Reem Kufi", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(217, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 51)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ミニゲーム"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("UD Digi Kyokasho NK-R", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "** これはでたらめなゲームです. 少なくとも2枚の写真が同じであれば勝ちです"
        '
        'lbl_Sum
        '
        Me.lbl_Sum.AutoSize = True
        Me.lbl_Sum.Font = New System.Drawing.Font("Reem Kufi", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_Sum.ForeColor = System.Drawing.Color.Red
        Me.lbl_Sum.Location = New System.Drawing.Point(24, 51)
        Me.lbl_Sum.Name = "lbl_Sum"
        Me.lbl_Sum.Size = New System.Drawing.Size(47, 39)
        Me.lbl_Sum.TabIndex = 7
        Me.lbl_Sum.Text = "¥0"
        '
        'lbl_Notic
        '
        Me.lbl_Notic.AutoSize = True
        Me.lbl_Notic.Font = New System.Drawing.Font("UD Digi Kyokasho NK-R", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_Notic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Notic.Location = New System.Drawing.Point(28, 265)
        Me.lbl_Notic.Name = "lbl_Notic"
        Me.lbl_Notic.Size = New System.Drawing.Size(456, 15)
        Me.lbl_Notic.TabIndex = 8
        Me.lbl_Notic.Text = "***今日の君の番は終わりました。 リセットするには横のボタンを押してくださいね　^^"
        Me.lbl_Notic.Visible = False
        '
        'btn_Reset
        '
        Me.btn_Reset.BackColor = System.Drawing.Color.Transparent
        Me.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Reset.FlatAppearance.BorderSize = 0
        Me.btn_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Reset.Font = New System.Drawing.Font("Reem Kufi", 8.25!)
        Me.btn_Reset.Image = Global.VBApp.My.Resources.Resources.icons8_reset_50
        Me.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Reset.Location = New System.Drawing.Point(487, 246)
        Me.btn_Reset.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(64, 50)
        Me.btn_Reset.TabIndex = 9
        Me.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Reset.UseVisualStyleBackColor = False
        Me.btn_Reset.Visible = False
        '
        'ptbD
        '
        Me.ptbD.BackgroundImage = Global.VBApp.My.Resources.Resources.Roses
        Me.ptbD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbD.Location = New System.Drawing.Point(466, 93)
        Me.ptbD.Name = "ptbD"
        Me.ptbD.Size = New System.Drawing.Size(127, 145)
        Me.ptbD.TabIndex = 5
        Me.ptbD.TabStop = False
        '
        'btn_Spin
        '
        Me.btn_Spin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Spin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Spin.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_Spin.FlatAppearance.BorderSize = 0
        Me.btn_Spin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btn_Spin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Spin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Spin.Font = New System.Drawing.Font("Reem Kufi", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Spin.Image = Global.VBApp.My.Resources.Resources.icons8_roulette_48
        Me.btn_Spin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Spin.Location = New System.Drawing.Point(226, 298)
        Me.btn_Spin.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Spin.Name = "btn_Spin"
        Me.btn_Spin.Size = New System.Drawing.Size(168, 61)
        Me.btn_Spin.TabIndex = 3
        Me.btn_Spin.Text = "スピン"
        Me.btn_Spin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Spin.UseVisualStyleBackColor = False
        '
        'ptbC
        '
        Me.ptbC.BackgroundImage = Global.VBApp.My.Resources.Resources.Lisa
        Me.ptbC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbC.Location = New System.Drawing.Point(321, 93)
        Me.ptbC.Name = "ptbC"
        Me.ptbC.Size = New System.Drawing.Size(127, 145)
        Me.ptbC.TabIndex = 2
        Me.ptbC.TabStop = False
        '
        'ptbB
        '
        Me.ptbB.BackgroundImage = Global.VBApp.My.Resources.Resources.Jisoo
        Me.ptbB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbB.Location = New System.Drawing.Point(176, 93)
        Me.ptbB.Name = "ptbB"
        Me.ptbB.Size = New System.Drawing.Size(127, 145)
        Me.ptbB.TabIndex = 1
        Me.ptbB.TabStop = False
        '
        'ptbA
        '
        Me.ptbA.BackgroundImage = Global.VBApp.My.Resources.Resources.Jennie
        Me.ptbA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbA.Location = New System.Drawing.Point(31, 93)
        Me.ptbA.Name = "ptbA"
        Me.ptbA.Size = New System.Drawing.Size(127, 145)
        Me.ptbA.TabIndex = 0
        Me.ptbA.TabStop = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 383)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.lbl_Notic)
        Me.Controls.Add(Me.lbl_Sum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ptbD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Spin)
        Me.Controls.Add(Me.ptbC)
        Me.Controls.Add(Me.ptbB)
        Me.Controls.Add(Me.ptbA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "笑いましょう"
        CType(Me.ptbD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbA As PictureBox
    Friend WithEvents ptbB As PictureBox
    Friend WithEvents ptbC As PictureBox
    Friend WithEvents btn_Spin As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ptbD As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Sum As Label
    Friend WithEvents lbl_Notic As Label
    Friend WithEvents btn_Reset As Button
End Class
