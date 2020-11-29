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


    ' Load
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


    ' Listbox
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

            ' Rellenamos el ListBox.
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
                    txtNombre.Text = usuario.nombre
                    txtApellidos.Text = usuario.apellidos
                    txtDireccion.Text = usuario.direccion
                    txtTelefono.Text = usuario.telefono
                    If (usuario.admin = True) Then
                        checkboxAdmin.Checked = True
                    Else
                        checkboxAdmin.Checked = False
                    End If
                End If

            End While

            FileClose(1)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub lbUsuarios_Click(sender As Object, e As EventArgs) Handles lbUsuarios.Click

    End Sub


    ' Nuevo
    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripNuevo.Click
        txtUsuario.Clear()
        txtContrasena.Clear()
        txtTelefono.Clear()
        txtNombre.Clear()
        txtApellidos.Clear()
        txtDireccion.Clear()


    End Sub


    ' Abrir
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
        End While

        FileClose(1)

        stripAbrir.Enabled = False
    End Sub

    'Guardar
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripGuardar.Click
        FileOpen(1, "usuarios.txt", OpenMode.Input)

        ' Variables usadas para comprobar si existe o no el usuario antes de guardar.
        ' en coincidencia guardamos el resultado de la lectura del archivo secuencial
        Dim coincidencia As String = ""
        ' El booleano "libre" lo usamos para cambiarlo a false (no está libre el nombre de usuario) si no se puede
        ' grabar el usuario que se acaba de introducir.
        Dim libre As Boolean = True

        'Comprobamos si ya existe el usuario.
        While Not EOF(1)
            Input(1, coincidencia)
            '  MsgBox("Coincidencia: " & coincidencia & " lo otro: " & listboxUsuarios.GetItemText(listboxUsuarios.SelectedItem))
            If listboxUsuarios.GetItemText(listboxUsuarios.SelectedItem).Equals(coincidencia) Then
                MsgBox("Ya existe ese usuario. Por favor bórrelo y cree uno nuevo si quiere cambiar datos.")
                FileClose(1)
                libre = False
                Exit While
            End If
        End While

        ' Si en el while loop no se cambió el booleano a false, significa que no hay un usuario con el mismo nomre
        ' y se puede grabar.
        If (libre = True) Then
            FileClose(1)

            FileOpen(1, "usuarios.txt", OpenMode.Append)

            Write(1, txtUsuario.Text, CInt(txtContrasena.Text), txtNombre.Text, txtApellidos.Text, txtDireccion.Text, CInt(txtTelefono.Text), checkboxAdmin.Checked.ToString)
            FileClose(1)

        End If

        ' Limpiamos el listbox y volvemos a rellenarlo, actualizando la lista de usuarios.
        listboxUsuarios.Items.Clear()
        AbrirToolStripMenuItem_Click(sender, e)
    End Sub


    ' Eliminar
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripEliminar.Click
        FileOpen(1, "usuarios.txt", OpenMode.Input)

        Dim coincidencia As String = ""
        Dim datos As New ArrayList

        While Not EOF(1)
            Input(1, coincidencia)
            ' Una vez encontraodo el usuario, empezamos a iterar desde el principio, por eso cerramos
            ' y volvemos a abrir el archivo.
            If listboxUsuarios.GetItemText(listboxUsuarios.SelectedItem).Equals(coincidencia) Then
                ' Nos saltamos el añadir estos datos al nuevo fichero     
                MsgBox(" Esto no se graba: " & coincidencia)
                Input(1, usuario.contrasena)
                Input(1, usuario.nombre)
                Input(1, usuario.apellidos)
                Input(1, usuario.direccion)
                Input(1, usuario.telefono)
                Input(1, usuario.admin)
            Else
                MsgBox("Guardando")
                MsgBox("Esto es graba " & coincidencia)
                Input(1, usuario.contrasena)
                Input(1, usuario.nombre)
                Input(1, usuario.apellidos)
                Input(1, usuario.direccion)
                Input(1, usuario.telefono)
                Input(1, usuario.admin)

                ' Añadimos los datos al array
                datos.Add(coincidencia)
                MsgBox("El primer dato: " & datos.Item(0))
                datos.Add(usuario.contrasena)
                datos.Add(usuario.nombre)
                datos.Add(usuario.apellidos)
                datos.Add(usuario.direccion)
                datos.Add(usuario.telefono)
                datos.Add(usuario.admin)
            End If


        End While
        FileClose(1)

        ' Pasamos a sobreescribir el archivo con los datos menos el que se quería borrar.
        FileOpen(1, "usuarios.txt", OpenMode.Output)
        '  MsgBox(datos(2))
        For i = 0 To datos.Count - 1
            MsgBox("Pasamos a ver los datos del arraylist")
            MsgBox(datos.Item(i))
            Write(1, datos.Item(i))
        Next i
        FileClose(1)

        ' Limpiamos el listbox y volvemos a rellenarlo, actualizando la lista de usuarios.
        listboxUsuarios.Items.Clear()
        AbrirToolStripMenuItem_Click(sender, e)
    End Sub
End Class