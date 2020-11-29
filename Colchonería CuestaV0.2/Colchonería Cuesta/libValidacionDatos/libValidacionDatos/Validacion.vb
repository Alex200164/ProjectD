Imports System.IO

Public Class Validacion


    ' Función para ver si los datos (String) introducidos por el usuario son válidos para lo que se exige en
    ' el campo.
    Public Function validarNombre(stringRecibido As String) As Boolean
        ' Entorno:
        ' Creamos una lista de caracteres permitidos.
        Dim charsPosibles As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ"
        ' Las variables donde guardaremos los caracteres para compararlos.
        Dim chDeLista As Char
        Dim chRecibido As Char
        ' El buchón/chivato para ver si el número de aciertos (caracteres equivalentes) es el mismo al número
        ' de caracteres del string pasado por parámetro.
        Dim coincidencias As Integer = 0
        ' Finalmente la variable boolean valido para que en el formulario se pueda saber si
        ' el string es válido o no.
        Dim valido As Boolean = False



        ' Inicio
        ' Primero comprobamos el tamaño del string
        If stringRecibido.Length > 12 Then
            MsgBox("No se permiten más de 12 caracteres.", 0, "Longitud incorrecta")
        Else
            ' Iteramos un número de veces igual al tamaño del string pasado por parámetro.
            For i = 1 To stringRecibido.Length
                ' Guardamos el carácter en chRecibido.
                chRecibido = GetChar(stringRecibido, i)
                ' Comprobamos si el carácter que acabamos de guardar es igual a los caracteres del string(charsPosibles).
                ' Iteramos un número de veces igual al tamaño de charsPosibles (dos veces el abecedario, una en minúsculas y otra mayúsculas)
                For j = 1 To charsPosibles.Length
                    If chRecibido = GetChar(charsPosibles, j) Then
                        ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                        coincidencias = coincidencias + 1
                    End If
                Next j

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
    Public Function validarCodigo(codigo As String) As Boolean
        ' Se opta de nuevo por la solución de poner en un String los valores permitidos.
        Dim charsPosibles As String = "0123456789"
        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        ' Solo se permiten códigos de hasta 4 números.
        ' La validación de que sean 4 se hace en otro método, porque eso depende de la creación de usuarios.
        If codigo.Length > 4 Then
            MsgBox("Por favor, introduzca una contraseña/código de 4 dígitos", 0, "Longitud incorrecta.")

        Else
            For i = 1 To codigo.Length
                For j = 1 To charsPosibles.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                    Else
                        coincidencias = coincidencias + 1
                    End If
                Next j

            Next i
        End If
        If coincidencias = codigo.Length Then
            valido = True
        End If
        Return valido
    End Function

    ' Método que de momento es obsoleto. Se usaba para validar datos. Se recibían argumentos
    ' y se comparaban con los datos de un fichero de texto. Si había coincidencia al leer las parejas usuario/contraseña
    ' se daba acceso a la aplicación.
    ' Ahora se usa el método que comprueba un fichero de organización secuencial.
    Public Function comprobarDatos(fichero As String, nombreRecibido As String, codigoRecibido As String, admin As Boolean) As Boolean
        ' la variable/parámetro admin es false. Se pondrá true si se quiere ejecutar este método para comprobar si el usuario es admin
        ' o no. 
        ' Se usa este método en la pantalla de ventas principal de la tpv cuando se quiere acceder a la gestión de usuarios
        ' para comprobar que la persona es admin.

        ' variables (string) para guardar la lectura (se leerá por lineas) del fichero y poder compararlas con los parámetros recibidos.
        Dim lineaNombre As String
        Dim lineaCodigo As String
        Dim asterisco As Char
        ' El booleano de retorno que indicará a la form que lo reciba si los datos son válidos o no (valor true en caso de que lo sean)
        Dim valido As Boolean
        ' Un booleano para poder frenar el while infinito.
        Dim bandera As Boolean = False


        Try
            Dim accesoDatos As New FileStream(fichero, FileMode.Open, FileAccess.Read)
            Dim sr As New StreamReader(accesoDatos)
            ' lee por lineas hasta encontrar una coincidencia con un nombre
            Try
                While (bandera = False)
                    lineaNombre = sr.ReadLine()
                    ' Si encuentra coincidencia (se compara el valor recibido con el valor leido (guardado en una variable del método) del fichero.
                    If lineaNombre.Equals(nombreRecibido) Then
                        lineaCodigo = sr.ReadLine
                        ' se comprueba si la siguiente linea, la contraseña aparejada al nombre, es igual a la contraseña
                        ' recibida por parámetro.
                        If (admin = False) Then
                            ' Se ejecuta este código (no se comprueba si hay asterisco tras la contraseña) si el parámetro booleano admin es false.
                            If lineaCodigo.Equals(codigoRecibido) Then
                                valido = True
                                bandera = True
                            End If
                            ' Y se ejecuta este código (se comprueba si hay asterisco tras la contraseña) si el parámetro booleano admin es true.
                        Else
                            If lineaCodigo.Equals(codigoRecibido) Then
                                asterisco = ChrW(sr.Read)

                                If asterisco = "*" Then
                                    valido = True
                                    bandera = True
                                Else
                                    MsgBox("Este usuario no es administrador. No tene permiso para gestionar usuarios.", 0, "Usuario sin permisos.")
                                End If
                            End If
                        End If
                    End If

                End While

                If bandera = False Then
                    ' Si no se encontró ningún nombre y contraseña, sacamos el mensaje.
                    MsgBox("No existe el usuario o ha introducido datos incorrectos. Por favor, inténtelo de nuevo.", 0, "Error de acceso")
                End If
                sr.Close()
                accesoDatos.Close()
            Catch ex As Exception
                MsgBox("Error. No se encontró ningún usuario con esos datos.", 0, "Usuario inexistente.")
            End Try
        Catch ex As NullReferenceException
            ' Llamamos a la función mensajeErrorDatos para mostrar el mensaje de error.
            mensajeErrorDatos()
            ' Y escribimos el error en el fichero de errores.
            errorLogWrite()

        End Try

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
        MsgBox("Hola")
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
                    MsgBox("coincidenciaContrasena:" & coincidenciaContrasena & " y parámetro: " & contrasena)
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
End Class
