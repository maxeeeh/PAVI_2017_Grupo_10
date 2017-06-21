<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_acceso_sistema
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMPacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoPacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialMedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticaDeTratamientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticaDeTurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarTurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarIntervencionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMTratamientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticaInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacientesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.SoporteToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1144, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMPacientesToolStripMenuItem, Me.ListadoPacientesToolStripMenuItem, Me.HistorialMedicoToolStripMenuItem, Me.EstadisticaDeTratamientosToolStripMenuItem})
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'ABMPacientesToolStripMenuItem
        '
        Me.ABMPacientesToolStripMenuItem.Name = "ABMPacientesToolStripMenuItem"
        Me.ABMPacientesToolStripMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.ABMPacientesToolStripMenuItem.Text = "ABM Pacientes"
        '
        'ListadoPacientesToolStripMenuItem
        '
        Me.ListadoPacientesToolStripMenuItem.Name = "ListadoPacientesToolStripMenuItem"
        Me.ListadoPacientesToolStripMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.ListadoPacientesToolStripMenuItem.Text = "Listado Pacientes"
        '
        'HistorialMedicoToolStripMenuItem
        '
        Me.HistorialMedicoToolStripMenuItem.Name = "HistorialMedicoToolStripMenuItem"
        Me.HistorialMedicoToolStripMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.HistorialMedicoToolStripMenuItem.Text = "Historial Medico"
        '
        'EstadisticaDeTratamientosToolStripMenuItem
        '
        Me.EstadisticaDeTratamientosToolStripMenuItem.Name = "EstadisticaDeTratamientosToolStripMenuItem"
        Me.EstadisticaDeTratamientosToolStripMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.EstadisticaDeTratamientosToolStripMenuItem.Text = "Estadistica de tratamientos"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMEmpleadosToolStripMenuItem, Me.ABMCargosToolStripMenuItem, Me.EstadisticaDeTurnosToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ABMEmpleadosToolStripMenuItem
        '
        Me.ABMEmpleadosToolStripMenuItem.Name = "ABMEmpleadosToolStripMenuItem"
        Me.ABMEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.ABMEmpleadosToolStripMenuItem.Text = "ABM Empleados"
        '
        'ABMCargosToolStripMenuItem
        '
        Me.ABMCargosToolStripMenuItem.Name = "ABMCargosToolStripMenuItem"
        Me.ABMCargosToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.ABMCargosToolStripMenuItem.Text = "ABM Cargos"
        '
        'EstadisticaDeTurnosToolStripMenuItem
        '
        Me.EstadisticaDeTurnosToolStripMenuItem.Name = "EstadisticaDeTurnosToolStripMenuItem"
        Me.EstadisticaDeTurnosToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.EstadisticaDeTurnosToolStripMenuItem.Text = "Estadistica de Turnos"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarTurnosToolStripMenuItem, Me.RegistrarIntervencionToolStripMenuItem, Me.GenerarFacturaToolStripMenuItem})
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.TransaccionesToolStripMenuItem.Text = "Transacciones"
        '
        'RegistrarTurnosToolStripMenuItem
        '
        Me.RegistrarTurnosToolStripMenuItem.Name = "RegistrarTurnosToolStripMenuItem"
        Me.RegistrarTurnosToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.RegistrarTurnosToolStripMenuItem.Text = "Registrar Turnos"
        '
        'RegistrarIntervencionToolStripMenuItem
        '
        Me.RegistrarIntervencionToolStripMenuItem.Name = "RegistrarIntervencionToolStripMenuItem"
        Me.RegistrarIntervencionToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.RegistrarIntervencionToolStripMenuItem.Text = "Registrar Intervencion"
        '
        'GenerarFacturaToolStripMenuItem
        '
        Me.GenerarFacturaToolStripMenuItem.Name = "GenerarFacturaToolStripMenuItem"
        Me.GenerarFacturaToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.GenerarFacturaToolStripMenuItem.Text = "Generar Factura"
        '
        'SoporteToolStripMenuItem
        '
        Me.SoporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMTratamientosToolStripMenuItem, Me.ABMInsumosToolStripMenuItem, Me.ListadoInsumosToolStripMenuItem, Me.EstadisticaInsumosToolStripMenuItem})
        Me.SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        Me.SoporteToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.SoporteToolStripMenuItem.Text = "Soporte"
        '
        'ABMTratamientosToolStripMenuItem
        '
        Me.ABMTratamientosToolStripMenuItem.Name = "ABMTratamientosToolStripMenuItem"
        Me.ABMTratamientosToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.ABMTratamientosToolStripMenuItem.Text = "ABM Tratamientos"
        '
        'ABMInsumosToolStripMenuItem
        '
        Me.ABMInsumosToolStripMenuItem.Name = "ABMInsumosToolStripMenuItem"
        Me.ABMInsumosToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.ABMInsumosToolStripMenuItem.Text = "ABM Insumos"
        '
        'ListadoInsumosToolStripMenuItem
        '
        Me.ListadoInsumosToolStripMenuItem.Name = "ListadoInsumosToolStripMenuItem"
        Me.ListadoInsumosToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.ListadoInsumosToolStripMenuItem.Text = "Listado Insumos"
        '
        'EstadisticaInsumosToolStripMenuItem
        '
        Me.EstadisticaInsumosToolStripMenuItem.Name = "EstadisticaInsumosToolStripMenuItem"
        Me.EstadisticaInsumosToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.EstadisticaInsumosToolStripMenuItem.Text = "Estadistica Insumos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'frm_acceso_sistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 827)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1162, 874)
        Me.MinimumSize = New System.Drawing.Size(1162, 874)
        Me.Name = "frm_acceso_sistema"
        Me.Text = "Consultorio Odontologico"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PacientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMPacientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticaDeTratamientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistorialMedicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMCargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticaDeTurnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoPacientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarTurnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarIntervencionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMInsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMTratamientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoInsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticaInsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
