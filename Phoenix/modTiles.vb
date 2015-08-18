Module modTiles

    'Get tile based on integer stored in frmmain.map array 
    Public Sub GetSourceRect(ByVal X As Integer, ByVal Y As Integer, ByVal layer As Integer)


        If layer = 0 Then 'Background 
            Select Case frmmain.Map(X, Y, 0)
                Case 0 'Lava Floor
                    frmmain.srect = New Rectangle(32, 352, frmmain.TileSize, frmmain.TileSize)
                Case 1 'Stone Block 
                    frmmain.srect = New Rectangle(192, 96, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make tile solid 
                Case 2 ' solid Grass
                    frmmain.srect = New Rectangle(32, 0, frmmain.TileSize, frmmain.TileSize)

                Case 3 'Black tile 
                    frmmain.srect = New Rectangle(325, 155, frmmain.TileSize, frmmain.TileSize)
                Case 4 'Carpet Tile L1
                    frmmain.srect = New Rectangle(384, 224, frmmain.TileSize, frmmain.TileSize)
                Case 5 'Carpet Tile L2
                    frmmain.srect = New Rectangle(384, 256, frmmain.TileSize, frmmain.TileSize)
                Case 6 'Carpet Tile R1
                    frmmain.srect = New Rectangle(416, 224, frmmain.TileSize, frmmain.TileSize)
                Case 7 'Carpet Tile R2
                    frmmain.srect = New Rectangle(416, 256, frmmain.TileSize, frmmain.TileSize)
                Case 8 'Carpet Tile M1
                    frmmain.srect = New Rectangle(32, 384, frmmain.TileSize, frmmain.TileSize)
                Case 9 'Carpet Tile M2
                    frmmain.srect = New Rectangle(64, 384, frmmain.TileSize, frmmain.TileSize)
                Case 10 'Carpet Tile Mf
                    frmmain.srect = New Rectangle(96, 384, frmmain.TileSize, frmmain.TileSize)
                Case 11 'Carpet Tile M3
                    frmmain.srect = New Rectangle(0, 416, frmmain.TileSize, frmmain.TileSize)
                Case 12 'Carpet Tile M4 
                    frmmain.srect = New Rectangle(0, 448, frmmain.TileSize, frmmain.TileSize)


            End Select

        ElseIf layer = 2 Then 'Foreground 

            Select Case frmmain.Map(X, Y, 2)
                Case 0 'nothing
                    frmmain.srect = New Rectangle(2080, 0, frmmain.TileSize, frmmain.TileSize)
                Case 1 'Wood 1
                    frmmain.srect = New Rectangle(32, 0, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make tile solid 
                Case 2 'Blue Glass Path 
                    frmmain.srect = New Rectangle(32, 512, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 0 'Make tile passable
                Case 3 'Blue Glas Path End
                    frmmain.srect = New Rectangle(32, 544, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make tile solid 
                Case 4 'Blue Glass Stairs 
                    frmmain.srect = New Rectangle(96, 512, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 0 'Make tile passable
                Case 5 'Wood 
                    frmmain.srect = New Rectangle(128, 576, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 0 'Make tile passable
                Case 6 'Stone Path 
                    frmmain.srect = New Rectangle(224, 576, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 0 'Make tile passable
            End Select

        ElseIf layer = 3 Then 'NPC
            Select Case frmmain.Map(X, Y, 3)

                Case 1  'Wise Man 
                    frmmain.srect = New Rectangle(32, 0, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 2  'Witch Looking Left 
                    frmmain.srect = New Rectangle(0, 160, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 3 'Guy in Suit looking left 
                    frmmain.srect = New Rectangle(576, 288, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 4 'White Hair guy looking left 
                    frmmain.srect = New Rectangle(576, 160, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 5 'Red hooded guy looking right 
                    frmmain.srect = New Rectangle(576, 576, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 6 'Red hooded guy looking up
                    frmmain.srect = New Rectangle(576, 608, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 7 'Red hooded guy looking left 
                    frmmain.srect = New Rectangle(576, 544, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 8 'Pink Witch looking right 
                    frmmain.srect = New Rectangle(0, 320, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 9 'Red hair guy looking right 
                    frmmain.srect = New Rectangle(672, 704, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 10 'vampire looking up 
                    frmmain.srect = New Rectangle(480, 608, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 11 'vampire looking up 2
                    frmmain.srect = New Rectangle(512, 608, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 12 'vampire looking up 3
                    frmmain.srect = New Rectangle(544, 608, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 13 'Angel Looking down 
                    frmmain.srect = New Rectangle(384, 256, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 14 'Angel Looking down 
                    frmmain.srect = New Rectangle(416, 256, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 15 'Angel Looking down 
                    frmmain.srect = New Rectangle(448, 256, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 16 'Snow Girl Looking Left 
                    frmmain.srect = New Rectangle(480, 160, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 17 'Wise Man Looking Left
                    frmmain.srect = New Rectangle(0, 32, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 18 'Purple Witch Looking right 
                    frmmain.srect = New Rectangle(96, 320, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 19 'White Hair Guy looking right 
                    frmmain.srect = New Rectangle(576, 192, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 20 'Knight looking down 
                    frmmain.srect = New Rectangle(704, 192, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid

            End Select

        ElseIf layer = 5 Then ' Foreground 2
            Select Case frmmain.Map(X, Y, 5)
                Case 0 'nothing
                    frmmain.srect = New Rectangle(2080, 0, frmmain.TileSize, frmmain.TileSize)

            End Select

        ElseIf layer = 6 Then '2.5D Tiles 
            Select Case frmmain.Map(X, Y, 6)
                Case 0 'nothing
                    frmmain.srect = New Rectangle(2080, 0, frmmain.TileSize, frmmain.TileSize)
                Case 1 'Top of Stone Arc
                    frmmain.srect = New Rectangle(1376, 416, frmmain.TileSize, frmmain.TileSize)
                Case 2 'Stone arc 1
                    frmmain.srect = New Rectangle(1344, 416, frmmain.TileSize, frmmain.TileSize)
                Case 3 'Stone arc 2
                    frmmain.srect = New Rectangle(1408, 416, frmmain.TileSize, frmmain.TileSize)
                Case 4 'Stone arc 3
                    frmmain.srect = New Rectangle(1344, 448, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 5 'Stone arc 4
                    frmmain.srect = New Rectangle(1344, 480, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 6 'Stone arc 5
                    frmmain.srect = New Rectangle(1408, 448, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 7 'Stone arc 6
                    frmmain.srect = New Rectangle(1408, 480, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 8 'Stone arc 7
                    frmmain.srect = New Rectangle(1376, 448, frmmain.TileSize, frmmain.TileSize)
                Case 9 'sign 
                    frmmain.srect = New Rectangle(96, 256, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 10 'Statue 1
                    frmmain.srect = New Rectangle(128, 384, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid
                Case 11 'Statue 1
                    frmmain.srect = New Rectangle(128, 416, frmmain.TileSize, frmmain.TileSize)
                    frmmain.Map(X, Y, 1) = 1 'Make Tile Solid


            End Select
        End If
    End Sub

    'Get Building Graphics based on integer stored in frmmain.map array 
    Public Sub GetSourceRect2(ByVal X As Integer, ByVal Y As Integer, ByVal layer As Integer, ByRef width As Integer, ByRef height As Integer)
        Select Case frmmain.Map(X, Y, layer)

            Case 0 'Nothing 
                'Set Width and Height 
                width = 32
                height = 32

                'Get Tile Image 
                frmmain.srect = New Rectangle(0, 0, frmmain.TileSize, frmmain.TileSize)

            Case 1 'Dungeon
                'Set Width and Height 
                width = 544
                height = 448

                'Get Tile Image
                frmmain.srect = New Rectangle(0, 0, width, height)

            Case 2 'Shrine
                'Set Width and Height 
                width = 229
                height = 209

                'Get Tile Image
                frmmain.srect = New Rectangle(544, 0, width, height)

            Case 3 'Large House
                'Set Width and Height 
                width = 224
                height = 192

                'Get Tile Image
                frmmain.srect = New Rectangle(832, 0, width, height)

            Case 4 'Medium Sized House
                'Set Width and Height 
                width = 224
                height = 117

                'Get Tile Image
                frmmain.srect = New Rectangle(832, 192, width, height)

            Case 5 'Small house
                'Set Width and Height 
                width = 224
                height = 128

                'Get Tile Image
                frmmain.srect = New Rectangle(832, 300, width, height)
        End Select
    End Sub
End Module
