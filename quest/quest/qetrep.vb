Public Class qetrep

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        condition.Close()
        condition.Show()
        condition.CheckBox7.Checked = True
        condition.CheckBox7.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strSplitAllReponse() As String = TextBox2.Text.Split(";")
        For Each Se In strSplitAllReponse
            '            ' ListBox6.Items.Add(Se)
            ListBox1.Items.Add((Se))
            '            ComboBox2.Items.Add(Se)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objQuest As Quest = QuestManager.GetQuest(frmHome.lstQuest.SelectedItem.ToString)
        Dim NewQuestionAndRep As New questionrep
        NewQuestionAndRep.Question = TextBox1.Text
        ' ListBox4.Items.Add(strSplitQuestQuestion(k))
        NewQuestionAndRep.rep = TextBox2.Text
        NewQuestionAndRep.Cond = TextBox3.Text
        objQuest.Questionrrep.Add(NewQuestionAndRep)
        ' NpcDialog.ListOfQuestion.Add(NewQuestion)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox1.SelectedItem <> Nothing Then
            Dim NewResponse As New ResponseNPC
            NewResponse.ResponseID = ListBox1.SelectedItem
            NewResponse.Type = TextBox5.Text
            NewResponse.Args = TextBox6.Text
            '   Dim objQuest As Quest = QuestManager.GetQuest(frmHome.lstQuest.SelectedItem.ToString)
            ' NewResponse.Q = frmHome.lstQuest.SelectedItem.ToS
            NpcDialog.ListOfResponse.Add(NewResponse)
        End If
     
    End Sub

    
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem <> Nothing Then
            TextBox4.Text = ListBox1.SelectedItem
        End If
    End Sub

    Private Sub qetrep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmHome.lstQuest.SelectedItem = Nothing Then
            Me.Close()
        End If
    End Sub


  
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class