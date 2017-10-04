Option Strict On

Module Module1

    Sub Main()

        Dim ergebnis = MeineMethode(8, 9.3)
        Console.WriteLine(ergebnis)

        ' Parameter benennen
        ergebnis = MeineMethode(zahl:=8, wert:=9.4)
        ergebnis = MeineMethode(8, wert:=9.4)
        ergebnis = MeineMethode(wert:=9.4, zahl:=8)

        ' Optionale Parameter
        OptionaleParameter(49.0, 100, "Hallo")
        OptionaleParameter(49.0, 100)
        OptionaleParameter(0.0)
        OptionaleParameter(9.7, text:="Blablabla")

        ' Referenzparameter
        Dim i = 50
        RefrenzParameter(i)
        Console.WriteLine(i)

        ' Param Array
        'Dim x(4) As Integer
        'x(0) = 1
        ParamsArray(7, 9, 0, 0, 0, 4, 2, 3, 6, 8)

        ' Methoden überladen
        MeineMethode(8)
        MeineMethode(9, 8.7)
        MeineMethode(9, 9)

        ' Übung SwapText
        Dim text1 = "Hallo"
        Dim text2 = "Welt"

        Console.WriteLine(text1)    ' Hallo
        Console.WriteLine(text2)    ' Welt

        SwapText(text1, text2)

        Console.WriteLine(text1)    ' Welt
        Console.WriteLine(text2)    ' Hallo

        Console.WriteLine("Primzahlen")
        For i = 0 To 1000
            If IsPrime(i) Then
                Console.WriteLine(i)
            End If
        Next


        Console.ReadLine()
    End Sub

    Private Function IsPrime(value As Integer) As Boolean
        If value < 2 Then Return False

        If value = 2 Then Return True

        For i = 2 To (value \ 2) + 1 Step 1
            If value Mod i = 0 Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub SwapText(ByRef s1 As String, ByRef s2 As String)
        Dim temp = s1
        s1 = s2
        s2 = temp
    End Sub

    Private Function MeineMethode(zahl As Integer, wert As Double) As String
        Return (zahl + wert).ToString()
    End Function
    Private Function MeineMethode(zahl As Integer) As String
        Return MeineMethode(zahl, 0)
    End Function

    Private Sub OptionaleParameter(wert As Double, Optional zahl As Integer = 1000, Optional text As String = "")
    End Sub

    Private Sub RefrenzParameter(ByRef zahl As Integer)
        zahl += 100
    End Sub

    Private Sub ParamsArray(ParamArray werte As Integer())
        For Each i In werte
            Console.WriteLine(i)
        Next
    End Sub

End Module
