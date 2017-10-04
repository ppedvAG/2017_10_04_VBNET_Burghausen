Option Strict On

Public Class Form1
    Private Sub PlusButton_Click(sender As Object, e As EventArgs) Handles PlusButton.Click
        ' Auslesen aus den TextBox
        Dim zahl1 = Integer.Parse(Input1TextBox.Text)
        Dim zahl2 = Integer.Parse(Input2TextBox.Text)

        ' Berechnung
        Dim ergebnis = zahl1 + zahl2

        ' Anzeigen
        OutputTextBox.Text = ergebnis.ToString()
    End Sub

    Private Sub MinusButton_Click(sender As Object, e As EventArgs) Handles MinusButton.Click
        OutputTextBox.Text = (Integer.Parse(Input1TextBox.Text) - Integer.Parse(Input2TextBox.Text)).ToString()
    End Sub

    Private Sub MalButton_Click(sender As Object, e As EventArgs) Handles MalButton.Click
        Dim ergebnis = Integer.Parse(Input1TextBox.Text) * Integer.Parse(Input2TextBox.Text)
        OutputTextBox.Text = ergebnis.ToString()
    End Sub

    Private Sub DividiertButton_Click(sender As Object, e As EventArgs) Handles DividiertButton.Click
        Dim ergebnis = Integer.Parse(Input1TextBox.Text) / Integer.Parse(Input2TextBox.Text)
        OutputTextBox.Text = ergebnis.ToString()
    End Sub

    Private Sub ModuloButton_Click(sender As Object, e As EventArgs) Handles ModuloButton.Click
        Dim ergebnis = Integer.Parse(Input1TextBox.Text) Mod Integer.Parse(Input2TextBox.Text)
        OutputTextBox.Text = ergebnis.ToString()
    End Sub
End Class
