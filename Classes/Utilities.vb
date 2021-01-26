Public Class Utilities 'Change main to form name
    Public cb As List(Of PictureBox) = New List(Of PictureBox)() 'Creates of list of PictureBoxes

#Region "Help Functions"

    Public Sub loadImages(images As Image())
        Dim i As Integer = 0
        shuffleArray(images)
        For Each pb As PictureBox In cb 'Loops through all pictureboxes and fills them with an image.
            pb.BackgroundImage = images(i)
            'pb.BackgroundImageLayout = formBase.BackgroundImageLayout.Stretch
            i += 1
        Next

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

        'For Each x As Control In main.gbCharacters.Controls
        'If TypeOf x Is PictureBox Then
        'x.Visible = False
        'End If
        'Next

        'main.lblAll.Visible = True
        'main.gbCharacters.BackgroundImage = My.Resources.shalltear
        'main.gbCharacters.BackgroundImageLayout = ImageLayout.Stretch
        'main.lblAll.BackColor = Color.Transparent
        'main.lblAll.ForeColor = Color.FromArgb(26, 0, 154)
        'main.gbCharacters.ForeColor = Color.White

    End Sub

#End Region

End Class
