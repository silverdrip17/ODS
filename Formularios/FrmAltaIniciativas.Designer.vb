<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaIniciativas
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
        Me.cboOds = New System.Windows.Forms.ComboBox()
        Me.lstMetas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEscribirIniviativa = New System.Windows.Forms.Label()
        Me.lstmetaseleccionadas = New System.Windows.Forms.ListBox()
        Me.lbltituloiniciativa = New System.Windows.Forms.Label()
        Me.txtboxtitulo = New System.Windows.Forms.TextBox()
        Me.lblDescripcionIniciativa = New System.Windows.Forms.Label()
        Me.txtDescripcionIniciativa = New System.Windows.Forms.TextBox()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.txtFechaInicio = New System.Windows.Forms.TextBox()
        Me.txtFechaFin = New System.Windows.Forms.TextBox()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.btnAñadirIniciativa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboOds
        '
        Me.cboOds.FormattingEnabled = True
        Me.cboOds.Location = New System.Drawing.Point(43, 63)
        Me.cboOds.Name = "cboOds"
        Me.cboOds.Size = New System.Drawing.Size(278, 24)
        Me.cboOds.TabIndex = 0
        '
        'lstMetas
        '
        Me.lstMetas.FormattingEnabled = True
        Me.lstMetas.ItemHeight = 16
        Me.lstMetas.Location = New System.Drawing.Point(450, 63)
        Me.lstMetas.Name = "lstMetas"
        Me.lstMetas.Size = New System.Drawing.Size(250, 132)
        Me.lstMetas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'lblEscribirIniviativa
        '
        Me.lblEscribirIniviativa.AutoSize = True
        Me.lblEscribirIniviativa.Location = New System.Drawing.Point(64, 130)
        Me.lblEscribirIniviativa.Name = "lblEscribirIniviativa"
        Me.lblEscribirIniviativa.Size = New System.Drawing.Size(138, 16)
        Me.lblEscribirIniviativa.TabIndex = 11
        Me.lblEscribirIniviativa.Text = "Metas Seleccionadas"
        '
        'lstmetaseleccionadas
        '
        Me.lstmetaseleccionadas.FormattingEnabled = True
        Me.lstmetaseleccionadas.ItemHeight = 16
        Me.lstmetaseleccionadas.Location = New System.Drawing.Point(60, 157)
        Me.lstmetaseleccionadas.Name = "lstmetaseleccionadas"
        Me.lstmetaseleccionadas.Size = New System.Drawing.Size(260, 20)
        Me.lstmetaseleccionadas.TabIndex = 12
        '
        'lbltituloiniciativa
        '
        Me.lbltituloiniciativa.AutoSize = True
        Me.lbltituloiniciativa.Location = New System.Drawing.Point(57, 194)
        Me.lbltituloiniciativa.Name = "lbltituloiniciativa"
        Me.lbltituloiniciativa.Size = New System.Drawing.Size(95, 16)
        Me.lbltituloiniciativa.TabIndex = 13
        Me.lbltituloiniciativa.Text = "Titulo Iniciativa"
        '
        'txtboxtitulo
        '
        Me.txtboxtitulo.Location = New System.Drawing.Point(60, 223)
        Me.txtboxtitulo.Name = "txtboxtitulo"
        Me.txtboxtitulo.Size = New System.Drawing.Size(259, 22)
        Me.txtboxtitulo.TabIndex = 14
        '
        'lblDescripcionIniciativa
        '
        Me.lblDescripcionIniciativa.AutoSize = True
        Me.lblDescripcionIniciativa.Location = New System.Drawing.Point(57, 263)
        Me.lblDescripcionIniciativa.Name = "lblDescripcionIniciativa"
        Me.lblDescripcionIniciativa.Size = New System.Drawing.Size(130, 16)
        Me.lblDescripcionIniciativa.TabIndex = 15
        Me.lblDescripcionIniciativa.Text = "Descipcion Iniciativa"
        '
        'txtDescripcionIniciativa
        '
        Me.txtDescripcionIniciativa.Location = New System.Drawing.Point(60, 292)
        Me.txtDescripcionIniciativa.Multiline = True
        Me.txtDescripcionIniciativa.Name = "txtDescripcionIniciativa"
        Me.txtDescripcionIniciativa.Size = New System.Drawing.Size(293, 106)
        Me.txtDescripcionIniciativa.TabIndex = 16
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(447, 223)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(79, 16)
        Me.lblFechaInicio.TabIndex = 17
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Location = New System.Drawing.Point(450, 242)
        Me.txtFechaInicio.Multiline = True
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(170, 25)
        Me.txtFechaInicio.TabIndex = 18
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Location = New System.Drawing.Point(450, 303)
        Me.txtFechaFin.Multiline = True
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(170, 25)
        Me.txtFechaFin.TabIndex = 20
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(447, 284)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(66, 16)
        Me.lblFechaFin.TabIndex = 19
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'btnAñadirIniciativa
        '
        Me.btnAñadirIniciativa.Location = New System.Drawing.Point(541, 359)
        Me.btnAñadirIniciativa.Name = "btnAñadirIniciativa"
        Me.btnAñadirIniciativa.Size = New System.Drawing.Size(198, 38)
        Me.btnAñadirIniciativa.TabIndex = 21
        Me.btnAñadirIniciativa.Text = "Añadir Iniciativa"
        Me.btnAñadirIniciativa.UseVisualStyleBackColor = True
        '
        'FrmAltaIniciativas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAñadirIniciativa)
        Me.Controls.Add(Me.txtFechaFin)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.txtFechaInicio)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.txtDescripcionIniciativa)
        Me.Controls.Add(Me.lblDescripcionIniciativa)
        Me.Controls.Add(Me.txtboxtitulo)
        Me.Controls.Add(Me.lbltituloiniciativa)
        Me.Controls.Add(Me.lstmetaseleccionadas)
        Me.Controls.Add(Me.lblEscribirIniviativa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstMetas)
        Me.Controls.Add(Me.cboOds)
        Me.Name = "FrmAltaIniciativas"
        Me.Text = "Alta de iniciativa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboOds As ComboBox
    Friend WithEvents lstMetas As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEscribirIniviativa As Label
    Friend WithEvents lstmetaseleccionadas As ListBox
    Friend WithEvents lbltituloiniciativa As Label
    Friend WithEvents txtboxtitulo As TextBox
    Friend WithEvents lblDescripcionIniciativa As Label
    Friend WithEvents txtDescripcionIniciativa As TextBox
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents txtFechaInicio As TextBox
    Friend WithEvents txtFechaFin As TextBox
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents btnAñadirIniciativa As Button
End Class
