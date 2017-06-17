Public Class frm_profesionalConMasTurnos

    Dim clase_auxiliar As New Atributos_Compartidos

    Private Sub frm_profesionalConMasTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_Estadística()

    End Sub

    Private Sub mostrar_Estadística()
        Dim sql As String = ""
        Dim tabla As New Data.DataTable


        sql &= "SELECT Empleado.apellido+', '+Empleado.nombre as Empleado,COUNT(*)as Cantidad"
        sql &= " FROM Empleado INNER JOIN Turno "
        sql &= " ON Empleado.id_empleado = Turno.id_empleado"
        sql &= " WHERE Empleado.habilitado=1"
        sql &= " GROUP BY Empleado.apellido,Empleado.nombre"

        tabla = clase_auxiliar.ejecuto_sql(sql)

        ProfesionalConMasTurnosBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
        

    End Sub


    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class