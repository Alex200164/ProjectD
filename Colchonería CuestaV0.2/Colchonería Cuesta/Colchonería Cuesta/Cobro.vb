Imports System.IO
Imports System.Drawing.Printing

Public Class Cobro

    Dim banderaPago As Boolean = False

    Public stringTicket As String = ""

    Public numeroRegistros As Single = 0

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
        Label_numDevolver.Text = 0

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Cobro_Aux.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Cobro_Aux.txt")
        ' Contendrá el valor de los registros que extraigamos del fichero Cobro_Aux.txt
        Dim columna As String = ""

        lectura.leerProducto_ListBox(numeroRegistros, "Cobro_Aux.txt", columna)

        Dim aux As String = columna

        ' Asignamos al label el valor de aux (que es el precio total a pagar)
        Label3.Text = Trim(aux)

    End Sub

    ' Para imprimir
    Private Sub ticket(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

        ' Instanciamos la clase Lectura para acceder a los métodos que nos permitirán leer desde ficheros
        Dim lectura As New LecturaEscrituraArchivos.Lectura

        ' Accedemos al archivo "Cobro_Aux.txt" y extraemos el número de registros con los que cuenta
        Dim numeroRegistros As Integer = lectura.numeroRegistros("Cobro_Aux.txt")

        ' Contendrá el valor de los registros que extraigamos del fichero Cobro_Aux.txt
        Dim columna As String = ""
        ' Leemos
        lectura.leerProducto_ListBox(1, "Cobro_Aux.txt", columna)

        Dim espacios As Single = 120
        Dim incremento As Single = 25

        Dim estilo As String = "Arial"

        Dim auxIVA2 As Single = (Val(Label3.Text) * 0.21)

        Dim auxIVA As Single = Val(Label3.Text) - auxIVA2


        Dim auxStrinIVA As String = auxIVA

        ' Imprimimos Imagen

        ev.Graphics.DrawImage((PictureBox1.Image), 180, espacios, 220, 60)

        ' Imprimimos Texto
        espacios += 70
        ev.Graphics.DrawString("           Colchoneria CUESTA    ", New Font(estilo, 14, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("                Calle Vallehermoso, 42    ", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("                  Telef. 91 593 22 15    ", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("                  Telef. 605 689 166    ", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("Factura simplificada", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("Fecha: " + Now.ToLocalTime, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("Categoria    Nombre              tama.   Precio", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString(stringTicket, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        If (numeroRegistros >= 4) Then
            espacios += numeroRegistros * 18
        ElseIf (numeroRegistros < 4) Then
            espacios += numeroRegistros * 15
        End If
        ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("Subtotal:                                              " + auxStrinIVA, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("21% IVA", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("Total:                                                   " + Label3.Text, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("Cantidad entregada:                            " + TextBox_importe.Text, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("Cambio:                                               " + Label_numDevolver.Text, New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("      -------- Gracias por su visita --------           ", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("----------------------------------------------------------", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("            Colchonería CUESTA S.L.", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("                CIF: B83821652", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("            C/Fuencaral, 84, 28004", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)
        espacios += incremento
        ev.Graphics.DrawString("                  Madrid, Madrid", New Font(estilo, 12, FontStyle.Regular), Brushes.Black, 120, espacios)

        ev.HasMorePages = False
    End Sub

    ' Botón para finalizar e imprimir el recibo
    Private Sub btn_finalizarImprimir_Click(sender As Object, e As EventArgs) Handles btn_finalizarImprimir.Click

        If (ComboBox1.SelectedItem <> "Tarjeta") Then
            If (ComboBox1.SelectedItem <> "Efectivo") Then
                MsgBox("Debe seleccionar un método de pago. Operación abortada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Aviso")
                Return
            End If
        End If

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

        ' Borramos el fichero "Cobro_Aux.txt"
        My.Computer.FileSystem.DeleteFile("Cobro_Aux.txt")

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
            TextBox_importe.Text = Label3.Text
            banderaPago = False
        End If
        ' Pagar con efectivo
        If (ComboBox1.SelectedItem = "Efectivo") Then
            TextBox_importe.Show()
            banderaPago = True
        End If

    End Sub

End Class