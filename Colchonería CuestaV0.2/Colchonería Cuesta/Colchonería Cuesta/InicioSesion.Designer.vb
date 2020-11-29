<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnIniciarSesión = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(269, 293)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lbUsuario.TabIndex = 1
        Me.lbUsuario.Text = "Usuario:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(269, 329)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 2
        Me.lbCodigo.Text = "Código:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(337, 290)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(337, 326)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 4
        '
        'btnIniciarSesión
        '
        Me.btnIniciarSesión.Location = New System.Drawing.Point(337, 371)
        Me.btnIniciarSesión.Name = "btnIniciarSesión"
        Me.btnIniciarSesión.Size = New System.Drawing.Size(112, 23)
        Me.btnIniciarSesión.TabIndex = 5
        Me.btnIniciarSesión.Text = "Iniciar sesión"
        Me.btnIniciarSesión.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(337, 400)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(112, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "abort-146096_640.png")
        Me.ImageList1.Images.SetKeyName(1, "design-2381160_960_720.png")
        Me.ImageList1.Images.SetKeyName(2, "ltipo.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Diseño_base.My.Resources.Resources.ltipo
        Me.PictureBox1.Location = New System.Drawing.Point(117, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(610, 272)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'InicioSesion
        '
        Me.AcceptButton = Me.btnIniciarSesión
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIniciarSesión)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.lbUsuario)
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InicioSesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnIniciarSesión As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
End Class
