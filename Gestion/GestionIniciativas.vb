Imports System.Collections.ObjectModel
Imports Entidades
Public Class GestionIniciativas
    Private cadenaDeConexion As String = "Data Source = *; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Public ReadOnly Property MisODS As ReadOnlyCollection(Of ODS)

    Public Sub New()

    End Sub

    Public Function devolverODS()
        Return MisODS
    End Function

    Public Function guardarOds(ByRef msg As String) As ReadOnlyCollection(Of ODS)

    End Function

End Class
