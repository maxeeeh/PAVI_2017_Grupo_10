﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_cargo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_cargo))
        Me.lbl_campo_obligatorio = New System.Windows.Forms.Label()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.lbl_filtro = New System.Windows.Forms.Label()
        Me.lst_cargos = New System.Windows.Forms.ListBox()
        Me.grp_descripcion = New System.Windows.Forms.GroupBox()
        Me.txt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.grp_descripcion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_campo_obligatorio
        '
        Me.lbl_campo_obligatorio.AutoSize = True
        Me.lbl_campo_obligatorio.Location = New System.Drawing.Point(383, 192)
        Me.lbl_campo_obligatorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_campo_obligatorio.Name = "lbl_campo_obligatorio"
        Me.lbl_campo_obligatorio.Size = New System.Drawing.Size(131, 17)
        Me.lbl_campo_obligatorio.TabIndex = 17
        Me.lbl_campo_obligatorio.Text = "* Campo obligatorio"
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Location = New System.Drawing.Point(287, 502)
        Me.cmd_borrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(100, 28)
        Me.cmd_borrar.TabIndex = 16
        Me.cmd_borrar.Text = "Eliminar"
        Me.cmd_borrar.UseVisualStyleBackColor = True
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(172, 217)
        Me.txt_filtro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(333, 22)
        Me.txt_filtro.TabIndex = 15
        '
        'lbl_filtro
        '
        Me.lbl_filtro.AutoSize = True
        Me.lbl_filtro.Location = New System.Drawing.Point(20, 220)
        Me.lbl_filtro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_filtro.Name = "lbl_filtro"
        Me.lbl_filtro.Size = New System.Drawing.Size(145, 17)
        Me.lbl_filtro.TabIndex = 14
        Me.lbl_filtro.Text = "Filtrar por descripcion"
        '
        'lst_cargos
        '
        Me.lst_cargos.FormattingEnabled = True
        Me.lst_cargos.ItemHeight = 16
        Me.lst_cargos.Location = New System.Drawing.Point(24, 251)
        Me.lst_cargos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lst_cargos.Name = "lst_cargos"
        Me.lst_cargos.Size = New System.Drawing.Size(481, 228)
        Me.lst_cargos.TabIndex = 13
        '
        'grp_descripcion
        '
        Me.grp_descripcion.Controls.Add(Me.txt_descripcion)
        Me.grp_descripcion.Location = New System.Drawing.Point(16, 15)
        Me.grp_descripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_descripcion.Name = "grp_descripcion"
        Me.grp_descripcion.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_descripcion.Size = New System.Drawing.Size(499, 174)
        Me.grp_descripcion.TabIndex = 12
        Me.grp_descripcion.TabStop = False
        Me.grp_descripcion.Text = "Descripcion*"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(7, 23)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(483, 142)
        Me.txt_descripcion.TabIndex = 0
        Me.txt_descripcion.Text = ""
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(401, 502)
        Me.cmd_salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(100, 28)
        Me.cmd_salir.TabIndex = 11
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Location = New System.Drawing.Point(172, 502)
        Me.cmd_registrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(100, 28)
        Me.cmd_registrar.TabIndex = 10
        Me.cmd_registrar.Text = "Guardar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'frm_registrar_cargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 543)
        Me.Controls.Add(Me.lbl_campo_obligatorio)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.lbl_filtro)
        Me.Controls.Add(Me.lst_cargos)
        Me.Controls.Add(Me.grp_descripcion)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_registrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(546, 543)
        Me.MinimumSize = New System.Drawing.Size(546, 543)
        Me.Name = "frm_registrar_cargo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Cargo"
        Me.grp_descripcion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_campo_obligatorio As System.Windows.Forms.Label
    Friend WithEvents cmd_borrar As System.Windows.Forms.Button
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_filtro As System.Windows.Forms.Label
    Friend WithEvents lst_cargos As System.Windows.Forms.ListBox
    Friend WithEvents grp_descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_registrar As System.Windows.Forms.Button
End Class
