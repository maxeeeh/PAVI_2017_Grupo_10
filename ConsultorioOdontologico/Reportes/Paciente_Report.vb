Imports Microsoft.Reporting.WinForms

Public Class frm_paciente_report

    Dim clase_auxiliar As New Atributos_Compartidos


    Private Sub frm_paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clase_auxiliar.cargar_combobox(cmb_loc, tabla_para_combo("Localidad"))
        clase_auxiliar.cargar_combobox(cmb_td, tabla_para_combo("TipoDocumento"))
        dtp_hasta.Value = DateAndTime.Today
        Dim sql As String = ""
        sql &= "SELECT P.apellido + ', ' + P.nombre AS pac, TD.descripcion + ', ' + P.nro_documento AS doc, P.sexo, P.fecha_nacimiento, L.descripcion AS loc"
        sql &= " FROM Paciente P JOIN"
        sql &= " TipoDocumento TD ON P.id_tipo_documento = TD.id_tipo_documento JOIN"
        sql &= " Localidad L ON P.id_localidad = L.id_localidad"
        sql &= " WHERE P.habilitado = 1"
        buscar_pacientes(sql)
    End Sub

    Private Function tabla_para_combo(ByVal nombre_tabla As String) As DataTable
        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        Dim id As String = nombre_tabla.ToLower()

        If nombre_tabla = "TipoDocumento" Then
            id = "tipo_documento"
        End If

        sql &= "SELECT id_" & id & ", descripcion"
        sql &= " FROM " & nombre_tabla
        tabla = clase_auxiliar.ejecuto_sql(sql)

        Dim tabla_final As New Data.DataTable
        tabla_final.Columns.Add()
        tabla_final.Columns.Add()

        Dim fila As Data.DataRow
        fila = tabla_final.NewRow()
        fila(0) = 0
        fila(1) = "TODOS"
        tabla_final.Rows.Add(fila)

        For Each fila In tabla.Rows
            Dim fila_a_agregar As Data.DataRow
            fila_a_agregar = tabla_final.NewRow()
            fila_a_agregar(0) = fila(0)
            fila_a_agregar(1) = fila(1)
            tabla_final.Rows.Add(fila_a_agregar)
        Next
        Return tabla_final
    End Function

    Private Sub buscar_pacientes(ByVal sql As String)
        sql &= " ORDER BY pac ASC"


        PacientesBindingSource.DataSource = clase_auxiliar.ejecuto_sql(sql)
        Me.rv_pacientes.RefreshReport()
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

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim sql As String = ""
        

        sql &= "SELECT P.apellido + ', ' + P.nombre AS pac, TD.descripcion + ', ' + P.nro_documento AS doc, P.sexo, P.fecha_nacimiento, L.descripcion AS loc"
        sql &= " FROM Paciente P JOIN"
        sql &= " TipoDocumento TD ON P.id_tipo_documento = TD.id_tipo_documento JOIN"
        sql &= " Localidad L ON P.id_localidad = L.id_localidad"
        sql &= " WHERE "

        For Each radio_button As Windows.Forms.RadioButton In grp_estado.Controls
            If radio_button.Checked = True Then
                If radio_button.Text = "TODOS" Then
                    sql &= "(P.habilitado = 1 OR P.habilitado = 0)"
                    Exit For
                ElseIf radio_button.Text = "Habilitados" Then
                    sql &= "P.habilitado = 1"
                    Exit For
                Else
                    sql &= "P.habilitado = 0"
                    Exit For
                End If
            End If
        Next

        For Each radio_button As Windows.Forms.RadioButton In grp_sexo.Controls
            If radio_button.Checked = True Then
                If radio_button.Text = "TODOS" Then
                    sql &= " AND (P.sexo = 'H' OR P.sexo = 'M')"
                    Exit For
                ElseIf radio_button.Text = "Hombre" Then
                    sql &= " AND P.sexo = 'H'"
                    Exit For
                Else
                    sql &= " AND P.sexo = 'M'"
                    Exit For
                End If
            End If
        Next

        If cmb_loc.SelectedIndex <> 0 Then
            sql &= " AND L.id_localidad = " & cmb_loc.SelectedValue
        End If

        If cmb_td.SelectedIndex <> 0 Then
            sql &= " AND TD.id_tipo_documento = " & cmb_td.SelectedValue
        End If

        If chk_habilitar_fechas.Checked = True Then
            Dim fecha_desde As Date = dtp_desde.Value
            Dim fecha_hasta As Date = dtp_hasta.Value
            If fecha_desde > fecha_hasta Then
                MessageBox.Show("La fecha DESDE debe ser menor a la fecha HASTA", "ERROR", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            sql &= " AND P.fecha_nacimiento BETWEEN '" & fecha_desde.ToString("yyyy-MM-dd") & "' AND '" & fecha_hasta.ToString("yyyy-MM-dd") & "'"
        End If
        buscar_pacientes(sql)
    End Sub

    Private Sub frm_paciente_report_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'La siguiente linea usa el metodo "confirmar_salida" de la clase "Atributos_Compartidos" para
        'ver si el usuario cancelo el cerrado del formulario. (Le manda el evento de cerrado "e" al metodo)
        e.Cancel = clase_auxiliar.confirmar_salida(e)
    End Sub
End Class