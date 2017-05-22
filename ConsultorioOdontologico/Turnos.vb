Public Class frm_turnos

    Enum tipo_accion
        normal
        cargando_formulario
    End Enum

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    'Para saber si existe en la BD'
    Enum respuesta_validacion
        _se_superpone
        _no_se_superpone
    End Enum

    'Para saber si hay algun campo con informacion erronea'
    Enum respuesta_validacion_error
        _ok
        _error
    End Enum

    'En la siguiente linea se asigna automaticamente la cadena de conexion segun en que compu este (ayudandose con una clase)
    Dim clase_auxiliar As New Atributos_Compartidos
    Dim cadena_conexion As String = clase_auxiliar._cadena_conexion
    Dim accion As tipo_accion = tipo_accion.normal

    Private Sub frm_turnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clase_auxiliar.cargar_combobox(cmb_empleado, tabla_para_combo("Empleado")) 'la "tabla_para_combo" es solo de este formulario
        clase_auxiliar.cargar_combobox(cmb_paciente, tabla_para_combo("Paciente"))
        cmb_empleado.SelectedIndex = 0
        cmb_paciente.SelectedIndex = 0
        Me.actualizar_datos_grilla()
    End Sub

    Private Function tabla_para_combo(ByVal nombre_tabla As String) As DataTable ' el parametro puede ser "Empleado" o "Paciente"
        'Esta funcion da una tabla con 2 columnas: la primera es el id_paciente o id_empleado, y la segunda el apellido y nombre concatenados

        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        'En el select hace id_empleado o id_paciente, y despues concatena asi: "Apellido, Nombre"
        sql &= "SELECT id_" & nombre_tabla.ToLower() & ", apellido + ', ' + nombre"
        sql &= " FROM " & nombre_tabla
        sql &= " WHERE habilitado = 1"
        sql &= " ORDER BY apellido"
        tabla = clase_auxiliar.ejecuto_sql(sql)

        'Todo lo siguiente es para poder agregarle al principio del combobox el "TODOS"
        Dim tablafinal As New Data.DataTable() 'Define la tabla
        tablafinal.Columns.Add() 'le agrega una columna donde ira el pk (para el TODOS es 0)
        tablafinal.Columns.Add() 'le agrega una columna done ira la descripcion (para el TODOS es TODOS)

        'Aca se crea la fila que dice "TODOS" y se la agrega a la tablafinal
        Dim fila As Data.DataRow
        fila = tablafinal.NewRow()
        fila(0) = 0 'En el campo de la pk (indice 0) hace 0
        fila(1) = "TODOS" 'En el campo del nombre (indice 1) hace "Todos"
        tablafinal.Rows.Add(fila)

        'Agrega todas las filas de la "tabla" (que contiene las filas de los turnos) a la "tablafinal" que empieza con "TODOS"
        For Each unaFila In tabla.Rows
            Dim filaAAgregar As Data.DataRow
            filaAAgregar = tablafinal.NewRow
            filaAAgregar(0) = unaFila(0)
            filaAAgregar(1) = unaFila(1)
            tablafinal.Rows.Add(filaAAgregar)
        Next

        Return tablafinal

    End Function

    'A este lo deje comentado porque no terminaba de funcionar bien
    Private Sub cmb_SelectionChangeCommited(sender As Object, e As EventArgs) Handles cmb_empleado.SelectionChangeCommitted, cmb_paciente.SelectionChangeCommitted, chk_habilitar_interseccion.CheckStateChanged

        'Cuando se elige un paciente o un empleado, se actualizan las filas de la grilla
        If Not accion = tipo_accion.cargando_formulario Then
            Me.actualizar_datos_grilla()
        End If

        If cmb_empleado.SelectedValue <> 0 Then
            Me.actualizar_horarios_empleado()
        Else
            Me.txt_hora_ingreso.Text = ""
            Me.txt_hora_egreso.Text = ""

        End If
    End Sub

    Private Sub actualizar_datos_grilla() 'Lo que pasa cuando se cambian los filtros de la grilla

        If (cmb_empleado.SelectedIndex <> -1) Or (cmb_paciente.SelectedIndex <> -1) Then 'Si se eligio un empleado o un paciente

            Dim tabla As New Data.DataTable
            Dim sql As String = ""

            sql &= " SELECT     T.fecha"
            sql &= "          , T.hora_desde"
            sql &= "          , T.hora_hasta"
            sql &= "          , E.apellido + ', ' + E.nombre As emp"
            sql &= "          , T.id_empleado"
            sql &= "          , P.apellido + ', ' + P.nombre As pac"
            sql &= "          , T.id_paciente"
            sql &= "          , T.observaciones"
            sql &= " FROM     Turno T JOIN Paciente P ON P.id_paciente = T.id_paciente" 'FROM Paciente JOIN Turno JOIN Empleado
            sql &= "                  JOIN Empleado E ON E.id_empleado = T.id_empleado"
            sql &= " WHERE P.habilitado = 1 AND E.habilitado = 1"
            sql &= " AND T.fecha >= '" & DateAndTime.DateString & "'" 'Solo muestra los turnos que son de hoy en adelante
            'sql &= " AND T.hora_desde >= [horaActual]"  <-- No se si ponerlo

            Dim conjuncion_interseccion As String = ""

            If chk_habilitar_interseccion.Checked Then
                conjuncion_interseccion = " AND T.id_paciente = " & Me.cmb_paciente.SelectedValue.ToString()
                conjuncion_interseccion &= " AND T.id_empleado = " & Me.cmb_empleado.SelectedValue.ToString()
            Else
                conjuncion_interseccion = " AND (T.id_paciente = " & Me.cmb_paciente.SelectedValue.ToString()
                conjuncion_interseccion &= " OR T.id_empleado = " & Me.cmb_empleado.SelectedValue.ToString() & ")"
            End If

            If cmb_empleado.SelectedValue <> 0 Or cmb_paciente.SelectedValue <> 0 Then 'si NO dice TODOS en ambos combobox
                If (cmb_empleado.SelectedIndex <> -1 And cmb_empleado.SelectedValue <> 0) And (cmb_paciente.SelectedIndex <> -1 And cmb_paciente.SelectedValue <> 0) Then 'si se eligio un paciente y un empleado
                    sql &= conjuncion_interseccion
                ElseIf cmb_empleado.SelectedIndex <> -1 And cmb_paciente.SelectedValue = 0 Then 'si se eligio un empleado
                    sql &= " AND T.id_empleado = " & Me.cmb_empleado.SelectedValue.ToString() 'El valueMember del cmb es el id_empleado
                ElseIf cmb_paciente.SelectedIndex <> -1 And cmb_empleado.SelectedValue = 0 Then 'si se eligio un paciente
                    sql &= " AND T.id_paciente = " & Me.cmb_paciente.SelectedValue.ToString() 'El valueMember del cmb es el id_paciente
                End If

                If cmb_empleado.SelectedValue <> 0 And cmb_paciente.SelectedValue <> 0 Then
                    chk_habilitar_interseccion.Enabled = True
                Else
                    chk_habilitar_interseccion.Enabled = False
                End If
            Else
                chk_habilitar_interseccion.Enabled = False
            End If

            sql &= " ORDER BY fecha, hora_desde"
            tabla = clase_auxiliar.ejecuto_sql(sql)
            llenar_grilla(tabla)

        Else
            grid_turnos.Rows.Clear() 'si no se eligio ni un empleado ni un paciente entonces se vacia la grilla
        End If

    End Sub


    Private Sub llenar_grilla(ByVal tabla As DataTable)
        Dim c As Integer

        Me.grid_turnos.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            grid_turnos.Rows.Add()              'convierte el valor de la tabla de la BD a tipo FechaHora para usarlo en grilla
            grid_turnos.Rows(c).Cells(0).Value = Convert.ToDateTime(tabla.Rows(c)("fecha")).ToString("yyyy/MM/dd")
            grid_turnos.Rows(c).Cells(1).Value = Convert.ToDateTime(tabla.Rows(c)("hora_desde")).ToString("HH:mm")
            grid_turnos.Rows(c).Cells(2).Value = Convert.ToDateTime(tabla.Rows(c)("hora_hasta")).ToString("HH:mm")
            grid_turnos.Rows(c).Cells(3).Value = tabla.Rows(c)("emp")
            grid_turnos.Rows(c).Cells(4).Value = tabla.Rows(c)("id_empleado")
            grid_turnos.Rows(c).Cells(5).Value = tabla.Rows(c)("pac")
            grid_turnos.Rows(c).Cells(6).Value = tabla.Rows(c)("id_paciente")
            grid_turnos.Rows(c).Cells(7).Value = tabla.Rows(c)("observaciones")
        Next

    End Sub

    Private Sub actualizar_horarios_empleado()

        Dim tabla As New Data.DataTable
        Dim sql As String = "SELECT hora_ingreso, hora_egreso FROM Empleado WHERE id_empleado = " & cmb_empleado.SelectedValue.ToString
        tabla = clase_auxiliar.ejecuto_sql(sql)

        If tabla.Rows.Count > 0 Then
            txt_hora_ingreso.Text = tabla.Rows(0)("hora_ingreso")
            txt_hora_egreso.Text = tabla.Rows(0)("hora_egreso")
        End If

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub frm_turnos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'La siguiente linea usa el metodo "confirmar_salida" de la clase "Atributos_Compartidos" para
        'ver si el usuario cancelo el cerrado del formulario. (Le manda el evento de cerrado "e" al metodo)
        e.Cancel = clase_auxiliar.confirmar_salida(e)
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        clase_auxiliar.blanquear_campos(Me)
        cmb_paciente.SelectedIndex = 0
        cmb_empleado.SelectedIndex = 0
    End Sub

    Private Sub grid_turnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_turnos.CellClick
        Me.cargar_formulario()
    End Sub

    Private Sub grid_turnos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grid_turnos.RowHeaderMouseClick
        Me.cargar_formulario()
    End Sub

    Private Sub cargar_formulario()
        'clase_auxiliar.blanquear_campos(Me)
        Me.accion = tipo_accion.cargando_formulario
        cmb_empleado.SelectedValue = grid_turnos.CurrentRow.Cells("id_empleado").Value
        cmb_paciente.SelectedValue = grid_turnos.CurrentRow.Cells("id_paciente").Value
        dtp_fecha_turno.Value = DateTime.Parse(grid_turnos.CurrentRow.Cells("fecha_turno").Value)
        dtp_hora_desde.Value = DateTime.Parse(grid_turnos.CurrentRow.Cells("hora_desde").Value)
        dtp_hora_hasta.Value = DateTime.Parse(grid_turnos.CurrentRow.Cells("hora_hasta").Value)
        Me.txt_observaciones.Text = grid_turnos.CurrentRow.Cells("observaciones").Value
        Me.cmd_buscar.Enabled = True
        Me.accion = tipo_accion.normal

        Me.actualizar_horarios_empleado
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Me.actualizar_datos_grilla()
        Me.actualizar_horarios_empleado()
    End Sub

    Private Function validar_datos() As respuesta_validacion_error
        Dim message_str As String = "Se encuentran los siguientes errores:"
        Dim libre_de_error As Boolean = True
        'vbCrLf es basicamente un enter, un salto a la linea siguiente

        If cmb_paciente.SelectedIndex = -1 Or cmb_paciente.SelectedValue = 0 Then
            libre_de_error = False
            message_str &= vbCrLf & "Debe seleccionar un paciente."
        End If

        If cmb_empleado.SelectedIndex = -1 Or cmb_empleado.SelectedValue = 0 Then
            libre_de_error = False
            message_str &= vbCrLf & "Debe seleccionar un empleado."
        Else
            Dim sql_empleado As String = "SELECT * FROM Empleado WHERE id_empleado = " & cmb_empleado.SelectedValue
            Dim datos_empleado As DataTable = clase_auxiliar.ejecuto_sql(sql_empleado)
            Dim hora_ingreso As DateTime = DateTime.Parse(datos_empleado.Rows(0)("hora_ingreso"))
            Dim hora_egreso As DateTime = DateTime.Parse(datos_empleado.Rows(0)("hora_egreso"))
            'MessageBox.Show("hora_ingreso: " & hora_ingreso.ToString _
            '                & "hora_egreso: " & hora_egreso.ToString _
            '                & "hora_turno: " & dtp_hora_desde.Value.ToString _
            '                & "hora_hasta turno: " & dtp_hora_hasta.Value.ToString)


            If dtp_hora_desde.Value < hora_ingreso Or dtp_hora_hasta.Value > hora_egreso Then
                libre_de_error = False
                message_str &= vbCrLf & "El turno debe ser dentro del horario del empleado."
            End If
        End If

        If dtp_fecha_turno.Value < DateTime.Today Then
            libre_de_error = False
            message_str &= vbCrLf & "La fecha seleccionada debe ser de hoy en adelante."
        ElseIf dtp_fecha_turno.Value = DateTime.Today And dtp_hora_desde.Value < DateTime.Now Then
            libre_de_error = False
            message_str &= vbCrLf & "La hora seleccionada debe ser posterior a la hora actual."
        End If

        If dtp_hora_desde.Value >= dtp_hora_hasta.Value Then
            libre_de_error = False
            message_str &= vbCrLf & "La hora de fin debe ser mayor que la hora de inicio."
        End If

        If libre_de_error = True Then
            Return respuesta_validacion_error._ok
        Else
            MessageBox.Show(message_str, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return respuesta_validacion_error._error
        End If

    End Function

    Private Function existe_turno() As Boolean
        For Each fila In grid_turnos.Rows 'Con el for, se revisan todos los turnos asignado hasta ahora
            If fila.Cells("id_paciente").Value = cmb_paciente.SelectedValue _
                And DateTime.Parse(fila.Cells("fecha_turno").Value) = dtp_fecha_turno.Value _
                And DateTime.Parse(fila.Cells("hora_desde").Value) = dtp_hora_desde.Value _
                Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function hay_superposicion() As respuesta_validacion
        'Esta funcion verifica que el nuevo turno a asignar no se superponga con algun turno ya asignado
        'Para hacer esa verificacion se usan los datos de la grilla
        'Tener en cuenta que para cuando se usa este metodo, en la grilla solo hay turnos con al menos el paciente o el empleado elegido
        For Each fila In grid_turnos.Rows 'Con el for, se revisan todos los turnos asignado hasta ahora
            If DateTime.Parse(fila.Cells("fecha_turno").Value) = dtp_fecha_turno.Value Then 'si la fecha del turno viejo y nuevo coinciden
                Dim hora_desde_vieja As DateTime = DateTime.Parse(fila.Cells("hora_desde").Value) 'hora_desde de un turno ya asignado
                Dim hora_hasta_vieja As DateTime = DateTime.Parse(fila.Cells("hora_hasta").Value) 'hora_hasta de un turno ya asignado
                Dim hora_desde_nueva As DateTime = dtp_hora_desde.Value 'hora_desde del nuevo turno a asignar
                Dim hora_hasta_nueva As DateTime = dtp_hora_hasta.Value 'hora_hasta del nuevo turno a asignar
                'El analisis que se hace para determinar si el nuevo turno se superpone con el turno viejo es el siguiente:
                'Para que no se superpongan los turnos se debe cumplir 1 de 2 condiciones:
                '   -que el turno nuevo termine antes de que empiece el viejo; 
                '   ó
                '   -que el turno nuevo empiece luego de que termine el viejo
                'Si no se cumplen ninguna de las 2 condiciones, entonces los turnos se superponen
                If Not (hora_hasta_nueva < hora_desde_vieja Or hora_desde_nueva > hora_hasta_vieja) Then
                    Return respuesta_validacion._se_superpone
                End If
            End If
        Next
        'Si la funcion llega hasta aca es porque no encontro ningun turno con el que se superponga
        Return respuesta_validacion._no_se_superpone
    End Function

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If validar_datos() = respuesta_validacion_error._ok Then
            If hay_superposicion() = respuesta_validacion._no_se_superpone Then
                insertar()
                actualizar_datos_grilla()
                MessageBox.Show("Se ha registrado el turno correctamente")
            ElseIf hay_superposicion() = respuesta_validacion._se_superpone Then
                MessageBox.Show("El turno se superpone con un turno ya existente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub insertar()
        Dim txt_insert As String = ""

        txt_insert &= "INSERT INTO Turno ("
        txt_insert &= " id_paciente"
        txt_insert &= ", fecha"
        txt_insert &= ", hora_desde"
        txt_insert &= ", id_empleado"
        txt_insert &= ", hora_hasta"
        txt_insert &= ", observaciones)"
        txt_insert &= " VALUES ("
        txt_insert &= cmb_paciente.SelectedValue
        txt_insert &= ", '" & Format(Me.dtp_fecha_turno.Value, "yyyy-MM-dd") & "'"
        txt_insert &= ", '" & Format(Me.dtp_hora_desde.Value, "HH:mm") & "'"
        txt_insert &= ", " & cmb_empleado.SelectedValue
        txt_insert &= ", '" & Format(Me.dtp_hora_hasta.Value, "HH:mm") & "'"
        txt_insert &= ", '" & txt_observaciones.Text & "')"

        clase_auxiliar.insertar_modificar_eliminar(txt_insert)
    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        If existe_turno() Then
            Dim res As Integer = MessageBox.Show("                        Esta seguro?", "Confirmacion", MessageBoxButtons.OKCancel)
            If res = DialogResult.OK Then

                Dim txt_delete As String = ""

                txt_delete &= "DELETE FROM Turno"
                txt_delete &= " WHERE id_paciente = " & cmb_paciente.SelectedValue
                txt_delete &= " AND fecha = '" & Format(dtp_fecha_turno.Value, "yyyy-MM-dd") & "'"
                txt_delete &= " AND hora_desde = '" & Format(dtp_hora_desde.Value, "HH:mm") & "'"

                clase_auxiliar.insertar_modificar_eliminar(txt_delete)

                Me.actualizar_datos_grilla()
                MessageBox.Show("Se ha eliminado el turno correctamente" _
                            , "Informacion" _
                            , MessageBoxButtons.OK _
                            , MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No se encuentra el turno que borrar")
        End If
    End Sub

End Class