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
        Me.btnTodasOds = New System.Windows.Forms.Button()
        Me.btnCambiosMetas = New System.Windows.Forms.Button()
        Me.btnCambiosODS = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnCambiosMetas
        '
        Me.btnCambiosMetas.Location = New System.Drawing.Point(654, 12)
        Me.btnCambiosMetas.Name = "btnCambiosMetas"
        Me.btnCambiosMetas.Size = New System.Drawing.Size(218, 105)
        Me.btnCambiosMetas.TabIndex = 3
        Me.btnCambiosMetas.Text = "Cambios METAS"
        Me.btnCambiosMetas.UseVisualStyleBackColor = True
        '
        'btnCambiosODS
        '
        Me.btnCambiosODS.Location = New System.Drawing.Point(654, 163)
        Me.btnCambiosODS.Name = "btnCambiosODS"
        Me.btnCambiosODS.Size = New System.Drawing.Size(218, 105)
        Me.btnCambiosODS.TabIndex = 4
        Me.btnCambiosODS.Text = "Cambios ODS"
        Me.btnCambiosODS.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 361)
        Me.Controls.Add(Me.btnCambiosODS)
        Me.Controls.Add(Me.btnCambiosMetas)
        Me.Controls.Add(Me.btnTodasOds)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTodasOds As Button
    Friend WithEvents btnCambiosMetas As Button
    Friend WithEvents btnCambiosODS As Button
End Class
