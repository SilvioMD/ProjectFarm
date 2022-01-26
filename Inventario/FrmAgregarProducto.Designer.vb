<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarProducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGVMostrarProductos = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbControlNo = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RbControlSi = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbPediatrico = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RbAdulto = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtUnidadMedida = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAcceder = New System.Windows.Forms.Button()
        Me.CboPresentacion = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CboAccFarm = New System.Windows.Forms.ComboBox()
        Me.CboLaboratorio = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtCantidadMinima = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVMostrarProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(25, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(617, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Producto:"
        '
        'CbTipoProducto
        '
        Me.CbTipoProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CbTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbTipoProducto.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipoProducto.ForeColor = System.Drawing.Color.White
        Me.CbTipoProducto.FormattingEnabled = True
        Me.CbTipoProducto.Items.AddRange(New Object() {"Medicamento", "Variedades"})
        Me.CbTipoProducto.Location = New System.Drawing.Point(772, 13)
        Me.CbTipoProducto.Name = "CbTipoProducto"
        Me.CbTipoProducto.Size = New System.Drawing.Size(204, 27)
        Me.CbTipoProducto.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CbTipoProducto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 50)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.DGVMostrarProductos)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(998, 574)
        Me.Panel2.TabIndex = 4
        '
        'DGVMostrarProductos
        '
        Me.DGVMostrarProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.DGVMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMostrarProductos.Location = New System.Drawing.Point(12, 317)
        Me.DGVMostrarProductos.Name = "DGVMostrarProductos"
        Me.DGVMostrarProductos.Size = New System.Drawing.Size(964, 250)
        Me.DGVMostrarProductos.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.TxtUnidadMedida)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.BtnAcceder)
        Me.Panel4.Controls.Add(Me.CboPresentacion)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.CboAccFarm)
        Me.Panel4.Controls.Add(Me.CboLaboratorio)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Panel4.Location = New System.Drawing.Point(470, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(506, 296)
        Me.Panel4.TabIndex = 4
        Me.Panel4.UseWaitCursor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbControlNo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.RbControlSi)
        Me.GroupBox2.Location = New System.Drawing.Point(259, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 76)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.UseWaitCursor = True
        '
        'RbControlNo
        '
        Me.RbControlNo.AutoSize = True
        Me.RbControlNo.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbControlNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.RbControlNo.Location = New System.Drawing.Point(112, 43)
        Me.RbControlNo.Name = "RbControlNo"
        Me.RbControlNo.Size = New System.Drawing.Size(45, 27)
        Me.RbControlNo.TabIndex = 27
        Me.RbControlNo.TabStop = True
        Me.RbControlNo.Text = "No"
        Me.RbControlNo.UseVisualStyleBackColor = True
        Me.RbControlNo.UseWaitCursor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(25, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 28)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "control:"
        Me.Label13.UseWaitCursor = True
        '
        'RbControlSi
        '
        Me.RbControlSi.AutoSize = True
        Me.RbControlSi.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbControlSi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.RbControlSi.Location = New System.Drawing.Point(112, 16)
        Me.RbControlSi.Name = "RbControlSi"
        Me.RbControlSi.Size = New System.Drawing.Size(40, 27)
        Me.RbControlSi.TabIndex = 28
        Me.RbControlSi.TabStop = True
        Me.RbControlSi.Text = "Si"
        Me.RbControlSi.UseVisualStyleBackColor = True
        Me.RbControlSi.UseWaitCursor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbPediatrico)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.RbAdulto)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 209)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 78)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseWaitCursor = True
        '
        'RbPediatrico
        '
        Me.RbPediatrico.AutoSize = True
        Me.RbPediatrico.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPediatrico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.RbPediatrico.Location = New System.Drawing.Point(114, 45)
        Me.RbPediatrico.Name = "RbPediatrico"
        Me.RbPediatrico.Size = New System.Drawing.Size(96, 27)
        Me.RbPediatrico.TabIndex = 26
        Me.RbPediatrico.TabStop = True
        Me.RbPediatrico.Text = "Pediatrico"
        Me.RbPediatrico.UseVisualStyleBackColor = True
        Me.RbPediatrico.UseWaitCursor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(7, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 28)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Edad:"
        Me.Label12.UseWaitCursor = True
        '
        'RbAdulto
        '
        Me.RbAdulto.AutoSize = True
        Me.RbAdulto.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAdulto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.RbAdulto.Location = New System.Drawing.Point(114, 16)
        Me.RbAdulto.Name = "RbAdulto"
        Me.RbAdulto.Size = New System.Drawing.Size(72, 27)
        Me.RbAdulto.TabIndex = 25
        Me.RbAdulto.TabStop = True
        Me.RbAdulto.Text = "Adulto"
        Me.RbAdulto.UseVisualStyleBackColor = True
        Me.RbAdulto.UseWaitCursor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(49, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(166, 28)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Unidad de Medida:"
        Me.Label14.UseWaitCursor = True
        '
        'TxtUnidadMedida
        '
        Me.TxtUnidadMedida.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TxtUnidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUnidadMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnidadMedida.ForeColor = System.Drawing.Color.White
        Me.TxtUnidadMedida.Location = New System.Drawing.Point(220, 178)
        Me.TxtUnidadMedida.Name = "TxtUnidadMedida"
        Me.TxtUnidadMedida.Size = New System.Drawing.Size(189, 26)
        Me.TxtUnidadMedida.TabIndex = 14
        Me.TxtUnidadMedida.Tag = ""
        Me.TxtUnidadMedida.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Image = Global.Capa_de_Vistas.My.Resources.Resources.buscar
        Me.Button2.Location = New System.Drawing.Point(421, 139)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 29)
        Me.Button2.TabIndex = 24
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = Global.Capa_de_Vistas.My.Resources.Resources.buscar
        Me.Button1.Location = New System.Drawing.Point(421, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 29)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.UseWaitCursor = True
        '
        'BtnAcceder
        '
        Me.BtnAcceder.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAcceder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAcceder.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAcceder.Image = Global.Capa_de_Vistas.My.Resources.Resources.buscar
        Me.BtnAcceder.Location = New System.Drawing.Point(421, 51)
        Me.BtnAcceder.Name = "BtnAcceder"
        Me.BtnAcceder.Size = New System.Drawing.Size(38, 27)
        Me.BtnAcceder.TabIndex = 13
        Me.BtnAcceder.UseVisualStyleBackColor = False
        Me.BtnAcceder.UseWaitCursor = True
        '
        'CboPresentacion
        '
        Me.CboPresentacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CboPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboPresentacion.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPresentacion.ForeColor = System.Drawing.Color.White
        Me.CboPresentacion.FormattingEnabled = True
        Me.CboPresentacion.Items.AddRange(New Object() {"Medicamento", "Variedades"})
        Me.CboPresentacion.Location = New System.Drawing.Point(220, 137)
        Me.CboPresentacion.Name = "CboPresentacion"
        Me.CboPresentacion.Size = New System.Drawing.Size(204, 27)
        Me.CboPresentacion.TabIndex = 17
        Me.CboPresentacion.UseWaitCursor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(96, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 28)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Presentación:"
        Me.Label11.UseWaitCursor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(26, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(189, 28)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Accion Farmacologica:"
        Me.Label10.UseWaitCursor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(105, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 28)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Laboratorio:"
        Me.Label9.UseWaitCursor = True
        '
        'CboAccFarm
        '
        Me.CboAccFarm.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CboAccFarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboAccFarm.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAccFarm.ForeColor = System.Drawing.Color.White
        Me.CboAccFarm.FormattingEnabled = True
        Me.CboAccFarm.Items.AddRange(New Object() {"Medicamento", "Variedades"})
        Me.CboAccFarm.Location = New System.Drawing.Point(220, 96)
        Me.CboAccFarm.Name = "CboAccFarm"
        Me.CboAccFarm.Size = New System.Drawing.Size(204, 27)
        Me.CboAccFarm.TabIndex = 4
        Me.CboAccFarm.UseWaitCursor = True
        '
        'CboLaboratorio
        '
        Me.CboLaboratorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CboLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboLaboratorio.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLaboratorio.ForeColor = System.Drawing.Color.White
        Me.CboLaboratorio.FormattingEnabled = True
        Me.CboLaboratorio.Items.AddRange(New Object() {"Medicamento", "Variedades"})
        Me.CboLaboratorio.Location = New System.Drawing.Point(220, 50)
        Me.CboLaboratorio.Name = "CboLaboratorio"
        Me.CboLaboratorio.Size = New System.Drawing.Size(204, 27)
        Me.CboLaboratorio.TabIndex = 3
        Me.CboLaboratorio.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(24, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Medicamento"
        Me.Label4.UseWaitCursor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtDescripcion)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.BtnGuardar)
        Me.Panel3.Controls.Add(Me.TxtCantidadMinima)
        Me.Panel3.Controls.Add(Me.TxtCantidad)
        Me.Panel3.Controls.Add(Me.TxtPrecio)
        Me.Panel3.Controls.Add(Me.TxtNombre)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(14, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(436, 296)
        Me.Panel3.TabIndex = 0
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.ForeColor = System.Drawing.Color.White
        Me.TxtDescripcion.Location = New System.Drawing.Point(206, 209)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(189, 26)
        Me.TxtDescripcion.TabIndex = 31
        Me.TxtDescripcion.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(84, 207)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 28)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Descripción:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Green
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGuardar.Location = New System.Drawing.Point(206, 248)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(189, 33)
        Me.BtnGuardar.TabIndex = 29
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtCantidadMinima
        '
        Me.TxtCantidadMinima.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TxtCantidadMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidadMinima.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadMinima.ForeColor = System.Drawing.Color.White
        Me.TxtCantidadMinima.Location = New System.Drawing.Point(206, 176)
        Me.TxtCantidadMinima.Name = "TxtCantidadMinima"
        Me.TxtCantidadMinima.Size = New System.Drawing.Size(189, 26)
        Me.TxtCantidadMinima.TabIndex = 13
        Me.TxtCantidadMinima.Tag = ""
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.ForeColor = System.Drawing.Color.White
        Me.TxtCantidad.Location = New System.Drawing.Point(206, 136)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(189, 26)
        Me.TxtCantidad.TabIndex = 12
        Me.TxtCantidad.Tag = ""
        '
        'TxtPrecio
        '
        Me.TxtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.ForeColor = System.Drawing.Color.White
        Me.TxtPrecio.Location = New System.Drawing.Point(206, 98)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(189, 26)
        Me.TxtPrecio.TabIndex = 11
        Me.TxtPrecio.Tag = ""
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.White
        Me.TxtNombre.Location = New System.Drawing.Point(206, 57)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(189, 26)
        Me.TxtNombre.TabIndex = 10
        Me.TxtNombre.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(35, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 28)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Cantidad Minima:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(102, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 28)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Cantidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(133, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 28)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Precio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nombre del producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Datos requeridos"
        '
        'FrmAgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(998, 624)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAgregarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAgregarInventario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVMostrarProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CbTipoProducto As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CboPresentacion As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CboAccFarm As ComboBox
    Friend WithEvents CboLaboratorio As ComboBox
    Friend WithEvents TxtCantidadMinima As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnAcceder As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents RbControlSi As RadioButton
    Friend WithEvents RbControlNo As RadioButton
    Friend WithEvents RbPediatrico As RadioButton
    Friend WithEvents RbAdulto As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtUnidadMedida As TextBox
    Friend WithEvents DGVMostrarProductos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label15 As Label
End Class
