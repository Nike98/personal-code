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
        Me.L1 = New System.Windows.Forms.ListBox()
        Me.L2 = New System.Windows.Forms.ListBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnAddAll = New System.Windows.Forms.Button()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.ButtonDelAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.FormattingEnabled = True
        Me.L1.ItemHeight = 16
        Me.L1.Items.AddRange(New Object() {"User 1", "User 2", "User 3", "User 4", "User 5", "User 6", "User 7", "User 8"})
        Me.L1.Location = New System.Drawing.Point(41, 90)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(163, 180)
        Me.L1.TabIndex = 0
        '
        'L2
        '
        Me.L2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.FormattingEnabled = True
        Me.L2.ItemHeight = 16
        Me.L2.Location = New System.Drawing.Point(477, 90)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(163, 180)
        Me.L2.TabIndex = 1
        '
        'BtnAdd
        '
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnAdd.Location = New System.Drawing.Point(304, 109)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnAddAll
        '
        Me.BtnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnAddAll.Location = New System.Drawing.Point(304, 150)
        Me.BtnAddAll.Name = "BtnAddAll"
        Me.BtnAddAll.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddAll.TabIndex = 3
        Me.BtnAddAll.Text = "Add All"
        Me.BtnAddAll.UseVisualStyleBackColor = True
        '
        'ButtonDel
        '
        Me.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonDel.Location = New System.Drawing.Point(304, 192)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDel.TabIndex = 4
        Me.ButtonDel.Text = "Delete"
        Me.ButtonDel.UseVisualStyleBackColor = True
        '
        'ButtonDelAll
        '
        Me.ButtonDelAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonDelAll.Location = New System.Drawing.Point(304, 231)
        Me.ButtonDelAll.Name = "ButtonDelAll"
        Me.ButtonDelAll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelAll.TabIndex = 5
        Me.ButtonDelAll.Text = "Delete All"
        Me.ButtonDelAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(689, 435)
        Me.Controls.Add(Me.ButtonDelAll)
        Me.Controls.Add(Me.ButtonDel)
        Me.Controls.Add(Me.BtnAddAll)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add And Delete List Box Items"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents L1 As ListBox
    Friend WithEvents L2 As ListBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnAddAll As Button
    Friend WithEvents ButtonDel As Button
    Friend WithEvents ButtonDelAll As Button
End Class
