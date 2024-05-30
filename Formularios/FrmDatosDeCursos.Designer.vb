<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatosDeCursos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grbCurso = New System.Windows.Forms.GroupBox()
        Me.lstIniciativas = New System.Windows.Forms.ListBox()
        Me.grbCurso.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCursos
        '
        Me.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Location = New System.Drawing.Point(34, 79)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(158, 24)
        Me.cboCursos.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(239, 366)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(181, 50)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INICIATIVA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ODS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "META"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(204, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 30)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MODULO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(204, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 30)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "PROFESOR/A"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbCurso
        '
        Me.grbCurso.Controls.Add(Me.Label3)
        Me.grbCurso.Controls.Add(Me.Label5)
        Me.grbCurso.Controls.Add(Me.Label1)
        Me.grbCurso.Controls.Add(Me.Label4)
        Me.grbCurso.Controls.Add(Me.Label2)
        Me.grbCurso.Location = New System.Drawing.Point(396, 79)
        Me.grbCurso.Name = "grbCurso"
        Me.grbCurso.Size = New System.Drawing.Size(354, 252)
        Me.grbCurso.TabIndex = 7
        Me.grbCurso.TabStop = False
        Me.grbCurso.Text = "GroupBox1"
        '
        'lstIniciativas
        '
        Me.lstIniciativas.FormattingEnabled = True
        Me.lstIniciativas.ItemHeight = 16
        Me.lstIniciativas.Location = New System.Drawing.Point(34, 183)
        Me.lstIniciativas.Name = "lstIniciativas"
        Me.lstIniciativas.Size = New System.Drawing.Size(208, 148)
        Me.lstIniciativas.TabIndex = 8
        '
        'FrmDatosDeCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstIniciativas)
        Me.Controls.Add(Me.grbCurso)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.cboCursos)
        Me.Name = "FrmDatosDeCursos"
        Me.Text = "DATOS DE LOS CURSOS"
        Me.grbCurso.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboCursos As ComboBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents grbCurso As GroupBox
    Friend WithEvents lstIniciativas As ListBox
End Class
