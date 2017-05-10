Public Class frm_registrar_paciente


    'Lo que me permite conectar a la BD'
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=BGH\MORILLASSQL;User ID=Morillas;Initial Catalog=ConsultorioOdontologicoBD;password=Morillas"
    'Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=LAPATOP\LUCIANOSQL;User ID=Luciano;Initial Catalog=ConsultorioOdontologicoBD;Password=Luciano"

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

    Private Sub frm_registrar_paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
        cargar_combo(cmb_loc _
                     , leo_tabla("Localidad") _
                     , "id_localidad" _
                     , "descripcion")
        cargar_combo(cmb_tipo_doc _
                     , leo_tabla("TipoDocumento") _
                     , "id_tipo_documento" _
                     , "descripcion")
        cargar_combo(cmb_eliminar_por_tipo_doc _
                     , leo_tabla("TipoDocumento") _
                     , "id_tipo_documento" _
                     , "descripcion")

    End Sub

    Private Sub cargar_grilla()
        'Dim conexion As New Data.OleDb.OleDbConnection
        'Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        'conexion.ConnectionString = cadena_conexion
        'conexion.Open()

        ''Se indica al comando que conexion a BD se va usar'
        'cmd.Connection = conexion
        ''Indico que tipo de comando voy a usar, como voy a mandar la consulta'
        'cmd.CommandType = CommandType.Text

        Dim sql As String = ""
        sql &= " SELECT   P.apellido"
        sql &= "          , P.nombre"
        sql &= "          , T.id_tipo_documento"
        sql &= "          , T.descripcion"
        sql &= "          , P.nro_documento"
        sql &= "          , P.sexo"
        sql &= "          , P.fecha_nacimiento"
        sql &= "          , P.telefono"
        sql &= "          , P.celular"
        sql &= "          , P.id_localidad"
        sql &= "          , P.calle"
        sql &= "          , P.nro_calle"
        sql &= "          , P.piso"
        sql &= "          , P.departamento"
        sql &= " FROM     Paciente P JOIN TipoDocumento T"
        sql &= " ON       P.id_tipo_documento = T.id_tipo_documento"
        sql &= " WHERE habilitado = 1"  'asegurarse de que esto lo de habilitado en la BD


        'Le digo cual es la consulta'
        'cmd.CommandText = sql
        'Ejecuto la consulta y guardo los datos en algun contenedor'
        tabla = ejecuto_sql(sql)
        'tabla.Load(ejecuto_sql(sql))
        'conexion.Close()

        'Dim c As Integer

        'Me.grid_pacientes.Rows.Clear()

        'For c = 0 To tabla.Rows.Count - 1
        '    grid_pacientes.Rows.Add()
        '    grid_pacientes.Rows(c).Cells(0).Value = tabla.Rows(c)("nombre")
        '    grid_pacientes.Rows(c).Cells(1).Value = tabla.Rows(c)("apellido")
        '    grid_pacientes.Rows(c).Cells(2).Value = tabla.Rows(c)("descripcion")
        '    grid_pacientes.Rows(c).Cells(3).Value = tabla.Rows(c)("id_tipo_documento")
        '    grid_pacientes.Rows(c).Cells(4).Value = tabla.Rows(c)("nro_documento")
        '    grid_pacientes.Rows(c).Cells(5).Value = tabla.Rows(c)("sexo")
        '    grid_pacientes.Rows(c).Cells(6).Value = tabla.Rows(c)("fecha_nacimiento")
        '    grid_pacientes.Rows(c).Cells(7).Value = tabla.Rows(c)("telefono")
        '    grid_pacientes.Rows(c).Cells(8).Value = tabla.Rows(c)("celular")
        '    grid_pacientes.Rows(c).Cells(9).Value = tabla.Rows(c)("id_localidad")
        '    grid_pacientes.Rows(c).Cells(10).Value = tabla.Rows(c)("calle")
        '    grid_pacientes.Rows(c).Cells(11).Value = tabla.Rows(c)("nro_calle")
        '    grid_pacientes.Rows(c).Cells(12).Value = tabla.Rows(c)("piso")
        '    grid_pacientes.Rows(c).Cells(13).Value = tabla.Rows(c)("departamento")

        'Next
        llenar_grilla(tabla)
    End Sub


    'Lee una tabla de base de datos y devuelve su contenido en un DataTable'
    Private Function leo_tabla(ByVal nombre_tabla As String) As DataTable
        'Dim conexion As New Data.OleDb.OleDbConnection
        'Dim cmd As New Data.OleDb.OleDbCommand
        'Dim tabla As New Data.DataTable

        'conexion.ConnectionString = cadena_conexion
        'conexion.Open()
        'cmd.Connection = conexion
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = "SELECT * FROM " & nombre_tabla
        'tabla.Load(cmd.ExecuteReader())
        'conexion.Close()
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
        Dim nom As String = ""
        Dim message_str As String = "Se encuentran los siguientes errores:"
        Dim libre_de_error As Boolean = True
        If txt_ape.Text = "" Then
            'MessageBox.Show("El campo apellido esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_ape.Focus()
            'Return respuesta_validacion_error._error
            libre_de_error = False
            message_str &= vbCrLf & "El campo apellido esta vacio."
        End If

        If txt_nom.Text = "" Then
            'MessageBox.Show("El campo nombre esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_nom.Focus()
            'Return respuesta_validacion_error._error
            libre_de_error = False
            message_str &= vbCrLf & "El campo nombre esta vacio"
        End If

        If cmb_tipo_doc.SelectedIndex = -1 Then
            'MessageBox.Show("El campo localidad esta sin seleccion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'cmb_loc.Focus()
            'Return respuesta_validacion_error._error
            libre_de_error = False
            message_str &= vbCrLf & "El campo tipo documento esta sin seleccion"
        End If

        If txt_nro_doc.Text.Length < 8 Then
            'MessageBox.Show("El campo CUIL debe contener 12 digitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_cuil.Focus()
            'Return respuesta_validacion_error._error
            libre_de_error = False
            message_str &= vbCrLf & "El campo numero de documento debe contener 8 digitos"
        End If

        If (Not rb_mujer.Checked) And (Not rb_hombre.Checked) Then
            libre_de_error = False
            message_str &= vbCrLf & "Se debe seleccionar un sexo"
        End If

        If (txt_telefono.Text = "" And txt_celular.Text = "") Then
            'MessageBox.Show("Se debe registrar al menos un numero de contacto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_telefono.Focus()
            'Return respuesta_validacion_error._error
            libre_de_error = False
            message_str &= vbCrLf & "Se debe registrar al menos un numero de contacto"
        End If

        If (txt_telefono.Text.Length > 0 And txt_telefono.Text.Length < 7) Then
            'MessageBox.Show("Numero telefonico incorrecto. Debe contener al menos 7 digitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Return respuesta_validacion_error._error
            libre_de_error = False
            message_str &= vbCrLf & "Numero telefonico incorrecto. Debe contener al menos 7 digitos"
        End If

        If txt_telefono.Text.Length > 0 Then
            For Each c As Char In txt_telefono.Text
                If Not (IsNumeric(c)) Then
                    'MessageBox.Show("Numero telefonico incorrecto. No debe contener letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Return respuesta_validacion_error._error
                    libre_de_error = False
                    message_str &= vbCrLf & "Numero telefonico incorrecto. No debe contener letras"
                    Exit For
                End If
            Next
        End If

        If (txt_celular.Text.Length > 0 And txt_celular.Text.Length < 8) Then
            'MessageBox.Show("Numero de celular incorrecto. Debe contener al menos 2 digitos de codigo de area y 6 digitos de numero de celular", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Return respuesta_validacion_error._error
            libre_de_error = False
            message_str &= vbCrLf & "Numero de celular incorrecto. Debe contener al menos 2 digitos de codigo de area y 6 digitos de numero de celular"
        End If

        If txt_celular.Text.Length > 0 Then
            For Each c As Char In txt_celular.Text
                If Not (IsNumeric(c)) Then
                    'MessageBox.Show("Numero de celular incorrecto. No debe contener letras o simbolos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Return respuesta_validacion_error._error
                    libre_de_error = False
                    message_str &= vbCrLf & "Numero de celular incorrecto. No debe contener letras o simbolos"
                    Exit For
                End If
            Next
        End If

        If txt_calle.Text = "" Then
            'MessageBox.Show("El campo calle esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_calle.Focus()
            'Return respuesta_validacion_error._error
            libre_de_error = False
            message_str &= vbCrLf & "El campo calle esta vacio"
        End If

        If txt_nro_calle.Text = "" Then
            'MessageBox.Show("El campo numero calle esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_nro_calle.Focus()
            'Return respuesta_validacion_error._error
            libre_de_error = False
            message_str &= vbCrLf & "El campo numero calle esta vacio"
        Else
            For Each c As Char In txt_nro_calle.Text
                If Not (IsNumeric(c)) Then
                    'MessageBox.Show("El campo numero calle no debe contener letras o simbolos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'txt_nro_calle.Focus()
                    'Return respuesta_validacion_error._error
                    libre_de_error = False
                    message_str &= vbCrLf & "El campo numero calle no debe contener letras o simbolos"
                    Exit For
                End If
            Next
        End If

        If cmb_loc.SelectedIndex = -1 Then
            'MessageBox.Show("El campo localidad esta sin seleccion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'cmb_loc.Focus()
            'Return respuesta_validacion_error._error
            libre_de_error = False
            message_str &= vbCrLf & "El campo localidad esta sin seleccion"
        End If

        If txt_piso.Text.Length > 0 Then
            For Each c As Char In txt_piso.Text
                If Not (IsNumeric(c)) Then
                    'MessageBox.Show("El campo piso no debe contener letras o simbolos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'txt_piso.Focus()
                    'Return respuesta_validacion_error._error
                    libre_de_error = False
                    message_str &= vbCrLf & "El campo piso no debe contener letras o simbolos"
                    Exit For
                End If
            Next
            If txt_depto.Text = "" And Not (String.Compare(txt_piso.Text, "0") = 0) Then
                'MessageBox.Show("Debe especificar cual es el departamento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'txt_depto.Focus()
                'Return respuesta_validacion_error._error
                libre_de_error = False
                message_str &= vbCrLf & "Debe especificar cual es el departamento"
            End If
        End If

        If txt_depto.Text.Length > 0 Then
            If txt_piso.Text = "" Then
                'MessageBox.Show("Debe especificar cual es el piso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'txt_piso.Focus()
                'Return respuesta_validacion_error._error
                libre_de_error = False
                message_str &= vbCrLf & "Debe especificar cual es el piso"
            Else
                For Each c As Char In txt_piso.Text
                    If Not (IsNumeric(c)) And Not (String.Compare(txt_piso.Text, "0") = 0) Then
                        '    MessageBox.Show("El campo piso no debe contener letras o simbolos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    txt_piso.Focus()
                        'Return respuesta_validacion_error._error
                        libre_de_error = False
                        message_str &= vbCrLf & "El campo piso no debe contener letras o simbolos"
                        Exit For
                    End If
                Next
            End If

        End If


        'For Each obj As Windows.Forms.Control In grp_datos_personales.Controls
        '    'Otras validaciones---'
        '    nom = obj.Name
        '    'MessageBox.Show(nom)
        '    'If Not (nom = "txt_piso") Or Not (nom = "txt_depto") Or Not (nom = "txt_celular") Or Not (nom = "txt_telefono") Or Not (nom = "txt_eliminar_por_cuil") Then
        '    If Not (nom = "txt_celular") And Not (nom = "txt_telefono") Then
        '        If nom = "txt_cuil" And obj.Text.Length < 14 Then
        '            MessageBox.Show("El campo " + obj.Name + " esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End If
        '        If obj.GetType().Name = "TextBox" Or obj.GetType().Name = "MaskedTextBox" Then
        '            If obj.Text = "" Then
        '                MessageBox.Show("El campo " + obj.Name + " esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                obj.Focus()
        '                Return respuesta_validacion_error._error
        '            End If
        '        End If
        '    End If
        '    If obj.GetType().Name = "ComboBox" Then
        '        Dim local As ComboBox = obj
        '        If local.SelectedIndex = -1 Then
        '            MessageBox.Show("El campo " + obj.Name + " esta sin seleccion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            obj.Focus()
        '            Return respuesta_validacion_error._error
        '        End If
        '    End If
        'Next
        If libre_de_error = True Then
            Return respuesta_validacion_error._ok
        Else
            MessageBox.Show(message_str, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return respuesta_validacion_error._error
        End If

    End Function

    Private Function validar_pacientes(ByVal id_tipo_documento As Integer, _
                                       ByVal nro_documento As String _
                                       ) As respuesta_validacion
        Dim sql As String = ""
        sql &= "SELECT id_tipo_documento, nro_documento"
        sql &= " FROM Paciente"
        sql &= " WHERE id_tipo_documento = " & id_tipo_documento
        sql &= " AND nro_documento = '" & nro_documento & "'"

        Dim tabla As New DataTable

        tabla = Me.ejecuto_sql(sql)

        If tabla.Rows.Count = 0 Then
            Return respuesta_validacion._no_existe
        Else
            Return respuesta_validacion._existe
        End If
    End Function


    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click
        'Al metodo para validar los campos lo llama pero por alguna razon no va a la rama del Else cuando estan vacios'
        If validar_datos() = respuesta_validacion_error._ok Then
            If Me.accion = tipo_grabacion.insertar Then
                'DeLucho: para hacer la siguiente validacion asumo que el id_tipo_documento es igual al indice del cmb_tipo_documento + 1, verificar despues
                If validar_pacientes(Me.cmb_tipo_doc.SelectedValue, Me.txt_nro_doc.Text) = respuesta_validacion._no_existe Then
                    insertar()
                    MessageBox.Show("Se ha registrado el paciente correctamente")
                Else
                    MessageBox.Show("Se ha detectado un paciente con el mismo tipo y numero de documento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                If validar_datos() = respuesta_validacion_error._ok Then
                    If validar_pacientes(Me.cmb_tipo_doc.SelectedValue, Me.txt_nro_doc.Text) = respuesta_validacion._existe Then
                        modificar()
                        MessageBox.Show("Se ha modificado el paciente correctamente")
                        habilitar_controles()
                        limpiar_campos()
                        accion = tipo_grabacion.insertar
                    Else
                        MessageBox.Show("Se ha detectado que el paciente no existe en la base de datos. Compruebe que a ingresado correctamente el tipo y numero de documento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        rb_mujer.Enabled = True
        rb_hombre.Enabled = True
        txt_telefono.Enabled = True
        txt_celular.Enabled = True
        txt_calle.Enabled = True
        txt_nro_calle.Enabled = True
        txt_piso.Enabled = True
        txt_depto.Enabled = True
        cmb_loc.Enabled = True
        cmd_registrar.Enabled = True
        cmb_tipo_doc.Enabled = True
    End Sub

    Private Sub limpiar_campos()
        For Each obj As Windows.Forms.Control In grp_datos_personales.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If

            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
            End If

            If obj.GetType().Name = "RadioButton" Then
                Dim local As RadioButton = obj
                local.Checked = False
            End If

            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
            End If
        Next

        For Each obj As Windows.Forms.Control In grp_domicilio.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If

            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
            End If
        Next
    End Sub

    Private Sub cmd_eliminar_por_doc_Click(sender As Object, e As EventArgs) Handles cmd_eliminar_por_doc.Click
        If validar_pacientes(Me.cmb_eliminar_por_tipo_doc.SelectedValue, Me.txt_eliminar_por_doc.Text) = respuesta_validacion._existe Then
            Dim res As Integer = MessageBox.Show("                        Esta seguro?", "Confirmacion", MessageBoxButtons.OKCancel)
            If res = DialogResult.OK Then
                eliminar(Me.cmb_eliminar_por_tipo_doc.SelectedValue, Me.txt_eliminar_por_doc.Text)
                MessageBox.Show("Se ha eliminado el paciente correctamente" _
                            , "Informacion" _
                            , MessageBoxButtons.OK _
                            , MessageBoxIcon.Information)
                Me.cargar_grilla()
                Me.txt_eliminar_por_doc.Text = ""
            End If
        Else
            MessageBox.Show("Se ha detectado que el paciente no existe en la base de datos" _
                        , "ERROR" _
                        , MessageBoxButtons.OK _
                        , MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub cmd_eliminar_fila_seleccionada_Click(sender As Object, e As EventArgs)

        If grid_pacientes.CurrentCell.Selected = False Then

            MessageBox.Show("Debe seleccionar una fila de la grilla" _
                        , "ERROR" _
                        , MessageBoxButtons.OK _
                        , MessageBoxIcon.Error)

            Exit Sub
        End If

        Dim res As Integer = MessageBox.Show("                        Esta seguro?", "Confirmacion", MessageBoxButtons.OKCancel)
        If res = DialogResult.OK Then
            eliminar(Me.grid_pacientes.CurrentRow.Cells(3).Value, Me.grid_pacientes.CurrentRow.Cells(4).Value)
            cargar_grilla()
            Me.txt_eliminar_por_doc.Text = ""
            MessageBox.Show("Se ha eliminado el paciente correctamente" _
                            , "Informacion" _
                            , MessageBoxButtons.OK _
                            , MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub insertar()
        Dim txt_insert As String = ""

        txt_insert &= "INSERT INTO Paciente ("
        'txt_insert &= "id_empleado"
        txt_insert &= "nro_documento"
        txt_insert &= ", id_tipo_documento"
        txt_insert &= ", nombre"
        txt_insert &= ", apellido"
        txt_insert &= ", sexo"
        txt_insert &= ", fecha_nacimiento"
        txt_insert &= ", id_localidad"
        txt_insert &= ", telefono"
        txt_insert &= ", celular"
        txt_insert &= ", calle"
        txt_insert &= ", nro_calle"
        txt_insert &= ", piso"
        txt_insert &= ", departamento"
        txt_insert &= ", habilitado)" '<---- FIJARSE QUE ESTE EN BD!!!
        txt_insert &= " VALUES ("
        txt_insert &= "'" & Me.txt_nro_doc.Text & "'"
        txt_insert &= ", " & Me.cmb_tipo_doc.SelectedValue  '<--- REVISAR ESTO VS SELECTEDVALUE sin + 1
        txt_insert &= ", '" & Me.txt_nom.Text & "'"
        txt_insert &= ", '" & Me.txt_ape.Text & "'"
        If rb_hombre.Checked Then
            txt_insert &= ", 'H'"
        Else
            txt_insert &= ", 'M'"
        End If
        txt_insert &= ", '" & Format(Me.dtp_fecha_nac.Value, "yyyy-MM-dd") & "'"
        txt_insert &= ", " & Me.cmb_loc.SelectedValue

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

        txt_insert &= ", 1)"



        insertar_modificar_eliminar(txt_insert)
        'Dim conexion As New Data.OleDb.OleDbConnection
        'Dim cmd As New Data.OleDb.OleDbCommand

        'conexion.ConnectionString = cadena_conexion
        'conexion.Open()
        'cmd.Connection = conexion
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = txt_insert
        'cmd.ExecuteNonQuery()
        'conexion.Close()
    End Sub


    Private Sub eliminar(ByVal tipoDoc, ByVal nroDoc)
        Dim txt_delete As String = ""

        txt_delete &= "UPDATE Paciente"
        txt_delete &= " SET habilitado = 0"
        txt_delete &= " WHERE id_tipo_documento = " & tipoDoc 'HACER STRIMG
        txt_delete &= " AND nro_documento = '" & nroDoc & "'"

        insertar_modificar_eliminar(txt_delete)
    End Sub

    Private Sub modificar()
        Dim txt_update As String = ""

        txt_update &= "UPDATE Paciente "
        txt_update &= "SET nombre = '" & txt_nom.Text & "'"
        txt_update &= " ,apellido = '" & txt_ape.Text & "'"
        If rb_hombre.Checked Then
            txt_update &= " ,sexo = 'H'"
        Else
            txt_update &= " ,sexo = 'M'"
        End If

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

        txt_update &= " WHERE id_tipo_documento = " & (cmb_tipo_doc.SelectedValue)
        txt_update &= " AND nro_documento = '" & txt_nro_doc.Text & "'"

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

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        If cmb_tipo_doc.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un tipo de documento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_tipo_doc.Focus()
            Exit Sub
        End If

        If txt_nro_doc.Text.Length < 8 Then
            MessageBox.Show("El campo NroDoc debe contener 8 digitos. Ejemplo: 00-000-000", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_nro_doc.Focus()
            Exit Sub
        End If


        Dim encontrado As Boolean = False

        For c = 0 To (grid_pacientes.Rows.Count - 1)
            If cmb_tipo_doc.SelectedValue = grid_pacientes.Rows(c).Cells(3).Value.ToString _
                And String.Compare(grid_pacientes.Rows(c).Cells(4).Value, txt_nro_doc.Text, False) = 0 Then

                llenar_formulario(c)

                encontrado = True
                Exit For

            End If
        Next

        If encontrado = True Then
            accion = tipo_grabacion.modificar
            habilitar_controles()
            dtp_fecha_nac.Enabled = False
            cmb_tipo_doc.Enabled = False
            'cmd_registrar.Text = "Modificar"
        Else
            MessageBox.Show("No se ha encontrado ningun paciente con el el tipo y numero de documento especificado", _
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub llenar_formulario(row As Integer)

        txt_nom.Text = grid_pacientes.Rows(row).Cells(0).Value
        txt_ape.Text = grid_pacientes.Rows(row).Cells(1).Value
        cmb_tipo_doc.SelectedIndex = grid_pacientes.Rows(row).Cells(3).Value - 1
        txt_nro_doc.Text = grid_pacientes.Rows(row).Cells(4).Value
        Select Case grid_pacientes.Rows(row).Cells(5).Value.ToUpper()
            Case "H"
                rb_hombre.Checked = True
                rb_mujer.Checked = False
            Case "M"
                rb_hombre.Checked = False
                rb_mujer.Checked = True
        End Select
        'Dim dt As DateTime = DateTime.ParseExact(grid_empleados.Rows(row).Cells(5).Value, "dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture)
        dtp_fecha_nac.Value = grid_pacientes.Rows(row).Cells(6).Value
        txt_telefono.Text = grid_pacientes.Rows(row).Cells(7).Value
        txt_celular.Text = grid_pacientes.Rows(row).Cells(8).Value
        cmb_loc.SelectedIndex = grid_pacientes.Rows(row).Cells(9).Value - 1
        txt_calle.Text = grid_pacientes.Rows(row).Cells(10).Value
        txt_nro_calle.Text = grid_pacientes.Rows(row).Cells(11).Value
        txt_piso.Text = grid_pacientes.Rows(row).Cells(12).Value
        txt_depto.Text = grid_pacientes.Rows(row).Cells(13).Value

    End Sub

    Private Sub grid_pacientes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grid_pacientes.RowHeaderMouseClick

        llenar_formulario(grid_pacientes.CurrentRow.Index)

        accion = tipo_grabacion.modificar
        habilitar_controles()
        dtp_fecha_nac.Enabled = False
        cmb_tipo_doc.Enabled = False '<--- REEMP CMB_CARGO POR ESTO, VER SI TIENE SENTIDO
        'cmd_registrar.Text = "Modificar"
    End Sub

    Private Sub llenar_grilla(ByVal tabla As DataTable)
        Dim c As Integer

        Me.grid_pacientes.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            grid_pacientes.Rows.Add()
            grid_pacientes.Rows(c).Cells(0).Value = tabla.Rows(c)("nombre")
            grid_pacientes.Rows(c).Cells(1).Value = tabla.Rows(c)("apellido")
            grid_pacientes.Rows(c).Cells(2).Value = tabla.Rows(c)("descripcion")
            grid_pacientes.Rows(c).Cells(3).Value = tabla.Rows(c)("id_tipo_documento")
            grid_pacientes.Rows(c).Cells(4).Value = tabla.Rows(c)("nro_documento")
            grid_pacientes.Rows(c).Cells(5).Value = tabla.Rows(c)("sexo")
            grid_pacientes.Rows(c).Cells(6).Value = tabla.Rows(c)("fecha_nacimiento")
            grid_pacientes.Rows(c).Cells(7).Value = tabla.Rows(c)("telefono")
            grid_pacientes.Rows(c).Cells(8).Value = tabla.Rows(c)("celular")
            grid_pacientes.Rows(c).Cells(9).Value = tabla.Rows(c)("id_localidad")
            grid_pacientes.Rows(c).Cells(10).Value = tabla.Rows(c)("calle")
            grid_pacientes.Rows(c).Cells(11).Value = tabla.Rows(c)("nro_calle")
            grid_pacientes.Rows(c).Cells(12).Value = tabla.Rows(c)("piso")
            grid_pacientes.Rows(c).Cells(13).Value = tabla.Rows(c)("departamento")

        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro_nombre_apellido.TextChanged
        Dim pattern As String = txt_filtro_nombre_apellido.Text
        Dim sql As String = ""

        Dim tabla As New Data.DataTable

        sql &= " SELECT   P.apellido"
        sql &= "          , P.nombre"
        sql &= "          , T.id_tipo_documento"
        sql &= "          , T.descripcion"
        sql &= "          , P.nro_documento"
        sql &= "          , P.sexo"
        sql &= "          , P.fecha_nacimiento"
        sql &= "          , P.telefono"
        sql &= "          , P.celular"
        sql &= "          , P.id_localidad"
        sql &= "          , P.calle"
        sql &= "          , P.nro_calle"
        sql &= "          , P.piso"
        sql &= "          , P.departamento"
        sql &= " FROM     Paciente P JOIN TipoDocumento T"
        sql &= " ON       P.id_tipo_documento = T.id_tipo_documento"
        sql &= " WHERE habilitado = 1"

        sql &= " AND (CONCAT(P.apellido, ' ', P.nombre) LIKE '" & pattern & "%'"
        sql &= " OR CONCAT(P.nombre, ' ', P.apellido) LIKE '" & pattern & "%')"

        tabla = ejecuto_sql(sql)
        llenar_grilla(tabla)
    End Sub

    Private Sub lbl_eliminar_por_tipo_doc_Click(sender As Object, e As EventArgs) Handles lbl_eliminar_por_tipo_doc.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_eliminar_por_doc.MaskInputRejected

    End Sub
End Class
