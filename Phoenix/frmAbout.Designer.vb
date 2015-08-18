<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.btnclose = New System.Windows.Forms.Button()
        Me.txtCredits = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(82, 371)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(94, 22)
        Me.btnclose.TabIndex = 2
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'txtCredits
        '
        Me.txtCredits.Location = New System.Drawing.Point(24, 230)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(211, 130)
        Me.txtCredits.TabIndex = 3
        Me.txtCredits.Text = resources.GetString("txtCredits.Text")
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.Phoenix.My.Resources.Resources.Title
        Me.ClientSize = New System.Drawing.Size(264, 417)
        Me.Controls.Add(Me.txtCredits)
        Me.Controls.Add(Me.btnclose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents txtCredits As System.Windows.Forms.RichTextBox
End Class
