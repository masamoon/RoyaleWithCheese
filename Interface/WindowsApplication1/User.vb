Imports System.Data.SqlClient

Public Class User
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        CN = New SqlConnection(Globals.connectionPath)
        CMD = New SqlCommand

        CMD.Connection = CN
        CN.Open()

        CMD.CommandText = "SELECT dbo.IsFriend(@uid, @fid)"
        CMD.Parameters.Add(New SqlParameter("@uid", Globals.user.id))
        CMD.Parameters.Add(New SqlParameter("@fid", Globals.shared_usr.id))
        Dim result As Integer
        result = CMD.ExecuteScalar
        If result = 0 Then
            Button3.Show()
            Button4.Hide()
        Else
            Button3.Hide()
            Button4.Show()
        End If

        ClearConnection()
        CN.Open()
        CMD.CommandText = "SELECT * FROM dbo.GetUserInfo(@uid)"

        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.shared_usr.id

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        While RDR.Read
            Dim u As New Usr
            u.id = RDR.Item("id")

            u.username = RDR.Item("username")
            Username_box.Text = u.username
            u.fname = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("fname")), "", RDR.Item("fname")))
            u.lname = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("lname")), "", RDR.Item("lname")))
            fnameBox.Text = u.fname
            lnameBox.Text = u.lname
            u.location = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("location")), "", RDR.Item("location")))
            Location_box.Text = u.location
            u.email = RDR.Item("email")


        End While
        RDR.Close()
        CN.Close()

        CN = New SqlConnection(Globals.connectionPath)
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN

        ListBox1.Items.Clear()
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.HorizontalScrollbar = True
        ListBox2.Items.Clear()
        ListBox3.ScrollAlwaysVisible = True
        ListBox3.HorizontalScrollbar = True

        CMD.CommandText = "SELECT * FROM dbo.GetUsrMovieInfo(@id)"

        CMD.Parameters.Add("@id", SqlDbType.Int).Value = Globals.shared_usr.id
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


        CMD.CommandText = "SELECT * FROM dbo.GetUserLists(@uid)"

        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.shared_usr.id

        Dim RDR3 As SqlDataReader
        RDR3 = CMD.ExecuteReader
        While RDR3.Read
            ListBox2.Items.Add(RDR3.Item("name"))
        End While
        RDR3.Close()
        ClearConnection()
        CN.Open()
        CMD.CommandText = "SELECT * FROM dbo.GetFriends(@uid)"
        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.shared_usr.id
        RDR3 = CMD.ExecuteReader
        While RDR3.Read
            Dim u As New Usr
            u.id = RDR3.Item("id")
            u.username = RDR3.Item("username")
            u.fname = Convert.ToString(IIf(RDR3.IsDBNull(RDR3.GetOrdinal("fname")), "", RDR3.Item("fname")))
            u.lname = Convert.ToString(IIf(RDR3.IsDBNull(RDR3.GetOrdinal("lname")), "", RDR3.Item("lname")))
            u.location = Convert.ToString(IIf(RDR3.IsDBNull(RDR3.GetOrdinal("location")), "", RDR3.Item("location")))
            u.email = RDR3.Item("email")
            ListBox4.Items.Add(u)
        End While

        RDR3.Close()
        ClearConnection()
        CN.Open()
        CMD.CommandText = "SELECT * FROM dbo.GetSubsToUsers(@uid)"
        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.shared_usr.id
        RDR1 = CMD.ExecuteReader
        While RDR1.Read
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
            ListBox3.Items.Add(f)
        End While


        If Globals.shared_usr.username = Globals.user.username Then
            fnameBox.ReadOnly = False
            lnameBox.ReadOnly = False
            Button2.Show()
            Button3.Hide()
            Button4.Hide()
            Button5.Show()

        Else
            fnameBox.ReadOnly = True
            lnameBox.ReadOnly = True
            Button2.Hide()
            Button5.Hide()
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
            Dim mpage As New MoviePage
            mpage.Show()
            Me.Hide()
        End If
        If TabControl1.SelectedIndex = 1 Then
            If ListBox2.SelectedItem Is Nothing Then
                MessageBox.Show("No movie selected!")
                Return
            End If
            Globals.shared_movie = ListBox2.SelectedItem
            Dim mpage As New MoviePage
            mpage.Show()
            Me.Hide()
        End If
        If TabControl1.SelectedIndex = 2 Then
            If ListBox3.SelectedItem Is Nothing Then
                MessageBox.Show("No profile selected!")
                Return
            End If
            Globals.shared_fm = ListBox3.SelectedItem
            Dim fpage As New FilmmakerUser
            fpage.Show()
            Me.Hide()
        End If
        If TabControl1.SelectedIndex = 3 Then
            If ListBox4.SelectedItem Is Nothing Then
                MessageBox.Show("No profile selected!")
                Return
            End If
            Globals.shared_usr = ListBox4.SelectedItem
            Dim upage As New User
            upage.Show()
            Me.Hide()
        End If
    End Sub

    Public Sub User_FormClosed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.FormClosed
        Me.Hide()
        MainForm.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearConnection()
        CN.Open()
        CMD.CommandText = "EXEC dbo.pr_UpdateUsrInfo @fname = @fname2, @lname = @lname2, @uid = @uid2"
        CMD.Parameters.Add(New SqlParameter("@fname2", fnameBox.Text))
        CMD.Parameters.Add(New SqlParameter("@lname2", lnameBox.Text))
        CMD.Parameters.Add(New SqlParameter("@uid2", Globals.user.id))

        Try
            CMD.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("There was an error when updating your profile.")
            Return
        End Try
        MessageBox.Show("Profile updated!")
        MainForm.getContent(sender, e)
        MainForm.focus(False)
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClearConnection()
        CN.Open()
        CMD.CommandText = "EXEC dbo.pr_AddFriend @uid = @uid2, @fid = @fid2"
        CMD.Parameters.Add(New SqlParameter("@uid2", Globals.user.id))
        CMD.Parameters.Add(New SqlParameter("@fid2", Globals.shared_usr.id))
        Try
            CMD.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("There was an error when adding this person to your friendlist.")
            Return
        End Try
        MessageBox.Show("Your are now friends with " & Globals.shared_usr.username & "!")
        MainForm.getContent(sender, e)
        MainForm.focus(False)
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearConnection()
        CN.Open()
        CMD.CommandText = "EXEC dbo.pr_DelFriendship @uid = @uid2, @fid = @fid2"
        CMD.Parameters.Add(New SqlParameter("@uid2", Globals.user.id))
        CMD.Parameters.Add(New SqlParameter("@fid2", Globals.shared_usr.id))
        Try
            CMD.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("There was an error deleting this person from your friendlist.")
            Return
        End Try
        MessageBox.Show("Your are no longer friends with " & Globals.shared_usr.username & "!")
        MainForm.getContent(sender, e)
        MainForm.focus(False)
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MessageBox.Show("You will lose all your data. Are you sure you want to delete your account?", "Delete account?", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        Else
            ClearConnection()
            CN.Open()
            CMD.CommandText = "EXEC dbo.pr_DelUsr @uid = @uid2"
            CMD.Parameters.Add(New SqlParameter("@uid2", Globals.user.id))
            Try
                CMD.ExecuteNonQuery()
            Catch ex As System.Data.SqlClient.SqlException
                MessageBox.Show("There was an error deleting this person from your friendlist.")
                Return
            End Try
            MessageBox.Show("Account deleted!")
            MainForm.getContent(sender, e)
            MainForm.focus(False)
            Me.Hide()
            Dim log As New Login
            log.Show()
        End If
    End Sub
End Class