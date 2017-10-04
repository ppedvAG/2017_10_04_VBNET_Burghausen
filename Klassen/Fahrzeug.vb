Option Strict On

Public Class Fahrzeug

    Private _farbe As String        'Rot Blau Grün Gelb
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
            If value > 200 Then
                value = 200
            End If

            _geschwindigkeit = value
        End Set
    End Property

    Private _erstzulassung As Date
    Public Property Erstzulassung() As Date
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

    Public Sub Beschleunigen(dV As Integer)
        Geschwindigkeit += dV
    End Sub
    Public Sub Beschleunigen(faktor As Double)
        Geschwindigkeit = CInt(Geschwindigkeit * faktor)
    End Sub

    Public Sub Bremsen(dV As Integer)
        Geschwindigkeit -= dV
    End Sub

End Class
