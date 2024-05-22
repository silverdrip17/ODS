Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.IO
Imports Entidades
Public Class GestionIniciativas
    Private cadenaDeConexion As String = "Data Source = .; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Public Sub New()
        GuardarErrores("Esto es una prueba")
        If Environment.MachineName = "DESKTOP-NIH4RAC" Then
            cadenaDeConexion = "Data Source = DESKTOP-NIH4RAC\MSSQLSERVER2; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
        ElseIf Environment.MachineName = "4V-PRO-948" Then
            cadenaDeConexion = "Data Source = 4V-PRO-948\SQLEXPRESS; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
        End If
    End Sub

    Public Function DevolverOds(ByRef msg As String) As ReadOnlyCollection(Of ODS)
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
                msg = $"No existe ninguna meta en el ods {numeroods}"
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

    Public Sub ModificarOds(idOds As Integer, nombre As String, descripcion As String, ByRef mensajerror As String)
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "Select Count(*) from ODS where NUMERO = @idOds"
            Dim cmdLeerOds As New SqlCommand(sql, oConexion)
            cmdLeerOds.Parameters.AddWithValue("@idOds", idOds)
            Dim nOds As Integer = cmdLeerOds.ExecuteScalar()
            If nOds = 0 Then
                sql = "INSERT INTO ODS VALUES (@idOds,@NOMBRE,@DESCNUEVA)"
                Dim cmdAnyadirOds As New SqlCommand(sql, oConexion)
                cmdAnyadirOds.Parameters.AddWithValue("@DESCNUEVA", descripcion)
                cmdAnyadirOds.Parameters.AddWithValue("@NOMBRE", nombre)
                cmdAnyadirOds.Parameters.AddWithValue("@idOds", idOds)
                cmdAnyadirOds.ExecuteNonQuery()
                mensajerror = "ODS creado correctamente"
            Else
                sql = "update ODS set DESCRIPCION=@DESCNUEVA, NOMBRE=@NOMBRE where NUMERO=@idOds"
                Dim cmdCambiarDesc As New SqlCommand(sql, oConexion)
                cmdCambiarDesc.Parameters.AddWithValue("@DESCNUEVA", descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@NOMBRE", nombre)
                cmdCambiarDesc.Parameters.AddWithValue("@idOds", idOds)
                cmdCambiarDesc.ExecuteNonQuery()
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

    Public Sub ModificarMeta(numODS As Integer, codMeta As String, nombre As String, descripcion As String, ByRef mensajerror As String)
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
                cmdCambiarDesc.Parameters.AddWithValue("@descripcion", descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@NOMBRE", nombre)
                cmdCambiarDesc.Parameters.AddWithValue("@NUMEROODS", numODS)
                cmdCambiarDesc.Parameters.AddWithValue("@CODMETA", codMeta)
                cmdCambiarDesc.ExecuteNonQuery()
                mensajerror = "La meta ha sido modificada exitosamente."
            Else
                sql = "INSERT INTO Metas (NUMEROODS, CODMETA, NOMBRE, DESCRIPCION) VALUES (@NUMEROODS, @CODMETA, @NOMBRE, @descripcion)"
                Dim cmdCambiarDesc As New SqlCommand(sql, oConexion)
                cmdCambiarDesc.Parameters.AddWithValue("@descripcion", descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@NOMBRE", nombre)
                cmdCambiarDesc.Parameters.AddWithValue("@NUMEROODS", numODS)
                cmdCambiarDesc.Parameters.AddWithValue("@CODMETA", codMeta)
                cmdCambiarDesc.ExecuteNonQuery()
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

    Public Function DevolverIniciativa(ByRef msg As String) As ReadOnlyCollection(Of Iniciativa)
        Dim todasLasIniciativas As New List(Of Iniciativa)
        msg = ""
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "SELECT CODINICIATIVA, TITULO, DESCRIPCION, FECHAINICIO, FECHAFIN FROM INICIATIVA"
            Dim cmdLeer As New SqlCommand(sql, oConexion)
            Dim dr As SqlDataReader = cmdLeer.ExecuteReader
            Do While dr.Read
                Dim inici As New Iniciativa(dr("CODINICIATIVA").ToString, dr("TITULO").ToString, dr("DESCRIPCION").ToString, dr("FECHAINICIO").ToString, dr("FECHAFIN").ToString)
                todasLasIniciativas.Add(inici)
            Loop
        Catch ex As Exception
            msg = ex.Message
        Finally
            oConexion.Close()
        End Try
        Return todasLasIniciativas.AsReadOnly
    End Function
    Dim listaErrores As New List(Of String)
    Private Function GuardarErrores(msg As String) As String
        Dim rutafichero As String = ".\Ficheros\errores.log"
        listaErrores.Add(msg)
        Try
            If Not File.Exists(rutafichero) Then
                File.AppendAllLines(rutafichero, listaErrores)
            Else
                File.AppendAllLines(rutafichero, listaErrores)
            End If
        Catch ex As Exception
            Return "Error, la carpeta Ficheros no existe"
        End Try
        Return ""
    End Function
    'Public Function LeerPersona() As String
    '    Dim existeFichero As Boolean = File.Exists(NOMBREFICHERO)
    '    If Not existeFichero Then Return $"El fichero {NOMBREFICHERO} no existe"
    '    Dim lineas() As String = File.ReadAllLines(NOMBREFICHERO)
    '    Dim partes() As String
    '    Dim nuevaPersona As Persona
    '    For i As Integer = 0 To lineas.Length - 1
    '        partes = lineas(i).Split("*")
    '        nuevaPersona = New Persona(partes(0), partes(1), partes(2))
    '        Personas.Add(nuevaPersona)
    '    Next
    '    Return Nothing
    'End Function
    'Public Function GrabarFichero() As String
    '    Dim cantidadPersonas As Integer = Personas.Count - 1
    '    Dim datosPersona(cantidadPersonas) As String

    '    For i As Integer = 0 To cantidadPersonas
    '        datosPersona(i) = $"{Personas(i).Dni}*{Personas(i).Nombre}*{Personas(i).FechaNacimiento}"
    '    Next
    '    File.WriteAllLines(NOMBREFICHERO, datosPersona)
    '    Return Nothing
    'End Function

    'Public Function GuardarODSMetas(readonlyods As ReadOnlyCollection(Of ODS)) As String
    '    Dim ods() As String = {}
    '    Array.Resize(ods, ods.Length + 1)
    '    For Each odss As ODS In readonlyods
    '        Array.Resize(ods, ods.Length + 1)
    '        If String.IsNullOrWhiteSpace(odss.Nombre) OrElse String.IsNullOrWhiteSpace(odss.Descripcion) Then
    '            ods(ods.Length - 1) = odss.NumODS
    '        Else
    '            ods(ods.Length - 1) = odss.NumODS & "*" & odss.Nombre & "*" & odss.Descripcion
    '        End If

    '    Next
    '    Try
    '        For i = 0 To ods.Length - 1
    '            Dim metas() As String = {}
    '            MetasDeUnOds(ods(i) + 1,)


    '        Next
    '    Catch ex As Exception
    '        Return "Error, la carpeta Ficheros no existe"
    '    End Try
    '    Return ""
    'End Function




    Public Sub AnadirIniciativa(iniciativa As Iniciativa, ByRef msg As String)
        'Todo guardar la iniciativa en la BBDD
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql = "INSERT INTO INICIATIVA (TITULO, DESCRIPCION, [FECHA INICIO], [FECHA FIN], IDSOLICITANTE) VALUES (@TITULO, @DESCRIPCION, @FECHAIN, @FECHAFIN, @IDSOLICITANTE)"
            Dim cmdIniciativa As New SqlCommand(sql, oConexion)
            cmdIniciativa.Parameters.AddWithValue("@TITULO", iniciativa.Titulo)
            cmdIniciativa.Parameters.AddWithValue("@DESCRIPCION", iniciativa.Descripcion)
            cmdIniciativa.Parameters.AddWithValue("@FECHAIN", iniciativa.FechaInicio)
            cmdIniciativa.Parameters.AddWithValue("@FECHAFIN", iniciativa.FechaFin)
            cmdIniciativa.Parameters.AddWithValue("@IDSOLICITANTE", iniciativa.Solicitante.IdSolicitante)
            cmdIniciativa.ExecuteNonQuery()
            Dim sqlCodIniciativa As String = "SELECT COUNT(INICIATIVA.CODINICIATIVA) FROM INICIATIVA"
            cmdIniciativa = New SqlCommand(sqlCodIniciativa, oConexion)
            Dim codIniciativa As Integer = cmdIniciativa.ExecuteScalar
            'Iniciativa-Profesorado
            Dim sqlIniciativaProfesorado As String = "INSERT INTO INICIATIVA_PROFESORADO(IDPROF, CODINICIATIVA) VALUES (@IDPROF, @CODINICIATIVA)"
            Dim cmdIniciativaProfesorado As New SqlCommand(sqlIniciativaProfesorado, oConexion)
            For Each profesor As Profesor In iniciativa.Profesores
                cmdIniciativaProfesorado.Parameters.Clear()
                cmdIniciativaProfesorado.Parameters.AddWithValue("@IDPROF", profesor.IdProf)
                cmdIniciativaProfesorado.Parameters.AddWithValue("@CODINICIATIVA", codIniciativa)
                cmdIniciativaProfesorado.ExecuteScalar()
            Next

            'INICIATIVA-METAS
            Dim sqlIniciativaMetas As String = "INSERT INTO INICIATIVA_METAS(CODINICIATIVA, NUMEROODS, CODMETA) VALUES (@CODINICIATIVA, @NUMEROODS, @CODMETA)"
            Dim cmdIniciativaMetas As New SqlCommand(sqlIniciativaMetas, oConexion)
            For Each meta As Metas In iniciativa.ListaMetas
                cmdIniciativaMetas.Parameters.Clear()
                cmdIniciativaMetas.Parameters.AddWithValue("@CODINICIATIVA", codIniciativa)
                cmdIniciativaMetas.Parameters.AddWithValue("@NUMEROODS", meta.NumODS)
                cmdIniciativaMetas.Parameters.AddWithValue("@CODMETA", meta.CodMeta)
                cmdIniciativaMetas.ExecuteScalar()
            Next
            'INICIATIVA-MODULOS
            Dim horas As Integer = (iniciativa.FechaFin - iniciativa.FechaInicio).TotalHours

            Dim sqlIniciativaModulos As String = "INSERT INTO INICIATIVA_MODULOS(CODINICIATIVA, CODCURSO, CODMODULO, HORAS) VALUES (@CODINICIATIVA, @CODCURSO, @CODMODULO, @HORAS)"
            Dim cmdIniciativaModulos As New SqlCommand(sqlIniciativaModulos, oConexion)
            For Each modulo As Modulo In iniciativa.Modulos
                cmdIniciativaModulos.Parameters.Clear()
                cmdIniciativaModulos.Parameters.AddWithValue("@CODINICIATIVA", codIniciativa)
                cmdIniciativaModulos.Parameters.AddWithValue("@CODCURSO", modulo.CodCurso)
                cmdIniciativaModulos.Parameters.AddWithValue("@CODMODULO", modulo.CodModulo)
                cmdIniciativaModulos.Parameters.AddWithValue("@HORAS", horas)
                cmdIniciativaModulos.ExecuteScalar()
            Next
            msg = "La iniciativa se ha añadido"
        Catch ex As Exception
            msg = ex.ToString
        Finally
            oConexion.Close()
        End Try
    End Sub
    Public Function EliminarIniciativa(iniciativa As Iniciativa) As String
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Try
            oConexion.Open()
            Dim sql As String = "DELETE FROM INICIATIVA_MODULOS WHERE CODINICIATIVA=@CODINICIATIVA"
            Dim cmdDeLasIniciativas As New SqlCommand(sql, oConexion)
            cmdDeLasIniciativas = New SqlCommand(sql, oConexion)
            cmdDeLasIniciativas.Parameters.AddWithValue("@CODINICIATIVA", iniciativa.CodIniciativa)
            cmdDeLasIniciativas.ExecuteNonQuery()

            sql = "DELETE FROM INICIATIVA_METAS WHERE CODINICIATIVA=@CODINICIATIVA"
            cmdDeLasIniciativas = New SqlCommand(sql, oConexion)
            cmdDeLasIniciativas.Parameters.AddWithValue("@CODINICIATIVA", iniciativa.CodIniciativa)
            cmdDeLasIniciativas.ExecuteNonQuery()

            sql = "DELETE FROM INICIATIVA_PROFESORADO WHERE CODINICIATIVA=@CODINICIATIVA"
            cmdDeLasIniciativas = New SqlCommand(sql, oConexion)
            cmdDeLasIniciativas.Parameters.AddWithValue("@CODINICIATIVA", iniciativa.CodIniciativa)
            cmdDeLasIniciativas.ExecuteNonQuery()

            sql = "DELETE FROM INICIATIVA WHERE CODINICIATIVA=@CODINICIATIVA"
            cmdDeLasIniciativas = New SqlCommand(sql, oConexion)
            cmdDeLasIniciativas.Parameters.AddWithValue("@CODINICIATIVA", iniciativa.CodIniciativa)
            cmdDeLasIniciativas.ExecuteNonQuery()

        Catch ex As Exception
            Return ex.Message
        Finally
            oConexion.Close()
        End Try
        Return ""
    End Function
End Class