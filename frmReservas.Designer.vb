<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservas
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
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.cbServicio = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvReservas = New System.Windows.Forms.DataGridView()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.dtFechaHora = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbUsuario
        '
        Me.cbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(97, 30)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(156, 26)
        Me.cbUsuario.TabIndex = 0
        '
        'cbServicio
        '
        Me.cbServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbServicio.FormattingEnabled = True
        Me.cbServicio.Location = New System.Drawing.Point(97, 62)
        Me.cbServicio.Name = "cbServicio"
        Me.cbServicio.Size = New System.Drawing.Size(156, 26)
        Me.cbServicio.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.dgvReservas)
        Me.GroupBox1.Controls.Add(Me.chkEstado)
        Me.GroupBox1.Controls.Add(Me.dtFechaHora)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbUsuario)
        Me.GroupBox1.Controls.Add(Me.cbServicio)
        Me.GroupBox1.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 515)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESERVAS"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.Location = New System.Drawing.Point(663, 68)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(73, 58)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEliminar.Location = New System.Drawing.Point(584, 68)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 58)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEditar.Location = New System.Drawing.Point(505, 68)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(73, 58)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAgregar.Location = New System.Drawing.Point(426, 68)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(73, 58)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvReservas
        '
        Me.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservas.Location = New System.Drawing.Point(21, 160)
        Me.dgvReservas.Name = "dgvReservas"
        Me.dgvReservas.Size = New System.Drawing.Size(734, 338)
        Me.dgvReservas.TabIndex = 8
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.Location = New System.Drawing.Point(97, 130)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(77, 24)
        Me.chkEstado.TabIndex = 7
        Me.chkEstado.Text = "Activo"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'dtFechaHora
        '
        Me.dtFechaHora.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaHora.Location = New System.Drawing.Point(97, 95)
        Me.dtFechaHora.Name = "dtFechaHora"
        Me.dtFechaHora.Size = New System.Drawing.Size(208, 25)
        Me.dtFechaHora.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Horario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Servicios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuarios"
        '
        'frmReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GymRegister.My.Resources.Resources.Captura_de_pantalla_2025_04_15_220716
        Me.ClientSize = New System.Drawing.Size(800, 636)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReservas"
        Me.Text = "frmReservas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents cbServicio As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvReservas As DataGridView
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents dtFechaHora As DateTimePicker
End Class
