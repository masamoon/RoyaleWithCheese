Imports System.Data.SqlClient
Public Class FilmmakerUnregisterd
    Dim CN As SqlConnection
    Dim CMD As SqlCommand

    Private Sub FilmmakerUnregisterd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection(Globals.connectionPath)
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM dbo.GetFilmmakerInfo(@uid)"

        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.shared_fm.id

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        While RDR.Read
            Dim u As New Filmmaker
            u.fname = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("fname")), "", RDR.Item("fname")))
            u.lname = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("lname")), "", RDR.Item("lname")))
            Fullname_box.Text = u.fname + " " + u.lname
            u.biography = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("biography")), "", RDR.Item("biography")))
            Bio.Text = u.biography
            u.birthdate = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("birthdate")), "", RDR.Item("birthdate")))
            Birthdate.Text = u.birthdate

        End While
        RDR.Close()
        CN.Close()

        CN = New SqlConnection(Globals.connectionPath)
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM dbo.GetAllParticipations(@fid)"
        CMD.Parameters.Add("@fid", SqlDbType.Int).Value = Globals.shared_fm.id

        Dim RDR1 As SqlDataReader
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            Dim m As New Movie
            m.avg_rating = 0
            m.movie_id = RDR1.Item("movie_id")
            m.title = RDR1.Item("title")
            m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
            m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
            m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
            m.runtime = RDR1.Item("runtime")
            m.year = RDR1.Item("year")
            If (Not IsDBNull(RDR1.Item("avg_rating"))) Then
                m.avg_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("avg_rating")), "", RDR1.Item("avg_rating")))
            End If
            ListBox4.Items.Add(m)
        End While

        RDR1.Close()
        CN.Close()
        ClearConnection()
        CN.Open()
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM dbo.GetRolesG(@fid)"
        CMD.Parameters.Add("@fid", SqlDbType.Int).Value = Globals.shared_fm.id

        Dim RDR5 As SqlDataReader
        RDR5 = CMD.ExecuteReader
        While RDR5.Read
            ListBox5.Items.Add(RDR5.Item("role_name"))
        End While
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        Globals.shared_movie = ListBox4.SelectedItem


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Globals.shared_movie = ListBox4.SelectedItem
        Me.Hide()
        MoviePage.Show()
    End Sub

    Public Sub FilmmakerUnregisterd_FormClosed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.FormClosed
        Me.Hide()
        Dim m As New MainForm
        m.Show()
    End Sub


    Private Sub ClearConnection()
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
        CN.ConnectionString = Globals.connectionPath
        CMD.Connection = CN
        CMD.Parameters.Clear()
    End Sub

End Class