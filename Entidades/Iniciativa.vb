Imports System.Collections.ObjectModel

Public Class Iniciativa
    Implements IEquatable(Of Iniciativa)

    Public Property CodIniciativa As Integer
    Public Property Titulo As String
    Public Property Descripcion As String
    Public Property FechaInicio As Date
    Public Property FechaFin As Date

    Public Property Solicitante As Solicitante
    Public Property ListaMetas As List(Of Metas)
    Public Property Profesores As List(Of Profesor)
    Public Property Modulos As List(Of Modulo)
    Public Sub New()
        ListaMetas = New List(Of Metas)
        Profesores = New List(Of Profesor)
        Modulos = New List(Of Modulo)
    End Sub


    Public Sub New(codIniciativa As Integer, titulo As String, descripcion As String, fechaInicio As Date, fechaFin As Date)
        Me.New()
        Me.Descripcion = descripcion
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
    End Sub

    Public Sub New(codIniciativa As Integer, titulo As String, descripcion As String, fechaInicio As Date, fechaFin As Date, solicitante As Solicitante, listaMetas As List(Of Metas), profesores As List(Of Profesor), modulos As List(Of Modulo))
        Me.New(codIniciativa, titulo, descripcion, fechaInicio, fechaFin)
        Me.Solicitante = solicitante
        Me.ListaMetas = listaMetas
        Me.Profesores = profesores
        Me.Modulos = modulos
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
