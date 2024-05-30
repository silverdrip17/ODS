Imports Entidades

Public Class FrmDatosDeCursos
    Private Enum EstadoCurso
        EligiendoCurso = 0
        EligiendoDtoCurso = 1
        MostrandoDatosDtoCurso = 2
    End Enum
    Private estado As EstadoCurso
    Private Sub FrmDatosDeCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msgError As String = ""
        cboCursos.Items.AddRange(Gestor.DevolverCursos(msgError).ToArray)
        MostrarVista()
    End Sub
    Private Sub MostrarVista()
        lstIniciativas.Visible = (estado = EstadoCurso.EligiendoDtoCurso) OrElse (estado = EstadoCurso.MostrandoDatosDtoCurso)
        grbCurso.Visible = estado = EstadoCurso.MostrandoDatosDtoCurso
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub cboCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCursos.SelectedIndexChanged
        If cboCursos.SelectedItem Is Nothing Then
            estado = EstadoCurso.EligiendoCurso
            MostrarVista()
            Exit Sub
        End If
        Dim miCurso As Curso = TryCast(cboCursos.SelectedItem, Curso)
        lstIniciativas.Items.Clear()
        Dim msgError As String = ""
        lstIniciativas.Items.AddRange(Gestor.DatosCurso(miCurso, msgError).ToArray)
        If Not String.IsNullOrWhiteSpace(msgError) Then
            MessageBox.Show(msgError)
        Else
            estado = EstadoCurso.EligiendoDtoCurso
        End If
        MostrarVista()
    End Sub

    Private Sub lstIniciativas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIniciativas.SelectedIndexChanged
        If lstIniciativas.SelectedItem Is Nothing Then
            estado = EstadoCurso.EligiendoDtoCurso
            Exit Sub
        End If
        Dim miDtoCurso As DtoCurso = TryCast(lstIniciativas.SelectedItem, DtoCurso)
        lblIniciativa.Text = If(miDtoCurso.Iniciativa <> Nothing, miDtoCurso.Iniciativa, "")
        lblMeta.Text = If(miDtoCurso.Meta <> Nothing, miDtoCurso.Meta, "")
        lblModulo.Text = If(miDtoCurso.Modulo <> Nothing, miDtoCurso.Modulo, "")
        lblOds.Text = If(miDtoCurso.ODS <> Nothing, miDtoCurso.ODS, "")
        lblProfesora.Text = If(miDtoCurso.ProfesorA <> Nothing, miDtoCurso.ProfesorA, "")
        estado = EstadoCurso.MostrandoDatosDtoCurso
        MostrarVista()
    End Sub

    'Aun no se usa
    Private Sub LimpiarControles()
        lblIniciativa.Text = ""
        lblMeta.Text = ""
        lblModulo.Text = ""
        lblOds.Text = ""
        lblProfesora.Text = ""
    End Sub
End Class