Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click

        Dim myUnique As New Unique() 'call to the class as object'
        MsgBox(myUnique.MyString) 'call to the parameter'



    End Sub
End Class
