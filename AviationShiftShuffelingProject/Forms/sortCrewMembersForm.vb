Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient
Imports System.Collections.ObjectModel


Public Class sortCrewMembersForm



    Private Sub sortCrewMembersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load simple choices A, B, C, D into cbGroupPicker combo box'
        cbGroupPicker.Items.Add("A")
        cbGroupPicker.Items.Add("B")
        cbGroupPicker.Items.Add("C")
        cbGroupPicker.Items.Add("D")
    End Sub


    Private Sub cbGroupPicker_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGroupPicker.SelectedIndexChanged
        'get selected data to a variable'
        Dim var_GroupName As String
        var_GroupName = cbGroupPicker.Text

        ' Clear the existing items in the ListView control
        lvCrewman.Items.Clear()
        lvRic.Items.Clear()

        'load datato listview'
        Dim str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
        Dim con As New SqlConnection(str)

        Try
            con.Open()
            '----------------------> crew
            Dim cmd As New SqlCommand("SELECT * FROM [GroupMembers_MASTER_Table] WHERE [Group] = @GroupName AND [Position] = 'CREWMAN'", con)
            cmd.Parameters.AddWithValue("@GroupName", var_GroupName)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim value As String = reader("Name").ToString() 'get value from the table
                lvCrewman.Items.Add(value)
            End While
            reader.Close()


            '----------------------->RIC
            Dim cmdToLoadRIC As New SqlCommand("SELECT * FROM [GroupMembers_MASTER_Table] WHERE [Group] = @GroupName AND [Position] = 'RIC'", con)
            cmdToLoadRIC.Parameters.AddWithValue("@GroupName", var_GroupName)

            Dim readerRics As SqlDataReader = cmdToLoadRIC.ExecuteReader()
            While readerRics.Read()
                Dim valueRIC As String = readerRics("Name").ToString() 'get values
                lvRic.Items.Add(valueRIC)
            End While
            readerRics.Close()


            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    'change the order of text of crewman
    '--- --- --- --- ---
    Private Sub lvCrewman_MouseDown(sender As Object, e As MouseEventArgs) Handles lvCrewman.MouseDown
        If e.Button = MouseButtons.Left AndAlso lvCrewman.SelectedIndex >= 0 Then
            lvCrewman.DoDragDrop(lvCrewman.SelectedItem, DragDropEffects.Move)
        End If
    End Sub

    Private Sub lvCrewman_DragEnter(sender As Object, e As DragEventArgs) Handles lvCrewman.DragEnter
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem", True) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub lvCrewman_DragOver(sender As Object, e As DragEventArgs) Handles lvCrewman.DragOver
        If e.Data.GetDataPresent(GetType(String)) Then
            Dim dragItemCM As String = CType(e.Data.GetData(GetType(String)), String)
            Dim targetIndexCM As Integer = lvCrewman.IndexFromPoint(lvCrewman.PointToClient(New Point(e.X, e.Y)))
            If targetIndexCM >= 0 AndAlso targetIndexCM <> lvCrewman.Items.IndexOf(dragItemCM) Then
                lvCrewman.Items.Remove(dragItemCM)
                lvCrewman.Items.Insert(targetIndexCM, dragItemCM)
                lvCrewman.SetSelected(targetIndexCM, True)
            End If
        End If
    End Sub

    '--- --- --- --- ---


    'change the order or RIC lisBox
    '--- --- --- --- ---
    Private Sub lvRic_MouseDown(sender As Object, e As MouseEventArgs) Handles lvRic.MouseDown
        If e.Button = MouseButtons.Left AndAlso lvRic.SelectedIndex >= 0 Then
            lvRic.DoDragDrop(lvRic.SelectedItem, DragDropEffects.Move)
        End If
    End Sub

    Private Sub lvRic_DragEnter(sender As Object, e As DragEventArgs) Handles lvRic.DragEnter
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem", True) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub lvRic_DragOver(sender As Object, e As DragEventArgs) Handles lvRic.DragOver
        If e.Data.GetDataPresent(GetType(String)) Then
            Dim dragItem As String = CType(e.Data.GetData(GetType(String)), String)
            Dim targetIndex As Integer = lvRic.IndexFromPoint(lvRic.PointToClient(New Point(e.X, e.Y)))
            If targetIndex >= 0 AndAlso targetIndex <> lvRic.Items.IndexOf(dragItem) Then
                lvRic.Items.Remove(dragItem)
                lvRic.Items.Insert(targetIndex, dragItem)
                lvRic.SetSelected(targetIndex, True)
            End If
        End If
    End Sub
End Class