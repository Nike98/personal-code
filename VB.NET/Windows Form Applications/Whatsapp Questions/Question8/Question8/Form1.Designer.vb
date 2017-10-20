<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOption
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
        Me.RadArCir = New System.Windows.Forms.RadioButton()
        Me.RadArTriangle = New System.Windows.Forms.RadioButton()
        Me.RadVolCube = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'RadArCir
        '
        Me.RadArCir.AutoSize = True
        Me.RadArCir.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.RadArCir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadArCir.Location = New System.Drawing.Point(84, 58)
        Me.RadArCir.Name = "RadArCir"
        Me.RadArCir.Size = New System.Drawing.Size(97, 18)
        Me.RadArCir.TabIndex = 0
        Me.RadArCir.TabStop = True
        Me.RadArCir.Text = "Area of Circle"
        Me.RadArCir.UseVisualStyleBackColor = False
        '
        'RadArTriangle
        '
        Me.RadArTriangle.AutoSize = True
        Me.RadArTriangle.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.RadArTriangle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadArTriangle.Location = New System.Drawing.Point(84, 98)
        Me.RadArTriangle.Name = "RadArTriangle"
        Me.RadArTriangle.Size = New System.Drawing.Size(112, 18)
        Me.RadArTriangle.TabIndex = 0
        Me.RadArTriangle.TabStop = True
        Me.RadArTriangle.Text = "Area of Triangle"
        Me.RadArTriangle.UseVisualStyleBackColor = False
        '
        'RadVolCube
        '
        Me.RadVolCube.AutoSize = True
        Me.RadVolCube.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.RadVolCube.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadVolCube.Location = New System.Drawing.Point(84, 136)
        Me.RadVolCube.Name = "RadVolCube"
        Me.RadVolCube.Size = New System.Drawing.Size(113, 18)
        Me.RadVolCube.TabIndex = 0
        Me.RadVolCube.TabStop = True
        Me.RadVolCube.Text = "Volume of Cube"
        Me.RadVolCube.UseVisualStyleBackColor = False
        '
        'FrmOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.RadVolCube)
        Me.Controls.Add(Me.RadArTriangle)
        Me.Controls.Add(Me.RadArCir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area And Volume"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadArCir As RadioButton
    Friend WithEvents RadArTriangle As RadioButton
    Friend WithEvents RadVolCube As RadioButton
End Class
