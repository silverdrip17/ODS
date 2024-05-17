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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProfesores = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboODS = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCursos = New System.Windows.Forms.Label()
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.lblMódulos = New System.Windows.Forms.Label()
        Me.lstModulos = New System.Windows.Forms.ListBox()
        Me.cboModulos = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboMetas = New System.Windows.Forms.ComboBox()
        Me.lstMetas = New System.Windows.Forms.ListBox()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboIniciativasEliminar = New System.Windows.Forms.ComboBox()
        Me.dgvIniciativas = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboMetasEliminar = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboODSEliminar = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminarIniciativas = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIniciativas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboSolicitantes
        '
        Me.cboSolicitantes.FormattingEnabled = True
        Me.cboSolicitantes.Location = New System.Drawing.Point(404, 578)
        Me.cboSolicitantes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSolicitantes.Name = "cboSolicitantes"
        Me.cboSolicitantes.Size = New System.Drawing.Size(281, 28)
        Me.cboSolicitantes.TabIndex = 0
        '
        'lstProfesores
        '
        Me.lstProfesores.FormattingEnabled = True
        Me.lstProfesores.ItemHeight = 20
        Me.lstProfesores.Location = New System.Drawing.Point(997, 578)
        Me.lstProfesores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstProfesores.Name = "lstProfesores"
        Me.lstProfesores.Size = New System.Drawing.Size(259, 124)
        Me.lstProfesores.TabIndex = 1
        '
        'lbltituloiniciativa
        '
        Me.lbltituloiniciativa.AutoSize = True
        Me.lbltituloiniciativa.Location = New System.Drawing.Point(61, 46)
        Me.lbltituloiniciativa.Name = "lbltituloiniciativa"
        Me.lbltituloiniciativa.Size = New System.Drawing.Size(112, 20)
        Me.lbltituloiniciativa.TabIndex = 13
        Me.lbltituloiniciativa.Text = "Titulo Iniciativa"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(64, 88)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(291, 26)
        Me.txtTitulo.TabIndex = 14
        '
        'lblDescripcionIniciativa
        '
        Me.lblDescripcionIniciativa.AutoSize = True
        Me.lblDescripcionIniciativa.Location = New System.Drawing.Point(61, 249)
        Me.lblDescripcionIniciativa.Name = "lblDescripcionIniciativa"
        Me.lblDescripcionIniciativa.Size = New System.Drawing.Size(152, 20)
        Me.lblDescripcionIniciativa.TabIndex = 15
        Me.lblDescripcionIniciativa.Text = "Descipcion Iniciativa"
        '
        'txtDescripcionIniciativa
        '
        Me.txtDescripcionIniciativa.Location = New System.Drawing.Point(64, 285)
        Me.txtDescripcionIniciativa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcionIniciativa.Multiline = True
        Me.txtDescripcionIniciativa.Name = "txtDescripcionIniciativa"
        Me.txtDescripcionIniciativa.Size = New System.Drawing.Size(329, 132)
        Me.txtDescripcionIniciativa.TabIndex = 16
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(79, 454)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(95, 20)
        Me.lblFechaInicio.TabIndex = 17
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(79, 539)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(80, 20)
        Me.lblFechaFin.TabIndex = 19
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'btnAñadirIniciativa
        '
        Me.btnAñadirIniciativa.Location = New System.Drawing.Point(525, 661)
        Me.btnAñadirIniciativa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAñadirIniciativa.Name = "btnAñadirIniciativa"
        Me.btnAñadirIniciativa.Size = New System.Drawing.Size(308, 91)
        Me.btnAñadirIniciativa.TabIndex = 21
        Me.btnAñadirIniciativa.Text = "Añadir Iniciativa"
        Me.btnAñadirIniciativa.UseVisualStyleBackColor = True
        '
        'lblIDSolicitante
        '
        Me.lblIDSolicitante.AutoSize = True
        Me.lblIDSolicitante.Location = New System.Drawing.Point(400, 541)
        Me.lblIDSolicitante.Name = "lblIDSolicitante"
        Me.lblIDSolicitante.Size = New System.Drawing.Size(91, 20)
        Me.lblIDSolicitante.TabIndex = 22
        Me.lblIDSolicitante.Text = "Solicitantes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(993, 541)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Profesores Seleccionados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(695, 541)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Profesores"
        '
        'cboProfesores
        '
        Me.cboProfesores.FormattingEnabled = True
        Me.cboProfesores.Location = New System.Drawing.Point(699, 578)
        Me.cboProfesores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboProfesores.Name = "cboProfesores"
        Me.cboProfesores.Size = New System.Drawing.Size(281, 28)
        Me.cboProfesores.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(400, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "ODS"
        '
        'cboODS
        '
        Me.cboODS.FormattingEnabled = True
        Me.cboODS.Location = New System.Drawing.Point(404, 95)
        Me.cboODS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboODS.Name = "cboODS"
        Me.cboODS.Size = New System.Drawing.Size(281, 28)
        Me.cboODS.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(993, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Módulos Seleccionados"
        '
        'lblCursos
        '
        Me.lblCursos.AutoSize = True
        Me.lblCursos.Location = New System.Drawing.Point(400, 301)
        Me.lblCursos.Name = "lblCursos"
        Me.lblCursos.Size = New System.Drawing.Size(59, 20)
        Me.lblCursos.TabIndex = 46
        Me.lblCursos.Text = "Cursos"
        '
        'cboCursos
        '
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Location = New System.Drawing.Point(404, 338)
        Me.cboCursos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(281, 28)
        Me.cboCursos.TabIndex = 45
        '
        'lblMódulos
        '
        Me.lblMódulos.AutoSize = True
        Me.lblMódulos.Location = New System.Drawing.Point(695, 301)
        Me.lblMódulos.Name = "lblMódulos"
        Me.lblMódulos.Size = New System.Drawing.Size(69, 20)
        Me.lblMódulos.TabIndex = 42
        Me.lblMódulos.Text = "Módulos"
        '
        'lstModulos
        '
        Me.lstModulos.FormattingEnabled = True
        Me.lstModulos.ItemHeight = 20
        Me.lstModulos.Location = New System.Drawing.Point(997, 338)
        Me.lstModulos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstModulos.Name = "lstModulos"
        Me.lstModulos.Size = New System.Drawing.Size(259, 124)
        Me.lstModulos.TabIndex = 41
        '
        'cboModulos
        '
        Me.cboModulos.FormattingEnabled = True
        Me.cboModulos.Location = New System.Drawing.Point(699, 338)
        Me.cboModulos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModulos.Name = "cboModulos"
        Me.cboModulos.Size = New System.Drawing.Size(281, 28)
        Me.cboModulos.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(993, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 20)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Metas Seleccionadas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(695, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Metas"
        '
        'cboMetas
        '
        Me.cboMetas.FormattingEnabled = True
        Me.cboMetas.Location = New System.Drawing.Point(699, 95)
        Me.cboMetas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboMetas.Name = "cboMetas"
        Me.cboMetas.Size = New System.Drawing.Size(281, 28)
        Me.cboMetas.TabIndex = 49
        '
        'lstMetas
        '
        Me.lstMetas.FormattingEnabled = True
        Me.lstMetas.ItemHeight = 20
        Me.lstMetas.Location = New System.Drawing.Point(997, 85)
        Me.lstMetas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstMetas.Name = "lstMetas"
        Me.lstMetas.Size = New System.Drawing.Size(259, 124)
        Me.lstMetas.TabIndex = 48
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(71, 490)
        Me.dtpInicio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(308, 26)
        Me.dtpInicio.TabIndex = 52
        '
        'dtpFin
        '
        Me.dtpFin.Location = New System.Drawing.Point(71, 574)
        Me.dtpFin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(308, 26)
        Me.dtpFin.TabIndex = 53
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(699, 435)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(135, 26)
        Me.NumericUpDown1.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(695, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Nº Horas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1297, 442)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 20)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "INICIATIVAS"
        '
        'cboIniciativasEliminar
        '
        Me.cboIniciativasEliminar.FormattingEnabled = True
        Me.cboIniciativasEliminar.Location = New System.Drawing.Point(1300, 479)
        Me.cboIniciativasEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboIniciativasEliminar.Name = "cboIniciativasEliminar"
        Me.cboIniciativasEliminar.Size = New System.Drawing.Size(281, 28)
        Me.cboIniciativasEliminar.TabIndex = 71
        '
        'dgvIniciativas
        '
        Me.dgvIniciativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIniciativas.Location = New System.Drawing.Point(1300, 132)
        Me.dgvIniciativas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvIniciativas.Name = "dgvIniciativas"
        Me.dgvIniciativas.RowHeadersWidth = 51
        Me.dgvIniciativas.RowTemplate.Height = 24
        Me.dgvIniciativas.Size = New System.Drawing.Size(681, 289)
        Me.dgvIniciativas.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1592, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 20)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Metas"
        '
        'cboMetasEliminar
        '
        Me.cboMetasEliminar.FormattingEnabled = True
        Me.cboMetasEliminar.Location = New System.Drawing.Point(1595, 85)
        Me.cboMetasEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboMetasEliminar.Name = "cboMetasEliminar"
        Me.cboMetasEliminar.Size = New System.Drawing.Size(281, 28)
        Me.cboMetasEliminar.TabIndex = 68
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1297, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 20)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "ODS"
        '
        'cboODSEliminar
        '
        Me.cboODSEliminar.FormattingEnabled = True
        Me.cboODSEliminar.Location = New System.Drawing.Point(1300, 85)
        Me.cboODSEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboODSEliminar.Name = "cboODSEliminar"
        Me.cboODSEliminar.Size = New System.Drawing.Size(281, 28)
        Me.cboODSEliminar.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1720, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 20)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "ELIMINAR INICIATIVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(609, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "AÑADIR INICIATIVA"
        '
        'btnEliminarIniciativas
        '
        Me.btnEliminarIniciativas.Location = New System.Drawing.Point(1301, 574)
        Me.btnEliminarIniciativas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminarIniciativas.Name = "btnEliminarIniciativas"
        Me.btnEliminarIniciativas.Size = New System.Drawing.Size(308, 91)
        Me.btnEliminarIniciativas.TabIndex = 74
        Me.btnEliminarIniciativas.Text = "Eliminar Iniciativas"
        Me.btnEliminarIniciativas.UseVisualStyleBackColor = True
        '
        'FrmAltaIniciativas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2164, 1054)
        Me.Controls.Add(Me.btnEliminarIniciativas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboIniciativasEliminar)
        Me.Controls.Add(Me.dgvIniciativas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboMetasEliminar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboODSEliminar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboMetas)
        Me.Controls.Add(Me.lstMetas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCursos)
        Me.Controls.Add(Me.cboCursos)
        Me.Controls.Add(Me.lblMódulos)
        Me.Controls.Add(Me.lstModulos)
        Me.Controls.Add(Me.cboModulos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboODS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboProfesores)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAltaIniciativas"
        Me.Text = "Alta de iniciativa"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIniciativas, System.ComponentModel.ISupportInitialize).EndInit()

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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboProfesores As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboODS As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCursos As Label
    Friend WithEvents cboCursos As ComboBox
    Friend WithEvents lblMódulos As Label
    Friend WithEvents lstModulos As ListBox
    Friend WithEvents cboModulos As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboMetas As ComboBox
    Friend WithEvents lstMetas As ListBox
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboIniciativasEliminar As ComboBox
    Friend WithEvents dgvIniciativas As DataGridView

    Friend WithEvents Label10 As Label
    Friend WithEvents cboMetasEliminar As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboODSEliminar As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEliminarIniciativas As Button

End Class
