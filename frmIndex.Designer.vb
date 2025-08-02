<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIndex
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnServicios = New System.Windows.Forms.Button()
        Me.btnReservas = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuloAdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.GymRegister.My.Resources.Resources.Captura_de_pantalla_2025_04_15_220716
        Me.Panel1.Controls.Add(Me.btnServicios)
        Me.Panel1.Controls.Add(Me.btnReservas)
        Me.Panel1.Controls.Add(Me.btnUsuarios)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 540)
        Me.Panel1.TabIndex = 0
        '
        'btnServicios
        '
        Me.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServicios.Location = New System.Drawing.Point(63, 240)
        Me.btnServicios.Name = "btnServicios"
        Me.btnServicios.Size = New System.Drawing.Size(162, 39)
        Me.btnServicios.TabIndex = 7
        Me.btnServicios.Text = "Servicios"
        Me.btnServicios.UseVisualStyleBackColor = True
        '
        'btnReservas
        '
        Me.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservas.Location = New System.Drawing.Point(574, 240)
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.Size = New System.Drawing.Size(162, 39)
        Me.btnReservas.TabIndex = 6
        Me.btnReservas.Text = "Registro de Reservas"
        Me.btnReservas.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.Location = New System.Drawing.Point(314, 240)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(162, 39)
        Me.btnUsuarios.TabIndex = 5
        Me.btnUsuarios.Text = "Registro de Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GymRegister.My.Resources.Resources.Captura_de_pantalla_2025_04_15_221217
        Me.PictureBox2.Location = New System.Drawing.Point(0, 339)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(806, 198)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(577, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "System Register"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ContactoToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(802, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.NuevoToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.ImportarToolStripMenuItem, Me.ExportarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar como..."
        '
        'ImportarToolStripMenuItem
        '
        Me.ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
        Me.ImportarToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ImportarToolStripMenuItem.Text = "Importar"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaseDeDatosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ContactoToolStripMenuItem.Text = "Contacto"
        '
        'BaseDeDatosToolStripMenuItem
        '
        Me.BaseDeDatosToolStripMenuItem.Name = "BaseDeDatosToolStripMenuItem"
        Me.BaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.BaseDeDatosToolStripMenuItem.Text = "Base de Datos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiciosToolStripMenuItem, Me.RegistroDeUsuariosToolStripMenuItem, Me.ModuloAdministracionToolStripMenuItem, Me.ReservasToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'RegistroDeUsuariosToolStripMenuItem
        '
        Me.RegistroDeUsuariosToolStripMenuItem.Name = "RegistroDeUsuariosToolStripMenuItem"
        Me.RegistroDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.RegistroDeUsuariosToolStripMenuItem.Text = "Registro de Usuarios"
        '
        'ModuloAdministracionToolStripMenuItem
        '
        Me.ModuloAdministracionToolStripMenuItem.Name = "ModuloAdministracionToolStripMenuItem"
        Me.ModuloAdministracionToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ModuloAdministracionToolStripMenuItem.Text = "Modulo Administracion"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(712, 80)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "G  Y  M"
        '
        'frmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 535)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmIndex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GymRegisterSystem"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModuloAdministracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReservas As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnServicios As Button
End Class
