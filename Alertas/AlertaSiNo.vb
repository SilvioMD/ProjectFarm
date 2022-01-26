Public Class AlertaSiNo
    Private Sub BtnSi_Click(sender As Object, e As EventArgs) Handles BtnSi.Click
        VariablesGlobales.RespuestaAlerta = True
        Hide()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        VariablesGlobales.RespuestaAlerta = False
        Hide()
    End Sub
End Class