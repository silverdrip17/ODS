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
        Me.lblIniciativa = New System.Windows.Forms.Label()
        Me.lblModulo = New System.Windows.Forms.Label()
        Me.lblMeta = New System.Windows.Forms.Label()
        Me.lblOds = New System.Windows.Forms.Label()
        Me.lblProfesora = New System.Windows.Forms.Label()
        Me.grbCurso.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCursos
        '
        Me.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Location = New System.Drawing.Point(34, 62)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(158, 24)
        Me.cboCursos.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(240, 360)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(153, 50)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INICIATIVA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ODS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "META"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MODULO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "PROFESOR/A"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grbCurso
        '
        Me.grbCurso.Controls.Add(Me.lblProfesora)
        Me.grbCurso.Controls.Add(Me.lblOds)
        Me.grbCurso.Controls.Add(Me.lblMeta)
        Me.grbCurso.Controls.Add(Me.lblModulo)
        Me.grbCurso.Controls.Add(Me.lblIniciativa)
        Me.grbCurso.Controls.Add(Me.Label3)
        Me.grbCurso.Controls.Add(Me.Label5)
        Me.grbCurso.Controls.Add(Me.Label1)
        Me.grbCurso.Controls.Add(Me.Label4)
        Me.grbCurso.Controls.Add(Me.Label2)
        Me.grbCurso.Location = New System.Drawing.Point(396, 62)
        Me.grbCurso.Name = "grbCurso"
        Me.grbCurso.Size = New System.Drawing.Size(392, 242)
        Me.grbCurso.TabIndex = 7
        Me.grbCurso.TabStop = False
        '
        'lstIniciativas
        '
        Me.lstIniciativas.FormattingEnabled = True
        Me.lstIniciativas.ItemHeight = 16
        Me.lstIniciativas.Location = New System.Drawing.Point(34, 156)
        Me.lstIniciativas.Name = "lstIniciativas"
        Me.lstIniciativas.Size = New System.Drawing.Size(208, 148)
        Me.lstIniciativas.TabIndex = 8
        '
        'lblIniciativa
        '
        Me.lblIniciativa.BackColor = System.Drawing.SystemColors.Info
        Me.lblIniciativa.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblIniciativa.Location = New System.Drawing.Point(149, 23)
        Me.lblIniciativa.Name = "lblIniciativa"
        Me.lblIniciativa.Size = New System.Drawing.Size(206, 23)
        Me.lblIniciativa.TabIndex = 7
        '
        'lblModulo
        '
        Me.lblModulo.BackColor = System.Drawing.SystemColors.Info
        Me.lblModulo.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblModulo.Location = New System.Drawing.Point(149, 63)
        Me.lblModulo.Name = "lblModulo"
        Me.lblModulo.Size = New System.Drawing.Size(206, 23)
        Me.lblModulo.TabIndex = 8
        '
        'lblMeta
        '
        Me.lblMeta.BackColor = System.Drawing.SystemColors.Info
        Me.lblMeta.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblMeta.Location = New System.Drawing.Point(149, 102)
        Me.lblMeta.Name = "lblMeta"
        Me.lblMeta.Size = New System.Drawing.Size(206, 23)
        Me.lblMeta.TabIndex = 9
        '
        'lblOds
        '
        Me.lblOds.BackColor = System.Drawing.SystemColors.Info
        Me.lblOds.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblOds.Location = New System.Drawing.Point(149, 141)
        Me.lblOds.Name = "lblOds"
        Me.lblOds.Size = New System.Drawing.Size(206, 23)
        Me.lblOds.TabIndex = 10
        '
        'lblProfesora
        '
        Me.lblProfesora.BackColor = System.Drawing.SystemColors.Info
        Me.lblProfesora.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblProfesora.Location = New System.Drawing.Point(149, 186)
        Me.lblProfesora.Name = "lblProfesora"
        Me.lblProfesora.Size = New System.Drawing.Size(206, 23)
        Me.lblProfesora.TabIndex = 11
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
        Me.grbCurso.PerformLayout()
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
    Friend WithEvents lblProfesora As Label
    Friend WithEvents lblOds As Label
    Friend WithEvents lblMeta As Label
    Friend WithEvents lblModulo As Label
    Friend WithEvents lblIniciativa As Label
End Class
