Imports Gestion
Imports Entidades
Imports System.Collections.ObjectModel
Public Class Form1

    Private Sub BtnTodasOds_Click(sender As Object, e As EventArgs) ' todo PROFESORADO Si no hace nada, quitarlo
        'dgvods.DataSource = Gestor.DevolverODS
    End Sub

    Private Sub btnTodasOds_Click_1(sender As Object, e As EventArgs) Handles btnTodasOds.Click ' todo PROFESORADO Quitar el _1
        Dim msg As String = ""
        Dim listaOds As ReadOnlyCollection(Of ODS)

        dgvOds.DataSource = False 'todo PROFESORADO ¿cómo?
        listaOds = Gestor.GuardarOds(msg) ' todo PROFESORADO Si devuelve un msg, habrá que hacer algo con el 
        dgvOds.DataSource = listaOds
        dgvOds.Columns("imagen").Visible = False ' todo Si había errores no existirá esta columna y provocará error de ejecución

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
    End Sub
End Class
