Imports System.Collections.ObjectModel
Imports Entidades
Public Class GestionIniciativas
    Private cadenaDeConexion As String = "Data Source = *; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Public ReadOnly Property MisODS As ReadOnlyCollection(Of ODS)

    Public Sub New()
        If Environment.MachineName = "DESKTOP-NIH4RAC" Then
            cadenaDeConexion = "Data Source = DESKTOP-NIH4RAC\MSSQLSERVER2; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"

        End If
    End Sub

    Public Function devolverODS()
        Return MisODS
    End Function

    Public Function guardarOds(ByRef msg As String) As ReadOnlyCollection(Of ODS)

    End Function

    Public Function devolverMeta(numODS As Integer)
        If numODS > 17 Then
            Return Nothing
        End If
        Return MisODS(numODS).ListaMetas
    End Function

End Class
