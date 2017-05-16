Public Class frm_turnos
    'En la siguiente linea se asigna automaticamente la cadena de conexion segun en que compu este (ayudandose con una clase)
    Dim clase_auxiliar As New Atributos_Compartidos
    Dim cadena_conexion As String = clase_auxiliar._cadena_conexion

    Private Sub frm_turnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clase_auxiliar.cargar_combobox(cmb_empleado, tabla_para_combo("Empleado")) 'la "tabla_para_combo" es solo de este formulario
        clase_auxiliar.cargar_combobox(cmb_paciente, tabla_para_combo("Paciente"))
        clase_auxiliar.blanquear_campos(Me) 'Esto es para que los combobox empiecen en blanco

    End Sub

    Private Function tabla_para_combo(ByVal nombre_tabla As String) As DataTable ' el parametro puede ser "Empleado" o "Paciente"
        'Da una tabla con 2 columnas: la primera es el id_paciente o id_empleado, y la segunda el apellido y nombre concatenados
        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        'En el select hace id_empleado o id_paciente, y despues concatena asi: "Apellido, Nombre"
        sql &= "SELECT id_" & nombre_tabla.ToLower() & ", apellido + ', ' + nombre"
        sql &= " FROM " & nombre_tabla
        sql &= " WHERE habilitado = 1"
        sql &= " ORDER BY apellido"
        Return clase_auxiliar.ejecuto_sql(sql)
    End Function

    Private Sub frm_turnos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'La siguiente linea usa el metodo "confirmar_salida" de la clase "Atributos_Compartidos" para
        'ver si el usuario cancelo el cerrado del formulario. (Le manda el evento de cerrado "e" al metodo)
        e.Cancel = clase_auxiliar.confirmar_salida(e)
    End Sub

    Private Sub cmb_SelectionChangeCommited(sender As Object, e As EventArgs) Handles cmb_empleado.SelectionChangeCommitted, cmb_paciente.SelectionChangeCommitted
        'Cuando se elige un paciente o un empleado, se actualizan las filas de la grilla

        If (cmb_empleado.SelectedIndex <> -1) Or (cmb_paciente.SelectedIndex <> -1) Then 'Si se eligio un empleado o un paciente

            Dim tabla As New Data.DataTable
            Dim sql As String = ""

            sql &= " SELECT     T.fecha"
            sql &= "          , T.hora_desde"
            sql &= "          , T.hora_hasta"
            sql &= "          , E.apellido + ', ' + E.nombre As emp"
            sql &= "          , P.apellido + ', ' + P.nombre As pac"
            sql &= " FROM     Turno T JOIN Paciente P ON P.id_paciente = T.id_paciente" 'FROM Paciente JOIN Turno JOIN Empleado
            sql &= "                  JOIN Empleado E ON E.id_empleado = T.id_empleado"
            sql &= " WHERE P.habilitado = 1 AND E.habilitado = 1" ' AND T.fecha > [fechaActual] AND T.hora_desde >= [horaActual]  <--VER COMO HACER ESTO

            If cmb_empleado.SelectedIndex <> -1 Then 'si se eligio un empleado
                sql &= " AND T.id_empleado = " & Me.cmb_empleado.SelectedValue.ToString() 'El valueMember del cmb es el id_empleado
            End If

            If cmb_paciente.SelectedIndex <> -1 Then 'si se eligio un paciente
                sql &= " AND T.id_paciente = " & Me.cmb_paciente.SelectedValue.ToString() 'El valueMember del cmb es el id_paciente
            End If

            'sql &= " ORDER BY fecha, hora_desde"
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

        Next
    End Sub

End Class