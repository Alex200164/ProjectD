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

    ' Primera líneas de código en ejecutarse al iniciarse el formulario por primera vez
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dependiendo de si el usuario inicia como admin o no, se habilita o deshabilita el botón de gestión
        If lbAdmin.Text.Equals("*") Then
            ' Habilitamos botón de gestión
            btnGestionarPerfiles.Enabled = True
        Else
            ' Deshabilitamos botón de gestión
            btnGestionarPerfiles.Enabled = False
        End If

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        Dim escritura As New LecturaEscrituraArchivos.Escritura

        escritura.escribirProducto(1, "Productos.txt", "Colchón", "", "", 0)
        escritura.escribirProducto(2, "Productos.txt", "Canapé", "", "", 0)
        escritura.escribirProducto(3, "Productos.txt", "Estructura", "", "", 0)





        Dim aux As String = ""
        Dim categoria As String = ""
        Dim nombre As String = ""
        Dim tamaño As String = ""
        Dim precio As Integer = 0


        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Productos.txt")

        ' Hacemos una lectura inicial para tener en aux una variable para comparar y evitar duplicidades
        lectura.leerProducto(1, "Productos.txt", categoria, nombre, tamaño, precio)
        aux = categoria
        ComboBox1.Items.Add(aux)
        ' Bucle for para leer e introducir todos las categorias existentes en 
        For contador As Integer = 2 To numeroRegistros
            ' Leemos
            lectura.leerProducto(contador, "Productos.txt", categoria, nombre, tamaño, precio)
            If (aux <> categoria) Then
                ComboBox1.Items.Add(categoria)
                aux = categoria
            End If

        Next

        ' Iniciamos StreamReader para leer del fichero
        '  Dim sr As New StreamReader(fs) o (fichero)
        ' Introducimos dentro de los ComboBox los datos actuales de productos.
        '  ComboBox1.Items.Add()


    End Sub

    ' Botón para pasar al formulario de confirmación ventas
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Accedemos al archivo auxiliar "PedidoDatosAuxiliar"
        Dim fichero As New FileStream("PedidoDatosAuxiliar.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)


        ' Escondemos esté formulario. 
        Me.Hide()
        ' Mostramos la pantalla de cobro
        Cobro.Show()
    End Sub

    ' Botón para añadir productos al listBox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Accedemos al archivo auxiliar "PedidoDatosAuxiliar"
        Dim fichero As New FileStream("PedidoDatosAuxiliar.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim sw As New StreamWriter(fichero)


    End Sub


End Class
