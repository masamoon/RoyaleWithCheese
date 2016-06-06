Imports System.Data.SqlClient

Public Class Search
    Public search_query As String
    Public search_type As String
    Dim CN As New SqlConnection(Globals.connectionPath)
    Dim CMD As New SqlCommand
    Dim u As New Usr
    Dim f As New Filmmaker

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN.Open()

        CMD.Connection = CN
        If (search_type.Equals("Movies")) Then
            CMD.CommandText = "Select * FROM dbo.Search(@title,@user_id)"
            ComboBoxAdv.Items.Add("Year")
            ComboBoxAdv.Items.Add("Title")
        End If

        If (search_type.Equals("Users")) Then
            CMD.CommandText = "Select * FROM dbo.SearchU(@title)"
            ComboBoxAdv.Items.Add("First Name")
            ComboBoxAdv.Items.Add("Last Name")
            ComboBoxAdv.Items.Add("Location")
        End If

        If (search_type.Equals("Filmmakers")) Then
            CMD.CommandText = "Select * FROM dbo.SearchFM(@title)"
            ComboBoxAdv.Items.Add("First Name")
            ComboBoxAdv.Items.Add("Last Name")
            ComboBoxAdv.Items.Add("Location")
            ComboBoxAdv.Items.Add("Birthdate")
        End If


        CMD.CommandType = CommandType.Text
        CMD.Parameters.Add(New SqlParameter("@title", "%" + search_query + "%"))
        CMD.Parameters.Add(New SqlParameter("@user_id", Globals.user.id))



        Dim RDR1 As SqlDataReader
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            If (search_type.Equals("Movies")) Then

                Dim m As New Movie
                m.user_rating = 0
                m.tmp_rating = 0
                m.movie_id = RDR1.Item("movie_id")
                m.title = RDR1.Item("title")
                m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
                m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
                m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
                m.runtime = RDR1.Item("runtime")
                m.year = RDR1.Item("year")
                m.tmp_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
                m.user_review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
                m.avg_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("avg_rating")), "", RDR1.Item("avg_rating")))
                ListBox1.Items.Add(m)

            End If

            If (search_type.Equals("Users")) Then

                Dim u As New Usr
                u.id = RDR1.Item("id")
                u.username = RDR1.Item("username")
                u.fname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("fname")), "", RDR1.Item("fname")))
                u.lname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("lname")), "", RDR1.Item("lname")))
                u.location = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("location")), "", RDR1.Item("location")))
                u.email = RDR1.Item("email")
                ListBox1.Items.Add(u)
            End If

            If (search_type.Equals("Filmmakers")) Then

                Dim f As New Filmmaker
                f.id = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("filmmaker_id")), "", RDR1.Item("filmmaker_id")))
                If (Not IsDBNull(RDR1.Item("id"))) Then
                    f.user_id = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("id")), "", RDR1.Item("id")))
                End If
                f.username = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("username")), "", RDR1.Item("username")))
                f.fname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("fname")), "", RDR1.Item("fname")))
                f.lname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("lname")), "", RDR1.Item("lname")))
                f.location = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("location")), "", RDR1.Item("location")))
                f.biography = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("biography")), "", RDR1.Item("biography")))
                f.birthdate = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("birthdate")), "", RDR1.Item("birthdate")))
                f.email = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("email")), "", RDR1.Item("email")))
                ListBox1.Items.Add(f)
            End If


        End While

        If CN.State = ConnectionState.Open Then
            CN.Close()
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAdv.SelectedIndexChanged
        ListBox1.Items.Clear()
        If ComboBoxAdv.SelectedIndex = 0 Then
            Dim CN As New SqlConnection(Globals.connectionPath)
            Dim CMD As New SqlCommand
            CMD.Connection = CN
            If (search_type.Equals("Movies")) Then
                CMD.CommandText = "Select * FROM dbo.Search(@title,@user_id)
		                        ORDER BY year"
            End If
            If (search_type.Equals("Users")) Then
                CMD.CommandText = "Select * FROM dbo.SearchU(@title)
		                        ORDER BY fname"
            End If
            If (search_type.Equals("Filmmaker")) Then
                CMD.CommandText = "Select * FROM dbo.SearchFM(@title)
		                        ORDER BY fname"
            End If
            CMD.CommandType = CommandType.Text
            CMD.Parameters.Add(New SqlParameter("@title", "%" + search_query + "%"))
            CMD.Parameters.Add(New SqlParameter("@user_id", Globals.user.id))
            Dim genres As New List(Of String)
            CN.Open()
            Dim RDR1 As SqlDataReader
            RDR1 = CMD.ExecuteReader
            While RDR1.Read
                If (search_type.Equals("Movies")) Then
                    Dim m As Movie = New Movie
                    m.user_rating = 0
                    m.tmp_rating = 0
                    m.movie_id = RDR1.Item("movie_id")
                    m.title = RDR1.Item("title")
                    m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
                    m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
                    m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
                    m.runtime = RDR1.Item("runtime")
                    m.year = RDR1.Item("year")
                    m.tmp_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
                    m.user_review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
                    m.avg_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("avg_rating")), "", RDR1.Item("avg_rating")))
                    ListBox1.Items.Add(m)
                End If
            End While

            If CN.State = ConnectionState.Open Then
                CN.Close()
            End If

        End If
            If ComboBoxAdv.SelectedIndex = 1 Then
            Dim CN As New SqlConnection(Globals.connectionPath)
            Dim CMD As New SqlCommand
            CMD.Connection = CN
            If (search_type.Equals("Movies")) Then
                CMD.CommandText = "Select * FROM dbo.Search(@title,@user_id)
		                        ORDER BY title"
            End If
            If (search_type.Equals("Users")) Then
                CMD.CommandText = "Select * FROM dbo.SearchU(@title)
		                        ORDER BY lname"
            End If
            If (search_type.Equals("Filmmaker")) Then
                CMD.CommandText = "Select * FROM dbo.SearchFM(@title)
		                        ORDER BY lname"
            End If
            CMD.CommandType = CommandType.Text
            CMD.Parameters.Add(New SqlParameter("@title", "%" + search_query + "%"))
            CMD.Parameters.Add(New SqlParameter("@user_id", Globals.user.id))
            Dim genres As New List(Of String)
            CN.Open()
            Dim RDR1 As SqlDataReader
            RDR1 = CMD.ExecuteReader

            While RDR1.Read
                If (search_type.Equals("Movies")) Then
                    Dim m As Movie = New Movie
                    m.user_rating = 0
                    m.tmp_rating = 0
                    m.movie_id = RDR1.Item("movie_id")
                    m.title = RDR1.Item("title")
                    m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
                    m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
                    m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
                    m.runtime = RDR1.Item("runtime")
                    m.year = RDR1.Item("year")
                    m.user_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
                    m.user_review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
                    m.avg_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("avg_rating")), "", RDR1.Item("avg_rating")))
                    ListBox1.Items.Add(m)
                End If
                If (search_type.Equals("Users")) Then
                    Dim u As New Usr
                    u.id = RDR1.Item("id")
                    u.username = RDR1.Item("username")
                    u.fname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("fname")), "", RDR1.Item("fname")))
                    u.lname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("lname")), "", RDR1.Item("lname")))
                    u.location = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("location")), "", RDR1.Item("location")))
                    u.email = RDR1.Item("email")
                    ListBox1.Items.Add(u)
                End If
                If (search_type.Equals("Filmmakers")) Then
                    Dim f As New Filmmaker
                    f.id = RDR1.Item("user_id")
                    f.biography = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("biography")), "", RDR1.Item("biography")))
                    f.birthdate = Convert.ToDateTime(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("birthdate")), "", RDR1.Item("birthdate")))
                    ListBox1.Items.Add(f)
                End If
            End While

            If CN.State = ConnectionState.Open Then
                CN.Close()
            End If
        End If
        If ComboBoxAdv.SelectedIndex = 2 Then
            Dim CN As New SqlConnection(Globals.connectionPath)
            Dim CMD As New SqlCommand
            CMD.Connection = CN
            If (search_type.Equals("Users")) Then
                CMD.CommandText = "Select * FROM dbo.SearchU(@title)
		                        ORDER BY location"
            End If
            If (search_type.Equals("Filmmaker")) Then
                CMD.CommandText = "Select * FROM dbo.SearchFM(@title)
		                        ORDER BY location"
            End If
            CMD.CommandType = CommandType.Text
            CMD.Parameters.Add(New SqlParameter("@title", "%" + search_query + "%"))
            Dim genres As New List(Of String)
            CN.Open()
            Dim RDR1 As SqlDataReader
            RDR1 = CMD.ExecuteReader

            While RDR1.Read
                If (search_type.Equals("Movies")) Then
                    Dim m As Movie = New Movie
                    m.tmp_rating = 0
                    m.user_rating = 0
                    m.movie_id = RDR1.Item("movie_id")
                    m.title = RDR1.Item("title")
                    m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
                    m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
                    m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
                    m.runtime = RDR1.Item("runtime")
                    m.year = RDR1.Item("year")
                    m.user_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
                    m.user_review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
                    m.avg_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("avg_rating")), "", RDR1.Item("avg_rating")))
                    ListBox1.Items.Add(m)
                End If
                If (search_type.Equals("Users")) Then
                    Dim u As New Usr
                    u.id = RDR1.Item("id")
                    u.username = RDR1.Item("username")
                    u.fname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("fname")), "", RDR1.Item("fname")))
                    u.lname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("lname")), "", RDR1.Item("lname")))
                    u.location = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("location")), "", RDR1.Item("location")))
                    u.email = RDR1.Item("email")
                    ListBox1.Items.Add(u)
                End If
                If (search_type.Equals("Filmmakers")) Then
                    Dim f As New Filmmaker
                    f.id = RDR1.Item("user_id")
                    f.biography = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("biography")), "", RDR1.Item("biography")))
                    f.birthdate = Convert.ToDateTime(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("birthdate")), "", RDR1.Item("birthdate")))
                    ListBox1.Items.Add(f)
                End If
            End While

            If CN.State = ConnectionState.Open Then
                CN.Close()
            End If

        End If
        If ComboBoxAdv.SelectedIndex = 3 Then
            Dim CN As New SqlConnection(Globals.connectionPath)
            Dim CMD As New SqlCommand
            CMD.Connection = CN

            If (search_type.Equals("Filmmaker")) Then
                CMD.CommandText = "Select * FROM dbo.SearchFM(@title)
		                        ORDER BY birthdate"
            End If
            CMD.CommandType = CommandType.Text
            CMD.Parameters.Add(New SqlParameter("@title", "%" + search_query + "%"))
            Dim genres As New List(Of String)
            CN.Open()
            Dim RDR1 As SqlDataReader
            RDR1 = CMD.ExecuteReader


            While RDR1.Read
                If (search_type.Equals("Movies")) Then
                    Dim m As New Movie
                    m.user_rating = 0
                    m.tmp_rating = 0
                    m.movie_id = RDR1.Item("movie_id")
                    m.title = RDR1.Item("title")
                    m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
                    m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
                    m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
                    m.runtime = RDR1.Item("runtime")
                    m.year = RDR1.Item("year")
                    m.user_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
                    m.user_review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
                    m.avg_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("avg_rating")), "", RDR1.Item("avg_rating")))
                    ListBox1.Items.Add(m)

                End If
                If (search_type.Equals("Users")) Then
                    Dim u As New Usr
                    u.id = RDR1.Item("id")
                    u.username = RDR1.Item("username")
                    u.fname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("fname")), "", RDR1.Item("fname")))
                    u.lname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("lname")), "", RDR1.Item("lname")))
                    u.location = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("location")), "", RDR1.Item("location")))
                    u.email = RDR1.Item("email")
                    ListBox1.Items.Add(u)
                End If
                If (search_type.Equals("Filmmakers")) Then
                    Dim f As New Filmmaker
                    f.id = RDR1.Item("user_id")
                    f.biography = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("biography")), "", RDR1.Item("biography")))
                    f.birthdate = Convert.ToDateTime(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("birthdate")), "", RDR1.Item("birthdate")))
                    ListBox1.Items.Add(f)
                End If
            End While

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.Items.Count <= 0 Then
            MessageBox.Show("No item selected!")
            Return
        End If
        If (search_type.Equals("Movies")) Then
            Globals.shared_movie = ListBox1.SelectedItem
            Me.Close()
            MainForm.Hide()
            Dim mpage As New MoviePage
            mpage.Show()
        End If
        If (search_type.Equals("Users")) Then
            Globals.shared_usr = ListBox1.SelectedItem
            Dim upage As New User
            upage.Show()
            Me.Hide()
        End If
        If (search_type.Equals("Filmmakers")) Then
            Globals.shared_fm = ListBox1.SelectedItem
            If String.IsNullOrEmpty(Globals.shared_fm.username) Then
                Dim fpage As New FilmmakerUnregisterd
                fpage.Show()
                Me.Hide()
            Else
                Dim fpage As New FilmmakerUser
                fpage.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Search_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
        Me.Hide()
    End Sub

End Class