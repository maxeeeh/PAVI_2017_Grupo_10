Public Class Factura
    Dim clase_auxiliar As New Atributos_Compartidos
    Dim tabla_intervenciones As New DataTable
    Dim monto_total As Double = 0

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        clase_auxiliar.cargar_combobox(cmb_pacientes, tabla_para_combo_pacientes())

    End Sub

   

    Private Function tabla_para_combo_pacientes() As DataTable

        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        'En el select hace id_empleado o id_paciente, y despues concatena asi: "Apellido, Nombre"
        sql &= "SELECT P.id_paciente , P.apellido + ', ' + P.nombre"
        sql &= " FROM Paciente P"
        sql &= " WHERE habilitado = 1 AND P.id_paciente = ANY (SELECT I1.id_paciente FROM Intervencion I1 WHERE I1.pagado = 0)"
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
        cargar_tabla_intervenciones()
        clase_auxiliar.cargar_combobox(cmb_intervenciones, tabla_intervenciones)
        Me.grid_intervenciones.Rows.Clear()
        Me.cmd_agregar.Enabled = True
        Me.cmd_remover.Enabled = False
    End Sub

    Private Sub frm_intervenciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'La siguiente linea usa el metodo "confirmar_salida" de la clase "Atributos_Compartidos" para
        'ver si el usuario cancelo el cerrado del formulario. (Le manda el evento de cerrado "e" al metodo)
        e.Cancel = clase_auxiliar.confirmar_salida(e)
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
End Class