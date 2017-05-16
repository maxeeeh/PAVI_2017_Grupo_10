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
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.lbl_paciente = New System.Windows.Forms.Label()
        Me.cmb_empleado = New System.Windows.Forms.ComboBox()
        Me.cmb_paciente = New System.Windows.Forms.ComboBox()
        Me.fecha_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid_turnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_turnos
        '
        Me.grid_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_turnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_turno, Me.hora_desde, Me.hora_hasta, Me.empleado, Me.paciente})
        Me.grid_turnos.Location = New System.Drawing.Point(12, 194)
        Me.grid_turnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grid_turnos.Name = "grid_turnos"
        Me.grid_turnos.RowTemplate.Height = 24
        Me.grid_turnos.Size = New System.Drawing.Size(993, 370)
        Me.grid_turnos.TabIndex = 0
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
        Me.cmb_empleado.Size = New System.Drawing.Size(335, 24)
        Me.cmb_empleado.TabIndex = 3
        '
        'cmb_paciente
        '
        Me.cmb_paciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_paciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_paciente.FormattingEnabled = True
        Me.cmb_paciente.Location = New System.Drawing.Point(105, 86)
        Me.cmb_paciente.Name = "cmb_paciente"
        Me.cmb_paciente.Size = New System.Drawing.Size(335, 24)
        Me.cmb_paciente.TabIndex = 4
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
        'frm_turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 578)
        Me.Controls.Add(Me.cmb_paciente)
        Me.Controls.Add(Me.cmb_empleado)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.lbl_empleado)
        Me.Controls.Add(Me.grid_turnos)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frm_turnos"
        Me.Text = "Turnos"
        CType(Me.grid_turnos, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
