Imports System.IO

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

        ' Accedemos al archivo auxiliar "PedidoDatosAuxiliar" para leer
        Dim fichero As New FileStream("Productos.txt", FileMode.OpenOrCreate, FileAccess.Read)
        ' Iniciamos StreamReader para leer del fichero
        Dim sr As New StreamReader(fs) o (fichero)
        ' Introducimos dentro de los ComboBox los datos actuales de productos.
        ComboBox1.Items.Add()


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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged












    End Sub
End Class
