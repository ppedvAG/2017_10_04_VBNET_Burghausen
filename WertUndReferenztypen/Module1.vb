Module Module1

    Sub Main()
        ' Objekte von Strukturen sind immer Werttypen
        ' Objekte von Klassen sind immer Referenztypen
        ' Einzige Ausnahme: class String!

        Console.WriteLine("----- Werttypen -----")

        Dim i As Integer = 10
        Dim j As Integer = i

        Console.WriteLine($"I: {i}")
        Console.WriteLine($"J: {j}")

        Console.WriteLine("J ändern")
        j = 50
        Console.WriteLine($"I: {i}")
        Console.WriteLine($"J: {j}")


        Console.WriteLine($"{vbNewLine}{vbNewLine}")

        Console.WriteLine("----- Referenztypen -----")

        Dim pkw As Fahrzeug = New Fahrzeug()
        pkw.Geschwindigkeit = 80
        Dim bus As Fahrzeug = pkw

        Console.WriteLine($"PKW: {pkw.Geschwindigkeit}")
        Console.WriteLine($"Bus: {bus.Geschwindigkeit}")

        Console.WriteLine("Bus beschleunigen")
        bus.Geschwindigkeit = 120

        Console.WriteLine($"PKW: {pkw.Geschwindigkeit}")
        Console.WriteLine($"Bus: {bus.Geschwindigkeit}")


        Console.ReadLine()
    End Sub

End Module
