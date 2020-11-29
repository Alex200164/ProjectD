Imports System.IO
Imports LecturaEscrituraArchivos


Public Class PantallaVentas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnGestionarPerfiles.Click
        ComprobarAdmin.Show()



    End Sub

    ' Método que se ejecuta al cargarse el formulario por primera vez
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dependiendo de si el usuario inicia como admin o no, se habilita o deshabilita el botón de gestión
        If lbAdmin.Text.Equals("*") Then
            ' Habilitamos botón de gestión
            btnGestionarPerfiles.Enabled = True
        Else
            ' Deshabilitamos botón de gestión
            btnGestionarPerfiles.Enabled = False
        End If

        ' Cargamos el comboBox1 con las categorías actualmente disponibles de productos del fichero "Productos.txt"
        ' Instanciamos la clase Escritura para acceder a los métodos que nos permiten escribir en ficheros.
        Dim escritura As New LecturaEscrituraArchivos.Escritura

        ' Escribimos en el fichero una serie de productos de prueba
        escritura.escribirProducto(1, "Productos.txt", "Colchón", "Colchón deluxe", "1.9", 0)
        escritura.escribirProducto(2, "Productos.txt", "Canapé", "Canape deluxe", "2.0", 0)
        escritura.escribirProducto(3, "Productos.txt", "Estructura", "Estructura deluxe", "1.5", 0)
        escritura.escribirProducto(4, "Productos.txt", "miau", "Miau deluxe", "0.5", 0)
        escritura.escribirProducto(5, "Productos.txt", "miau", "Miau deluxe", "0.6", 0)
        escritura.escribirProducto(6, "Productos.txt", "miau", "Miau deluxe", "0.9", 0)
        escritura.escribirProducto(7, "Productos.txt", "miau", "Miau básico", "0.3", 0)
        escritura.escribirProducto(8, "Productos.txt", "Estructura", "Estructura básica", "1.3", 0)
        escritura.escribirProducto(9, "Productos.txt", "Canapé", "Canape deluxe", "1.8", 0)
        escritura.escribirProducto(10, "Productos.txt", "Colchón", "Colchón deluxe", "2.3", 0)

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

    ' Botón para pasar al formulario de confirmación ventas
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCobro.Click
        ' Accedemos al archivo auxiliar "PedidoDatosAuxiliar"
        Dim fichero As New FileStream("PedidoDatosAuxiliar.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)


        ' Escondemos esté formulario. 
        Me.Hide()
        ' Mostramos la pantalla de cobro
        Cobro.Show()
    End Sub

    ' Botón para añadir productos al listBox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAnadirprod.Click
        ' Accedemos al archivo auxiliar "PedidoDatosAuxiliar"
        Dim fichero As New FileStream("PedidoDatosAuxiliar.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim sw As New StreamWriter(fichero)


    End Sub

    Private Sub listboxProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxProductos.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        lbAdmin.Text = ""
        Me.Close()
        InicioSesion.Show()
    End Sub

    ' Método ejecutado cuando se produce un cambio en el comboBox (Normalmente el usuario seleccionando un indice)
    Private Sub comboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCategoria.SelectedIndexChanged

        ' Borramos los items que estuvieran relacionados con el primer combobox debido al cambio de categoria
        comboProducto.Items.Clear()
        comboProducto.Text = ""
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

    ' Método ejecutado cuando se produce un cambio en el comboBox (Normalmente el usuario seleccionando un indice)
    Private Sub comboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProducto.SelectedIndexChanged

        ' Borramos los items que estuvieran relacionados con el primer combobox debido al cambio de categoria
        comboTamano.Items.Clear()
        comboTamano.Text = ""

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

End Class
