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
    Private Sub CheckBoxWeaponartDagger_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartDagger.CheckedChanged
        If CheckBoxWeaponartDagger.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartDagger.Checked = False
            ElseIf Dex1B < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in one handed blades to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartDagger.Checked = False
            Else
                WAD = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartDagger.Checked = False And WAD = 1 Then
            WAD = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartShortsword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartShortsword.CheckedChanged
        If CheckBoxWeaponartShortsword.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartShortsword.Checked = False
            ElseIf Dex1B < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in one handed blades to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartShortsword.Checked = False
            Else
                WASS = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartShortsword.Checked = False And WASS = 1 Then
            WASS = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartLongsword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartLongsword.CheckedChanged
        If CheckBoxWeaponartLongsword.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartLongsword.Checked = False
            ElseIf Dex2B < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in two handed blades to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartLongsword.Checked = False
            Else
                WALS = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartLongsword.Checked = False And WALS = 1 Then
            WALS = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartGreatsword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartGreatsword.CheckedChanged
        If CheckBoxWeaponartGreatsword.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartGreatsword.Checked = False
            ElseIf Dex2B < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in two handed blades to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartGreatsword.Checked = False
            Else
                WAGS = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartGreatsword.Checked = False And WAGS = 1 Then
            WAGS = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartHatchet_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartHatchet.CheckedChanged
        If CheckBoxWeaponartHatchet.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartHatchet.Checked = False
            ElseIf Dex1A < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in one handed axes to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartHatchet.Checked = False
            Else
                WAHA = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartHatchet.Checked = False And WAHA = 1 Then
            WAHA = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartBattleaxe_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartBattleaxe.CheckedChanged
        If CheckBoxWeaponartBattleaxe.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartBattleaxe.Checked = False
            ElseIf Dex1A < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in one handed axes to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartBattleaxe.Checked = False
            Else
                WABA = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartBattleaxe.Checked = False And WABA = 1 Then
            WABA = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartWaraxe_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartWaraxe.CheckedChanged
        If CheckBoxWeaponartWaraxe.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartWaraxe.Checked = False
            ElseIf Dex2A < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in two handed axes to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartWaraxe.Checked = False
            Else
                WAWA = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartWaraxe.Checked = False And WAWA = 1 Then
            WAWA = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartGreataxe_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartGreataxe.CheckedChanged
        If CheckBoxWeaponartGreataxe.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartGreataxe.Checked = False
            ElseIf Dex2A < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in two handed axes to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartGreataxe.Checked = False
            Else
                WAGA = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartGreataxe.Checked = False And WAGA = 1 Then
            WAGA = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartHammer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartHammer.CheckedChanged
        If CheckBoxWeaponartHammer.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartHammer.Checked = False
            ElseIf Dex1H < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in one handed hammers to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartHammer.Checked = False
            Else
                WAH = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartHammer.Checked = False And WAH = 1 Then
            WAH = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartBattlehammer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartBattlehammer.CheckedChanged
        If CheckBoxWeaponartBattlehammer.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartBattlehammer.Checked = False
            ElseIf Dex1H < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in one handed hammers to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartBattlehammer.Checked = False
            Else
                WABH = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartBattlehammer.Checked = False And WABH = 1 Then
            WABH = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartWarhammer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartWarhammer.CheckedChanged
        If CheckBoxWeaponartWarhammer.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartWarhammer.Checked = False
            ElseIf Dex2H < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in two handed hammers to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartWarhammer.Checked = False
            Else
                WAWH = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartWarhammer.Checked = False And WAWH = 1 Then
            WAWH = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartGreathammer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartGreathammer.CheckedChanged
        If CheckBoxWeaponartGreathammer.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartGreathammer.Checked = False
            ElseIf Dex2H < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in two handed hammers to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartGreathammer.Checked = False
            Else
                WAGH = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartGreathammer.Checked = False And WAGH = 1 Then
            WAGH = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartHuntingspear_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartHuntingspear.CheckedChanged
        If CheckBoxWeaponartHuntingspear.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartHuntingspear.Checked = False
            ElseIf Dex1P < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in one handed spears to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartHuntingspear.Checked = False
            Else
                WAHP = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartHuntingspear.Checked = False And WAHP = 1 Then
            WAHP = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartBattlespear_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartBattlespear.CheckedChanged
        If CheckBoxWeaponartBattlespear.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartBattlespear.Checked = False
            ElseIf Dex1P < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in one handed spears to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartBattlespear.Checked = False
            Else
                WABP = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartBattlespear.Checked = False And WABP = 1 Then
            WABP = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartWarspear_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartWarspear.CheckedChanged
        If CheckBoxWeaponartWarspear.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartWarspear.Checked = False
            ElseIf Dex2P < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in two handed spears to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartWarspear.Checked = False
            Else
                WAWP = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartWarspear.Checked = False And WAWP = 1 Then
            WAWP = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartGreatspear_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartGreatspear.CheckedChanged
        If CheckBoxWeaponartGreatspear.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartGreatspear.Checked = False
            ElseIf Dex2P < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in two handed spears to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartGreatspear.Checked = False
            Else
                WAGP = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartGreatspear.Checked = False And WAGP = 1 Then
            WAGP = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartBow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartBow.CheckedChanged
        If CheckBoxWeaponartBow.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartBow.Checked = False
            ElseIf DexBow < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in bows to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartBow.Checked = False
            Else
                WAB = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartBow.Checked = False And WAB = 1 Then
            WAB = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartBuckler_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartBuckler.CheckedChanged
        If CheckBoxWeaponartBuckler.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartBuckler.Checked = False
            ElseIf DexShield < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in shields to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartBuckler.Checked = False
            Else
                WABuckler = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartBuckler.Checked = False And WABuckler = 1 Then
            WABuckler = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartKiteshield_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartKiteshield.CheckedChanged
        If CheckBoxWeaponartKiteshield.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartKiteshield.Checked = False
            ElseIf DexShield < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in shields to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartKiteshield.Checked = False
            Else
                WAKshield = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartKiteshield.Checked = False And WAKshield = 1 Then
            WAKshield = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub
    Private Sub CheckBoxWeaponartGreatshield_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeaponartGreatshield.CheckedChanged
        If CheckBoxWeaponartGreatshield.Checked = True Then
            If XP < 10 Then
                MsgBox("You do not have enough XP! Weapon arts cost 10 XP!")
                CheckBoxWeaponartGreatshield.Checked = False
            ElseIf DexShield < 1 And DexE < 1 Then
                MsgBox("You must have dexterity in one handed blades to have this weapon art!" & vbCrLf & "Please select the dexterity first!")
                CheckBoxWeaponartGreatshield.Checked = False
            Else
                WAGS = 1
                XP = XP - 10
            End If
        ElseIf CheckBoxWeaponartGreatshield.Checked = False And WAGshield = 1 Then
            WAGshield = 0
            XP = XP + 10
        End If
        TalentLableChange()
    End Sub

    'Weapon dexterities

    Private Sub CheckBoxWepondexOnehandedblades_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexOnehandedblades.CheckedChanged
        If CheckBoxWepondexOnehandedblades.Checked = True Then
            If DexterityCount() = 0 Then
                Dex1B = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex1B = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexOnehandedblades.Checked = False
            End If
        ElseIf CheckBoxWepondexOnehandedblades.Checked = False And Dex1b = 1 Then
            Dex1B = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexTwohandedblades_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexTwohandedblades.CheckedChanged
        If CheckBoxWepondexTwohandedblades.Checked = True Then
            If DexterityCount() = 0 Then
                Dex2B = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex2B = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexTwohandedblades.Checked = False
            End If
        ElseIf CheckBoxWepondexTwohandedblades.Checked = False And Dex2b = 1 Then
            Dex2B = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
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
                If DexterityCount() > 0 Then
                    XP = XP + 5
                End If
            End If
            TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexTwohandedaxes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexTwohandedaxes.CheckedChanged
        If CheckBoxWepondexTwohandedaxes.Checked = True Then
            If DexterityCount() = 0 Then
                Dex2A = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex2A = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexTwohandedaxes.Checked = False
            End If
        ElseIf CheckBoxWepondexTwohandedaxes.Checked = False And Dex2A = 1 Then
            Dex2A = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexOnehandedhammers_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexOnehandedhammers.CheckedChanged
        If CheckBoxWepondexOnehandedhammers.Checked = True Then
            If DexterityCount() = 0 Then
                Dex1H = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex1H = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexOnehandedhammers.Checked = False
            End If
        ElseIf CheckBoxWepondexOnehandedhammers.Checked = False And Dex1h = 1 Then
            Dex1H = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexTwohandedhammers_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexTwohandedhammers.CheckedChanged
        If CheckBoxWepondexTwohandedhammers.Checked = True Then
            If DexterityCount() = 0 Then
                Dex2H = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex2H = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexTwohandedhammers.Checked = False
            End If
        ElseIf CheckBoxWepondexTwohandedhammers.Checked = False And Dex2h = 1 Then
            Dex2H = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexOnehandedspears_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexOnehandedspears.CheckedChanged
        If CheckBoxWepondexOnehandedspears.Checked = True Then
            If DexterityCount() = 0 Then
                Dex1P = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex1P = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexOnehandedspears.Checked = False
            End If
        ElseIf CheckBoxWepondexOnehandedspears.Checked = False And Dex1p = 1 Then
            Dex1P = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexTwohandedspears_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexTwohandedspears.CheckedChanged
        If CheckBoxWepondexTwohandedspears.Checked = True Then
            If DexterityCount() = 0 Then
                Dex2P = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                Dex2P = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexTwohandedspears.Checked = False
            End If
        ElseIf CheckBoxWepondexTwohandedspears.Checked = False And Dex2p = 1 Then
            Dex2P = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexBows_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexBows.CheckedChanged

    End Sub

    Private Sub CheckBoxWepondexDualwielding_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexDualwielding.CheckedChanged
        If CheckBoxWepondexDualwielding.Checked = True Then
            If DexterityCount() = 0 Then
                DexDuel = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                DexDuel = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexDualwielding.Checked = False
            End If
        ElseIf CheckBoxWepondexDualwielding.Checked = False And DexDuel = 1 Then
            DexDuel = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexExoticweapons_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexExoticweapons.CheckedChanged
        If CheckBoxWepondexExoticweapons.Checked = True Then
            If DexterityCount() = 0 Then
                DexE = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                DexE = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexExoticweapons.Checked = False
            End If
        ElseIf CheckBoxWepondexExoticweapons.Checked = False And Dexe = 1 Then
            DexE = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWeapondexWeaponcasting_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWeapondexWeaponcasting.CheckedChanged
        If CheckBoxWeapondexWeaponcasting.Checked = True Then
            If DexterityCount() = 0 Then
                WeaponCasting = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                WeaponCasting = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWeapondexWeaponcasting.Checked = False
            End If
        ElseIf CheckBoxWeapondexWeaponcasting.Checked = False And WeaponCasting = 1 Then
            WeaponCasting = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexShields_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexShields.CheckedChanged
        If CheckBoxWepondexShields.Checked = True Then
            If DexterityCount() = 0 Then
                DexShield = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                DexShield = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexShields.Checked = False
            End If
        ElseIf CheckBoxWepondexShields.Checked = False And DexShield = 1 Then
            DexShield = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
        End If
        TalentLableChange()
    End Sub

    Private Sub CheckBoxWepondexThrowingweapons_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWepondexThrowingweapons.CheckedChanged
        If CheckBoxWepondexThrowingweapons.Checked = True Then
            If DexterityCount() = 0 Then
                DexT = 1
            ElseIf DexterityCount() > 0 And XP >= 5 Then
                DexT = 1
                XP = XP - 5
            Else
                MsgBox("You do not have enough XP!!")
                CheckBoxWepondexThrowingweapons.Checked = False
            End If
        ElseIf CheckBoxWepondexThrowingweapons.Checked = False And Dext = 1 Then
            DexT = 0
            If DexterityCount() > 0 Then
                XP = XP + 5
            End If
        End If
        TalentLableChange()
    End Sub




#End Region

    Private Sub ButtonWeapondexForm1_Click(sender As Object, e As EventArgs) Handles ButtonWeapondexForm1.Click
        Me.Hide()
    End Sub

    Private Sub ButtonWeaponartForm1_Click(sender As Object, e As EventArgs) Handles ButtonWeaponartForm1.Click
        Me.Hide()
    End Sub
End Class