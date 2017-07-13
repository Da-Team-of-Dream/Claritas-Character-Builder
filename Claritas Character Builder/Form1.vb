Public Class Form1
    Private Sub ButtonWelcomeKin_Click(sender As Object, e As EventArgs) Handles ButtonWelcomeKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelWelcome.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton6.CheckedChanged, RadioButton30.CheckedChanged, RadioButton29.CheckedChanged, RadioButton24.CheckedChanged, RadioButton23.CheckedChanged, RadioButton18.CheckedChanged, RadioButton17.CheckedChanged, RadioButton12.CheckedChanged, RadioButton11.CheckedChanged

    End Sub

    Private Sub ButtonKinWelcome_Click(sender As Object, e As EventArgs) Handles ButtonKinWelcome.Click
        Me.PanelWelcome.Enabled = True
        Me.PanelWelcome.BringToFront()
        Me.PanelKin.Enabled = False

    End Sub

    Private Sub PanelKin_Paint(sender As Object, e As PaintEventArgs) Handles PanelKin.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LabelKinDarkelf.Click, Label38.Click, Label23.Click

    End Sub
End Class
