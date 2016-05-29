Public Class Usr

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Private _username As String
    Public Property username() As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Private _fname As String
    Public Property fname() As String
        Get
            Return _fname
        End Get
        Set(value As String)
            _fname = value
        End Set
    End Property

    Private _lname As String
    Public Property lname() As String
        Get
            Return _lname
        End Get
        Set(value As String)
            _lname = value
        End Set
    End Property

    Private _location As String
    Public Property location() As String
        Get
            Return _location
        End Get
        Set(value As String)
            _location = value
        End Set
    End Property

    Private _email As String
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Private _review As String
    Public Property review() As String
        Get
            Return _review
        End Get
        Set(value As String)
            _review = value
        End Set
    End Property

    Private _rating As Integer
    Public Property rating() As Integer
        Get
            Return _rating
        End Get
        Set(value As Integer)
            _rating = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _username
    End Function

End Class
