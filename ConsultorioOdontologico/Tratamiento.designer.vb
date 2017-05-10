<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_tratamiento
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
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.grid_tratamientos = New System.Windows.Forms.DataGridView()
        Me.id_tratamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.grp_descripcion = New System.Windows.Forms.GroupBox()
        Me.txt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.grp_costo = New System.Windows.Forms.GroupBox()
        Me.txt_costo = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_campos_obligatorios = New System.Windows.Forms.Label()
        Me.txt_filtro_descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_filtro_descripcion = New System.Windows.Forms.Label()
        CType(Me.grid_tratamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_descripcion.SuspendLayout()
        Me.grp_costo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(240, 16)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 67
        Me.lblFecha.Text = "Fecha"
        '
        'grid_tratamientos
        '
        Me.grid_tratamientos.AllowUserToAddRows = False
        Me.grid_tratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_tratamientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tratamiento, Me.descripcion, Me.costo})
        Me.grid_tratamientos.Location = New System.Drawing.Point(12, 224)
        Me.grid_tratamientos.Name = "grid_tratamientos"
        Me.grid_tratamientos.ReadOnly = True
        Me.grid_tratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_tratamientos.Size = New System.Drawing.Size(375, 139)
        Me.grid_tratamientos.TabIndex = 69
        '
        'id_tratamiento
        '
        Me.id_tratamiento.FillWeight = 5.0!
        Me.id_tratamiento.HeaderText = "ID"
        Me.id_tratamiento.Name = "id_tratamiento"
        Me.id_tratamiento.ReadOnly = True
        Me.id_tratamiento.Visible = False
        Me.id_tratamiento.Width = 5
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 260
        '
        'costo
        '
        Me.costo.HeaderText = "Costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        Me.costo.Width = 70
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_nuevo.Location = New System.Drawing.Point(12, 378)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(89, 23)
        Me.cmd_nuevo.TabIndex = 0
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Enabled = False
        Me.cmd_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_registrar.Location = New System.Drawing.Point(107, 378)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(89, 23)
        Me.cmd_registrar.TabIndex = 1
        Me.cmd_registrar.Text = "Guardar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Enabled = False
        Me.cmd_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_eliminar.Location = New System.Drawing.Point(202, 378)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(89, 23)
        Me.cmd_eliminar.TabIndex = 78
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir.Location = New System.Drawing.Point(297, 378)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(89, 23)
        Me.cmd_salir.TabIndex = 79
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'grp_descripcion
        '
        Me.grp_descripcion.Controls.Add(Me.txt_descripcion)
        Me.grp_descripcion.Location = New System.Drawing.Point(12, 12)
        Me.grp_descripcion.Name = "grp_descripcion"
        Me.grp_descripcion.Size = New System.Drawing.Size(375, 81)
        Me.grp_descripcion.TabIndex = 81
        Me.grp_descripcion.TabStop = False
        Me.grp_descripcion.Text = "Descripción del tratamiento*"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(6, 19)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(363, 50)
        Me.txt_descripcion.TabIndex = 0
        Me.txt_descripcion.Text = ""
        '
        'grp_costo
        '
        Me.grp_costo.Controls.Add(Me.txt_costo)
        Me.grp_costo.Location = New System.Drawing.Point(12, 104)
        Me.grp_costo.Name = "grp_costo"
        Me.grp_costo.Size = New System.Drawing.Size(375, 51)
        Me.grp_costo.TabIndex = 85
        Me.grp_costo.TabStop = False
        Me.grp_costo.Text = "Costo del tratamiento*"
        '
        'txt_costo
        '
        Me.txt_costo.Location = New System.Drawing.Point(6, 19)
        Me.txt_costo.Mask = "0000.00"
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Size = New System.Drawing.Size(46, 20)
        Me.txt_costo.TabIndex = 0
        '
        'lbl_campos_obligatorios
        '
        Me.lbl_campos_obligatorios.AutoSize = True
        Me.lbl_campos_obligatorios.Location = New System.Drawing.Point(278, 156)
        Me.lbl_campos_obligatorios.Name = "lbl_campos_obligatorios"
        Me.lbl_campos_obligatorios.Size = New System.Drawing.Size(108, 13)
        Me.lbl_campos_obligatorios.TabIndex = 89
        Me.lbl_campos_obligatorios.Text = "* Campos obligatorios"
        '
        'txt_filtro_descripcion
        '
        Me.txt_filtro_descripcion.Location = New System.Drawing.Point(128, 188)
        Me.txt_filtro_descripcion.Name = "txt_filtro_descripcion"
        Me.txt_filtro_descripcion.Size = New System.Drawing.Size(253, 20)
        Me.txt_filtro_descripcion.TabIndex = 91
        '
        'lbl_filtro_descripcion
        '
        Me.lbl_filtro_descripcion.AutoSize = True
        Me.lbl_filtro_descripcion.Location = New System.Drawing.Point(15, 191)
        Me.lbl_filtro_descripcion.Name = "lbl_filtro_descripcion"
        Me.lbl_filtro_descripcion.Size = New System.Drawing.Size(107, 13)
        Me.lbl_filtro_descripcion.TabIndex = 90
        Me.lbl_filtro_descripcion.Text = "Filtrar por descripción"
        '
        'frm_registrar_tratamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 411)
        Me.Controls.Add(Me.txt_filtro_descripcion)
        Me.Controls.Add(Me.lbl_filtro_descripcion)
        Me.Controls.Add(Me.lbl_campos_obligatorios)
        Me.Controls.Add(Me.grp_costo)
        Me.Controls.Add(Me.grp_descripcion)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grid_tratamientos)
        Me.Controls.Add(Me.lblFecha)
        Me.MaximumSize = New System.Drawing.Size(414, 450)
        Me.MinimumSize = New System.Drawing.Size(414, 450)
        Me.Name = "frm_registrar_tratamiento"
        Me.Text = "Registrar Tratamiento"
        CType(Me.grid_tratamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_descripcion.ResumeLayout(False)
        Me.grp_costo.ResumeLayout(False)
        Me.grp_costo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents grid_tratamientos As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_registrar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents grp_descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents grp_costo As System.Windows.Forms.GroupBox
    Friend WithEvents txt_costo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents id_tratamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_campos_obligatorios As System.Windows.Forms.Label
    Friend WithEvents txt_filtro_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_filtro_descripcion As System.Windows.Forms.Label

End Class
