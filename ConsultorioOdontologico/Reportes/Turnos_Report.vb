Public Class frm_turnos_report
    Dim clase_auxiliar As New Atributos_Compartidos
    Dim filtros_aplicados() As String = {" ", " ", " ", " "}

    Private Sub Turnos_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clase_auxiliar.cargar_combobox(cmb_empleado, tabla_para_combo("Empleado")) 'la "tabla_para_combo" es solo de este formulario
        clase_auxiliar.cargar_combobox(cmb_paciente, tabla_para_combo("Paciente"))
        dtp_hasta.Value = DateAndTime.Today
        Dim sql As String = ""
        sql &= "SELECT "
        sql &= " Turno.fecha, "
        sql &= " Turno.hora_desde,"
        sql &= " Turno.hora_hasta,"
        sql &= " Paciente.apellido + ', ' + Paciente.nombre AS pac,"
        sql &= " Empleado.apellido + ', ' + Empleado.nombre AS emp"
        sql &= " FROM Empleado INNER JOIN Turno ON Empleado.id_empleado = Turno.id_empleado"
        sql &= " INNER JOIN Paciente ON Turno.id_paciente = Paciente.id_paciente"
        sql &= " WHERE Empleado.habilitado = 1 AND Paciente.habilitado = 1"
        Me.listar_turnos(sql)
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

    Private Sub listar_turnos(ByVal sql As String)
        sql &= " ORDER BY Turno.fecha ASC, Turno.hora_desde ASC"
        Dim value_param As String = "Filtrado por: "
        Dim tiene_filtro As Boolean = False

        For Each value As String In filtros_aplicados
            If value <> " " Then
                tiene_filtro = True
                value_param &= value
            End If
        Next

        If tiene_filtro = False Then
            value_param = " "
        End If
        Dim param As Microsoft.Reporting.WinForms.ReportParameter = New Microsoft.Reporting.WinForms.ReportParameter("TipoReporte", value_param) 'agregar los filtros aplicados al string
        rv_turnos.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        rv_turnos.LocalReport.ReportPath = "Reportes\Report\Turnos_Report.rdlc"
        rv_turnos.LocalReport.SetParameters(param)
        Me.TurnosBindingSource.DataSource = clase_auxiliar.ejecuto_sql(sql)
        Me.rv_turnos.RefreshReport()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim sql As String = ""


        sql &= "SELECT "
        sql &= " Turno.fecha, "
        sql &= " Turno.hora_desde,"
        sql &= " Turno.hora_hasta,"
        sql &= " Paciente.apellido + ', ' + Paciente.nombre AS pac,"
        sql &= " Empleado.apellido + ', ' + Empleado.nombre AS emp"
        sql &= " FROM Empleado INNER JOIN Turno ON Empleado.id_empleado = Turno.id_empleado"
        sql &= " INNER JOIN Paciente ON Turno.id_paciente = Paciente.id_paciente"
        sql &= " WHERE Empleado.habilitado = 1 AND Paciente.habilitado = 1 "

        If rb_sexo_todos.Enabled = True Then 'si esto esta deshabilitado es porque se eligio un paciente
            For Each radio_button As Windows.Forms.RadioButton In grp_sexo.Controls
                If radio_button.Checked = True Then
                    If radio_button.Text = "TODOS" Then
                        sql &= "AND (Paciente.sexo = 'H' OR Paciente.sexo = 'M')"
                        filtros_aplicados(0) = " "
                        Exit For
                    ElseIf radio_button.Text = "Hombre" Then
                        sql &= "AND Paciente.sexo = 'H'"
                        filtros_aplicados(0) = "[sexo HOMBRE]"
                        Exit For
                    Else
                        sql &= "AND Paciente.sexo = 'M'"
                        filtros_aplicados(0) = "[sexo MUJER]"
                        Exit For
                    End If
                End If
            Next
        Else
            filtros_aplicados(0) = " "
        End If

        If chk_habilitar_fechas.Checked = True Then
            Dim fecha_desde As Date = dtp_desde.Value
            Dim fecha_hasta As Date = dtp_hasta.Value
            If fecha_desde > fecha_hasta Then
                MessageBox.Show("La fecha DESDE debe ser menor a la fecha HASTA", "ERROR", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            sql &= " AND Turno.fecha BETWEEN '" & fecha_desde.ToString("yyyy-MM-dd") & "' AND '" & fecha_hasta.ToString("yyyy-MM-dd") & "'"
            filtros_aplicados(1) = "[rango fecha turno [" & fecha_desde.ToString("dd/MM/yyyy") & " - " & fecha_hasta.ToString("dd/MM/yyyy") & "]]"
        Else
            filtros_aplicados(1) = " "
        End If

        If cmb_paciente.SelectedIndex <> 0 Then
            sql &= " AND Paciente.id_paciente = " & cmb_paciente.SelectedValue
            filtros_aplicados(2) = "[turnos paciente " & cmb_paciente.Text.ToUpper() & "]"
        Else
            filtros_aplicados(2) = " "
        End If

        If cmb_empleado.SelectedIndex <> 0 Then
            sql &= " AND Empleado.id_empleado = " & cmb_empleado.SelectedValue
            filtros_aplicados(3) = "[turnos empleado " & cmb_empleado.Text.ToUpper() & "]"
        Else
            filtros_aplicados(3) = " "
        End If
        listar_turnos(sql)
    End Sub

    Private Sub chk_habilitar_fechas_CheckedChanged(sender As Object, e As EventArgs) Handles chk_habilitar_fechas.CheckedChanged
        If dtp_desde.Enabled = False Then
            dtp_desde.Enabled = True
            dtp_hasta.Enabled = True
        Else
            dtp_desde.Enabled = False
            dtp_hasta.Enabled = False
        End If
    End Sub

    Private Sub cmb_paciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_paciente.SelectionChangeCommitted
        If cmb_paciente.SelectedIndex <> 0 Then
            clase_auxiliar.blanquear_campos(Me.grp_sexo)
            Me.rb_h.Enabled = False
            Me.rb_m.Enabled = False
            Me.rb_sexo_todos.Enabled = False
        Else
            Me.rb_h.Enabled = True
            Me.rb_m.Enabled = True
            Me.rb_sexo_todos.Enabled = True
            Me.rb_sexo_todos.Checked = True

        End If


    End Sub

    Private Sub frm_turnos_report_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'La siguiente linea usa el metodo "confirmar_salida" de la clase "Atributos_Compartidos" para
        'ver si el usuario cancelo el cerrado del formulario. (Le manda el evento de cerrado "e" al metodo)
        e.Cancel = clase_auxiliar.confirmar_salida(e)
    End Sub

End Class