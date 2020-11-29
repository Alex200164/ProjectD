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
        Me.comboNombreProd = New System.Windows.Forms.ComboBox()
        Me.lbProducto = New System.Windows.Forms.Label()
        Me.comboTamano = New System.Windows.Forms.ComboBox()
        Me.lbTamano = New System.Windows.Forms.Label()
        Me.listboxCarrito = New System.Windows.Forms.ListBox()
        Me.lbPrecioTotal = New System.Windows.Forms.Label()
        Me.btnCobro = New System.Windows.Forms.Button()
        Me.lbCajaDiaria = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbAdmin = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripGestionProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripGestionPerfiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.stripCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbCarrito = New System.Windows.Forms.Label()
        Me.lbPrecioTotalText = New System.Windows.Forms.Label()
        Me.btnNotas = New System.Windows.Forms.Button()
        Me.btnQuitarProd = New System.Windows.Forms.Button()
        Me.btnAnadirprod = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.stripGuardarCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lbCajaDiariaText = New System.Windows.Forms.Label()
        Me.lbTiempoText = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboCategoria
        '
        Me.comboCategoria.FormattingEnabled = True
        Me.comboCategoria.Location = New System.Drawing.Point(12, 56)
        Me.comboCategoria.Name = "comboCategoria"
        Me.comboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.comboCategoria.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(139, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(384, 223)
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
        Me.lbCategoria.Location = New System.Drawing.Point(9, 34)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.Size = New System.Drawing.Size(52, 13)
        Me.lbCategoria.TabIndex = 2
        Me.lbCategoria.Text = "Categoria"
        '
        'comboNombreProd
        '
        Me.comboNombreProd.FormattingEnabled = True
        Me.comboNombreProd.Location = New System.Drawing.Point(139, 56)
        Me.comboNombreProd.Name = "comboNombreProd"
        Me.comboNombreProd.Size = New System.Drawing.Size(121, 21)
        Me.comboNombreProd.TabIndex = 3
        '
        'lbProducto
        '
        Me.lbProducto.AutoSize = True
        Me.lbProducto.Location = New System.Drawing.Point(136, 34)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(50, 13)
        Me.lbProducto.TabIndex = 4
        Me.lbProducto.Text = "Producto"
        '
        'comboTamano
        '
        Me.comboTamano.FormattingEnabled = True
        Me.comboTamano.Location = New System.Drawing.Point(266, 56)
        Me.comboTamano.Name = "comboTamano"
        Me.comboTamano.Size = New System.Drawing.Size(121, 21)
        Me.comboTamano.TabIndex = 5
        '
        'lbTamano
        '
        Me.lbTamano.AutoSize = True
        Me.lbTamano.Location = New System.Drawing.Point(263, 34)
        Me.lbTamano.Name = "lbTamano"
        Me.lbTamano.Size = New System.Drawing.Size(46, 13)
        Me.lbTamano.TabIndex = 6
        Me.lbTamano.Text = "Tamaño"
        '
        'listboxCarrito
        '
        Me.listboxCarrito.FormattingEnabled = True
        Me.listboxCarrito.Location = New System.Drawing.Point(401, 56)
        Me.listboxCarrito.Name = "listboxCarrito"
        Me.listboxCarrito.Size = New System.Drawing.Size(286, 121)
        Me.listboxCarrito.TabIndex = 7
        '
        'lbPrecioTotal
        '
        Me.lbPrecioTotal.AutoSize = True
        Me.lbPrecioTotal.Location = New System.Drawing.Point(546, 180)
        Me.lbPrecioTotal.Name = "lbPrecioTotal"
        Me.lbPrecioTotal.Size = New System.Drawing.Size(67, 13)
        Me.lbPrecioTotal.TabIndex = 9
        Me.lbPrecioTotal.Text = "Precio Total:"
        '
        'btnCobro
        '
        Me.btnCobro.Location = New System.Drawing.Point(529, 392)
        Me.btnCobro.Name = "btnCobro"
        Me.btnCobro.Size = New System.Drawing.Size(136, 44)
        Me.btnCobro.TabIndex = 10
        Me.btnCobro.Text = "Proceder a realizar pago"
        Me.btnCobro.UseVisualStyleBackColor = True
        '
        'lbCajaDiaria
        '
        Me.lbCajaDiaria.AutoSize = True
        Me.lbCajaDiaria.Location = New System.Drawing.Point(263, 529)
        Me.lbCajaDiaria.Name = "lbCajaDiaria"
        Me.lbCajaDiaria.Size = New System.Drawing.Size(119, 13)
        Me.lbCajaDiaria.TabIndex = 11
        Me.lbCajaDiaria.Text = "Cuanto hemos vendido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(546, 529)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tiempo/Hora:"
        '
        'lbAdmin
        '
        Me.lbAdmin.AutoSize = True
        Me.lbAdmin.Location = New System.Drawing.Point(211, 550)
        Me.lbAdmin.Name = "lbAdmin"
        Me.lbAdmin.Size = New System.Drawing.Size(0, 13)
        Me.lbAdmin.TabIndex = 17
        Me.lbAdmin.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(708, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripGestionProductos, Me.stripGestionPerfiles, Me.ToolStripSeparator1, Me.stripGuardarCaja, Me.ToolStripSeparator2, Me.stripCerrarSesion})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ArchivoToolStripMenuItem.Text = "Menú"
        '
        'stripGestionProductos
        '
        Me.stripGestionProductos.Name = "stripGestionProductos"
        Me.stripGestionProductos.Size = New System.Drawing.Size(181, 22)
        Me.stripGestionProductos.Text = "Gestionar productos"
        '
        'stripGestionPerfiles
        '
        Me.stripGestionPerfiles.Name = "stripGestionPerfiles"
        Me.stripGestionPerfiles.Size = New System.Drawing.Size(181, 22)
        Me.stripGestionPerfiles.Text = "Gestionar perfiles"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'stripCerrarSesion
        '
        Me.stripCerrarSesion.Name = "stripCerrarSesion"
        Me.stripCerrarSesion.Size = New System.Drawing.Size(181, 22)
        Me.stripCerrarSesion.Text = "Cerrar sesión"
        '
        'lbCarrito
        '
        Me.lbCarrito.AutoSize = True
        Me.lbCarrito.Location = New System.Drawing.Point(407, 40)
        Me.lbCarrito.Name = "lbCarrito"
        Me.lbCarrito.Size = New System.Drawing.Size(40, 13)
        Me.lbCarrito.TabIndex = 22
        Me.lbCarrito.Text = "Carrito:"
        '
        'lbPrecioTotalText
        '
        Me.lbPrecioTotalText.AutoSize = True
        Me.lbPrecioTotalText.Location = New System.Drawing.Point(640, 194)
        Me.lbPrecioTotalText.Name = "lbPrecioTotalText"
        Me.lbPrecioTotalText.Size = New System.Drawing.Size(0, 13)
        Me.lbPrecioTotalText.TabIndex = 26
        Me.lbPrecioTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNotas
        '
        Me.btnNotas.Location = New System.Drawing.Point(266, 491)
        Me.btnNotas.Name = "btnNotas"
        Me.btnNotas.Size = New System.Drawing.Size(181, 34)
        Me.btnNotas.TabIndex = 27
        Me.btnNotas.Text = "Notas"
        Me.btnNotas.UseVisualStyleBackColor = True
        '
        'btnQuitarProd
        '
        Me.btnQuitarProd.ImageIndex = 0
        Me.btnQuitarProd.ImageList = Me.ImageList1
        Me.btnQuitarProd.Location = New System.Drawing.Point(529, 302)
        Me.btnQuitarProd.Name = "btnQuitarProd"
        Me.btnQuitarProd.Size = New System.Drawing.Size(136, 62)
        Me.btnQuitarProd.TabIndex = 13
        Me.btnQuitarProd.UseVisualStyleBackColor = True
        '
        'btnAnadirprod
        '
        Me.btnAnadirprod.ImageKey = "design-2381160_960_720.png"
        Me.btnAnadirprod.ImageList = Me.ImageList1
        Me.btnAnadirprod.Location = New System.Drawing.Point(529, 213)
        Me.btnAnadirprod.Name = "btnAnadirprod"
        Me.btnAnadirprod.Size = New System.Drawing.Size(136, 70)
        Me.btnAnadirprod.TabIndex = 8
        Me.btnAnadirprod.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Diseño_base.My.Resources.Resources.quill_311597_960_720
        Me.PictureBox1.Location = New System.Drawing.Point(453, 490)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'stripGuardarCaja
        '
        Me.stripGuardarCaja.Name = "stripGuardarCaja"
        Me.stripGuardarCaja.Size = New System.Drawing.Size(181, 22)
        Me.stripGuardarCaja.Text = "Guardar caja diaria"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'lbCajaDiariaText
        '
        Me.lbCajaDiariaText.AutoSize = True
        Me.lbCajaDiariaText.Location = New System.Drawing.Point(381, 529)
        Me.lbCajaDiariaText.Name = "lbCajaDiariaText"
        Me.lbCajaDiariaText.Size = New System.Drawing.Size(66, 13)
        Me.lbCajaDiariaText.TabIndex = 31
        Me.lbCajaDiariaText.Text = "Sin caja aún"
        '
        'lbTiempoText
        '
        Me.lbTiempoText.AutoSize = True
        Me.lbTiempoText.Location = New System.Drawing.Point(625, 529)
        Me.lbTiempoText.Name = "lbTiempoText"
        Me.lbTiempoText.Size = New System.Drawing.Size(0, 13)
        Me.lbTiempoText.TabIndex = 32
        '
        'PantallaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(708, 598)
        Me.Controls.Add(Me.lbTiempoText)
        Me.Controls.Add(Me.lbCajaDiariaText)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNotas)
        Me.Controls.Add(Me.lbPrecioTotalText)
        Me.Controls.Add(Me.lbCarrito)
        Me.Controls.Add(Me.lbAdmin)
        Me.Controls.Add(Me.btnQuitarProd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbCajaDiaria)
        Me.Controls.Add(Me.btnCobro)
        Me.Controls.Add(Me.lbPrecioTotal)
        Me.Controls.Add(Me.btnAnadirprod)
        Me.Controls.Add(Me.listboxCarrito)
        Me.Controls.Add(Me.lbTamano)
        Me.Controls.Add(Me.comboTamano)
        Me.Controls.Add(Me.lbProducto)
        Me.Controls.Add(Me.comboNombreProd)
        Me.Controls.Add(Me.lbCategoria)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.comboCategoria)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "PantallaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboCategoria As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lbCategoria As Label
    Friend WithEvents comboNombreProd As ComboBox
    Friend WithEvents lbProducto As Label
    Friend WithEvents comboTamano As ComboBox
    Friend WithEvents lbTamano As Label
    Friend WithEvents listboxCarrito As ListBox
    Friend WithEvents btnAnadirprod As Button
    Friend WithEvents lbPrecioTotal As Label
    Friend WithEvents btnCobro As Button
    Friend WithEvents lbCajaDiaria As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnQuitarProd As Button
    Friend WithEvents lbAdmin As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents stripGestionProductos As ToolStripMenuItem
    Friend WithEvents stripGestionPerfiles As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents stripCerrarSesion As ToolStripMenuItem
    Friend WithEvents lbCarrito As Label
    Friend WithEvents lbPrecioTotalText As Label
    Friend WithEvents btnNotas As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents stripGuardarCaja As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents lbCajaDiariaText As Label
    Friend WithEvents lbTiempoText As Label
End Class
