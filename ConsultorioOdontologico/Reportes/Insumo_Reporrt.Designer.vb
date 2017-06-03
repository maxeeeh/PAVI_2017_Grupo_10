<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insumo_Reporrt
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
        Me.InsumosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Insumo_DataSet = New ConsultorioOdontologico.Insumo_DataSet()
        CType(Me.InsumosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insumo_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DS_Insumo"
        ReportDataSource1.Value = Me.InsumosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.Insumo_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(35, 46)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(530, 347)
        Me.ReportViewer1.TabIndex = 0
        '
        'InsumosBindingSource
        '
        Me.InsumosBindingSource.DataMember = "Insumos"
        Me.InsumosBindingSource.DataSource = Me.Insumo_DataSet
        '
        'Insumo_DataSet
        '
        Me.Insumo_DataSet.DataSetName = "Insumo_DataSet"
        Me.Insumo_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Insumo_Reporrt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 405)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Insumo_Reporrt"
        Me.Text = "Insumo_Reporrt"
        CType(Me.InsumosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insumo_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents InsumosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Insumo_DataSet As ConsultorioOdontologico.Insumo_DataSet
End Class
