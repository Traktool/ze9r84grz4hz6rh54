<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lstQuest = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuestID = New System.Windows.Forms.TextBox()
        Me.lblQuestID = New System.Windows.Forms.Label()
        Me.txtQuestName = New System.Windows.Forms.TextBox()
        Me.lblQuestName = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.lstQuestStep = New System.Windows.Forms.ListBox()
        Me.lstQuestObj = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtQuestCond = New System.Windows.Forms.TextBox()
        Me.lblQuestCond = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUpStep = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnUpObj = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.txtStepId = New System.Windows.Forms.TextBox()
        Me.txtStepGainKamas = New System.Windows.Forms.TextBox()
        Me.txtStepGainXp = New System.Windows.Forms.TextBox()
        Me.txtStepDialog = New System.Windows.Forms.TextBox()
        Me.txtStepAll = New System.Windows.Forms.TextBox()
        Me.lblStepID = New System.Windows.Forms.Label()
        Me.lblStepGainXp = New System.Windows.Forms.Label()
        Me.lblStepAll = New System.Windows.Forms.Label()
        Me.lblStepGainKamas = New System.Windows.Forms.Label()
        Me.lblStepDialog = New System.Windows.Forms.Label()
        Me.lvwStepItems = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtQuestStepObjID = New System.Windows.Forms.TextBox()
        Me.txtQuestStepObjType = New System.Windows.Forms.TextBox()
        Me.txtQuestStepObjArgs = New System.Windows.Forms.TextBox()
        Me.txtQuestStepObjVisible = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.lblStepItem = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.btnAddQuest = New System.Windows.Forms.Button()
        Me.txtAddQuest = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnAddQuestionAndRep = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(495, 516)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(351, 140)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'lstQuest
        '
        Me.lstQuest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstQuest.FormattingEnabled = True
        Me.lstQuest.Location = New System.Drawing.Point(4, 28)
        Me.lstQuest.Name = "lstQuest"
        Me.lstQuest.Size = New System.Drawing.Size(128, 628)
        Me.lstQuest.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quetes"
        '
        'txtQuestID
        '
        Me.txtQuestID.Location = New System.Drawing.Point(41, 42)
        Me.txtQuestID.Name = "txtQuestID"
        Me.txtQuestID.Size = New System.Drawing.Size(265, 20)
        Me.txtQuestID.TabIndex = 3
        '
        'lblQuestID
        '
        Me.lblQuestID.AutoSize = True
        Me.lblQuestID.Location = New System.Drawing.Point(3, 45)
        Me.lblQuestID.Name = "lblQuestID"
        Me.lblQuestID.Size = New System.Drawing.Size(18, 13)
        Me.lblQuestID.TabIndex = 2
        Me.lblQuestID.Text = "ID"
        '
        'txtQuestName
        '
        Me.txtQuestName.Location = New System.Drawing.Point(41, 16)
        Me.txtQuestName.Name = "txtQuestName"
        Me.txtQuestName.Size = New System.Drawing.Size(265, 20)
        Me.txtQuestName.TabIndex = 1
        '
        'lblQuestName
        '
        Me.lblQuestName.AutoSize = True
        Me.lblQuestName.Location = New System.Drawing.Point(2, 19)
        Me.lblQuestName.Name = "lblQuestName"
        Me.lblQuestName.Size = New System.Drawing.Size(29, 13)
        Me.lblQuestName.TabIndex = 0
        Me.lblQuestName.Text = "Nom"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox2.Location = New System.Drawing.Point(138, 516)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(351, 140)
        Me.RichTextBox2.TabIndex = 5
        Me.RichTextBox2.Text = ""
        '
        'lstQuestStep
        '
        Me.lstQuestStep.FormattingEnabled = True
        Me.lstQuestStep.Location = New System.Drawing.Point(5, 33)
        Me.lstQuestStep.Name = "lstQuestStep"
        Me.lstQuestStep.Size = New System.Drawing.Size(140, 212)
        Me.lstQuestStep.TabIndex = 0
        '
        'lstQuestObj
        '
        Me.lstQuestObj.FormattingEnabled = True
        Me.lstQuestObj.Location = New System.Drawing.Point(5, 33)
        Me.lstQuestObj.Name = "lstQuestObj"
        Me.lstQuestObj.Size = New System.Drawing.Size(140, 212)
        Me.lstQuestObj.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtQuestCond)
        Me.GroupBox1.Controls.Add(Me.lblQuestCond)
        Me.GroupBox1.Controls.Add(Me.lblQuestName)
        Me.GroupBox1.Controls.Add(Me.txtQuestID)
        Me.GroupBox1.Controls.Add(Me.txtQuestName)
        Me.GroupBox1.Controls.Add(Me.lblQuestID)
        Me.GroupBox1.Location = New System.Drawing.Point(138, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 103)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Générale"
        '
        'txtQuestCond
        '
        Me.txtQuestCond.Location = New System.Drawing.Point(41, 68)
        Me.txtQuestCond.Name = "txtQuestCond"
        Me.txtQuestCond.Size = New System.Drawing.Size(265, 20)
        Me.txtQuestCond.TabIndex = 5
        '
        'lblQuestCond
        '
        Me.lblQuestCond.AutoSize = True
        Me.lblQuestCond.Location = New System.Drawing.Point(3, 71)
        Me.lblQuestCond.Name = "lblQuestCond"
        Me.lblQuestCond.Size = New System.Drawing.Size(32, 13)
        Me.lblQuestCond.TabIndex = 4
        Me.lblQuestCond.Text = "Cond"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnUpStep)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.lstQuestStep)
        Me.GroupBox2.Location = New System.Drawing.Point(138, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 280)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Etapes"
        '
        'btnUpStep
        '
        Me.btnUpStep.Location = New System.Drawing.Point(107, 9)
        Me.btnUpStep.Name = "btnUpStep"
        Me.btnUpStep.Size = New System.Drawing.Size(37, 23)
        Me.btnUpStep.TabIndex = 57
        Me.btnUpStep.Text = "Up"
        Me.btnUpStep.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(112, 251)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 23)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(6, 251)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 20)
        Me.TextBox14.TabIndex = 54
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnUpObj)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.TextBox18)
        Me.GroupBox3.Controls.Add(Me.lstQuestObj)
        Me.GroupBox3.Location = New System.Drawing.Point(304, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 280)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Objectifs"
        '
        'btnUpObj
        '
        Me.btnUpObj.Location = New System.Drawing.Point(107, 9)
        Me.btnUpObj.Name = "btnUpObj"
        Me.btnUpObj.Size = New System.Drawing.Size(37, 23)
        Me.btnUpObj.TabIndex = 58
        Me.btnUpObj.Text = "Up"
        Me.btnUpObj.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(111, 249)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(33, 23)
        Me.Button4.TabIndex = 56
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(6, 251)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 55
        '
        'txtStepId
        '
        Me.txtStepId.Location = New System.Drawing.Point(113, 22)
        Me.txtStepId.Name = "txtStepId"
        Me.txtStepId.Size = New System.Drawing.Size(238, 20)
        Me.txtStepId.TabIndex = 9
        '
        'txtStepGainKamas
        '
        Me.txtStepGainKamas.Location = New System.Drawing.Point(113, 46)
        Me.txtStepGainKamas.Name = "txtStepGainKamas"
        Me.txtStepGainKamas.Size = New System.Drawing.Size(238, 20)
        Me.txtStepGainKamas.TabIndex = 10
        '
        'txtStepGainXp
        '
        Me.txtStepGainXp.Location = New System.Drawing.Point(113, 72)
        Me.txtStepGainXp.Name = "txtStepGainXp"
        Me.txtStepGainXp.Size = New System.Drawing.Size(238, 20)
        Me.txtStepGainXp.TabIndex = 11
        '
        'txtStepDialog
        '
        Me.txtStepDialog.Location = New System.Drawing.Point(113, 98)
        Me.txtStepDialog.Name = "txtStepDialog"
        Me.txtStepDialog.Size = New System.Drawing.Size(238, 20)
        Me.txtStepDialog.TabIndex = 12
        '
        'txtStepAll
        '
        Me.txtStepAll.Location = New System.Drawing.Point(113, 124)
        Me.txtStepAll.Name = "txtStepAll"
        Me.txtStepAll.Size = New System.Drawing.Size(238, 20)
        Me.txtStepAll.TabIndex = 13
        '
        'lblStepID
        '
        Me.lblStepID.AutoSize = True
        Me.lblStepID.Location = New System.Drawing.Point(18, 23)
        Me.lblStepID.Name = "lblStepID"
        Me.lblStepID.Size = New System.Drawing.Size(49, 13)
        Me.lblStepID.TabIndex = 16
        Me.lblStepID.Text = "ID Etape"
        '
        'lblStepGainXp
        '
        Me.lblStepGainXp.AutoSize = True
        Me.lblStepGainXp.Location = New System.Drawing.Point(18, 75)
        Me.lblStepGainXp.Name = "lblStepGainXp"
        Me.lblStepGainXp.Size = New System.Drawing.Size(58, 13)
        Me.lblStepGainXp.TabIndex = 17
        Me.lblStepGainXp.Text = "Gain en xp"
        '
        'lblStepAll
        '
        Me.lblStepAll.AutoSize = True
        Me.lblStepAll.Location = New System.Drawing.Point(18, 127)
        Me.lblStepAll.Name = "lblStepAll"
        Me.lblStepAll.Size = New System.Drawing.Size(18, 13)
        Me.lblStepAll.TabIndex = 18
        Me.lblStepAll.Text = "All"
        '
        'lblStepGainKamas
        '
        Me.lblStepGainKamas.AutoSize = True
        Me.lblStepGainKamas.Location = New System.Drawing.Point(18, 49)
        Me.lblStepGainKamas.Name = "lblStepGainKamas"
        Me.lblStepGainKamas.Size = New System.Drawing.Size(79, 13)
        Me.lblStepGainKamas.TabIndex = 21
        Me.lblStepGainKamas.Text = "Gain en Kamas"
        '
        'lblStepDialog
        '
        Me.lblStepDialog.AutoSize = True
        Me.lblStepDialog.Location = New System.Drawing.Point(18, 101)
        Me.lblStepDialog.Name = "lblStepDialog"
        Me.lblStepDialog.Size = New System.Drawing.Size(37, 13)
        Me.lblStepDialog.TabIndex = 22
        Me.lblStepDialog.Text = "Dialog"
        '
        'lvwStepItems
        '
        Me.lvwStepItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwStepItems.Location = New System.Drawing.Point(113, 150)
        Me.lvwStepItems.Name = "lvwStepItems"
        Me.lvwStepItems.Size = New System.Drawing.Size(238, 109)
        Me.lvwStepItems.TabIndex = 23
        Me.lvwStepItems.UseCompatibleStateImageBehavior = False
        Me.lvwStepItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 140
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantité"
        '
        'txtQuestStepObjID
        '
        Me.txtQuestStepObjID.Location = New System.Drawing.Point(102, 22)
        Me.txtQuestStepObjID.Name = "txtQuestStepObjID"
        Me.txtQuestStepObjID.Size = New System.Drawing.Size(249, 20)
        Me.txtQuestStepObjID.TabIndex = 24
        '
        'txtQuestStepObjType
        '
        Me.txtQuestStepObjType.Location = New System.Drawing.Point(102, 48)
        Me.txtQuestStepObjType.Name = "txtQuestStepObjType"
        Me.txtQuestStepObjType.Size = New System.Drawing.Size(249, 20)
        Me.txtQuestStepObjType.TabIndex = 25
        '
        'txtQuestStepObjArgs
        '
        Me.txtQuestStepObjArgs.Location = New System.Drawing.Point(102, 74)
        Me.txtQuestStepObjArgs.Name = "txtQuestStepObjArgs"
        Me.txtQuestStepObjArgs.Size = New System.Drawing.Size(51, 20)
        Me.txtQuestStepObjArgs.TabIndex = 26
        '
        'txtQuestStepObjVisible
        '
        Me.txtQuestStepObjVisible.Location = New System.Drawing.Point(102, 100)
        Me.txtQuestStepObjVisible.Name = "txtQuestStepObjVisible"
        Me.txtQuestStepObjVisible.Size = New System.Drawing.Size(249, 20)
        Me.txtQuestStepObjVisible.TabIndex = 27
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0 = #1", "1 = Aller voir #1", "2 = Montrer à #1 : #3 #2", "3 = Ramener à #1 : x#3 #2", "4 = Découvrir la carte #1", "5 = Découvrir la zone #1", "6 = Vaincre x#2 #1 en un seul combat", "7 = Monstre à vaincre : #1", "8 = Utiliser : #1", "9 = Retourner voir #1", "10 = Escorter #1 #2", "11 = Vaincre un joueur en défi #1", "12 = Rapporter #3 âme de #2 à #1.", "13 = Eliminer #1."})
        Me.ComboBox1.Location = New System.Drawing.Point(159, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Id objectif"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Visible"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Args"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Label15"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(113, 265)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(194, 20)
        Me.TextBox13.TabIndex = 36
        '
        'lblStepItem
        '
        Me.lblStepItem.AutoSize = True
        Me.lblStepItem.Location = New System.Drawing.Point(18, 150)
        Me.lblStepItem.Name = "lblStepItem"
        Me.lblStepItem.Size = New System.Drawing.Size(32, 13)
        Me.lblStepItem.TabIndex = 33
        Me.lblStepItem.Text = "Items"
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(895, 25)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(119, 212)
        Me.ListBox4.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(852, 354)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Type"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(855, 381)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Args"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(852, 325)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 13)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "ID Rep"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(963, 378)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(265, 20)
        Me.TextBox15.TabIndex = 41
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(963, 351)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(265, 20)
        Me.TextBox16.TabIndex = 40
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(963, 325)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(265, 20)
        Me.TextBox17.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(892, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Listes Questions"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(852, 299)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(105, 13)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Details des réponses"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(963, 296)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 51
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(842, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Up"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(842, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 23)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Down"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(501, 496)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 54
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox3.Location = New System.Drawing.Point(852, 481)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(351, 140)
        Me.RichTextBox3.TabIndex = 55
        Me.RichTextBox3.Text = ""
        '
        'btnAddQuest
        '
        Me.btnAddQuest.Location = New System.Drawing.Point(99, 4)
        Me.btnAddQuest.Name = "btnAddQuest"
        Me.btnAddQuest.Size = New System.Drawing.Size(33, 23)
        Me.btnAddQuest.TabIndex = 56
        Me.btnAddQuest.Text = "+"
        Me.btnAddQuest.UseVisualStyleBackColor = True
        '
        'txtAddQuest
        '
        Me.txtAddQuest.Location = New System.Drawing.Point(48, 6)
        Me.txtAddQuest.Name = "txtAddQuest"
        Me.txtAddQuest.Size = New System.Drawing.Size(45, 20)
        Me.txtAddQuest.TabIndex = 56
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(311, 265)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(40, 20)
        Me.TextBox4.TabIndex = 57
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(311, 287)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(40, 21)
        Me.Button9.TabIndex = 58
        Me.Button9.Text = "ADD"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(18, 269)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "Label22"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox4.Location = New System.Drawing.Point(138, 448)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(351, 140)
        Me.RichTextBox4.TabIndex = 60
        Me.RichTextBox4.Text = ""
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(725, 496)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 61
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1020, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 20)
        Me.TextBox1.TabIndex = 62
        '
        'RichTextBox5
        '
        Me.RichTextBox5.Location = New System.Drawing.Point(1020, 103)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.Size = New System.Drawing.Size(252, 126)
        Me.RichTextBox5.TabIndex = 63
        Me.RichTextBox5.Text = ""
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1051, 74)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 64
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1020, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(252, 20)
        Me.TextBox2.TabIndex = 65
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1132, 74)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 66
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnAddQuestionAndRep
        '
        Me.btnAddQuestionAndRep.Location = New System.Drawing.Point(895, 241)
        Me.btnAddQuestionAndRep.Name = "btnAddQuestionAndRep"
        Me.btnAddQuestionAndRep.Size = New System.Drawing.Size(119, 23)
        Me.btnAddQuestionAndRep.TabIndex = 67
        Me.btnAddQuestionAndRep.Text = "AddQuestion et rep"
        Me.btnAddQuestionAndRep.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtQuestStepObjVisible)
        Me.GroupBox4.Controls.Add(Me.txtQuestStepObjID)
        Me.GroupBox4.Controls.Add(Me.txtQuestStepObjType)
        Me.GroupBox4.Controls.Add(Me.txtQuestStepObjArgs)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(479, 329)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(357, 161)
        Me.GroupBox4.TabIndex = 59
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Objectifs"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.lblStepGainXp)
        Me.GroupBox5.Controls.Add(Me.txtStepId)
        Me.GroupBox5.Controls.Add(Me.txtStepGainKamas)
        Me.GroupBox5.Controls.Add(Me.txtStepGainXp)
        Me.GroupBox5.Controls.Add(Me.txtStepDialog)
        Me.GroupBox5.Controls.Add(Me.txtStepAll)
        Me.GroupBox5.Controls.Add(Me.lblStepID)
        Me.GroupBox5.Controls.Add(Me.lblStepAll)
        Me.GroupBox5.Controls.Add(Me.lblStepGainKamas)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Me.lblStepDialog)
        Me.GroupBox5.Controls.Add(Me.lvwStepItems)
        Me.GroupBox5.Controls.Add(Me.TextBox4)
        Me.GroupBox5.Controls.Add(Me.lblStepItem)
        Me.GroupBox5.Controls.Add(Me.TextBox13)
        Me.GroupBox5.Location = New System.Drawing.Point(479, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(357, 311)
        Me.GroupBox5.TabIndex = 68
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Etape"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(22, 229)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 61
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(7, 203)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 60
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(895, 424)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 69
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 662)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnAddQuestionAndRep)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.RichTextBox5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.txtAddQuest)
        Me.Controls.Add(Me.btnAddQuest)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstQuest)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmHome"
        Me.Text = "frmHome"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lstQuest As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuestID As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestID As System.Windows.Forms.Label
    Friend WithEvents txtQuestName As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestName As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents lstQuestStep As System.Windows.Forms.ListBox
    Friend WithEvents lstQuestObj As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtQuestCond As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestCond As System.Windows.Forms.Label
    Friend WithEvents txtStepId As System.Windows.Forms.TextBox
    Friend WithEvents txtStepGainKamas As System.Windows.Forms.TextBox
    Friend WithEvents txtStepGainXp As System.Windows.Forms.TextBox
    Friend WithEvents txtStepDialog As System.Windows.Forms.TextBox
    Friend WithEvents txtStepAll As System.Windows.Forms.TextBox
    Friend WithEvents lblStepID As System.Windows.Forms.Label
    Friend WithEvents lblStepGainXp As System.Windows.Forms.Label
    Friend WithEvents lblStepAll As System.Windows.Forms.Label
    Friend WithEvents lblStepGainKamas As System.Windows.Forms.Label
    Friend WithEvents lblStepDialog As System.Windows.Forms.Label
    Friend WithEvents lvwStepItems As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtQuestStepObjID As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestStepObjType As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestStepObjArgs As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestStepObjVisible As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents lblStepItem As System.Windows.Forms.Label
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAddQuest As System.Windows.Forms.Button
    Friend WithEvents txtAddQuest As System.Windows.Forms.TextBox
    Friend WithEvents btnUpStep As System.Windows.Forms.Button
    Friend WithEvents btnUpObj As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnAddQuestionAndRep As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox

End Class
