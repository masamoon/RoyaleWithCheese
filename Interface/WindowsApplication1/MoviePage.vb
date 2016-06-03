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
        CMD.CommandText = "SELECT * FROM dbo.GetReview(@movie_id, @user_id)"
        CMD.Parameters.Add("@movie_id", SqlDbType.Int).Value = Globals.shared_movie.movie_id
        CMD.Parameters.Add("@user_id", SqlDbType.Int).Value = Globals.user.id
        Dim RDR1 As SqlDataReader
        Dim rev As String
        Dim rat As Integer
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            rat = 0
            rev = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
            If (Not IsDBNull(RDR1.Item("rating"))) Then
                rat = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
            End If
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
        CMD.CommandText = "SELECT * FROM dbo.GetReviewFromFriend(@mov_id, @uid)"
        CMD.Parameters.Add("@mov_id", SqlDbType.Int).Value = Globals.shared_movie.movie_id
        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.user.id
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            Dim u As New Usr
            u.rating = 0
            u.username = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("username")), "", RDR1.Item("username")))
            u.review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
            If (Not IsDBNull(RDR1.Item("rating"))) Then
                u.rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
            End If
            ListBox1.Items.Add(u)
        End While
        If ListBox1.Items.Count > 0 Then
            ListBox1.SetSelected(0, True)
        End If
        RDR1.Close()

        CMD.CommandText = "SELECT * FROM dbo.GetAllReviews(@mid)"
        CMD.Parameters.Add("@mid", SqlDbType.Int).Value = Globals.shared_movie.movie_id
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
            Dim u As New Usr
            u.rating = 0
            u.username = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("username")), "", RDR1.Item("username")))
            u.review = Convert.ToString(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("body")), "", RDR1.Item("body")))
            If (Not IsDBNull(RDR1.Item("rating"))) Then
                u.rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("rating")), "", RDR1.Item("rating")))
            End If
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
        Dim Review As New Review(ListBox1.SelectedItem)
        Review.Show()
    End Sub

    Private Sub ReviewButton_Click(sender As Object, e As EventArgs) Handles ReviewButton.Click
        If ListBox2.SelectedIndex < 0 Then
            MessageBox.Show("No one wrote reviews about this movie.")
            Return
        End If
        Dim Review As New Review(ListBox2.SelectedItem)
        Review.Show()
    End Sub

    Private Sub UpdateReviewButton_Click(sender As Object, e As EventArgs) Handles UpdateReviewButton.Click
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
        MainForm.getContent(sender, e)
        MainForm.focus(False)
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
        If String.IsNullOrEmpty(myreviewTextBox.Text) Then
            MessageBox.Show("Please write a review!")
            Return
        End If
        ClearConnection()
        Dim tmp As New Integer
        tmp = ListBox1.SelectedIndex
        CN.Open()
        CMD.CommandText = "EXEC dbo.pr_GeneralAddReview @body = @body2 , @movie_id = @mid, @user_id = @uid"
        CMD.Parameters.Add(New SqlParameter("@mid", Globals.shared_movie.movie_id))
        CMD.Parameters.Add(New SqlParameter("@uid", Globals.user.id))
        CMD.Parameters.Add(New SqlParameter("@body2", myreviewTextBox.Text))
        Try
            CMD.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("There was an error when updating your rating.")
        Return
        End Try
        MessageBox.Show("Review updated!")
        MainForm.getContent(sender, e)
        MainForm.focus(False)
    End Sub

End Class