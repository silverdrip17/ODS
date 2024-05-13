Public Class Profesor
    Implements IEquatable(Of Profesor)

    Public Property IdProf As Integer
    Public Property Nombre As String

    Public Sub New()
    End Sub
    Public Sub New(codCurso As Integer, nombre As String)
        Me.IdProf = codCurso
        Me.Nombre = nombre
    End Sub
    Public Overrides Function ToString() As String
        Return Me.Nombre.ToString()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Profesor))
    End Function

    Public Overloads Function Equals(other As Profesor) As Boolean Implements IEquatable(Of Profesor).Equals
        Return other IsNot Nothing AndAlso
               IdProf = other.IdProf
    End Function
End Class
