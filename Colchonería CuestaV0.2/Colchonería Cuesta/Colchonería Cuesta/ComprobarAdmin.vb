' No hace falta hacer imports libValidaciones para instanciar sus clases porque está inlcuida en el proyecto.
Imports System.IO

Public Class ComprobarAdmin
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        ' Podemos instanciar una clase de la biblioteca libValidaciones de al siguiente manera
        Dim validarNombre As New libValidacionDatos.Validacion
        Dim valido As Boolean
        'Primero vemos que ni el campo del nombre ni el campo del código estén vacíos.


        ' Si no ponemos esta estructura condicional, al hacer txtNombre.Clear se ejecuta de nuevo el método
        ' validarNombre, y al haber colocado un espacio en blanco (para dejar el campo nombre vacío) salta error. 
        ' (El espacio en blanco no está incluido en el String(campo de la clase validarNombre) con todos los caracteres
        ' permitidos en el campo nombre).
        ' Si ponemos este "si el campo está vacío no se ejecute el método" evitamos que nos salga dos veces un mensaje de error.
        If txtNombre.Text <> "" Then
            ' Tomamos el último carácter introducido (hay que poner -1 o da Overflow exception)
            ' para compararlo con la lista de caracteres permitidos.
            ' valido = validarNombre.validarNombre(txtNombre.Text.Chars(txtNombre.Text.Length - 1))
            valido = validarNombre.validarNombre(txtNombre.Text)
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
                If txtNombre.Text <> "" And txtCodigo.Text <> "" Then

                    btnAutenticar.Enabled = True
                Else
                    btnAutenticar.Enabled = False
                End If
            Else
                '
                MsgBox("Carácter inválido." & Chr(13) & "Por favor, introduzca caracteres en este campo." & Chr(13) & "Evite usar números o caracteres especiales." & Chr(13) & "Por ejemplo: %/()&1274", 0, "Carácter inválido")
                ' Limpiamos el campo de texto. Si me da tiempo, borrar solamente el último carácter para que el usuario
                ' no tenga que volver a escribir todo.
                txtNombre.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtNombre.Focus()

            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        Dim validarCodigo As New libValidacionDatos.Validacion
        Dim valido As Boolean


        If txtCodigo.Text <> "" Then
            Try
                valido = validarCodigo.validarCodigo(txtCodigo.Text)
            Catch ex As Exception
                MsgBox("Se ha producido una excepción." & Chr(13) & ex.Message & Chr(13) & "Es probable que haya intentado introducir un carácter. Por favor, introduzca un número.")
            End Try

            If valido Then
                If txtNombre.Text <> "" And txtCodigo.Text <> "" Then
                    btnAutenticar.Enabled = True
                Else
                    btnAutenticar.Enabled = False
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

    Private Sub btnAutenticar_Click(sender As Object, e As EventArgs) Handles btnAutenticar.Click
        Dim validarAcceso As New libValidacionDatos.Validacion
        ' Salía un aviso que decí que esta var booleana no se usaba. no la borro por las dudas.
        ' Dim valido As Boolean
        ' Si todo es correcto, mostramos el siguiente formulario, la TPV en sí
        ' y escondemos de vista el formulario de inicio de sesión. (no se puede hacer close porque es el formulario
        ' con el que arranca la app.
        Try
            ' Se le pasa el último parámetro false porque no estamos comprobando si es admin o no.
            ' El último parámetro sirve para eso.
            If (validarAcceso.comprobarDatos("datosAcceso.txt", txtNombre.Text, txtCodigo.Text, True) = True) Then

                ' Guardamos la hora de acceso del usuario (con sus datos):
                Dim datosAcceso As New FileStream("logAcceso.txt", FileMode.Append, FileAccess.Write)
                Dim sw As New StreamWriter(datosAcceso)
                '  Añade el usuario admi si no existe

                sw.WriteLine(txtNombre.Text)
                sw.WriteLine(txtCodigo.Text)
                sw.WriteLine("Acceso en: " & Now)

                ' Cerramos los flujos.
                sw.Close()
                datosAcceso.Close()

                Me.Close()
                PantallaVentas.Hide()
                GestionPerfiles.Show()
            Else

                ' No hace falta mostrar este mensaje porque de eso ya se encarga el método si el login/acceso falla.
                ' MsgBox("No se han introducido datos correctos. Vuelva a intentarlo.", 0, "Datos de acceso incorrectos.")
            End If

        Catch fnf As FileNotFoundException
            MsgBox("No se ha encontrado el archivo donde se guardan los datos de acceso a la aplicación.", 0, "Archivo no existe.")
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class