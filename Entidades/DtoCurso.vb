Public Class DtoCurso
    Public Property Iniciativa As String
    Public Property Meta As String
    Public Property ODS As String
    Public Property Modulo As String
    Public Property ProfesorA As String
    Public Property IdCurso As Integer

    Public Sub New()
    End Sub
    Public Sub New(idCurso As Integer)
        Me.IdCurso = idCurso
    End Sub

    Public Sub New(idcurso As Integer, iniciativa As String, meta As String, ods As String, modulo As String, profesorA As String)
        Me.New(idcurso)
        Me.Iniciativa = iniciativa
        Me.Meta = meta
        Me.ODS = ods
        Me.Modulo = modulo
        Me.ProfesorA = profesorA
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Iniciativa.ToString() + Me.Meta.ToString + Me.ODS.ToString + Me.Modulo.ToString + Me.ProfesorA.ToString
    End Function
End Class
