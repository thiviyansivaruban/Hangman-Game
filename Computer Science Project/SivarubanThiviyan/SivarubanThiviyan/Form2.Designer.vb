<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblLettersGuessed = New System.Windows.Forms.Label()
        Me.lstLettersGuessed = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblSecretWord = New System.Windows.Forms.Label()
        Me.btnPlayGame = New System.Windows.Forms.Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.picHint = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCredits = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picHint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLettersGuessed
        '
        Me.lblLettersGuessed.AutoSize = True
        Me.lblLettersGuessed.Font = New System.Drawing.Font("Sitka Banner", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLettersGuessed.Location = New System.Drawing.Point(12, 277)
        Me.lblLettersGuessed.Name = "lblLettersGuessed"
        Me.lblLettersGuessed.Size = New System.Drawing.Size(150, 30)
        Me.lblLettersGuessed.TabIndex = 23
        Me.lblLettersGuessed.Text = "Letters Guessed"
        '
        'lstLettersGuessed
        '
        Me.lstLettersGuessed.BackColor = System.Drawing.Color.Yellow
        Me.lstLettersGuessed.ColumnWidth = 20
        Me.lstLettersGuessed.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLettersGuessed.FormattingEnabled = True
        Me.lstLettersGuessed.ItemHeight = 16
        Me.lstLettersGuessed.Location = New System.Drawing.Point(14, 310)
        Me.lstLettersGuessed.MultiColumn = True
        Me.lstLettersGuessed.Name = "lstLettersGuessed"
        Me.lstLettersGuessed.Size = New System.Drawing.Size(145, 132)
        Me.lstLettersGuessed.TabIndex = 22
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBack.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(13, 37)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 34)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.White
        Me.lblScore.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Red
        Me.lblScore.Location = New System.Drawing.Point(485, 37)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 32)
        Me.lblScore.TabIndex = 20
        '
        'lblSecretWord
        '
        Me.lblSecretWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretWord.Location = New System.Drawing.Point(16, 129)
        Me.lblSecretWord.Name = "lblSecretWord"
        Me.lblSecretWord.Size = New System.Drawing.Size(595, 65)
        Me.lblSecretWord.TabIndex = 19
        Me.lblSecretWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlayGame
        '
        Me.btnPlayGame.BackColor = System.Drawing.Color.Yellow
        Me.btnPlayGame.Font = New System.Drawing.Font("MS PGothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayGame.Location = New System.Drawing.Point(246, 400)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(134, 44)
        Me.btnPlayGame.TabIndex = 18
        Me.btnPlayGame.Text = "Start"
        Me.btnPlayGame.UseVisualStyleBackColor = False
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.Location = New System.Drawing.Point(442, 298)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(0, 29)
        Me.lblHint.TabIndex = 25
        '
        'picHint
        '
        Me.picHint.Location = New System.Drawing.Point(235, 232)
        Me.picHint.Name = "picHint"
        Me.picHint.Size = New System.Drawing.Size(157, 147)
        Me.picHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHint.TabIndex = 17
        Me.picHint.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Yellow
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(628, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCredits, Me.mnuExit})
        Me.mnuMenu.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(49, 20)
        Me.mnuMenu.Text = "Menu"
        '
        'mnuCredits
        '
        Me.mnuCredits.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mnuCredits.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuCredits.Name = "mnuCredits"
        Me.mnuCredits.Size = New System.Drawing.Size(116, 22)
        Me.mnuCredits.Text = "Credits"
        '
        'mnuExit
        '
        Me.mnuExit.BackColor = System.Drawing.Color.Red
        Me.mnuExit.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(116, 22)
        Me.mnuExit.Text = "Exit"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(628, 462)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblLettersGuessed)
        Me.Controls.Add(Me.lstLettersGuessed)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblSecretWord)
        Me.Controls.Add(Me.btnPlayGame)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.picHint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Game"
        CType(Me.picHint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLettersGuessed As Label
    Friend WithEvents lstLettersGuessed As ListBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents lblSecretWord As Label
    Friend WithEvents btnPlayGame As Button
    Friend WithEvents lblHint As Label
    Friend WithEvents picHint As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents mnuCredits As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
