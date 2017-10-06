Public Structure Bruchzahl

    Public ReadOnly Property Zähler As Integer
    Public ReadOnly Property Nenner As Integer

    Public Sub New(zähler As Integer, nenner As Integer)
        Me.Zähler = zähler
        Me.Nenner = nenner
    End Sub


    Public Shared Operator *(ByVal left As Bruchzahl, ByVal right As Bruchzahl) As Bruchzahl
        Dim z = left.Zähler * right.Zähler
        Dim n = left.Nenner * right.Nenner

        Return New Bruchzahl(z, n)
    End Operator

    Public Shared Operator *(ByVal left As Bruchzahl, ByVal right As Integer) As Bruchzahl
        Dim z = left.Zähler * right
        Return New Bruchzahl(z, left.Nenner)
    End Operator

    Public Shared Operator *(ByVal left As Integer, ByVal right As Bruchzahl) As Bruchzahl
        Return right * left
    End Operator

    Public Overrides Function ToString() As String
        Return $"{Zähler}/{Nenner}"
    End Function

End Structure
