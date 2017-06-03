Public Class Insumo_Reporrt
    Dim clase_Auxiliar As New Atributos_Compartidos

    Private Sub Insumo_Reporrt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        busar_Insumo()


    End Sub

    Private Sub busar_Insumo()
        Dim sql As String = ""
        sql &= "SELECT descripcion FROM Insumo WHERE habilitado = 1 "

        InsumosBindingSource.DataSource = clase_Auxiliar.ejecuto_sql(sql)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class