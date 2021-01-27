Imports System.Runtime.InteropServices
Public Class formBase
#Region "Variables"
    Dim farm As Farmables = New Farmables
    Dim mouseDown_ As Boolean = False
    Private Offset As Point
#End Region
    Private Sub base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = Region.FromHrgn(CreateRoundRgn(0, 0, Width, Height, 20, 20))
        onButtonSelected(pnlNav, btnFarming, "FARMING")
        farm.farmables()
        startingVisibility()
    End Sub
#Region "Events"
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>'Creates round form border
    Private Shared Function CreateRoundRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

#Region "Button Click Events"
    Private Sub btnFarming_Click(sender As Object, e As EventArgs) Handles btnFarming.Click
        onButtonSelected(pnlNav, btnFarming, "FARMING")
        Visibility(conFarming)

    End Sub

    Private Sub btnBuilds_Click(sender As Object, e As EventArgs) Handles btnBuilds.Click
        onButtonSelected(pnlNav, btnBuilds, " BUILDS")
        Visibility(conBuilds)

    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        onButtonSelected(pnlNav, btnExp, "EXP CALCULATOR")
    End Sub

    Private Sub btnWeaponRecords_Click(sender As Object, e As EventArgs) Handles btnWeaponRecords.Click
        onButtonSelected(pnlNav, btnWeaponRecords, "WEAPON RECORDS")
    End Sub

    Private Sub btnCharacterRecords_Click(sender As Object, e As EventArgs) Handles btnCharacterRecords.Click
        onButtonSelected(pnlNav, btnCharacterRecords, "CHARACTER RECORDS")
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        fixBtnFarm()
        onButtonSelected(pnlNav, btnAbout, "ABOUT")
    End Sub
#End Region

#Region "Button Leave Events"
    Private Sub btnFarming_Leave(sender As Object, e As EventArgs) Handles btnFarming.Leave
        onButtonLeave(btnFarming)
    End Sub
    Private Sub btnBuilds_Leave(sender As Object, e As EventArgs) Handles btnBuilds.Leave
        onButtonLeave(btnBuilds)
    End Sub
    Private Sub btnExp_Leave(sender As Object, e As EventArgs) Handles btnExp.Leave
        onButtonLeave(btnExp)
    End Sub
    Private Sub btnWeaponRecords_Leave(sender As Object, e As EventArgs) Handles btnWeaponRecords.Leave
        onButtonLeave(btnWeaponRecords)
    End Sub
    Private Sub btnCharacterRecords_Leave(sender As Object, e As EventArgs) Handles btnCharacterRecords.Leave
        onButtonLeave(btnCharacterRecords)
    End Sub
    Private Sub btnCredits_Leave(sender As Object, e As EventArgs) Handles btnAbout.Leave
        onButtonLeave(btnAbout)
    End Sub
#End Region

#Region "Draggable Form"
    Private Sub mouseDown_Event(sender As Object, e As MouseEventArgs) Handles pnlDrag.MouseDown
        Offset.X = e.X
        Offset.Y = e.Y
        mouseDown_ = True
    End Sub

    Private Sub mouseMove_Event(sender As Object, e As MouseEventArgs) Handles pnlDrag.MouseMove
        If (mouseDown_ = True) Then
            Dim currentPointPos As Point = PointToScreen(e.Location)
            Location = New Point(currentPointPos.X - Offset.X, currentPointPos.Y - Offset.Y)
        End If
    End Sub

    Private Sub mouseUp_Event(sender As Object, e As MouseEventArgs) Handles pnlDrag.MouseUp
        mouseDown_ = False
    End Sub
#End Region

#End Region

#Region "Methods"
    'When a button is selected move Navigation Panel to button and change buttons color
    Private Sub onButtonSelected(pnl As Panel, btn As Button, text As String)
        pnl.Height = btn.Height
        pnl.Top = btn.Top
        pnl.Left = btn.Left
        btn.BackColor = Color.FromArgb(29, 19, 45)
        btn.ForeColor = Color.FromArgb(65, 57, 76)
        btn.Font = New Font(btn.Font, FontStyle.Bold)
        lblName.Text = text

    End Sub

    'When selecting another button revert color changes
    Private Sub onButtonLeave(btn As Button)
        fixBtnFarm()
        btn.BackColor = Color.FromArgb(11, 7, 17)
        btn.ForeColor = Color.FromArgb(220, 20, 60)
        btn.Font = New Font(btn.Font, FontStyle.Regular)
    End Sub

    'Fix issues the Farm Button has been having until knowing the issue
    Private Sub fixBtnFarm()
        If btnFarming.BackColor = Color.FromArgb(8, 105, 114) Then
        Else
            btnFarming.BackColor = Color.FromArgb(11, 7, 17)
            btnFarming.ForeColor = Color.FromArgb(220, 20, 60)
            btnFarming.Font = New Font(btnFarming.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Visibility(p As Panel)
        If p Is conFarming Then
            conBuilds.Visible = False
            p.Visible = True
        ElseIf p Is conBuilds Then
            conFarming.Visible = False
            p.Visible = True
        End If
    End Sub
    Private Sub startingVisibility()
        conFarming.Visible = True
        conBuilds.Visible = False
    End Sub
#End Region

End Class
