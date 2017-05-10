<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_paciente
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
        Me.cmb_eliminar_por_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.lbl_eliminar = New System.Windows.Forms.Label()
        Me.lbl_eliminar_por_doc = New System.Windows.Forms.Label()
        Me.cmd_eliminar_por_doc = New System.Windows.Forms.Button()
        Me.cmd_eliminar_fila_seleccionada = New System.Windows.Forms.Button()
        Me.lbl_asterisco = New System.Windows.Forms.Label()
        Me.lbl_nro = New System.Windows.Forms.Label()
        Me.grid_pacientes = New System.Windows.Forms.DataGridView()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.piso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_advertencia = New System.Windows.Forms.Label()
        Me.grp_domicilio = New System.Windows.Forms.GroupBox()
        Me.cmb_loc = New System.Windows.Forms.ComboBox()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.txt_depto = New System.Windows.Forms.TextBox()
        Me.txt_piso = New System.Windows.Forms.TextBox()
        Me.lbl_depto = New System.Windows.Forms.Label()
        Me.lbl_piso = New System.Windows.Forms.Label()
        Me.txt_nro_calle = New System.Windows.Forms.TextBox()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.grp_datos_personales = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rb_hombre = New System.Windows.Forms.RadioButton()
        Me.rb_mujer = New System.Windows.Forms.RadioButton()
        Me.cmb_tipo_doc = New System.Windows.Forms.ComboBox()
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
        Me.lbl_nro_doc = New System.Windows.Forms.Label()
        Me.txt_nro_doc = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_tipo_documento = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbl_eliminar_por_tipo_doc = New System.Windows.Forms.Label()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.grp_pacientes = New System.Windows.Forms.GroupBox()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_filtro_nombre_apellido = New System.Windows.Forms.TextBox()
        Me.txt_eliminar_por_doc = New System.Windows.Forms.MaskedTextBox()
        CType(Me.grid_pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grp_domicilio.SuspendLayout()
        Me.grp_datos_personales.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grp_pacientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_eliminar_por_tipo_doc
        '
        Me.cmb_eliminar_por_tipo_doc.FormattingEnabled = True
        Me.cmb_eliminar_por_tipo_doc.Location = New System.Drawing.Point(280, 76)
        Me.cmb_eliminar_por_tipo_doc.Name = "cmb_eliminar_por_tipo_doc"
        Me.cmb_eliminar_por_tipo_doc.Size = New System.Drawing.Size(60, 21)
        Me.cmb_eliminar_por_tipo_doc.TabIndex = 32
        '
        'lbl_eliminar
        '
        Me.lbl_eliminar.AutoSize = True
        Me.lbl_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_eliminar.Location = New System.Drawing.Point(24, 15)
        Me.lbl_eliminar.Name = "lbl_eliminar"
        Me.lbl_eliminar.Size = New System.Drawing.Size(760, 16)
        Me.lbl_eliminar.TabIndex = 29
        Me.lbl_eliminar.Text = "Ingrese el tipo y numero de documento del paciente o seleccione la fila que muest" & _
    "ra los datos del paciente que desea eliminar"
        '
        'lbl_eliminar_por_doc
        '
        Me.lbl_eliminar_por_doc.AutoSize = True
        Me.lbl_eliminar_por_doc.Location = New System.Drawing.Point(349, 80)
        Me.lbl_eliminar_por_doc.Name = "lbl_eliminar_por_doc"
        Me.lbl_eliminar_por_doc.Size = New System.Drawing.Size(44, 13)
        Me.lbl_eliminar_por_doc.TabIndex = 28
        Me.lbl_eliminar_por_doc.Text = "NroDoc"
        '
        'cmd_eliminar_por_doc
        '
        Me.cmd_eliminar_por_doc.Location = New System.Drawing.Point(483, 75)
        Me.cmd_eliminar_por_doc.Name = "cmd_eliminar_por_doc"
        Me.cmd_eliminar_por_doc.Size = New System.Drawing.Size(112, 23)
        Me.cmd_eliminar_por_doc.TabIndex = 27
        Me.cmd_eliminar_por_doc.Text = "Eliminar"
        Me.cmd_eliminar_por_doc.UseVisualStyleBackColor = True
        '
        'cmd_eliminar_fila_seleccionada
        '
        Me.cmd_eliminar_fila_seleccionada.Location = New System.Drawing.Point(223, 111)
        Me.cmd_eliminar_fila_seleccionada.Name = "cmd_eliminar_fila_seleccionada"
        Me.cmd_eliminar_fila_seleccionada.Size = New System.Drawing.Size(373, 23)
        Me.cmd_eliminar_fila_seleccionada.TabIndex = 25
        Me.cmd_eliminar_fila_seleccionada.Text = "Eliminar Fila Seleccionada"
        Me.cmd_eliminar_fila_seleccionada.UseVisualStyleBackColor = True
        '
        'lbl_asterisco
        '
        Me.lbl_asterisco.AutoSize = True
        Me.lbl_asterisco.Location = New System.Drawing.Point(697, 242)
        Me.lbl_asterisco.Name = "lbl_asterisco"
        Me.lbl_asterisco.Size = New System.Drawing.Size(108, 13)
        Me.lbl_asterisco.TabIndex = 38
        Me.lbl_asterisco.Text = "* Campos obligatorios"
        '
        'lbl_nro
        '
        Me.lbl_nro.AutoSize = True
        Me.lbl_nro.Location = New System.Drawing.Point(226, 22)
        Me.lbl_nro.Name = "lbl_nro"
        Me.lbl_nro.Size = New System.Drawing.Size(31, 13)
        Me.lbl_nro.TabIndex = 2
        Me.lbl_nro.Text = "Nro *"
        '
        'grid_pacientes
        '
        Me.grid_pacientes.AllowUserToAddRows = False
        Me.grid_pacientes.AllowUserToDeleteRows = False
        Me.grid_pacientes.AllowUserToResizeColumns = False
        Me.grid_pacientes.AllowUserToResizeRows = False
        Me.grid_pacientes.ColumnHeadersHeight = 30
        Me.grid_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_pacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nom, Me.ape, Me.tipoDoc, Me.id_tipo_documento, Me.nroDoc, Me.sexo, Me.fecha_nacimiento, Me.telefono, Me.celular, Me.id_localidad, Me.calle, Me.nro_calle, Me.piso, Me.departamento})
        Me.grid_pacientes.Cursor = System.Windows.Forms.Cursors.Cross
        Me.grid_pacientes.Location = New System.Drawing.Point(12, 20)
        Me.grid_pacientes.Name = "grid_pacientes"
        Me.grid_pacientes.ReadOnly = True
        Me.grid_pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_pacientes.Size = New System.Drawing.Size(790, 254)
        Me.grid_pacientes.TabIndex = 17
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
        'tipoDoc
        '
        Me.tipoDoc.FillWeight = 50.0!
        Me.tipoDoc.HeaderText = "TipoDoc"
        Me.tipoDoc.Name = "tipoDoc"
        Me.tipoDoc.ReadOnly = True
        Me.tipoDoc.Width = 123
        '
        'id_tipo_documento
        '
        Me.id_tipo_documento.FillWeight = 2.0!
        Me.id_tipo_documento.HeaderText = "id_tipo_documento"
        Me.id_tipo_documento.MinimumWidth = 2
        Me.id_tipo_documento.Name = "id_tipo_documento"
        Me.id_tipo_documento.ReadOnly = True
        Me.id_tipo_documento.Visible = False
        Me.id_tipo_documento.Width = 2
        '
        'nroDoc
        '
        Me.nroDoc.FillWeight = 50.0!
        Me.nroDoc.HeaderText = "NroDoc"
        Me.nroDoc.Name = "nroDoc"
        Me.nroDoc.ReadOnly = True
        Me.nroDoc.Width = 123
        '
        'sexo
        '
        Me.sexo.HeaderText = "sexo"
        Me.sexo.Name = "sexo"
        Me.sexo.ReadOnly = True
        Me.sexo.Visible = False
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
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(150, 108)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(200, 23)
        Me.cmd_buscar.TabIndex = 13
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(819, 306)
        Me.TabControl1.TabIndex = 37
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.lbl_advertencia)
        Me.TabPage1.Controls.Add(Me.grp_domicilio)
        Me.TabPage1.Controls.Add(Me.grp_datos_personales)
        Me.TabPage1.Controls.Add(Me.lbl_asterisco)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(811, 280)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar"
        '
        'lbl_advertencia
        '
        Me.lbl_advertencia.AutoSize = True
        Me.lbl_advertencia.Location = New System.Drawing.Point(536, 259)
        Me.lbl_advertencia.Name = "lbl_advertencia"
        Me.lbl_advertencia.Size = New System.Drawing.Size(269, 13)
        Me.lbl_advertencia.TabIndex = 39
        Me.lbl_advertencia.Text = "-Debe especificar al menos 1 (uno) numero de contacto"
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
        Me.grp_domicilio.Location = New System.Drawing.Point(401, 9)
        Me.grp_domicilio.Name = "grp_domicilio"
        Me.grp_domicilio.Size = New System.Drawing.Size(397, 106)
        Me.grp_domicilio.TabIndex = 19
        Me.grp_domicilio.TabStop = False
        Me.grp_domicilio.Text = "Domicilio"
        '
        'cmb_loc
        '
        Me.cmb_loc.Enabled = False
        Me.cmb_loc.FormattingEnabled = True
        Me.cmb_loc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmb_loc.Location = New System.Drawing.Point(99, 73)
        Me.cmb_loc.Name = "cmb_loc"
        Me.cmb_loc.Size = New System.Drawing.Size(278, 21)
        Me.cmb_loc.TabIndex = 10
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(25, 76)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(60, 13)
        Me.lbl_localidad.TabIndex = 8
        Me.lbl_localidad.Text = "Localidad *"
        '
        'txt_depto
        '
        Me.txt_depto.Enabled = False
        Me.txt_depto.Location = New System.Drawing.Point(277, 45)
        Me.txt_depto.Name = "txt_depto"
        Me.txt_depto.Size = New System.Drawing.Size(100, 20)
        Me.txt_depto.TabIndex = 7
        '
        'txt_piso
        '
        Me.txt_piso.Enabled = False
        Me.txt_piso.Location = New System.Drawing.Point(99, 46)
        Me.txt_piso.Name = "txt_piso"
        Me.txt_piso.Size = New System.Drawing.Size(100, 20)
        Me.txt_piso.TabIndex = 6
        '
        'lbl_depto
        '
        Me.lbl_depto.AutoSize = True
        Me.lbl_depto.Location = New System.Drawing.Point(214, 49)
        Me.lbl_depto.Name = "lbl_depto"
        Me.lbl_depto.Size = New System.Drawing.Size(36, 13)
        Me.lbl_depto.TabIndex = 5
        Me.lbl_depto.Text = "Depto"
        '
        'lbl_piso
        '
        Me.lbl_piso.AutoSize = True
        Me.lbl_piso.Location = New System.Drawing.Point(51, 49)
        Me.lbl_piso.Name = "lbl_piso"
        Me.lbl_piso.Size = New System.Drawing.Size(27, 13)
        Me.lbl_piso.TabIndex = 4
        Me.lbl_piso.Text = "Piso"
        '
        'txt_nro_calle
        '
        Me.txt_nro_calle.Enabled = False
        Me.txt_nro_calle.Location = New System.Drawing.Point(277, 19)
        Me.txt_nro_calle.Name = "txt_nro_calle"
        Me.txt_nro_calle.Size = New System.Drawing.Size(100, 20)
        Me.txt_nro_calle.TabIndex = 3
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(48, 22)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(37, 13)
        Me.lbl_calle.TabIndex = 1
        Me.lbl_calle.Text = "Calle *"
        '
        'txt_calle
        '
        Me.txt_calle.Enabled = False
        Me.txt_calle.Location = New System.Drawing.Point(99, 19)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(100, 20)
        Me.txt_calle.TabIndex = 0
        '
        'grp_datos_personales
        '
        Me.grp_datos_personales.Controls.Add(Me.cmd_buscar)
        Me.grp_datos_personales.Controls.Add(Me.Label2)
        Me.grp_datos_personales.Controls.Add(Me.rb_hombre)
        Me.grp_datos_personales.Controls.Add(Me.rb_mujer)
        Me.grp_datos_personales.Controls.Add(Me.cmb_tipo_doc)
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
        Me.grp_datos_personales.Controls.Add(Me.lbl_nro_doc)
        Me.grp_datos_personales.Controls.Add(Me.txt_nro_doc)
        Me.grp_datos_personales.Controls.Add(Me.lbl_tipo_documento)
        Me.grp_datos_personales.Location = New System.Drawing.Point(8, 9)
        Me.grp_datos_personales.Name = "grp_datos_personales"
        Me.grp_datos_personales.Size = New System.Drawing.Size(374, 268)
        Me.grp_datos_personales.TabIndex = 17
        Me.grp_datos_personales.TabStop = False
        Me.grp_datos_personales.Text = "Datos Personales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Sexo*"
        '
        'rb_hombre
        '
        Me.rb_hombre.AutoSize = True
        Me.rb_hombre.Enabled = False
        Me.rb_hombre.Location = New System.Drawing.Point(150, 152)
        Me.rb_hombre.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_hombre.Name = "rb_hombre"
        Me.rb_hombre.Size = New System.Drawing.Size(62, 17)
        Me.rb_hombre.TabIndex = 16
        Me.rb_hombre.TabStop = True
        Me.rb_hombre.Text = "Hombre"
        Me.rb_hombre.UseVisualStyleBackColor = True
        '
        'rb_mujer
        '
        Me.rb_mujer.Enabled = False
        Me.rb_mujer.Location = New System.Drawing.Point(214, 153)
        Me.rb_mujer.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_mujer.Name = "rb_mujer"
        Me.rb_mujer.Size = New System.Drawing.Size(59, 15)
        Me.rb_mujer.TabIndex = 15
        Me.rb_mujer.TabStop = True
        Me.rb_mujer.Text = "Mujer"
        Me.rb_mujer.UseVisualStyleBackColor = True
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(150, 82)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(66, 21)
        Me.cmb_tipo_doc.TabIndex = 8
        '
        'txt_celular
        '
        Me.txt_celular.Enabled = False
        Me.txt_celular.Location = New System.Drawing.Point(150, 243)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(200, 20)
        Me.txt_celular.TabIndex = 12
        '
        'txt_telefono
        '
        Me.txt_telefono.Enabled = False
        Me.txt_telefono.Location = New System.Drawing.Point(150, 210)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(200, 20)
        Me.txt_telefono.TabIndex = 11
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.Location = New System.Drawing.Point(96, 244)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(39, 13)
        Me.lbl_celular.TabIndex = 10
        Me.lbl_celular.Text = "Celular"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(87, 211)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telefono.TabIndex = 9
        Me.lbl_telefono.Text = "Teléfono"
        '
        'dtp_fecha_nac
        '
        Me.dtp_fecha_nac.Enabled = False
        Me.dtp_fecha_nac.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtp_fecha_nac.Location = New System.Drawing.Point(150, 177)
        Me.dtp_fecha_nac.Name = "dtp_fecha_nac"
        Me.dtp_fecha_nac.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fecha_nac.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha de Nacimiento *"
        '
        'lbl_ape
        '
        Me.lbl_ape.AutoSize = True
        Me.lbl_ape.Location = New System.Drawing.Point(93, 22)
        Me.lbl_ape.Name = "lbl_ape"
        Me.lbl_ape.Size = New System.Drawing.Size(51, 13)
        Me.lbl_ape.TabIndex = 0
        Me.lbl_ape.Text = "Apellido *"
        '
        'txt_ape
        '
        Me.txt_ape.Enabled = False
        Me.txt_ape.Location = New System.Drawing.Point(150, 19)
        Me.txt_ape.Name = "txt_ape"
        Me.txt_ape.Size = New System.Drawing.Size(200, 20)
        Me.txt_ape.TabIndex = 0
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Location = New System.Drawing.Point(93, 45)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(51, 13)
        Me.lbl_nom.TabIndex = 5
        Me.lbl_nom.Text = "Nombre *"
        '
        'txt_nom
        '
        Me.txt_nom.Enabled = False
        Me.txt_nom.Location = New System.Drawing.Point(150, 42)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(200, 20)
        Me.txt_nom.TabIndex = 1
        '
        'lbl_nro_doc
        '
        Me.lbl_nro_doc.AutoSize = True
        Me.lbl_nro_doc.Location = New System.Drawing.Point(222, 85)
        Me.lbl_nro_doc.Name = "lbl_nro_doc"
        Me.lbl_nro_doc.Size = New System.Drawing.Size(51, 13)
        Me.lbl_nro_doc.TabIndex = 13
        Me.lbl_nro_doc.Text = "Nro Doc*"
        '
        'txt_nro_doc
        '
        Me.txt_nro_doc.Location = New System.Drawing.Point(278, 84)
        Me.txt_nro_doc.Mask = "00-000-000"
        Me.txt_nro_doc.Name = "txt_nro_doc"
        Me.txt_nro_doc.Size = New System.Drawing.Size(72, 20)
        Me.txt_nro_doc.TabIndex = 11
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = True
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(82, 88)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(55, 13)
        Me.lbl_tipo_documento.TabIndex = 1
        Me.lbl_tipo_documento.Text = "Tipo Doc*"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.txt_eliminar_por_doc)
        Me.TabPage2.Controls.Add(Me.cmb_eliminar_por_tipo_doc)
        Me.TabPage2.Controls.Add(Me.lbl_eliminar_por_tipo_doc)
        Me.TabPage2.Controls.Add(Me.lbl_eliminar)
        Me.TabPage2.Controls.Add(Me.lbl_eliminar_por_doc)
        Me.TabPage2.Controls.Add(Me.cmd_eliminar_por_doc)
        Me.TabPage2.Controls.Add(Me.cmd_eliminar_fila_seleccionada)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(811, 280)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Eliminar"
        '
        'lbl_eliminar_por_tipo_doc
        '
        Me.lbl_eliminar_por_tipo_doc.AutoSize = True
        Me.lbl_eliminar_por_tipo_doc.Location = New System.Drawing.Point(220, 80)
        Me.lbl_eliminar_por_tipo_doc.Name = "lbl_eliminar_por_tipo_doc"
        Me.lbl_eliminar_por_tipo_doc.Size = New System.Drawing.Size(51, 13)
        Me.lbl_eliminar_por_tipo_doc.TabIndex = 31
        Me.lbl_eliminar_por_tipo_doc.Text = "Tipo Doc"
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_nuevo.Location = New System.Drawing.Point(496, 646)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(89, 23)
        Me.cmd_nuevo.TabIndex = 36
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir.Location = New System.Drawing.Point(722, 646)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(89, 23)
        Me.cmd_salir.TabIndex = 35
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'grp_pacientes
        '
        Me.grp_pacientes.Controls.Add(Me.grid_pacientes)
        Me.grp_pacientes.Location = New System.Drawing.Point(10, 360)
        Me.grp_pacientes.Name = "grp_pacientes"
        Me.grp_pacientes.Size = New System.Drawing.Size(819, 280)
        Me.grp_pacientes.TabIndex = 33
        Me.grp_pacientes.TabStop = False
        Me.grp_pacientes.Text = "Pacientes"
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Enabled = False
        Me.cmd_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_registrar.Location = New System.Drawing.Point(609, 646)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(89, 23)
        Me.cmd_registrar.TabIndex = 34
        Me.cmd_registrar.Text = "Guardar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Filtrar por nombre y/o apellido"
        '
        'txt_filtro_nombre_apellido
        '
        Me.txt_filtro_nombre_apellido.Location = New System.Drawing.Point(177, 334)
        Me.txt_filtro_nombre_apellido.Name = "txt_filtro_nombre_apellido"
        Me.txt_filtro_nombre_apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_filtro_nombre_apellido.TabIndex = 21
        '
        'txt_eliminar_por_doc
        '
        Me.txt_eliminar_por_doc.Location = New System.Drawing.Point(402, 76)
        Me.txt_eliminar_por_doc.Mask = "00-000-000"
        Me.txt_eliminar_por_doc.Name = "txt_eliminar_por_doc"
        Me.txt_eliminar_por_doc.Size = New System.Drawing.Size(72, 20)
        Me.txt_eliminar_por_doc.TabIndex = 33
        '
        'frm_registrar_paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 684)
        Me.Controls.Add(Me.txt_filtro_nombre_apellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.grp_pacientes)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(858, 723)
        Me.MinimumSize = New System.Drawing.Size(858, 723)
        Me.Name = "frm_registrar_paciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Paciente"
        CType(Me.grid_pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grp_domicilio.ResumeLayout(False)
        Me.grp_domicilio.PerformLayout()
        Me.grp_datos_personales.ResumeLayout(False)
        Me.grp_datos_personales.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.grp_pacientes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_eliminar_por_tipo_doc As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_eliminar As System.Windows.Forms.Label
    Friend WithEvents lbl_eliminar_por_doc As System.Windows.Forms.Label
    Friend WithEvents cmd_eliminar_por_doc As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_fila_seleccionada As System.Windows.Forms.Button
    Friend WithEvents lbl_asterisco As System.Windows.Forms.Label
    Friend WithEvents lbl_nro As System.Windows.Forms.Label
    Friend WithEvents grid_pacientes As System.Windows.Forms.DataGridView
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ape As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nroDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_nacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents piso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents departamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grp_domicilio As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_loc As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents txt_depto As System.Windows.Forms.TextBox
    Friend WithEvents txt_piso As System.Windows.Forms.TextBox
    Friend WithEvents lbl_depto As System.Windows.Forms.Label
    Friend WithEvents lbl_piso As System.Windows.Forms.Label
    Friend WithEvents txt_nro_calle As System.Windows.Forms.TextBox
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents grp_datos_personales As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents rb_hombre As System.Windows.Forms.RadioButton
    Protected WithEvents rb_mujer As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_tipo_doc As System.Windows.Forms.ComboBox
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
    Friend WithEvents lbl_nro_doc As System.Windows.Forms.Label
    Friend WithEvents txt_nro_doc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_eliminar_por_tipo_doc As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents grp_pacientes As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_registrar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_filtro_nombre_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_advertencia As System.Windows.Forms.Label
    Friend WithEvents txt_eliminar_por_doc As System.Windows.Forms.MaskedTextBox

End Class
