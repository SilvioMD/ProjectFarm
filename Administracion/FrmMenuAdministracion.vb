Public Class FrmMenuAdministracion
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
        Button5.Text = "Agregar Usuario"
        Button6.Text = "Accesos"
        Button7.Text = "Historial"
        Button8.Text = "Gastos Varios"
        Button9.Text = "Respaldo"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
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
End Class