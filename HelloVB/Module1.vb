Option Strict On

Module Module1

    Sub Main()
        Console.WriteLine("Mein Text")

        Dim text As String = "hallo"
        Dim textzeichen As Char = "X"c

        Dim einByte As Byte
        Dim kleineZahl As Short
        Dim zahl As Integer
        Dim großeZahl As Long

        Dim f As Single = 4.0F
        Dim d As Double = 4.0
        Dim metric As Decimal = 3.87D

        Dim bedingung As Boolean = True 'False

        ' Mathematische Operatoren
        zahl = 6 + 8
        zahl = 6 - 8
        zahl = 6 * 8
        'zahl = 13 / 5   ' Ergebnis: 3 -> gerundet
        zahl = 13 \ 5   ' Ergebnis: 2 -> Alles ab dem Komma abschneiden
        zahl = 14 Mod 5 ' Rest der ganzahligen Division

        ' Vergleichsoperatoren
        bedingung = 5 < 7
        bedingung = 5 <= 7
        bedingung = 5 > 7
        bedingung = 5 >= 7
        bedingung = 5 = 7
        bedingung = 5 <> 7
        bedingung = Not bedingung

        ' Verknüpfungsopertoren
        bedingung = 5 > 7 And 8 > 4         ' In C#: &
        bedingung = 5 > 7 AndAlso 8 > 4     ' In C#: &&

        bedingung = 5 < 7 Or 8 > 4          ' In C#: |
        bedingung = 5 < 7 OrElse 8 > 4      ' In C#: ||

        bedingung = 5 < 7 Xor 8 > 4


        Console.WriteLine("Das Ergebnis der Bedingung war: " & bedingung & ".")
        Console.WriteLine("Das Ergebnis der Bedingung war: {0}.", bedingung)
        Console.WriteLine($"Das Ergebnis der Bedingung war: {bedingung}.")

        Console.Write("Bite geben Sie eine Zahl ein: ")
        Dim eingabe As String = Console.ReadLine()

        zahl = Convert.ToInt32(eingabe)
        zahl = Integer.Parse(eingabe)

        Console.WriteLine($"Die Eingabe war: {zahl + 8}")

        Console.ReadKey()
    End Sub

End Module
