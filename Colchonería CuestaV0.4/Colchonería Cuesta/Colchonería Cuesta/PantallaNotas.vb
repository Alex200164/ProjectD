Imports System.IO
Public Class PantallaNotas


    Private Sub PantallaNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        txtNotas.Clear()
        ' Dim fs As New FileStream("Notas.txt", FileMode.Create, FileAccess.Write)
        ' Dim sw As New StreamWriter(fs)

        ' sw.WriteLine(txtNotas.Text)

        ' sw.Close()
        ' fs.Close()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim fs As New FileStream("Notas.txt", FileMode.Create, FileAccess.Write)
        Dim sw As New StreamWriter(fs)

        sw.WriteLine(txtNotas.Text)

        sw.Close()
        fs.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Me.Close()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim fs As New FileStream("Notas.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        ' Leemos todo el archivo y lo guardamos en el textbox.
        txtNotas.Text = sr.ReadToEnd
        sr.Close()
        fs.Close()




    End Sub


End Class