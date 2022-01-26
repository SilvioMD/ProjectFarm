Imports Capa_de_Seguridad
Imports Capa_de_Dominio

Public Class FrmVerificarIdentidad

    Dim mostrar As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
    End Sub

    Private Sub BtnVisible_Click(sender As Object, e As EventArgs) Handles BtnVisible.Click

        If mostrar = False Then
            txtcontraseña.PasswordChar = ""
            BtnVisible.Image = My.Resources.novisible
            mostrar = True
        Else
            txtcontraseña.PasswordChar = "*"
            BtnVisible.Image = My.Resources.visible
            mostrar = False
        End If
    End Sub

    Private Sub BtnAcceder_Click(sender As Object, e As EventArgs) Handles BtnAcceder.Click
        If txtcontraseña.Text <> "" Then
            Dim acceso As Integer

            acceso = DomAccesoUsuario.DomValidarAcceso(CacheDatosUsuario.Usuario, txtcontraseña.Text)

            If acceso = 1 Then
                MsgBox("contraseña incorrecta")
                txtcontraseña.Clear()

            ElseIf acceso = 2 Then
                Hide()
                VariablesGlobales.IdentidadVerificada = True


            End If
        End If
    End Sub
End Class