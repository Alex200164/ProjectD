<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComprobarAdmin
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
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbContrasena = New System.Windows.Forms.Label()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnAutenticar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(117, 36)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lbUsuario.TabIndex = 0
        Me.lbUsuario.Text = "Usuario:"
        '
        'lbContrasena
        '
        Me.lbContrasena.AutoSize = True
        Me.lbContrasena.Location = New System.Drawing.Point(54, 66)
        Me.lbContrasena.Name = "lbContrasena"
        Me.lbContrasena.Size = New System.Drawing.Size(102, 13)
        Me.lbContrasena.TabIndex = 1
        Me.lbContrasena.Text = "Código/Contraseña:"
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Location = New System.Drawing.Point(117, 9)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(211, 13)
        Me.lbTitulo.TabIndex = 2
        Me.lbTitulo.Text = "Introduzca nombre de usuario y contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(162, 33)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(162, 59)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 4
        '
        'btnAutenticar
        '
        Me.btnAutenticar.Location = New System.Drawing.Point(171, 85)
        Me.btnAutenticar.Name = "btnAutenticar"
        Me.btnAutenticar.Size = New System.Drawing.Size(75, 23)
        Me.btnAutenticar.TabIndex = 5
        Me.btnAutenticar.Text = "Autenticar"
        Me.btnAutenticar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(171, 114)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'ComprobarAdmin
        '
        Me.AcceptButton = Me.btnAutenticar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 139)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAutenticar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lbTitulo)
        Me.Controls.Add(Me.lbContrasena)
        Me.Controls.Add(Me.lbUsuario)
        Me.Name = "ComprobarAdmin"
        Me.Text = "ComprobarAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbContrasena As Label
    Friend WithEvents lbTitulo As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnAutenticar As Button
    Friend WithEvents btnVolver As Button
End Class
