<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionPerfiles
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
        Me.lbUsuarios = New System.Windows.Forms.Label()
        Me.listboxUsuarios = New System.Windows.Forms.ListBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lbApellidos = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.stripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.stripAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.stripGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.checkboxAdmin = New System.Windows.Forms.CheckBox()
        Me.lbAdmin = New System.Windows.Forms.Label()
        Me.btnNotas = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbCaracPermitidos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbUsuarios
        '
        Me.lbUsuarios.AutoSize = True
        Me.lbUsuarios.Location = New System.Drawing.Point(177, 43)
        Me.lbUsuarios.Name = "lbUsuarios"
        Me.lbUsuarios.Size = New System.Drawing.Size(48, 13)
        Me.lbUsuarios.TabIndex = 8
        Me.lbUsuarios.Text = "Usuarios"
        '
        'listboxUsuarios
        '
        Me.listboxUsuarios.FormattingEnabled = True
        Me.listboxUsuarios.Location = New System.Drawing.Point(149, 59)
        Me.listboxUsuarios.Name = "listboxUsuarios"
        Me.listboxUsuarios.Size = New System.Drawing.Size(120, 95)
        Me.listboxUsuarios.TabIndex = 9
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(395, 263)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(212, 20)
        Me.txtTelefono.TabIndex = 10
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(287, 132)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 11
        Me.lbNombre.Text = "Nombre:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(287, 94)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(102, 13)
        Me.lbCodigo.TabIndex = 12
        Me.lbCodigo.Text = "Código/Contraseña:"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(395, 94)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(49, 20)
        Me.txtContrasena.TabIndex = 13
        '
        'lbApellidos
        '
        Me.lbApellidos.AutoSize = True
        Me.lbApellidos.Location = New System.Drawing.Point(287, 161)
        Me.lbApellidos.Name = "lbApellidos"
        Me.lbApellidos.Size = New System.Drawing.Size(49, 13)
        Me.lbApellidos.TabIndex = 15
        Me.lbApellidos.Text = "Apellidos"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(664, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'stripMenu
        '
        Me.stripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripNuevo, Me.ToolStripSeparator1, Me.stripAbrir, Me.stripEliminar, Me.ToolStripSeparator4, Me.stripGuardar, Me.ToolStripSeparator3, Me.SalirToolStripMenuItem})
        Me.stripMenu.Name = "stripMenu"
        Me.stripMenu.Size = New System.Drawing.Size(60, 20)
        Me.stripMenu.Text = "Archivo"
        '
        'stripNuevo
        '
        Me.stripNuevo.Name = "stripNuevo"
        Me.stripNuevo.Size = New System.Drawing.Size(151, 22)
        Me.stripNuevo.Text = "Nuevo usuario"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'stripAbrir
        '
        Me.stripAbrir.Name = "stripAbrir"
        Me.stripAbrir.Size = New System.Drawing.Size(151, 22)
        Me.stripAbrir.Text = "Abrir"
        '
        'stripEliminar
        '
        Me.stripEliminar.Name = "stripEliminar"
        Me.stripEliminar.Size = New System.Drawing.Size(151, 22)
        Me.stripEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(148, 6)
        '
        'stripGuardar
        '
        Me.stripGuardar.Name = "stripGuardar"
        Me.stripGuardar.Size = New System.Drawing.Size(151, 22)
        Me.stripGuardar.Text = "Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(148, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(395, 63)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(209, 20)
        Me.txtUsuario.TabIndex = 17
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(287, 66)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lbUsuario.TabIndex = 18
        Me.lbUsuario.Text = "Usuario:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(395, 129)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(212, 20)
        Me.txtNombre.TabIndex = 19
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(395, 161)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(212, 20)
        Me.txtApellidos.TabIndex = 20
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(395, 190)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(212, 20)
        Me.txtDireccion.TabIndex = 21
        '
        'lbDireccion
        '
        Me.lbDireccion.AutoSize = True
        Me.lbDireccion.Location = New System.Drawing.Point(287, 193)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lbDireccion.TabIndex = 22
        Me.lbDireccion.Text = "Dirección:"
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Location = New System.Drawing.Point(287, 266)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(67, 13)
        Me.lbTelefono.TabIndex = 23
        Me.lbTelefono.Text = "Nº Teléfono:"
        '
        'checkboxAdmin
        '
        Me.checkboxAdmin.AutoSize = True
        Me.checkboxAdmin.Location = New System.Drawing.Point(395, 299)
        Me.checkboxAdmin.Name = "checkboxAdmin"
        Me.checkboxAdmin.Size = New System.Drawing.Size(15, 14)
        Me.checkboxAdmin.TabIndex = 24
        Me.checkboxAdmin.UseVisualStyleBackColor = True
        '
        'lbAdmin
        '
        Me.lbAdmin.AutoSize = True
        Me.lbAdmin.Location = New System.Drawing.Point(287, 299)
        Me.lbAdmin.Name = "lbAdmin"
        Me.lbAdmin.Size = New System.Drawing.Size(36, 13)
        Me.lbAdmin.TabIndex = 25
        Me.lbAdmin.Text = "Admin"
        '
        'btnNotas
        '
        Me.btnNotas.Location = New System.Drawing.Point(12, 353)
        Me.btnNotas.Name = "btnNotas"
        Me.btnNotas.Size = New System.Drawing.Size(127, 34)
        Me.btnNotas.TabIndex = 28
        Me.btnNotas.Text = "Notas"
        Me.btnNotas.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Diseño_base.My.Resources.Resources.quill_311597_960_720
        Me.PictureBox1.Location = New System.Drawing.Point(149, 352)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'lbCaracPermitidos
        '
        Me.lbCaracPermitidos.AutoSize = True
        Me.lbCaracPermitidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCaracPermitidos.Location = New System.Drawing.Point(392, 213)
        Me.lbCaracPermitidos.Name = "lbCaracPermitidos"
        Me.lbCaracPermitidos.Size = New System.Drawing.Size(219, 16)
        Me.lbCaracPermitidos.TabIndex = 31
        Me.lbCaracPermitidos.Text = "Caracteres permitidos en dirección:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(400, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = ",'ªº\- espacios y números."
        '
        'GestionPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(664, 399)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbCaracPermitidos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNotas)
        Me.Controls.Add(Me.lbAdmin)
        Me.Controls.Add(Me.checkboxAdmin)
        Me.Controls.Add(Me.lbTelefono)
        Me.Controls.Add(Me.lbDireccion)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lbApellidos)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.listboxUsuarios)
        Me.Controls.Add(Me.lbUsuarios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GestionPerfiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbUsuarios As Label
    Friend WithEvents listboxUsuarios As ListBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents lbApellidos As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents stripMenu As ToolStripMenuItem
    Friend WithEvents stripNuevo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents stripAbrir As ToolStripMenuItem
    Friend WithEvents stripGuardar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lbDireccion As Label
    Friend WithEvents lbTelefono As Label
    Friend WithEvents checkboxAdmin As CheckBox
    Friend WithEvents lbAdmin As Label
    Friend WithEvents stripEliminar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnNotas As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbCaracPermitidos As Label
    Friend WithEvents Label1 As Label
End Class
