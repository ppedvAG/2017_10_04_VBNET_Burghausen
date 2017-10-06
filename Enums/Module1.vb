Option Strict On

Imports System.Windows.Forms

Module Module1

    Sub Main()

        Dim tag = GetToday()

        Select Case tag
            Case Wochentag.Freitag
                Console.WriteLine("Juhu bald ist Wochenende!! :D")

        End Select

        While True
            Dim result As DialogResult = MessageBox.Show("Ein unerwarteter Fehler ist aufgetreten!", "Achtung!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

            Select Case result
                Case DialogResult.Retry
                    Console.WriteLine("Juhu, nochmal!!")

                Case DialogResult.Cancel
                    Exit While
            End Select
        End While

    End Sub

    Private Function GetToday() As Wochentag
        Return Wochentag.Freitag
    End Function
    Private Function GetThisMonth() As Integer
        Return 10
    End Function

End Module
