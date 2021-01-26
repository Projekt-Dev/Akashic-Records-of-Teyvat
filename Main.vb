Imports System.Runtime.InteropServices
Public Class formBase
    Private Sub base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = Region.FromHrgn(CreateRoundRgn(0, 0, Width, Height, 20, 20))
        onButtonSelected(pnlNav, btnFarming)
    End Sub

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
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




#Region "Methods"
    Private Sub onButtonSelected(pnl As Panel, btn As Button)
        pnl.Height = btn.Height
        pnl.Top = btn.Top
        pnl.Left = btn.Left
        btn.BackColor = Color.FromArgb(128, 0, 2)
    End Sub

    Private Sub onButtonLeave(btn As Button)
        If btnFarming.BackColor = Color.FromArgb(15, 15, 15) Then
        Else
            btnFarming.BackColor = Color.FromArgb(15, 15, 15)
        End If

        btn.BackColor = Color.FromArgb(15, 15, 15)
    End Sub

#End Region


End Class
