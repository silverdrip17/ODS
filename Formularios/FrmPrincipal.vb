﻿Imports Gestion
Imports Entidades
Imports System.Collections.ObjectModel
Public Class FrmPrincipal

    Private Sub BtnTodasOds_Click(sender As Object, e As EventArgs) ' todo PROFESORADO Si no hace nada, quitarlo
        'dgvods.DataSource = Gestor.DevolverODS
    End Sub

    Private Sub btnTodasOds_Click_1(sender As Object, e As EventArgs) Handles btnTodasOds.Click ' todo PROFESORADO Quitar el _1
        Dim msg As String = ""
        Dim listaOds As ReadOnlyCollection(Of ODS)

        dgvOds.DataSource = Nothing
        listaOds = Gestor.DevolverOds(msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            Exit Sub
        End If
        dgvOds.DataSource = listaOds
        dgvOds.Columns("imagen").Visible = False


        btnIniciativa.Show()
        btnCambiosMetas.Show()
        btnCambiosODS.Show()
    End Sub

    Private Sub btnCambiosMetas_Click(sender As Object, e As EventArgs) Handles btnCambiosMetas.Click
        Dim forMetas As New FrmMantenimientoMetas
        forMetas.Show()
    End Sub

    Private Sub btnCambiosODS_Click(sender As Object, e As EventArgs) Handles btnCambiosODS.Click
        Dim forOds As New FrmMantenimientoODS
        forOds.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCambiosMetas.Hide()
        btnCambiosODS.Hide()
        btnIniciativa.Hide()
    End Sub

    Private Sub btnIniciativa_Click(sender As Object, e As EventArgs) Handles btnIniciativa.Click
        FrmAltaIniciativas.Show()
    End Sub
End Class