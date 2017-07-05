Module FunctionsList
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
                    OutputString = OutputString & StringReader
                    StringReader = Reader.ReadLine
                End While
            End If
            StringReader = Reader.ReadLine
        End While
        Reader.Close()
        Return OutputString
    End Function
End Module
