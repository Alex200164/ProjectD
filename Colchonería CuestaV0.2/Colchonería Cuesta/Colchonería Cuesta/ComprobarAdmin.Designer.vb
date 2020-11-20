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
        Me.lbNombreUsuario = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnAutenticar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbNombreUsuario
        '
        Me.lbNombreUsuario.AutoSize = True
        Me.lbNombreUsuario.Location = New System.Drawing.Point(117, 36)
        Me.lbNombreUsuario.Name = "lbNombreUsuario"
        Me.lbNombreUsuario.Size = New System.Drawing.Size(44, 13)
        Me.lbNombreUsuario.TabIndex = 0
        Me.lbNombreUsuario.Text = "Nombre"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(117, 64)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigo.TabIndex = 1
        Me.lbCodigo.Text = "Codigo"
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
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(162, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 139)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAutenticar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lbTitulo)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.lbNombreUsuario)
        Me.Name = "ComprobarAdmin"
        Me.Text = "ComprobarAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNombreUsuario As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents lbTitulo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnAutenticar As Button
    Friend WithEvents btnVolver As Button
End Class
