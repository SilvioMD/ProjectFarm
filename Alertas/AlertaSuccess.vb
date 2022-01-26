Public Class AlertaSuccess
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        VariablesGlobales.RespuestaAlerta = True
        Hide()
    End Sub
End Class