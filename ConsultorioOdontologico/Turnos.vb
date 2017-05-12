Public Class frm_turnos

    'En la siguiente linea se asigna automaticamente la cadena de conexion segun en que compu este (ayudandose con una clase)
    Dim cadena_conexion As String = (New Cadena_Conexion)._cadena_conexion

    Private Sub frm_turnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Asigna la cadena de conexion segun la compu actual (por el tema de Git y eso)
        Select Case Environment.UserName
            Case "Luciano" 'Lucho
                cadena_conexion = "Provider=SQLNCLI11;Data Source=LAPATOP\LUCIANOSQL;User ID=Luciano;Initial Catalog=ConsultorioOdontologicoBD;Password=Luciano"
            Case "NOTEBOOK" 'maxeeeh
                cadena_conexion = "Provider=SQLNCLI11;Data Source=BGH\MORILLASSQL;User ID=Morillas;Initial Catalog=ConsultorioOdontologicoBD;password=Morillas"
        End Select



    End Sub


    Private Sub frm_turnos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("          ¿Esta seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class