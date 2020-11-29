<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaNotas
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
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbEspacioNotas = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(193, 99)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(378, 265)
        Me.txtNotas.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.ToolStripSeparator2, Me.AbrirToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(113, 6)
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(113, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lbEspacioNotas
        '
        Me.lbEspacioNotas.AutoSize = True
        Me.lbEspacioNotas.Location = New System.Drawing.Point(190, 83)
        Me.lbEspacioNotas.Name = "lbEspacioNotas"
        Me.lbEspacioNotas.Size = New System.Drawing.Size(101, 13)
        Me.lbEspacioNotas.TabIndex = 2
        Me.lbEspacioNotas.Text = "Espacio para notas:"
        '
        'PantallaNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbEspacioNotas)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PantallaNotas"
        Me.Text = "Notas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNotas As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbEspacioNotas As Label
End Class
