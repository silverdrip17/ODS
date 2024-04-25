Imports System.Collections.ObjectModel
Imports Entidades
Public Class GestionIniciativas
    Private cadenaDeConexion As String = "Data Source = *; Initial Catalog = Estado; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Public ReadOnly Property MisODS As ReadOnlyCollection(Of ODS)

    Public Sub New()

    End Sub

    Public Function devolverODS()
        Return MisODS
    End Function

End Class
