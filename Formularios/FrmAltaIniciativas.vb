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

    Private Sub lblMódulos_Click(sender As Object, e As EventArgs) Handles lblMódulos.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMetas.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMetas.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub lblCursos_Click(sender As Object, e As EventArgs) Handles lblCursos.Click

    End Sub

    Private Sub cboCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCursos.SelectedIndexChanged

    End Sub

    Private Sub lblModulosSeleccionados_Click(sender As Object, e As EventArgs) Handles lblModulosSeleccionados.Click

    End Sub

    Private Sub lstModulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstModulos.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub lstCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCursos.SelectedIndexChanged

    End Sub

    Private Sub cboModulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModulos.SelectedIndexChanged

    End Sub
End Class