Public Class Solicitante
    Implements IEquatable(Of Solicitante)

    Public Property IdSolicitante As Integer
    Public Property Nombre As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Sub New(codCurso As Integer, nombre As String)
        Me.IdSolicitante = codCurso
        Me.Nombre = nombre
    End Sub
    Public Overrides Function ToString() As String
        Return Me.Nombre.ToString()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Solicitante))
    End Function

    Public Overloads Function Equals(other As Solicitante) As Boolean Implements IEquatable(Of Solicitante).Equals
        Return other IsNot Nothing AndAlso
               IdSolicitante = other.IdSolicitante
    End Function
End Class
