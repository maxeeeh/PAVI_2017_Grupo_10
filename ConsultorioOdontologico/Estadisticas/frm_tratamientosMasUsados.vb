Public Class frm_tratamientosMasUsados

    Dim clase_auxiliar As New Atributos_Compartidos

    Private Sub frm_tratamientosMasUsados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_Estadística()
        
    End Sub




    Private Sub mostrar_Estadística()
        Dim sql As String = ""
        Dim tabla As New Data.DataTable


        sql &= "SELECT Tratamiento.descripcion,COUNT(*) as valor"
        sql &= " FROM Tratamiento INNER JOIN TratamientoXIntervencion ON Tratamiento.id_tratamiento = TratamientoXIntervencion.id_tratamiento"
        sql &= " GROUP BY  Tratamiento.descripcion"

        tabla = clase_auxiliar.ejecuto_sql(sql)

        TratamientosMasUsadosBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()





    End Sub
End Class