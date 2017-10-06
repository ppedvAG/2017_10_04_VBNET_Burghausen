Option Strict On

Public Class Fahrzeug

    Public Const MaxGeschwindigkeit As Integer = 200

    Public Sub New(farbe As String)
        Me.Farbe = farbe
    End Sub
    Public Sub New(geschwindigkeit As Integer)
        Me.Geschwindigkeit = geschwindigkeit
    End Sub
    Public Sub New(farbe As String, geschwindigkeit As Integer)
        Me.New(farbe)
        Me.Geschwindigkeit = geschwindigkeit
    End Sub
    Public Sub New(farbe As String, geschwindigkeit As Integer, erstzulassung As Date)
        Me.New(farbe, geschwindigkeit)
        Me.Erstzulassung = erstzulassung
    End Sub

    Private _farbe As String
    Public Property Farbe As String
        Get
            Return _farbe
        End Get
        Set(value As String)
            Select Case value
                Case "Rot", "Blau", "Grün", "Gelb"
                    _farbe = value
                Case Else
                    _farbe = "Ungültig"
            End Select
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

    Private _erstzulassung As Date
    ''' <summary>
    ''' Die Erstzulassung des Fahrzeugs.
    ''' </summary>
    Public Property Erstzulassung As Date
        Get
            Return _erstzulassung
        End Get
        Set(ByVal value As Date)
            _erstzulassung = value
        End Set
    End Property

#Region "Datenkapselung in Java"
    'Public Function GetGeschwindigkeit() As Integer
    '    Return _geschwindigkeit
    'End Function
    'Public Sub SetGeschwindigkeit(geschwindigkeit As Integer)
    '    If geschwindigkeit > 200 Then
    '        geschwindigkeit = 200
    '    End If

    '    _geschwindigkeit = geschwindigkeit
    'End Sub
#End Region

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

    Protected Overrides Sub Finalize() ' Destruktor

    End Sub

End Class
