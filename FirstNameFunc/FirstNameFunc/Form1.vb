﻿Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String
        Dim firstSpace As Integer
        firstSpace = name.IndexOf(" ")
        Dim fstName As String = name.Substring(0, firstSpace)

        Return fstName

    End Function

End Class
