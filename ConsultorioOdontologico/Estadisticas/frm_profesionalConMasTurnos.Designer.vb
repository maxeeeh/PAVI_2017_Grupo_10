﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_profesionalConMasTurnos
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
        Me.ProfesionalConMasTurnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Estadisticas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesionalConMasTurnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ProfesionalConMasTurnos"
        ReportDataSource1.Value = Me.ProfesionalConMasTurnosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.ProfesionalConMasTurnos_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(903, 567)
        Me.ReportViewer1.TabIndex = 0
        '
        'Estadisticas_DataSet
        '
        Me.Estadisticas_DataSet.DataSetName = "Estadisticas_DataSet"
        Me.Estadisticas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfesionalConMasTurnosBindingSource
        '
        Me.ProfesionalConMasTurnosBindingSource.DataMember = "ProfesionalConMasTurnos"
        Me.ProfesionalConMasTurnosBindingSource.DataSource = Me.Estadisticas_DataSet
        '
        'frm_profesionalConMasTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 568)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_profesionalConMasTurnos"
        Me.Text = "frm_profesionalConMasTurnos"
        CType(Me.Estadisticas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesionalConMasTurnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProfesionalConMasTurnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Estadisticas_DataSet As ConsultorioOdontologico.Estadisticas_DataSet
End Class
