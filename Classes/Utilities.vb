Public Class Utilities
    Public cb As List(Of PictureBox) = New List(Of PictureBox)() 'Creates of list of PictureBoxes for characters
    Public wb As List(Of PictureBox) = New List(Of PictureBox)() 'Creates of list of PictureBoxes for weapons
    Dim dayInt As Integer = Date.Today.DayOfWeek
    Dim farms As FarmableArrays = New FarmableArrays

#Region "Help Functions"

    Public Sub loadCharacterImages(images As Image())
        Dim i As Integer = 0
        shuffleArray(images)
        For Each pb As PictureBox In cb 'Loops through all pictureboxes and fills them with an image.
            pb.BackgroundImage = images(i)
            pb.BackgroundImageLayout = formBase.BackgroundImageLayout.Stretch
            i += 1
        Next
    End Sub
    Public Sub loadWeaponImages(images As Image())
        Dim i As Integer = 0
        shuffleArray(images)
        For Each pb As PictureBox In wb 'Loops through all pictureboxes and fills them with an image.
            pb.BackgroundImage = images(i)
            pb.BackgroundImageLayout = formBase.BackgroundImageLayout.Stretch
            i += 1
        Next
    End Sub
    Private Sub labelText(text As String)
        formBase.lblFarmableCharacters.Text = text
        formBase.lblFarmableWeapons.Text = text
    End Sub

#End Region

#Region "Methods"

#Region "Shuffle Image Arrays"
    Public Sub shuffleArray(arr As Image())
        Dim n As Integer = arr.Length
        Dim ran As New Random

        For i = 0 To arr.Length - 1
            swap(arr, i, i + ran.Next(n - i))
        Next

    End Sub
    Public Sub swap(array As Image(), a As Integer, b As Integer)
        Dim temp As Image = array(a)
        array(a) = array(b)
        array(b) = temp
    End Sub
#End Region

    Public Sub sundayAttributes()
        For Each x As Control In formBase.pnlFarmCharacters.Controls
            If TypeOf x Is PictureBox Then
                x.Visible = False
            End If
        Next
    End Sub


    Public Sub farmableCharacters()
        'Loops through the container to find all PictureBox controls and adds them to the list
        For Each c As Control In formBase.pnlFarmCharacters.Controls
            If TypeOf c Is PictureBox Then
                cb.Add(c)
            End If
        Next

        'Case statement to display info depending on the day.
        Select Case dayInt
            Case 0
                labelText("Sunday:")
                sundayAttributes()
            Case 1
                labelText("Monday:")
                loadCharacterImages(farms.cMonday)
            Case 2
                labelText("Tuesday:")
                loadCharacterImages(farms.cTuesday)
            Case 3
                labelText("Wednesday:")
                loadCharacterImages(farms.cMonday)
            Case 4
                labelText("Thursday:")
                loadCharacterImages(farms.cMonday)
            Case 5
                labelText("Friday:")
                loadCharacterImages(farms.cMonday)

            Case 6
                labelText("Saturday:")
                loadCharacterImages(farms.cMonday)
        End Select
    End Sub

    Public Sub farmableWeapons()
        'Loops through the container to find all PictureBox controls and adds them to the list
        For Each x As Control In formBase.pnlFarmWeapons.Controls
            If TypeOf x Is PictureBox Then
                wb.Add(x)
            End If
        Next

        'Case statement to display info depending on the day.
        Select Case dayInt
            Case 0
                sundayAttributes()
            Case 1
                loadWeaponImages(farms.wMonday)
            Case 2
                loadWeaponImages(farms.wTuesday)
            Case 3
                loadWeaponImages(farms.wMonday)
            Case 4
                loadWeaponImages(farms.wMonday)
            Case 5
                loadWeaponImages(farms.wMonday)

            Case 6
                loadWeaponImages(farms.wMonday)
        End Select
    End Sub

#End Region

End Class
