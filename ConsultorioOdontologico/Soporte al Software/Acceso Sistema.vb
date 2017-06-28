Public Class frm_acceso_sistema

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close() 'La ventana principal no pide confirmacion para salir, eso lo hace cada sub-ventana
    End Sub

    ''' <summary>
    ''' Abre un formulario nuevo en la ventana, cerrando el anterior si hace falta
    ''' </summary>
    ''' <param name="formulario"></param>
    ''' <remarks></remarks>
    Private Sub abrir_formulario(formulario As System.Windows.Forms.Form)
        'Tener en cuenta:
        '   -la ventana principal es un contenedor MDI, osea que permite abrir nuevos formularios adentro suyo.
        '   -solo debe haber abierto 1 formulario como maximo a la vez, por lo que este metodo verifica eso.
        If Me.ActiveMdiChild Is Nothing Then 'Si no hay un formulario abierto, no hay ningun formulario abierto y abre el nuevo
            ejecutar_apertura_formulario(formulario)
        Else 'Si ya hay un formulario abierto, lo intenta cerrar (preguntandole al usuario)
            If formulario.Name <> Me.MdiChildren(0).Name Then
                Me.MdiChildren(0).Close()
                If Me.ActiveMdiChild Is Nothing Then 'Verifica de nuevo que no haya un formulario abierto para  ver si abre el nuevo
                    ejecutar_apertura_formulario(formulario)
                End If
            End If
        End If
    End Sub

    Private Sub ejecutar_apertura_formulario(formulario As System.Windows.Forms.Form)
        formulario.Show()
        formulario.MdiParent = Me
        Me.Text = "Consultorio Odontologico - " & formulario.Text
    End Sub

    Private Sub frm_acceso_sistema_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate
        'Esto es simplemente para que cambie el titulo de la ventana principal cuando se cierra un formulario
        If Me.ActiveMdiChild Is Nothing Then
            Me.Text = "Consultorio Odontologico"
        End If
    End Sub

    Private Sub ABMPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMPacientesToolStripMenuItem.Click
        abrir_formulario(frm_registrar_paciente)
    End Sub

    Private Sub ListadoPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoPacientesToolStripMenuItem.Click
        abrir_formulario(frm_paciente_report)
    End Sub

    Private Sub HistorialMedicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialMedicoToolStripMenuItem.Click
        abrir_formulario(frm_historial_medico)
    End Sub

    Private Sub EstadisticaDeTratamientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticaDeTratamientosToolStripMenuItem.Click
        abrir_formulario(frm_tratamientosPorPacientes)
    End Sub

    Private Sub ABMEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMEmpleadosToolStripMenuItem.Click
        abrir_formulario(frm_registrar_empleado)
    End Sub

    Private Sub ABMCargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMCargosToolStripMenuItem.Click
        abrir_formulario(frm_registrar_cargo)
    End Sub

    Private Sub EstadisticaDeTurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticaDeTurnosToolStripMenuItem.Click
        abrir_formulario(frm_profesionalConMasTurnos)
    End Sub

    Private Sub RegistrarTurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarTurnosToolStripMenuItem.Click
        abrir_formulario(frm_turnos)
    End Sub

    Private Sub RegistrarIntervencionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarIntervencionToolStripMenuItem.Click
        abrir_formulario(frm_intervenciones)
    End Sub

    Private Sub GenerarFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarFacturaToolStripMenuItem.Click
        abrir_formulario(frm_factura)
    End Sub

    Private Sub ABMTratamientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTratamientosToolStripMenuItem.Click
        abrir_formulario(frm_registrar_tratamiento)
    End Sub

    Private Sub ABMInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMInsumosToolStripMenuItem.Click
        abrir_formulario(frm_registrar_insumo)
    End Sub

    Private Sub ListadoInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoInsumosToolStripMenuItem.Click
        abrir_formulario(frm_insumo_report)
    End Sub

    Private Sub EstadisticaInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticaInsumosToolStripMenuItem.Click
        abrir_formulario(frm_Insumos_Mas_Usados)
    End Sub
End Class