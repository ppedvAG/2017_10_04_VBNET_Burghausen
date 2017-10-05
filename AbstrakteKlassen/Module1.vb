Module Module1

    Sub Main()

        'Dim x = New Grafik()

        Dim k = New Kreis()
        Dim l = New Linie()

        Verwende(k)
        Verwende(l)

        Console.ReadKey()

    End Sub

    Private Sub Verwende(g As Grafik)
        g.Zeichnen()
    End Sub

End Module
