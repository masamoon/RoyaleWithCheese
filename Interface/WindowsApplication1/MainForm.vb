Imports System.Data.SqlClient

Public Class MainForm

    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Private tmpMovie As Movie
    Private tmpUsr As Usr
    Private tmpFilmmaker As Filmmaker

    Private tmpMovieFromFriend As Movie
    Private tmpUserFromFriend As Usr
    Private tmpFilmmakerFromFriend As Filmmaker

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Show()
        ListBox2.ScrollAlwaysVisible = True
        ListBox2.HorizontalScrollbar = True
        ListBox3.Items.Clear()
    End Sub

    Private Sub getContent(ByVal sender As Object, ByVal e As EventArgs)
        CN.Open()
        ListBox1.Items.Clear()
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.HorizontalScrollbar = True
        ListBox2.Items.Clear()
        ListBox3.ScrollAlwaysVisible = True
        ListBox3.HorizontalScrollbar = True
        CMD.CommandText = "SELECT * From Movie join Review on Review.movie_id = Movie.movie_id join Usr on Review.user_id = Usr.id
                            WHERE Usr.id = @id"
        CMD.Parameters.Add("@id", SqlDbType.Int).Value = Globals.user.id
        Dim RDR1 As SqlDataReader
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            Dim m As New Movie
            m.movie_id = RDR1.Item("movie_id")
            m.title = RDR1.Item("title")
            m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
            m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
            m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
            m.runtime = RDR1.Item("runtime")
            m.year = RDR1.Item("year")
            ListBox1.Items.Add(m)
        End While
        RDR1.Close()

        CMD.CommandText = "SELECT * FROM FriendList join Usr on FriendList.user_id = Usr.id OR FriendList.user_id_friend = Usr.id
                            WHERE ((user_id = @uid OR user_id_friend = @uid) AND id != @uid)"
        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.user.id
        Dim RDR2 As SqlDataReader
        RDR2 = CMD.ExecuteReader
        While RDR2.Read
            Dim u As New Usr
            u.id = RDR2.Item("id")
            u.username = RDR2.Item("username")
            u.fname = Convert.ToString(IIf(RDR2.IsDBNull(RDR2.GetOrdinal("fname")), "", RDR2.Item("fname")))
            u.lname = Convert.ToString(IIf(RDR2.IsDBNull(RDR2.GetOrdinal("lname")), "", RDR2.Item("lname")))
            u.location = Convert.ToString(IIf(RDR2.IsDBNull(RDR2.GetOrdinal("location")), "", RDR2.Item("location")))
            u.email = RDR2.Item("email")
            ListBox2.Items.Add(u)
        End While
        RDR2.Close()
        CMD.CommandText = "Select * From Filmmaker"
        Dim RDR3 As SqlDataReader
        RDR3 = CMD.ExecuteReader
        While RDR3.Read
            Dim f As New Filmmaker
            f.id = RDR3.Item("user_id")
            f.biography = Convert.ToString(IIf(RDR3.IsDBNull(RDR3.GetOrdinal("biography")), "", RDR3.Item("biography")))
            f.birthdate = Convert.ToDateTime(IIf(RDR3.IsDBNull(RDR3.GetOrdinal("birthdate")), "", RDR3.Item("birthdate")))
            ListBox3.Items.Add(f)
        End While

        RDR3.Close()
        CN.Close()
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = 0
        End If
        If ListBox2.Items.Count > 0 Then
            ListBox2.SelectedIndex = 0
        End If
        If ListBox3.Items.Count > 0 Then
            ListBox3.SelectedIndex = 0
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            tmpMovie = ListBox1.SelectedItem
            ShowMovie()
        End If
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex > -1 Then
            tmpUsr = ListBox2.SelectedItem
            showUsr()
        End If
    End Sub
    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        If ListBox3.SelectedIndex > -1 Then
            tmpFilmmaker = ListBox3.SelectedItem
            '          ShowFilmmaker()
        End If
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        If ListBox4.SelectedIndex > -1 Then
            tmpMovieFromFriend = ListBox4.SelectedItem
            showMovieFromFriend()
        End If
    End Sub

    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged
        If ListBox5.SelectedIndex > -1 Then
            tmpUserFromFriend = ListBox5.SelectedItem
            '    showUsrFromFriend()
        End If
    End Sub
    Private Sub ListBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox6.SelectedIndexChanged
        If ListBox6.SelectedIndex > -1 Then
            tmpFilmmakerFromFriend = ListBox6.SelectedItem
            '          ShowFilmmaker()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            If ListBox1.Items.Count > 0 Then
                ListBox1.SetSelected(0, True)
            End If
        End If
        If TabControl1.SelectedIndex = 1 Then
            If ListBox2.Items.Count > 0 Then
                ListBox2.SetSelected(0, True)
            End If
        End If
        If TabControl1.SelectedIndex = 2 Then
            If ListBox3.Items.Count > 0 Then
                ListBox3.SetSelected(0, True)
            End If
        End If
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedIndexChanged
        If TabControl2.SelectedIndex = 0 Then
            If ListBox4.Items.Count > 0 Then
                ListBox4.SetSelected(0, True)
            End If
        End If
        If TabControl2.SelectedIndex = 1 Then
            If ListBox5.Items.Count > 0 Then
                ListBox5.SetSelected(0, True)
            End If
        End If
        If TabControl2.SelectedIndex = 2 Then
            If ListBox6.Items.Count > 0 Then
                ListBox6.SetSelected(0, True)
            End If
        End If
    End Sub

    Private Sub getUser(ByVal sender As Object, ByVal e As EventArgs)
        CN.Open()
        CMD.CommandText = "SELECT * FROM Usr WHERE username = @username"
        CMD.Parameters.Add("@username", SqlDbType.VarChar).Value = Globals.user.username
        Dim RDR1 As SqlDataReader
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            Globals.user.id = RDR1.Item("id")
            Globals.user.fname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("fname")), "", RDR1.Item("fname")))
            Globals.user.lname = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("lname")), "", RDR1.Item("lname")))
            Globals.user.location = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("location")), "", RDR1.Item("location")))
            Globals.user.email = RDR1.Item("email")
        End While
        RDR1.Close()
        CN.Close()
    End Sub

    Private Sub showMovie()
        hideUsr()
        synbioTextBox.Show()
        PosterBox.Show()
        yearLabel.Show()
        GenresLabel.Text = ""
        GenresLabel.Show()
        If ListBox1.Items.Count <= 0 Then Exit Sub
        nameLabel.Text = tmpMovie.title
        yearLabel.Text = tmpMovie.year
        synbioTextBox.Text = tmpMovie.synopsis
        For Each genre As String In tmpMovie.genres
            GenresLabel.Text += genre & " | "
        Next genre
        PosterBox.SizeMode = PictureBoxSizeMode.StretchImage
        If Not String.IsNullOrEmpty(tmpMovie.poster) Then
            PosterBox.ImageLocation = tmpMovie.poster
            PosterBox.Load()
        Else
            PosterBox.ImageLocation = "C:\Users\alagao\Desktop\posters\Question-mark.png"
            PosterBox.Load()
        End If
        RuntimeTextBox.Text = tmpMovie.runtime & " min"
        CountryTextBox.Text = tmpMovie.country
    End Sub

    Private Sub hideMovie()
        synbioTextBox.Hide()
        PosterBox.Hide()
        yearLabel.Hide()
        GenresLabel.Hide()
        RuntimeTextBox.Clear()
        CountryTextBox.Clear()

    End Sub

    Private Sub showUsr()
        hideMovie()
        SeeProfileButton.Show()
        UserNameLabel.Show()
        NameBox.Show()
        LocationLabel.Show()
        LocationBox.Show()
        TabControl2.Show()
        SeeFriendsProfileButton.Show()
        FriendsRatingLabel.Show()
        FriendsRatingBox.Show()
        If ListBox2.Items.Count <= 0 Then Exit Sub
        nameLabel.Text = tmpUsr.username
        FriendsRatingLabel.Text = tmpUsr.username & "'s rating"
        SeeFriendsProfileButton.Hide()
        NameBox.Text = tmpUsr.fname & " " & tmpUsr.lname
        LocationBox.Text = tmpUsr.location
        getContentUsr()
    End Sub

    Private Sub hideUsr()
        SeeProfileButton.Hide()
        UserNameLabel.Hide()
        NameBox.Hide()
        LocationLabel.Hide()
        LocationBox.Hide()
        TabControl2.Hide()
        SeeFriendsProfileButton.Hide()
        FriendsRatingLabel.Hide()
        FriendsRatingBox.Hide()
    End Sub

    Private Sub showMovieFromFriend()

    End Sub

    Private Sub getContentUsr()
        ClearConnection()
        CN.Open()
        ListBox4.Items.Clear()
        ListBox4.ScrollAlwaysVisible = True
        ListBox4.HorizontalScrollbar = True
        ListBox5.Items.Clear()
        ListBox5.ScrollAlwaysVisible = True
        ListBox5.HorizontalScrollbar = True
        ListBox6.Items.Clear()
        ListBox6.ScrollAlwaysVisible = True
        ListBox6.HorizontalScrollbar = True
        CMD.CommandText = "SELECT * From Movie join Review on Review.movie_id = Movie.movie_id join Usr on Review.user_id = Usr.id
                            WHERE Usr.id = @friend_id"
        CMD.Parameters.Add("@friend_id", SqlDbType.Int).Value = tmpUsr.id
        Dim RDR1 As SqlDataReader
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            Dim m As New Movie
            m.movie_id = RDR1.Item("movie_id")
            m.title = RDR1.Item("title")
            m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
            m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
            m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
            m.runtime = RDR1.Item("runtime")
            m.year = RDR1.Item("year")
            m.user_rating = RDR1.Item("rating")
            ListBox4.Items.Add(m)
        End While
        RDR1.Close()

        CMD.CommandText = "SELECT * FROM FriendList join Usr on FriendList.user_id = Usr.id OR FriendList.user_id_friend = Usr.id
                            WHERE ((user_id = @frienduid OR user_id_friend = @frienduid) AND id != @frienduid)"
        CMD.Parameters.Add("@frienduid", SqlDbType.Int).Value = tmpUsr.id
        Dim RDR2 As SqlDataReader
        RDR2 = CMD.ExecuteReader
        While RDR2.Read
            Dim u As New Usr
            u.id = RDR2.Item("id")
            u.username = RDR2.Item("username")
            u.fname = Convert.ToString(IIf(RDR2.IsDBNull(RDR2.GetOrdinal("fname")), "", RDR2.Item("fname")))
            u.lname = Convert.ToString(IIf(RDR2.IsDBNull(RDR2.GetOrdinal("lname")), "", RDR2.Item("lname")))
            u.location = Convert.ToString(IIf(RDR2.IsDBNull(RDR2.GetOrdinal("location")), "", RDR2.Item("location")))
            u.email = RDR2.Item("email")
            ListBox5.Items.Add(u)
        End While
        RDR2.Close()
        CMD.CommandText = "Select * From Filmmaker"
        Dim RDR3 As SqlDataReader
        RDR3 = CMD.ExecuteReader
        While RDR3.Read
            Dim f As New Filmmaker
            f.id = RDR3.Item("user_id")
            f.biography = Convert.ToString(IIf(RDR3.IsDBNull(RDR3.GetOrdinal("biography")), "", RDR3.Item("biography")))
            f.birthdate = Convert.ToDateTime(IIf(RDR3.IsDBNull(RDR3.GetOrdinal("birthdate")), "", RDR3.Item("birthdate")))
            ListBox6.Items.Add(f)
        End While

        RDR3.Close()
        CN.Close()
        If ListBox4.Items.Count > 0 Then
            ListBox4.SelectedIndex = 0
        End If
        If ListBox5.Items.Count > 0 Then
            ListBox5.SelectedIndex = 0
        End If
        If ListBox5.Items.Count > 0 Then
            ListBox5.SelectedIndex = 0
        End If

    End Sub

    Public Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CN = New SqlConnection(Globals.connectionPath)
        CMD = New SqlCommand
        CMD.Connection = CN
        heyLabel.Text = "Hey, " & Globals.user.username & "!"
        getUser(sender, e)
        getContent(sender, e)
        If ListBox1.Items.Count > 0 Then
            ListBox1.SetSelected(0, True)
        End If
    End Sub

    Private Sub ClearConnection()
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
        CN.ConnectionString = Globals.connectionPath
        CMD.Connection = CN
        CMD.Parameters.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TabControl1.SelectedIndex = 0 Then
            Globals.shared_movie = ListBox1.SelectedItem
        Else
            Globals.shared_movie = ListBox4.SelectedItem
        End If

        Globals.lastForm = "MainForm"
        Hide()
        MoviePage.Show()
    End Sub
End Class
