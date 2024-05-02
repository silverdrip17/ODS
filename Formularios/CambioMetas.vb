Imports Entidades
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
        For i As Integer = 0 To odsSeleccionado.ListaMetas.Count - 1
            cboMetas.Items.Add(odsSeleccionado.ListaMetas(i))
        Next
    End Sub
End Class