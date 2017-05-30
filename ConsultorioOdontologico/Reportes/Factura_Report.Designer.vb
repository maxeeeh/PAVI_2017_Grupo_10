<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_factura_report
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
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Factura_DataSet = New ConsultorioOdontologico.Factura_DataSet()
        Me.rv_factura = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factura_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.Factura_DataSet
        '
        'Factura_DataSet
        '
        Me.Factura_DataSet.DataSetName = "Factura_DataSet"
        Me.Factura_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rv_factura
        '
        ReportDataSource1.Name = "DS_Factura"
        ReportDataSource1.Value = Me.FacturaBindingSource
        Me.rv_factura.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_factura.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.Factura_Report.rdlc"
        Me.rv_factura.Location = New System.Drawing.Point(36, 12)
        Me.rv_factura.Name = "rv_factura"
        Me.rv_factura.Size = New System.Drawing.Size(564, 629)
        Me.rv_factura.TabIndex = 0
        '
        'frm_factura_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 656)
        Me.Controls.Add(Me.rv_factura)
        Me.Name = "frm_factura_report"
        Me.Text = "Visualizador Factura"
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factura_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rv_factura As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Factura_DataSet As ConsultorioOdontologico.Factura_DataSet
End Class
