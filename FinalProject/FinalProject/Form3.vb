Public Class Form3
    'Gurtaj Khabra, Anthony Ngo
    'Final Project
    'Information Form

    Private Sub Form3_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        'Shows Form1 (Menu) if Form3 (Instructions) is closed
        Form1.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        'Shows Form1 (Menu) and closes Form3 (Instructions)
        Me.Close()
        Form1.Show()

    End Sub
End Class