Imports CapaNegocios
Imports CapaEntidades

Public Class frmReservas
    Dim bllReservas As New ReservasBLL()
    Dim bllUsuarios As New UsuarioBLL()
    Dim bllServicios As New ServicioBLL()
    Dim idSeleccionado As Integer = -1

    Private Sub frmReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbUsuario.DataSource = bllUsuarios.ObtenerTodos()
        cbUsuario.DisplayMember = "Nombre"
        cbUsuario.ValueMember = "IdUsuario"

        cbServicio.DataSource = bllServicios.ObtenerTodos()
        cbServicio.DisplayMember = "Nombre"
        cbServicio.ValueMember = "IdServicio"

        CargarReservas()
    End Sub

    Private Sub CargarReservas()
        dgvReservas.DataSource = Nothing
        dgvReservas.DataSource = bllReservas.ObtenerTodos()
    End Sub

    Private Sub Limpiar()
        cbUsuario.SelectedIndex = -1
        cbServicio.SelectedIndex = -1
        dtFechaHora.Value = DateTime.Now
        chkEstado.Checked = True
        idSeleccionado = -1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim reserva As New Reserva With {
            .IdUsuario = cbUsuario.SelectedValue,
            .IdServicio = cbServicio.SelectedValue,
            .FechaHora = dtFechaHora.Value,
            .Estado = chkEstado.Checked
        }
        bllReservas.Agregar(reserva)
        CargarReservas()
        Limpiar()
    End Sub

    Private Sub dgvReservas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservas.CellClick
        If e.RowIndex >= 0 Then
            Dim fila = dgvReservas.Rows(e.RowIndex)
            idSeleccionado = fila.Cells("IdReserva").Value
            cbUsuario.SelectedValue = fila.Cells("IdUsuario").Value
            cbServicio.SelectedValue = fila.Cells("IdServicio").Value
            dtFechaHora.Value = Convert.ToDateTime(fila.Cells("FechaHora").Value)
            chkEstado.Checked = Convert.ToBoolean(fila.Cells("Estado").Value)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If idSeleccionado <> -1 Then
            Dim reserva As New Reserva With {
                .IdReserva = idSeleccionado,
                .IdUsuario = cbUsuario.SelectedValue,
                .IdServicio = cbServicio.SelectedValue,
                .FechaHora = dtFechaHora.Value,
                .Estado = chkEstado.Checked
            }
            bllReservas.Editar(reserva)
            CargarReservas()
            Limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idSeleccionado <> -1 Then
            bllReservas.Eliminar(idSeleccionado)
            CargarReservas()
            Limpiar()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
End Class