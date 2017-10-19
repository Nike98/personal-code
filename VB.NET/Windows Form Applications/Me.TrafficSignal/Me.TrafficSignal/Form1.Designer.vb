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
        Me.components = New System.ComponentModel.Container()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShapeRed = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShapeYellow = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShapeGreen = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShapeGreen, Me.OvalShapeYellow, Me.OvalShapeRed})
        Me.ShapeContainer1.Size = New System.Drawing.Size(180, 390)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShapeRed
        '
        Me.OvalShapeRed.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OvalShapeRed.BorderWidth = 3
        Me.OvalShapeRed.Location = New System.Drawing.Point(51, 24)
        Me.OvalShapeRed.Name = "OvalShapeRed"
        Me.OvalShapeRed.Size = New System.Drawing.Size(75, 75)
        '
        'OvalShapeYellow
        '
        Me.OvalShapeYellow.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OvalShapeYellow.BorderWidth = 3
        Me.OvalShapeYellow.Location = New System.Drawing.Point(51, 135)
        Me.OvalShapeYellow.Name = "OvalShapeYellow"
        Me.OvalShapeYellow.Size = New System.Drawing.Size(75, 75)
        '
        'OvalShapeGreen
        '
        Me.OvalShapeGreen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OvalShapeGreen.BorderWidth = 3
        Me.OvalShapeGreen.Location = New System.Drawing.Point(51, 247)
        Me.OvalShapeGreen.Name = "OvalShapeGreen"
        Me.OvalShapeGreen.Size = New System.Drawing.Size(75, 75)
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(51, 355)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(180, 390)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traffic Signal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShapeRed As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShapeGreen As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShapeYellow As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer

End Class
