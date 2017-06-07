<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_acceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu_acceso))
        Me.cmd_paciente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_tratamiento = New System.Windows.Forms.Button()
        Me.cmd_cargo = New System.Windows.Forms.Button()
        Me.cmd_insumo = New System.Windows.Forms.Button()
        Me.cmd_empleado = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_factura = New System.Windows.Forms.Button()
        Me.cmd_intervencion = New System.Windows.Forms.Button()
        Me.cmd_turno = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmd_listado_insumos = New System.Windows.Forms.Button()
        Me.cmd_listado_turno = New System.Windows.Forms.Button()
        Me.cmd_listado_paciente = New System.Windows.Forms.Button()
        Me.cmd_historial_medico = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_paciente
        '
        Me.cmd_paciente.Location = New System.Drawing.Point(6, 19)
        Me.cmd_paciente.Name = "cmd_paciente"
        Me.cmd_paciente.Size = New System.Drawing.Size(112, 44)
        Me.cmd_paciente.TabIndex = 0
        Me.cmd_paciente.Text = "Paciente"
        Me.cmd_paciente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_tratamiento)
        Me.GroupBox1.Controls.Add(Me.cmd_cargo)
        Me.GroupBox1.Controls.Add(Me.cmd_insumo)
        Me.GroupBox1.Controls.Add(Me.cmd_empleado)
        Me.GroupBox1.Controls.Add(Me.cmd_paciente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 121)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SOPORTE/ABMC"
        '
        'cmd_tratamiento
        '
        Me.cmd_tratamiento.Location = New System.Drawing.Point(242, 19)
        Me.cmd_tratamiento.Name = "cmd_tratamiento"
        Me.cmd_tratamiento.Size = New System.Drawing.Size(112, 44)
        Me.cmd_tratamiento.TabIndex = 4
        Me.cmd_tratamiento.Text = "Tratamiento"
        Me.cmd_tratamiento.UseVisualStyleBackColor = True
        '
        'cmd_cargo
        '
        Me.cmd_cargo.Location = New System.Drawing.Point(6, 69)
        Me.cmd_cargo.Name = "cmd_cargo"
        Me.cmd_cargo.Size = New System.Drawing.Size(112, 44)
        Me.cmd_cargo.TabIndex = 3
        Me.cmd_cargo.Text = "Cargo"
        Me.cmd_cargo.UseVisualStyleBackColor = True
        '
        'cmd_insumo
        '
        Me.cmd_insumo.Location = New System.Drawing.Point(124, 69)
        Me.cmd_insumo.Name = "cmd_insumo"
        Me.cmd_insumo.Size = New System.Drawing.Size(112, 44)
        Me.cmd_insumo.TabIndex = 2
        Me.cmd_insumo.Text = "Insumo"
        Me.cmd_insumo.UseVisualStyleBackColor = True
        '
        'cmd_empleado
        '
        Me.cmd_empleado.Location = New System.Drawing.Point(124, 19)
        Me.cmd_empleado.Name = "cmd_empleado"
        Me.cmd_empleado.Size = New System.Drawing.Size(112, 44)
        Me.cmd_empleado.TabIndex = 1
        Me.cmd_empleado.Text = "Empleado"
        Me.cmd_empleado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_factura)
        Me.GroupBox2.Controls.Add(Me.cmd_intervencion)
        Me.GroupBox2.Controls.Add(Me.cmd_turno)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 70)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TRANSACCIONALES"
        '
        'cmd_factura
        '
        Me.cmd_factura.Location = New System.Drawing.Point(242, 19)
        Me.cmd_factura.Name = "cmd_factura"
        Me.cmd_factura.Size = New System.Drawing.Size(112, 44)
        Me.cmd_factura.TabIndex = 3
        Me.cmd_factura.Text = "Factura"
        Me.cmd_factura.UseVisualStyleBackColor = True
        '
        'cmd_intervencion
        '
        Me.cmd_intervencion.Location = New System.Drawing.Point(124, 19)
        Me.cmd_intervencion.Name = "cmd_intervencion"
        Me.cmd_intervencion.Size = New System.Drawing.Size(112, 44)
        Me.cmd_intervencion.TabIndex = 1
        Me.cmd_intervencion.Text = "Intervencion"
        Me.cmd_intervencion.UseVisualStyleBackColor = True
        '
        'cmd_turno
        '
        Me.cmd_turno.Location = New System.Drawing.Point(6, 19)
        Me.cmd_turno.Name = "cmd_turno"
        Me.cmd_turno.Size = New System.Drawing.Size(112, 44)
        Me.cmd_turno.TabIndex = 0
        Me.cmd_turno.Text = "Turno"
        Me.cmd_turno.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmd_listado_insumos)
        Me.GroupBox3.Controls.Add(Me.cmd_listado_turno)
        Me.GroupBox3.Controls.Add(Me.cmd_listado_paciente)
        Me.GroupBox3.Controls.Add(Me.cmd_historial_medico)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 215)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 125)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LISTADOS"
        '
        'cmd_listado_insumos
        '
        Me.cmd_listado_insumos.Location = New System.Drawing.Point(6, 69)
        Me.cmd_listado_insumos.Name = "cmd_listado_insumos"
        Me.cmd_listado_insumos.Size = New System.Drawing.Size(112, 44)
        Me.cmd_listado_insumos.TabIndex = 4
        Me.cmd_listado_insumos.Text = "Insumos"
        Me.cmd_listado_insumos.UseVisualStyleBackColor = True
        '
        'cmd_listado_turno
        '
        Me.cmd_listado_turno.Location = New System.Drawing.Point(242, 19)
        Me.cmd_listado_turno.Name = "cmd_listado_turno"
        Me.cmd_listado_turno.Size = New System.Drawing.Size(112, 44)
        Me.cmd_listado_turno.TabIndex = 3
        Me.cmd_listado_turno.Text = "Turnos"
        Me.cmd_listado_turno.UseVisualStyleBackColor = True
        '
        'cmd_listado_paciente
        '
        Me.cmd_listado_paciente.Location = New System.Drawing.Point(124, 19)
        Me.cmd_listado_paciente.Name = "cmd_listado_paciente"
        Me.cmd_listado_paciente.Size = New System.Drawing.Size(112, 44)
        Me.cmd_listado_paciente.TabIndex = 1
        Me.cmd_listado_paciente.Text = "Pacientes"
        Me.cmd_listado_paciente.UseVisualStyleBackColor = True
        '
        'cmd_historial_medico
        '
        Me.cmd_historial_medico.Location = New System.Drawing.Point(6, 19)
        Me.cmd_historial_medico.Name = "cmd_historial_medico"
        Me.cmd_historial_medico.Size = New System.Drawing.Size(112, 44)
        Me.cmd_historial_medico.TabIndex = 0
        Me.cmd_historial_medico.Text = "Historial Medico"
        Me.cmd_historial_medico.UseVisualStyleBackColor = True
        '
        'frm_menu_acceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 347)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(409, 386)
        Me.MinimumSize = New System.Drawing.Size(409, 386)
        Me.Name = "frm_menu_acceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Acceso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_paciente As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_tratamiento As System.Windows.Forms.Button
    Friend WithEvents cmd_cargo As System.Windows.Forms.Button
    Friend WithEvents cmd_insumo As System.Windows.Forms.Button
    Friend WithEvents cmd_empleado As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_factura As System.Windows.Forms.Button
    Friend WithEvents cmd_intervencion As System.Windows.Forms.Button
    Friend WithEvents cmd_turno As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_listado_insumos As System.Windows.Forms.Button
    Friend WithEvents cmd_listado_turno As System.Windows.Forms.Button
    Friend WithEvents cmd_listado_paciente As System.Windows.Forms.Button
    Friend WithEvents cmd_historial_medico As System.Windows.Forms.Button
End Class
