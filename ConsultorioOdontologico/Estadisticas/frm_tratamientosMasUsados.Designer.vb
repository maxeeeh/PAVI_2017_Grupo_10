<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tratamientosMasUsados
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Estadisticas_DataSet = New ConsultorioOdontologico.Estadisticas_DataSet()
        Me.TratamientosMasUsadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Estadisticas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TratamientosMasUsadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "tratamientosMasUsados"
        ReportDataSource1.Value = Me.TratamientosMasUsadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.TratamientosMasUsados_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(860, 405)
        Me.ReportViewer1.TabIndex = 0
        '
        'Estadisticas_DataSet
        '
        Me.Estadisticas_DataSet.DataSetName = "Estadisticas_DataSet"
        Me.Estadisticas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TratamientosMasUsadosBindingSource
        '
        Me.TratamientosMasUsadosBindingSource.DataMember = "TratamientosMasUsados"
        Me.TratamientosMasUsadosBindingSource.DataSource = Me.Estadisticas_DataSet
        '
        'frm_tratamientosMasUsados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 405)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_tratamientosMasUsados"
        Me.Text = "frm_tratamientosMasUsados"
        CType(Me.Estadisticas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TratamientosMasUsadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TratamientosMasUsadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Estadisticas_DataSet As ConsultorioOdontologico.Estadisticas_DataSet
End Class
