Imports System.Collections.ObjectModel
Imports Entidades
Public Class GestionIniciativas
    Public ReadOnly Property MisODS As ReadOnlyCollection(Of ODS)

    Public Sub New()

    End Sub

    Public Function devolverODS()
        Return MisODS
    End Function

End Class
