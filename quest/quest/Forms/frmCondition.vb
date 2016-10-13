Public Class frmCondition
    Dim criptedConditions = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '   Dim test As New List(Of Integer)

        '    Return String.Join(",", test)
        VerifQuestNotEmpty()
        If CheckBox7.Checked = True Then
            frmAddQuestionAnwser.TextBox3.Text = criptedConditions
            Dim SpellsSplitMultiarg() As String = criptedConditions.Split(";")
            If SpellsSplitMultiarg.Count >= 1 Then
                For i As Integer = 0 To SpellsSplitMultiarg.Length - 1
                    frmAddQuestionAnwser.RichTextBox1.AppendText("-" & frmHome.RenderConditionsListe(SpellsSplitMultiarg(i)) & vbCrLf)
                Next
            End If
            '     fzefze = String.Join(";", strTotalCond)
        Else
            '    frmHome.TextBox2.Text = fzefze
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox7.Checked = True Then
            frmAddQuestionAnwser.TextBox3.Text = criptedConditions
            Dim SpellsSplitMultiarg() As String = criptedConditions.Split(";")
            If SpellsSplitMultiarg.Count >= 1 Then
                For k As Integer = 0 To SpellsSplitMultiarg.Length - 1
                    frmAddQuestionAnwser.RichTextBox1.AppendText("-" & frmHome.RenderConditionsListe(SpellsSplitMultiarg(k)) & vbCrLf)
                Next
            End If
            '     fzefze = String.Join(";", strTotalCond)
        Else
            frmHome.TextBox2.Text = criptedConditions
        End If

    End Sub

    Sub SplitConditionsElements()

        Dim SpellsSplitMultiarg() As String = frmHome.TextBox2.Text.Split(";")
        If SpellsSplitMultiarg.Count >= 1 Then
            For i As Integer = 0 To SpellsSplitMultiarg.Length - 1
                fzefezefok(SpellsSplitMultiarg(i))
            Next
        End If

        MessageBox.Show("Izafatem VIDE !")
    End Sub

    Private Function fzefezefok(k As String) As String
        Dim feeko
        If k.Contains("|") Then
            feeko = k.Split("|")
        Else
            feeko = k & "|0"
            feeko = k.Split("|")
        End If

        Select Case feeko(0)
            Case "0"
                CheckBox1.Checked = True
            Case "1"
                TextBox1.Text = feeko(1)
                CheckBox2.Checked = True
            Case "2"
                Dim SplitLVl() As String = feeko(1).Split(",")


                '  Return " Item : " & SplitLVl(0) & " X" & SplitLVl(1)
                NumericUpDown1.Value = SplitLVl(1)
                TextBox2.Text = SplitLVl(0)
                CheckBox3.Checked = True
            Case "3"
                CheckBox4.Checked = True
                TextBox3.Text = feeko(1)
                Return " Quetes : ' " & feeko(1) & "' Terminé"
            Case "4" ' quete x etape x
                Dim SplitLVl() As String = feeko(1).Split(",")
                '  CheckBox4.Checked = True
                'TextBox3.Text = ""
                Return " Quetes : " & SplitLVl(0) & " Etape :" & SplitLVl(1)
            Case "5"
                CheckBox5.Checked = True
                '   Return " Actualise la quete !"
            Case "6"
                Return " lance la quete: " & feeko(1)
            Case Else
                Return k
        End Select
        Return k
    End Function


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VerifQuestNotEmpty()

        If CheckBox7.Checked = True Then
            frmAddQuestionAnwser.TextBox3.Text = criptedConditions
            Dim SpellsSplitMultiarg() As String = criptedConditions.Split(";")
            If SpellsSplitMultiarg.Count >= 1 Then
                For k As Integer = 0 To SpellsSplitMultiarg.Length - 1
                    frmAddQuestionAnwser.RichTextBox1.AppendText("-" & frmHome.RenderConditionsListe(SpellsSplitMultiarg(k)) & vbCrLf)
                Next
            End If
            '     fzefze = String.Join(";", strTotalCond)
        Else
            '   frmHome.TextBox2.Text = fzefze
        End If
    End Sub

    Private Sub VerifQuestNotEmpty()
        'test
        Dim strTotalCond As New List(Of String)
        If CheckBox1.Checked = True Then
            strTotalCond.Add("0")
        End If
        If CheckBox2.Checked = True Then
            If TextBox1.Text = "" Then
                MessageBox.Show("Quete en cours Champs ID Quest VIDE !")
            Else
                strTotalCond.Add("1|" & TextBox1.Text)
            End If

        End If
        If CheckBox3.Checked = True Then
            If TextBox2.Text = "" Then
                MessageBox.Show("Items Champs ID Item VIDE !")
            Else
                strTotalCond.Add("2|" & TextBox2.Text & "," & NumericUpDown1.Value)
            End If

        End If
        RichTextBox1.Clear()
        Dim SpellsSplitMultiarg() As String = String.Join(";", strTotalCond).Split(";")
        If SpellsSplitMultiarg.Count >= 1 Then
            For k As Integer = 0 To SpellsSplitMultiarg.Length - 1
                RichTextBox1.AppendText("-" & frmHome.RenderConditionsListe(SpellsSplitMultiarg(k)) & vbCrLf)
            Next
        End If
        criptedConditions = String.Join(";", strTotalCond)
    End Sub

    Private Sub frmCondition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  test
    End Sub
End Class