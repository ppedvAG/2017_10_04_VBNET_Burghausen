Module Module1

    Sub Main()

#Region "Übung 1"
        'Console.Write("Bitte geben sie ein Ergebnis ein: ")
        'Dim eingabe = Integer.Parse(Console.ReadLine())

        'If (eingabe > 6) Then
        '    Console.WriteLine("Der Test wurde bestanden.")
        'Else
        '    Console.WriteLine("Der Test wurde leider nicht bestanden.")
        'End If
#End Region

#Region "Übung 2"

        'While True

        '    Console.Write("Bitte geben sie ein Ergebnis ein: ")
        '    Dim eingabe = Integer.Parse(Console.ReadLine())

        '    If eingabe = -1 Then Exit While

        '    If eingabe < 0 OrElse eingabe > 10 Then
        '        Console.WriteLine("Ungültige Eingabe.")
        '    ElseIf eingabe > 6 Then
        '        Console.WriteLine("Der Test wurde bestanden.")
        '    Else
        '        Console.WriteLine("Der Test wurde leider nicht bestanden.")
        '    End If

        'End While
#End Region

#Region "Übung 3"

        While True
            Dim eingabe = Console.ReadLine()

            Select Case eingabe
                Case "-1" : Exit While

                Case "0", "1", "2", "3", "4", "5", "6" : Console.WriteLine("Der Test wurde leider nicht bestanden.")

                Case "7" : Console.WriteLine("Genügend")
                Case "8" : Console.WriteLine("Befriedigend")
                Case "9" : Console.WriteLine("Gut")
                Case "10" : Console.WriteLine("Sehr Gut")

                Case Else : Console.WriteLine("Ungültige Eingabe")
            End Select
        End While

#End Region

    End Sub

End Module
