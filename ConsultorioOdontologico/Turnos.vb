Public Class frm_turnos
    'En la siguiente linea se asigna automaticamente la cadena de conexion segun en que compu este (ayudandose con una clase)
    Dim clase_auxiliar As New Atributos_Compartidos
    Dim cadena_conexion As String = clase_auxiliar._cadena_conexion

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
        fila = tablaFinal.NewRow()
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

    Private Sub frm_turnos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'La siguiente linea usa el metodo "confirmar_salida" de la clase "Atributos_Compartidos" para
        'ver si el usuario cancelo el cerrado del formulario. (Le manda el evento de cerrado "e" al metodo)
        e.Cancel = clase_auxiliar.confirmar_salida(e)
    End Sub

    Private Sub cmb_SelectionChangeCommited(sender As Object, e As EventArgs) Handles cmb_empleado.SelectionChangeCommitted, cmb_paciente.SelectionChangeCommitted, chk_habilitar_interseccion.CheckStateChanged
        'Cuando se elige un paciente o un empleado, se actualizan las filas de la grilla
        Me.actualizar_datos_grilla()
    End Sub

    Private Sub actualizar_datos_grilla() 'Lo que pasa cuando se cambian los filtros de la grilla

        If (cmb_empleado.SelectedIndex <> -1) Or (cmb_paciente.SelectedIndex <> -1) Then 'Si se eligio un empleado o un paciente

            Dim tabla As New Data.DataTable
            Dim sql As String = ""

            sql &= " SELECT     T.fecha"
            sql &= "          , T.hora_desde"
            sql &= "          , T.hora_hasta"
            sql &= "          , E.apellido + ', ' + E.nombre As emp"
            sql &= "          , P.apellido + ', ' + P.nombre As pac"
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
            grid_turnos.Rows(c).Cells(0).Value = Convert.ToDateTime(tabla.Rows(c)("fecha")).ToString("dd/MM/yyyy")
            grid_turnos.Rows(c).Cells(1).Value = Convert.ToDateTime(tabla.Rows(c)("hora_desde")).ToString("hh:mm")
            grid_turnos.Rows(c).Cells(2).Value = Convert.ToDateTime(tabla.Rows(c)("hora_hasta")).ToString("hh:mm")
            grid_turnos.Rows(c).Cells(3).Value = tabla.Rows(c)("emp")
            grid_turnos.Rows(c).Cells(4).Value = tabla.Rows(c)("pac")
            grid_turnos.Rows(c).Cells(5).Value = tabla.Rows(c)("observaciones")

        Next
    End Sub

End Class