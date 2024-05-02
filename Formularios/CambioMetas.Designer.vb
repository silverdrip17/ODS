<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioMetas
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
        Me.cboods = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblimagen = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoMeta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboMetas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbNombre = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcionMeta = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboods
        '
        Me.cboods.FormattingEnabled = True
        Me.cboods.Location = New System.Drawing.Point(159, 114)
        Me.cboods.Name = "cboods"
        Me.cboods.Size = New System.Drawing.Size(327, 24)
        Me.cboods.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SELECCIONA ODS"
        '
        'lblimagen
        '
        Me.lblimagen.Location = New System.Drawing.Point(625, 39)
        Me.lblimagen.Name = "lblimagen"
        Me.lblimagen.Size = New System.Drawing.Size(54, 51)
        Me.lblimagen.TabIndex = 6
        Me.lblimagen.Text = "IMAGEN"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(446, 174)
        Me.DataGridView1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(502, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Código Meta:"
        '
        'txtCodigoMeta
        '
        Me.txtCodigoMeta.Location = New System.Drawing.Point(600, 120)
        Me.txtCodigoMeta.Name = "txtCodigoMeta"
        Me.txtCodigoMeta.Size = New System.Drawing.Size(140, 22)
        Me.txtCodigoMeta.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "SELECCIONA META"
        '
        'cboMetas
        '
        Me.cboMetas.FormattingEnabled = True
        Me.cboMetas.Location = New System.Drawing.Point(194, 377)
        Me.cboMetas.Name = "cboMetas"
        Me.cboMetas.Size = New System.Drawing.Size(163, 24)
        Me.cboMetas.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(507, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nombre:"
        '
        'txtbNombre
        '
        Me.txtbNombre.Location = New System.Drawing.Point(600, 177)
        Me.txtbNombre.Name = "txtbNombre"
        Me.txtbNombre.Size = New System.Drawing.Size(140, 22)
        Me.txtbNombre.TabIndex = 13
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(507, 215)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(82, 16)
        Me.lblDescripcion.TabIndex = 14
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'txtDescripcionMeta
        '
        Me.txtDescripcionMeta.Location = New System.Drawing.Point(510, 234)
        Me.txtDescripcionMeta.Multiline = True
        Me.txtDescripcionMeta.Name = "txtDescripcionMeta"
        Me.txtDescripcionMeta.Size = New System.Drawing.Size(260, 80)
        Me.txtDescripcionMeta.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 44)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Agregar Nueva Meta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(661, 357)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 45)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Guardar Cambio Metas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(544, 357)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 45)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Eliminar Meta"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CambioMetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDescripcionMeta)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtbNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboMetas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigoMeta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblimagen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboods)
        Me.Name = "CambioMetas"
        Me.Text = "Cambios Metas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboods As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblimagen As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoMeta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboMetas As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbNombre As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtDescripcionMeta As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
