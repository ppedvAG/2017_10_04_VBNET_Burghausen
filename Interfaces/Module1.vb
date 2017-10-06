Module Module1

    Sub Main()

        Using f As New Fahrzeug()           'IDisposable

            Lackieren(f)

        End Using


    End Sub

    Public Sub Lackieren(irgendwas As ILackierbar)
        irgendwas.Farbe = "Schwarz"
    End Sub

End Module
