Imports System.IO


' Gestionar que no se repita la combinación nombre usuario y codigo.
' Gestionar, en información de usuario,a la hora de buscar, que tengan un ID, porque puede que no basten
' nombres y apellidos para diferenciar empleados.

' Permitir máximo 100 caracteres en el textbox multiline/descripción.


' lo de seleccionar nombre del listbox y que se muestre información en el textbox del usuario
' puede que sea un poco complejo
' otra opción es en el menuStrip dar la opción de cargar archivos y ya está.
' Cada usuario tendría su fichero y listo. Tampoco serían tantos, así que no es gran problema.
' Si sigo con la idea del listbox, pensar en un ID, porque no puedo buscar en el .txt de accesoDatos por nombre ya que
' podrían existir dos iguales.

Public Class GestionPerfiles
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GestionPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fichero As String = "datosAcceso.txt"
        Dim accesoDatos As New FileStream(fichero, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(accesoDatos)
        Dim bool As Boolean = False
        Dim nombre As String
        ' Vamos a colocar de forma dinámica los nombres de los usuarios. 
        ' El admin podrá hacer click en items la lista creada, esto habilitará
        ' los botones del menuStrip pertinentes.
        ' Bucle "infinito" hasta que sea true.
        While sr.Peek > 0
            nombre = sr.ReadLine

            ' Se añade al listbox el nombre del usuario.
            If Not IsNumeric(nombre) Then
                If Not nombre.Equals("*") Then
                    listboxUsuarios.Items.Add(nombre)
                End If
            End If

        End While

    End Sub

    Private Sub listboxUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxUsuarios.SelectedIndexChanged
        Dim fichero As String = "datosAcceso.txt"
        Dim accesoDatos As New FileStream(fichero, FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(accesoDatos)
        Dim texto As String
        ' Booleano usado para salir de bucle infinito.
        Dim bool As Boolean = False
        ' Vamos a ver si el nombre seleccionado del listbox tiene una coincidencia en el archivo

        ' datosAcceso. Si la tiene, leemos hasta la marca que marca el final de los datos de ese usuario.

        ' datosAcceso. Si la tiene, leemos hasta le marca que marca el final de los datos de ese usuario.

        While sr.Peek > 0
            nombre = sr.ReadLine
            If (nombre.Equals(listboxUsuarios.SelectedItem)) Then
                While bool = False
                    texto = sr.ReadLine

                    If texto.Equals("^") Then
                        ' Si encontramos el carácter especial que marca el final de la información del usuario
                        ' nos salimos del bucle.
                        bool = True
                    Else
                        txtDetalles.Text = texto
                    End If
                End While
            End If


            ' Se añade al listbox el nombre del usuario.
            listboxUsuarios.Items.Add(nombre)

        End While
    End Sub

    Private Sub lbUsuarios_Click(sender As Object, e As EventArgs) Handles lbUsuarios.Click

    End Sub
End Class