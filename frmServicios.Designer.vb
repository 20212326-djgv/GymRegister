<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicios
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
        Me.dgvServicios = New System.Windows.Forms.DataGridView()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ChkEstado = New System.Windows.Forms.CheckBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvServicios)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.ChkEstado)
        Me.GroupBox1.Controls.Add(Me.txtDuracion)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 412)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SERVICIOS"
        '
        'dgvServicios
        '
        Me.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServicios.Location = New System.Drawing.Point(79, 107)
        Me.dgvServicios.Name = "dgvServicios"
        Me.dgvServicios.Size = New System.Drawing.Size(544, 298)
        Me.dgvServicios.TabIndex = 14
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(699, 151)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 41)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(699, 109)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 41)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(699, 67)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 41)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(699, 22)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 44)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'ChkEstado
        '
        Me.ChkEstado.AutoSize = True
        Me.ChkEstado.Location = New System.Drawing.Point(576, 47)
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.Size = New System.Drawing.Size(69, 20)
        Me.ChkEstado.TabIndex = 8
        Me.ChkEstado.Text = "Activo"
        Me.ChkEstado.UseVisualStyleBackColor = True
        '
        'txtDuracion
        '
        Me.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracion.Location = New System.Drawing.Point(83, 73)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(200, 22)
        Me.txtDuracion.TabIndex = 7
        '
        'txtPrecio
        '
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecio.Location = New System.Drawing.Point(386, 73)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(175, 22)
        Me.txtPrecio.TabIndex = 6
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(386, 45)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(175, 22)
        Me.txtDescripcion.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(83, 42)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 22)
        Me.txtNombre.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(8, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Duracion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(328, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(290, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(15, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre"
        '
        'frmServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GymRegister.My.Resources.Resources.Captura_de_pantalla_2025_04_15_220716
        Me.ClientSize = New System.Drawing.Size(794, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmServicios"
        Me.Text = "frmServicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvServicios As DataGridView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents ChkEstado As CheckBox
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
