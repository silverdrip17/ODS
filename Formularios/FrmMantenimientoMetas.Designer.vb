<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantenimientoMetas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboods = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoMeta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboMetas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbNombre = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcionMeta = New System.Windows.Forms.TextBox()
        Me.btnGuardarMeta = New System.Windows.Forms.Button()
        Me.btnEliminarMeta = New System.Windows.Forms.Button()
        Me.btnFoto = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboods
        '
        Me.cboods.FormattingEnabled = True
        Me.cboods.Location = New System.Drawing.Point(179, 142)
        Me.cboods.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboods.Name = "cboods"
        Me.cboods.Size = New System.Drawing.Size(367, 28)
        Me.cboods.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SELECCIONA ODS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 199)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(502, 218)
        Me.DataGridView1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(565, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Código Meta:"
        '
        'txtCodigoMeta
        '
        Me.txtCodigoMeta.Location = New System.Drawing.Point(675, 150)
        Me.txtCodigoMeta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoMeta.Name = "txtCodigoMeta"
        Me.txtCodigoMeta.Size = New System.Drawing.Size(157, 26)
        Me.txtCodigoMeta.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 464)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "SELECCIONA META"
        '
        'cboMetas
        '
        Me.cboMetas.FormattingEnabled = True
        Me.cboMetas.Location = New System.Drawing.Point(218, 460)
        Me.cboMetas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboMetas.Name = "cboMetas"
        Me.cboMetas.Size = New System.Drawing.Size(252, 28)
        Me.cboMetas.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(570, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nombre:"
        '
        'txtbNombre
        '
        Me.txtbNombre.Location = New System.Drawing.Point(675, 221)
        Me.txtbNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbNombre.Name = "txtbNombre"
        Me.txtbNombre.Size = New System.Drawing.Size(157, 26)
        Me.txtbNombre.TabIndex = 13
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(570, 269)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(96, 20)
        Me.lblDescripcion.TabIndex = 14
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'txtDescripcionMeta
        '
        Me.txtDescripcionMeta.Location = New System.Drawing.Point(574, 292)
        Me.txtDescripcionMeta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcionMeta.Multiline = True
        Me.txtDescripcionMeta.Name = "txtDescripcionMeta"
        Me.txtDescripcionMeta.Size = New System.Drawing.Size(292, 99)
        Me.txtDescripcionMeta.TabIndex = 15
        '
        'btnGuardarMeta
        '
        Me.btnGuardarMeta.Location = New System.Drawing.Point(744, 446)
        Me.btnGuardarMeta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardarMeta.Name = "btnGuardarMeta"
        Me.btnGuardarMeta.Size = New System.Drawing.Size(123, 56)
        Me.btnGuardarMeta.TabIndex = 17
        Me.btnGuardarMeta.Text = "Guardar Cambio Metas"
        Me.btnGuardarMeta.UseVisualStyleBackColor = True
        '
        'btnEliminarMeta
        '
        Me.btnEliminarMeta.Location = New System.Drawing.Point(612, 446)
        Me.btnEliminarMeta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminarMeta.Name = "btnEliminarMeta"
        Me.btnEliminarMeta.Size = New System.Drawing.Size(125, 56)
        Me.btnEliminarMeta.TabIndex = 18
        Me.btnEliminarMeta.Text = "Eliminar Meta"
        Me.btnEliminarMeta.UseVisualStyleBackColor = True
        '
        'btnFoto
        '
        Me.btnFoto.Location = New System.Drawing.Point(673, 15)
        Me.btnFoto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(126, 128)
        Me.btnFoto.TabIndex = 19
        Me.btnFoto.UseVisualStyleBackColor = True
        '
        'FrmMantenimientoMetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.btnFoto)
        Me.Controls.Add(Me.btnEliminarMeta)
        Me.Controls.Add(Me.btnGuardarMeta)
        Me.Controls.Add(Me.txtDescripcionMeta)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtbNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboMetas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigoMeta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboods)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmMantenimientoMetas"
        Me.Text = "Cambios Metas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboods As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoMeta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboMetas As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbNombre As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtDescripcionMeta As TextBox
    Friend WithEvents btnGuardarMeta As Button
    Friend WithEvents btnEliminarMeta As Button
    Friend WithEvents btnFoto As Button
End Class
