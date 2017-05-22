<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_turnos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_turnos))
        Me.grid_turnos = New System.Windows.Forms.DataGridView()
        Me.fecha_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.cmb_empleado = New System.Windows.Forms.ComboBox()
        Me.cmb_paciente = New System.Windows.Forms.ComboBox()
        Me.chk_habilitar_interseccion = New System.Windows.Forms.CheckBox()
        Me.grp_grilla = New System.Windows.Forms.GroupBox()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.dtp_fecha_turno = New System.Windows.Forms.DateTimePicker()
        Me.lbl_hora_desde = New System.Windows.Forms.Label()
        Me.lbl_hasta = New System.Windows.Forms.Label()
        Me.grp_hora = New System.Windows.Forms.GroupBox()
        Me.dtp_hora_hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_hora_desde = New System.Windows.Forms.DateTimePicker()
        Me.lbl_paciente = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.grp_hora_empleado = New System.Windows.Forms.GroupBox()
        Me.txt_hora_egreso = New System.Windows.Forms.MaskedTextBox()
        Me.txt_hora_ingreso = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.lbl_egreso = New System.Windows.Forms.Label()
        Me.lbl_obsercaciones = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        CType(Me.grid_turnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_grilla.SuspendLayout()
        Me.grp_hora.SuspendLayout()
        Me.grp_hora_empleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_turnos
        '
        Me.grid_turnos.AllowUserToAddRows = False
        Me.grid_turnos.AllowUserToDeleteRows = False
        Me.grid_turnos.AllowUserToResizeColumns = False
        Me.grid_turnos.AllowUserToResizeRows = False
        Me.grid_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_turnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_turno, Me.hora_desde, Me.hora_hasta, Me.empleado, Me.id_empleado, Me.paciente, Me.id_paciente, Me.observaciones})
        Me.grid_turnos.Location = New System.Drawing.Point(12, 19)
        Me.grid_turnos.Margin = New System.Windows.Forms.Padding(2)
        Me.grid_turnos.Name = "grid_turnos"
        Me.grid_turnos.RowTemplate.Height = 24
        Me.grid_turnos.Size = New System.Drawing.Size(790, 271)
        Me.grid_turnos.TabIndex = 0
        '
        'fecha_turno
        '
        Me.fecha_turno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.fecha_turno.DefaultCellStyle = DataGridViewCellStyle1
        Me.fecha_turno.HeaderText = "Fecha Turno"
        Me.fecha_turno.Name = "fecha_turno"
        Me.fecha_turno.Width = 93
        '
        'hora_desde
        '
        Me.hora_desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.hora_desde.DefaultCellStyle = DataGridViewCellStyle2
        Me.hora_desde.HeaderText = "Hora Desde"
        Me.hora_desde.Name = "hora_desde"
        Me.hora_desde.Width = 89
        '
        'hora_hasta
        '
        Me.hora_hasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.hora_hasta.DefaultCellStyle = DataGridViewCellStyle3
        Me.hora_hasta.HeaderText = "Hora Hasta"
        Me.hora_hasta.Name = "hora_hasta"
        Me.hora_hasta.Width = 86
        '
        'empleado
        '
        Me.empleado.HeaderText = "Empleado"
        Me.empleado.Name = "empleado"
        Me.empleado.Width = 150
        '
        'id_empleado
        '
        Me.id_empleado.HeaderText = "id_empleado"
        Me.id_empleado.Name = "id_empleado"
        Me.id_empleado.Visible = False
        '
        'paciente
        '
        Me.paciente.HeaderText = "Paciente"
        Me.paciente.Name = "paciente"
        Me.paciente.Width = 150
        '
        'id_paciente
        '
        Me.id_paciente.HeaderText = "id_paciente"
        Me.id_paciente.Name = "id_paciente"
        Me.id_paciente.Visible = False
        '
        'observaciones
        '
        Me.observaciones.HeaderText = "Observaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.Width = 200
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.Location = New System.Drawing.Point(62, 63)
        Me.lbl_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_empleado.TabIndex = 1
        Me.lbl_empleado.Text = "Empleado"
        '
        'cmb_empleado
        '
        Me.cmb_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_empleado.FormattingEnabled = True
        Me.cmb_empleado.Location = New System.Drawing.Point(126, 60)
        Me.cmb_empleado.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_empleado.Name = "cmb_empleado"
        Me.cmb_empleado.Size = New System.Drawing.Size(182, 21)
        Me.cmb_empleado.TabIndex = 3
        '
        'cmb_paciente
        '
        Me.cmb_paciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_paciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_paciente.FormattingEnabled = True
        Me.cmb_paciente.Location = New System.Drawing.Point(126, 93)
        Me.cmb_paciente.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_paciente.Name = "cmb_paciente"
        Me.cmb_paciente.Size = New System.Drawing.Size(182, 21)
        Me.cmb_paciente.TabIndex = 4
        '
        'chk_habilitar_interseccion
        '
        Me.chk_habilitar_interseccion.AutoSize = True
        Me.chk_habilitar_interseccion.Checked = True
        Me.chk_habilitar_interseccion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_habilitar_interseccion.Location = New System.Drawing.Point(126, 129)
        Me.chk_habilitar_interseccion.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_habilitar_interseccion.Name = "chk_habilitar_interseccion"
        Me.chk_habilitar_interseccion.Size = New System.Drawing.Size(265, 17)
        Me.chk_habilitar_interseccion.TabIndex = 5
        Me.chk_habilitar_interseccion.Text = "Ver solo turnos de ese paciente con ese empleado"
        Me.chk_habilitar_interseccion.UseVisualStyleBackColor = True
        '
        'grp_grilla
        '
        Me.grp_grilla.Controls.Add(Me.grid_turnos)
        Me.grp_grilla.Location = New System.Drawing.Point(12, 301)
        Me.grp_grilla.Margin = New System.Windows.Forms.Padding(2)
        Me.grp_grilla.Name = "grp_grilla"
        Me.grp_grilla.Padding = New System.Windows.Forms.Padding(2)
        Me.grp_grilla.Size = New System.Drawing.Size(819, 296)
        Me.grp_grilla.TabIndex = 6
        Me.grp_grilla.TabStop = False
        Me.grp_grilla.Text = "Turnos"
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(498, 615)
        Me.cmd_Nuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(89, 23)
        Me.cmd_Nuevo.TabIndex = 7
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(384, 615)
        Me.cmd_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(89, 23)
        Me.cmd_eliminar.TabIndex = 8
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(611, 615)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(89, 23)
        Me.cmd_guardar.TabIndex = 9
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(724, 615)
        Me.cmd_salir.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(89, 23)
        Me.cmd_salir.TabIndex = 10
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'dtp_fecha_turno
        '
        Me.dtp_fecha_turno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtp_fecha_turno.Location = New System.Drawing.Point(524, 58)
        Me.dtp_fecha_turno.MinDate = New Date(2017, 5, 22, 0, 0, 0, 0)
        Me.dtp_fecha_turno.Name = "dtp_fecha_turno"
        Me.dtp_fecha_turno.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fecha_turno.TabIndex = 11
        '
        'lbl_hora_desde
        '
        Me.lbl_hora_desde.AutoSize = True
        Me.lbl_hora_desde.Location = New System.Drawing.Point(22, 20)
        Me.lbl_hora_desde.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_hora_desde.Name = "lbl_hora_desde"
        Me.lbl_hora_desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_hora_desde.TabIndex = 14
        Me.lbl_hora_desde.Text = "Desde"
        '
        'lbl_hasta
        '
        Me.lbl_hasta.AutoSize = True
        Me.lbl_hasta.Location = New System.Drawing.Point(26, 51)
        Me.lbl_hasta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_hasta.TabIndex = 15
        Me.lbl_hasta.Text = "Hasta"
        '
        'grp_hora
        '
        Me.grp_hora.Controls.Add(Me.dtp_hora_hasta)
        Me.grp_hora.Controls.Add(Me.lbl_hora_desde)
        Me.grp_hora.Controls.Add(Me.dtp_hora_desde)
        Me.grp_hora.Controls.Add(Me.lbl_hasta)
        Me.grp_hora.Location = New System.Drawing.Point(473, 95)
        Me.grp_hora.Margin = New System.Windows.Forms.Padding(2)
        Me.grp_hora.Name = "grp_hora"
        Me.grp_hora.Padding = New System.Windows.Forms.Padding(2)
        Me.grp_hora.Size = New System.Drawing.Size(150, 81)
        Me.grp_hora.TabIndex = 17
        Me.grp_hora.TabStop = False
        Me.grp_hora.Text = "Hora"
        '
        'dtp_hora_hasta
        '
        Me.dtp_hora_hasta.CustomFormat = "HH:mm"
        Me.dtp_hora_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_hora_hasta.Location = New System.Drawing.Point(71, 49)
        Me.dtp_hora_hasta.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_hora_hasta.Name = "dtp_hora_hasta"
        Me.dtp_hora_hasta.ShowUpDown = True
        Me.dtp_hora_hasta.Size = New System.Drawing.Size(50, 20)
        Me.dtp_hora_hasta.TabIndex = 21
        Me.dtp_hora_hasta.Value = New Date(2017, 5, 22, 0, 0, 0, 0)
        '
        'dtp_hora_desde
        '
        Me.dtp_hora_desde.CustomFormat = "HH:mm"
        Me.dtp_hora_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_hora_desde.Location = New System.Drawing.Point(71, 17)
        Me.dtp_hora_desde.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_hora_desde.Name = "dtp_hora_desde"
        Me.dtp_hora_desde.ShowUpDown = True
        Me.dtp_hora_desde.Size = New System.Drawing.Size(50, 20)
        Me.dtp_hora_desde.TabIndex = 20
        Me.dtp_hora_desde.Value = New Date(2017, 5, 22, 0, 0, 0, 0)
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Location = New System.Drawing.Point(68, 93)
        Me.lbl_paciente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(49, 13)
        Me.lbl_paciente.TabIndex = 2
        Me.lbl_paciente.Text = "Paciente"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(471, 61)
        Me.lbl_fecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 18
        Me.lbl_fecha.Text = "Fecha"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(320, 60)
        Me.cmd_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(89, 53)
        Me.cmd_buscar.TabIndex = 19
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'grp_hora_empleado
        '
        Me.grp_hora_empleado.Controls.Add(Me.txt_hora_egreso)
        Me.grp_hora_empleado.Controls.Add(Me.txt_hora_ingreso)
        Me.grp_hora_empleado.Controls.Add(Me.lbl_ingreso)
        Me.grp_hora_empleado.Controls.Add(Me.lbl_egreso)
        Me.grp_hora_empleado.Location = New System.Drawing.Point(636, 95)
        Me.grp_hora_empleado.Margin = New System.Windows.Forms.Padding(2)
        Me.grp_hora_empleado.Name = "grp_hora_empleado"
        Me.grp_hora_empleado.Padding = New System.Windows.Forms.Padding(2)
        Me.grp_hora_empleado.Size = New System.Drawing.Size(104, 81)
        Me.grp_hora_empleado.TabIndex = 22
        Me.grp_hora_empleado.TabStop = False
        Me.grp_hora_empleado.Text = "Empleado"
        '
        'txt_hora_egreso
        '
        Me.txt_hora_egreso.Enabled = False
        Me.txt_hora_egreso.Location = New System.Drawing.Point(64, 50)
        Me.txt_hora_egreso.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_hora_egreso.Mask = "00:00"
        Me.txt_hora_egreso.Name = "txt_hora_egreso"
        Me.txt_hora_egreso.Size = New System.Drawing.Size(36, 20)
        Me.txt_hora_egreso.TabIndex = 17
        Me.txt_hora_egreso.ValidatingType = GetType(Date)
        '
        'txt_hora_ingreso
        '
        Me.txt_hora_ingreso.Enabled = False
        Me.txt_hora_ingreso.Location = New System.Drawing.Point(64, 20)
        Me.txt_hora_ingreso.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_hora_ingreso.Mask = "00:00"
        Me.txt_hora_ingreso.Name = "txt_hora_ingreso"
        Me.txt_hora_ingreso.Size = New System.Drawing.Size(36, 20)
        Me.txt_hora_ingreso.TabIndex = 16
        Me.txt_hora_ingreso.ValidatingType = GetType(Date)
        '
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.Location = New System.Drawing.Point(22, 20)
        Me.lbl_ingreso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(42, 13)
        Me.lbl_ingreso.TabIndex = 14
        Me.lbl_ingreso.Text = "Ingreso"
        '
        'lbl_egreso
        '
        Me.lbl_egreso.AutoSize = True
        Me.lbl_egreso.Location = New System.Drawing.Point(26, 51)
        Me.lbl_egreso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_egreso.Name = "lbl_egreso"
        Me.lbl_egreso.Size = New System.Drawing.Size(40, 13)
        Me.lbl_egreso.TabIndex = 15
        Me.lbl_egreso.Text = "Egreso"
        '
        'lbl_obsercaciones
        '
        Me.lbl_obsercaciones.AutoSize = True
        Me.lbl_obsercaciones.Location = New System.Drawing.Point(38, 207)
        Me.lbl_obsercaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_obsercaciones.Name = "lbl_obsercaciones"
        Me.lbl_obsercaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_obsercaciones.TabIndex = 23
        Me.lbl_obsercaciones.Text = "Observaciones"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(126, 207)
        Me.txt_observaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(615, 72)
        Me.txt_observaciones.TabIndex = 24
        '
        'frm_turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 643)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.lbl_obsercaciones)
        Me.Controls.Add(Me.grp_hora_empleado)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.grp_hora)
        Me.Controls.Add(Me.dtp_fecha_turno)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.grp_grilla)
        Me.Controls.Add(Me.chk_habilitar_interseccion)
        Me.Controls.Add(Me.cmb_paciente)
        Me.Controls.Add(Me.cmb_empleado)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.lbl_empleado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(858, 682)
        Me.MinimumSize = New System.Drawing.Size(858, 682)
        Me.Name = "frm_turnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turnos"
        CType(Me.grid_turnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_grilla.ResumeLayout(False)
        Me.grp_hora.ResumeLayout(False)
        Me.grp_hora.PerformLayout()
        Me.grp_hora_empleado.ResumeLayout(False)
        Me.grp_hora_empleado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_turnos As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_empleado As System.Windows.Forms.Label
    Friend WithEvents cmb_empleado As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_paciente As System.Windows.Forms.ComboBox
    Friend WithEvents chk_habilitar_interseccion As System.Windows.Forms.CheckBox
    Friend WithEvents grp_grilla As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_Nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents dtp_fecha_turno As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_hora_desde As System.Windows.Forms.Label
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents grp_hora As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_hora_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_hora_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_turno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_desde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_hasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents grp_hora_empleado As System.Windows.Forms.GroupBox
    Friend WithEvents txt_hora_ingreso As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_ingreso As System.Windows.Forms.Label
    Friend WithEvents lbl_egreso As System.Windows.Forms.Label
    Friend WithEvents txt_hora_egreso As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_obsercaciones As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
End Class
