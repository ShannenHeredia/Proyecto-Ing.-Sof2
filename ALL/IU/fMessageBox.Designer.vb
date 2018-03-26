<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMessageBox
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMessageBox))
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.pnlImagen = New System.Windows.Forms.Panel
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.gpoMensajes = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLine = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.recOk = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.recCancelar = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.Panel2.SuspendLayout()
        Me.gpoMensajes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.DimGray
        Me.lblMensaje.Location = New System.Drawing.Point(19, 146)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(318, 164)
        Me.lblMensaje.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.DimGray
        Me.lblTitulo.Location = New System.Drawing.Point(113, 39)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(237, 42)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlImagen
        '
        Me.pnlImagen.BackColor = System.Drawing.Color.Transparent
        Me.pnlImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlImagen.Location = New System.Drawing.Point(17, 23)
        Me.pnlImagen.Name = "pnlImagen"
        Me.pnlImagen.Size = New System.Drawing.Size(89, 78)
        Me.pnlImagen.TabIndex = 1
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.BackColor = System.Drawing.Color.White
        Me.cmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdAceptar.FlatAppearance.BorderSize = 0
        Me.cmdAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cmdAceptar.ForeColor = System.Drawing.Color.DimGray
        Me.cmdAceptar.Location = New System.Drawing.Point(273, 435)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 33)
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.pnlImagen)
        Me.Panel2.Controls.Add(Me.lblMensaje)
        Me.Panel2.Controls.Add(Me.lblTitulo)
        Me.Panel2.Location = New System.Drawing.Point(19, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 338)
        Me.Panel2.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(2, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(353, 1)
        Me.Label2.TabIndex = 381
        '
        'gpoMensajes
        '
        Me.gpoMensajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoMensajes.Controls.Add(Me.Label3)
        Me.gpoMensajes.Controls.Add(Me.cmdCerrar)
        Me.gpoMensajes.Controls.Add(Me.Label1)
        Me.gpoMensajes.Controls.Add(Me.lblLine)
        Me.gpoMensajes.Controls.Add(Me.cmdAceptar)
        Me.gpoMensajes.Controls.Add(Me.Panel2)
        Me.gpoMensajes.Controls.Add(Me.cmdCancelar)
        Me.gpoMensajes.Controls.Add(Me.ShapeContainer2)
        Me.gpoMensajes.Location = New System.Drawing.Point(0, -6)
        Me.gpoMensajes.Name = "gpoMensajes"
        Me.gpoMensajes.Size = New System.Drawing.Size(399, 490)
        Me.gpoMensajes.TabIndex = 379
        Me.gpoMensajes.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Helvetica-Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(46, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 29)
        Me.Label3.TabIndex = 389
        Me.Label3.Text = "Mensajes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.BackColor = System.Drawing.Color.Transparent
        Me.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCerrar.FlatAppearance.BorderSize = 0
        Me.cmdCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmdCerrar.ForeColor = System.Drawing.Color.White
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCerrar.Location = New System.Drawing.Point(346, 6)
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCerrar.Size = New System.Drawing.Size(52, 45)
        Me.cmdCerrar.TabIndex = 390
        Me.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(375, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 338)
        Me.Label1.TabIndex = 381
        '
        'lblLine
        '
        Me.lblLine.BackColor = System.Drawing.Color.Silver
        Me.lblLine.Location = New System.Drawing.Point(23, 395)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(353, 3)
        Me.lblLine.TabIndex = 380
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.White
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cmdCancelar.ForeColor = System.Drawing.Color.DimGray
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(156, 435)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(93, 35)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.recOk, Me.recCancelar})
        Me.ShapeContainer2.Size = New System.Drawing.Size(393, 471)
        Me.ShapeContainer2.TabIndex = 379
        Me.ShapeContainer2.TabStop = False
        '
        'recOk
        '
        Me.recOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recOk.BackColor = System.Drawing.Color.White
        Me.recOk.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recOk.BorderColor = System.Drawing.Color.DodgerBlue
        Me.recOk.CornerRadius = 10
        Me.recOk.Location = New System.Drawing.Point(261, 414)
        Me.recOk.Name = "recOk"
        Me.recOk.Size = New System.Drawing.Size(115, 44)
        '
        'recCancelar
        '
        Me.recCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recCancelar.BackColor = System.Drawing.Color.White
        Me.recCancelar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recCancelar.BorderColor = System.Drawing.Color.Crimson
        Me.recCancelar.CornerRadius = 10
        Me.recCancelar.Location = New System.Drawing.Point(139, 414)
        Me.recCancelar.Name = "recCancelar"
        Me.recCancelar.Size = New System.Drawing.Size(115, 44)
        '
        'fMessageBox
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(399, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.gpoMensajes)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fMessageBox"
        Me.Opacity = 0.95
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.gpoMensajes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents recOk As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents pnlImagen As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents gpoMensajes As System.Windows.Forms.GroupBox
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents recCancelar As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents cmdCerrar As System.Windows.Forms.Button
End Class
