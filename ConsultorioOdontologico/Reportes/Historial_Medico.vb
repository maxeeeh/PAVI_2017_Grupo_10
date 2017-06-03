Public Class frm_historial_medico
    Dim clase_auxiliar As New Atributos_Compartidos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clase_auxiliar.cargar_combobox(cmb_filtro_paciente, tabla_para_combo_paciente())
        cmb_filtro_paciente.SelectedIndex = -1
    End Sub

    Private Function tabla_para_combo_paciente() As DataTable
        'Esta funcion da una tabla con 2 columnas: la primera es el id_paciente y la segunda el apellido y nombre concatenados

        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        'En el select hace id_paciente, y despues concatena asi: "Apellido, Nombre"
        sql &= "SELECT P.id_paciente, P.apellido + ', ' + P.nombre"
        sql &= " FROM Paciente P"
        sql &= " WHERE P.habilitado = 1"
        sql &= " ORDER BY P.apellido"
        tabla = clase_auxiliar.ejecuto_sql(sql)

        Return tabla
    End Function

    Private Sub buscar_historial()
        If cmb_filtro_paciente.SelectedIndex <> -1 Then
            Dim sql As String = ""

            sql &= "SELECT"
            sql &= " I.id_intervencion,"
            sql &= " I.fecha,"
            sql &= " I.hora,"
            sql &= " TD.descripcion + ': ' + P.nro_documento AS doc,"
            sql &= " P.apellido + ', ' + P.nombre AS pac,"
            sql &= " E.apellido + ', ' + E.nombre AS emp,"
            sql &= " I.observaciones"
            'sql &= " Tratamiento.descripcion AS tra,"
            'sql &= " Insumo.descripcion AS ins,"
            'sql &= " InsumoXIntervencion.cantidad_insumos"
            'sql &= " FROM InsumoXIntervencion INNER JOIN"
            'sql &= " Insumo ON InsumoXIntervencion.id_insumo = Insumo.id_insumo INNER JOIN"
            'sql &= " Intervencion ON InsumoXIntervencion.id_intervencion = Intervencion.id_intervencion INNER JOIN"
            sql &= " FROM Intervencion I JOIN"
            sql &= " Empleado E ON I.id_empleado = E.id_empleado JOIN"
            sql &= " Paciente P ON I.id_paciente = P.id_paciente JOIN"
            sql &= " TipoDocumento TD ON P.id_tipo_documento = TD.id_tipo_documento"
            'sql &= " TratamientoXIntervencion ON Intervencion.id_intervencion = TratamientoXIntervencion.id_intervencion INNER JOIN"
            'sql &= " Tratamiento ON TratamientoXIntervencion.id_tratamiento = Tratamiento.id_tratamiento"
            sql &= " WHERE P.id_paciente = " & cmb_filtro_paciente.SelectedValue

            Historial_MedicoBindingSource.DataSource = clase_auxiliar.ejecuto_sql(sql)

            AddHandler rv_historial_medico.LocalReport.SubreportProcessing, AddressOf Me.SubreportProcessingEventHandler

            Me.rv_historial_medico.RefreshReport()

        Else
            rv_historial_medico.Clear()
        End If

    End Sub

    Private Sub cmb_filtro_paciente_SelectionChangeCommited(sender As Object, e As EventArgs) Handles cmb_filtro_paciente.SelectionChangeCommitted
        buscar_historial()
    End Sub

    Private Sub SubreportProcessingEventHandler(sender As Object, e As Microsoft.Reporting.WinForms.SubreportProcessingEventArgs)
        'MessageBox.Show(e.ReportPath)
        Dim subreport_name As String = e.ReportPath
        Dim sql As String = ""

        Select Case subreport_name
            Case "Tratamientos_SubReport"
                sql &= "SELECT T.descripcion"
                sql &= " FROM TratamientoXIntervencion TI JOIN Intervencion I ON TI.id_intervencion = I.id_intervencion"
                sql &= " JOIN Tratamiento T ON TI.id_tratamiento = T.id_tratamiento"
                sql &= " WHERE I.id_intervencion = " & Convert.ToInt32(e.Parameters("id_intervencion").Values.First())

                'Le digo explicitamente como se llama su DataSet aunque se lo haya definido en el diseño y le paso su fuente de datos
                e.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DS_Tratamiento", clase_auxiliar.ejecuto_sql(sql)))
            Case "Insumos_SupReport"
                sql &= "SELECT Ins.descripcion, II.cantidad_insumos"
                sql &= " FROM InsumoXIntervencion II JOIN Intervencion I ON II.id_intervencion = I.id_intervencion"
                sql &= " JOIN Insumo Ins ON II.id_insumo = Ins.id_insumo"
                sql &= " WHERE I.id_intervencion = " & Convert.ToInt32(e.Parameters("id_intervencion").Values.First())

                'Le digo explicitamente como se llama su DataSet aunque se lo haya definido en el diseño y le paso su fuente de datos
                e.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DS_Insumo", clase_auxiliar.ejecuto_sql(sql)))
        End Select
        
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class