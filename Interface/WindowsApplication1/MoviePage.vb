Imports System.Data.SqlClient

Public Class MoviePage


    Dim CN As SqlConnection
    Dim CMD As SqlCommand


    Public Sub MoviePage_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CN = New SqlConnection(Globals.connectionPath)
        CMD = New SqlCommand
        CMD.Connection = CN
        getContent(sender, e)
        synbioTextBox.SelectionLength = 0
        genresLabel.Text = ""
        For Each genre As String In Globals.shared_movie.genres
            genresLabel.Text += genre & " | "
        Next genre
    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        synbioTextBox.SelectionLength = 0
    End Sub

    Public Sub MoviePage_FormClosed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.FormClosed
        Me.Hide()
        Select Case Globals.lastForm
            Case "MainForm"
                MainForm.Show()
        End Select


    End Sub

    Private Sub getContent(ByVal sender As Object, ByVal e As EventArgs)
        CN.Open()
        CMD.CommandText = "SELECT * FROM Movie WHERE movie_id = @movie_id"

        CMD.Parameters.Add("@movie_id", SqlDbType.Int).Value = Globals.shared_movie.movie_id
        Dim RDR1 As SqlDataReader
        Dim poster_path As String
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            nameLabel.Text = RDR1.Item("title")
            synbioTextBox.Text = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
            CountryTextBox.Text = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
            poster_path = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
            RuntimeTextBox.Text = RDR1.Item("runtime")
            yearLabel.Text = RDR1.Item("year")
        End While
        If Not String.IsNullOrEmpty(poster_path) Then
            PosterBox.ImageLocation = poster_path
            PosterBox.SizeMode = PictureBoxSizeMode.StretchImage
            PosterBox.Load()
        Else
            PosterBox.ImageLocation = "C:\Users\alagao\Desktop\posters\Question-mark.png"
        PosterBox.Load()
        End If
    End Sub


End Class