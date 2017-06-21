<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tratamientosPorPacientes
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
        Me.TratamientosPorPacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Estadisticas_DataSet = New ConsultorioOdontologico.Estadisticas_DataSet()
        Me.rv_tratamientosPaciente = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmb_filtro_paciente = New System.Windows.Forms.ComboBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.lbl_paciente = New System.Windows.Forms.Label()
        CType(Me.TratamientosPorPacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Estadisticas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TratamientosPorPacientesBindingSource
        '
        Me.TratamientosPorPacientesBindingSource.DataMember = "TratamientosPorPacientes"
        Me.TratamientosPorPacientesBindingSource.DataSource = Me.Estadisticas_DataSet
        '
        'Estadisticas_DataSet
        '
        Me.Estadisticas_DataSet.DataSetName = "Estadisticas_DataSet"
        Me.Estadisticas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rv_tratamientosPaciente
        '
        Me.rv_tratamientosPaciente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Datos_TratamientosPorPacientes"
        ReportDataSource1.Value = Me.TratamientosPorPacientesBindingSource
        Me.rv_tratamientosPaciente.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_tratamientosPaciente.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.TratamientosPorPacientes_Estadistica.rdlc"
        Me.rv_tratamientosPaciente.Location = New System.Drawing.Point(17, 59)
        Me.rv_tratamientosPaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.rv_tratamientosPaciente.Name = "rv_tratamientosPaciente"
        Me.rv_tratamientosPaciente.Size = New System.Drawing.Size(1104, 715)
        Me.rv_tratamientosPaciente.TabIndex = 0
        '
        'cmb_filtro_paciente
        '
        Me.cmb_filtro_paciente.FormattingEnabled = True
        Me.cmb_filtro_paciente.Location = New System.Drawing.Point(92, 13)
        Me.cmb_filtro_paciente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_filtro_paciente.Name = "cmb_filtro_paciente"
        Me.cmb_filtro_paciente.Size = New System.Drawing.Size(293, 24)
        Me.cmb_filtro_paciente.TabIndex = 1
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(393, 11)
        Me.cmd_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(100, 28)
        Me.cmd_buscar.TabIndex = 2
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_paciente.Location = New System.Drawing.Point(18, 17)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(67, 17)
        Me.lbl_paciente.TabIndex = 3
        Me.lbl_paciente.Text = "Paciente:"
        '
        'frm_tratamientosPorPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 790)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmb_filtro_paciente)
        Me.Controls.Add(Me.rv_tratamientosPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_tratamientosPorPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tratamientos Por Pacientes"
        CType(Me.TratamientosPorPacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Estadisticas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rv_tratamientosPaciente As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TratamientosPorPacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Estadisticas_DataSet As ConsultorioOdontologico.Estadisticas_DataSet
    Friend WithEvents cmb_filtro_paciente As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
End Class
