<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobro
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
        Me.btn_finalizarImprimir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_importe = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn_ponerPunto = New System.Windows.Forms.Button()
        Me.Label_devolver = New System.Windows.Forms.Label()
        Me.Label_numDevolver = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_finalizarImprimir
        '
        Me.btn_finalizarImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizarImprimir.Location = New System.Drawing.Point(278, 332)
        Me.btn_finalizarImprimir.Name = "btn_finalizarImprimir"
        Me.btn_finalizarImprimir.Size = New System.Drawing.Size(310, 51)
        Me.btn_finalizarImprimir.TabIndex = 0
        Me.btn_finalizarImprimir.Text = "&Finalizar e imprimir recibo"
        Me.btn_finalizarImprimir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total a pagar ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Importe ="
        '
        'TextBox_importe
        '
        Me.TextBox_importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_importe.Location = New System.Drawing.Point(109, 93)
        Me.TextBox_importe.Name = "TextBox_importe"
        Me.TextBox_importe.Size = New System.Drawing.Size(100, 24)
        Me.TextBox_importe.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(64, 224)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(282, 187)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(72, 58)
        Me.btn1.TabIndex = 6
        Me.btn1.Text = "&1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(366, 187)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(72, 58)
        Me.btn3.TabIndex = 8
        Me.btn3.Text = "&3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(282, 123)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(72, 58)
        Me.btn4.TabIndex = 9
        Me.btn4.Text = "&4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(366, 123)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(72, 58)
        Me.btn5.TabIndex = 10
        Me.btn5.Text = "&5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(448, 123)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(72, 58)
        Me.btn6.TabIndex = 11
        Me.btn6.Text = "&6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(282, 59)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(72, 58)
        Me.btn7.TabIndex = 12
        Me.btn7.Text = "&7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(366, 59)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(72, 58)
        Me.btn8.TabIndex = 13
        Me.btn8.Text = "&8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(448, 59)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(72, 58)
        Me.btn9.TabIndex = 14
        Me.btn9.Text = "&9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrar.Location = New System.Drawing.Point(529, 59)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(59, 250)
        Me.btn_borrar.TabIndex = 15
        Me.btn_borrar.Text = "&Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(282, 251)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(156, 58)
        Me.btn0.TabIndex = 16
        Me.btn0.Text = "&0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(448, 187)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(72, 58)
        Me.btn2.TabIndex = 7
        Me.btn2.Text = "&2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn_ponerPunto
        '
        Me.btn_ponerPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ponerPunto.Location = New System.Drawing.Point(448, 251)
        Me.btn_ponerPunto.Name = "btn_ponerPunto"
        Me.btn_ponerPunto.Size = New System.Drawing.Size(72, 58)
        Me.btn_ponerPunto.TabIndex = 17
        Me.btn_ponerPunto.Text = "&."
        Me.btn_ponerPunto.UseVisualStyleBackColor = True
        '
        'Label_devolver
        '
        Me.Label_devolver.AutoSize = True
        Me.Label_devolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_devolver.Location = New System.Drawing.Point(12, 135)
        Me.Label_devolver.Name = "Label_devolver"
        Me.Label_devolver.Size = New System.Drawing.Size(116, 24)
        Me.Label_devolver.TabIndex = 18
        Me.Label_devolver.Text = "A devolver ="
        '
        'Label_numDevolver
        '
        Me.Label_numDevolver.AutoSize = True
        Me.Label_numDevolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_numDevolver.Location = New System.Drawing.Point(134, 135)
        Me.Label_numDevolver.Name = "Label_numDevolver"
        Me.Label_numDevolver.Size = New System.Drawing.Size(20, 24)
        Me.Label_numDevolver.TabIndex = 19
        Me.Label_numDevolver.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Cobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(609, 410)
        Me.Controls.Add(Me.Label_numDevolver)
        Me.Controls.Add(Me.Label_devolver)
        Me.Controls.Add(Me.btn_ponerPunto)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox_importe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_finalizarImprimir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cobro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pantalla de cobro"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_finalizarImprimir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_importe As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn_ponerPunto As Button
    Friend WithEvents Label_devolver As Label
    Friend WithEvents Label_numDevolver As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
