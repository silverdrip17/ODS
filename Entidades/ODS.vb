Imports System.Collections.ObjectModel

Public Class ODS
    Implements IEquatable(Of ODS)

    Public Property NumODS As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Imagen As String ' todo Debería ser ReadOnly y calcularla aquí
    Public ReadOnly Property ListaMetas As List(Of Metas)
    ' todo PROFESORADO Para que realmente sea ReadOnly debe devolver una ReadOnlyCollections
    ' Pero en ese caso mejor que no sea ReadOnly

    Public Sub New()
    End Sub
    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Sub New(numODS As Integer)
        Me.NumODS = numODS
    End Sub

    Public Sub New(numODS As Integer, nombre As String, descripcion As String)
        Me.New(numODS)
        Me.Nombre = nombre
        Me.Descripcion = descripcion
    End Sub
    ' todo PROFESORADO Estaría bien otro recibiendo también las metas
    
    'Public Sub New(numODS As Integer, nombre As String, descripcion As String, imagen As String)
    '    Me.New(numODS)
    '    Me.Nombre = nombre
    '    Me.Descripcion = descripcion
    '    Me.Imagen = imagen
    'End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, ODS))
    End Function

    Public Overloads Function Equals(other As ODS) As Boolean Implements IEquatable(Of ODS).Equals
        Return other IsNot Nothing AndAlso
               NumODS = other.NumODS
    End Function

    Public Overrides Function ToString() As String
        Return $"{NumODS}: {Nombre}"
    End Function
End Class
