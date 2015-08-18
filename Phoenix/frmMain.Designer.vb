<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.pgbHP2 = New System.Windows.Forms.ProgressBar()
        Me.tmrHP = New System.Windows.Forms.Timer(Me.components)
        Me.pgbXP2 = New System.Windows.Forms.ProgressBar()
        Me.picStat = New System.Windows.Forms.PictureBox()
        Me.picSave = New System.Windows.Forms.PictureBox()
        Me.picexit = New System.Windows.Forms.PictureBox()
        Me.picInventory = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.tmrLevel = New System.Windows.Forms.Timer(Me.components)
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblXP = New System.Windows.Forms.Label()
        Me.tmrAnimate = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picexit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrGame
        '
        Me.tmrGame.Enabled = True
        Me.tmrGame.Interval = 1000
        '
        'pgbHP2
        '
        Me.pgbHP2.ForeColor = System.Drawing.Color.Red
        Me.pgbHP2.Location = New System.Drawing.Point(677, 202)
        Me.pgbHP2.Name = "pgbHP2"
        Me.pgbHP2.Size = New System.Drawing.Size(45, 20)
        Me.pgbHP2.TabIndex = 7
        '
        'tmrHP
        '
        Me.tmrHP.Enabled = True
        Me.tmrHP.Interval = 500
        '
        'pgbXP2
        '
        Me.pgbXP2.ForeColor = System.Drawing.Color.Blue
        Me.pgbXP2.Location = New System.Drawing.Point(677, 228)
        Me.pgbXP2.Name = "pgbXP2"
        Me.pgbXP2.Size = New System.Drawing.Size(45, 20)
        Me.pgbXP2.TabIndex = 8
        '
        'picStat
        '
        Me.picStat.Image = Global.Phoenix.My.Resources.Resources.button_stat
        Me.picStat.Location = New System.Drawing.Point(647, 120)
        Me.picStat.Name = "picStat"
        Me.picStat.Size = New System.Drawing.Size(74, 22)
        Me.picStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStat.TabIndex = 6
        Me.picStat.TabStop = False
        '
        'picSave
        '
        Me.picSave.Image = Global.Phoenix.My.Resources.Resources.button_save
        Me.picSave.Location = New System.Drawing.Point(648, 147)
        Me.picSave.Name = "picSave"
        Me.picSave.Size = New System.Drawing.Size(74, 22)
        Me.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSave.TabIndex = 4
        Me.picSave.TabStop = False
        '
        'picexit
        '
        Me.picexit.Image = Global.Phoenix.My.Resources.Resources.button_exit
        Me.picexit.Location = New System.Drawing.Point(648, 174)
        Me.picexit.Name = "picexit"
        Me.picexit.Size = New System.Drawing.Size(74, 22)
        Me.picexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picexit.TabIndex = 3
        Me.picexit.TabStop = False
        '
        'picInventory
        '
        Me.picInventory.Image = Global.Phoenix.My.Resources.Resources.button_inventory
        Me.picInventory.Location = New System.Drawing.Point(647, 93)
        Me.picInventory.Name = "picInventory"
        Me.picInventory.Size = New System.Drawing.Size(74, 22)
        Me.picInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInventory.TabIndex = 2
        Me.picInventory.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Black
        Me.picLogo.Image = Global.Phoenix.My.Resources.Resources.Title1
        Me.picLogo.Location = New System.Drawing.Point(647, 18)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(75, 69)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'tmrLevel
        '
        Me.tmrLevel.Enabled = True
        Me.tmrLevel.Interval = 500
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.BackColor = System.Drawing.Color.Black
        Me.lblHP.ForeColor = System.Drawing.Color.Red
        Me.lblHP.Location = New System.Drawing.Point(649, 206)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(22, 13)
        Me.lblHP.TabIndex = 9
        Me.lblHP.Text = "HP"
        '
        'lblXP
        '
        Me.lblXP.AutoSize = True
        Me.lblXP.BackColor = System.Drawing.Color.Black
        Me.lblXP.ForeColor = System.Drawing.Color.Red
        Me.lblXP.Location = New System.Drawing.Point(649, 232)
        Me.lblXP.Name = "lblXP"
        Me.lblXP.Size = New System.Drawing.Size(21, 13)
        Me.lblXP.TabIndex = 10
        Me.lblXP.Text = "XP"
        '
        'tmrAnimate
        '
        Me.tmrAnimate.Enabled = True
        Me.tmrAnimate.Interval = 250
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 457)
        Me.Controls.Add(Me.lblXP)
        Me.Controls.Add(Me.lblHP)
        Me.Controls.Add(Me.pgbXP2)
        Me.Controls.Add(Me.pgbHP2)
        Me.Controls.Add(Me.picStat)
        Me.Controls.Add(Me.picSave)
        Me.Controls.Add(Me.picexit)
        Me.Controls.Add(Me.picInventory)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phoenix : Rise Of The Fallen"
        CType(Me.picStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picexit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents picInventory As System.Windows.Forms.PictureBox
    Friend WithEvents picexit As System.Windows.Forms.PictureBox
    Friend WithEvents picSave As System.Windows.Forms.PictureBox
    Friend WithEvents picStat As System.Windows.Forms.PictureBox
    Public WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents pgbHP2 As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrHP As System.Windows.Forms.Timer
    Friend WithEvents pgbXP2 As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrLevel As System.Windows.Forms.Timer
    Friend WithEvents lblHP As System.Windows.Forms.Label
    Friend WithEvents lblXP As System.Windows.Forms.Label
    Friend WithEvents tmrAnimate As System.Windows.Forms.Timer

End Class
