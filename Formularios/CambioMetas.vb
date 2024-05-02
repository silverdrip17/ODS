Imports Gestion

Public Class CambioMetas
    Private Sub CambioMetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Gestor.MisODS.Count - 1
            cboods.Items.Add(Gestor.MisODS(i))
        Next
    End Sub

    Private Sub Descripcion_Click(sender As Object, e As EventArgs) Handles lblDescripcion.Click

    End Sub

    Private Sub cboods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboods.SelectedIndexChanged

    End Sub
End Class