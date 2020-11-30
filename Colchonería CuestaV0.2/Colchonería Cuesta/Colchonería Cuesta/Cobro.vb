Imports System.IO
Imports System.Drawing.Printing

Public Class Cobro

    Dim banderaPago As Boolean = False

    ' Botón cero
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox_importe.Text = TextBox_importe.Text + "0"
    End Sub

    ' Botón uno
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox_importe.Text = TextBox_importe.Text + "1"
    End Sub

    ' Botón dos
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox_importe.Text = TextBox_importe.Text + "2"
    End Sub

    ' Botón tres
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox_importe.Text = TextBox_importe.Text + "3"
    End Sub

    ' Botón cuatro
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox_importe.Text = TextBox_importe.Text + "4"
    End Sub

    ' Botón cinco
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox_importe.Text = TextBox_importe.Text + "5"
    End Sub

    ' Botón seis
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox_importe.Text = TextBox_importe.Text + "6"
    End Sub

    ' Botón siete
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox_importe.Text = TextBox_importe.Text + "7"
    End Sub

    ' Botón ocho
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox_importe.Text = TextBox_importe.Text + "8"
    End Sub

    ' Botón nueve
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox_importe.Text = TextBox_importe.Text + "9"
    End Sub

    ' Botón borrar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        TextBox_importe.Clear()
    End Sub

    ' Botón para introducir un punto
    Private Sub btn_ponerPunto_Click(sender As Object, e As EventArgs) Handles btn_ponerPunto.Click
        TextBox_importe.Text = TextBox_importe.Text + "."
    End Sub

    ' Se ejecuta al cargarse el formulario
    Private Sub Cobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_importe.Focus()

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Productos.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Cobro_Aux.txt")
        ' Contendrá el valor de los registros que extraigamos del fichero Cobro_Aux.txt
        Dim columna As String = ""

        lectura.leerProducto_ListBox(numeroRegistros, "Cobro_Aux.txt", columna)

        Dim aux As String = columna

        ' Asignamos al label el valor de aux (que es el precio total a pagar)
        Label3.Text = Trim(aux)

        ' Borramos el fichero "Cobro_Aux.txt"
        My.Computer.FileSystem.DeleteFile("Cobro_Aux.txt")

    End Sub

    ' Para imprimir
    Private Sub ticket(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

        ev.Graphics.DrawString("Colchoneria CUESTA", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 120)
        ev.Graphics.DrawString("Calle Vallehermoso, 42", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 150)
        ev.Graphics.DrawString("Telef. 91 593 22 15", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 180)
        ev.Graphics.DrawString("Telef. 605 689 166", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 210)
        ev.Graphics.DrawString("-------------------", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 240)

        ev.Graphics.DrawString("Fecha: 11-30-2020", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 270)
        ev.Graphics.DrawString("Hora: 21:15:31", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 300)

        ev.Graphics.DrawString("-------------------", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 330)

        ev.Graphics.DrawString("Cant. Nombre         Precio Total", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 360)
        ev.Graphics.DrawString("-------------------", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 390)

        ev.Graphics.DrawString("Producto", New Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 420)

        ev.Graphics.DrawString("-------------------", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 450)

        ev.Graphics.DrawString("Subtotal:", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 480)
        ev.Graphics.DrawString("21% IVA", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 510)

        ev.Graphics.DrawString("-------------------", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 540)

        ev.Graphics.DrawString("Total:     43000", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 570)

        ev.Graphics.DrawString("-------------------", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 600)

        ev.Graphics.DrawString("Cantidad entregada:  5000", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 630)
        ev.Graphics.DrawString("Cambio: 700", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 660)

        ev.Graphics.DrawString("-------------------", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 690)
        ev.Graphics.DrawString("---- Gracias por su visita ----", New Font("Courier new", 12, FontStyle.Regular), Brushes.Black, 120, 720)
        ev.Graphics.DrawString("-------------------", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 750)
        ev.Graphics.DrawString("Colchonería CUESTA S.L.", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 780)
        ev.Graphics.DrawString("CIF: B83821652", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 810)
        ev.Graphics.DrawString("C/Fuencaral, 84, 28004", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 840)
        ev.Graphics.DrawString("Madrid, Madrid", New Font("Courier new", 14, FontStyle.Regular), Brushes.Black, 120, 870)


        ev.HasMorePages = False

    End Sub

    ' Botón para finalizar e imprimir el recibo
    Private Sub btn_finalizarImprimir_Click(sender As Object, e As EventArgs) Handles btn_finalizarImprimir.Click


        ' Imprimir
        AddHandler PrintDocument1.PrintPage, AddressOf Me.ticket
        PrintDocument1.PrinterSettings.PrintFileName() = "PRUEBA"
        PrintDocument1.Print()


        If (Val(Label_devolver.Text) < 0) Then
                ' Comprobamos que el cliente ha pagado lo suficiente para cubrir el precio.
                ' En caso contrario avisamos con un mensaje 
                MsgBox("El dinero aportado por el cliente es insuficiente.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Aviso")
                Return
            End If


            ' Conexión con el archivo 
            ' Dim Variable As New FileStream("")
            ' Imprimir...

            ' Cerramos la pantalla de gestión de cobros
            Me.Close()
        ' Volvemos a la pantalla de ventas.
        PantallaVentas.Show()
    End Sub

    ' Al pulsar el botón salir del menú
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Cerramos está pantalla
        Me.Close()
        ' Mostramos de nuevo la pantallaVentas
        PantallaVentas.Show()
    End Sub

    Private Sub TextBox_importe_TextChanged(sender As Object, e As EventArgs) Handles TextBox_importe.TextChanged
        If (banderaPago = True) Then
            ' Se realiza el calculo del importe a devolver por parte del vendedor
            Label_numDevolver.Text = Val(TextBox_importe.Text) - Val(Label3.Text)
        End If

    End Sub

    ' Cuando se produzca un cambio en el comboBox...
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Pagar con tarjeta
        If (ComboBox1.SelectedItem = "Tarjeta") Then
            Label_numDevolver.Text = "0"
            TextBox_importe.Hide()
            banderaPago = False
        End If
        ' Pagar con efectivo
        If (ComboBox1.SelectedItem = "Efectivo") Then
            TextBox_importe.Show()
            banderaPago = True
        End If

    End Sub

End Class