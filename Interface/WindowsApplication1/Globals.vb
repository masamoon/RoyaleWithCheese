Imports System.Data.SqlClient

Public Class Globals



    Public Shared user As Usr = New Usr
    Public Shared connectionPath As String = "data source=ALOPES-PC\SQLEXPRESS;integrated security=true;initial catalog=mov"
    Public Shared shared_movie As Movie = New Movie
    Public Shared lastForm As String
    Public Shared stack As New Stack
    Public Shared shared_usr As Usr
    Public Shared shared_fm As Filmmaker
    Public Shared working_directory As String

    Public Sub ClearConnection(CN As SqlConnection, CMD As SqlCommand)
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
        CN.ConnectionString = Globals.connectionPath
        CMD.Connection = CN
        CMD.Parameters.Clear()
    End Sub
End Class
