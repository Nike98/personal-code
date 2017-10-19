<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAreaTriangleInput
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
        Me.LblBase = New System.Windows.Forms.Label()
        Me.TxtTriBase = New System.Windows.Forms.TextBox()
        Me.LblTriHeight = New System.Windows.Forms.Label()
        Me.TxtTriHeight = New System.Windows.Forms.TextBox()
        Me.BtnArTriangle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblBase
        '
        Me.LblBase.AutoSize = True
        Me.LblBase.BackColor = System.Drawing.SystemColors.Menu
        Me.LblBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblBase.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBase.Location = New System.Drawing.Point(37, 27)
        Me.LblBase.Name = "LblBase"
        Me.LblBase.Size = New System.Drawing.Size(166, 17)
        Me.LblBase.TabIndex = 0
        Me.LblBase.Text = "Input the Base of the Triangle"
        Me.LblBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTriBase
        '
        Me.TxtTriBase.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTriBase.Location = New System.Drawing.Point(62, 55)
        Me.TxtTriBase.Name = "TxtTriBase"
        Me.TxtTriBase.Size = New System.Drawing.Size(100, 23)
        Me.TxtTriBase.TabIndex = 1
        Me.TxtTriBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTriHeight
        '
        Me.LblTriHeight.AutoSize = True
        Me.LblTriHeight.BackColor = System.Drawing.SystemColors.Menu
        Me.LblTriHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTriHeight.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTriHeight.Location = New System.Drawing.Point(37, 105)
        Me.LblTriHeight.Name = "LblTriHeight"
        Me.LblTriHeight.Size = New System.Drawing.Size(178, 17)
        Me.LblTriHeight.TabIndex = 2
        Me.LblTriHeight.Text = "Input the Height of the Triangle"
        Me.LblTriHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTriHeight
        '
        Me.TxtTriHeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTriHeight.Location = New System.Drawing.Point(62, 134)
        Me.TxtTriHeight.Name = "TxtTriHeight"
        Me.TxtTriHeight.Size = New System.Drawing.Size(100, 23)
        Me.TxtTriHeight.TabIndex = 3
        Me.TxtTriHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnArTriangle
        '
        Me.BtnArTriangle.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArTriangle.Location = New System.Drawing.Point(75, 176)
        Me.BtnArTriangle.Name = "BtnArTriangle"
        Me.BtnArTriangle.Size = New System.Drawing.Size(75, 23)
        Me.BtnArTriangle.TabIndex = 4
        Me.BtnArTriangle.Text = "Submit"
        Me.BtnArTriangle.UseVisualStyleBackColor = True
        '
        'FrmAreaTriangleInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(244, 211)
        Me.Controls.Add(Me.BtnArTriangle)
        Me.Controls.Add(Me.TxtTriHeight)
        Me.Controls.Add(Me.LblTriHeight)
        Me.Controls.Add(Me.TxtTriBase)
        Me.Controls.Add(Me.LblBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAreaTriangleInput"
        Me.Text = "AreaTriangleInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBase As Label
    Friend WithEvents TxtTriBase As TextBox
    Friend WithEvents LblTriHeight As Label
    Friend WithEvents TxtTriHeight As TextBox
    Friend WithEvents BtnArTriangle As Button
End Class
