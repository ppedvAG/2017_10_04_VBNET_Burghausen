Public Class Fahrzeug

    Private _geschwindigkeit As Integer
    Public Property Geschwindigkeit As Integer
        Get
            Return _geschwindigkeit
        End Get
        Set(ByVal value As Integer)
            _geschwindigkeit = value
        End Set
    End Property

End Class
