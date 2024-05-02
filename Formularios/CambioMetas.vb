﻿Imports Entidades
Imports Gestion

Public Class CambioMetas
    Private Sub CambioMetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Gestor.MisODS.Count - 1
            cboods.Items.Add(Gestor.MisODS(i))
        Next
    End Sub



    Private Sub cboods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboods.SelectedIndexChanged
        Dim odsSeleccionado As ODS = TryCast(cboods.SelectedItem, ODS)
        If odsSeleccionado Is Nothing Then
            Exit Sub
        End If
        If odsSeleccionado.ListaMetas.Count = 0 Then
            MessageBox.Show("NO HAY METAS EN ESTE ODS")
            Exit Sub
        End If
        For i As Integer = 0 To odsSeleccionado.ListaMetas.Count - 1
            cboMetas.Items.Add(odsSeleccionado.ListaMetas(i))
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



        Next
    End Sub
End Class