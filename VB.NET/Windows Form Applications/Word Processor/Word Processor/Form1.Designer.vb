<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbBold = New System.Windows.Forms.ToolStripButton()
        Me.tsbItalic = New System.Windows.Forms.ToolStripButton()
        Me.tsbUnderline = New System.Windows.Forms.ToolStripButton()
        Me.tsbStrike = New System.Windows.Forms.ToolStripButton()
        Me.tscbFontSize = New System.Windows.Forms.ToolStripComboBox()
        Me.rtbContent = New System.Windows.Forms.RichTextBox()
        Me.OpenDiag = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDiag = New System.Windows.Forms.SaveFileDialog()
        Me.MainMenu.SuspendLayout()
        Me.TsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.InsertToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(592, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator2, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(187, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripMenuItem2, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CToolStripMenuItem.Text = "C&ut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(162, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PictureToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.InsertToolStripMenuItem.Text = "&Insert"
        '
        'PictureToolStripMenuItem
        '
        Me.PictureToolStripMenuItem.Name = "PictureToolStripMenuItem"
        Me.PictureToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PictureToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PictureToolStripMenuItem.Text = "Pic&ture"
        '
        'TsMain
        '
        Me.TsMain.BackColor = System.Drawing.Color.Gainsboro
        Me.TsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.tsbOpen, Me.tsbSave, Me.ToolStripSeparator1, Me.tsbBold, Me.tsbItalic, Me.tsbUnderline, Me.tsbStrike, Me.tscbFontSize})
        Me.TsMain.Location = New System.Drawing.Point(0, 24)
        Me.TsMain.Name = "TsMain"
        Me.TsMain.Size = New System.Drawing.Size(592, 25)
        Me.TsMain.TabIndex = 1
        Me.TsMain.Text = "ToolStrip1"
        '
        'tsbNew
        '
        Me.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNew.Image = CType(resources.GetObject("tsbNew.Image"), System.Drawing.Image)
        Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.Size = New System.Drawing.Size(23, 22)
        Me.tsbNew.Text = "Create New File"
        '
        'tsbOpen
        '
        Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOpen.Image = CType(resources.GetObject("tsbOpen.Image"), System.Drawing.Image)
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(23, 22)
        Me.tsbOpen.Text = "Open New File"
        '
        'tsbSave
        '
        Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSave.Image = CType(resources.GetObject("tsbSave.Image"), System.Drawing.Image)
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(23, 22)
        Me.tsbSave.Text = "Save "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbBold
        '
        Me.tsbBold.CheckOnClick = True
        Me.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbBold.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbBold.Image = CType(resources.GetObject("tsbBold.Image"), System.Drawing.Image)
        Me.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBold.Name = "tsbBold"
        Me.tsbBold.Size = New System.Drawing.Size(23, 22)
        Me.tsbBold.Text = "B"
        '
        'tsbItalic
        '
        Me.tsbItalic.CheckOnClick = True
        Me.tsbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbItalic.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbItalic.Image = CType(resources.GetObject("tsbItalic.Image"), System.Drawing.Image)
        Me.tsbItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbItalic.Name = "tsbItalic"
        Me.tsbItalic.Size = New System.Drawing.Size(23, 22)
        Me.tsbItalic.Text = "I"
        '
        'tsbUnderline
        '
        Me.tsbUnderline.CheckOnClick = True
        Me.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbUnderline.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbUnderline.Image = CType(resources.GetObject("tsbUnderline.Image"), System.Drawing.Image)
        Me.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUnderline.Name = "tsbUnderline"
        Me.tsbUnderline.Size = New System.Drawing.Size(23, 22)
        Me.tsbUnderline.Text = "U"
        '
        'tsbStrike
        '
        Me.tsbStrike.CheckOnClick = True
        Me.tsbStrike.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbStrike.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbStrike.Image = CType(resources.GetObject("tsbStrike.Image"), System.Drawing.Image)
        Me.tsbStrike.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStrike.Name = "tsbStrike"
        Me.tsbStrike.Size = New System.Drawing.Size(23, 22)
        Me.tsbStrike.Text = "S"
        '
        'tscbFontSize
        '
        Me.tscbFontSize.BackColor = System.Drawing.SystemColors.Window
        Me.tscbFontSize.DropDownHeight = 90
        Me.tscbFontSize.IntegralHeight = False
        Me.tscbFontSize.Items.AddRange(New Object() {"2", "4", "6", "7.8", "8", "9", "10", "12", "14", "16", "18", "22", "24", "26", "28", "36", "42", "54", "62", "68", "72"})
        Me.tscbFontSize.Name = "tscbFontSize"
        Me.tscbFontSize.Size = New System.Drawing.Size(75, 25)
        Me.tscbFontSize.Text = "7.8"
        '
        'rtbContent
        '
        Me.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbContent.Location = New System.Drawing.Point(12, 52)
        Me.rtbContent.Name = "rtbContent"
        Me.rtbContent.Size = New System.Drawing.Size(568, 386)
        Me.rtbContent.TabIndex = 2
        Me.rtbContent.Text = ""
        '
        'SaveFileDiag
        '
        Me.SaveFileDiag.Filter = "Rich Text File | *.rtf"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 450)
        Me.Controls.Add(Me.rtbContent)
        Me.Controls.Add(Me.TsMain)
        Me.Controls.Add(Me.MainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Word Processor"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.TsMain.ResumeLayout(False)
        Me.TsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TsMain As ToolStrip
    Friend WithEvents rtbContent As RichTextBox
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbNew As ToolStripButton
    Friend WithEvents tsbOpen As ToolStripButton
    Friend WithEvents tsbSave As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbBold As ToolStripButton
    Friend WithEvents tsbItalic As ToolStripButton
    Friend WithEvents tsbUnderline As ToolStripButton
    Friend WithEvents tsbStrike As ToolStripButton
    Friend WithEvents tscbFontSize As ToolStripComboBox
    Friend WithEvents OpenDiag As OpenFileDialog
    Friend WithEvents SaveFileDiag As SaveFileDialog
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
