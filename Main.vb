Imports System.Runtime.InteropServices
Public Class formBase
    Dim farm As Farmables = New Farmables
    Private Sub base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = Region.FromHrgn(CreateRoundRgn(0, 0, Width, Height, 20, 20))
        onButtonSelected(pnlNav, btnFarming)
        farm.farmables()
    End Sub
#Region "Events"
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>'Creates round form border
    Private Shared Function CreateRoundRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

#Region "Button Click Events"
    Private Sub btnFarming_Click(sender As Object, e As EventArgs) Handles btnFarming.Click
        onButtonSelected(pnlNav, btnFarming)
    End Sub

    Private Sub btnBuilds_Click(sender As Object, e As EventArgs) Handles btnBuilds.Click
        onButtonSelected(pnlNav, btnBuilds)
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        onButtonSelected(pnlNav, btnExp)
    End Sub

    Private Sub btnWeaponRecords_Click(sender As Object, e As EventArgs) Handles btnWeaponRecords.Click
        onButtonSelected(pnlNav, btnWeaponRecords)
    End Sub

    Private Sub btnCharacterRecords_Click(sender As Object, e As EventArgs) Handles btnCharacterRecords.Click
        onButtonSelected(pnlNav, btnCharacterRecords)
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        fixBtnFarm()
        onButtonSelected(pnlNav, btnCredits)
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
    Private Sub btnCredits_Leave(sender As Object, e As EventArgs) Handles btnCredits.Leave
        onButtonLeave(btnCredits)
    End Sub
#End Region

#End Region

#Region "Methods"
    'When a button is selecte move Navigation Panel to button and change buttons' color
    Private Sub onButtonSelected(pnl As Panel, btn As Button)
        pnl.Height = btn.Height
        pnl.Top = btn.Top
        pnl.Left = btn.Left
        btn.BackColor = Color.FromArgb(29, 19, 45)
        btn.ForeColor = Color.FromArgb(65, 57, 76)
        btn.Font = New Font(btn.Font, FontStyle.Bold)
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
        Application.Exit()
    End Sub

#End Region

End Class
