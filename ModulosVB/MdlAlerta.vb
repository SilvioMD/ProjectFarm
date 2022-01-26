
Module MdlAlerta

    Public Sub DesplegarAlerta(Mensaje As String, TipoMensaje As Integer, TipoIcono As Integer)

        'aceptar
        If TipoMensaje = 1 Then

            Dim Aceptar As New AlertaAceptar
            Aceptar.TxtMensaje.Text = Mensaje
            Aceptar.PBIcon.Image = SeleccionarIcono(TipoIcono)
            Aceptar.ShowDialog()

            'aceptar cancelar
        ElseIf TipoMensaje = 2 Then
            Dim AceptarCanc As New AlertaAceptarCancelar
            AceptarCanc.TxtMensaje.Text = Mensaje
            AceptarCanc.PBIcon.Image = SeleccionarIcono(TipoIcono)
            AceptarCanc.ShowDialog()

            'Si no
        ElseIf TipoMensaje = 3 Then
            Dim SiNo As New AlertaSiNo
            SiNo.TxtMensaje.Text = Mensaje
            SiNo.PBIcon.Image = SeleccionarIcono(TipoIcono)
            SiNo.ShowDialog()

            'success
        ElseIf TipoMensaje = 4 Then
            Dim Success As New AlertaSuccess
            Success.TxtMensaje.Text = Mensaje
            Success.PBIcon.Image = SeleccionarIcono(TipoIcono)
            Success.ShowDialog()

        End If


    End Sub

    Public Function SeleccionarIcono(SelIcono As Integer) As Bitmap

        Dim Icono As Bitmap = My.Resources.icono_info

        'icono informacion
        If SelIcono = 1 Then

            Icono = My.Resources.icono_info
            'icono eliminar
        ElseIf SelIcono = 2 Then
            Icono = My.Resources.icono_error
            'icono pregunta
        ElseIf SelIcono = 3 Then
            Icono = My.Resources.icono_pregunta
        End If

        Return Icono
    End Function

End Module
