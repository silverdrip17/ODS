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
        Me.cboSolicitantes = New System.Windows.Forms.ComboBox()
        Me.lstProfesores = New System.Windows.Forms.ListBox()
        Me.lbltituloiniciativa = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblDescripcionIniciativa = New System.Windows.Forms.Label()
        Me.txtDescripcionIniciativa = New System.Windows.Forms.TextBox()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.btnAñadirIniciativa = New System.Windows.Forms.Button()
        Me.lblIDSolicitante = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.lstSolicitantes = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProfesores = New System.Windows.Forms.ComboBox()
        Me.lstODS = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCursos = New System.Windows.Forms.Label()
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.lblModulosSeleccionados = New System.Windows.Forms.Label()
        Me.lstModulos = New System.Windows.Forms.ListBox()
        Me.lblMódulos = New System.Windows.Forms.Label()
        Me.lstCursos = New System.Windows.Forms.ListBox()
        Me.cboModulos = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboMetas = New System.Windows.Forms.ComboBox()
        Me.lstMetas = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cboSolicitantes
        '
        Me.cboSolicitantes.FormattingEnabled = True
        Me.cboSolicitantes.Location = New System.Drawing.Point(661, 221)
        Me.cboSolicitantes.Name = "cboSolicitantes"
        Me.cboSolicitantes.Size = New System.Drawing.Size(250, 24)
        Me.cboSolicitantes.TabIndex = 0
        '
        'lstProfesores
        '
        Me.lstProfesores.FormattingEnabled = True
        Me.lstProfesores.ItemHeight = 16
        Me.lstProfesores.Location = New System.Drawing.Point(926, 403)
        Me.lstProfesores.Name = "lstProfesores"
        Me.lstProfesores.Size = New System.Drawing.Size(231, 100)
        Me.lstProfesores.TabIndex = 1
        '
        'lbltituloiniciativa
        '
        Me.lbltituloiniciativa.AutoSize = True
        Me.lbltituloiniciativa.Location = New System.Drawing.Point(33, 27)
        Me.lbltituloiniciativa.Name = "lbltituloiniciativa"
        Me.lbltituloiniciativa.Size = New System.Drawing.Size(95, 16)
        Me.lbltituloiniciativa.TabIndex = 13
        Me.lbltituloiniciativa.Text = "Titulo Iniciativa"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(36, 56)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(259, 22)
        Me.txtTitulo.TabIndex = 14
        '
        'lblDescripcionIniciativa
        '
        Me.lblDescripcionIniciativa.AutoSize = True
        Me.lblDescripcionIniciativa.Location = New System.Drawing.Point(33, 96)
        Me.lblDescripcionIniciativa.Name = "lblDescripcionIniciativa"
        Me.lblDescripcionIniciativa.Size = New System.Drawing.Size(130, 16)
        Me.lblDescripcionIniciativa.TabIndex = 15
        Me.lblDescripcionIniciativa.Text = "Descipcion Iniciativa"
        '
        'txtDescripcionIniciativa
        '
        Me.txtDescripcionIniciativa.Location = New System.Drawing.Point(36, 125)
        Me.txtDescripcionIniciativa.Multiline = True
        Me.txtDescripcionIniciativa.Name = "txtDescripcionIniciativa"
        Me.txtDescripcionIniciativa.Size = New System.Drawing.Size(293, 106)
        Me.txtDescripcionIniciativa.TabIndex = 16
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(33, 242)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(79, 16)
        Me.lblFechaInicio.TabIndex = 17
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(328, 242)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(66, 16)
        Me.lblFechaFin.TabIndex = 19
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'btnAñadirIniciativa
        '
        Me.btnAñadirIniciativa.Location = New System.Drawing.Point(36, 501)
        Me.btnAñadirIniciativa.Name = "btnAñadirIniciativa"
        Me.btnAñadirIniciativa.Size = New System.Drawing.Size(274, 73)
        Me.btnAñadirIniciativa.TabIndex = 21
        Me.btnAñadirIniciativa.Text = "Añadir Iniciativa"
        Me.btnAñadirIniciativa.UseVisualStyleBackColor = True
        '
        'lblIDSolicitante
        '
        Me.lblIDSolicitante.AutoSize = True
        Me.lblIDSolicitante.Location = New System.Drawing.Point(658, 192)
        Me.lblIDSolicitante.Name = "lblIDSolicitante"
        Me.lblIDSolicitante.Size = New System.Drawing.Size(76, 16)
        Me.lblIDSolicitante.TabIndex = 22
        Me.lblIDSolicitante.Text = "Solicitantes"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(36, 262)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 24
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(331, 262)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 25
        '
        'lstSolicitantes
        '
        Me.lstSolicitantes.FormattingEnabled = True
        Me.lstSolicitantes.ItemHeight = 16
        Me.lstSolicitantes.Location = New System.Drawing.Point(926, 224)
        Me.lstSolicitantes.Name = "lstSolicitantes"
        Me.lstSolicitantes.Size = New System.Drawing.Size(231, 100)
        Me.lstSolicitantes.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(923, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Solicitantes Seleccionados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(923, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Profesores Seleccionados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(658, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Profesores"
        '
        'cboProfesores
        '
        Me.cboProfesores.FormattingEnabled = True
        Me.cboProfesores.Location = New System.Drawing.Point(661, 403)
        Me.cboProfesores.Name = "cboProfesores"
        Me.cboProfesores.Size = New System.Drawing.Size(250, 24)
        Me.cboProfesores.TabIndex = 28
        '
        'lstODS
        '
        Me.lstODS.FormattingEnabled = True
        Me.lstODS.ItemHeight = 16
        Me.lstODS.Location = New System.Drawing.Point(926, 56)
        Me.lstODS.Name = "lstODS"
        Me.lstODS.Size = New System.Drawing.Size(231, 100)
        Me.lstODS.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(923, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ODS Seleccionados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(658, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "ODS"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(661, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 24)
        Me.ComboBox1.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1430, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Cursos Seleccionados"
        '
        'lblCursos
        '
        Me.lblCursos.AutoSize = True
        Me.lblCursos.Location = New System.Drawing.Point(1165, 201)
        Me.lblCursos.Name = "lblCursos"
        Me.lblCursos.Size = New System.Drawing.Size(49, 16)
        Me.lblCursos.TabIndex = 46
        Me.lblCursos.Text = "Cursos"
        '
        'cboCursos
        '
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Location = New System.Drawing.Point(1168, 230)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(250, 24)
        Me.cboCursos.TabIndex = 45
        '
        'lblModulosSeleccionados
        '
        Me.lblModulosSeleccionados.AutoSize = True
        Me.lblModulosSeleccionados.Location = New System.Drawing.Point(1430, 374)
        Me.lblModulosSeleccionados.Name = "lblModulosSeleccionados"
        Me.lblModulosSeleccionados.Size = New System.Drawing.Size(153, 16)
        Me.lblModulosSeleccionados.TabIndex = 44
        Me.lblModulosSeleccionados.Text = "Módulos Seleccionados"
        '
        'lstModulos
        '
        Me.lstModulos.FormattingEnabled = True
        Me.lstModulos.ItemHeight = 16
        Me.lstModulos.Location = New System.Drawing.Point(1433, 403)
        Me.lstModulos.Name = "lstModulos"
        Me.lstModulos.Size = New System.Drawing.Size(231, 100)
        Me.lstModulos.TabIndex = 43
        '
        'lblMódulos
        '
        Me.lblMódulos.AutoSize = True
        Me.lblMódulos.Location = New System.Drawing.Point(1165, 374)
        Me.lblMódulos.Name = "lblMódulos"
        Me.lblMódulos.Size = New System.Drawing.Size(59, 16)
        Me.lblMódulos.TabIndex = 42
        Me.lblMódulos.Text = "Módulos"
        '
        'lstCursos
        '
        Me.lstCursos.FormattingEnabled = True
        Me.lstCursos.ItemHeight = 16
        Me.lstCursos.Location = New System.Drawing.Point(1433, 230)
        Me.lstCursos.Name = "lstCursos"
        Me.lstCursos.Size = New System.Drawing.Size(231, 100)
        Me.lstCursos.TabIndex = 41
        '
        'cboModulos
        '
        Me.cboModulos.FormattingEnabled = True
        Me.cboModulos.Location = New System.Drawing.Point(1168, 403)
        Me.cboModulos.Name = "cboModulos"
        Me.cboModulos.Size = New System.Drawing.Size(250, 24)
        Me.cboModulos.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1430, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Metas Seleccionadas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1165, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Metas"
        '
        'cboMetas
        '
        Me.cboMetas.FormattingEnabled = True
        Me.cboMetas.Location = New System.Drawing.Point(1168, 56)
        Me.cboMetas.Name = "cboMetas"
        Me.cboMetas.Size = New System.Drawing.Size(250, 24)
        Me.cboMetas.TabIndex = 49
        '
        'lstMetas
        '
        Me.lstMetas.FormattingEnabled = True
        Me.lstMetas.ItemHeight = 16
        Me.lstMetas.Location = New System.Drawing.Point(1433, 56)
        Me.lstMetas.Name = "lstMetas"
        Me.lstMetas.Size = New System.Drawing.Size(231, 100)
        Me.lstMetas.TabIndex = 48
        '
        'FrmAltaIniciativas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1748, 696)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboMetas)
        Me.Controls.Add(Me.lstMetas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCursos)
        Me.Controls.Add(Me.cboCursos)
        Me.Controls.Add(Me.lblModulosSeleccionados)
        Me.Controls.Add(Me.lstModulos)
        Me.Controls.Add(Me.lblMódulos)
        Me.Controls.Add(Me.lstCursos)
        Me.Controls.Add(Me.cboModulos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lstODS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboProfesores)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstSolicitantes)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lblIDSolicitante)
        Me.Controls.Add(Me.btnAñadirIniciativa)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.txtDescripcionIniciativa)
        Me.Controls.Add(Me.lblDescripcionIniciativa)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.lbltituloiniciativa)
        Me.Controls.Add(Me.lstProfesores)
        Me.Controls.Add(Me.cboSolicitantes)
        Me.Name = "FrmAltaIniciativas"
        Me.Text = "Alta de iniciativa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboSolicitantes As ComboBox
    Friend WithEvents lstProfesores As ListBox
    Friend WithEvents lbltituloiniciativa As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents lblDescripcionIniciativa As Label
    Friend WithEvents txtDescripcionIniciativa As TextBox
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents btnAñadirIniciativa As Button
    Friend WithEvents lblIDSolicitante As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents lstSolicitantes As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboProfesores As ComboBox
    Friend WithEvents lstODS As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCursos As Label
    Friend WithEvents cboCursos As ComboBox
    Friend WithEvents lblModulosSeleccionados As Label
    Friend WithEvents lstModulos As ListBox
    Friend WithEvents lblMódulos As Label
    Friend WithEvents lstCursos As ListBox
    Friend WithEvents cboModulos As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboMetas As ComboBox
    Friend WithEvents lstMetas As ListBox
End Class
