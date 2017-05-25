Public Class frm_intervenciones
    Dim clase_auxiliar As New Atributos_Compartidos
    Dim id_empleado As Integer 'se le asigna el valor cuando se realiza la busqueda del turno
    Dim id_paciente As Integer
    Dim tabla_tratamientos As New DataTable
    Dim monto_total As Double


    Private Sub frm_intervenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clase_auxiliar.cargar_combobox(cmb_insumos, "Insumo")
        clase_auxiliar.cargar_combobox(cmb_tratamientos, tabla_para_combo_tratamiento())
        clase_auxiliar.cargar_combobox(cmb_paciente, tabla_para_combo_paciente())
        cmb_paciente.SelectedIndex = -1

        cmb_tratamientos.SelectedIndex = -1
        cmb_insumos.SelectedIndex = -1

        tabla_tratamientos = Me.clase_auxiliar.leo_tabla("tratamiento")
    End Sub

    Private Function tabla_para_combo_tratamiento() As Data.DataTable
        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        sql &= "SELECT id_tratamiento, descripcion FROM Tratamiento WHERE habilitado=1"

        tabla = clase_auxiliar.ejecuto_sql(sql)

        Return tabla
    End Function

    Private Function tabla_para_combo_paciente() As DataTable ' el parametro puede ser "Empleado" o "Paciente"
        'Esta funcion da una tabla con 2 columnas: la primera es el id_paciente o id_empleado, y la segunda el apellido y nombre concatenados

        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        'En el select hace id_empleado o id_paciente, y despues concatena asi: "Apellido, Nombre"
        sql &= "SELECT T.id_paciente, P.apellido + ', ' + P.nombre"
        sql &= " FROM Paciente P JOIN Turno T ON P.id_paciente = T.id_paciente"
        sql &= " WHERE P.habilitado = 1 AND T.fecha = '" & DateTime.Today.ToString("yyyy-MM-dd") & "'"
        sql &= " ORDER BY P.apellido"
        tabla = clase_auxiliar.ejecuto_sql(sql)


        Return tabla

    End Function

    Private Sub cmd_buscar_turno_Click(sender As Object, e As EventArgs) Handles cmd_buscar_turno.Click

        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        sql &= "SELECT T.* , E.apellido + ', ' + E.nombre As emp"
        sql &= " FROM Turno T  JOIN Empleado E ON T.id_empleado=E.id_Empleado"
        sql &= " WHERE  T.fecha = '" & DateTime.Today.ToString("yyyy-MM-dd") & "'"
        sql &= "AND T.id_paciente=" & cmb_paciente.SelectedValue
        tabla = clase_auxiliar.ejecuto_sql(sql)

        txt_empleado.Text = tabla.Rows(0)("emp")
        txt_fecha.Text = tabla.Rows(0)("fecha")
        txt_hora_desde.Text = tabla.Rows(0)("hora_desde")
        txt_hora_hasta.Text = tabla.Rows(0)("hora_hasta")
        txt__observaciones_turno.Text = tabla.Rows(0)("observaciones")

        id_empleado = tabla.Rows(0)("id_empleado")
        id_paciente = cmb_paciente.SelectedValue

        habilitar_controles()

    End Sub

    Private Sub cmb_paciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_paciente.SelectedIndexChanged

    End Sub

    Private Sub txt_hora_hasta_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_hora_hasta.MaskInputRejected

    End Sub

    Private Sub habilitar_controles()

        cmb_tratamientos.Enabled = True
        txt_nro_tratamiento.Enabled = True
        cmd_agregar_tratamiento.Enabled = True
        cmd_remover_tratamiento.Enabled = True


        cmb_insumos.Enabled = True
        nud_cantidad_insumo.Enabled = True
        txt_nro_insumo.Enabled = True
        cmd_agregar_insumo.Enabled = True
        cmd_remover_insumo.Enabled = True
        txt__observaciones_intervencion.Enabled = True
    End Sub

    Private Sub cmd_agregar_insumo_Click(sender As Object, e As EventArgs) Handles cmd_agregar_insumo.Click
        If cmb_insumos.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un insumo a agregar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim fila_de_insumo As Integer = insumo_ya_esta_agregado()
            If fila_de_insumo <> -1 Then 'Si fila_de_insumo es -1 es porque no habia sido agregado
                Dim res As Integer = MessageBox.Show("El insumo ya estaba agregado. ¿Desea reemplazar la cantidad?", _
                                                     "Confirmacion", MessageBoxButtons.OKCancel)
                If res = DialogResult.OK Then
                    Me.grid_insumos.Rows(fila_de_insumo).Cells("cantidad").Value = nud_cantidad_insumo.Value
                End If
            Else
                Me.grid_insumos.Rows.Add(Me.grid_insumos.Rows.Count + 1, Me.cmb_insumos.Text, nud_cantidad_insumo.Value, Me.cmb_insumos.SelectedIndex)
            End If
            nud_cantidad_insumo.Value = 1
            cmb_insumos.SelectedIndex = -1
        End If
    End Sub

    Private Function insumo_ya_esta_agregado() As Integer
        For fila As Integer = 0 To grid_insumos.Rows.Count - 1 'Con el for, se revisan todos los insumos previamente agregados a la grilla
            If grid_insumos.Rows(fila).Cells("id_insumo").Value = cmb_insumos.SelectedIndex Then
                Return fila
            End If
        Next
        Return -1 'si no encontro el insumo en ninguna fila
    End Function

    Private Function tratamiento_ya_esta_agregado() As Integer
        For fila As Integer = 0 To grid_tratamientos.Rows.Count - 1 'Con el for, se revisan todos los tratamientos previamente agregados a la grilla
            If grid_tratamientos.Rows(fila).Cells("id_tratamiento").Value = cmb_tratamientos.SelectedIndex Then
                Return fila
            End If
        Next
        Return -1 'si no encontro el tratamiento en ninguna fila
    End Function

    Private Sub cmd_remover_insumo_Click(sender As Object, e As EventArgs) Handles cmd_remover_insumo.Click
        If txt_nro_insumo.Text = "" Then
            MessageBox.Show("El campo txt_nro_insumo esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Me.reasignar_nro_filas(Me.txt_nro_insumo.Text, Me.grid_insumos)

            txt_nro_insumo.Text = ""
            cmb_insumos.SelectedIndex = -1
        End If

    End Sub

    Private Sub grid_insumos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_insumos.CellClick
        llenar_insumos()
    End Sub

    Private Sub grid_insumos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grid_insumos.RowHeaderMouseClick
        llenar_insumos()
    End Sub

    Private Sub llenar_insumos()
        Me.cmb_insumos.SelectedIndex = grid_insumos.Rows(grid_insumos.CurrentRow.Index).Cells("id_insumo").Value
        Me.txt_nro_insumo.Text = grid_insumos.Rows(grid_insumos.CurrentRow.Index).Cells(0).Value
        Me.nud_cantidad_insumo.Value = grid_insumos.Rows(grid_insumos.CurrentRow.Index).Cells(2).Value
    End Sub


    Private Sub llenar_tratamiento()
        Me.cmb_tratamientos.SelectedIndex = grid_tratamientos.Rows(grid_tratamientos.CurrentRow.Index).Cells("id_tratamiento").Value
        Me.txt_nro_tratamiento.Text = grid_tratamientos.Rows(grid_tratamientos.CurrentRow.Index).Cells(0).Value

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub frm_intervenciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'La siguiente linea usa el metodo "confirmar_salida" de la clase "Atributos_Compartidos" para
        'ver si el usuario cancelo el cerrado del formulario. (Le manda el evento de cerrado "e" al metodo)
        e.Cancel = clase_auxiliar.confirmar_salida(e)
    End Sub

    Private Sub cmd_agregar_tratamiento_Click(sender As Object, e As EventArgs) Handles cmd_agregar_tratamiento.Click
        If cmb_tratamientos.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un tratamiento a agregar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        ElseIf tratamiento_ya_esta_agregado Then
        Else
            Dim fila_de_tratamiento As Integer = tratamiento_ya_esta_agregado()
            If fila_de_tratamiento <> -1 Then 'Si fila_de_tratamiento es -1 es porque no habia sido agregado
                Dim res As Integer = MessageBox.Show("El tratamiento ya estaba agregado")
            Else
                Me.grid_tratamientos.Rows.Add(Me.grid_tratamientos.Rows.Count + 1, Me.cmb_tratamientos.Text, Me.cmb_tratamientos.SelectedIndex)
                Me.actualizar_monto_total()
            End If
            cmb_tratamientos.SelectedIndex = -1

        End If
    End Sub
    Private Sub reasignar_nro_filas(ByVal txt_nro_fila As String, ByRef grilla As DataGridView)
        Dim nro_fila As Integer = Convert.ToInt32(txt_nro_fila) - 1
        grilla.Rows.RemoveAt(nro_fila)
        'lo siguiente reasigna los nros de las filas siguientes a las que se borro
        For c As Integer = nro_fila To grilla.Rows.Count - 1
            grilla.Rows(c).Cells("num").Value = c + 1
        Next

    End Sub

    Private Sub cmd_remover_tratamiento_Click(sender As Object, e As EventArgs) Handles cmd_remover_tratamiento.Click
        If txt_nro_tratamiento.Text = "" Then
            MessageBox.Show("El campo txt_nro_tratamiento esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.reasignar_nro_filas(Me.txt_nro_tratamiento.Text, Me.grid_tratamientos)
            txt_nro_tratamiento.Text = ""
            cmb_tratamientos.SelectedIndex = -1
            Me.actualizar_monto_total()
        End If


    End Sub

    Private Sub grid_tratamientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_tratamientos.CellClick
        Me.llenar_tratamiento()

    End Sub

    Private Sub grid_tratamientos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grid_tratamientos.RowHeaderMouseClick
        Me.llenar_tratamiento()

    End Sub

    Private Sub actualizar_monto_total()
        monto_total = 0
        If tabla_tratamientos.Rows.Count <> 0 Then
            Dim id_tratamiento_local As Integer
            Dim costo_como_string As String
            Dim costo_con_comas As String
            Dim costo As Double
            For Each fila_grilla In grid_tratamientos.Rows()
                id_tratamiento_local = fila_grilla.Cells("id_tratamiento").Value
                costo_como_string = tabla_tratamientos.Rows(id_tratamiento_local)("costo")
                costo_con_comas = costo_como_string.Replace(".", ",")
                costo = Convert.ToDouble(costo_con_comas)
                monto_total = monto_total + costo
            Next
        End If
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If grid_insumos.Rows().Count = 0 Or grid_tratamientos.Rows().Count = 0 Then
            MessageBox.Show("Debe haber por lo menos 1 tratamiento y 1 insumo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'INICIAR CONEXION DE TRANSACCION
            Me.clase_auxiliar.iniciar_conexion_con_transaccion()
            'GUARDAR LOS DATOS DE LA INTERVENCION
            Dim sql_intervencion As String = ""
            sql_intervencion &= "INSERT INTO Intervencion (fecha, hora, id_paciente, id_empleado, monto_total, observaciones)"
            sql_intervencion &= " VALUES ("
            sql_intervencion &= " '" & DateTime.Today.ToString("yyyy-MM-dd") & "'"
            sql_intervencion &= ", '" & DateTime.Now.ToString("HH:mm") & "'"
            sql_intervencion &= ", " & id_paciente.ToString
            sql_intervencion &= ", " & id_empleado.ToString
            sql_intervencion &= ", " & monto_total.ToString 'se hace un update despues de guardar los tratamientosxinterv
            If Me.txt__observaciones_intervencion.Text <> "" Then
                sql_intervencion &= ", '" & Me.txt__observaciones_intervencion.Text & "'"
            Else
                sql_intervencion &= ", ''"
            End If
            sql_intervencion &= " )"

            Me.clase_auxiliar.insertar_modificar_eliminar(sql_intervencion)

            '(Para hacer lo que sigue, primero buscamos el id de la intervencion recien creada)
            Dim id_intervencion As Integer = Me.clase_auxiliar.ejecuto_sql("SELECT TOP 1 id_intervencion FROM intervencion ORDER BY id_intervencion DESC").Rows(0)("id_intervencion")

            'GUARDAR LOS DATOS DE LOS TRATAMIENTOSXINTERVENCION
            Dim sql_tratamXinterv As String
            For Each fila In Me.grid_tratamientos.Rows()
                sql_tratamXinterv = ""
                sql_tratamXinterv &= "INSERT INTO TratamientoXIntervencion (id_intervencion, id_tratamiento) VALUES ("
                sql_tratamXinterv &= " " & id_intervencion.ToString
                sql_tratamXinterv &= ", " & fila.Cells("id_tratamiento").Value.ToString
                sql_tratamXinterv &= ")"

                Me.clase_auxiliar.insertar_modificar_eliminar(sql_tratamXinterv)
            Next

            'GUARDAR LOS DATOS DE LOS INSUMOSXINTERVENCION
            Dim sql_insumoXinterv As String
            For Each fila In Me.grid_insumos.Rows()
                sql_insumoXinterv = ""
                sql_insumoXinterv &= "INSERT INTO InsumoXIntervencion (id_intervencion, id_insumo, cantidad_insumos) VALUES ("
                sql_insumoXinterv &= " " & id_intervencion.ToString
                sql_insumoXinterv &= ", " & fila.Cells("id_insumo").Value.ToString
                sql_insumoXinterv &= ", " & fila.Cells("cantidad").Value.ToString
                sql_insumoXinterv &= ")"

                Me.clase_auxiliar.insertar_modificar_eliminar(sql_insumoXinterv)
            Next

            'CERRAR CONEXION DE TRANSACCION
            Me.clase_auxiliar.cerrar_conexion_con_transaccion()
            MessageBox.Show("EXITO", "ERROR", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Question)

        End If
    End Sub
End Class