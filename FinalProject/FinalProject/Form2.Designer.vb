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
        Me.components = New System.ComponentModel.Container()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblScoreMessage = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTargets = New System.Windows.Forms.Timer(Me.components)
        Me.picBottom = New System.Windows.Forms.PictureBox()
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCheckMiss = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTime.Location = New System.Drawing.Point(412, 571)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(160, 77)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "0"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoreMessage
        '
        Me.lblScoreMessage.BackColor = System.Drawing.Color.Black
        Me.lblScoreMessage.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreMessage.ForeColor = System.Drawing.SystemColors.Control
        Me.lblScoreMessage.Location = New System.Drawing.Point(845, 605)
        Me.lblScoreMessage.Name = "lblScoreMessage"
        Me.lblScoreMessage.Size = New System.Drawing.Size(87, 48)
        Me.lblScoreMessage.TabIndex = 1
        Me.lblScoreMessage.Text = "Score:"
        Me.lblScoreMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Black
        Me.lblScore.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.SystemColors.Control
        Me.lblScore.Location = New System.Drawing.Point(918, 605)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(61, 48)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        Me.tmrMain.Interval = 1000
        '
        'tmrTargets
        '
        Me.tmrTargets.Enabled = True
        Me.tmrTargets.Interval = 2000
        '
        'picBottom
        '
        Me.picBottom.BackColor = System.Drawing.Color.Black
        Me.picBottom.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.picBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.picBottom.Location = New System.Drawing.Point(0, 571)
        Me.picBottom.Name = "picBottom"
        Me.picBottom.Size = New System.Drawing.Size(984, 86)
        Me.picBottom.TabIndex = 4
        Me.picBottom.TabStop = False
        '
        'tmrMove
        '
        Me.tmrMove.Interval = 1
        '
        'tmrCheckMiss
        '
        Me.tmrCheckMiss.Interval = 300
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalProject.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 657)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreMessage)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.picBottom)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(990, 686)
        Me.MinimumSize = New System.Drawing.Size(990, 686)
        Me.Name = "Form2"
        Me.Text = "Reaction Mechanics"
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblScoreMessage As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents tmrTargets As System.Windows.Forms.Timer
    Friend WithEvents picBottom As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMove As System.Windows.Forms.Timer
    Friend WithEvents tmrCheckMiss As System.Windows.Forms.Timer
End Class
