Public Class Form1

    Dim BackgroundBox(23) As Boolean
    Dim OldBackgroundBox As Integer = 0
    Dim NewBackgroundBox As Integer = 0

    Function BackgroundCount() As Boolean
        Dim n As Integer = 0
        For x = 0 To 22
            If BackgroundBox(x) Then
                n = n + 1
            End If
        Next
        If n >= 2 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub BackgroundCheckboxControl(N As Integer)
        If BackgroundBox(N) = False Then
            If BackgroundCount() Then
                If OldBackgroundBox = 1 Then
                    Me.CheckBoxBackgroundsSeaworthy.Checked = False
                ElseIf OldBackgroundBox = 2 Then
                    Me.CheckBoxBackgroundsBlacksmith.Checked = False
                ElseIf OldBackgroundBox = 3 Then
                    Me.CheckBoxBackgroundsTailor.Checked = False
                ElseIf OldBackgroundBox = 4 Then
                    Me.CheckBoxBackgroundsScholar.Checked = False
                ElseIf OldBackgroundBox = 5 Then
                    Me.CheckBoxBackgroundsArcanescholar.Checked = False
                ElseIf OldBackgroundBox = 6 Then
                    Me.CheckBoxBackgroundsRepairman.Checked = False
                ElseIf OldBackgroundBox = 7 Then
                    Me.CheckBoxBackgroundsFisherman.Checked = False
                ElseIf OldBackgroundBox = 8 Then
                    Me.CheckBoxBackgroundsArchitect.Checked = False
                ElseIf OldBackgroundBox = 9 Then
                    Me.CheckBoxBackgroundsWoodsman.Checked = False
                ElseIf OldBackgroundBox = 10 Then
                    Me.CheckBoxBackgroundsCartographer.Checked = False
                ElseIf OldBackgroundBox = 11 Then
                    Me.CheckBoxBackgroundsSmuggler.Checked = False
                ElseIf OldBackgroundBox = 12 Then
                    Me.CheckBoxBackgroundsHistorian.Checked = False
                ElseIf OldBackgroundBox = 13 Then
                    Me.CheckBoxBackgroundsBotanist.Checked = False
                ElseIf OldBackgroundBox = 14 Then
                    Me.CheckBoxBackgroundsMiddleman.Checked = False
                ElseIf OldBackgroundBox = 15 Then
                    Me.CheckBoxBackgroundsGuard.Checked = False
                ElseIf OldBackgroundBox = 16 Then
                    Me.CheckBoxBackgroundsEnchantmentspecialist.Checked = False
                ElseIf OldBackgroundBox = 17 Then
                    Me.CheckBoxBackgroundsCleanser.Checked = False
                ElseIf OldBackgroundBox = 18 Then
                    Me.CheckBoxBackgroundsTradesman.Checked = False
                ElseIf OldBackgroundBox = 19 Then
                    Me.CheckBoxBackgroundsWanderer.Checked = False
                ElseIf OldBackgroundBox = 20 Then
                    Me.CheckBoxBackgroundsUrchin.Checked = False
                ElseIf OldBackgroundBox = 21 Then
                    Me.CheckBoxBackgroundsWeaponsarmorknowledge.Checked = False
                ElseIf OldBackgroundBox = 22 Then
                    Me.CheckBoxBackgroundsCourier.Checked = False
                End If
            End If
            OldBackgroundBox = NewBackgroundBox
            NewBackgroundBox = N
        End If
        BackgroundBox(1) = Me.CheckBoxBackgroundsSeaworthy.Checked
        BackgroundBox(2) = Me.CheckBoxBackgroundsBlacksmith.Checked
        BackgroundBox(3) = Me.CheckBoxBackgroundsTailor.Checked
        BackgroundBox(4) = Me.CheckBoxBackgroundsScholar.Checked
        BackgroundBox(5) = Me.CheckBoxBackgroundsArcanescholar.Checked
        BackgroundBox(6) = Me.CheckBoxBackgroundsRepairman.Checked
        BackgroundBox(7) = Me.CheckBoxBackgroundsFisherman.Checked
        BackgroundBox(8) = Me.CheckBoxBackgroundsArchitect.Checked
        BackgroundBox(9) = Me.CheckBoxBackgroundsWoodsman.Checked
        BackgroundBox(10) = Me.CheckBoxBackgroundsCartographer.Checked
        BackgroundBox(11) = Me.CheckBoxBackgroundsSmuggler.Checked
        BackgroundBox(12) = Me.CheckBoxBackgroundsHistorian.Checked
        BackgroundBox(13) = Me.CheckBoxBackgroundsBotanist.Checked
        BackgroundBox(14) = Me.CheckBoxBackgroundsMiddleman.Checked
        BackgroundBox(15) = Me.CheckBoxBackgroundsGuard.Checked
        BackgroundBox(16) = Me.CheckBoxBackgroundsEnchantmentspecialist.Checked
        BackgroundBox(17) = Me.CheckBoxBackgroundsCleanser.Checked
        BackgroundBox(18) = Me.CheckBoxBackgroundsTradesman.Checked
        BackgroundBox(19) = Me.CheckBoxBackgroundsWanderer.Checked
        BackgroundBox(20) = Me.CheckBoxBackgroundsUrchin.Checked
        BackgroundBox(21) = Me.CheckBoxBackgroundsWeaponsarmorknowledge.Checked
        BackgroundBox(22) = Me.CheckBoxBackgroundsCourier.Checked

    End Sub





    Private Sub ButtonWelcomeKin_Click(sender As Object, e As EventArgs) Handles ButtonWelcomeKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelWelcome.Enabled = False
    End Sub


    Private Sub ButtonKinWelcome_Click(sender As Object, e As EventArgs) Handles ButtonKinWelcome.Click
        Me.PanelWelcome.Enabled = True
        Me.PanelWelcome.BringToFront()
        Me.PanelKin.Enabled = False

    End Sub

    Private Sub LabelKinAngalucian_Click(sender As Object, e As EventArgs) Handles LabelKinAngalucian.Click
        ConstructInfoForm("KinAngalucian")
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

    Private Sub LabelKinFaerleth_Click(sender As Object, e As EventArgs) Handles LabelKinFaerleth.Click
        ConstructInfoForm("KinFaerleth")
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
        'resets
        Me.RadioButtonNyadTaint.Checked = False
        Me.RadioButtonNyadWateraffinity.Checked = False
        Me.RadioButtonNyadSqueeze.Checked = False
    End Sub

    Private Sub ButtonNyadBackground_Click(sender As Object, e As EventArgs) Handles ButtonNyadBackground.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelNyad.Enabled = False

    End Sub

    Private Sub ButtonNyadInfo_Click(sender As Object, e As EventArgs) Handles ButtonNyadInfo.Click
        ConstructInfoForm("AttributeNyad")
    End Sub

    Private Sub ButtonDryadKin_Click(sender As Object, e As EventArgs) Handles ButtonDryadKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelDryad.Enabled = False
        'resets
        Me.RadioButtonDryadBarkSkin.Checked = False
        Me.RadioButtonDryadNutrients.Checked = False
        Me.RadioButtonDryadRooted.Checked = False
    End Sub

    Private Sub ButtonDryadBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonDryadBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelDryad.Enabled = False
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
        'resets
        Me.RadioButtonGoblinEntertaining.Checked = False
        Me.RadioButtonGoblinLightFrame.Checked = False
        Me.RadioButtonGoblinRollAway.Checked = False
    End Sub

    Private Sub ButtonGoblinBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonGoblinBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelGoblin.Enabled = False
    End Sub

    Private Sub ButtonGnomeKin_Click(sender As Object, e As EventArgs) Handles ButtonGnomeKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelGnome.Enabled = False
        'resets
        Me.RadioButtonGnomeEfficientArmor.Checked = False
        Me.RadioButtonGnomeSmallSize.Checked = False
        Me.RadioButtonGnomeTrinkets.Checked = False
    End Sub

    Private Sub ButtonGnomeBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonGnomeBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelGnome.Enabled = False
    End Sub

    Private Sub ButtonGnomeInfo_Click(sender As Object, e As EventArgs) Handles ButtonGnomeInfo.Click
        ConstructInfoForm("AttributeGnome")
    End Sub

    Private Sub ButtonDwarfInfo_Click(sender As Object, e As EventArgs) Handles ButtonDwarfInfo.Click
        ConstructInfoForm("AttributeDwarf")
    End Sub

    Private Sub ButtonDwarfKin_Click(sender As Object, e As EventArgs) Handles ButtonDwarfKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelDwarf.Enabled = False
        'resets
        Me.RadioButtonDwarfDwarfIt.Checked = False
        Me.RadioButtonDwarfExamination.Checked = False
        Me.RadioButtonDwarfLowLightVision.Checked = False
    End Sub

    Private Sub ButtonDwarfBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonDwarfBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelDwarf.Enabled = False
    End Sub

    Private Sub ButtonJadeImperialInfo_Click(sender As Object, e As EventArgs) Handles ButtonJadeImperialInfo.Click
        ConstructInfoForm("AttributeJadeImperial")
    End Sub

    Private Sub ButtonJadeImperialKin_Click(sender As Object, e As EventArgs) Handles ButtonJadeImperialKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelJadeImperial.Enabled = False
        'resets
        Me.RadioButtonJadeImperailSanctioned.Checked = False
        Me.RadioButtonJadeImperialAncestry.Checked = False
        Me.RadioButtonJadeImperialTeamPlayer.Checked = False
    End Sub

    Private Sub ButtonJadeImperialBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonJadeImperialBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelJadeImperial.Enabled = False
    End Sub

    Private Sub ButtonSquirrelInfo_Click(sender As Object, e As EventArgs) Handles ButtonSquirrelInfo.Click
        ConstructInfoForm("AttributeSquirrel")
    End Sub

    Private Sub ButtonSquirrelKin_Click(sender As Object, e As EventArgs) Handles ButtonSquirrelKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelSquirrel.Enabled = False
        'resets
        Me.RadioButtonSquirrelForage.Checked = False
        Me.RadioButtonSquirrelHonorDuel.Checked = False
        Me.RadioButtonSquirrelTacticalWithdrawl.Checked = False
    End Sub

    Private Sub ButtonSquirrelBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonSquirrelBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelSquirrel.Enabled = False
    End Sub

    Private Sub ButtonTrollInfo_Click(sender As Object, e As EventArgs) Handles ButtonTrollInfo.Click
        ConstructInfoForm("AttributeTroll")
    End Sub

    Private Sub ButtonTrollKin_Click(sender As Object, e As EventArgs) Handles ButtonTrollKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelTroll.Enabled = False
        'resets
        Me.RadioButtonTrollLug.Checked = False
        Me.RadioButtonTrollStoneDigestion.Checked = False
        Me.RadioButtonTrollStout.Checked = False
    End Sub

    Private Sub ButtonTrollBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonTrollBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelTroll.Enabled = False
    End Sub

    Private Sub ButtonCatdrahInfo_Click(sender As Object, e As EventArgs) Handles ButtonCatdrahInfo.Click
        ConstructInfoForm("AttributeCatdrah")
    End Sub

    Private Sub ButtonCatdrahKin_Click(sender As Object, e As EventArgs) Handles ButtonCatdrahKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelCatdrah.Enabled = False
        'resets
        Me.RadioButtonCatdrahClimbTree.Checked = False
        Me.RadioButtonCatdrahCuteness.Checked = False
        Me.RadioButtonCatdrahSafeLanding.Checked = False
    End Sub

    Private Sub ButtonCatdrahBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonCatdrahBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelCatdrah.Enabled = False
    End Sub

    Private Sub ButtonKinsmanInfo_Click(sender As Object, e As EventArgs) Handles ButtonKinsmanInfo.Click
        ConstructInfoForm("AttributeKinsman")
    End Sub

    Private Sub ButtonKinsmanKin_Click(sender As Object, e As EventArgs) Handles ButtonKinsmanKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelKinsman.Enabled = False
        'resets
        Me.RadioButtonKinsmanMilitia.Checked = False
        Me.RadioButtonKinsmanNeutrality.Checked = False
        Me.RadioButtonKinsmanTrustMe.Checked = False
    End Sub

    Private Sub ButtonKinsmanBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonKinsmanBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelKinsman.Enabled = False
    End Sub

    Private Sub ButtonMinotaurInfo_Click(sender As Object, e As EventArgs) Handles ButtonMinotaurInfo.Click
        ConstructInfoForm("AttributeMinotaur")
    End Sub

    Private Sub ButtonMinotaurKin_Click(sender As Object, e As EventArgs) Handles ButtonMinotaurKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelMinotaur.Enabled = False
        'resets
        Me.RadioButtonMinotaurCharge.Checked = False
        Me.RadioButtonMinotaurDaunting.Checked = False
        Me.RadioButtonMinotaurRam.Checked = False
    End Sub

    Private Sub ButtonMinotaurBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonMinotaurBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelMinotaur.Enabled = False
    End Sub

    Private Sub ButtonAngelucianInfo_Click(sender As Object, e As EventArgs) Handles ButtonAngelucianInfo.Click
        ConstructInfoForm("AttributeAngalucian")
    End Sub

    Private Sub ButtonAngalucianKin_Click(sender As Object, e As EventArgs) Handles ButtonAngalucianKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelAngalucian.Enabled = False
        'resets
        Me.RadioButtonAngalucianAmaze.Checked = False
        Me.RadioButtonAngalucianBeaconoflight.Checked = False
        Me.RadioButtonAngalucianBlessedweapon.Checked = False
        Me.RadioButtonAngalucianFlight.Checked = False
        Me.RadioButtonAngalucianTakeheed.Checked = False

    End Sub

    Private Sub ButtonAngalucianBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonAngalucianBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelAngalucian.Enabled = False
    End Sub

    Private Sub ButtonDarkelfKin_Click(sender As Object, e As EventArgs) Handles ButtonDarkelfKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelDarkelf.Enabled = False
        'resets
        Me.RadioButtonDarkelfAlignment.Checked = False
        Me.RadioButtonDarkelfLightsleeper.Checked = False
        Me.RadioButtonDarkelfNightvision.Checked = False
    End Sub

    Private Sub ButtonDarkelfInfo_Click(sender As Object, e As EventArgs) Handles ButtonDarkelfInfo.Click
        ConstructInfoForm("AttributeDarkelf")
    End Sub

    Private Sub ButtonDarkelfBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonDarkelfBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelDarkelf.Enabled = False
    End Sub

    Private Sub ButtonFelucianInfo_Click(sender As Object, e As EventArgs) Handles ButtonFelucianInfo.Click
        ConstructInfoForm("AttributeFelucian")
    End Sub

    Private Sub ButtonFelucianKin_Click(sender As Object, e As EventArgs) Handles ButtonFelucianKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelFelucian.Enabled = False
        'resets
        Me.RadioButtonFelucianDarkness.Checked = False
        Me.RadioButtonFelucianHangingaround.Checked = False
        Me.RadioButtonFelucianWingburst.Checked = False
    End Sub

    Private Sub ButtonFelucianBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonFelucianBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelFelucian.Enabled = False
    End Sub

    Private Sub ButtonGigayonaInfo_Click(sender As Object, e As EventArgs) Handles ButtonGigayonaInfo.Click
        ConstructInfoForm("AttributeGigayona")
    End Sub

    Private Sub ButtonGigayonaKin_Click(sender As Object, e As EventArgs) Handles ButtonGigayonaKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelGigayona.Enabled = False
        'resets
        Me.RadioButtonGigayonaBellysmash.Checked = False
        Me.RadioButtonGigayonaFoodsfood.Checked = False
        Me.RadioButtonGigayonaThickcoat.Checked = False
    End Sub

    Private Sub ButtonGigayonaBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonGigayonaBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelGigayona.Enabled = False
    End Sub

    Private Sub ButtonHighelfInfo_Click(sender As Object, e As EventArgs) Handles ButtonHighelfInfo.Click
        ConstructInfoForm("AttributeHighelf")
    End Sub

    Private Sub ButtonHighelfKin_Click(sender As Object, e As EventArgs) Handles ButtonHighelfKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelHighelf.Enabled = False
        'resets
        Me.RadioButtonHighelfBedazzle.Checked = False
        Me.RadioButtonHighelfColorsofthewind.Checked = False
        Me.RadioButtonHighelfLightfoot.Checked = False
    End Sub

    Private Sub ButtonHighelfBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonHighelfBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelHighelf.Enabled = False
    End Sub

    Private Sub ButtonFaerlethInfo_Click(sender As Object, e As EventArgs) Handles ButtonFaerlethInfo.Click
        ConstructInfoForm("AttributeFaerleth")
    End Sub

    Private Sub ButtonFaerlethKin_Click(sender As Object, e As EventArgs) Handles ButtonFaerlethKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelFaerleth.Enabled = False
        'resets
        Me.RadioButtonFaerlethHideyhole.Checked = False
        Me.RadioButtonFaerlethMastermunchyologist.Checked = False
        Me.RadioButtonFaerlethRiddle.Checked = False
        Me.RadioButtonFaerlethToughfeet.Checked = False
    End Sub

    Private Sub ButtonFaerlethBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonFaerlethBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelFaerleth.Enabled = False
    End Sub

    Private Sub ButtonOrcInfo_Click(sender As Object, e As EventArgs) Handles ButtonOrcInfo.Click
        ConstructInfoForm("AttributeOrc")
    End Sub

    Private Sub ButtonOrcKin_Click(sender As Object, e As EventArgs) Handles ButtonOrcKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelOrc.Enabled = False
        'resets
        Me.RadioButtonOrcBloodpool.Checked = False
        Me.RadioButtonOrcFeelnopain.Checked = False
        Me.RadioButtonOrcGruff.Checked = False
    End Sub

    Private Sub ButtonOrcBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonOrcBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelOrc.Enabled = False
    End Sub

    Private Sub ButtonSanjoranInfo_Click(sender As Object, e As EventArgs) Handles ButtonSanjoranInfo.Click
        ConstructInfoForm("AttributeSanjoran")
    End Sub

    Private Sub ButtonSanjoranKin_Click(sender As Object, e As EventArgs) Handles ButtonSanjoranKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelSanjoran.Enabled = False
        'resets
        Me.RadioButtonSanjoranNip.Checked = False
        Me.RadioButtonSanjoranRegrowth.Checked = False
        Me.RadioButtonSanjoranResistance.Checked = False
    End Sub

    Private Sub ButtonSanjoranBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonSanjoranBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelSanjoran.Enabled = False
    End Sub

    Private Sub ButtonWastelanderInfo_Click(sender As Object, e As EventArgs) Handles ButtonWastelanderInfo.Click
        ConstructInfoForm("AttributeWastelander")
    End Sub

    Private Sub ButtonWastelanderKin_Click(sender As Object, e As EventArgs) Handles ButtonWastelanderKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelWastelander.Enabled = False
        'resets
        Me.RadioButtonWastelanderBlendin.Checked = False
        Me.RadioButtonWastelanderStreetsmart.Checked = False
        Me.RadioButtonWastelanderThuroughsearch.Checked = False
    End Sub

    Private Sub ButtonWastelanderBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonWastelanderBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelWastelander.Enabled = False
    End Sub

    Private Sub ButtonWolfsbeinInfo_Click(sender As Object, e As EventArgs) Handles ButtonWolfsbeinInfo.Click
        ConstructInfoForm("AttributeWolfsbein")
    End Sub

    Private Sub ButtonWolfsbeinKin_Click(sender As Object, e As EventArgs) Handles ButtonWolfsbeinKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelWolfsbein.Enabled = False
        'resets
        Me.RadioButtonWolfsbeinPowerthrough.Checked = False
        Me.RadioButtonWolfsbeinRedolent.Checked = False
        Me.RadioButtonWolfsbeinTrustworthy.Checked = False
    End Sub

    Private Sub ButtonWolfsbeinBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonWolfsbeinBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelWolfsbein.Enabled = False
    End Sub

    Private Sub ButtonWoodelfInfo_Click(sender As Object, e As EventArgs) Handles ButtonWoodelfInfo.Click
        ConstructInfoForm("AttributeWoodelf")
    End Sub

    Private Sub ButtonWoodelfKin_Click(sender As Object, e As EventArgs) Handles ButtonWoodelfKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelWoodelf.Enabled = False
        'resets
        Me.RadioButtonWoodelfElementaryinvocation.Checked = False
        Me.RadioButtonWoodelfForestflight.Checked = False
        Me.RadioButtonWoodelfLifeattunement.Checked = False
    End Sub

    Private Sub ButtonWoodelfBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonWoodelfBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelWoodelf.Enabled = False
    End Sub



    Private Sub ButtonDrakohnonInfo_Click(sender As Object, e As EventArgs) Handles ButtonDrakohnonInfo.Click
        ConstructInfoForm("AttributeDrakonnon")
    End Sub

    Private Sub ButtonDrakohnonBackground_Click(sender As Object, e As EventArgs) Handles ButtonDrakohnonBackground.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelDrakohnon.Enabled = False
    End Sub

    Private Sub ButtonDrakohnonKin_Click(sender As Object, e As EventArgs) Handles ButtonDrakohnonKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelDrakohnon.Enabled = False
    End Sub
End Class