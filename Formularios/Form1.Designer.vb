<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpEditar = New System.Windows.Forms.GroupBox()
        Me.lblEditarMetas = New System.Windows.Forms.Label()
        Me.lblEditarOds = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTodasOds = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtEditarOds = New System.Windows.Forms.TextBox()
        Me.txtEditarMetas = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEditar.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 11)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(626, 324)
        Me.DataGridView1.TabIndex = 0
        '
        'grpEditar
        '
        Me.grpEditar.Controls.Add(Me.txtEditarMetas)
        Me.grpEditar.Controls.Add(Me.txtEditarOds)
        Me.grpEditar.Controls.Add(Me.TextBox1)
        Me.grpEditar.Controls.Add(Me.lblEditarMetas)
        Me.grpEditar.Controls.Add(Me.lblEditarOds)
        Me.grpEditar.Controls.Add(Me.Label1)
        Me.grpEditar.Location = New System.Drawing.Point(705, 12)
        Me.grpEditar.Name = "grpEditar"
        Me.grpEditar.Size = New System.Drawing.Size(391, 308)
        Me.grpEditar.TabIndex = 1
        Me.grpEditar.TabStop = False
        Me.grpEditar.Text = "Editar ods y/o Metas"
        '
        'lblEditarMetas
        '
        Me.lblEditarMetas.AutoSize = True
        Me.lblEditarMetas.Location = New System.Drawing.Point(8, 186)
        Me.lblEditarMetas.Name = "lblEditarMetas"
        Me.lblEditarMetas.Size = New System.Drawing.Size(103, 20)
        Me.lblEditarMetas.TabIndex = 2
        Me.lblEditarMetas.Text = "Editar Metas:"
        '
        'lblEditarOds
        '
        Me.lblEditarOds.AutoSize = True
        Me.lblEditarOds.Location = New System.Drawing.Point(17, 132)
        Me.lblEditarOds.Name = "lblEditarOds"
        Me.lblEditarOds.Size = New System.Drawing.Size(94, 20)
        Me.lblEditarOds.TabIndex = 1
        Me.lblEditarOds.Text = "Editar ODS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ODS:"
        '
        'btnTodasOds
        '
        Me.btnTodasOds.Location = New System.Drawing.Point(27, 367)
        Me.btnTodasOds.Name = "btnTodasOds"
        Me.btnTodasOds.Size = New System.Drawing.Size(186, 37)
        Me.btnTodasOds.TabIndex = 2
        Me.btnTodasOds.Text = "Ver Todos los ODS"
        Me.btnTodasOds.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.GreenYellow
        Me.TextBox1.Location = New System.Drawing.Point(127, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 26)
        Me.TextBox1.TabIndex = 3
        '
        'txtEditarOds
        '
        Me.txtEditarOds.BackColor = System.Drawing.Color.GreenYellow
        Me.txtEditarOds.Location = New System.Drawing.Point(127, 132)
        Me.txtEditarOds.Name = "txtEditarOds"
        Me.txtEditarOds.Size = New System.Drawing.Size(245, 26)
        Me.txtEditarOds.TabIndex = 4
        '
        'txtEditarMetas
        '
        Me.txtEditarMetas.BackColor = System.Drawing.Color.GreenYellow
        Me.txtEditarMetas.Location = New System.Drawing.Point(127, 183)
        Me.txtEditarMetas.Name = "txtEditarMetas"
        Me.txtEditarMetas.Size = New System.Drawing.Size(245, 26)
        Me.txtEditarMetas.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 513)
        Me.Controls.Add(Me.btnTodasOds)
        Me.Controls.Add(Me.grpEditar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEditar.ResumeLayout(False)
        Me.grpEditar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents grpEditar As GroupBox
    Friend WithEvents lblEditarMetas As Label
    Friend WithEvents lblEditarOds As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEditarMetas As TextBox
    Friend WithEvents txtEditarOds As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnTodasOds As Button
End Class
