Imports Capa_de_Seguridad
Public Class FrmMenuModulos

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub FrmMenuModulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CacheDatosUsuario.Rol = "Farmaceutico" Then
            BtnAdministracion.Visible = False

        End If
    End Sub

    Private Sub BtnMinM_Click(sender As Object, e As EventArgs) Handles BtnMinM.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click

    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        Dim Inventario As New FrmMenuInventario
        Hide()
        Inventario.Show()
    End Sub

    Private Sub BtnCompras_Click(sender As Object, e As EventArgs) Handles BtnCompras.Click
        Dim Compra As New FrmMenuCompras
        Hide()
        Compra.Show()
    End Sub

    Private Sub BtnConfiguracion_Click(sender As Object, e As EventArgs) Handles BtnVenta.Click
        Dim Venta As New FrmMenuVentas
        Hide()
        Venta.Show()
    End Sub

    Private Sub BtnAdministracion_Click(sender As Object, e As EventArgs) Handles BtnAdministracion.Click
        Dim Administracion As New FrmMenuAdministracion
        Hide()
        Administracion.Show()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class