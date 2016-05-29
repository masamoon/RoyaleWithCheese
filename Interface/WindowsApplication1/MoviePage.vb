Imports System.Data.SqlClient

'BUG: ListboxX.SelectedItem always returns the last item from the second Listbox


Public Class MoviePage


    Dim CN As SqlConnection
    Dim CMD As SqlCommand

    Dim tempUsr As New Usr
    Dim tempUsr2 As New Usr


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

    Public Sub MoviePage_FormClosed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.FormClosed
        Me.Hide()
        Select Case Globals.lastForm
            Case "MainForm"
                MainForm.Show()
        End Select
    End Sub

    Public Sub getContent(ByVal sender As Object, ByVal e As EventArgs)
        Dim poster_path As String
        nameLabel.Text = Globals.shared_movie.title
        synbioTextBox.Text = Globals.shared_movie.synopsis
        CountryTextBox.Text = Globals.shared_movie.country
        poster_path = Globals.shared_movie.poster
        RuntimeTextBox.Text = Globals.shared_movie.runtime
        yearLabel.Text = Globals.shared_movie.year
        If Not String.IsNullOrEmpty(poster_path) Then
            PosterBox.ImageLocation = poster_path
            PosterBox.SizeMode = PictureBoxSizeMode.StretchImage
            PosterBox.Load()
        Else
            PosterBox.ImageLocation = "C:\Users\alagao\Desktop\posters\Question-mark.png"
            PosterBox.Load()
        End If

        CN.Open()
        CMD.CommandText = "SELECT * FROM Review WHERE movie_id = @movie_id AND user_id = @user_id"
        CMD.Parameters.Add("@movie_id", SqlDbType.Int).Value = Globals.shared_movie.movie_id
        CMD.Parameters.Add("@user_id", SqlDbType.Int).Value = Globals.user.id
        Dim RDR1 As SqlDataReader
        Dim rev As String
        Dim rat As Integer
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            rev = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
            rat = Convert.ToUInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
        End While
        If Not String.IsNullOrEmpty(rev) Then
            myreviewTextBox.Text = rev
        Else
            myreviewTextBox.Text = "Write your review here..."
        End If
        If Not rat = 0 Then
            MyRatingTextBox.Text = rat
        End If
        RDR1.Close()
        CMD.CommandText = "SELECT * FROM FriendList join Usr on FriendList.user_id = Usr.id OR FriendList.user_id_friend = Usr.id Join Review on Review.user_id = FriendList.user_id_friend JOIN Movie ON Movie.movie_id = Review.movie_id
WHERE ((FriendList.user_id = @uid OR user_id_friend = @uid) AND Usr.id != @uid)  AND Review.movie_id = @mov_id"
        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.user.id
        CMD.Parameters.Add("@mov_id", SqlDbType.Int).Value = Globals.shared_movie.movie_id
        Dim u As New Usr
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            u.username = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("username")), "", RDR1.Item("username")))
            u.review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
            u.rating = Convert.ToUInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
            ListBox1.Items.Add(u)
        End While
        If ListBox1.Items.Count > 0 Then
            ListBox1.SetSelected(0, True)
        End If
        RDR1.Close()

        CMD.CommandText = "SELECT * From Movie join Review on Review.movie_id = Movie.movie_id join Usr on Review.user_id = Usr.id
WHERE Movie.movie_id = @mid"
        CMD.Parameters.Add("@mid", SqlDbType.Int).Value = Globals.shared_movie.movie_id
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            u.username = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("username")), "", RDR1.Item("username")))
            u.review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
            u.rating = Convert.ToUInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
            ListBox2.Items.Add(u)
        End While
        If ListBox2.Items.Count > 0 Then
            ListBox2.SetSelected(0, True)
        End If
        RDR1.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            tempUsr = ListBox1.SelectedItem
        End If
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex > -1 Then
            tempUsr2 = ListBox2.SelectedItem
        End If
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

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        Select Case Globals.lastForm
            Case "MainForm"
                MainForm.Show()
        End Select
    End Sub

    Private Sub FriendReviewButton_Click(sender As Object, e As EventArgs) Handles FriendsReviewButton.Click
        If ListBox1.SelectedIndex < 0 Then
            MessageBox.Show("No friends wrote reviews about this movie.")
            Return
        End If
        MessageBox.Show(ListBox1.SelectedItem.ToString)
        Dim Review As New Review(ListBox1.SelectedItem)
        Review.Show()
    End Sub

    Private Sub ReviewButton_Click(sender As Object, e As EventArgs) Handles ReviewButton.Click
        If ListBox2.SelectedIndex < 0 Then
            MessageBox.Show("No one wrote reviews about this movie.")
            Return
        End If
        MessageBox.Show(ListBox2.SelectedItem.ToString)
        Dim Review As New Review(ListBox2.SelectedItem)
        Review.Show()
    End Sub

    Private Sub UpdateReviewButton_Click(sender As Object, e As EventArgs) Handles UpdateReviewButton.Click
        ClearConnection()
        Dim tmp As New Integer
        tmp = ListBox1.SelectedIndex
        CN.Open()
        CMD.CommandText = "SELECT dbo.WroteReview(@movie_id, @user_id)"
        CMD.Parameters.Add(New SqlParameter("@movie_id", Globals.shared_movie.movie_id))
        CMD.Parameters.Add(New SqlParameter("@user_id", Globals.user.id))
        Dim accept As Integer
        accept = CMD.ExecuteScalar
        If accept = 1 Then
            CMD.CommandText = "UPDATE Review SET rating = @rating WHERE user_id = @uid AND movie_id = @mid"
            CMD.Parameters.Add(New SqlParameter("@mid", Globals.shared_movie.movie_id))
            CMD.Parameters.Add(New SqlParameter("@uid", Globals.user.id))
            CMD.Parameters.Add(New SqlParameter("@rating", MyRatingTextBox.Text))
            Try
                CMD.ExecuteNonQuery()
            Catch ex As System.Data.SqlClient.SqlException
                MessageBox.Show("There was an error when updating your rating. Make sure you type a number from 1 to 10.")
                Return
            End Try
        Else
            CMD.CommandText = "SELECT TOP 1 * FROM Review ORDER BY id DESC"
            Dim id As Integer
            Dim RDR1 As SqlDataReader
            RDR1 = CMD.ExecuteReader
            While RDR1.Read
                id = RDR1.Item("id") + 1
            End While
            CMD.CommandText = "INSERT INTO Review (id, rating, movie_id, user_id) VALUES (@id, @rating, @mo_id, @u_id)"
            CMD.Parameters.Add(New SqlParameter("@id", id))
            CMD.Parameters.Add(New SqlParameter("@rating", MyRatingTextBox.Text))
            CMD.Parameters.Add(New SqlParameter("@m_id", Globals.shared_movie.movie_id))
            CMD.Parameters.Add(New SqlParameter("@u_id", Globals.user.id))
            Try
                CMD.ExecuteNonQuery()
            Catch ex As System.Data.SqlClient.SqlException
                MessageBox.Show("There was an error when updating your rating. Make sure you type a number from 1 to 10.")
                Return
            End Try
        End If
        MessageBox.Show("Rating updated!")
        MainForm.getContent(sender, e)
        MainForm.focus()
    End Sub

    Private Sub ClearConnection()
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
        CN.ConnectionString = Globals.connectionPath
        CMD.Connection = CN
        CMD.Parameters.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearConnection()
        Dim tmp As New Integer
        tmp = ListBox1.SelectedIndex
        CN.Open()
        CMD.CommandText = "SELECT dbo.WroteReview(@movie_id, @user_id)"
        CMD.Parameters.Add(New SqlParameter("@movie_id", Globals.shared_movie.movie_id))
        CMD.Parameters.Add(New SqlParameter("@user_id", Globals.user.id))
        Dim accept As Integer
        accept = CMD.ExecuteScalar
        If accept = 1 Then
            CMD.CommandText = "UPDATE Review SET body = @body WHERE user_id = @uid AND movie_id = @mid"
            CMD.Parameters.Add(New SqlParameter("@mid", Globals.shared_movie.movie_id))
            CMD.Parameters.Add(New SqlParameter("@uid", Globals.user.id))
            CMD.Parameters.Add(New SqlParameter("@body", myreviewTextBox.Text))
            Try
                CMD.ExecuteNonQuery()
            Catch ex As System.Data.SqlClient.SqlException
                MessageBox.Show("There was an error when updating your rating. Make sure you type a number from 1 to 10.")
                Return
            End Try
        Else
            CMD.CommandText = "SELECT TOP 1 * FROM Review ORDER BY id DESC"
            Dim id As Integer
            Dim RDR1 As SqlDataReader
            RDR1 = CMD.ExecuteReader
            While RDR1.Read
                id = RDR1.Item("id") + 1
            End While
            CMD.CommandText = "INSERT INTO Review (id, body, movie_id, user_id) VALUES (@id, @body, @mo_id, @u_id)"
            CMD.Parameters.Add(New SqlParameter("@id", id))
            CMD.Parameters.Add(New SqlParameter("@body", myreviewTextBox.Text))
            CMD.Parameters.Add(New SqlParameter("@m_id", Globals.shared_movie.movie_id))
            CMD.Parameters.Add(New SqlParameter("@u_id", Globals.user.id))
            Try
                CMD.ExecuteNonQuery()
            Catch ex As System.Data.SqlClient.SqlException
                MessageBox.Show("There was an error when updating your review.")
                Return
            End Try
        End If
        MessageBox.Show("Review updated!")
        MainForm.getContent(sender, e)
        MainForm.focus()
    End Sub
End Class