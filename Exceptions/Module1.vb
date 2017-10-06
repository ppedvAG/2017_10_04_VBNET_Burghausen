Option Strict On

Module Module1

    Sub Main()

        Try

            Dim zahl1 = Integer.Parse(Console.ReadLine())
            Dim zahl2 = Integer.Parse(Console.ReadLine())

            If zahl1 = 6 OrElse zahl2 = 6 Then
                Throw New MustNotBe6Exception("Es darf nicht 6 eingegeben werden!!")
            End If

            Dim ergebnis = zahl1 + zahl2

            Console.WriteLine(ergebnis)

        Catch ex As FormatException

            Console.WriteLine("Bitte nur Zahlen eingeben.")
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)

        Catch ex As OverflowException

            Console.WriteLine("Bitte keine zu großen Zahlen eingeben.")
            Console.WriteLine(ex.Message)

        Catch ex As Exception
            Console.WriteLine(ex.Message)

        End Try

        Console.ReadLine()

    End Sub

End Module