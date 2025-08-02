Imports CapaNegocios
Imports CapaEntidades

Public Class frmUsuario
    Dim bll As New UsuarioBLL()
    Dim idSeleccionado As Integer = -1

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRol.Items.AddRange(New String() {"Administrador", "Cliente", "Empleado"})
        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()
        dgvUsuarios.DataSource = Nothing
        dgvUsuarios.DataSource = bll.ObtenerTodos()
    End Sub

    Private Sub Limpiar()
        txtNombre.Clear()
        txtCorreo.Clear()
        txtContraseña.Clear()
        cbRol.SelectedIndex = -1
        idSeleccionado = -1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim usuario As New Usuario With {
            .Nombre = txtNombre.Text,
            .Correo = txtCorreo.Text,
            .Contraseña = txtContraseña.Text,
            .Rol = cbRol.Text
        }
        bll.Agregar(usuario)
        CargarUsuarios()
        Limpiar()
    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If e.RowIndex >= 0 Then
            Dim fila = dgvUsuarios.Rows(e.RowIndex)
            idSeleccionado = fila.Cells("IdUsuario").Value
            txtNombre.Text = fila.Cells("Nombre").Value.ToString()
            txtCorreo.Text = fila.Cells("Correo").Value.ToString()
            txtContraseña.Text = fila.Cells("Contraseña").Value.ToString()
            cbRol.Text = fila.Cells("Rol").Value.ToString()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If idSeleccionado <> -1 Then
            Dim usuario As New Usuario With {
                .IdUsuario = idSeleccionado,
                .Nombre = txtNombre.Text,
                .Correo = txtCorreo.Text,
                .Contraseña = txtContraseña.Text,
                .Rol = cbRol.Text
            }
            bll.Editar(usuario)
            CargarUsuarios()
            Limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idSeleccionado <> -1 Then
            bll.Eliminar(idSeleccionado)
            CargarUsuarios()
            Limpiar()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
End Class