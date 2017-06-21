<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_intervenciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_intervenciones))
        Me.cmb_paciente = New System.Windows.Forms.ComboBox()
        Me.lbl_paciente = New System.Windows.Forms.Label()
        Me.cmd_buscar_turno = New System.Windows.Forms.Button()
        Me.cmb_tratamientos = New System.Windows.Forms.ComboBox()
        Me.lbl_tratamiento = New System.Windows.Forms.Label()
        Me.cmd_agregar_tratamiento = New System.Windows.Forms.Button()
        Me.cmb_insumos = New System.Windows.Forms.ComboBox()
        Me.nud_cantidad_insumo = New System.Windows.Forms.NumericUpDown()
        Me.lbl_insumo = New System.Windows.Forms.Label()
        Me.grp_tratamientos = New System.Windows.Forms.GroupBox()
        Me.grid_tratamientos = New System.Windows.Forms.DataGridView()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tratamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_nro_tratamiento = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_nro_tratamiento = New System.Windows.Forms.Label()
        Me.cmd_remover_tratamiento = New System.Windows.Forms.Button()
        Me.grp_insumos = New System.Windows.Forms.GroupBox()
        Me.grid_insumos = New System.Windows.Forms.DataGridView()
        Me.nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion_insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_remover_insumo = New System.Windows.Forms.Button()
        Me.lbl_nro_insumo = New System.Windows.Forms.Label()
        Me.txt_nro_insumo = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_agregar_insumo = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.txt_empleado = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tratamientos = New System.Windows.Forms.TabPage()
        Me.txt_monto_total = New System.Windows.Forms.TextBox()
        Me.lbl_monto_total = New System.Windows.Forms.Label()
        Me.insumos = New System.Windows.Forms.TabPage()
        Me.grid_datos_turno = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt__observaciones_turno = New System.Windows.Forms.RichTextBox()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_hora_hasta = New System.Windows.Forms.Label()
        Me.lbl_hora_desde = New System.Windows.Forms.Label()
        Me.txt_hora_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_hora_desde = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt__observaciones_intervencion = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.nud_cantidad_insumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_tratamientos.SuspendLayout()
        CType(Me.grid_tratamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_insumos.SuspendLayout()
        CType(Me.grid_insumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tratamientos.SuspendLayout()
        Me.insumos.SuspendLayout()
        Me.grid_datos_turno.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_paciente
        '
        Me.cmb_paciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_paciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_paciente.FormattingEnabled = True
        Me.cmb_paciente.Location = New System.Drawing.Point(132, 30)
        Me.cmb_paciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_paciente.Name = "cmb_paciente"
        Me.cmb_paciente.Size = New System.Drawing.Size(241, 24)
        Me.cmb_paciente.TabIndex = 8
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Location = New System.Drawing.Point(49, 33)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(72, 17)
        Me.lbl_paciente.TabIndex = 6
        Me.lbl_paciente.Text = "Paciente *"
        '
        'cmd_buscar_turno
        '
        Me.cmd_buscar_turno.Location = New System.Drawing.Point(392, 27)
        Me.cmd_buscar_turno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_buscar_turno.Name = "cmd_buscar_turno"
        Me.cmd_buscar_turno.Size = New System.Drawing.Size(152, 28)
        Me.cmd_buscar_turno.TabIndex = 9
        Me.cmd_buscar_turno.Text = "Buscar Turno"
        Me.cmd_buscar_turno.UseVisualStyleBackColor = True
        '
        'cmb_tratamientos
        '
        Me.cmb_tratamientos.Enabled = False
        Me.cmb_tratamientos.FormattingEnabled = True
        Me.cmb_tratamientos.Location = New System.Drawing.Point(115, 20)
        Me.cmb_tratamientos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_tratamientos.Name = "cmb_tratamientos"
        Me.cmb_tratamientos.Size = New System.Drawing.Size(329, 24)
        Me.cmb_tratamientos.TabIndex = 10
        '
        'lbl_tratamiento
        '
        Me.lbl_tratamiento.AutoSize = True
        Me.lbl_tratamiento.Location = New System.Drawing.Point(16, 20)
        Me.lbl_tratamiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_tratamiento.Name = "lbl_tratamiento"
        Me.lbl_tratamiento.Size = New System.Drawing.Size(93, 17)
        Me.lbl_tratamiento.TabIndex = 11
        Me.lbl_tratamiento.Text = "Tratamiento *"
        '
        'cmd_agregar_tratamiento
        '
        Me.cmd_agregar_tratamiento.Enabled = False
        Me.cmd_agregar_tratamiento.Location = New System.Drawing.Point(481, 16)
        Me.cmd_agregar_tratamiento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_agregar_tratamiento.Name = "cmd_agregar_tratamiento"
        Me.cmd_agregar_tratamiento.Size = New System.Drawing.Size(135, 63)
        Me.cmd_agregar_tratamiento.TabIndex = 12
        Me.cmd_agregar_tratamiento.Text = "Agregar Tratamiento"
        Me.cmd_agregar_tratamiento.UseVisualStyleBackColor = True
        '
        'cmb_insumos
        '
        Me.cmb_insumos.Enabled = False
        Me.cmb_insumos.FormattingEnabled = True
        Me.cmb_insumos.Location = New System.Drawing.Point(92, 16)
        Me.cmb_insumos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_insumos.Name = "cmb_insumos"
        Me.cmb_insumos.Size = New System.Drawing.Size(256, 24)
        Me.cmb_insumos.TabIndex = 13
        '
        'nud_cantidad_insumo
        '
        Me.nud_cantidad_insumo.Enabled = False
        Me.nud_cantidad_insumo.Location = New System.Drawing.Point(363, 17)
        Me.nud_cantidad_insumo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nud_cantidad_insumo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_cantidad_insumo.Name = "nud_cantidad_insumo"
        Me.nud_cantidad_insumo.Size = New System.Drawing.Size(53, 22)
        Me.nud_cantidad_insumo.TabIndex = 14
        Me.nud_cantidad_insumo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_insumo
        '
        Me.lbl_insumo.AutoSize = True
        Me.lbl_insumo.Location = New System.Drawing.Point(24, 20)
        Me.lbl_insumo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_insumo.Name = "lbl_insumo"
        Me.lbl_insumo.Size = New System.Drawing.Size(62, 17)
        Me.lbl_insumo.TabIndex = 15
        Me.lbl_insumo.Text = "Insumo *"
        '
        'grp_tratamientos
        '
        Me.grp_tratamientos.Controls.Add(Me.grid_tratamientos)
        Me.grp_tratamientos.Location = New System.Drawing.Point(9, 86)
        Me.grp_tratamientos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_tratamientos.Name = "grp_tratamientos"
        Me.grp_tratamientos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_tratamientos.Size = New System.Drawing.Size(607, 167)
        Me.grp_tratamientos.TabIndex = 16
        Me.grp_tratamientos.TabStop = False
        Me.grp_tratamientos.Text = "Tratamientos"
        '
        'grid_tratamientos
        '
        Me.grid_tratamientos.AllowUserToAddRows = False
        Me.grid_tratamientos.AllowUserToDeleteRows = False
        Me.grid_tratamientos.AllowUserToResizeColumns = False
        Me.grid_tratamientos.AllowUserToResizeRows = False
        Me.grid_tratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_tratamientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num, Me.descripcion, Me.id_tratamiento, Me.costo})
        Me.grid_tratamientos.Location = New System.Drawing.Point(8, 23)
        Me.grid_tratamientos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_tratamientos.Name = "grid_tratamientos"
        Me.grid_tratamientos.Size = New System.Drawing.Size(591, 137)
        Me.grid_tratamientos.TabIndex = 0
        '
        'num
        '
        Me.num.HeaderText = "Nº"
        Me.num.Name = "num"
        Me.num.Width = 25
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 315
        '
        'id_tratamiento
        '
        Me.id_tratamiento.HeaderText = "id_tratamiento"
        Me.id_tratamiento.Name = "id_tratamiento"
        Me.id_tratamiento.Visible = False
        '
        'costo
        '
        Me.costo.HeaderText = "Costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        Me.costo.Width = 60
        '
        'txt_nro_tratamiento
        '
        Me.txt_nro_tratamiento.Enabled = False
        Me.txt_nro_tratamiento.Location = New System.Drawing.Point(123, 53)
        Me.txt_nro_tratamiento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nro_tratamiento.Mask = "99"
        Me.txt_nro_tratamiento.Name = "txt_nro_tratamiento"
        Me.txt_nro_tratamiento.Size = New System.Drawing.Size(25, 22)
        Me.txt_nro_tratamiento.TabIndex = 17
        '
        'lbl_nro_tratamiento
        '
        Me.lbl_nro_tratamiento.AutoSize = True
        Me.lbl_nro_tratamiento.Location = New System.Drawing.Point(5, 57)
        Me.lbl_nro_tratamiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nro_tratamiento.Name = "lbl_nro_tratamiento"
        Me.lbl_nro_tratamiento.Size = New System.Drawing.Size(103, 17)
        Me.lbl_nro_tratamiento.TabIndex = 18
        Me.lbl_nro_tratamiento.Text = "Nº Tratamiento"
        '
        'cmd_remover_tratamiento
        '
        Me.cmd_remover_tratamiento.Enabled = False
        Me.cmd_remover_tratamiento.Location = New System.Drawing.Point(172, 50)
        Me.cmd_remover_tratamiento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_remover_tratamiento.Name = "cmd_remover_tratamiento"
        Me.cmd_remover_tratamiento.Size = New System.Drawing.Size(273, 28)
        Me.cmd_remover_tratamiento.TabIndex = 19
        Me.cmd_remover_tratamiento.Text = "Remover Tratamiento"
        Me.cmd_remover_tratamiento.UseVisualStyleBackColor = True
        '
        'grp_insumos
        '
        Me.grp_insumos.Controls.Add(Me.grid_insumos)
        Me.grp_insumos.Location = New System.Drawing.Point(8, 86)
        Me.grp_insumos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_insumos.Name = "grp_insumos"
        Me.grp_insumos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_insumos.Size = New System.Drawing.Size(607, 202)
        Me.grp_insumos.TabIndex = 20
        Me.grp_insumos.TabStop = False
        Me.grp_insumos.Text = "Insumos"
        '
        'grid_insumos
        '
        Me.grid_insumos.AllowUserToAddRows = False
        Me.grid_insumos.AllowUserToDeleteRows = False
        Me.grid_insumos.AllowUserToResizeColumns = False
        Me.grid_insumos.AllowUserToResizeRows = False
        Me.grid_insumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_insumos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nro, Me.descripcion_insumo, Me.cantidad, Me.id_insumo})
        Me.grid_insumos.Location = New System.Drawing.Point(8, 23)
        Me.grid_insumos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_insumos.Name = "grid_insumos"
        Me.grid_insumos.Size = New System.Drawing.Size(591, 171)
        Me.grid_insumos.TabIndex = 0
        '
        'nro
        '
        Me.nro.HeaderText = "Nº"
        Me.nro.Name = "nro"
        Me.nro.ReadOnly = True
        Me.nro.Width = 25
        '
        'descripcion_insumo
        '
        Me.descripcion_insumo.HeaderText = "Descripcion"
        Me.descripcion_insumo.Name = "descripcion_insumo"
        Me.descripcion_insumo.ReadOnly = True
        Me.descripcion_insumo.Width = 300
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 75
        '
        'id_insumo
        '
        Me.id_insumo.HeaderText = "Insumo"
        Me.id_insumo.Name = "id_insumo"
        Me.id_insumo.Visible = False
        '
        'cmd_remover_insumo
        '
        Me.cmd_remover_insumo.Enabled = False
        Me.cmd_remover_insumo.Location = New System.Drawing.Point(143, 50)
        Me.cmd_remover_insumo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_remover_insumo.Name = "cmd_remover_insumo"
        Me.cmd_remover_insumo.Size = New System.Drawing.Size(273, 28)
        Me.cmd_remover_insumo.TabIndex = 23
        Me.cmd_remover_insumo.Text = "Remover Insumo"
        Me.cmd_remover_insumo.UseVisualStyleBackColor = True
        '
        'lbl_nro_insumo
        '
        Me.lbl_nro_insumo.AutoSize = True
        Me.lbl_nro_insumo.Location = New System.Drawing.Point(4, 57)
        Me.lbl_nro_insumo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nro_insumo.Name = "lbl_nro_insumo"
        Me.lbl_nro_insumo.Size = New System.Drawing.Size(72, 17)
        Me.lbl_nro_insumo.TabIndex = 22
        Me.lbl_nro_insumo.Text = "Nº Insumo"
        '
        'txt_nro_insumo
        '
        Me.txt_nro_insumo.Enabled = False
        Me.txt_nro_insumo.Location = New System.Drawing.Point(92, 53)
        Me.txt_nro_insumo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nro_insumo.Mask = "99"
        Me.txt_nro_insumo.Name = "txt_nro_insumo"
        Me.txt_nro_insumo.Size = New System.Drawing.Size(27, 22)
        Me.txt_nro_insumo.TabIndex = 21
        '
        'cmd_agregar_insumo
        '
        Me.cmd_agregar_insumo.Enabled = False
        Me.cmd_agregar_insumo.Location = New System.Drawing.Point(472, 16)
        Me.cmd_agregar_insumo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_agregar_insumo.Name = "cmd_agregar_insumo"
        Me.cmd_agregar_insumo.Size = New System.Drawing.Size(135, 62)
        Me.cmd_agregar_insumo.TabIndex = 24
        Me.cmd_agregar_insumo.Text = "Agregar Insumo"
        Me.cmd_agregar_insumo.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Enabled = False
        Me.cmd_guardar.Location = New System.Drawing.Point(401, 708)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(100, 28)
        Me.cmd_guardar.TabIndex = 25
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(527, 708)
        Me.cmd_salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(100, 28)
        Me.cmd_salir.TabIndex = 26
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(276, 708)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(100, 28)
        Me.cmd_nuevo.TabIndex = 27
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.Location = New System.Drawing.Point(40, 23)
        Me.lbl_empleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(71, 17)
        Me.lbl_empleado.TabIndex = 28
        Me.lbl_empleado.Text = "Empleado"
        '
        'txt_empleado
        '
        Me.txt_empleado.Location = New System.Drawing.Point(120, 20)
        Me.txt_empleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_empleado.Name = "txt_empleado"
        Me.txt_empleado.ReadOnly = True
        Me.txt_empleado.Size = New System.Drawing.Size(491, 22)
        Me.txt_empleado.TabIndex = 29
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tratamientos)
        Me.TabControl1.Controls.Add(Me.insumos)
        Me.TabControl1.Location = New System.Drawing.Point(16, 373)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(633, 327)
        Me.TabControl1.TabIndex = 30
        '
        'tratamientos
        '
        Me.tratamientos.Controls.Add(Me.txt_monto_total)
        Me.tratamientos.Controls.Add(Me.lbl_monto_total)
        Me.tratamientos.Controls.Add(Me.cmd_agregar_tratamiento)
        Me.tratamientos.Controls.Add(Me.cmb_tratamientos)
        Me.tratamientos.Controls.Add(Me.lbl_tratamiento)
        Me.tratamientos.Controls.Add(Me.grp_tratamientos)
        Me.tratamientos.Controls.Add(Me.txt_nro_tratamiento)
        Me.tratamientos.Controls.Add(Me.lbl_nro_tratamiento)
        Me.tratamientos.Controls.Add(Me.cmd_remover_tratamiento)
        Me.tratamientos.Location = New System.Drawing.Point(4, 25)
        Me.tratamientos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tratamientos.Name = "tratamientos"
        Me.tratamientos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tratamientos.Size = New System.Drawing.Size(625, 298)
        Me.tratamientos.TabIndex = 0
        Me.tratamientos.Text = "Tratamientos"
        Me.tratamientos.UseVisualStyleBackColor = True
        '
        'txt_monto_total
        '
        Me.txt_monto_total.Location = New System.Drawing.Point(472, 261)
        Me.txt_monto_total.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_monto_total.Name = "txt_monto_total"
        Me.txt_monto_total.ReadOnly = True
        Me.txt_monto_total.Size = New System.Drawing.Size(132, 22)
        Me.txt_monto_total.TabIndex = 21
        Me.txt_monto_total.Text = "$ 0"
        Me.txt_monto_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_monto_total
        '
        Me.lbl_monto_total.AutoSize = True
        Me.lbl_monto_total.Location = New System.Drawing.Point(379, 265)
        Me.lbl_monto_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_monto_total.Name = "lbl_monto_total"
        Me.lbl_monto_total.Size = New System.Drawing.Size(83, 17)
        Me.lbl_monto_total.TabIndex = 20
        Me.lbl_monto_total.Text = "Monto Total"
        '
        'insumos
        '
        Me.insumos.Controls.Add(Me.grp_insumos)
        Me.insumos.Controls.Add(Me.cmb_insumos)
        Me.insumos.Controls.Add(Me.nud_cantidad_insumo)
        Me.insumos.Controls.Add(Me.lbl_insumo)
        Me.insumos.Controls.Add(Me.txt_nro_insumo)
        Me.insumos.Controls.Add(Me.lbl_nro_insumo)
        Me.insumos.Controls.Add(Me.cmd_agregar_insumo)
        Me.insumos.Controls.Add(Me.cmd_remover_insumo)
        Me.insumos.Location = New System.Drawing.Point(4, 25)
        Me.insumos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.insumos.Name = "insumos"
        Me.insumos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.insumos.Size = New System.Drawing.Size(625, 298)
        Me.insumos.TabIndex = 1
        Me.insumos.Text = "Insumos"
        Me.insumos.UseVisualStyleBackColor = True
        '
        'grid_datos_turno
        '
        Me.grid_datos_turno.Controls.Add(Me.Label2)
        Me.grid_datos_turno.Controls.Add(Me.txt__observaciones_turno)
        Me.grid_datos_turno.Controls.Add(Me.txt_fecha)
        Me.grid_datos_turno.Controls.Add(Me.Label1)
        Me.grid_datos_turno.Controls.Add(Me.lbl_hora_hasta)
        Me.grid_datos_turno.Controls.Add(Me.lbl_hora_desde)
        Me.grid_datos_turno.Controls.Add(Me.txt_hora_hasta)
        Me.grid_datos_turno.Controls.Add(Me.txt_hora_desde)
        Me.grid_datos_turno.Controls.Add(Me.lbl_empleado)
        Me.grid_datos_turno.Controls.Add(Me.txt_empleado)
        Me.grid_datos_turno.Location = New System.Drawing.Point(16, 63)
        Me.grid_datos_turno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_datos_turno.Name = "grid_datos_turno"
        Me.grid_datos_turno.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_datos_turno.Size = New System.Drawing.Size(633, 198)
        Me.grid_datos_turno.TabIndex = 31
        Me.grid_datos_turno.TabStop = False
        Me.grid_datos_turno.Text = "Datos del Turno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Observaciones del turno"
        '
        'txt__observaciones_turno
        '
        Me.txt__observaciones_turno.Location = New System.Drawing.Point(15, 123)
        Me.txt__observaciones_turno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt__observaciones_turno.Name = "txt__observaciones_turno"
        Me.txt__observaciones_turno.ReadOnly = True
        Me.txt__observaciones_turno.Size = New System.Drawing.Size(597, 67)
        Me.txt__observaciones_turno.TabIndex = 36
        Me.txt__observaciones_turno.Text = ""
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(120, 54)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.ReadOnly = True
        Me.txt_fecha.Size = New System.Drawing.Size(89, 22)
        Me.txt_fecha.TabIndex = 35
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Fecha Turno"
        '
        'lbl_hora_hasta
        '
        Me.lbl_hora_hasta.AutoSize = True
        Me.lbl_hora_hasta.Location = New System.Drawing.Point(404, 59)
        Me.lbl_hora_hasta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_hora_hasta.Name = "lbl_hora_hasta"
        Me.lbl_hora_hasta.Size = New System.Drawing.Size(80, 17)
        Me.lbl_hora_hasta.TabIndex = 33
        Me.lbl_hora_hasta.Text = "Hora Hasta"
        '
        'lbl_hora_desde
        '
        Me.lbl_hora_desde.AutoSize = True
        Me.lbl_hora_desde.Location = New System.Drawing.Point(236, 59)
        Me.lbl_hora_desde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_hora_desde.Name = "lbl_hora_desde"
        Me.lbl_hora_desde.Size = New System.Drawing.Size(84, 17)
        Me.lbl_hora_desde.TabIndex = 32
        Me.lbl_hora_desde.Text = "Hora Desde"
        '
        'txt_hora_hasta
        '
        Me.txt_hora_hasta.Location = New System.Drawing.Point(493, 55)
        Me.txt_hora_hasta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_hora_hasta.Mask = "99:99"
        Me.txt_hora_hasta.Name = "txt_hora_hasta"
        Me.txt_hora_hasta.ReadOnly = True
        Me.txt_hora_hasta.Size = New System.Drawing.Size(44, 22)
        Me.txt_hora_hasta.TabIndex = 31
        '
        'txt_hora_desde
        '
        Me.txt_hora_desde.Location = New System.Drawing.Point(329, 55)
        Me.txt_hora_desde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_hora_desde.Mask = "99:99"
        Me.txt_hora_desde.Name = "txt_hora_desde"
        Me.txt_hora_desde.ReadOnly = True
        Me.txt_hora_desde.Size = New System.Drawing.Size(44, 22)
        Me.txt_hora_desde.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 265)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Observaciones de la intervencion "
        '
        'txt__observaciones_intervencion
        '
        Me.txt__observaciones_intervencion.Enabled = False
        Me.txt__observaciones_intervencion.Location = New System.Drawing.Point(33, 295)
        Me.txt__observaciones_intervencion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt__observaciones_intervencion.Name = "txt__observaciones_intervencion"
        Me.txt__observaciones_intervencion.Size = New System.Drawing.Size(597, 67)
        Me.txt__observaciones_intervencion.TabIndex = 38
        Me.txt__observaciones_intervencion.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(496, 367)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "* Campos obligatorios"
        '
        'frm_intervenciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 732)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt__observaciones_intervencion)
        Me.Controls.Add(Me.grid_datos_turno)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_buscar_turno)
        Me.Controls.Add(Me.cmb_paciente)
        Me.Controls.Add(Me.lbl_paciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(678, 779)
        Me.MinimumSize = New System.Drawing.Size(678, 779)
        Me.Name = "frm_intervenciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intervenciones"
        CType(Me.nud_cantidad_insumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_tratamientos.ResumeLayout(False)
        CType(Me.grid_tratamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_insumos.ResumeLayout(False)
        CType(Me.grid_insumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tratamientos.ResumeLayout(False)
        Me.tratamientos.PerformLayout()
        Me.insumos.ResumeLayout(False)
        Me.insumos.PerformLayout()
        Me.grid_datos_turno.ResumeLayout(False)
        Me.grid_datos_turno.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_paciente As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_turno As System.Windows.Forms.Button
    Friend WithEvents cmb_tratamientos As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tratamiento As System.Windows.Forms.Label
    Friend WithEvents cmd_agregar_tratamiento As System.Windows.Forms.Button
    Friend WithEvents cmb_insumos As System.Windows.Forms.ComboBox
    Friend WithEvents nud_cantidad_insumo As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_insumo As System.Windows.Forms.Label
    Friend WithEvents grp_tratamientos As System.Windows.Forms.GroupBox
    Friend WithEvents grid_tratamientos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nro_tratamiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_nro_tratamiento As System.Windows.Forms.Label
    Friend WithEvents cmd_remover_tratamiento As System.Windows.Forms.Button
    Friend WithEvents grp_insumos As System.Windows.Forms.GroupBox
    Friend WithEvents grid_insumos As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_remover_insumo As System.Windows.Forms.Button
    Friend WithEvents lbl_nro_insumo As System.Windows.Forms.Label
    Friend WithEvents txt_nro_insumo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmd_agregar_insumo As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents lbl_empleado As System.Windows.Forms.Label
    Friend WithEvents txt_empleado As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tratamientos As System.Windows.Forms.TabPage
    Friend WithEvents insumos As System.Windows.Forms.TabPage
    Friend WithEvents grid_datos_turno As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_hora_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_hora_desde As System.Windows.Forms.Label
    Friend WithEvents txt_hora_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_hora_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt__observaciones_turno As System.Windows.Forms.RichTextBox
    Friend WithEvents nro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion_insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt__observaciones_intervencion As System.Windows.Forms.RichTextBox
    Friend WithEvents num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tratamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_monto_total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_monto_total As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
