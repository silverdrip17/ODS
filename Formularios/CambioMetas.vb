Imports System.Collections.ObjectModel
Imports Entidades
Imports Gestion

Public Class CambioMetas
    Private Sub CambioMetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Gestor.MisODS.Count - 1
            cboods.Items.Add(Gestor.MisODS(i))
        Next
    End Sub



    Private Sub cboods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboods.SelectedIndexChanged
        'Dim odsSeleccionado As ODS = TryCast(cboods.SelectedItem, ODS)
        'If odsSeleccionado Is Nothing Then
        '    Exit Sub
        'End If
        'If odsSeleccionado.ListaMetas.Count = 0 Then
        '    MessageBox.Show("NO HAY METAS EN ESTE ODS")
        '    Exit Sub
        'End If
        'For i As Integer = 0 To odsSeleccionado.ListaMetas.Count - 1
        '    cboMetas.Items.Add(odsSeleccionado.ListaMetas(i))
        'Next
        Dim odsSeleccionado As ODS = TryCast(cboods.SelectedItem, ODS)
        Dim msg As String = ""
        Dim listaMetas As ReadOnlyCollection(Of Metas)

        DataGridView1.DataSource = Nothing
        Dim idProv = odsSeleccionado.NumODS

        listaMetas = Gestor.MetasDeUnOds(idProv, msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            Exit Sub
        End If
        DataGridView1.DataSource = listaMetas
        For i As Integer = 0 To listaMetas.Count - 1
            cboMetas.Items.Add(listaMetas(i))
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarMeta.Click
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
            Gestor.AñadirMetaAODS(odsSeleccionado.NumODS, metaAñadir)



        Next
    End Sub

    Private Sub cboMetas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMetas.SelectedIndexChanged
        Dim metaSeleccionada As Metas = TryCast(cboMetas.SelectedItem, Metas)
        txtbNombre.Text = metaSeleccionada.Nombre
        txtCodigoMeta.Text = metaSeleccionada.CodMeta
        txtDescripcionMeta.Text = metaSeleccionada.Descripcion
    End Sub
End Class