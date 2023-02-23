Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient
Imports System.Collections.ObjectModel
Imports System.Windows.Forms


Public Class sortCrewMembersForm

    'connection string
    Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"


    Private Sub sortCrewMembersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load simple choices A, B, C, D into cbGroupPicker combo box'
        cbGroupPicker.Items.Add("A")
        cbGroupPicker.Items.Add("B")
        cbGroupPicker.Items.Add("C")
        cbGroupPicker.Items.Add("D")


    End Sub

    'adding crew members to listBox
    Private Sub cbGroupPicker_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGroupPicker.SelectedIndexChanged

        LoadCrewMembersAccordingToGroupName.LoadDataToListBoxes(sender, e, Me)

    End Sub

    'change the order of text of crewman
    Private Sub lvCrewman_MouseDown(sender As Object, e As MouseEventArgs) Handles lvCrewman.MouseDown

        CrewMembersOrderChangingCommand.dragWantedItem(sender, e, Me)

    End Sub

    Private Sub lvCrewman_DragEnter(sender As Object, e As DragEventArgs) Handles lvCrewman.DragEnter

        CrewMembersOrderChangingCommand.dragOverOtherItems(sender, e)

    End Sub

    Private Sub lvCrewman_DragOver(sender As Object, e As DragEventArgs) Handles lvCrewman.DragOver

        CrewMembersOrderChangingCommand.dropWantedItem(sender, e, Me)

    End Sub


    'change the order of RIC lisBox
    Private Sub lvRic_MouseDown(sender As Object, e As MouseEventArgs) Handles lvRic.MouseDown

        CrewMembersOrderChangingCommand.dragWantedItem(sender, e, Me)

    End Sub

    Private Sub lvRic_DragEnter(sender As Object, e As DragEventArgs) Handles lvRic.DragEnter

        CrewMembersOrderChangingCommand.dragOverOtherItems(sender, e)

    End Sub

    Private Sub lvRic_DragOver(sender As Object, e As DragEventArgs) Handles lvRic.DragOver

        CrewMembersOrderChangingCommand.dropWantedItem(sender, e, Me)

    End Sub

    'detlete selected item from boxes
    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click
        If lvCrewman.SelectedIndex <> -1 Then
            lvCrewman.Items.RemoveAt(lvCrewman.SelectedIndex)
        End If
    End Sub


    'make crew member listbox editable


End Class