<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_paciente_report
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rv_pacientes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.grp_rango_fecha = New System.Windows.Forms.GroupBox()
        Me.chk_habilitar_fechas = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_desde = New System.Windows.Forms.DateTimePicker()
        Me.grp_estado = New System.Windows.Forms.GroupBox()
        Me.rb_deshabilitados = New System.Windows.Forms.RadioButton()
        Me.rb_habilitados = New System.Windows.Forms.RadioButton()
        Me.rb_estado_todos = New System.Windows.Forms.RadioButton()
        Me.grp_sexo = New System.Windows.Forms.GroupBox()
        Me.rb_m = New System.Windows.Forms.RadioButton()
        Me.rb_h = New System.Windows.Forms.RadioButton()
        Me.rb_sexo_todos = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmb_loc = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmb_td = New System.Windows.Forms.ComboBox()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pacientes_DataSet = New ConsultorioOdontologico.Pacientes_DataSet()
        Me.grp_rango_fecha.SuspendLayout()
        Me.grp_estado.SuspendLayout()
        Me.grp_sexo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pacientes_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rv_pacientes
        '
        ReportDataSource2.Name = "Pacientes_DataSet"
        ReportDataSource2.Value = Me.PacientesBindingSource
        Me.rv_pacientes.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rv_pacientes.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.Pacientes_Report.rdlc"
        Me.rv_pacientes.LocalReport.ReportPath = ""
        Me.rv_pacientes.Location = New System.Drawing.Point(12, 114)
        Me.rv_pacientes.Name = "rv_pacientes"
        Me.rv_pacientes.Size = New System.Drawing.Size(601, 371)
        Me.rv_pacientes.TabIndex = 0
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(538, 29)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 66)
        Me.cmd_buscar.TabIndex = 1
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'grp_rango_fecha
        '
        Me.grp_rango_fecha.Controls.Add(Me.chk_habilitar_fechas)
        Me.grp_rango_fecha.Controls.Add(Me.Label2)
        Me.grp_rango_fecha.Controls.Add(Me.Label1)
        Me.grp_rango_fecha.Controls.Add(Me.dtp_hasta)
        Me.grp_rango_fecha.Controls.Add(Me.dtp_desde)
        Me.grp_rango_fecha.Location = New System.Drawing.Point(12, 12)
        Me.grp_rango_fecha.Name = "grp_rango_fecha"
        Me.grp_rango_fecha.Size = New System.Drawing.Size(172, 96)
        Me.grp_rango_fecha.TabIndex = 2
        Me.grp_rango_fecha.TabStop = False
        Me.grp_rango_fecha.Text = "Fecha Nacimiento"
        '
        'chk_habilitar_fechas
        '
        Me.chk_habilitar_fechas.AutoSize = True
        Me.chk_habilitar_fechas.Location = New System.Drawing.Point(51, 76)
        Me.chk_habilitar_fechas.Name = "chk_habilitar_fechas"
        Me.chk_habilitar_fechas.Size = New System.Drawing.Size(64, 17)
        Me.chk_habilitar_fechas.TabIndex = 7
        Me.chk_habilitar_fechas.Text = "Habilitar"
        Me.chk_habilitar_fechas.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Desde"
        '
        'dtp_hasta
        '
        Me.dtp_hasta.Enabled = False
        Me.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_hasta.Location = New System.Drawing.Point(61, 49)
        Me.dtp_hasta.Name = "dtp_hasta"
        Me.dtp_hasta.Size = New System.Drawing.Size(100, 20)
        Me.dtp_hasta.TabIndex = 4
        Me.dtp_hasta.Value = New Date(2017, 6, 5, 0, 0, 0, 0)
        '
        'dtp_desde
        '
        Me.dtp_desde.Enabled = False
        Me.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_desde.Location = New System.Drawing.Point(61, 22)
        Me.dtp_desde.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dtp_desde.Name = "dtp_desde"
        Me.dtp_desde.Size = New System.Drawing.Size(100, 20)
        Me.dtp_desde.TabIndex = 3
        Me.dtp_desde.Value = New Date(1970, 1, 1, 0, 0, 0, 0)
        '
        'grp_estado
        '
        Me.grp_estado.Controls.Add(Me.rb_deshabilitados)
        Me.grp_estado.Controls.Add(Me.rb_habilitados)
        Me.grp_estado.Controls.Add(Me.rb_estado_todos)
        Me.grp_estado.Location = New System.Drawing.Point(194, 12)
        Me.grp_estado.Name = "grp_estado"
        Me.grp_estado.Size = New System.Drawing.Size(107, 96)
        Me.grp_estado.TabIndex = 3
        Me.grp_estado.TabStop = False
        Me.grp_estado.Text = "Estado"
        '
        'rb_deshabilitados
        '
        Me.rb_deshabilitados.AutoSize = True
        Me.rb_deshabilitados.Location = New System.Drawing.Point(6, 73)
        Me.rb_deshabilitados.Name = "rb_deshabilitados"
        Me.rb_deshabilitados.Size = New System.Drawing.Size(94, 17)
        Me.rb_deshabilitados.TabIndex = 2
        Me.rb_deshabilitados.Text = "Deshabilitados"
        Me.rb_deshabilitados.UseVisualStyleBackColor = True
        '
        'rb_habilitados
        '
        Me.rb_habilitados.AutoSize = True
        Me.rb_habilitados.Checked = True
        Me.rb_habilitados.Location = New System.Drawing.Point(6, 45)
        Me.rb_habilitados.Name = "rb_habilitados"
        Me.rb_habilitados.Size = New System.Drawing.Size(77, 17)
        Me.rb_habilitados.TabIndex = 1
        Me.rb_habilitados.TabStop = True
        Me.rb_habilitados.Text = "Habilitados"
        Me.rb_habilitados.UseVisualStyleBackColor = True
        '
        'rb_estado_todos
        '
        Me.rb_estado_todos.AutoSize = True
        Me.rb_estado_todos.Location = New System.Drawing.Point(6, 17)
        Me.rb_estado_todos.Name = "rb_estado_todos"
        Me.rb_estado_todos.Size = New System.Drawing.Size(63, 17)
        Me.rb_estado_todos.TabIndex = 0
        Me.rb_estado_todos.Text = "TODOS"
        Me.rb_estado_todos.UseVisualStyleBackColor = True
        '
        'grp_sexo
        '
        Me.grp_sexo.Controls.Add(Me.rb_m)
        Me.grp_sexo.Controls.Add(Me.rb_h)
        Me.grp_sexo.Controls.Add(Me.rb_sexo_todos)
        Me.grp_sexo.Location = New System.Drawing.Point(307, 12)
        Me.grp_sexo.Name = "grp_sexo"
        Me.grp_sexo.Size = New System.Drawing.Size(85, 96)
        Me.grp_sexo.TabIndex = 4
        Me.grp_sexo.TabStop = False
        Me.grp_sexo.Text = "Sexo"
        '
        'rb_m
        '
        Me.rb_m.AutoSize = True
        Me.rb_m.Location = New System.Drawing.Point(6, 73)
        Me.rb_m.Name = "rb_m"
        Me.rb_m.Size = New System.Drawing.Size(51, 17)
        Me.rb_m.TabIndex = 5
        Me.rb_m.TabStop = True
        Me.rb_m.Text = "Mujer"
        Me.rb_m.UseVisualStyleBackColor = True
        '
        'rb_h
        '
        Me.rb_h.AutoSize = True
        Me.rb_h.Location = New System.Drawing.Point(6, 45)
        Me.rb_h.Name = "rb_h"
        Me.rb_h.Size = New System.Drawing.Size(62, 17)
        Me.rb_h.TabIndex = 4
        Me.rb_h.TabStop = True
        Me.rb_h.Text = "Hombre"
        Me.rb_h.UseVisualStyleBackColor = True
        '
        'rb_sexo_todos
        '
        Me.rb_sexo_todos.AutoSize = True
        Me.rb_sexo_todos.Checked = True
        Me.rb_sexo_todos.Location = New System.Drawing.Point(6, 17)
        Me.rb_sexo_todos.Name = "rb_sexo_todos"
        Me.rb_sexo_todos.Size = New System.Drawing.Size(63, 17)
        Me.rb_sexo_todos.TabIndex = 3
        Me.rb_sexo_todos.TabStop = True
        Me.rb_sexo_todos.Text = "TODOS"
        Me.rb_sexo_todos.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmb_loc)
        Me.GroupBox3.Location = New System.Drawing.Point(398, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(134, 47)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Localidad"
        '
        'cmb_loc
        '
        Me.cmb_loc.FormattingEnabled = True
        Me.cmb_loc.Location = New System.Drawing.Point(6, 19)
        Me.cmb_loc.Name = "cmb_loc"
        Me.cmb_loc.Size = New System.Drawing.Size(121, 21)
        Me.cmb_loc.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmb_td)
        Me.GroupBox4.Location = New System.Drawing.Point(398, 61)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(134, 47)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Documento"
        '
        'cmb_td
        '
        Me.cmb_td.FormattingEnabled = True
        Me.cmb_td.Location = New System.Drawing.Point(6, 19)
        Me.cmb_td.Name = "cmb_td"
        Me.cmb_td.Size = New System.Drawing.Size(121, 21)
        Me.cmb_td.TabIndex = 0
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.Pacientes_DataSet
        '
        'Pacientes_DataSet
        '
        Me.Pacientes_DataSet.DataSetName = "Pacientes_DataSet"
        Me.Pacientes_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frm_paciente_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 515)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grp_sexo)
        Me.Controls.Add(Me.grp_estado)
        Me.Controls.Add(Me.grp_rango_fecha)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.rv_pacientes)
        Me.Name = "frm_paciente_report"
        Me.Text = "Reporte de Paciente"
        Me.grp_rango_fecha.ResumeLayout(False)
        Me.grp_rango_fecha.PerformLayout()
        Me.grp_estado.ResumeLayout(False)
        Me.grp_estado.PerformLayout()
        Me.grp_sexo.ResumeLayout(False)
        Me.grp_sexo.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pacientes_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rv_pacientes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pacientes_DataSet As ConsultorioOdontologico.Pacientes_DataSet
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents grp_rango_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents chk_habilitar_fechas As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents grp_estado As System.Windows.Forms.GroupBox
    Friend WithEvents rb_deshabilitados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_habilitados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_estado_todos As System.Windows.Forms.RadioButton
    Friend WithEvents grp_sexo As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_loc As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_td As System.Windows.Forms.ComboBox
    Friend WithEvents rb_m As System.Windows.Forms.RadioButton
    Friend WithEvents rb_h As System.Windows.Forms.RadioButton
    Friend WithEvents rb_sexo_todos As System.Windows.Forms.RadioButton
End Class
