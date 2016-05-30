Imports System.Data.SqlClient

Public Class FilmmakerUser
    Dim CN As SqlConnection
    Dim CMD As SqlCommand

    Private Sub FilmmakerUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source=DESKTOP-QMMOJTU\SQLEXPRESS;integrated security=true;initial catalog=mov")
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM Filmmaker JOIN Usr on Usr.username = Filmmaker.username WHERE Usr.id=@uid"

        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = 1

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        While RDR.Read
            Dim u As New Filmmaker
            u.id = RDR.Item("id")

            u.username = RDR.Item("username")
            Username_box.Text = u.username
            u.fname = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("fname")), "", RDR.Item("fname")))
            u.lname = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("lname")), "", RDR.Item("lname")))
            Fullname_box.Text = u.fname + " " + u.lname
            u.location = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("location")), "", RDR.Item("location")))
            Location_box.Text = u.location
            u.biography = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("biography")), "", RDR.Item("biography")))
            Bio.Text = u.biography
            u.birthdate = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("birthdate")), "", RDR.Item("birthdate")))
            Birthdate.Text = u.birthdate
            u.email = RDR.Item("email")


        End While
        RDR.Close()
        CN.Close()

        CN = New SqlConnection("data source=DESKTOP-QMMOJTU\SQLEXPRESS;integrated security=true;initial catalog=mov")
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN

        ListBox1.Items.Clear()
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.HorizontalScrollbar = True
        ListBox2.Items.Clear()
        ListBox3.ScrollAlwaysVisible = True
        ListBox3.HorizontalScrollbar = True

        CMD.CommandText = "SELECT * FROM Review JOIN Movie ON Review.movie_id=Movie.movie_id WHERE user_id=@uid"

        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = 1

        Dim RDR2 As SqlDataReader
        RDR2 = CMD.ExecuteReader
        While RDR2.Read
            Dim r As New Review
            r.id = RDR2.Item("id")

            r.movie_id = RDR2.Item("movie_id")
            r.user_id = RDR2.Item("user_id")
            r.rating = RDR2.Item("rating")
            ListBox1.Items.Add(RDR2.Item("title") + " | rating: " + Convert.ToString(r.rating))




        End While
        RDR2.Close()
        CN.Close()

        CN = New SqlConnection("data source=DESKTOP-QMMOJTU\SQLEXPRESS;integrated security=true;initial catalog=mov")
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN


        CMD.CommandText = "SELECT * FROM List WHERE user_id=@uid"

        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = 1

        Dim RDR3 As SqlDataReader
        RDR3 = CMD.ExecuteReader
        While RDR3.Read
            ListBox2.Items.Add(RDR3.Item("name"))
        End While

        RDR3.Close()
        CN.Close()

        CN = New SqlConnection("data source=DESKTOP-QMMOJTU\SQLEXPRESS;integrated security=true;initial catalog=mov")
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM Movie JOIN Participates ON Movie.movie_id = Participates.movie_id WHERE Participates.filmmaker_id=@fid"
        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = 1

        Dim RDR4 As SqlDataReader
        RDR4 = CMD.ExecuteReader
        While RDR4.Read
            ListBox4.Items.Add(RDR4.Item("title"))
        End While

        RDR4.Close()
        CN.Close()


        CN = New SqlConnection("data source=DESKTOP-QMMOJTU\SQLEXPRESS;integrated security=true;initial catalog=mov")
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM Filmmaker JOIN Usr on Usr.username = Filmmaker.username JOIN FilmmakerRole on FilmmakerRole.filmmaker_id = Filmmaker.filmmaker_id JOIN Roles on Roles.role_id=FilmmakerRole.role_id WHERE Usr.id=@uid"

        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = 1

        Dim RDR5 As SqlDataReader
        RDR5 = CMD.ExecuteReader
        While RDR5.Read
            ListBox5.Items.Add(RDR5.Item("role_name"))
        End While








    End Sub
End Class