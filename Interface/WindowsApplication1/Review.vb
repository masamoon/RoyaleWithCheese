Imports System.Data.SqlClient


Public Class Review
    Inherits System.Windows.Forms.Form

    Public tmpUser As Usr
    Dim CN As New SqlConnection
    Dim CMD As New SqlCommand

    Public Sub New(ByVal user)
        ' This call is required by the designer.
        InitializeComponent()
        tmpUser = user
    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ratingTextBox.SelectionLength = 0
    End Sub

    Public Sub Review_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Globals.user.username = tmpUser.username Then
            reviewTextBox.ReadOnly = False
            ratingTextBox.ReadOnly = False
            UpdateReviewButton.Show()
            UpdateRatingButton.Show()
        Else
            reviewTextBox.ReadOnly = True
            ratingTextBox.ReadOnly = True
            UpdateReviewButton.Hide()
            UpdateRatingButton.Hide()
        End If
        nameLabel.Text = tmpUser.username & "'s review of " & Chr(34) & Globals.shared_movie.title & Chr(34)
        yearLabel.Text = Globals.shared_movie.year
        If Not String.IsNullOrEmpty(tmpUser.review) Then
            reviewTextBox.Text = tmpUser.review
        Else
            reviewTextBox.Text = "The user has not written a review."
        End If
        If Not tmpUser.rating = 0 Then
            ratingTextBox.Text = tmpUser.rating
        End If

    End Sub

    Public Sub Review_FormClosed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.FormClosed
        Me.Hide()
    End Sub

    Private Sub RatingTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ratingTextBox.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                  Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub UpdateRatingButton_Click(sender As Object, e As EventArgs) Handles UpdateRatingButton.Click
        If Globals.user.username IsNot tmpUser.username Then
            Return
        End If
        ClearConnection()
        Dim tmp As New Integer
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
            CMD.Parameters.Add(New SqlParameter("@rating", ratingTextBox.Text))
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
            CMD.Parameters.Add(New SqlParameter("@rating", ratingTextBox.Text))
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

    Private Sub UpdateReviewButton_Click(sender As Object, e As EventArgs) Handles UpdateReviewButton.Click
        ClearConnection()
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
            CMD.Parameters.Add(New SqlParameter("@body", reviewTextBox.Text))
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
            CMD.Parameters.Add(New SqlParameter("@body", reviewTextBox.Text))
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