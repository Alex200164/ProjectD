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


    Public Function validarCodigo(codigo As String) As Boolean
        Dim charsPosibles As String = "0123456789"
        Dim valido As Boolean = False
        If codigo.Length > 4 Then
            MsgBox("Por favor, introduzca una contraseña/código de 4 dígitos", 0, "Longitud incorrecta.")

        Else
            For i = 1 To codigo.Length
                For j = 1 To charsPosibles.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then
                    Else
                        valido = True
                    End If
                Next j

            Next i
        End If

        Return valido
    End Function

    Public Function comprobarDatos(fichero As String, nombreRecibido As String, codigoRecibido As String) As Boolean
        ' variables (string) para guardar la lectura (se leerá por lineas) del fichero y poder compararlas con los parámetros recibidos.
        Dim lineaNombre As String
        Dim lineaCodigo As String
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
                        If lineaCodigo.Equals(codigoRecibido) Then
                            valido = True
                            bandera = True
                        End If

                    End If

                End While

                If bandera = False Then
                    ' Si no se encontró ningún nombre y contraseña, sacamos el mensaje.
                    MsgBox("No existe el usuario o ha introducido datos incorrectos. Por favor, inténtelo de nuevo.")
                End If
                sr.Close()
                accesoDatos.Close()
            Catch ex As Exception
                MsgBox("Error. No se encontró ningún usuario con esos datos.", 0, "Usuario inexistente.")
            End Try
        Catch ex As NullReferenceException
                ' Llamamos a la función mensajeErrorDatos para mostrar el mensaje de error.
                mensajeErrorDatos()

        End Try
        Return valido
    End Function


    Public Function mensajeErrorDatos()
        MsgBox("Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)
    End Function
End Class
