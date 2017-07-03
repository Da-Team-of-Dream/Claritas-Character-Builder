Public Class Form1
    Private Sub ButtonWelcomeKin_Click(sender As Object, e As EventArgs) Handles ButtonWelcomeKin.Click
        Me.Panel2.Enabled = True
        Me.Panel2.BringToFront()
        Me.welcome.Enabled = False
    End Sub
End Class
