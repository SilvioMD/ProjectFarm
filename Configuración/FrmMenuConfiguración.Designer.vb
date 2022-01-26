<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuConfiguración
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnOcultarMenu = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMax = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PlnBotones = New System.Windows.Forms.Panel()
        Me.BtnActInfo = New System.Windows.Forms.Button()
        Me.BtnVerInfo = New System.Windows.Forms.Button()
        Me.BtnCambiarContra = New System.Windows.Forms.Button()
        Me.BtnUsuarioOpc = New System.Windows.Forms.Button()
        Me.BtnRespaldo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PlnBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnOcultarMenu)
        Me.Panel1.Controls.Add(Me.BtnMin)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnMax)
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 34)
        Me.Panel1.TabIndex = 8
        '
        'BtnOcultarMenu
        '
        Me.BtnOcultarMenu.FlatAppearance.BorderSize = 0
        Me.BtnOcultarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOcultarMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOcultarMenu.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnOcultarMenu.Location = New System.Drawing.Point(203, 0)
        Me.BtnOcultarMenu.Name = "BtnOcultarMenu"
        Me.BtnOcultarMenu.Size = New System.Drawing.Size(41, 29)
        Me.BtnOcultarMenu.TabIndex = 6
        Me.BtnOcultarMenu.Text = "||||"
        Me.BtnOcultarMenu.UseVisualStyleBackColor = True
        '
        'BtnMin
        '
        Me.BtnMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMin.FlatAppearance.BorderSize = 0
        Me.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMin.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnMin.Location = New System.Drawing.Point(724, 0)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(38, 34)
        Me.BtnMin.TabIndex = 5
        Me.BtnMin.Text = "__"
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Configuración"
        '
        'BtnMax
        '
        Me.BtnMax.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMax.FlatAppearance.BorderSize = 0
        Me.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMax.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnMax.Location = New System.Drawing.Point(762, 0)
        Me.BtnMax.Name = "BtnMax"
        Me.BtnMax.Size = New System.Drawing.Size(41, 34)
        Me.BtnMax.TabIndex = 2
        Me.BtnMax.Text = "|  |"
        Me.BtnMax.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSalir.Location = New System.Drawing.Point(803, 0)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(45, 34)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "X"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.Panel4)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlMenu.Location = New System.Drawing.Point(0, 34)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(206, 474)
        Me.PnlMenu.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Controls.Add(Me.PlnBotones)
        Me.Panel4.Controls.Add(Me.BtnUsuarioOpc)
        Me.Panel4.Controls.Add(Me.BtnRespaldo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(206, 474)
        Me.Panel4.TabIndex = 11
        '
        'PlnBotones
        '
        Me.PlnBotones.Controls.Add(Me.BtnActInfo)
        Me.PlnBotones.Controls.Add(Me.BtnVerInfo)
        Me.PlnBotones.Controls.Add(Me.BtnCambiarContra)
        Me.PlnBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PlnBotones.Location = New System.Drawing.Point(0, 37)
        Me.PlnBotones.Name = "PlnBotones"
        Me.PlnBotones.Size = New System.Drawing.Size(206, 126)
        Me.PlnBotones.TabIndex = 1
        '
        'BtnActInfo
        '
        Me.BtnActInfo.BackColor = System.Drawing.Color.SlateGray
        Me.BtnActInfo.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray
        Me.BtnActInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActInfo.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActInfo.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnActInfo.Location = New System.Drawing.Point(0, 80)
        Me.BtnActInfo.Name = "BtnActInfo"
        Me.BtnActInfo.Size = New System.Drawing.Size(208, 46)
        Me.BtnActInfo.TabIndex = 2
        Me.BtnActInfo.Text = "Actualizar información"
        Me.BtnActInfo.UseVisualStyleBackColor = False
        '
        'BtnVerInfo
        '
        Me.BtnVerInfo.BackColor = System.Drawing.Color.SlateGray
        Me.BtnVerInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnVerInfo.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray
        Me.BtnVerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerInfo.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerInfo.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnVerInfo.Location = New System.Drawing.Point(-2, 0)
        Me.BtnVerInfo.Name = "BtnVerInfo"
        Me.BtnVerInfo.Size = New System.Drawing.Size(208, 41)
        Me.BtnVerInfo.TabIndex = 1
        Me.BtnVerInfo.Text = "Ver Información"
        Me.BtnVerInfo.UseVisualStyleBackColor = False
        '
        'BtnCambiarContra
        '
        Me.BtnCambiarContra.BackColor = System.Drawing.Color.SlateGray
        Me.BtnCambiarContra.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray
        Me.BtnCambiarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCambiarContra.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiarContra.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCambiarContra.Location = New System.Drawing.Point(0, 40)
        Me.BtnCambiarContra.Name = "BtnCambiarContra"
        Me.BtnCambiarContra.Size = New System.Drawing.Size(208, 44)
        Me.BtnCambiarContra.TabIndex = 3
        Me.BtnCambiarContra.Text = "Cambiar contraseña"
        Me.BtnCambiarContra.UseVisualStyleBackColor = False
        '
        'BtnUsuarioOpc
        '
        Me.BtnUsuarioOpc.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUsuarioOpc.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnUsuarioOpc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUsuarioOpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarioOpc.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarioOpc.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnUsuarioOpc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuarioOpc.Location = New System.Drawing.Point(0, 0)
        Me.BtnUsuarioOpc.Name = "BtnUsuarioOpc"
        Me.BtnUsuarioOpc.Size = New System.Drawing.Size(206, 37)
        Me.BtnUsuarioOpc.TabIndex = 0
        Me.BtnUsuarioOpc.Text = "Usuario"
        Me.BtnUsuarioOpc.UseVisualStyleBackColor = False
        '
        'BtnRespaldo
        '
        Me.BtnRespaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRespaldo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRespaldo.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRespaldo.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnRespaldo.Location = New System.Drawing.Point(0, 162)
        Me.BtnRespaldo.Name = "BtnRespaldo"
        Me.BtnRespaldo.Size = New System.Drawing.Size(208, 41)
        Me.BtnRespaldo.TabIndex = 5
        Me.BtnRespaldo.Text = "Respaldo"
        Me.BtnRespaldo.UseVisualStyleBackColor = False
        '
        'FrmMenuConfiguración
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(848, 508)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "FrmMenuConfiguración"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenuConfiguración"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMenu.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PlnBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnMax As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnOcultarMenu As Button
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PlnBotones As Panel
    Friend WithEvents BtnActInfo As Button
    Friend WithEvents BtnVerInfo As Button
    Friend WithEvents BtnCambiarContra As Button
    Friend WithEvents BtnUsuarioOpc As Button
    Friend WithEvents BtnRespaldo As Button
End Class
