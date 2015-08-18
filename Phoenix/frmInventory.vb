'ISU by : Harsh Mistry 
'Phoenix : A Massive RPG 
'May 1st , 2014 - June 13th , 2014 
'Powered by the Qian Engine : A Infinity Computing Production 

Public Class frmInventory

    'Declare item names array 
    Dim names(100) As String

    Private Sub picExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picExit.Click
        'Exit inventory window
        Me.Close()
    End Sub

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Make Inventory Label  background transparent 
        lblInven.BackColor = Color.Transparent

        'Set Item Name values 
        names(0) = "Food"
        names(1) = "Potions"
        names(2) = "Super Heal"
        names(3) = "Badges"
        names(4) = "Escape Rope"
        names(5) = "Mega Heal"

     
    End Sub


    Private Sub tmrRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Refresh Item Count every 0.5 seconds
        Dim text As String
        Dim value As Integer
        Dim index As Integer

        'Get selected index
        index = lstItems.SelectedIndex

        'Clear List Box 
        lstItems.Items.Clear()

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
            lstItems.Items.Add(text & vbTab & value)
        Next

        'Set Selected index back to old selected index
        lstItems.SelectedIndex = index
    End Sub

    'Use of 1 of the selected item
    Private Sub picUse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUse.Click


        'Declare Use variables
        Dim use As Integer
        Dim useValue As Integer
        Dim HP As Integer = modSaveData.maxHealth

        'Get Selected Item 
        use = lstItems.SelectedIndex

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
                Else
                    MsgBox("Your health is already at 100 % , no need to eat food") 'Display error
                End If
            Case 1 'Drink Potion 
                If modSaveData.health < HP Then 'Only drink potion if health is less then 100 
                    modSaveData.health = modSaveData.health + 11 'Increase Health by 10 
                    modSaveData.items(use) = modSaveData.items(use) - 1 'Take away 1 item 
                Else
                    MsgBox("Your health is already at 100 % , no need to drink potion") 'Display error
                End If
            Case 2 'Super heal 
                If modSaveData.health < HP Then 'Only heal if health is less then 100 
                    modSaveData.health = modSaveData.health + 50 'Increase Health by 10 
                    modSaveData.items(use) = modSaveData.items(use) - 1 'Take away 1 item 
                Else
                    MsgBox("Your health is already at 100 %, no need to heal") 'Display error
                End If
            Case 3 'Display error
                MsgBox("This is not a Usable Item")
            Case 4 'Display error
                MsgBox("This is not a Usable Item")
            Case 5 'Mega heal
                If modSaveData.health < HP Then 'Only heal if health is less then 100 
                    modSaveData.health = modSaveData.health + 80 'Increase Health by 10 
                    modSaveData.items(use) = modSaveData.items(use) - 1 'Take away 1 item 
                Else
                    MsgBox("Your health is already at 100 % , no need to heal") 'Display error
                End If
        End Select

        'Make Sure health is at max or less , if more correct it
        If modSaveData.health > HP Then
            modSaveData.health = HP ' reset health to max
        End If
    End Sub
End Class