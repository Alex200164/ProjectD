Imports System.IO

Public Class Validacion


    ' Función para ver si los datos (String) introducidos por el usuario son válidos para lo que se exige en
    ' el campo.
    Public Function validarUsuario(stringRecibido As String, tipo As Integer) As Boolean
        ' Si se recibe 0, se está recibiendo que se va a validar un usuario.
        ' Si es 1, es nombre.
        ' Si es 2 es apellido.
        ' Si es 3 es dirección.

        ' Entorno:
        ' Creamos una lista de caracteres permitidos.
        Dim charsPosibles As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ"
        ' Se permiten espacios y otros caracteres en los nombres, apellidos y direcciones.
        ' Para el nombre y apellidos es el mismo rango de caracteres posible.
        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
        Dim charsposiblesDireccion As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ ,'ªº\-0123456789"
        ' Las variables donde guardaremos los caracteres para compararlos.
        Dim chDeLista As Char
        Dim chRecibido As Char
        ' El buchón/chivato para ver si el número de aciertos (caracteres equivalentes) es el mismo al número
        ' de caracteres del string pasado por parámetro.
        Dim coincidencias As Integer = 0
        ' Finalmente la variable boolean valido para que en el formulario se pueda saber si
        ' el string es válido o no.
        Dim valido As Boolean = False
        Dim valorMaximo As Integer

        If tipo = 0 Then
            valorMaximo = 12
        ElseIf tipo = 1 Then
            valorMaximo = 12
        ElseIf tipo = 2 Then
            valorMaximo = 30
        ElseIf tipo = 3 Then
            valorMaximo = 50

        End If



        ' Inicio
        ' Primero comprobamos el tamaño del string
        If stringRecibido.Length > valorMaximo Then
            MsgBox("No se permiten más de" & valorMaximo & " caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta")
        Else
            ' Iteramos un número de veces igual al tamaño del string pasado por parámetro.
            For i = 1 To stringRecibido.Length
                ' Guardamos el carácter en chRecibido.
                chRecibido = GetChar(stringRecibido, i)
                ' Comprobamos si el carácter que acabamos de guardar es igual a los caracteres del string(charsPosibles).
                ' Iteramos un número de veces igual al tamaño de charsPosibles (dos veces el abecedario, una en minúsculas y otra mayúsculas)

                If tipo = 0 Then
                    For j = 1 To charsPosibles.Length
                        If chRecibido = GetChar(charsPosibles, j) Then
                            ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                            coincidencias = coincidencias + 1
                        Else
                            ' MsgBox("No ha introducido un carácter válido.", MsgBoxStyle.Exclamation, "Error al introducir datos para el acceso.")
                        End If
                    Next j
                ElseIf tipo = 1 Then
                    For j = 1 To charsPosiblesNombre.Length
                        If chRecibido = GetChar(charsPosiblesNombre, j) Then
                            ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                            coincidencias = coincidencias + 1
                        Else
                            ' MsgBox("No ha introducido un carácter válido.", MsgBoxStyle.Exclamation, "Error al introducir datos para el acceso.")
                        End If
                    Next j
                ElseIf tipo = 2 Then
                    ' Con el apellido usamos el mismo rango de caracteres válidos que con el nombre.
                    For j = 1 To charsPosiblesNombre.Length
                        If chRecibido = GetChar(charsPosiblesNombre, j) Then
                            ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                            coincidencias = coincidencias + 1
                        Else
                            ' MsgBox("No ha introducido un carácter válido.", MsgBoxStyle.Exclamation, "Error al introducir datos para el acceso.")
                        End If
                    Next j
                ElseIf tipo = 3 Then
                    For j = 1 To charsposiblesDireccion.Length
                        If chRecibido = GetChar(charsposiblesDireccion, j) Then
                            ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                            coincidencias = coincidencias + 1
                        Else
                            ' MsgBox("No ha introducido un carácter válido.", MsgBoxStyle.Exclamation, "Error al introducir datos para el acceso.")
                        End If
                    Next j
                End If


            Next i

            ' Si el buchón tiene un valor igual al tamaño del string pasado, significa que todos los caracteres
            ' son válidos, pues fueron comparados con los caracteres del String y fueron dados por buenos.
            If coincidencias = stringRecibido.Length Then
                valido = True
            End If
        End If

        Return valido

    End Function

    ' Método usado en la pantalla de inicio de sesión para ver que se introducen solo números en el campo de contraseña.
    Public Function validarCodigo(codigo As String, tipo As Integer) As Boolean
        ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 4 dígitos)
        ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
        ' Si se recibe 2 se está validando precios en productos

        ' Se opta de nuevo por la solución de poner en un String los valores permitidos.
        Dim charsPosibles As String = "0123456789"
        ' Para el campo de teléfono se permite usar el carácter especial +.
        Dim charsPosiblesTelefono As String = "0123456789+"
        Dim charsPosiblesPrecio As String = "0123456789. "
        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer
        If tipo = 0 Then
            valorMaximo = 4
        ElseIf tipo = 1 Then
            valorMaximo = 9
        ElseIf tipo = 2 Then
            valorMaximo = 5
        End If
        ' Solo se permiten códigos de hasta 4 números.
        ' La validación de que sean 4 se hace en otro método, porque eso depende de la creación de usuarios.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca una contraseña/código de 4 dígitos", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")

        Else
            For i = 1 To codigo.Length
                If tipo = 0 Then
                    For j = 1 To charsPosibles.Length
                        If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                        Else
                            ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                            ' entonces los datos se validan.
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                ElseIf tipo = 1 Then
                    For j = 1 To charsPosiblesTelefono.Length
                        If (GetChar(codigo, i) <> GetChar(charsPosiblesTelefono, j)) Then

                        Else
                            ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                            ' entonces los datos se validan.
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                ElseIf tipo = 2 Then
                    For j = 1 To charsPosiblesPrecio.Length
                        If (GetChar(codigo, i) <> GetChar(charsPosiblesPrecio, j)) Then

                        Else
                            ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                            ' entonces los datos se validan.
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                End If

            Next i
        End If
        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        End If
        Return valido
    End Function



    ' Método para comprobar que usuario y contraseña introducidos en la pantalla de inicio
    ' coinciden con datos guardados en el fichero secuencial usuarios.txt
    Public Function comprobarDatosSecuencial(file As String, usuario As String, contrasena As Integer) As Integer
        'si devuelve 0 los datos están mal, si devuelve 1 están bien, y si 2 es el admin el que se está conectando.
        Dim coincidenciaNombre As String = ""
        Dim coincidenciaContrasena As Integer = 0
        Dim correcto As Integer = 0
        Dim coincidencia As String
        Dim admin As Boolean
        Try
            ' Este método es como el de coprobar datos para archivos de texto, pero para archivos secuenciales.
            ' Devuelve un booleano, true si los datos coinciden, false si los datos no son correctos.
            FileOpen(1, file, OpenMode.Input)

            While Not EOF(1)
                Input(1, coincidenciaNombre)
                '  MsgBox("coincidenciaNombre:" & coincidenciaNombre & " y parámetro: " & usuario)
                If coincidenciaNombre.Equals(usuario) Then
                    ' Si mientras se lee el archivo secuencial se encuentra un nombre que coincida con el
                    ' pasado por parámetro, se pasa a leer el siguiente campo(la contraseña).
                    Input(1, coincidenciaContrasena)
                    'comentado, razón: esta linea era para testeo: MsgBox("coincidenciaContrasena:" & coincidenciaContrasena & " y parámetro: " & contrasena)
                    ' Si la contraseña coincide con la pasada por parámetro, entonces se valida el acceso a la aplicación.
                    If coincidenciaContrasena = contrasena Then
                        '  FileOpen(1, "usuarios.txt", OpenMode.Input)
                        Input(1, coincidencia)
                        Input(1, coincidencia)
                        Input(1, coincidencia)
                        Input(1, coincidencia)
                        Input(1, admin)
                        If admin = True Then
                            correcto = 2
                            ' Salimos del  while porque ya encontramos al usuario.
                            Exit While
                        Else
                            ' Salimos del  while porque ya encontramos al usuario.
                            correcto = 1
                            Exit While
                        End If
                    Else

                    End If


                End If

            End While


            FileClose(1)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

        Return correcto
    End Function


    Public Function errorLogWrite()
        ' Escribir en errorLog
        Dim fichero = "Errorlog.txt"
        Dim fich As New FileStream(fichero, FileMode.Append, FileAccess.Write)
        Dim rs As New StreamWriter(fich)
        rs.WriteLine(Now & "---> " & "Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)

        rs.Close()
        fich.Close()
    End Function

    Public Function mensajeErrorDatos()
        MsgBox("Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)
        errorLogWrite()
    End Function





    ' Método usado para validar diversos campos
    ' Si se recibe el integer 0 = se valida el campo categoría
    ' si se recibe el integer 1 = se valida el campo nombre
    ' si se recibe el integer 2 = se valida el campo tamaño

    Public Function validarCampoProducto(stringRecibido As String, tipo As Integer) As Boolean
        ' Entorno:
        ' Creamos una lista de caracteres permitidos.
        Dim charsPosibles As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
        Dim charsPosiblesCategoria As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
        Dim charsposiblesTamano As String = "0123456789'. "
        ' Las variables donde guardaremos los caracteres para compararlos.
        Dim chDeLista As Char
        Dim chRecibido As Char
        ' El buchón/chivato para ver si el número de aciertos (caracteres equivalentes) es el mismo al número
        ' de caracteres del string pasado por parámetro.
        Dim coincidencias As Integer = 0
        ' Finalmente la variable boolean valido para que en el formulario se pueda saber si
        ' el string es válido o no.
        Dim valido As Boolean = False
        Dim valorMaximo As Integer


        ' Asignamos el valor a la variable valorMaximo según el tipo de campo que hemos recibido por parámetro.
        If tipo = 0 Or tipo = 1 Then
            valorMaximo = 15
        ElseIf tipo = 2 Then
            valorMaximo = 8
        End If


        ' Inicio
        ' Primero comprobamos el tamaño del string
        If stringRecibido.Length > valorMaximo Then
            MsgBox("No se permiten más de" & valorMaximo & " caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta")
        Else
            ' Iteramos un número de veces igual al tamaño del string pasado por parámetro.
            For i = 1 To stringRecibido.Length
                ' Guardamos el carácter en chRecibido.
                chRecibido = GetChar(stringRecibido, i)
                ' Comprobamos si el carácter que acabamos de guardar es igual a los caracteres del string(charsPosibles).
                ' Iteramos un número de veces igual al tamaño del string usado para comparar los caracteres en el campo.


                ' Con esta estructura vemos qué estamos validando
                ' Solo si es el tamaño (parámetro con valor 2) se usa la lista charsPosiblesTamano 
                ' Que solo permite números y punto
                If tipo = 2 Then
                    For j = 1 To charsposiblesTamano.Length
                        If chRecibido = GetChar(charsposiblesTamano, j) Then
                            ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                ElseIf tipo = 1 Then
                    ' Si estamos validando nombre:
                    For j = 1 To charsPosibles.Length
                        If chRecibido = GetChar(charsPosibles, j) Then
                            ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                    ' Si estamos validando categoría:
                ElseIf tipo = 0 Then

                    For j = 1 To charsPosiblesCategoria.Length
                        If chRecibido = GetChar(charsPosiblesCategoria, j) Then
                            ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                End If
            Next i

            ' Si el buchón tiene un valor igual al tamaño del string pasado, significa que todos los caracteres
            ' son válidos, pues fueron comparados con los caracteres del String y fueron dados por buenos.
            If coincidencias = stringRecibido.Length Then
                valido = True
            End If
        End If

        Return valido

    End Function


End Class
