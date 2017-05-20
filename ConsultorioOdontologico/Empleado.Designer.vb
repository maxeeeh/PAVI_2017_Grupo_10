<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_empleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_empleado))
        Me.grid_empleados = New System.Windows.Forms.DataGridView()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.piso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_egreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_empleados = New System.Windows.Forms.GroupBox()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.lbl_campos_obligatorios = New System.Windows.Forms.Label()
        Me.cmb_filtro_cargo = New System.Windows.Forms.ComboBox()
        Me.txt_filtro_nombre_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_filtro_nombre_apellido = New System.Windows.Forms.Label()
        Me.chk_filtro_cargo = New System.Windows.Forms.CheckBox()
        Me.lbl_advertencia = New System.Windows.Forms.Label()
        Me.cmd_eliminar_por_cuil = New System.Windows.Forms.Button()
        Me.grp_domicilio = New System.Windows.Forms.GroupBox()
        Me.cmb_loc = New System.Windows.Forms.ComboBox()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.txt_depto = New System.Windows.Forms.TextBox()
        Me.txt_piso = New System.Windows.Forms.TextBox()
        Me.lbl_depto = New System.Windows.Forms.Label()
        Me.lbl_piso = New System.Windows.Forms.Label()
        Me.txt_nro_calle = New System.Windows.Forms.TextBox()
        Me.lbl_nro = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.grp_datos_laborales = New System.Windows.Forms.GroupBox()
        Me.cmb_cargo = New System.Windows.Forms.ComboBox()
        Me.lbl_hora_egreso = New System.Windows.Forms.Label()
        Me.lbl_hora_ingreso = New System.Windows.Forms.Label()
        Me.lbl_cargo = New System.Windows.Forms.Label()
        Me.grp_datos_personales = New System.Windows.Forms.GroupBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.txt_cuil = New System.Windows.Forms.MaskedTextBox()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_celular = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.dtp_fecha_nac = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_ape = New System.Windows.Forms.Label()
        Me.txt_ape = New System.Windows.Forms.TextBox()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.lbl_cuil = New System.Windows.Forms.Label()
        Me.txt_hora_egreso = New System.Windows.Forms.MaskedTextBox()
        Me.txt_hora_ingreso = New System.Windows.Forms.MaskedTextBox()
        CType(Me.grid_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_empleados.SuspendLayout()
        Me.grp_domicilio.SuspendLayout()
        Me.grp_datos_laborales.SuspendLayout()
        Me.grp_datos_personales.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_empleados
        '
        Me.grid_empleados.AllowUserToAddRows = False
        Me.grid_empleados.AllowUserToDeleteRows = False
        Me.grid_empleados.AllowUserToResizeColumns = False
        Me.grid_empleados.AllowUserToResizeRows = False
        Me.grid_empleados.ColumnHeadersHeight = 30
        Me.grid_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nom, Me.ape, Me.cuil, Me.cargo, Me.id_cargo, Me.fecha_nacimiento, Me.telefono, Me.celular, Me.id_localidad, Me.calle, Me.nro_calle, Me.piso, Me.departamento, Me.hora_ingreso, Me.hora_egreso})
        Me.grid_empleados.Cursor = System.Windows.Forms.Cursors.Cross
        Me.grid_empleados.Location = New System.Drawing.Point(16, 23)
        Me.grid_empleados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_empleados.Name = "grid_empleados"
        Me.grid_empleados.ReadOnly = True
        Me.grid_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_empleados.Size = New System.Drawing.Size(1053, 334)
        Me.grid_empleados.TabIndex = 17
        '
        'nom
        '
        Me.nom.FillWeight = 50.0!
        Me.nom.HeaderText = "Nombre"
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        Me.nom.Width = 245
        '
        'ape
        '
        Me.ape.FillWeight = 50.0!
        Me.ape.HeaderText = "Apellido"
        Me.ape.Name = "ape"
        Me.ape.ReadOnly = True
        Me.ape.Width = 245
        '
        'cuil
        '
        Me.cuil.FillWeight = 50.0!
        Me.cuil.HeaderText = "CUIL"
        Me.cuil.Name = "cuil"
        Me.cuil.ReadOnly = True
        Me.cuil.Width = 123
        '
        'cargo
        '
        Me.cargo.FillWeight = 50.0!
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        Me.cargo.Width = 123
        '
        'id_cargo
        '
        Me.id_cargo.FillWeight = 2.0!
        Me.id_cargo.HeaderText = "id_cargo"
        Me.id_cargo.MinimumWidth = 2
        Me.id_cargo.Name = "id_cargo"
        Me.id_cargo.ReadOnly = True
        Me.id_cargo.Visible = False
        Me.id_cargo.Width = 2
        '
        'fecha_nacimiento
        '
        Me.fecha_nacimiento.HeaderText = "fecha_nacimiento"
        Me.fecha_nacimiento.Name = "fecha_nacimiento"
        Me.fecha_nacimiento.ReadOnly = True
        Me.fecha_nacimiento.Visible = False
        '
        'telefono
        '
        Me.telefono.HeaderText = "telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Visible = False
        '
        'celular
        '
        Me.celular.HeaderText = "celular"
        Me.celular.Name = "celular"
        Me.celular.ReadOnly = True
        Me.celular.Visible = False
        '
        'id_localidad
        '
        Me.id_localidad.HeaderText = "id_localidad"
        Me.id_localidad.Name = "id_localidad"
        Me.id_localidad.ReadOnly = True
        Me.id_localidad.Visible = False
        '
        'calle
        '
        Me.calle.HeaderText = "calle"
        Me.calle.Name = "calle"
        Me.calle.ReadOnly = True
        Me.calle.Visible = False
        '
        'nro_calle
        '
        Me.nro_calle.HeaderText = "nro_calle"
        Me.nro_calle.Name = "nro_calle"
        Me.nro_calle.ReadOnly = True
        Me.nro_calle.Visible = False
        '
        'piso
        '
        Me.piso.HeaderText = "piso"
        Me.piso.Name = "piso"
        Me.piso.ReadOnly = True
        Me.piso.Visible = False
        '
        'departamento
        '
        Me.departamento.HeaderText = "departamento"
        Me.departamento.Name = "departamento"
        Me.departamento.ReadOnly = True
        Me.departamento.Visible = False
        '
        'hora_ingreso
        '
        Me.hora_ingreso.HeaderText = "hora_ingreso"
        Me.hora_ingreso.Name = "hora_ingreso"
        Me.hora_ingreso.ReadOnly = True
        Me.hora_ingreso.Visible = False
        '
        'hora_egreso
        '
        Me.hora_egreso.HeaderText = "hora_egreso"
        Me.hora_egreso.Name = "hora_egreso"
        Me.hora_egreso.ReadOnly = True
        Me.hora_egreso.Visible = False
        '
        'grp_empleados
        '
        Me.grp_empleados.Controls.Add(Me.grid_empleados)
        Me.grp_empleados.Location = New System.Drawing.Point(16, 425)
        Me.grp_empleados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_empleados.Name = "grp_empleados"
        Me.grp_empleados.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_empleados.Size = New System.Drawing.Size(1092, 364)
        Me.grp_empleados.TabIndex = 18
        Me.grp_empleados.TabStop = False
        Me.grp_empleados.Text = "Empleados"
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_nuevo.Location = New System.Drawing.Point(664, 807)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(119, 28)
        Me.cmd_nuevo.TabIndex = 23
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir.Location = New System.Drawing.Point(965, 807)
        Me.cmd_salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(119, 28)
        Me.cmd_salir.TabIndex = 22
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Enabled = False
        Me.cmd_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_registrar.Location = New System.Drawing.Point(815, 807)
        Me.cmd_registrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(119, 28)
        Me.cmd_registrar.TabIndex = 21
        Me.cmd_registrar.Text = "Guardar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'lbl_campos_obligatorios
        '
        Me.lbl_campos_obligatorios.AutoSize = True
        Me.lbl_campos_obligatorios.Location = New System.Drawing.Point(959, 336)
        Me.lbl_campos_obligatorios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_campos_obligatorios.Name = "lbl_campos_obligatorios"
        Me.lbl_campos_obligatorios.Size = New System.Drawing.Size(145, 17)
        Me.lbl_campos_obligatorios.TabIndex = 26
        Me.lbl_campos_obligatorios.Text = "* Campos obligatorios"
        '
        'cmb_filtro_cargo
        '
        Me.cmb_filtro_cargo.Enabled = False
        Me.cmb_filtro_cargo.FormattingEnabled = True
        Me.cmb_filtro_cargo.Location = New System.Drawing.Point(637, 383)
        Me.cmb_filtro_cargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_filtro_cargo.Name = "cmb_filtro_cargo"
        Me.cmb_filtro_cargo.Size = New System.Drawing.Size(160, 24)
        Me.cmb_filtro_cargo.TabIndex = 11
        '
        'txt_filtro_nombre_apellido
        '
        Me.txt_filtro_nombre_apellido.Location = New System.Drawing.Point(271, 383)
        Me.txt_filtro_nombre_apellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_filtro_nombre_apellido.Name = "txt_filtro_nombre_apellido"
        Me.txt_filtro_nombre_apellido.Size = New System.Drawing.Size(132, 22)
        Me.txt_filtro_nombre_apellido.TabIndex = 28
        '
        'lbl_filtro_nombre_apellido
        '
        Me.lbl_filtro_nombre_apellido.AutoSize = True
        Me.lbl_filtro_nombre_apellido.Location = New System.Drawing.Point(48, 386)
        Me.lbl_filtro_nombre_apellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_filtro_nombre_apellido.Name = "lbl_filtro_nombre_apellido"
        Me.lbl_filtro_nombre_apellido.Size = New System.Drawing.Size(197, 17)
        Me.lbl_filtro_nombre_apellido.TabIndex = 29
        Me.lbl_filtro_nombre_apellido.Text = "Filtrar por nombre y/o apellido"
        '
        'chk_filtro_cargo
        '
        Me.chk_filtro_cargo.AutoSize = True
        Me.chk_filtro_cargo.Location = New System.Drawing.Point(477, 386)
        Me.chk_filtro_cargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chk_filtro_cargo.Name = "chk_filtro_cargo"
        Me.chk_filtro_cargo.Size = New System.Drawing.Size(131, 21)
        Me.chk_filtro_cargo.TabIndex = 30
        Me.chk_filtro_cargo.Text = "Filtrar por cargo"
        Me.chk_filtro_cargo.UseVisualStyleBackColor = True
        '
        'lbl_advertencia
        '
        Me.lbl_advertencia.AutoSize = True
        Me.lbl_advertencia.Location = New System.Drawing.Point(744, 352)
        Me.lbl_advertencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_advertencia.Name = "lbl_advertencia"
        Me.lbl_advertencia.Size = New System.Drawing.Size(360, 17)
        Me.lbl_advertencia.TabIndex = 31
        Me.lbl_advertencia.Text = "-Debe especificar al menos 1 (uno) numero de contacto"
        '
        'cmd_eliminar_por_cuil
        '
        Me.cmd_eliminar_por_cuil.Location = New System.Drawing.Point(512, 807)
        Me.cmd_eliminar_por_cuil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_eliminar_por_cuil.Name = "cmd_eliminar_por_cuil"
        Me.cmd_eliminar_por_cuil.Size = New System.Drawing.Size(119, 28)
        Me.cmd_eliminar_por_cuil.TabIndex = 32
        Me.cmd_eliminar_por_cuil.Text = "Eliminar"
        Me.cmd_eliminar_por_cuil.UseVisualStyleBackColor = True
        '
        'grp_domicilio
        '
        Me.grp_domicilio.Controls.Add(Me.cmb_loc)
        Me.grp_domicilio.Controls.Add(Me.lbl_localidad)
        Me.grp_domicilio.Controls.Add(Me.txt_depto)
        Me.grp_domicilio.Controls.Add(Me.txt_piso)
        Me.grp_domicilio.Controls.Add(Me.lbl_depto)
        Me.grp_domicilio.Controls.Add(Me.lbl_piso)
        Me.grp_domicilio.Controls.Add(Me.txt_nro_calle)
        Me.grp_domicilio.Controls.Add(Me.lbl_nro)
        Me.grp_domicilio.Controls.Add(Me.lbl_calle)
        Me.grp_domicilio.Controls.Add(Me.txt_calle)
        Me.grp_domicilio.Location = New System.Drawing.Point(556, 30)
        Me.grp_domicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_domicilio.Name = "grp_domicilio"
        Me.grp_domicilio.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_domicilio.Size = New System.Drawing.Size(529, 130)
        Me.grp_domicilio.TabIndex = 35
        Me.grp_domicilio.TabStop = False
        Me.grp_domicilio.Text = "Domicilio"
        '
        'cmb_loc
        '
        Me.cmb_loc.Enabled = False
        Me.cmb_loc.FormattingEnabled = True
        Me.cmb_loc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmb_loc.Location = New System.Drawing.Point(132, 90)
        Me.cmb_loc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_loc.Name = "cmb_loc"
        Me.cmb_loc.Size = New System.Drawing.Size(369, 24)
        Me.cmb_loc.TabIndex = 10
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(33, 94)
        Me.lbl_localidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(78, 17)
        Me.lbl_localidad.TabIndex = 8
        Me.lbl_localidad.Text = "Localidad *"
        '
        'txt_depto
        '
        Me.txt_depto.Enabled = False
        Me.txt_depto.Location = New System.Drawing.Point(369, 55)
        Me.txt_depto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_depto.Name = "txt_depto"
        Me.txt_depto.Size = New System.Drawing.Size(132, 22)
        Me.txt_depto.TabIndex = 7
        '
        'txt_piso
        '
        Me.txt_piso.Enabled = False
        Me.txt_piso.Location = New System.Drawing.Point(132, 57)
        Me.txt_piso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_piso.Name = "txt_piso"
        Me.txt_piso.Size = New System.Drawing.Size(132, 22)
        Me.txt_piso.TabIndex = 6
        '
        'lbl_depto
        '
        Me.lbl_depto.AutoSize = True
        Me.lbl_depto.Location = New System.Drawing.Point(285, 60)
        Me.lbl_depto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_depto.Name = "lbl_depto"
        Me.lbl_depto.Size = New System.Drawing.Size(46, 17)
        Me.lbl_depto.TabIndex = 5
        Me.lbl_depto.Text = "Depto"
        '
        'lbl_piso
        '
        Me.lbl_piso.AutoSize = True
        Me.lbl_piso.Location = New System.Drawing.Point(68, 60)
        Me.lbl_piso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_piso.Name = "lbl_piso"
        Me.lbl_piso.Size = New System.Drawing.Size(35, 17)
        Me.lbl_piso.TabIndex = 4
        Me.lbl_piso.Text = "Piso"
        '
        'txt_nro_calle
        '
        Me.txt_nro_calle.Enabled = False
        Me.txt_nro_calle.Location = New System.Drawing.Point(369, 23)
        Me.txt_nro_calle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nro_calle.Name = "txt_nro_calle"
        Me.txt_nro_calle.Size = New System.Drawing.Size(132, 22)
        Me.txt_nro_calle.TabIndex = 3
        '
        'lbl_nro
        '
        Me.lbl_nro.AutoSize = True
        Me.lbl_nro.Location = New System.Drawing.Point(301, 27)
        Me.lbl_nro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nro.Name = "lbl_nro"
        Me.lbl_nro.Size = New System.Drawing.Size(40, 17)
        Me.lbl_nro.TabIndex = 2
        Me.lbl_nro.Text = "Nro *"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(64, 27)
        Me.lbl_calle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(48, 17)
        Me.lbl_calle.TabIndex = 1
        Me.lbl_calle.Text = "Calle *"
        '
        'txt_calle
        '
        Me.txt_calle.Enabled = False
        Me.txt_calle.Location = New System.Drawing.Point(132, 23)
        Me.txt_calle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(132, 22)
        Me.txt_calle.TabIndex = 0
        '
        'grp_datos_laborales
        '
        Me.grp_datos_laborales.Controls.Add(Me.txt_hora_egreso)
        Me.grp_datos_laborales.Controls.Add(Me.txt_hora_ingreso)
        Me.grp_datos_laborales.Controls.Add(Me.cmb_cargo)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_hora_egreso)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_hora_ingreso)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_cargo)
        Me.grp_datos_laborales.Location = New System.Drawing.Point(556, 167)
        Me.grp_datos_laborales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_datos_laborales.Name = "grp_datos_laborales"
        Me.grp_datos_laborales.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_datos_laborales.Size = New System.Drawing.Size(529, 129)
        Me.grp_datos_laborales.TabIndex = 34
        Me.grp_datos_laborales.TabStop = False
        Me.grp_datos_laborales.Text = "Datos Laborales"
        '
        'cmb_cargo
        '
        Me.cmb_cargo.Enabled = False
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Location = New System.Drawing.Point(132, 22)
        Me.cmb_cargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.Size = New System.Drawing.Size(160, 24)
        Me.cmb_cargo.TabIndex = 8
        '
        'lbl_hora_egreso
        '
        Me.lbl_hora_egreso.AutoSize = True
        Me.lbl_hora_egreso.Location = New System.Drawing.Point(16, 91)
        Me.lbl_hora_egreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_hora_egreso.Name = "lbl_hora_egreso"
        Me.lbl_hora_egreso.Size = New System.Drawing.Size(97, 17)
        Me.lbl_hora_egreso.TabIndex = 7
        Me.lbl_hora_egreso.Text = "Hora Egreso *"
        '
        'lbl_hora_ingreso
        '
        Me.lbl_hora_ingreso.AutoSize = True
        Me.lbl_hora_ingreso.Location = New System.Drawing.Point(13, 59)
        Me.lbl_hora_ingreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_hora_ingreso.Name = "lbl_hora_ingreso"
        Me.lbl_hora_ingreso.Size = New System.Drawing.Size(99, 17)
        Me.lbl_hora_ingreso.TabIndex = 6
        Me.lbl_hora_ingreso.Text = "Hora Ingreso *"
        '
        'lbl_cargo
        '
        Me.lbl_cargo.AutoSize = True
        Me.lbl_cargo.Location = New System.Drawing.Point(57, 26)
        Me.lbl_cargo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cargo.Name = "lbl_cargo"
        Me.lbl_cargo.Size = New System.Drawing.Size(55, 17)
        Me.lbl_cargo.TabIndex = 4
        Me.lbl_cargo.Text = "Cargo *"
        '
        'grp_datos_personales
        '
        Me.grp_datos_personales.Controls.Add(Me.cmd_buscar)
        Me.grp_datos_personales.Controls.Add(Me.txt_cuil)
        Me.grp_datos_personales.Controls.Add(Me.txt_celular)
        Me.grp_datos_personales.Controls.Add(Me.txt_telefono)
        Me.grp_datos_personales.Controls.Add(Me.lbl_celular)
        Me.grp_datos_personales.Controls.Add(Me.lbl_telefono)
        Me.grp_datos_personales.Controls.Add(Me.dtp_fecha_nac)
        Me.grp_datos_personales.Controls.Add(Me.Label1)
        Me.grp_datos_personales.Controls.Add(Me.lbl_ape)
        Me.grp_datos_personales.Controls.Add(Me.txt_ape)
        Me.grp_datos_personales.Controls.Add(Me.lbl_nom)
        Me.grp_datos_personales.Controls.Add(Me.txt_nom)
        Me.grp_datos_personales.Controls.Add(Me.lbl_cuil)
        Me.grp_datos_personales.Location = New System.Drawing.Point(32, 30)
        Me.grp_datos_personales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_datos_personales.Name = "grp_datos_personales"
        Me.grp_datos_personales.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_datos_personales.Size = New System.Drawing.Size(499, 267)
        Me.grp_datos_personales.TabIndex = 33
        Me.grp_datos_personales.TabStop = False
        Me.grp_datos_personales.Text = "Datos Personales"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(329, 101)
        Me.cmd_buscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(137, 28)
        Me.cmd_buscar.TabIndex = 13
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'txt_cuil
        '
        Me.txt_cuil.Location = New System.Drawing.Point(200, 103)
        Me.txt_cuil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cuil.Mask = "00-00000000-0"
        Me.txt_cuil.Name = "txt_cuil"
        Me.txt_cuil.Size = New System.Drawing.Size(111, 22)
        Me.txt_cuil.TabIndex = 11
        '
        'txt_celular
        '
        Me.txt_celular.Enabled = False
        Me.txt_celular.Location = New System.Drawing.Point(200, 225)
        Me.txt_celular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(265, 22)
        Me.txt_celular.TabIndex = 12
        '
        'txt_telefono
        '
        Me.txt_telefono.Enabled = False
        Me.txt_telefono.Location = New System.Drawing.Point(200, 185)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(265, 22)
        Me.txt_telefono.TabIndex = 11
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.Location = New System.Drawing.Point(108, 229)
        Me.lbl_celular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(52, 17)
        Me.lbl_celular.TabIndex = 10
        Me.lbl_celular.Text = "Celular"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(95, 188)
        Me.lbl_telefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(64, 17)
        Me.lbl_telefono.TabIndex = 9
        Me.lbl_telefono.Text = "Teléfono"
        '
        'dtp_fecha_nac
        '
        Me.dtp_fecha_nac.Enabled = False
        Me.dtp_fecha_nac.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtp_fecha_nac.Location = New System.Drawing.Point(200, 144)
        Me.dtp_fecha_nac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_fecha_nac.Name = "dtp_fecha_nac"
        Me.dtp_fecha_nac.Size = New System.Drawing.Size(265, 22)
        Me.dtp_fecha_nac.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 151)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha de Nacimiento *"
        '
        'lbl_ape
        '
        Me.lbl_ape.AutoSize = True
        Me.lbl_ape.Location = New System.Drawing.Point(101, 27)
        Me.lbl_ape.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ape.Name = "lbl_ape"
        Me.lbl_ape.Size = New System.Drawing.Size(67, 17)
        Me.lbl_ape.TabIndex = 0
        Me.lbl_ape.Text = "Apellido *"
        '
        'txt_ape
        '
        Me.txt_ape.Enabled = False
        Me.txt_ape.Location = New System.Drawing.Point(200, 23)
        Me.txt_ape.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ape.Name = "txt_ape"
        Me.txt_ape.Size = New System.Drawing.Size(265, 22)
        Me.txt_ape.TabIndex = 0
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Location = New System.Drawing.Point(101, 65)
        Me.lbl_nom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(67, 17)
        Me.lbl_nom.TabIndex = 5
        Me.lbl_nom.Text = "Nombre *"
        '
        'txt_nom
        '
        Me.txt_nom.Enabled = False
        Me.txt_nom.Location = New System.Drawing.Point(200, 63)
        Me.txt_nom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(265, 22)
        Me.txt_nom.TabIndex = 1
        '
        'lbl_cuil
        '
        Me.lbl_cuil.AutoSize = True
        Me.lbl_cuil.Location = New System.Drawing.Point(119, 107)
        Me.lbl_cuil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cuil.Name = "lbl_cuil"
        Me.lbl_cuil.Size = New System.Drawing.Size(47, 17)
        Me.lbl_cuil.TabIndex = 1
        Me.lbl_cuil.Text = "CUIL *"
        '
        'txt_hora_egreso
        '
        Me.txt_hora_egreso.Enabled = False
        Me.txt_hora_egreso.Location = New System.Drawing.Point(132, 87)
        Me.txt_hora_egreso.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_hora_egreso.Mask = "00:00"
        Me.txt_hora_egreso.Name = "txt_hora_egreso"
        Me.txt_hora_egreso.Size = New System.Drawing.Size(49, 22)
        Me.txt_hora_egreso.TabIndex = 10
        Me.txt_hora_egreso.ValidatingType = GetType(Date)
        '
        'txt_hora_ingreso
        '
        Me.txt_hora_ingreso.Enabled = False
        Me.txt_hora_ingreso.Location = New System.Drawing.Point(132, 55)
        Me.txt_hora_ingreso.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_hora_ingreso.Mask = "00:00"
        Me.txt_hora_ingreso.Name = "txt_hora_ingreso"
        Me.txt_hora_ingreso.Size = New System.Drawing.Size(49, 22)
        Me.txt_hora_ingreso.TabIndex = 9
        Me.txt_hora_ingreso.ValidatingType = GetType(Date)
        '
        'frm_registrar_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 837)
        Me.Controls.Add(Me.grp_domicilio)
        Me.Controls.Add(Me.grp_datos_laborales)
        Me.Controls.Add(Me.grp_datos_personales)
        Me.Controls.Add(Me.cmd_eliminar_por_cuil)
        Me.Controls.Add(Me.lbl_advertencia)
        Me.Controls.Add(Me.chk_filtro_cargo)
        Me.Controls.Add(Me.lbl_filtro_nombre_apellido)
        Me.Controls.Add(Me.txt_filtro_nombre_apellido)
        Me.Controls.Add(Me.cmb_filtro_cargo)
        Me.Controls.Add(Me.lbl_campos_obligatorios)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Controls.Add(Me.grp_empleados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1141, 884)
        Me.MinimumSize = New System.Drawing.Size(1141, 883)
        Me.Name = "frm_registrar_empleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Empleado"
        CType(Me.grid_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_empleados.ResumeLayout(False)
        Me.grp_domicilio.ResumeLayout(False)
        Me.grp_domicilio.PerformLayout()
        Me.grp_datos_laborales.ResumeLayout(False)
        Me.grp_datos_laborales.PerformLayout()
        Me.grp_datos_personales.ResumeLayout(False)
        Me.grp_datos_personales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents grp_empleados As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_registrar As System.Windows.Forms.Button
    Friend WithEvents lbl_campos_obligatorios As System.Windows.Forms.Label
    Friend WithEvents cmb_filtro_cargo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_filtro_nombre_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_filtro_nombre_apellido As System.Windows.Forms.Label
    Friend WithEvents chk_filtro_cargo As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_advertencia As System.Windows.Forms.Label
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ape As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_nacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents piso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents departamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_egreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_eliminar_por_cuil As System.Windows.Forms.Button
    Friend WithEvents grp_domicilio As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_loc As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents txt_depto As System.Windows.Forms.TextBox
    Friend WithEvents txt_piso As System.Windows.Forms.TextBox
    Friend WithEvents lbl_depto As System.Windows.Forms.Label
    Friend WithEvents lbl_piso As System.Windows.Forms.Label
    Friend WithEvents txt_nro_calle As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nro As System.Windows.Forms.Label
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents grp_datos_laborales As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_cargo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_hora_egreso As System.Windows.Forms.Label
    Friend WithEvents lbl_hora_ingreso As System.Windows.Forms.Label
    Friend WithEvents lbl_cargo As System.Windows.Forms.Label
    Friend WithEvents grp_datos_personales As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_cuil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_celular As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_celular As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_nac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_ape As System.Windows.Forms.Label
    Friend WithEvents txt_ape As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nom As System.Windows.Forms.Label
    Friend WithEvents txt_nom As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cuil As System.Windows.Forms.Label
    Friend WithEvents txt_hora_egreso As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_hora_ingreso As System.Windows.Forms.MaskedTextBox

End Class
