Option Strict On

Public Class Grafik

    Public Property Farbe As String

    Public Overridable Sub Zeichnen()
        Console.WriteLine($"Zeichne Grafik in der Farbe {Farbe}.")
    End Sub

End Class
