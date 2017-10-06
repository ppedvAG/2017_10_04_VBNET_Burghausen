Module Module1

    Sub Main()

        Dim b1 = New Bruchzahl(7, 9)
        Dim b2 = New Bruchzahl(3, 4)

        Dim ergebnis = b1 * 2

        Console.WriteLine($"{b1} * {b2} = {ergebnis}")
        Console.ReadLine()
    End Sub

End Module
