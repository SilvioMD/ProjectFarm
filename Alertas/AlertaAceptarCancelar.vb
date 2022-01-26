Public Class AlertaAceptarCancelar
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        VariablesGlobales.RespuestaAlerta = True
        Hide()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        VariablesGlobales.RespuestaAlerta = False
        Hide()
    End Sub
End Class