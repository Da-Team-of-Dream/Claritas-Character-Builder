Module FunctionsList
    ' this function reads and outputs the requested text
    Function BuildInfoFormLabel(Item As String) As String
        Dim path As String = My.Application.Info.DirectoryPath
        Dim Reader As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(path & "\Character_Builder_Internal_Info.txt")
        Dim StringReader As String
        Dim OutputString As String = ""
        StringReader = Reader.ReadLine
        While StringReader IsNot "end"
            If StringReader = Item Then
                StringReader = Reader.ReadLine
                While StringReader IsNot Item
                    OutputString = OutputString & StringReader & vbCrLf
                    StringReader = Reader.ReadLine
                End While
            End If
            StringReader = Reader.ReadLine
        End While
        Reader.Close()
        Return OutputString
    End Function
    Sub ConstructInfoForm(Text As String)
        Dim InfoForm As New FormInfo()
        InfoForm.InfoFormLabel.Text = BuildInfoFormLabel(Text)
        InfoForm.Show()

    End Sub
End Module
