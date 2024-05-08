Public Class Modulo
    Public Property CodCurso As Integer
    Public Property CodModulo As Integer

    Public Property Nombre As String

    Public Sub New()

    End Sub
    Public Sub New(codCurso As Integer, codModulo As Integer, nombre As String)
        Me.CodCurso = codCurso
        Me.CodModulo = codModulo
        Me.Nombre = nombre
    End Sub
    Public Overrides Function ToString() As String
        Return Me.Nombre.ToString()
    End Function
End Class
