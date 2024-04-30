﻿Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Entidades
Public Class GestionIniciativas
    Private cadenaDeConexion As String = "Data Source = *; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Public ReadOnly Property MisODS As ReadOnlyCollection(Of ODS)

    Public Sub New()

    End Sub

    Public Function DevolverODS()
        Return MisODS
    End Function

    Public Function GuardarOds(ByRef msg As String) As ReadOnlyCollection(Of ODS)
        Dim todosLosOds As New List(Of ODS)
        msg = ""
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "select NUMERO, NOMBRE, DESCRIPCIO FROM PROYECTOODS"
            Dim cmdLeer As New SqlCommand(sql, oConexion)
            Dim dr As SqlDataReader = cmdLeer.ExecuteReader
            Do While dr.Read
                Dim odss As New ODS(dr("NUMERO").ToString, dr("NOMBRE").ToString, dr("DESCRIPCION").ToString)
                todosLosOds.Add(odss)
            Loop
        Catch ex As Exception
            msg = ex.Message
            Return Nothing
        Finally
            oConexion.Close()
        End Try
        Return todosLosOds.AsReadOnly
    End Function

    Public Function DevolverMeta(numODS As Integer)
        If numODS > 17 Then
            Return Nothing
        End If
        Return MisODS(numODS).ListaMetas
    End Function

End Class
