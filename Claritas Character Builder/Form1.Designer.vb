<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.welcome = New System.Windows.Forms.Panel()
        Me.LabelWelcomeFoot = New System.Windows.Forms.Label()
        Me.LabelWelcomePlayerage = New System.Windows.Forms.Label()
        Me.LabelWelcomePlayername = New System.Windows.Forms.Label()
        Me.TextboxWelcomePlayerage = New System.Windows.Forms.TextBox()
        Me.TextboxWelcomePlayername = New System.Windows.Forms.TextBox()
        Me.ButtonWelcomeKin = New System.Windows.Forms.Button()
        Me.LabelWelcomeHeading = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.welcome.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'welcome
        '
        Me.welcome.Controls.Add(Me.LabelWelcomeFoot)
        Me.welcome.Controls.Add(Me.LabelWelcomePlayerage)
        Me.welcome.Controls.Add(Me.LabelWelcomePlayername)
        Me.welcome.Controls.Add(Me.TextboxWelcomePlayerage)
        Me.welcome.Controls.Add(Me.TextboxWelcomePlayername)
        Me.welcome.Controls.Add(Me.ButtonWelcomeKin)
        Me.welcome.Controls.Add(Me.LabelWelcomeHeading)
        Me.welcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.welcome.Location = New System.Drawing.Point(0, 0)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(479, 261)
        Me.welcome.TabIndex = 1
        '
        'LabelWelcomeFoot
        '
        Me.LabelWelcomeFoot.Location = New System.Drawing.Point(15, 138)
        Me.LabelWelcomeFoot.Name = "LabelWelcomeFoot"
        Me.LabelWelcomeFoot.Size = New System.Drawing.Size(452, 49)
        Me.LabelWelcomeFoot.TabIndex = 6
        Me.LabelWelcomeFoot.Text = "Your character's name and age are the last thing you'll fill in, but start thinki" &
    "ng about them now!"
        '
        'LabelWelcomePlayerage
        '
        Me.LabelWelcomePlayerage.Location = New System.Drawing.Point(260, 73)
        Me.LabelWelcomePlayerage.Name = "LabelWelcomePlayerage"
        Me.LabelWelcomePlayerage.Size = New System.Drawing.Size(66, 23)
        Me.LabelWelcomePlayerage.TabIndex = 5
        Me.LabelWelcomePlayerage.Text = "Your Age"
        Me.LabelWelcomePlayerage.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelWelcomePlayername
        '
        Me.LabelWelcomePlayername.Location = New System.Drawing.Point(24, 73)
        Me.LabelWelcomePlayername.Name = "LabelWelcomePlayername"
        Me.LabelWelcomePlayername.Size = New System.Drawing.Size(70, 20)
        Me.LabelWelcomePlayername.TabIndex = 4
        Me.LabelWelcomePlayername.Text = "Your Name"
        Me.LabelWelcomePlayername.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextboxWelcomePlayerage
        '
        Me.TextboxWelcomePlayerage.Location = New System.Drawing.Point(332, 70)
        Me.TextboxWelcomePlayerage.Name = "TextboxWelcomePlayerage"
        Me.TextboxWelcomePlayerage.Size = New System.Drawing.Size(100, 20)
        Me.TextboxWelcomePlayerage.TabIndex = 3
        '
        'TextboxWelcomePlayername
        '
        Me.TextboxWelcomePlayername.Location = New System.Drawing.Point(100, 70)
        Me.TextboxWelcomePlayername.Name = "TextboxWelcomePlayername"
        Me.TextboxWelcomePlayername.Size = New System.Drawing.Size(100, 20)
        Me.TextboxWelcomePlayername.TabIndex = 2
        '
        'ButtonWelcomeKin
        '
        Me.ButtonWelcomeKin.Location = New System.Drawing.Point(392, 226)
        Me.ButtonWelcomeKin.Name = "ButtonWelcomeKin"
        Me.ButtonWelcomeKin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonWelcomeKin.TabIndex = 1
        Me.ButtonWelcomeKin.Text = "Next"
        Me.ButtonWelcomeKin.UseVisualStyleBackColor = True
        '
        'LabelWelcomeHeading
        '
        Me.LabelWelcomeHeading.Location = New System.Drawing.Point(12, 9)
        Me.LabelWelcomeHeading.Name = "LabelWelcomeHeading"
        Me.LabelWelcomeHeading.Size = New System.Drawing.Size(455, 51)
        Me.LabelWelcomeHeading.TabIndex = 0
        Me.LabelWelcomeHeading.Text = "Welcome to Claritas character creatior! To get started fill in the blanks and cli" &
    "ck next. Remeber you can always  go back to any page."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(479, 261)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "panel2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 261)
        Me.Controls.Add(Me.welcome)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.welcome.ResumeLayout(False)
        Me.welcome.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents welcome As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonWelcomeKin As Button
    Friend WithEvents LabelWelcomeHeading As Label
    Friend WithEvents LabelWelcomePlayerage As Label
    Friend WithEvents LabelWelcomePlayername As Label
    Friend WithEvents TextboxWelcomePlayerage As TextBox
    Friend WithEvents TextboxWelcomePlayername As TextBox
    Friend WithEvents LabelWelcomeFoot As Label
End Class
