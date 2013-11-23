<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rules
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
        Me.TxtRules = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtRules
        '
        Me.TxtRules.BackColor = System.Drawing.SystemColors.Window
        Me.TxtRules.Location = New System.Drawing.Point(12, 12)
        Me.TxtRules.Multiline = True
        Me.TxtRules.Name = "TxtRules"
        Me.TxtRules.ReadOnly = True
        Me.TxtRules.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtRules.Size = New System.Drawing.Size(353, 367)
        Me.TxtRules.TabIndex = 0
        '
        'Rules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 391)
        Me.Controls.Add(Me.TxtRules)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(393, 429)
        Me.MinimumSize = New System.Drawing.Size(393, 429)
        Me.Name = "Rules"
        Me.Text = "Rules"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtRules As System.Windows.Forms.TextBox
End Class
