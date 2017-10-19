<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TxtB1 = New System.Windows.Forms.TextBox()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.LblOutput = New System.Windows.Forms.Label()
        Me.BtnValidate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtB1
        '
        Me.TxtB1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtB1.Location = New System.Drawing.Point(93, 51)
        Me.TxtB1.MaxLength = 4
        Me.TxtB1.Name = "TxtB1"
        Me.TxtB1.Size = New System.Drawing.Size(85, 22)
        Me.TxtB1.TabIndex = 0
        '
        'LblMsg
        '
        Me.LblMsg.AutoSize = True
        Me.LblMsg.BackColor = System.Drawing.SystemColors.Window
        Me.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMsg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMsg.Location = New System.Drawing.Point(90, 19)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(96, 15)
        Me.LblMsg.TabIndex = 1
        Me.LblMsg.Text = "Input the Value"
        '
        'LblOutput
        '
        Me.LblOutput.AutoSize = True
        Me.LblOutput.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblOutput.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOutput.Location = New System.Drawing.Point(25, 156)
        Me.LblOutput.Name = "LblOutput"
        Me.LblOutput.Size = New System.Drawing.Size(157, 16)
        Me.LblOutput.TabIndex = 2
        Me.LblOutput.Text = "Waiting for Verification  ...."
        '
        'BtnValidate
        '
        Me.BtnValidate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnValidate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValidate.Location = New System.Drawing.Point(93, 211)
        Me.BtnValidate.Name = "BtnValidate"
        Me.BtnValidate.Size = New System.Drawing.Size(75, 23)
        Me.BtnValidate.TabIndex = 3
        Me.BtnValidate.Text = "Validate"
        Me.BtnValidate.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnValidate)
        Me.Controls.Add(Me.LblOutput)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.TxtB1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pallindrome Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtB1 As TextBox
    Friend WithEvents LblMsg As Label
    Friend WithEvents LblOutput As Label
    Friend WithEvents BtnValidate As Button
End Class
