Imports Capa_de_Dominio

Public Class FrmAgregarProducto

    Private Sub FrmAgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CbTipoProducto.DataSource = DomCatalogos.DomCatTipoProducto()
        CbTipoProducto.DisplayMember = "TipoProducto"
        CbTipoProducto.ValueMember = "IdTipo"

        CboLaboratorio.DataSource = DomCatalogos.DomCatLaboratorio()
        CboLaboratorio.DisplayMember = "Laboratorio"
        CboLaboratorio.ValueMember = "IdLaboratorio"

        CboAccFarm.DataSource = DomCatalogos.DomCatAccionFarmaciologica()
        CboAccFarm.DisplayMember = "AccionFarmaciologica"
        CboAccFarm.ValueMember = "IdAccionFarmaciologica"

        CboPresentacion.DataSource = DomCatalogos.DomCatPresentacion()
        CboPresentacion.DisplayMember = "Presentacion"
        CboPresentacion.ValueMember = "IdPresentacion"

        DGVMostrarProductos.DataSource = DomMedicamento.MostrarMed()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim Tipoedad, ControlM As Integer


        'definir el tipo de producto
        If Integer.Parse(CbTipoProducto.SelectedValue.ToString) = 2 Then
            MsgBox("valor: " + CbTipoProducto.SelectedValue.ToString)

            'definir el tipo de edad recomendada
            If RbAdulto.Checked Then
                Tipoedad = 1
            ElseIf RbPediatrico.Checked Then
                Tipoedad = 2
            End If

            'definir si el medicamento esta controlado
            If RbControlSi.Checked Then
                ControlM = 1
            ElseIf RbControlNo.Checked Then
                ControlM = 2

            End If
        End If

        If TxtNombre.Text <> "" And TxtPrecio.Text <> "" And TxtCantidad.Text <> "" And TxtCantidadMinima.Text <> "" Then

            DomProducto.AgregarProductos(TxtNombre.Text, Integer.Parse(CbTipoProducto.ValueMember), Double.Parse(TxtPrecio.Text), Integer.Parse(TxtCantidad.Text), Integer.Parse(TxtCantidadMinima.Text), TxtUnidadMedida.Text,
                                    Integer.Parse(CboAccFarm.SelectedValue.ToString), Integer.Parse(CboLaboratorio.SelectedValue.ToString), ControlM, Integer.Parse(CboPresentacion.SelectedValue.ToString), Tipoedad, TxtDescripcion.Text)
        Else
            MsgBox("faltan campos necesarios")
        End If

    End Sub
End Class