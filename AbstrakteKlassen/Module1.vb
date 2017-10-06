Module Module1

    Sub Main()

        'Dim x = New Grafik()

        Dim k = New Kreis()
        Dim l = New Linie()

        Verwende(k)
        Verwende(l)


        Dim grafiken = New List(Of Grafik)
        grafiken.Add(k)
        grafiken.Add(l)

        For Each g In grafiken
            g.Zeichnen()
        Next

        Console.ReadKey()

    End Sub

    Private Sub Verwende(g As Grafik)
        g.Zeichnen()
    End Sub

End Module
