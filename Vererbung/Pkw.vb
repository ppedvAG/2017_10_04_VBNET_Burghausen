Option Strict On

Public Class Pkw
    Inherits Fahrzeug

    Public Sub New(farbe As String)
        MyBase.New(farbe)
    End Sub

    Private _sitzplätze As Integer
    Public Property Sitzplätze As Integer
        Get
            Return _sitzplätze
        End Get
        Set(value As Integer)
            _sitzplätze = value
        End Set
    End Property

End Class
