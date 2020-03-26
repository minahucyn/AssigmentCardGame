<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBoxScore = New System.Windows.Forms.GroupBox()
        Me.LabelPlayerTwoScore = New System.Windows.Forms.Label()
        Me.LabelPlayerOneScore = New System.Windows.Forms.Label()
        Me.GroupBoxPlayer1 = New System.Windows.Forms.GroupBox()
        Me.ButtonFlipCardPlayerOne = New System.Windows.Forms.Button()
        Me.GroupBoxPlayer2 = New System.Windows.Forms.GroupBox()
        Me.ButtonFlipCardPlayerTwo = New System.Windows.Forms.Button()
        Me.PanelGame = New System.Windows.Forms.Panel()
        Me.GroupBoxInstructions = New System.Windows.Forms.GroupBox()
        Me.LabelInstructions = New System.Windows.Forms.Label()
        Me.PanelGreet = New System.Windows.Forms.Panel()
        Me.ButtonQuit = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ComboBoxNumberOfRounds = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelGameTitle = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardOneThree = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardOneOne = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardOneSix = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardOneFive = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardOneFour = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardOneTwo = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardTwoThree = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardTwoOne = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardTwoSix = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardTwoFive = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardTwoFour = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCardTwoTwo = New System.Windows.Forms.PictureBox()
        Me.GroupBoxScore.SuspendLayout()
        Me.GroupBoxPlayer1.SuspendLayout()
        Me.GroupBoxPlayer2.SuspendLayout()
        Me.PanelGame.SuspendLayout()
        Me.GroupBoxInstructions.SuspendLayout()
        Me.PanelGreet.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardOneThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardOneOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardOneSix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardOneFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardOneFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardOneTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardTwoThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardTwoOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardTwoSix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardTwoFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardTwoFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCardTwoTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxScore
        '
        Me.GroupBoxScore.Controls.Add(Me.LabelPlayerTwoScore)
        Me.GroupBoxScore.Controls.Add(Me.LabelPlayerOneScore)
        Me.GroupBoxScore.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxScore.Location = New System.Drawing.Point(7, 3)
        Me.GroupBoxScore.Name = "GroupBoxScore"
        Me.GroupBoxScore.Size = New System.Drawing.Size(216, 81)
        Me.GroupBoxScore.TabIndex = 16
        Me.GroupBoxScore.TabStop = False
        Me.GroupBoxScore.Text = "Score"
        '
        'LabelPlayerTwoScore
        '
        Me.LabelPlayerTwoScore.AutoSize = True
        Me.LabelPlayerTwoScore.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPlayerTwoScore.Location = New System.Drawing.Point(6, 48)
        Me.LabelPlayerTwoScore.Name = "LabelPlayerTwoScore"
        Me.LabelPlayerTwoScore.Size = New System.Drawing.Size(109, 25)
        Me.LabelPlayerTwoScore.TabIndex = 1
        Me.LabelPlayerTwoScore.Tag = "Player Two:  "
        Me.LabelPlayerTwoScore.Text = "Player Two:"
        '
        'LabelPlayerOneScore
        '
        Me.LabelPlayerOneScore.AutoSize = True
        Me.LabelPlayerOneScore.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPlayerOneScore.Location = New System.Drawing.Point(6, 17)
        Me.LabelPlayerOneScore.Name = "LabelPlayerOneScore"
        Me.LabelPlayerOneScore.Size = New System.Drawing.Size(115, 25)
        Me.LabelPlayerOneScore.TabIndex = 0
        Me.LabelPlayerOneScore.Tag = "Player One:  "
        Me.LabelPlayerOneScore.Text = "Player One: "
        '
        'GroupBoxPlayer1
        '
        Me.GroupBoxPlayer1.Controls.Add(Me.ButtonFlipCardPlayerOne)
        Me.GroupBoxPlayer1.Controls.Add(Me.PictureBoxCardOneThree)
        Me.GroupBoxPlayer1.Controls.Add(Me.PictureBoxCardOneOne)
        Me.GroupBoxPlayer1.Controls.Add(Me.PictureBoxCardOneSix)
        Me.GroupBoxPlayer1.Controls.Add(Me.PictureBoxCardOneFive)
        Me.GroupBoxPlayer1.Controls.Add(Me.PictureBoxCardOneFour)
        Me.GroupBoxPlayer1.Controls.Add(Me.PictureBoxCardOneTwo)
        Me.GroupBoxPlayer1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPlayer1.Location = New System.Drawing.Point(7, 100)
        Me.GroupBoxPlayer1.Name = "GroupBoxPlayer1"
        Me.GroupBoxPlayer1.Size = New System.Drawing.Size(543, 167)
        Me.GroupBoxPlayer1.TabIndex = 28
        Me.GroupBoxPlayer1.TabStop = False
        Me.GroupBoxPlayer1.Text = "Player 1"
        '
        'ButtonFlipCardPlayerOne
        '
        Me.ButtonFlipCardPlayerOne.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonFlipCardPlayerOne.Location = New System.Drawing.Point(447, 129)
        Me.ButtonFlipCardPlayerOne.Name = "ButtonFlipCardPlayerOne"
        Me.ButtonFlipCardPlayerOne.Size = New System.Drawing.Size(74, 25)
        Me.ButtonFlipCardPlayerOne.TabIndex = 30
        Me.ButtonFlipCardPlayerOne.Text = "Filp Card"
        Me.ButtonFlipCardPlayerOne.UseVisualStyleBackColor = True
        '
        'GroupBoxPlayer2
        '
        Me.GroupBoxPlayer2.Controls.Add(Me.ButtonFlipCardPlayerTwo)
        Me.GroupBoxPlayer2.Controls.Add(Me.PictureBoxCardTwoThree)
        Me.GroupBoxPlayer2.Controls.Add(Me.PictureBoxCardTwoOne)
        Me.GroupBoxPlayer2.Controls.Add(Me.PictureBoxCardTwoSix)
        Me.GroupBoxPlayer2.Controls.Add(Me.PictureBoxCardTwoFive)
        Me.GroupBoxPlayer2.Controls.Add(Me.PictureBoxCardTwoFour)
        Me.GroupBoxPlayer2.Controls.Add(Me.PictureBoxCardTwoTwo)
        Me.GroupBoxPlayer2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPlayer2.Location = New System.Drawing.Point(7, 273)
        Me.GroupBoxPlayer2.Name = "GroupBoxPlayer2"
        Me.GroupBoxPlayer2.Size = New System.Drawing.Size(543, 167)
        Me.GroupBoxPlayer2.TabIndex = 29
        Me.GroupBoxPlayer2.TabStop = False
        Me.GroupBoxPlayer2.Text = "Player 2"
        '
        'ButtonFlipCardPlayerTwo
        '
        Me.ButtonFlipCardPlayerTwo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonFlipCardPlayerTwo.Location = New System.Drawing.Point(447, 129)
        Me.ButtonFlipCardPlayerTwo.Name = "ButtonFlipCardPlayerTwo"
        Me.ButtonFlipCardPlayerTwo.Size = New System.Drawing.Size(74, 25)
        Me.ButtonFlipCardPlayerTwo.TabIndex = 31
        Me.ButtonFlipCardPlayerTwo.Text = "Flip Card"
        Me.ButtonFlipCardPlayerTwo.UseVisualStyleBackColor = True
        '
        'PanelGame
        '
        Me.PanelGame.Controls.Add(Me.GroupBoxInstructions)
        Me.PanelGame.Controls.Add(Me.GroupBoxScore)
        Me.PanelGame.Controls.Add(Me.GroupBoxPlayer1)
        Me.PanelGame.Controls.Add(Me.GroupBoxPlayer2)
        Me.PanelGame.Location = New System.Drawing.Point(3, 5)
        Me.PanelGame.Name = "PanelGame"
        Me.PanelGame.Size = New System.Drawing.Size(556, 444)
        Me.PanelGame.TabIndex = 31
        '
        'GroupBoxInstructions
        '
        Me.GroupBoxInstructions.Controls.Add(Me.LabelInstructions)
        Me.GroupBoxInstructions.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxInstructions.Location = New System.Drawing.Point(229, 3)
        Me.GroupBoxInstructions.Name = "GroupBoxInstructions"
        Me.GroupBoxInstructions.Size = New System.Drawing.Size(321, 81)
        Me.GroupBoxInstructions.TabIndex = 17
        Me.GroupBoxInstructions.TabStop = False
        Me.GroupBoxInstructions.Text = "Player Instructions"
        '
        'LabelInstructions
        '
        Me.LabelInstructions.AutoSize = True
        Me.LabelInstructions.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LabelInstructions.Location = New System.Drawing.Point(15, 19)
        Me.LabelInstructions.Name = "LabelInstructions"
        Me.LabelInstructions.Size = New System.Drawing.Size(243, 52)
        Me.LabelInstructions.TabIndex = 0
        Me.LabelInstructions.Text = "This Game is simple, just select a card and flip." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "That's all." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Have fun playin" &
    "g!!!"
        '
        'PanelGreet
        '
        Me.PanelGreet.Controls.Add(Me.PictureBox2)
        Me.PanelGreet.Controls.Add(Me.PictureBox1)
        Me.PanelGreet.Controls.Add(Me.ButtonQuit)
        Me.PanelGreet.Controls.Add(Me.ButtonStart)
        Me.PanelGreet.Controls.Add(Me.ComboBoxNumberOfRounds)
        Me.PanelGreet.Controls.Add(Me.Label3)
        Me.PanelGreet.Controls.Add(Me.LabelGameTitle)
        Me.PanelGreet.Location = New System.Drawing.Point(588, 27)
        Me.PanelGreet.Name = "PanelGreet"
        Me.PanelGreet.Size = New System.Drawing.Size(556, 444)
        Me.PanelGreet.TabIndex = 32
        '
        'ButtonQuit
        '
        Me.ButtonQuit.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuit.Location = New System.Drawing.Point(89, 337)
        Me.ButtonQuit.Name = "ButtonQuit"
        Me.ButtonQuit.Size = New System.Drawing.Size(187, 55)
        Me.ButtonQuit.TabIndex = 4
        Me.ButtonQuit.Text = "Quit"
        Me.ButtonQuit.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.Location = New System.Drawing.Point(285, 337)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(187, 55)
        Me.ButtonStart.TabIndex = 3
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ComboBoxNumberOfRounds
        '
        Me.ComboBoxNumberOfRounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNumberOfRounds.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxNumberOfRounds.FormattingEnabled = True
        Me.ComboBoxNumberOfRounds.Items.AddRange(New Object() {"3", "4", "5", "6"})
        Me.ComboBoxNumberOfRounds.Location = New System.Drawing.Point(221, 252)
        Me.ComboBoxNumberOfRounds.Name = "ComboBoxNumberOfRounds"
        Me.ComboBoxNumberOfRounds.Size = New System.Drawing.Size(113, 40)
        Me.ComboBoxNumberOfRounds.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(416, 30)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "How many rounds would you like to play?"
        '
        'LabelGameTitle
        '
        Me.LabelGameTitle.AutoSize = True
        Me.LabelGameTitle.Font = New System.Drawing.Font("Old English Text MT", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGameTitle.ForeColor = System.Drawing.Color.ForestGreen
        Me.LabelGameTitle.Location = New System.Drawing.Point(129, 28)
        Me.LabelGameTitle.Name = "LabelGameTitle"
        Me.LabelGameTitle.Size = New System.Drawing.Size(307, 114)
        Me.LabelGameTitle.TabIndex = 0
        Me.LabelGameTitle.Text = "Clover"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AssigmentCardGame.My.Resources.Resources.CloverIcon
        Me.PictureBox2.Location = New System.Drawing.Point(414, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(98, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AssigmentCardGame.My.Resources.Resources.CloverIcon
        Me.PictureBox1.Location = New System.Drawing.Point(45, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxCardOneThree
        '
        Me.PictureBoxCardOneThree.Location = New System.Drawing.Point(189, 24)
        Me.PictureBoxCardOneThree.Name = "PictureBoxCardOneThree"
        Me.PictureBoxCardOneThree.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardOneThree.TabIndex = 20
        Me.PictureBoxCardOneThree.TabStop = False
        Me.PictureBoxCardOneThree.Tag = "13"
        '
        'PictureBoxCardOneOne
        '
        Me.PictureBoxCardOneOne.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBoxCardOneOne.Location = New System.Drawing.Point(17, 24)
        Me.PictureBoxCardOneOne.Name = "PictureBoxCardOneOne"
        Me.PictureBoxCardOneOne.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardOneOne.TabIndex = 8
        Me.PictureBoxCardOneOne.TabStop = False
        Me.PictureBoxCardOneOne.Tag = "11"
        '
        'PictureBoxCardOneSix
        '
        Me.PictureBoxCardOneSix.Location = New System.Drawing.Point(447, 24)
        Me.PictureBoxCardOneSix.Name = "PictureBoxCardOneSix"
        Me.PictureBoxCardOneSix.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardOneSix.TabIndex = 17
        Me.PictureBoxCardOneSix.TabStop = False
        Me.PictureBoxCardOneSix.Tag = "16"
        '
        'PictureBoxCardOneFive
        '
        Me.PictureBoxCardOneFive.Location = New System.Drawing.Point(361, 24)
        Me.PictureBoxCardOneFive.Name = "PictureBoxCardOneFive"
        Me.PictureBoxCardOneFive.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardOneFive.TabIndex = 18
        Me.PictureBoxCardOneFive.TabStop = False
        Me.PictureBoxCardOneFive.Tag = "15"
        '
        'PictureBoxCardOneFour
        '
        Me.PictureBoxCardOneFour.Location = New System.Drawing.Point(275, 24)
        Me.PictureBoxCardOneFour.Name = "PictureBoxCardOneFour"
        Me.PictureBoxCardOneFour.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardOneFour.TabIndex = 19
        Me.PictureBoxCardOneFour.TabStop = False
        Me.PictureBoxCardOneFour.Tag = "14"
        '
        'PictureBoxCardOneTwo
        '
        Me.PictureBoxCardOneTwo.Location = New System.Drawing.Point(103, 24)
        Me.PictureBoxCardOneTwo.Name = "PictureBoxCardOneTwo"
        Me.PictureBoxCardOneTwo.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardOneTwo.TabIndex = 21
        Me.PictureBoxCardOneTwo.TabStop = False
        Me.PictureBoxCardOneTwo.Tag = "12"
        '
        'PictureBoxCardTwoThree
        '
        Me.PictureBoxCardTwoThree.Location = New System.Drawing.Point(189, 24)
        Me.PictureBoxCardTwoThree.Name = "PictureBoxCardTwoThree"
        Me.PictureBoxCardTwoThree.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardTwoThree.TabIndex = 20
        Me.PictureBoxCardTwoThree.TabStop = False
        Me.PictureBoxCardTwoThree.Tag = "23"
        '
        'PictureBoxCardTwoOne
        '
        Me.PictureBoxCardTwoOne.Location = New System.Drawing.Point(17, 24)
        Me.PictureBoxCardTwoOne.Name = "PictureBoxCardTwoOne"
        Me.PictureBoxCardTwoOne.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardTwoOne.TabIndex = 8
        Me.PictureBoxCardTwoOne.TabStop = False
        Me.PictureBoxCardTwoOne.Tag = "21"
        '
        'PictureBoxCardTwoSix
        '
        Me.PictureBoxCardTwoSix.Location = New System.Drawing.Point(447, 24)
        Me.PictureBoxCardTwoSix.Name = "PictureBoxCardTwoSix"
        Me.PictureBoxCardTwoSix.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardTwoSix.TabIndex = 17
        Me.PictureBoxCardTwoSix.TabStop = False
        Me.PictureBoxCardTwoSix.Tag = "26"
        '
        'PictureBoxCardTwoFive
        '
        Me.PictureBoxCardTwoFive.Location = New System.Drawing.Point(361, 24)
        Me.PictureBoxCardTwoFive.Name = "PictureBoxCardTwoFive"
        Me.PictureBoxCardTwoFive.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardTwoFive.TabIndex = 18
        Me.PictureBoxCardTwoFive.TabStop = False
        Me.PictureBoxCardTwoFive.Tag = "25"
        '
        'PictureBoxCardTwoFour
        '
        Me.PictureBoxCardTwoFour.Location = New System.Drawing.Point(275, 24)
        Me.PictureBoxCardTwoFour.Name = "PictureBoxCardTwoFour"
        Me.PictureBoxCardTwoFour.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardTwoFour.TabIndex = 19
        Me.PictureBoxCardTwoFour.TabStop = False
        Me.PictureBoxCardTwoFour.Tag = "24"
        '
        'PictureBoxCardTwoTwo
        '
        Me.PictureBoxCardTwoTwo.Location = New System.Drawing.Point(103, 24)
        Me.PictureBoxCardTwoTwo.Name = "PictureBoxCardTwoTwo"
        Me.PictureBoxCardTwoTwo.Size = New System.Drawing.Size(80, 106)
        Me.PictureBoxCardTwoTwo.TabIndex = 21
        Me.PictureBoxCardTwoTwo.TabStop = False
        Me.PictureBoxCardTwoTwo.Tag = "22"
        '
        'MainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 454)
        Me.Controls.Add(Me.PanelGreet)
        Me.Controls.Add(Me.PanelGame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainView"
        Me.Text = "Card Game"
        Me.GroupBoxScore.ResumeLayout(False)
        Me.GroupBoxScore.PerformLayout()
        Me.GroupBoxPlayer1.ResumeLayout(False)
        Me.GroupBoxPlayer2.ResumeLayout(False)
        Me.PanelGame.ResumeLayout(False)
        Me.GroupBoxInstructions.ResumeLayout(False)
        Me.GroupBoxInstructions.PerformLayout()
        Me.PanelGreet.ResumeLayout(False)
        Me.PanelGreet.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardOneThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardOneOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardOneSix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardOneFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardOneFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardOneTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardTwoThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardTwoOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardTwoSix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardTwoFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardTwoFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCardTwoTwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxCardOneOne As PictureBox
    Friend WithEvents GroupBoxScore As GroupBox
    Friend WithEvents LabelPlayerTwoScore As Label
    Friend WithEvents LabelPlayerOneScore As Label
    Friend WithEvents PictureBoxCardOneSix As PictureBox
    Friend WithEvents PictureBoxCardOneFive As PictureBox
    Friend WithEvents PictureBoxCardOneFour As PictureBox
    Friend WithEvents PictureBoxCardOneThree As PictureBox
    Friend WithEvents PictureBoxCardOneTwo As PictureBox
    Friend WithEvents GroupBoxPlayer1 As GroupBox
    Friend WithEvents GroupBoxPlayer2 As GroupBox
    Friend WithEvents PictureBoxCardTwoThree As PictureBox
    Friend WithEvents PictureBoxCardTwoOne As PictureBox
    Friend WithEvents PictureBoxCardTwoSix As PictureBox
    Friend WithEvents PictureBoxCardTwoFive As PictureBox
    Friend WithEvents PictureBoxCardTwoFour As PictureBox
    Friend WithEvents PictureBoxCardTwoTwo As PictureBox
    Friend WithEvents PanelGame As Panel
    Friend WithEvents PanelGreet As Panel
    Friend WithEvents ComboBoxNumberOfRounds As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelGameTitle As Label
    Friend WithEvents ButtonQuit As Button
    Friend WithEvents ButtonStart As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonFlipCardPlayerOne As Button
    Friend WithEvents ButtonFlipCardPlayerTwo As Button
    Friend WithEvents GroupBoxInstructions As GroupBox
    Friend WithEvents LabelInstructions As Label
End Class
