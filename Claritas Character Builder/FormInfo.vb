Public Class FormInfo
    Private Sub FormInfo_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.VScroll = True Then
            Me.InfoFormLabel.Size = New System.Drawing.Size(Me.Width - 20, Me.Height)
        Else
            Me.InfoFormLabel.Size = New System.Drawing.Size(Me.Width, Me.Height)
        End If
    End Sub
End Class