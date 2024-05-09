Imports System.Collections.ObjectModel
Imports Entidades
Imports Gestion

Public Class CambioMetas
    Private Sub CambioMetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg As String = ""
        btnFoto.Hide()
        'For i As Integer = 0 To Gestor.DevolverOds
        cboods.Items.AddRange(Gestor.DevolverOds(msg).ToArray)
        'Next
    End Sub



    Private Sub cboods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboods.SelectedIndexChanged
        DataGridView1.DataSource = Nothing
        Dim odsSeleccionado As ODS = TryCast(cboods.SelectedItem, ODS)
        Dim msg As String = ""
        Dim listaMetas As ReadOnlyCollection(Of Metas)

        DataGridView1.DataSource = Nothing
        Dim idProv = odsSeleccionado.NumODS
        btnFoto.Show()
        btnFoto.BackgroundImage = Image.FromFile($"./Imagenes/{odsSeleccionado.NumODS}.jpg")
        btnFoto.BackgroundImageLayout = ImageLayout.Stretch

        listaMetas = Gestor.MetasDeUnOds(idProv, msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            cboMetas.Items.Clear()
            Exit Sub
        End If
        DataGridView1.DataSource = listaMetas
        cboMetas.Items.Clear()

        For i As Integer = 0 To listaMetas.Count - 1
            cboMetas.Items.Add(listaMetas(i))
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim msg As String = ""
        Dim odsSeleccionado As ODS = TryCast(cboods.SelectedItem, ODS)
        For i As Integer = 0 To odsSeleccionado.ListaMetas.Count - 1
            Dim metaComparar As Metas = TryCast(odsSeleccionado.ListaMetas(i), Metas)
            Dim metaAñadir As Metas
            metaAñadir.NumODS = odsSeleccionado.NumODS
            metaAñadir.Nombre = txtbNombre.Text
            metaAñadir.CodMeta = metaComparar.NumODS + "." + txtCodigoMeta.Text
            metaAñadir.Descripcion = txtDescripcionMeta.Text
            If metaComparar.CodMeta = metaAñadir.CodMeta Then
                MessageBox.Show("Ya existe una meta con este código")
                Exit Sub
            End If
            'Gestor.AñadirMetaAODS(odsSeleccionado.NumODS, metaAñadir)
            Gestor.MetasDeUnOds(odsSeleccionado.NumODS, msg)
        Next
    End Sub

    Private Sub cboMetas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMetas.SelectedIndexChanged
        Dim metaSeleccionada As Metas = TryCast(cboMetas.SelectedItem, Metas)
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