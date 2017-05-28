<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_insumo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_insumo))
        Me.txt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.grp_descripcion = New System.Windows.Forms.GroupBox()
        Me.lst_insumos = New System.Windows.Forms.ListBox()
        Me.lbl_filtro = New System.Windows.Forms.Label()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        Me.lbl_campo_obligatorio = New System.Windows.Forms.Label()
        Me.grp_descripcion.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(6, 19)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(362, 116)
        Me.txt_descripcion.TabIndex = 0
        Me.txt_descripcion.Text = ""
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Location = New System.Drawing.Point(129, 376)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_registrar.TabIndex = 2
        Me.cmd_registrar.Text = "Guardar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(301, 376)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(75, 23)
        Me.cmd_salir.TabIndex = 3
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'grp_descripcion
        '
        Me.grp_descripcion.Controls.Add(Me.txt_descripcion)
        Me.grp_descripcion.Location = New System.Drawing.Point(12, 12)
        Me.grp_descripcion.Name = "grp_descripcion"
        Me.grp_descripcion.Size = New System.Drawing.Size(374, 141)
        Me.grp_descripcion.TabIndex = 4
        Me.grp_descripcion.TabStop = False
        Me.grp_descripcion.Text = "Descripcion*"
        '
        'lst_insumos
        '
        Me.lst_insumos.FormattingEnabled = True
        Me.lst_insumos.Location = New System.Drawing.Point(18, 204)
        Me.lst_insumos.Name = "lst_insumos"
        Me.lst_insumos.Size = New System.Drawing.Size(362, 160)
        Me.lst_insumos.TabIndex = 5
        '
        'lbl_filtro
        '
        Me.lbl_filtro.AutoSize = True
        Me.lbl_filtro.Location = New System.Drawing.Point(15, 179)
        Me.lbl_filtro.Name = "lbl_filtro"
        Me.lbl_filtro.Size = New System.Drawing.Size(107, 13)
        Me.lbl_filtro.TabIndex = 6
        Me.lbl_filtro.Text = "Filtrar por descripcion"
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(129, 176)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(251, 20)
        Me.txt_filtro.TabIndex = 7
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Location = New System.Drawing.Point(215, 376)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_borrar.TabIndex = 8
        Me.cmd_borrar.Text = "Eliminar"
        Me.cmd_borrar.UseVisualStyleBackColor = True
        '
        'lbl_campo_obligatorio
        '
        Me.lbl_campo_obligatorio.AutoSize = True
        Me.lbl_campo_obligatorio.Location = New System.Drawing.Point(287, 156)
        Me.lbl_campo_obligatorio.Name = "lbl_campo_obligatorio"
        Me.lbl_campo_obligatorio.Size = New System.Drawing.Size(98, 13)
        Me.lbl_campo_obligatorio.TabIndex = 9
        Me.lbl_campo_obligatorio.Text = "* Campo obligatorio"
        '
        'frm_registrar_insumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 411)
        Me.Controls.Add(Me.lbl_campo_obligatorio)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.lbl_filtro)
        Me.Controls.Add(Me.lst_insumos)
        Me.Controls.Add(Me.grp_descripcion)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(414, 450)
        Me.MinimumSize = New System.Drawing.Size(414, 450)
        Me.Name = "frm_registrar_insumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Insumo"
        Me.grp_descripcion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents cmd_registrar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents grp_descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents lst_insumos As System.Windows.Forms.ListBox
    Friend WithEvents lbl_filtro As System.Windows.Forms.Label
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents cmd_borrar As System.Windows.Forms.Button
    Friend WithEvents lbl_campo_obligatorio As System.Windows.Forms.Label
End Class
