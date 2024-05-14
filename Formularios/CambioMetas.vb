Imports System.Collections.ObjectModel
Imports Entidades
Imports Gestion

Public Class CambioMetas
    Private Sub CambioMetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg As String = ""
        ' todo PROFESORADO Hay que limpiar la lista por si luego se carga este formulario con ShowDialog en lugar de con Show
        btnFoto.Hide()
        For i As Integer = 0 To Gestor.MisODS.Count - 1
            cboods.Items.Add(Gestor.MisODS(i)) ' todo PROFESORADO Hay que guardar en una lista porque así está llamando continuamente (y si estuviera bien, iendo a la base de datos cada vez)
        Next
    End Sub
    Private Sub LimpiarTextoMetas()
        txtCodigoMeta.Clear()
        txtbNombre.Clear()
        txtDescripcionMeta.Clear()
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
            'LimpiarTextoMetas()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarMeta.Click 'todo PROFESORADO Nombre de método nada significativo Button1_Click
        ' todo PROFESORADO Puede no haber ODS o luego Meta seleccionada
        Dim odsSeleccionado As ODS = TryCast(cboods.SelectedItem, ODS)
        ' todo PROFESORADO ¿Este For para buscar si el odsSeleccionado ya contiene la meta? Y para que se define el método Equals de Meta entonces? En cambio así no tiene sentido
        For i As Integer = 0 To odsSeleccionado.ListaMetas.Count - 1
            Dim metaComparar As Metas = TryCast(odsSeleccionado.ListaMetas(i), Metas)
            Dim metaAñadir As Metas
            metaAñadir.NumODS = odsSeleccionado.NumODS ' todo Provocará error de ejecución pues metaAñadir es Nothing
            metaAñadir.Nombre = txtbNombre.Text
            metaAñadir.CodMeta = metaComparar.NumODS + "." + txtCodigoMeta.Text ' todo PROFESORADO ¿Cómo?
            metaAñadir.Descripcion = txtDescripcionMeta.Text
            If metaComparar.CodMeta = metaAñadir.CodMeta Then ' todo PROFESORADO Esto así no funciona pero además lo lógico es que esto lo contemple el propio método de AñadirMetaAODS
                MessageBox.Show("Ya existe una meta con este código")
                Exit Sub
            End If
            Gestor.AñadirMetaAODS(odsSeleccionado.NumODS, metaAñadir) ' todo PROFESORADO ERROR GRAVE, lo intentará hacer odsSeleccionado.ListaMetas.Count - 1 o odsSeleccionado.ListaMetas.Count - 2 veces



        Next
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