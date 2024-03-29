﻿Imports System.Data.SqlClient

Public Class MainForm

    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Private tmpMovie As Movie
    Private tmpUsr As Usr
    Private tmpFilmmaker As Filmmaker

    Private tmpMovieFromFriend As Movie
    Private tmpUserFromFriend As Usr
    Private tmpFilmmakerFromFriend As Filmmaker

    Private idx As New Integer
    Private mine As Boolean

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Show()
        ListBox2.ScrollAlwaysVisible = True
        ListBox2.HorizontalScrollbar = True

    End Sub

    Public Sub getContent(ByVal sender As Object, ByVal e As EventArgs)
        If CN.State = ConnectionState.Open Then
            CN.Close()
            ClearConnection()
        End If
        CN.Open()
        ListBox1.Items.Clear()
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.HorizontalScrollbar = True
        ListBox2.Items.Clear()

        ClearConnection()
        CN.Open()
        CMD.CommandText = "SELECT * FROM dbo.GetUsrMovieInfo(@id)"
        CMD.Parameters.Add("@id", SqlDbType.Int).Value = Globals.user.id
        Dim RDR1 As SqlDataReader
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            Dim m As New Movie
            m.user_rating = 0
            m.avg_rating = 0
            m.movie_id = RDR1.Item("movie_id")
            m.title = RDR1.Item("title")
            m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
            m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
            m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
            m.runtime = RDR1.Item("runtime")
            m.year = RDR1.Item("year")
            If (Not IsDBNull(RDR1.Item("rating"))) Then
                m.user_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
            End If
            m.user_review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
            If (Not IsDBNull(RDR1.Item("rating"))) Then
                m.avg_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("avg_rating")), "", RDR1.Item("avg_rating")))
            End If
            ListBox1.Items.Add(m)
        End While
        RDR1.Close()

        CMD.CommandText = "SELECT * FROM dbo.GetFriends(@uid)"
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
        CN.Close()
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = 0
        End If
        If ListBox2.Items.Count > 0 Then
            ListBox2.SelectedIndex = 0
        End If

        hideUsr()
        showMovie()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            tmpMovie = ListBox1.SelectedItem
            Globals.user.rating = tmpMovie.user_rating
            Globals.user.review = tmpMovie.user_review
            Globals.shared_movie = tmpMovie
            showMovie()
        End If
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex > -1 Then
            tmpUsr = ListBox2.SelectedItem
            showUsr()
            If ListBox4.Items.Count > 0 Then
                ListBox4.SetSelected(0, True)
            End If
        End If
    End Sub


    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        If ListBox4.SelectedIndex > -1 Then
            tmpMovieFromFriend = ListBox4.SelectedItem

            tmpUsr.rating = tmpMovieFromFriend.user_rating
            tmpUsr.review = tmpMovieFromFriend.user_review

            FriendsRatingBox.Text = tmpMovieFromFriend.user_rating
            OverallRatingTextBox.Text = tmpMovieFromFriend.avg_rating
            Globals.shared_movie = tmpMovieFromFriend

            showMovieFromFriend()

        End If
    End Sub

    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged
        If ListBox5.SelectedIndex > -1 Then
            tmpUserFromFriend = ListBox5.SelectedItem
            showUsrFromFriend()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            showMovie()
            If ListBox1.Items.Count > 0 Then
                ListBox1.SetSelected(0, True)
            End If
        End If
        If TabControl1.SelectedIndex = 1 Then
            showUsr()
            If ListBox2.Items.Count > 0 Then
                ListBox2.SetSelected(0, True)
            End If
            TabControl2.TabIndex = 0
            If ListBox4.Items.Count > 0 Then
                ListBox4.SetSelected(0, True)
            End If
        End If

    End Sub

    Private Sub TabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedIndexChanged
        If TabControl2.SelectedIndex = 0 Then
            showMovieFromFriend()
            If ListBox4.Items.Count > 0 Then
                ListBox4.SetSelected(0, True)
            End If
        End If
        If TabControl2.SelectedIndex = 1 Then
            showUsrFromFriend()
            If ListBox5.Items.Count > 0 Then
                ListBox5.SetSelected(0, True)
            End If
        End If


    End Sub

    Private Sub getUser(ByVal sender As Object, ByVal e As EventArgs)
        CN.Open()
        CMD.CommandText = "SELECT * FROM GetUsr(@username)"
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
        RuntimeLabel.Show()
        RuntimeTextBox.Show()
        countryLabel.Show()
        CountryTextBox.Show()
        MyRatingLabel.Show()
        MyRatingTextBox.Show()
        OverallRatingLabel.Show()
        OverallRatingTextBox.Show()
        UpdateReviewButton.Show()
        synbioTextBox.Show()
        PosterBox.Show()
        yearLabel.Show()
        SeeReviewButton.Show()
        Button2.Show()
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
            PosterBox.ImageLocation = Globals.working_directory + "\posters\" + tmpMovie.poster
            PosterBox.Load()
        Else
            PosterBox.ImageLocation = Globals.working_directory + "\posters\Question-mark.png"
            PosterBox.Load()
        End If
        RuntimeTextBox.Text = tmpMovie.runtime & " min"
        CountryTextBox.Text = tmpMovie.country
        MyRatingTextBox.Text = tmpMovie.user_rating
        OverallRatingTextBox.Text = tmpMovie.avg_rating
    End Sub

    Private Sub hideMovie()
        synbioTextBox.Hide()
        PosterBox.Hide()
        yearLabel.Hide()
        GenresLabel.Hide()
        RuntimeTextBox.Clear()
        CountryTextBox.Clear()
        MyRatingTextBox.Hide()
        MyRatingLabel.Hide()
        UpdateReviewButton.Hide()
    End Sub

    Private Sub showUsr()
        hideMovie()
        SeeProfileButton.Show()
        UserNameLabel.Show()
        NameBox.Show()
        LocationLabel.Show()
        LocationBox.Show()
        TabControl2.Show()
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
        SeeFriendsProfileButton.Hide()
        RuntimeLabel.Show()
        RuntimeTextBox.Show()
        countryLabel.Show()
        CountryTextBox.Show()
        OverallRatingLabel.Show()
        OverallRatingTextBox.Show()
        FriendsRatingLabel.Show()
        FriendsRatingBox.Show()
        Button2.Show()
        SeeReviewButton.Show()
        If ListBox4.Items.Count > 0 Then
            RuntimeTextBox.Text = tmpMovieFromFriend.runtime & "min"
            CountryTextBox.Text = tmpMovieFromFriend.country
        End If

    End Sub

    Private Sub showUsrFromFriend()
        RuntimeLabel.Hide()
        RuntimeTextBox.Hide()
        countryLabel.Hide()
        CountryTextBox.Hide()
        OverallRatingLabel.Hide()
        OverallRatingTextBox.Hide()
        FriendsRatingBox.Hide()
        FriendsRatingLabel.Hide()
        Button2.Hide()
        SeeReviewButton.Hide()
        SeeFriendsProfileButton.Show()

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

        CMD.CommandText = "SELECT * FROM GetUsrMovieInfo(@id)"
        CMD.Parameters.Add("@id", SqlDbType.Int).Value = tmpUsr.id
        Dim RDR1 As SqlDataReader
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            Dim m As New Movie
            m.user_rating = 0
            m.movie_id = RDR1.Item("movie_id")
            m.title = RDR1.Item("title")
            m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
            m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
            m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
            m.runtime = RDR1.Item("runtime")
            m.year = RDR1.Item("year")
            If (Not IsDBNull(RDR1.Item("rating"))) Then
                m.user_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
            End If
            m.user_review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
            m.avg_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("avg_rating")), "", RDR1.Item("avg_rating")))
            ListBox4.Items.Add(m)
        End While

        RDR1.Close()

        CMD.CommandText = "SELECT * FROM GetFriends(@uid)"
        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = tmpUsr.id
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
        SearchComboBox.Items.Add("Movies")
        SearchComboBox.Items.Add("Users")
        SearchComboBox.Items.Add("Filmmakers")
        SearchComboBox.SelectedIndex = 0
        TabControl1.TabIndex = 0
        hideUsr()
        showMovie()
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
            If ListBox1.Items.Count = 0 Then
                MessageBox.Show("No movie available!")
                Return
            End If
            Globals.shared_movie = ListBox1.SelectedItem
            idx = ListBox1.SelectedIndex
            mine = True
        Else
            If ListBox4.Items.Count = 0 Then
                MessageBox.Show("No movie available!")
                Return
            End If
            Globals.shared_movie = ListBox4.SelectedItem
            idx = ListBox4.SelectedIndex
            mine = False
        End If
        Globals.lastForm = "MainForm"
        Me.Hide()
        Dim mpage As New MoviePage
        mpage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()
        ListBox2.ScrollAlwaysVisible = True
        ListBox2.HorizontalScrollbar = True

    End Sub

    Private Sub MyRatingTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyRatingTextBox.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                  Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub SeeReviewButton_Click(sender As Object, e As EventArgs) Handles SeeReviewButton.Click

        Dim rev As Review
        If TabControl1.SelectedIndex = 0 Then
            If ListBox1.Items.Count = 0 Then
                MessageBox.Show("No review available!")
                Return
            End If
            rev = New Review(Globals.user)
            idx = ListBox1.SelectedIndex
            mine = True
        Else
            If ListBox4.Items.Count = 0 Then
                MessageBox.Show("No review available!")
                Return
            End If
            rev = New Review(tmpUsr)
            idx = ListBox4.SelectedIndex
            mine = False
        End If
        rev.Show()
    End Sub

    Private Sub UpdateReviewButton_Click(sender As Object, e As EventArgs) Handles UpdateReviewButton.Click
        If TabControl1.SelectedIndex = 0 Then
            If ListBox1.Items.Count = 0 Then
                MessageBox.Show("Invalid operation!")
                Return
            End If
        ElseIf TabControl1.SelectedIndex = 1 Then
            If ListBox4.Items.Count = 0 Then
                MessageBox.Show("Invalid operation!")
                Return
            End If
        End If
        If String.IsNullOrEmpty(MyRatingTextBox.Text) Then
            MessageBox.Show("Please insert a value!")
            Return
        End If
        ClearConnection()
        Dim tmp As New Integer
        tmp = ListBox1.SelectedIndex
        CN.Open()
        CMD.CommandText = "EXEC dbo.pr_GeneralAddRating @rating = @rating4, @movie_id = @mid, @user_id = @uid"
        CMD.Parameters.Add(New SqlParameter("@mid", Globals.shared_movie.movie_id))
        CMD.Parameters.Add(New SqlParameter("@uid", Globals.user.id))
        CMD.Parameters.Add(New SqlParameter("@rating4", MyRatingTextBox.Text))
        Try
            CMD.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("There was an error when updating your rating. Make sure you type a number from 1 to 10.")
            Return
        End Try
        MessageBox.Show("Rating updated!")
        getContent(sender, e)
        ListBox1.SetSelected(tmp, True)
    End Sub

    Public Sub focus(deleting As Boolean)
        If mine Then
            If ListBox1.Items.Count > 0 Then
                If deleting And idx > 0 Then
                    ListBox1.SetSelected(idx - 1, True)
                Else
                    ListBox1.SetSelected(idx, True)
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrEmpty(SearchTextBox.Text) Then
            MessageBox.Show("Please enter a search term.")
            Return
        End If
        Dim s As New Search
        s.search_type = SearchComboBox.SelectedItem.ToString
        s.search_query = SearchTextBox.Text
        s.Show()
        Me.Hide()
    End Sub

    Private Sub SeeProfileButton_Click(sender As Object, e As EventArgs) Handles SeeProfileButton.Click
        If ListBox2.Items.Count <= 0 Then
            MessageBox.Show("No item selected!")
            Return
        End If

        Globals.shared_usr = ListBox2.SelectedItem
        Dim upage As New User
        upage.Show()
        Me.Hide()
    End Sub

    Private Sub SeeFriendsProfileButton_Click(sender As Object, e As EventArgs) Handles SeeFriendsProfileButton.Click
        If ListBox5.Items.Count <= 0 Then
            MessageBox.Show("No item selected!")
            Return
        End If
        Globals.shared_usr = ListBox5.SelectedItem
        Dim upage As New User
        upage.Show()
        Me.Hide()
    End Sub

    Private Sub clearFilterButton_Click(sender As Object, e As EventArgs) Handles clearFilterButton.Click
        ListBox1.Items.Clear()
        searchFilterBox.Clear()
        ClearConnection()
        CN.Open()
        CMD.CommandText = "SELECT * FROM dbo.GetUsrMovieInfo(@id)"
        CMD.Parameters.Add("@id", SqlDbType.Int).Value = Globals.user.id
        ListBox1.Items.Clear()
        Dim RDR1 As SqlDataReader
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            Dim m As New Movie
            m.user_rating = 0
            m.avg_rating = 0
            m.movie_id = RDR1.Item("movie_id")
            m.title = RDR1.Item("title")
            m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
            m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
            m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
            m.runtime = RDR1.Item("runtime")
            m.year = RDR1.Item("year")
            If (Not IsDBNull(RDR1.Item("rating"))) Then
                m.user_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
            End If
            m.user_review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
            If (Not IsDBNull(RDR1.Item("rating"))) Then
                m.avg_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("avg_rating")), "", RDR1.Item("avg_rating")))
            End If
            ListBox1.Items.Add(m)
        End While
        RDR1.Close()
    End Sub

    Private Sub filterbutton_Click(sender As Object, e As EventArgs) Handles filterbutton.Click
        ClearConnection()
        CN.Open()
        CMD.CommandText = "SELECT * FROM dbo.Filter(@id, @title)"
        CMD.Parameters.Add("@id", SqlDbType.Int).Value = Globals.user.id
        CMD.Parameters.Add("@title", SqlDbType.Text).Value = "%" + searchFilterBox.Text + "%"
        ListBox1.Items.Clear()
        Dim RDR1 As SqlDataReader
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            Dim m As New Movie
            m.user_rating = 0
            m.avg_rating = 0
            m.movie_id = RDR1.Item("movie_id")
            m.title = RDR1.Item("title")
            m.synopsis = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("synopsis")), "", RDR1.Item("synopsis")))
            m.country = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("country")), "", RDR1.Item("country")))
            m.poster = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("poster")), "", RDR1.Item("poster")))
            m.runtime = RDR1.Item("runtime")
            m.year = RDR1.Item("year")
            If (Not IsDBNull(RDR1.Item("rating"))) Then
                m.user_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
            End If
            m.user_review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
            If (Not IsDBNull(RDR1.Item("rating"))) Then
                m.avg_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("avg_rating")), "", RDR1.Item("avg_rating")))
            End If
            ListBox1.Items.Add(m)
        End While
        RDR1.Close()
    End Sub

    Private Sub MyProfileButton_Click(sender As Object, e As EventArgs) Handles MyProfileButton.Click
        Globals.shared_usr = Globals.user
        Dim upage As New User
        upage.Show()
        Me.Hide()
    End Sub
End Class
