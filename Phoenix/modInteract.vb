Module modInteract

    'Declare Map Variables 
    Public BattleX As Integer
    Public BattleY As Integer
    Public MapBackUp(100, 100, 10) As Integer
    Public PlayX As Integer
    Public PlayY As Integer

    Public Sub GetInteractAction(ByVal X As Integer, ByVal Y As Integer)
        'Determine Interact action 
        Select Case frmmain.Map(X / frmmain.TileSize, Y / frmmain.TileSize, 4)
            Case 0 'Nothing to interact with
                MsgBox("There is Nothing to Interact With Here!") 'Display message

            Case 1 'Wise man message 
                frmmain.txt = "Welcome Wise Master to Phoenix : The Rise of the Fallen." & vbCrLf & "Follow the Glass road to glory." & vbCrLf & "You must defeat all Lords and Masters to Gain the Ultimate Title" 'Display message 
                frmmain.view = True 'Show message 

            Case 2 'Battle with Lord Harkon

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "I shall defeat you and send you back to the deep trenches " & vbCrLf & "of the Underworld" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed

                    BattleFunction(X, Y, 1, 100, "Lord Harkon")
                End If
            Case 3 'Market Sign 
                frmmain.txt = "Welcome to the Main Market" & vbCrLf & "Talk to the red hooded merchants to buy items" 'Display message 
                frmmain.view = True 'Show message 
            Case 4 'Food Seller 
                frmmain.txt = "Hi My name is BOB the RED " & vbCrLf & "Would you like to buy some Food for 20 gold ? " & vbCrLf & "Press I & O together to buy!" 'Display message 
                frmmain.view = True 'Show message 
                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed

                    frmmain.view = False 'Hide Message frane 
                    ShopFunction(20, 0, "Item added to inventory") 'Run Shop Script 

                End If
            Case 5 'Food Seller 
                frmmain.txt = "Hi My name is Creep" & vbCrLf & "Would you like to buy some potions for 30 gold ? " & vbCrLf & "Press I & O together to buy!" 'Display message 
                frmmain.view = True 'Show message 
                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed

                    frmmain.view = False 'Hide Message frane 
                    ShopFunction(30, 1, "Item added to inventory") 'Run Shop Script 
                 
                End If
            Case 6 'Super heal seller  
                frmmain.txt = "Hi My name is Jon " & vbCrLf & "Would you like to buy some Super Heal potions for 60 gold ? " & vbCrLf & "Press I & O together to buy!" 'Display message 
                frmmain.view = True 'Show message 
                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed

                    frmmain.view = False 'Hide Message frane 
                    ShopFunction(60, 2, "Item added to inventory") 'Run Shop Script 

                End If
            Case 7 'Escape rope seller 
                frmmain.txt = "Hi My name is Logan " & vbCrLf & "Would you like to buy a Escape Rope for 10 gold ? " & vbCrLf & "Press I & O together to buy!" 'Display message 
                frmmain.view = True 'Show message 
                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed

                    frmmain.view = False 'Hide Message frane 
                    ShopFunction(10, 4, "Item added to inventory") 'Run Shop Script 

                End If
            Case 8 'Mega Heal seller  
                frmmain.txt = "Hi My name is Brad " & vbCrLf & "Would you like to buy a Mega Heal potions for 50 gold ? " & vbCrLf & "Press I & O together to buy!" 'Display message 
                frmmain.view = True 'Show message 
                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed

                    frmmain.view = False 'Hide Message frane 
                    ShopFunction(50, 5, "Item added to inventory") 'Run Shop Script 

                End If
            Case 9 'Healer
                frmmain.txt = "Hi My name is Jack " & vbCrLf & "Would you like me to Heal you to complete health for 1 gold ? " & vbCrLf & "Press I & O together to Heal!" 'Display message 
                frmmain.view = True 'Show message 
                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed

                    frmmain.view = False 'Hide Message frane 
                    ShopFunction(1, -1, "You Have Been Healed") 'Run Shop Script 

                End If
            Case 10 'Battle with Lord Bishop 

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "I shall defeat you The Fallen" & vbCrLf & "You will Never Rise" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed

                    BattleFunction(X, Y, 2, 120, "Lord Bishop")
                End If
            Case 11 'Battle with Smith 

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "I shall defeat you The Fallen" & vbCrLf & "You will Never Rise" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed

                    BattleFunction(X, Y, 3, 135, "Ms.Smith")
                End If
            Case 12 'Battle with The teller 

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "Oh , You are challenging Me" & vbCrLf & "LOL !!!!!!!!!" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 3, 140, "Pink Curse")
                End If
            Case 13 'Battle with The wise punk

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "Ah........" & vbCrLf & "You Must Die!" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 4, 160, "The Wise Punk")
                End If
            Case 14 'Battle with Wise Monk 

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "Blah , Blah , Blah , Blah ." & vbCrLf & "Lets Get this Over with !" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 4, 140, "The Wise Monk ")
                End If
            Case 15 'Battle with Count Doom 

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "I Smell Blood of the Fallen " & vbCrLf & "Come Here ......" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 5, 200, "Count Doom ")
                End If
            Case 16 'Battle with Hunting Hawk 

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "I Sense the soul of the fallen" & vbCrLf & "Challenge me if you dare!" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 6, 250, "Hunting Hawk")
                End If
            Case 17 'Battle with Snow Girl 

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "The Fallen , you are supposed to be dead" & vbCrLf & "Anyway I will Freeze you if you challenge me" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 7, 250, "Snow Girl ")
                End If
            Case 18 'Battle with Wise Man 

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "The Fallen you must master The wise before you can challenge " & vbCrLf & "the ignorant" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 8, 250, "The Wise One")
                End If
            Case 19 'Sign 
                frmmain.txt = "The Dungeon of the Master" & vbCrLf & "Enter to Challenge the Master" & vbCrLf & "Remember to buy alot of potions before entering" 'Set Message
                frmmain.view = True 'Show Message
            Case 20 'Battle with The purple curse

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "Oh , You are challenging Me" & vbCrLf & "LOL !!!!!!!!!" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 3, 140, "Purple Curse")
                End If
            Case 21 'Battle with The purple curse

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "Battle or Not" & vbCrLf & "you will lose" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 9, 205, "Reactor")
                End If
            Case 22 'Battle with the Knight 

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "Back Off" & vbCrLf & "Weakling " & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 10, 205, "Knight of Phoenix")
                End If
            Case 23 'Battle with Town Guards

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "Its My Duty To...." & vbCrLf & "Destroy you " & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 10, 100, "Town Guard")
                End If
            Case 24 'Battle with running Hawk 

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "You Hurt my Sister" & vbCrLf & "I am going to now defeat you !" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 6, 250, "Running Hawk")
                End If

            Case 25 'Battle with Count Maul

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "I Smell Blood of the Fallen " & vbCrLf & "Come Here ......" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 5, 250, "Count Maul")
                End If

            Case 26 'Castle sign 

                'Display messsage 

                frmmain.txt = "Welcome to The Castle of The Lord" & vbCrLf & "Enter If you Dare" & vbCrLf & "Note : You Must Be A level 21 Master to Enter" 'Set Message
                frmmain.view = True 'Show Message

            Case 27 'Castle of The Lord

                'Let Player Enter only if they are level 21
                If modSaveData.level >= 21 Then
                    BackUp() 'Backup Main Map 
                    Map2() 'Load Map 2
                    modSaveData.map = 2 'Set Map to 2 
                Else
                    MsgBox("You may not enter. You are not a Level 21 Master") 'Display Error Message 
                End If

            Case 28 'Battle with The lord

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "I am the lord !!!!" & vbCrLf & "Come Here ......" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 11, 500, "The Lord")
                End If

            Case 29 'Exit Building
                frmmain.IsRunning = False 'Stop Game engine

                'Load Backup array into main array 
                For count As Integer = 0 To 100
                    For count2 As Integer = 0 To 100
                        For layer As Integer = 0 To 10
                            frmmain.Map(count, count2, layer) = MapBackUp(count, count2, layer)
                        Next
                    Next
                Next

                'Make Player Visible on Mini Map
                frmMiniMap.picPlayer.Visible = True

                'Set Map back to 1
                modSaveData.map = 1

                'Chnage Minimap Image
                frmMiniMap.BackgroundImage = My.Resources.MiniMap1

                'Restart Game Engine 
                frmmain.IsRunning = True
                frmmain.StartGameLoop()

            Case 30 'Dungeon of the Master

                'Let Player Enter only if they have 1 badge
                If modSaveData.items(3) = 1 Then
                    BackUp() 'Backup Main Map 
                    Map2() 'Load map 
                    modSaveData.map = 3 'Set Map to 3

                ElseIf modSaveData.items(3) > 1 Then 'Don't allow the player to re-eneter if they have already won 

                    MsgBox("You May not Re Enter , The Master Has Forbid you as your face reminds him of his pathetic loss") 'Display Error Message 

                Else
                    MsgBox("You may not enter. You are need atleast 1 badge to enter") 'Display Error Message 
                End If
            Case 31 'Battle with The Master

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "I am the Master!!!" & vbCrLf & "Come Here ......" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 12, 750, "The Master")
                End If
            Case 32 'Leaders sign 

                'Display messsage 

                frmmain.txt = "Welcome to The House of the Awesome Leaser" & vbCrLf & "Enter If you Dare" & vbCrLf & "Note : You Must have 2 badges to enter" 'Set Message
                frmmain.view = True 'Show Message

            Case 33 'Leaders House\

                'Let Player Enter if he/she has 2 badges
                If modSaveData.items(3) = 2 Then
                    BackUp() 'Backup Main Map 
                    Map2() 'Load Map 2
                    modSaveData.map = 4 'Set Map to 4 

                Else
                    MsgBox("You may not enter. You a do not have 2 badges") 'Display Error Message 
                End If

            Case 34 'Battle with The Leader

                'Display messsage of go to battle depending on weather I has been pressed on this tile or not 

                frmmain.txt = "I am the Leader" & vbCrLf & "How Dare you Enter my house" & vbCrLf & "Press ( I & O ) Together  to Battle Me" 'Set Message
                frmmain.view = True 'Show Message

                If frmmain.GetKeyState(Keys.O) = True Then 'Continue when I and O are both pressed
                    BattleFunction(X, Y, 13, 850, "The Leader")
                End If
        End Select

    End Sub

    'Run Battle Script and Set AI Values 
    Private Sub BattleFunction(ByVal X As Integer, ByVal Y As Integer, ByVal ID As Integer, ByVal AI As Integer, ByVal Name As String)
        frmmain.view = False 'Hide Message frane n
        BattleX = X 'Set X value for battle 
        BattleY = Y 'Set Y Value for Battle 
        frmBattle.opName = Name 'Set Name
        frmBattle.Max = AI 'Set AI Health 
        frmmain.Opacity = 0 'Hide Main window
        frmBattle.playID = ID 'Set Battle ID 
        frmBattle.Show() 'Open Battle Window
        frmmain.IsRunning = False 'Stop Game Engine 
        My.Computer.Audio.Stop() 'Stop In-game music 
        frmBattle.BringToFront() 'Bring Window to front
    End Sub

    'Run Shop Script to check if player has enough money and to take away money from player
    Private Sub ShopFunction(ByVal cost As Integer, ByVal item As Integer, ByVal message As String)

        If modSaveData.gold = cost Or modSaveData.gold > cost Then 'Make sure user has enough money 
            modSaveData.gold = modSaveData.gold - cost 'Subtract gold

            'Add 1 item to inventory only if a item is being purchased and not a service 
            If item > -1 Then
                modSaveData.items(item) = modSaveData.items(item) + 1 'Add 1  item to inventory 
                MsgBox(message) 'Display added item to inventory message

            ElseIf item = -1 Then 'Healer Item ID 
                modSaveData.health = modSaveData.maxHealth 'Heal Player 
                MsgBox(message) 'Display Message 
            End If

        Else
            'If user doesn't have enough money display error 
            MsgBox("Sorry, You dont have enough gold")
        End If

    End Sub

    'Back-Up Entire Map to backup array 
    Private Sub BackUp()

        For count As Integer = 0 To 100
            For count2 As Integer = 0 To 100
                For layer As Integer = 0 To 10
                    MapBackUp(count, count2, layer) = frmmain.Map(count, count2, layer)
                Next
            Next
        Next


    End Sub

    'Load Map 2 from modMap2.vb 
    Private Sub Map2()
        frmmain.IsRunning = False 'Stop Game engine 
        modMap2.MapLoad2(frmmain.Map) 'Load Map 2

        frmMiniMap.BackgroundImage = My.Resources.MiniMap2 'Change Mini Map Image
        frmMiniMap.picPlayer.Visible = False 'Make Player Invisible on Mini Map 


        'Restart Game Engine 
        frmmain.IsRunning = True


    End Sub
End Module
