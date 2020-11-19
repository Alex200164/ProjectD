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
        Me.btnLogoEmpresa = New System.Windows.Forms.Button()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnIniciarSesión = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogoEmpresa
        '
        Me.btnLogoEmpresa.Location = New System.Drawing.Point(236, 45)
        Me.btnLogoEmpresa.Name = "btnLogoEmpresa"
        Me.btnLogoEmpresa.Size = New System.Drawing.Size(310, 211)
        Me.btnLogoEmpresa.TabIndex = 0
        Me.btnLogoEmpresa.UseVisualStyleBackColor = True
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(269, 293)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(44, 13)
        Me.lbNombre.TabIndex = 1
        Me.lbNombre.Text = "Nombre"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(269, 329)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigo.TabIndex = 2
        Me.lbCodigo.Text = "Código"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(337, 290)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
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
        'InicioSesion
        '
        Me.AcceptButton = Me.btnIniciarSesión
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIniciarSesión)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.btnLogoEmpresa)
        Me.Name = "InicioSesion"
        Me.Text = "InicioSesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogoEmpresa As Button
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnIniciarSesión As Button
    Friend WithEvents btnSalir As Button
End Class
