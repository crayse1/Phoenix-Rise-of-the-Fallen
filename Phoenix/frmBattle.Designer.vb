<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBattle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBattle))
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.lstMoves = New System.Windows.Forms.ListBox()
        Me.picUse = New System.Windows.Forms.PictureBox()
        Me.picAttack = New System.Windows.Forms.PictureBox()
        Me.pgbHP = New System.Windows.Forms.ProgressBar()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblHP2 = New System.Windows.Forms.Label()
        Me.pgbHP2 = New System.Windows.Forms.ProgressBar()
        Me.lblAI = New System.Windows.Forms.Label()
        Me.picAI = New System.Windows.Forms.PictureBox()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.txtInfo = New System.Windows.Forms.RichTextBox()
        Me.tmrInventory = New System.Windows.Forms.Timer(Me.components)
        Me.lstINV = New System.Windows.Forms.ListBox()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.picItem = New System.Windows.Forms.PictureBox()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAttack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.Image = Global.Phoenix.My.Resources.Resources.player
        Me.picPlayer.Location = New System.Drawing.Point(27, 240)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(199, 193)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'lstMoves
        '
        Me.lstMoves.FormattingEnabled = True
        Me.lstMoves.Location = New System.Drawing.Point(140, 460)
        Me.lstMoves.Name = "lstMoves"
        Me.lstMoves.Size = New System.Drawing.Size(407, 108)
        Me.lstMoves.TabIndex = 1
        '
        'picUse
        '
        Me.picUse.Image = Global.Phoenix.My.Resources.Resources.button_inventory
        Me.picUse.Location = New System.Drawing.Point(36, 485)
        Me.picUse.Name = "picUse"
        Me.picUse.Size = New System.Drawing.Size(86, 26)
        Me.picUse.TabIndex = 3
        Me.picUse.TabStop = False
        '
        'picAttack
        '
        Me.picAttack.Image = Global.Phoenix.My.Resources.Resources.button_attack
        Me.picAttack.Location = New System.Drawing.Point(36, 453)
        Me.picAttack.Name = "picAttack"
        Me.picAttack.Size = New System.Drawing.Size(86, 26)
        Me.picAttack.TabIndex = 4
        Me.picAttack.TabStop = False
        '
        'pgbHP
        '
        Me.pgbHP.ForeColor = System.Drawing.Color.Red
        Me.pgbHP.Location = New System.Drawing.Point(232, 399)
        Me.pgbHP.Name = "pgbHP"
        Me.pgbHP.Size = New System.Drawing.Size(188, 23)
        Me.pgbHP.TabIndex = 5
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.BackColor = System.Drawing.Color.Red
        Me.lblHP.ForeColor = System.Drawing.Color.Black
        Me.lblHP.Location = New System.Drawing.Point(283, 404)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(69, 13)
        Me.lblHP.TabIndex = 6
        Me.lblHP.Text = "HP :100/100"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.Red
        Me.lblname.Location = New System.Drawing.Point(227, 371)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(106, 25)
        Me.lblname.TabIndex = 7
        Me.lblname.Text = " The Fallen "
        '
        'lblHP2
        '
        Me.lblHP2.AutoSize = True
        Me.lblHP2.BackColor = System.Drawing.Color.Red
        Me.lblHP2.ForeColor = System.Drawing.Color.Black
        Me.lblHP2.Location = New System.Drawing.Point(636, 187)
        Me.lblHP2.Name = "lblHP2"
        Me.lblHP2.Size = New System.Drawing.Size(69, 13)
        Me.lblHP2.TabIndex = 9
        Me.lblHP2.Text = "HP :100/100"
        '
        'pgbHP2
        '
        Me.pgbHP2.ForeColor = System.Drawing.Color.Red
        Me.pgbHP2.Location = New System.Drawing.Point(576, 182)
        Me.pgbHP2.Name = "pgbHP2"
        Me.pgbHP2.Size = New System.Drawing.Size(188, 23)
        Me.pgbHP2.TabIndex = 8
        '
        'lblAI
        '
        Me.lblAI.AutoSize = True
        Me.lblAI.BackColor = System.Drawing.Color.Transparent
        Me.lblAI.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAI.ForeColor = System.Drawing.Color.Red
        Me.lblAI.Location = New System.Drawing.Point(577, 154)
        Me.lblAI.Name = "lblAI"
        Me.lblAI.Size = New System.Drawing.Size(147, 25)
        Me.lblAI.TabIndex = 10
        Me.lblAI.Text = "Challenger Name"
        '
        'picAI
        '
        Me.picAI.BackColor = System.Drawing.Color.Transparent
        Me.picAI.Image = Global.Phoenix.My.Resources.Resources.player
        Me.picAI.Location = New System.Drawing.Point(370, 27)
        Me.picAI.Name = "picAI"
        Me.picAI.Size = New System.Drawing.Size(199, 192)
        Me.picAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAI.TabIndex = 11
        Me.picAI.TabStop = False
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Enabled = True
        Me.tmrRefresh.Interval = 500
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(556, 460)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(196, 107)
        Me.txtInfo.TabIndex = 12
        Me.txtInfo.Text = "Battle !!!!"
        '
        'tmrInventory
        '
        Me.tmrInventory.Enabled = True
        Me.tmrInventory.Interval = 500
        '
        'lstINV
        '
        Me.lstINV.FormattingEnabled = True
        Me.lstINV.Location = New System.Drawing.Point(140, 460)
        Me.lstINV.Name = "lstINV"
        Me.lstINV.Size = New System.Drawing.Size(612, 108)
        Me.lstINV.TabIndex = 13
        Me.lstINV.Visible = False
        '
        'picExit
        '
        Me.picExit.Image = Global.Phoenix.My.Resources.Resources.button_exit
        Me.picExit.Location = New System.Drawing.Point(36, 485)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(86, 26)
        Me.picExit.TabIndex = 14
        Me.picExit.TabStop = False
        Me.picExit.Visible = False
        '
        'picItem
        '
        Me.picItem.Image = Global.Phoenix.My.Resources.Resources.button_use
        Me.picItem.Location = New System.Drawing.Point(36, 453)
        Me.picItem.Name = "picItem"
        Me.picItem.Size = New System.Drawing.Size(86, 26)
        Me.picItem.TabIndex = 15
        Me.picItem.TabStop = False
        Me.picItem.Visible = False
        '
        'frmBattle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Phoenix.My.Resources.Resources.battle
        Me.ClientSize = New System.Drawing.Size(798, 589)
        Me.Controls.Add(Me.picItem)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.lstINV)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.picAI)
        Me.Controls.Add(Me.lblAI)
        Me.Controls.Add(Me.lblHP2)
        Me.Controls.Add(Me.pgbHP2)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblHP)
        Me.Controls.Add(Me.pgbHP)
        Me.Controls.Add(Me.picAttack)
        Me.Controls.Add(Me.picUse)
        Me.Controls.Add(Me.lstMoves)
        Me.Controls.Add(Me.picPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBattle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Battle"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAttack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents lstMoves As System.Windows.Forms.ListBox
    Friend WithEvents picUse As System.Windows.Forms.PictureBox
    Friend WithEvents picAttack As System.Windows.Forms.PictureBox
    Friend WithEvents pgbHP As System.Windows.Forms.ProgressBar
    Friend WithEvents lblHP As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblHP2 As System.Windows.Forms.Label
    Friend WithEvents pgbHP2 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblAI As System.Windows.Forms.Label
    Friend WithEvents picAI As System.Windows.Forms.PictureBox
    Friend WithEvents tmrRefresh As System.Windows.Forms.Timer
    Friend WithEvents txtInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents tmrInventory As System.Windows.Forms.Timer
    Friend WithEvents lstINV As System.Windows.Forms.ListBox
    Friend WithEvents picExit As System.Windows.Forms.PictureBox
    Friend WithEvents picItem As System.Windows.Forms.PictureBox
End Class
