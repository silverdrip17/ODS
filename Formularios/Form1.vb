Imports Gestion
Imports Entidades
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visibilidadGeneral(False)
        cboOds.Items.AddRange(Gestor.devolverODS())

    End Sub

    Public Sub visibilidadGeneral(visible As Boolean)
        If visible Then
            lblEditarMetas.Visible = True
            lblEditarOds.Visible = True
            txtEditarMetas.Visible = True
            txtEditarOds.Visible = True
        Else
            lblEditarMetas.Visible = False
            lblEditarOds.Visible = False
            txtEditarMetas.Visible = False
            txtEditarOds.Visible = False
        End If
    End Sub

    Private Sub cboOds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOds.SelectedIndexChanged
        visibilidadGeneral(True)
    End Sub
End Class
