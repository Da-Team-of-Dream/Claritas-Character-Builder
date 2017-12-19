Module FunctionsList
    ' this function reads and outputs the requested text
    Function BuildInfoFormLabel(Item As String) As String
        Dim path As String = My.Application.Info.DirectoryPath
        Dim Reader As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(path & "\Character_Builder_Internal_Info.txt")
        Dim StringReader As String
        Dim OutputString As String = ""
        StringReader = Reader.ReadLine()
        Do Until Reader.EndOfStream
            If StringReader = Item Then
                StringReader = Reader.ReadLine()
                Do Until StringReader = Item
                    OutputString = OutputString & StringReader & vbCrLf
                    StringReader = Reader.ReadLine()
                Loop
            End If
            StringReader = Reader.ReadLine()
        Loop
        Reader.Close()
        Return OutputString
    End Function
    Sub ConstructInfoForm(Text As String)
        Dim InfoForm As New FormInfo()
        InfoForm.InfoFormLabel.Text = BuildInfoFormLabel(Text)
        InfoForm.Show()
    End Sub
End Module
Module AbilityVariables
    'Classless Abilities
    Public Sense As Integer = 0
    Public Detection As Integer = 0
    Public ScrollWriting As Integer = 0
    Public SenseR2 As Integer = 0
    Public DetectionR2 As Integer = 0
    Public ScrollWritingR2 As Integer = 0
    'Classless Skills
    Public Enchanting As Integer = 0
    Public Forestry As Integer = 0
    Public Leatherworking As Integer = 0
    Public Prowess As Integer = 0
    Public Smithing As Integer = 0
    Public EnchantingR2 As Integer = 0
    Public ForestryR2 As Integer = 0
    Public LeatherworkingR2 As Integer = 0
    Public ProwessR2 As Integer = 0
    Public SmithingR2 As Integer = 0
    'Dex
    Public DexT As Integer = 0
    Public Dex1B As Integer = 0
    Public Dex2B As Integer = 0
    Public Dex1A As Integer = 0
    Public Dex2A As Integer = 0
    Public Dex1H As Integer = 0
    Public Dex2H As Integer = 0
    Public Dex1P As Integer = 0
    Public Dex2P As Integer = 0
    Public DexE As Integer = 0
    Public DexBow As Integer = 0
    Public DexShield As Integer = 0
    Public DexDuel As Integer = 0
    'Cleric Talents
    Public BornAnew As Integer = 0
    Public Convert As Integer = 0
    Public Healing As Integer = 0
    Public Remedy As Integer = 0
    Public Potions As Integer = 0
    'Nobel Talents
    Public Charisma As Integer = 0
    Public Engineering As Integer = 0
    Public Imperius As Integer = 0
    Public Languages As Integer = 0
    Public Leadership As Integer = 0
    'Ranger Talents
    Public Deadeye As Integer = 0
    Public AHide As Integer = 0
    Public Iaijutsu As Integer = 0
    Public Traps As Integer = 0
    Public Tracking As Integer = 0
    'Rogue Talents
    Public Blind As Integer = 0
    Public Disguise As Integer = 0
    Public Expose As Integer = 0
    Public Vanish As Integer = 0
    Public Disease As Integer = 0
    'Void Knight Talents
    Public Jump As Integer = 0
    Public Lifelink As Integer = 0
    Public ShroudofProtection As Integer = 0
    Public Silence As Integer = 0
    Public Void As Integer = 0
    'Warior Talents
    Public CrushingBlow As Integer = 0
    Public Disarm As Integer = 0
    Public Gimp As Integer = 0
    Public KnockDown As Integer = 0
    Public LikeARock As Integer = 0
    'Wizard Talents
    Public Snowball As Integer = 0
    Public LightningBolt As Integer = 0
    Public Fireball As Integer = 0
    Public Surge As Integer = 0
    Public LifeSyphon As Integer = 0
    Public Migraine As Integer = 0
    Public SnowballR2 As Integer = 0
    Public LightningBoltR2 As Integer = 0
    Public FireballR2 As Integer = 0
    Public SurgeR2 As Integer = 0
    Public LifeSyphonR2 As Integer = 0
    Public MigraineR2 As Integer = 0
    Public HP As Integer = 0
    Public XP As Integer = 15
    Public TalentLableString As String
    Sub ClearTalentInfo()
        'Classless Abilities
        Sense = 0
        Detection = 0
        ScrollWriting = 0
        SenseR2 = 0
        DetectionR2 = 0
        ScrollWritingR2 = 0
        'Classless Skills
        Enchanting = 0
        Forestry = 0
        Leatherworking = 0
        Prowess = 0
        Smithing = 0
        EnchantingR2 = 0
        ForestryR2 = 0
        LeatherworkingR2 = 0
        ProwessR2 = 0
        SmithingR2 = 0
        'Dex
        DexT = 0
        Dex1B = 0
        Dex2B = 0
        Dex1A = 0
        Dex2A = 0
        Dex1H = 0
        Dex2H = 0
        Dex1P = 0
        Dex2P = 0
        DexE = 0
        DexBow = 0
        DexShield = 0
        DexDuel = 0
        'Class Talents
        BornAnew = 0
        Convert = 0
        Healing = 0
        Remedy = 0
        Potions = 0
        Charisma = 0
        Engineering = 0
        Imperius = 0
        Languages = 0
        Leadership = 0
        Deadeye = 0
        AHide = 0
        Iaijutsu = 0
        Traps = 0
        Tracking = 0
        Blind = 0
        Disguise = 0
        Expose = 0
        Vanish = 0
        Disease = 0
        Jump = 0
        Lifelink = 0
        ShroudofProtection = 0
        Silence = 0
        Void = 0
        CrushingBlow = 0
        Disarm = 0
        Gimp = 0
        KnockDown = 0
        LikeARock = 0
        Snowball = 0
        LightningBolt = 0
        Fireball = 0
        Surge = 0
        LifeSyphon = 0
        Migraine = 0
        SnowballR2 = 0
        LightningBoltR2 = 0
        FireballR2 = 0
        SurgeR2 = 0
        LifeSyphonR2 = 0
        MigraineR2 = 0
        HP = 0
        XP = 15
        TalentLableChange()
    End Sub
    Sub ClearWizardInfo()


    End Sub
    Sub TalentLableChange()
        TalentLableString = ""
        If Sense > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Sense & " Sense R1"
        End If
        If Detection > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Detection & "Detection R1"
        End If
        If ScrollWriting > 0 Then
            TalentLableString = TalentLableString & vbCrLf & ScrollWriting & "Scroll Writing R1"
        End If
        If SenseR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & SenseR2 & "Sense R2"
        End If
        If DetectionR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & DetectionR2 & "Detection R2"
        End If
        If ScrollWritingR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & ScrollWritingR2 & "Scroll Writing R2"
        End If
        If Enchanting > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Enchanting R1"
        End If
        If Leatherworking > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Leatherworking R1"
        End If
        If Forestry > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Forestry R1"
        End If
        If Prowess > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Prowess R1"
        End If
        If Smithing > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Smithing R1"
        End If
        If EnchantingR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Enchanting R2"
        End If
        If LeatherworkingR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Leatherworking R2"
        End If
        If ForestryR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Forestry R2"
        End If
        If ProwessR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Prowess R2"
        End If
        If SmithingR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Smithing R2"
        End If
        If Dex1A > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity 1 Handed Axe"
        End If
        If Dex2A > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity 2 Handed Axe"
        End If
        If Dex1H > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity 1 Handed Hammer"
        End If
        If Dex2H > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity 2 Handed Hammer"
        End If
        If DexBow > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity Bow"
        End If
        If Dex1P > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity 1 Handed Spear"
        End If
        If Dex2P > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity 2 Handed Spear"
        End If
        If Dex1B > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity 1 Handed Blades"
        End If
        If Dex2B > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity 2 Handed Blades"
        End If
        If DexT > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity Trowing"
        End If
        If DexE > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity Exotic"
        End If
        If DexShield > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity Shield"
        End If
        If DexDuel > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Weapon Dextarity Duelweilding"
        End If
        If BornAnew > 0 Then
            TalentLableString = TalentLableString & vbCrLf & BornAnew & "Born Anew R1"
        End If
        If Convert > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Convert & "Convert R1"
        End If
        If Healing > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Healing & "Healing R1"
        End If
        If Remedy > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Remedy & "Remedy R1"
        End If
        If Potions > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Potions R1"
        End If
        If Charisma > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Charisma & "Charisma R1"
        End If
        If Imperius > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Imperius R1"
        End If
        If Leadership > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Leadership R1"
        End If
        If Languages > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Languages R1"
        End If
        If Engineering > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Engineering R1"
        End If
        If Deadeye > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Deadeye & "Deadeye R1"
        End If
        If AHide > 0 Then
            TalentLableString = TalentLableString & vbCrLf & AHide & "Hide R1"
        End If
        If Iaijutsu > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Iaijutsu & "Iaijutsu R1"
        End If
        If Traps > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Traps & "Traps R1"
        End If
        If Tracking > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Tracking R1"
        End If
        If Blind > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Blind & "Blind R1"
        End If
        If Disguise > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Disguise & "Disguise R1"
        End If
        If Expose > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Expose & "Expose R1"
        End If
        If Vanish > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Vanish & "Vanish R1"
        End If
        If Disease > 0 Then
            TalentLableString = TalentLableString & vbCrLf & "Disease"
        End If
        If Void > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Void & "Void"
        End If
        If Jump > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Jump & "Jump R1"
        End If
        If Lifelink > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Lifelink & "Lifelink R1"
        End If
        If Silence > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Silence & "Silence R1"
        End If
        If ShroudofProtection > 0 Then
            TalentLableString = TalentLableString & vbCrLf & ShroudofProtection & "Shroud of Protection R1"
        End If
        If CrushingBlow > 0 Then
            TalentLableString = TalentLableString & vbCrLf & CrushingBlow & "Crushing Blow R1"
        End If
        If Gimp > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Gimp & "Gimp"
        End If
        If KnockDown > 0 Then
            TalentLableString = TalentLableString & vbCrLf & KnockDown & "Knock Down"
        End If
        If Disarm > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Disarm & "Disarm"
        End If
        If LikeARock > 0 Then
            TalentLableString = TalentLableString & vbCrLf & LikeARock & "Like A Rock"
        End If
        If Surge > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Surge & "Surge R1"
        End If
        If SurgeR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & SurgeR2 & "Surge R2"
        End If
        If LifeSyphon > 0 Then
            TalentLableString = TalentLableString & vbCrLf & LifeSyphon & "LifeSyphon R1"
        End If
        If LifeSyphonR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & LifeSyphonR2 & "LifeSyphon R2"
        End If
        If Migraine > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Migraine & "Migraine R1"
        End If
        If MigraineR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & MigraineR2 & "Migraine R2"
        End If
        If LightningBolt > 0 Then
            TalentLableString = TalentLableString & vbCrLf & LightningBolt & "LightningBolt R1"
        End If
        If LightningBoltR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & LightningBoltR2 & "LightningBolt R2"
        End If
        If Fireball > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Fireball & "Fireball R1"
        End If
        If FireballR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & FireballR2 & "Fireball R2"
        End If
        If Snowball > 0 Then
            TalentLableString = TalentLableString & vbCrLf & Snowball & "Snowball R1"
        End If
        If SnowballR2 > 0 Then
            TalentLableString = TalentLableString & vbCrLf & SnowballR2 & "Snowball R2"
        End If
        If HP > 0 Then
            TalentLableString = TalentLableString & vbCrLf & HP & "HP"
        End If
        Form1.LabelVoidknightXp.Text = "XP Left: " & XP
        Form1.LabelClericXp.Text = "XP Left: " & XP
        Form1.LabelNobleXp.Text = "XP Left: " & XP
        Form1.LabelRangerXp.Text = "XP Left: " & XP
        Form1.LabelRogueXp.Text = "XP Left: " & XP
        Form1.LabelVoidknightXp.Text = "XP Left: " & XP
        Form1.LabelWarriorXp.Text = "XP Left: " & XP
        Form1.LabelKinesiokairoXp.Text = "XP Left: " & XP
        Form1.LabelKinesiopyroXp.Text = "XP Left: " & XP
        Form1.LabelKinesioHydroXp.Text = "XP Left: " & XP
        Form1.LabelNecrohydroXp.Text = "XP Left: " & XP
        Form1.LabelNecrokairoXp.Text = "XP Left: " & XP
        Form1.LabelNecropyroXp.Text = "XP Left: " & XP
        Form1.LabelNeuroHydroXp.Text = "XP Left: " & XP
        Form1.LabelNeurokairoXp.Text = "XP Left: " & XP
        Form1.LabelNeuropyroXp.Text = "XP Left: " & XP
        Form1.LabelClericChosen.Text = TalentLableString
        Form1.LabelNobleChosen.Text = TalentLableString
        Form1.LabelRangerChosen.Text = TalentLableString
        Form1.LabelRogueChosen.Text = TalentLableString
        Form1.LabelVoidknightChosen.Text = TalentLableString
        Form1.LabelWarriorChosen.Text = TalentLableString
        Form1.LabelKinesiokairoChosen.Text = TalentLableString
        Form1.LabelKinesiopyroChosen.Text = TalentLableString
        Form1.LabelKinesioHydroChosen.Text = TalentLableString
        Form1.LabelNecrohydroChosen.Text = TalentLableString
        Form1.LabelNecrokairoChosen.Text = TalentLableString
        Form1.LabelNecropyroChosen.Text = TalentLableString
        Form1.LabelNeuroHydroChosen.Text = TalentLableString
        Form1.LabelNeurokairoChosen.Text = TalentLableString
        Form1.LabelNeuropyroChosen.Text = TalentLableString

    End Sub
End Module
