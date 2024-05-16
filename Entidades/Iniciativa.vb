Imports System.Collections.ObjectModel

Public Class Iniciativa
    Implements IEquatable(Of Iniciativa)

    Public Property CodIniciativa As Integer
    Public Property Titulo As String
    Public Property Descripcion As String
    Public Property FechaInicio As Date
    Public Property FechaFin As Date

    Private ReadOnly _Solicitante As Solicitante
    Public ReadOnly Property Solicitante() As Solicitante
        Get
            Return _Solicitante
        End Get
    End Property
    Public ReadOnly Property ListaMetas As ReadOnlyCollection(Of Metas)
    Public ReadOnly Property Profesores As ReadOnlyCollection(Of Profesor)
    Public ReadOnly Property Modulos As ReadOnlyCollection(Of Modulo)
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


    'Constructor con las colecciones para poder usar método en GestionIniciativa
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
