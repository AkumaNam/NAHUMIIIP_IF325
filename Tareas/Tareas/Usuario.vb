Imports System.Text.RegularExpressions
Public Class Usuario
    Dim conexion As New Conexion()
    Dim dt As New DataTable
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        Llenar()

    End Sub

    'username@midominio.com
    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function


    Private Sub limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtUserName.Clear()
        txtPsw.Clear()
        txtCorreo.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCorreo(LCase(txtCorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo.Focus()
            txtCorreo.SelectAll()
        Else
            insertarUsuaurio()
            MessageBox.Show("Correo valido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub
    Private Sub insertarUsuaurio()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol, estado As String
        idUsuario = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        userName = txtUserName.Text
        psw = txtPsw.Text
        correo = txtCorreo.Text
        estado = "activo"
        rol = cmbRol.Text
        Try
            If conexion.insertarUsuario(idUsuario, convertMayus(nombre), convertMayus(apellido), userName, psw, rol, estado, LCase(correo)) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Llenar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Function convertMayus(ByVal text As String)
        Return StrConv(text, VbStrConv.ProperCase)
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim ID As Integer
        Dim rol As String
        ID = txtCodigo.Text
        rol = cmbRol.Text
        Try
            If conexion.eliminarUsuario(ID, rol) Then
                MessageBox.Show("Eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Llenar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al eliminar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ID As Integer
        Dim nombre, apellido, username, psw, correo, rol As String
        ID = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        username = txtUserName.Text
        psw = txtPsw.Text
        correo = txtCorreo.Text
        rol = cmbRol.Text
        Try
            If conexion.modificarUsuario(ID, nombre, apellido, username, psw, rol, correo) Then
                MessageBox.Show("Modificado Exitosamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Llenar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellContentClick
        Dim FilaActual As Integer
        FilaActual = dtg.CurrentRow.Index
        txtCodigo.Text = dtg.Rows(FilaActual).Cells(0).Value
        txtNombre.Text = dtg.Rows(FilaActual).Cells(1).Value
        txtApellido.Text = dtg.Rows(FilaActual).Cells(2).Value
        txtUserName.Text = dtg.Rows(FilaActual).Cells(3).Value
        txtPsw.Text = dtg.Rows(FilaActual).Cells(4).Value
        cmbRol.Text = dtg.Rows(FilaActual).Cells(5).Value
        txtCorreo.Text = dtg.Rows(FilaActual).Cells(7).Value
    End Sub
    Private Sub buscar()
        Try
            dt = conexion.busqueda(" usuario ", " nombreUsuario like '%" + txtBuscar.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtg.DataSource = dt
                conexion.conexion.Close()
            Else
                dtg.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            dt = conexion.busqueda(" usuario ", " nombreUsuario like '%" + txtBuscar.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtg.DataSource = dt
                conexion.conexion.Close()
            Else
                dtg.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Llenar()
        conexion.Llenar("select idUsuario as 'ID', nombre as 'Nombre', apellido as 'Apellido', nombreUsuario as 'Usuario', psw as 'Contraseña', rol as 'Rol', estado as 'Estado', correo as 'Correo Eléctronico' from usuario", "usuario")
        dtg.DataSource = conexion.ds.Tables("usuario")
    End Sub
End Class