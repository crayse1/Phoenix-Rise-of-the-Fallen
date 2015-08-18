'ISU by : Harsh Mistry 
'Phoenix : A Massive RPG 
'May 1st , 2014 - June 13th , 2014 
'Powered by the Qian Engine : A Infinity Computing Production 
Public Class frmStat

    Private Sub frmStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set the Colour of the XP and HP bars
        pgbHP.ForeColor = Color.Red
        pgbXP.ForeColor = Color.Blue

    End Sub


    'Refresh values every 0.5 seconds
    Private Sub tmrRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefresh.Tick

        'Declare variables 
        Dim playTime As Long
        Dim Hours As Long
        Dim Minutes As Long
        Dim Seconds As Long
        Dim Kingdom As String = Nothing

        'Refresh Max health values
        pgbHP.Maximum = modSaveData.maxHealth

        'Refresh Max XP Values 
        pgbXP.Maximum = modSaveData.maxXP

        'Refresh Health value
        If modSaveData.health > 0 And modSaveData.health <= modSaveData.maxHealth Then 'Only refresh if Health is more then 0 and if its below max 

            pgbHP.Value = modSaveData.health 'Refresh progress Bar
            lblHP.Text = "HP : " & modSaveData.health & "/" & modSaveData.maxHealth 'Refresh label 

        ElseIf modSaveData.health > modSaveData.maxHealth Then 'Fix the Health Value if its above max

            modSaveData.health = modSaveData.maxHealth 'Fix Health Value 
            pgbHP.Value = modSaveData.health 'Refresh progress Bar
            lblHP.Text = "HP : " & modSaveData.health & "/" & modSaveData.maxHealth 'Refresh label 

        End If

        'Refresh XP Value 
        pgbXP.Value = modSaveData.xp

        lblXP.Text = "XP : " & modSaveData.xp & "/" & modSaveData.maxXP

        'Determine amount of time player 
        playTime = modSaveData.time

        'Determine current kingdom
        Select Case modSaveData.map
            Case 1
                Kingdom = " Current Map : Kingdom of Rise"
            Case 2
                Kingdom = " Current Map : The Castle of the Lord"
            Case 3
                Kingdom = " Current Map : The Dungeon of the Master"
            Case 4
                Kingdom = " Current Kingdom : The Leaders House"

        End Select

        'Determine numbers of Hours , Minutes , and seconds game has been played
        Hours = playTime \ 3600
        playTime = playTime Mod 3600
        Minutes = playTime \ 60
        Seconds = playTime Mod 60

        'Display Time Played in the time format (HH,MM,SS)
        lblTime.Text = "Time Played : " & Hours & " Hours : " & Minutes & " Minutes : " & Seconds & " Seconds"

        'Display Kingdom and player level 
        lblMap.Text = "Level : " & modSaveData.level & Space(10) & Kingdom
    End Sub

    Private Sub picExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picExit.Click
        'Exit Status Window
        Me.Hide()
    End Sub
End Class