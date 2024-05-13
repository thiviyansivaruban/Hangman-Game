<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPlayGame = New System.Windows.Forms.Button()
        Me.btnHowToPlay = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCredits = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitle.Location = New System.Drawing.Point(48, 150)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(543, 78)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Who's that Pokémon?"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlayGame
        '
        Me.btnPlayGame.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPlayGame.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayGame.Location = New System.Drawing.Point(246, 300)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(153, 50)
        Me.btnPlayGame.TabIndex = 1
        Me.btnPlayGame.Text = "PLAY GAME"
        Me.btnPlayGame.UseVisualStyleBackColor = False
        '
        'btnHowToPlay
        '
        Me.btnHowToPlay.BackColor = System.Drawing.Color.Red
        Me.btnHowToPlay.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHowToPlay.ForeColor = System.Drawing.Color.White
        Me.btnHowToPlay.Location = New System.Drawing.Point(12, 36)
        Me.btnHowToPlay.Name = "btnHowToPlay"
        Me.btnHowToPlay.Size = New System.Drawing.Size(118, 43)
        Me.btnHowToPlay.TabIndex = 2
        Me.btnHowToPlay.Text = "How to Play"
        Me.btnHowToPlay.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Yellow
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(643, 24)
        Me.MenuStrip1.TabIndex = 3
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
        Me.mnuCredits.Size = New System.Drawing.Size(180, 22)
        Me.mnuCredits.Text = "Credits"
        '
        'mnuExit
        '
        Me.mnuExit.BackColor = System.Drawing.Color.Red
        Me.mnuExit.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SivarubanThiviyan.My.Resources.Resources.Pokemon_Wallpaper
        Me.ClientSize = New System.Drawing.Size(643, 362)
        Me.Controls.Add(Me.btnHowToPlay)
        Me.Controls.Add(Me.btnPlayGame)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Word Guess"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPlayGame As Button
    Friend WithEvents btnHowToPlay As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents mnuCredits As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
