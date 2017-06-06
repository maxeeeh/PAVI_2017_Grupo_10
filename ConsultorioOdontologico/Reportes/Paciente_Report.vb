Imports Microsoft.Reporting.WinForms

Public Class frm_paciente_report

    Dim clase_auxiliar As New Atributos_Compartidos
    Dim filtros_aplicados() As String = {" ", " ", " ", " ", " ", " "}


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
        filtros_aplicados(0) = "[HABILITADO]"
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

        Dim param As Microsoft.Reporting.WinForms.ReportParameter = New Microsoft.Reporting.WinForms.ReportParameter("TipoReporte", value_param)
        rv_pacientes.ProcessingMode = ProcessingMode.Local
        rv_pacientes.LocalReport.ReportPath = "Reportes\Report\Pacientes_Report.rdlc"
        rv_pacientes.LocalReport.SetParameters(param)

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
                    filtros_aplicados(0) = " "
                    Exit For
                ElseIf radio_button.Text = "Habilitados" Then
                    sql &= "P.habilitado = 1"
                    filtros_aplicados(0) = "[HABILITADO]"
                    Exit For
                Else
                    sql &= "P.habilitado = 0"
                    filtros_aplicados(0) = "[DESHABILITADO]"
                    Exit For
                End If
            End If
        Next

        For Each radio_button As Windows.Forms.RadioButton In grp_sexo.Controls
            If radio_button.Checked = True Then
                If radio_button.Text = "TODOS" Then
                    sql &= " AND (P.sexo = 'H' OR P.sexo = 'M')"
                    filtros_aplicados(1) = " "
                    Exit For
                ElseIf radio_button.Text = "Hombre" Then
                    sql &= " AND P.sexo = 'H'"
                    filtros_aplicados(1) = "[sexo HOMBRE]"
                    Exit For
                Else
                    sql &= " AND P.sexo = 'M'"
                    filtros_aplicados(1) = "[sexo MUJER]"
                    Exit For
                End If
            End If
        Next

        If cmb_loc.SelectedIndex <> 0 Then
            sql &= " AND L.id_localidad = " & cmb_loc.SelectedValue
            filtros_aplicados(2) = "[localidad " & cmb_loc.Text.ToUpper() & "]"
        Else
            filtros_aplicados(2) = " "
        End If

        If cmb_td.SelectedIndex <> 0 Then
            sql &= " AND TD.id_tipo_documento = " & cmb_td.SelectedValue
            filtros_aplicados(3) = "[tipo documento " & cmb_td.Text.ToUpper() & "]"
        Else
            filtros_aplicados(3) = " "
        End If

        If chk_habilitar_fechas.Checked = True Then
            Dim fecha_desde As Date = dtp_desde.Value
            Dim fecha_hasta As Date = dtp_hasta.Value
            If fecha_desde > fecha_hasta Then
                MessageBox.Show("La fecha DESDE debe ser menor a la fecha HASTA", "ERROR", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            sql &= " AND P.fecha_nacimiento BETWEEN '" & fecha_desde.ToString("yyyy-MM-dd") & "' AND '" & fecha_hasta.ToString("yyyy-MM-dd") & "'"
            filtros_aplicados(4) = "[rango fecha nacimiento [" & fecha_desde.ToString("dd/MM/yyyy") & " - " & fecha_hasta.ToString("dd/MM/yyyy") & "]]"
        Else
            filtros_aplicados(4) = " "
        End If
        buscar_pacientes(sql)
    End Sub


End Class