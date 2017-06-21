<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_historial_medico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_historial_medico))
        Me.Historial_MedicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rv_historial_medico = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmb_filtro_paciente = New System.Windows.Forms.ComboBox()
        Me.lbl_filtro_paciente = New System.Windows.Forms.Label()
        Me.HistorialMedico_DataSet = New ConsultorioOdontologico.HistorialMedico_DataSet()
        CType(Me.Historial_MedicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorialMedico_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rv_historial_medico
        '
        Me.rv_historial_medico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DS_Historial_Medico"
        ReportDataSource1.Value = Me.Historial_MedicoBindingSource
        Me.rv_historial_medico.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_historial_medico.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.Historial_Medico_Report.rdlc"
        Me.rv_historial_medico.Location = New System.Drawing.Point(16, 38)
        Me.rv_historial_medico.Margin = New System.Windows.Forms.Padding(4)
        Me.rv_historial_medico.MinimumSize = New System.Drawing.Size(1057, 507)
        Me.rv_historial_medico.Name = "rv_historial_medico"
        Me.rv_historial_medico.Size = New System.Drawing.Size(1106, 737)
        Me.rv_historial_medico.TabIndex = 0
        '
        'cmb_filtro_paciente
        '
        Me.cmb_filtro_paciente.FormattingEnabled = True
        Me.cmb_filtro_paciente.Location = New System.Drawing.Point(140, 5)
        Me.cmb_filtro_paciente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_filtro_paciente.Name = "cmb_filtro_paciente"
        Me.cmb_filtro_paciente.Size = New System.Drawing.Size(260, 24)
        Me.cmb_filtro_paciente.TabIndex = 1
        '
        'lbl_filtro_paciente
        '
        Me.lbl_filtro_paciente.AutoSize = True
        Me.lbl_filtro_paciente.Location = New System.Drawing.Point(63, 9)
        Me.lbl_filtro_paciente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_filtro_paciente.Name = "lbl_filtro_paciente"
        Me.lbl_filtro_paciente.Size = New System.Drawing.Size(67, 17)
        Me.lbl_filtro_paciente.TabIndex = 2
        Me.lbl_filtro_paciente.Text = "Paciente:"
        '
        'HistorialMedico_DataSet
        '
        Me.HistorialMedico_DataSet.DataSetName = "HistorialMedico_DataSet"
        Me.HistorialMedico_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frm_historial_medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 743)
        Me.Controls.Add(Me.lbl_filtro_paciente)
        Me.Controls.Add(Me.cmb_filtro_paciente)
        Me.Controls.Add(Me.rv_historial_medico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1138, 790)
        Me.Name = "frm_historial_medico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Historial Medico"
        CType(Me.Historial_MedicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorialMedico_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rv_historial_medico As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Historial_MedicoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmb_filtro_paciente As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_filtro_paciente As System.Windows.Forms.Label
    Friend WithEvents HistorialMedico_DataSet As ConsultorioOdontologico.HistorialMedico_DataSet
End Class
