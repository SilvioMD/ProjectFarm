<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertaSiNo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnOcultar = New System.Windows.Forms.Button()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.PBIcon = New System.Windows.Forms.PictureBox()
        Me.TxtMensaje = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnSi = New System.Windows.Forms.Button()
        Me.BtnNo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PBIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.BtnOcultar)
        Me.Panel1.Controls.Add(Me.LblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 42)
        Me.Panel1.TabIndex = 1
        '
        'BtnOcultar
        '
        Me.BtnOcultar.BackColor = System.Drawing.Color.Indigo
        Me.BtnOcultar.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.BtnOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOcultar.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOcultar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnOcultar.Location = New System.Drawing.Point(384, 1)
        Me.BtnOcultar.Name = "BtnOcultar"
        Me.BtnOcultar.Size = New System.Drawing.Size(51, 39)
        Me.BtnOcultar.TabIndex = 1
        Me.BtnOcultar.Text = "X"
        Me.BtnOcultar.UseVisualStyleBackColor = False
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblTitulo.Location = New System.Drawing.Point(23, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(106, 23)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Notificación"
        '
        'PBIcon
        '
        Me.PBIcon.Location = New System.Drawing.Point(18, 66)
        Me.PBIcon.Name = "PBIcon"
        Me.PBIcon.Size = New System.Drawing.Size(133, 152)
        Me.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBIcon.TabIndex = 3
        Me.PBIcon.TabStop = False
        '
        'TxtMensaje
        '
        Me.TxtMensaje.BackColor = System.Drawing.SystemColors.Control
        Me.TxtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMensaje.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMensaje.Location = New System.Drawing.Point(157, 66)
        Me.TxtMensaje.Multiline = True
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(264, 152)
        Me.TxtMensaje.TabIndex = 4
        Me.TxtMensaje.Text = "Mensaje para el usuario"
        Me.TxtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.BtnSi)
        Me.Panel2.Controls.Add(Me.BtnNo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 233)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(431, 60)
        Me.Panel2.TabIndex = 5
        '
        'BtnSi
        '
        Me.BtnSi.BackColor = System.Drawing.Color.Green
        Me.BtnSi.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BtnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSi.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSi.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSi.Location = New System.Drawing.Point(214, 13)
        Me.BtnSi.Name = "BtnSi"
        Me.BtnSi.Size = New System.Drawing.Size(89, 35)
        Me.BtnSi.TabIndex = 1
        Me.BtnSi.Text = "Si"
        Me.BtnSi.UseVisualStyleBackColor = False
        '
        'BtnNo
        '
        Me.BtnNo.BackColor = System.Drawing.Color.Red
        Me.BtnNo.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNo.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNo.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnNo.Location = New System.Drawing.Point(319, 13)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(92, 35)
        Me.BtnNo.TabIndex = 0
        Me.BtnNo.Text = "No"
        Me.BtnNo.UseVisualStyleBackColor = False
        '
        'AlertaSiNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 293)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtMensaje)
        Me.Controls.Add(Me.PBIcon)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AlertaSiNo"
        Me.Text = "FrmAlertaSiNo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnOcultar As Button
    Friend WithEvents LblTitulo As Label
    Friend WithEvents PBIcon As PictureBox
    Friend WithEvents TxtMensaje As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnSi As Button
    Friend WithEvents BtnNo As Button
End Class
