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

    Sub SetHalfbreedPanel()
        If Me.RadioButtonKinAngalucian.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinCatdrah.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinDarkelf.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinDrakhonon.Checked = True Then
            Me.RadioButtonHalfbreedDrakhonon.Enabled = False
        ElseIf Me.RadioButtonKinDryad.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinDwarf.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinFaerleth.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinFairy.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinFelucian.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinGiGaYoNa.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinGnome.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinGoblin.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinHighElf.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinJadeImperial.Checked = True Then
            Me.RadioButtonHalfbreedJadeimperial.Enabled = False
        ElseIf Me.RadioButtonKinKinsmen.Checked = True Then
            Me.RadioButtonHalfbreedKinsmen.Enabled = False
        ElseIf Me.RadioButtonKinMinotaur.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinNyad.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinOrc.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinSquirrel.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinWastelander.Checked = True Then
            Me.RadioButtonHalfbreedWastelander.Enabled = False
        ElseIf Me.RadioButtonKinWolfsbein.Checked = True Then
            RadioButtonHalfbreedAngelucian.Enabled = False
            RadioButtonHalfbreedCatdrah.Enabled = False
            RadioButtonHalfbreedDarkelf.Enabled = False
            RadioButtonHalfbreedDryad.Enabled = False
            RadioButtonHalfbreedDwarf.Enabled = False
            RadioButtonHalfbreedFairy.Enabled = False
            RadioButtonHalfbreedFelucian.Enabled = False
            RadioButtonHalfbreedGigayona.Enabled = False
            RadioButtonHalfbreedGnome.Enabled = False
            RadioButtonHalfbreedGoblin.Enabled = False
            RadioButtonHalfbreedHighelf.Enabled = False
            RadioButtonHalfbreedFaerleth.Enabled = False
            RadioButtonHalfbreedMinotaur.Enabled = False
            RadioButtonHalfbreedNyad.Enabled = False
            RadioButtonHalfbreedOrc.Enabled = False
            RadioButtonHalfbreedSanjoran.Enabled = False
            RadioButtonHalfbreedTroll.Enabled = False
            RadioButtonHalfbreedWolfsbein.Enabled = False
            RadioButtonHalfbreedWoodelf.Enabled = False
            RadioButtonHalfbreedSquirrel.Enabled = False
        ElseIf Me.RadioButtonKinWoodElf.Checked = True Then

        End If
    End Sub

    Private Sub ButtonWelcomeKin_Click(sender As Object, e As EventArgs) Handles ButtonWelcomeKin.Click
        If TextboxWelcomePlayername.Text = "" Or TextboxWelcomePlayerage.Text = "" Then
            MsgBox("Please enter your name and age.")
        Else
            Me.PanelKin.Enabled = True
            Me.PanelKin.BringToFront()
            Me.PanelWelcome.Enabled = False
        End If
    End Sub

    Private Sub ButtonKinWelcome_Click(sender As Object, e As EventArgs) Handles ButtonKinWelcome.Click
        Me.PanelWelcome.Enabled = True
        Me.PanelWelcome.BringToFront()
        Me.PanelKin.Enabled = False

    End Sub

#Region "kinfo form"
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
#End Region

#Region "Kin page selection"
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

    Private Sub ButtonFairyKin_Click(sender As Object, e As EventArgs) Handles ButtonFairyKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelFairy.Enabled = False
        'resets
        Me.RadioButtonFairyFlutter.Checked = False
        Me.RadioButtonFairyIlluminate.Checked = False
        Me.RadioButtonFairyPlanttelepathy.Checked = False
        Me.RadioButtonFairyAhlucaro.Checked = False
        Me.RadioButtonFairySzhoom.Checked = False
    End Sub

    Private Sub ButtonFairyBackground_Click(sender As Object, e As EventArgs) Handles ButtonFairyBackgrounds.Click
        Me.PanelBackgrounds.Enabled = True
        Me.PanelBackgrounds.BringToFront()
        Me.PanelFairy.Enabled = False

    End Sub

    Private Sub ButtonFairyInfo_Click(sender As Object, e As EventArgs) Handles ButtonFairyInfo.Click
        ConstructInfoForm("AttributeFairy")
    End Sub

    Private Sub ButtonJadeImperialInfo_Click(sender As Object, e As EventArgs) Handles ButtonJadeImperialInfo.Click
        ConstructInfoForm("AttributeJadeImperial")
    End Sub

    Private Sub ButtonJadeImperialKin_Click(sender As Object, e As EventArgs) Handles ButtonJadeImperialKin.Click
        Me.PanelKin.Enabled = True
        Me.PanelKin.BringToFront()
        Me.PanelJadeImperial.Enabled = False
        'resets
        Me.RadioButtonJadeImperialSanctioned.Checked = False
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
#End Region

    Private Sub ButtonKinAttributes_Click(sender As Object, e As EventArgs) Handles ButtonKinAttributes.Click
        If Me.RadioButtonKinAngalucian.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelAngalucian.BringToFront()
            Me.PanelAngalucian.Enabled = True
        ElseIf Me.RadioButtonKinCatdrah.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelCatdrah.BringToFront()
            Me.PanelCatdrah.Enabled = True
        ElseIf Me.RadioButtonKinDarkelf.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelDarkelf.BringToFront()
            Me.PanelDarkelf.Enabled = True
        ElseIf Me.RadioButtonKinDrakhonon.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelDrakohnon.BringToFront()
            Me.PanelDrakohnon.Enabled = True
        ElseIf Me.RadioButtonKinDryad.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelDryad.BringToFront()
            Me.PanelDryad.Enabled = True
        ElseIf Me.RadioButtonKinDwarf.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelDwarf.BringToFront()
            Me.PanelDwarf.Enabled = True
        ElseIf Me.RadioButtonKinFaerleth.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelFaerleth.BringToFront()
            Me.PanelFaerleth.Enabled = True
        ElseIf Me.RadioButtonKinFairy.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelFairy.BringToFront()
            Me.PanelFairy.Enabled = True
        ElseIf Me.RadioButtonKinFelucian.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelFelucian.BringToFront()
            Me.PanelFelucian.Enabled = True
        ElseIf Me.RadioButtonKinGiGaYoNa.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelGigayona.BringToFront()
            Me.PanelGigayona.Enabled = True
        ElseIf Me.RadioButtonKinGnome.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelGnome.BringToFront()
            Me.PanelGnome.Enabled = True
        ElseIf Me.RadioButtonKinGoblin.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelGoblin.BringToFront()
            Me.PanelGoblin.Enabled = True
        ElseIf Me.RadioButtonKinHighElf.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelHighelf.BringToFront()
            Me.PanelHighelf.Enabled = True
        ElseIf Me.RadioButtonKinJadeImperial.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelJadeImperial.BringToFront()
            Me.PanelJadeImperial.Enabled = True
        ElseIf Me.RadioButtonKinKinsmen.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelKinsman.BringToFront()
            Me.PanelKinsman.Enabled = True
        ElseIf Me.RadioButtonKinMinotaur.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelMinotaur.BringToFront()
            Me.PanelMinotaur.Enabled = True
        ElseIf Me.RadioButtonKinNyad.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelNyad.BringToFront()
            Me.PanelNyad.Enabled = True
        ElseIf Me.RadioButtonKinOrc.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelOrc.BringToFront()
            Me.PanelOrc.Enabled = True
        ElseIf Me.RadioButtonKinSquirrel.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelSquirrel.BringToFront()
            Me.PanelSquirrel.Enabled = True
        ElseIf Me.RadioButtonKinWastelander.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelWastelander.BringToFront()
            Me.PanelWastelander.Enabled = True
        ElseIf Me.RadioButtonKinWolfsbein.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelWolfsbein.BringToFront()
            Me.PanelWolfsbein.Enabled = True
        ElseIf Me.RadioButtonKinWoodElf.Checked = True Then
            Me.PanelKin.Enabled = False
            Me.PanelWoodelf.BringToFront()
            Me.PanelWoodelf.Enabled = True
        Else
            MsgBox("You must select a kin befor moving on!!")
        End If
    End Sub

    Private Sub ButtonBackgroundsKintype_Click(sender As Object, e As EventArgs) Handles ButtonBackgroundsKintype.Click
        If Me.RadioButtonKinAngalucian.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelAngalucian.BringToFront()
            Me.PanelAngalucian.Enabled = True
        ElseIf Me.RadioButtonKinCatdrah.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelCatdrah.BringToFront()
            Me.PanelCatdrah.Enabled = True
        ElseIf Me.RadioButtonKinDarkelf.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelDarkelf.BringToFront()
            Me.PanelDarkelf.Enabled = True
        ElseIf Me.RadioButtonKinDrakhonon.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelDrakohnon.BringToFront()
            Me.PanelDrakohnon.Enabled = True
        ElseIf Me.RadioButtonKinDryad.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelDryad.BringToFront()
            Me.PanelDryad.Enabled = True
        ElseIf Me.RadioButtonKinDwarf.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelDwarf.BringToFront()
            Me.PanelDwarf.Enabled = True
        ElseIf Me.RadioButtonKinFaerleth.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelFaerleth.BringToFront()
            Me.PanelFaerleth.Enabled = True
        ElseIf Me.RadioButtonKinFairy.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelFairy.BringToFront()
            Me.PanelFairy.Enabled = True
        ElseIf Me.RadioButtonKinFelucian.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelFelucian.BringToFront()
            Me.PanelFelucian.Enabled = True
        ElseIf Me.RadioButtonKinGiGaYoNa.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelGigayona.BringToFront()
            Me.PanelGigayona.Enabled = True
        ElseIf Me.RadioButtonKinGnome.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelGnome.BringToFront()
            Me.PanelGnome.Enabled = True
        ElseIf Me.RadioButtonKinGoblin.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelGoblin.BringToFront()
            Me.PanelGoblin.Enabled = True
        ElseIf Me.RadioButtonKinHighElf.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelHighelf.BringToFront()
            Me.PanelHighelf.Enabled = True
        ElseIf Me.RadioButtonKinJadeImperial.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelJadeImperial.BringToFront()
            Me.PanelJadeImperial.Enabled = True
        ElseIf Me.RadioButtonKinKinsmen.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelKinsman.BringToFront()
            Me.PanelKinsman.Enabled = True
        ElseIf Me.RadioButtonKinMinotaur.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelMinotaur.BringToFront()
            Me.PanelMinotaur.Enabled = True
        ElseIf Me.RadioButtonKinNyad.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelNyad.BringToFront()
            Me.PanelNyad.Enabled = True
        ElseIf Me.RadioButtonKinOrc.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelOrc.BringToFront()
            Me.PanelOrc.Enabled = True
        ElseIf Me.RadioButtonKinSquirrel.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelSquirrel.BringToFront()
            Me.PanelSquirrel.Enabled = True
        ElseIf Me.RadioButtonKinWastelander.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelWastelander.BringToFront()
            Me.PanelWastelander.Enabled = True
        ElseIf Me.RadioButtonKinWolfsbein.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelWolfsbein.BringToFront()
            Me.PanelWolfsbein.Enabled = True
        ElseIf Me.RadioButtonKinWoodElf.Checked = True Then
            Me.PanelBackgrounds.Enabled = False
            Me.PanelWoodelf.BringToFront()
            Me.PanelWoodelf.Enabled = True
        Else
            MsgBox("Something went wrong??? :) please restart the program.")
        End If
    End Sub

#Region "Checkbox Checks"
    Private Sub CheckBoxBackgroundsSeaworthy_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsSeaworthy.CheckedChanged
        BackgroundCheckboxControl(1)
    End Sub

    Private Sub CheckBoxBackgroundsBlacksmith_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsBlacksmith.CheckedChanged
        BackgroundCheckboxControl(2)
    End Sub

    Private Sub CheckBoxBackgroundsTailor_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsTailor.CheckedChanged
        BackgroundCheckboxControl(3)
    End Sub

    Private Sub CheckBoxBackgroundsScholar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsScholar.CheckedChanged
        BackgroundCheckboxControl(4)
    End Sub

    Private Sub CheckBoxBackgroundsArcanescholar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsArcanescholar.CheckedChanged
        BackgroundCheckboxControl(5)
    End Sub

    Private Sub CheckBoxBackgroundsRepairman_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsRepairman.CheckedChanged
        BackgroundCheckboxControl(6)
    End Sub

    Private Sub CheckBoxBackgroundsFisherman_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsFisherman.CheckedChanged
        BackgroundCheckboxControl(7)
    End Sub

    Private Sub CheckBoxBackgroundsArchitect_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsArchitect.CheckedChanged
        BackgroundCheckboxControl(8)
    End Sub

    Private Sub CheckBoxBackgroundsWoodsman_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsWoodsman.CheckedChanged
        BackgroundCheckboxControl(9)
    End Sub

    Private Sub CheckBoxBackgroundsCartographer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsCartographer.CheckedChanged
        BackgroundCheckboxControl(10)
    End Sub

    Private Sub CheckBoxBackgroundsSmuggler_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsSmuggler.CheckedChanged
        BackgroundCheckboxControl(11)
    End Sub

    Private Sub CheckBoxBackgroundsHistorian_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsHistorian.CheckedChanged
        BackgroundCheckboxControl(12)
    End Sub

    Private Sub CheckBoxBackgroundsBotanist_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsBotanist.CheckedChanged
        BackgroundCheckboxControl(13)
    End Sub

    Private Sub CheckBoxBackgroundsMiddleman_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsMiddleman.CheckedChanged
        BackgroundCheckboxControl(14)
    End Sub

    Private Sub CheckBoxBackgroundsGuard_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsGuard.CheckedChanged
        BackgroundCheckboxControl(15)
    End Sub

    Private Sub CheckBoxBackgroundsEnchantmentspecialist_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsEnchantmentspecialist.CheckedChanged
        BackgroundCheckboxControl(16)
    End Sub

    Private Sub CheckBoxBackgroundsCleanser_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsCleanser.CheckedChanged
        BackgroundCheckboxControl(17)
    End Sub

    Private Sub CheckBoxBackgroundsTradesman_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsTradesman.CheckedChanged
        BackgroundCheckboxControl(18)
    End Sub

    Private Sub CheckBoxBackgroundsWanderer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsWanderer.CheckedChanged
        BackgroundCheckboxControl(19)
    End Sub

    Private Sub CheckBoxBackgroundsUrchin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsUrchin.CheckedChanged
        BackgroundCheckboxControl(20)
    End Sub

    Private Sub CheckBoxBackgroundsWeaponsarmorknowledge_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsWeaponsarmorknowledge.CheckedChanged
        BackgroundCheckboxControl(21)
    End Sub

    Private Sub CheckBoxBackgroundsCourier_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackgroundsCourier.CheckedChanged
        BackgroundCheckboxControl(22)
    End Sub

    Private Sub ButtonBackgroundsClass_Click(sender As Object, e As EventArgs) Handles ButtonBackgroundsClass.Click
        If BackgroundCount() Then
            PanelClass.BringToFront()
            PanelBackgrounds.Enabled = False
            PanelClass.Enabled = True
        Else
            MsgBox("Please select 2 Backgrounds!!")
        End If
    End Sub
#End Region

    Private Sub ButtonClassNext_Click(sender As Object, e As EventArgs) Handles ButtonClassNext.Click
        If RadioButtonClassCleric.Checked Then
            PanelCleric.BringToFront()
            PanelCleric.Enabled = True
            PanelClass.Enabled = False
        ElseIf RadioButtonClassNoble.Checked Then
            PanelNoble.BringToFront()
            PanelNoble.Enabled = True
            PanelClass.Enabled = False
        ElseIf RadioButtonClassRanger.Checked Then
            PanelRanger.BringToFront()
            PanelRanger.Enabled = True
            PanelClass.Enabled = False
            DexBow = 1
            TalentLableChange()
        ElseIf RadioButtonClassVoidKnight.Checked Then
            PanelVoidknight.BringToFront()
            PanelVoidknight.Enabled = True
            PanelClass.Enabled = False
        ElseIf RadioButtonClassWarrior.Checked Then
            PanelWarrior.BringToFront()
            PanelWarrior.Enabled = True
            PanelClass.Enabled = False
        ElseIf RadioButtonClassWizard.Checked Then
            PanelWizard.BringToFront()
            PanelWizard.Enabled = True
            PanelClass.Enabled = False
        ElseIf RadioButtonClassRogue.Checked Then
            PanelRogue.BringToFront()
            PanelRogue.Enabled = True
            PanelClass.Enabled = False
        Else
            MsgBox("You must select a class befor moving on!!")
        End If
    End Sub

#Region "Class info form"

    Private Sub LabelClassWarrior_Click(sender As Object, e As EventArgs) Handles LabelClassWarrior.Click
        ConstructInfoForm("ClassWarrior")
    End Sub

    Private Sub LabelClassRanger_Click(sender As Object, e As EventArgs) Handles LabelClassRanger.Click
        ConstructInfoForm("ClassRanger")
    End Sub

    Private Sub LabelClassRogue_Click(sender As Object, e As EventArgs) Handles LabelClassRogue.Click
        ConstructInfoForm("ClassRogue")
    End Sub

    Private Sub LabelClassNoble_Click(sender As Object, e As EventArgs) Handles LabelClassNoble.Click
        ConstructInfoForm("ClassNoble")
    End Sub

    Private Sub LabelClassWizard_Click(sender As Object, e As EventArgs) Handles LabelClassWizard.Click
        ConstructInfoForm("ClassWizard")
    End Sub

    Private Sub LabelClassVoidknight_Click(sender As Object, e As EventArgs) Handles LabelClassVoidknight.Click
        ConstructInfoForm("ClassVoidKnight")
    End Sub

    Private Sub LabelClassCleric_Click(sender As Object, e As EventArgs) Handles LabelClassCleric.Click
        ConstructInfoForm("ClassCleric")
    End Sub
#End Region

    Private Sub ButtonWizardTalents_Click(sender As Object, e As EventArgs) Handles ButtonWizardTalents.Click
        If RadioButtonWizardHydromancy.Checked And RadioButtonWizardKinesiomancy.Checked Then
            PanelKinesiohydro.BringToFront()
            PanelKinesiohydro.Enabled = True
            PanelWizard.Enabled = False
        ElseIf RadioButtonWizardHydromancy.Checked And RadioButtonWizardNecromancy.Checked Then
            PanelNecrohydro.BringToFront()
            PanelNecrohydro.Enabled = True
            PanelWizard.Enabled = False
        ElseIf RadioButtonWizardHydromancy.Checked And RadioButtonWizardNeuromancy.Checked Then
            PanelNeurohydro.BringToFront()
            PanelNeurohydro.Enabled = True
            PanelWizard.Enabled = False
        ElseIf RadioButtonWizardPyromancy.Checked And RadioButtonWizardKinesiomancy.Checked Then
            PanelKinesiopyro.BringToFront()
            PanelKinesiopyro.Enabled = True
            PanelWizard.Enabled = False
        ElseIf RadioButtonWizardPyromancy.Checked And RadioButtonWizardNecromancy.Checked Then
            PanelNecropyro.BringToFront()
            PanelNecropyro.Enabled = True
            PanelWizard.Enabled = False
        ElseIf RadioButtonWizardPyromancy.Checked And RadioButtonWizardNeuromancy.Checked Then
            PanelNeuropyro.BringToFront()
            PanelNeuropyro.Enabled = True
            PanelWizard.Enabled = False
        ElseIf RadioButtonWizardKairomancy.Checked And RadioButtonWizardKinesiomancy.Checked Then
            PanelKinesiokairo.BringToFront()
            PanelKinesiokairo.Enabled = True
            PanelWizard.Enabled = False
        ElseIf RadioButtonWizardKairomancy.Checked And RadioButtonWizardNecromancy.Checked Then
            PanelNecrokairo.BringToFront()
            PanelNecrokairo.Enabled = True
            PanelWizard.Enabled = False
        ElseIf RadioButtonWizardKairomancy.Checked And RadioButtonWizardNeuromancy.Checked Then
            PanelNeurokairo.BringToFront()
            PanelNeurokairo.Enabled = True
            PanelWizard.Enabled = False
        Else
            MsgBox("You must select an Elemental and Manifold Magic to continue!!")

        End If

    End Sub

#Region "Talent To Prev"
    Private Sub ButtonWizardClass_Click(sender As Object, e As EventArgs) Handles ButtonWizardClass.Click
        PanelClass.BringToFront()
        PanelClass.Enabled = True
        PanelWizard.Enabled = False
        RadioButtonWizardHydromancy.Checked = False
        RadioButtonWizardKairomancy.Checked = False
        RadioButtonWizardPyromancy.Checked = False
        RadioButtonWizardKinesiomancy.Checked = False
        RadioButtonWizardNecromancy.Checked = False
        RadioButtonWizardNeuromancy.Checked = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonKinesiokairoWizard_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoWizard.Click
        PanelWizard.BringToFront()
        PanelWizard.Enabled = True
        PanelKinesiokairo.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonKinesiopyroWizard_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroWizard.Click
        PanelWizard.BringToFront()
        PanelWizard.Enabled = True
        PanelKinesiopyro.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonKinesiohydroWizard_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroWizard.Click
        PanelWizard.BringToFront()
        PanelWizard.Enabled = True
        PanelKinesiohydro.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonNecrokairoWizard_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoWizard.Click
        PanelWizard.BringToFront()
        PanelWizard.Enabled = True
        PanelNecrokairo.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonNecropyroWizard_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroWizard.Click
        PanelWizard.BringToFront()
        PanelWizard.Enabled = True
        PanelNecropyro.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonNecrohydroWizard_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroWizard.Click
        PanelWizard.BringToFront()
        PanelWizard.Enabled = True
        PanelNecrohydro.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonNeurokairoWizard_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoWizard.Click
        PanelWizard.BringToFront()
        PanelWizard.Enabled = True
        PanelNeurokairo.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonNeuropyroClass_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroClass.Click
        PanelWizard.BringToFront()
        PanelWizard.Enabled = True
        PanelNeuropyro.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonNeuroHydroWizard_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroWizard.Click
        PanelWizard.BringToFront()
        PanelWizard.Enabled = True
        PanelNeurohydro.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonVoidknightClass_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightClass.Click
        PanelClass.BringToFront()
        PanelClass.Enabled = True
        PanelVoidknight.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonClericClass_Click(sender As Object, e As EventArgs) Handles ButtonClericClass.Click
        PanelClass.BringToFront()
        PanelClass.Enabled = True
        PanelCleric.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonNobleClass_Click(sender As Object, e As EventArgs) Handles ButtonNobleClass.Click
        PanelClass.BringToFront()
        PanelClass.Enabled = True
        PanelNoble.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonRogueClass_Click(sender As Object, e As EventArgs) Handles ButtonRogueClass.Click
        PanelClass.BringToFront()
        PanelClass.Enabled = True
        PanelRogue.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonRangerClass_Click(sender As Object, e As EventArgs) Handles ButtonRangerClass.Click
        PanelClass.BringToFront()
        PanelClass.Enabled = True
        PanelRanger.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonWarriorClass_Click(sender As Object, e As EventArgs) Handles ButtonWarriorClass.Click
        PanelClass.BringToFront()
        PanelClass.Enabled = True
        PanelWarrior.Enabled = False
        ClearTalentInfo()
    End Sub

    Private Sub ButtonClassBackgrounds_Click(sender As Object, e As EventArgs) Handles ButtonClassBackgrounds.Click
        PanelBackgrounds.BringToFront()
        PanelBackgrounds.Enabled = True
        PanelClass.Enabled = False
    End Sub
#End Region

#Region "NobleTalents"
    Private Sub ButtonNobleCharismaPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleCharismaPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Charisma = Charisma + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleImperiusPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleImperiusPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Imperius = Imperius + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleEngineeringPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleEngineeringPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        ElseIf Engineering = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        Else
            Engineering = Engineering + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleLeadershipPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleLeadershipPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        ElseIf Leadership = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        Else
            Leadership = Leadership + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleLanguagesPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleLanguagesPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        ElseIf Languages = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        Else
            Languages = Languages + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNobleSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonNobleHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleCharismaMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleCharismaMinus.Click
        If Charisma > 0 Then
            Charisma = Charisma - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleImperiusMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleImperiusMinus.Click
        If Imperius > 0 Then
            Imperius = Imperius - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleEngineeringMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleEngineeringMinus.Click
        If Engineering > 0 Then
            Engineering = Engineering - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleLeadershipMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleLeadershipMinus.Click
        If Leadership > 0 Then
            Leadership = Leadership - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleLanguagesMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleLanguagesMinus.Click
        If Languages > 0 Then
            Languages = Languages - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNobleSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNobleHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonNobleHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub
#End Region

#Region "VoidknightTalents"
    Private Sub ButtonVoidknightVoidPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightVoidPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Void = Void + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightJumpPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightJumpPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Jump = Jump + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightShroudofprotectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightShroudofprotectionPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            ShroudofProtection = ShroudofProtection + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightLifelinkPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightLifelinkPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Lifelink = Lifelink + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightSilencePlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightSilencePlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Silence = Silence + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonVoidknightSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightScrollwritingPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightScrollwritingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And ScrollWriting = 2) Or (XP < 10 And ScrollWriting = 1) Or (XP < 15 And ScrollWriting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If ScrollWriting = 1 Then
                    XP = XP - 10
                ElseIf ScrollWriting > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                ScrollWritingR2 = ScrollWritingR2 + 1
                If ScrollWriting < 2 Then
                    ScrollWriting = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                ScrollWriting = ScrollWriting + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightEnchantingPlus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightEnchantingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Enchanting = 1) Or (XP < 15 And Enchanting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Enchanting = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                EnchantingR2 = EnchantingR2 + 1
                Enchanting = 0
            End If
        ElseIf Enchanting = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf EnchantingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Enchanting = Enchanting + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightVoidMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightVoidMinus.Click
        If Void > 0 Then
            Void = Void - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightJumpMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightJumpMinus.Click
        If Jump > 0 Then
            Jump = Jump - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightShroudofprotectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightShroudofprotectionMinus.Click
        If ShroudofProtection > 0 Then
            ShroudofProtection = ShroudofProtection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightLifelinkMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightLifelinkMinus.Click
        If Lifelink > 0 Then
            Lifelink = Lifelink - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightSilenceMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightSilenceMinus.Click
        If Silence > 0 Then
            Silence = Silence - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonVoidknightSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightScrollwritingMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightScrollwritingMinus.Click
        If ScrollWritingR2 > 0 Then
            ScrollWritingR2 = ScrollWritingR2 - 1
            XP = XP + 5
        ElseIf ScrollWriting > 0 Then
            ScrollWriting = ScrollWriting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonVoidknightEnchantingMinus_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightEnchantingMinus.Click
        If EnchantingR2 = 1 Then
            EnchantingR2 = EnchantingR2 - 1
            XP = XP + 15
        ElseIf Enchanting = 1 Then
            Enchanting = Enchanting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub


#End Region

#Region "ClericTalents"

    Private Sub ButtonClericHealingPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericHealingPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Healing = Healing + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericPotionsPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericPotionsPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Potions = Potions + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericConvertPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericConvertPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Convert = Convert + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericRemedyPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericRemedyPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Remedy = Remedy + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericBornanewPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericBornanewPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            BornAnew = BornAnew + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonClericSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonClericSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericScrollwritingPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericScrollwritingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And ScrollWriting = 2) Or (XP < 10 And ScrollWriting = 1) Or (XP < 15 And ScrollWriting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If ScrollWriting = 1 Then
                    XP = XP - 10
                ElseIf ScrollWriting > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                ScrollWritingR2 = ScrollWritingR2 + 1
                If ScrollWriting < 2 Then
                    ScrollWriting = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                ScrollWriting = ScrollWriting + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericEnchantingPlus_Click(sender As Object, e As EventArgs) Handles ButtonClericEnchantingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Enchanting = 1) Or (XP < 15 And Enchanting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Enchanting = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                EnchantingR2 = EnchantingR2 + 1
                Enchanting = 0
            End If
        ElseIf Enchanting = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf EnchantingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Enchanting = Enchanting + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericHealingMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericHealingMinus.Click
        If Healing > 0 Then
            Healing = Healing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericPotionsMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericPotionsMinus.Click
        If Potions > 0 Then
            Potions = Potions - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericConvertMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericConvertMinus.Click
        If Convert > 0 Then
            Convert = Convert - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericRemedyMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericRemedyMinus.Click
        If Remedy > 0 Then
            Remedy = Remedy - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericBornanewMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericBornanewMinus.Click
        If BornAnew > 0 Then
            BornAnew = BornAnew - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonClericSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonClericMinusScrollwriting_Click(sender As Object, e As EventArgs) Handles ButtonClericMinusScrollwriting.Click

    End Sub

    Private Sub ButtonClericEnchantingMinus_Click(sender As Object, e As EventArgs) Handles ButtonClericEnchantingMinus.Click
        If EnchantingR2 = 1 Then
            EnchantingR2 = EnchantingR2 - 1
            XP = XP + 15
        ElseIf Enchanting = 1 Then
            Enchanting = Enchanting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub


#End Region

#Region "RogueTalents"

    Private Sub ButtonRogueVanishPlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueVanishPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Vanish = Vanish + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueExposePlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueExposePlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Expose = Expose + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueDiseasePlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueDiseasePlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Disease = Disease + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueDisguisePlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueDisguisePlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Disguise = Disguise + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueBlindPlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueBlindPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Blind = Blind + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonRogueSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonRogueHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueVanishMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueVanishMinus.Click
        If Vanish > 0 Then
            Vanish = Vanish - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueExposeMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueExposeMinus.Click
        If Expose > 0 Then
            Expose = Expose - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueDiseaseMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueDiseaseMinus.Click
        If Disease > 0 Then
            Disease = Disease - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueDisguiseMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueDisguiseMinus.Click
        If Disguise > 0 Then
            Disguise = Disguise - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueBlindMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueBlindMinus.Click
        If Blind > 0 Then
            Blind = Blind - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueWeaponDexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueWeaponDexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonRogueSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRogueHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonRogueHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

#End Region

#Region "RangerTalents"

    Private Sub ButtonRangerDeadeyePlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerDeadeyePlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Deadeye = Deadeye + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerTrapsPlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerTrapsPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Traps = Traps + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerIaijutsuPlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerIaijutsuPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Iaijutsu = Iaijutsu + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerHidePlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerHidePlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerTrackingPlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerTrackingPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Tracking = Tracking + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonRangerSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonRangerHealthPlus.Click

    End Sub

    Private Sub ButtonRangerDeadeyeMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerDeadeyeMinus.Click
        If Deadeye > 0 Then
            Deadeye = Deadeye - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerTrapsMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerTrapsMinus.Click
        If Traps > 0 Then
            Traps = Traps - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerIaijutsuMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerIaijutsuMinus.Click
        If Iaijutsu > 0 Then
            Iaijutsu = Iaijutsu - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerHideMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerHideMinus.Click
        If AHide > 0 Then
            AHide = AHide - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerTrackingMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerTrackingMinus.Click
        If Tracking > 0 Then
            Tracking = Tracking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonRangerSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonRangerHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonRangerHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

#End Region

#Region "WarriorTalents"

    Private Sub ButtonWarriorCrushingblowPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorCrushingblowPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            CrushingBlow = CrushingBlow + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorLikearockPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorLikearockPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            LikeARock = LikeARock + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorGimpPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorGimpPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Gimp = Gimp + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorKnockdownPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorKnockdownPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            KnockDown = KnockDown + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorDisarmPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorDisarmPlus.Click
        If XP < 5 Then
            MsgBox("You do not have enough XP!!")
        Else
            Disarm = Disarm + 1
            XP = XP - 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonWarriorSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorCrushingblowMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorCrushingblowMinus.Click
        If CrushingBlow > 0 Then
            CrushingBlow = CrushingBlow - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorLikearockMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorLikearockMinus.Click
        If LikeARock > 0 Then
            LikeARock = LikeARock - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorGimpMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorGimpMinus.Click
        If Gimp > 0 Then
            Gimp = Gimp - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorKnockdownMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorKnockdownMinus.Click
        If KnockDown > 0 Then
            KnockDown = KnockDown - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorDisarmMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorDisarmMinus.Click
        If Disarm > 0 Then
            Disarm = Disarm - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonWarriorSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonWarriorHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonWarriorHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

#End Region

#Region "KinesioKairoTalents"
    Private Sub ButtonKinesiokairoSurgePlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoSurgePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Surge >= 2) Or (XP < 10 And Surge = 1) Or (XP < 15 And Surge = 0 And LightningBolt <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Surge = 0 And LightningBolt = 0 Then
                    XP = XP - 10
                ElseIf Surge = 1 Then
                    XP = XP - 10
                ElseIf Surge > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SurgeR2 = SurgeR2 + 1
                If Surge < 2 Then
                    Surge = 2
                End If
            End If
        Else
            If (Surge + LightningBolt = 0) Or XP >= 5 Then
                If (Surge + LightningBolt) <> 0 Then
                    XP = XP - 5
                End If
                Surge = Surge + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoLightningboltPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoLightningboltPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And LightningBolt >= 2) Or (XP < 10 And LightningBolt = 1) Or (XP < 15 And LightningBolt = 0 And Surge <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Surge = 0 And LightningBolt = 0 Then
                    XP = XP - 10
                ElseIf LightningBolt = 1 Then
                    XP = XP - 10
                ElseIf LightningBolt > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                LightningBoltR2 = LightningBoltR2 + 1
                If LightningBolt < 2 Then
                    LightningBolt = 2
                End If
            End If
        Else
            If (Surge + LightningBolt = 0) Or XP >= 5 Then
                If (Surge + LightningBolt) <> 0 Then
                    XP = XP - 5
                End If
                LightningBolt = LightningBolt + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonKinesiokairoSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoScrollwritingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoScrollwritingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And ScrollWriting = 2) Or (XP < 10 And ScrollWriting = 1) Or (XP < 15 And ScrollWriting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If ScrollWriting = 1 Then
                    XP = XP - 10
                ElseIf ScrollWriting > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                ScrollWritingR2 = ScrollWritingR2 + 1
                If ScrollWriting < 2 Then
                    ScrollWriting = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                ScrollWriting = ScrollWriting + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoEnchantingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoEnchantingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Enchanting = 1) Or (XP < 15 And Enchanting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Enchanting = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                EnchantingR2 = EnchantingR2 + 1
                Enchanting = 0
            End If
        ElseIf Enchanting = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf EnchantingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Enchanting = Enchanting + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoSurgeMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoSurgeMinus.Click
        If SurgeR2 > 0 Then
            SurgeR2 = SurgeR2 - 1
            XP = XP + 5
        ElseIf (Surge + LightningBolt = 1) Then
            Surge = Surge - 1
        ElseIf Surge > 0 Then
            Surge = Surge - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoLightningboltMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoLightningboltMinus.Click
        If LightningBoltR2 > 0 Then
            LightningBoltR2 = LightningBoltR2 - 1
            XP = XP + 5
        ElseIf (Surge + LightningBolt = 1) Then
            LightningBolt = LightningBolt - 1
        ElseIf LightningBolt > 0 Then
            LightningBolt = LightningBolt - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoWeapondexterity_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoWeapondexterity.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonKinesiokairoSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoScrollwritingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoScrollwritingMinus.Click
        If ScrollWritingR2 > 0 Then
            ScrollWritingR2 = ScrollWritingR2 - 1
            XP = XP + 5
        ElseIf ScrollWriting > 0 Then
            ScrollWriting = ScrollWriting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiokairoEnchantingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoEnchantingMinus.Click
        If EnchantingR2 = 1 Then
            EnchantingR2 = EnchantingR2 - 1
            XP = XP + 15
        ElseIf Enchanting = 1 Then
            Enchanting = Enchanting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub



#End Region

#Region "KinesioPyroTalents"
    Private Sub ButtonKinesiopyroSurgePlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroSurgePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Surge >= 2) Or (XP < 10 And Surge = 1) Or (XP < 15 And Surge = 0 And Fireball <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Surge = 0 And Fireball = 0 Then
                    XP = XP - 10
                ElseIf Surge = 1 Then
                    XP = XP - 10
                ElseIf Surge > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SurgeR2 = SurgeR2 + 1
                If Surge < 2 Then
                    Surge = 2
                End If
            End If
        Else
            If (Surge + Fireball = 0) Or XP >= 5 Then
                If (Surge + Fireball) <> 0 Then
                    XP = XP - 5
                End If
                Surge = Surge + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroFireballPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroFireballPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Fireball >= 2) Or (XP < 10 And Fireball = 1) Or (XP < 15 And Fireball = 0 And Surge <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Surge = 0 And Fireball = 0 Then
                    XP = XP - 10
                ElseIf Fireball = 1 Then
                    XP = XP - 10
                ElseIf Fireball > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                FireballR2 = FireballR2 + 1
                If Fireball < 2 Then
                    Fireball = 2
                End If
            End If
        Else
            If (Surge + Fireball = 0) Or XP >= 5 Then
                If (Surge + Fireball) <> 0 Then
                    XP = XP - 5
                End If
                Fireball = Fireball + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonKinesiopyroSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroScrollwritingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroScrollwritingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And ScrollWriting = 2) Or (XP < 10 And ScrollWriting = 1) Or (XP < 15 And ScrollWriting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If ScrollWriting = 1 Then
                    XP = XP - 10
                ElseIf ScrollWriting > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                ScrollWritingR2 = ScrollWritingR2 + 1
                If ScrollWriting < 2 Then
                    ScrollWriting = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                ScrollWriting = ScrollWriting + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroEnchantingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroEnchantingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Enchanting = 1) Or (XP < 15 And Enchanting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Enchanting = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                EnchantingR2 = EnchantingR2 + 1
                Enchanting = 0
            End If
        ElseIf Enchanting = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf EnchantingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Enchanting = Enchanting + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroSurgeMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroSurgeMinus.Click
        If SurgeR2 > 0 Then
            SurgeR2 = SurgeR2 - 1
            XP = XP + 5
        ElseIf (Surge + Fireball = 1) Then
            Surge = Surge - 1
        ElseIf Surge > 0 Then
            Surge = Surge - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroFireballMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroFireballMinus.Click
        If FireballR2 > 0 Then
            FireballR2 = FireballR2 - 1
            XP = XP + 5
        ElseIf (Surge + Fireball = 1) Then
            Fireball = Fireball - 1
        ElseIf Fireball > 0 Then
            Fireball = Fireball - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroForestyMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroForestyMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonKinesiopyroSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroScrollwritingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroScrollwritingMinus.Click
        If ScrollWritingR2 > 0 Then
            ScrollWritingR2 = ScrollWritingR2 - 1
            XP = XP + 5
        ElseIf ScrollWriting > 0 Then
            ScrollWriting = ScrollWriting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiopyroEnchantingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroEnchantingMinus.Click
        If EnchantingR2 = 1 Then
            EnchantingR2 = EnchantingR2 - 1
            XP = XP + 15
        ElseIf Enchanting = 1 Then
            Enchanting = Enchanting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

#End Region

#Region "KinesioHydroTalents"
    Private Sub ButtonKinesiohydroSurgePlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroSurgePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Surge >= 2) Or (XP < 10 And Surge = 1) Or (XP < 15 And Surge = 0 And Snowball <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Surge = 0 And Snowball = 0 Then
                    XP = XP - 10
                ElseIf Surge = 1 Then
                    XP = XP - 10
                ElseIf Surge > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SurgeR2 = SurgeR2 + 1
                If Surge < 2 Then
                    Surge = 2
                End If
            End If
        Else
            If (Surge + Snowball = 0) Or XP >= 5 Then
                If (Surge + Snowball) <> 0 Then
                    XP = XP - 5
                End If
                Surge = Surge + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroSnowballPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroSnowballPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Snowball >= 2) Or (XP < 10 And Snowball = 1) Or (XP < 15 And Snowball = 0 And Surge <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Surge = 0 And Snowball = 0 Then
                    XP = XP - 10
                ElseIf Snowball = 1 Then
                    XP = XP - 10
                ElseIf Snowball > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SnowballR2 = SnowballR2 + 1
                If Snowball < 2 Then
                    Snowball = 2
                End If
            End If
        Else
            If (Surge + Snowball = 0) Or XP >= 5 Then
                If (Surge + Snowball) <> 0 Then
                    XP = XP - 5
                End If
                Snowball = Snowball + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonKinesiohydroSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroScrollwritingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroScrollwritingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And ScrollWriting = 2) Or (XP < 10 And ScrollWriting = 1) Or (XP < 15 And ScrollWriting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If ScrollWriting = 1 Then
                    XP = XP - 10
                ElseIf ScrollWriting > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                ScrollWritingR2 = ScrollWritingR2 + 1
                If ScrollWriting < 2 Then
                    ScrollWriting = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                ScrollWriting = ScrollWriting + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroEnchantingPlus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroEnchantingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Enchanting = 1) Or (XP < 15 And Enchanting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Enchanting = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                EnchantingR2 = EnchantingR2 + 1
                Enchanting = 0
            End If
        ElseIf Enchanting = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf EnchantingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Enchanting = Enchanting + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroSurgeMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroSurgeMinus.Click
        If SurgeR2 > 0 Then
            SurgeR2 = SurgeR2 - 1
            XP = XP + 5
        ElseIf (Surge + Snowball = 1) Then
            Surge = Surge - 1
        ElseIf Surge > 0 Then
            Surge = Surge - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroSnowballMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroSnowballMinus.Click
        If SnowballR2 > 0 Then
            SnowballR2 = SnowballR2 - 1
            XP = XP + 5
        ElseIf (Surge + Snowball = 1) Then
            Snowball = Snowball - 1
        ElseIf Snowball > 0 Then
            Snowball = Snowball - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonKinesiohydroSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroScrollwritingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroScrollwritingMinus.Click
        If ScrollWritingR2 > 0 Then
            ScrollWritingR2 = ScrollWritingR2 - 1
            XP = XP + 5
        ElseIf ScrollWriting > 0 Then
            ScrollWriting = ScrollWriting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonKinesiohydroEnchantingMinus_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroEnchantingMinus.Click
        If EnchantingR2 = 1 Then
            EnchantingR2 = EnchantingR2 - 1
            XP = XP + 15
        ElseIf Enchanting = 1 Then
            Enchanting = Enchanting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub


#End Region

#Region "NecroKairoTalents"
    Private Sub ButtonNecrokairoLifesyphonPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoLifesyphonPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And LifeSyphon >= 2) Or (XP < 10 And LifeSyphon = 1) Or (XP < 15 And LifeSyphon = 0 And LightningBolt <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If LifeSyphon = 0 And LightningBolt = 0 Then
                    XP = XP - 10
                ElseIf LifeSyphon = 1 Then
                    XP = XP - 10
                ElseIf LifeSyphon > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                LifeSyphonR2 = LifeSyphonR2 + 1
                If LifeSyphon < 2 Then
                    LifeSyphon = 2
                End If
            End If
        Else
            If (LifeSyphon + LightningBolt = 0) Or XP >= 5 Then
                If (LifeSyphon + LightningBolt) <> 0 Then
                    XP = XP - 5
                End If
                LifeSyphon = LifeSyphon + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoLightningboltPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoLightningboltPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And LightningBolt >= 2) Or (XP < 10 And LightningBolt = 1) Or (XP < 15 And LightningBolt = 0 And LifeSyphon <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If LifeSyphon = 0 And LightningBolt = 0 Then
                    XP = XP - 10
                ElseIf LightningBolt = 1 Then
                    XP = XP - 10
                ElseIf LightningBolt > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                LightningBolt = LightningBolt + 1
                If LightningBolt < 2 Then
                    LightningBolt = 2
                End If
            End If
        Else
            If (LifeSyphon + LightningBolt = 0) Or XP >= 5 Then
                If (LifeSyphon + LightningBolt) <> 0 Then
                    XP = XP - 5
                End If
                LightningBolt = LightningBolt + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNecrokairoSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoScrollwritingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoScrollwritingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And ScrollWriting = 2) Or (XP < 10 And ScrollWriting = 1) Or (XP < 15 And ScrollWriting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If ScrollWriting = 1 Then
                    XP = XP - 10
                ElseIf ScrollWriting > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                ScrollWritingR2 = ScrollWritingR2 + 1
                If ScrollWriting < 2 Then
                    ScrollWriting = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                ScrollWriting = ScrollWriting + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoEnchantingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoEnchantingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Enchanting = 1) Or (XP < 15 And Enchanting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Enchanting = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                EnchantingR2 = EnchantingR2 + 1
                Enchanting = 0
            End If
        ElseIf Enchanting = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf EnchantingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Enchanting = Enchanting + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoLifesyphoneMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoLifesyphoneMinus.Click
        If LifeSyphonR2 > 0 Then
            LifeSyphonR2 = LifeSyphonR2 - 1
            XP = XP + 5
        ElseIf (LifeSyphon + LightningBolt = 1) Then
            LifeSyphon = LifeSyphon - 1
        ElseIf LifeSyphon > 0 Then
            LifeSyphon = LifeSyphon - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoLightningboltMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoLightningboltMinus.Click
        If LightningBoltR2 > 0 Then
            LightningBoltR2 = LightningBoltR2 - 1
            XP = XP + 5
        ElseIf (LifeSyphon + LightningBolt = 1) Then
            LightningBolt = LightningBolt - 1
        ElseIf LightningBolt > 0 Then
            LightningBolt = LightningBolt - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNecrokairoSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoScrollwritingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoScrollwritingMinus.Click
        If ScrollWritingR2 > 0 Then
            ScrollWritingR2 = ScrollWritingR2 - 1
            XP = XP + 5
        ElseIf ScrollWriting > 0 Then
            ScrollWriting = ScrollWriting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrokairoEnchantingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoEnchantingMinus.Click
        If EnchantingR2 = 1 Then
            EnchantingR2 = EnchantingR2 - 1
            XP = XP + 15
        ElseIf Enchanting = 1 Then
            Enchanting = Enchanting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub


#End Region

#Region "NecroPyroTalents"
    Private Sub ButtonNecropyroLifesyphonPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroLifesyphonPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And LifeSyphon >= 2) Or (XP < 10 And LifeSyphon = 1) Or (XP < 15 And LifeSyphon = 0 And Fireball <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If LifeSyphon = 0 And Fireball = 0 Then
                    XP = XP - 10
                ElseIf LifeSyphon = 1 Then
                    XP = XP - 10
                ElseIf LifeSyphon > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                LifeSyphonR2 = LifeSyphonR2 + 1
                If LifeSyphon < 2 Then
                    LifeSyphon = 2
                End If
            End If
        Else
            If (LifeSyphon + Fireball = 0) Or XP >= 5 Then
                If (LifeSyphon + Fireball) <> 0 Then
                    XP = XP - 5
                End If
                LifeSyphon = LifeSyphon + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroFireballPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroFireballPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Fireball >= 2) Or (XP < 10 And Fireball = 1) Or (XP < 15 And Fireball = 0 And LifeSyphon <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If LifeSyphon = 0 And Fireball = 0 Then
                    XP = XP - 10
                ElseIf Fireball = 1 Then
                    XP = XP - 10
                ElseIf Fireball > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                FireballR2 = FireballR2 + 1
                If Fireball < 2 Then
                    Fireball = 2
                End If
            End If
        Else
            If (LifeSyphon + Fireball = 0) Or XP >= 5 Then
                If (LifeSyphon + Fireball) <> 0 Then
                    XP = XP - 5
                End If
                Fireball = Fireball + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNecropyroSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroScrollwritingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroScrollwritingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And ScrollWriting = 2) Or (XP < 10 And ScrollWriting = 1) Or (XP < 15 And ScrollWriting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If ScrollWriting = 1 Then
                    XP = XP - 10
                ElseIf ScrollWriting > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                ScrollWritingR2 = ScrollWritingR2 + 1
                If ScrollWriting < 2 Then
                    ScrollWriting = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                ScrollWriting = ScrollWriting + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroEnchantingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroEnchantingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Enchanting = 1) Or (XP < 15 And Enchanting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Enchanting = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                EnchantingR2 = EnchantingR2 + 1
                Enchanting = 0
            End If
        ElseIf Enchanting = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf EnchantingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Enchanting = Enchanting + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroLifesyphoneMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroLifesyphoneMinus.Click
        If LifeSyphonR2 > 0 Then
            LifeSyphonR2 = LifeSyphonR2 - 1
            XP = XP + 5
        ElseIf (LifeSyphon + Fireball = 1) Then
            LifeSyphon = LifeSyphon - 1
        ElseIf LifeSyphon > 0 Then
            LifeSyphon = LifeSyphon - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroFireballMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroFireballMinus.Click
        If FireballR2 > 0 Then
            FireballR2 = FireballR2 - 1
            XP = XP + 5
        ElseIf (LifeSyphon + Fireball = 1) Then
            Fireball = Fireball - 1
        ElseIf Fireball > 0 Then
            Fireball = Fireball - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub Button6NecropyroSenseMinus_Click(sender As Object, e As EventArgs) Handles Button6NecropyroSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroScrollwritingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroScrollwritingMinus.Click
        If ScrollWritingR2 > 0 Then
            ScrollWritingR2 = ScrollWritingR2 - 1
            XP = XP + 5
        ElseIf ScrollWriting > 0 Then
            ScrollWriting = ScrollWriting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecropyroEnchantingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroEnchantingMinus.Click
        If EnchantingR2 = 1 Then
            EnchantingR2 = EnchantingR2 - 1
            XP = XP + 15
        ElseIf Enchanting = 1 Then
            Enchanting = Enchanting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

#End Region

#Region "NecroHydroTalents"
    Private Sub ButtonNecrohydroLifesyphonPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroLifesyphonPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And LifeSyphon >= 2) Or (XP < 10 And LifeSyphon = 1) Or (XP < 15 And LifeSyphon = 0 And Snowball <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If LifeSyphon = 0 And Snowball = 0 Then
                    XP = XP - 10
                ElseIf LifeSyphon = 1 Then
                    XP = XP - 10
                ElseIf LifeSyphon > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                LifeSyphonR2 = LifeSyphonR2 + 1
                If LifeSyphon < 2 Then
                    LifeSyphon = 2
                End If
            End If
        Else
            If (LifeSyphon + Snowball = 0) Or XP >= 5 Then
                If (LifeSyphon + Snowball) <> 0 Then
                    XP = XP - 5
                End If
                LifeSyphon = LifeSyphon + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroSnowballPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroSnowballPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Snowball >= 2) Or (XP < 10 And Snowball = 1) Or (XP < 15 And Snowball = 0 And LifeSyphon <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If LifeSyphon = 0 And Snowball = 0 Then
                    XP = XP - 10
                ElseIf Snowball = 1 Then
                    XP = XP - 10
                ElseIf Snowball > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SnowballR2 = SnowballR2 + 1
                If Snowball < 2 Then
                    Snowball = 2
                End If
            End If
        Else
            If (LifeSyphon + Snowball = 0) Or XP >= 5 Then
                If (LifeSyphon + Snowball) <> 0 Then
                    XP = XP - 5
                End If
                Snowball = Snowball + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNecrohydroSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroScrollwritingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroScrollwritingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And ScrollWriting = 2) Or (XP < 10 And ScrollWriting = 1) Or (XP < 15 And ScrollWriting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If ScrollWriting = 1 Then
                    XP = XP - 10
                ElseIf ScrollWriting > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                ScrollWritingR2 = ScrollWritingR2 + 1
                If ScrollWriting < 2 Then
                    ScrollWriting = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                ScrollWriting = ScrollWriting + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroEnchantingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroEnchantingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Enchanting = 1) Or (XP < 15 And Enchanting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Enchanting = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                EnchantingR2 = EnchantingR2 + 1
                Enchanting = 0
            End If
        ElseIf Enchanting = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf EnchantingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Enchanting = Enchanting + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroLifesyphonMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroLifesyphonMinus.Click
        If LifeSyphonR2 > 0 Then
            LifeSyphonR2 = LifeSyphonR2 - 1
            XP = XP + 5
        ElseIf (LifeSyphon + Snowball = 1) Then
            LifeSyphon = LifeSyphon - 1
        ElseIf LifeSyphon > 0 Then
            LifeSyphon = LifeSyphon - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroSnowballMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroSnowballMinus.Click
        If SnowballR2 > 0 Then
            SnowballR2 = SnowballR2 - 1
            XP = XP + 5
        ElseIf (Migraine + Snowball = 1) Then
            Snowball = Snowball - 1
        ElseIf Snowball > 0 Then
            Snowball = Snowball - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNecrohydroSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroScrollwritingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroScrollwritingMinus.Click
        If ScrollWritingR2 > 0 Then
            ScrollWritingR2 = ScrollWritingR2 - 1
            XP = XP + 5
        ElseIf ScrollWriting > 0 Then
            ScrollWriting = ScrollWriting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNecrohydroEnchantingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroEnchantingMinus.Click
        If EnchantingR2 = 1 Then
            EnchantingR2 = EnchantingR2 - 1
            XP = XP + 15
        ElseIf Enchanting = 1 Then
            Enchanting = Enchanting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub
#End Region

#Region "NeuroKairoTalents"
    Private Sub ButtonNeurokairoMigrainePlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoMigrainePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Migraine >= 2) Or (XP < 10 And Migraine = 1) Or (XP < 15 And Migraine = 0 And LightningBolt <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Migraine = 0 And LightningBolt = 0 Then
                    XP = XP - 10
                ElseIf Migraine = 1 Then
                    XP = XP - 10
                ElseIf Migraine > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                MigraineR2 = MigraineR2 + 1
                If Migraine < 2 Then
                    Migraine = 2
                End If
            End If
        Else
            If (Migraine + LightningBolt = 0) Or XP >= 5 Then
                If (Migraine + LightningBolt) <> 0 Then
                    XP = XP - 5
                End If
                Migraine = Migraine + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoLightningboltPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoLightningboltPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And LightningBolt >= 2) Or (XP < 10 And LightningBolt = 1) Or (XP < 15 And LightningBolt = 0 And Migraine <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Migraine = 0 And LightningBolt = 0 Then
                    XP = XP - 10
                ElseIf LightningBolt = 1 Then
                    XP = XP - 10
                ElseIf LightningBolt > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                LightningBoltR2 = LightningBoltR2 + 1
                If LightningBolt < 2 Then
                    LightningBolt = 2
                End If
            End If
        Else
            If (Migraine + LightningBolt = 0) Or XP >= 5 Then
                If (Migraine + LightningBolt) <> 0 Then
                    XP = XP - 5
                End If
                LightningBolt = LightningBolt + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNeurokairoSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoScrollwritingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoScrollwritingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And ScrollWriting = 2) Or (XP < 10 And ScrollWriting = 1) Or (XP < 15 And ScrollWriting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If ScrollWriting = 1 Then
                    XP = XP - 10
                ElseIf ScrollWriting > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                ScrollWritingR2 = ScrollWritingR2 + 1
                If ScrollWriting < 2 Then
                    ScrollWriting = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                ScrollWriting = ScrollWriting + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoEnchantingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoEnchantingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Enchanting = 1) Or (XP < 15 And Enchanting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Enchanting = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                EnchantingR2 = EnchantingR2 + 1
                Enchanting = 0
            End If
        ElseIf Enchanting = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf EnchantingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Enchanting = Enchanting + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoMigraineMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoMigraineMinus.Click
        If MigraineR2 > 0 Then
            MigraineR2 = MigraineR2 - 1
            XP = XP + 5
        ElseIf (Migraine + LightningBolt = 1) Then
            Migraine = Migraine - 1
        ElseIf Migraine > 0 Then
            Migraine = Migraine - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoLightningboldMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoLightningboldMinus.Click
        If LightningBoltR2 > 0 Then
            LightningBoltR2 = LightningBoltR2 - 1
            XP = XP + 5
        ElseIf (Migraine + LightningBolt = 1) Then
            LightningBolt = LightningBolt - 1
        ElseIf LightningBolt > 0 Then
            LightningBolt = LightningBolt - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNeurokairoSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoScrollwritingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoScrollwritingMinus.Click
        If ScrollWritingR2 > 0 Then
            ScrollWritingR2 = ScrollWritingR2 - 1
            XP = XP + 5
        ElseIf ScrollWriting > 0 Then
            ScrollWriting = ScrollWriting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeurokairoEnchantingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoEnchantingMinus.Click
        If EnchantingR2 = 1 Then
            EnchantingR2 = EnchantingR2 - 1
            XP = XP + 15
        ElseIf Enchanting = 1 Then
            Enchanting = Enchanting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub


#End Region

#Region "NeuroPyroTalents"
    Private Sub ButtonNeuropyroMigrainePlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroMigrainePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Migraine >= 2) Or (XP < 10 And Migraine = 1) Or (XP < 15 And Migraine = 0 And Fireball <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Migraine = 0 And Fireball = 0 Then
                    XP = XP - 10
                ElseIf Migraine = 1 Then
                    XP = XP - 10
                ElseIf Migraine > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                MigraineR2 = MigraineR2 + 1
                If Migraine < 2 Then
                    Migraine = 2
                End If
            End If
        Else
            If (Migraine + Fireball = 0) Or XP >= 5 Then
                If (Migraine + Fireball) <> 0 Then
                    XP = XP - 5
                End If
                Migraine = Migraine + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroFireballPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroFireballPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Fireball >= 2) Or (XP < 10 And Fireball = 1) Or (XP < 15 And Fireball = 0 And Migraine <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Migraine = 0 And Fireball = 0 Then
                    XP = XP - 10
                ElseIf Fireball = 1 Then
                    XP = XP - 10
                ElseIf Fireball > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                FireballR2 = FireballR2 + 1
                If Fireball < 2 Then
                    Fireball = 2
                End If
            End If
        Else
            If (Migraine + Fireball = 0) Or XP >= 5 Then
                If (Migraine + Fireball) <> 0 Then
                    XP = XP - 5
                End If
                Fireball = Fireball + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNeuropyroSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroScrollwritingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroScrollwritingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And ScrollWriting = 2) Or (XP < 10 And ScrollWriting = 1) Or (XP < 15 And ScrollWriting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If ScrollWriting = 1 Then
                    XP = XP - 10
                ElseIf ScrollWriting > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                ScrollWritingR2 = ScrollWritingR2 + 1
                If ScrollWriting < 2 Then
                    ScrollWriting = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                ScrollWriting = ScrollWriting + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroEnchantingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroEnchantingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Enchanting = 1) Or (XP < 15 And Enchanting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Enchanting = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                EnchantingR2 = EnchantingR2 + 1
                Enchanting = 0
            End If
        ElseIf Enchanting = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf EnchantingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Enchanting = Enchanting + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroMigraineMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroMigraineMinus.Click
        If MigraineR2 > 0 Then
            MigraineR2 = MigraineR2 - 1
            XP = XP + 5
        ElseIf (Migraine + Fireball = 1) Then
            Migraine = Migraine - 1
        ElseIf Migraine > 0 Then
            Migraine = Migraine - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroFireballMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroFireballMinus.Click
        If FireballR2 > 0 Then
            FireballR2 = FireballR2 - 1
            XP = XP + 5
        ElseIf (Migraine + Fireball = 1) Then
            Fireball = Fireball - 1
        ElseIf Fireball > 0 Then
            Fireball = Fireball - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNeuropyroSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroScrollwritingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroScrollwritingMinus.Click
        If ScrollWritingR2 > 0 Then
            ScrollWritingR2 = ScrollWritingR2 - 1
            XP = XP + 5
        ElseIf ScrollWriting > 0 Then
            ScrollWriting = ScrollWriting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuropyroEnchantingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroEnchantingMinus.Click
        If EnchantingR2 = 1 Then
            EnchantingR2 = EnchantingR2 - 1
            XP = XP + 15
        ElseIf Enchanting = 1 Then
            Enchanting = Enchanting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub


#End Region

#Region "NeuroHydroTalents"
    Private Sub ButtonNeuroHydroMigrainePlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroMigrainePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Migraine >= 2) Or (XP < 10 And Migraine = 1) Or (XP < 15 And Migraine = 0 And Snowball <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Migraine = 0 And Snowball = 0 Then
                    XP = XP - 10
                ElseIf Migraine = 1 Then
                    XP = XP - 10
                ElseIf Migraine > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                MigraineR2 = MigraineR2 + 1
                If Migraine < 2 Then
                    Migraine = 2
                End If
            End If
        Else
            If (Migraine + Snowball = 0) Or XP >= 5 Then
                If (Migraine + Snowball) <> 0 Then
                    XP = XP - 5
                End If
                Migraine = Migraine + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroSnowballPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroSnowballPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Snowball >= 2) Or (XP < 10 And Snowball = 1) Or (XP < 15 And Snowball = 0 And Migraine <> 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Migraine = 0 And Snowball = 0 Then
                    XP = XP - 10
                ElseIf Snowball = 1 Then
                    XP = XP - 10
                ElseIf Snowball > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SnowballR2 = SnowballR2 + 1
                If Snowball < 2 Then
                    Snowball = 2
                End If
            End If
        Else
            If (Migraine + Snowball = 0) Or XP >= 5 Then
                If (Migraine + Snowball) <> 0 Then
                    XP = XP - 5
                End If
                Snowball = Snowball + 1
            Else
                MsgBox("You do not have enough XP!!")
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroForestryPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroForestryPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Forestry = 1) Or (XP < 15 And Forestry = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Forestry = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ForestryR2 = ForestryR2 + 1
                Forestry = 0
            End If
        ElseIf Forestry = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ForestryR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Forestry = Forestry + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroLeatherworkingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroLeatherworkingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Leatherworking = 1) Or (XP < 15 And Leatherworking = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Leatherworking = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                LeatherworkingR2 = LeatherworkingR2 + 1
                Leatherworking = 0
            End If
        ElseIf Leatherworking = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf LeatherworkingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Leatherworking = Leatherworking + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroProwessPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroProwessPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Prowess = 1) Or (XP < 15 And Prowess = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Prowess = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                ProwessR2 = ProwessR2 + 1
                Prowess = 0
            End If
        ElseIf Prowess = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf ProwessR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Prowess = Prowess + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroSmithingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroSmithingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Smithing = 1) Or (XP < 15 And Smithing = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Smithing = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                SmithingR2 = SmithingR2 + 1
                Smithing = 0
            End If
        ElseIf Smithing = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf SmithingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Smithing = Smithing + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroWeapondexterityPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroWeapondexterityPlus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNeuroHydroSensePlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroSensePlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Sense = 2) Or (XP < 10 And Sense = 1) Or (XP < 15 And Sense = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Sense = 1 Then
                    XP = XP - 10
                ElseIf Sense > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                SenseR2 = SenseR2 + 1
                If Sense < 2 Then
                    Sense = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Sense = Sense + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroDetectionPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroDetectionPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And Detection = 2) Or (XP < 10 And Detection = 1) Or (XP < 15 And Detection = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Detection = 1 Then
                    XP = XP - 10
                ElseIf Detection > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                DetectionR2 = DetectionR2 + 1
                If Detection < 2 Then
                    Detection = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Detection = Detection + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroHealthPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroHealthPlus.Click
        If XP < (HP + 2) Then
            MsgBox("You do not have enough XP!!")
        Else
            HP = HP + 1
            XP = XP - HP - 1
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroScrollwritingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroScrollwritingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 5 And ScrollWriting = 2) Or (XP < 10 And ScrollWriting = 1) Or (XP < 15 And ScrollWriting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If ScrollWriting = 1 Then
                    XP = XP - 10
                ElseIf ScrollWriting > 1 Then
                    XP = XP - 5
                Else
                    XP = XP - 15
                End If
                ScrollWritingR2 = ScrollWritingR2 + 1
                If ScrollWriting < 2 Then
                    ScrollWriting = 2
                End If
            End If
        Else
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                ScrollWriting = ScrollWriting + 1
                XP = XP - 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroEnchantingPlus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroEnchantingPlus.Click
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            If (XP < 10 And Enchanting = 1) Or (XP < 15 And Enchanting = 0) Then
                MsgBox("You do not have enough XP!!")
            Else
                If Enchanting = 1 Then
                    XP = XP - 10
                Else
                    XP = XP - 15
                End If
                EnchantingR2 = EnchantingR2 + 1
                Enchanting = 0
            End If
        ElseIf Enchanting = 1 Then
            MsgBox("This is a Skill. You cannot have multiple of the same rank of skill!!")
        ElseIf EnchantingR2 = 0 Then
            If XP < 5 Then
                MsgBox("You do not have enough XP!!")
            Else
                Enchanting = Enchanting + 1
                XP = XP - 5
            End If
        Else
            MsgBox("This is a Skill. If you have the R2 of a Skill, then you have the rank 1!!")
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroMigraineMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroMigraineMinus.Click
        If MigraineR2 > 0 Then
            MigraineR2 = MigraineR2 - 1
            XP = XP + 5
        ElseIf (Migraine + Snowball = 1) Then
            Migraine = Migraine - 1
        ElseIf Migraine > 0 Then
            Migraine = Migraine - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroSnowballMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroSnowballMinus.Click
        If SnowballR2 > 0 Then
            SnowballR2 = SnowballR2 - 1
            XP = XP + 5
        ElseIf (Migraine + Snowball = 1) Then
            Snowball = Snowball - 1
        ElseIf Snowball > 0 Then
            Snowball = Snowball - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroForestryMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroForestryMinus.Click
        If ForestryR2 = 1 Then
            ForestryR2 = ForestryR2 - 1
            XP = XP + 15
        ElseIf Forestry = 1 Then
            Forestry = Forestry - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroLeatherworkingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroLeatherworkingMinus.Click
        If LeatherworkingR2 = 1 Then
            LeatherworkingR2 = LeatherworkingR2 - 1
            XP = XP + 15
        ElseIf Leatherworking = 1 Then
            Leatherworking = Leatherworking - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroProwessMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroProwessMinus.Click
        If ProwessR2 = 1 Then
            ProwessR2 = ProwessR2 - 1
            XP = XP + 15
        ElseIf Prowess = 1 Then
            Prowess = Prowess - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroSmithingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroSmithingMinus.Click
        If SmithingR2 = 1 Then
            SmithingR2 = SmithingR2 - 1
            XP = XP + 15
        ElseIf Smithing = 1 Then
            Smithing = Smithing - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroWeapondexterityMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroWeapondexterityMinus.Click
        ConsrtuctDexForm()
    End Sub

    Private Sub ButtonNeuroHydroSenseMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroSenseMinus.Click
        If SenseR2 > 0 Then
            SenseR2 = SenseR2 - 1
            XP = XP + 5
        ElseIf Sense > 0 Then
            Sense = Sense - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroDetectionMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroDetectionMinus.Click
        If DetectionR2 > 0 Then
            DetectionR2 = DetectionR2 - 1
            XP = XP + 5
        ElseIf Detection > 0 Then
            Detection = Detection - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroHealthMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroHealthMinus.Click
        If HP > 0 Then
            HP = HP - 1
            XP = XP + HP + 2
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroScrollwritingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroScrollwritingMinus.Click
        If ScrollWritingR2 > 0 Then
            ScrollWritingR2 = ScrollWritingR2 - 1
            XP = XP + 5
        ElseIf ScrollWriting > 0 Then
            ScrollWriting = ScrollWriting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub ButtonNeuroHydroEnchantingMinus_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroEnchantingMinus.Click
        If EnchantingR2 = 1 Then
            EnchantingR2 = EnchantingR2 - 1
            XP = XP + 15
        ElseIf Enchanting = 1 Then
            Enchanting = Enchanting - 1
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

#End Region

#Region "Talent modifyers page navagation"


    Private Sub ButtonKinesiokairoModifier_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelKinesiokairo.Enabled = False
    End Sub

    Private Sub ButtonKinesiopyroModifier_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelKinesiopyro.Enabled = False
    End Sub

    Private Sub ButtonKinesiohydroModifyer_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroModifyer.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelKinesiohydro.Enabled = False
    End Sub

    Private Sub ButtonNecrokairoModifier_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelNecrokairo.Enabled = False
    End Sub

    Private Sub ButtonNecropyroModifier_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelNecropyro.Enabled = False
    End Sub

    Private Sub ButtonNecrohydroModifier_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelNecrohydro.Enabled = False
    End Sub

    Private Sub ButtonNeurokairoModifier_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelNeurokairo.Enabled = False
    End Sub

    Private Sub ButtonNeuropyroModifier_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelNeuropyro.Enabled = False
    End Sub

    Private Sub ButtonNeurohydroModifier_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelNeurohydro.Enabled = False
    End Sub

    Private Sub ButtonVoidknightModifier_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelVoidknight.Enabled = False
    End Sub

    Private Sub ButtonClericModifier_Click(sender As Object, e As EventArgs) Handles ButtonClericModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelCleric.Enabled = False
    End Sub

    Private Sub ButtonNobleModifier_Click(sender As Object, e As EventArgs) Handles ButtonNobleModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelNoble.Enabled = False
    End Sub

    Private Sub ButtonRogueModifier_Click(sender As Object, e As EventArgs) Handles ButtonRogueModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelRogue.Enabled = False
    End Sub

    Private Sub ButtonRangerModifier_Click(sender As Object, e As EventArgs) Handles ButtonRangerModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelRanger.Enabled = False
    End Sub

    Private Sub ButtonWarriorModifier_Click(sender As Object, e As EventArgs) Handles ButtonWarriorModifier.Click
        Me.PanelModifier.Enabled = True
        Me.PanelModifier.BringToFront()
        Me.PanelWarrior.Enabled = False
    End Sub

    Private Sub ButtonModifierClasstype_Click(sender As Object, e As EventArgs) Handles ButtonModifierClasstype.Click
        If RadioButtonWizardHydromancy.Checked = True And RadioButtonWizardNecromancy.Checked = True Then
            Me.PanelNecrohydro.Enabled = True
            Me.PanelNecrohydro.BringToFront()
            Me.PanelModifier.Enabled = False
        ElseIf RadioButtonWizardHydromancy.Checked = True And RadioButtonWizardNeuromancy.Checked = True Then
            Me.PanelNeurohydro.Enabled = True
            Me.PanelNeurohydro.BringToFront()
            Me.PanelModifier.Enabled = False
        ElseIf RadioButtonWizardHydromancy.Checked = True And RadioButtonWizardKinesiomancy.Checked = True Then
            Me.PanelKinesiohydro.Enabled = True
            Me.PanelKinesiohydro.BringToFront()
            Me.PanelModifier.Enabled = False
        ElseIf RadioButtonWizardPyromancy.Checked = True And RadioButtonWizardNecromancy.Checked = True Then
            Me.PanelNecropyro.Enabled = True
            Me.PanelNecropyro.BringToFront()
            Me.PanelModifier.Enabled = False
        ElseIf RadioButtonWizardPyromancy.Checked = True And RadioButtonWizardNeuromancy.Checked = True Then
            Me.PanelNeuropyro.Enabled = True
            Me.PanelNeuropyro.BringToFront()
            Me.PanelModifier.Enabled = False
        ElseIf RadioButtonWizardPyromancy.Checked = True And RadioButtonWizardKinesiomancy.Checked = True Then
            Me.PanelKinesiopyro.Enabled = True
            Me.PanelKinesiopyro.BringToFront()
            Me.PanelModifier.Enabled = False
        ElseIf RadioButtonWizardKairomancy.Checked = True And RadioButtonWizardNecromancy.Checked = True Then
            Me.PanelNecrokairo.Enabled = True
            Me.PanelNecrokairo.BringToFront()
            Me.PanelModifier.Enabled = False
        ElseIf RadioButtonWizardKairomancy.Checked = True And RadioButtonWizardNeuromancy.Checked = True Then
            Me.PanelNeurokairo.Enabled = True
            Me.PanelNeurokairo.BringToFront()
            Me.PanelModifier.Enabled = False
        ElseIf RadioButtonWizardKairomancy.Checked = True And RadioButtonWizardKinesiomancy.Checked = True Then
            Me.PanelKinesiokairo.Enabled = True
            Me.PanelKinesiokairo.BringToFront()
            Me.PanelModifier.Enabled = False
        ElseIf RadioButtonClassCleric.Checked = True Or RadioButtonClassNoble.Checked = True Or RadioButtonClassRanger.Checked = True Or RadioButtonClassRogue.Checked Or RadioButtonClassVoidKnight.Checked = True Or RadioButtonClassWarrior.Checked = True Then
            Me.PanelClass.Enabled = True
            Me.PanelClass.BringToFront()
            Me.PanelModifier.Enabled = False
        End If
    End Sub
#End Region

#Region "Background Info"
    Private Sub ButtonBackgroundsInfo_Click(sender As Object, e As EventArgs) Handles ButtonBackgroundsInfo.Click
        ConstructInfoForm("Backgrounds")
    End Sub
#End Region

#Region "Talent Info"
    Private Sub ButtonKinesiokairoInfo_Click(sender As Object, e As EventArgs) Handles ButtonKinesiokairoInfo.Click
        ConstructInfoForm("AllTalentsKairoKinesio")
    End Sub

    Private Sub ButtonKinesiopyroInfo_Click(sender As Object, e As EventArgs) Handles ButtonKinesiopyroInfo.Click
        ConstructInfoForm("AllTalentsPyroKinesio")
    End Sub

    Private Sub ButtonKinesiohydroInfo_Click(sender As Object, e As EventArgs) Handles ButtonKinesiohydroInfo.Click
        ConstructInfoForm("AllTalentsHydroKinesio")
    End Sub

    Private Sub ButtonnecrokairoinfoInfo_Click(sender As Object, e As EventArgs) Handles ButtonNecrokairoInfo.Click
        ConstructInfoForm("AllTalentsKairoNecro")
    End Sub

    Private Sub ButtonNecropyroInfo_Click(sender As Object, e As EventArgs) Handles ButtonNecropyroInfo.Click
        ConstructInfoForm("AllTalentsPyroNecro")
    End Sub

    Private Sub ButtonNecrohydroInfo_Click(sender As Object, e As EventArgs) Handles ButtonNecrohydroInfo.Click
        ConstructInfoForm("AllTalentsHydroNecro")
    End Sub

    Private Sub ButtonNeurokairoInfo_Click(sender As Object, e As EventArgs) Handles ButtonNeurokairoInfo.Click
        ConstructInfoForm("AllTalentsKairoNeuro")
    End Sub

    Private Sub ButtonNeuropyroInfo_Click(sender As Object, e As EventArgs) Handles ButtonNeuropyroInfo.Click
        ConstructInfoForm("AllTalentsPyroNeuro")
    End Sub

    Private Sub ButtonNeurohydroInfo_Click(sender As Object, e As EventArgs) Handles ButtonNeurohydroInfo.Click
        ConstructInfoForm("AllTalentsPyroNecro")
    End Sub

    Private Sub ButtonClericInfo_Click(sender As Object, e As EventArgs) Handles ButtonClericInfo.Click
        ConstructInfoForm("AllTalentsCleric")
    End Sub

    Private Sub ButtonNobleInfo_Click(sender As Object, e As EventArgs) Handles ButtonNobleInfo.Click
        ConstructInfoForm("AllTalentsNoble")
    End Sub

    Private Sub ButtonRangerInfo_Click(sender As Object, e As EventArgs) Handles ButtonRangerInfo.Click
        ConstructInfoForm("AllTalentsRanger")
    End Sub

    Private Sub ButtonRogueInfo_Click(sender As Object, e As EventArgs) Handles ButtonRogueInfo.Click
        ConstructInfoForm("AllTalentsRogue")
    End Sub

    Private Sub ButtonVoidknightInfo_Click(sender As Object, e As EventArgs) Handles ButtonVoidknightInfo.Click
        ConstructInfoForm("AllTalentsVoidKnight")
    End Sub

    Private Sub ButtonWarriorInfo_Click(sender As Object, e As EventArgs) Handles ButtonWarriorInfo.Click
        ConstructInfoForm("AllTalentsWarrior")
    End Sub

#End Region

#Region "Modifiers info"
    Private Sub ButtonModifierInfo_Click(sender As Object, e As EventArgs) Handles ButtonModifierInfo.Click
        ConstructInfoForm("Modifiers")
    End Sub
#End Region

    Private Sub ButtonModifierEnd_Click(sender As Object, e As EventArgs) Handles ButtonModifierEnd.Click
        If RadioButtonModifiersHalfBreed.Checked = True Then
            PanelHalfbreed.BringToFront()
            PanelHalfbreed.Enabled = True
            PanelModifier.Enabled = False
            SetHalfbreedPanel()
        ElseIf RadioButtonModifiersBoundWeapon.Checked = False And
             RadioButtonModifiersCommon.Checked = False And
             RadioButtonModifiersHalfBreed.Checked = False And
             RadioButtonModifiersSoulSplitter.Checked = False And
             RadioButtonModifiersSparkofInsanity.Checked = False And
             RadioButtonModifiersUndead.Checked = False And
             RadioButtonModifiersVampiric.Checked = False And
             RadioButtonModifiersWerewolf.Checked = False And
             RadioButtonModifiersFastMetabolism.Checked = False And
             RadioButtonModifiersFlashback.Checked = False And
             RadioButtonModifiersGuant.Checked = False And
             RadioButtonModifiersNaturalist.Checked = False And
             RadioButtonModifiersIndebtedsoul.Checked = False And
             RadioButtonModifiersToughskin.Checked = False Then
            MsgBox("Please select a Modifier!:)")
        Else
            PanelEnd.BringToFront()
            PanelEnd.Enabled = True
            PanelModifier.Enabled = False
        End If
    End Sub

#Region "Magic info"
    Private Sub LabelWizardKairomancy_Click(sender As Object, e As EventArgs) Handles LabelWizardKairomancy.Click
        ConstructInfoForm("ClassKairomancy")
    End Sub

    Private Sub LabelWizardPyromancy_Click(sender As Object, e As EventArgs) Handles LabelWizardPyromancy.Click
        ConstructInfoForm("ClassPyromancy")
    End Sub

    Private Sub LabelWizardHydromancy_Click(sender As Object, e As EventArgs) Handles LabelWizardHydromancy.Click
        ConstructInfoForm("ClassHydromancy")
    End Sub

    Private Sub LabelWizardKinesiomancy_Click(sender As Object, e As EventArgs) Handles LabelWizardKinesiomancy.Click
        ConstructInfoForm("ClassKinesiomancy")
    End Sub

    Private Sub LabelWizardNecromancy_Click(sender As Object, e As EventArgs) Handles LabelWizardNecromancy.Click
        ConstructInfoForm("ClassNecromancy")
    End Sub

    Private Sub LabelWizardNeuromancy_Click(sender As Object, e As EventArgs) Handles LabelWizardNeuromancy.Click
        ConstructInfoForm("ClassNeuromancy")
    End Sub
#End Region

#Region "Character Sheet Construction"
    Function Charactersheetkin() As String
        Dim Chosenkin As String = ""
        If RadioButtonKinAngalucian.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Angalucian"
        End If
        If RadioButtonKinCatdrah.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Catdrah"
        End If
        If RadioButtonKinDarkelf.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Dark Elf"
        End If
        If RadioButtonKinDrakhonon.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Drakhonon"
        End If
        If RadioButtonKinDryad.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Dryad"
        End If
        If RadioButtonKinDwarf.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Dwarf"
        End If
        If RadioButtonKinFairy.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Fairy"
        End If
        If RadioButtonKinFelucian.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Felucian"
        End If
        If RadioButtonKinGiGaYoNa.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Gi-Ga-Yo-Na"
        End If
        If RadioButtonKinGnome.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Gnome"
        End If
        If RadioButtonKinGoblin.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Goblin"
        End If
        If RadioButtonKinHighElf.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "High Elf"
        End If
        If RadioButtonKinFaerleth.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Faerleth"
        End If
        If RadioButtonKinJadeImperial.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Jadeimperial"
        End If
        If RadioButtonKinKinsmen.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Kinsmen"
        End If
        If RadioButtonKinMinotaur.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Minotaur"
        End If
        If RadioButtonKinNyad.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Nyad"
        End If
        If RadioButtonKinOrc.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Orc"
        End If
        If RadioButtonSanjoran.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Sanjoran"
        End If
        If RadioButtonKinSquirrel.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Squirrel"
        End If
        If RadioButtonTroll.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Troll"
        End If
        If RadioButtonKinWastelander.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Wastelander"
        End If
        If RadioButtonKinWolfsbein.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Wolfsbein"
        End If
        If RadioButtonKinWoodElf.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Wood Elf"
        End If
        If RadioButtonHalfbreedAngelucian.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Angelucian"
        End If
        If RadioButtonHalfbreedCatdrah.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Catdrah"
        End If
        If RadioButtonHalfbreedDarkelf.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Dark Elf"
        End If
        If RadioButtonHalfbreedDrakhonon.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Drakhonon"
        End If
        If RadioButtonHalfbreedDryad.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Dryad"
        End If
        If RadioButtonHalfbreedDwarf.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Dwarf"
        End If
        If RadioButtonHalfbreedFairy.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Fairy"
        End If
        If RadioButtonHalfbreedFelucian.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Felucian"
        End If
        If RadioButtonHalfbreedGigayona.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Gigayona"
        End If
        If RadioButtonHalfbreedGnome.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Gnome"
        End If
        If RadioButtonHalfbreedGoblin.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Goblin"
        End If
        If RadioButtonHalfbreedHighelf.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "High Elf"
        End If
        If RadioButtonHalfbreedFaerleth.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Faerleth"
        End If
        If RadioButtonHalfbreedJadeimperial.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Jade Imperial"
        End If
        If RadioButtonHalfbreedKinsmen.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Kinsmen"
        End If
        If RadioButtonHalfbreedMinotaur.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Minotaur"
        End If
        If RadioButtonHalfbreedNyad.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Nyad"
        End If
        If RadioButtonHalfbreedOrc.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Orc"
        End If
        If RadioButtonHalfbreedSanjoran.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Sanjoran"
        End If
        If RadioButtonHalfbreedSquirrel.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Squirrel"
        End If
        If RadioButtonHalfbreedTroll.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Troll"
        End If
        If RadioButtonHalfbreedWastelander.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Wastelander"
        End If
        If RadioButtonHalfbreedWolfsbein.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Wolfsbein"
        End If
        If RadioButtonHalfbreedWoodelf.Checked = True Then
            Chosenkin = Chosenkin & vbCrLf & "Woodelf"
        End If
        Return Chosenkin
    End Function
    Function Charactersheetclass() As String
        Dim Chosenclass As String = ""
        If RadioButtonClassCleric.Checked = True Then
            Chosenclass = Chosenclass & vbCrLf & "Cleric"
        End If
        If RadioButtonClassNoble.Checked = True Then
            Chosenclass = Chosenclass & vbCrLf & "Noble"
        End If
        If RadioButtonClassRanger.Checked = True Then
            Chosenclass = Chosenclass & vbCrLf & "Ranger"
        End If
        If RadioButtonClassRogue.Checked = True Then
            Chosenclass = Chosenclass & vbCrLf & "Rogue"
        End If
        If RadioButtonClassVoidKnight.Checked = True Then
            Chosenclass = Chosenclass & vbCrLf & "Void Knight"
        End If
        If RadioButtonClassWarrior.Checked = True Then
            Chosenclass = Chosenclass & vbCrLf & "Warrior"
        End If
        If RadioButtonClassWizard.Checked = True Then
            Chosenclass = Chosenclass & vbCrLf & "Wizard"
        End If

        Return Chosenclass
    End Function
    Function Charactersheetmodifier() As String
        Dim Chosenmodifier As String = ""
        If RadioButtonModifiersCommon.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Common"
        End If
        If RadioButtonModifiersHalfBreed.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Half-Breed"
        End If
        If RadioButtonModifiersSoulSplitter.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Soul-Splitter"
        End If
        If RadioButtonModifiersSparkofInsanity.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Spark of Insanity"
        End If
        If RadioButtonModifiersUndead.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Undead"
        End If
        If RadioButtonModifiersVampiric.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Vampiric"
        End If
        If RadioButtonModifiersWerewolf.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "WereWolf"
        End If
        If RadioButtonModifiersBoundWeapon.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Bound Weapon"
        End If
        If RadioButtonModifiersNaturalist.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Naturalist"
        End If
        If RadioButtonModifiersGuant.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Guant"
        End If
        If RadioButtonModifiersFastMetabolism.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Fast Metabolism"
        End If
        If RadioButtonModifiersToughskin.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Tough Skin"
        End If
        If RadioButtonModifiersFlashback.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Flashback"
        End If
        If RadioButtonModifiersIndebtedsoul.Checked = True Then
            Chosenmodifier = Chosenmodifier & vbCrLf & "Indebted Soul"
        End If

        Return Chosenmodifier
    End Function
    Function CharactersheetBackgrounds() As String
        Dim ChosenBackgrounds As String = ""
        If CheckBoxBackgroundsSeaworthy.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Seaworthy"
        End If
        If CheckBoxBackgroundsBlacksmith.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Blacksmith"
        End If
        If CheckBoxBackgroundsTailor.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Tailor"
        End If
        If CheckBoxBackgroundsScholar.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Scholar"
        End If
        If CheckBoxBackgroundsArcanescholar.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Arcane Scholar"
        End If
        If CheckBoxBackgroundsRepairman.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Repairman"
        End If
        If CheckBoxBackgroundsFisherman.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Fisherman"
        End If
        If CheckBoxBackgroundsArchitect.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Architect"
        End If
        If CheckBoxBackgroundsWoodsman.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Woodsman"
        End If
        If CheckBoxBackgroundsCartographer.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Cartographer"
        End If
        If CheckBoxBackgroundsSmuggler.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Smuggler"
        End If
        If CheckBoxBackgroundsHistorian.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Historian"
        End If
        If CheckBoxBackgroundsBotanist.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Botanist"
        End If
        If CheckBoxBackgroundsMiddleman.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Middleman"
        End If
        If CheckBoxBackgroundsGuard.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Guard"
        End If
        If CheckBoxBackgroundsEnchantmentspecialist.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Enchantment Specialist"
        End If
        If CheckBoxBackgroundsCleanser.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Cleanser"
        End If
        If CheckBoxBackgroundsTradesman.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Tradesman"
        End If
        If CheckBoxBackgroundsWanderer.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Wanderer"
        End If
        If CheckBoxBackgroundsUrchin.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Urchin"
        End If
        If CheckBoxBackgroundsWeaponsarmorknowledge.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Weapons and Armor Knowledge"
        End If
        If CheckBoxBackgroundsCourier.Checked = True Then
            ChosenBackgrounds = ChosenBackgrounds & vbCrLf & "Courier"
        End If

        Return ChosenBackgrounds
    End Function
    Function CharactersheetAttribute() As String
        Dim ChosenAttribute As String = ""
        If RadioButtonAngalucianAmaze.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Amaze"
        End If
        If RadioButtonAngalucianBeaconoflight.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Beacon of Light"
        End If
        If RadioButtonAngalucianBlessedweapon.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Blessed Weapon"
        End If
        If RadioButtonAngalucianFlight.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Flight"
        End If
        If RadioButtonAngalucianTakeheed.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Take Heed"
        End If
        If RadioButtonCatdrahClimbTree.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Tree Climb"
        End If
        If RadioButtonCatdrahCuteness.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Cuteness"
        End If
        If RadioButtonCatdrahSafeLanding.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Safe Landing"
        End If
        If RadioButtonDarkelfAlignment.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Alignment"
        End If
        If RadioButtonDarkelfLightsleeper.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Light Sleeper"
        End If
        If RadioButtonDarkelfNightvision.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Night Vision"
        End If
        If RadioButtonDrakohnonDragonskin.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Dragonskin"
        End If
        If RadioButtonDrakohnonFireisenergy.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Fire is Energy"
        End If
        If RadioButtonDrakohnonHeatvision.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Heat Vision"
        End If
        If RadioButtonDrakohnonPiercinggaze.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Piercing Gaze"
        End If
        If RadioButtonDryadBarkSkin.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Bark Skin"
        End If
        If RadioButtonDryadNutrients.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Nutrients"
        End If
        If RadioButtonDryadRooted.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Rooted"
        End If
        If RadioButtonDwarfDwarfIt.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Dwarf it"
        End If
        If RadioButtonDwarfExamination.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Examination"
        End If
        If RadioButtonDwarfLowLightVision.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Low-light Vision"
        End If
        If RadioButtonFaerlethHideyhole.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Hidey Hole"
        End If
        If RadioButtonFaerlethMastermunchyologist.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Master Munchyologist"
        End If
        If RadioButtonFaerlethRiddle.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Riddle"
        End If
        If RadioButtonFaerlethToughfeet.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Tough Feet"
        End If
        If RadioButtonFairyAhlucaro.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Ahlucaro"
        End If
        If RadioButtonFairyFlutter.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Flutter"
        End If
        If RadioButtonFairyIlluminate.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Illuminate"
        End If
        If RadioButtonFairyPlanttelepathy.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Plant Telepathy"
        End If
        If RadioButtonFairySzhoom.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Szhoom"
        End If
        If RadioButtonFelucianDarkness.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Darkness"
        End If
        If RadioButtonFelucianHangingaround.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Hanging Around"
        End If
        If RadioButtonFelucianWingburst.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Wingburst"
        End If
        If RadioButtonGigayonaBellysmash.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Belly Smash"
        End If
        If RadioButtonGigayonaFoodsfood.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Foods Food"
        End If
        If RadioButtonGigayonaThickcoat.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Thick Coat"
        End If
        If RadioButtonGnomeEfficientArmor.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Efficient Armor"
        End If
        If RadioButtonGnomeSmallSize.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Small Size"
        End If
        If RadioButtonGnomeTrinkets.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Trinkets"
        End If
        If RadioButtonGoblinEntertaining.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Enertaining"
        End If
        If RadioButtonGoblinLightFrame.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Light Frame"
        End If
        If RadioButtonGoblinRollAway.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Roll Away"
        End If
        If RadioButtonHighelfBedazzle.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Bedazzle"
        End If
        If RadioButtonHighelfColorsofthewind.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Colors of the Wind"
        End If
        If RadioButtonHighelfLightfoot.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Light Foot"
        End If
        If RadioButtonJadeImperialAncestry.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Ancestry"
        End If
        If RadioButtonJadeImperialTeamPlayer.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Team Player"
        End If
        If RadioButtonJadeImperialSanctioned.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Sanctioned"
        End If
        If RadioButtonKinsmanMilitia.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Militia"
        End If
        If RadioButtonKinsmanNeutrality.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Neutrality"
        End If
        If RadioButtonKinsmanTrustMe.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Trust Me"
        End If
        If RadioButtonMinotaurCharge.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Chargge"
        End If
        If RadioButtonMinotaurDaunting.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Daunting"
        End If
        If RadioButtonMinotaurRam.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Ram"
        End If
        If RadioButtonNyadFlow.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Flow"
        End If
        If RadioButtonNyadSqueeze.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Squeeze"
        End If
        If RadioButtonNyadTaint.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Taint"
        End If
        If RadioButtonNyadThebiggertheyare.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "The Bigger they are"
        End If
        If RadioButtonNyadWateraffinity.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Water Affinity"
        End If
        If RadioButtonOrcBloodpool.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Bloodpool"
        End If
        If RadioButtonOrcFeelnopain.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Feel no Pain"
        End If
        If RadioButtonOrcGruff.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Gruff"
        End If
        If RadioButtonSanjoranNip.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Nip"
        End If
        If RadioButtonSanjoranRegrowth.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Regrowth"
        End If
        If RadioButtonSanjoranResistance.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Resistance"
        End If
        If RadioButtonSquirrelForage.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Forage"
        End If
        If RadioButtonSquirrelHonorDuel.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Honor Duel"
        End If
        If RadioButtonSquirrelTacticalWithdrawl.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Tactical Withdrawl"
        End If
        If RadioButtonTrollLug.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Lug"
        End If
        If RadioButtonTrollStoneDigestion.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Stone Digestion"
        End If
        If RadioButtonTrollStout.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Stout"
        End If
        If RadioButtonWastelanderBlendin.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Blend in"
        End If
        If RadioButtonWastelanderStreetsmart.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Street Smart"
        End If
        If RadioButtonWastelanderThuroughsearch.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Thurough Search"
        End If
        If RadioButtonWolfsbeinPowerthrough.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Power Through"
        End If
        If RadioButtonWolfsbeinRedolent.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Redolent"
        End If
        If RadioButtonWolfsbeinTrustworthy.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Trustworthy"
        End If
        If RadioButtonWoodelfElementaryinvocation.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Elementary Invocation"
        End If
        If RadioButtonWoodelfForestflight.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Forest Flight"
        End If
        If RadioButtonWoodelfLifeattunement.Checked = True Then
            ChosenAttribute = ChosenAttribute & vbCrLf & "Life Attunement"
        End If

        Return ChosenAttribute
    End Function
#End Region
End Class