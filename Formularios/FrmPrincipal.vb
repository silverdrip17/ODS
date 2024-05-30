Imports Gestion
Imports Entidades
Imports System.Collections.ObjectModel
Public Class FrmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg As String = ""
        Dim listaOds As ReadOnlyCollection(Of ODS)
        listaOds = Gestor.DevolverOds(msg)
        If Not String.IsNullOrWhiteSpace(msg) Then
            MessageBox.Show(msg)
            'Gestor.GuardarErrores(msg)
            Exit Sub
        End If
    End Sub

    Private Sub METASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles METASToolStripMenuItem.Click
        Dim forMetas As New FrmMantenimientoMetas
        Me.Hide()
        forMetas.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ODSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ODSToolStripMenuItem.Click
        Dim forOds As New FrmMantenimientoODS
        Me.Hide()
        forOds.ShowDialog()
        Me.Show()
    End Sub

    Private Sub INICIATIVASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INICIATIVASToolStripMenuItem.Click
        Dim forIniciativas As New FrmAltaIniciativas
        Me.Hide()
        forIniciativas.ShowDialog()
        Me.Show()
    End Sub

    Private Sub CURSOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CURSOSToolStripMenuItem.Click
        Dim forCursos As New FrmDatosDeCursos
        Me.Hide()
        forCursos.ShowDialog()
        Me.Show()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
