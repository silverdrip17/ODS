Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports Entidades

Public Class FrmAltaIniciativas
    Private cadenaDeConexion As String = "Data Source = .; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        If Environment.MachineName = "DESKTOP-NIH4RAC" Then
            cadenaDeConexion = "Data Source = DESKTOP-NIH4RAC\MSSQLSERVER2; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
        ElseIf Environment.MachineName = "4V-PRO-948" Then
            cadenaDeConexion = "Data Source = 4V-PRO-948\SQLEXPRESS; Initial Catalog = PROYECTOODS; Integrated Security = SSPI; MultipleActiveResultSets=true"
        End If
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Sub FrmAltaIniciativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg As String = ""
        cboODS.Items.AddRange(Gestor.DevolverOds(msg).ToArray)
        cboSolicitantes.Items.AddRange(Gestor.DevolverSolicitantes(msg).ToArray)
        cboProfesores.Items.AddRange(Gestor.DevolverProfesores(msg).ToArray)
        cboCursos.Items.AddRange(Gestor.DevolverCursos(msg).ToArray)
        cboIniciativasEliminar.Items.AddRange(Gestor.DevolverIniciativa(msg).ToArray)
        WindowState = FormWindowState.Maximized
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODS.SelectedIndexChanged
        cboMetas.SelectedItem = ""
        Dim odsSeleccionado As ODS = TryCast(cboODS.SelectedItem, ODS)
        Dim msg As String = ""
        Dim listaMetas As ReadOnlyCollection(Of Metas)
        Dim idProv = odsSeleccionado.NumODS
        listaMetas = Gestor.MetasDeUnOds(idProv, msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            Gestor.GuardarErrores(msg)
            cboMetas.Items.Clear()
            Exit Sub
        End If
        cboMetas.Items.Clear()

        For i As Integer = 0 To listaMetas.Count - 1
            cboMetas.Items.Add(listaMetas(i))
        Next
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMetas.SelectedIndexChanged
        Dim metaSeleccionada As Metas = TryCast(cboMetas.SelectedItem, Metas)
        If metaSeleccionada Is Nothing Then
            Exit Sub
        End If
        If lstMetas.Items.Count <> 0 Then
            For i As Integer = 0 To lstMetas.Items.Count - 1
                If lstMetas.Items(i) Is metaSeleccionada Then
                    MessageBox.Show("Esta meta ya estaba introducida")
                    Exit Sub
                End If
            Next
        End If
        lstMetas.Items.Add(metaSeleccionada)
    End Sub
    Private Sub cboProfesor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProfesores.SelectedIndexChanged
        Dim profeSeleccionado As Profesor = TryCast(cboProfesores.SelectedItem, Profesor)
        If profeSeleccionado Is Nothing Then
            Exit Sub
        End If
        If lstProfesores.Items.Count <> 0 Then
            For i As Integer = 0 To lstProfesores.Items.Count - 1
                If lstProfesores.Items(i) Is profeSeleccionado Then
                    MessageBox.Show("Este profesor ya estaba introducido")
                    Exit Sub
                End If
            Next
        End If
        lstProfesores.Items.Add(profeSeleccionado)
    End Sub
    Private Sub cboModulo_SelectedIndexChange(sender As Object, e As EventArgs) Handles cboModulos.SelectedIndexChanged
        Dim moduloSeleccionada As Modulo = TryCast(cboModulos.SelectedItem, Modulo)
        If moduloSeleccionada Is Nothing Then
            Exit Sub
        End If
        If lstModulos.Items.Count <> 0 Then
            For i As Integer = 0 To lstModulos.Items.Count - 1
                If lstModulos.Items(i) Is moduloSeleccionada Then
                    MessageBox.Show("Este modulo ya estaba introducida")
                    Exit Sub
                End If
            Next
        End If
        lstModulos.Items.Add(moduloSeleccionada)
    End Sub
    Private Sub lisas_DoubleClick(sender As Object, e As EventArgs) Handles lstMetas.DoubleClick, lstModulos.DoubleClick, lstProfesores.DoubleClick
        sender.Items.Remove(sender.SelectedItem)

    End Sub

    Private Sub cboCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCursos.SelectedIndexChanged
        Dim cursoSeleccionado As Curso = TryCast(cboCursos.SelectedItem, Curso)
        Dim msg As String = ""
        Dim listaModulos As ReadOnlyCollection(Of Modulo)

        Dim id = cursoSeleccionado.CodCurso

        listaModulos = Gestor.ModulosDeUnCurso(id, msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            Exit Sub
        End If

        cboModulos.Items.Clear()

        For i As Integer = 0 To listaModulos.Count - 1
            cboModulos.Items.Add(listaModulos(i))
        Next
    End Sub

    Private Sub btnAñadirIniciativa_Click(sender As Object, e As EventArgs) Handles btnAñadirIniciativa.Click
        If String.IsNullOrWhiteSpace(txtTitulo.Text) OrElse String.IsNullOrWhiteSpace(txtDescripcionIniciativa.Text) Then
            MessageBox.Show("Debes rellenar todos los campos")
            Exit Sub
        End If
        If lstModulos.Items.Count = 0 OrElse lstMetas.Items.Count = 0 OrElse lstProfesores.Items.Count = 0 Then
            MessageBox.Show("Debe haber mínimo un valor en las listas")
            Exit Sub
        End If
        Dim fechaIn, fechaFin As Date
        If Not Date.TryParse(dtpInicio.Format, fechaIn) Then
            MessageBox.Show("Debe ser una fecha válida")
            Exit Sub
        End If
        If Not Date.TryParse(dtpFin.Format, fechaFin) OrElse fechaFin < fechaIn Then
            MessageBox.Show("Debe ser una fecha válida, y no puede ser anterior a la fecha de inicio")
            Exit Sub
        End If
        'Todo guardar la iniciativa en la BBDD
        Dim oConexion As New SqlConnection(cadenaDeConexion)
        Dim mensaje As String
        Try
            oConexion.Open()
            Dim sql As String = "SELECT CODINICIATIVA, TITULO FROM INICIATIVA WHERE LOWER(INICIATIVA.TITULO) = LOWER(@TITULO)"
            Dim cmdIniciativa As New SqlCommand(sql, oConexion)
            cmdIniciativa.Parameters.AddWithValue("@TITULO", txtTitulo.Text.ToLower)
            Dim drIniciativa As SqlDataReader = cmdIniciativa.ExecuteReader
            Dim iniciativa As Iniciativa = If(drIniciativa.Read(), New Iniciativa(drIniciativa("CODINICIATIVA"), drIniciativa("TITULO").ToString), Nothing)
            'Si no tengo la iniciativa, hay que hacer Insert.
            If iniciativa Is Nothing Then
                sql = "INSERT INTO INICIATIVA (TITULO, DESCRIPCION, [FECHA INICIO], [FECHA FIN], IDSOLICITANTE) VALUES (@TITULO, @DESCRIPCION, @FECHAIN, @FECHAFIN, @IDSOLICITANTE)"
                mensaje = "La iniciativa se ha añadido"
            Else
                'Si ya tengo iniciativa, pregunto si quiere modificarla.
                Dim respuesta As DialogResult = MessageBox.Show($"La iniciativa de nombre {iniciativa.Titulo} ya existía. ¿Deseas actualizarla con los datos introducidos?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If respuesta.No Then
                    MessageBox.Show("No se ha hecho ningún cambio")
                    Exit Sub
                End If
                sql = "UPDATE INICIATIVA SET TITULO = @TITULO, DESCRIPCION = @DESCRIPCION, [FECHA INICIO] = @FECHAIN, [FECHA FIN] = @FECHAFIN, IDSOLICITANTE = @IDSOLICITANTE WHERE CODINICIATIVA = @CODINICIATIVA"
                mensaje = "La iniciativa se ha modificado"
            End If
            'Conseguir solicitante del cboBox.
            Dim miSolicitante As Solicitante = TryCast(cboSolicitantes.SelectedItem, Solicitante)
            Dim idSolicitante As Integer = miSolicitante.IdSolicitante
            'Añadir/modificar iniciativa
            cmdIniciativa = New SqlCommand(sql, oConexion)
            cmdIniciativa.Parameters.AddWithValue("@TITULO", txtTitulo.Text)
            cmdIniciativa.Parameters.AddWithValue("@DESCRIPCION", txtDescripcionIniciativa.Text)
            cmdIniciativa.Parameters.AddWithValue("@FECHAIN", fechaIn)
            cmdIniciativa.Parameters.AddWithValue("@FECHAFIN", fechaFin)
            cmdIniciativa.Parameters.AddWithValue("@IDSOLICITANTE", idSolicitante)
            If iniciativa IsNot Nothing Then cmdIniciativa.Parameters.AddWithValue("@CODINICIATIVA", idSolicitante)
            cmdIniciativa.ExecuteNonQuery()
            'Falta sacar el codigoIniciativa
            Dim sqlCodIniciativa As String = "SELECT INICIATIVA.CODINICIATIVA FROM INICIATIVA WHERE INICIATIVA.CODINICIATIVA = @TITULO"
            'Iniciativa-Profesorado
            Dim sqlIniciativaProfesorado As String = "INSERT INTO INICIATIVA_PROFESORADO(IDPROF, CODINICIATIVA) VALUES (@IDPROF, @CODINICIATIVA)"
            Dim miProfesor As Profesor = cboProfesores.SelectedItem
            Dim cmdIniciativaProfesorado As New SqlCommand(sqlIniciativaProfesorado, oConexion)
            cmdIniciativaProfesorado.Parameters.AddWithValue("@IDPROF", miProfesor.IdProf)
            'cmdIniciativaProfesorado.Parameters.AddWithValue("@CODINICIATIVA", ) 'codigoINiciativa) 
            'Iniciativa-Metas
            Dim misMetas As New List(Of Metas)
            misMetas.AddRange(lstMetas.Items)

        Catch ex As Exception
            mensaje = ex.ToString
        Finally
            oConexion.Close()
            MessageBox.Show(mensaje)
        End Try
    End Sub

    Private Sub cboODSEliminar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODSEliminar.SelectedIndexChanged
        cboMetas.SelectedItem = ""
        Dim odsSeleccionado As ODS = TryCast(cboODS.SelectedItem, ODS)
        Dim msg As String = ""
        Dim listaMetas As ReadOnlyCollection(Of Metas)
        Dim idProv = odsSeleccionado.NumODS
        listaMetas = Gestor.MetasDeUnOds(idProv, msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            Gestor.GuardarErrores(msg)
            cboMetas.Items.Clear()
            Exit Sub
        End If
        cboMetas.Items.Clear()

        For i As Integer = 0 To listaMetas.Count - 1
            cboMetas.Items.Add(listaMetas(i))
        Next
    End Sub

    Private Sub cboMetasEliminar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMetasEliminar.SelectedIndexChanged
        Dim metaSeleccionada As Metas = TryCast(cboMetas.SelectedItem, Metas)
        If metaSeleccionada Is Nothing Then
            Exit Sub
        End If
    End Sub
End Class