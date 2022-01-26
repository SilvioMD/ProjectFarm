Public Class FrmMenuConfiguración

    'declarar los formularios que contendra el menu principal
    Dim Info As FrmVerInfo
    Dim Actualizar As FrmUsuarioActualizar
    Dim CambiarContra As FrmUsuarioCambiarContra

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub BtnMax_Click(sender As Object, e As EventArgs) Handles BtnMax.Click
        If WindowState = 2 Then
            WindowState = FormWindowState.Normal

        ElseIf WindowState = 0 Then
            WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnActInfo_Click(sender As Object, e As EventArgs) Handles BtnActInfo.Click

        'validar si el formulario ya esta abierto
        If Actualizar Is Nothing Then
            'abrir formulario dentro del formulario padre
            Actualizar = New FrmUsuarioActualizar With {
                .MdiParent = Me
            }
            'mostrar formulario 
            Actualizar.Show()
        Else
            'traer al frente el formulario
            Actualizar.BringToFront()

        End If

    End Sub

    Private Sub BtnMenuModulos_Click(sender As Object, e As EventArgs)
        Dim FrmModulos As New FrmMenuModulos
        Hide()
        FrmModulos.Show()
    End Sub

    Private Sub BtnOcultarMenu_Click(sender As Object, e As EventArgs) Handles BtnOcultarMenu.Click

        If PnlMenu.Visible = True Then
            PnlMenu.Visible = False
        Else
            PnlMenu.Visible = True
        End If

    End Sub

    Private Sub BtnUsuarioOpc_Click(sender As Object, e As EventArgs) Handles BtnUsuarioOpc.Click

        If PlnBotones.Visible = False Then
            PlnBotones.Visible = True
        Else
            PlnBotones.Visible = False
        End If
    End Sub

    Private Sub BtnVerInfo_Click(sender As Object, e As EventArgs) Handles BtnVerInfo.Click

        'validar si el formulario ya esta abierto
        If Info Is Nothing Then
            'abrir formulario dentro del formulario padre
            Info = New FrmVerInfo With {
                .MdiParent = Me
            }
            'mostrar formulario 
            Info.Show()

        Else
            'traer al frente el formulario
            Info.BringToFront()

        End If

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub BtnCambiarContra_Click(sender As Object, e As EventArgs) Handles BtnCambiarContra.Click

        'validar si el formulario ya esta abierto
        If CambiarContra Is Nothing Then
            'abrir formulario dentro del formulario padre
            CambiarContra = New FrmUsuarioCambiarContra With {
                .MdiParent = Me
            }
            'mostrar formulario 
            CambiarContra.Show()
        Else
            'traer al frente el formulario
            CambiarContra.BringToFront()

        End If
    End Sub

    Private Sub BtnRespaldo_Click(sender As Object, e As EventArgs) Handles BtnRespaldo.Click

    End Sub
End Class