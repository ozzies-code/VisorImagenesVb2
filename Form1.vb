Public Class FrmVisor
    Private Sub btnSeleccionarImagen_Click(sender As Object, e As EventArgs) Handles btnSeleccionarImagen.Click

        'Mostrar el cuadro de diálogo para seleccionar una imagen

        If ofdSeleccionarImagen.ShowDialog = DialogResult.OK Then
            'Mostrar la imagen seleccionada en el PictureBox
            PicMostrarImagen.Image = Image.FromFile(ofdSeleccionarImagen.FileName)
            'Mostrar el nombre del archivo como titulo del formulario
            Me.Text = "Visor de Imagenes(" & ofdSeleccionarImagen.FileName & ")"
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'Cerrar la ventana y salir de la aplicacion
        Me.Close()
    End Sub

    Private Sub btnAgrandar_Click(sender As Object, e As EventArgs) Handles btnAgrandar.Click
        Me.Width = Me.Width + 20
        Me.Height = Me.Height + 20
        'Aumenta el ancho y alto
    End Sub

    Private Sub btnReducir_Click(sender As Object, e As EventArgs) Handles btnReducir.Click
        Me.Width = Me.Width - 20
        Me.Height = Me.Height - 20
        'Reduce el ancho y alto
    End Sub

    Private Sub btnDibujar_Click(sender As Object, e As EventArgs) Handles btnDibujar.Click
        Dim objGraphics As Graphics
        objGraphics = Me.CreateGraphics
        objGraphics.Clear(SystemColors.Control)
        objGraphics.DrawRectangle(Pens.Blue, PicMostrarImagen.Left - 1,
PicMostrarImagen.Top - 1, PicMostrarImagen.Width + 1, PicMostrarImagen.Height + 1)
        objGraphics.Dispose() 'destruye el objeto graphics liberando la memoria
        'Dibuja un rectangulo alrededor del PictureBox de color azul
    End Sub
End Class
