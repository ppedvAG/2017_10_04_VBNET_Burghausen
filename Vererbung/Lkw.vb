Option Strict On

Public Class Lkw
    Inherits Fahrzeug

    Public Sub New(farbe As String)
        MyBase.New(farbe)
    End Sub

    Private _maxLadung As Integer
    Public Property MaxLadung As Integer
        Get
            Return _maxLadung
        End Get
        Set(ByVal value As Integer)
            _maxLadung = value
        End Set
    End Property

End Class
