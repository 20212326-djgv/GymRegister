Imports CapaEntidades
Imports CapaNegocios

Public Class frmServicios
    Dim bll As New ServicioBLL()
    Dim idSeleccionado As Integer = -1

    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarServicios()
    End Sub

    Private Sub CargarServicios()
        dgvServicios.DataSource = Nothing
        dgvServicios.DataSource = bll.ObtenerTodos()
    End Sub

    Private Sub Limpiar()
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        txtDuracion.Clear()
        ChkEstado.Checked = True
        idSeleccionado = -1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim servicio As New Servicio With {
            .Nombre = txtNombre.Text,
            .Descripcion = txtDescripcion.Text,
            .Precio = Convert.ToDecimal(txtPrecio.Text),
            .Duracion = Convert.ToInt32(txtDuracion.Text),
            .Estado = ChkEstado.Checked
        }
        bll.Agregar(servicio)
        CargarServicios()
        Limpiar()
    End Sub

    Private Sub dgvServicios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicios.CellClick
        If e.RowIndex >= 0 Then
            Dim fila = dgvServicios.Rows(e.RowIndex)
            idSeleccionado = fila.Cells("IdServicio").Value
            txtNombre.Text = fila.Cells("Nombre").Value.ToString()
            txtDescripcion.Text = fila.Cells("Descripcion").Value.ToString()
            txtPrecio.Text = fila.Cells("Precio").Value.ToString()
            txtDuracion.Text = Convert.ToInt32(fila.Cells("Duracion").Value)
            ChkEstado.Checked = Convert.ToBoolean(fila.Cells("Estado").Value)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If idSeleccionado <> -1 Then
            Dim servicio As New Servicio With {
                .IdServicio = idSeleccionado,
                .Nombre = txtNombre.Text,
                .Descripcion = txtDescripcion.Text,
                .Precio = Convert.ToDecimal(txtPrecio.Text),
                .Duracion = Convert.ToInt32(txtDuracion.Text),
                .Estado = ChkEstado.Checked
            }
            bll.Editar(servicio)
            CargarServicios()
            Limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idSeleccionado <> -1 Then
            bll.Eliminar(idSeleccionado)
            CargarServicios()
            Limpiar()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
End Class