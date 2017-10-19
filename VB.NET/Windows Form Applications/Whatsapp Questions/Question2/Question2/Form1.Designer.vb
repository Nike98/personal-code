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
        Me.LabelInput = New System.Windows.Forms.Label()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.LabelMsg = New System.Windows.Forms.Label()
        Me.ComboBoxColors = New System.Windows.Forms.ComboBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelInput
        '
        Me.LabelInput.AutoSize = True
        Me.LabelInput.BackColor = System.Drawing.SystemColors.Window
        Me.LabelInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInput.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInput.Location = New System.Drawing.Point(133, 19)
        Me.LabelInput.Name = "LabelInput"
        Me.LabelInput.Size = New System.Drawing.Size(175, 15)
        Me.LabelInput.TabIndex = 0
        Me.LabelInput.Text = "Input The Name Of the Colour"
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInput.Location = New System.Drawing.Point(160, 48)
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.Size = New System.Drawing.Size(121, 23)
        Me.TextBoxInput.TabIndex = 1
        '
        'LabelMsg
        '
        Me.LabelMsg.AutoSize = True
        Me.LabelMsg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelMsg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMsg.Location = New System.Drawing.Point(118, 147)
        Me.LabelMsg.Name = "LabelMsg"
        Me.LabelMsg.Size = New System.Drawing.Size(228, 18)
        Me.LabelMsg.TabIndex = 2
        Me.LabelMsg.Text = "The Color will be Added in the List"
        Me.LabelMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBoxColors
        '
        Me.ComboBoxColors.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBoxColors.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxColors.FormattingEnabled = True
        Me.ComboBoxColors.Location = New System.Drawing.Point(160, 181)
        Me.ComboBoxColors.Name = "ComboBoxColors"
        Me.ComboBoxColors.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxColors.TabIndex = 3
        '
        'ButtonAdd
        '
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonAdd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(183, 93)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 36)
        Me.ButtonAdd.TabIndex = 4
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(471, 241)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ComboBoxColors)
        Me.Controls.Add(Me.LabelMsg)
        Me.Controls.Add(Me.TextBoxInput)
        Me.Controls.Add(Me.LabelInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Background Change By Colour Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelInput As Label
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents LabelMsg As Label
    Friend WithEvents ComboBoxColors As ComboBox
    Friend WithEvents ButtonAdd As Button
End Class
