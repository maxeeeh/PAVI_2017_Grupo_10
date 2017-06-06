Imports Microsoft.Reporting.WinForms

Public Class frm_paciente_report

    Dim clase_Auxiliar As New Atributos_Compartidos

    Private Sub frm_paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_hasta.Value = DateAndTime.Today
        Dim sql As String = ""
        sql &= "SELECT P.apellido + ', ' + P.nombre AS pac, TD.descripcion + ', ' + P.nro_documento AS doc, P.sexo, P.fecha_nacimiento, L.descripcion AS loc"
        sql &= " FROM Paciente P JOIN"
        sql &= " TipoDocumento TD ON P.id_tipo_documento = TD.id_tipo_documento JOIN"
        sql &= " Localidad L ON P.id_localidad = L.id_localidad"
        buscar_pacientes(sql)
    End Sub

    Private Sub buscar_pacientes(ByVal sql As String)
        sql &= " ORDER BY pac ASC"
        Dim param As Microsoft.Reporting.WinForms.ReportParameter = New Microsoft.Reporting.WinForms.ReportParameter("TipoReporte", "TODO")
        rv_pacientes.ProcessingMode = ProcessingMode.Local
        rv_pacientes.LocalReport.ReportPath = "Reportes\Report\Pacientes_Report.rdlc"
        rv_pacientes.LocalReport.SetParameters(param)

        PacientesBindingSource.DataSource = clase_Auxiliar.ejecuto_sql(sql)
        Me.rv_pacientes.RefreshReport()
    End Sub

    'Private Sub buscar_pacientes()
    '    Dim sql As String = ""
    '    sql &= "SELECT P.apellido + ', ' + P.nombre AS pac, TD.descripcion + ', ' + P.nro_documento AS doc, P.sexo, P.fecha_nacimiento, L.descripcion"
    '    sql &= " FROM Paciente P JOIN"
    '    sql &= " TipoDocumento ON P.id_tipo_documento = TD.id_tipo_documento JOIN"
    '    sql &= " Localidad L ON P.id_localidad = L.id_localidad"
    '    sql &= " WHERE "
    '    If rb_habilitados.Checked = True Then
    '        sql &= "P.habilitado = 1, "
    '    ElseIf rb_deshabilitados.Checked = True Then
    '        sql &= "P.habilitado = 0, "
    '    End If

    '    If rb_m.Checked = True Then
    '        sql &= "P.sexo = 'M', "
    '    ElseIf rb_f.Checked = True Then
    '        sql &= "P.sexo = 'F', "
    '    End If

    '    'For Each radio_button As Windows.Forms.RadioButton In grp_estado.Controls
    '    '    If radio_button.Checked = True Then
    '    '        If radio_button.Text = "TODOS" Then
    '    '            sql &= "habilitado = 1 OR habilitado = 0"
    '    '            Exit For
    '    '        ElseIf radio_button.Text = "Habilitados" Then
    '    '            sql &= "habilitado = 1"
    '    '            Exit For
    '    '        Else
    '    '            sql &= "habilitado = 0"
    '    '            Exit For
    '    '        End If
    '    '    End If
    '    'Next



    '    Dim param As Microsoft.Reporting.WinForms.ReportParameter = New Microsoft.Reporting.WinForms.ReportParameter("TipoReporte", "TODO")
    '    rv_pacientes.ProcessingMode = ProcessingMode.Local
    '    rv_pacientes.LocalReport.ReportPath = "Reportes\Report\Pacientes_Report.rdlc"
    '    rv_pacientes.LocalReport.SetParameters(param)

    '    PacientesBindingSource.DataSource = clase_Auxiliar.ejecuto_sql(sql)
    '    Me.rv_pacientes.RefreshReport()

    '    'MessageBox.Show(rv_pacientes.LocalReport.ReportPath.ToString())
    'End Sub

  
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
                    sql &= "(habilitado = 1 OR habilitado = 0)"
                    Exit For
                ElseIf radio_button.Text = "Habilitados" Then
                    sql &= "habilitado = 1"
                    Exit For
                Else
                    sql &= "habilitado = 0"
                    Exit For
                End If
            End If
        Next

        For Each radio_button As Windows.Forms.RadioButton In grp_sexo.Controls
            If radio_button.Checked = True Then
                If radio_button.Text = "TODOS" Then
                    sql &= "AND (sexo = 'H' OR sexo = 'M')"
                ElseIf radio_button.Text = "Hombre" Then
                    sql &= "AND sexo = 'H'"
                Else
                    sql &= "AND sexo = 'M'"
                End If
            End If
        Next


        buscar_pacientes(sql)
    End Sub
End Class