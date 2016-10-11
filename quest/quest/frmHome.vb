Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class frmHome

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.OpenConnexion() 'Connexion Sql

        QuestManager.LoadQuestObjectifs() 'Quetes
        QuestManager.LoadQuestSteps() 'Quetes
        QuestManager.LoadQuests() 'Quetes

        NpcDialog.LoadQuestion()
        NpcDialog.LoadResponse()
       
        GroupBox5.Enabled = False
        GroupBox4.Enabled = False

       




    End Sub
    Public Shared Function rep(ByVal ResponseID As Integer) As ResponseNPC
        For Each MyResponse As ResponseNPC In NpcDialog.ListOfResponse
            If ResponseID = MyResponse.ResponseID Then
                Return MyResponse
            End If
        Next
        Return Nothing
    End Function
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstQuest.SelectedIndexChanged
        If lstQuest.SelectedItem <> Nothing Then

            GroupBox5.Enabled = False
              GroupBox4.Enabled = False

            lstQuestStep.Items.Clear()
            lvwStepItems.Items.Clear()
            ListBox4.Items.Clear()
            '  ListBox5.Items.Clear()
            TextBox15.Text = ""
            TextBox16.Text = ""
            TextBox17.Text = ""
            ComboBox2.Items.Clear()
            txtStepId.Text = ""
            Label15.Text = ""
            ' TextBox5.Text = test.id
            '  TextBox6.Text = test.GainObjects
            txtQuestStepObjID.Text = ""
            txtQuestStepObjType.Text = ""
            txtQuestStepObjArgs.Text = ""
            txtQuestStepObjVisible.Text = ""
            txtStepGainKamas.Text = ""
            txtStepGainXp.Text = ""
            txtStepDialog.Text = ""
            txtStepAll.Text = ""
            lstQuestObj.Items.Clear()
            Dim objQuest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
            Dim objQuestQuestionandRep As QuestionNPC = question(objQuest.id)
            '  Dim liste
            If objQuest.Questionrrep.Count = 0 Then
                If Not objQuestQuestionandRep Is Nothing Then

                    Dim strSplitQuestQuestion() As String = objQuestQuestionandRep.QuestionID.Split("~")
                    Dim strSplitQuestReponse() As String = objQuestQuestionandRep.ResponsesPossible.Split("~")
                    Dim strSplitQuestCondition() As String = objQuestQuestionandRep.Cond.Split("~")
                    ' If SpellsSplitMultiarg.Count >= 1 Then
                    For k As Integer = 0 To strSplitQuestQuestion.Count - 1
                        Dim NewQuestionAndRep As New questionrep
                        NewQuestionAndRep.Question = strSplitQuestQuestion(k)
                        ListBox4.Items.Add(strSplitQuestQuestion(k))
                        NewQuestionAndRep.rep = strSplitQuestReponse(k)
                        NewQuestionAndRep.Cond = strSplitQuestCondition(k)
                        objQuest.Questionrrep.Add(NewQuestionAndRep)

                        '   Debug.WriteLine(test.Questionrrep)
                        'Debug.WriteLine(SpellsSplitMultiargzaaaaaaaaaa(k))
                        'Debug.WriteLine(SpellsSplitMultiargzaaaaaaaaaabbbbb(k))
                        'Debug.WriteLine(SpellsSplitMultiargzaaaaaaaaaabbbbbcccccccccc(k))
                    Next
                End If
            Else
                '     If Not objQuestQuestionandRep Is Nothing Then

                '      Dim strSplitQuestQuestion() As String = objQuestQuestionandRep.QuestionID.Split("~")
                '     Dim strSplitQuestReponse() As String = objQuestQuestionandRep.ResponsesPossible.Split("~")
                '     Dim strSplitQuestCondition() As String = objQuestQuestionandRep.Cond.Split("~")
                ' If SpellsSplitMultiarg.Count >= 1 Then
                For k As Integer = 0 To objQuest.Questionrrep.Count - 1
                    '    Dim NewQuestionAndRep As New questionrep
                    '    NewQuestionAndRep.Question = strSplitQuestQuestion(k)
                    ListBox4.Items.Add(objQuest.Questionrrep(k).Question)
                    '   NewQuestionAndRep.rep = strSplitQuestReponse(k)
                    '    NewQuestionAndRep.Cond = strSplitQuestCondition(k)
                    '    objQuest.Questionrrep.Add(NewQuestionAndRep)

                    '   Debug.WriteLine(test.Questionrrep)
                    'Debug.WriteLine(SpellsSplitMultiargzaaaaaaaaaa(k))
                    'Debug.WriteLine(SpellsSplitMultiargzaaaaaaaaaabbbbb(k))
                    'Debug.WriteLine(SpellsSplitMultiargzaaaaaaaaaabbbbbcccccccccc(k))
                Next
                '   End If
            End If   'If Not objQuestQuestionandRep Is Nothing Then
            '    Dim SpellsSplit() As String = objQuestQuestionandRep.QuestionID.Split("~")
            '    For Each S In SpellsSplit
            '        ListBox4.Items.Add(S)

            '    Next
            '    Dim SpellsSpliti() As String = objQuestQuestionandRep.ResponsesPossible.Split("~")
            '    For Each S In SpellsSpliti
            '        '   ListBox5.Items.Add(S)
            '        Dim SpellsSplitii() As String = S.Split(";")
            '        For Each Se In SpellsSplitii
            '            ' ListBox6.Items.Add(Se)
            '            ComboBox2.Items.Add(Se)
            '        Next
            '    Next
            '    ComboBox2.SelectedIndex = 1
            'End If

            txtQuestName.Text = objQuest.Name
            txtQuestID.Text = objQuest.id
            txtQuestCond.Text = objQuest.Conditions
            For Each S As QuestStep In objQuest.Steps
                'If S.Ordre = Ordre Then
                '    Return S
                lstQuestStep.Items.Add(S.id)
                'End If
            Next
            ' Return Nothing
        End If

        ' infosques(525)
    End Sub
    Public Sub infosques(ByVal CharacterName As Integer, Optional ByVal types As String = "")
        '  MyConsole.StartLoading("Loading QuestObjectifs from database...")
        RichTextBox2.Clear()
        Dim Result As MySqlDataReader = Nothing
        '   Dim SQLText As String = "DELETE FROM player_characters WHERE id=@CharacterName"
        SyncLock sql.AccountsSync
            Dim SQLText As String
            If types <> "" Then
                SQLText = "SELECT * FROM questsinfos Where ID=@CharacterName and Types=@type"

            Else
                SQLText = "SELECT * FROM questsinfos Where ID=@CharacterName"

            End If
            '  MyConsole.StartLoading("Loading QuestObjectifs from database...")

            Dim SQLCommand As New MySqlCommand(SQLText, sql.Accounts)
            '    Dim Result As MySqlDataReader = SQLCommand.ExecuteReader
            SQLCommand.Parameters.Add(New MySqlParameter("@CharacterName", CharacterName))
            If types <> "" Then
                SQLCommand.Parameters.Add(New MySqlParameter("@type", types))
            Else

            End If

            Result = SQLCommand.ExecuteReader
            While Result.Read

                RichTextBox2.AppendText("ID:" & Result("ID") & vbCrLf & "   Types:" & Result("Types") & vbCrLf & "      Text:" & Result("Text") & vbCrLf & vbCrLf)

            End While

            Result.Close()

        End SyncLock

        '  MyConsole.StopLoading()
        '  MyConsole.Status("'@" & QuestObjectifList.Count & "@' QuestObjectifs loaded from database")
    End Sub

    Public Shared Function GetPersoQuestIDINFO(ByVal id As String)
        Dim i As Integer
        For i = 0 To QuestManager.QuestList.Count - 1
            If QuestManager.QuestList(i).Name = id Then
                Return i
            End If

        Next i
        'For Each Q As Quest In QuestList
        '    If Q.id = id Then
        '        Return Q
        '    End If
        'Next
        Return Nothing
    End Function

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstQuestStep.SelectedIndexChanged
        If lstQuestStep.SelectedItem <> Nothing Then
            '    txtStepId.Enabled = True

            GroupBox4.Enabled = False
            GroupBox5.Enabled = True
            lstQuestObj.Items.Clear()
            txtQuestStepObjID.Text = ""
            Label15.Text = ""
            txtQuestStepObjType.Text = ""
            txtQuestStepObjArgs.Text = ""
            txtQuestStepObjVisible.Text = ""
            lvwStepItems.Items.Clear()
            Dim test As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
            txtStepId.Text = test.id
            ' TextBox5.Text = test.id
            '  TextBox6.Text = test.GainObjects
            txtStepGainKamas.Text = test.GainKamas
            txtStepGainXp.Text = test.GainXp
            txtStepDialog.Text = test.Dialogue
            txtStepAll.Text = test.All
            '   If test.GainObjects.Count > 0 Then

            lvwStepItems.Items.Clear()
            For Each liededene As String In test.GainObjects
                '  Dim obj = objet(liededene)
                If liededene <> "0" Then
                    Dim SpellsSplit() As String = liededene.Split(",")
                    '    If SpellsSplit(1) = Nothing Then
                    If SpellsSplit.Count = 1 Then
                        'Dim NewItem As Item = ItemsHandler.GetItemTemplate(S).GenerateItem(1)
                        'Client.Character.Items.AddItem(Client, NewItem)
                        ''   Im021;2~6897
                        Dim ActualItem As ListViewItem = lvwStepItems.Items.Add(SpellsSplit(0))
                        ActualItem.SubItems.Add(objet(SpellsSplit(0)))
                        ActualItem.SubItems.Add(1)
                        'Client.Send("Im021;1" & "~" & S)
                    Else
                        Dim ActualItem As ListViewItem = lvwStepItems.Items.Add(SpellsSplit(0))
                        ActualItem.SubItems.Add(objet(SpellsSplit(0)))
                        ActualItem.SubItems.Add(SpellsSplit(1))
                        'Dim NewItem As Item = ItemsHandler.GetItemTemplate(SpellsSplit(0)).GenerateItem(SpellsSplit(1))
                        'Client.Character.Items.AddItem(Client, NewItem)
                        ''  Client.SendNormalMessage("vous avez recu : " & ItemsHandler.GetItemTemplate(SpellsSplit(0)).Name)
                        'Client.Send("Im021;" & SpellsSplit(1) & "~" & SpellsSplit(0))
                    End If
                End If
            Next
            ' End If
            lstQuestObj.Items.Clear()
            For Each S As QuestObjectif In test.Objectifs

                'If S.Ordre = Ordre Then
                '    Return S
                lstQuestObj.Items.Add(S.id)
                'End If
            Next
        End If
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstQuestObj.SelectedIndexChanged
        If lstQuestObj.SelectedItem <> Nothing Then
            RichTextBox2.Clear()
            GroupBox4.Enabled = True
            Dim testftf As QuestObjectif = QuestManager.GetObjectif(lstQuestObj.SelectedItem.ToString)
            '  For Each S As QuestObjectif In test.Objectifs

            txtQuestStepObjID.Text = testftf.id
            txtQuestStepObjType.Text = testftf.type
            txtQuestStepObjArgs.Text = testftf.arguments
            ComboBox1.SelectedIndex = testftf.type
            Select Case testftf.type
                Case 3
                    Dim base = "Ramener à #1 : x#3 #2"
                    Dim s1 As String() = testftf.arguments.Split(",")
                    Dim iditem As Integer = s1(0)
                    Dim nbrefois As Integer = s1(1)
                    base = base.Replace("#1", "PNJ")
                    base = base.Replace("#2", objet(s1(0)) & " [" & s1(0) & "]")
                    base = base.Replace("#3", (s1(1)))
                    Label15.Text = base
                Case 4
                    Dim base = "Découvrir la carte #1"

                    base = base.Replace("#1", testftf.arguments)

                    Label15.Text = base
            End Select
            txtQuestStepObjVisible.Text = testftf.IsInvisble
            'If S.Ordre = Ordre Then
            '    Return S
            '  ListBox3.Items.Add(S.id)
            'End If
            ' Next
            infosques(lstQuestObj.SelectedItem.ToString, "o")
        End If
    End Sub

    Private Sub npcs(ByVal CharacterName As Integer)
        Dim Result As MySqlDataReader = Nothing
        '   Dim SQLText As String = "DELETE FROM player_characters WHERE id=@CharacterName"
        SyncLock sql.AccountsSync
            Dim SQLText As String

            SQLText = "SELECT * FROM questsinfos Where ID=@CharacterName"

            '  MyConsole.StartLoading("Loading QuestObjectifs from database...")

            Dim SQLCommand As New MySqlCommand(SQLText, sql.Accounts)
            '    Dim Result As MySqlDataReader = SQLCommand.ExecuteReader
            SQLCommand.Parameters.Add(New MySqlParameter("@CharacterName", CharacterName))

            Result = SQLCommand.ExecuteReader
            While Result.Read

                RichTextBox2.AppendText("ID:" & Result("ID") & vbCrLf & "   Types:" & Result("Types") & vbCrLf & "      Text:" & Result("Text") & vbCrLf & vbCrLf)

            End While

            Result.Close()

        End SyncLock
    End Sub

    Private Function objet(ByVal CharacterName As Integer)

        '   Dim SQLText As String = "DELETE FROM player_characters WHERE id=@CharacterName"
        SyncLock sql.AccountsSync
            Dim SqlInfos
            Dim Result As MySqlDataReader = Nothing
            Dim SQLText As String

            SQLText = "SELECT * FROM items_data Where ID=@CharacterName"

            '  MyConsole.StartLoading("Loading QuestObjectifs from database...")

            Dim SQLCommand As New MySqlCommand(SQLText, sql.Accounts)
            '    Dim Result As MySqlDataReader = SQLCommand.ExecuteReader
            SQLCommand.Parameters.Add(New MySqlParameter("@CharacterName", CharacterName))

            Result = SQLCommand.ExecuteReader
            While Result.Read

                '  RichTextBox2.AppendText("ID:" & Result("ID") & vbCrLf & "   Types:" & Result("Name") & vbCrLf)

                SqlInfos = Result("Name")

            End While

            Result.Close()
            Return SqlInfos
        End SyncLock
    End Function

    Private Sub TextBox13_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

        Dim cmd As New MySqlCommand("Select Name,ID FROM items_data", sql.Accounts)

        '   Dim cmd As New SqlCommand("Select Name FROM items_data", sql.Accounts)
        ' If con.State = ConnectionState.Closed Then sql.Accounts.Open()
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(ds, "Autofill")

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Name").ToString() & " [" & ds.Tables(0).Rows(i)("ID").ToString() & "]")

        Next
        TextBox13.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox13.AutoCompleteCustomSource = col

        TextBox13.AutoCompleteMode = AutoCompleteMode.Suggest
        If TextBox13.Text.Contains("[") Then
            Dim t2 As String() = TextBox13.Text.Split("[")

            Label22.Text = t2(1).Substring(0, t2(1).Length - 1)
        End If

    End Sub

    Public Function question(ByVal PnjID As Integer)
        For Each MyQuestion As QuestionNPC In NpcDialog.ListOfQuestion
            If MyQuestion.Q = PnjID Then
                'Dim SpellsSplit() As String = MyQuestion.Split("~")
                'For i As Integer = 0 To SpellsSplit.Length - 1
                '    '        '   Dim SpellSplit() As String = SpellsSplit(i).Split(",")
                '    '        '  c.Spells.AddSpell(SpellSplit(0), SpellSplit(1), SpellSplit(2))
                '    '        NewQuestion.QuestionID.Add(SpellsSplit(i))
                'Next
                'End If
                Return MyQuestion
            End If
        Next
        Return Nothing
    End Function

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        If ListBox4.SelectedItem <> Nothing Then
            '     ListBox5.SelectedItem =
            infosques(ListBox4.SelectedItem.ToString, "o")
            Dim QInfo As questionrep = GetQuestion(ListBox4.SelectedItem.ToString)
            TextBox1.Text = QInfo.rep

            ComboBox2.Items.Clear()
            Dim strSplitAllReponse() As String = QInfo.rep.Split(";")
            For Each Se In strSplitAllReponse
                '            ' ListBox6.Items.Add(Se)
                ComboBox2.Items.Add((Se))
                '            ComboBox2.Items.Add(Se)
            Next
            RichTextBox5.Clear()
            RichTextBox5.AppendText("Condition :" & vbCrLf & DecrypteAndCrypte(QInfo.Cond, "d") & vbCrLf)
            ' RichTextBox4.AppendText("       " & testefe(S, "q") & vbCrLf)
            TextBox2.Text = QInfo.Cond
            '        Next
            '    Next
            ComboBox2.SelectedIndex = 0
            '  ListBox5.SelectedIndex = ListBox4.SelectedIndex
            '    Dim test = rep(ListBox6.SelectedItem.ToString)
        End If
    End Sub
    Public Function GetQuestion(ByVal id As String) As questionrep
        Dim objQuest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
        For Each Q As questionrep In objQuest.Questionrrep
            If Q.Question = id Then
                Return Q
            End If
        Next
        Return Nothing
    End Function
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem.ToString <> "0" Then

            Dim test = rep(ComboBox2.SelectedItem.ToString)
            If Not test Is Nothing Then
                TextBox17.Text = test.ResponseID
                TextBox16.Text = test.Type
                TextBox15.Text = test.Args
                ' TextBox14.Text = test.ResponseID

                'Dim SpellsSpliti() As String = teszt.ResponsesPossible.Split("~")
                'For Each S In SpellsSpliti
                '    ListBox5.Items.Add(S)

                '    'Next

            End If
        End If

    End Sub

    'Move up
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Make sure our item is not the first one on the list.
        If ListBox4.SelectedIndex > 0 Then
            Dim I = ListBox4.SelectedIndex - 1
            ' ListBox5.Items.Insert(I, ListBox5.SelectedItem = ListBox4.SelectedIndex - 1)
            'ListBox5.Items.RemoveAt(ListBox5.SelectedIndex = ListBox4.SelectedIndex - 1)
            '  ListBox5.SelectedIndex = I
            ListBox4.Items.Insert(I, ListBox4.SelectedItem)
            ' ListBox5.Items.Insert(I, ListBox5.SelectedItem)
            ListBox4.Items.RemoveAt(ListBox4.SelectedIndex)
            ' ListBox5.Items.RemoveAt(ListBox5.SelectedIndex)

            ListBox4.SelectedIndex = I
            '  ListBox5.SelectedIndex = I
        End If
    End Sub

    'Move down
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Make sure our item is not the last one on the list.
        If ListBox4.SelectedIndex < ListBox4.Items.Count - 1 Then
            'Insert places items above the index you supply, since we want
            'to move it down the list we have to do + 2
            Dim I = ListBox4.SelectedIndex + 2
            ListBox4.Items.Insert(I, ListBox4.SelectedItem)
            'ListBox5.Items.Insert(I, ListBox5.SelectedItem)
            ListBox4.Items.RemoveAt(ListBox4.SelectedIndex)
            ' ListBox5.Items.RemoveAt(ListBox5.SelectedIndex)
            ListBox4.SelectedIndex = I - 1

            ' ListBox5.SelectedIndex = I - 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lstQuest.SelectedItem <> Nothing Then
            Dim test As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)

            QuestManager.syncro(test, TextBox14.Text)
            lstQuest.SelectedIndex = lstQuest.SelectedIndex - 1
            lstQuest.SelectedIndex = lstQuest.SelectedIndex + 1
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim test As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
        Dim teststep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
        QuestManager.syncrou(test, TextBox18.Text, teststep)
        lstQuestStep.SelectedIndex = lstQuestStep.SelectedIndex - 1
        lstQuestStep.SelectedIndex = lstQuestStep.SelectedIndex + 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RichTextBox3.AppendText("INSERT INTO `quest` VALUES ('" & txtQuestID.Text & "','" & txtQuestName.Text & "','" & teststep() & "','" & txtQuestCond.Text & "');" & vbCrLf)
        teststepo()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnAddQuest.Click
        QuestManager.syncroy(txtAddQuest.Text)
    End Sub

    Private Function teststep() As String
        Dim test As New List(Of Integer)

        Dim testi As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
        For Each S In testi.Steps
            test.Add(S.id)

        Next
        Return String.Join(",", test)
    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnUpStep.Click
        Dim testi As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
        Dim test As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
        QuestManager.upStepAction(testi, test)
        'For Each S In testi.Steps
        '    test.Add(S.id)

        'Next
        'Return String.Join(",", test)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnUpObj.Click
        Dim testi As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
        Dim test As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
        Dim testpp As QuestObjectif = QuestManager.GetObjectif(lstQuestObj.SelectedItem.ToString)
        QuestManager.fefe(testi, test, testpp)
    End Sub

    Private Function teststepo() As String
        '   Dim test As New List(Of Integer)

        Dim testi As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
        For Each S In testi.Steps
            Dim obj As New List(Of Integer)
            For Each Sp As QuestObjectif In S.Objectifs
                obj.Add(Sp.id)
            Next

            '  RichTextBox3.AppendText("INSERT INTO `quest_steps` VALUES ('" & teststepo() & "');" & vbCrLf)
            RichTextBox3.AppendText("INSERT INTO `quest_steps` VALUES ('" & S.id & "', '" & String.Join("|", obj) & "', '" & String.Join(";", S.GainObjects) & "', '" & S.GainKamas & "','" & S.GainXp & "', '" & S.Dialogue & "','" & S.All & "');" & vbCrLf)
            '  test.Add(S.id)

        Next

        '   Dim testi As Quest = QuestManager.GetQuest(ListBox1.SelectedItem.ToString)
        For Each S In testi.Steps
            Dim obj As New List(Of Integer)
            For Each Sp As QuestObjectif In S.Objectifs
                '  obj.Add(Sp.id)
                RichTextBox3.AppendText("INSERT INTO `quest_objectifs` VALUES ('" & Sp.id & "', '" & Sp.type & "', '" & Sp.arguments & "', '" & Sp.IsInvisble & "');" & vbCrLf)

                ' INSERT INTO `quest_objectifs` VALUES ('785', '3', '421,6', '0');
            Next

            '  RichTextBox3.AppendText("INSERT INTO `quest_steps` VALUES ('" & teststepo() & "');" & vbCrLf)
            '  test.Add(S.id)

        Next



        Dim strQuestionList As New List(Of String) 'As questionrep = testi.Questionrrep
        Dim strcondList As New List(Of String)
        Dim strRepList As New List(Of String)
        For Each iSj In testi.Questionrrep
            strQuestionList.Add(iSj.Question)
            strcondList.Add(iSj.Cond)
            strRepList.Add(iSj.rep)
            ' strQuestionList += String.Join(",", iSj.Question)
            'Dim SpellsSplit() As String = iSj.rep.Split(";")
            'For Each iSj2 In SpellsSplit
            '    RichTextBox4.AppendText("           " & testefe(iSj2, "a") & vbCrLf)
            'Next

        Next
        'Debug.WriteLine(String.Join("~", strQuestionList))

        RichTextBox3.AppendText("INSERT INTO `npc_question` VALUES ('" & TextBox5.Text & "', '" & String.Join("~", strQuestionList) & "', '" & String.Join("~", strRepList) & "', '" & String.Join("~", strcondList) & "', '" & testi.id & "');" & vbCrLf)


        ' Dim teszt As QuestionNPC = question(testi.id)
        ' RichTextBox3.AppendText("INSERT INTO `npc_question` VALUES ('" & teszt.NpcID & "', '" & teszt.QuestionID & "', '" & teszt.ResponsesPossible & "', '" & teszt.Cond & "', '" & testi.id & "');" & vbCrLf)
        '   RichTextBox3.AppendText("INSERT INTO `npc_question` VALUES ('" & testi.Questionrrep)
        '  Dim teszt As QuestionNPC = question(testi.id)

        Dim SpellsSpliti() As String = String.Join("~", strRepList).Split("~")
        For Each S In SpellsSpliti
            If S.Contains(";") Then
                Dim SpellsSplitiz() As String = S.Split(";")
                For Each Sz In SpellsSplitiz
                    Dim testazaz = rep(Sz)
                    RichTextBox3.AppendText("INSERT INTO `npc_response` VALUES ('" & testazaz.ResponseID & "', '" & testazaz.Type & "', '" & testazaz.Args & "', '');" & vbCrLf)
                    '    ygy()
                Next

            Else
                If S <> 0 Then

                    Dim testazaz = rep(S)
                    RichTextBox3.AppendText("INSERT INTO `npc_response` VALUES ('" & testazaz.ResponseID & "', '" & testazaz.Type & "', '" & testazaz.Args & "', '');" & vbCrLf)
                End If
            End If

        Next

        '   Dim liste

        Return Nothing
    End Function

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If lstQuestStep.SelectedItem <> Nothing Then

            Dim quest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
            Dim questStep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
            If TextBox4.Text = "" Or TextBox4.Text = "1" Then
                questStep.GainObjects.Add(Label22.Text)
            Else

                questStep.GainObjects.Add(Label22.Text & "," & TextBox4.Text)
            End If
            '  ListBox2.SelectedItem = ListBox2.SelectedItem
            lstQuestStep.Items(lstQuestStep.SelectedIndex) = txtStepId.Text
            TextBox4.Text = ""
            TextBox13.Text = ""
            '  ListBox2.SelectedIndex = ListBox2.SelectedIndex
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '  MyConsole.StartLoading("Loading QuestObjectifs from database...")
        RichTextBox4.Clear()
        Dim i = 0
        Dim test As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
        Dim teszt As QuestionNPC = question(test.id)
        Dim SpellsSplitdzdzz() As String = teszt.Cond.Split("~")
        For Each S In ListBox4.Items

            RichTextBox4.AppendText("Condition :" & vbCrLf & DecrypteAndCrypte(SpellsSplitdzdzz(i), "d") & vbCrLf)
            RichTextBox4.AppendText("       " & testefe(S, "q") & vbCrLf)
            'If ListBox5.Items(i).ToString <> "0" Then

            Dim objQuest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
            '  Dim objQuestQuestionandRep As QuestionNPC = question(objQuest.id)

            '    If ListBox5.Items(i).ToString.Contains(";") Then

            For Each iSj In objQuest.Questionrrep
                Dim SpellsSplit() As String = iSj.rep.Split(";")
                For Each iSj2 In SpellsSplit
                    RichTextBox4.AppendText("           " & testefe(iSj2, "a") & vbCrLf)
                Next

            Next
            '    Else
            '        RichTextBox4.AppendText("           " & testefe(ListBox5.Items(i).ToString, "a") & vbCrLf)

            '    End If
            'Else
            RichTextBox4.AppendText("           Aucune Réponse !" & vbCrLf)

            '  End If
            i += 1
            RichTextBox4.AppendText("__________________________________" & vbCrLf & vbCrLf)
        Next
    End Sub

    Private Function testefe(S As String, Optional ByVal types As String = "") As String
        Dim Result As MySqlDataReader = Nothing
        ' Dim SQLText As String = "DELETE FROM player_characters WHERE id=@CharacterName"
        SyncLock sql.AccountsSync
            Dim SQLText As String

            SQLText = "SELECT * FROM dialog Where ID=@CharacterName and Types=@type"

            '  MyConsole.StartLoading("Loading QuestObjectifs from database...")

            Dim SQLCommand As New MySqlCommand(SQLText, sql.Accounts)
            '    Dim Result As MySqlDataReader = SQLCommand.ExecuteReader
            SQLCommand.Parameters.Add(New MySqlParameter("@CharacterName", S))
            SQLCommand.Parameters.Add(New MySqlParameter("@type", types))
            Dim SqlInfos = ""
            Result = SQLCommand.ExecuteReader
            While Result.Read

                'RichTextBox2.AppendText("ID:" & Result("ID") & vbCrLf & "   Types:" & Result("Types") & vbCrLf & "      Text:" & Result("Text") & vbCrLf & vbCrLf)
                'RichTextBox2.AppendText("ID:" & Result("ID") & vbCrLf & "   Types:" & Result("Types") & vbCrLf & "      Text:" & Result("Text") & vbCrLf & vbCrLf)
                ' Return Result("Text")

                SqlInfos = Result("Text")

            End While

            Result.Close()
            Return SqlInfos
        End SyncLock
    End Function

    Public Function DecrypteAndCrypte(SpellsSplitdzdzz As String, p2 As String) As String
        Dim final = ""
        Dim SpellsSplitMultiarg() As String = SpellsSplitdzdzz.Split(";")
        If SpellsSplitMultiarg.Count >= 1 Then
            For k As Integer = 0 To SpellsSplitMultiarg.Length - 1
                final += "-" & fzefezefok(SpellsSplitMultiarg(k)) & vbCrLf
            Next
        End If

        Return final
    End Function

    Public Function fzefezefok(k As String) As String
        '  Dim final = ""
        Dim feeko
        If k.Contains("|") Then
            feeko = k.Split("|")
        Else
            feeko = k & "|0"
            feeko = k.Split("|")
        End If

        Select Case feeko(0)
            Case "0"
                Return " Aucune Condition"
            Case "1"
                Return " Quetes : ' " & feeko(1) & "' en cours"
            Case "2"

                Dim SplitLVl() As String = feeko(1).Split(",")

                Return " Item : " & SplitLVl(0) & " X" & SplitLVl(1)
            Case "3"
                Return " Quetes : ' " & feeko(1) & "' Terminé"
            Case "4" ' quete x etape x
                Dim SplitLVl() As String = feeko(1).Split(",")

                Return " Quetes : " & SplitLVl(0) & " Etape :" & SplitLVl(1)
            Case "5"
                Return " Actualise la quete !"
            Case "6"
                Return " lance la quete: " & feeko(1)
            Case Else
                Return k
        End Select
    End Function

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        condition.Close()
        condition.Show()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        condition.Close()
        condition.Show()
        condition.apeed()
    End Sub

#Region "Step"
    Private Sub txtStepId_TextChanged(sender As Object, e As EventArgs) Handles txtStepId.TextChanged
        If txtStepId.Text <> "" Then
            Dim quest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
            Dim questStep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
            '   Dim questObjc As QuestObjectif = QuestManager.GetObjectif(ListBox3.SelectedItem.ToString)

            questStep.id = txtStepId.Text
            '   Dim teseeet = ListBox2.SelectedItem.ToString
            lstQuestStep.Items(lstQuestStep.SelectedIndex) = txtStepId.Text

        End If
    End Sub
    Private Sub txtStepGainXp_TextChanged(sender As Object, e As EventArgs) Handles txtStepGainXp.TextChanged
        If txtStepGainXp.Text <> "" Then
            Dim quest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
            Dim questStep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
            '   Dim questObjc As QuestObjectif = QuestManager.GetObjectif(ListBox3.SelectedItem.ToString)
            questStep.GainXp = txtStepGainXp.Text
        End If
    End Sub
    Private Sub txtGainKamas_TextChanged(sender As Object, e As EventArgs) Handles txtStepGainKamas.TextChanged
        If txtStepGainKamas.Text <> "" Then
            Dim quest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
            Dim questStep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
            '   Dim questObjc As QuestObjectif = QuestManager.GetObjectif(ListBox3.SelectedItem.ToString)
            questStep.GainKamas = txtStepGainKamas.Text
        End If
    End Sub
    Private Sub txtStepDialog_TextChanged(sender As Object, e As EventArgs) Handles txtStepDialog.TextChanged
        If txtStepDialog.Text <> "" Then
            Dim quest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
            Dim questStep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
            '   Dim questObjc As QuestObjectif = QuestManager.GetObjectif(ListBox3.SelectedItem.ToString)
            questStep.Dialogue = txtStepDialog.Text
        End If
    End Sub
    Private Sub txtStepAll_TextChanged(sender As Object, e As EventArgs) Handles txtStepAll.TextChanged
        If txtStepAll.Text <> "" Then
            Dim quest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
            Dim questStep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
            '   Dim questObjc As QuestObjectif = QuestManager.GetObjectif(ListBox3.SelectedItem.ToString)
            questStep.All = txtStepAll.Text
        End If
    End Sub
#End Region

#Region "txtObj"
    Private Sub QuestStepObjID_TextChanged(sender As Object, e As EventArgs) Handles txtQuestStepObjID.TextChanged
        If lstQuestObj.SelectedItem <> Nothing Then
            If txtQuestStepObjID.Text <> "" Then
                Dim quest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
                Dim questStep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
                Dim questObjc As QuestObjectif = QuestManager.GetObjectif(lstQuestObj.SelectedItem.ToString)
                questObjc.id = txtQuestStepObjID.Text
                lstQuestObj.Items(lstQuestObj.SelectedIndex) = txtQuestStepObjID.Text
            End If

        End If
    End Sub
    Private Sub txtQuestStepObjType_TextChanged(sender As Object, e As EventArgs) Handles txtQuestStepObjType.TextChanged
        If lstQuestObj.SelectedItem <> Nothing Then
            If txtQuestStepObjType.Text <> "" Then
                Dim quest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
                Dim questStep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
                Dim questObjc As QuestObjectif = QuestManager.GetObjectif(lstQuestObj.SelectedItem.ToString)
                questObjc.type = txtQuestStepObjType.Text
                '  lstQuestObj.Items(lstQuestObj.SelectedIndex) = txtQuestStepObjID.Text
            End If

        End If
    End Sub
    Private Sub txtQuestStepObjArgs_TextChanged(sender As Object, e As EventArgs) Handles txtQuestStepObjArgs.TextChanged
        If lstQuestObj.SelectedItem <> Nothing Then
            If txtQuestStepObjArgs.Text <> "" Then
                Dim quest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
                Dim questStep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
                Dim questObjc As QuestObjectif = QuestManager.GetObjectif(lstQuestObj.SelectedItem.ToString)
                questObjc.arguments = txtQuestStepObjArgs.Text

            End If

        End If
    End Sub
    Private Sub txtQuestStepObjVisible_TextChanged(sender As Object, e As EventArgs) Handles txtQuestStepObjVisible.TextChanged
        If lstQuestObj.SelectedItem <> Nothing Then
            If txtQuestStepObjVisible.Text <> "" Then
                Dim quest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
                Dim questStep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
                Dim questObjc As QuestObjectif = QuestManager.GetObjectif(lstQuestObj.SelectedItem.ToString)
                questObjc.IsInvisble = txtQuestStepObjVisible.Text
            End If
        End If
    End Sub

#End Region

    Private Sub btnAddQuestionAndRep_Click(sender As Object, e As EventArgs) Handles btnAddQuestionAndRep.Click
        qetrep.Close()
        qetrep.Show()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click

        Dim quest As Quest = QuestManager.GetQuest(lstQuest.SelectedItem.ToString)
        Dim questStep As QuestStep = QuestManager.GetQStep(lstQuestStep.SelectedItem.ToString)
        Dim itemTempDelete = ""
        For Each liededene As String In questStep.GainObjects
            If liededene.Contains(TextBox3.Text & ",") Then
                itemTempDelete = liededene
            End If

        Next
        If itemTempDelete <> Nothing Then
            questStep.GainObjects.Remove(itemTempDelete)
            lvwStepItems.Items.Clear()
            For Each liededene As String In questStep.GainObjects
                '  Dim obj = objet(liededene)
                If liededene <> "0" Then
                    Dim SpellsSplit() As String = liededene.Split(",")
                    '    If SpellsSplit(1) = Nothing Then
                    If SpellsSplit.Count = 1 Then
                        'Dim NewItem As Item = ItemsHandler.GetItemTemplate(S).GenerateItem(1)
                        'Client.Character.Items.AddItem(Client, NewItem)
                        ''   Im021;2~6897
                        Dim ActualItem As ListViewItem = lvwStepItems.Items.Add(SpellsSplit(0))
                        ActualItem.SubItems.Add(objet(SpellsSplit(0)))
                        ActualItem.SubItems.Add(1)
                        'Client.Send("Im021;1" & "~" & S)
                    Else
                        Dim ActualItem As ListViewItem = lvwStepItems.Items.Add(SpellsSplit(0))
                        ActualItem.SubItems.Add(objet(SpellsSplit(0)))
                        ActualItem.SubItems.Add(SpellsSplit(1))
                        'Dim NewItem As Item = ItemsHandler.GetItemTemplate(SpellsSplit(0)).GenerateItem(SpellsSplit(1))
                        'Client.Character.Items.AddItem(Client, NewItem)
                        ''  Client.SendNormalMessage("vous avez recu : " & ItemsHandler.GetItemTemplate(SpellsSplit(0)).Name)
                        'Client.Send("Im021;" & SpellsSplit(1) & "~" & SpellsSplit(0))
                    End If
                End If
            Next
        End If

    End Sub
End Class