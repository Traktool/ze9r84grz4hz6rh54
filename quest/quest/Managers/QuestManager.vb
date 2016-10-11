Imports MySql.Data.MySqlClient

Class QuestManager
    Public Shared QuestListORG As New List(Of Quest)
    Public Shared QuestList As New List(Of Quest)
    Private Shared QuestStepList As New List(Of QuestStep)
    Private Shared QuestObjectifList As New List(Of QuestObjectif)
    Public Shared Function GetQuest(ByVal id As String) As Quest
        For Each Q As Quest In QuestManager.QuestListORG
            If Q.Name = id Then
                Return Q
            End If
        Next
        Return Nothing
    End Function
    Public Shared Sub LoadQuestObjectifs()
        '  MyConsole.StartLoading("Loading QuestObjectifs from database...")

        SyncLock Manager.AccountsSync

            Dim SQLText As String = "SELECT * FROM quest_objectifs"
            Dim SQLCommand As New MySqlCommand(SQLText, Manager.Accounts)
            Dim Result As MySqlDataReader = SQLCommand.ExecuteReader

            While Result.Read

                Dim NewQO As New QuestObjectif

                NewQO.id = Result("id")
                NewQO.type = Result("type")

                NewQO.arguments = Result("arguments")
                'If NewQO.type = QuestObjectifType.Découvrir_la_carte Then
                '    MapsHandler.ListMapsFromQuest.Add(NewQO.arguments)
                'End If
                NewQO.IsInvisble = Result("isInvisible")

                QuestObjectifList.Add(NewQO)


            End While

            Result.Close()

        End SyncLock

        '  MyConsole.StopLoading()
        '  MyConsole.Status("'@" & QuestObjectifList.Count & "@' QuestObjectifs loaded from database")
    End Sub



    Public Shared Sub LoadQuestSteps()
        ' MyConsole.StartLoading("Loading QuestSteps from database...")

        SyncLock Manager.AccountsSync

            Dim SQLText As String = "SELECT * FROM quest_steps"
            Dim SQLCommand As New MySqlCommand(SQLText, Manager.Accounts)
            Dim Result As MySqlDataReader = SQLCommand.ExecuteReader

            While Result.Read

                Dim NewQS As New QuestStep

                NewQS.id = Result("id")
                Dim t As String = Result("objectifs")
                Dim t2 As String() = t.Split("|")
                For i As Integer = 0 To t2.Length - 1
                    Dim QObj As New QuestObjectif
                    QObj.Ordre = NewQS.Objectifs.Count
                    QObj = (GetObjectif(t2(i)))
                    '   CloneObject.clone(QObj) = QObj
                    NewQS.Objectifs.Add(QObj)
                Next
                If Not Result("gainobjet") Is Nothing Then
                    Dim d As String = Result("gainobjet")
                    Dim d2 As String() = d.Split(";")
                    For i As Integer = 0 To d2.Length - 1
                        NewQS.GainObjects.Add(d2(i))
                    Next
                End If
                If Not Result("gainkamas") Is Nothing Then
                    NewQS.GainKamas = Result("gainkamas")
                Else
                    NewQS.GainKamas = 0
                End If

                If Not Result("gainxp") Is Nothing Then
                    NewQS.GainXp = Result("gainxp")
                Else
                    NewQS.GainXp = 0
                End If

                NewQS.Dialogue = Result("dialogue")
                NewQS.All = Result("all")
                QuestStepList.Add(NewQS)


            End While

            Result.Close()

        End SyncLock

        '  MyConsole.StopLoading()
        '  MyConsole.Status("'@" & QuestStepList.Count & "@' QuestSteps loaded from database")
    End Sub

    Public Shared Function GetObjectif(ByVal id As Integer) As QuestObjectif
        For Each QO As QuestObjectif In QuestObjectifList
            If QO.id = id Then
                Return QO
            End If
        Next
        Return Nothing
    End Function
    Public Shared Sub LoadQuests()

        ' MyConsole.StartLoading("Loading Quests from database...")

        SyncLock Manager.AccountsSync

            Dim SQLText As String = "SELECT * FROM quests"
            Dim SQLCommand As New MySqlCommand(SQLText, Manager.Accounts)

            Dim Result As MySqlDataReader = SQLCommand.ExecuteReader

            While Result.Read

                Dim NewQ As New Quest

                NewQ.id = Result("id")
                NewQ.Name = Result("name")
                Dim t As String = Result("steps")
                Dim t2 As String() = t.Split(";")
                For i As Integer = 0 To t2.Length - 1
                    Dim Qstep As New QuestStep
                    Qstep = (GetQStep(t2(i)))
                    Qstep.Ordre = NewQ.Steps.Count
                    ' CloneObject.clone = Qstep
                    ' Dim e As CloneObject = New CloneObject()
                    ' Set property.
                    '  CloneObject.clone(Qstep) = Qstep

                    NewQ.Steps.Add(Qstep)
                Next
                If NewQ.Steps.Count > 0 Then
                    NewQ.NowStep = NewQ.GetStepByOrdre(0)
                End If
                NewQ.Conditions = Result("conditions")
                '  CloneObject.clone(NewQ) = NewQ
                QuestList.Add(NewQ)
                QuestListORG.Add(NewQ)
                frmHome.lstQuest.Items.Add(NewQ.Name)
            End While

            Result.Close()

        End SyncLock

        '  MyConsole.StopLoading()
        ' MyConsole.Status("'@" & QuestList.Count & "@' Quests loaded from database")
    End Sub

    Public Shared Function GetQStep(ByVal id As Integer) As QuestStep
        For Each QS As QuestStep In QuestStepList
            If QS.id = id Then
                Return QS
            End If
        Next
        Return Nothing
    End Function



    Shared Sub syncro(testr As Quest, test1 As Integer)

        Dim NewQS As New QuestStep

        NewQS.id = test1
        testr.Steps.Add(NewQS)
        QuestStepList.Add(NewQS)
    End Sub


    Shared Sub syncrou(test As Quest, p2 As String, teststep As QuestStep)
        Dim NewQO As New QuestObjectif

        NewQO.id = p2


        QuestObjectifList.Add(NewQO)
        ' Dim tetet As QuestStep = GetQStep()

        teststep.Objectifs.Add(NewQO)
        ' QuestStepList.Add(NewQS)
    End Sub

    Shared Sub syncroy(p1 As String)

        Dim NewQ As New Quest

        NewQ.id = p1
        NewQ.Name = p1
        QuestList.Add(NewQ)
        QuestListORG.Add(NewQ)
        frmHome.lstQuest.Items.Add(NewQ.Name)
    End Sub

    Shared Sub upStepAction(quest As Quest, questStep As QuestStep)
        '  Remonter l'étape de quête d'un index
        Dim tempIndex = quest.Steps.IndexOf(questStep) ' select index id actuel
        If tempIndex <> 0 Then ' if tempIndex others 0
            quest.Steps.Remove(questStep)
            quest.Steps.Insert(tempIndex - 1, questStep)
        End If
        '    frmHome.lstQuest.SelectedIndex = frmHome.lstQuest.SelectedIndex
        frmHome.lstQuest.SelectedIndex = frmHome.lstQuest.SelectedIndex - 1
        frmHome.lstQuest.SelectedIndex = frmHome.lstQuest.SelectedIndex + 1
    End Sub

    Shared Sub fefe(testi As Quest, test As QuestStep, testpp As QuestObjectif)
        Dim tempIndex = test.Objectifs.IndexOf(testpp) ' select index id actuel
        If tempIndex <> 0 Then ' if tempIndex others 0
            test.Objectifs.Remove(testpp)
            test.Objectifs.Insert(tempIndex - 1, testpp)
        End If
        '    frmHome.lstQuest.SelectedIndex = frmHome.lstQuest.SelectedIndex
        frmHome.lstQuestStep.SelectedIndex = frmHome.lstQuestStep.SelectedIndex - 1
        frmHome.lstQuestStep.SelectedIndex = frmHome.lstQuestStep.SelectedIndex + 1
        ' test.Objectifs.Remove(testpp)
        '.Objectifs.Insert(0, testpp)
    End Sub

End Class
