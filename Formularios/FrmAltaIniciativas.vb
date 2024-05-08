Imports Entidades

Public Class FrmAltaIniciativas
    Private Sub FrmAltaIniciativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg As String = ""
        cboOds.Items.AddRange(Gestor.DevolverOds(msg).ToArray)
        lstMetas.Hide()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOds.SelectedIndexChanged
        lstMetas.Items.Clear()
        If cboOds.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim odsSeleccionado As ODS = TryCast(cboOds.SelectedItem, ODS)
        Dim misMetas As New List(Of Metas)
        Dim msg As String = ""
        misMetas.AddRange(Gestor.MetasDeUnOds(odsSeleccionado.NumODS.ToString, msg))
        If msg <> "" Then
            MessageBox.Show(msg)
            Exit Sub
        End If
        lstMetas.Items.AddRange(misMetas.ToArray)
    End Sub


End Class