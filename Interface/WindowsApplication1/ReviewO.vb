Public Class ReviewO
    Private _id As Integer
    Private _movie_id As Integer
    Private _body As String
    Private _user_id As Integer
    Private _rating As Integer

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property movie_id() As Integer
        Get
            Return _movie_id
        End Get
        Set(value As Integer)
            _movie_id = value
        End Set
    End Property

    Public Property body() As Integer
        Get
            Return _body
        End Get
        Set(value As Integer)
            _body = value
        End Set
    End Property

    Public Property user_id() As Integer
        Get
            Return _user_id
        End Get
        Set(value As Integer)
            _user_id = value
        End Set
    End Property

    Public Property rating() As Integer
        Get
            Return _rating
        End Get
        Set(value As Integer)
            _rating = value
        End Set
    End Property

End Class