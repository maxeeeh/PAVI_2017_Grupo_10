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
        Me.grid_turnos = New System.Windows.Forms.DataGridView()
        Me.fecha_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.lbl_paciente = New System.Windows.Forms.Label()
        Me.cmb_empleado = New System.Windows.Forms.ComboBox()
        Me.cmb_paciente = New System.Windows.Forms.ComboBox()
        Me.chk_habilitar_interseccion = New System.Windows.Forms.CheckBox()
        Me.grp_grilla = New System.Windows.Forms.GroupBox()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.dtp_fecha_turno = New System.Windows.Forms.DateTimePicker()
        CType(Me.grid_turnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_grilla.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_turnos
        '
        Me.grid_turnos.AllowUserToAddRows = False
        Me.grid_turnos.AllowUserToDeleteRows = False
        Me.grid_turnos.AllowUserToResizeColumns = False
        Me.grid_turnos.AllowUserToResizeRows = False
        Me.grid_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_turnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_turno, Me.hora_desde, Me.hora_hasta, Me.empleado, Me.paciente, Me.observaciones})
        Me.grid_turnos.Location = New System.Drawing.Point(16, 23)
        Me.grid_turnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grid_turnos.Name = "grid_turnos"
        Me.grid_turnos.RowTemplate.Height = 24
        Me.grid_turnos.Size = New System.Drawing.Size(1053, 334)
        Me.grid_turnos.TabIndex = 0
        '
        'fecha_turno
        '
        Me.fecha_turno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.fecha_turno.DefaultCellStyle = DataGridViewCellStyle1
        Me.fecha_turno.HeaderText = "Fecha Turno"
        Me.fecha_turno.Name = "fecha_turno"
        Me.fecha_turno.Width = 118
        '
        'hora_desde
        '
        Me.hora_desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.hora_desde.DefaultCellStyle = DataGridViewCellStyle2
        Me.hora_desde.HeaderText = "Hora Desde"
        Me.hora_desde.Name = "hora_desde"
        Me.hora_desde.Width = 113
        '
        'hora_hasta
        '
        Me.hora_hasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.hora_hasta.DefaultCellStyle = DataGridViewCellStyle3
        Me.hora_hasta.HeaderText = "Hora Hasta"
        Me.hora_hasta.Name = "hora_hasta"
        Me.hora_hasta.Width = 109
        '
        'empleado
        '
        Me.empleado.HeaderText = "Empleado"
        Me.empleado.Name = "empleado"
        Me.empleado.Width = 150
        '
        'paciente
        '
        Me.paciente.HeaderText = "Paciente"
        Me.paciente.Name = "paciente"
        Me.paciente.Width = 150
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
        Me.lbl_empleado.Location = New System.Drawing.Point(28, 48)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(71, 17)
        Me.lbl_empleado.TabIndex = 1
        Me.lbl_empleado.Text = "Empleado"
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Location = New System.Drawing.Point(28, 86)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(63, 17)
        Me.lbl_paciente.TabIndex = 2
        Me.lbl_paciente.Text = "Paciente"
        '
        'cmb_empleado
        '
        Me.cmb_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_empleado.FormattingEnabled = True
        Me.cmb_empleado.Location = New System.Drawing.Point(105, 45)
        Me.cmb_empleado.Name = "cmb_empleado"
        Me.cmb_empleado.Size = New System.Drawing.Size(351, 24)
        Me.cmb_empleado.TabIndex = 3
        '
        'cmb_paciente
        '
        Me.cmb_paciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_paciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_paciente.FormattingEnabled = True
        Me.cmb_paciente.Location = New System.Drawing.Point(105, 86)
        Me.cmb_paciente.Name = "cmb_paciente"
        Me.cmb_paciente.Size = New System.Drawing.Size(351, 24)
        Me.cmb_paciente.TabIndex = 4
        '
        'chk_habilitar_interseccion
        '
        Me.chk_habilitar_interseccion.AutoSize = True
        Me.chk_habilitar_interseccion.Checked = True
        Me.chk_habilitar_interseccion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_habilitar_interseccion.Location = New System.Drawing.Point(105, 130)
        Me.chk_habilitar_interseccion.Name = "chk_habilitar_interseccion"
        Me.chk_habilitar_interseccion.Size = New System.Drawing.Size(351, 21)
        Me.chk_habilitar_interseccion.TabIndex = 5
        Me.chk_habilitar_interseccion.Text = "Ver solo turnos de ese paciente con ese empleado"
        Me.chk_habilitar_interseccion.UseVisualStyleBackColor = True
        '
        'grp_grilla
        '
        Me.grp_grilla.Controls.Add(Me.grid_turnos)
        Me.grp_grilla.Location = New System.Drawing.Point(16, 425)
        Me.grp_grilla.Name = "grp_grilla"
        Me.grp_grilla.Size = New System.Drawing.Size(1092, 364)
        Me.grp_grilla.TabIndex = 6
        Me.grp_grilla.TabStop = False
        Me.grp_grilla.Text = "Turnos"
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(664, 807)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(119, 28)
        Me.cmd_Nuevo.TabIndex = 7
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(512, 807)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(119, 28)
        Me.cmd_eliminar.TabIndex = 8
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(815, 807)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(119, 28)
        Me.cmd_guardar.TabIndex = 9
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(965, 807)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(119, 28)
        Me.cmd_salir.TabIndex = 10
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'dtp_fecha_turno
        '
        Me.dtp_fecha_turno.Enabled = False
        Me.dtp_fecha_turno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtp_fecha_turno.Location = New System.Drawing.Point(698, 70)
        Me.dtp_fecha_turno.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_fecha_turno.Name = "dtp_fecha_turno"
        Me.dtp_fecha_turno.Size = New System.Drawing.Size(265, 22)
        Me.dtp_fecha_turno.TabIndex = 11
        '
        'frm_turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 836)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frm_turnos"
        Me.Text = "Turnos"
        CType(Me.grid_turnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_grilla.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_turnos As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_empleado As System.Windows.Forms.Label
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents cmb_empleado As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_paciente As System.Windows.Forms.ComboBox
    Friend WithEvents fecha_turno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_desde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_hasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_habilitar_interseccion As System.Windows.Forms.CheckBox
    Friend WithEvents grp_grilla As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_Nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents dtp_fecha_turno As System.Windows.Forms.DateTimePicker
End Class
