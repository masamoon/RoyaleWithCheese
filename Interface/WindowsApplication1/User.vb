Imports System.Data.SqlClient

Public Class User
    Dim CN As SqlConnection
    Dim CMD As SqlCommand

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Fullname_box.TextChanged

    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        CN = New SqlConnection("data source=DESKTOP-QMMOJTU\SQLEXPRESS;integrated security=true;initial catalog=mov")
        CMD = New SqlCommand
        CN.Open()
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM Usr WHERE id=@uid"

        CMD.Parameters.Add("@uid", SqlDbType.Int).Value = 1

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        While RDR.Read
            Dim u As New Usr
            u.id = RDR.Item("id")

            u.username = RDR.Item("username")
            Username_box.Text = u.username
            u.fname = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("fname")), "", RDR.Item("fname")))
            u.lname = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("lname")), "", RDR.Item("lname")))
            Fullname_box.Text = u.fname + " " + u.lname
            u.location = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("location")), "", RDR.Item("location")))
            Location_box.Text = u.location


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


    End Sub

    Private Sub ClearConnection()
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
        CN.ConnectionString = "data source=DESKTOP-QMMOJTU\SQLEXPRESS;integrated security=true;initial catalog=mov"
        CMD.Connection = CN
        CMD.Parameters.Clear()
    End Sub

    Private Sub Reviews_Click(sender As Object, e As EventArgs) Handles Reviews.Click




    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class