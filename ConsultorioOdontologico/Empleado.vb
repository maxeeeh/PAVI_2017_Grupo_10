Public Class frm_registrar_empleado

    'La siguiente linea asigna dinamicamente en Load dependiendo en que maquina este (ayudandose con una clase)
    Dim cadena_conexion As String = (New Cadena_Conexion)._cadena_conexion

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    'Para saber si existe en la BD'
    Enum respuesta_validacion
        _existe
        _no_existe
    End Enum

    'Para saber si hay algun campo con informacion erronea'
    Enum respuesta_validacion_error
        _ok
        _error
    End Enum

    Dim accion As tipo_grabacion = tipo_grabacion.insertar

    Private Sub frm_registrar_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar_grilla()
        cargar_combo(cmb_loc _
                     , leo_tabla("Localidad") _
                     , "id_localidad" _
                     , "descripcion")
        cargar_combo(cmb_cargo _
                     , leo_tabla("Cargo") _
                     , "id_cargo" _
                     , "descripcion")

        Dim tabla As New Data.DataTable
        tabla = leo_tabla("Cargo")
        cargar_combo(cmb_filtro_cargo _
                     , tabla _
                     , "id_cargo" _
                     , "descripcion")

    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New Data.DataTable


        Dim sql As String = ""
        sql &= " SELECT   E.apellido"
        sql &= "          , E.nombre"
        sql &= "          , E.cuil"
        sql &= "          , C.id_cargo"
        sql &= "          , C.descripcion"
        sql &= "          , E.fecha_nacimiento"
        sql &= "          , E.telefono"
        sql &= "          , E.celular"
        sql &= "          , E.id_localidad"
        sql &= "          , E.calle"
        sql &= "          , E.nro_calle"
        sql &= "          , E.piso"
        sql &= "          , E.departamento"
        sql &= "          , E.hora_ingreso"
        sql &= "          , E.hora_egreso"
        sql &= " FROM     Empleado E JOIN cargo C"
        sql &= " ON       E.id_cargo = C.id_cargo"
        sql &= " WHERE E.habilitado = 1"
        sql &= " ORDER BY E.apellido ASC"


        tabla = ejecuto_sql(sql)

        llenar_grilla(tabla)
    End Sub


    'Lee una tabla de base de datos y devuelve su contenido en un DataTable'
    Private Function leo_tabla(ByVal nombre_tabla As String) As DataTable
        Return ejecuto_sql("SELECT * FROM " & nombre_tabla)
    End Function

    Private Function ejecuto_sql(ByVal sql As String) As DataTable
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function

    Private Sub cargar_combo(ByRef combo As ComboBox _
                             , ByVal tabla As DataTable _
                             , ByVal pk As String _
                             , ByVal descriptor As String)

        'Origen de los datos'
        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        habilitar_controles()
        limpiar_campos()


        Me.accion = tipo_grabacion.insertar

        Me.txt_ape.Focus()
    End Sub





    Private Function validar_datos() As respuesta_validacion_error
        Dim message_str As String = "Se encuentran los siguientes errores:"
        Dim libre_de_error As Boolean = True
        If txt_ape.Text = "" Then
            libre_de_error = False
            message_str &= vbCrLf & "El campo apellido esta vacio."
        End If

        If txt_nom.Text = "" Then
            libre_de_error = False
            message_str &= vbCrLf & "El campo nombre esta vacio"
        End If

        If txt_cuil.Text.Length < 13 Then
            libre_de_error = False
            message_str &= vbCrLf & "El campo CUIL debe contener 11 digitos"
        End If

        If (Date.Today.Year - dtp_fecha_nac.Value.Year) < 18 Then
            libre_de_error = False
            message_str &= vbCrLf & "El empleado a registrar debe tener como minimo 18 años"
        End If

        If (txt_telefono.Text = "" And txt_celular.Text = "") Then
            libre_de_error = False
            message_str &= vbCrLf & "Se debe registrar al menos un numero de contacto"
        End If

        If (txt_telefono.Text.Length > 0 And txt_telefono.Text.Length < 7) Then
            libre_de_error = False
            message_str &= vbCrLf & "Numero telefonico incorrecto. Debe contener al menos 7 digitos"
        End If

        If txt_telefono.Text.Length > 0 Then
            For Each c As Char In txt_telefono.Text
                If Not (IsNumeric(c)) Then
                    libre_de_error = False
                    message_str &= vbCrLf & "Numero telefonico incorrecto. No debe contener letras"
                    Exit For
                End If
            Next
        End If

        If (txt_celular.Text.Length > 0 And txt_celular.Text.Length < 8) Then
            libre_de_error = False
            message_str &= vbCrLf & "Numero de celular incorrecto. Debe contener al menos 2 digitos de codigo de area y 6 digitos de numero de celular"
        End If

        If txt_celular.Text.Length > 0 Then
            For Each c As Char In txt_celular.Text
                If Not (IsNumeric(c)) Then
                    libre_de_error = False
                    message_str &= vbCrLf & "Numero de celular incorrecto. No debe contener letras o simbolos"
                    Exit For
                End If
            Next
        End If

        If txt_calle.Text = "" Then
            libre_de_error = False
            message_str &= vbCrLf & "El campo calle esta vacio"
        End If

        If txt_nro_calle.Text = "" Then
            libre_de_error = False
            message_str &= vbCrLf & "El campo numero calle esta vacio"
        Else
            For Each c As Char In txt_nro_calle.Text
                If Not (IsNumeric(c)) Then
                    libre_de_error = False
                    message_str &= vbCrLf & "El campo numero calle no debe contener letras o simbolos"
                    Exit For
                End If
            Next
        End If

        If cmb_loc.SelectedIndex = -1 Then
            libre_de_error = False
            message_str &= vbCrLf & "El campo localidad esta sin seleccion"
        End If

        If txt_piso.Text.Length > 0 Then
            For Each c As Char In txt_piso.Text
                If Not (IsNumeric(c)) Then
                    libre_de_error = False
                    message_str &= vbCrLf & "El campo piso no debe contener letras o simbolos"
                    Exit For
                End If
            Next
            If txt_depto.Text = "" And Not (String.Compare(txt_piso.Text, "0") = 0) Then
                libre_de_error = False
                message_str &= vbCrLf & "Debe especificar cual es el departamento"
            End If
        End If

        If txt_depto.Text.Length > 0 Then
            If txt_piso.Text = "" Then
                libre_de_error = False
                message_str &= vbCrLf & "Debe especificar cual es el piso"
            Else
                For Each c As Char In txt_piso.Text
                    If Not (IsNumeric(c)) And Not (String.Compare(txt_piso.Text, "0") = 0) Then
                        libre_de_error = False
                        message_str &= vbCrLf & "El campo piso no debe contener letras o simbolos"
                        Exit For
                    End If
                Next
            End If

        End If

        If cmb_cargo.SelectedIndex = -1 Then
            libre_de_error = False
            message_str &= vbCrLf & "El campo cargo esta sin seleccion"
        End If

        If txt_hora_ingreso.Text.Length < 5 Then
            libre_de_error = False
            message_str &= vbCrLf & "Debe especificar una hora de ingreso completa (00hs : 00min)"
        End If

        If txt_hora_egreso.Text.Length < 5 Then
            libre_de_error = False
            message_str &= vbCrLf & "Debe especificar una hora de egreso completa (00hs : 00min)"
        End If

        If libre_de_error = True Then
            Return respuesta_validacion_error._ok
        Else
            MessageBox.Show(message_str, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return respuesta_validacion_error._error
        End If

    End Function

    Private Function validar_empleados(ByVal cuil) As respuesta_validacion
        Dim sql As String = ""
        sql &= "SELECT cuil "
        sql &= " FROM Empleado"
        sql &= " WHERE cuil  = '" & cuil & "'"

        Dim tabla As New DataTable

        tabla = Me.ejecuto_sql(sql)

        If tabla.Rows.Count = 0 Then
            Return respuesta_validacion._no_existe
        Else
            Return respuesta_validacion._existe
        End If
    End Function


    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click
        If validar_datos() = respuesta_validacion_error._ok Then
            If Me.accion = tipo_grabacion.insertar Then
                If validar_empleados(Me.txt_cuil.Text) = respuesta_validacion._no_existe Then
                    insertar()
                    limpiar_campos()
                    MessageBox.Show("Se ha registrado el empleado correctamente")
                Else
                    MessageBox.Show("Se ha detectado un empleado con el mismo numero de cuil", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                If validar_datos() = respuesta_validacion_error._ok Then
                    If validar_empleados(txt_cuil.Text) = respuesta_validacion._existe Then
                        modificar()
                        MessageBox.Show("Se ha modificado el empleado correctamente")
                        habilitar_controles()
                        limpiar_campos()
                        accion = tipo_grabacion.insertar
                    Else
                        MessageBox.Show("Se ha detectado que el empleado no existe en la base de datos. Compruebe que haya escrito correctamente el CUIL del empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Complete los campos con la informacion correcta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
            Me.cargar_grilla()
            'Else
            'MessageBox.Show("Complete los campos con la informacion correcta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub habilitar_controles()
        txt_ape.Enabled = True
        txt_nom.Enabled = True
        dtp_fecha_nac.Enabled = True
        txt_telefono.Enabled = True
        txt_celular.Enabled = True
        txt_calle.Enabled = True
        txt_nro_calle.Enabled = True
        txt_piso.Enabled = True
        txt_depto.Enabled = True
        cmb_loc.Enabled = True
        cmb_cargo.Enabled = True
        txt_hora_ingreso.Enabled = True
        txt_hora_egreso.Enabled = True
        cmd_registrar.Enabled = True
        'cmd_registrar.Text = "Registrar"
    End Sub

    Private Sub limpiar_campos()
        'For Each obj As Windows.Forms.Control In Me.Controls
        '    If TypeOf obj Is TextBox Then
        '        obj.Text = ""
        '    End If

        '    If TypeOf obj Is MaskedTextBox Then
        '        obj.Text = ""
        '    End If

        '    If TypeOf obj Is ComboBox Then
        '        Dim local As ComboBox = obj
        '        local.SelectedIndex = -1
        '    End If
        'Next

        For Each obj As Windows.Forms.Control In Me.grp_datos_personales.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If

            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
            End If
        Next

        For Each obj As Windows.Forms.Control In Me.grp_domicilio.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If

            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
            End If
        Next

        For Each obj As Windows.Forms.Control In Me.grp_datos_laborales.Controls
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
            End If

            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
            End If
        Next
    End Sub

    Private Sub cmd_eliminar_por_cuil_Click(sender As Object, e As EventArgs) Handles cmd_eliminar_por_cuil.Click

        If validar_empleados(Me.txt_cuil.Text) = respuesta_validacion._existe Then
            If buscar_empleado_y_llenar_formulario() Then
                Dim res As Integer = MessageBox.Show("                        Esta seguro?", "Confirmacion", MessageBoxButtons.OKCancel)
                If res = DialogResult.OK Then
                    eliminar(Me.txt_cuil.Text)

                    Me.cargar_grilla()
                    accion = tipo_grabacion.insertar
                    habilitar_controles()
                    MessageBox.Show("Se ha eliminado el empleado correctamente" _
                                , "Informacion" _
                                , MessageBoxButtons.OK _
                                , MessageBoxIcon.Information)
                Else
                    accion = tipo_grabacion.modificar
                    habilitar_controles()
                    Me.dtp_fecha_nac.Enabled = False
                    cmb_cargo.Enabled = False
                End If
            End If

        Else
            MessageBox.Show("Se ha detectado que el empleado no existe en la base de datos" _
                        , "ERROR" _
                        , MessageBoxButtons.OK _
                        , MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub cmd_eliminar_fila_seleccionada_Click(sender As Object, e As EventArgs)

        If grid_empleados.CurrentCell.Selected = False Then

            MessageBox.Show("Debe seleccionar una fila de la grilla" _
                        , "ERROR" _
                        , MessageBoxButtons.OK _
                        , MessageBoxIcon.Error)

            Exit Sub
        End If

        Dim res As Integer = MessageBox.Show("                        Esta seguro?", "Confirmacion", MessageBoxButtons.OKCancel)
        If res = DialogResult.OK Then
            eliminar(Me.grid_empleados.CurrentRow.Cells(2).Value)
            cargar_grilla()
            MessageBox.Show("Se ha eliminado el empleado correctamente" _
                            , "Informacion" _
                            , MessageBoxButtons.OK _
                            , MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub insertar()
        Dim txt_insert As String = ""

        txt_insert &= "INSERT INTO Empleado ("
        txt_insert &= "nombre"
        txt_insert &= ", apellido"
        txt_insert &= ", cuil"
        txt_insert &= ", fecha_nacimiento"
        txt_insert &= ", telefono"
        txt_insert &= ", celular"
        txt_insert &= ", id_localidad"
        txt_insert &= ", calle"
        txt_insert &= ", nro_calle"
        txt_insert &= ", piso"
        txt_insert &= ", departamento"
        txt_insert &= ", id_cargo"
        txt_insert &= ", hora_ingreso"
        txt_insert &= ", hora_egreso"
        txt_insert &= ", habilitado)"
        txt_insert &= " VALUES ("
        txt_insert &= "'" & Me.txt_nom.Text & "'"
        txt_insert &= ", '" & Me.txt_ape.Text & "'"
        txt_insert &= ", '" & Me.txt_cuil.Text & "'"
        txt_insert &= ", '" & Format(Me.dtp_fecha_nac.Value, "yyyy-MM-dd") & "'"

        If txt_telefono.Text = "" Then
            txt_insert &= ", ''"
        Else
            txt_insert &= ", '" & Me.txt_telefono.Text & "'"
        End If
        If txt_celular.Text = "" Then
            txt_insert &= ", ''"
        Else
            txt_insert &= ", '" & Me.txt_celular.Text & "'"
        End If

        txt_insert &= ", " & Me.cmb_loc.SelectedValue
        txt_insert &= ", '" & Me.txt_calle.Text & "'"
        txt_insert &= ", " & Me.txt_nro_calle.Text

        If txt_piso.Text = "" Then
            txt_insert &= ", 0"
        Else
            txt_insert &= ", " & Me.txt_piso.Text
        End If
        If txt_depto.Text = "" Then
            txt_insert &= ", ''"
        Else
            txt_insert &= ", '" & Me.txt_depto.Text & "'"
        End If

        txt_insert &= ", " & Me.cmb_cargo.SelectedValue
        txt_insert &= ", '" & Me.txt_hora_ingreso.Text & "'"
        txt_insert &= ", '" & Me.txt_hora_egreso.Text & "'"
        txt_insert &= ", 1)"

        insertar_modificar_eliminar(txt_insert)
    End Sub


    Private Sub eliminar(ByVal cuil As String)
        Dim txt_delete As String = ""

        txt_delete &= "UPDATE Empleado"
        txt_delete &= " SET habilitado = 0"
        txt_delete &= " WHERE cuil = '" & cuil & "'"

        insertar_modificar_eliminar(txt_delete)
    End Sub

    Private Sub modificar()
        Dim txt_update As String = ""

        txt_update &= "UPDATE Empleado "
        txt_update &= "SET nombre = '" & txt_nom.Text & "'"
        txt_update &= " ,apellido = '" & txt_ape.Text & "'"

        If txt_telefono.Text = "" Then
            txt_update &= ",telefono = ''"
        Else
            txt_update &= ",telefono = '" & Me.txt_telefono.Text & "'"
        End If

        If txt_celular.Text = "" Then
            txt_update &= ",celular = ''"
        Else
            txt_update &= ",celular = '" & Me.txt_celular.Text & "'"
        End If

        'txt_update &= " ,telefono = '" & txt_telefono.Text & "'"
        'txt_update &= " ,celular = '" & txt_celular.Text & "'"


        txt_update &= " ,id_localidad = " & cmb_loc.SelectedIndex + 1
        txt_update &= " ,calle = '" & txt_calle.Text & "'"
        txt_update &= " ,nro_calle = " & txt_nro_calle.Text

        If txt_piso.Text = "" Then
            txt_update &= ",piso = 0"
        Else
            txt_update &= ",piso = " & Me.txt_piso.Text
        End If

        If txt_depto.Text = "" Then
            txt_update &= ",departamento = ''"
        Else
            txt_update &= ",departamento = '" & Me.txt_depto.Text & "'"
        End If

        'txt_update &= " ,piso = " & txt_piso.Text
        'txt_update &= " ,departamento = '" & txt_depto.Text & "'"


        txt_update &= " ,hora_ingreso = '" & txt_hora_ingreso.Text & "'"
        txt_update &= " ,hora_egreso = '" & txt_hora_egreso.Text & "'"
        txt_update &= " WHERE cuil = '" & txt_cuil.Text & "'"





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

    Private Function buscar_empleado_y_llenar_formulario() As Boolean
        Dim encontrado As Boolean = False

        For c = 0 To (grid_empleados.Rows.Count - 1)
            If String.Compare(grid_empleados.Rows(c).Cells(2).Value, txt_cuil.Text, False) = 0 Then

                llenar_formulario(c)

                encontrado = True
                Exit For

            End If
        Next

        Return encontrado
    End Function

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        If txt_cuil.Text.Length < 13 Then
            MessageBox.Show("El campo CUIL debe contener 13 digitos, el cual incluye los 2 (dos) guiones. Ejemplo: 00-00000000-0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_cuil.Focus()
            Exit Sub
        End If

        If buscar_empleado_y_llenar_formulario() = True Then
            accion = tipo_grabacion.modificar
            habilitar_controles()
            dtp_fecha_nac.Enabled = False
            cmb_cargo.Enabled = False
        Else
            MessageBox.Show("No se ha encontrado ningun empleado con el CUIL especificado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub llenar_formulario(row As Integer)

        txt_nom.Text = grid_empleados.Rows(row).Cells(0).Value
        txt_ape.Text = grid_empleados.Rows(row).Cells(1).Value
        txt_cuil.Text = grid_empleados.Rows(row).Cells(2).Value
        cmb_cargo.SelectedIndex = grid_empleados.Rows(row).Cells(4).Value - 1
        'Dim dt As DateTime = DateTime.ParseExact(grid_empleados.Rows(row).Cells(5).Value, "dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture)
        dtp_fecha_nac.Value = grid_empleados.Rows(row).Cells(5).Value
        txt_telefono.Text = grid_empleados.Rows(row).Cells(6).Value
        txt_celular.Text = grid_empleados.Rows(row).Cells(7).Value
        cmb_loc.SelectedIndex = grid_empleados.Rows(row).Cells(8).Value - 1
        txt_calle.Text = grid_empleados.Rows(row).Cells(9).Value
        txt_nro_calle.Text = grid_empleados.Rows(row).Cells(10).Value
        txt_piso.Text = grid_empleados.Rows(row).Cells(11).Value
        txt_depto.Text = grid_empleados.Rows(row).Cells(12).Value
        txt_hora_ingreso.Text = grid_empleados.Rows(row).Cells(13).Value
        txt_hora_egreso.Text = grid_empleados.Rows(row).Cells(14).Value

    End Sub

    Private Sub llenar_form_click_en_grid()
        llenar_formulario(grid_empleados.CurrentRow.Index)

        accion = tipo_grabacion.modificar
        habilitar_controles()
        dtp_fecha_nac.Enabled = False
        cmb_cargo.Enabled = False
    End Sub

    Private Sub grid_empleados_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grid_empleados.RowHeaderMouseClick
        llenar_form_click_en_grid()
    End Sub

    Private Sub txt_filtro_nombre_apellido_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro_nombre_apellido.TextChanged
        Dim pattern As String = txt_filtro_nombre_apellido.Text
        Dim sql As String = ""

        Dim tabla As New Data.DataTable

        sql &= " SELECT   E.apellido"
        sql &= "          , E.nombre"
        sql &= "          , E.cuil"
        sql &= "          , C.id_cargo"
        sql &= "          , C.descripcion"
        sql &= "          , E.fecha_nacimiento"
        sql &= "          , E.telefono"
        sql &= "          , E.celular"
        sql &= "          , E.id_localidad"
        sql &= "          , E.calle"
        sql &= "          , E.nro_calle"
        sql &= "          , E.piso"
        sql &= "          , E.departamento"
        sql &= "          , E.hora_ingreso"
        sql &= "          , E.hora_egreso"
        sql &= " FROM     Empleado E JOIN cargo C"
        sql &= " ON       E.id_cargo = C.id_cargo"
        sql &= " WHERE E.habilitado = 1"
        If cmb_filtro_cargo.Enabled = True Then
            sql &= " AND E.id_cargo = " & (cmb_filtro_cargo.SelectedValue)
        End If
        sql &= " AND (CONCAT(E.apellido, ' ', E.nombre) LIKE '" & pattern & "%'"
        sql &= " OR CONCAT(E.nombre, ' ', E.apellido) LIKE '" & pattern & "%')"

        tabla = ejecuto_sql(sql)
        llenar_grilla(tabla)

    End Sub

    Private Sub llenar_grilla(ByVal tabla As DataTable)
        Dim c As Integer

        Me.grid_empleados.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            grid_empleados.Rows.Add()
            grid_empleados.Rows(c).Cells(0).Value = tabla.Rows(c)("nombre")
            grid_empleados.Rows(c).Cells(1).Value = tabla.Rows(c)("apellido")
            grid_empleados.Rows(c).Cells(2).Value = tabla.Rows(c)("cuil")
            grid_empleados.Rows(c).Cells(3).Value = tabla.Rows(c)("descripcion")
            grid_empleados.Rows(c).Cells(4).Value = tabla.Rows(c)("id_cargo")
            grid_empleados.Rows(c).Cells(5).Value = tabla.Rows(c)("fecha_nacimiento")
            grid_empleados.Rows(c).Cells(6).Value = tabla.Rows(c)("telefono")
            grid_empleados.Rows(c).Cells(7).Value = tabla.Rows(c)("celular")
            grid_empleados.Rows(c).Cells(8).Value = tabla.Rows(c)("id_localidad")
            grid_empleados.Rows(c).Cells(9).Value = tabla.Rows(c)("calle")
            grid_empleados.Rows(c).Cells(10).Value = tabla.Rows(c)("nro_calle")
            grid_empleados.Rows(c).Cells(11).Value = tabla.Rows(c)("piso")
            grid_empleados.Rows(c).Cells(12).Value = tabla.Rows(c)("departamento")
            grid_empleados.Rows(c).Cells(13).Value = tabla.Rows(c)("hora_ingreso")
            grid_empleados.Rows(c).Cells(14).Value = tabla.Rows(c)("hora_egreso")

        Next
    End Sub

    Private Sub chk_filtro_cargo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_filtro_cargo.CheckedChanged
        If cmb_filtro_cargo.Enabled = False Then
            cmb_filtro_cargo.Enabled = True
            cmb_filtro_cargo_SelectedIndexChanged(sender, e)
        Else
            cmb_filtro_cargo.Enabled = False
            cargar_grilla()
        End If
    End Sub

    Private Sub cmb_filtro_cargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filtro_cargo.SelectedIndexChanged
        Dim sql As String = ""

        Dim tabla As New Data.DataTable

        sql &= " SELECT   E.apellido"
        sql &= "          , E.nombre"
        sql &= "          , E.cuil"
        sql &= "          , C.id_cargo"
        sql &= "          , C.descripcion"
        sql &= "          , E.fecha_nacimiento"
        sql &= "          , E.telefono"
        sql &= "          , E.celular"
        sql &= "          , E.id_localidad"
        sql &= "          , E.calle"
        sql &= "          , E.nro_calle"
        sql &= "          , E.piso"
        sql &= "          , E.departamento"
        sql &= "          , E.hora_ingreso"
        sql &= "          , E.hora_egreso"
        sql &= " FROM     Empleado E JOIN cargo C"
        sql &= " ON       E.id_cargo = C.id_cargo"
        sql &= " WHERE E.habilitado = 1"
        If cmb_filtro_cargo.Enabled = True Then
            sql &= " AND E.id_cargo = " & (cmb_filtro_cargo.SelectedValue)
        End If
        sql &= " ORDER BY E.apellido ASC"

        tabla = ejecuto_sql(sql)
        llenar_grilla(tabla)
    End Sub

    Private Sub frm_registrar_tratamiento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Esta seguro que desea salir", "Importante", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub grid_empleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_empleados.CellClick
        llenar_form_click_en_grid()
    End Sub


End Class
