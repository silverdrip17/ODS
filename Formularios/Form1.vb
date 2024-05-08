﻿Imports Gestion
Imports Entidades
Imports System.Collections.ObjectModel
Public Class Form1

    Private Sub BtnTodasOds_Click(sender As Object, e As EventArgs)
        'dgvods.DataSource = Gestor.DevolverODS
    End Sub

    Private Sub btnTodasOds_Click_1(sender As Object, e As EventArgs) Handles btnTodasOds.Click
        Dim msg As String = ""
        Dim listaOds As ReadOnlyCollection(Of ODS)

        dgvOds.DataSource = False
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
        Dim forMetas As New CambioMetas
        forMetas.Show()
    End Sub

    Private Sub btnCambiosODS_Click(sender As Object, e As EventArgs) Handles btnCambiosODS.Click
        Dim forOds As New CambioODS
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
