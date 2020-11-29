Module Productos
    Structure Productos
        <VBFixedString(15)> Public Categoria As String
        <VBFixedString(15)> Public NombreProducto As String
        <VBFixedString(8)> Public Tamaño As String
        Public Precio As Integer

        ' Método utilizado para inicializar con valores por defecto
        Public Sub defaultProducto()
            Categoria = "null"
            NombreProducto = "null"
            Tamaño = "null"
            Precio = 0
        End Sub
    End Structure
    Public producto As New Productos
End Module
