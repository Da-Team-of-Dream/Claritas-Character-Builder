Public Class FormDex

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
        ConstructInfoForm("AllweaponsWeaponart")
    End Sub

#Region "checkbox check events"

    'Weapon arts
    Private Sub RadioButtonWeaponartDagger_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartDagger.CheckedChanged
        If RadioButtonWeaponartDagger.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartDagger.Checked = False
            ElseIf Dex1B < 1 Then
                MsgBox("You must have dexterity in one handed blades to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartDagger.Checked = False
            Else
                WAD = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartShortsword_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartShortsword.CheckedChanged
        If RadioButtonWeaponartShortsword.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartShortsword.Checked = False
            ElseIf Dex1B < 1 Then
                MsgBox("You must have dexterity in one handed blades to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartShortsword.Checked = False
            Else
                WASS = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartLongsword_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartLongsword.CheckedChanged
        If RadioButtonWeaponartLongsword.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartLongsword.Checked = False
            ElseIf Dex2B < 1 Then
                MsgBox("You must have dexterity in two handed blades to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartLongsword.Checked = False
            Else
                WALS = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartGreatsword_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartGreatsword.CheckedChanged
        If RadioButtonWeaponartGreatsword.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartGreatsword.Checked = False
            ElseIf Dex2B < 1 Then
                MsgBox("You must have dexterity in two handed blades to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartGreatsword.Checked = False
            Else
                WAGS = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartHatchet_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartHatchet.CheckedChanged
        If RadioButtonWeaponartHatchet.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartHatchet.Checked = False
            ElseIf Dex1a < 1 Then
                MsgBox("You must have dexterity in one handed axes to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartHatchet.Checked = False
            Else
                WAHA = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartBattleaxe_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartBattleaxe.CheckedChanged
        If RadioButtonWeaponartBattleaxe.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartBattleaxe.Checked = False
            ElseIf Dex1a < 1 Then
                MsgBox("You must have dexterity in one handed axes to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartBattleaxe.Checked = False
            Else
                WABA = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartWaraxe_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartWaraxe.CheckedChanged
        If RadioButtonWeaponartWaraxe.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartWaraxe.Checked = False
            ElseIf Dex2a < 1 Then
                MsgBox("You must have dexterity in two handed axes to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartWaraxe.Checked = False
            Else
                WAWA = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartGreataxe_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartGreataxe.CheckedChanged
        If RadioButtonWeaponartGreataxe.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartGreataxe.Checked = False
            ElseIf Dex2a < 1 Then
                MsgBox("You must have dexterity in two handed axes to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartGreataxe.Checked = False
            Else
                WAGA = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartHammer_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartHammer.CheckedChanged
        If RadioButtonWeaponartHammer.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartHammer.Checked = False
            ElseIf Dex1H < 1 Then
                MsgBox("You must have dexterity in one handed hammers to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartHammer.Checked = False
            Else
                WAH = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartBattlehammer_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartBattlehammer.CheckedChanged
        If RadioButtonWeaponartBattlehammer.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartBattlehammer.Checked = False
            ElseIf Dex1h < 1 Then
                MsgBox("You must have dexterity in one handed hammers to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartBattlehammer.Checked = False
            Else
                WABH = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartWarhammer_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartWarhammer.CheckedChanged
        If RadioButtonWeaponartWarhammer.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartWarhammer.Checked = False
            ElseIf Dex2h < 1 Then
                MsgBox("You must have dexterity in two handed hammers to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartWarhammer.Checked = False
            Else
                WAWH = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartGreathammer_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartGreathammer.CheckedChanged
        If RadioButtonWeaponartGreathammer.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartGreathammer.Checked = False
            ElseIf Dex2h < 1 Then
                MsgBox("You must have dexterity in two handed hammers to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartGreathammer.Checked = False
            Else
                WAGH = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartHuntingspear_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartHuntingspear.CheckedChanged
        If RadioButtonWeaponartHuntingspear.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartHuntingspear.Checked = False
            ElseIf Dex1p < 1 Then
                MsgBox("You must have dexterity in one handed spears to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartHuntingspear.Checked = False
            Else
                WAHP = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartBattlespear_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartBattlespear.CheckedChanged
        If RadioButtonWeaponartBattlespear.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartBattlespear.Checked = False
            ElseIf Dex1p < 1 Then
                MsgBox("You must have dexterity in one handed spears to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartBattlespear.Checked = False
            Else
                WABP = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartWarspear_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartWarspear.CheckedChanged
        If RadioButtonWeaponartWarspear.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartWarspear.Checked = False
            ElseIf Dex2p < 1 Then
                MsgBox("You must have dexterity in two handed spears to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartWarspear.Checked = False
            Else
                WAWP = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartGreatspear_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartGreatspear.CheckedChanged
        If RadioButtonWeaponartGreatspear.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartGreatspear.Checked = False
            ElseIf Dex2p < 1 Then
                MsgBox("You must have dexterity in two handed spears to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartGreatspear.Checked = False
            Else
                WAGP = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartBow_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartBow.CheckedChanged
        If RadioButtonWeaponartBow.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartBow.Checked = False
            ElseIf DexBow < 1 Then
                MsgBox("You must have dexterity in bows to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartBow.Checked = False
            Else
                WAB = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartBuckler_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartBuckler.CheckedChanged
        If RadioButtonWeaponartBuckler.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartBuckler.Checked = False
            ElseIf DexShield < 1 Then
                MsgBox("You must have dexterity in shields to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartBuckler.Checked = False
            Else
                WABuckler = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartKiteshield_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartKiteshield.CheckedChanged
        If RadioButtonWeaponartKiteshield.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartKiteshield.Checked = False
            ElseIf DexShield < 1 Then
                MsgBox("You must have dexterity in shields to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartKiteshield.Checked = False
            Else
                WAKshield = 1
            End If
        End If
        TalentLableChange()
    End Sub
    Private Sub RadioButtonWeaponartGreatshield_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWeaponartGreatshield.CheckedChanged
        If RadioButtonWeaponartGreatshield.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                RadioButtonWeaponartGreatshield.Checked = False
            ElseIf DexShield < 1 Then
                MsgBox("You must have dexterity in one handed blades to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                RadioButtonWeaponartGreatshield.Checked = False
            Else
                WAGS = 1
            End If
        End If
        TalentLableChange()
    End Sub

    'Weapon dexterities

    Private Sub CheckBoxWepondexOnehandedblades_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexOnehandedblades.CheckedChanged
        If CheckBoxWepondexOnehandedblades.Checked = True Then
            If DexterityCount() = 0 Then
                Dex1B = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex1B = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexOnehandedblades.Checked = False
            End If
        ElseIf CheckBoxWepondexOnehandedblades.Checked = False And Dex1b = 1 Then
            Dex1B = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexTwohandedblades_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexTwohandedblades.CheckedChanged
        If CheckBoxWepondexTwohandedblades.Checked = True Then
            If DexterityCount() = 0 Then
                Dex2B = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex2B = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexTwohandedblades.Checked = False
            End If
        ElseIf CheckBoxWepondexTwohandedblades.Checked = False And Dex2b = 1 Then
            Dex2B = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexOnehandedaxes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexOnehandedaxes.CheckedChanged
        If CheckBoxWepondexOnehandedaxes.Checked = True Then
            If DexterityCount() = 0 Then
                Dex1A = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex1A = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexOnehandedaxes.Checked = False
            End If
        ElseIf CheckBoxWepondexOnehandedaxes.Checked = False And Dex1a = 1 Then
            Dex1A = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexTwohandedaxes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexTwohandedaxes.CheckedChanged
        If CheckBoxWepondexTwohandedaxes.Checked = True Then
            If DexterityCount() = 0 Then
                Dex2A = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex2A = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexTwohandedaxes.Checked = False
            End If
        ElseIf CheckBoxWepondexTwohandedaxes.Checked = False And Dex2A = 1 Then
            Dex2A = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexOnehandedhammers_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexOnehandedhammers.CheckedChanged
        If CheckBoxWepondexOnehandedhammers.Checked = True Then
            If DexterityCount() = 0 Then
                Dex1H = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex1H = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexOnehandedhammers.Checked = False
            End If
        ElseIf CheckBoxWepondexOnehandedhammers.Checked = False And Dex1h = 1 Then
            Dex1H = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexTwohandedhammers_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexTwohandedhammers.CheckedChanged
        If CheckBoxWepondexTwohandedhammers.Checked = True Then
            If DexterityCount() = 0 Then
                Dex2H = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex2H = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexTwohandedhammers.Checked = False
            End If
        ElseIf CheckBoxWepondexTwohandedhammers.Checked = False And Dex2h = 1 Then
            Dex2H = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexOnehandedspears_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexOnehandedspears.CheckedChanged
        If CheckBoxWepondexOnehandedspears.Checked = True Then
            If DexterityCount() = 0 Then
                Dex1P = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex1P = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexOnehandedspears.Checked = False
            End If
        ElseIf CheckBoxWepondexOnehandedspears.Checked = False And Dex1p = 1 Then
            Dex1P = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexTwohandedspears_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexTwohandedspears.CheckedChanged
        If CheckBoxWepondexTwohandedspears.Checked = True Then
            If DexterityCount() = 0 Then
                Dex2P = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex2P = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexTwohandedspears.Checked = False
            End If
        ElseIf CheckBoxWepondexTwohandedspears.Checked = False And Dex2p = 1 Then
            Dex2P = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexBows_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexBows.CheckedChanged
        If CheckBoxWepondexBows.Checked = True Then
            If DexterityCount() = 0 Then
                DexBow = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                DexBow = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexBows.Checked = False
            End If
        ElseIf CheckBoxWepondexBows.Checked = False And DexBow = 1 Then
            DexBow = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexDualwielding_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexDualwielding.CheckedChanged
        If CheckBoxWepondexDualwielding.Checked = True Then
            If DexterityCount() = 0 Then
                DexDuel = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                DexDuel = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexDualwielding.Checked = False
            End If
        ElseIf CheckBoxWepondexDualwielding.Checked = False And DexDuel = 1 Then
            DexDuel = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexExoticweapons_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexExoticweapons.CheckedChanged
        If CheckBoxWepondexExoticweapons.Checked = True Then
            If DexterityCount() = 0 Then
                DexE = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                DexE = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexExoticweapons.Checked = False
            End If
        ElseIf CheckBoxWepondexExoticweapons.Checked = False And Dexe = 1 Then
            DexE = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWeapondexWeaponcasting_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeapondexWeaponcasting.CheckedChanged
        If CheckBoxWeapondexWeaponcasting.Checked = True Then
            If DexterityCount() = 0 Then
                WeaponCasting = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                WeaponCasting = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWeapondexWeaponcasting.Checked = False
            End If
        ElseIf CheckBoxWeapondexWeaponcasting.Checked = False And WeaponCasting = 1 Then
            WeaponCasting = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexShields_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexShields.CheckedChanged
        If CheckBoxWepondexShields.Checked = True Then
            If DexterityCount() = 0 Then
                DexShield = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                DexShield = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexShields.Checked = False
            End If
        ElseIf CheckBoxWepondexShields.Checked = False And DexShield = 1 Then
            DexShield = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexThrowingweapons_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexThrowingweapons.CheckedChanged
        If CheckBoxWepondexThrowingweapons.Checked = True Then
            If DexterityCount() = 0 Then
                DexT = 1
                XP = XP - 5
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                DexT = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexThrowingweapons.Checked = False
            End If
        ElseIf CheckBoxWepondexThrowingweapons.Checked = False And Dext = 1 Then
            DexT = 0
            XP = XP + 5
        End If
        TalentLableChange()
    End Sub


#End Region
End Class