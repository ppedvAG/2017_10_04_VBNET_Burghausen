Public Class Kreis
    Inherits Grafik

    Public Property Radius As Double

    Public Overrides Sub Zeichnen()
        Console.WriteLine($"Zeichne Kreis in der Farbe {Farbe} mit einem Radius von {Radius}.")
        'MyBase.Zeichnen()
    End Sub

End Class
