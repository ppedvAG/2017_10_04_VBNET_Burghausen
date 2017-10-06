Module Module1

    Sub Main()

        Dim g = New Grafik()
        g.Farbe = "Rosa"
        g.Zeichnen()

        Dim l = New Linie()
        l.Farbe = "Rot"
        l.Länge = 7
        l.Zeichnen()

        Dim k = New Kreis()
        k.Farbe = "Grün"
        k.Radius = 2.12
        k.Zeichnen()
        Dim gk As Grafik = k
        gk.Zeichnen()

        Console.WriteLine()

        VerwendeGrafik(g)
        VerwendeGrafik(l)
        VerwendeGrafik(k)

        Console.ReadKey()
    End Sub


    Private Sub VerwendeGrafik(g As Grafik)
        g.Zeichnen()
    End Sub

End Module
