Imports System.Data.SqlClient

Public Class Movie

    Private _movie_id As Integer
    Public Property movie_id() As Integer
        Get
            Return _movie_id
        End Get
        Set(value As Integer)
            _movie_id = value
        End Set
    End Property

    Private _title As String
    Public Property title() As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Private _synopsis As String
    Public Property synopsis() As String
        Get
            Return _synopsis
        End Get
        Set(value As String)
            _synopsis = value
        End Set
    End Property

    Private _studio As String
    Public Property studio() As String
        Get
            Return _studio
        End Get
        Set(value As String)
            _studio = value
        End Set
    End Property

    Private _country As String
    Public Property country() As String
        Get
            Return _country
        End Get
        Set(value As String)
            _country = value
        End Set
    End Property

    Private _poster As String
    Public Property poster() As String
        Get
            Return _poster
        End Get
        Set(value As String)
            _poster = value
        End Set
    End Property

    Private _runtime As Integer
    Public Property runtime() As Integer
        Get
            Return _runtime
        End Get
        Set(value As Integer)
            _runtime = value
        End Set
    End Property

    Private _year As Integer
    Public Property year() As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
        End Set
    End Property

    Private _genres As String
    Public Property genres() As String
        Get
            Return _genres
        End Get
        Set(value As String)
            _genres = value
        End Set
    End Property

    Private _user_rating As Integer
    Public Property user_rating() As Integer
        Get
            Return _user_rating
        End Get
        Set(value As Integer)
            _user_rating = value
        End Set
    End Property

    Private Function getGenres()
        Dim CN As New SqlConnection(Globals.connectionPath)
        Dim CMD As New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "select dbo.GetGenre(@movie_id)"
        CMD.CommandType = CommandType.Text
        CMD.Parameters.Add(New SqlParameter("@movie_id", _movie_id))
        Dim genre As String
        genre = ""
        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                genre += CMD.ExecuteScalar
            End If
        Catch ex As Exception
            MsgBox("ExecQuery Error: " & vbNewLine & ex.Message)
        End Try
        _genres = genre

        If CN.State = ConnectionState.Open Then
            CN.Close()
        End If
        Return True
    End Function

    Overrides Function ToString() As String
        If String.IsNullOrEmpty(_genres) Then
            getGenres()
        End If
        If _user_rating = 0 Then
            Return _movie_id & vbTab & _title & " (" & _year & ")"
        Else
            Return _movie_id & vbTab & _title & " (" & _year & ")" & Convert.ToChar(Keys.Tab) & Convert.ToChar(Keys.Tab) & _user_rating
        End If

    End Function

End Class
