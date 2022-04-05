Public Class Form2
    'Gurtaj Khabra, Anthony Ngo
    'Final Project
    'Game Form

    Const intSCOREPERTARGET As Integer = 100 'The score gained for each target destroyed
    Const intMAXMISSES = 5 'The maximum amount of misses allowed by the player
    Dim intTime As Integer 'Used to keep track of time and determine when to change targetspeed and tmrUpdate interval
    Dim intScore As Integer 'Used to keep track of player's score
    Dim intMisses As Integer 'Used to keep track of number of misses and it will create a picturebox everytime you miss a target
    Dim intMethod As Integer 'Used to randomize a method from 1 - 6
    Dim picTarget As PictureBox 'Used to create targets based on a random method
    Dim picCross As PictureBox 'Used to create an "X" image everytime 
    Dim intLoop As Integer 'Used within "For...Next" loops
    Dim intTargetSpeed As Integer 'Used to set target speed
    Dim intDestroyed As Integer 'Used to keep track of number of targets destroyed

    Private Sub Form2_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        'Shows Form1 (Menu) if Form2 (Game) is closed
        Form1.Show()

    End Sub

    Private Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick

        'Uses a timer which increases the time by 1 for every tick (1 second)
        intTime = intTime + 1
        Me.lblTime.Text = intTime
        Me.lblScore.Text = intScore
        Call TargetSpeed()

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Randomizes target positions, randomly selects a target from the 6 possible, and creates 
    'targets
    '
    'post:Random targets are created
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub tmrTargets_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTargets.Tick

        Dim XPosition As Integer

        XPosition = RndInt(0, 9)
        intMethod = RndInt(1, 6)
        picTarget = New PictureBox
        picTarget.Width = 100
        picTarget.Height = 100
        picTarget.Top = 0 - picTarget.Height
        picTarget.Left = 100 * XPosition
        picTarget.BackColor = Color.Transparent

        Select Case intMethod
            Case 1
                picTarget.Image = My.Resources.Q
                picTarget.Tag = "q"
            Case 2
                picTarget.Image = My.Resources.W
                picTarget.Tag = "w"
            Case 3
                picTarget.Image = My.Resources.E
                picTarget.Tag = "e"
            Case 4
                picTarget.Image = My.Resources.R
                picTarget.Tag = "r"
            Case 5
                picTarget.Image = My.Resources.D
                picTarget.Tag = "d"
            Case 6
                picTarget.Image = My.Resources.F
                picTarget.Tag = "f"
        End Select

        Controls.Add(picTarget)

        tmrCheckMiss.Enabled = True
        tmrMove.Enabled = True

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Changes intTargetSpeed and tmrUpdate.interval at certain time checkpoints
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub TargetSpeed()

        If intTime = 5 Then
            intTargetSpeed = 7
            tmrCheckMiss.Interval = 400
        ElseIf intTime = 10 Then
            intTargetSpeed = 9
            tmrCheckMiss.Interval = 700
        ElseIf intTime = 20 Then
            intTargetSpeed = 11
            tmrCheckMiss.Interval = 800
        ElseIf intTime = 25 Then
            intTargetSpeed = 13
            tmrCheckMiss.Interval = 1000
        ElseIf intTime = 45 Then
            intTargetSpeed = 15
        ElseIf intTime = 60 Then
            intTargetSpeed = 16
        ElseIf intTime = 100 Then
            intTargetSpeed = 18
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Returns a random integer which fits into the range of intLowNum and intHighNum
    '
    'post: Creates a random integer
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Function RndInt(ByVal intLowNum As Integer, ByVal intHighNum As Integer)

        Randomize()
        Return (Int((intHighNum - intLowNum + 1) * Rnd()) + intLowNum)

    End Function

    Private Sub tmrMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMove.Tick

        picTarget.Top += intTargetSpeed
        Call CheckGameOver()

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Creates invisible picture box to prevent error on startup, sets initial target speed
    '
    'post: Invisible picture box created, target speed set to 6
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        picTarget = New PictureBox
        picTarget.Width = 100
        picTarget.Height = 100
        picTarget.Top = 0 - picTarget.Height
        picTarget.Visible = False
        intTargetSpeed = 6

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Checks if the top of picTarget is equal to the top of picBottom, adds miss, calls ShowMisses
    '
    'post: Adds 1 to intMisses, ShowMisses called
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckMiss.Tick

        If picTarget.Top > picBottom.Top Then
            Me.Controls.Remove(picTarget)
            intMisses += 1
            Call ShowMisses()
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Creates picCross if called by tmrUpdate and Form2_KeyUp, sets them next to each other
    '
    'post: picCross created and spaced apart
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub ShowMisses()

        For Me.intLoop = 1 To intMisses
            If intMisses < 6 Then
                picCross = New PictureBox
                picCross.BackColor = Color.Black
                picCross.BackgroundImage = My.Resources.White_X
                picCross.Width = 50
                picCross.Height = 50
                picCross.Top = 588
                picCross.Left = 50 * intLoop + 10 + 5 * intLoop
                picCross.BackgroundImageLayout = ImageLayout.Stretch
                Me.Controls.Add(picCross)
                picCross.BringToFront()
            End If
        Next intLoop

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Checks the key pressed for each target, if correct key then calls UpdateScore, if incorrect 
    'calls ShowMisses
    '
    'post: Calls UpdateScore or ShowMisses
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub Form2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        Dim chrKeyPressed As Char

        Select Case e.KeyValue
            Case Keys.Q
                chrKeyPressed = "q"
            Case Keys.W
                chrKeyPressed = "w"
            Case Keys.E
                chrKeyPressed = "e"
            Case Keys.R
                chrKeyPressed = "r"
            Case Keys.D
                chrKeyPressed = "d"
            Case Keys.F
                chrKeyPressed = "f"
            Case Else
                chrKeyPressed = "X"
        End Select

        If picTarget.Visible = True Then
            'Prevents a glitch where misses goes up by 2 if target is close to bottom and wrong key is hit
            picTarget.Top = -100
            If chrKeyPressed = picTarget.Tag Then
                Me.Controls.Remove(picTarget)
                tmrMove.Enabled = False
                intDestroyed += 1
                Call UpdateScore()
            Else
                Me.Controls.Remove(picTarget)
                tmrMove.Enabled = False
                intMisses += 1
                Call ShowMisses()
            End If
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Checks if intMisses is greater than 4, if true then all timers disabled, "Game over" 
    'text displayed. Form 2 closes and reopens Form 1
    '
    'post: Timers disabled, "Game over" message displayed, returns user to main menu if 
    'intMisses is greater than 4
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub CheckGameOver()

        Dim intResult As Integer
        intLoop = 0

        If intMisses > 4 Then
            tmrCheckMiss.Enabled = False
            tmrMain.Enabled = False
            tmrTargets.Enabled = False
            tmrMove.Enabled = False

            intResult = MessageBox.Show("Game over.", "Reaction Mechanics")

            Form1.Show()
            Me.Close()

        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Updates score depending on targets destroyed
    '
    'post: intScore is changed
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub UpdateScore()

        intScore = intDestroyed * intSCOREPERTARGET

    End Sub

End Class