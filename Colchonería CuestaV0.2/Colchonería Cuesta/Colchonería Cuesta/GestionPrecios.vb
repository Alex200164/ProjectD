﻿Public Class GestionPrecios

    ' Método que se ejecuta al cargarse el formulario por primera vez
    Private Sub GestionPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtTamano.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub comboTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTamano.SelectedIndexChanged

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

    End Sub

    ' Método que se ejecuta al presionar el botón de "Retirar producto"
    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click

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

        ' Borramos los elementos del comboBox 1 
        comboCategoria.Items.Clear()

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros3 As Integer = lectura.numeroRegistros("Productos.txt")

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
        For contador As Integer = 2 To numeroRegistros3

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


    End Sub

End Class