<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionPrecios
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
        Me.comboCategoria = New System.Windows.Forms.ComboBox()
        Me.comboProducto = New System.Windows.Forms.ComboBox()
        Me.comboTamano = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtTamano = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolverAVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNotas = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboCategoria
        '
        Me.comboCategoria.FormattingEnabled = True
        Me.comboCategoria.Location = New System.Drawing.Point(13, 26)
        Me.comboCategoria.Name = "comboCategoria"
        Me.comboCategoria.Size = New System.Drawing.Size(163, 21)
        Me.comboCategoria.TabIndex = 0
        '
        'comboProducto
        '
        Me.comboProducto.FormattingEnabled = True
        Me.comboProducto.Location = New System.Drawing.Point(223, 26)
        Me.comboProducto.Name = "comboProducto"
        Me.comboProducto.Size = New System.Drawing.Size(163, 21)
        Me.comboProducto.TabIndex = 1
        '
        'comboTamano
        '
        Me.comboTamano.FormattingEnabled = True
        Me.comboTamano.Location = New System.Drawing.Point(422, 26)
        Me.comboTamano.Name = "comboTamano"
        Me.comboTamano.Size = New System.Drawing.Size(163, 21)
        Me.comboTamano.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Categoría"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tamaño"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.comboCategoria)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.comboTamano)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.comboProducto)
        Me.Panel1.Location = New System.Drawing.Point(21, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 67)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnBorrar)
        Me.Panel2.Controls.Add(Me.btnRetirar)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnAñadir)
        Me.Panel2.Controls.Add(Me.txtPrecio)
        Me.Panel2.Controls.Add(Me.txtTamano)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.txtCategoria)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(21, 157)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(613, 246)
        Me.Panel2.TabIndex = 7
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(94, 187)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(128, 43)
        Me.btnBorrar.TabIndex = 15
        Me.btnBorrar.Text = "Borrar campos"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(342, 141)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(185, 53)
        Me.btnRetirar.TabIndex = 14
        Me.btnRetirar.Text = "Retirar producto"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(342, 82)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(185, 53)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar producto"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(342, 20)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(185, 53)
        Me.btnAñadir.TabIndex = 12
        Me.btnAñadir.Text = "Añadir producto"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(94, 139)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(126, 20)
        Me.txtPrecio.TabIndex = 11
        '
        'txtTamano
        '
        Me.txtTamano.Location = New System.Drawing.Point(94, 99)
        Me.txtTamano.Name = "txtTamano"
        Me.txtTamano.Size = New System.Drawing.Size(126, 20)
        Me.txtTamano.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(94, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(126, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(94, 20)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(126, 20)
        Me.txtCategoria.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Precio ="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tamaño ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nombre ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Categoría ="
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAVentasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(732, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VolverAVentasToolStripMenuItem
        '
        Me.VolverAVentasToolStripMenuItem.Name = "VolverAVentasToolStripMenuItem"
        Me.VolverAVentasToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.VolverAVentasToolStripMenuItem.Text = "Volver a ventas"
        '
        'btnNotas
        '
        Me.btnNotas.Location = New System.Drawing.Point(12, 454)
        Me.btnNotas.Name = "btnNotas"
        Me.btnNotas.Size = New System.Drawing.Size(124, 34)
        Me.btnNotas.TabIndex = 28
        Me.btnNotas.Text = "Notas"
        Me.btnNotas.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Diseño_base.My.Resources.Resources.quill_311597_960_720
        Me.PictureBox1.Location = New System.Drawing.Point(142, 453)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'GestionPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(732, 500)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNotas)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GestionPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboCategoria As ComboBox
    Friend WithEvents comboProducto As ComboBox
    Friend WithEvents comboTamano As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtTamano As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents btnRetirar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VolverAVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnNotas As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
