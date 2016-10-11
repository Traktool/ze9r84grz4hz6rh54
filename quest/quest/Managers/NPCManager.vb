Imports MySql.Data.MySqlClient

Public Class NpcDialog

    Private Dialog As QuestionNPC
    Private Response As ResponseNPC

    Public Shared ListOfQuestion As New List(Of QuestionNPC)
    Public Shared ListOfResponse As New List(Of ResponseNPC)

    Public Shared Sub LoadQuestion()
        ListOfQuestion.Clear()
        ListOfResponse.Clear()
        '  MyConsole.StartLoading("Loading question from database...")
        SyncLock Manager.AccountsSync

            Dim SQLText As String = "SELECT * FROM npc_question"

            Dim SQLCommand As New MySqlCommand(SQLText, Manager.Accounts)

            Dim Result As MySqlDataReader = SQLCommand.ExecuteReader

            While Result.Read

                Dim NewQuestion As New QuestionNPC

                NewQuestion.NpcID = Result("npcid")





                'Dim eq As String = Result("questionid")

                'If eq <> "" Then
                '    Dim SpellsSplit() As String = eq.Split("~")
                '    For i As Integer = 0 To SpellsSplit.Length - 1
                '        '   Dim SpellSplit() As String = SpellsSplit(i).Split(",")
                '        '  c.Spells.AddSpell(SpellSplit(0), SpellSplit(1), SpellSplit(2))
                '        NewQuestion.QuestionID.Add(SpellsSplit(i))
                '    Next
                'End If

                'Dim eR As String = Result("responses")

                'If eR <> "" Then
                '    Dim SpellsSplit() As String = eR.Split("~")

                '    For i As Integer = 0 To SpellsSplit.Length - 1
                '        NewQuestion.QuestionID.Add(SpellsSplit(i))
                '    Next

                'End If


                NewQuestion.QuestionID = Result("questionid")



                NewQuestion.ResponsesPossible = Result("responses")
                NewQuestion.Cond = Result("cond")


                NewQuestion.Q = Result("q")








                ListOfQuestion.Add(NewQuestion)

            End While

            Result.Close()

        End SyncLock

        ' MyConsole.StopLoading()
        ' MyConsole.Status("'@" & ListOfQuestion.Count & "@' question loaded from database")
    End Sub

    Public Shared Sub LoadResponse()

        '  MyConsole.StartLoading("Loading response from database...")
        SyncLock Manager.AccountsSync

            Dim SQLText As String = "SELECT * FROM npc_response"
            Dim SQLCommand As New MySqlCommand(SQLText, Manager.Accounts)

            Dim Result As MySqlDataReader = SQLCommand.ExecuteReader

            While Result.Read

                Dim NewResponse As New ResponseNPC

                NewResponse.ResponseID = Result("responseid")
                NewResponse.Type = Result("type")
                NewResponse.Args = Result("args")
                '   NewResponse.Q = Result("q")
                ListOfResponse.Add(NewResponse)

            End While

            Result.Close()

        End SyncLock

        '  MyConsole.StopLoading()
        '  MyConsole.Status("'@" & ListOfResponse.Count & "@' response loaded from database")
    End Sub
End Class
