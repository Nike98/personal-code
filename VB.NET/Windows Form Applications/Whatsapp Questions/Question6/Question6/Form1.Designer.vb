<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm1
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
        Me.LstB1 = New System.Windows.Forms.ListBox()
        Me.LstB2 = New System.Windows.Forms.ListBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstB1
        '
        Me.LstB1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstB1.FormattingEnabled = True
        Me.LstB1.ItemHeight = 16
        Me.LstB1.Items.AddRange(New Object() {"User 1", "User 2", "User 3", "User 4", "User 5", "User 6", "User 7"})
        Me.LstB1.Location = New System.Drawing.Point(39, 46)
        Me.LstB1.Name = "LstB1"
        Me.LstB1.Size = New System.Drawing.Size(120, 132)
        Me.LstB1.TabIndex = 0
        '
        'LstB2
        '
        Me.LstB2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstB2.FormattingEnabled = True
        Me.LstB2.ItemHeight = 16
        Me.LstB2.Location = New System.Drawing.Point(427, 46)
        Me.LstB2.Name = "LstB2"
        Me.LstB2.Size = New System.Drawing.Size(120, 132)
        Me.LstB2.TabIndex = 1
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(237, 92)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(122, 35)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(592, 239)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.LstB2)
        Me.Controls.Add(Me.LstB1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListBox And Buttons"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstB1 As ListBox
    Friend WithEvents LstB2 As ListBox
    Friend WithEvents BtnAdd As Button
End Class
