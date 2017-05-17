Public Class frm_registrar_insumo

    'En la siguiente linea se asigna automaticamente la cadena de conexion segun en que compu este (ayudandose con una clase)
    Dim clase_auxiliar As New Atributos_Compartidos
    Dim cadena_conexion As String = clase_auxiliar._cadena_conexion

    Dim descripcion_a_modificar As String = ""
    'Para saber si existe en la BD'
    Enum respuesta_validacion
        _existe
        _no_existe
        _existe_deshabilitado
    End Enum


    'Para saber si hay algun campo con informacion erronea'
    Enum respuesta_validacion_error
        _ok
        _error
    End Enum

    Private Sub cargar_lista()
        llenar_lista(clase_auxiliar.leo_tabla_soporte("Insumo"))
    End Sub

    Private Sub frm_registrar_insumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar_lista()
        lst_insumos.SelectedIndex = -1
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub insertar()
        Dim txt_insert As String = ""

        txt_insert &= "INSERT INTO Insumo ("
        txt_insert &= "descripcion)"
        txt_insert &= " VALUES ("
        txt_insert &= "'" & txt_descripcion.Text & "')"

        insertar_modificar_eliminar(txt_insert)
    End Sub

    Private Sub modificar()
        Dim txt_update As String = ""

        txt_update &= "UPDATE Insumo "
        txt_update &= "SET descripcion= '" & Me.txt_descripcion.Text & "', habilitado = 1"
        txt_update &= " WHERE descripcion='" & Me.descripcion_a_modificar & "'"

        insertar_modificar_eliminar(txt_update)
    End Sub

    Private Sub eliminar(ByVal id As Integer)
        Dim txt_delete As String = ""

        txt_delete &= "UPDATE Insumo"
        txt_delete &= " SET habilitado = 0"
        txt_delete &= " WHERE id_insumo = " & id

        insertar_modificar_eliminar(txt_delete)
    End Sub

    Private Sub insertar_modificar_eliminar(ByVal sql As String)
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub


    Private Function validar_datos() As respuesta_validacion_error
        If txt_descripcion.Text = "" Then
            MessageBox.Show("El campo descripcion esta vacio" & vbCrLf & "Debe proveer de una descripcion para el insumo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_descripcion.Focus()
            Return respuesta_validacion_error._error
        End If
        Return respuesta_validacion_error._ok
    End Function

    Private Function validar_insumos(ByVal descripcion) As respuesta_validacion
        Dim sql As String = ""
        sql &= "SELECT descripcion, habilitado "
        sql &= " FROM Insumo"
        sql &= " WHERE descripcion  = '" & descripcion & "'"

        Dim tabla As New DataTable

        tabla = Me.clase_auxiliar.ejecuto_sql(sql)

        For i As Integer = 0 To tabla.Rows.Count - 1
            If String.Compare(normalizar_texto(Me.txt_descripcion.Text), normalizar_texto(tabla(i)(0))) = 0 Then
                If tabla(i)(1) = True Then
                    Return respuesta_validacion._existe
                Else
                    descripcion_a_modificar = tabla(i)(0)
                    Return respuesta_validacion._existe_deshabilitado
                End If
            End If
        Next
        Return respuesta_validacion._no_existe

        'If tabla.Rows.Count = 0 Then
        '    Return respuesta_validacion._no_existe
        'Else
        '    Return respuesta_validacion._existe
        'End If
    End Function

    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click
        If validar_datos() = respuesta_validacion_error._ok Then
            Select Case validar_insumos(Me.txt_descripcion.Text)
                Case respuesta_validacion._no_existe
                    insertar()
                    Me.txt_descripcion.Text = ""
                    'clase_auxiliar.blanquear_campos(Me)
                    Me.cargar_lista()
                    MessageBox.Show("Se ha registrado el insumo correctamente")
                Case respuesta_validacion._existe_deshabilitado
                    Dim res As Integer = MessageBox.Show("Se ha detectado un insumo con la misma descipcion deshabilitado " & vbCrLf & "                                                 en la base de datos." & vbCrLf _
                                                         & "                                      ¿Desea habilitarlo nuevamente?", _
                                                         "Confirmacion", MessageBoxButtons.OKCancel)
                    If res = DialogResult.OK Then
                        modificar()
                        Me.txt_descripcion.Text = ""
                        'clase_auxiliar.blanquear_campos(Me)
                        Me.cargar_lista()
                        MessageBox.Show("   Se ha habilitado el insumo nuevamente")
                    End If
                Case respuesta_validacion._existe
                    MessageBox.Show("Se ha detectado un insumo con la misma descipcion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

            'If validar_insumos(Me.txt_descripcion.Text) = respuesta_validacion._no_existe Then
            '    insertar()
            '    MessageBox.Show("Se ha registrado el insumo correctamente")
            'Else
            '    MessageBox.Show("Se ha detectado un insumo con la misma descipcion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            'Me.cargar_lista()
            'txt_descripcion.Text = ""
        End If
    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        If lst_insumos.SelectedIndex = -1 Then

            MessageBox.Show("Debe seleccionar un insumo de la lista" _
                        , "ERROR" _
                        , MessageBoxButtons.OK _
                        , MessageBoxIcon.Error)

            Exit Sub
        End If

        Dim res As Integer = MessageBox.Show("                        Esta seguro?", "Confirmacion", MessageBoxButtons.OKCancel)
        If res = DialogResult.OK Then
            eliminar(lst_insumos.SelectedValue)
            cargar_lista()
            MessageBox.Show("Se ha eliminado el insumo correctamente" _
                            , "Informacion" _
                            , MessageBoxButtons.OK _
                            , MessageBoxIcon.Information)
            lst_insumos.SelectedIndex = -1
        End If
    End Sub

    Private Sub txt_filtro_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro.TextChanged
        Dim pattern As String = txt_filtro.Text
        Dim sql As String = ""

        Dim tabla As New Data.DataTable
        sql &= "SELECT *"
        sql &= " FROM Insumo"
        sql &= " WHERE habilitado = 1 AND descripcion LIKE '" & pattern & "%'"
        sql &= " ORDER BY descripcion ASC"
        llenar_lista(clase_auxiliar.ejecuto_sql(sql))
    End Sub

    Private Sub llenar_lista(ByVal tabla As DataTable)
        lst_insumos.DataSource = tabla
        lst_insumos.DisplayMember = "descripcion"
        lst_insumos.ValueMember = "id_insumo"
    End Sub

    Private Sub frm_registrar_insumo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'La siguiente linea usa el metodo "confirmar_salida" de la clase "Atributos_Compartidos" para
        'ver si el usuario cancelo el cerrado del formulario. (Le manda el evento de cerrado "e" al metodo)
        e.Cancel = clase_auxiliar.confirmar_salida(e)
    End Sub


    Private Function normalizar_texto(ByVal text As String) As String
        Dim text_normalized As String = text.ToLower()

        Dim vocalesSinAcento() As Char = "aeiou".ToCharArray()
        Dim vocalesConAcento() As Char = "áéíóú".ToCharArray()

        'For Each c As Char In text_normalized
        '    Select Case c
        '        Case "á"c
        '            text_normalized = text_normalized.Replace(c, "a"c)
        '        Case "é"c
        '            text_normalized = text_normalized.Replace(c, "e"c)
        '        Case "í"c
        '            text_normalized = text_normalized.Replace(c, "i"c)
        '        Case "ó"c
        '            text_normalized = text_normalized.Replace(c, "o"c)
        '        Case "ú"c
        '            text_normalized = text_normalized.Replace(c, "u"c)
        '    End Select
        'Next

        For index As Integer = 0 To vocalesSinAcento.GetUpperBound(0)
            text_normalized = text_normalized.Replace(vocalesConAcento(index), vocalesSinAcento(index))
        Next

        Return text_normalized

    End Function
End Class