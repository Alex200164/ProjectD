Imports System.ComponentModel
Imports libValidacionDatos.Validacion
Imports System.IO

Public Class InicioSesion
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        Dim validarNombre As New libValidacionDatos.Validacion
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
            valido = validarNombre.validarNombre(txtUsuario.Text)
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
                If txtUsuario.Text <> "" And txtCodigo.Text <> "" Then

                    btnIniciarSesión.Enabled = True
                Else
                    btnIniciarSesión.Enabled = False
                End If
            Else
                '
                MsgBox("Carácter inválido." & Chr(13) & "Por favor, introduzca caracteres en este campo." & Chr(13) & "Evite usar números o caracteres especiales." & Chr(13) & "Por ejemplo: %/()&1274", 0, "Carácter inválido")
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
        btnIniciarSesión.Enabled = False
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        Dim validarCodigo As New libValidacionDatos.Validacion
        Dim valido As Boolean


        If txtCodigo.Text <> "" Then
            Try
                valido = validarCodigo.validarCodigo(txtCodigo.Text)
            Catch ex As Exception
                MsgBox("Se ha producido una excepción." & Chr(13) & ex.Message & Chr(13) & "Es probable que haya intentado introducir un carácter. Por favor, introduzca un número.")
            End Try

            If valido Then
                If txtUsuario.Text <> "" And txtCodigo.Text <> "" Then
                    btnIniciarSesión.Enabled = True
                Else
                    btnIniciarSesión.Enabled = False
                End If
            Else
                'Dejo esto aquí por si no usamos la excepción por algún motivo(pero al intentar ejecutar el método validarCodigo dará excepción, ojo):  MsgBox("Dato inválido." & Chr(13) & "Por favor, introduzca ´números enteros en este campo(sin comas o puntos)." & Chr(13) & "Evite usar caracteres o caracteres especiales." & Chr(13) & "Por ejemplo: %/()abcABC", 0, "Dato inválido")


                ' Limpiamos el campo de texto. Si me da tiempo, borrar solamente el último carácter para que el usuario
                ' no tenga que volver a escribir todo.
                txtCodigo.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtCodigo.Focus()
            End If
        End If



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub btnIniciarSesión_Click(sender As Object, e As EventArgs) Handles btnIniciarSesión.Click
        Dim validarAcceso As New libValidacionDatos.Validacion
        Dim resultado As Integer
        Dim coincidencia As String = ""
        ' Llamamos al método para comprobar los datos y guardamo el resultado en una variable tipo integer
        resultado = validarAcceso.comprobarDatosSecuencial("usuarios.txt", txtUsuario.Text, CInt(txtCodigo.Text))

        ' Si devuelve 0, no son correctos los datos.
        If (resultado = 0) Then
            MsgBox("Los datos no son correctos.")

            ' Si devuelve 1 se entra como usuario sin privilegios de admin.
        ElseIf (resultado = 1) Then
            Me.Hide()
            PantallaVentas.Show()
            ' Guardamos la hora de acceso del usuario (con sus datos):
            Dim datosAcceso As New FileStream("logAcceso.txt", FileMode.Append, FileAccess.Write)
            Dim sw As New StreamWriter(datosAcceso)
            sw.WriteLine(txtUsuario.Text)
            sw.WriteLine(txtCodigo.Text)
            sw.WriteLine("Acceso en: " & Now)

            ' Cerramos los flujos para escribir en el log de acceso.
            sw.Close()
            datosAcceso.Close()
            ' Si devuelve 2 se entra como admin.
        ElseIf (resultado = 2) Then
            PantallaVentas.btnGestionarPerfiles.Enabled = True
            PantallaVentas.lbAdmin.Text = "*"
            Me.Hide()
            PantallaVentas.Show()
            ' Guardamos la hora de acceso del usuario (con sus datos):
            Dim datosAcceso As New FileStream("logAcceso.txt", FileMode.Append, FileAccess.Write)
            Dim sw As New StreamWriter(datosAcceso)
            sw.WriteLine(txtUsuario.Text)
            sw.WriteLine(txtCodigo.Text)
            sw.WriteLine("Acceso en: " & Now)

            ' Cerramos los flujos para escribir en el log de acceso.
            sw.Close()
            datosAcceso.Close()



        End If
        FileClose(1)

    End Sub


End Class