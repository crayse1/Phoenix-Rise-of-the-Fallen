'Phoenix : A Massive RPG 
'ICS3U ISU 
'ISU by : Harsh Mistry 
'Powered by the Qian Engine : A Infinity Computing Production 

'Import System File writing libraries
Imports System
Imports System.IO
Imports System.Text

Module modSaveData
    'Data Variables
    Public map As Integer = 1
    Public items(100) As Integer
    Public health As Integer = 100
    Public level As Integer = 1
    Public xp As Integer = 0
    Public castle1 As Boolean = False
    Public castle2 As Boolean = False
    Public castle3 As Boolean = False
    Public boss As Boolean = False
    Public time As Integer = 0
    Public heals As Integer = 3
    Public maxHealth As Integer = 100
    Public gold As Integer = 100
    Public maxXP As Integer = 100
    Public Level2 As Boolean
    Public Level3 As Boolean
    Public Level6 As Boolean
    Public Level9 As Boolean
    Public level13 As Boolean
    Public level16 As Boolean
    Public level21 As Boolean
    Public boss1 As Boolean
    Public boss2 As Boolean
    Public boss3 As Boolean
    Public interact(100, 100) As Integer
    Public loaded As Boolean




    'File Saving Variables
    Public txtPath As String
    Dim file As System.IO.StreamWriter

    'File Loading Variables
    Public txtLoad As String
    Dim load As System.IO.StreamReader



    'Write save data to data file
    Public Sub Writer()
        'Add File Name to end of file path 
        txtPath = txtPath & "\GameSave.phoenix"

        'Add other variables to end of items array 
        items(100) = map
        items(99) = health
        items(98) = level
        items(97) = xp
        items(96) = castle1
        items(95) = castle2
        items(94) = castle3
        items(93) = boss
        items(92) = time
        items(91) = heals
        items(90) = maxHealth
        items(89) = frmmain.MapX
        items(88) = frmmain.MapY
        items(87) = frmmain.MainX
        items(86) = frmmain.MainY
        items(85) = gold
        items(84) = maxXP
        items(83) = Level2
        items(82) = Level3
        items(81) = Level6
        items(80) = Level9
        items(79) = level13
        items(78) = level16
        items(77) = level21
        items(76) = boss1
        items(75) = boss2


        'Initilize File Writer 
        file = My.Computer.FileSystem.OpenTextFileWriter(txtPath, False)


        'Write items array to text file 
        For count As Integer = 0 To 100
            file.WriteLine(items(count))
        Next

        'Write Interact layer to text file 
        For count As Integer = 0 To 100
            For count2 As Integer = 0 To 100
                file.WriteLine(frmmain.Map(count, count2, 4))
            Next
        Next


        'Write Moves to text file
        For count As Integer = 0 To 4
            For count2 As Integer = 0 To 1
                file.WriteLine(frmBattle.Moves(count, count2))
            Next
        Next

        file.Close()

    End Sub

    'Load Save File 
    Public Sub Reader()
        'Initilize File Reader 
        If txtLoad <> Nothing Then
            load = My.Computer.FileSystem.OpenTextFileReader(txtLoad)


            'Set loaded value to true 
            loaded = True

            'Read Each line and write each value to items array
            For count As Integer = 0 To 100
                items(count) = load.ReadLine()

            Next

            'Read Each line and add values to interact array
            For count As Integer = 0 To 100
                For count2 As Integer = 0 To 100
                    interact(count, count2) = load.ReadLine
                Next
            Next

            'Read Each line and add to moves array 
            For count As Integer = 0 To 4
                For count2 As Integer = 0 To 1
                    frmBattle.Moves(count, count2) = load.ReadLine
                Next
            Next

            'Assign last 9 values to the proper save data variables 
            map = items(100)
            health = items(99)
            level = items(98)
            xp = items(97)
            castle1 = (96)
            castle2 = items(95)
            castle3 = items(94)
            boss = items(93)
            time = items(92)
            heals = items(91)
            maxHealth = items(90)
            frmmain.MapX = items(89)
            frmmain.MapY = items(88)
            frmmain.MainX = items(87)
            frmmain.MainY = items(86)
            gold = items(85)
            maxXP = items(84)
            Level2 = items(83)
            Level3 = items(82)
            Level6 = items(81)
            Level9 = items(80)
            level13 = items(79)
            level16 = items(78)
            level21 = items(77)
            boss1 = items(76)
            boss2 = items(75)

        End If


    End Sub
End Module
