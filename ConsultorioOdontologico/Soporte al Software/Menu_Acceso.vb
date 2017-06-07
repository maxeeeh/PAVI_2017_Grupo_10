Public Class frm_menu_acceso

    Private Sub cmd_paciente_Click(sender As Object, e As EventArgs) Handles cmd_paciente.Click
        Dim ventana As Form = New frm_registrar_paciente
        ventana.Show()
    End Sub

    Private Sub cmd_empleado_Click(sender As Object, e As EventArgs) Handles cmd_empleado.Click
        Dim ventana As Form = New frm_registrar_empleado
        ventana.Show()
    End Sub

    Private Sub cmd_tratamiento_Click(sender As Object, e As EventArgs) Handles cmd_tratamiento.Click
        Dim ventana As Form = New frm_registrar_tratamiento
        ventana.Show()
    End Sub

    Private Sub cmd_cargo_Click(sender As Object, e As EventArgs) Handles cmd_cargo.Click
        Dim ventana As Form = New frm_registrar_cargo
        ventana.Show()
    End Sub

    Private Sub cmd_insumo_Click(sender As Object, e As EventArgs) Handles cmd_insumo.Click
        Dim ventana As Form = New frm_registrar_insumo
        ventana.Show()
    End Sub

    Private Sub cmd_turno_Click(sender As Object, e As EventArgs) Handles cmd_turno.Click
        Dim ventana As Form = New frm_turnos
        ventana.Show()
    End Sub

    Private Sub cmd_intervencion_Click(sender As Object, e As EventArgs) Handles cmd_intervencion.Click
        Dim ventana As Form = New frm_intervenciones
        ventana.Show()
    End Sub

    Private Sub cmd_factura_Click(sender As Object, e As EventArgs) Handles cmd_factura.Click
        Dim ventana As Form = New frm_factura
        ventana.Show()
    End Sub

    Private Sub cmd_historial_medico_Click(sender As Object, e As EventArgs) Handles cmd_historial_medico.Click
        Dim ventana As Form = New frm_historial_medico
        ventana.Show()
    End Sub

    Private Sub cmd_listado_paciente_Click(sender As Object, e As EventArgs) Handles cmd_listado_paciente.Click
        Dim ventana As Form = New frm_paciente_report
        ventana.Show()
    End Sub

    Private Sub cmd_listado_turno_Click(sender As Object, e As EventArgs) Handles cmd_listado_turno.Click
        Dim ventana As Form = New frm_turnos_report
        ventana.Show()
    End Sub

    Private Sub cmd_listado_insumos_Click(sender As Object, e As EventArgs) Handles cmd_listado_insumos.Click
        Dim ventana As Form = New frm_insumo_report
        ventana.Show()
    End Sub
End Class