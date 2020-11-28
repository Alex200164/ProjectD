Module Usuarios
    Structure Usuarios
        <VBFixedString(12)> Dim usuario As String
        Dim contrasena As Integer
        <VBFixedString(20)> Dim nombre As String
        <VBFixedString(20)> Dim apellidos As String
        <VBFixedString(20)> Dim direccion As String
        Dim telefono As Integer
        Dim admin As String
    End Structure
    Public usuario As New Usuarios
End Module
