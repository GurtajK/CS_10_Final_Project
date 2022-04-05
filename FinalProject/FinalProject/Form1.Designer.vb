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
        Me.picTitle = New System.Windows.Forms.PictureBox()
        Me.picStart = New System.Windows.Forms.PictureBox()
        Me.picHelp = New System.Windows.Forms.PictureBox()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picTitle
        '
        Me.picTitle.BackColor = System.Drawing.Color.Transparent
        Me.picTitle.BackgroundImage = Global.FinalProject.My.Resources.Resources.Title___Italics
        Me.picTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.picTitle.Location = New System.Drawing.Point(38, 25)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(567, 116)
        Me.picTitle.TabIndex = 0
        Me.picTitle.TabStop = False
        '
        'picStart
        '
        Me.picStart.BackColor = System.Drawing.Color.Transparent
        Me.picStart.BackgroundImage = Global.FinalProject.My.Resources.Resources.StartButton
        Me.picStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picStart.Location = New System.Drawing.Point(192, 123)
        Me.picStart.Name = "picStart"
        Me.picStart.Size = New System.Drawing.Size(237, 56)
        Me.picStart.TabIndex = 1
        Me.picStart.TabStop = False
        '
        'picHelp
        '
        Me.picHelp.BackColor = System.Drawing.Color.Transparent
        Me.picHelp.BackgroundImage = Global.FinalProject.My.Resources.Resources.HelpButton
        Me.picHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picHelp.Location = New System.Drawing.Point(192, 193)
        Me.picHelp.Name = "picHelp"
        Me.picHelp.Size = New System.Drawing.Size(237, 56)
        Me.picHelp.TabIndex = 2
        Me.picHelp.TabStop = False
        '
        'picExit
        '
        Me.picExit.BackColor = System.Drawing.Color.Transparent
        Me.picExit.BackgroundImage = Global.FinalProject.My.Resources.Resources.ExitButton
        Me.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picExit.Location = New System.Drawing.Point(192, 258)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(237, 56)
        Me.picExit.TabIndex = 3
        Me.picExit.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(619, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewGame, Me.mnuHelp, Me.mnuExit})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'mnuNewGame
        '
        Me.mnuNewGame.Name = "mnuNewGame"
        Me.mnuNewGame.Size = New System.Drawing.Size(132, 22)
        Me.mnuNewGame.Text = "New Game"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(132, 22)
        Me.mnuHelp.Text = "Help"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(132, 22)
        Me.mnuExit.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalProject.My.Resources.Resources.menuBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(619, 358)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.picHelp)
        Me.Controls.Add(Me.picStart)
        Me.Controls.Add(Me.picTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Reaction Mechanics"
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTitle As System.Windows.Forms.PictureBox
    Friend WithEvents picStart As System.Windows.Forms.PictureBox
    Friend WithEvents picHelp As System.Windows.Forms.PictureBox
    Friend WithEvents picExit As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem

End Class
