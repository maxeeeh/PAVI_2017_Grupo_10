Public Class frm_turnos

    'En la siguiente linea se asigna automaticamente la cadena de conexion segun en que compu este (ayudandose con una clase)
    Dim clase_auxiliar As New Atributos_Compartidos
    Dim cadena_conexion As String = clase_auxiliar._cadena_conexion

    Private Sub frm_turnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_turnos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'La siguiente linea usa el metodo "confirmar_salida" de la clase "Atributos_Compartidos" para
        'ver si el usuario cancelo el cerrado del formulario. (Le manda el evento de cerrado "e" al metodo)
        e.Cancel = (New Atributos_Compartidos).confirmar_salida(e)
    End Sub
End Class