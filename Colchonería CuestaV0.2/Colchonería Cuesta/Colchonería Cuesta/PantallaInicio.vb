Imports System.IO
Public Class PantallaInicio
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        Dim validarUsuario As New libValidacionDatos.Validacion
        Dim valido As Boolean
        'Primero vemos que ni el campo del nombre ni el campo del código estén vacíos.

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


                ' Finalmente si ambos campos tienen datos válidos introducidos, habilitamos el botón de iniciar
                ' sesión.
                If txtUsuario.Text <> "" And txtContrasena.Text <> "" Then

                    btnIniciarSesion.Enabled = True
                Else
                    btnIniciarSesion.Enabled = False
                End If
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


    ' Load
    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Focus()

        'Estas lineas son de testeo (son para generar un txt con admin y 1111 para probar el acceso)
        ' borrarlas cuando sea el momento. Por ahora no tocarlas.
        If File.Exists("datosAcceso.txt") Then
            ' Si el archivo ya existe significa que no hace falta añadir un admin.
        Else
            ' Si no existe, añadimos uno con append.
            '   Dim datosAcceso As New FileStream("datosAcceso.txt", FileMode.Append, FileAccess.Write)
            '  Dim sw As New StreamWriter(datosAcceso)
            '  Añade el usuario admi si no existe

            '  sw.WriteLine("admin")
            '  sw.WriteLine("1111")
            '  sw.Close()
            '  datosAcceso.Close()
        End If

        txtUsuario.Focus()
        btnIniciarSesion.Enabled = False
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged
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
                If txtUsuario.Text <> "" And txtContrasena.Text <> "" Then
                    btnIniciarSesion.Enabled = True
                Else
                    btnIniciarSesion.Enabled = False
                End If
            Else
                'Dejo esto aquí por si no usamos la excepción por algún motivo(pero al intentar ejecutar el método validarCodigo dará excepción, ojo):  MsgBox("Dato inválido." & Chr(13) & "Por favor, introduzca ´números enteros en este campo(sin comas o puntos)." & Chr(13) & "Evite usar caracteres o caracteres especiales." & Chr(13) & "Por ejemplo: %/()abcABC", 0, "Dato inválido")


                ' Limpiamos el campo de texto. Si me da tiempo, borrar solamente el último carácter para que el usuario
                ' no tenga que volver a escribir todo.
                txtContrasena.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtContrasena.Focus()
            End If
        End If

    End Sub

    ' Salir
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub


    ' Btn Iniciar sesión
    Private Sub btnIniciarSesión_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim validarAcceso As New libValidacionDatos.Validacion
        Dim resultado As Integer
        Dim coincidencia As String = ""
        ' Llamamos al método para comprobar los datos y guardamo el resultado en una variable tipo integer
        resultado = validarAcceso.comprobarDatosSecuencial("usuarios.txt", txtUsuario.Text, CInt(txtContrasena.Text))

        ' Si devuelve 0, no son correctos los datos.
        If (resultado = 0) Then
            MsgBox("Los datos no son correctos.", MsgBoxStyle.Exclamation, "Error durante el acceso.")

            ' Si devuelve 1 se entra como usuario sin privilegios de admin.
        ElseIf (resultado = 1) Then
            Me.Hide()
            PantallaVentas.Show()
            ' Guardamos la hora de acceso del usuario (con sus datos):
            Dim datosAcceso As New FileStream("logAcceso.txt", FileMode.Append, FileAccess.Write)
            Dim sw As New StreamWriter(datosAcceso)
            sw.WriteLine(txtUsuario.Text)
            sw.WriteLine(txtContrasena.Text)
            sw.WriteLine("Acceso en: " & Now)

            ' Cerramos los flujos para escribir en el log de acceso.
            sw.Close()
            datosAcceso.Close()
            ' Si devuelve 2 se entra como admin.
        ElseIf (resultado = 2) Then
            PantallaVentas.stripGestionPerfiles.Enabled = True
            lbAdmin.Text = "*"
            Me.Hide()
            PantallaVentas.Show()
            Try
                ' Guardamos la hora de acceso del usuario (con sus datos):
                Dim datosAcceso As New FileStream("logAcceso.txt", FileMode.Append, FileAccess.Write)
                Dim sw As New StreamWriter(datosAcceso)
                sw.WriteLine(txtUsuario.Text)
                sw.WriteLine(txtContrasena.Text)
                sw.WriteLine("Acceso en: " & Now)

                ' Cerramos los flujos para escribir en el log de acceso.
                sw.Close()
                datosAcceso.Close()
            Catch ex As Exception
                MsgBox("Error al escribir en el log de accesos.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Aviso")
                Dim fichero = "Errorlog.txt"
                Dim fich As New FileStream(fichero, FileMode.Append, FileAccess.Write)
                Dim rs As New StreamWriter(fich)
                rs.WriteLine(Now & "---> " & "Error en la apertura del archivo para escribir." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)

                rs.Close()
                fich.Close()
            End Try
        End If
        FileClose(1)

    End Sub

    ' Reloj
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbReloj.Text = DateTime.Now.ToString
    End Sub


End Class