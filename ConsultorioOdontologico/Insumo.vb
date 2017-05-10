Public Class frm_registrar_insumo
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=BGH\MORILLASSQL;User ID=Morillas;Initial Catalog=ConsultorioOdontologicoBD;password=Morillas"


    'Para saber si existe en la BD'
    Enum respuesta_validacion
        _existe
        _no_existe
    End Enum

    'Para saber si hay algun campo con informacion erronea'
    Enum respuesta_validacion_error
        _ok
        _error
    End Enum


    Private Function ejecuto_sql(ByVal sql As String) As DataTable
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function

    Private Function leo_tabla(ByVal nombre_tabla As String) As DataTable
        Return ejecuto_sql("SELECT * FROM " & nombre_tabla & " WHERE habilitado = 1 ORDER BY descripcion ASC")
    End Function

    Private Sub cargar_lista()
        llenar_lista(leo_tabla("Insumo"))
    End Sub

    Private Sub frm_registrar_insumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_lista()
        lst_insumos.SelectedIndex = -1
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub insertar()
        Dim txt_insert As String = ""

        txt_insert &= "INSERT INTO Insumo ("
        txt_insert &= "descripcion)"
        txt_insert &= " VALUES ("
        txt_insert &= "'" & txt_descripcion.Text & "')"

        insertar_modificar_eliminar(txt_insert)
    End Sub

    Private Sub eliminar(ByVal id As Integer)
        Dim txt_delete As String = ""

        txt_delete &= "UPDATE Insumo"
        txt_delete &= "SET habilitado = 0"
        txt_delete &= " WHERE id_insumo = " & id

        insertar_modificar_eliminar(txt_delete)
    End Sub

    Private Sub insertar_modificar_eliminar(ByVal sql As String)
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub


    Private Function validar_datos() As respuesta_validacion_error
        If txt_descripcion.Text = "" Then
            MessageBox.Show("El campo descripcion esta vacio" & vbCrLf & "Debe proveer de una descripcion para el insumo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_descripcion.Focus()
            Return respuesta_validacion_error._error
        End If
        Return respuesta_validacion_error._ok
    End Function

    Private Function validar_insumos(ByVal descripcion) As respuesta_validacion
        Dim sql As String = ""
        sql &= "SELECT * "
        sql &= " FROM Insumo"
        sql &= " WHERE descripcion  = '" & descripcion & "'"

        Dim tabla As New DataTable

        tabla = Me.ejecuto_sql(sql)

        If tabla.Rows.Count = 0 Then
            Return respuesta_validacion._no_existe
        Else
            Return respuesta_validacion._existe
        End If
    End Function

    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click
        If validar_datos() = respuesta_validacion_error._ok Then
            If validar_insumos(Me.txt_descripcion.Text) = respuesta_validacion._no_existe Then
                insertar()
                MessageBox.Show("Se ha registrado el insumo correctamente")
            Else
                MessageBox.Show("Se ha detectado un insumo con la misma descipcion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.cargar_lista()
            txt_descripcion.Text = ""
        End If
    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        If lst_insumos.SelectedIndex = -1 Then

            MessageBox.Show("Debe seleccionar un insumo de la lista" _
                        , "ERROR" _
                        , MessageBoxButtons.OK _
                        , MessageBoxIcon.Error)

            Exit Sub
        End If

        Dim res As Integer = MessageBox.Show("                        Esta seguro?", "Confirmacion", MessageBoxButtons.OKCancel)
        If res = DialogResult.OK Then
            eliminar(lst_insumos.SelectedValue)
            cargar_lista()
            MessageBox.Show("Se ha eliminado el insumo correctamente" _
                            , "Informacion" _
                            , MessageBoxButtons.OK _
                            , MessageBoxIcon.Information)
            lst_insumos.SelectedIndex = -1
        End If
    End Sub

    Private Sub txt_filtro_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro.TextChanged
        Dim pattern As String = txt_filtro.Text
        Dim sql As String = ""

        Dim tabla As New Data.DataTable
        sql &= "SELECT *"
        sql &= " FROM Insumo"
        sql &= " WHERE habilitado = 1 AND descripcion LIKE '" & pattern & "%'"
        llenar_lista(ejecuto_sql(sql))
    End Sub

    Private Sub llenar_lista(ByVal tabla As DataTable)
        lst_insumos.DataSource = tabla
        lst_insumos.DisplayMember = "descripcion"
        lst_insumos.ValueMember = "id_insumo"
    End Sub

    Private Sub frm_registrar_tratamiento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Esta seguro que desea salir", "Importante", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

End Class