Public Class frm_Insumos_Mas_Usados

    Dim clase_auxiliar As New Atributos_Compartidos

    Private Sub frm_Insumos_Mas_Usados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrar_Estadística()

    End Sub

    Private Sub mostrar_Estadística()
        Dim sql As String = ""
        Dim tabla As New Data.DataTable


        sql &= "SELECT Insumo.descripcion,SUM( InsumoXIntervencion.cantidad_insumos) as cantidad"
        sql &= " FROM Insumo INNER JOIN"
        sql &= " InsumoXIntervencion ON Insumo.id_insumo = InsumoXIntervencion.id_insumo"
        sql &= " WHERE Insumo.habilitado = 1"
        sql &= " GROUP BY Insumo.descripcion"

        tabla = clase_auxiliar.ejecuto_sql(sql)

        Insumos_Mas_UsadosBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()

    End Sub

End Class