Imports Entidades

Public Class CambioODS
    Private Sub CambioODS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnfoto.Hide()
        For i As Integer = 0 To Gestor.MisODS.Count - 1
            cboODS.Items.Add(Gestor.MisODS(i))
        Next
    End Sub

    Private Sub cboODS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODS.SelectedIndexChanged
        Dim odsSeleccionado As ODS = TryCast(cboODS.SelectedItem, ODS)
        If odsSeleccionado Is Nothing Then
            Exit Sub
        End If
        txtDescripcionODS.Text = odsSeleccionado.Descripcion
        txtNombreODS.Text = odsSeleccionado.Nombre
        txtNumODS.Text = odsSeleccionado.NumODS
        btnfoto.Show()
        btnfoto.BackgroundImage = Image.FromFile($"./Imagenes/{odsSeleccionado.NumODS}.jpg")
        btnfoto.BackgroundImageLayout = ImageLayout.Stretch

    End Sub
End Class