Public Class FormInfo
    Private Sub FormInfo_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.InfoFormLabel.MaximumSize = New Size(Me.Width - 25, 0)
    End Sub
End Class