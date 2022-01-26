<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarioCambiarContra
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblConfUsuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtNuevaContra = New System.Windows.Forms.TextBox()
        Me.TxtConfContra = New System.Windows.Forms.TextBox()
        Me.BtnMinIS = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnMinIS)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 33)
        Me.Panel1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(39, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 66)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Cambiar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Capa_de_Vistas.My.Resources.Resources.usuario_login
        Me.PictureBox1.Location = New System.Drawing.Point(39, 153)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 241)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblConfUsuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnActualizar)
        Me.GroupBox1.Controls.Add(Me.TxtNuevaContra)
        Me.GroupBox1.Controls.Add(Me.TxtConfContra)
        Me.GroupBox1.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(223, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 330)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'LblConfUsuario
        '
        Me.LblConfUsuario.AutoSize = True
        Me.LblConfUsuario.ForeColor = System.Drawing.Color.Black
        Me.LblConfUsuario.Location = New System.Drawing.Point(76, 44)
        Me.LblConfUsuario.Name = "LblConfUsuario"
        Me.LblConfUsuario.Size = New System.Drawing.Size(152, 23)
        Me.LblConfUsuario.TabIndex = 20
        Me.LblConfUsuario.Text = "@nombre usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(46, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(46, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nueva contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(46, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Confirmar contraseña"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnActualizar.Location = New System.Drawing.Point(50, 260)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(185, 30)
        Me.BtnActualizar.TabIndex = 19
        Me.BtnActualizar.Text = "Cambiar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'TxtNuevaContra
        '
        Me.TxtNuevaContra.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TxtNuevaContra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNuevaContra.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNuevaContra.ForeColor = System.Drawing.SystemColors.Info
        Me.TxtNuevaContra.Location = New System.Drawing.Point(50, 132)
        Me.TxtNuevaContra.Name = "TxtNuevaContra"
        Me.TxtNuevaContra.Size = New System.Drawing.Size(185, 27)
        Me.TxtNuevaContra.TabIndex = 10
        Me.TxtNuevaContra.Tag = ""
        '
        'TxtConfContra
        '
        Me.TxtConfContra.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TxtConfContra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtConfContra.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfContra.ForeColor = System.Drawing.SystemColors.Info
        Me.TxtConfContra.Location = New System.Drawing.Point(50, 198)
        Me.TxtConfContra.Name = "TxtConfContra"
        Me.TxtConfContra.Size = New System.Drawing.Size(185, 27)
        Me.TxtConfContra.TabIndex = 11
        Me.TxtConfContra.Tag = ""
        '
        'BtnMinIS
        '
        Me.BtnMinIS.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMinIS.FlatAppearance.BorderSize = 0
        Me.BtnMinIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinIS.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnMinIS.Image = Global.Capa_de_Vistas.My.Resources.Resources.min
        Me.BtnMinIS.Location = New System.Drawing.Point(490, 0)
        Me.BtnMinIS.Name = "BtnMinIS"
        Me.BtnMinIS.Size = New System.Drawing.Size(35, 33)
        Me.BtnMinIS.TabIndex = 4
        Me.BtnMinIS.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Image = Global.Capa_de_Vistas.My.Resources.Resources.cerrar
        Me.Button2.Location = New System.Drawing.Point(525, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 33)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmUsuarioCambiarContra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(559, 432)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUsuarioCambiarContra"
        Me.Text = "FrmUsuarioCambiarContra"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblConfUsuario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtNuevaContra As TextBox
    Friend WithEvents TxtConfContra As TextBox
    Friend WithEvents BtnMinIS As Button
    Friend WithEvents Button2 As Button
End Class
