<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaInicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaInicio))
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbContrasena = New System.Windows.Forms.Label()
        Me.lbReloj = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lbAdmin = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        Me.HelpProvider2 = New System.Windows.Forms.HelpProvider()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(291, 272)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lbUsuario.TabIndex = 1
        Me.lbUsuario.Text = "Usuario:"
        '
        'lbContrasena
        '
        Me.lbContrasena.AutoSize = True
        Me.lbContrasena.Location = New System.Drawing.Point(277, 310)
        Me.lbContrasena.Name = "lbContrasena"
        Me.lbContrasena.Size = New System.Drawing.Size(64, 13)
        Me.lbContrasena.TabIndex = 2
        Me.lbContrasena.Text = "Contraseña:"
        '
        'lbReloj
        '
        Me.lbReloj.AutoSize = True
        Me.lbReloj.Location = New System.Drawing.Point(623, 403)
        Me.lbReloj.Name = "lbReloj"
        Me.lbReloj.Size = New System.Drawing.Size(31, 13)
        Me.lbReloj.TabIndex = 3
        Me.lbReloj.Text = "Reloj"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(358, 272)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(87, 20)
        Me.txtUsuario.TabIndex = 4
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(358, 307)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(64, 20)
        Me.txtContrasena.TabIndex = 5
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.Location = New System.Drawing.Point(358, 351)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(103, 42)
        Me.btnIniciarSesion.TabIndex = 6
        Me.btnIniciarSesion.Text = "&Iniciar sesión"
        Me.btnIniciarSesion.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(370, 399)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lbAdmin
        '
        Me.lbAdmin.AutoSize = True
        Me.lbAdmin.Location = New System.Drawing.Point(194, 170)
        Me.lbAdmin.Name = "lbAdmin"
        Me.lbAdmin.Size = New System.Drawing.Size(0, 13)
        Me.lbAdmin.TabIndex = 8
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\Tomás\Desktop\GitHubProyecto\ProyectoD\Colchonería CuestaV0.2\Colchonerí" &
    "a Cuesta\Colchonería Cuesta\Resources\ayuda.txt"
        '
        'picboxLogo
        '
        Me.picboxLogo.Image = CType(resources.GetObject("picboxLogo.Image"), System.Drawing.Image)
        Me.picboxLogo.Location = New System.Drawing.Point(98, 12)
        Me.picboxLogo.Name = "picboxLogo"
        Me.picboxLogo.Size = New System.Drawing.Size(647, 220)
        Me.picboxLogo.TabIndex = 0
        Me.picboxLogo.TabStop = False
        '
        'HelpProvider2
        '
        Me.HelpProvider2.HelpNamespace = "C:\Users\Tomás\Desktop\GitHubProyecto\ProyectoD\Colchonería CuestaV0.2\Colchonerí" &
    "a Cuesta\Colchonería Cuesta\Resources\ayuda.txt"
        '
        'PantallaInicio
        '
        Me.AcceptButton = Me.btnIniciarSesion
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbAdmin)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lbReloj)
        Me.Controls.Add(Me.lbContrasena)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.picboxLogo)
        Me.Name = "PantallaInicio"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picboxLogo As PictureBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbContrasena As Label
    Friend WithEvents lbReloj As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSalir As Button
    Friend WithEvents lbAdmin As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents HelpProvider2 As HelpProvider
End Class
