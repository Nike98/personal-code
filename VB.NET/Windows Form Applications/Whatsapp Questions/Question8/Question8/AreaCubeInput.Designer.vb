<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAreaCircleInput
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
        Me.TxtArCirInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnArCircle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtArCirInput
        '
        Me.TxtArCirInput.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArCirInput.Location = New System.Drawing.Point(61, 67)
        Me.TxtArCirInput.Name = "TxtArCirInput"
        Me.TxtArCirInput.Size = New System.Drawing.Size(100, 23)
        Me.TxtArCirInput.TabIndex = 0
        Me.TxtArCirInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Menu
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input the Radius of the Circle"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnArCircle
        '
        Me.BtnArCircle.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArCircle.Location = New System.Drawing.Point(76, 124)
        Me.BtnArCircle.Name = "BtnArCircle"
        Me.BtnArCircle.Size = New System.Drawing.Size(75, 23)
        Me.BtnArCircle.TabIndex = 2
        Me.BtnArCircle.Text = "Submit"
        Me.BtnArCircle.UseVisualStyleBackColor = True
        '
        'FrmAreaCircleInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(244, 211)
        Me.Controls.Add(Me.BtnArCircle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtArCirInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAreaCircleInput"
        Me.Text = "AreaCircleInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtArCirInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnArCircle As Button
End Class
