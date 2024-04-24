Public Class Metas
    Implements IEquatable(Of Metas)

    Public Property NumODS As Integer
    Public Property CodMeta As String
    Public Property Nombre As String
    Public Property Descripcion As String

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Metas))
    End Function

    Public Overloads Function Equals(other As Metas) As Boolean Implements IEquatable(Of Metas).Equals
        Return other IsNot Nothing AndAlso
               NumODS = other.NumODS AndAlso
               CodMeta.ToLower = other.CodMeta.ToLower
    End Function
End Class
