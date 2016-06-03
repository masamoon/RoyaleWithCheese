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
            DeleteReviewButton.Show()
        Else
            reviewTextBox.ReadOnly = True
            ratingTextBox.ReadOnly = True
            UpdateReviewButton.Hide()
            UpdateRatingButton.Hide()
            DeleteReviewButton.Hide()
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
        ClearConnection()
        CN.Open()
        CMD.CommandText = "EXEC dbo.pr_GeneralAddRating @rating = @rating4, @movie_id = @mid, @user_id = @uid"
        CMD.Parameters.Add(New SqlParameter("@mid", Globals.shared_movie.movie_id))
        CMD.Parameters.Add(New SqlParameter("@uid", Globals.user.id))
        CMD.Parameters.Add(New SqlParameter("@rating4", ratingTextBox.Text))
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

    Private Sub UpdateReviewButton_Click(sender As Object, e As EventArgs) Handles UpdateReviewButton.Click
        If String.IsNullOrEmpty(reviewTextBox.Text) Then
            MessageBox.Show("Please write a review!")
            Return
        End If
        ClearConnection()
        CN.Open()
        CMD.CommandText = "EXEC dbo.pr_GeneralAddReview @body = @body2 , @movie_id = @mid, @user_id = @uid"
        CMD.Parameters.Add(New SqlParameter("@mid", Globals.shared_movie.movie_id))
        CMD.Parameters.Add(New SqlParameter("@uid", Globals.user.id))
        CMD.Parameters.Add(New SqlParameter("@body2", reviewTextBox.Text))
        Try
            CMD.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("There was an error when updating your rating. Make sure you type a number from 1 to 10.")
            Return
        End Try
        MessageBox.Show("Review updated!")
        MainForm.getContent(sender, e)
        MainForm.focus(False)
    End Sub

    Private Sub DeleteReviewButton_Click(sender As Object, e As EventArgs) Handles DeleteReviewButton.Click
        ClearConnection()
        CN.Open()
        CMD.CommandText = "EXEC dbo.pr_DeleteReview @movie_id = @mid, @user_id = @uid"
        CMD.Parameters.Add(New SqlParameter("@mid", Globals.shared_movie.movie_id))
        CMD.Parameters.Add(New SqlParameter("@uid", Globals.user.id))
        Try
            CMD.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("There was an error when deleting your review.")
            Return
        End Try
        MainForm.getContent(sender, e)
        MainForm.focus(True)
        Me.Hide()
        MessageBox.Show("Review deleted.")

    End Sub
End Class