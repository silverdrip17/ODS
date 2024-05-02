Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Entidades
Public Class GestionIniciativas
    Private cadenaDeConexion As String = "Data Source = .; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Private _MisOds As List(Of ODS)
    Public ReadOnly Property MisODS As ReadOnlyCollection(Of ODS)
        Get
            Return _MisOds.AsReadOnly
        End Get
    End Property

    Public Sub New()
        If Environment.MachineName = "DESKTOP-NIH4RAC" Then
            cadenaDeConexion = "Data Source = DESKTOP-NIH4RAC\MSSQLSERVER2; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
        ElseIf Environment.MachineName = "4V-PRO-948" Then
            cadenaDeConexion = "Data Source = 4V-PRO-948\SQLEXPRESS; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
        End If
    End Sub

    'Public Function DevolverODS()
    '    Return MisODS
    'End Function

    Public Function GuardarOds(ByRef msg As String) As ReadOnlyCollection(Of ODS)
        Dim todosLosOds As New List(Of ODS)
        msg = ""
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "select NUMERO, NOMBRE, DESCRIPCION FROM ODS"
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
        _MisOds = New List(Of ODS)
        _MisOds.AddRange(todosLosOds)
        Return todosLosOds.AsReadOnly
    End Function

    Private _MisMetas As List(Of Metas)
    Public ReadOnly Property MisMetas(ods As Integer) As ReadOnlyCollection(Of Metas)
        Get
            Return MisODS(ods).ListaMetas
        End Get
    End Property

    Public Function GuardarMetas(ByRef msg As String) As ReadOnlyCollection(Of Metas)
        Dim todasLasMetas As New List(Of Metas)
        msg = ""
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "SELECT NUMEROODS, CODMETA, NOMBRE, DESCRIPCCION FROM METAS"
            Dim cmdLeer As New SqlCommand(sql, oConexion)
            Dim dr As SqlDataReader = cmdLeer.ExecuteReader
            Do While dr.Read
                Dim metasss As New Metas(dr("NUMEROODS").ToString, dr("codmeta").ToString, dr("NOMBRE").ToString, dr("DESCRIPCION").ToString)
                todasLasMetas.Add(metasss)
            Loop
        Catch ex As Exception
            msg = ex.Message
            Return Nothing
        Finally
            oConexion.Close()
        End Try
        _MisMetas = New List(Of Metas)
        _MisMetas.AddRange(todasLasMetas)
        Return todasLasMetas.AsReadOnly
    End Function

    Public Function MetasDeUnOds(numeroods As String, ByRef msg As String) As ReadOnlyCollection(Of Metas)
        'saber si exixte el ods
        Dim listaMetas As New List(Of Metas)
        msg = ""
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "Select METAS.* From METAS Where NUMEROODS = @numeroods"
            Dim cmdLeerProv As New SqlCommand(sql, oConexion)
            cmdLeerProv.Parameters.AddWithValue("@numeroods", numeroods)
            Dim nOds As Integer = cmdLeerProv.ExecuteScalar()
            If nOds = 0 Then
                msg = $"No existe ningun ods con el numero {numeroods}"
                Return listaMetas.AsReadOnly
            End If
        Catch ex As Exception
            msg = ex.Message
        End Try
        Return listaMetas.AsReadOnly
    End Function

    Public Function DevolverMeta(numODS As Integer)
        If numODS > 17 Then
            Return Nothing
        End If
        Return MisODS(numODS).ListaMetas
    End Function

    Public Function añadirMetaAODS(numODS As Integer)

    End Function
End Class
