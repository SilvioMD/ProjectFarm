<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertaSuccess
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
        Me.TxtMensaje = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.PBIcon = New System.Windows.Forms.PictureBox()
        CType(Me.PBIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtMensaje
        '
        Me.TxtMensaje.BackColor = System.Drawing.Color.LimeGreen
        Me.TxtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMensaje.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMensaje.Location = New System.Drawing.Point(141, 8)
        Me.TxtMensaje.Multiline = True
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(252, 75)
        Me.TxtMensaje.TabIndex = 5
        Me.TxtMensaje.Text = "Mensaje para el usuario"
        Me.TxtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Green
        Me.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Location = New System.Drawing.Point(141, 89)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(252, 33)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'PBIcon
        '
        Me.PBIcon.Location = New System.Drawing.Point(12, 8)
        Me.PBIcon.Name = "PBIcon"
        Me.PBIcon.Size = New System.Drawing.Size(117, 114)
        Me.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBIcon.TabIndex = 6
        Me.PBIcon.TabStop = False
        '
        'AlertaSuccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(410, 135)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.PBIcon)
        Me.Controls.Add(Me.TxtMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AlertaSuccess"
        Me.Text = "AlertaSuccess"
        CType(Me.PBIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtMensaje As TextBox
    Friend WithEvents PBIcon As PictureBox
    Friend WithEvents BtnAceptar As Button
End Class
