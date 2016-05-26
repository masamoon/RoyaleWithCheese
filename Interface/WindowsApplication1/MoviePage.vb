Imports System.Data.SqlClient

Public Class MoviePage


    Dim CN As SqlConnection
    Dim CMD As SqlCommand


    Private Sub getContent(ByVal sender As Object, ByVal e As EventArgs)
        CN.Open()
        CMD.CommandText = "SELECT * FROM Movie WHERE movie_id = @movie_id"


        CMD.Parameters.Add("@movie_id", SqlDbType.Int).Value = Globals.shared_movie.movie_id
        Dim RDR1 As SqlDataReader
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            Dim poster_path As String
            nameLabel.Text = RDR1.Item("title")
            synbioTextBox.Text = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
            CountryTextBox.Text = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
            poster_path = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
            Runtime = RDR1.Item("runtime")


        End While

    End Sub


End Class