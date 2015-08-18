'ISU by : Harsh Mistry 
'Phoenix : A Massive RPG 
'May 1st , 2014 - June 13th , 2014 
'Powered by the Qian Engine : A Infinity Computing Production 

Public Class frmGameOver

    Private Sub picExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picExit.Click
        'Exit Application
        End

    End Sub

    'Stop All proccess when X button is pressed
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End 'Close Application


    End Sub

    Private Sub picHeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Heal Player if the player still has some heals left 
        If modSaveData.heals > 0 Then
            modSaveData.health = maxHealth  'Replenish Health 
            modSaveData.heals = modSaveData.heals - 1 'subtract 1 heal 


            'Show Message 
            MsgBox("You have " & modSaveData.heals & " Heals Left" & vbCrLf & "You are Lucky this isn't a EA Game" & vbCrLf & "Otherwise this would have cost you $0.99" & vbCrLf & "Hint : Use Mega Heal Potions to heal yourself", MsgBoxStyle.Exclamation)

            'Show Game Screen 
            Me.Hide()
            frmmain.Show()
            frmmain.Opacity = 100

            'Run Game engine 
            frmmain.IsRunning = True
            frmmain.StartGameLoop()
        Else
            MsgBox("You Don't have any Heal(s) left , Please use the load button to load a previous game or restart the app to start a new game") 'Display Error 
        End If
    End Sub

    Private Sub picLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLoad.Click
        'Declare Dialog Variable 
        Dim dialog As New OpenFileDialog

        'Make desktop the default folder 
        dialog.InitialDirectory = Environment.SpecialFolder.Desktop

        'Set dialog box title 
        dialog.Title = "Select Save File to Load"

        'Show Dialog box , Get File path , and only let player load file if Ok is selected
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            modSaveData.txtLoad = dialog.FileName.ToString 'If ok button clicked then set txtload to = path selected

            'Stop Game engine 
            frmmain.IsRunning = False

           

            'Dont Let Player Load file if they are on Map 2
            If modSaveData.map <> 1 Then

                'Erase Original Map 
                For count As Integer = 0 To 100
                    For count2 As Integer = 0 To 100
                        For layer As Integer = 0 To 10
                            frmmain.Map(count, count2, layer) = 0 'Set all cells to  = 0 
                            frmmain.Map(count, count2, 0) = 0 'Make Background lava 
                        Next
                    Next
                Next

                'Load map from backup array 
                For count As Integer = 0 To 100
                    For count2 As Integer = 0 To 100
                        For layer As Integer = 0 To 10
                            frmmain.Map(count, count2, layer) = modInteract.MapBackUp(count, count2, layer)
                        Next
                    Next
                Next

                'Make Player Visible on Mini Map
                frmMiniMap.picPlayer.Visible = True



                'Chnage Minimap Image
                frmMiniMap.BackgroundImage = My.Resources.MiniMap1
            End If

            'Load Items File reader
            modSaveData.Reader()

            'Set Map back to 1
            modSaveData.map = 1

            'Restart Game Engine 
            frmmain.IsRunning = True


            'Hide form and bring up main game screen 
            Me.Hide()
            frmmain.Opacity = 100
            frmmain.Show()
            frmmain.StartGameLoop()

        End If

        

    End Sub
End Class