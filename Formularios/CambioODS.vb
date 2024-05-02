Imports Entidades

Public Class CambioODS
    Private Sub CambioODS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Gestor.MisODS.Count - 1
            cboODS.Items.Add(Gestor.MisODS(i))
        Next
    End Sub

    Private Sub cboODS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODS.SelectedIndexChanged
        Dim odsSeleccionado As ODS = TryCast(cboODS.SelectedItem, ODS)

    End Sub
End Class