'ISU by : Harsh Mistry 
'Phoenix : A Massive RPG 
'May 1st , 2014 - June 13th , 2014 
'Powered by the Qian Engine : A Infinity Computing Production 


Public Class frmBattle
    'Battle Variables 
    Public Moves(4, 1) As Integer
    Public AI(4, 1) As Integer
    Public Type As String
    Public AI_Type As Integer
    Public Txt As String
    Public playID As Integer
    Public AI_HP As Integer = 100
    Dim RndNum As Integer
    Dim XP As Integer
    Dim reward As Integer
    Public Max As Integer
    Dim names(100) As String
    Public opName As String

    'Sleep variables 
    Declare Sub Sleep Lib "kernel32.dll" (ByVal Milliseconds As Integer)


    'Get Move Name based on values in array 
    Public Sub moveList(ByVal attack As Array, ByVal num As Integer)

        'Determine Move name , type, and damage 
        Select Case attack(num, 0)
            Case 0 'Nothing 
                Txt = "Empty"
                Type = "Empty"
                attack(num, 1) = 0
            Case 1 'Claw
                Txt = "Claw"
                Type = "General"
                attack(num, 1) = 10
            Case 2 'Smash
                Txt = "Smash"
                Type = "General"
                attack(num, 1) = 20
            Case 3 'Fire Attack 
                Txt = "Fire Attack"
                Type = "General"
                attack(num, 1) = 20
            Case 4 'Confuse
                Txt = "Confuse"
                Type = "General"
                attack(num, 1) = 5
            Case 5 'Shockwave
                Txt = "Shockwave"
                Type = "Electric"
                attack(num, 1) = 40
            Case 6 'RockWave
                Txt = "Rockwave"
                Type = "Ground"
                attack(num, 1) = 40
            Case 7 'Blood
                Txt = "Blood"
                Type = "Vampire"
                attack(num, 1) = 50
            Case 8 'Pixie Dust  
                Txt = "Pixie Dust"
                Type = "Magic"
                attack(num, 1) = 60
            Case 9 'SnowBall
                Txt = "SnowBall"
                Type = "Water"
                attack(num, 1) = 50
            Case 10 'Wise Attack
                Txt = "Wise Attack "
                Type = "Water"
                attack(num, 1) = 60
            Case 11 'Slash
                Txt = "Slash"
                Type = "Weapon"
                attack(num, 1) = 70
            Case 12 'Lord Attack
                Txt = "Lord Attack"
                Type = "??????"
                attack(num, 1) = 100
            Case 13 'Master Attack
                Txt = "Master Attack"
                Type = "??????"
                attack(num, 1) = 120
            Case 14 'Leader Attack 
                Txt = "Leader Attack"
                Type = "??????"
                attack(num, 1) = 120
        End Select
    End Sub

    Private Sub frmBattle_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Clear List Box 
        lstMoves.Items.Clear()

        'Set Player Max HP 
        pgbHP.Maximum = modSaveData.maxHealth

        'Start Timer 
        tmrRefresh.Enabled = True

        'Reset AI HP 
        AI_HP = 100


        'Display Player Moves in List Box
        For count As Integer = 0 To 4
            moveList(Moves, count) 'Call Move List procedure
            lstMoves.Items.Add("Move : " & Txt & Space(7) & "Move Type : " & Type) 'Display Information in List Box

        Next

        'Display AI Name 
        lblAI.Text = opName


        'Determine and display AI values 
        Select Case playID
            Case 1 'AI_1
                picAI.Image = My.Resources.AI_1 'Display Image
                AI_Type = 1 'set Player type to easy 
                XP = 100 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 1
                AI(0, 1) = 10
                AI(1, 1) = 20
                AI(1, 0) = 2
                RndNum = 2

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 100.5
            Case 2 'AI_2
                picAI.Image = My.Resources.AI_2 'Display Image

                AI_Type = 1 'set Player type to easy 
                XP = 100 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 1
                AI(0, 1) = 10
                AI(1, 1) = 20
                AI(2, 0) = 5
                AI(2, 1) = 40
                AI(1, 0) = 2
                RndNum = 3

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 230
            Case 3 'AI_3
                picAI.Image = My.Resources.AI_3 'Display Image

                AI_Type = 1 'set Player type to easy 
                XP = 100 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 1
                AI(0, 1) = 10
                AI(1, 1) = 20
                AI(2, 0) = 5
                AI(2, 1) = 40
                AI(1, 0) = 2
                RndNum = 3

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 250
            Case 4 'AI_4
                picAI.Image = My.Resources.AI_4 'Display Image

                AI_Type = 2 'set Player type to easy 
                XP = 150 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 1
                AI(0, 1) = 10
                AI(1, 1) = 20
                AI(2, 0) = 5
                AI(2, 1) = 40
                AI(1, 0) = 2
                AI(3, 0) = 6
                AI(3, 1) = 40
                RndNum = 4

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 250
            Case 5 'AI_5
                picAI.Image = My.Resources.AI_5 'Display Image

                AI_Type = 2 'set Player type to hard
                XP = 150 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 7
                AI(0, 1) = 20
                AI(1, 1) = 20
                AI(2, 0) = 7
                AI(2, 1) = 40
                AI(1, 0) = 2
                AI(3, 0) = 7
                AI(3, 1) = 60
                RndNum = 4

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 250
            Case 6 'AI_6
                picAI.Image = My.Resources.AI_6 'Display Image

                AI_Type = 2 'set Player type to hard
                XP = 200 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 8
                AI(0, 1) = 20
                AI(1, 1) = 20
                AI(2, 0) = 8
                AI(2, 1) = 40
                AI(1, 0) = 2
                AI(3, 0) = 8
                AI(3, 1) = 65
                RndNum = 4

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 350
            Case 7 'AI_7
                picAI.Image = My.Resources.AI_7 'Display Image

                AI_Type = 1 'set Player type to easy
                XP = 150 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 9
                AI(0, 1) = 20
                AI(1, 1) = 20
                AI(2, 0) = 9
                AI(2, 1) = 40
                AI(1, 0) = 2
                AI(3, 0) = 9
                AI(3, 1) = 55
                RndNum = 4

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 300
            Case 8 'AI_8
                picAI.Image = My.Resources.AI_8 'Display Image

                AI_Type = 1 'set Player type to easy
                XP = 150 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 10
                AI(0, 1) = 20
                AI(1, 1) = 20
                AI(2, 0) = 10
                AI(2, 1) = 40
                AI(1, 0) = 2
                AI(3, 0) = 10
                AI(3, 1) = 55
                RndNum = 4

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 150
            Case 9 'AI_1.2
                picAI.Image = My.Resources.AI_1 'Display Image
                AI_Type = 1 'set Player type to easy 
                XP = 350 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 10
                AI(0, 1) = 30
                AI(1, 1) = 60
                AI(1, 0) = 10
                RndNum = 2

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 400

            Case 10 'AI_9
                picAI.Image = My.Resources.AI_9 'Display Image
                AI_Type = 1 'set Player type to easy 
                XP = 350 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 11
                AI(0, 1) = 20
                AI(1, 1) = 60
                AI(1, 0) = 11
                AI(2, 0) = 11
                AI(2, 1) = 20
                RndNum = 3

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 400

            Case 11 'The Lord
                picAI.Image = My.Resources.AI_2 'Display Image

                AI_Type = 2 'set Player type to easy 
                XP = 500 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 12
                AI(0, 1) = 30
                AI(1, 1) = 90
                AI(2, 0) = 12
                AI(2, 1) = 85
                AI(1, 0) = 12
                RndNum = 3

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 3000
            Case 12 'The Master
                picAI.Image = My.Resources.AI_10 'Display Image

                AI_Type = 2 'set Player type to easy 
                XP = 500 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 13
                AI(0, 1) = 120
                AI(1, 1) = 30
                AI(2, 0) = 13
                AI(2, 1) = 85
                AI(1, 0) = 13
                RndNum = 3

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 3000

            Case 13 'The Leader
                picAI.Image = My.Resources.AI_10 'Display Image

                AI_Type = 2 'set Player type to easy 
                XP = 500 'Set XP value for winner 

                'Set Attack Moves 
                AI(0, 0) = 14
                AI(0, 1) = 140
                AI(1, 1) = 30
                AI(2, 0) = 14
                AI(2, 1) = 90
                AI(1, 0) = 14
                RndNum = 3

                'Set Progress Bar Max
                pgbHP2.Maximum = Max

                'set AI HP 
                AI_HP = Max

                'Set amount of money to give if pplayer wins
                reward = 3000
        End Select
    End Sub


    Private Sub tmrRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefresh.Tick

        'Set Player Max HP 
        pgbHP.Maximum = modSaveData.maxHealth


        'Check Player Health to see if he/she has died
        If modSaveData.health <= 0 Then
            Me.Hide() 'Hide Window
            frmGameOver.Show() 'Show Game over Screen
        End If

        'Refresh Player HP if its above or = to 0 
        If modSaveData.health >= 0 And modSaveData.health <= modSaveData.maxHealth Then
            pgbHP.Value = modSaveData.health
            lblHP.Text = "HP : " & modSaveData.health & "/" & modSaveData.maxHealth
        End If
        'Check to see if AI has been defeated
        If AI_HP <= 0 Then
            tmrRefresh.Enabled = False 'Stop timer 
            MsgBox("You Won!!!") 'Display Message 
            modSaveData.xp = modSaveData.xp + XP 'Add XP
            modSaveData.gold = modSaveData.gold + reward 'Add Money 

            If playID >= 11 Then 'Add a Badge if the player has beaten a boss
                modSaveData.items(3) = modSaveData.items(3) + 1
                MsgBox("You have Earned a Badge") 'Display Message
            End If

            'Play Bacground Music if User has turned on play music
            If frmmain.playMusic = True Then
                My.Computer.Audio.Play(My.Resources._01_prelude, AudioPlayMode.BackgroundLoop) ' Play music 
            End If

            'Check to see if level should be incremented 
            If modSaveData.xp >= modSaveData.maxXP Then
                modSaveData.xp = 0 'Reset xp 
                modSaveData.level = modSaveData.level + 1
                MsgBox("You Have Leveled Up !!!!!!!!") 'Display Level Up Message 
            End If

            frmmain.Map(modInteract.BattleX / frmmain.TileSize, modInteract.BattleY / frmmain.TileSize, 4) = 0 'Set Interact Tile to 0 so player can play the same AI again

            Me.Hide() 'Hide Battle Window
            frmmain.Opacity = 100 'Show Main game screen 

            frmmain.IsRunning = True 'Set Game running to true


            frmmain.StartGameLoop() 'Start Game Engine 




        End If

        'Refresh AI HP if AI HP is more than or = to 0 
        If AI_HP >= 0 Then
            pgbHP2.Value = AI_HP
            lblHP2.Text = "HP : " & AI_HP & "/" & Max
        End If


    End Sub

    Private Sub frmBattle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load Randomize Function 
        Randomize()

        'Set Item Name values 
        names(0) = "Food"
        names(1) = "Potions"
        names(2) = "Super Heal"
        names(3) = "Badges"
        names(4) = "Escape Rope"
        names(5) = "Mega Heal"


    End Sub

    Private Sub picAttack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAttack.Click
        'Declare variables 
        Dim index As Integer
        Dim damage As Integer
        Dim MoveName As Integer

        'Disable attack button to avoid error
        picAttack.Enabled = False

        'Get Selected Move 
        index = lstMoves.SelectedIndex

        'Check to Make sure index is not -1
        If index < 0 Then
            txtInfo.Text = "No Move was Selected" 'Display Error
            picAttack.Enabled = True 'Re-enable button
            Exit Sub 'Exit sub event
        End If

        'Check to see if selected move is empty or not
        If Moves(index, 0) = 0 Then
            txtInfo.Text = "That Move Spot is Empty , Choose another Move Spot" 'Display Error
            picAttack.Enabled = True 'Re-enable button
            Exit Sub 'Exit sub event
        End If

        'Determine move damage and move name
        damage = Moves(index, 1)
        MoveName = index

        'Get Move name 
        moveList(Moves, MoveName)

        'Display Move name 
        txtInfo.Text = "The Fallen Used : " & Txt

        'Inflict Damage
        AI_HP = AI_HP - damage

        'Run AI script only if AI is still alive 
        If AI_HP > 0 Then
            AI_Script()
        Else
            picAttack.Enabled = True
        End If


    End Sub

    'Script to determine the AI Attack and Damage 
    Public Sub AI_Script()
        Dim random As Integer
        Dim MoveName As Integer
        Dim damage As Integer

        'Choose a random number for selecting a AI Move 
        Randomize()

        random = Int(RndNum * Rnd() + 0)

        'Determine move damage and move 
        damage = AI(random, 1)
        MoveName = random

        'Get Move name 
        moveList(AI, MoveName)

        'Display Move name 
        txtInfo.Text = lblAI.Text & " Used : " & Txt

        'Inflict Damage
        modSaveData.health = modSaveData.health - damage

        'Re-enable Attack button 
        picAttack.Enabled = True
    End Sub

    Private Sub picUse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUse.Click
        'Hide Attack and Inventory Buttons 
        picAttack.Visible = False
        picUse.Visible = False


        'Show Inventory and Use Buttons 
        lstINV.Visible = True
        picItem.Visible = True
        picExit.Visible = True

    End Sub

    Private Sub tmrInventory_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrInventory.Tick
        'Refresh Item Count every 0.5 seconds
        Dim text As String
        Dim value As Integer
        Dim index As Integer

        'Get selected index
        index = lstINV.SelectedIndex

        'Clear List Box 
        lstINV.Items.Clear()

        'Load Values into list box 
        For count As Integer = 0 To 99
            'Get Item name 
            text = names(count)

            'Get Item Value 
            value = modSaveData.items(count)

            'Exit loop when there are no more item names to write 
            If text = Nothing Then
                Exit For
            End If

            'Write Values and Names into list box 
            lstINV.Items.Add(text & vbTab & value)
        Next

        'Set Selected index back to old selected index
        lstINV.SelectedIndex = index
    End Sub

    'Use one of the Items selected 
    Private Sub picItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picItem.Click

        'Declare Use variables
        Dim use As Integer
        Dim useValue As Integer
        Dim HP As Integer = modSaveData.maxHealth

        'Get Selected Item 
        use = lstINV.SelectedIndex

        'If use is < 0 exit sub event
        If use < 0 Then
            Exit Sub 'exit sub event
        End If

        'Get item value 
        useValue = modSaveData.items(use)

        'Check to see if useValue is less than 0 , if yes exit sub event 
        If useValue <= 0 Then
            MsgBox("You don't have any of that item avalible to use") ' Display error
            Exit Sub 'Exit sub event 
        End If

        'Determine and Carry out Use action 
        Select Case use
            Case 0 'Eat Food
                If modSaveData.health < HP Then 'Only eat food if health is less then 100 
                    modSaveData.health = modSaveData.health + 10 'Increase Health by 10 
                    modSaveData.items(use) = modSaveData.items(use) - 1 'Take away 1 item 
                    ItemUse() 'Run Use Sub Procedure 
                Else
                    MsgBox("Your health is already at 100 , no need to eat food") 'Display error
                End If
            Case 1 'Drink Potion 
                If modSaveData.health < HP Then 'Only drink potion if health is less then 100 
                    modSaveData.health = modSaveData.health + 11 'Increase Health by 10 
                    modSaveData.items(use) = modSaveData.items(use) - 1 'Take away 1 item 
                    ItemUse() 'Run Use Sub Procedure 
                Else
                    MsgBox("Your health is already at 100 , no need to drink potion") 'Display error
                End If
            Case 2 'Super heal 
                If modSaveData.health < HP Then 'Only heal if health is less then 100 
                    modSaveData.health = modSaveData.health + 50 'Increase Health by 10 
                    modSaveData.items(use) = modSaveData.items(use) - 1 'Take away 1 item 
                    ItemUse() 'Run Use Sub Procedure 
                Else
                    MsgBox("Your health is already at 100 , no need to heal") 'Display error
                End If
            Case 3 'Display error
                MsgBox("This is not a Usable Item")
            Case 4 'Escape Rope 

                'Let the Player Escape the Battle if AI type is easy 
                If AI_Type = 1 Then 'AI Type = Easy

                    'Hide Inventory 
                    lstINV.Visible = False
                    picItem.Visible = False
                    picExit.Visible = False

                    'Show Attack buttons 
                    picAttack.Visible = True
                    picUse.Visible = True

                    'Play Bacground Music if User has turned on play music
                    If frmmain.playMusic = True Then
                        My.Computer.Audio.Play(My.Resources._01_prelude, AudioPlayMode.BackgroundLoop) ' Play music 
                    End If

                    Me.Hide() 'Hide Battle Window
                    frmmain.Opacity = 100 'Show Main game screen 

                    frmmain.IsRunning = True 'Set Game running to true

                    frmmain.StartGameLoop() 'Start Game Engine 

                Else 'AI Type = Hard 
                    MsgBox("Sorry you can not escape from this NPC") 'Display Error 
                End If

            Case 5 'Mega heal : Set value of healing based on oppenent type
                If modSaveData.health < HP Then 'Only heal if health is less then max

                    If playID < 11 Then 'Regular Oppenets 
                        modSaveData.health = modSaveData.health + 80 'Increase Health by 10 
                    ElseIf playID >= 11 Then 'Bosses
                        modSaveData.health = modSaveData.maxHealth
                    End If

                    modSaveData.items(use) = modSaveData.items(use) - 1 'Take away 1 item 
                    ItemUse() 'Run Use Sub Procedure 
                Else
                    MsgBox("Your health is already at  , no need to heal") 'Display error
                End If
        End Select

        'Make Sure health is 100 or less , if more correct it
        If modSaveData.health > HP Then
            modSaveData.health = HP ' reset health to 100 
        End If
    End Sub

    'Hide Inventory and Excute AI Script 
    Private Sub ItemUse()
        'Hide Inventory 
        lstINV.Visible = False
        picItem.Visible = False
        picExit.Visible = False

        'Show Attack buttons 
        picAttack.Visible = True
        picUse.Visible = True

        'Excute AI script 
        AI_Script()
    End Sub

    'Go back to Battle 
    Private Sub picExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picExit.Click
        'Hide Inventory 
        lstINV.Visible = False
        picItem.Visible = False
        picExit.Visible = False

        'Show Attack buttons 
        picAttack.Visible = True
        picUse.Visible = True



    End Sub

    'Stop All proccess when X button is pressed
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End 'Close Application


    End Sub

End Class