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
        Me.rv_tratamientosPaciente = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmb_filtro_paciente = New System.Windows.Forms.ComboBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.TratamientosPorPacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Estadisticas_DataSet = New ConsultorioOdontologico.Estadisticas_DataSet()
        CType(Me.TratamientosPorPacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Estadisticas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.rv_tratamientosPaciente.Location = New System.Drawing.Point(13, 48)
        Me.rv_tratamientosPaciente.Name = "rv_tratamientosPaciente"
        Me.rv_tratamientosPaciente.Size = New System.Drawing.Size(768, 324)
        Me.rv_tratamientosPaciente.TabIndex = 0
        '
        'cmb_filtro_paciente
        '
        Me.cmb_filtro_paciente.FormattingEnabled = True
        Me.cmb_filtro_paciente.Location = New System.Drawing.Point(13, 12)
        Me.cmb_filtro_paciente.Name = "cmb_filtro_paciente"
        Me.cmb_filtro_paciente.Size = New System.Drawing.Size(221, 21)
        Me.cmb_filtro_paciente.TabIndex = 1
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(240, 10)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 2
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
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
        'frm_tratamientosPorPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 384)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmb_filtro_paciente)
        Me.Controls.Add(Me.rv_tratamientosPaciente)
        Me.Name = "frm_tratamientosPorPacientes"
        Me.Text = "Tratamientos Por Pacientes"
        CType(Me.TratamientosPorPacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Estadisticas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rv_tratamientosPaciente As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TratamientosPorPacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Estadisticas_DataSet As ConsultorioOdontologico.Estadisticas_DataSet
    Friend WithEvents cmb_filtro_paciente As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
End Class
