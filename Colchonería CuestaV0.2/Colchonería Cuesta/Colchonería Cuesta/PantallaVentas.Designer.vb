<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaVentas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaVentas))
        Me.comboCategoria = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lbCategoria = New System.Windows.Forms.Label()
        Me.comboProducto = New System.Windows.Forms.ComboBox()
        Me.lbProducto = New System.Windows.Forms.Label()
        Me.comboTamano = New System.Windows.Forms.ComboBox()
        Me.lbTamano = New System.Windows.Forms.Label()
        Me.listboxProductos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCobro = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnQuitarProd = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnGestionarPerfiles = New System.Windows.Forms.Button()
        Me.btnGestionarProductos = New System.Windows.Forms.Button()
        Me.lbAdmin = New System.Windows.Forms.Label()
        Me.btnAnadirprod = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'comboCategoria
        '
        Me.comboCategoria.FormattingEnabled = True
        Me.comboCategoria.Location = New System.Drawing.Point(21, 35)
        Me.comboCategoria.Name = "comboCategoria"
        Me.comboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.comboCategoria.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(12, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(439, 262)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "abort-146096_640.png")
        Me.ImageList1.Images.SetKeyName(1, "design-2381160_960_720.png")
        Me.ImageList1.Images.SetKeyName(2, "ltipo.png")
        '
        'lbCategoria
        '
        Me.lbCategoria.AutoSize = True
        Me.lbCategoria.Location = New System.Drawing.Point(21, 13)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.Size = New System.Drawing.Size(52, 13)
        Me.lbCategoria.TabIndex = 2
        Me.lbCategoria.Text = "Categoria"
        '
        'comboProducto
        '
        Me.comboProducto.FormattingEnabled = True
        Me.comboProducto.Location = New System.Drawing.Point(164, 35)
        Me.comboProducto.Name = "comboProducto"
        Me.comboProducto.Size = New System.Drawing.Size(121, 21)
        Me.comboProducto.TabIndex = 3
        '
        'lbProducto
        '
        Me.lbProducto.AutoSize = True
        Me.lbProducto.Location = New System.Drawing.Point(161, 9)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(50, 13)
        Me.lbProducto.TabIndex = 4
        Me.lbProducto.Text = "Producto"
        '
        'comboTamano
        '
        Me.comboTamano.FormattingEnabled = True
        Me.comboTamano.Location = New System.Drawing.Point(307, 35)
        Me.comboTamano.Name = "comboTamano"
        Me.comboTamano.Size = New System.Drawing.Size(121, 21)
        Me.comboTamano.TabIndex = 5
        '
        'lbTamano
        '
        Me.lbTamano.AutoSize = True
        Me.lbTamano.Location = New System.Drawing.Point(304, 9)
        Me.lbTamano.Name = "lbTamano"
        Me.lbTamano.Size = New System.Drawing.Size(46, 13)
        Me.lbTamano.TabIndex = 6
        Me.lbTamano.Text = "Tamaño"
        '
        'listboxProductos
        '
        Me.listboxProductos.FormattingEnabled = True
        Me.listboxProductos.Location = New System.Drawing.Point(491, 35)
        Me.listboxProductos.Name = "listboxProductos"
        Me.listboxProductos.Size = New System.Drawing.Size(170, 264)
        Me.listboxProductos.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(488, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Precio Total:"
        '
        'btnCobro
        '
        Me.btnCobro.Location = New System.Drawing.Point(491, 513)
        Me.btnCobro.Name = "btnCobro"
        Me.btnCobro.Size = New System.Drawing.Size(136, 61)
        Me.btnCobro.TabIndex = 10
        Me.btnCobro.Text = "Proceder a realizar pago"
        Me.btnCobro.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(407, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cuanto hemos vendido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(588, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tiempo/Hora:"
        '
        'btnQuitarProd
        '
        Me.btnQuitarProd.ImageIndex = 0
        Me.btnQuitarProd.ImageList = Me.ImageList1
        Me.btnQuitarProd.Location = New System.Drawing.Point(491, 434)
        Me.btnQuitarProd.Name = "btnQuitarProd"
        Me.btnQuitarProd.Size = New System.Drawing.Size(136, 62)
        Me.btnQuitarProd.TabIndex = 13
        Me.btnQuitarProd.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(21, 549)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(121, 37)
        Me.btnCerrarSesion.TabIndex = 14
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnGestionarPerfiles
        '
        Me.btnGestionarPerfiles.Location = New System.Drawing.Point(164, 549)
        Me.btnGestionarPerfiles.Name = "btnGestionarPerfiles"
        Me.btnGestionarPerfiles.Size = New System.Drawing.Size(121, 37)
        Me.btnGestionarPerfiles.TabIndex = 15
        Me.btnGestionarPerfiles.Text = "Gestionar Perfiles"
        Me.btnGestionarPerfiles.UseVisualStyleBackColor = True
        '
        'btnGestionarProductos
        '
        Me.btnGestionarProductos.Location = New System.Drawing.Point(307, 549)
        Me.btnGestionarProductos.Name = "btnGestionarProductos"
        Me.btnGestionarProductos.Size = New System.Drawing.Size(121, 37)
        Me.btnGestionarProductos.TabIndex = 16
        Me.btnGestionarProductos.Text = "Gestionar Productos"
        Me.btnGestionarProductos.UseVisualStyleBackColor = True
        '
        'lbAdmin
        '
        Me.lbAdmin.AutoSize = True
        Me.lbAdmin.Location = New System.Drawing.Point(664, 560)
        Me.lbAdmin.Name = "lbAdmin"
        Me.lbAdmin.Size = New System.Drawing.Size(0, 13)
        Me.lbAdmin.TabIndex = 17
        Me.lbAdmin.Visible = False
        '
        'btnAnadirprod
        '
        Me.btnAnadirprod.ImageKey = "design-2381160_960_720.png"
        Me.btnAnadirprod.ImageList = Me.ImageList1
        Me.btnAnadirprod.Location = New System.Drawing.Point(491, 349)
        Me.btnAnadirprod.Name = "btnAnadirprod"
        Me.btnAnadirprod.Size = New System.Drawing.Size(136, 70)
        Me.btnAnadirprod.TabIndex = 8
        Me.btnAnadirprod.UseVisualStyleBackColor = True
        '
        'PantallaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(708, 598)
        Me.Controls.Add(Me.lbAdmin)
        Me.Controls.Add(Me.btnGestionarProductos)
        Me.Controls.Add(Me.btnGestionarPerfiles)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnQuitarProd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCobro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAnadirprod)
        Me.Controls.Add(Me.listboxProductos)
        Me.Controls.Add(Me.lbTamano)
        Me.Controls.Add(Me.comboTamano)
        Me.Controls.Add(Me.lbProducto)
        Me.Controls.Add(Me.comboProducto)
        Me.Controls.Add(Me.lbCategoria)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.comboCategoria)
        Me.Name = "PantallaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboCategoria As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lbCategoria As Label
    Friend WithEvents comboProducto As ComboBox
    Friend WithEvents lbProducto As Label
    Friend WithEvents comboTamano As ComboBox
    Friend WithEvents lbTamano As Label
    Friend WithEvents listboxProductos As ListBox
    Friend WithEvents btnAnadirprod As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCobro As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnQuitarProd As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnGestionarPerfiles As Button
    Friend WithEvents btnGestionarProductos As Button
    Friend WithEvents lbAdmin As Label
End Class
