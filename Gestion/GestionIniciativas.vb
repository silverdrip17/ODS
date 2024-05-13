Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Entidades
Public Class GestionIniciativas
    Private cadenaDeConexion As String = "Data Source = .; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"

    Private _MisOds As List(Of ODS)
    Public ReadOnly Property MisODS As ReadOnlyCollection(Of ODS) ' todo PROFESORADO NO se puede hacer así, ya que _MisOds puede estar vacío (no puede depender de que llamemos o no al método GuardarOds)
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

    Public Function GuardarOds(ByRef msg As String) As ReadOnlyCollection(Of ODS) ' todo PROFESORADO Nombre ilógico para lo que hace, y ver comentarios en documento de correcciones sobre esta función
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

    Private _MisMetas As List(Of Metas) ' todo PROFESORADO Esta variable no debe existir
    Public ReadOnly Property MisMetas(ods As Integer) As ReadOnlyCollection(Of Metas)
        Get
            Return MisODS(ods).ListaMetas.AsReadOnly ' todo PROFESORADO No tiene sentido que tenga que obtener TODOS los Ods, esta propiedad debe hacer la consulta con la base de datos de forma que solo busque las metas de un ODS
        End Get
    End Property

    Public Function GuardarMetas(ByRef msg As String) As ReadOnlyCollection(Of Metas) ' todo PROFESORADO No se necesita para nada. Nunca querremos TODAS las metas
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

    Public Function MetasDeUnOds(numeroods As String, ByRef msg As String) As ReadOnlyCollection(Of Metas) ' todo PROFESORADO ¿Función y propiedad para obtener las metas de un ods?
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
                msg = $"No existe ningun ods con el numero {numeroods}" ' todo PROFESORADO En esta parte será que no hay metas del ODS, no que no existe el ODS
                Return listaMetas.AsReadOnly
            End If
            sql = "Select NUMEROODS, CODMETA, NOMBRE, DESCRIPCION From METAS Where NUMEROODS = @numeroods"
            Dim cdmLoc As New SqlCommand(sql, oConexion)
            cdmLoc.Parameters.AddWithValue("@numeroods", numeroods)
            Dim drMetas As SqlDataReader = cdmLoc.ExecuteReader

            Do While drMetas.Read
                Dim met As New Metas(Integer.Parse(drMetas("NUMEROODS")), drMetas("CODMETA").ToString, drMetas("NOMBRE").ToString, drMetas("DESCRIPCION"))
                listaMetas.Add(met)
            Loop
        Catch ex As Exception
            msg = ex.Message
        End Try
        Return listaMetas.AsReadOnly
    End Function

    Public Function DevolverMeta(numODS As Integer) ' todo PROFESORADO Si es una función debe tener tipo de retorno. Por el nombre parece que devuelve solo 1.
        ' Otra tercera forma de querer devolver las metas de un ODS? Y esta tampoco debe ser así
        If numODS > 17 Then
            Return Nothing
        End If
        Return MisODS(numODS - 1).ListaMetas
    End Function

    Public Function AñadirMetaAODS(numODS As Integer, meta As Metas) ' todo PROFESORADO Como no podemos tener la colección MisODS así, menos añadir la meta de esta forma.
        ' El método deberá controlar que no contiene ya la meta en la BD y si todo va bien, añadirla allí
        ' Si no devuelve nada no es función sino sub
        For i As Integer = 0 To MisODS.Count - 1
            If MisODS(i).NumODS = numODS Then
                MisODS(i).ListaMetas.Add(meta)
            End If
        Next
        ' todo PROFESORADO 
    End Function

    Public Function ModificarOds(idOds As Integer, nombre As String, descripcion As String, ByRef mensajerror As String) As String ' todo PROFESORADO ¿qué sentido tiene que devuelva 2 mensajes diferentes: uno con variable mensajerror y otro la función que SIEMPRE devuelve Nothing
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "Select Count(*) from ODS where IDODS = @idOds" ' todo PROFESORADO ERROR DE EJECUCIÓN, No existe IDODS
            Dim cmdLeerOds As New SqlCommand(sql, oConexion)
            cmdLeerOds.Parameters.AddWithValue("@idOds", idOds)
            Dim nProv As Integer = cmdLeerOds.ExecuteScalar()
            If nProv = 0 Then
                sql = "INSERT INTO ODS VALUES (@idOds,@NOMBRE,@DESCNUEVA)"
                Dim cmdAnyadirOds As New SqlCommand(sql, oConexion)
                cmdAnyadirOds.Parameters.AddWithValue("@DESCNUEVA", descripcion)
                cmdAnyadirOds.Parameters.AddWithValue("@NOMBRE", nombre)
                cmdAnyadirOds.Parameters.AddWithValue("@idOds", idOds)
                cmdAnyadirOds.ExecuteNonQuery() ' todo PROFESORADO Controlar número de filas devueltas, y solo si es 1 realmente estará creado
                mensajerror = "ODS creado correctamente"
            Else
                sql = "update ODS set DESCRIPCION = @DESCNUEVA, NOMBRE=@NOMBRE where IDODS = @idOds"
                Dim cmdCambiarDesc As New SqlCommand(sql, oConexion)
                cmdCambiarDesc.Parameters.AddWithValue("@DESCNUEVA", descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@NOMBRE", nombre)
                cmdCambiarDesc.Parameters.AddWithValue("@idOds", idOds)
                cmdCambiarDesc.ExecuteNonQuery() ' todo Lo mismo de antes
                mensajerror = "ODS modificado correctamente"

            End If
        Catch ex As Exception
            mensajerror = ex.ToString
        Finally
            oConexion.Close()
        End Try
        Return Nothing
    End Function
    Public Function ModificarOds(ods As ODS, ByRef mensajerror As String) As String
        Return ModificarOds(ods.NumODS, ods.Nombre, ods.Descripcion, mensajerror)
    End Function

    Public Sub ModificarMeta(metamodificar As Metas, ByRef mensajerror As String) ' todo Profesorado Si ModificarOds está sobrecargado este debería seguir la misma lógica
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "SELECT DESCRIPCION FROM Metas WHERE IDODS = @IDODS AND NUMERO = @NUMERO"
            Dim cmdLeerMeta As New SqlCommand(sql, oConexion)
            cmdLeerMeta.Parameters.AddWithValue("@IDODS", metamodificar.NumODS)
            cmdLeerMeta.Parameters.AddWithValue("@NUMERO", metamodificar.CodMeta)
            Dim drMeta As SqlDataReader = cmdLeerMeta.ExecuteReader()
            If drMeta.Read() Then
                sql = "UPDATE Metas SET DESCRIPCION = @descripcion WHERE IDODS = @IDODS AND NUMERO = @NUMERO"
                Dim cmdCambiarDesc As New SqlCommand(sql, oConexion)
                cmdCambiarDesc.Parameters.AddWithValue("@descripcion", metamodificar.Descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@IDODS", metamodificar.NumODS)
                cmdCambiarDesc.Parameters.AddWithValue("@NUMERO", metamodificar.CodMeta)
                cmdCambiarDesc.ExecuteNonQuery() ' todo Como antes...
                mensajerror = "La meta ha sido modificada exitosamente."
            Else
                sql = "INSERT INTO Metas (IDODS, NUMERO, DESCRIPCION) VALUES (@IDODS, @NUMERO, @descripcion)"
                Dim cmdCambiarDesc As New SqlCommand(sql, oConexion)
                cmdCambiarDesc.Parameters.AddWithValue("@descripcion", metamodificar.Descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@IDODS", metamodificar.NumODS)
                cmdCambiarDesc.Parameters.AddWithValue("@NUMERO", metamodificar.CodMeta)
                cmdCambiarDesc.ExecuteNonQuery() ' todo ...
                mensajerror = "La meta ha sido creada."
            End If
        Catch ex As Exception
            mensajerror = ex.ToString
        Finally
            oConexion.Close()
        End Try
    End Sub
End Class
