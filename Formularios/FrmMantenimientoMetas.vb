Imports System.Collections.ObjectModel
Imports Entidades
Imports Gestion

Public Class FrmMantenimientoMetas
    Private Sub CambioMetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg As String = ""
        ' todo PROFESORADO Hay que limpiar la lista por si luego se carga este formulario con ShowDialog en lugar de con Show
        btnFoto.Hide()
        Dim misODS = Gestor.DevolverOds(msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            Exit Sub
        End If
        For i As Integer = 0 To misODS.Count - 1
            cboods.Items.Add(misODS(i)) ' todo PROFESORADO Hay que guardar en una lista porque así está llamando continuamente (y si estuviera bien, iendo a la base de datos cada vez)
        Next
    End Sub
    Private Sub LimpiarTextoMetas()
        txtCodigoMeta.Clear()
        txtbNombre.Clear()
        txtDescripcionMeta.Clear()
        cboMetas.Items.Clear()
    End Sub


    Private Sub cboods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboods.SelectedIndexChanged  ' todo PROFESORADO El control debería llamarse cboOds
        DataGridView1.DataSource = Nothing
        Dim odsSeleccionado As ODS = TryCast(cboods.SelectedItem, ODS)
        ' todo PROFESORADO Debe controlar que realmente se ha seleccionado un elemento
        Dim msg As String = ""
        Dim listaMetas As ReadOnlyCollection(Of Metas)

        DataGridView1.DataSource = Nothing ' todo PROFESORADO Cambiar el nombre al control
        Dim idProv = odsSeleccionado.NumODS
        btnFoto.Show()
        btnFoto.BackgroundImage = Image.FromFile($"./Imagenes/{odsSeleccionado.NumODS}.jpg")
        btnFoto.BackgroundImageLayout = ImageLayout.Stretch

        listaMetas = Gestor.MetasDeUnOds(idProv, msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            LimpiarTextoMetas()
            Exit Sub
        End If
        DataGridView1.DataSource = listaMetas
        For i As Integer = 0 To listaMetas.Count - 1
            cboMetas.Items.Add(listaMetas(i))
        Next
        btnFoto.Show()
        btnFoto.BackgroundImage = Image.FromFile($"./Imagenes/{odsSeleccionado.NumODS}.jpg")
        btnFoto.BackgroundImageLayout = ImageLayout.Stretch


    End Sub



    Private Sub cboMetas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMetas.SelectedIndexChanged
        Dim metaSeleccionada As Metas = TryCast(cboMetas.SelectedItem, Metas)
        ' todo PROFESORADO ¿Y si metaSeleccionada está a Nothing? Se provoca error de ejecución
        txtbNombre.Text = metaSeleccionada.Nombre
        txtCodigoMeta.Text = metaSeleccionada.CodMeta
        txtDescripcionMeta.Text = metaSeleccionada.Descripcion
    End Sub

    Private Sub btnGuardarMeta_Click(sender As Object, e As EventArgs) Handles btnGuardarMeta.Click
        If cboods.SelectedItem Is Nothing Then
            MessageBox.Show("Debes seleccionar un ODS")
            Exit Sub
        End If
        Dim odsSeleccionado As ODS = TryCast(cboods.SelectedItem, ODS)
        Dim msg As String = ""
        Gestor.ModificarMeta(odsSeleccionado.NumODS, txtCodigoMeta.Text, txtbNombre.Text, txtDescripcionMeta.Text, msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
        End If

    End Sub
End Class