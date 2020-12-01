Public Class GestionPrecios

    ' Método que se ejecuta al cargarse el formulario por primera vez
    Private Sub GestionPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Deshabilitamos los botones hasta que el usuario introduzca algún valor en todos los campos.
        btnAñadir.Enabled = False
        btnModificar.Enabled = False
        btnRetirar.Enabled = False
        ' Variables auxiliares para recoger los datos de lectura
        Dim aux As String = ""
        Dim categoria As String = ""
        Dim nombre As String = ""
        Dim tamaño As String = ""
        Dim precio As Integer = 0

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Productos.txt")

        ' Creamos un arrayList que se encarga de guardar los valores ya introducidos para así evitar duplicidades
        Dim listaCategoria As New ArrayList
        ' Creamos una bandera para conocer si el valor es aceptado o no.
        Dim doble As Boolean

        ' Hacemos una lectura inicial para tener en aux una variable para comparar y evitar duplicidades
        lectura.leerProducto(1, "Productos.txt", categoria, nombre, tamaño, precio)

        ' Añadimos al arrayList
        listaCategoria.Add(categoria)

        ' Añadimos al comboBox
        comboCategoria.Items.Add(categoria)

        ' Bucle for para leer e introducir todos las categorias existentes en 
        For contador As Integer = 2 To numeroRegistros

            ' Leemos
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamaño, precio)
            ' Comprobamos el valor de categoria obtenido tantas veces como posiciones haya dentro del arrayList
            For contador2 As Integer = 0 To listaCategoria.Count - 1
                ' Comprobamos si el valor recibido se encuentra ya en el arrayList, en caso contrario se le da luz verde para ser introducido
                ' En el comboBox
                If (categoria = listaCategoria.Item(contador2)) Then
                    doble = True
                    Exit For
                Else
                    ' Añadimos al arrayList
                    listaCategoria.Add(categoria)
                    doble = False
                End If
            Next
            ' Añadimos al comboBox el valor si se nos permite
            If (doble = False) Then
                comboCategoria.Items.Add(categoria)
            End If

        Next
    End Sub

    Private Sub comboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCategoria.SelectedIndexChanged

        ' Borramos los items que estuvieran relacionados con el primer combobox debido al cambio de categoria
        comboProducto.Items.Clear()
        comboProducto.Text = ""
        comboTamano.Items.Clear()
        comboTamano.Text = ""

        ' Borramos el valor anterior del segundo TextBox
        txtNombre.Clear()
        ' Borramos el valor anterior del tercer TextBox
        txtTamano.Clear()
        ' Borramos el valor anterior del cuarto TextBox
        txtPrecio.Clear()
        ' Introducimos en el primer TextBox el valor seleccionado
        txtCategoria.Text = comboCategoria.SelectedItem


        ' Variables auxiliares para recoger los datos de lectura
        Dim aux As String = ""
        Dim categoria As String = ""
        Dim nombre As String = ""
        Dim tamaño As String = ""
        Dim precio As Integer = 0

        ' Creamos un arrayList que se encarga de guardar los valores ya introducidos para así evitar duplicidades
        Dim listaNombre As New ArrayList
        ' Creamos una bandera para conocer si el valor es aceptado o no.
        Dim doble As Boolean = True

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Productos.txt")

        ' Introducimos en el auxiliar la categoria seleccionada por el usuario
        aux = comboCategoria.SelectedItem
        ' Ciclamos hasta que encontremos un valor que podamos introducir, de esta manera tendremos mínimo un valor en el ArrayList
        For contador As Integer = 1 To numeroRegistros
            ' Leemos
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamaño, precio)

            If (aux = categoria) Then
                ' Añadimos al arrayList
                listaNombre.Add(nombre)
                comboProducto.Items.Add(nombre)
                doble = False
                Exit For
            End If
        Next

        ' Bucle for para leer e introducir todos las categorias existentes en 
        For contador As Integer = 2 To numeroRegistros
            ' Leemos
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamaño, precio)

            ' Si la categoria recibida coincide...
            If (aux = categoria) Then
                ' Ciclamos tantas veces como posiciones tenga el ArrayList en busca de valores no repetidos
                For contador2 As Integer = 0 To listaNombre.Count - 1
                    ' Comprobamos si el valor recibido se encuentra ya en el arrayList, en caso contrario se le da luz verde para ser introducido
                    ' En el comboBox
                    If (nombre = listaNombre.Item(contador2)) Then
                        doble = True
                        Exit For
                    Else
                        ' Añadimos al arrayList
                        listaNombre.Add(nombre)
                        doble = False
                    End If
                Next
                ' Introducimos en el comboBox el nombre de producto si se nos permite
                If (doble = False) Then

                    comboProducto.Items.Add(nombre)
                End If
            End If

        Next

    End Sub

    Private Sub comboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProducto.SelectedIndexChanged

        ' Borramos los items que estuvieran relacionados con el primer combobox debido al cambio de categoria
        comboTamano.Items.Clear()
        comboTamano.Text = ""

        ' Borramos el valor anterior del segundo TextBox
        txtNombre.Clear()
        ' Borramos el valor anterior del tercer TextBox
        txtTamano.Clear()
        ' Borramos el valor anterior del cuarto TextBox
        txtPrecio.Clear()
        ' Introducimos en el primer TextBox el valor seleccionado
        txtNombre.Text = comboProducto.SelectedItem

        ' Variables auxiliares para recoger los datos de lectura
        Dim aux As String = ""
        Dim categoria As String = ""
        Dim nombre As String = ""
        Dim tamanno As String = ""
        Dim precio As Integer = 0

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Productos.txt")

        ' Introducimos el nombre seleccionado en el segundo comboBox
        aux = comboProducto.SelectedItem

        ' Bucle for para leer e introducir todos las categorias existentes en 
        For contador As Integer = 1 To numeroRegistros
            ' Leemos
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamanno, precio)
            ' Si el nombre coincide, lo introducimos
            If (aux = nombre) Then
                comboTamano.Items.Add(tamanno)
            End If

        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCategoria.TextChanged
        Dim validacion As New libValidacionDatos.Validacion
        Dim valido As Boolean
        If txtCategoria.Text <> "" Then
            ' Llamamos al método para validar, y le pasamos el valor 0 como argumento porque estamos comprobando la categoría
            '   MsgBox(txtCategoria.Text)
            valido = validacion.validarCampoProducto(txtCategoria.Text, 0)

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
                txtCategoria.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtCategoria.Focus()

            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Dim validacion As New libValidacionDatos.Validacion
        Dim valido As Boolean
        If txtNombre.Text <> "" Then
            ' Llamamos al método para validar, y le pasamos el valor 1 como argumento porque estamos comprobando el nombre.
            valido = validacion.validarCampoProducto(txtNombre.Text, 1)

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
                txtNombre.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtNombre.Focus()

            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtTamano.TextChanged
        Dim validacion As New libValidacionDatos.Validacion
        Dim valido As Boolean
        If txtTamano.Text <> "" Then
            ' Llamamos al método para validar, y le pasamos el valor 2 como argumento porque estamos comprobando el tamaño.
            valido = validacion.validarCampoProducto(txtTamano.Text, 2)

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
                txtTamano.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtTamano.Focus()

            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        Dim validarCodigo As New libValidacionDatos.Validacion
        Dim valido As Boolean
        If Not (txtCategoria.Text.Equals("") AndAlso txtNombre.Text.Equals("") AndAlso txtTamano.Text.Equals("")) Then
            btnAñadir.Enabled = True
            btnModificar.Enabled = True
            btnRetirar.Enabled = True

        End If
        If txtPrecio.Text <> "" Then
            Try
                valido = validarCodigo.validarCodigo(txtPrecio.Text, 2)
            Catch ex As Exception
                MsgBox("Se ha producido una excepción." & Chr(13) & ex.Message & Chr(13) & "Es probable que haya intentado introducir un carácter. Por favor, introduzca un número.")
                ' No hace falta guardar este dato en el errorLog. Se ha decidido simplemente mostrarle el mensaje
                ' al usuario.
            End Try
            If valido Then

            Else
                'Dejo esto aquí por si no usamos la excepción por algún motivo(pero al intentar ejecutar el método validarCodigo dará excepción, ojo):  MsgBox("Dato inválido." & Chr(13) & "Por favor, introduzca ´números enteros en este campo(sin comas o puntos)." & Chr(13) & "Evite usar caracteres o caracteres especiales." & Chr(13) & "Por ejemplo: %/()abcABC", 0, "Dato inválido")


                ' Limpiamos el campo de texto. Si me da tiempo, borrar solamente el último carácter para que el usuario
                ' no tenga que volver a escribir todo.
                txtPrecio.Clear()

                ' Ponemos el focus en el nombre para que le sea cómodo al usuario volver a escribir.
                txtPrecio.Focus()

            End If

        End If

    End Sub

    Private Sub comboTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTamano.SelectedIndexChanged

        If Not (comboTamano.GetItemText(comboTamano.SelectedItem).Equals("")) And (comboCategoria.GetItemText(comboCategoria.SelectedItem).Equals("") And comboProducto.GetItemText(comboProducto.SelectedItem).Equals("")) Then
            btnModificar.Enabled = True
        End If
        ' Introducimos en el tercer TextBox el valor seleccionado
        txtTamano.Text = comboTamano.SelectedItem

        ' Variables auxiliares para recoger los datos de lectura
        Dim aux As String = ""
        Dim categoria As String = comboCategoria.SelectedItem
        Dim nombre As String = comboProducto.SelectedItem
        Dim tamanno As String = comboTamano.SelectedItem
        Dim precio As Integer = 0

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Productos.txt")

        ' Introducimos el nombre seleccionado en el tercer comboBox
        aux = comboProducto.SelectedItem

        ' Bucle for para leer e introducir todos las categorias existentes en 
        For contador As Integer = 1 To numeroRegistros
            ' Leemos
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamanno, precio)
            If (categoria = comboCategoria.SelectedItem) Then
                If (nombre = comboProducto.SelectedItem) Then
                    If (tamanno = comboTamano.SelectedItem) Then
                        txtPrecio.Text = precio
                    End If
                End If
            End If

        Next

    End Sub

    ' Método que se ejecuta al presionar el botón de "Borrar campos"
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        ' Cambiamos el texto de los comboBox
        comboCategoria.Text = ""
        comboProducto.Items.Clear()
        comboProducto.Text = ""
        comboTamano.Items.Clear()
        comboTamano.Text = ""

        ' Vaciamos los textBox
        txtCategoria.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        txtTamano.Clear()
        txtPrecio.Clear()

        btnAñadir.Enabled = False
        btnBorrar.Enabled = False
        btnModificar.Enabled = False
        btnRetirar.Enabled = False

    End Sub

    ' Método que se ejecuta la presionar el botón de "Añadir producto"
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        ' Variables auxiliares para recoger los datos de lectura
        Dim aux As String = ""
        Dim categoria As String = ""
        Dim nombre As String = ""
        Dim tamano As String = ""
        Dim precio As Integer = 0

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Productos.txt")

        ' Instanciamos la clase Escritura para acceder a los métodos que nos permiten escribir en ficheros.
        Dim escritura As New LecturaEscrituraArchivos.Escritura

        ' Bandera para saber si se ha encontrado un valor duplicado o no
        Dim duplicado As Boolean = False
        ' Bucle for para leer y identificar si hay registros que coincidan con el registro que se quiere introducir nuevo 
        For contador As Integer = 1 To numeroRegistros

            ' Leemos del archivo Productos.txt
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamano, precio)

            If (categoria = comboCategoria.SelectedItem) Then
                If (nombre = comboProducto.SelectedItem) Then
                    If (tamano = comboTamano.SelectedItem) Then
                        duplicado = True
                    End If
                End If
            End If
        Next


        ' Si no se ha encontrado ningún registro con los mismos datos, introducimos registro nuevo 
        If (duplicado = False) Then
            ' Escribimos en el fichero el registro
            escritura.escribirProducto((numeroRegistros + 1), "Productos.txt", txtCategoria.Text, txtNombre.Text, txtTamano.Text, Val(txtPrecio.Text))
        Else
            MsgBox("El producto que se intenta añadir ya existe, operación abortada.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Aviso")
        End If

        ' Actualizamos los comboBox
        actualizarDatosComboBox()


    End Sub

    ' Método que se ejecuta al presionar el botón de "Retirar producto"
    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click

        Dim codigoRespuesta As Single = MsgBox("¿Está seguro de que desea retirar el producto?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Confirmación")

        If (codigoRespuesta = 2) Then
            MsgBox("Operación abortada", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Información")
            Return
        End If

        ' Cogemos los datos y los introducimos en el fichero "Productos_Auxiliar.txt"

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Productos.txt")

        ' Instanciamos la clase Escritura para acceder a los métodos que nos permiten escribir en ficheros.
        Dim escritura As New LecturaEscrituraArchivos.Escritura

        ' Variables auxiliares para recoger los datos de lectura
        Dim aux As String = ""
        Dim categoria As String = ""
        Dim nombre As String = ""
        Dim tamano As String = ""
        Dim precio As Integer = 0

        Dim contadorAux As Integer = 1
        ' Bucle for para leer e introducir todos los registros existentes en el fichero "Productos_Auxiliar.txt" menos el registro que queremos eliminar 
        For contador As Integer = 1 To numeroRegistros

            ' Leemos del archivo Productos.txt
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamano, precio)

            If (categoria = comboCategoria.SelectedItem) Then
                If (nombre = comboProducto.SelectedItem) Then
                    If (tamano = comboTamano.SelectedItem) Then
                        contadorAux = contadorAux - 1
                    Else
                        ' Escribimos en el archivo Productos_Auxiliar.txt
                        escritura.escribirProducto(contadorAux, "Productos_Auxiliar.txt", categoria, nombre, tamano, precio)
                    End If
                Else
                    ' Escribimos en el archivo Productos_Auxiliar.txt
                    escritura.escribirProducto(contadorAux, "Productos_Auxiliar.txt", categoria, nombre, tamano, precio)
                End If
            Else
                ' Escribimos en el archivo Productos_Auxiliar.txt
                escritura.escribirProducto(contadorAux, "Productos_Auxiliar.txt", categoria, nombre, tamano, precio)
            End If
            contadorAux = contadorAux + 1
        Next

        ' Borramos el fichero Productos.txt
        My.Computer.FileSystem.DeleteFile("Productos.txt")


        ' Accedemos al archivo "Productos_Auxiliar.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistrosProdAux As Integer = lectura.numeroRegistros("Productos_Auxiliar.txt")

        ' Bucle for para leer e introducir todos los registros nuevos en el fichero "Productos.txt" 
        For contador As Integer = 1 To numeroRegistrosProdAux

            ' Leemos del archivo Productos_Auxiliar.txt
            lectura.leerProducto(contador, "Productos_Auxiliar.txt", categoria, nombre, tamano, precio)

            ' Escribimos en el archivo Productos.txt
            escritura.escribirProducto(contador, "Productos.txt", categoria, nombre, tamano, precio)

        Next

        ' Borramos el fichero Productos_Auxiliar.txt
        My.Computer.FileSystem.DeleteFile("Productos_Auxiliar.txt")

        ' Actualizamos los comboBox
        actualizarDatosComboBox()




    End Sub

    ' Método que se ejecuta al presionar el botón de "Modificar producto"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim codigoRespuesta As Single = MsgBox("¿Está seguro de que desea modificar el producto?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Confirmación")

        If (codigoRespuesta = 2) Then
            MsgBox("Operación abortada", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Información")
            Return
        End If

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Productos.txt")

        ' Instanciamos la clase Escritura para acceder a los métodos que nos permiten escribir en ficheros.
        Dim escritura As New LecturaEscrituraArchivos.Escritura

        ' Variables auxiliares para recoger los datos de lectura
        Dim aux As String = ""
        Dim categoria As String = ""
        Dim nombre As String = ""
        Dim tamano As String = ""
        Dim precio As Integer = 0


        ' Bandera para saber si se ha encontrado el registro original o no
        Dim encontradoID As Boolean = False
        ' Bucle for para leer y identificar si hay registros que coincidan con el registro que se quiere introducir nuevo 
        For contador As Integer = 1 To numeroRegistros

            ' Leemos del archivo Productos.txt
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamano, precio)

            ' Si los datos coinciden, escribimos
            If (categoria = comboCategoria.SelectedItem) Then
                If (nombre = comboProducto.SelectedItem) Then
                    If (tamano = comboTamano.SelectedItem) Then
                        ' Escribimos en el fichero el registro
                        escritura.escribirProducto(contador, "Productos.txt", txtCategoria.Text, txtNombre.Text, txtTamano.Text, Val(txtPrecio.Text))
                        ' Cambiamos el estado de la bandera
                        encontradoID = True
                    End If
                End If
            End If
        Next

        ' En caso de no haber encontrado la ID del registro a modificar...
        If (encontradoID = False) Then
            MsgBox("El producto que intenta modificar no existe, operación abortada.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Aviso")
        End If

        ' Actualizamos los comboBox con la información nueva
        actualizarDatosComboBox()


    End Sub

    Private Sub actualizarDatosComboBox()
        ' Actualizamos los comboBox

        ' Variables auxiliares para recoger los datos de lectura
        Dim aux As String = ""
        Dim categoria As String = ""
        Dim nombre As String = ""
        Dim tamano As String = ""
        Dim precio As Integer = 0

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Productos.txt")

        ' Instanciamos la clase Escritura para acceder a los métodos que nos permiten escribir en ficheros.
        Dim escritura As New LecturaEscrituraArchivos.Escritura

        ' Borramos los elementos del comoBox 1 
        comboCategoria.Items.Clear()

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros2 As Integer = lectura.numeroRegistros("Productos.txt")

        ' Creamos un arrayList que se encarga de guardar los valores ya introducidos para así evitar duplicidades
        Dim listaCategoria As New ArrayList
        ' Creamos una bandera para conocer si el valor es aceptado o no.
        Dim doble As Boolean

        ' Hacemos una lectura inicial para tener en aux una variable para comparar y evitar duplicidades
        lectura.leerProducto(1, "Productos.txt", categoria, nombre, tamano, precio)

        ' Añadimos al arrayList
        listaCategoria.Add(categoria)

        ' Añadimos al comboBox
        comboCategoria.Items.Add(categoria)

        ' Bucle for para leer e introducir todos las categorias existentes en 
        For contador As Integer = 2 To numeroRegistros2

            ' Leemos
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamano, precio)
            ' Comprobamos el valor de categoria obtenido tantas veces como posiciones haya dentro del arrayList
            For contador2 As Integer = 0 To listaCategoria.Count - 1
                ' Comprobamos si el valor recibido se encuentra ya en el arrayList, en caso contrario se le da luz verde para ser introducido
                ' En el comboBox
                If (categoria = listaCategoria.Item(contador2)) Then
                    doble = True
                    Exit For
                Else
                    ' Añadimos al arrayList
                    listaCategoria.Add(categoria)
                    doble = False
                End If
            Next
            ' Añadimos al comboBox el valor si se nos permite
            If (doble = False) Then
                comboCategoria.Items.Add(categoria)
            End If

        Next

        ' Cambiamos el texto de los comboBox
        comboCategoria.Text = ""
        comboProducto.Items.Clear()
        comboProducto.Text = ""
        comboTamano.Items.Clear()
        comboTamano.Text = ""

        ' Vaciamos los textBox
        txtCategoria.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        txtTamano.Clear()
        txtPrecio.Clear()

        ' Se reinician los botones
        btnAñadir.Enabled = False
        btnBorrar.Enabled = False
        btnModificar.Enabled = False
        btnRetirar.Enabled = False
    End Sub

    Private Sub VolverAVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAVentasToolStripMenuItem.Click
        Me.Close()
        PantallaVentas.Show()

    End Sub

    Private Sub btnNotas_Click(sender As Object, e As EventArgs) Handles btnNotas.Click
        PantallaNotas.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class