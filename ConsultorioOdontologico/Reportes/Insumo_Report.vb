Public Class frm_insumo_report
    Dim clase_auxiliar As New Atributos_Compartidos


    Private Sub Insumo_Reporrt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filtro As String = " WHERE habilitado = 1"
        buscar_insumos(filtro)
    End Sub

    Private Sub buscar_insumos(ByVal filtro As String)
        Dim sql As String = ""
        sql &= "SELECT descripcion FROM Insumo" & filtro & " ORDER BY descripcion ASC"


        InsumosBindingSource.DataSource = clase_auxiliar.ejecuto_sql(sql)
        Me.rv_insumos.RefreshReport()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim filtro As String = ""

        For Each radio_button As Windows.Forms.RadioButton In grp_estado.Controls
            If radio_button.Checked = True Then
                If radio_button.Text = "Habilitados" Then
                    filtro = " WHERE habilitado = 1"
                    Exit For
                Else
                    filtro = " WHERE habilitado = 0"
                    Exit For
                End If
            End If
        Next
        buscar_insumos(filtro)
    End Sub

    Private Sub frm_insumo_report_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'La siguiente linea usa el metodo "confirmar_salida" de la clase "Atributos_Compartidos" para
        'ver si el usuario cancelo el cerrado del formulario. (Le manda el evento de cerrado "e" al metodo)
        e.Cancel = clase_auxiliar.confirmar_salida(e)
    End Sub
End Class