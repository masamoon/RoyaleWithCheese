Public Class Filmmaker
    Inherits Usr


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


End Class
