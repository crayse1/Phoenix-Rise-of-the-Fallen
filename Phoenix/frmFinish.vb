'ISU by : Harsh Mistry 
'Phoenix : A Massive RPG 
'May 1st , 2014 - June 13th , 2014 
'Powered by the Qian Engine : A Infinity Computing Production 

Public Class frmFinish

    Private Sub picExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picExit.Click
        'Close application 
        End
    End Sub



    'Stop All proccess when X button is pressed
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End 'Close Application


    End Sub

    Private Sub frmFinish_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Play Celebration Music
        My.Computer.Audio.Play(My.Resources.win, AudioPlayMode.BackgroundLoop)

        'Align Credits to center of textbox 
        txtCredits.SelectionAlignment = HorizontalAlignment.Center

    End Sub
End Class