Public Class Factura
    Dim clase_auxiliar As New Atributos_Compartidos
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        clase_auxiliar.cargar_combobox(cmb_pacientes, tabla_para_combo("Paciente"))

    End Sub

   

    Private Function tabla_para_combo(ByVal nombre_tabla As String) As DataTable ' el parametro puede ser "Empleado" o "Paciente"
        'Esta funcion da una tabla con 2 columnas: la primera es el id_paciente o id_empleado, y la segunda el apellido y nombre concatenados

        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        'En el select hace id_empleado o id_paciente, y despues concatena asi: "Apellido, Nombre"
        sql &= "SELECT id_" & nombre_tabla.ToLower() & ", apellido + ', ' + nombre"
        sql &= " FROM " & nombre_tabla
        sql &= " WHERE habilitado = 1"
        sql &= " ORDER BY apellido"
        tabla = clase_auxiliar.ejecuto_sql(sql)

       

        Return tabla

    End Function
End Class