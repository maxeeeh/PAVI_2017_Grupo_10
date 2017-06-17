Public Class frm_tratamientosPorPacientes
    Dim clase_auxiliar As New Atributos_Compartidos
    Private Sub frm_tratamientosPorPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub cargar_estadistica()
        Dim sql As String = ""
        sql &= "SELECT T.descripcion, COUNT(*) AS valor, P.apellido + ', ' + P.nombre AS paciente"
        sql &= " FROM Tratamiento T JOIN "
        sql &= " TratamientoXIntervencion TxI ON T.id_tratamiento = TxI.id_tratamiento JOIN"
        sql &= " Intervencion I ON TxI.id_intervencion = I.id_intervencion JOIN"
        sql &= " Paciente P ON I.id_paciente = P.id_paciente"
        sql &= " WHERE P.habilitado = 1 AND P.id_paciente =" & cmb_filtro_paciente.SelectedValue
        sql &= " GROUP BY T.descripcion, P.apellido, P.nombre"
        sql &= " ORDER BY valor DESC"
        Me.TratamientosPorPacientesBindingSource.DataSource = Me.clase_auxiliar.ejecuto_sql(sql)
        Me.rv_tratamientosPaciente.RefreshReport()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        If Me.cmb_filtro_paciente.SelectedIndex <> -1 Then
            Me.cargar_estadistica()
        Else
            MessageBox.Show("Debe seleccionar un paciente")
        End If

    End Sub
End Class