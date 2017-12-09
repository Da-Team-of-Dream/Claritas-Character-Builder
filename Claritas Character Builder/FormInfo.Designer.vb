<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInfo))
        Me.InfoFormLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InfoFormLabel
        '
        Me.InfoFormLabel.AutoSize = True
        Me.InfoFormLabel.BackColor = System.Drawing.Color.Transparent
        Me.InfoFormLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.InfoFormLabel.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoFormLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.InfoFormLabel.Location = New System.Drawing.Point(0, 0)
        Me.InfoFormLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InfoFormLabel.MaximumSize = New System.Drawing.Size(720, 0)
        Me.InfoFormLabel.Name = "InfoFormLabel"
        Me.InfoFormLabel.Padding = New System.Windows.Forms.Padding(27, 25, 0, 0)
        Me.InfoFormLabel.Size = New System.Drawing.Size(110, 60)
        Me.InfoFormLabel.TabIndex = 0
        Me.InfoFormLabel.Text = "Label1"
        '
        'FormInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(732, 362)
        Me.Controls.Add(Me.InfoFormLabel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormInfo"
        Me.Text = "FormInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InfoFormLabel As Label
End Class
