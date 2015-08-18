<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStat))
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.pgbHP = New System.Windows.Forms.ProgressBar()
        Me.pgbXP = New System.Windows.Forms.ProgressBar()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblXP = New System.Windows.Forms.Label()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblMap = New System.Windows.Forms.Label()
        Me.picExit = New System.Windows.Forms.PictureBox()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayer.Image = Global.Phoenix.My.Resources.Resources.player
        Me.picPlayer.Location = New System.Drawing.Point(12, 12)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(96, 94)
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'pgbHP
        '
        Me.pgbHP.Location = New System.Drawing.Point(194, 12)
        Me.pgbHP.Name = "pgbHP"
        Me.pgbHP.Size = New System.Drawing.Size(294, 21)
        Me.pgbHP.TabIndex = 1
        '
        'pgbXP
        '
        Me.pgbXP.Location = New System.Drawing.Point(194, 39)
        Me.pgbXP.Name = "pgbXP"
        Me.pgbXP.Size = New System.Drawing.Size(294, 21)
        Me.pgbXP.TabIndex = 2
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.BackColor = System.Drawing.Color.Transparent
        Me.lblHP.Location = New System.Drawing.Point(116, 16)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(72, 13)
        Me.lblHP.TabIndex = 3
        Me.lblHP.Text = "HP : 100/100"
        '
        'lblXP
        '
        Me.lblXP.AutoSize = True
        Me.lblXP.BackColor = System.Drawing.Color.Transparent
        Me.lblXP.Location = New System.Drawing.Point(115, 44)
        Me.lblXP.Name = "lblXP"
        Me.lblXP.Size = New System.Drawing.Size(59, 13)
        Me.lblXP.TabIndex = 4
        Me.lblXP.Text = "XP : 0/100"
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Enabled = True
        Me.tmrRefresh.Interval = 500
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Location = New System.Drawing.Point(112, 69)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(128, 13)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Time Played : HH,MM,SS"
        '
        'lblMap
        '
        Me.lblMap.AutoSize = True
        Me.lblMap.BackColor = System.Drawing.Color.Transparent
        Me.lblMap.Location = New System.Drawing.Point(112, 90)
        Me.lblMap.Name = "lblMap"
        Me.lblMap.Size = New System.Drawing.Size(91, 13)
        Me.lblMap.TabIndex = 6
        Me.lblMap.Text = "Current Kingdom :"
        '
        'picExit
        '
        Me.picExit.Image = Global.Phoenix.My.Resources.Resources.button_exit
        Me.picExit.Location = New System.Drawing.Point(399, 77)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(87, 26)
        Me.picExit.TabIndex = 7
        Me.picExit.TabStop = False
        '
        'frmStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = Global.Phoenix.My.Resources.Resources.inventory
        Me.ClientSize = New System.Drawing.Size(500, 113)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.lblMap)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblXP)
        Me.Controls.Add(Me.lblHP)
        Me.Controls.Add(Me.pgbXP)
        Me.Controls.Add(Me.pgbHP)
        Me.Controls.Add(Me.picPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Player Status"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents pgbHP As System.Windows.Forms.ProgressBar
    Friend WithEvents pgbXP As System.Windows.Forms.ProgressBar
    Friend WithEvents lblHP As System.Windows.Forms.Label
    Friend WithEvents lblXP As System.Windows.Forms.Label
    Friend WithEvents tmrRefresh As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblMap As System.Windows.Forms.Label
    Friend WithEvents picExit As System.Windows.Forms.PictureBox
End Class
