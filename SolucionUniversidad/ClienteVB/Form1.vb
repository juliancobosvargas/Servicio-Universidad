Public Class Form1

    Private servicio As New ReferenciaServicio.ServicioEscuelaSoapClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEscuela.DataSource = servicio.Listar.Tables(0)
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        If dgvEscuela.Rows.Count > 0 Then
            Dim i As Integer = dgvEscuela.CurrentRow.Index
            If i >= 0 Then
                txtCodAct.Text = dgvEscuela.Item(0, i).Value
                txtNombreAct.Text = dgvEscuela.Item(1, i).Value
            End If
        End If
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim arreglo() As String = servicio.Agregar(txtCodigo.Text, txtNombre.Text)
        Select Case arreglo(0)
            Case "True"
                MsgBox(arreglo(1), MsgBoxStyle.Information, "Correcto")
                'actualizo tabla
                dgvEscuela.DataSource = servicio.Listar.Tables(0)
            Case "False"
                MsgBox(arreglo(1), MsgBoxStyle.Critical, "Error")
        End Select
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim arreglo() As String = servicio.Actualizar(txtCodAct.Text, txtNombreAct.Text)
        Select Case arreglo(0)
            Case "True"
                MsgBox(arreglo(1), MsgBoxStyle.Information, "Correcto")
                'actualizo tabla
                dgvEscuela.DataSource = servicio.Listar.Tables(0)
            Case "False"
                MsgBox(arreglo(1), MsgBoxStyle.Critical, "Error")
        End Select
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvBuscado.DataSource = servicio.Buscar(txtNombreBuscado.Text, cboCriterio.Text).Tables(0)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim arreglo() As String = servicio.Eliminar(txtCodAct.Text)
        Select Case arreglo(0)
            Case "True"
                MsgBox(arreglo(1), MsgBoxStyle.Information, "Correcto")
                'actualizo tabla
                dgvEscuela.DataSource = servicio.Listar.Tables(0)
            Case "False"
                MsgBox(arreglo(1), MsgBoxStyle.Critical, "Error")
        End Select
    End Sub
End Class
