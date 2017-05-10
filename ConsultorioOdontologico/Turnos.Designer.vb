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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.fecha_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.lbl_paciente = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_turno, Me.hora_desde, Me.hora_hasta, Me.empleado, Me.paciente})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 158)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(745, 301)
        Me.DataGridView1.TabIndex = 0
        '
        'fecha_turno
        '
        Me.fecha_turno.HeaderText = "Fecha Turno"
        Me.fecha_turno.Name = "fecha_turno"
        '
        'hora_desde
        '
        Me.hora_desde.HeaderText = "Hora Desde"
        Me.hora_desde.Name = "hora_desde"
        '
        'hora_hasta
        '
        Me.hora_hasta.HeaderText = "Hora Hasta"
        Me.hora_hasta.Name = "hora_hasta"
        '
        'empleado
        '
        Me.empleado.HeaderText = "Empleado"
        Me.empleado.Name = "empleado"
        '
        'paciente
        '
        Me.paciente.HeaderText = "Paciente"
        Me.paciente.Name = "paciente"
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.Location = New System.Drawing.Point(21, 39)
        Me.lbl_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_empleado.TabIndex = 1
        Me.lbl_empleado.Text = "Empleado"
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Location = New System.Drawing.Point(21, 70)
        Me.lbl_paciente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(49, 13)
        Me.lbl_paciente.TabIndex = 2
        Me.lbl_paciente.Text = "Paciente"
        '
        'frm_turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 470)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.lbl_empleado)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.Name = "frm_turnos"
        Me.Text = "Turnos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents fecha_turno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_desde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_hasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_empleado As System.Windows.Forms.Label
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
End Class
