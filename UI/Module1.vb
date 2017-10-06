Imports Logik
Imports Tynamix.ObjectFiller

Module Module1

    Sub Main()

        Console.Write("Bitte geben sie eine Temperatur in °C ein: ")
        Dim input = Console.ReadLine()
        Dim celsius = Double.Parse(input)

        Dim converter = New TemperaturConverter()

        Dim fahrenheit = converter.CelsiusToFahrenheit(celsius)

        Console.WriteLine($"In Fahrenheit sind das: {fahrenheit}°")

        Dim fahrzeugfiller As New Filler(Of Fahrzeug)
        fahrzeugfiller.Setup() _
            .OnProperty(Function(f) f.Farbe).Use(New RandomListItem(Of String)("Rot", "Blau", "Grün")) _
            .OnProperty(Function(f) f.Geschwindigkeit).Use(New IntRange(0, 200)) _
            .OnProperty(Function(f) f.Fahrer).Use(New RealNames(NameStyle.FirstNameLastName))

        Dim autos = fahrzeugfiller.Create(50)

        For Each a In autos
            Console.WriteLine($"{a.Fahrer,-25} | {a.Farbe,-4} | {a.Geschwindigkeit,3} km/h")
        Next

        Console.ReadKey()
    End Sub

End Module
