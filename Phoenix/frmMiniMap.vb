'ISU by : Harsh Mistry 
'Phoenix : A Massive RPG 
'May 1st , 2014 - June 13th , 2014 
'Powered by the Qian Engine : A Infinity Computing Production 
Public Class frmMiniMap



   

    'Prevent Form from closing
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Please use the Map key (P) to exit the Mini Map ") 'Display Error
        e.Cancel = True 'Stop form from closing

    End Sub

    'Update Player position ever 0.5 seconds
    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick

        'Declare Variables 
        Dim X As Integer
        Dim Y As Integer
        Dim location As Point

        'Get Player position 
        X = frmmain.MainX / 32
        Y = frmmain.MainY / 32

        'Set New point for picturebox
        location.X = X * 2
        location.Y = Y * 2

        'Set Picture boxes new location 
        picPlayer.Location = location
    End Sub
End Class