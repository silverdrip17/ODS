﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.dgvOds = New System.Windows.Forms.DataGridView()
        Me.btnTodasOds = New System.Windows.Forms.Button()
        Me.btnCambiosMetas = New System.Windows.Forms.Button()
        Me.btnCambiosODS = New System.Windows.Forms.Button()
        CType(Me.dgvOds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOds
        '
        Me.dgvOds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOds.Location = New System.Drawing.Point(24, 9)
        Me.dgvOds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvOds.Name = "dgvOds"
        Me.dgvOds.RowHeadersWidth = 62
        Me.dgvOds.RowTemplate.Height = 28
        Me.dgvOds.Size = New System.Drawing.Size(524, 259)
        Me.dgvOds.TabIndex = 0
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
        Me.btnCambiosMetas.Location = New System.Drawing.Point(579, 12)
        Me.btnCambiosMetas.Name = "btnCambiosMetas"
        Me.btnCambiosMetas.Size = New System.Drawing.Size(218, 105)
        Me.btnCambiosMetas.TabIndex = 3
        Me.btnCambiosMetas.Text = "Cambios METAS"
        Me.btnCambiosMetas.UseVisualStyleBackColor = True
        '
        'btnCambiosODS
        '
        Me.btnCambiosODS.Location = New System.Drawing.Point(579, 163)
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
        Me.ClientSize = New System.Drawing.Size(831, 361)
        Me.Controls.Add(Me.btnCambiosODS)
        Me.Controls.Add(Me.btnCambiosMetas)
        Me.Controls.Add(Me.btnTodasOds)
        Me.Controls.Add(Me.dgvOds)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvOds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvOds As DataGridView
    Friend WithEvents btnTodasOds As Button
    Friend WithEvents btnCambiosMetas As Button
    Friend WithEvents btnCambiosODS As Button
End Class
