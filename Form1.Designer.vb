<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisor))
        Me.PicMostrarImagen = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnSeleccionarImagen = New System.Windows.Forms.Button()
        Me.ofdSeleccionarImagen = New System.Windows.Forms.OpenFileDialog()
        Me.btnAgrandar = New System.Windows.Forms.Button()
        Me.btnReducir = New System.Windows.Forms.Button()
        Me.btnDibujar = New System.Windows.Forms.Button()
        CType(Me.PicMostrarImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicMostrarImagen
        '
        Me.PicMostrarImagen.Image = CType(resources.GetObject("PicMostrarImagen.Image"), System.Drawing.Image)
        Me.PicMostrarImagen.Location = New System.Drawing.Point(20, 18)
        Me.PicMostrarImagen.Margin = New System.Windows.Forms.Padding(5)
        Me.PicMostrarImagen.Name = "PicMostrarImagen"
        Me.PicMostrarImagen.Size = New System.Drawing.Size(335, 331)
        Me.PicMostrarImagen.TabIndex = 5
        Me.PicMostrarImagen.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Location = New System.Drawing.Point(374, 89)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(59, 54)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnSeleccionarImagen
        '
        Me.btnSeleccionarImagen.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSeleccionarImagen.BackgroundImage = CType(resources.GetObject("btnSeleccionarImagen.BackgroundImage"), System.Drawing.Image)
        Me.btnSeleccionarImagen.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSeleccionarImagen.Location = New System.Drawing.Point(374, 18)
        Me.btnSeleccionarImagen.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSeleccionarImagen.Name = "btnSeleccionarImagen"
        Me.btnSeleccionarImagen.Size = New System.Drawing.Size(59, 61)
        Me.btnSeleccionarImagen.TabIndex = 3
        Me.btnSeleccionarImagen.UseVisualStyleBackColor = False
        '
        'ofdSeleccionarImagen
        '
        Me.ofdSeleccionarImagen.FileName = "OpenFileDialog1"
        Me.ofdSeleccionarImagen.Filter = "Archivos de mapa de bits|*.BMP|JPEG|*.JPG"
        Me.ofdSeleccionarImagen.Title = "Seleccionar Imagen"
        '
        'btnAgrandar
        '
        Me.btnAgrandar.BackColor = System.Drawing.Color.IndianRed
        Me.btnAgrandar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgrandar.Location = New System.Drawing.Point(363, 151)
        Me.btnAgrandar.Name = "btnAgrandar"
        Me.btnAgrandar.Size = New System.Drawing.Size(32, 31)
        Me.btnAgrandar.TabIndex = 6
        Me.btnAgrandar.Text = "˄"
        Me.btnAgrandar.UseVisualStyleBackColor = False
        '
        'btnReducir
        '
        Me.btnReducir.BackColor = System.Drawing.Color.IndianRed
        Me.btnReducir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReducir.Location = New System.Drawing.Point(401, 151)
        Me.btnReducir.Name = "btnReducir"
        Me.btnReducir.Size = New System.Drawing.Size(32, 31)
        Me.btnReducir.TabIndex = 7
        Me.btnReducir.Text = "˅"
        Me.btnReducir.UseVisualStyleBackColor = False
        '
        'btnDibujar
        '
        Me.btnDibujar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDibujar.BackgroundImage = CType(resources.GetObject("btnDibujar.BackgroundImage"), System.Drawing.Image)
        Me.btnDibujar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDibujar.Location = New System.Drawing.Point(374, 190)
        Me.btnDibujar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDibujar.Name = "btnDibujar"
        Me.btnDibujar.Size = New System.Drawing.Size(59, 61)
        Me.btnDibujar.TabIndex = 8
        Me.btnDibujar.UseVisualStyleBackColor = False
        '
        'FrmVisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(438, 362)
        Me.Controls.Add(Me.btnDibujar)
        Me.Controls.Add(Me.btnReducir)
        Me.Controls.Add(Me.btnAgrandar)
        Me.Controls.Add(Me.PicMostrarImagen)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSeleccionarImagen)
        Me.Font = New System.Drawing.Font("Book Antiqua", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmVisor"
        Me.Text = "Visor de Images 2.0"
        CType(Me.PicMostrarImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicMostrarImagen As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnSeleccionarImagen As Button
    Friend WithEvents ofdSeleccionarImagen As OpenFileDialog
    Friend WithEvents btnAgrandar As Button
    Friend WithEvents btnReducir As Button
    Friend WithEvents btnDibujar As Button
End Class
