﻿Imports System.Data.SqlClient
Imports Entidades

Public Class FrmMantenimientoODS
    Private Sub FrmMantenimientoODS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg As String = ""
        btnfoto.Hide()
        Dim misODS = Gestor.DevolverOds(msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            Gestor.GuardarErrores(msg)
            Exit Sub
        End If
        For i As Integer = 0 To misODS.Count - 1
            cboODS.Items.Add(misODS(i)) ' todo PROFESORADO Hay que guardar en una lista porque así está llamando continuamente (y si estuviera bien, iendo a la base de datos cada vez)
        Next
    End Sub

    Private Sub cboODS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODS.SelectedIndexChanged
        Dim odsSeleccionado As ODS = TryCast(cboODS.SelectedItem, ODS)
        If odsSeleccionado Is Nothing Then
            Exit Sub
        End If
        txtDescripcionODS.Text = odsSeleccionado.Descripcion
        txtNombreODS.Text = odsSeleccionado.Nombre
        txtNumODS.Text = odsSeleccionado.NumODS
        btnfoto.Show()
        btnfoto.BackgroundImage = Image.FromFile($"./Imagenes/{odsSeleccionado.NumODS}.jpg") ' todo PROFESORADO ¿Y si no existe el fichero? ¿Y si está corrupto?
        btnfoto.BackgroundImageLayout = ImageLayout.Stretch

    End Sub


    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        Dim msg As String = ""
        Gestor.ModificarOds(txtNumODS.Text, txtNombreODS.Text, txtDescripcionODS.Text, msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            Gestor.GuardarErrores(msg)
            Exit Sub
        End If
        ' todo PROFESORADO NO hace nada con el posible mensaje de error y si es función con el valor devuelto
    End Sub

End Class