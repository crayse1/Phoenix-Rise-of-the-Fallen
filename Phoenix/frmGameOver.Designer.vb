<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOver
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
        Dim picHeal As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameOver))
        Me.lblOver = New System.Windows.Forms.Label()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.picLoad = New System.Windows.Forms.PictureBox()
        picHeal = New System.Windows.Forms.PictureBox()
        CType(picHeal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picHeal
        '
        picHeal.BackColor = System.Drawing.Color.Transparent
        picHeal.Image = Global.Phoenix.My.Resources.Resources.button_mhp
        picHeal.Location = New System.Drawing.Point(92, 61)
        picHeal.Name = "picHeal"
        picHeal.Size = New System.Drawing.Size(88, 27)
        picHeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        picHeal.TabIndex = 3
        picHeal.TabStop = False
        AddHandler picHeal.Click, AddressOf Me.picHeal_Click
        '
        'lblOver
        '
        Me.lblOver.AutoSize = True
        Me.lblOver.BackColor = System.Drawing.Color.Transparent
        Me.lblOver.Font = New System.Drawing.Font("Papyrus", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOver.Location = New System.Drawing.Point(75, 25)
        Me.lblOver.Name = "lblOver"
        Me.lblOver.Size = New System.Drawing.Size(121, 33)
        Me.lblOver.TabIndex = 0
        Me.lblOver.Text = "Game Over"
        '
        'picExit
        '
        Me.picExit.Image = Global.Phoenix.My.Resources.Resources.button_exit
        Me.picExit.Location = New System.Drawing.Point(92, 127)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(88, 27)
        Me.picExit.TabIndex = 2
        Me.picExit.TabStop = False
        '
        'picLoad
        '
        Me.picLoad.Image = Global.Phoenix.My.Resources.Resources.button_load
        Me.picLoad.Location = New System.Drawing.Point(92, 94)
        Me.picLoad.Name = "picLoad"
        Me.picLoad.Size = New System.Drawing.Size(88, 27)
        Me.picLoad.TabIndex = 4
        Me.picLoad.TabStop = False
        '
        'frmGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Phoenix.My.Resources.Resources.inventory
        Me.ClientSize = New System.Drawing.Size(267, 168)
        Me.Controls.Add(Me.picLoad)
        Me.Controls.Add(picHeal)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.lblOver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmGameOver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Over"
        CType(picHeal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOver As System.Windows.Forms.Label
    Friend WithEvents picExit As System.Windows.Forms.PictureBox
    Friend WithEvents picLoad As System.Windows.Forms.PictureBox
End Class
