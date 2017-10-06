Public Class Fahrzeug
    Implements ILackierbar, IDisposable

    Public Property Geschwindigkeit As Integer

    Public Property Farbe As String Implements ILackierbar.Farbe

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Verbindungen etc schließen und aufräumen
    End Sub
End Class
