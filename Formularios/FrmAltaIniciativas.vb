Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports Entidades

Public Class FrmAltaIniciativas
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
        If Not Date.TryParse(dtpInicio.Value, fechaIn) Then
            MessageBox.Show("Debe ser una fecha válida")
            Exit Sub
        End If
        If Not Date.TryParse(dtpFin.Value, fechaFin) OrElse fechaFin <= fechaIn Then
            MessageBox.Show("Debe ser una fecha válida, y además superior a la fecha de inicio")
            Exit Sub
        End If
        Dim iniciativaNueva As New Iniciativa
        iniciativaNueva.Descripcion = txtDescripcionIniciativa.Text
        iniciativaNueva.Solicitante = cboSolicitantes.SelectedItem
        iniciativaNueva.FechaInicio = fechaIn
        iniciativaNueva.FechaFin = fechaFin
        iniciativaNueva.Titulo = txtTitulo.Text

        For i As Integer = 0 To lstMetas.Items.Count - 1
            Dim meta As Metas = lstMetas.Items(i)
            iniciativaNueva.ListaMetas.Add(meta)
        Next
        For i As Integer = 0 To lstModulos.Items.Count - 1
            Dim modulo As Modulo = lstModulos.Items(i)
            iniciativaNueva.Modulos.Add(modulo)
        Next
        For i As Integer = 0 To lstProfesores.Items.Count - 1
            Dim profe As Profesor = lstProfesores.Items(i)
            iniciativaNueva.Profesores.Add(profe)
        Next
        Dim msgError = ""
        Gestor.AnadirIniciativa(iniciativaNueva, msgError)
        MessageBox.Show(msgError)
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

    Private Sub cboIniciativasEliminar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIniciativasEliminar.SelectedIndexChanged
        Dim msg As String = ""
        dgvIniciativas.DataSource = Nothing
        Dim listaIniciativa As ReadOnlyCollection(Of Iniciativa)
        listaIniciativa = Gestor.DevolverIniciativa(msg)
        dgvIniciativas.DataSource = listaIniciativa
    End Sub
    Private Sub btnEliminarIniciativas_Click(sender As Object, e As EventArgs) Handles btnEliminarIniciativas.Click
        Dim msg As String = ""
        Dim iniciativaAEliminar As Iniciativa = TryCast(cboIniciativasEliminar.SelectedItem, Iniciativa)
        MessageBox.Show(Gestor.EliminarIniciativa(iniciativaAEliminar))
        cboIniciativasEliminar.Items.Clear()
        cboIniciativasEliminar.Text = ""
        cboIniciativasEliminar.Items.AddRange(Gestor.DevolverIniciativa(msg).ToArray)
    End Sub
End Class