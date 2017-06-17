Public Class frm_registrar_tratamiento

    'En la siguiente linea se asigna automaticamente la cadena de conexion segun en que compu este (ayudandose con una clase)
    Dim clase_auxiliar As New Atributos_Compartidos
    Dim cadena_conexion As String = clase_auxiliar._cadena_conexion

    Dim descripcion_a_modificar As String = ""

    Enum tipo_grabacion
        insertar
        modificar
    End Enum


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

    Dim accion As tipo_grabacion = tipo_grabacion.insertar

    Private Sub frm_registrar_tratamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd_eliminar.Enabled = True
        cargar_grilla()
        cmd_registrar.Enabled = False
        txt_costo.Enabled = False
        txt_descripcion.Enabled = False


    End Sub

    Private Sub cargar_grilla()
        llenar_grilla(clase_auxiliar.leo_tabla_soporte("Tratamiento"))
    End Sub

    'Se controla que los campos no esten vacios
    Private Function validar_datos() As respuesta_validacion_error

        Dim message_str As String = "Se encuentran los siguientes errores:"
        Dim libre_de_error As Boolean = True

        If txt_costo.Text.Replace(" ", "") = "," Then
            libre_de_error = False
            message_str &= vbCrLf & "El campo costo esta vacio"
        End If

        If txt_descripcion.Text = "" Then

            libre_de_error = False
            message_str &= vbCrLf & "El campo decripcion esta vacio"
        Else
            For Each c As Char In txt_descripcion.Text
                If (IsNumeric(c)) Then
                    libre_de_error = False
                    message_str &= vbCrLf & "Descripcion de tratamiento incorrecta. No debe contener numeros"
                    Exit For
                End If
            Next
        End If



        If libre_de_error = True Then
            Return respuesta_validacion_error._ok
        Else
            MessageBox.Show(message_str, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return respuesta_validacion_error._error
        End If

    End Function

    'Se valida que no exista un tratamiento con la misma descripcion
    Private Function validar_tratamientos(ByVal desc As String) As respuesta_validacion
        Dim sql As String = ""
        sql &= "SELECT descripcion, habilitado "
        sql &= " FROM Tratamiento"
        'sql &= " WHERE descripcion  = '" & desc & "'"

        Dim tabla As New DataTable

        tabla = clase_auxiliar.ejecuto_sql(sql)

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


    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


    Private Sub habilitar_controles()
        cmd_eliminar.Enabled = True
        txt_descripcion.Enabled = True
        txt_costo.Enabled = True
        cmd_registrar.Enabled = True
    End Sub

    Private Sub limpiar_campos()
        txt_descripcion.Text = ""
        txt_costo.Text = ""
        txt_filtro_descripcion.Text = ""
    End Sub




    Private Sub eliminar(ByVal id)
        Dim txt_delete As String = ""

        txt_delete &= "UPDATE Tratamiento"
        txt_delete &= " SET habilitado = 0"
        txt_delete &= " WHERE id_tratamiento = '" & id & "'"

        insertar_modificar_eliminar(txt_delete)
    End Sub

    Private Sub insertar()

        'MessageBox.Show(CDec(Me.txt_costo.Text.Trim()))

        Dim txt_insert As String = ""

        txt_insert &= "INSERT INTO Tratamiento ("
        txt_insert &= "descripcion"
        txt_insert &= ", costo)"
        txt_insert &= " VALUES ("
        txt_insert &= "'" & Me.txt_descripcion.Text & "'"
        'Dim dec As String = Me.txt_costo.Text.Substring(5)
        'Dim ent As String = Me.txt_costo.Text.Substring(0, 5)




        'If dec.Length = 0 Then
        '    dec = "00"
        'Else
        '    If dec.Length = 1 Then
        '        dec = dec & "0"
        '    Else
        '        dec = dec.Replace(" ", "0")
        '    End If
        'End If



        'txt_insert &= ", '" & ent & dec & "')"
        txt_insert &= ", " & Me.txt_costo.Text.Replace(",", ".") & "')"


        insertar_modificar_eliminar(txt_insert)

    End Sub




    Private Sub modificar(ByVal habilitar As Boolean)
        Dim txt_update As String = ""

        txt_update &= "UPDATE Tratamiento "
        txt_update &= "SET costo= '" & Me.txt_costo.Text.Replace(",", ".") & "'"
        If habilitar Then
            txt_update &= ", descripcion = '" & Me.txt_descripcion.Text & "'"
            txt_update &= ", habilitado = 1"
            txt_update &= " WHERE descripcion='" & Me.descripcion_a_modificar & "'"
        Else
            txt_update &= " WHERE descripcion='" & Me.txt_descripcion.Text & "'"
        End If


        insertar_modificar_eliminar(txt_update)
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



    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        habilitar_controles()
        clase_auxiliar.blanquear_campos(Me)
        Me.lbl_costo_anterior.Visible = False
        Me.accion = tipo_grabacion.insertar
        Me.txt_descripcion.Focus()
    End Sub

    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click

        If validar_datos() = respuesta_validacion_error._ok Then
            If Me.accion = tipo_grabacion.insertar Then
                Select Case validar_tratamientos(Me.txt_descripcion.Text)
                    Case respuesta_validacion._no_existe
                        insertar()
                        clase_auxiliar.blanquear_campos(Me)
                        Me.cargar_grilla()
                        MessageBox.Show("Se ha registrado el tratamiento correctamente")
                    Case respuesta_validacion._existe_deshabilitado
                        Dim res As Integer = MessageBox.Show("Se ha detectado un tratamiento con la misma descipcion deshabilitado " & vbCrLf & "                                                 en la base de datos." & vbCrLf _
                                                             & "                                      ¿Desea habilitarlo nuevamente?", _
                                                             "Confirmacion", MessageBoxButtons.OKCancel)
                        If res = DialogResult.OK Then
                            modificar(True)
                            clase_auxiliar.blanquear_campos(Me)
                            Me.cargar_grilla()
                            MessageBox.Show("   Se ha habilitado el tratamiento nuevamente")
                        End If
                    Case respuesta_validacion._existe
                        MessageBox.Show("Se ha detectado un tratamiento con la misma descipcion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
                'If validar_tratamientos(txt_descripcion.Text) = respuesta_validacion._no_existe Then
                '    insertar()
                '    MessageBox.Show("Se ha registrado el tratamiento correctamente")
                '    cargar_grilla()
                '    limpiar_campos()
                'Else
                '    MessageBox.Show("Se ha detectado un tratamiento con la misma descripcion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If

            Else
                If validar_datos() = respuesta_validacion_error._ok Then
                    modificar(False)
                    Me.lbl_costo_anterior.Visible = False
                    habilitar_controles()
                    clase_auxiliar.blanquear_campos(Me)
                    accion = tipo_grabacion.insertar
                    cargar_grilla()
                    MessageBox.Show("Se ha modificado el tratamiento correctamente")
                End If
            End If
        End If

    End Sub

    Private Sub cmd_eliminar_fila_seleccionada_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click


        If grid_tratamientos.CurrentCell.Selected = False Then

            MessageBox.Show("Debe seleccionar una fila de la grilla" _
                        , "ERROR" _
                        , MessageBoxButtons.OK _
                        , MessageBoxIcon.Error)

            Exit Sub
        End If

        Dim res As Integer = MessageBox.Show(" Esta seguro?", "Confirmacion", MessageBoxButtons.OKCancel)
        If res = DialogResult.OK Then
            'el 0 representa la posicion de la columna por la cual tomo el valor en este caso elimino por id
            'que esta en la posicion 0 
            Dim txt_delete As String = ""

            txt_delete &= "UPDATE Tratamiento"
            txt_delete &= " SET habilitado = 0"
            txt_delete &= " WHERE id_tratamiento= " & Me.grid_tratamientos.CurrentRow.Cells(0).Value

            insertar_modificar_eliminar(txt_delete)
            Me.lbl_costo_anterior.Visible = False
            cargar_grilla()
            MessageBox.Show("Se ha eliminado el tratamiento correctamente" _
                            , "Informacion" _
                            , MessageBoxButtons.OK _
                            , MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub llenar_form_click_en_grid()
        txt_descripcion.Text = Me.grid_tratamientos.CurrentRow.Cells(1).Value
        Me.lbl_costo_anterior.Text = "Costo anterior: $ " & Me.grid_tratamientos.CurrentRow.Cells(2).Value
        Me.lbl_costo_anterior.Visible = True
        'txt_costo.Text = Me.grid_tratamientos.CurrentRow.Cells(2).Value

        accion = tipo_grabacion.modificar
        habilitar_controles()
        txt_descripcion.Enabled = False
    End Sub

    Private Sub grid_tratamientos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grid_tratamientos.RowHeaderMouseClick
        llenar_form_click_en_grid()
    End Sub

    Private Sub dgv_tratamientos_CellClick(sender As Object, e As EventArgs) Handles grid_tratamientos.CellClick
        llenar_form_click_en_grid()
    End Sub

    Private Sub llenar_grilla(ByVal tabla As DataTable)

        Dim c As Integer

        Me.grid_tratamientos.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            grid_tratamientos.Rows.Add()
            grid_tratamientos.Rows(c).Cells(0).Value = tabla.Rows(c)("id_tratamiento")
            grid_tratamientos.Rows(c).Cells(1).Value = tabla.Rows(c)("descripcion")
            grid_tratamientos.Rows(c).Cells(2).Value = tabla.Rows(c)("costo")



        Next
    End Sub

    Private Sub txt_filtro_descripcion_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro_descripcion.TextChanged
        Dim pattern As String = txt_filtro_descripcion.Text
        Dim sql As String = ""

        Dim tabla As New Data.DataTable

        sql &= " SELECT *"
        sql &= " FROM     Tratamiento"
        sql &= " WHERE habilitado = 1 AND descripcion LIKE '" & pattern & "%'"
        sql &= " OR descripcion LIKE '%" & pattern & "%'"
        sql &= " ORDER BY descripcion ASC"

        tabla = clase_auxiliar.ejecuto_sql(sql)
        llenar_grilla(tabla)
    End Sub



    Private Sub frm_registrar_tratamiento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
