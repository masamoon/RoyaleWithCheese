﻿Imports System.Data.SqlClient
Imports System.IO

Public Class Login
    Private Function LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If String.IsNullOrEmpty(UsernameBox.Text) Then
            MsgBox("Please enter a username") : Return False
        End If

        Dim CN As New SqlConnection(Globals.connectionPath)
        Dim CMD As New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT dbo.Username_Exists(@username)"
        CMD.CommandType = CommandType.Text
        CMD.Parameters.Add(New SqlParameter("@username", UsernameBox.Text))

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                Dim res As Integer
                res = CMD.ExecuteScalar
                If res = 0 Then
                    MsgBox("Invalid username!")
                Else
                    Globals.user.username = UsernameBox.Text
                    Dim m As New MainForm
                    m.Show()
                    Me.Hide()
                End If
            End If

        Catch ex As Exception
            MsgBox("ExecQuery Error: " & vbNewLine & ex.Message)
        End Try

        If CN.State = ConnectionState.Open Then
            CN.Close()
        End If

        Return True
    End Function

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.working_directory = Directory.GetCurrentDirectory()
    End Sub
End Class