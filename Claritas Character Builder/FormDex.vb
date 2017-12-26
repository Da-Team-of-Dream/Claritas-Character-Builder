Public Class FormDex
    Private Sub PanelWeapondex_Paint(sender As Object, e As PaintEventArgs) Handles PanelWeapondex.Paint

    End Sub

    Private Sub ButtonWeaponartWeapondex_Click(sender As Object, e As EventArgs) Handles ButtonWeaponartWeapondex.Click
        PanelWeaponart.Enabled = False
        PanelWeapondex.Enabled = True
        PanelWeapondex.BringToFront()
    End Sub

    Private Sub ButtonWeapondexWeaponart_Click(sender As Object, e As EventArgs) Handles ButtonWeapondexWeaponart.Click
        PanelWeapondex.Enabled = False
        PanelWeaponart.Enabled = True
        PanelWeaponart.BringToFront()
    End Sub

    Private Sub ButtonWeaponartInfo_Click(sender As Object, e As EventArgs) Handles ButtonWeaponartInfo.Click
        ConstructInfoForm("Weaponart")
    End Sub
End Class