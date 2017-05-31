Public Class frm_factura
    Dim clase_auxiliar As New Atributos_Compartidos
    Dim tabla_intervenciones As New DataTable
    Dim monto_total As Double = 0

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        clase_auxiliar.cargar_combobox(cmb_pacientes, tabla_para_combo_pacientes())
        If cmb_pacientes.SelectedIndex <> -1 Then
            Me.cargar_intervenciones()
        End If
    End Sub

    Private Function tabla_para_combo_pacientes() As DataTable

        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        'En el select hace id_empleado o id_paciente, y despues concatena asi: "Apellido, Nombre"
        sql &= "SELECT P.id_paciente , P.apellido + ', ' + P.nombre"
        sql &= " FROM Paciente P"
        sql &= " WHERE habilitado = 1 AND P.id_paciente = ANY (SELECT I.id_paciente FROM Intervencion I WHERE I.pagado = 0)"
        sql &= " ORDER BY P.apellido"
        '       sql &= " GROUP BY id_" & nombre_tabla.ToLower() & ", apellido + ', ' + nombre"
        tabla = clase_auxiliar.ejecuto_sql(sql)

        Return tabla

    End Function

    Private Sub cargar_tabla_intervenciones() ' el parametro puede ser "Empleado" o "Paciente"
        'Esta funcion da una tabla con 2 columnas: la primera es el id_paciente o id_empleado, y la segunda el apellido y nombre concatenados

            Dim tabla As New Data.DataTable
            Dim sql As String = ""
            'En el select hace id_empleado o id_paciente, y despues concatena asi: "Apellido, Nombre"
            sql &= "SELECT I.id_intervencion, I.fecha, I.monto_total As monto, I.id_empleado, E.nombre + ', ' + E.apellido As empleado"
            sql &= " FROM Intervencion I JOIN Empleado E ON I.id_empleado = E.id_empleado"
            sql &= " WHERE pagado = 0 AND id_paciente = " & cmb_pacientes.SelectedValue.ToString
            sql &= " ORDER BY fecha ASC"
            tabla_intervenciones = clase_auxiliar.ejecuto_sql(sql) 'guarda la tabla de las intervenciones en una variable

    End Sub

    Private Sub cmb_pacientes_SelectionChangeCommited(sender As Object, e As EventArgs) Handles cmb_pacientes.SelectionChangeCommitted
        cargar_intervenciones()
    End Sub

    Private Sub cargar_intervenciones()
        cargar_tabla_intervenciones()
        clase_auxiliar.cargar_combobox(cmb_intervenciones, tabla_intervenciones)
        Me.grid_intervenciones.Rows.Clear()
        Me.cmd_agregar.Enabled = True
        Me.cmd_remover.Enabled = False
        Me.monto_total = 0
        Me.txt_monto_total.Text = "$ 0"
    End Sub

    Private Sub frm_intervenciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'La siguiente linea usa el metodo "confirmar_salida" de la clase "Atributos_Compartidos" para
        'ver si el usuario cancelo el cerrado del formulario. (Le manda el evento de cerrado "e" al metodo)
        e.Cancel = clase_auxiliar.confirmar_salida(e)
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_agregar_Click(sender As Object, e As EventArgs) Handles cmd_agregar.Click
        For c As Integer = 0 To Me.tabla_intervenciones.Rows.Count - 1
            If Me.tabla_intervenciones.Rows(c)("id_intervencion") = Me.cmb_intervenciones.SelectedValue Then
                Me.grid_intervenciones.Rows.Add( _
                    cmb_intervenciones.SelectedValue, _
                    Convert.ToDateTime(Me.tabla_intervenciones.Rows(c)("fecha")).ToString("dd-MM-yyyy"), _
                    Me.tabla_intervenciones.Rows(c)("id_empleado"), _
                    Me.tabla_intervenciones.Rows(c)("empleado"), _
                    Me.tabla_intervenciones.Rows(c)("monto") _
                    )
                Me.actualizar_monto_total(tabla_intervenciones.Rows(c)("monto"))
                Me.tabla_intervenciones.Rows.RemoveAt(c)
                clase_auxiliar.cargar_combobox(cmb_intervenciones, tabla_intervenciones)
                Me.cmd_remover.Enabled = True
                If tabla_intervenciones.Rows.Count = 0 Then
                    Me.cmd_agregar.Enabled = False
                End If

                Exit For
            End If
        Next

    End Sub

    Private Sub actualizar_monto_total(ByVal monto_t As String)
        Dim monto_con_comas As String
        Dim monto As Double

        monto_con_comas = monto_t.Replace(".", ",")
        monto = Convert.ToDouble(monto_con_comas)
        monto_total = monto_total + monto
        Me.txt_monto_total.Text = "$ " & monto_total
    End Sub

    Private Sub cmd_remover_Click(sender As Object, e As EventArgs) Handles cmd_remover.Click
        Dim fila_intervencion_borrada As Data.DataRow
        fila_intervencion_borrada = tabla_intervenciones.NewRow
        fila_intervencion_borrada("id_intervencion") = Me.grid_intervenciones.CurrentRow.Cells("id_intervencion").Value
        fila_intervencion_borrada("fecha") = Me.grid_intervenciones.CurrentRow.Cells("fecha").Value
        fila_intervencion_borrada("monto") = Me.grid_intervenciones.CurrentRow.Cells("monto").Value
        fila_intervencion_borrada("id_empleado") = Me.grid_intervenciones.CurrentRow.Cells("id_empleado").Value
        fila_intervencion_borrada("empleado") = Me.grid_intervenciones.CurrentRow.Cells("empleado").Value

        Me.tabla_intervenciones.Rows.Add(fila_intervencion_borrada)
        Dim monto = "-" & grid_intervenciones.CurrentRow.Cells("monto").Value '😁

        Me.grid_intervenciones.Rows.RemoveAt(grid_intervenciones.CurrentRow.Index)



        'Me.actualizar_monto_total()

        Me.actualizar_monto_total(monto)

        If grid_intervenciones.Rows.Count = 0 Then
            Me.cmd_remover.Enabled = False
        End If
        Me.cmd_agregar.Enabled = True
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If grid_intervenciones.Rows().Count = 0 Then
            MessageBox.Show("Debe haber por lo menos 1 intervencion a facturar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'INICIAR CONEXION DE TRANSACCION
            Me.clase_auxiliar.iniciar_conexion_con_transaccion()
            'GUARDAR LOS DATOS DE LA FACTURA
            Dim sql_factura As String = ""
            sql_factura &= "INSERT INTO Factura (id_paciente, monto_total, fecha, id_forma_pago)"
            sql_factura &= " VALUES ("
            sql_factura &= cmb_pacientes.SelectedValue.ToString
            sql_factura &= ", " & monto_total.ToString.Replace(",", ".") 'se hace un update despues de guardar los tratamientosxinterv <- copiado de intervenciones
            sql_factura &= ", '" & DateTime.Today.ToString("yyyy-MM-dd") & "'"
            'sql_factura &= ", '" & DateTime.Now.ToString("HH:mm") & "'"
            If Me.rbt_efectivo.Checked Then
                sql_factura &= ", 1"
            ElseIf Me.rbt_tarjeta.Checked Then
                sql_factura &= ", 2"
            End If
            sql_factura &= " )"

            Me.clase_auxiliar.insertar_modificar_eliminar(sql_factura)

            '(Para hacer lo que sigue, primero buscamos el id de la factura recien creada)
            Dim id_factura As Integer = Me.clase_auxiliar.ejecuto_sql("SELECT TOP 1 id_factura FROM factura ORDER BY id_factura DESC").Rows(0)("id_factura")

            'GUARDAR LOS DATOS DE LOS DETALLEFACTURA
            Dim sql_detallefactura As String
            For Each fila In Me.grid_intervenciones.Rows()
                sql_detallefactura = ""
                sql_detallefactura &= "INSERT INTO detallefactura (id_factura, id_intervencion, precio) VALUES ("
                sql_detallefactura &= " " & id_factura.ToString
                sql_detallefactura &= ", " & fila.Cells("id_intervencion").Value.ToString
                sql_detallefactura &= ", " & fila.Cells("monto").Value.ToString().Replace(",", ".")
                sql_detallefactura &= ")"

                Me.clase_auxiliar.insertar_modificar_eliminar(sql_detallefactura)
            Next

            'MODIFICAR INTERVENCION (PAGADO)
            Dim sql_intervencion As String
            For c As Integer = 0 To Me.grid_intervenciones.Rows.Count() - 1
                sql_intervencion = ""
                sql_intervencion &= "UPDATE Intervencion SET pagado = 1"
                sql_intervencion &= "WHERE id_intervencion = " & Me.grid_intervenciones.Rows(c).Cells("id_intervencion").Value.ToString

                Me.clase_auxiliar.insertar_modificar_eliminar(sql_intervencion)
            Next

            'CERRAR CONEXION DE TRANSACCION
            Me.clase_auxiliar.cerrar_conexion_con_transaccion()
            MessageBox.Show("Se ha registrado la factura correctamente")
            clase_auxiliar.cargar_combobox(cmb_pacientes, tabla_para_combo_pacientes())
            limpiar_form()
            Dim factura_impresa As Windows.Forms.Form
            factura_impresa = New frm_factura_report(id_factura)
            factura_impresa.Show()
        End If
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        limpiar_form()
    End Sub

    Private Sub limpiar_form()
        monto_total = 0
        clase_auxiliar.blanquear_campos(Me)
        grid_intervenciones.Rows.Clear()
        cmd_agregar.Enabled = False
        cmd_remover.Enabled = False
        txt_monto_total.Text = "$ 0"
        rbt_efectivo.Checked = True
    End Sub
End Class