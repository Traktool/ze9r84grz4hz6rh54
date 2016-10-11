
Class Quest
    Public id As Integer = 0
    Public Name As String = ""
    Public Steps As New List(Of QuestStep)
    Public Questionrrep As New List(Of questionrep)
    Public NowStep As New QuestStep
    Public Conditions As String = ""


    Public Function GetStepByOrdre(ByVal Ordre As Integer) As QuestStep
        For Each S As QuestStep In Steps
            If S.Ordre = Ordre Then
                Return S
            End If
        Next
        Return Nothing
    End Function
End Class
