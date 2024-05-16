Imports Gestion
Imports Entidades
Imports System.Collections.ObjectModel
Public Class FrmPrincipal

    Private Sub BtnTodasOds_Click(sender As Object, e As EventArgs) ' todo PROFESORADO Si no hace nada, quitarlo
        'dgvods.DataSource = Gestor.DevolverODS
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
        Dim msg As String = ""
        Dim listaOds As ReadOnlyCollection(Of ODS)

        listaOds = Gestor.DevolverOds(msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            Gestor.GuardarError(msg)
            Exit Sub
        End If

    End Sub

    Private Sub btnIniciativa_Click(sender As Object, e As EventArgs) Handles btnIniciativa.Click
        FrmAltaIniciativas.Show()
    End Sub
End Class
