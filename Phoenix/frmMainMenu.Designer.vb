<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.picNew = New System.Windows.Forms.PictureBox()
        Me.picLoad = New System.Windows.Forms.PictureBox()
        Me.picAbout = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyBindingsAndControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnOffBackgroundMusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnOnBackgroundMusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picNew
        '
        Me.picNew.Image = Global.Phoenix.My.Resources.Resources.button_play
        Me.picNew.Location = New System.Drawing.Point(87, 243)
        Me.picNew.Name = "picNew"
        Me.picNew.Size = New System.Drawing.Size(80, 26)
        Me.picNew.TabIndex = 0
        Me.picNew.TabStop = False
        '
        'picLoad
        '
        Me.picLoad.Image = Global.Phoenix.My.Resources.Resources.button_load
        Me.picLoad.Location = New System.Drawing.Point(88, 280)
        Me.picLoad.Name = "picLoad"
        Me.picLoad.Size = New System.Drawing.Size(88, 26)
        Me.picLoad.TabIndex = 1
        Me.picLoad.TabStop = False
        '
        'picAbout
        '
        Me.picAbout.Image = Global.Phoenix.My.Resources.Resources.button_about
        Me.picAbout.Location = New System.Drawing.Point(88, 314)
        Me.picAbout.Name = "picAbout"
        Me.picAbout.Size = New System.Drawing.Size(88, 26)
        Me.picAbout.TabIndex = 2
        Me.picAbout.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImage = Global.Phoenix.My.Resources.Resources.inventory
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.ExitGameToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(263, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeyBindingsAndControlsToolStripMenuItem, Me.TurnOffBackgroundMusicToolStripMenuItem, Me.TurnOnBackgroundMusicToolStripMenuItem})
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'KeyBindingsAndControlsToolStripMenuItem
        '
        Me.KeyBindingsAndControlsToolStripMenuItem.Name = "KeyBindingsAndControlsToolStripMenuItem"
        Me.KeyBindingsAndControlsToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.KeyBindingsAndControlsToolStripMenuItem.Text = "Key Bindings and Controls"
        '
        'TurnOffBackgroundMusicToolStripMenuItem
        '
        Me.TurnOffBackgroundMusicToolStripMenuItem.Name = "TurnOffBackgroundMusicToolStripMenuItem"
        Me.TurnOffBackgroundMusicToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.TurnOffBackgroundMusicToolStripMenuItem.Text = "Turn Off Background Music"
        '
        'TurnOnBackgroundMusicToolStripMenuItem
        '
        Me.TurnOnBackgroundMusicToolStripMenuItem.Name = "TurnOnBackgroundMusicToolStripMenuItem"
        Me.TurnOnBackgroundMusicToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.TurnOnBackgroundMusicToolStripMenuItem.Text = "Turn On Background Music"
        '
        'ExitGameToolStripMenuItem
        '
        Me.ExitGameToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ExitGameToolStripMenuItem.Name = "ExitGameToolStripMenuItem"
        Me.ExitGameToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ExitGameToolStripMenuItem.Text = "Exit Game"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Phoenix.My.Resources.Resources.Title
        Me.ClientSize = New System.Drawing.Size(263, 418)
        Me.Controls.Add(Me.picAbout)
        Me.Controls.Add(Me.picLoad)
        Me.Controls.Add(Me.picNew)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picNew As System.Windows.Forms.PictureBox
    Friend WithEvents picLoad As System.Windows.Forms.PictureBox
    Friend WithEvents picAbout As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeyBindingsAndControlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnOffBackgroundMusicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnOnBackgroundMusicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
