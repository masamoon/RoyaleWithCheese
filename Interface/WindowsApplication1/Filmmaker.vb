Public Class Filmmaker

    Private _id As Integer
    Public Property id As Integer
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

    Private _biography As String
    Public Property biography() As String
        Get
            Return _biography
        End Get
        Set(value As String)
            _biography = value
        End Set
    End Property

    Private _birthdate As Date
    Public Property birthdate() As Date
        Get
            Return _birthdate
        End Get
        Set(value As Date)
            _birthdate = value
        End Set
    End Property

    Private _roles As List(Of String)
    Public Property roles() As List(Of String)
        Get
            Return _roles
        End Get
        Set(value As List(Of String))
            _roles = value
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

    Private _hasAccount As Boolean
    Public Property hasAccount() As Boolean
        Get
            Return _hasAccount
        End Get
        Set(value As Boolean)
            _hasAccount = value
        End Set
    End Property

    Private _user_id As Integer
    Public Property user_id() As Integer
        Get
            Return _user_id
        End Get
        Set(value As Integer)
            _user_id = value
        End Set
    End Property




    Overrides Function ToString() As String
        Return fname & " " & lname
    End Function
End Class
