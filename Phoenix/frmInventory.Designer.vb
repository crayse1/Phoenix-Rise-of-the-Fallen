<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim tmrRefresh As System.Windows.Forms.Timer
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.lblInven = New System.Windows.Forms.Label()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.picUse = New System.Windows.Forms.PictureBox()
        tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRefresh
        '
        tmrRefresh.Enabled = True
        tmrRefresh.Interval = 500
        AddHandler tmrRefresh.Tick, AddressOf Me.tmrRefresh_Tick
        '
        'picExit
        '
        Me.picExit.Image = Global.Phoenix.My.Resources.Resources.button_exit
        Me.picExit.Location = New System.Drawing.Point(111, 292)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(87, 25)
        Me.picExit.TabIndex = 0
        Me.picExit.TabStop = False
        '
        'lblInven
        '
        Me.lblInven.AutoSize = True
        Me.lblInven.BackColor = System.Drawing.SystemColors.Control
        Me.lblInven.Font = New System.Drawing.Font("Viner Hand ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInven.Location = New System.Drawing.Point(105, 28)
        Me.lblInven.Name = "lblInven"
        Me.lblInven.Size = New System.Drawing.Size(103, 31)
        Me.lblInven.TabIndex = 1
        Me.lblInven.Text = "Inventory"
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(31, 72)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(259, 173)
        Me.lstItems.TabIndex = 2
        '
        'picUse
        '
        Me.picUse.Image = Global.Phoenix.My.Resources.Resources.button_use
        Me.picUse.Location = New System.Drawing.Point(111, 261)
        Me.picUse.Name = "picUse"
        Me.picUse.Size = New System.Drawing.Size(87, 25)
        Me.picUse.TabIndex = 3
        Me.picUse.TabStop = False
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Phoenix.My.Resources.Resources.inventory
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(318, 329)
        Me.Controls.Add(Me.picUse)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.lblInven)
        Me.Controls.Add(Me.picExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInventory"
        Me.ShowIcon = False
        Me.Text = "Inventory "
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picExit As System.Windows.Forms.PictureBox
    Friend WithEvents lblInven As System.Windows.Forms.Label
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents picUse As System.Windows.Forms.PictureBox
End Class
