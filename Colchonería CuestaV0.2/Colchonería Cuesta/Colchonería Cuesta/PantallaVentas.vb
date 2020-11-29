Imports System.IO
Imports LecturaEscrituraArchivos


Public Class PantallaVentas

    ' No podemos poner este precio en los métodos porque si no se reiniciará cada vez que ejecutemos el método.
    ' Si declaramos precioTotal en un método, se inica como 0. Luego se le pone el valor del producto que
    ' se añadó al listbox. Al darle al botón de añadir de nuevo, se reinicia el código asociado a ése botón
    ' y la variable está a 0 otra vez, por tanto no se produce la suma.
    ' HAY QUE CAMBIAR EL PRECIO A SINGLE, NO OLVIDAR!!!
    Dim precioTotal As Integer = 0
    Dim arrayPreciosLista As New ArrayList


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbPrecioTotal.Click

    End Sub



    ' Método que se ejecuta al cargarse el formulario por primera vez
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Activamos el reloj.
        lbTiempoText.Text = Now

        ' Dependiendo de si el usuario inicia como admin o no, se habilitan ciertas órdenes del menu strip 
        '(opciones en la barra de herramientas)
        ' Por ejemplo: el guardar caja y gestión de perfiles.
        If lbAdmin.Text.Equals("*") Then
            ' Habilitamos botón de gestión
            stripGestionPerfiles.Enabled = True

            ' Si se inició la sesión como admin, permitimos guardar.
            stripGuardarCaja.Enabled = True
        Else
            ' Deshabilitamos botón de gestión y guardar caja.
            stripGuardarCaja.Enabled = False
            stripGestionPerfiles.Enabled = False
        End If

        '



        ' Cargamos el comboBox1 con las categorías actualmente disponibles de productos del fichero "Productos.txt"
        ' Instanciamos la clase Escritura para acceder a los métodos que nos permiten escribir en ficheros.
        Dim escritura As New LecturaEscrituraArchivos.Escritura

        ' Escribimos en el fichero una serie de productos de prueba
        escritura.escribirProducto(1, "Productos.txt", "Colchón", "Colchón deluxe", "1.9", 400)
        escritura.escribirProducto(2, "Productos.txt", "Canapé", "Canape deluxe", "2.0", 600)
        escritura.escribirProducto(3, "Productos.txt", "Estructura", "Estructura deluxe", "1.5", 400)
        escritura.escribirProducto(4, "Productos.txt", "miau", "Miau deluxe", "0.5", 300)
        escritura.escribirProducto(5, "Productos.txt", "miau", "Miau deluxe", "0.6", 350)
        escritura.escribirProducto(6, "Productos.txt", "miau", "Miau deluxe", "0.9", 400)
        escritura.escribirProducto(7, "Productos.txt", "miau", "Miau básico", "0.3", 250)
        escritura.escribirProducto(8, "Productos.txt", "Estructura", "Estructura básica", "1.3", 100)
        escritura.escribirProducto(9, "Productos.txt", "Canapé", "Canape deluxe", "1.8", 540)
        escritura.escribirProducto(10, "Productos.txt", "Colchón", "Colchón deluxe", "2.3", 500)

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

    ' Botón para pasar al formulario de confirmación ventas. A eliminar y poner en menustrip
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCobro.Click
        ' Accedemos al archivo auxiliar "PedidoDatosAuxiliar"
        '  Dim fichero As New FileStream("PedidoDatosAuxiliar.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)


        ' Escondemos esté formulario. 
        Me.Hide()
        ' Mostramos la pantalla de cobro
        Cobro.Show()
    End Sub

    ' Botón para añadir productos al listBox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAnadirprod.Click
        ' Accedemos al archivo auxiliar "PedidoDatosAuxiliar"
        ' Dim fichero As New FileStream("PedidoDatosAuxiliar.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        ' Dim sw As New StreamWriter(fichero)
        FileOpen(1, "Productos.txt", OpenMode.Random, OpenShare.Shared, OpenAccess.Read, 42)
        Dim lectura As New LecturaEscrituraArchivos.Lectura
        Dim posicion As Integer = 0
        Dim categoria As String = comboCategoria.GetItemText(comboCategoria.SelectedItem)
        Dim linea As String = ""

        While Not EOF(1)
            ' No hace falta poner el último parámetro 
            FileGet(1, producto)
            '  MsgBox(comboCategoria.GetItemText(comboCategoria.SelectedItem))
            '   MsgBox("categoria: " & producto.Categoria)
            '  MsgBox("nombre producto: " & producto.NombreProducto)
            '  MsgBox("tamaño: " & producto.Tamaño)
            '  MsgBox("precio: " & producto.Precio)

            If producto.Categoria.Equals(comboCategoria.GetItemText(comboCategoria.SelectedItem)) Then
                If producto.NombreProducto.Equals(comboNombreProd.GetItemText(comboNombreProd.SelectedItem)) Then
                    If producto.Tamaño = comboTamano.GetItemText(comboTamano.SelectedItem) Then
                        ' Guardamos todos los campos del producto en un string
                        linea = linea & producto.Categoria & " "
                        linea = linea & producto.NombreProducto & " "
                        linea = linea & producto.Tamaño & " "
                        linea = linea & producto.Precio & " "
                        ' que es lo que añadiremos al listbox.

                        ' Como lo que se guarda en el listbox es una linea de producto
                        ' como string, con varios campos, creamos un arrayList solo para los productos.
                        ' Para cuando tengamos que eliminar items del listbox.

                        ' Añadimos al arrayList el precio. Como los productos
                        ' y por tanto sus precios se añaden de forma paralela
                        ' en el array se guardan los precios con el índice
                        ' correspondiente al producto en el listbox.
                        arrayPreciosLista.Add(producto.Precio)

                        ' Añadimos el item al listbox, con el string con todos los datos del producto elegido.
                        listboxCarrito.Items.Add(linea)

                        ' comentado:
                        ' listboxCarrito.Items.Add(producto.Categoria)
                        ' listboxCarrito.Items.Add(producto.NombreProducto)
                        ' listboxCarrito.Items.Add(producto.Tamaño)
                        ' listboxCarrito.Items.Add(producto.Precio)

                        ' Actualizamos la variable precioTotal.
                        precioTotal = precioTotal + producto.Precio
                        ' Usamos la variable precioTotal para poner texto acualizado en el label donde se muestra
                        ' el precio total de los productos sumados en el carrito.
                        lbPrecioTotalText.Text = precioTotal
                    End If
                End If
            End If
        End While

        FileClose(1)
    End Sub

    Private Sub listboxProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxCarrito.SelectedIndexChanged

    End Sub



    ' Categoría
    ' Método ejecutado cuando se produce un cambio en el comboBox (Normalmente el usuario seleccionando un indice)
    Private Sub comboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCategoria.SelectedIndexChanged

        ' Borramos los items que estuvieran relacionados con el primer combobox debido al cambio de categoria
        comboNombreProd.Items.Clear()
        comboNombreProd.Text = ""
        comboTamano.Items.Clear()
        comboTamano.Text = ""

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
                comboNombreProd.Items.Add(nombre)
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

                    comboNombreProd.Items.Add(nombre)
                End If
            End If

        Next

    End Sub

    ' Producto
    ' Método ejecutado cuando se produce un cambio en el comboBox (Normalmente el usuario seleccionando un indice)
    Private Sub comboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboNombreProd.SelectedIndexChanged

        ' Borramos los items que estuvieran relacionados con el primer combobox debido al cambio de categoria
        comboTamano.Items.Clear()
        comboTamano.Text = ""

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

        ' Introducimos el nombre seleccionado en el segundo comboBox
        aux = comboNombreProd.SelectedItem

        ' Bucle for para leer e introducir todos las categorias existentes en 
        For contador As Integer = 1 To numeroRegistros
            ' Leemos
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamano, precio)
            ' Si el nombre coincide, lo introducimos
            If (aux = nombre) Then
                comboTamano.Items.Add(tamano)
            End If

        Next

    End Sub

    ' Botón tamaño.
    Private Sub comboTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTamano.SelectedIndexChanged

    End Sub

    Private Sub GestionarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripGestionProductos.Click

        GestionPrecios.Show()

    End Sub



    Private Sub GestionarPerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripGestionPerfiles.Click
        ComprobarAdmin.Show()
    End Sub

    Private Sub stripCerrarSesion_Click(sender As Object, e As EventArgs) Handles stripCerrarSesion.Click
        lbAdmin.Text = ""
        Me.Close()
        InicioSesion.Show()
    End Sub


    'Quitar, eliminar
    Private Sub btnQuitarProd_Click(sender As Object, e As EventArgs) Handles btnQuitarProd.Click
        ' Si hay items en el listbox entonces se procede a eliminar.
        If listboxCarrito.Items.Count > 0 And listboxCarrito.SelectedIndex >= 0 Then
            ' Actualizamos el precio total y el label donde mostramos el texto:        
            precioTotal = precioTotal - arrayPreciosLista(listboxCarrito.SelectedIndex)
            lbPrecioTotalText.Text = precioTotal
            ' Quitamos el precio del arraylist también, dado que el item ya no estará en el listbox.
            arrayPreciosLista.RemoveAt(listboxCarrito.SelectedIndex)
            ' Quiamos el producto del listbox, efectivamente quitando un item.
            listboxCarrito.Items.Remove(listboxCarrito.SelectedItem)
        Else
        End If


    End Sub

    ' Notas
    Private Sub btnNotas_Click(sender As Object, e As EventArgs) Handles btnNotas.Click
        ' System.Diagnostics.Process.Start("notepad.exe", System.IO.Directory.GetCurrentDirectory)
        PantallaNotas.Show()


    End Sub

    Private Sub stripGuardarCaja_Click(sender As Object, e As EventArgs) Handles stripGuardarCaja.Click
        Try
            Dim datosAcceso As New FileStream("cajaDiaria.txt", FileMode.Append, FileAccess.Write)
            Dim sw As New StreamWriter(datosAcceso)
            sw.WriteLine(lbCajaDiariaText.Text)
            sw.WriteLine("Guardada la caja diaria en: " & Now)
            ' Cerramos los flujos para escribir en el log de acceso.
            sw.Close()
            datosAcceso.Close()
            MsgBox("Caja diaria guardada correctamente.")
        Catch ex As exception
        End Try

    End Sub
End Class
