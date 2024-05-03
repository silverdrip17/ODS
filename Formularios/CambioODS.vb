Imports System.Data.SqlClient
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


    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        Dim msg As String = ""
        Gestor.ModificarOds(txtNumODS.Text, txtNombreODS.Text, txtDescripcionODS.Text, msg)
    End Sub
    Public Sub ModificarMeta(metamodificar As Meta, ByRef mensajerror As String)
        Dim oConexion As New SqlConnection(CADENA_CONEXION)
        Try
            oConexion.Open()
            Dim sql As String = "SELECT DESCRIPCION FROM Metas WHERE IDODS = @IDODS AND NUMERO = @NUMERO"
            Dim cmdLeerMeta As New SqlCommand(sql, oConexion)
            cmdLeerMeta.Parameters.AddWithValue("@IDODS", metamodificar.IdODS)
            cmdLeerMeta.Parameters.AddWithValue("@NUMERO", metamodificar.Numero)
            Dim drMeta As SqlDataReader = cmdLeerMeta.ExecuteReader()
            If drMeta.Read() Then
                sql = "UPDATE Metas SET DESCRIPCION = @descripcion WHERE IDODS = @IDODS AND NUMERO = @NUMERO"
                Dim cmdCambiarDesc As New SqlCommand(sql, oConexion)
                cmdCambiarDesc.Parameters.AddWithValue("@descripcion", metamodificar.Descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@IDODS", metamodificar.IdODS)
                cmdCambiarDesc.Parameters.AddWithValue("@NUMERO", metamodificar.Numero)
                cmdCambiarDesc.ExecuteNonQuery()
                mensajerror = "La meta ha sido modificada exitosamente."
            Else
                sql = "INSERT INTO Metas (IDODS, NUMERO, DESCRIPCION) VALUES (@IDODS, @NUMERO, @descripcion)"
                Dim cmdCambiarDesc As New SqlCommand(sql, oConexion)
                cmdCambiarDesc.Parameters.AddWithValue("@descripcion", metamodificar.Descripcion)
                cmdCambiarDesc.Parameters.AddWithValue("@IDODS", metamodificar.IdODS)
                cmdCambiarDesc.Parameters.AddWithValue("@NUMERO", metamodificar.Numero)
                cmdCambiarDesc.ExecuteNonQuery()
                mensajerror = "La meta ha sido creada."
            End If
        Catch ex As Exception
            mensajerror = ex.ToString
        Finally
            oConexion.Close()
        End Try
    End Sub
End Class