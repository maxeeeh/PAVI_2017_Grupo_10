Public Class frm_paciente

    Dim clase_Auxiliar As New Atributos_Compartidos

    Private Sub frm_paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        busar_Pacientes()
    End Sub

    Private Sub busar_Pacientes()
        Dim sql As String = ""
        sql &= "SELECT apellido +', '+ nombre AS nombre_apellido FROM Paciente WHERE habilitado = 1 "

        PacientesBindingSource.DataSource = clase_Auxiliar.ejecuto_sql(sql)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class