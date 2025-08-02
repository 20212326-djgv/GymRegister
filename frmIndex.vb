Imports CapaEntidades
Imports CapaNegocios

Public Class frmIndex


    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim f As New frmUsuario()
        f.ShowDialog()
    End Sub

    Private Sub btnReservas_Click(sender As Object, e As EventArgs) Handles btnReservas.Click
        Dim f As New frmReservas()
        f.ShowDialog()
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        Dim f As New frmServicios()
        f.ShowDialog()
    End Sub

End Class
