Public Class Form1
    Private Sub ButtonWelcomeKin_Click(sender As Object, e As EventArgs) Handles ButtonWelcomeKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelWelcome.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonKinWolfsbein.CheckedChanged, RadioButtonKinWastelander.CheckedChanged, RadioButtonKinAngalucian.CheckedChanged, RadioButtonKinWoodElf.CheckedChanged

    End Sub

    Private Sub ButtonKinWelcome_Click(sender As Object, e As EventArgs) Handles ButtonKinWelcome.Click
        Me.PanelWelcome.Enabled = True
        Me.PanelWelcome.BringToFront()
        Me.PanelKin.Enabled = False

    End Sub

    Private Sub LabelKinAngalucian_Click(sender As Object, e As EventArgs) Handles LabelKinAngalucian.Click
        MsgBox("it worked!!")
        'ConstructInfoForm("KinAngalucian")
    End Sub

    Private Sub LabelKinCatdrah_Click(sender As Object, e As EventArgs) Handles LabelKinCatdrah.Click
        ConstructInfoForm("KinCatdrah")
    End Sub

    Private Sub LabelKinDarkelf_Click(sender As Object, e As EventArgs) Handles LabelKinDarkelf.Click
        ConstructInfoForm("KinDarkElf")
    End Sub

    Private Sub LabelKinDrakhonon_Click(sender As Object, e As EventArgs) Handles LabelKinDrakhonon.Click
        ConstructInfoForm("KinDrakhonon")
    End Sub

    Private Sub LabelKinDryad_Click(sender As Object, e As EventArgs) Handles LabelKinDryad.Click
        ConstructInfoForm("KinDryad")
    End Sub

    Private Sub LabelKinDwarf_Click(sender As Object, e As EventArgs) Handles LabelKinDwarf.Click
        ConstructInfoForm("KinDwarf")
    End Sub

    Private Sub LabelKinFairy_Click(sender As Object, e As EventArgs) Handles LabelKinFairy.Click
        ConstructInfoForm("KinFairy")
    End Sub

    Private Sub LabelKinFelucian_Click(sender As Object, e As EventArgs) Handles LabelKinFelucian.Click
        ConstructInfoForm("KinFelucian")
    End Sub

    Private Sub LabelKinGiGaYoNa_Click(sender As Object, e As EventArgs) Handles LabelKinGiGaYoNa.Click
        ConstructInfoForm("KinGi-GaYo-Na")
    End Sub

    Private Sub LabelKinGnome_Click(sender As Object, e As EventArgs) Handles LabelKinGnome.Click
        ConstructInfoForm("KinGnome")
    End Sub

    Private Sub LabelKinGoblin_Click(sender As Object, e As EventArgs) Handles LabelKinGoblin.Click
        ConstructInfoForm("KinGoblin")
    End Sub

    Private Sub LabelKinHighElf_Click(sender As Object, e As EventArgs) Handles LabelKinHighElf.Click
        ConstructInfoForm("KinHighElf")
    End Sub

    Private Sub LabelKinHobbit_Click(sender As Object, e As EventArgs) Handles LabelKinHobbit.Click
        ConstructInfoForm("KinHobbit")
    End Sub

    Private Sub LabelKinJadeImperial_Click(sender As Object, e As EventArgs) Handles LabelKinJadeImperial.Click
        ConstructInfoForm("KinJadeImperial")
    End Sub

    Private Sub LabelKinKinsmen_Click(sender As Object, e As EventArgs) Handles LabelKinKinsmen.Click
        ConstructInfoForm("KinKinsmen")
    End Sub

    Private Sub LabelKinMinotaur_Click(sender As Object, e As EventArgs) Handles LabelKinMinotaur.Click
        ConstructInfoForm("KinMinotaur")
    End Sub

    Private Sub LabelKinNyad_Click(sender As Object, e As EventArgs) Handles LabelKinNyad.Click
        ConstructInfoForm("KinNyad")
    End Sub

    Private Sub LabelKinOrc_Click(sender As Object, e As EventArgs) Handles LabelKinOrc.Click
        ConstructInfoForm("KinOrc")
    End Sub

    Private Sub LabelKinSanjoran_Click(sender As Object, e As EventArgs) Handles LabelKinSanjoran.Click
        ConstructInfoForm("KinSanjoran")
    End Sub

    Private Sub LabelKinSquirrel_Click(sender As Object, e As EventArgs) Handles LabelKinSquirrel.Click
        ConstructInfoForm("KinSquirrels")
    End Sub

    Private Sub LabelKinTroll_Click(sender As Object, e As EventArgs) Handles LabelKinTroll.Click
        ConstructInfoForm("KinTroll")
    End Sub

    Private Sub LabelKinWastelander_Click(sender As Object, e As EventArgs) Handles LabelKinWastelander.Click
        ConstructInfoForm("KinWastelander")
    End Sub

    Private Sub LabelKinWolfsbein_Click(sender As Object, e As EventArgs) Handles LabelKinWolfsbein.Click
        ConstructInfoForm("KinWolfsbein")
    End Sub

    Private Sub LabelKinWoodElf_Click(sender As Object, e As EventArgs) Handles LabelKinWoodElf.Click
        ConstructInfoForm("KinWoodElf")
    End Sub

    Private Sub ButtonNyadKin_Click(sender As Object, e As EventArgs) Handles ButtonNyadKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelNyad.Enabled = False
    End Sub

    Private Sub ButtonNyadBackground_Click(sender As Object, e As EventArgs) Handles ButtonNyadBackground.Click
        'Me.PanelBackgrounds.Enabled = True
        'Me.PanelBackgrounds.BringToFront()
        'Me.PanelNyad.Enabled = False

    End Sub

    Private Sub ButtonNyadInfo_Click(sender As Object, e As EventArgs) Handles ButtonNyadInfo.Click
        ConstructInfoForm("AttributeNyad")
    End Sub

    Private Sub ButtonDryadKin_Click(sender As Object, e As EventArgs) Handles ButtonDryadKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelDryad.Enabled = False
    End Sub

    Private Sub ButtonDryadBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonDryadBackgrounds.Click
        'Me.PanelBackgrounds.Enabled = True
        'Me.PanelBackgrounds.BringToFront()
        'Me.PanelDryad.Enabled = False
    End Sub

    Private Sub ButtonDryadInfo_Click(sender As Object, e As EventArgs) Handles ButtonDryadInfo.Click
        ConstructInfoForm("AttributeDryad")
    End Sub

    Private Sub ButtonGoblinInfo_Click(sender As Object, e As EventArgs) Handles ButtonGoblinInfo.Click
        ConstructInfoForm("AttributeGoblin")
    End Sub

    Private Sub ButtonGoblinKin_Click(sender As Object, e As EventArgs) Handles ButtonGoblinKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelGoblin.Enabled = False
    End Sub

    Private Sub ButtonGoblinBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonGoblinBackgrounds.Click
        'Me.PanelBackgrounds.Enabled = True
        'Me.PanelBackgrounds.BringToFront()
        'Me.PanelGoblin.Enabled = False
    End Sub

    Private Sub ButtonGnomeKin_Click(sender As Object, e As EventArgs) Handles ButtonGnomeKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelGnome.Enabled = False
    End Sub

    Private Sub ButtonGnomeBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonGnomeBackgrounds.Click
        'Me.PanelBackgrounds.Enabled = True
        'Me.PanelBackgrounds.BringToFront()
        'Me.PanelGnome.Enabled = False
    End Sub

    Private Sub ButtonGnomeInfo_Click(sender As Object, e As EventArgs) Handles ButtonGnomeInfo.Click
        ConstructInfoForm("AttributeGnome")
    End Sub
End Class
