'ISU by : Harsh Mistry 
'Phoenix : A Massive RPG 
'May 1st , 2014 - June 13th , 2014 
'Powered by the Qian Engine : A Infinity Computing Production 


'Import system drawing libraries 
Imports System.Drawing

'Import System imaging tools 
Imports System.Drawing.Imaging.PixelFormat





Public Class frmmain
  
    'Map Variables
    Dim ResWidth As Integer = 750
    Dim ResHeight As Integer = 550
    Public TileSize As Integer = 32


    'Key Detection Variables
    Dim KeyPush As Short = 0
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    'Graphics Variables 
    Dim G As Graphics ' Main Graphics Variable 
    Dim BBG As Graphics 'Back Buffer to Prevent Flickering 
    Dim BB As Bitmap
    Dim bmpTile As Bitmap 'Copy background tiles to this layer 

    Public srect As Rectangle
    Dim drect As Rectangle


    'Frame Per Second Counter Variables 
    Public tSec As Integer = TimeOfDay.Second
    Public tFrames As Integer = 0
    Public MaxFrames As Integer = 0

    ' Map Variables
    Public Map(100, 100, 10) As Integer
    Public MapX As Double = 20 'Total Map Width 
    Public MapY As Double = 20 'Total Map Height 

    'Game Running Variables 
    Public IsRunning As Boolean = True  'Store Weather Game is running or not

    'Mouse Location Variables 
    Public mouseX As Integer ' Mosue X Position on Grid 
    Public mouseY As Integer 'Mouse Y Position on Grid 
    Public mMapX As Integer 'Mouse X Position on Map 
    Public mMapY As Integer 'Mouse Y Position on Map 

    'Main Character Variables
    Dim bmpChar As Bitmap   'copy Main Character tiles to this layer 
    Dim xPos As Integer = 0
    Dim yPos As Integer = 0
    Dim MoveSpeed As Integer = 8
    Dim MoveDir As Short = 0
    Dim LastDir As Short = 2
    Public MainX As Decimal = (MapX + 9) * TileSize
    Public MainY As Decimal = (MapY + 6) * TileSize


    'Debug Variables
    Dim debug As Boolean = False

    'Foreground variables 
    Dim bmpFore As Bitmap ' Copy Foreground tiles to this layer 

    'NPC variables 
    Dim bmpNPC As Bitmap 'Copy Npc tiles to this layer 
    Dim animate As Integer

    'Foreground 2 Layer variables 
    Dim bmpFore2 As Bitmap

    'Building Variables 
    Dim bmpBuild As Bitmap
    Dim buildX As Integer 'Building Width 
    Dim buildY As Integer 'Building Height


    'Message box variables 
    Public txt As String
    Public bmpMessage As Bitmap
    Public view As Boolean

    'Money Variables 
    Dim bmpWallet As Bitmap
    Dim bank As String
    Dim viewBank As Boolean = False
   
    'Bitmap Conversion Variables 
    Dim bmpConverted1 As Bitmap
    Dim bmpConverted2 As Bitmap
    Dim bmpConverted3 As Bitmap
    Dim bmpConverted4 As Bitmap
    Dim bmpconverted5 As Bitmap
    Dim bmpconverted6 As Bitmap
    Dim bmpconverted7 As Bitmap

    'Mini Map Varaibles 
    Dim Mini As Boolean = False

    'Music Variables 
    Public playMusic As Boolean




    Public Function GetKeyState(ByVal key1 As Integer) As Boolean
        'Get Key pressed
        Dim s As Short
        s = GetAsyncKeyState(key1)
        If s = 0 Then Return False

        Return True
    End Function
    Private Sub SetInteractAction()
        'Interact Button Pressed 
        If GetKeyState(Keys.I) = True Then
            GetInteractAction(MainX, MainY)
        End If

        'Debug button Pressed (Tilde Key)
        If GetKeyState(Keys.Oemtilde) = True Then

            'Activate or deactivate debug mode based on debug variable 
            If debug = False Then
              
                    debug = True 'Set debug mode to True
                    picLogo.Visible = False 'Hide logo


            Else
                debug = False 'Set debug mode to false 
                picLogo.Visible = True 'Show Logo 

            End If
        End If

        'Close Message box 
        If GetKeyState(Keys.O) = True Then
            view = False 'Close Message Box's 
            viewBank = False 'Close Bank Message box
        End If

        'Open/close Mini Map 
        If GetKeyState(Keys.P) = True Then
            Select Case Mini 'Check if Form is to be closed or opened
                Case False
                    Mini = True 'Set variable to true , so next time button is clicked ; the form closes
                    frmMiniMap.Show() 'Show minimap
                Case Else
                    Mini = False 'Reset Mini variable
                    frmMiniMap.Hide() 'Hide minimap 
            End Select
        End If

        'Open/close bank message box 
        If GetKeyState(Keys.U) = True Then

            viewBank = True 'Display message box 

        End If

    End Sub



    Private Sub SetMoveDir()
        'Set Direction based on key pressed 
        If GetKeyState(Keys.W) = True Then MoveDir = 1
        If GetKeyState(Keys.S) = True Then MoveDir = 2
        If GetKeyState(Keys.A) = True Then MoveDir = 3
        If GetKeyState(Keys.D) = True Then MoveDir = 4
        If GetKeyState(Keys.Up) = True Then MoveDir = 1
        If GetKeyState(Keys.Down) = True Then MoveDir = 2
        If GetKeyState(Keys.Left) = True Then MoveDir = 3
        If GetKeyState(Keys.Right) = True Then MoveDir = 4


        'Set move direction back to 0 once key is released
        If GetKeyState(Keys.W) = False And _
            GetKeyState(Keys.S) = False And _
            GetKeyState(Keys.A) = False And _
            GetKeyState(Keys.D) = False And _
            GetKeyState(Keys.Up) = False And _
            GetKeyState(Keys.Down) = False And _
            GetKeyState(Keys.Left) = False And _
            GetKeyState(Keys.Right) = False Then

            MoveDir = 0
        End If

        'Make LastDirection = Move direction 
        If MoveDir <> 0 Then LastDir = MoveDir
    End Sub

    Private Sub frmmain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If playMusic = True Then ' Play music if Play music is true 
            'Play Background Music 
            My.Computer.Audio.Play(My.Resources._01_prelude, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

  

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    

        ' Show Form to prevent Breaks in Loop 
        Me.Show()
        Me.Focus()

        

        'Set Default player moves 
        frmBattle.Moves(0, 0) = 3

        'If a save file was loaded Add Save File location to form title 
        If modSaveData.txtLoad <> Nothing Then
            Me.Text = Me.Text & " ---- Save File Loaded : " & modSaveData.txtLoad
        End If

        ' Initialize Graphics Objects 
        G = Me.CreateGraphics
        BB = New Bitmap(ResWidth, ResHeight) ' Create Back buffer size of the form 
        bmpTile = New Bitmap(My.Resources.background) 'Background graphics 
        bmpChar = New Bitmap(My.Resources.Main_Character) 'Main Character Graphics 
        bmpFore = New Bitmap(My.Resources.foreground) 'Foreground graphics 
        bmpNPC = New Bitmap(My.Resources.Wise_Intro_Man) 'Npc Graphics
        bmpFore2 = New Bitmap(My.Resources.foreground) 'Foreground 2 graphics 
        bmpMessage = New Bitmap(My.Resources.frame) 'Message Box Frame graphics 
        bmpWallet = New Bitmap(My.Resources.frame_gold) 'Message box for current money in wallet/bank
        bmpBuild = New Bitmap(My.Resources.Building_Tileset) 'Building Graphics

        'Make tileset backgrounds transparent 
        bmpNPC.MakeTransparent(Color.White)  'Npc Tileset
        bmpFore.MakeTransparent(Color.White)  ' Foreground tile set 
        bmpFore2.MakeTransparent(Color.White)  ' Foreground 2 tile set 
        bmpMessage.MakeTransparent(Color.Fuchsia) 'Message box frame
        bmpWallet.MakeTransparent(Color.Fuchsia) 'Gold box 


        'Convert bitmaps to faster "32bppPargb" pixel format to speed up frame rates
        bmpConverted1 = bmpTile.Clone(New Rectangle(Point.Empty, bmpTile.Size), Imaging.PixelFormat.Format32bppPArgb) 'Background
        bmpConverted2 = bmpFore.Clone(New Rectangle(Point.Empty, bmpFore.Size), Imaging.PixelFormat.Format32bppPArgb) 'Foreground
        bmpConverted3 = bmpNPC.Clone(New Rectangle(Point.Empty, bmpNPC.Size), Imaging.PixelFormat.Format32bppPArgb)   'Npc's
        bmpConverted4 = bmpChar.Clone(New Rectangle(Point.Empty, bmpChar.Size), Imaging.PixelFormat.Format32bppPArgb) 'Main Character
        bmpconverted5 = bmpFore2.Clone(New Rectangle(Point.Empty, bmpFore2.Size), Imaging.PixelFormat.Format32bppPArgb) 'Foreground 2
        bmpconverted6 = bmpMessage.Clone(New Rectangle(Point.Empty, bmpMessage.Size), Imaging.PixelFormat.Format32bppPArgb) 'Message box frame 
        bmpconverted7 = bmpBuild.Clone(New Rectangle(Point.Empty, bmpBuild.Size), Imaging.PixelFormat.Format32bppPArgb) 'Building Tileset

        'Load Map Values based on sav
        Select Case modSaveData.map
            Case 1
                modMap1.loadMap1(Map)
            Case 2
                modMap2.MapLoad2(Map)
        End Select

        'Load interact layer  values if the game was loaded from a previous save file 
        If modSaveData.loaded = True Then
            For count As Integer = 0 To 100
                For count2 As Integer = 0 To 100
                    Map(count, count2, 4) = modSaveData.interact(count, count2)
                Next
            Next
        End If


   

        'Start Game Loop 
        StartGameLoop()
    End Sub

    Public Sub StartGameLoop()
        Do While IsRunning = True
            'Keep App responsive to future commands to prevent endless loop 
            Application.DoEvents()

            '---------------------Background Actions For Essential Operation --------------------

            '1 : Check user input 
            SetMoveDir()
            MoveMap(MoveDir)
            SetInteractAction()

            '2 : Draw Graphics 
            DrawGraphics()

            '3 : Check User HP
            If modSaveData.health <= 0 Then
                IsRunning = False 'Stop Game

                'Hide All forms except main form
                frmInventory.Hide()
                frmAbout.Hide()
                frmMainMenu.Hide()
                frmStat.Hide()

                'Show game over screen
                frmGameOver.Show()
            End If





            'Update FPS counter
            FrameCounter()

        Loop
    End Sub


    'Move the Map in the desired direction when Move direction changes 
    Private Sub MoveMap(ByVal dir As Short)
        Select Case dir
            Case 1 'Move Character up 1
                If Map(MainX / TileSize, Math.Ceiling(MainY / TileSize) - 1, 1) = 0 Then 'Check if next block is passable or solid 


                    yPos = yPos + MoveSpeed
                    MainY = (MainY - MoveSpeed) 'Adjust Main value to make sure rounding is done properly 


                    If yPos >= TileSize Then
                        yPos = 0
                        MapY = MapY - 1 'Move the Map 1 block to the left 
                    End If
                End If
            Case 2 'Move Character down 1
                If Map(MainX / TileSize, Math.Floor(MainY / TileSize) + 1, 1) = 0 Then 'Check if next block is passable or solid 
                    yPos = yPos - MoveSpeed
                    MainY = (MainY + MoveSpeed) 'Adjust Main value to make sure rounding is done properly 

                    If yPos <= TileSize * -1 Then
                        yPos = 0
                        MapY = MapY + 1 'Move the Map 1 block to the right
                    End If
                End If
            Case 3  'Move Character left 1
                If Map(Math.Ceiling(MainX / TileSize) - 1, MainY / TileSize, 1) = 0 Then 'Check if next block is passable or solid 
                    xPos = xPos + MoveSpeed
                    MainX = (MainX - MoveSpeed) 'Adjust Main value to make sure rounding is done properly 

                    If xPos >= TileSize Then
                        xPos = 0
                        MapX = MapX - 1 'Move the Map 1 block up 
                    End If
                End If
            Case 4 'Move Character right 1
                If Map(Math.Floor(MainX / TileSize) + 1, MainY / TileSize, 1) = 0 Then 'Check if next block is passable or solid 

                    xPos = xPos - MoveSpeed
                    MainX = (MainX + MoveSpeed) 'Adjust Main value to make sure rounding is done properly 


                    If xPos <= TileSize * -1 Then
                        xPos = 0
                        MapX = MapX + 1 'Move the Map 1 block down 
                    End If
                End If
        End Select
    End Sub

    Private Sub DrawGraphics()


        'Draw tiles on layers  0 to 5 onto the screen
        For X = -1 To 19
            For Y = -1 To 14
                For Layer = 0 To 5

                    If Layer = 0 Or Layer = 2 Or Layer = 3 Or Layer = 5 Then 'Only draw tiles if layer = 0 , 2 , 3, or 5
                        GetSourceRect(MapX + X, MapY + Y, Layer) 'Call Source rectangle sub procedure 
                        drect = New Rectangle((X * TileSize) + xPos, (Y * TileSize) + yPos, TileSize, TileSize)
                        If Layer = 0 Then
                            G.DrawImage(bmpConverted1, drect, srect, GraphicsUnit.Pixel) 'Background Tiles
                        ElseIf Layer = 2 Then
                            G.DrawImage(bmpConverted2, drect, srect, GraphicsUnit.Pixel) 'Foreground Tiles
                        ElseIf Layer = 3 Then
                            G.DrawImage(bmpConverted3, drect, srect, GraphicsUnit.Pixel)   'Npc Tiles
                        ElseIf Layer = 5 Then
                            G.DrawImage(bmpconverted5, drect, srect, GraphicsUnit.Pixel) 'Foreground 2 tiles 
                        End If
                    End If
                Next
            Next
        Next




        'Get right Tile based on direction and draw character to the screen
        GetCharacter(LastDir)
        G.DrawImage(bmpConverted4, 9 * TileSize, 6 * TileSize, srect, GraphicsUnit.Pixel)



        'Draw 2.5D Tiles 
        For x = -1 To 19
            For y = -1 To 14

                GetSourceRect(MapX + x, MapY + y, 6) 'Call Source rectangle sub procedure 
                drect = New Rectangle((x * TileSize) + xPos, (y * TileSize) + yPos, TileSize, TileSize)
                G.DrawImage(bmpconverted5, drect, srect, GraphicsUnit.Pixel) 'Draw 2.5D Tiles 

            Next
        Next


        'Draw Buildings on screen
        For x = -3 To 21
            For y = -9 To 16

                GetSourceRect2(MapX + x, MapY + y, 7, buildX, buildY) 'Call Source rectangle sub procedure 
                drect = New Rectangle((x * TileSize) + xPos, (y * TileSize) + yPos, buildX, buildY)
                G.DrawImage(bmpconverted7, drect, srect, GraphicsUnit.Pixel) 'Draw 2.5D Tiles 

            Next
        Next



        'Messagebox Drawing Script

        If view = True Then 'Only Draw to screen if the message box is supposed to be viewed
            Message() 'Load sub event procedure
        ElseIf viewBank = True Then 'Draw Bank Message box
            gold()
        End If


        ' Debugging Features(Only activate when debug mode is active)
        If debug = True Then

            'Highlight the portion of the grid that is currently selected 
            G.DrawRectangle(Pens.Red, mouseX * TileSize, mouseY * TileSize, TileSize, TileSize)



            'Draw Frame Counter and Display Mouse Position (if Debug mode is active )
            G.DrawString("Frame: " & tFrames & vbCrLf & _
                         "FPS: " & MaxFrames & vbCrLf & _
                         "M MapX: " & mMapX & vbCrLf & _
                         "M MapY: " & mMapY & vbCrLf & _
                         "", Me.Font, Brushes.Red, 650, 0)
        End If


        'Copy backbuffer to Graphics object 
        G = Graphics.FromImage(BB)


        ' Draw back buffer to screen 
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, 0, 0, ResWidth, ResHeight)

        ' Fix Overdraw
        G.Clear(Color.Black)

        'Update collisions 
        modMap1.Collisions(Map)

        'Update Interact Values 
        modMap2.UpdateInteract(Map)



    End Sub

    Private Sub GetCharacter(ByVal dir As Short)
        'Get Character tile based on direction
        Select Case dir
            Case 0
                srect = New Rectangle(0, 0, TileSize, TileSize)
            Case 1
                srect = New Rectangle(0, 96, TileSize, TileSize)
            Case 2
                srect = New Rectangle(0, 0, TileSize, TileSize)
            Case 3
                srect = New Rectangle(0, 32, TileSize, TileSize)
            Case 4
                srect = New Rectangle(0, 64, TileSize, TileSize)
        End Select
    End Sub

    'Count Frames per second based on time of day 
    Private Sub FrameCounter()

        If tSec = TimeOfDay.Second And IsRunning = True Then 'Only Count frames if Game is running 
            tFrames = tFrames + 1
        Else  ' If Game is not running then set framerate to 0 
            MaxFrames = tFrames
            tFrames = 0
            tSec = TimeOfDay.Second
        End If
    End Sub


    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'Get Mouse Location and round down to make sure correct tile is selected 
        mouseX = Math.Floor(e.X / TileSize)
        mouseY = Math.Floor(e.Y / TileSize)

        'Get The Position of the Mouse in relation to the entire Map 
        mMapX = MapX + mouseX
        mMapY = MapY + mouseY

    End Sub


    'Check Colliders
    Private Function blocked(ByVal dir As Short) As Boolean

        'Determine if the next tiles are passable or solid (1 = solid , 0 = pass) 
        Select Case dir
            Case 0 ' North Tile
                If Map(MainX / TileSize, Math.Ceiling(MainY / TileSize) - 1, 1) = 1 Then
                    Return True
                End If
            Case 1 ' South Tile
                If Map(MainX / TileSize, Math.Floor(MainY / TileSize) + 1, 1) = 1 Then
                    Return True
                End If
            Case 2 ' West Tile
                If Map(Math.Ceiling(MainX / TileSize) - 1, MainY / TileSize, 1) = 1 Then
                    Return True
                End If
            Case 3 ' East Tile
                If Map(Math.Floor(MainX / TileSize) + 1, MainY / TileSize, 1) = 1 Then
                    Return True
                End If
        End Select

        Return False
    End Function

    Private Sub picexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picexit.Click
        'Exit application after saving 
        End
    End Sub

    Private Sub picInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picInventory.Click
        'Open inventory window 
        frmInventory.Show()
    End Sub

    'Stop All proccess when X button is pressed
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing  
        End 'Close Application
      

    End Sub

    Private Sub picStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picStat.Click
        'Load Status window
        frmStat.Show()
    End Sub

    ' Keep track of play time 
    Private Sub tmrGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGame.Tick
        
        'Add 1 second to play time 
        modSaveData.time = modSaveData.time + 1

    End Sub

    Private Sub picSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSave.Click


        'Declare Dialog Variable 
        Dim dialog As New FolderBrowserDialog

        'Set description
        dialog.Description = "Select Location to Save Data File"

        'Only Let Users save if they are on Map 1
        If modSaveData.map = 1 Then

            'Show Dialog box and geth file path 
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                modSaveData.txtPath = dialog.SelectedPath 'If ok button clicked then set txtpath to = path selected
            End If


            'Load Items File Writer 
            modSaveData.Writer()


            'Display Messag 
            MsgBox("Game Saved", MsgBoxStyle.Exclamation)

        Else
            MsgBox("You may only save while on the main map", MsgBoxStyle.Critical) 'Display Error Message 
        End If

    End Sub

    'Draw NPC Messages to the screen
    Private Sub Message()

        srect = New Rectangle(0, 0, 640, 145) 'Get Frame from tileset 
        G.DrawImage(bmpconverted6, 0, 315, srect, GraphicsUnit.Pixel) 'Draw Frame to screen
        G.DrawString(txt, frmGameOver.lblOver.Font, Brushes.Red, 10, 325) 'Display Text using font from gameover form 

    End Sub

    'Draw Money message box to screen
    Private Sub gold()

        srect = New Rectangle(0, 0, 640, 145) 'Get Frame from tileset 
        G.DrawImage(bmpWallet, 0, 315, srect, GraphicsUnit.Pixel) 'Draw Frame to screen
        bank = "Bank of Phoenix : " & vbCrLf & "Your Current Bank Balance is : " & vbCrLf & modSaveData.gold & " Gold"
        G.DrawString(bank, frmGameOver.lblOver.Font, Brushes.Red, 10, 325) 'Display Text using font from gameover form 

    End Sub


    'Refresh Health & XP every 0.5 seconds
    Private Sub tmrHP_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHP.Tick

        'Refresh the maximum health value 
        pgbHP2.Maximum = modSaveData.maxHealth

        'Refresh Max XP value 
        pgbXP2.Maximum = modSaveData.maxXP


        'Refresh Health  if its above 0 and if its above max health , correct the health value 
        If modSaveData.health > 0 And modSaveData.health <= modSaveData.maxHealth Then

            pgbHP2.Value = modSaveData.health 'Refresh Health 

        ElseIf modSaveData.health > modSaveData.maxHealth Then

            modSaveData.health = modSaveData.maxHealth 'Fix Health Value to Max 
            pgbHP2.Value = modSaveData.health 'Refresh Health 

        End If

        'Fix Xp if its over the max
        If modSaveData.xp > modSaveData.maxXP Then
            modSaveData.xp = modSaveData.maxXP
        End If

        'Refresh XP 
        pgbXP2.Value = modSaveData.xp
    End Sub

    'Set Level perks
    Private Sub tmrLevel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLevel.Tick

        Select Case modSaveData.level 'Set Level Perks based   on current level
            Case 2 'Level 2
                If modSaveData.Level2 = False Then 'Only Enable level 2 perks once 

                    modSaveData.Level2 = True 'Set Level 2 to true 
                    modSaveData.maxHealth = 120 'Set Max HP to 120 
                    modSaveData.maxXP = 130 'Set Max HP to 130 

                    'Display level Up Message 
                    txt = "You Have Leveled up to Level 2 " & vbCrLf & "Your Max Health has been upgraded to 120" & vbCrLf & "Press O to close this message"
                    view = True
                End If
            Case 3 'Level 3 
                If modSaveData.Level3 = False Then 'Only Enable level 3 perks once 

                    modSaveData.Level3 = True 'Set Level 3 to true 
                    modSaveData.maxHealth = 135 'Set Max HP to 135 
                    frmBattle.Moves(1, 0) = 5

                    'Display level Up Message 
                    txt = "You Have Leveled up to Level 3 " & vbCrLf & "Your Max Health has been upgraded to 135" & vbCrLf & "You have Learned the Move Shockwave" & vbCrLf & "Press O to close this message"
                    view = True
                End If
            Case 6 'Level 6
                If modSaveData.Level6 = False Then 'Only Enable level 3 perks once 

                    modSaveData.Level6 = True 'Set Level 6 to true 
                    modSaveData.maxHealth = 150 'Set Max HP to 150
                    frmBattle.Moves(2, 0) = 7

                    'Display level Up Message 
                    txt = "You Have Leveled up to Level 6 " & vbCrLf & "Your Max Health has been upgraded to 150" & vbCrLf & "You have Learned the Move Blood" & vbCrLf & "Press O to close this message"
                    view = True
                End If
            Case 9 'Level 9
                If modSaveData.Level9 = False Then 'Only Enable level 9 perks once 

                    modSaveData.Level9 = True 'Set Level 9 to true 
                    modSaveData.maxHealth = 180 'Set Max HP to 180
                    modSaveData.maxXP = 230 'Set max xp to 230 
                    frmBattle.Moves(3, 0) = 10

                    'Display level Up Message 
                    txt = "You Have Leveled up to Level 9 " & vbCrLf & "Your Max Health has been upgraded to 180" & vbCrLf & "You have Learned the Move Wise Attack" & vbCrLf & "Press O to close this message"
                    view = True
                End If

            Case 13 'Level 13
                If modSaveData.level13 = False Then 'Only Enable level 13 perks once 

                    modSaveData.level13 = True 'Set Level 13 to true 
                    modSaveData.maxHealth = 200 'Set Max HP to 200
                    modSaveData.maxXP = 300 'Set max xp to 300
                    frmBattle.Moves(4, 0) = 11

                    'Display level Up Message 
                    txt = "You Have Leveled up to Level 13 " & vbCrLf & "Your Max Health has been upgraded to 200" & vbCrLf & "You have Learned the Move Slash" & vbCrLf & "Press O to close this message"
                    view = True
                End If
            Case 16 'Level 16
                If modSaveData.level16 = False Then 'Only Enable level 16 perks once 

                    modSaveData.level16 = True 'Set Level 16 to true 
                    modSaveData.maxXP = 500 'Set max xp to 500


                    'Display level Up Message 
                    txt = "You Have Leveled up to Level 16 " & vbCrLf & "Max XP is now set to 500" & vbCrLf & "Press O to close this message"
                    view = True
                End If
            Case 21 'Level 21
                If modSaveData.level21 = False Then 'Only Enable level 21 perks once 

                    modSaveData.level21 = True 'Set Level 21 to true 
                    modSaveData.maxHealth = 280 'Set Max HP to 200


                    'Display level Up Message 
                    txt = "You Have Leveled up to Level 21 " & vbCrLf & "Your Max Health has been upgraded to 280" & vbCrLf & "Press O to close this message"
                    view = True
                End If
        End Select

        Select Case modSaveData.items(3) 'Assign Perks Based on Current Number of Badges 
            Case 1 '1 Badge 

                If modSaveData.boss1 = False Then 'Award 1 Badge perks only once
                    frmBattle.Moves(0, 0) = 12 'Award the player lordattack 
                    modSaveData.boss1 = True 'Set Boss 1 to true 
                    Map(74, 79, 4) = 0 'Make it so you can't Re-enter the castle 

                    'Display Message 
                    txt = "You Have Earned 1 Badge " & vbCrLf & "You have now learned the move Lord Attack" & vbCrLf & "Press O to close this message"
                    view = True
                End If
            Case 2 '2 badges
                If modSaveData.boss2 = False Then 'Award 2nd Badge perks only once
                    frmBattle.Moves(1, 0) = 13 'Award the player Master Attack 
                    modSaveData.boss2 = True 'Set Boss 1 to true 
                    modSaveData.maxHealth = 300 'Upgrade health to 300 

                    'Display Message 
                    txt = "You Have Earned the 2nd Badge " & vbCrLf & "You have now learned the move Master Attack" & vbCrLf & "Your Health has been upgraded to 300" & vbCrLf & "Press O to close this message"
                    view = True
                End If

            Case 3 '3 Badges
                Me.Opacity = 0 'Hide Main Form 
                frmFinish.Show() 'Show Finished Form 

        End Select
    End Sub


    'Animate certain Npc's By changing their tile values every 0.25 seconds
    Private Sub tmrAnimate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAnimate.Tick

        If modSaveData.map = 1 Then 'Only Animate Main NPC's when player is on Map 1
            animate = animate + 1 'Add 1 to animate to make sure the game renders the correct tile 

            Select Case animate 'Set Correct Tile Value based on animate integer 
                Case 1 'Animation Tile 1
                    Map(25, 34, 3) = 10
                    Map(33, 44, 3) = 13
                    Map(20, 84, 3) = 10
                    Map(29, 81, 3) = 13
                Case 2 'Animation Tile 2 
                    Map(25, 34, 3) = 11
                    Map(33, 44, 3) = 14
                    Map(20, 84, 3) = 11
                    Map(29, 81, 3) = 14

                Case 3 'Animation Tile 3
                    Map(25, 34, 3) = 12
                    Map(33, 44, 3) = 15
                    Map(20, 84, 3) = 12
                    Map(29, 81, 3) = 15

                Case 4 'Animation Tile 4
                    Map(25, 34, 3) = 11
                    Map(33, 44, 3) = 14
                    Map(20, 84, 3) = 11
                    Map(29, 81, 3) = 14

                Case 5 'Animation Tile 5
                    Map(25, 34, 3) = 10
                    Map(33, 44, 3) = 13
                    Map(20, 84, 3) = 10
                    Map(29, 81, 3) = 13
                    animate = 0 'Reset Animate Variable 

            End Select
        End If
    End Sub
End Class

