<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultForm
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
        Me.LblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResult.Location = New System.Drawing.Point(12, 83)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(49, 18)
        Me.LblResult.TabIndex = 0
        Me.LblResult.Text = "Label1"
        Me.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ResultForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(244, 211)
        Me.Controls.Add(Me.LblResult)
        Me.Name = "ResultForm"
        Me.Text = "ResultForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblResult As Label
End Class
