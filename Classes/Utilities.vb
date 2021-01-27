Public Class Utilities
    Public cb As List(Of PictureBox) = New List(Of PictureBox)() 'Creates of list of PictureBoxes for characters
    Public wb As List(Of PictureBox) = New List(Of PictureBox)() 'Creates of list of PictureBoxes for weapons
    Dim dayInt As Integer = Date.Today.DayOfWeek ' From a range of 0-6 determines what today is
    Dim farms As FarmableArrays = New FarmableArrays 'Reference to FarmableArrays

#Region "Help Functions" 'To prevent a lot of repetitive code these functions were created to minimize that
    Public Sub loadFarmableImages(cImg As Image(), wImg As Image())
        Dim i As Integer = 0
        shuffleArray(cImg)
        For Each pb As PictureBox In cb 'Loops through all pictureboxes and fills them with an image.
            pb.BackgroundImage = cImg(i)
            pb.BackgroundImageLayout = formBase.BackgroundImageLayout.Stretch
            i += 1
        Next

        If wb.Count > wImg.Length Then 'If the length of the weapons list is larger than the length of the weapons array it will remove excess PictureBoxes and resize Panel Container
            wb.Remove(formBase.pbWeapon18)
            wb.Remove(formBase.pbWeapon19)
            wb.Remove(formBase.pbWeapon20)
            wb.Remove(formBase.pbWeapon21)
            wb.Remove(formBase.pbWeapon22)
            formBase.pnlFarmWeapons.Height = 270
        End If
        Dim x As Integer = 0
        shuffleArray(wImg) 'Shuffles array so everytime it is loaded the images are in random order.
        For Each pb As PictureBox In wb 'Loops through all pictureboxes and fills them with an image.
            pb.BackgroundImage = wImg(x)
            pb.BackgroundImageLayout = formBase.BackgroundImageLayout.Stretch
            x += 1
        Next

    End Sub

    Private Sub labelText(text As String) 'Simple function to amplify laziness
        formBase.lblDate.Text = text
    End Sub
#End Region

#Region "Methods"

#Region "Shuffle Image Arrays" 'Swap the array of images into random indexes
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

    Public Sub sundayAttributes() 'Disabling all PictureBoxes for sundays since this day everything it farmable
        For Each x As Control In formBase.pnlFarmCharacters.Controls
            If TypeOf x Is PictureBox Then
                x.Visible = False
            End If
        Next
        For Each y As Control In formBase.pnlFarmWeapons.Controls
            If TypeOf y Is PictureBox Then
                y.Visible = False
            End If
        Next
    End Sub


    Public Sub farmables()
        'Loops through the container to find all PictureBox controls and adds them to the list
        For Each c As Control In formBase.pnlFarmCharacters.Controls
            If TypeOf c Is PictureBox Then
                cb.Add(c)
            End If
        Next
        'Loops through the container to find all PictureBox controls and adds them to the list
        For Each x As Control In formBase.pnlFarmWeapons.Controls
            If TypeOf x Is PictureBox Then
                wb.Add(x)
            End If
        Next

        'Case statement to display info depending on the day.
        Select Case dayInt
            Case 0
                labelText("Sunday: Everything it farmable today! Happy grinding!")
                sundayAttributes()
            Case 1
                labelText("Monday:")
                loadFarmableImages(farms.c1, farms.w1)
            Case 2
                labelText("Tuesday:")
                loadFarmableImages(farms.c2, farms.w2)
            Case 3
                labelText("Wednesday:")
                loadFarmableImages(farms.c3, farms.w3)
            Case 4
                labelText("Thursday:")
                loadFarmableImages(farms.c1, farms.w1)
            Case 5
                labelText("Friday:")
                loadFarmableImages(farms.c2, farms.w2)
            Case 6
                labelText("Saturday:")
                loadFarmableImages(farms.c3, farms.w3)
        End Select

    End Sub

#End Region

End Class
