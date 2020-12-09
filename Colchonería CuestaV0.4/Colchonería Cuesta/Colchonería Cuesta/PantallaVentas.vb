Imports System.IO
Imports LecturaEscrituraArchivos


Public Class PantallaVentas

    Dim precioTotal As Single = 0
    Dim arrayPreciosLista As New ArrayList

    ' Método que se ejecuta al cargarse el formulario por primera vez
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Activamos el reloj.
        lbReloj.Text = Now

        ' Dependiendo de si el usuario inicia como admin o no, se habilitan ciertas órdenes del menu strip 
        '(opciones en la barra de herramientas)
        ' Por ejemplo: el guardar caja y gestión de perfiles.
        If PantallaInicio.lbAdmin.Text.Equals("*") Then
            ' Habilitamos botón de gestión
            stripGestionPerfiles.Enabled = True

            ' Si se inició la sesión como admin, permitimos guardar,e tc.
            stripGuardarCaja.Enabled = True
            stripAbrirCajaDiaria.Enabled = True
            stripGestionProductos.Enabled = True
        Else
            ' Deshabilitamos botón de gestión y guardar caja.
            stripGuardarCaja.Enabled = False
            stripGestionPerfiles.Enabled = False
            stripAbrirCajaDiaria.Enabled = False
            stripGestionProductos.Enabled = False
        End If

        ' Cargamos el comboBox1 con las categorías actualmente disponibles de productos del fichero "Productos.txt"


        ' Variables auxiliares para recoger los datos de lectura
        Dim aux As String = ""
        Dim categoria As String = ""
        Dim nombre As String = ""
        Dim tamaño As String = ""
        Dim precio As Single = 0

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

    ' Botón para pasar al formulario de confirmación ventas.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCobro.Click
        If (listboxCarrito.Items.Count <> 0) Then
            ' Recogemos los datos del label precio
            Dim precioTotal As Single = lbPrecioTotalText.Text
        End If

        If (listboxCarrito.Items.Count = 0) Then
            MsgBox("No hay articulos en la cesta. Operación abortada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Aviso")
            Return
        End If

        ' Instanciamos la clase Escritura para acceder a los métodos que nos permiten escribir en ficheros.
        Dim escritura As New LecturaEscrituraArchivos.Escritura

        Dim numeroRegistros As Single = listboxCarrito.Items.Count

        ' Utilizado para introducir los valores en las ID correctas
        Dim contadorAux As Single = 1

        Dim datos As String = ""

        ' Y los contenidos del listBox y los añadimos a un archivo auxiliar "Cobro_Aux.txt"
        For contador As Integer = 0 To numeroRegistros - 1

            ' Recogemos los datos de la columna
            Dim columna As String = listboxCarrito.Items.Item(contador)
            'Introducimos en variable
            datos = datos & columna & vbCrLf

            contadorAux = contadorAux + 1
        Next

        Cobro.numeroRegistros = listboxCarrito.Items.Count



        ' Y los contenidos del listBox y los añadimos a un archivo auxiliar "Cobro_Aux.txt"
        'For contador As Integer = 0 To numeroRegistros - 1

        ' Recogemos los datos de la columna
        'Dim columna As String = listboxCarrito.Items.Item(contador)
        'Introducimos la columna
        'escritura.escribirListaListBox(contadorAux, "Cobro_Aux.txt", columna)

        'contadorAux = contadorAux + 1
        'Next

        ' Introducimos el precio total al final del fichero.
        escritura.escribirListaListBox(contadorAux, "Cobro_Aux.txt", precioTotal)

        Cobro.stringTicket = datos

        ' Escondemos esté formulario. 
        Me.Hide()

        ' Cambiamos el texto de los comboBox
        comboCategoria.Text = ""
        comboNombreProd.Items.Clear()
        comboNombreProd.Text = ""
        comboTamano.Items.Clear()
        comboTamano.Text = ""
        listboxCarrito.Items.Clear()
        precioTotal = 0
        arrayPreciosLista.Clear()
        lbPrecioTotalText.Text = "---"

        ' Mostramos la pantalla de cobro
        Cobro.Show()
    End Sub

    ' Botón para añadir productos al listBox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAnadirprod.Click
        ' Accedemos al archivo auxiliar "PedidoDatosAuxiliar"
        ' Dim fichero As New FileStream("PedidoDatosAuxiliar.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        ' Dim sw As New StreamWriter(fichero)
        Try
            FileOpen(1, "Productos.txt", OpenMode.Random, OpenShare.Shared, OpenAccess.Read, 42)
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
                            linea = linea & producto.Categoria & " " & Chr(13)
                            linea = linea & producto.NombreProducto & " " & Chr(13)
                            linea = linea & producto.Tamaño & " " & Chr(13)
                            linea = linea & producto.Precio & " " & Chr(13)
                            ' que es lo que añadiremos al listbox.

                            ' Como lo que se guarda en el listbox es una linea de producto
                            ' como string, con varios campos, creamos un arrayList solo para los productos.
                            ' Para cuando tengamos que eliminar items del listbox.

                            ' Añadimos al arrayList el precio. Como los productos
                            ' y por tanto sus precios se añaden de forma paralela
                            ' en el array se guardan los precios con el índice
                            ' correspondiente al producto en el listbox.
                            arrayPreciosLista.Add(Math.Round(producto.Precio, 2))

                            ' Añadimos el item al listbox, con el string con todos los datos del producto elegido.
                            listboxCarrito.Items.Add(linea)

                            ' comentado:
                            ' listboxCarrito.Items.Add(producto.Categoria)
                            ' listboxCarrito.Items.Add(producto.NombreProducto)
                            ' listboxCarrito.Items.Add(producto.Tamaño)
                            ' listboxCarrito.Items.Add(producto.Precio)

                            ' Actualizamos la variable precioTotal.
                            precioTotal = precioTotal + producto.Precio
                            Math.Round(precioTotal, 2)
                            ' Usamos la variable precioTotal para poner texto acualizado en el label donde se muestra
                            ' el precio total de los productos sumados en el carrito.
                            lbPrecioTotalText.Text = precioTotal
                        End If
                    End If
                End If
            End While

            FileClose(1)
        Catch ex As Exception
            MsgBox("Error al intentar abrir el fichero de productos para poder añadir item al carrito.", MsgBoxStyle.Exclamation, "Aviso")
            Dim fichero = "Errorlog.txt"
            Dim fich As New FileStream(fichero, FileMode.Append, FileAccess.Write)
            Dim rs As New StreamWriter(fich)
            rs.WriteLine(Now & "---> " & "Error al intentar abrir el fichero para lectura de productos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)

            rs.Close()
            fich.Close()
        End Try

    End Sub

    ' Categoría
    ' Método ejecutado cuando se produce un cambio en el comboBox (Normalmente el usuario seleccionando un indice)
    Private Sub comboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCategoria.SelectedIndexChanged

        ' Borramos los items que estuvieran relacionados con el primer combobox debido al cambio de categoria
        comboNombreProd.Items.Clear()
        comboNombreProd.Text = ""
        comboTamano.Items.Clear()
        comboTamano.Text = ""
        Label2.Text = "0"

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
        Label2.Text = "0"

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

    Private Sub GestionarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripGestionProductos.Click
        Me.Close()
        GestionPrecios.Show()

    End Sub



    Private Sub GestionarPerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripGestionPerfiles.Click
        ComprobarAdmin.Show()
    End Sub

    Private Sub stripCerrarSesion_Click(sender As Object, e As EventArgs) Handles stripCerrarSesion.Click
        PantallaInicio.lbAdmin.Text = ""
        Me.Close()
        PantallaInicio.Show()
    End Sub


    'Quitar, eliminar
    Private Sub btnQuitarProd_Click(sender As Object, e As EventArgs) Handles btnQuitarProd.Click
        ' Si hay items en el listbox entonces se procede a eliminar.
        If listboxCarrito.Items.Count > 0 And listboxCarrito.SelectedIndex >= 0 Then
            ' Actualizamos el precio total y el label donde mostramos el texto:        
            precioTotal = precioTotal - arrayPreciosLista(listboxCarrito.SelectedIndex)
            lbPrecioTotalText.Text = Math.Round(precioTotal, 2)
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
        ' Invisible porque no se ha podido implementar. 
        ' Actualmente se guarda en el archivo de recaudación diaria al cobrar al cliente. 
        ' Al pulsar el botón de finalizar en la pantalla de cobro.
        Try
            Dim datosAcceso As New FileStream("cajaDiaria.txt", FileMode.Append, FileAccess.Write)
            Dim sw As New StreamWriter(datosAcceso)
            sw.WriteLine(lbCajaDiariaText.Text)
            sw.WriteLine("Guardada la caja diaria en: " & Now)
            ' Cerramos los flujos para escribir en el log de acceso.
            sw.Close()
            datosAcceso.Close()
            MsgBox("Caja diaria guardada correctamente.")
        Catch ex As Exception
            MsgBox("Error al intentar escribir en el archivo de caja diaria", MsgBoxStyle.OkOnly, "Aviso")
        End Try

    End Sub

    Private Sub stripAbrirCajaDiaria_Click(sender As Object, e As EventArgs) Handles stripAbrirCajaDiaria.Click
        Try
            System.Diagnostics.Process.Start("cajaDiaria.txt", System.IO.Directory.GetCurrentDirectory)
        Catch ex As Exception
            MsgBox("No se puede abrir el archivo, es posible que no exista.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Aviso")
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbReloj.Text = DateTime.Now.ToString
    End Sub

    Private Sub comboTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTamano.SelectedIndexChanged

        ' Variables auxiliares para recoger los datos de lectura
        Dim aux As String = ""
        Dim categoria As String = comboCategoria.SelectedItem
        Dim nombre As String = comboNombreProd.SelectedItem
        Dim tamano As String = ""
        Dim precio As Integer = 0

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Productos.txt")

        ' Bucle for para leer e introducir todos las categorias existentes en 
        For contador As Integer = 1 To numeroRegistros
            ' Leemos
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamano, precio)
            ' Si el nombre coincide, lo introducimos
            If (categoria = comboCategoria.SelectedItem) Then
                If (nombre = comboNombreProd.SelectedItem) Then
                    If (tamano = comboTamano.SelectedItem) Then
                        Label2.Text = precio
                    End If
                End If
            End If

        Next

    End Sub

End Class
