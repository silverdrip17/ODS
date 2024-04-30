Imports Gestion
Imports Entidades
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisibilidadGeneral(False)

    End Sub

    Public Sub VisibilidadGeneral(visible As Boolean)
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
    Private Sub BtnTodasOds_Click(sender As Object, e As EventArgs)
        'dgvods.DataSource = Gestor.DevolverODS
    End Sub
End Class
