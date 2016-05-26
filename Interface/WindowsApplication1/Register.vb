Imports System.Data.SqlClient

Public Class Register
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If String.IsNullOrEmpty(UsernameBox.Text) Or String.IsNullOrEmpty(EmailBox.Text) Then
            MsgBox("Enter all required fields!")
        Else
            If Register() = True Then
                MsgBox("Your account has been created successfully!")
                Me.Close()
                Login.Show()
            Else
                MsgBox("An error occured!")
            End If
        End If
    End Sub


    Private Function Register()
        Dim u As New Usr
        Try
            u.username = UsernameBox.Text
            u.email = EmailBox.Text
            u.fname = FirstNameBox.Text
            u.lname = LastNameBox.Text
            u.location = ComboBox1.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim cn As New SqlConnection(Globals.connectionPath)

        Try
            cn.Open()
            Dim cmd As New SqlCommand()
            Dim accept As Integer

            Try
                If cn.State = ConnectionState.Open Then

                    cmd.Connection = cn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "SELECT dbo.Username_Exists(@username)"
                    cmd.Parameters.Add(New SqlParameter("@username", u.username))
                    accept = cmd.ExecuteScalar()
                    If accept = 1 Then
                        MsgBox("That username as already been choosen!")
                        UsernameBox.Clear()
                        UsernameBox.Focus()

                        Return False
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            cn.Open()

            Try
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT dbo.Email_Exists(@email)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@email", u.email))
                accept = cmd.ExecuteScalar()
                If accept = 1 Then
                    MsgBox("There already is an account associated with that email address!")
                    EmailBox.Clear()
                    EmailBox.Focus()

                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            cmd.CommandText = "SELECT TOP 1 * FROM Usr ORDER BY id DESC"
            cn.Open()
            Dim id As Integer
            Try
                Dim RDR1 As SqlDataReader
                RDR1 = cmd.ExecuteReader
                While RDR1.Read
                    id = RDR1.Item("id") + 1
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            cn.Dispose()
            cmd.Dispose()
            cn.ConnectionString = Globals.connectionPath

            cmd.CommandText = "INSERT INTO Usr (id, username, fname, lname, location, email) VALUES (@id, @username, @fname, @lname, @location, @email)"
            cn.Open()
            Try
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = UsernameBox.Text
                If Not String.IsNullOrEmpty(FirstNameBox.Text) Then
                    cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = FirstNameBox.Text
                Else
                    cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = DBNull.Value
                End If
                If Not String.IsNullOrEmpty(LastNameBox.Text) Then
                    cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = LastNameBox.Text
                Else
                    cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = DBNull.Value
                End If
                If Not String.IsNullOrEmpty(ComboBox1.Text) Then
                    cmd.Parameters.Add("@location", SqlDbType.VarChar).Value = ComboBox1.Text
                Else
                    cmd.Parameters.Add("@location", SqlDbType.VarChar).Value = DBNull.Value
                End If
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = EmailBox.Text
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            Globals.user = u


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Sub Register_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim file As String
        Dim arr() As String
        Dim count As Integer
        file = My.Resources.countries
        arr = file.Split(Environment.NewLine)
        For count = 0 To arr.Length - 1
            ComboBox1.Items.Add(arr(count))
        Next
    End Sub

    Private Sub a_Click(sender As Object, e As EventArgs) Handles a.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Register_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Show()
    End Sub
End Class