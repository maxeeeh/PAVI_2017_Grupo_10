Public Class frm_insumo_report
    Dim clase_auxiliar As New Atributos_Compartidos
    Dim param As Microsoft.Reporting.WinForms.ReportParameter = New Microsoft.Reporting.WinForms.ReportParameter("TipoReporte", "Filtrado por: [HABILITADO]")

    Private Sub Insumo_Reporrt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filtro As String = " WHERE habilitado = 1"
        buscar_insumos(filtro)
    End Sub

    Private Sub buscar_insumos(ByVal filtro As String)
        Dim sql As String = ""
        sql &= "SELECT descripcion FROM Insumo" & filtro & " ORDER BY descripcion ASC"


        rv_insumos.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        rv_insumos.LocalReport.ReportPath = "Reportes\Report\Insumos_Report.rdlc"
        rv_insumos.LocalReport.SetParameters(param)
        InsumosBindingSource.DataSource = clase_auxiliar.ejecuto_sql(sql)
        Me.rv_insumos.RefreshReport()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim filtro As String = ""

        For Each radio_button As Windows.Forms.RadioButton In grp_estado.Controls
            If radio_button.Checked = True Then
                If radio_button.Text = "TODOS" Then
                    param = New Microsoft.Reporting.WinForms.ReportParameter("TipoReporte", " ")
                    Exit For
                ElseIf radio_button.Text = "Habilitados" Then
                    filtro = " WHERE habilitado = 1"
                    param = New Microsoft.Reporting.WinForms.ReportParameter("TipoReporte", "Filtrado por: [HABILITADO]")
                    Exit For
                Else
                    filtro = " WHERE habilitado = 0"
                    param = New Microsoft.Reporting.WinForms.ReportParameter("TipoReporte", "Filtrado por: [DESHABILITADO]")
                    Exit For
                End If
            End If
        Next
        buscar_insumos(filtro)
    End Sub
End Class