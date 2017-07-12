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
        Me.InfoFormLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InfoFormLabel
        '
        Me.InfoFormLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoFormLabel.Location = New System.Drawing.Point(0, 0)
        Me.InfoFormLabel.Name = "InfoFormLabel"
        Me.InfoFormLabel.Size = New System.Drawing.Size(278, 294)
        Me.InfoFormLabel.TabIndex = 0
        Me.InfoFormLabel.Text = "Label1"
        '
        'FormInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(278, 294)
        Me.Controls.Add(Me.InfoFormLabel)
        Me.Name = "FormInfo"
        Me.Text = "FormInfo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InfoFormLabel As Label
End Class
