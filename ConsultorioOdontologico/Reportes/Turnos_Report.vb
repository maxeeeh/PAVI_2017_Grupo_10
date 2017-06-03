Public Class Turnos_Report
    Dim clase_auxiliar As New Atributos_Compartidos

    Private Sub Turnos_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.listar_turnos()
    End Sub

    Private Sub listar_turnos()
        Dim sql As String = ""
        sql &= "SELECT "
        sql &= " Turno.fecha, "
        sql &= " Turno.hora_desde,"
        sql &= " Turno.hora_hasta,"
        sql &= " Paciente.apellido + ', ' + Paciente.nombre AS pac,"
        sql &= " Empleado.apellido + ', ' + Empleado.nombre AS emp"
        sql &= " FROM Empleado INNER JOIN Turno ON Empleado.id_empleado = Turno.id_empleado"
        sql &= " INNER JOIN Paciente ON Turno.id_paciente = Paciente.id_paciente"
        sql &= " WHERE Empleado.habilitado = 1 AND Paciente.habilitado = 1"

        Me.TurnosBindingSource.DataSource = clase_auxiliar.ejecuto_sql(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class