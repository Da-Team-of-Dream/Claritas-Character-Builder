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
    'this procedure builds an instance of the info form
    Sub ConstructInfoForm(Text As String)
        Dim InfoForm As New FormInfo()
        InfoForm.InfoFormLabel.Text = BuildInfoFormLabel(Text)
        InfoForm.Show()
    End Sub
End Module
