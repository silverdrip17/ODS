﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.dgvOds = New System.Windows.Forms.DataGridView()
        Me.btnCambiosMetas = New System.Windows.Forms.Button()
        Me.btnCambiosODS = New System.Windows.Forms.Button()
        Me.btnIniciativa = New System.Windows.Forms.Button()
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
        'btnCambiosMetas
        '
        Me.btnCambiosMetas.Location = New System.Drawing.Point(732, 55)
        Me.btnCambiosMetas.Name = "btnCambiosMetas"
        Me.btnCambiosMetas.Size = New System.Drawing.Size(218, 105)
        Me.btnCambiosMetas.TabIndex = 3
        Me.btnCambiosMetas.Text = "Cambios METAS"
        Me.btnCambiosMetas.UseVisualStyleBackColor = True
        '
        'btnCambiosODS
        '
        Me.btnCambiosODS.Location = New System.Drawing.Point(732, 175)
        Me.btnCambiosODS.Name = "btnCambiosODS"
        Me.btnCambiosODS.Size = New System.Drawing.Size(218, 105)
        Me.btnCambiosODS.TabIndex = 4
        Me.btnCambiosODS.Text = "Cambios ODS"
        Me.btnCambiosODS.UseVisualStyleBackColor = True
        '
        'btnIniciativa
        '
        Me.btnIniciativa.Location = New System.Drawing.Point(732, 294)
        Me.btnIniciativa.Name = "btnIniciativa"
        Me.btnIniciativa.Size = New System.Drawing.Size(218, 105)
        Me.btnIniciativa.TabIndex = 5
        Me.btnIniciativa.Text = "Cambio Iniciativa"
        Me.btnIniciativa.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 491)
        Me.Controls.Add(Me.btnIniciativa)
        Me.Controls.Add(Me.btnCambiosODS)
        Me.Controls.Add(Me.btnCambiosMetas)
        Me.Controls.Add(Me.dgvOds)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmPrincipal"
        Me.Text = "Form1"
        CType(Me.dgvOds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvOds As DataGridView
    Friend WithEvents btnCambiosMetas As Button
    Friend WithEvents btnCambiosODS As Button
    Friend WithEvents btnIniciativa As Button
End Class
