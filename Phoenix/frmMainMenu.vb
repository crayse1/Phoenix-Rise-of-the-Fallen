'ISU by : Harsh Mistry 
'Phoenix : A Massive RPG 
'May 1st , 2014 - June 13th , 2014 
'Powered by the Qian Engine : A Infinity Computing Production 

Public Class frmMainMenu

    

    Private Sub picAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAbout.Click

        'Hide Main Menu and Show About Window
        frmAbout.Show()
        Me.Opacity = 0

    End Sub

    Private Sub picNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picNew.Click
        'Stop background music 
        My.Computer.Audio.Stop()

        'Hide Main Menu and Start Main Game
        Me.Opacity = 0
        frmmain.Show()
    End Sub

    Public Sub picLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLoad.Click

        'stop playing music
        My.Computer.Audio.Stop()

        'Declare Dialog Variable 
        Dim dialog As New OpenFileDialog

        'Make desktop the default folder 
        dialog.InitialDirectory = Environment.SpecialFolder.Desktop

        'Set dialog box title 
        dialog.Title = "Select Save File to Load"

        'Show Dialog box and geth file path 
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            modSaveData.txtLoad = dialog.FileName.ToString 'If ok button clicked then set txtload to = path selected
        Else
            Exit Sub 'Exit Sub if no file is selected
        End If


        'Load Items File reader
        modSaveData.Reader()


        'Hide Main Menu and bring up select game screen if a game file 
        Me.Opacity = 0
        frmmain.Show()
        frmmain.Opacity = 100
    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set Play Background Music to true by default
        frmmain.playMusic = True

        'Play Background Music 
        My.Computer.Audio.Play(My.Resources.TitleMusic, AudioPlayMode.BackgroundLoop)

    End Sub


    Private Sub ExitGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitGameToolStripMenuItem.Click
        'Exit Application 
        End
    End Sub



    'Stop All proccess when X button is pressed
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End 'Close Application


    End Sub

    Private Sub KeyBindingsAndControlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeyBindingsAndControlsToolStripMenuItem.Click
        'Display Key Bindings
        MsgBox("W,A,S,D or Arrow keys are to move" & vbCrLf & "I is to interact with items" & vbCrLf & "Use Mouse to Click buttons and open side windows" & vbCrLf & "Use O to close message boxs" _
               & vbCrLf & "Use P to Open/Close the Mini Map" & vbCrLf & "Use U to open bank message box")
    End Sub

    Private Sub TurnOffBackgroundMusicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnOffBackgroundMusicToolStripMenuItem.Click
        'Set Background Music to not play 
        frmmain.playMusic = False
        My.Computer.Audio.Stop()
    End Sub

    Private Sub TurnOnBackgroundMusicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnOnBackgroundMusicToolStripMenuItem.Click
        'Set Background music to play 
        frmmain.playMusic = True
    End Sub
End Class