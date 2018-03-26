<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDivision
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MdiParent = frmPrincipal
        frmPrincipal.Show()
    End Sub

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDivision))
        Me.pnlPrincipal = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.UcLabelRC11 = New ControlAsistencias.ucLabelRC
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAltaPacienteLive = New DevComponents.DotNetBar.BubbleButton
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.pnlPrincipal.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlPrincipal.Controls.Add(Me.Panel2)
        Me.pnlPrincipal.Controls.Add(Me.Panel1)
        Me.pnlPrincipal.Location = New System.Drawing.Point(-1, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(732, 397)
        Me.pnlPrincipal.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cmdAceptar)
        Me.Panel2.Controls.Add(Me.lblNombre)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.UcLabelRC11)
        Me.Panel2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Panel2.Location = New System.Drawing.Point(2, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 288)
        Me.Panel2.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.LightCoral
        Me.lblNombre.Location = New System.Drawing.Point(105, 98)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(197, 22)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre de la división..."
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtNombre.ForeColor = System.Drawing.Color.DimGray
        Me.txtNombre.Location = New System.Drawing.Point(99, 99)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(529, 22)
        Me.txtNombre.TabIndex = 2
        '
        'UcLabelRC11
        '
        Me.UcLabelRC11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC11.Location = New System.Drawing.Point(97, 94)
        Me.UcLabelRC11.Name = "UcLabelRC11"
        Me.UcLabelRC11.Size = New System.Drawing.Size(533, 31)
        Me.UcLabelRC11.TabIndex = 1
        Me.UcLabelRC11.Texthaschanged = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.cmdSalir)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 80)
        Me.Panel1.TabIndex = 388
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Location = New System.Drawing.Point(0, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(729, 1)
        Me.Label5.TabIndex = 1964
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.DimGray
        Me.lblTitulo.Location = New System.Drawing.Point(25, 22)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(196, 31)
        Me.lblTitulo.TabIndex = 534
        Me.lblTitulo.Text = "Alta de división"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.BackColor = System.Drawing.Color.Transparent
        Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSalir.FlatAppearance.BorderSize = 0
        Me.cmdSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmdSalir.ForeColor = System.Drawing.Color.DarkGray
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSalir.Location = New System.Drawing.Point(658, 12)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(70, 55)
        Me.cmdSalir.TabIndex = 379
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'cmdAltaPacienteLive
        '
        Me.cmdAltaPacienteLive.Image = CType(resources.GetObject("cmdAltaPacienteLive.Image"), System.Drawing.Image)
        Me.cmdAltaPacienteLive.ImageLarge = CType(resources.GetObject("cmdAltaPacienteLive.ImageLarge"), System.Drawing.Image)
        Me.cmdAltaPacienteLive.Name = "cmdAltaPacienteLive"
        Me.cmdAltaPacienteLive.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlP
        Me.cmdAltaPacienteLive.Tag = "Nuevo paciente"
        Me.cmdAltaPacienteLive.TagString = "Nuevo paciente"
        Me.cmdAltaPacienteLive.TooltipText = "Alta paciente"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdAceptar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.cmdAceptar.FlatAppearance.BorderSize = 0
        Me.cmdAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cmdAceptar.ForeColor = System.Drawing.Color.White
        Me.cmdAceptar.Location = New System.Drawing.Point(281, 180)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(167, 43)
        Me.cmdAceptar.TabIndex = 1762
        Me.cmdAceptar.Text = "&Guardar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'frmDivision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(730, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDivision"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.pnlPrincipal.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents cmdAltaPacienteLive As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Public WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents UcLabelRC11 As ControlAsistencias.ucLabelRC
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button

End Class
