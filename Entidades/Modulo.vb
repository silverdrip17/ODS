Public Class Modulo
    Implements IEquatable(Of Modulo)

    Public Property CodCurso As Integer
    Public Property CodModulo As Integer

    Public Property Nombre As String

    Public Sub New()

    End Sub
    Public Sub New(codCurso As Integer, codModulo As Integer, nombre As String)
        Me.CodCurso = codCurso
        Me.CodModulo = codModulo
        Me.Nombre = nombre
    End Sub
    Public Overrides Function ToString() As String
        Return Me.Nombre.ToString()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Modulo))
    End Function

    Public Overloads Function Equals(other As Modulo) As Boolean Implements IEquatable(Of Modulo).Equals
        Return other IsNot Nothing AndAlso
               CodCurso = other.CodCurso AndAlso
               CodModulo = other.CodModulo
    End Function
End Class
