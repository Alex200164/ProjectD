﻿Public Class Cobro
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
    End Sub

    ' Botón para finalizar e imprimir el recibo
    Private Sub btn_finalizarImprimir_Click(sender As Object, e As EventArgs) Handles btn_finalizarImprimir.Click

    End Sub
End Class