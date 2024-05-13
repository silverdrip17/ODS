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

<<<<<<< HEAD
    'Public Function DevolverODS()
    '    Return MisODS
    'End Function

    Public Function GuardarOds(ByRef msg As String) As ReadOnlyCollection(Of ODS) ' todo PROFESORADO Nombre ilógico para lo que hace, y ver comentarios en documento de correcciones sobre esta función
=======
    Public Function DevolverOds(ByRef msg As String) As ReadOnlyCollection(Of ODS)
>>>>>>> b0c85facfa0a80c2324a38c7fa01b224d6271ff2
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
        Return todosLosOds.AsReadOnly
    End Function

<<<<<<< HEAD
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
=======
    Public Function MetasDeUnOds(numeroods As String, ByRef msg As String) As ReadOnlyCollection(Of Metas)
>>>>>>> b0c85facfa0a80c2324a38c7fa01b224d6271ff2
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
<<<<<<< HEAD
                msg = $"No existe ningun ods con el numero {numeroods}" ' todo PROFESORADO En esta parte será que no hay metas del ODS, no que no existe el ODS
=======
                msg = $"No existe ninguna meta en el ods {numeroods}"
>>>>>>> b0c85facfa0a80c2324a38c7fa01b224d6271ff2
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

<<<<<<< HEAD
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
=======
    Public Sub ModificarOds(idOds As Integer, nombre As String, descripcion As String, ByRef mensajerror As String)
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "Select Count(*) from ODS where NUMERO = @idOds"
>>>>>>> b0c85facfa0a80c2324a38c7fa01b224d6271ff2
            Dim cmdLeerOds As New SqlCommand(sql, oConexion)
            cmdLeerOds.Parameters.AddWithValue("@idOds", idOds)
            Dim nOds As Integer = cmdLeerOds.ExecuteScalar()
            If nOds = 0 Then
                sql = "INSERT INTO ODS VALUES (@idOds,@NOMBRE,@DESCNUEVA)"
                Dim cmdAnyadirOds As New SqlCommand(sql, oConexion)
                cmdAnyadirOds.Parameters.AddWithValue("@DESCNUEVA", descripcion)
                cmdAnyadirOds.Parameters.AddWithValue("@NOMBRE", nombre)
                cmdAnyadirOds.Parameters.AddWithValue("@idOds", idOds)
                cmdAnyadirOds.ExecuteNonQuery() ' todo PROFESORADO Controlar número de filas devueltas, y solo si es 1 realmente estará creado
                mensajerror = "ODS creado correctamente"
            Else
                sql = "update ODS set DESCRIPCION=@DESCNUEVA, NOMBRE=@NOMBRE where NUMERO=@idOds"
                Dim cmdCambiarDesc As New SqlCommand(sql, oConexion)
                cmdCambiarDesc.Parameters.AddWithValue("@DESCNUEVA", descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@NOMBRE", nombre)
                cmdCambiarDesc.Parameters.AddWithValue("@idOds", idOds)
                cmdCambiarDesc.ExecuteNonQuery() ' todo Lo mismo de antes
                mensajerror = "ODS modificado correctamente"

            End If
        Catch ex As Exception
            If ex.Message.Contains("CREATE RULE") Then
                mensajerror = "Ese NÚMERO de ODS no es válido, debe ser un numero entre 1 y 17"
            Else
                mensajerror = ex.ToString
            End If
        Finally
            oConexion.Close()
        End Try
        End Sub
    Public Sub ModificarOds(ods As ODS, ByRef mensajerror As String)
        ModificarOds(ods.NumODS, ods.Nombre, ods.Descripcion, mensajerror)
    End Sub

<<<<<<< HEAD
    Public Sub ModificarMeta(metamodificar As Metas, ByRef mensajerror As String) ' todo Profesorado Si ModificarOds está sobrecargado este debería seguir la misma lógica
=======
    Public Sub ModificarMeta(numODS As Integer, codMeta As String, nombre As String, descripcion As String, ByRef mensajerror As String)
>>>>>>> b0c85facfa0a80c2324a38c7fa01b224d6271ff2
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "SELECT DESCRIPCION FROM Metas WHERE NUMEROODS = @NUMEROODS AND CODMETA = @CODMETA"
            Dim cmdLeerMeta As New SqlCommand(sql, oConexion)
            cmdLeerMeta.Parameters.AddWithValue("@NUMEROODS", numODS)
            cmdLeerMeta.Parameters.AddWithValue("@CODMETA", codMeta)
            Dim drMeta As SqlDataReader = cmdLeerMeta.ExecuteReader()
            If drMeta.Read() Then
                sql = "UPDATE Metas SET DESCRIPCION = @descripcion, NOMBRE = @NOMBRE WHERE NUMEROODS = @NUMEROODS AND CODMETA = @CODMETA"
                Dim cmdCambiarDesc As New SqlCommand(sql, oConexion)
<<<<<<< HEAD
                cmdCambiarDesc.Parameters.AddWithValue("@descripcion", metamodificar.Descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@IDODS", metamodificar.NumODS)
                cmdCambiarDesc.Parameters.AddWithValue("@NUMERO", metamodificar.CodMeta)
                cmdCambiarDesc.ExecuteNonQuery() ' todo Como antes...
=======
                cmdCambiarDesc.Parameters.AddWithValue("@descripcion", descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@NOMBRE", nombre)
                cmdCambiarDesc.Parameters.AddWithValue("@NUMEROODS", numODS)
                cmdCambiarDesc.Parameters.AddWithValue("@CODMETA", codMeta)
                cmdCambiarDesc.ExecuteNonQuery()
>>>>>>> b0c85facfa0a80c2324a38c7fa01b224d6271ff2
                mensajerror = "La meta ha sido modificada exitosamente."
            Else
                sql = "INSERT INTO Metas (NUMEROODS, CODMETA, NOMBRE, DESCRIPCION) VALUES (@NUMEROODS, @CODMETA, @NOMBRE, @descripcion)"
                Dim cmdCambiarDesc As New SqlCommand(sql, oConexion)
<<<<<<< HEAD
                cmdCambiarDesc.Parameters.AddWithValue("@descripcion", metamodificar.Descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@IDODS", metamodificar.NumODS)
                cmdCambiarDesc.Parameters.AddWithValue("@NUMERO", metamodificar.CodMeta)
                cmdCambiarDesc.ExecuteNonQuery() ' todo ...
=======
                cmdCambiarDesc.Parameters.AddWithValue("@descripcion", descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@NOMBRE", nombre)
                cmdCambiarDesc.Parameters.AddWithValue("@NUMEROODS", numODS)
                cmdCambiarDesc.Parameters.AddWithValue("@CODMETA", codMeta)
                cmdCambiarDesc.ExecuteNonQuery()
>>>>>>> b0c85facfa0a80c2324a38c7fa01b224d6271ff2
                mensajerror = "La meta ha sido creada."
            End If
        Catch ex As Exception
            mensajerror = ex.ToString
        Finally
            oConexion.Close()
        End Try
    End Sub
    Public Sub ModificarMeta(metamodificar As Metas, ByRef mensajerror As String)
        ModificarMeta(metamodificar.NumODS, metamodificar.CodMeta, metamodificar.Nombre, metamodificar.Descripcion, mensajerror)
    End Sub

    Public Function DevolverProfesores(ByRef msg As String) As ReadOnlyCollection(Of Profesor)
        Dim todosLosProfesores As New List(Of Profesor)
        msg = ""
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "SELECT IDPROF, NOMBRECOMPLETO FROM PROFESORADO"
            Dim cmdLeer As New SqlCommand(sql, oConexion)
            Dim dr As SqlDataReader = cmdLeer.ExecuteReader
            Do While dr.Read
                Dim profesor As New Profesor(dr("IDPROF").ToString, dr("NOMBRECOMPLETO").ToString)
                todosLosProfesores.Add(profesor)
            Loop
        Catch ex As Exception
            msg = ex.Message
            Return Nothing
        Finally
            oConexion.Close()
        End Try
        Return todosLosProfesores.AsReadOnly
    End Function

    Public Function DevolverSolicitantes(ByRef msg As String) As ReadOnlyCollection(Of Solicitante)
        Dim todosLosSolicitantes As New List(Of Solicitante)
        msg = ""
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "SELECT IDSOLICITANTE, NOMBRE FROM SOLICITANTE"
            Dim cmdLeer As New SqlCommand(sql, oConexion)
            Dim dr As SqlDataReader = cmdLeer.ExecuteReader
            Do While dr.Read
                Dim solicitante As New Solicitante(dr("IDSOLICITANTE").ToString, dr("NOMBRE").ToString)
                todosLosSolicitantes.Add(solicitante)
            Loop
        Catch ex As Exception
            msg = ex.Message
        Finally
            oConexion.Close()
        End Try
        Return todosLosSolicitantes.AsReadOnly
    End Function

    Public Function ModulosDeUnCurso(codcurso As String, ByRef msg As String) As ReadOnlyCollection(Of Modulo)
        Dim listaModulos As New List(Of Modulo)
        msg = ""
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sqlMod As String = "Select MODULO.* From MODULO Where CODCURSO = @CODCURSO"
            Dim cdmLoc As New SqlCommand(sqlMod, oConexion)
            cdmLoc.Parameters.AddWithValue("@CODCURSO", codcurso)
            Dim drModulos As SqlDataReader = cdmLoc.ExecuteReader
            Do While drModulos.Read
                Dim modu As New Modulo(Integer.Parse(drModulos("CODCURSO")), drModulos("CODMODULO").ToString, drModulos("NOMBRE").ToString)
                listaModulos.Add(modu)
            Loop
        Catch ex As Exception
            msg = ex.Message
        End Try
        Return listaModulos.AsReadOnly
    End Function

    Public Function DevolverCursos(ByRef msg As String) As ReadOnlyCollection(Of Curso)
        Dim todosLosCursos As New List(Of Curso)
        msg = ""
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "SELECT CODCURSO, NOMBRE FROM CURSO"
            Dim cmdLeer As New SqlCommand(sql, oConexion)
            Dim dr As SqlDataReader = cmdLeer.ExecuteReader
            Do While dr.Read
                Dim curso As New Curso(dr("CODCURSO").ToString, dr("NOMBRE").ToString)
                todosLosCursos.Add(curso)
            Loop
        Catch ex As Exception
            msg = ex.Message
        Finally
            oConexion.Close()
        End Try
        Return todosLosCursos.AsReadOnly
    End Function

End Class
