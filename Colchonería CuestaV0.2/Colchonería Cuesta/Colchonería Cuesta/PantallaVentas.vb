Public Class PantallaVentas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnGestionarPerfiles.Click
        ComprobarAdmin.Show()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lbAdmin.Text.Equals("*") Then
            btnGestionarPerfiles.Enabled = True
        Else
            btnGestionarPerfiles.Enabled = False
        End If
    End Sub

    ' Botón para pasar al formulario de confirmación ventas
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Cobro.Show()
    End Sub
End Class
