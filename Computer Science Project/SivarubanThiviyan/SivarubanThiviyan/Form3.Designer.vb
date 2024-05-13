<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblHowToPlay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBack.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(18, 19)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 34)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.White
        Me.lblInstructions.Location = New System.Drawing.Point(42, 105)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(577, 180)
        Me.lblInstructions.TabIndex = 11
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        '
        'lblHowToPlay
        '
        Me.lblHowToPlay.AutoSize = True
        Me.lblHowToPlay.Font = New System.Drawing.Font("MS PGothic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowToPlay.ForeColor = System.Drawing.Color.Yellow
        Me.lblHowToPlay.Location = New System.Drawing.Point(237, 43)
        Me.lblHowToPlay.Name = "lblHowToPlay"
        Me.lblHowToPlay.Size = New System.Drawing.Size(211, 29)
        Me.lblHowToPlay.TabIndex = 10
        Me.lblHowToPlay.Text = "HOW TO PLAY"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(664, 320)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblHowToPlay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "How to Play"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblHowToPlay As Label
End Class
