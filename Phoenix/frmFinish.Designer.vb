<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinish
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinish))
        Me.lblFin = New System.Windows.Forms.Label()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.txtCredits = New System.Windows.Forms.RichTextBox()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFin
        '
        Me.lblFin.AutoSize = True
        Me.lblFin.BackColor = System.Drawing.Color.Transparent
        Me.lblFin.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFin.Location = New System.Drawing.Point(40, 9)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(426, 15)
        Me.lblFin.TabIndex = 0
        Me.lblFin.Text = "You Have Completed Phoenix Rise of the Fallen : Thanks for playing"
        '
        'picExit
        '
        Me.picExit.Image = Global.Phoenix.My.Resources.Resources.button_exit
        Me.picExit.Location = New System.Drawing.Point(204, 167)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(86, 26)
        Me.picExit.TabIndex = 1
        Me.picExit.TabStop = False
        '
        'txtCredits
        '
        Me.txtCredits.Location = New System.Drawing.Point(43, 32)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.ReadOnly = True
        Me.txtCredits.Size = New System.Drawing.Size(423, 129)
        Me.txtCredits.TabIndex = 2
        Me.txtCredits.Text = resources.GetString("txtCredits.Text")
        '
        'frmFinish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Phoenix.My.Resources.Resources.inventory
        Me.ClientSize = New System.Drawing.Size(499, 205)
        Me.Controls.Add(Me.txtCredits)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.lblFin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFinish"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You Have Completed the Game"
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFin As System.Windows.Forms.Label
    Friend WithEvents picExit As System.Windows.Forms.PictureBox
    Friend WithEvents txtCredits As System.Windows.Forms.RichTextBox
End Class
