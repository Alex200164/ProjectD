' Clase con métodos enfocados a la escritura en ficheros
Imports System.IO

Public Class Escritura
    ' Estructura utilizada para introducir y leer registros en ficheros cuyo ambito sea de productos
    Structure Producto
        <VBFixedString(15)> Public Categoria As String
        <VBFixedString(15)> Public NombreProducto As String
        <VBFixedString(8)> Public Tamaño As String
        Public Precio As Single

        ' Método utilizado para inicializar con valores por defecto
        Public Sub defaultProducto()
            Categoria = "null"
            NombreProducto = "null"
            Tamaño = "null"
            Precio = 0.00
        End Sub

    End Structure

    ' Estructura utilizada para introducir y leer listBox en ficheros cuyo ambito sea de productos
    Structure Producto_ListBox
        <VBFixedString(46)> Public Columna As String

        ' Método utilizado para inicializar con valores por defecto
        Public Sub defaultProducto_ListBox()
            Columna = "null"
        End Sub

    End Structure

    ' Escribir un registro de producto, en un fichero de nuestra elección
    Public Sub escribirProducto(ByVal numeroRegistro As Integer, ByVal nombreFichero As String,
                                 ByVal categoria As String, ByVal nombre As String,
                                 ByVal tamaño As String, ByVal precio As Single)
        ' En caso de que no exista el fichero, lo creamos
        Dim fichero As New FileStream(nombreFichero, FileMode.OpenOrCreate, FileAccess.Write)
        ' Cerramos el flujo de datos
        fichero.Close()

        ' Preparamos la estructura de datos para estructurar el registro
        Dim estructura As New Producto
        With estructura
            .Categoria = categoria
            .NombreProducto = nombre
            .Tamaño = tamaño
            .Precio = precio
        End With

        ' Abrimos flujo de datos
        FileOpen(1, nombreFichero, OpenMode.Random, OpenShare.Shared, OpenAccess.Write, 42)
        ' Introducimos el registro
        FilePut(1, estructura, numeroRegistro)
        ' Cerramos el flujo de datos
        FileClose(1)
    End Sub

    ' Utilizado para introducir en un fichero las columnas de un listBox
    Public Sub escribirListaListBox(ByVal numeroRegistro As Integer, ByVal nombreFichero As String, ByVal columnaListBox As String)
        ' En caso de que no exista el fichero, lo creamos
        Dim fichero As New FileStream(nombreFichero, FileMode.OpenOrCreate, FileAccess.Write)
        ' Cerramos el flujo de datos
        fichero.Close()

        ' Preparamos la estructura de datos para estructurar el registro
        Dim estructura As New Producto_ListBox
        With estructura
            .Columna = columnaListBox
        End With

        ' Abrimos flujo de datos
        FileOpen(1, nombreFichero, OpenMode.Random, OpenShare.Shared, OpenAccess.Write, 46)
        ' Introducimos el registro
        FilePut(1, estructura, numeroRegistro)
        ' Cerramos el flujo de datos
        FileClose(1)

    End Sub


End Class

' Clase con métodos enfocados a la lectura de ficheros
Public Class Lectura
    ' Estructura utilizada para introducir y leer registros en ficheros cuyo ambito sea de productos
    Structure Producto
        <VBFixedString(15)> Public Categoria As String
        <VBFixedString(15)> Public NombreProducto As String
        <VBFixedString(8)> Public Tamaño As String
        Public Precio As Single

        ' Método utilizado para inicializar con valores por defecto
        Public Sub defaultProducto()
            Categoria = "null"
            NombreProducto = "null"
            Tamaño = "null"
            Precio = 0.00
        End Sub

    End Structure

    ' Estructura utilizada para introducir y leer listBox en ficheros cuyo ambito sea de productos
    Structure Producto_ListBox
        <VBFixedString(46)> Public Columna As String

        ' Método utilizado para inicializar con valores por defecto
        Public Sub defaultProducto_ListBox()
            Columna = "null"
        End Sub

    End Structure

    ' Método que devuelve el número de registros que se encuentran en un fichero.
    Public Function numeroRegistros(ByVal nombreFichero As String)
        ' En caso de que no exista el fichero, lo creamos
        Dim fichero As New FileStream(nombreFichero, FileMode.OpenOrCreate, FileAccess.Read)
        Dim longitud As Integer = fichero.Length
        longitud = longitud / 42
        fichero.Close()
        Return longitud
    End Function

    ' Leer de un registro de producto, en un fichero de nuestra elección
    ' Si en el número de registro introducimos una '*' leera todos 
    Public Sub leerProducto(ByVal numeroRegistro As Integer, ByVal nombreFichero As String,
                                 ByRef categoria As String, ByRef nombre As String,
                                 ByRef tamaño As String, ByRef precio As Single)
        ' En caso de que no exista el fichero, lo creamos
        Dim fichero As New FileStream(nombreFichero, FileMode.OpenOrCreate, FileAccess.Read)
        ' Cerramos el flujo de datos
        fichero.Close()

        ' Preparamos la estructura y la inicializamos con datos por defecto
        Dim estructura As Producto
        estructura.defaultProducto()

        ' Abrimos flujo de datos
        FileOpen(1, nombreFichero, OpenMode.Random, OpenShare.Shared, OpenAccess.Read, 42)

        ' Leemos del registro
        FileGet(1, estructura, numeroRegistro)

        ' Introducimos los datos en las variables que se nos han entregado por parámetro
        categoria = estructura.Categoria
        nombre = estructura.NombreProducto
        tamaño = estructura.Tamaño
        precio = estructura.Precio
        ' Cerramos el flujo de datos
        FileClose(1)
    End Sub

    Public Sub leerProducto_ListBox(ByVal numeroRegistro As Integer, ByVal nombreFichero As String,
                                 ByRef columna As String)
        ' En caso de que no exista el fichero, lo creamos
        Dim fichero As New FileStream(nombreFichero, FileMode.OpenOrCreate, FileAccess.Read)
        ' Cerramos el flujo de datos
        fichero.Close()

        ' Preparamos la estructura y la inicializamos con datos por defecto
        Dim estructura As Producto_ListBox
        estructura.defaultProducto_ListBox()

        ' Abrimos flujo de datos
        FileOpen(1, nombreFichero, OpenMode.Random, OpenShare.Shared, OpenAccess.Read, 46)

        ' Leemos del registro
        FileGet(1, estructura, numeroRegistro)

        ' Introducimos los datos en las variables que se nos han entregado por parámetro
        columna = estructura.Columna
        ' Cerramos el flujo de datos
        FileClose(1)
    End Sub


End Class

' Clase con métodos enfocados a la creación de ficheros
Public Class Creacion




End Class
