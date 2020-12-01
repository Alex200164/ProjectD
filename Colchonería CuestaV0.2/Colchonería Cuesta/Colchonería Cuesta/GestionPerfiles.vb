Imports System.IO


Public Class GestionPerfiles


    ' Load
    Private Sub GestionPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Dim fichero As String = "datosAcceso.txt"
        '  Dim accesoDatos As New FileStream(fichero, FileMode.Open, FileAccess.Read)
        '  Dim sr As New StreamReader(accesoDatos)
        '   Dim bool As Boolean = False
        '  Dim nombre As String
        ' todo lo de arriba está comentado por obsoleto para esta pantalla, pero quizás sirva en otro momento.
        stripEliminar.Enabled = False

        If listboxUsuarios.Items.Count <> 0 Then
        Else
            stripAbrir.Enabled = False

        End If
        stripAbrir.Enabled = True

        stripGuardar.Enabled = False
        stripEliminar.Enabled = False

    End Sub


    ' Listbox
    Private Sub listboxUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxUsuarios.SelectedIndexChanged
        ' Solo si se tiene un campo seleccionado se habilita el botón eliminar.
        stripEliminar.Enabled = True
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
            MsgBox("Error al intentar abrir la lista de perfiles.", MsgBoxStyle.OkOnly, "Aviso")
        End Try

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
        Dim validacion As New libValidacionDatos.Validacion

        Try
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
            ' Si los campos no están vacíos, se habilita el botón guardar.
            If (txtUsuario.Text.Equals("") And txtContrasena.Text.Equals("") And txtNombre.Text.Equals("") And txtApellidos.Text.Equals("") And txtDireccion.Text.Equals("")) Then
                FileClose(1)
                stripGuardar.Enabled = True
            End If

        Catch ex As Exception
            FileClose(1)
            validacion.mensajeErrorDatos()
            validacion.errorLogWrite()
        End Try

    End Sub

    'Guardar
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripGuardar.Click
        Dim validacion As New libValidacionDatos.Validacion
        Try
            FileOpen(1, "usuarios.txt", OpenMode.Input)
            ' Variables usadas para comprobar si existe o no el usuario antes de guardar.
            ' en coincidencia guardamos el resultado de la lectura del archivo secuencial
            Dim coincidencia As String = ""
            ' El booleano "libre" lo usamos para cambiarlo a false (no está libre el nombre de usuario) si no se puede
            ' grabar el usuario que se acaba de introducir.
            Dim libre As Boolean = True

            'Comprobamos si ya existe el usuario.
            If Not txtUsuario.Text.Equals("") Then
                While Not EOF(1)
                    Input(1, coincidencia)
                    ' MsgBox("Coincidencia: " & coincidencia & " lo otro: " & listboxUsuarios.GetItemText(listboxUsuarios.SelectedItem))
                    If listboxUsuarios.GetItemText(listboxUsuarios.SelectedItem).Equals(coincidencia) And txtUsuario.Text.Equals(coincidencia) Then
                        MsgBox("El usuario ya existe. Por favor, bórrelo y cree uno nuevo si desea hacer cambios.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Aviso")
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
            End If
        Catch ex As Exception
            validacion.errorLogWrite()
            validacion.mensajeErrorDatos()
        End Try

    End Sub


    ' Eliminar
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripEliminar.Click
        FileOpen(1, "usuarios.txt", OpenMode.Input)
        Dim a As Integer = 0 ' usado para recibir el resultado de msgbox que pregunta si estamos seguros de querer borrar un usuario.
        Dim coincidencia As String = ""
        Dim datos As New ArrayList

        If listboxUsuarios.GetItemText(listboxUsuarios.SelectedItem).Equals("admin") Then
            MsgBox("No se puede borrar el administrador", MsgBoxStyle.Information, "Aviso")
        Else


            a = MsgBox("¿Seguro que desea eliminar el usuario?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Aviso")
            If a = 6 Then


                While Not EOF(1)
                    Input(1, coincidencia)
                    ' Una vez encontraodo el usuario, empezamos a iterar desde el principio, por eso cerramos
                    ' y volvemos a abrir el archivo.
                    If listboxUsuarios.GetItemText(listboxUsuarios.SelectedItem).Equals(coincidencia) Then
                        ' Nos saltamos el añadir estos datos al nuevo fichero     

                        Input(1, usuario.contrasena)
                        Input(1, usuario.nombre)
                        Input(1, usuario.apellidos)
                        Input(1, usuario.direccion)
                        Input(1, usuario.telefono)
                        Input(1, usuario.admin)
                    Else
                        '  MsgBox("Guardando la nueva lista de usuarios.")
                        Input(1, usuario.contrasena)
                        Input(1, usuario.nombre)
                        Input(1, usuario.apellidos)
                        Input(1, usuario.direccion)
                        Input(1, usuario.telefono)
                        Input(1, usuario.admin)

                        ' Añadimos los datos al array
                        datos.Add(coincidencia)
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

                For i = 0 To datos.Count - 1

                    Write(1, datos.Item(i))
                Next i
                FileClose(1)

                ' Limpiamos el listbox y volvemos a rellenarlo, actualizando la lista de usuarios.
                listboxUsuarios.Items.Clear()
                AbrirToolStripMenuItem_Click(sender, e)

                stripEliminar.Enabled = False
            ElseIf a = 7 Then
                MsgBox("No se ha borrado ningún perfil.", 0, "Informaión")

            End If ' fin de la estructura condicional para que el usuario se asegure de si borra o no perfil
        End If ' fin del primer if, para controlar si se está intentando borrar al admin.
    End Sub

    ' Salir
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        PantallaVentas.Show()
        Me.Close()

    End Sub

    Private Sub btnNotas_Click(sender As Object, e As EventArgs) Handles btnNotas.Click
        PantallaNotas.Show()
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        Dim validarUsuario As New libValidacionDatos.Validacion
        Dim valido As Boolean
        'Primero vemos que ni el campo del nombre ni el campo del código estén vacíos.


        ' Si no ponemos esta estructura condicional, al hacer txtNombre.Clear se ejecuta de nuevo el método
        ' validarNombre, y al haber colocado un espacio en blanco (para dejar el campo nombre vacío) salta error. 
        ' (El espacio en blanco no está incluido en el String(campo de la clase validarNombre) con todos los caracteres
        ' permitidos en el campo nombre).
        ' Si ponemos este "si el campo está vacío no se ejecute el método" evitamos que nos salga dos veces un mensaje de error.
        If txtUsuario.Text <> "" Then
            ' Tomamos el último carácter introducido (hay que poner -1 o da Overflow exception)
            ' para compararlo con la lista de caracteres permitidos.
            ' valido = validarNombre.validarNombre(txtNombre.Text.Chars(txtNombre.Text.Length - 1))
            valido = validarUsuario.validarUsuario(txtUsuario.Text, 0)
            ' Aún se puede introducir esto: "Hola" volver atrás e introducir un número entre los caracteres,
            ' Así que hay que solucionarlo.
            If valido Then

                ' Una vez que se comprueba que los caracteres son válidos, solo falta ver si los
                ' datos introducidos coinciden con algunos de los datos guardados en el fichero.

                ' Si coincide y es usuario, no se cambiará el valor del booleano que indica 
                ' si el usuario actual es admin a True, se mantendrá en false.
                ' Si el usuario es admin, se cambiará a true para "enable = true" de los objetos necesarios.

                ' Si los caracteres no son válidos se le indica al usuario con un MsgBox, se limpian los campos txtBox
                ' Y se pone el focus en el nombre.


            Else

                MsgBox("Carácter inválido." & Chr(13) & "Por favor, introduzca caracteres en este campo." & Chr(13) & "Evite usar números o caracteres especiales." & Chr(13) & "Por ejemplo: %/()&1274", MsgBoxStyle.Exclamation, "Carácter inválido")
                ' Limpiamos el campo de texto. Si me da tiempo, borrar solamente el último carácter para que el usuario
                ' no tenga que volver a escribir todo.
                txtUsuario.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtUsuario.Focus()

            End If
        End If
    End Sub

    ' Texto Contraseña
    Private Sub txtContrasena_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged
        Dim validarCodigo As New libValidacionDatos.Validacion
        Dim valido As Boolean

        If txtContrasena.Text <> "" Then
            Try
                valido = validarCodigo.validarCodigo(txtContrasena.Text, 0)
            Catch ex As Exception
                MsgBox("Se ha producido una excepción." & Chr(13) & ex.Message & Chr(13) & "Es probable que haya intentado introducir un carácter. Por favor, introduzca un número.")
                ' No hace falta guardar este dato en el errorLog. Se ha decidido simplemente mostrarle el mensaje
                ' al usuario.
            End Try

            If valido Then
            Else
                MsgBox("Carácter inválido." & Chr(13) & "Por favor, introduzca caracteres en este campo." & Chr(13) & "Evite usar caracteres especiales." & Chr(13) & "Por ejemplo: %/()&", MsgBoxStyle.Exclamation, "Carácter inválido")

                'Dejo esto aquí por si no usamos la excepción por algún motivo(pero al intentar ejecutar el método validarCodigo dará excepción, ojo):  MsgBox("Dato inválido." & Chr(13) & "Por favor, introduzca ´números enteros en este campo(sin comas o puntos)." & Chr(13) & "Evite usar caracteres o caracteres especiales." & Chr(13) & "Por ejemplo: %/()abcABC", 0, "Dato inválido")


                ' Limpiamos el campo de texto. Si me da tiempo, borrar solamente el último carácter para que el usuario
                ' no tenga que volver a escribir todo.
                txtContrasena.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtContrasena.Focus()
            End If
        End If

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Dim validarUsuario As New libValidacionDatos.Validacion
        Dim valido As Boolean
        'Primero vemos que ni el campo del nombre ni el campo del código estén vacíos.

        If txtNombre.Text <> "" Then
            ' Pasamos el parámetro 1 porque estamos validando un nombre.
            valido = validarUsuario.validarUsuario(txtNombre.Text, 1)
            ' Aún se puede introducir esto: "Hola" volver atrás e introducir un número entre los caracteres,
            ' Así que hay que solucionarlo.
            If valido Then


            Else

                MsgBox("Carácter inválido." & Chr(13) & "Por favor, introduzca caracteres en este campo." & Chr(13) & "Evite usar números o caracteres especiales." & Chr(13) & "Por ejemplo: %/()&1274", MsgBoxStyle.Exclamation, "Carácter inválido")
                ' Limpiamos el campo de texto. Si me da tiempo, borrar solamente el último carácter para que el usuario
                ' no tenga que volver a escribir todo.
                txtNombre.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtNombre.Focus()

            End If
        End If
    End Sub

    Private Sub txtApellidos_TextChanged(sender As Object, e As EventArgs) Handles txtApellidos.TextChanged
        Dim validarUsuario As New libValidacionDatos.Validacion
        Dim valido As Boolean
        'Primero vemos que ni el campo del nombre ni el campo del código estén vacíos.

        If txtApellidos.Text <> "" Then
            ' Pasamos el parámetro 1 porque estamos validando un nombre.
            valido = validarUsuario.validarUsuario(txtApellidos.Text, 2)
            ' Aún se puede introducir esto: "Hola" volver atrás e introducir un número entre los caracteres,
            ' Así que hay que solucionarlo.
            If valido Then


            Else

                MsgBox("Carácter inválido." & Chr(13) & "Por favor, introduzca caracteres en este campo." & Chr(13) & "Evite usar números o caracteres especiales." & Chr(13) & "Por ejemplo: %/()&", MsgBoxStyle.Exclamation, "Carácter inválido")
                ' Limpiamos el campo de texto. Si me da tiempo, borrar solamente el último carácter para que el usuario
                ' no tenga que volver a escribir todo.
                txtApellidos.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtApellidos.Focus()

            End If
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        Dim validarUsuario As New libValidacionDatos.Validacion
        Dim valido As Boolean
        'Primero vemos que ni el campo del nombre ni el campo del código estén vacíos.

        If txtDireccion.Text <> "" Then
            ' Pasamos el parámetro 1 porque estamos validando un nombre.
            valido = validarUsuario.validarUsuario(txtDireccion.Text, 3)
            ' Aún se puede introducir esto: "Hola" volver atrás e introducir un número entre los caracteres,
            ' Así que hay que solucionarlo.
            If valido Then

                ' Una vez que se comprueba que los caracteres son válidos, solo falta ver si los
                ' datos introducidos coinciden con algunos de los datos guardados en el fichero.

                ' Si coincide y es usuario, no se cambiará el valor del booleano que indica 
                ' si el usuario actual es admin a True, se mantendrá en false.
                ' Si el usuario es admin, se cambiará a true para "enable = true" de los objetos necesarios.

                ' Si los caracteres no son válidos se le indica al usuario con un MsgBox, se limpian los campos txtBox
                ' Y se pone el focus en el nombre.


                ' Finalmente si ambos campos tienen datos válidos introducidos, habilitamos el botón de iniciar
                ' sesión.
                '  If txtUsuario.Text <> "" And txtCodigo.Text <> "" Then

                '   btnIniciarSesión.Enabled = True
                'else
                '  btnIniciarSesión.Enabled = False
                ' end If
            Else

                MsgBox("Carácter inválido." & Chr(13) & "Por favor, consulte los caracteres permitidos propuestos para la dirección.", MsgBoxStyle.Exclamation, "Carácter inválido")
                ' Limpiamos el campo de texto. Si me da tiempo, borrar solamente el último carácter para que el usuario
                ' no tenga que volver a escribir todo.
                txtDireccion.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtDireccion.Focus()

            End If
        End If
    End Sub

    ' Texto teléfono
    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
        Dim validarCodigo As New libValidacionDatos.Validacion
        Dim valido As Boolean

        ' Si los campos no están vacíos, se habilita el botón guardar.
        If Not (txtUsuario.Text.Equals("") And txtContrasena.Text.Equals("") And txtNombre.Text.Equals("") And txtApellidos.Text.Equals("") And txtDireccion.Text.Equals("")) And listboxUsuarios.Items.Count > 0 Then
            stripGuardar.Enabled = True
        End If

        If txtTelefono.Text <> "" Then
            Try
                ' Le pasamos valor 1 porque vamos a comprobar el teléfono, que permite 9 dígitos.
                valido = validarCodigo.validarCodigo(txtTelefono.Text, 1)
            Catch ex As Exception
                MsgBox("Se ha producido una excepción." & Chr(13) & ex.Message & Chr(13) & "Es probable que haya intentado introducir un carácter. Por favor, introduzca un número.")
                ' No hace falta guardar este dato en el errorLog. Se ha decidido simplemente mostrarle el mensaje
                ' al usuario.
            End Try

            If valido Then

            Else
                MsgBox("Carácter inválido." & Chr(13) & "Por favor, introduzca caracteres en este campo." & Chr(13) & "Evite usar caracteres especiales." & Chr(13) & "Por ejemplo: %/()&", MsgBoxStyle.Exclamation, "Carácter inválido")

                'Dejo esto aquí por si no usamos la excepción por algún motivo(pero al intentar ejecutar el método validarCodigo dará excepción, ojo):  MsgBox("Dato inválido." & Chr(13) & "Por favor, introduzca ´números enteros en este campo(sin comas o puntos)." & Chr(13) & "Evite usar caracteres o caracteres especiales." & Chr(13) & "Por ejemplo: %/()abcABC", 0, "Dato inválido")


                ' Limpiamos el campo de texto. Si me da tiempo, borrar solamente el último carácter para que el usuario
                ' no tenga que volver a escribir todo.
                txtTelefono.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtTelefono.Focus()
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Caracteres permitidos: ,'ªº\- espacios y números. ", MsgBoxStyle.Information, "Caracteres permitidos.")
    End Sub
End Class