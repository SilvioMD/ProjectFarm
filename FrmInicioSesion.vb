Imports Capa_de_Dominio

Public Class Form1

    Dim mostrar As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAcceder_Click(sender As Object, e As EventArgs) Handles BtnAcceder.Click

        Dim acceso As Integer

        If txtUsuario.Text <> "" And txtcontraseña.Text <> "" Then

            Try

                acceso = DomAccesoUsuario.DomValidarAcceso(txtUsuario.Text, txtcontraseña.Text)

                If acceso = 0 Then
                    MsgBox("usuario incorrecto")
                    txtUsuario.Clear()
                    txtcontraseña.Clear()

                ElseIf acceso = 1 Then
                    MsgBox("contraseña incorrecta")
                    txtcontraseña.Clear()

                ElseIf acceso = 2 Then

                    Dim presentacion As New FrmPresentacion
                    Dim menumodulos As New FrmMenuModulos
                    Hide()
                    presentacion.ShowDialog()
                    menumodulos.Show()

                Else
                    MsgBox("error en base de datos")
                    txtUsuario.Clear()
                    txtcontraseña.Clear()

                End If

            Catch ex As Exception
                MsgBox("error: " + ex.ToString)
            End Try
        Else
            MsgBox("ingrese los campos de texto")
        End If

    End Sub

    Private Sub ChkMostrarContra_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnMinIS_Click(sender As Object, e As EventArgs) Handles BtnMinIS.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
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
End Class
