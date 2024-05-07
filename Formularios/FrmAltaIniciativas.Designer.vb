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
        Me.cboOds = New System.Windows.Forms.ComboBox()
        Me.lstMetas = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cboOds
        '
        Me.cboOds.FormattingEnabled = True
        Me.cboOds.Location = New System.Drawing.Point(34, 63)
        Me.cboOds.Name = "cboOds"
        Me.cboOds.Size = New System.Drawing.Size(278, 24)
        Me.cboOds.TabIndex = 0
        '
        'lstMetas
        '
        Me.lstMetas.FormattingEnabled = True
        Me.lstMetas.ItemHeight = 16
        Me.lstMetas.Location = New System.Drawing.Point(450, 63)
        Me.lstMetas.Name = "lstMetas"
        Me.lstMetas.Size = New System.Drawing.Size(250, 132)
        Me.lstMetas.TabIndex = 1
        '
        'FrmAltaIniciativas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstMetas)
        Me.Controls.Add(Me.cboOds)
        Me.Name = "FrmAltaIniciativas"
        Me.Text = "Alta de iniciativa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboOds As ComboBox
    Friend WithEvents lstMetas As ListBox
End Class
