<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVolumeCubeInput
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
        Me.LblCubeSide = New System.Windows.Forms.Label()
        Me.TxtCubeInput = New System.Windows.Forms.TextBox()
        Me.BtnVolCube = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblCubeSide
        '
        Me.LblCubeSide.AutoSize = True
        Me.LblCubeSide.BackColor = System.Drawing.SystemColors.Menu
        Me.LblCubeSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCubeSide.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCubeSide.Location = New System.Drawing.Point(42, 34)
        Me.LblCubeSide.Name = "LblCubeSide"
        Me.LblCubeSide.Size = New System.Drawing.Size(150, 17)
        Me.LblCubeSide.TabIndex = 0
        Me.LblCubeSide.Text = "Input the Side of the Cube"
        '
        'TxtCubeInput
        '
        Me.TxtCubeInput.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCubeInput.Location = New System.Drawing.Point(62, 74)
        Me.TxtCubeInput.Name = "TxtCubeInput"
        Me.TxtCubeInput.Size = New System.Drawing.Size(100, 23)
        Me.TxtCubeInput.TabIndex = 1
        Me.TxtCubeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnVolCube
        '
        Me.BtnVolCube.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolCube.Location = New System.Drawing.Point(74, 135)
        Me.BtnVolCube.Name = "BtnVolCube"
        Me.BtnVolCube.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolCube.TabIndex = 2
        Me.BtnVolCube.Text = "Submit"
        Me.BtnVolCube.UseVisualStyleBackColor = True
        '
        'FrmVolumeCubeInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(244, 211)
        Me.Controls.Add(Me.BtnVolCube)
        Me.Controls.Add(Me.TxtCubeInput)
        Me.Controls.Add(Me.LblCubeSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmVolumeCubeInput"
        Me.Text = "VolumeCubeInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCubeSide As Label
    Friend WithEvents TxtCubeInput As TextBox
    Friend WithEvents BtnVolCube As Button
End Class
