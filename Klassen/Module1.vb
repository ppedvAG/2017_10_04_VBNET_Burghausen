Module Module1

    Sub Main()

        Dim f As Fahrzeug = New Fahrzeug()
        Dim f2 = New Fahrzeug()

        f.Erstzulassung = New Date(year:=2010, month:=9, day:=20)
        f.Geschwindigkeit = 2147000000
        f.Farbe = "Blau"
        f.Bremsen(50)


        f2.Erstzulassung = New Date(year:=2015, month:=1, day:=13)
        f2.Geschwindigkeit = 100
        f2.Farbe = "Lila"
        f2.Beschleunigen(30)
        f2.Beschleunigen(1.1)

        Console.WriteLine(f.Geschwindigkeit)
        Console.WriteLine(f.Farbe)
        Console.WriteLine(f2.Geschwindigkeit)
        Console.WriteLine(f2.Farbe)

        Console.ReadKey()
    End Sub

End Module
