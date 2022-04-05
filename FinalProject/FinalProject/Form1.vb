Public Class Form1
    'Gurtaj Khabra, Anthony Ngo
    'Final Project
    'Menu Form

    Private Sub picStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picStart.Click

        'Opens Form2 (Game) and hides Form1 (Menu) when "Start" is clicked
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub picHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHelp.Click

        'Opens Form3 (Instructions) and hides Form1 (Menu) when "Help" is clicked
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub picExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picExit.Click

        'Closes the game when "Exit" is clicked
        End

    End Sub

    Private Sub NewGameMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewGame.Click

        'Opens Form2 (Game) and hides Form1 (Menu)
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub HelpMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click

        'Opens Form3 (Instructions) and hides Form1 (Menu)
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub ExitMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click

        'Closes the game
        End

    End Sub
End Class
