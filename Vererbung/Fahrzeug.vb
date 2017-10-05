Option Strict On

Public Class Fahrzeug

    Public Const MaxGeschwindigkeit As Integer = 200

    Public Sub New(farbe As String)
        Me.Farbe = farbe
    End Sub

    Private _farbe As String
    Public Property Farbe As String
        Get
            Return _farbe
        End Get
        Set(value As String)
            _farbe = value
        End Set
    End Property


    Private _geschwindigkeit As Integer      'Feld
    Public Property Geschwindigkeit As Integer
        Get
            Return _geschwindigkeit
        End Get
        Set(value As Integer)
            If value > MaxGeschwindigkeit Then
                value = MaxGeschwindigkeit
            End If

            _geschwindigkeit = value
        End Set
    End Property

    ''' <summary>
    ''' Beschleunigt das Fahrzeug um einen übergebenen Wert.
    ''' </summary>
    ''' <param name="dV">Die Geschwindigkeitsänderung.</param>
    Public Sub Beschleunigen(dV As Integer)
        Geschwindigkeit += dV
    End Sub

    ''' <summary>
    ''' Beschleunigt das Fahrzeug um einen übergebenen Faktor.
    ''' Die Geschwindigkeit wird mit dem Faktor multipliziert.
    ''' </summary>
    ''' <param name="faktor">Die Geschwindigkeitsänderung.</param>
    Public Sub Beschleunigen(faktor As Double)
        Geschwindigkeit = CInt(Geschwindigkeit * faktor)
    End Sub

    Public Sub Bremsen(dV As Integer)
        Geschwindigkeit -= dV
    End Sub
End Class
