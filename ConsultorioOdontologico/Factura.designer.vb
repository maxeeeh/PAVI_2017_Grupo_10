﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_factura
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
        Me.cmb_pacientes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_intervenciones = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grid_intervenciones = New System.Windows.Forms.DataGridView()
        Me.id_intervencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.cmd_remover = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_monto_total = New System.Windows.Forms.TextBox()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.rbt_efectivo = New System.Windows.Forms.RadioButton()
        Me.rbt_tarjeta = New System.Windows.Forms.RadioButton()
        Me.lbl_forma_pago = New System.Windows.Forms.Label()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.lbl_campos_obligatorios = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.grid_intervenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_pacientes
        '
        Me.cmb_pacientes.FormattingEnabled = True
        Me.cmb_pacientes.Location = New System.Drawing.Point(152, 18)
        Me.cmb_pacientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_pacientes.Name = "cmb_pacientes"
        Me.cmb_pacientes.Size = New System.Drawing.Size(160, 24)
        Me.cmb_pacientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pacientes *"
        '
        'cmb_intervenciones
        '
        Me.cmb_intervenciones.FormattingEnabled = True
        Me.cmb_intervenciones.Location = New System.Drawing.Point(152, 66)
        Me.cmb_intervenciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_intervenciones.Name = "cmb_intervenciones"
        Me.cmb_intervenciones.Size = New System.Drawing.Size(160, 24)
        Me.cmb_intervenciones.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Intervenciones *"
        '
        'grid_intervenciones
        '
        Me.grid_intervenciones.AllowUserToAddRows = False
        Me.grid_intervenciones.AllowUserToDeleteRows = False
        Me.grid_intervenciones.AllowUserToResizeColumns = False
        Me.grid_intervenciones.AllowUserToResizeRows = False
        Me.grid_intervenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_intervenciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_intervencion, Me.fecha, Me.id_empleado, Me.empleado, Me.monto})
        Me.grid_intervenciones.Location = New System.Drawing.Point(25, 231)
        Me.grid_intervenciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_intervenciones.Name = "grid_intervenciones"
        Me.grid_intervenciones.Size = New System.Drawing.Size(525, 162)
        Me.grid_intervenciones.TabIndex = 4
        '
        'id_intervencion
        '
        Me.id_intervencion.HeaderText = "id_intervencion"
        Me.id_intervencion.Name = "id_intervencion"
        Me.id_intervencion.Visible = False
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        '
        'id_empleado
        '
        Me.id_empleado.HeaderText = "id_empleado"
        Me.id_empleado.Name = "id_empleado"
        Me.id_empleado.Visible = False
        '
        'empleado
        '
        Me.empleado.HeaderText = "Empleado"
        Me.empleado.Name = "empleado"
        Me.empleado.Width = 200
        '
        'monto
        '
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.Width = 50
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Enabled = False
        Me.cmd_agregar.Location = New System.Drawing.Point(321, 64)
        Me.cmd_agregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(100, 28)
        Me.cmd_agregar.TabIndex = 5
        Me.cmd_agregar.Text = "Agregar"
        Me.cmd_agregar.UseVisualStyleBackColor = True
        '
        'cmd_remover
        '
        Me.cmd_remover.Enabled = False
        Me.cmd_remover.Location = New System.Drawing.Point(25, 188)
        Me.cmd_remover.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_remover.Name = "cmd_remover"
        Me.cmd_remover.Size = New System.Drawing.Size(267, 28)
        Me.cmd_remover.TabIndex = 6
        Me.cmd_remover.Text = "Remover Intervencion Seleccionada"
        Me.cmd_remover.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Monto Total:"
        '
        'txt_monto_total
        '
        Me.txt_monto_total.Location = New System.Drawing.Point(359, 161)
        Me.txt_monto_total.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_monto_total.Name = "txt_monto_total"
        Me.txt_monto_total.ReadOnly = True
        Me.txt_monto_total.Size = New System.Drawing.Size(132, 22)
        Me.txt_monto_total.TabIndex = 8
        Me.txt_monto_total.Text = "$ 0"
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(347, 404)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(100, 28)
        Me.cmd_guardar.TabIndex = 9
        Me.cmd_guardar.Text = "Generar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(455, 404)
        Me.cmd_salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(100, 28)
        Me.cmd_salir.TabIndex = 10
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'rbt_efectivo
        '
        Me.rbt_efectivo.AutoSize = True
        Me.rbt_efectivo.Checked = True
        Me.rbt_efectivo.Location = New System.Drawing.Point(152, 101)
        Me.rbt_efectivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbt_efectivo.Name = "rbt_efectivo"
        Me.rbt_efectivo.Size = New System.Drawing.Size(79, 21)
        Me.rbt_efectivo.TabIndex = 11
        Me.rbt_efectivo.TabStop = True
        Me.rbt_efectivo.Text = "Efectivo"
        Me.rbt_efectivo.UseVisualStyleBackColor = True
        '
        'rbt_tarjeta
        '
        Me.rbt_tarjeta.AutoSize = True
        Me.rbt_tarjeta.Location = New System.Drawing.Point(152, 129)
        Me.rbt_tarjeta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbt_tarjeta.Name = "rbt_tarjeta"
        Me.rbt_tarjeta.Size = New System.Drawing.Size(74, 21)
        Me.rbt_tarjeta.TabIndex = 12
        Me.rbt_tarjeta.Text = "Tarjeta"
        Me.rbt_tarjeta.UseVisualStyleBackColor = True
        '
        'lbl_forma_pago
        '
        Me.lbl_forma_pago.AutoSize = True
        Me.lbl_forma_pago.Location = New System.Drawing.Point(35, 101)
        Me.lbl_forma_pago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_forma_pago.Name = "lbl_forma_pago"
        Me.lbl_forma_pago.Size = New System.Drawing.Size(114, 17)
        Me.lbl_forma_pago.TabIndex = 13
        Me.lbl_forma_pago.Text = "Forma de Pago *"
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(239, 404)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(100, 28)
        Me.cmd_nuevo.TabIndex = 14
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'lbl_campos_obligatorios
        '
        Me.lbl_campos_obligatorios.AutoSize = True
        Me.lbl_campos_obligatorios.Location = New System.Drawing.Point(355, 129)
        Me.lbl_campos_obligatorios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_campos_obligatorios.Name = "lbl_campos_obligatorios"
        Me.lbl_campos_obligatorios.Size = New System.Drawing.Size(145, 17)
        Me.lbl_campos_obligatorios.TabIndex = 27
        Me.lbl_campos_obligatorios.Text = "* Campos obligatorios"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(407, 212)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "* Campos obligatorios"
        '
        'frm_factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 441)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_campos_obligatorios)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.lbl_forma_pago)
        Me.Controls.Add(Me.rbt_tarjeta)
        Me.Controls.Add(Me.rbt_efectivo)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.txt_monto_total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmd_remover)
        Me.Controls.Add(Me.cmd_agregar)
        Me.Controls.Add(Me.grid_intervenciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_intervenciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_pacientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Factura"
        CType(Me.grid_intervenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_pacientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_intervenciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grid_intervenciones As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_remover As System.Windows.Forms.Button
    Friend WithEvents id_intervencion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_monto_total As System.Windows.Forms.TextBox
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents rbt_efectivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_tarjeta As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_forma_pago As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents lbl_campos_obligatorios As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
