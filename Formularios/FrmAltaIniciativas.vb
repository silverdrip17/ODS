Imports System.Collections.ObjectModel
Imports Entidades

Public Class FrmAltaIniciativas
    Private Sub FrmAltaIniciativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg As String = ""
        cboODS.Items.AddRange(Gestor.DevolverOds(msg).ToArray)
        cboSolicitantes.Items.AddRange(Gestor.DevolverSolicitantes(msg).ToArray)
        cboProfesores.Items.AddRange(Gestor.DevolverProfesores(msg).ToArray)
        cboCursos.Items.AddRange(Gestor.DevolverCursos(msg).ToArray)
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

    Private Sub lblMódulos_Click(sender As Object, e As EventArgs) Handles lblMódulos.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMetas.SelectedIndexChanged
        Dim metaSeleccionada As Metas = TryCast(cboMetas.SelectedItem, Metas)
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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMetas.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub lblCursos_Click(sender As Object, e As EventArgs) Handles lblCursos.Click

    End Sub
    Private Sub lstMetas_DoubleClick(sender As Object, e As EventArgs) Handles lstMetas.DoubleClick
        lstMetas.Items.Remove(lstMetas.SelectedItem)

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

    Private Sub lblModulosSeleccionados_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstModulos_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub lstCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstModulos.SelectedIndexChanged

    End Sub

    Private Sub cboModulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModulos.SelectedIndexChanged

    End Sub

    Private Sub btnAñadirIniciativa_Click(sender As Object, e As EventArgs) Handles btnAñadirIniciativa.Click
        If String.IsNullOrWhiteSpace(txtTitulo.Text) OrElse String.IsNullOrWhiteSpace(txtDescripcionIniciativa.Text) Then
            MessageBox.Show("Debes rellenar todos los campos")
        End If
        If lstModulos.Items.Count = 0 OrElse lstMetas.Items.Count = 0 OrElse lstSolicitantes.Items.Count = 0 OrElse lstProfesores.Items.Count = 0 Then
            MessageBox.Show("Debe haber mínimo un valor en las listas")
        End If
    End Sub
End Class