Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.IO
Imports Entidades
Public Class GestionIniciativas
    Private cadenaDeConexion As String = "Data Source = .; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Public Sub New()
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
    'Public Function GuardarError(msg As String) As String
    '    Dim rutafichero As String = "./Ficheros/Ficherrores"
    '    Try
    '        If Not File.Exists(rutafichero) Then
    '            File.WriteAllLines(rutafichero, msg)
    '        Else
    '            File.AppendAllLines(rutafichero, msg)
    '        End If
    '    Catch ex As Exception
    '        Return "Error, la carpeta Ficheros no existe"
    '    End Try
    '    Return "" 'GuardarCambios(kor.DatosKorrika)
    'End Function

    'Public Function GuardarODSMetas(readonlyods As ReadOnlyCollection(Of ODS)) As String
    '    Dim ods() As String = {}
    '    Array.Resize(ods, ods.Length + 1)
    '    For Each odss As ODS In readonlyods
    '        Array.Resize(ods, ods.Length + 1)
    '        If String.IsNullOrWhiteSpace(odss.Nombre) OrElse String.IsNullOrWhiteSpace(odss.Descripcion) Then
    '            ods(ods.Length - 1) = odss.NumODS
    '        ElseIf TypeOf kms Is KilometroFinanciado Then
    '            Dim kilFin As KilometroFinanciado = TryCast(kms, KilometroFinanciado)
    '            Korrikas(Korrikas.Length - 1) = kms.NumKm & "*" & kms.Direccion & "*" & kms.Localidad & "*" & kms.Provincia & "*" & kilFin.Organizacion & "*" & kilFin.Euros
    '        Else
    '            Korrikas(Korrikas.Length - 1) = kms.NumKm & "*" & kms.Direccion & "*" & kms.Localidad & "*" & kms.Provincia
    '        End If
    '    Next
    '    Try
    '        File.WriteAllLines("./Ficheros/Korrika" & kor.DatosKorrika.NKorrika, Korrikas)
    '    Catch ex As Exception
    '        Return "Error, la carpeta Ficheros no existe"
    '    End Try
    '    Return "" 'GuardarCambios(kor.DatosKorrika)
    'End Function

    'Public Function GuardarODSMetas(readonlyods As ReadOnlyCollection(Of ODS)) As String
    '    Dim ods() As String = {}
    '    Array.Resize(ods, ods.Length+ 1)
    '    For Each odss As ODS In readonlyods
    '        Array.Resize(ods, ods.Length + 1)
    '        If String.IsNullOrWhiteSpace(odss.Nombre) OrElse String.IsNullOrWhiteSpace(odss.Descripcion) Then
    '            ods(ods.Length - 1) = odss.NumODS
    '        ElseIf TypeOf kms Is KilometroFinanciado Then
    '        Dim kilFin As KilometroFinanciado = TryCast(kms, KilometroFinanciado)
    '            Korrikas(Korrikas.Length - 1) = kms.NumKm & "*" & kms.Direccion & "*" & kms.Localidad & "*" & kms.Provincia & "*" & kilFin.Organizacion & "*" & kilFin.Euros
    '        Else
    '            Korrikas(Korrikas.Length - 1) = kms.NumKm & "*" & kms.Direccion & "*" & kms.Localidad & "*" & kms.Provincia
    '        End If
    '    Next
    '    Try
    '        File.WriteAllLines("./Ficheros/Korrika" & kor.DatosKorrika.NKorrika, Korrikas)
    '    Catch ex As Exception
    '        Return "Error, la carpeta Ficheros no existe"
    '    End Try
    '    Return "" 'GuardarCambios(kor.DatosKorrika)
    'End Function

    'Public Sub AnadirIniciativa(iniciativa As Iniciativa, ByRef msg As String)
    '    'Todo guardar la iniciativa en la BBDD
    '    Dim oConexion As New SqlConnection(cadenaDeConexion)
    '    Try
    '        oConexion.Open()
    '        Dim sql As String = "SELECT CODINICIATIVA, TITULO FROM INICIATIVA WHERE LOWER(INICIATIVA.TITULO) = LOWER(@TITULO)"
    '        Dim cmdIniciativa As New SqlCommand(sql, oConexion)
    '        cmdIniciativa.Parameters.AddWithValue("@TITULO", iniciativa.Titulo)
    '        Dim drIniciativa As SqlDataReader = cmdIniciativa.ExecuteReader
    '        ' Dim iniciativaAux As Iniciativa = If(drIniciativa.Read(), New Iniciativa(drIniciativa("CODINICIATIVA"), drIniciativa("TITULO").ToString), Nothing)
    '        'Si no tengo la iniciativa, hay que hacer Insert.
    '        If iniciativaAux Is Nothing Then
    '            sql = "INSERT INTO INICIATIVA (TITULO, DESCRIPCION, [FECHA INICIO], [FECHA FIN], IDSOLICITANTE) VALUES (@TITULO, @DESCRIPCION, @FECHAIN, @FECHAFIN, @IDSOLICITANTE)"
    '        End If
    '        'Conseguir solicitante del cboBox.
    '        'Dim miSolicitante As Solicitante = TryCast(cboSolicitantes.SelectedItem, Solicitante)
    '        'Dim idSolicitante As Integer = miSolicitante.IdSolicitante
    '        'Añadir/modificar iniciativa
    '        cmdIniciativa = New SqlCommand(sql, oConexion)
    '        cmdIniciativa.Parameters.AddWithValue("@TITULO", iniciativa.Titulo)
    '        cmdIniciativa.Parameters.AddWithValue("@DESCRIPCION", iniciativa.Descripcion)
    '        cmdIniciativa.Parameters.AddWithValue("@FECHAIN", iniciativa.FechaInicio)
    '        cmdIniciativa.Parameters.AddWithValue("@FECHAFIN", iniciativa.FechaFin)
    '        'cmdIniciativa.Parameters.AddWithValue("@IDSOLICITANTE", iniciativa.idSolicitante)
    '        cmdIniciativa.ExecuteNonQuery()
    '        msg = "La iniciativa se ha añadido"
    '        'Falta sacar el codigoIniciativa
    '        Dim sqlCodIniciativa As String = "SELECT INICIATIVA.CODINICIATIVA FROM INICIATIVA WHERE INICIATIVA.CODINICIATIVA = @TITULO"
    '        'Iniciativa-Profesorado
    '        Dim sqlIniciativaProfesorado As String = "INSERT INTO INICIATIVA_PROFESORADO(IDPROF, CODINICIATIVA) VALUES (@IDPROF, @CODINICIATIVA)"
    '        'Dim miProfesor As Profesor = cboProfesores.SelectedItem
    '        'Dim cmdIniciativaProfesorado As New SqlCommand(sqlIniciativaProfesorado, oConexion)
    '        'cmdIniciativaProfesorado.Parameters.AddWithValue("@IDPROF", miProfesor.IdProf)
    '        ''cmdIniciativaProfesorado.Parameters.AddWithValue("@CODINICIATIVA", ) 'codigoINiciativa) 
    '        ''Iniciativa-Metas
    '        'Dim misMetas As New List(Of Metas)
    '        'misMetas.AddRange(lstMetas.Items)

    '    Catch ex As Exception
    '        msg = ex.ToString
    '    Finally
    '        oConexion.Close()
    '    End Try
    'End Sub
End Class