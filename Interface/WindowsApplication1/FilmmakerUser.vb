Imports System.Data.SqlClient

Public Class FilmmakerUser
    Dim CN As SqlConnection
    Dim CMD As SqlCommand

    Private Sub FilmmakerUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection(Globals.connectionPath)
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN
        CMD.CommandText = "SELECT dbo.IsSubscribed(@uid, @fid)"
        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.user.id
        CMD.Parameters.Add("@fid", SqlDbType.Int).Value = Globals.shared_fm.user_id
        Dim result As Integer
        result = CMD.ExecuteScalar
        If result = 1 Then
            ClearConnection()
            CN.Open()
            CMD.Connection = CN
            CMD.CommandText = "SELECT dbo.GetReward(@uid, @fid)"
            CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.user.id
            CMD.Parameters.Add("@fid", SqlDbType.Int).Value = Globals.shared_fm.user_id
            Dim reward As Integer
            reward = CMD.ExecuteScalar
            rewardTextBox.Text = reward
            UnsubscribeButton.Show()
            RewardLabel.Show()
            rewardTextBox.Show()
            UpdateRewardButton.Show()
            SubscribeButton.Hide()
        Else
            UnsubscribeButton.Hide()
            RewardLabel.Hide()
            rewardTextBox.Hide()
            UpdateRewardButton.Hide()
            SubscribeButton.Show()
        End If
        ClearConnection()
        CN.Open()
        CMD.CommandText = "SELECT * FROM dbo.GetFilmmaker(@uid)"

        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.shared_fm.user_id

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



        ListBox1.Items.Clear()
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.HorizontalScrollbar = True
        ListBox2.Items.Clear()
        ListBox3.ScrollAlwaysVisible = True
        ListBox3.HorizontalScrollbar = True

        ClearConnection()

        CN.Open()
        CMD.CommandText = "SELECT * FROM dbo.GetUsrMovieInfo(@uid)"

        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.shared_fm.user_id

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
            If (Not IsDBNull(RDR1.Item("avg_rating"))) Then
                m.avg_rating = Convert.ToInt16(IIf(RDR1.IsDBNull(RDR1.GetOrdinal("avg_rating")), "", RDR1.Item("avg_rating")))
            End If
            ListBox1.Items.Add(m)


        End While
        RDR1.Close()
        CN.Close()

        CN = New SqlConnection(Globals.connectionPath)
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN


        CMD.CommandText = "SELECT * FROM List WHERE user_id=@uid"

        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.user.id

        Dim RDR3 As SqlDataReader
        RDR3 = CMD.ExecuteReader
        While RDR3.Read
            ListBox2.Items.Add(RDR3.Item("name"))
        End While

        RDR3.Close()
        CN.Close()

        CN = New SqlConnection(Globals.connectionPath)
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM dbo.GetAllParticipations(@fid)"
        CMD.Parameters.Add("@fid", SqlDbType.Int).Value = Globals.shared_fm.id
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


        CN = New SqlConnection(Globals.connectionPath)
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM dbo.GetRolesG(@fid)"

        CMD.Parameters.Add("@fid", SqlDbType.Int).Value = Globals.shared_fm.id

        Dim RDR5 As SqlDataReader
        RDR5 = CMD.ExecuteReader
        While RDR5.Read
            ListBox5.Items.Add(RDR5.Item("role_name"))
        End While

        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = 0
        End If
        If ListBox2.Items.Count > 0 Then
            ListBox1.SelectedIndex = 0
        End If
        If ListBox3.Items.Count > 0 Then
            ListBox1.SelectedIndex = 0
        End If
        If ListBox4.Items.Count > 0 Then
            ListBox1.SelectedIndex = 0
        End If
        If ListBox5.Items.Count > 0 Then
            ListBox1.SelectedIndex = 0
        End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Or TabControl1.SelectedIndex = 3 Then
            Button1.Show()
        Else
            Button1.Hide()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TabControl1.SelectedIndex = 0 Then
            If ListBox1.SelectedItem Is Nothing Then
                MessageBox.Show("No movie selected!")
                Return
            End If
            Globals.shared_movie = ListBox1.SelectedItem
        Else
            If ListBox4.SelectedItem Is Nothing Then
                MessageBox.Show("No movie selected!")
                Return
            End If
            Globals.shared_movie = ListBox4.SelectedItem
        End If
        Dim mpage As New MoviePage
        Me.Hide()
        mpage.Show()

    End Sub

    Private Sub rewardTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rewardTextBox.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                  Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Public Sub FilmmakerUser_FormClosed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.FormClosed
        Me.Hide()
        Dim m As New MainForm
        m.Show()
    End Sub

    Private Sub SubscribeButton_Click(sender As Object, e As EventArgs) Handles SubscribeButton.Click
        ClearConnection()
        CN.Open()
        CMD.CommandText = "EXEC dbo.pr_AddSubs @uid = @uid2, @fid = @fid2, @reward = @reward2"
        CMD.Parameters.Add(New SqlParameter("@uid2", Globals.user.id))
        CMD.Parameters.Add(New SqlParameter("@fid2", Globals.shared_fm.user_id))
        CMD.Parameters.Add(New SqlParameter("@reward2", 0))
        Try
            CMD.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("There was an error when subscribing.")
            Return
        End Try
        MainForm.getContent(sender, e)
        MainForm.focus(True)
        Me.Hide()
        MessageBox.Show("Subsctiption successful!")
        Dim m As New MainForm
        m.Show()
    End Sub

    Private Sub UnsubscribeButton_Click(sender As Object, e As EventArgs) Handles UnsubscribeButton.Click
        ClearConnection()
        CN.Open()
        CMD.CommandText = "EXEC dbo.pr_DelSubs @uid = @uid2, @fid = @fid2"
        CMD.Parameters.Add(New SqlParameter("@uid2", Globals.user.id))
        CMD.Parameters.Add(New SqlParameter("@fid2", Globals.shared_fm.user_id))
        Try
            CMD.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("There was an error when unsubscribing.")
            Return
        End Try
        MainForm.getContent(sender, e)
        MainForm.focus(True)
        Me.Hide()
        MessageBox.Show("Unsubsctiption successful!")
        Dim m As New MainForm
        m.Show()
    End Sub

    Private Sub UpdateRewardButton_Click(sender As Object, e As EventArgs) Handles UpdateRewardButton.Click
        ClearConnection()
        CN.Open()
        CMD.CommandText = "EXEC dbo.pr_UpdateSubs @uid = @uid2, @fid = @fid2, @reward = @reward2"
        CMD.Parameters.Add(New SqlParameter("@uid2", Globals.user.id))
        CMD.Parameters.Add(New SqlParameter("@fid2", Globals.shared_fm.user_id))
        CMD.Parameters.Add(New SqlParameter("@reward2", rewardTextBox.Text))
        Try
            CMD.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("There was an error when updating the reward.")
            Return
        End Try
        MainForm.getContent(sender, e)
        MainForm.focus(True)
        Me.Hide()
        MessageBox.Show("Reward updated!")
        Dim m As New MainForm
        m.Show()
    End Sub
End Class