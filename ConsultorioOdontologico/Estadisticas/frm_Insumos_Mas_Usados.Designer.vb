<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Insumos_Mas_Usados
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
        Me.Insumos_Mas_UsadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Estadisticas_DataSet = New ConsultorioOdontologico.Estadisticas_DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.Insumos_Mas_UsadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Estadisticas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Insumos_Mas_UsadosBindingSource
        '
        Me.Insumos_Mas_UsadosBindingSource.DataMember = "Insumos_Mas_Usados"
        Me.Insumos_Mas_UsadosBindingSource.DataSource = Me.Estadisticas_DataSet
        '
        'Estadisticas_DataSet
        '
        Me.Estadisticas_DataSet.DataSetName = "Estadisticas_DataSet"
        Me.Estadisticas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.KeepSessionAlive = False
        ReportDataSource1.Name = "Insumos_Mas_Usados"
        ReportDataSource1.Value = Me.Insumos_Mas_UsadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.Insumos_mas_Usados_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 13)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1122, 764)
        Me.ReportViewer1.TabIndex = 0
        '
        'frm_Insumos_Mas_Usados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 790)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_Insumos_Mas_Usados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frm_Insumos_Mas_Usados"
        CType(Me.Insumos_Mas_UsadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Estadisticas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Insumos_Mas_UsadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Estadisticas_DataSet As ConsultorioOdontologico.Estadisticas_DataSet
End Class
