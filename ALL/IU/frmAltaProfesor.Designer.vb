<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaProfesor))
        Me.pnlPrincipal = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblMaterno = New System.Windows.Forms.Label
        Me.txtMaterno = New System.Windows.Forms.TextBox
        Me.UcLabelRC2 = New ControlAsistencias.ucLabelRC
        Me.lblPaterno = New System.Windows.Forms.Label
        Me.txtPaterno = New System.Windows.Forms.TextBox
        Me.UcLabelRC6 = New ControlAsistencias.ucLabelRC
        Me.cboDivision = New System.Windows.Forms.ComboBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.UcLabelRC11 = New ControlAsistencias.ucLabelRC
        Me.UcLabelRC1 = New ControlAsistencias.ucLabelRC
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAltaPacienteLive = New DevComponents.DotNetBar.BubbleButton
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
        Me.pnlPrincipal.Size = New System.Drawing.Size(732, 528)
        Me.pnlPrincipal.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblMaterno)
        Me.Panel2.Controls.Add(Me.txtMaterno)
        Me.Panel2.Controls.Add(Me.UcLabelRC2)
        Me.Panel2.Controls.Add(Me.lblPaterno)
        Me.Panel2.Controls.Add(Me.txtPaterno)
        Me.Panel2.Controls.Add(Me.UcLabelRC6)
        Me.Panel2.Controls.Add(Me.cboDivision)
        Me.Panel2.Controls.Add(Me.lblNombre)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.UcLabelRC11)
        Me.Panel2.Controls.Add(Me.UcLabelRC1)
        Me.Panel2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Panel2.Location = New System.Drawing.Point(2, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 446)
        Me.Panel2.TabIndex = 0
        '
        'lblMaterno
        '
        Me.lblMaterno.AutoSize = True
        Me.lblMaterno.BackColor = System.Drawing.Color.Transparent
        Me.lblMaterno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterno.ForeColor = System.Drawing.Color.LightCoral
        Me.lblMaterno.Location = New System.Drawing.Point(105, 180)
        Me.lblMaterno.Name = "lblMaterno"
        Me.lblMaterno.Size = New System.Drawing.Size(97, 22)
        Me.lblMaterno.TabIndex = 6
        Me.lblMaterno.Text = "A. Materno"
        Me.lblMaterno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMaterno
        '
        Me.txtMaterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtMaterno.ForeColor = System.Drawing.Color.DimGray
        Me.txtMaterno.Location = New System.Drawing.Point(99, 181)
        Me.txtMaterno.Multiline = True
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(529, 22)
        Me.txtMaterno.TabIndex = 7
        '
        'UcLabelRC2
        '
        Me.UcLabelRC2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC2.Location = New System.Drawing.Point(97, 176)
        Me.UcLabelRC2.Name = "UcLabelRC2"
        Me.UcLabelRC2.Size = New System.Drawing.Size(533, 31)
        Me.UcLabelRC2.TabIndex = 8
        Me.UcLabelRC2.Texthaschanged = False
        '
        'lblPaterno
        '
        Me.lblPaterno.AutoSize = True
        Me.lblPaterno.BackColor = System.Drawing.Color.Transparent
        Me.lblPaterno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaterno.ForeColor = System.Drawing.Color.LightCoral
        Me.lblPaterno.Location = New System.Drawing.Point(106, 110)
        Me.lblPaterno.Name = "lblPaterno"
        Me.lblPaterno.Size = New System.Drawing.Size(110, 22)
        Me.lblPaterno.TabIndex = 3
        Me.lblPaterno.Text = "A. Paterno..."
        Me.lblPaterno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPaterno
        '
        Me.txtPaterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtPaterno.ForeColor = System.Drawing.Color.DimGray
        Me.txtPaterno.Location = New System.Drawing.Point(100, 111)
        Me.txtPaterno.Multiline = True
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(529, 22)
        Me.txtPaterno.TabIndex = 4
        '
        'UcLabelRC6
        '
        Me.UcLabelRC6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC6.Location = New System.Drawing.Point(98, 106)
        Me.UcLabelRC6.Name = "UcLabelRC6"
        Me.UcLabelRC6.Size = New System.Drawing.Size(533, 31)
        Me.UcLabelRC6.TabIndex = 5
        Me.UcLabelRC6.Texthaschanged = False
        '
        'cboDivision
        '
        Me.cboDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.cboDivision.ForeColor = System.Drawing.Color.DimGray
        Me.cboDivision.FormattingEnabled = True
        Me.cboDivision.Location = New System.Drawing.Point(101, 257)
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Size = New System.Drawing.Size(525, 28)
        Me.cboDivision.TabIndex = 9
        Me.cboDivision.Visible = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.LightCoral
        Me.lblNombre.Location = New System.Drawing.Point(105, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(188, 22)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre del profesor..."
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
        Me.txtNombre.Location = New System.Drawing.Point(99, 41)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(529, 22)
        Me.txtNombre.TabIndex = 2
        '
        'UcLabelRC11
        '
        Me.UcLabelRC11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC11.Location = New System.Drawing.Point(97, 36)
        Me.UcLabelRC11.Name = "UcLabelRC11"
        Me.UcLabelRC11.Size = New System.Drawing.Size(533, 31)
        Me.UcLabelRC11.TabIndex = 1
        Me.UcLabelRC11.Texthaschanged = False
        '
        'UcLabelRC1
        '
        Me.UcLabelRC1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC1.Location = New System.Drawing.Point(97, 256)
        Me.UcLabelRC1.Name = "UcLabelRC1"
        Me.UcLabelRC1.Size = New System.Drawing.Size(533, 31)
        Me.UcLabelRC1.TabIndex = 10
        Me.UcLabelRC1.Tag = " "
        Me.UcLabelRC1.Texthaschanged = False
        Me.UcLabelRC1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
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
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.BackColor = System.Drawing.Color.Transparent
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdAceptar.FlatAppearance.BorderSize = 0
        Me.cmdAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmdAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdAceptar.ForeColor = System.Drawing.Color.White
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAceptar.Location = New System.Drawing.Point(588, 12)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(70, 55)
        Me.cmdAceptar.TabIndex = 535
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAceptar.UseVisualStyleBackColor = False
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
        Me.lblTitulo.Size = New System.Drawing.Size(234, 31)
        Me.lblTitulo.TabIndex = 534
        Me.lblTitulo.Text = "Alta de profesores"
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
        'frmAltaProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(730, 531)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAltaProfesor"
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
    Friend WithEvents UcLabelRC1 As ControlAsistencias.ucLabelRC
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents UcLabelRC11 As ControlAsistencias.ucLabelRC
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaterno As System.Windows.Forms.Label
    Friend WithEvents txtPaterno As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC6 As ControlAsistencias.ucLabelRC
    Friend WithEvents lblMaterno As System.Windows.Forms.Label
    Friend WithEvents txtMaterno As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC2 As ControlAsistencias.ucLabelRC
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox

End Class
