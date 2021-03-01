Public Class Buildables
    Public cb As List(Of PictureBox) = New List(Of PictureBox)() 'Creates of list of PictureBoxes for characters
    Dim farm As Farmables

#Region "Arrays"
    Public pyro As Image() = {
      My.Resources.portBig_Amber,
      My.Resources.portBig_Bennet,
      My.Resources.portBig_Diluc,
      My.Resources.portBig_Klee,
      My.Resources.portBig_XiangLing,
      My.Resources.portBig_Xinyan
    }
    Public hydro As Image() = {
        My.Resources.portBig_barbra,
        My.Resources.portBig_Mona,
        My.Resources.portBig_Tartaglia,
        My.Resources.portBig_Xinqui
    }
    Public geo As Image() = {
        My.Resources.portBig_Ningguang,
        My.Resources.portBig_Noelle,
        My.Resources.portBig_mcM,
        My.Resources.portBig_Zhongli,
        My.Resources.portBig_Albedo
    }
    Public electro As Image() = {
        My.Resources.portBig_Beidou,
        My.Resources.portBig_Fischl,
        My.Resources.portBig_Keqing,
        My.Resources.portBig_Lisa,
        My.Resources.portBig_Razor
    }
    Public cryo As Image() = {
        My.Resources.portBig_Chongyun,
        My.Resources.portBig_Diona,
        My.Resources.portBig_Keaya,
        My.Resources.portBig_QiQi,
        My.Resources.portBig_Ganyu
    }
    Public anemo As Image() = {
        My.Resources.portBig_Xaio,
        My.Resources.portBig_Jean,
        My.Resources.portBig_Sucrose,
        My.Resources.portBig_mcF,
        My.Resources.portBig_Venti
    }
#End Region

#Region "Shuffle Image Arrays" 'Swap the array of images into random indexes
    Public Sub shuffleArray(arr As Image())
        Dim n As Integer = arr.Length
        Dim ran As New Random

        For i = 0 To arr.Length - 1
            swap(arr, i, i + ran.Next(n - i))
        Next
    End Sub
    Private Sub swap(array As Image(), a As Integer, b As Integer)
        Dim temp As Image = array(a)
        array(a) = array(b)
        array(b) = temp
    End Sub
#End Region

    Public Sub loadFilteredImages(cI As Image())

        'Loops through the container to find all PictureBox controls and adds them to the list
        For Each c As Control In formMain.flowCharacters.Controls
            If TypeOf c Is PictureBox Then
                cb.Add(c)
            End If
        Next

        Dim i As Integer = 0
        shuffleArray(cI)
        If cb.Count > cI.Length Then
            cb.Remove(formMain.pbBuildChar1)
            cb.Remove(formMain.pbBuildChar6)
        End If
        For Each _cb As PictureBox In cb 'Loops through all pictureboxes and fills them with an image.
            _cb.BackgroundImage = cI(i)
            _cb.BackgroundImageLayout = formMain.BackgroundImageLayout.Zoom
            _cb.Visible = True
            i += 1
        Next
    End Sub

    Public Sub ClearPictureBoxes(parent As Control)
        cb.Clear()
        For Each child As Control In parent.Controls
            If TypeOf child Is PictureBox Then
                child.BackgroundImage = Nothing
            Else
                ClearPictureBoxes(child)
            End If
        Next
    End Sub
End Class
