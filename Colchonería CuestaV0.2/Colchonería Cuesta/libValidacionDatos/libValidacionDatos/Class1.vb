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


    Public Function validarCodigo(codigo As Integer) As Boolean
        Dim valido As Boolean = False
        Dim s As String
        Dim coincidencias As Integer

        ' Convertimos el codigo a String y lo guardamos en una variable tipo String para ver
        ' si tiene comas o puntos, pues solo se aceptan enteros, mayores de 0 y menores de 10 000 (o sea, 9999)
        s = codigo.ToString()
        MsgBox(s)

        For i = 1 To s.Length
            ' Comprobamos que sea número.
            If IsNumeric(codigo) Then
                ' Comprobamos que sea mayor o igual que cero
                If codigo >= 0 And codigo < 10000 Then
                    If GetChar(s, i).Equals(".") Then
                        coincidencias = coincidencias + 1


                    End If
                    If GetChar(s, i).Equals(",") Then
                        coincidencias = coincidencias + 1

                    End If
                    valido = True
                End If
            End If

        Next i
        If coincidencias >= 1 Then
            valido = False
        End If


        Return valido
    End Function

End Class
