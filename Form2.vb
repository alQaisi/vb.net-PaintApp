Imports System.Drawing.Drawing2D
Imports System.Drawing.Brush

Public Class Form2
    Dim G As Drawing.Graphics
    Dim drawFlag As Boolean = False
    Dim xDown, yDown, xUp, yUp As Integer
    Dim intL, intR, intT, intB, intW, intH As Integer
    Dim clrSelected As Color = Color.Black
    Dim intToolSelected As Integer = 0
    Dim intBrushSize As Integer = 6
    Dim strText As String
    Dim strFont As String = "Arial"
    Dim styFontStyle As FontStyle

    Sub dimSquare()
        If xUp < 0 Then xUp = 0
        If xUp > 480 Then xUp = 480
        If yUp < 0 Then yUp = 0
        If yUp > 480 Then yUp = 480
        intW = Math.Abs(xUp - xDown)
        intH = Math.Abs(yUp - yDown)
        If intW > intH Then intW = intH
        If xUp < xDown Then intL = xDown - intW Else intL = xDown
        If yUp < yDown Then intT = yDown - intW Else intT = yDown
    End Sub
    Sub dimRectangle()
        If xUp < 0 Then xUp = 0
        If xUp > 480 Then xUp = 480
        If yUp < 0 Then yUp = 0
        If yUp > 480 Then yUp = 480
        intW = Math.Abs(xUp - xDown)
        intH = Math.Abs(yUp - yDown)
        If xUp < xDown Then intL = xDown - intW Else intL = xDown
        If yUp < yDown Then intT = yDown - intH Else intT = yDown
    End Sub
    Sub dimCircle()
        If xUp < 0 Then xUp = 0
        If xUp > 480 Then xUp = 480
        If yUp < 0 Then yUp = 0
        If yUp > 480 Then yUp = 480
        intW = Math.Abs(xUp - xDown)
        intH = Math.Abs(yUp - yDown)
        If intW < intH Then intW = intH
        intL = xDown - intW
        intT = yDown - intW
        intW *= 2
    End Sub
    Sub dimEllipse()
        If xUp < 0 Then xUp = 0
        If xUp > 480 Then xUp = 480
        If yUp < 0 Then yUp = 0
        If yUp > 480 Then yUp = 480
        intW = Math.Abs(xUp - xDown)
        intH = Math.Abs(yUp - yDown)
        intL = xDown - intW
        intT = yDown - intH
        intW *= 2
        intH *= 2
    End Sub



    Private Sub lblPalette_Click(sender As Object, e As EventArgs) _
  Handles lblBlack.Click, lblNavy.Click, lblGreen.Click, lblTeal.Click,
    lblMaroon.Click, lblPurple.Click, lblOlive.Click, lblSilver.Click,
      lblGray.Click, lblBlue.Click, lblLime.Click, lblCyan.Click,
        lblRed.Click, lblFuchsia.Click, lblYellow.Click, lblWhite.Click
        lblColor.BackColor = sender.BackColor
        clrSelected = sender.BackColor
        Select Case clrSelected
            Case Color.Black
                lblColorSelected.Text = "Colour: Black"
            Case Color.Navy
                lblColorSelected.Text = "Colour: Navy"
            Case Color.Green
                lblColorSelected.Text = "Colour: Green"
            Case Color.Teal
                lblColorSelected.Text = "Colour: Teal"
            Case Color.Maroon
                lblColorSelected.Text = "Colour: Maroon"
            Case Color.Purple
                lblColorSelected.Text = "Colour: Purple"
            Case Color.Olive
                lblColorSelected.Text = "Colour: Olive"
            Case Color.Silver
                lblColorSelected.Text = "Colour: Silver"
            Case Color.Gray
                lblColorSelected.Text = "Colour: Gray"
            Case Color.Blue
                lblColorSelected.Text = "Colour: Blue"
            Case Color.Lime
                lblColorSelected.Text = "Colour: Lime"
            Case Color.Cyan
                lblColorSelected.Text = "Colour: Cyan"
            Case Color.Red
                lblColorSelected.Text = "Colour: Red"
            Case Color.Fuchsia
                lblColorSelected.Text = "Colour: Fuchsia"
            Case Color.Yellow
                lblColorSelected.Text = "Colour: Yellow"
            Case Color.White
                lblColorSelected.Text = "Colour: White"
        End Select
    End Sub

    Sub resetTools()
        lblBrush.BorderStyle = BorderStyle.Fixed3D
        lblLine.BorderStyle = BorderStyle.Fixed3D
        lblText.BorderStyle = BorderStyle.Fixed3D
        lblSqOut.BorderStyle = BorderStyle.Fixed3D
        lblSqFill.BorderStyle = BorderStyle.Fixed3D
        lblRecOut.BorderStyle = BorderStyle.Fixed3D
        lblRecFill.BorderStyle = BorderStyle.Fixed3D
        lblCircFill.BorderStyle = BorderStyle.Fixed3D
        lblCircFill.BorderStyle = BorderStyle.Fixed3D
        lblEllOut.BorderStyle = BorderStyle.Fixed3D
        lblEllFill.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub lblTool_Click(sender As Object, e As EventArgs) _
  Handles lblBrush.Click, lblLine.Click, lblText.Click, lblSqOut.Click,
    lblSqFill.Click, lblRecOut.Click, lblRecFill.Click, lblCircOut.Click,
      lblCircFill.Click, lblEllOut.Click, lblEllFill.Click
        resetTools()
        Select Case sender.Tag
            Case "Brush"
                intToolSelected = 1
                lblBrush.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Brush"
            Case "Line"
                intToolSelected = 2
                lblLine.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Line"
            Case "Text"
                intToolSelected = 3
                lblText.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Text"
            Case "Square"
                intToolSelected = 4
                lblSqOut.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Square Outlined"
            Case "SquareFilled"
                intToolSelected = 5
                lblSqFill.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Square Filled"
            Case "Rect"
                intToolSelected = 6
                lblRecOut.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Rectangle Outlined"
            Case "RectFilled"
                intToolSelected = 7
                lblRecFill.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Rectangle Filled"
            Case "Circ"
                intToolSelected = 8
                lblCircOut.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Circle Outlined"
            Case "CircFilled"
                intToolSelected = 9
                lblCircFill.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Circle Filled"
            Case "Ellipse"
                intToolSelected = 10
                lblEllOut.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Ellipse Outlined"
            Case "EllipseFilled"
                intToolSelected = 11
                lblEllFill.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Ellipse Filled"
        End Select
    End Sub

    Dim intPenWidth As Integer = 2
    Dim intFontSize As Integer = 12

    Private Sub cmdFont_Click(sender As Object, e As EventArgs) Handles cmdFont.Click
        dlgFont.ShowDialog()
        strFont = dlgFont.Font.Name
        styFontStyle = dlgFont.Font.Style
        intFontSize = dlgFont.Font.Size
        lblFontDetails.Text = "(" & strFont & " " & intFontSize & "pt, " & strFontStyleArray(styFontStyle) & ")"
    End Sub


    Private Sub mnuFileNew_Click_1(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        pnlMain.Enabled = True
        picCanvas.BackColor = Color.White
        bmpPic = New Bitmap(picCanvas.Width, picCanvas.Height)
        picCanvas.Image = bmpPic
        G = Graphics.FromImage(bmpPic)
        picCanvas.DrawToBitmap(bmpPic, picCanvas.ClientRectangle)
    End Sub

    Private Sub mnuFileSave_Click_1(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        sfdSavePic.Filter = "Bitmap |*.bmp"
        If sfdSavePic.ShowDialog = DialogResult.OK Then
            picCanvas.Image.Save(sfdSavePic.FileName, Drawing.Imaging.ImageFormat.Bmp)
            MsgBox("File saved.")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Application.Exit()
    End Sub
    Dim strFontStyleArray() As String = {"Regular", "Bold", "Italic", "Bold Italic", "Unknown",
  "Unknown", "Unknown", "Unknown", "Regular Strikeout", "Bold Strikeout",
    "Italic Strikeout", "Bold Italic Strikeout", "Regular Underline Strikeout",
      "Bold Underline Strikeout", "Italic Underline Strikeout",
        "Bold Italic Underline Strikeout"}
    Dim bmpPic As Bitmap
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbBrushSize_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbBrushSize.SelectedValueChanged
        intBrushSize = CInt(cmbBrushSize.Text)
    End Sub

    Private Sub cmbPenWidth_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPenWidth.SelectedValueChanged
        intPenWidth = CInt(cmbPenWidth.Text)
    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As MouseEventArgs) Handles picCanvas.MouseDown
        drawFlag = True
        xDown = e.X
        yDown = e.Y
    End Sub

    Private Sub picCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles picCanvas.MouseMove
        If intToolSelected = 1 And drawFlag = True Then
            xDown = e.X
            yDown = e.Y
            G.FillEllipse(New SolidBrush(clrSelected), xDown, yDown, intBrushSize, intBrushSize)
            picCanvas.Refresh()
        End If
    End Sub

    Private Sub picCanvas_MouseUp(sender As Object, e As MouseEventArgs) Handles picCanvas.MouseUp
        Dim brushFill As SolidBrush = New Drawing.SolidBrush(clrSelected)
        Dim penLine As New Pen(clrSelected, intPenWidth)

        drawFlag = False
        xUp = e.X
        yUp = e.Y

        Select Case intToolSelected
            Case 2
                G.DrawLine(penLine, xDown, yDown, xUp, yUp)
            Case 3
                strText = txtInsertText.Text
                G.DrawString(strText, New System.Drawing.Font(strFont, intFontSize, styFontStyle),
                brushFill, xUp, yUp)
            Case 4
                dimSquare()
                G.DrawRectangle(penLine, intL, intT, intW, intW)
            Case 5
                dimSquare()
                G.FillRectangle(brushFill, intL, intT, intW, intW)
            Case 6
                dimRectangle()
                G.DrawRectangle(penLine, intL, intT, intW, intH)
            Case 7
                dimRectangle()
                G.FillRectangle(brushFill, intL, intT, intW, intH)
            Case 8
                dimCircle()
                G.DrawEllipse(penLine, intL, intT, intW, intW)
            Case 9
                dimCircle()
                G.FillEllipse(brushFill, intL, intT, intW, intW)
            Case 10
                dimEllipse()
                G.DrawEllipse(penLine, intL, intT, intW, intH)
            Case 11
                dimEllipse()
                G.FillEllipse(brushFill, intL, intT, intW, intH)
        End Select
        picCanvas.Refresh()
    End Sub
End Class