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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm1))
        Me.TaherShah = New System.Windows.Forms.PictureBox()
        Me.BtnTaher = New System.Windows.Forms.Button()
        Me.Shaktimaan = New System.Windows.Forms.PictureBox()
        Me.BtnShakti = New System.Windows.Forms.Button()
        Me.TmrTaher = New System.Windows.Forms.Timer(Me.components)
        Me.TmrShakti = New System.Windows.Forms.Timer(Me.components)
        Me.StopBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        CType(Me.TaherShah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shaktimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TaherShah
        '
        Me.TaherShah.Image = CType(resources.GetObject("TaherShah.Image"), System.Drawing.Image)
        Me.TaherShah.Location = New System.Drawing.Point(12, 12)
        Me.TaherShah.Name = "TaherShah"
        Me.TaherShah.Size = New System.Drawing.Size(140, 95)
        Me.TaherShah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TaherShah.TabIndex = 0
        Me.TaherShah.TabStop = False
        '
        'BtnTaher
        '
        Me.BtnTaher.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTaher.Location = New System.Drawing.Point(12, 125)
        Me.BtnTaher.Name = "BtnTaher"
        Me.BtnTaher.Size = New System.Drawing.Size(168, 23)
        Me.BtnTaher.TabIndex = 1
        Me.BtnTaher.Text = "Click to Start Taher Shah"
        Me.BtnTaher.UseVisualStyleBackColor = True
        '
        'Shaktimaan
        '
        Me.Shaktimaan.Image = CType(resources.GetObject("Shaktimaan.Image"), System.Drawing.Image)
        Me.Shaktimaan.Location = New System.Drawing.Point(12, 182)
        Me.Shaktimaan.Name = "Shaktimaan"
        Me.Shaktimaan.Size = New System.Drawing.Size(140, 95)
        Me.Shaktimaan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Shaktimaan.TabIndex = 2
        Me.Shaktimaan.TabStop = False
        '
        'BtnShakti
        '
        Me.BtnShakti.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShakti.Location = New System.Drawing.Point(12, 298)
        Me.BtnShakti.Name = "BtnShakti"
        Me.BtnShakti.Size = New System.Drawing.Size(168, 23)
        Me.BtnShakti.TabIndex = 3
        Me.BtnShakti.Text = "Click to Start Shaktimaan"
        Me.BtnShakti.UseVisualStyleBackColor = True
        '
        'TmrTaher
        '
        Me.TmrTaher.Interval = 200
        '
        'TmrShakti
        '
        Me.TmrShakti.Interval = 200
        '
        'StopBtn
        '
        Me.StopBtn.Location = New System.Drawing.Point(385, 298)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.Size = New System.Drawing.Size(75, 23)
        Me.StopBtn.TabIndex = 4
        Me.StopBtn.Text = "Stop"
        Me.StopBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(515, 298)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 345)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.StopBtn)
        Me.Controls.Add(Me.BtnShakti)
        Me.Controls.Add(Me.Shaktimaan)
        Me.Controls.Add(Me.BtnTaher)
        Me.Controls.Add(Me.TaherShah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taher Aur Shaktimaan"
        CType(Me.TaherShah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shaktimaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TaherShah As PictureBox
    Friend WithEvents BtnTaher As Button
    Friend WithEvents Shaktimaan As PictureBox
    Friend WithEvents BtnShakti As Button
    Friend WithEvents TmrTaher As Timer
    Friend WithEvents TmrShakti As Timer
    Friend WithEvents StopBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
