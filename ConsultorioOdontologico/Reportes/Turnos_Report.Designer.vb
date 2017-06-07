<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_turnos_report
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_turnos_report))
        Me.TurnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurnosDataSet = New ConsultorioOdontologico.TurnosDataSet()
        Me.rv_turnos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtp_desde = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha_desde = New System.Windows.Forms.Label()
        Me.grp_rango_fechas = New System.Windows.Forms.GroupBox()
        Me.chk_habilitar_fechas = New System.Windows.Forms.CheckBox()
        Me.dtp_hasta = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha_hasta = New System.Windows.Forms.Label()
        Me.cmb_paciente = New System.Windows.Forms.ComboBox()
        Me.cmb_empleado = New System.Windows.Forms.ComboBox()
        Me.lbl_paciente = New System.Windows.Forms.Label()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.grp_sexo = New System.Windows.Forms.GroupBox()
        Me.rb_m = New System.Windows.Forms.RadioButton()
        Me.rb_h = New System.Windows.Forms.RadioButton()
        Me.rb_sexo_todos = New System.Windows.Forms.RadioButton()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        CType(Me.TurnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_rango_fechas.SuspendLayout()
        Me.grp_sexo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TurnosBindingSource
        '
        Me.TurnosBindingSource.DataMember = "Turnos"
        Me.TurnosBindingSource.DataSource = Me.TurnosDataSet
        '
        'TurnosDataSet
        '
        Me.TurnosDataSet.DataSetName = "TurnosDataSet"
        Me.TurnosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rv_turnos
        '
        Me.rv_turnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DS_Turnos"
        ReportDataSource1.Value = Me.TurnosBindingSource
        Me.rv_turnos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_turnos.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.Turnos_Report.rdlc"
        Me.rv_turnos.Location = New System.Drawing.Point(9, 103)
        Me.rv_turnos.Margin = New System.Windows.Forms.Padding(2)
        Me.rv_turnos.Name = "rv_turnos"
        Me.rv_turnos.Size = New System.Drawing.Size(811, 338)
        Me.rv_turnos.TabIndex = 0
        '
        'dtp_desde
        '
        Me.dtp_desde.Enabled = False
        Me.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_desde.Location = New System.Drawing.Point(62, 23)
        Me.dtp_desde.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_desde.MinDate = New Date(2017, 5, 30, 0, 0, 0, 0)
        Me.dtp_desde.Name = "dtp_desde"
        Me.dtp_desde.Size = New System.Drawing.Size(100, 20)
        Me.dtp_desde.TabIndex = 1
        Me.dtp_desde.Value = New Date(2017, 5, 30, 0, 0, 0, 0)
        '
        'lbl_fecha_desde
        '
        Me.lbl_fecha_desde.AutoSize = True
        Me.lbl_fecha_desde.Location = New System.Drawing.Point(16, 26)
        Me.lbl_fecha_desde.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_fecha_desde.Name = "lbl_fecha_desde"
        Me.lbl_fecha_desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_fecha_desde.TabIndex = 2
        Me.lbl_fecha_desde.Text = "Desde"
        '
        'grp_rango_fechas
        '
        Me.grp_rango_fechas.Controls.Add(Me.chk_habilitar_fechas)
        Me.grp_rango_fechas.Controls.Add(Me.dtp_hasta)
        Me.grp_rango_fechas.Controls.Add(Me.lbl_fecha_hasta)
        Me.grp_rango_fechas.Controls.Add(Me.dtp_desde)
        Me.grp_rango_fechas.Controls.Add(Me.lbl_fecha_desde)
        Me.grp_rango_fechas.Location = New System.Drawing.Point(22, 12)
        Me.grp_rango_fechas.Margin = New System.Windows.Forms.Padding(2)
        Me.grp_rango_fechas.Name = "grp_rango_fechas"
        Me.grp_rango_fechas.Padding = New System.Windows.Forms.Padding(2)
        Me.grp_rango_fechas.Size = New System.Drawing.Size(330, 87)
        Me.grp_rango_fechas.TabIndex = 3
        Me.grp_rango_fechas.TabStop = False
        Me.grp_rango_fechas.Text = "Rango de Fechas"
        '
        'chk_habilitar_fechas
        '
        Me.chk_habilitar_fechas.AutoSize = True
        Me.chk_habilitar_fechas.Location = New System.Drawing.Point(30, 53)
        Me.chk_habilitar_fechas.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_habilitar_fechas.Name = "chk_habilitar_fechas"
        Me.chk_habilitar_fechas.Size = New System.Drawing.Size(64, 17)
        Me.chk_habilitar_fechas.TabIndex = 5
        Me.chk_habilitar_fechas.Text = "Habilitar"
        Me.chk_habilitar_fechas.UseVisualStyleBackColor = True
        '
        'dtp_hasta
        '
        Me.dtp_hasta.Enabled = False
        Me.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_hasta.Location = New System.Drawing.Point(213, 23)
        Me.dtp_hasta.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_hasta.Name = "dtp_hasta"
        Me.dtp_hasta.Size = New System.Drawing.Size(100, 20)
        Me.dtp_hasta.TabIndex = 3
        '
        'lbl_fecha_hasta
        '
        Me.lbl_fecha_hasta.AutoSize = True
        Me.lbl_fecha_hasta.Location = New System.Drawing.Point(170, 26)
        Me.lbl_fecha_hasta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_fecha_hasta.Name = "lbl_fecha_hasta"
        Me.lbl_fecha_hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_fecha_hasta.TabIndex = 4
        Me.lbl_fecha_hasta.Text = "Hasta"
        '
        'cmb_paciente
        '
        Me.cmb_paciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_paciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_paciente.FormattingEnabled = True
        Me.cmb_paciente.Location = New System.Drawing.Point(511, 63)
        Me.cmb_paciente.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_paciente.Name = "cmb_paciente"
        Me.cmb_paciente.Size = New System.Drawing.Size(182, 21)
        Me.cmb_paciente.TabIndex = 8
        '
        'cmb_empleado
        '
        Me.cmb_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_empleado.FormattingEnabled = True
        Me.cmb_empleado.Location = New System.Drawing.Point(511, 30)
        Me.cmb_empleado.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_empleado.Name = "cmb_empleado"
        Me.cmb_empleado.Size = New System.Drawing.Size(182, 21)
        Me.cmb_empleado.TabIndex = 7
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Location = New System.Drawing.Point(453, 63)
        Me.lbl_paciente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(49, 13)
        Me.lbl_paciente.TabIndex = 6
        Me.lbl_paciente.Text = "Paciente"
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.Location = New System.Drawing.Point(447, 34)
        Me.lbl_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_empleado.TabIndex = 5
        Me.lbl_empleado.Text = "Empleado"
        '
        'grp_sexo
        '
        Me.grp_sexo.Controls.Add(Me.rb_m)
        Me.grp_sexo.Controls.Add(Me.rb_h)
        Me.grp_sexo.Controls.Add(Me.rb_sexo_todos)
        Me.grp_sexo.Location = New System.Drawing.Point(357, 12)
        Me.grp_sexo.Name = "grp_sexo"
        Me.grp_sexo.Size = New System.Drawing.Size(85, 87)
        Me.grp_sexo.TabIndex = 9
        Me.grp_sexo.TabStop = False
        Me.grp_sexo.Text = "Sexo"
        '
        'rb_m
        '
        Me.rb_m.AutoSize = True
        Me.rb_m.Location = New System.Drawing.Point(6, 64)
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
        Me.rb_h.Location = New System.Drawing.Point(6, 41)
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
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(708, 34)
        Me.cmd_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(98, 45)
        Me.cmd_buscar.TabIndex = 10
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'frm_turnos_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 451)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.grp_sexo)
        Me.Controls.Add(Me.cmb_paciente)
        Me.Controls.Add(Me.cmb_empleado)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.lbl_empleado)
        Me.Controls.Add(Me.grp_rango_fechas)
        Me.Controls.Add(Me.rv_turnos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(833, 490)
        Me.Name = "frm_turnos_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Turnos"
        CType(Me.TurnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_rango_fechas.ResumeLayout(False)
        Me.grp_rango_fechas.PerformLayout()
        Me.grp_sexo.ResumeLayout(False)
        Me.grp_sexo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rv_turnos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TurnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TurnosDataSet As ConsultorioOdontologico.TurnosDataSet
    Friend WithEvents dtp_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fecha_desde As System.Windows.Forms.Label
    Friend WithEvents grp_rango_fechas As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fecha_hasta As System.Windows.Forms.Label
    Friend WithEvents cmb_paciente As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_empleado As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents lbl_empleado As System.Windows.Forms.Label
    Friend WithEvents grp_sexo As System.Windows.Forms.GroupBox
    Friend WithEvents rb_m As System.Windows.Forms.RadioButton
    Friend WithEvents rb_h As System.Windows.Forms.RadioButton
    Friend WithEvents rb_sexo_todos As System.Windows.Forms.RadioButton
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents chk_habilitar_fechas As System.Windows.Forms.CheckBox
End Class
