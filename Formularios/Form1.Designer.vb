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
        Me.cboOds = New System.Windows.Forms.ComboBox()
        Me.btnCammbios = New System.Windows.Forms.Button()
        Me.txtEditarMetas = New System.Windows.Forms.TextBox()
        Me.txtEditarOds = New System.Windows.Forms.TextBox()
        Me.lblEditarMetas = New System.Windows.Forms.Label()
        Me.lblEditarOds = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTodasOds = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEditar.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 9)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(556, 259)
        Me.DataGridView1.TabIndex = 0
        '
        'grpEditar
        '
        Me.grpEditar.Controls.Add(Me.cboOds)
        Me.grpEditar.Controls.Add(Me.btnCammbios)
        Me.grpEditar.Controls.Add(Me.txtEditarMetas)
        Me.grpEditar.Controls.Add(Me.txtEditarOds)
        Me.grpEditar.Controls.Add(Me.lblEditarMetas)
        Me.grpEditar.Controls.Add(Me.lblEditarOds)
        Me.grpEditar.Controls.Add(Me.Label1)
        Me.grpEditar.Location = New System.Drawing.Point(627, 10)
        Me.grpEditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpEditar.Name = "grpEditar"
        Me.grpEditar.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpEditar.Size = New System.Drawing.Size(348, 246)
        Me.grpEditar.TabIndex = 1
        Me.grpEditar.TabStop = False
        Me.grpEditar.Text = "Editar ods y/o Metas"
        '
        'cboOds
        '
        Me.cboOds.BackColor = System.Drawing.Color.GreenYellow
        Me.cboOds.FormattingEnabled = True
        Me.cboOds.Location = New System.Drawing.Point(113, 49)
        Me.cboOds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboOds.Name = "cboOds"
        Me.cboOds.Size = New System.Drawing.Size(218, 24)
        Me.cboOds.TabIndex = 8
        '
        'btnCammbios
        '
        Me.btnCammbios.Location = New System.Drawing.Point(74, 189)
        Me.btnCammbios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCammbios.Name = "btnCammbios"
        Me.btnCammbios.Size = New System.Drawing.Size(202, 34)
        Me.btnCammbios.TabIndex = 7
        Me.btnCammbios.Text = "Confirmar Cambios"
        Me.btnCammbios.UseVisualStyleBackColor = True
        '
        'txtEditarMetas
        '
        Me.txtEditarMetas.BackColor = System.Drawing.Color.GreenYellow
        Me.txtEditarMetas.Location = New System.Drawing.Point(113, 146)
        Me.txtEditarMetas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEditarMetas.Name = "txtEditarMetas"
        Me.txtEditarMetas.Size = New System.Drawing.Size(218, 22)
        Me.txtEditarMetas.TabIndex = 5
        '
        'txtEditarOds
        '
        Me.txtEditarOds.BackColor = System.Drawing.Color.GreenYellow
        Me.txtEditarOds.Location = New System.Drawing.Point(113, 100)
        Me.txtEditarOds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEditarOds.Name = "txtEditarOds"
        Me.txtEditarOds.Size = New System.Drawing.Size(218, 22)
        Me.txtEditarOds.TabIndex = 4
        '
        'lblEditarMetas
        '
        Me.lblEditarMetas.AutoSize = True
        Me.lblEditarMetas.Location = New System.Drawing.Point(7, 149)
        Me.lblEditarMetas.Name = "lblEditarMetas"
        Me.lblEditarMetas.Size = New System.Drawing.Size(85, 16)
        Me.lblEditarMetas.TabIndex = 2
        Me.lblEditarMetas.Text = "Editar Metas:"
        '
        'lblEditarOds
        '
        Me.lblEditarOds.AutoSize = True
        Me.lblEditarOds.Location = New System.Drawing.Point(7, 106)
        Me.lblEditarOds.Name = "lblEditarOds"
        Me.lblEditarOds.Size = New System.Drawing.Size(77, 16)
        Me.lblEditarOds.TabIndex = 1
        Me.lblEditarOds.Text = "Editar ODS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ODS:"
        '
        'btnTodasOds
        '
        Me.btnTodasOds.Location = New System.Drawing.Point(24, 294)
        Me.btnTodasOds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTodasOds.Name = "btnTodasOds"
        Me.btnTodasOds.Size = New System.Drawing.Size(165, 30)
        Me.btnTodasOds.TabIndex = 2
        Me.btnTodasOds.Text = "Ver Todos los ODS"
        Me.btnTodasOds.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 410)
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
    Friend WithEvents btnTodasOds As Button
    Friend WithEvents btnCammbios As Button
    Friend WithEvents cboOds As ComboBox
End Class
