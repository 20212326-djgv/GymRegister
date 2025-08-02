<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbRol = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.dgvUsuarios)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbRol)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtContraseña)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(762, 546)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO DE USUARIOS"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLimpiar.Location = New System.Drawing.Point(649, 89)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(85, 62)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar Campos"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.Location = New System.Drawing.Point(555, 92)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(85, 62)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar Usuario"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditar.Location = New System.Drawing.Point(464, 92)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(85, 62)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "Editar Usuario"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregar.Location = New System.Drawing.Point(373, 92)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(85, 62)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar usuario"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(26, 160)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.Size = New System.Drawing.Size(708, 376)
        Me.dgvUsuarios.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ROL"
        '
        'cbRol
        '
        Me.cbRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Items.AddRange(New Object() {"ROL", "Administrador", "Empleado"})
        Me.cbRol.Location = New System.Drawing.Point(137, 126)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(121, 28)
        Me.cbRol.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Correo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(137, 89)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(220, 26)
        Me.txtContraseña.TabIndex = 2
        '
        'txtCorreo
        '
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(137, 57)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(220, 26)
        Me.txtCorreo.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(137, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(220, 26)
        Me.txtNombre.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Harlow Solid Italic", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(346, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(434, 61)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Registro de Usuarios"
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GymRegister.My.Resources.Resources.Captura_de_pantalla_2025_04_15_220716
        Me.ClientSize = New System.Drawing.Size(800, 638)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUsuario"
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbRol As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Label5 As Label
End Class
