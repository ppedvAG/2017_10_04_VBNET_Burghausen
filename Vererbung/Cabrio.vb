Public Class Cabrio
    Inherits Pkw

    Public Sub New(farbe As String)
        MyBase.New(farbe)
    End Sub

    Private _dachart As String
    Public Property Dachart As String
        Get
            Return _dachart
        End Get
        Set(value As String)
            _dachart = value
        End Set
    End Property
End Class
