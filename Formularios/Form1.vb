Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visibiladadGeneral(False)
    End Sub

    Public Sub visibiladadGeneral(visible As Boolean)
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
End Class
