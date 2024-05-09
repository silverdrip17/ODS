Imports Entidades

Public Class FrmAltaIniciativas
    Private Sub FrmAltaIniciativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg As String = ""
        cboSolicitantes.Items.AddRange(Gestor.DevolverOds(msg).ToArray)
        lstProfesores.Hide()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSolicitantes.SelectedIndexChanged
        lstProfesores.Items.Clear()
        If cboSolicitantes.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim odsSeleccionado As ODS = TryCast(cboSolicitantes.SelectedItem, ODS)
        Dim misMetas As New List(Of Metas)
        Dim msg As String = ""
        misMetas.AddRange(Gestor.MetasDeUnOds(odsSeleccionado.NumODS.ToString, msg))
        If msg <> "" Then
            MessageBox.Show(msg)
            Exit Sub
        End If
        lstProfesores.Items.AddRange(misMetas.ToArray)
        lstProfesores.Show()
    End Sub
End Class