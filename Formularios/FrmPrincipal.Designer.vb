<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnCambiosMetas = New System.Windows.Forms.Button()
        Me.btnCambiosODS = New System.Windows.Forms.Button()
        Me.btnIniciativa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCambiosMetas
        '
        Me.btnCambiosMetas.Location = New System.Drawing.Point(57, 154)
        Me.btnCambiosMetas.Name = "btnCambiosMetas"
        Me.btnCambiosMetas.Size = New System.Drawing.Size(218, 105)
        Me.btnCambiosMetas.TabIndex = 3
        Me.btnCambiosMetas.Text = "Cambios METAS"
        Me.btnCambiosMetas.UseVisualStyleBackColor = True
        '
        'btnCambiosODS
        '
        Me.btnCambiosODS.Location = New System.Drawing.Point(356, 154)
        Me.btnCambiosODS.Name = "btnCambiosODS"
        Me.btnCambiosODS.Size = New System.Drawing.Size(218, 105)
        Me.btnCambiosODS.TabIndex = 4
        Me.btnCambiosODS.Text = "Cambios ODS"
        Me.btnCambiosODS.UseVisualStyleBackColor = True
        '
        'btnIniciativa
        '
        Me.btnIniciativa.Location = New System.Drawing.Point(653, 154)
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
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 369)
        Me.Controls.Add(Me.btnIniciativa)
        Me.Controls.Add(Me.btnCambiosODS)
        Me.Controls.Add(Me.btnCambiosMetas)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmPrincipal"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCambiosMetas As Button
    Friend WithEvents btnCambiosODS As Button
    Friend WithEvents btnIniciativa As Button
End Class
