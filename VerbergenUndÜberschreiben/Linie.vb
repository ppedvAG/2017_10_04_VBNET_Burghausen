Public Class Linie
    Inherits Grafik

    Public Property Länge As Integer

    ' Verbergen
    Public Overloads Sub Zeichnen()
        Console.WriteLine($"Zeichne Linie in der Fabe {Farbe} mit einer Länge von  {Länge}.")
    End Sub

End Class
