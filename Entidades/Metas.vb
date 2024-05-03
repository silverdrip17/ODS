Public Class Metas
    Implements IEquatable(Of Metas)

    Public Property NumODS As Integer
    Public Property CodMeta As String
    Public Property Nombre As String
    Public Property Descripcion As String

    Public Sub New()
    End Sub

    Public Sub New(numODS As Integer, codMeta As String)
        Me.NumODS = numODS
        Me.CodMeta = codMeta
    End Sub

    Public Sub New(numODS As Integer, codMeta As String, nombre As String, descripcion As String)
        Me.New(numODS, codMeta)
        Me.Nombre = nombre
        Me.Descripcion = descripcion
    End Sub


    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Metas))
    End Function

    Public Overloads Function Equals(other As Metas) As Boolean Implements IEquatable(Of Metas).Equals
        Return other IsNot Nothing AndAlso
               NumODS = other.NumODS AndAlso
               CodMeta.ToLower = other.CodMeta.ToLower
    End Function

    Public Overrides Function ToString() As String
        Return $"{CodMeta}:{Nombre}"
    End Function
End Class
