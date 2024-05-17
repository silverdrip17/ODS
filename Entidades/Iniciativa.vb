Public Class Iniciativa
    Implements IEquatable(Of Iniciativa)

    Public Property CodIniciativa As Integer
    Public Property Titulo As String
    Public Property Descripcion As String
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Sub New()
    End Sub

    Public Sub New(codIniciativa As Integer, titulo As String)
        Me.CodIniciativa = codIniciativa
        Me.Titulo = titulo
    End Sub
    Public Sub New(codIniciativa As Integer, titulo As String, descripcion As String, fechaInicio As Date, fechaFin As Date)
        Me.New(codIniciativa, titulo)
        Me.Descripcion = descripcion
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Iniciativa))
    End Function

    Public Overloads Function Equals(other As Iniciativa) As Boolean Implements IEquatable(Of Iniciativa).Equals
        Return other IsNot Nothing AndAlso
               CodIniciativa = other.CodIniciativa
    End Function

    Public Overrides Function ToString() As String
        Return $"{CodIniciativa}:{Titulo}:{Descripcion}:{FechaInicio}:{FechaFin}"
    End Function
End Class
