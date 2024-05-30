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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.METASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ODSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INICIATIVASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CURSOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'METASToolStripMenuItem
        '
        Me.METASToolStripMenuItem.Name = "METASToolStripMenuItem"
        Me.METASToolStripMenuItem.Size = New System.Drawing.Size(69, 26)
        Me.METASToolStripMenuItem.Text = "METAS"
        '
        'ODSToolStripMenuItem
        '
        Me.ODSToolStripMenuItem.Name = "ODSToolStripMenuItem"
        Me.ODSToolStripMenuItem.Size = New System.Drawing.Size(53, 26)
        Me.ODSToolStripMenuItem.Text = "ODS"
        '
        'INICIATIVASToolStripMenuItem
        '
        Me.INICIATIVASToolStripMenuItem.Name = "INICIATIVASToolStripMenuItem"
        Me.INICIATIVASToolStripMenuItem.Size = New System.Drawing.Size(102, 26)
        Me.INICIATIVASToolStripMenuItem.Text = "INICIATIVAS"
        '
        'CURSOSToolStripMenuItem
        '
        Me.CURSOSToolStripMenuItem.Name = "CURSOSToolStripMenuItem"
        Me.CURSOSToolStripMenuItem.Size = New System.Drawing.Size(78, 26)
        Me.CURSOSToolStripMenuItem.Text = "CURSOS"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(61, 26)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.METASToolStripMenuItem, Me.ODSToolStripMenuItem, Me.INICIATIVASToolStripMenuItem, Me.CURSOSToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1079, 30)
        Me.MenuStrip2.TabIndex = 9
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(254, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 151)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "CUATROVIENTOS RSC"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1079, 369)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmPrincipal"
        Me.Text = "Menu"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents METASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ODSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INICIATIVASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CURSOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents Label1 As Label
End Class
