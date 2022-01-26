
Public Class FrmMenuInventario

    Dim info As FrmVerInfo
    Dim FormularioActual As Form
    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'validar si el formulario ya esta abierto
        If info Is Nothing Then
            'abrir formulario dentro del formulario padre
            info = New FrmVerInfo With {
                .MdiParent = Me
            }
            'mostrar formulario 
            info.Show()

        Else
            'traer al frente el formulario
            info.BringToFront()

        End If
    End Sub

    Private Sub FrmMenuInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Aside.Width = 180 Then
            Aside.Width = 40
            Ocultar()
        Else
            Aside.Width = 180
            MostrarBotones()
        End If
    End Sub
    'Ocultar los nombres i mostrar solamente imagen
    Private Sub Ocultar()
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

    End Sub

    Private Sub MostrarBotones()
        Button4.Text = "Inicio"
        Button5.Text = "Productos"
        Button6.Text = "Nuevo"
        Button7.Text = "Modificar"
        Button8.Text = "Buscar"
        Button9.Text = "Propiedades"

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Modulos As New FrmMenuModulos
        Hide()
        Modulos.Show()
    End Sub

    Private Sub BtnMinIS_Click(sender As Object, e As EventArgs) Handles BtnMinIS.Click
        If WindowState = 2 Then
            WindowState = FormWindowState.Normal

        ElseIf WindowState = 0 Then
            WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        AbrirForm(New FrmAgregarProducto)

    End Sub

    Private Sub AbrirForm(FormularioHijo As Form)
        If FormularioActual IsNot Nothing Then
            FormularioActual.Close()
        End If

        FormularioActual = FormularioHijo

        FormularioHijo.TopLevel = False
        FormularioHijo.Dock = DockStyle.Fill
        pnlFormulario.Controls.Add(FormularioHijo)
        pnlFormulario.Tag = FormularioHijo
        FormularioHijo.BringToFront()
        FormularioHijo.Show()
    End Sub

End Class