Imports Entidades

Public Class FrmAltaIniciativas
    Private Sub FrmAltaIniciativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboOds.Items.AddRange(Gestor.MisODS.ToArray)
        lstMetas.Hide()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOds.SelectedIndexChanged
        Dim miListaOds As ComboBox = TryCast(sender, ComboBox)
        If miListaOds.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim odsSeleccionado As ODS = TryCast(miListaOds.SelectedItem, ODS)
        lstMetas.Items.AddRange(odsSeleccionado.ListaMetas.ToArray)
    End Sub


End Class