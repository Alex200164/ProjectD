Imports System.IO


' Gestionar que no se repita la combinación nombre usuario y codigo.
' Gestionar, en información de usuario,a la hora de buscar, que tengan un ID, porque puede que no basten
' nombres y apellidos para diferenciar empleados.

' Permitir máximo 100 caracteres en el textbox multiline/descripción.


' lo de seleccionar nombre del listbox y que se muestre información en el textbox del usuario
' puede que sea un poco complejo
' otra opción es en el menuStrip dar la opción de cargar archivos y ya está.
' Cada usuario tendría su fichero y listo. Tampoco serían tantos, así que no es gran problema.
' Si sigo con la idea del listbox, pensar en un ID, porque no puedo buscar en el .txt de accesoDatos por nombre ya que
' podrían existir dos iguales.

Public Class GestionPerfiles


    Private Sub GestionPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Dim fichero As String = "datosAcceso.txt"
        '  Dim accesoDatos As New FileStream(fichero, FileMode.Open, FileAccess.Read)
        '  Dim sr As New StreamReader(accesoDatos)
        '   Dim bool As Boolean = False
        '  Dim nombre As String
        ' todo lo de arriba está comentado por obsoleto para esta pantalla, pero quizás sirva en otro momento.
        If listboxUsuarios.Items.Count <> 0 Then
        Else
            stripAbrir.Enabled = False
        End If
        stripAbrir.Enabled = True




    End Sub

    Private Sub listboxUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxUsuarios.SelectedIndexChanged
        Try
            ' Dejamos esto aquí, aunque resulte en la apertura repetida del archivo.
            ' No se sabe si el archivo puede ser borrado o modificado de alguna forma
            ' mientras se tiene abierta la aplicación. 
            ' Más vale comprobar siempre que se puede acceder al archivo.
            ' (la otra opción era poner esta apertura en form_load y dejarlo abierto
            ' hasta que se saliera de la pantalla de gestión de usuarios, pero se ha decidido
            ' hacerlo de esta otra forma porque es bastante más segura).
            FileOpen(1, "usuarios.txt", OpenMode.Input)

            While Not EOF(1)

                Input(1, usuario.usuario)
                If (usuario.usuario.Equals(listboxUsuarios.GetItemText(listboxUsuarios.SelectedItem))) Then

                    Input(1, usuario.contrasena)
                    Input(1, usuario.nombre)
                    Input(1, usuario.apellidos)
                    Input(1, usuario.direccion)
                    Input(1, usuario.telefono)
                    Input(1, usuario.admin)
                    txtUsuario.Text = usuario.usuario
                    txtContrasena.Text = usuario.contrasena
                    txtTelefono.Text = usuario.nombre
                    txtNombre.Text = usuario.apellidos
                    txtApellidos.Text = usuario.direccion
                    txtDireccion.Text = usuario.telefono
                    checkboxAdmin.Checked = True
                End If

            End While

            FileClose(1)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub lbUsuarios_Click(sender As Object, e As EventArgs) Handles lbUsuarios.Click

    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripNuevo.Click
        txtUsuario.Clear()
        txtContrasena.Clear()
        txtTelefono.Clear()
        txtNombre.Clear()
        txtApellidos.Clear()
        txtDireccion.Clear()


    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripAbrir.Click
        FileOpen(1, "usuarios.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, usuario.usuario)
            Input(1, usuario.contrasena)
            Input(1, usuario.nombre)
            Input(1, usuario.apellidos)
            Input(1, usuario.direccion)
            Input(1, usuario.telefono)
            Input(1, usuario.admin)
            listboxUsuarios.Items.Add(usuario.usuario)

            '   If (usuario.contrasena = 1111) Then
            ' MsgBox("Premio", 0, "Premio")
            '  End If


        End While
        FileClose(1)
        stripAbrir.Enabled = False
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripGuardar.Click
        FileOpen(1, "usuarios.txt", OpenMode.Append)
        Write(1, txtUsuario.Text, CInt(txtContrasena.Text), txtTelefono.Text, txtNombre.Text, txtApellidos.Text, CInt(txtDireccion.Text), checkboxAdmin.Checked.ToString)
        FileClose(1)
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class