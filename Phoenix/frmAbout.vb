'ISU by : Harsh Mistry 
'Phoenix : A Massive RPG 
'May 1st , 2014 - June 13th , 2014 
'Powered by the Qian Engine : A Infinity Computing Production 
Public Class frmAbout

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        'Hide About Window and Show Main Menu
        frmMainMenu.Opacity = 100
        Me.Hide()

    End Sub
End Class