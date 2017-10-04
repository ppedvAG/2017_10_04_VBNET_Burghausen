Option Strict On

Module Module1

    Sub Main()

        'Console.Write("Bitte geben Sie eine Zahl ein: ")
        'Dim eingabe = Integer.Parse(Console.ReadLine())

#Region "If ElseIf Else"
        'If eingabe > 5 Then
        '    Console.WriteLine("Die Eingabe war größer als 5")
        'ElseIf eingabe = 5 Then
        '    Console.WriteLine("Die Eingabe war gleich 5")
        'Else
        '    Console.WriteLine("Die Eingabe war kleiner als 5")
        'End If
#End Region

#Region "Select"

        'Select Case eingabe

        '    Case 5
        '        Console.WriteLine("Eingabe war 5")

        '    Case 6 To 10
        '        Console.WriteLine("Eingabe war 6...10")

        '    Case > 10
        '        Console.WriteLine("Eingabe war > 10")

        '    Case 1, 2, 3, 4
        '        Console.WriteLine("Eingabe war 1, 2, 3, 4")

        '    Case Else
        '        Console.WriteLine("Eingabe war irgend was anderes")

        'End Select

#End Region

#Region "While Schleife"

        'While eingabe < 100
        '    eingabe += 1

        '    If eingabe = 95 Then
        '        Continue While
        '    End If
        '    If eingabe = 98 Then
        '        Exit While
        '    End If

        '    Console.WriteLine(eingabe)
        'End While

#End Region

#Region "Do While Schleife"

        'Do
        '    eingabe += 1
        '    Console.WriteLine(eingabe)
        'Loop While eingabe < 100

#End Region

#Region "For Schleife"

        'For i = 99 To 0 Step -1
        '    Console.WriteLine(i)
        'Next

#End Region

#Region "For Each"

        Dim freunde = New List(Of String)
        freunde.Add("Siri")
        freunde.Add("Cortana")
        freunde.Add("Alexa")

        'For i = 0 To freunde.Count - 1 Step 1
        '    Console.WriteLine(freunde(i))
        'Next

        For Each f In freunde
            Console.WriteLine(f)
        Next
#End Region

        Console.ReadKey()
    End Sub

End Module
