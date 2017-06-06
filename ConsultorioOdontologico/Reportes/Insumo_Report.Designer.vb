<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insumo_report
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
        Me.InsumosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Insumo_DataSet = New ConsultorioOdontologico.Insumo_DataSet()
        Me.rv_insumos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.grp_estado = New System.Windows.Forms.GroupBox()
        Me.rb_deshabilitados = New System.Windows.Forms.RadioButton()
        Me.rb_habilitados = New System.Windows.Forms.RadioButton()
        Me.rb_estado_todos = New System.Windows.Forms.RadioButton()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        CType(Me.InsumosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insumo_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_estado.SuspendLayout()
        Me.SuspendLayout()
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
        'rv_insumos
        '
        ReportDataSource1.Name = "DS_Insumo"
        ReportDataSource1.Value = Me.InsumosBindingSource
        Me.rv_insumos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_insumos.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.Insumo_Report.rdlc"
        Me.rv_insumos.Location = New System.Drawing.Point(12, 66)
        Me.rv_insumos.Name = "rv_insumos"
        Me.rv_insumos.Size = New System.Drawing.Size(593, 425)
        Me.rv_insumos.TabIndex = 0
        '
        'grp_estado
        '
        Me.grp_estado.Controls.Add(Me.rb_deshabilitados)
        Me.grp_estado.Controls.Add(Me.rb_habilitados)
        Me.grp_estado.Controls.Add(Me.rb_estado_todos)
        Me.grp_estado.Location = New System.Drawing.Point(12, 12)
        Me.grp_estado.Name = "grp_estado"
        Me.grp_estado.Size = New System.Drawing.Size(270, 48)
        Me.grp_estado.TabIndex = 4
        Me.grp_estado.TabStop = False
        Me.grp_estado.Text = "Estado"
        '
        'rb_deshabilitados
        '
        Me.rb_deshabilitados.AutoSize = True
        Me.rb_deshabilitados.Location = New System.Drawing.Point(168, 22)
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
        Me.rb_habilitados.Location = New System.Drawing.Point(80, 22)
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
        Me.rb_estado_todos.Location = New System.Drawing.Point(6, 22)
        Me.rb_estado_todos.Name = "rb_estado_todos"
        Me.rb_estado_todos.Size = New System.Drawing.Size(63, 17)
        Me.rb_estado_todos.TabIndex = 0
        Me.rb_estado_todos.Text = "TODOS"
        Me.rb_estado_todos.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(305, 25)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(91, 29)
        Me.cmd_buscar.TabIndex = 5
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'frm_insumo_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 504)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.grp_estado)
        Me.Controls.Add(Me.rv_insumos)
        Me.Name = "frm_insumo_report"
        Me.Text = "Reporte de Insumos"
        CType(Me.InsumosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insumo_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_estado.ResumeLayout(False)
        Me.grp_estado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rv_insumos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents InsumosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Insumo_DataSet As ConsultorioOdontologico.Insumo_DataSet
    Friend WithEvents grp_estado As System.Windows.Forms.GroupBox
    Friend WithEvents rb_deshabilitados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_habilitados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_estado_todos As System.Windows.Forms.RadioButton
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
End Class
