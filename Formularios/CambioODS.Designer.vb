<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioODS
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
        Me.txtNumODS = New System.Windows.Forms.TextBox()
        Me.cboODS = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreODS = New System.Windows.Forms.TextBox()
        Me.txtDescripcionODS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNumODS
        '
        Me.txtNumODS.Location = New System.Drawing.Point(204, 97)
        Me.txtNumODS.Name = "txtNumODS"
        Me.txtNumODS.Size = New System.Drawing.Size(170, 22)
        Me.txtNumODS.TabIndex = 0
        '
        'cboODS
        '
        Me.cboODS.FormattingEnabled = True
        Me.cboODS.Location = New System.Drawing.Point(204, 45)
        Me.cboODS.Name = "cboODS"
        Me.cboODS.Size = New System.Drawing.Size(170, 24)
        Me.cboODS.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SELECCIONA UN ODS:"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblImagen
        '
        Me.lblImagen.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblImagen.Location = New System.Drawing.Point(522, 34)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(208, 156)
        Me.lblImagen.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NOMBRE ODS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nº ODS"
        '
        'txtNombreODS
        '
        Me.txtNombreODS.Location = New System.Drawing.Point(204, 142)
        Me.txtNombreODS.Name = "txtNombreODS"
        Me.txtNombreODS.Size = New System.Drawing.Size(170, 22)
        Me.txtNombreODS.TabIndex = 7
        '
        'txtDescripcionODS
        '
        Me.txtDescripcionODS.Location = New System.Drawing.Point(204, 185)
        Me.txtDescripcionODS.Multiline = True
        Me.txtDescripcionODS.Name = "txtDescripcionODS"
        Me.txtDescripcionODS.Size = New System.Drawing.Size(293, 106)
        Me.txtDescripcionODS.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DESCRIPCIÓN ODS"
        '
        'CambioODS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 331)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcionODS)
        Me.Controls.Add(Me.txtNombreODS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblImagen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboODS)
        Me.Controls.Add(Me.txtNumODS)
        Me.Name = "CambioODS"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumODS As TextBox
    Friend WithEvents cboODS As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblImagen As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreODS As TextBox
    Friend WithEvents txtDescripcionODS As TextBox
    Friend WithEvents Label4 As Label
End Class
