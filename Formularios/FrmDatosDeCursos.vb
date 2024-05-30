Public Class FrmDatosDeCursos
    Private Sub FrmDatosDeCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msgError As String = ""
        cboCursos.Items.AddRange(Gestor.DevolverCursos(msgError).ToArray)
    End Sub
End Class