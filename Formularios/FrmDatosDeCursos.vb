Public Class FrmDatosDeCursos
    Private Sub FrmDatosDeCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msgError As String = ""
        cboCursos.Items.AddRange(Gestor.DevolverCursos(msgError).ToArray)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub cboCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCursos.SelectedIndexChanged
        If cboCursos.SelectedItem Is Nothing Then Exit Sub
    End Sub
End Class