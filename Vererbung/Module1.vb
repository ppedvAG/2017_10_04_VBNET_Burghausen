Module Module1

    Sub Main()

        Dim f = New Fahrzeug("Blau")
        f.Geschwindigkeit = 50
        f.Beschleunigen(10)
        f.Bremsen(20)

        Dim p = New Pkw("Rot")
        p.Geschwindigkeit = 50
        p.Sitzplätze = 5
        p.Beschleunigen(10)
        p.Bremsen(20)

        Dim l = New Lkw("Grün")
        l.Geschwindigkeit = 50
        l.MaxLadung = 18000
        l.Beschleunigen(10)
        l.Bremsen(20)

        Dim c = New Cabrio("Gelb")
        c.Geschwindigkeit = 170
        c.Beschleunigen(30)

        Waschen(f)
        Waschen(p)
        Waschen(l)
        Waschen(c)

        Lackieren(f)
        Lackieren(p)
        Lackieren(l)
        Lackieren(c)

    End Sub


    Public Sub Waschen(f As Fahrzeug)
        ' mein Waschvorgang
        f.Farbe = "gewaschenes " & f.Farbe
    End Sub
    Public Sub Lackieren(f As Fahrzeug)
        f.Farbe = "Schwarz"
    End Sub
End Module
