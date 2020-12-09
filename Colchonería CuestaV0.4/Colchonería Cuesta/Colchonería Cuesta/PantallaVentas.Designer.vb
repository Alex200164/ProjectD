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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripGestionProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripGestionPerfiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.stripAbrirCajaDiaria = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripGuardarCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.stripCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbCarrito = New System.Windows.Forms.Label()
        Me.lbPrecioTotalText = New System.Windows.Forms.Label()
        Me.btnNotas = New System.Windows.Forms.Button()
        Me.lbCajaDiariaText = New System.Windows.Forms.Label()
        Me.lbReloj = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnQuitarProd = New System.Windows.Forms.Button()
        Me.btnAnadirprod = New System.Windows.Forms.Button()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboCategoria
        '
        Me.comboCategoria.FormattingEnabled = True
        Me.comboCategoria.Location = New System.Drawing.Point(14, 137)
        Me.comboCategoria.Name = "comboCategoria"
        Me.comboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.comboCategoria.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(57, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(320, 172)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ltipo.png")
        Me.ImageList1.Images.SetKeyName(1, "iconfinder_user-alt_285645.png")
        Me.ImageList1.Images.SetKeyName(2, "iconfinder_key-lock-unlock-clef_2931164.png")
        Me.ImageList1.Images.SetKeyName(3, "iconfinder_Cash_register_103062.png")
        Me.ImageList1.Images.SetKeyName(4, "quill-311597_960_720.png")
        Me.ImageList1.Images.SetKeyName(5, "design-2381160_960_720.png")
        Me.ImageList1.Images.SetKeyName(6, "abort-146096_640.png")
        '
        'lbCategoria
        '
        Me.lbCategoria.AutoSize = True
        Me.lbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategoria.Location = New System.Drawing.Point(12, 110)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.Size = New System.Drawing.Size(90, 24)
        Me.lbCategoria.TabIndex = 2
        Me.lbCategoria.Text = "Categoria"
        '
        'comboNombreProd
        '
        Me.comboNombreProd.FormattingEnabled = True
        Me.comboNombreProd.Location = New System.Drawing.Point(141, 137)
        Me.comboNombreProd.Name = "comboNombreProd"
        Me.comboNombreProd.Size = New System.Drawing.Size(121, 21)
        Me.comboNombreProd.TabIndex = 3
        '
        'lbProducto
        '
        Me.lbProducto.AutoSize = True
        Me.lbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProducto.Location = New System.Drawing.Point(137, 110)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(86, 24)
        Me.lbProducto.TabIndex = 4
        Me.lbProducto.Text = "Producto"
        '
        'comboTamano
        '
        Me.comboTamano.FormattingEnabled = True
        Me.comboTamano.Location = New System.Drawing.Point(272, 137)
        Me.comboTamano.Name = "comboTamano"
        Me.comboTamano.Size = New System.Drawing.Size(121, 21)
        Me.comboTamano.TabIndex = 5
        '
        'lbTamano
        '
        Me.lbTamano.AutoSize = True
        Me.lbTamano.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTamano.Location = New System.Drawing.Point(268, 110)
        Me.lbTamano.Name = "lbTamano"
        Me.lbTamano.Size = New System.Drawing.Size(80, 24)
        Me.lbTamano.TabIndex = 6
        Me.lbTamano.Text = "Tamaño"
        '
        'listboxCarrito
        '
        Me.listboxCarrito.FormattingEnabled = True
        Me.listboxCarrito.Location = New System.Drawing.Point(432, 212)
        Me.listboxCarrito.Name = "listboxCarrito"
        Me.listboxCarrito.Size = New System.Drawing.Size(293, 95)
        Me.listboxCarrito.TabIndex = 7
        '
        'lbPrecioTotal
        '
        Me.lbPrecioTotal.AutoSize = True
        Me.lbPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrecioTotal.Location = New System.Drawing.Point(537, 310)
        Me.lbPrecioTotal.Name = "lbPrecioTotal"
        Me.lbPrecioTotal.Size = New System.Drawing.Size(133, 25)
        Me.lbPrecioTotal.TabIndex = 9
        Me.lbPrecioTotal.Text = "Precio Total:"
        '
        'btnCobro
        '
        Me.btnCobro.Location = New System.Drawing.Point(542, 363)
        Me.btnCobro.Name = "btnCobro"
        Me.btnCobro.Size = New System.Drawing.Size(155, 50)
        Me.btnCobro.TabIndex = 10
        Me.btnCobro.Text = "Proceder a realizar pago"
        Me.btnCobro.UseVisualStyleBackColor = True
        '
        'lbCajaDiaria
        '
        Me.lbCajaDiaria.AutoSize = True
        Me.lbCajaDiaria.Location = New System.Drawing.Point(300, 466)
        Me.lbCajaDiaria.Name = "lbCajaDiaria"
        Me.lbCajaDiaria.Size = New System.Drawing.Size(119, 13)
        Me.lbCajaDiaria.TabIndex = 11
        Me.lbCajaDiaria.Text = "Cuanto hemos vendido:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(739, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripGestionProductos, Me.stripGestionPerfiles, Me.ToolStripSeparator1, Me.stripAbrirCajaDiaria, Me.stripGuardarCaja, Me.ToolStripSeparator2, Me.stripCerrarSesion})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ArchivoToolStripMenuItem.Text = "Menú"
        '
        'stripGestionProductos
        '
        Me.stripGestionProductos.Image = CType(resources.GetObject("stripGestionProductos.Image"), System.Drawing.Image)
        Me.stripGestionProductos.Name = "stripGestionProductos"
        Me.stripGestionProductos.Size = New System.Drawing.Size(181, 22)
        Me.stripGestionProductos.Text = "Gestionar productos"
        '
        'stripGestionPerfiles
        '
        Me.stripGestionPerfiles.Image = CType(resources.GetObject("stripGestionPerfiles.Image"), System.Drawing.Image)
        Me.stripGestionPerfiles.Name = "stripGestionPerfiles"
        Me.stripGestionPerfiles.Size = New System.Drawing.Size(181, 22)
        Me.stripGestionPerfiles.Text = "Gestionar perfiles"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'stripAbrirCajaDiaria
        '
        Me.stripAbrirCajaDiaria.Image = CType(resources.GetObject("stripAbrirCajaDiaria.Image"), System.Drawing.Image)
        Me.stripAbrirCajaDiaria.Name = "stripAbrirCajaDiaria"
        Me.stripAbrirCajaDiaria.Size = New System.Drawing.Size(181, 22)
        Me.stripAbrirCajaDiaria.Text = "Abrir caja diaria"
        '
        'stripGuardarCaja
        '
        Me.stripGuardarCaja.Image = CType(resources.GetObject("stripGuardarCaja.Image"), System.Drawing.Image)
        Me.stripGuardarCaja.Name = "stripGuardarCaja"
        Me.stripGuardarCaja.Size = New System.Drawing.Size(181, 22)
        Me.stripGuardarCaja.Text = "Guardar caja diaria"
        Me.stripGuardarCaja.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'stripCerrarSesion
        '
        Me.stripCerrarSesion.Image = CType(resources.GetObject("stripCerrarSesion.Image"), System.Drawing.Image)
        Me.stripCerrarSesion.Name = "stripCerrarSesion"
        Me.stripCerrarSesion.Size = New System.Drawing.Size(181, 22)
        Me.stripCerrarSesion.Text = "Cerrar sesión"
        '
        'lbCarrito
        '
        Me.lbCarrito.AutoSize = True
        Me.lbCarrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCarrito.Location = New System.Drawing.Point(428, 185)
        Me.lbCarrito.Name = "lbCarrito"
        Me.lbCarrito.Size = New System.Drawing.Size(69, 24)
        Me.lbCarrito.TabIndex = 22
        Me.lbCarrito.Text = "Carrito:"
        '
        'lbPrecioTotalText
        '
        Me.lbPrecioTotalText.AutoSize = True
        Me.lbPrecioTotalText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrecioTotalText.Location = New System.Drawing.Point(676, 310)
        Me.lbPrecioTotalText.Name = "lbPrecioTotalText"
        Me.lbPrecioTotalText.Size = New System.Drawing.Size(33, 25)
        Me.lbPrecioTotalText.TabIndex = 26
        Me.lbPrecioTotalText.Text = "---"
        Me.lbPrecioTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNotas
        '
        Me.btnNotas.Location = New System.Drawing.Point(45, 455)
        Me.btnNotas.Name = "btnNotas"
        Me.btnNotas.Size = New System.Drawing.Size(128, 34)
        Me.btnNotas.TabIndex = 27
        Me.btnNotas.Text = "Notas"
        Me.btnNotas.UseVisualStyleBackColor = True
        '
        'lbCajaDiariaText
        '
        Me.lbCajaDiariaText.AutoSize = True
        Me.lbCajaDiariaText.Location = New System.Drawing.Point(416, 466)
        Me.lbCajaDiariaText.Name = "lbCajaDiariaText"
        Me.lbCajaDiariaText.Size = New System.Drawing.Size(66, 13)
        Me.lbCajaDiariaText.TabIndex = 31
        Me.lbCajaDiariaText.Text = "Sin caja aún"
        '
        'lbReloj
        '
        Me.lbReloj.AutoSize = True
        Me.lbReloj.Location = New System.Drawing.Point(568, 466)
        Me.lbReloj.Name = "lbReloj"
        Me.lbReloj.Size = New System.Drawing.Size(31, 13)
        Me.lbReloj.TabIndex = 32
        Me.lbReloj.Text = "Reloj"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(179, 455)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'btnQuitarProd
        '
        Me.btnQuitarProd.ImageKey = "abort-146096_640.png"
        Me.btnQuitarProd.ImageList = Me.ImageList1
        Me.btnQuitarProd.Location = New System.Drawing.Point(625, 126)
        Me.btnQuitarProd.Name = "btnQuitarProd"
        Me.btnQuitarProd.Size = New System.Drawing.Size(72, 56)
        Me.btnQuitarProd.TabIndex = 13
        Me.btnQuitarProd.UseVisualStyleBackColor = True
        '
        'btnAnadirprod
        '
        Me.btnAnadirprod.BackgroundImage = CType(resources.GetObject("btnAnadirprod.BackgroundImage"), System.Drawing.Image)
        Me.btnAnadirprod.ImageKey = "design-2381160_960_720.png"
        Me.btnAnadirprod.ImageList = Me.ImageList1
        Me.btnAnadirprod.Location = New System.Drawing.Point(517, 126)
        Me.btnAnadirprod.Name = "btnAnadirprod"
        Me.btnAnadirprod.Size = New System.Drawing.Size(69, 56)
        Me.btnAnadirprod.TabIndex = 8
        Me.btnAnadirprod.UseVisualStyleBackColor = True
        '
        'picboxLogo
        '
        Me.picboxLogo.Image = CType(resources.GetObject("picboxLogo.Image"), System.Drawing.Image)
        Me.picboxLogo.Location = New System.Drawing.Point(233, 27)
        Me.picboxLogo.Name = "picboxLogo"
        Me.picboxLogo.Size = New System.Drawing.Size(278, 83)
        Me.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxLogo.TabIndex = 33
        Me.picboxLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(402, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 24)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Precio "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(402, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "0"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\Tomás\Desktop\GitHubProyecto\ProyectoD\Colchonería CuestaV0.2\Colchonerí" &
    "a Cuesta\Colchonería Cuesta\Resources\ayuda.txt"
        '
        'PantallaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(739, 496)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picboxLogo)
        Me.Controls.Add(Me.lbReloj)
        Me.Controls.Add(Me.lbCajaDiariaText)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNotas)
        Me.Controls.Add(Me.lbPrecioTotalText)
        Me.Controls.Add(Me.lbCarrito)
        Me.Controls.Add(Me.btnQuitarProd)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PantallaVentas"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de ventas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnQuitarProd As Button
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
    Friend WithEvents lbReloj As Label
    Friend WithEvents stripAbrirCajaDiaria As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picboxLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
