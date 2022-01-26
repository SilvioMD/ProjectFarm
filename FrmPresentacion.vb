Imports Capa_de_Seguridad

Public Class FrmPresentacion
    Private Sub FrmPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuario.Text = CacheDatosUsuario.Nombres + " " + CacheDatosUsuario.Apellidos + "  !!"
        ProgressBar1.Value = 0
        Opacity = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        progreso.Text = ProgressBar1.Value.ToString + "%"
        If Opacity < 1 Then
            Opacity += 0.05
        End If

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Opacity -= 0.1
        If Opacity = 0 Then
            Timer2.Stop()
            Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Progreso_Click(sender As Object, e As EventArgs) Handles progreso.Click

    End Sub
End Class