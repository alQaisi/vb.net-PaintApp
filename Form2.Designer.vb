<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.sfdSavePic = New System.Windows.Forms.SaveFileDialog()
        Me.mnuPaint = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.cmbPenWidth = New System.Windows.Forms.ComboBox()
        Me.lblPenWidth = New System.Windows.Forms.Label()
        Me.cmbBrushSize = New System.Windows.Forms.ComboBox()
        Me.lblBrushSize = New System.Windows.Forms.Label()
        Me.lblToolSelected = New System.Windows.Forms.Label()
        Me.lblEllFill = New System.Windows.Forms.Label()
        Me.lblEllOut = New System.Windows.Forms.Label()
        Me.lblCircFill = New System.Windows.Forms.Label()
        Me.lblCircOut = New System.Windows.Forms.Label()
        Me.lblRecFill = New System.Windows.Forms.Label()
        Me.lblRecOut = New System.Windows.Forms.Label()
        Me.lblSqFill = New System.Windows.Forms.Label()
        Me.lblSqOut = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblBrush = New System.Windows.Forms.Label()
        Me.lblColorSelected = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblWhite = New System.Windows.Forms.Label()
        Me.lblYellow = New System.Windows.Forms.Label()
        Me.lblFuchsia = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblCyan = New System.Windows.Forms.Label()
        Me.lblLime = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblGray = New System.Windows.Forms.Label()
        Me.lblSilver = New System.Windows.Forms.Label()
        Me.lblOlive = New System.Windows.Forms.Label()
        Me.lblPurple = New System.Windows.Forms.Label()
        Me.lblMaroon = New System.Windows.Forms.Label()
        Me.lblTeal = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblNavy = New System.Windows.Forms.Label()
        Me.lblBlack = New System.Windows.Forms.Label()
        Me.cmdFont = New System.Windows.Forms.Button()
        Me.lblFontDetails = New System.Windows.Forms.Label()
        Me.txtInsertText = New System.Windows.Forms.TextBox()
        Me.lblEditText = New System.Windows.Forms.Label()
        Me.pnlFrame = New System.Windows.Forms.Panel()
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.GunaImageReplaceColor1 = New Guna.UI.WinForms.GunaImageReplaceColor(Me.components)
        Me.mnuPaint.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'mnuPaint
        '
        Me.mnuPaint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuPaint.Location = New System.Drawing.Point(0, 0)
        Me.mnuPaint.Name = "mnuPaint"
        Me.mnuPaint.Size = New System.Drawing.Size(624, 24)
        Me.mnuPaint.TabIndex = 0
        Me.mnuPaint.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileSave, Me.mnuFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.Size = New System.Drawing.Size(98, 22)
        Me.mnuFileNew.Text = "New"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(98, 22)
        Me.mnuFileSave.Text = "Save"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(98, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.SystemColors.Control
        Me.pnlMain.Controls.Add(Me.cmbPenWidth)
        Me.pnlMain.Controls.Add(Me.lblPenWidth)
        Me.pnlMain.Controls.Add(Me.cmbBrushSize)
        Me.pnlMain.Controls.Add(Me.lblBrushSize)
        Me.pnlMain.Controls.Add(Me.lblToolSelected)
        Me.pnlMain.Controls.Add(Me.lblEllFill)
        Me.pnlMain.Controls.Add(Me.lblEllOut)
        Me.pnlMain.Controls.Add(Me.lblCircFill)
        Me.pnlMain.Controls.Add(Me.lblCircOut)
        Me.pnlMain.Controls.Add(Me.lblRecFill)
        Me.pnlMain.Controls.Add(Me.lblRecOut)
        Me.pnlMain.Controls.Add(Me.lblSqFill)
        Me.pnlMain.Controls.Add(Me.lblSqOut)
        Me.pnlMain.Controls.Add(Me.lblText)
        Me.pnlMain.Controls.Add(Me.lblLine)
        Me.pnlMain.Controls.Add(Me.lblBrush)
        Me.pnlMain.Controls.Add(Me.lblColorSelected)
        Me.pnlMain.Controls.Add(Me.lblColor)
        Me.pnlMain.Controls.Add(Me.lblWhite)
        Me.pnlMain.Controls.Add(Me.lblYellow)
        Me.pnlMain.Controls.Add(Me.lblFuchsia)
        Me.pnlMain.Controls.Add(Me.lblRed)
        Me.pnlMain.Controls.Add(Me.lblCyan)
        Me.pnlMain.Controls.Add(Me.lblLime)
        Me.pnlMain.Controls.Add(Me.lblBlue)
        Me.pnlMain.Controls.Add(Me.lblGray)
        Me.pnlMain.Controls.Add(Me.lblSilver)
        Me.pnlMain.Controls.Add(Me.lblOlive)
        Me.pnlMain.Controls.Add(Me.lblPurple)
        Me.pnlMain.Controls.Add(Me.lblMaroon)
        Me.pnlMain.Controls.Add(Me.lblTeal)
        Me.pnlMain.Controls.Add(Me.lblGreen)
        Me.pnlMain.Controls.Add(Me.lblNavy)
        Me.pnlMain.Controls.Add(Me.lblBlack)
        Me.pnlMain.Controls.Add(Me.cmdFont)
        Me.pnlMain.Controls.Add(Me.lblFontDetails)
        Me.pnlMain.Controls.Add(Me.txtInsertText)
        Me.pnlMain.Controls.Add(Me.lblEditText)
        Me.pnlMain.Enabled = False
        Me.pnlMain.Location = New System.Drawing.Point(0, 24)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(624, 538)
        Me.pnlMain.TabIndex = 1
        '
        'cmbPenWidth
        '
        Me.cmbPenWidth.FormattingEnabled = True
        Me.cmbPenWidth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbPenWidth.Location = New System.Drawing.Point(573, 459)
        Me.cmbPenWidth.Name = "cmbPenWidth"
        Me.cmbPenWidth.Size = New System.Drawing.Size(36, 21)
        Me.cmbPenWidth.TabIndex = 37
        Me.cmbPenWidth.Text = "2"
        '
        'lblPenWidth
        '
        Me.lblPenWidth.Location = New System.Drawing.Point(496, 462)
        Me.lblPenWidth.Name = "lblPenWidth"
        Me.lblPenWidth.Size = New System.Drawing.Size(71, 13)
        Me.lblPenWidth.TabIndex = 36
        Me.lblPenWidth.Text = "Pen Width:"
        Me.lblPenWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbBrushSize
        '
        Me.cmbBrushSize.FormattingEnabled = True
        Me.cmbBrushSize.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32"})
        Me.cmbBrushSize.Location = New System.Drawing.Point(573, 432)
        Me.cmbBrushSize.Name = "cmbBrushSize"
        Me.cmbBrushSize.Size = New System.Drawing.Size(36, 21)
        Me.cmbBrushSize.TabIndex = 35
        Me.cmbBrushSize.Text = "6"
        '
        'lblBrushSize
        '
        Me.lblBrushSize.Location = New System.Drawing.Point(496, 435)
        Me.lblBrushSize.Name = "lblBrushSize"
        Me.lblBrushSize.Size = New System.Drawing.Size(71, 13)
        Me.lblBrushSize.TabIndex = 34
        Me.lblBrushSize.Text = "Brush size:"
        Me.lblBrushSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblToolSelected
        '
        Me.lblToolSelected.AutoSize = True
        Me.lblToolSelected.Location = New System.Drawing.Point(497, 243)
        Me.lblToolSelected.Name = "lblToolSelected"
        Me.lblToolSelected.Size = New System.Drawing.Size(101, 13)
        Me.lblToolSelected.TabIndex = 33
        Me.lblToolSelected.Text = "Tool: none selected"
        '
        'lblEllFill
        '
        Me.lblEllFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEllFill.Image = CType(resources.GetObject("lblEllFill.Image"), System.Drawing.Image)
        Me.lblEllFill.Location = New System.Drawing.Point(536, 382)
        Me.lblEllFill.Name = "lblEllFill"
        Me.lblEllFill.Size = New System.Drawing.Size(36, 36)
        Me.lblEllFill.TabIndex = 23
        Me.lblEllFill.Tag = "EllipseFilled"
        '
        'lblEllOut
        '
        Me.lblEllOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEllOut.Image = CType(resources.GetObject("lblEllOut.Image"), System.Drawing.Image)
        Me.lblEllOut.Location = New System.Drawing.Point(499, 382)
        Me.lblEllOut.Name = "lblEllOut"
        Me.lblEllOut.Size = New System.Drawing.Size(36, 36)
        Me.lblEllOut.TabIndex = 24
        Me.lblEllOut.Tag = "Ellipse"
        '
        'lblCircFill
        '
        Me.lblCircFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCircFill.Image = CType(resources.GetObject("lblCircFill.Image"), System.Drawing.Image)
        Me.lblCircFill.Location = New System.Drawing.Point(573, 342)
        Me.lblCircFill.Name = "lblCircFill"
        Me.lblCircFill.Size = New System.Drawing.Size(36, 36)
        Me.lblCircFill.TabIndex = 25
        Me.lblCircFill.Tag = "CircFilled"
        '
        'lblCircOut
        '
        Me.lblCircOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCircOut.Image = CType(resources.GetObject("lblCircOut.Image"), System.Drawing.Image)
        Me.lblCircOut.Location = New System.Drawing.Point(536, 342)
        Me.lblCircOut.Name = "lblCircOut"
        Me.lblCircOut.Size = New System.Drawing.Size(36, 36)
        Me.lblCircOut.TabIndex = 26
        Me.lblCircOut.Tag = "Circ"
        '
        'lblRecFill
        '
        Me.lblRecFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecFill.Image = CType(resources.GetObject("lblRecFill.Image"), System.Drawing.Image)
        Me.lblRecFill.Location = New System.Drawing.Point(499, 342)
        Me.lblRecFill.Name = "lblRecFill"
        Me.lblRecFill.Size = New System.Drawing.Size(36, 36)
        Me.lblRecFill.TabIndex = 27
        Me.lblRecFill.Tag = "RectFilled"
        '
        'lblRecOut
        '
        Me.lblRecOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecOut.Image = CType(resources.GetObject("lblRecOut.Image"), System.Drawing.Image)
        Me.lblRecOut.Location = New System.Drawing.Point(573, 302)
        Me.lblRecOut.Name = "lblRecOut"
        Me.lblRecOut.Size = New System.Drawing.Size(36, 36)
        Me.lblRecOut.TabIndex = 28
        Me.lblRecOut.Tag = "Rect"
        '
        'lblSqFill
        '
        Me.lblSqFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSqFill.Image = CType(resources.GetObject("lblSqFill.Image"), System.Drawing.Image)
        Me.lblSqFill.Location = New System.Drawing.Point(536, 302)
        Me.lblSqFill.Name = "lblSqFill"
        Me.lblSqFill.Size = New System.Drawing.Size(36, 36)
        Me.lblSqFill.TabIndex = 29
        Me.lblSqFill.Tag = "SquareFilled"
        '
        'lblSqOut
        '
        Me.lblSqOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSqOut.Image = CType(resources.GetObject("lblSqOut.Image"), System.Drawing.Image)
        Me.lblSqOut.Location = New System.Drawing.Point(499, 302)
        Me.lblSqOut.Name = "lblSqOut"
        Me.lblSqOut.Size = New System.Drawing.Size(36, 36)
        Me.lblSqOut.TabIndex = 30
        Me.lblSqOut.Tag = "Square"
        '
        'lblText
        '
        Me.lblText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblText.Image = CType(resources.GetObject("lblText.Image"), System.Drawing.Image)
        Me.lblText.Location = New System.Drawing.Point(573, 262)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(36, 36)
        Me.lblText.TabIndex = 31
        Me.lblText.Tag = "Text"
        '
        'lblLine
        '
        Me.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLine.Image = CType(resources.GetObject("lblLine.Image"), System.Drawing.Image)
        Me.lblLine.Location = New System.Drawing.Point(536, 262)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(36, 36)
        Me.lblLine.TabIndex = 32
        Me.lblLine.Tag = "Line"
        '
        'lblBrush
        '
        Me.lblBrush.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBrush.Image = CType(resources.GetObject("lblBrush.Image"), System.Drawing.Image)
        Me.lblBrush.Location = New System.Drawing.Point(499, 262)
        Me.lblBrush.Name = "lblBrush"
        Me.lblBrush.Size = New System.Drawing.Size(36, 36)
        Me.lblBrush.TabIndex = 22
        Me.lblBrush.Tag = "Brush"
        '
        'lblColorSelected
        '
        Me.lblColorSelected.AutoSize = True
        Me.lblColorSelected.Location = New System.Drawing.Point(497, 27)
        Me.lblColorSelected.Name = "lblColorSelected"
        Me.lblColorSelected.Size = New System.Drawing.Size(70, 13)
        Me.lblColorSelected.TabIndex = 21
        Me.lblColorSelected.Text = "Colour: Black"
        '
        'lblColor
        '
        Me.lblColor.BackColor = System.Drawing.Color.Black
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor.Location = New System.Drawing.Point(499, 185)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(110, 45)
        Me.lblColor.TabIndex = 20
        '
        'lblWhite
        '
        Me.lblWhite.BackColor = System.Drawing.Color.White
        Me.lblWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWhite.Location = New System.Drawing.Point(586, 152)
        Me.lblWhite.Name = "lblWhite"
        Me.lblWhite.Size = New System.Drawing.Size(23, 23)
        Me.lblWhite.TabIndex = 5
        '
        'lblYellow
        '
        Me.lblYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYellow.Location = New System.Drawing.Point(557, 152)
        Me.lblYellow.Name = "lblYellow"
        Me.lblYellow.Size = New System.Drawing.Size(23, 23)
        Me.lblYellow.TabIndex = 6
        '
        'lblFuchsia
        '
        Me.lblFuchsia.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFuchsia.Location = New System.Drawing.Point(528, 152)
        Me.lblFuchsia.Name = "lblFuchsia"
        Me.lblFuchsia.Size = New System.Drawing.Size(23, 23)
        Me.lblFuchsia.TabIndex = 7
        '
        'lblRed
        '
        Me.lblRed.BackColor = System.Drawing.Color.Red
        Me.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRed.Location = New System.Drawing.Point(499, 152)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(23, 23)
        Me.lblRed.TabIndex = 8
        '
        'lblCyan
        '
        Me.lblCyan.BackColor = System.Drawing.Color.Cyan
        Me.lblCyan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCyan.Location = New System.Drawing.Point(586, 117)
        Me.lblCyan.Name = "lblCyan"
        Me.lblCyan.Size = New System.Drawing.Size(23, 23)
        Me.lblCyan.TabIndex = 9
        '
        'lblLime
        '
        Me.lblLime.BackColor = System.Drawing.Color.Lime
        Me.lblLime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLime.Location = New System.Drawing.Point(557, 117)
        Me.lblLime.Name = "lblLime"
        Me.lblLime.Size = New System.Drawing.Size(23, 23)
        Me.lblLime.TabIndex = 10
        '
        'lblBlue
        '
        Me.lblBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlue.Location = New System.Drawing.Point(528, 117)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(23, 23)
        Me.lblBlue.TabIndex = 11
        '
        'lblGray
        '
        Me.lblGray.BackColor = System.Drawing.Color.Gray
        Me.lblGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGray.Location = New System.Drawing.Point(499, 117)
        Me.lblGray.Name = "lblGray"
        Me.lblGray.Size = New System.Drawing.Size(23, 23)
        Me.lblGray.TabIndex = 12
        '
        'lblSilver
        '
        Me.lblSilver.BackColor = System.Drawing.Color.Silver
        Me.lblSilver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSilver.Location = New System.Drawing.Point(586, 82)
        Me.lblSilver.Name = "lblSilver"
        Me.lblSilver.Size = New System.Drawing.Size(23, 23)
        Me.lblSilver.TabIndex = 13
        '
        'lblOlive
        '
        Me.lblOlive.BackColor = System.Drawing.Color.Olive
        Me.lblOlive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOlive.Location = New System.Drawing.Point(557, 82)
        Me.lblOlive.Name = "lblOlive"
        Me.lblOlive.Size = New System.Drawing.Size(23, 23)
        Me.lblOlive.TabIndex = 14
        '
        'lblPurple
        '
        Me.lblPurple.BackColor = System.Drawing.Color.Purple
        Me.lblPurple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPurple.Location = New System.Drawing.Point(528, 82)
        Me.lblPurple.Name = "lblPurple"
        Me.lblPurple.Size = New System.Drawing.Size(23, 23)
        Me.lblPurple.TabIndex = 15
        '
        'lblMaroon
        '
        Me.lblMaroon.BackColor = System.Drawing.Color.Maroon
        Me.lblMaroon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaroon.Location = New System.Drawing.Point(499, 82)
        Me.lblMaroon.Name = "lblMaroon"
        Me.lblMaroon.Size = New System.Drawing.Size(23, 23)
        Me.lblMaroon.TabIndex = 16
        '
        'lblTeal
        '
        Me.lblTeal.BackColor = System.Drawing.Color.Teal
        Me.lblTeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTeal.Location = New System.Drawing.Point(586, 47)
        Me.lblTeal.Name = "lblTeal"
        Me.lblTeal.Size = New System.Drawing.Size(23, 23)
        Me.lblTeal.TabIndex = 17
        '
        'lblGreen
        '
        Me.lblGreen.BackColor = System.Drawing.Color.Green
        Me.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGreen.Location = New System.Drawing.Point(557, 47)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(23, 23)
        Me.lblGreen.TabIndex = 18
        '
        'lblNavy
        '
        Me.lblNavy.BackColor = System.Drawing.Color.Navy
        Me.lblNavy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNavy.Location = New System.Drawing.Point(528, 47)
        Me.lblNavy.Name = "lblNavy"
        Me.lblNavy.Size = New System.Drawing.Size(23, 23)
        Me.lblNavy.TabIndex = 19
        '
        'lblBlack
        '
        Me.lblBlack.BackColor = System.Drawing.Color.Black
        Me.lblBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlack.Location = New System.Drawing.Point(499, 47)
        Me.lblBlack.Name = "lblBlack"
        Me.lblBlack.Size = New System.Drawing.Size(23, 23)
        Me.lblBlack.TabIndex = 4
        '
        'cmdFont
        '
        Me.cmdFont.Location = New System.Drawing.Point(512, 485)
        Me.cmdFont.Name = "cmdFont"
        Me.cmdFont.Size = New System.Drawing.Size(97, 23)
        Me.cmdFont.TabIndex = 3
        Me.cmdFont.Text = "Select Font"
        Me.cmdFont.UseVisualStyleBackColor = True
        '
        'lblFontDetails
        '
        Me.lblFontDetails.AutoSize = True
        Me.lblFontDetails.Location = New System.Drawing.Point(317, 6)
        Me.lblFontDetails.Name = "lblFontDetails"
        Me.lblFontDetails.Size = New System.Drawing.Size(100, 13)
        Me.lblFontDetails.TabIndex = 2
        Me.lblFontDetails.Text = "(Arial 12pt, Regular)"
        '
        'txtInsertText
        '
        Me.txtInsertText.Location = New System.Drawing.Point(75, 3)
        Me.txtInsertText.Name = "txtInsertText"
        Me.txtInsertText.Size = New System.Drawing.Size(225, 20)
        Me.txtInsertText.TabIndex = 1
        '
        'lblEditText
        '
        Me.lblEditText.AutoSize = True
        Me.lblEditText.Location = New System.Drawing.Point(12, 6)
        Me.lblEditText.Name = "lblEditText"
        Me.lblEditText.Size = New System.Drawing.Size(57, 13)
        Me.lblEditText.TabIndex = 0
        Me.lblEditText.Text = "Insert Text"
        '
        'pnlFrame
        '
        Me.pnlFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFrame.Location = New System.Drawing.Point(9, 49)
        Me.pnlFrame.Name = "pnlFrame"
        Me.pnlFrame.Size = New System.Drawing.Size(482, 482)
        Me.pnlFrame.TabIndex = 2
        '
        'picCanvas
        '
        Me.picCanvas.BackColor = System.Drawing.Color.Gray
        Me.picCanvas.Location = New System.Drawing.Point(10, 50)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(480, 480)
        Me.picCanvas.TabIndex = 3
        Me.picCanvas.TabStop = False
        '
        'GunaImageReplaceColor1
        '
        Me.GunaImageReplaceColor1.Image = Nothing
        Me.GunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty
        Me.GunaImageReplaceColor1.OldColor = System.Drawing.Color.White
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 561)
        Me.Controls.Add(Me.picCanvas)
        Me.Controls.Add(Me.pnlFrame)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.mnuPaint)
        Me.MainMenuStrip = Me.mnuPaint
        Me.MaximumSize = New System.Drawing.Size(640, 600)
        Me.MinimumSize = New System.Drawing.Size(640, 600)
        Me.Name = "Form2"
        Me.Text = "vb.net Paint"
        Me.mnuPaint.ResumeLayout(False)
        Me.mnuPaint.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents dlgFont As FontDialog
    Friend WithEvents sfdSavePic As SaveFileDialog
    Friend WithEvents mnuPaint As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlFrame As Panel
    Friend WithEvents picCanvas As PictureBox
    Friend WithEvents cmdFont As Button
    Friend WithEvents lblFontDetails As Label
    Friend WithEvents txtInsertText As TextBox
    Friend WithEvents lblEditText As Label
    Friend WithEvents lblBlack As Label
    Friend WithEvents GunaImageReplaceColor1 As Guna.UI.WinForms.GunaImageReplaceColor
    Friend WithEvents lblWhite As Label
    Friend WithEvents lblYellow As Label
    Friend WithEvents lblFuchsia As Label
    Friend WithEvents lblRed As Label
    Friend WithEvents lblCyan As Label
    Friend WithEvents lblLime As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblGray As Label
    Friend WithEvents lblSilver As Label
    Friend WithEvents lblOlive As Label
    Friend WithEvents lblPurple As Label
    Friend WithEvents lblMaroon As Label
    Friend WithEvents lblTeal As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblNavy As Label
    Friend WithEvents lblColorSelected As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblBrush As Label
    Friend WithEvents lblToolSelected As Label
    Friend WithEvents lblEllFill As Label
    Friend WithEvents lblEllOut As Label
    Friend WithEvents lblCircFill As Label
    Friend WithEvents lblCircOut As Label
    Friend WithEvents lblRecFill As Label
    Friend WithEvents lblRecOut As Label
    Friend WithEvents lblSqFill As Label
    Friend WithEvents lblSqOut As Label
    Friend WithEvents lblText As Label
    Friend WithEvents lblLine As Label
    Friend WithEvents cmbBrushSize As ComboBox
    Friend WithEvents lblBrushSize As Label
    Friend WithEvents cmbPenWidth As ComboBox
    Friend WithEvents lblPenWidth As Label
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
End Class
