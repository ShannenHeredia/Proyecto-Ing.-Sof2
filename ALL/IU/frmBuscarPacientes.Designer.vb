<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmBuscarPacientes
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.MdiParent = frmPrincipal
        frmPrincipal.Show()
    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents lblRegistros As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarPacientes))
        Me.lblRegistros = New System.Windows.Forms.Label
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.ttInformacion = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.cmdAyuda = New System.Windows.Forms.Button
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.pnlFondo = New System.Windows.Forms.Panel
        Me.expPagar = New DevComponents.DotNetBar.ExpandablePanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.UcLabelRC11 = New ControlAsistencias.ucLabelRC
        Me.optGrupo = New System.Windows.Forms.RadioButton
        Me.optCodigo = New System.Windows.Forms.RadioButton
        Me.optEstudiante = New System.Windows.Forms.RadioButton
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.picBusqueda = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlDare = New System.Windows.Forms.Panel
        Me.pnlSubPanel = New System.Windows.Forms.Panel
        Me.lblTotal = New System.Windows.Forms.Label
        Me.DaRe = New Microsoft.VisualBasic.PowerPacks.DataRepeater
        Me.lblCodCarrera = New System.Windows.Forms.Label
        Me.lblGrupo = New System.Windows.Forms.Label
        Me.lblCodGrupo = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblMaterno = New System.Windows.Forms.Label
        Me.lblPaterno = New System.Windows.Forms.Label
        Me.picPaciente = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCarrera = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.lblNombreCompleto = New System.Windows.Forms.Label
        Me.lblCodAlumno = New System.Windows.Forms.Label
        Me.lblCodEspecie = New System.Windows.Forms.Label
        Me.lblFinadoLinea = New System.Windows.Forms.Label
        Me.picEditar = New System.Windows.Forms.PictureBox
        Me.lblTotal_ = New System.Windows.Forms.Label
        Me.lblPaciente = New System.Windows.Forms.Label
        Me.lblVertical3 = New System.Windows.Forms.Label
        Me.lblVertical4 = New System.Windows.Forms.Label
        Me.picMarcoCentroInf = New System.Windows.Forms.PictureBox
        Me.picMarcoIzqInf = New System.Windows.Forms.PictureBox
        Me.picMarcoDerInf = New System.Windows.Forms.PictureBox
        Me.picDemos = New System.Windows.Forms.PictureBox
        Me.gpbPreview = New System.Windows.Forms.GroupBox
        Me.pnlPreview = New System.Windows.Forms.Panel
        Me.lblPantherDerechos = New System.Windows.Forms.Label
        Me.lblMarcoInferior = New System.Windows.Forms.Label
        Me.lblMarcoIzquierdo = New System.Windows.Forms.Label
        Me.lblMarcoSuperior = New System.Windows.Forms.Label
        Me.lblMarcoDerecho = New System.Windows.Forms.Label
        Me.richPaciente = New DevComponents.DotNetBar.Controls.RichTextBoxEx
        Me.lblPreviewClinica = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.pnlImagenDeceso = New System.Windows.Forms.Panel
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.Uc_PanelDobleBuffer1 = New System.Windows.Forms.Panel
        Me.lblLineHorizontal10 = New System.Windows.Forms.Label
        Me.lblCorreoEmpreza = New System.Windows.Forms.Label
        Me.lblPara = New System.Windows.Forms.Label
        Me.lblCorreoPaciente = New System.Windows.Forms.Label
        Me.lblDe = New System.Windows.Forms.Label
        Me.cmdCerrarPreview = New System.Windows.Forms.Button
        Me.pnlFondo.SuspendLayout()
        Me.expPagar.SuspendLayout()
        CType(Me.picBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDare.SuspendLayout()
        Me.pnlSubPanel.SuspendLayout()
        Me.DaRe.ItemTemplate.SuspendLayout()
        Me.DaRe.SuspendLayout()
        CType(Me.picPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMarcoCentroInf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMarcoIzqInf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMarcoDerInf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDemos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbPreview.SuspendLayout()
        Me.pnlPreview.SuspendLayout()
        Me.pnlImagenDeceso.SuspendLayout()
        Me.Uc_PanelDobleBuffer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRegistros
        '
        Me.lblRegistros.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistros.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRegistros.ForeColor = System.Drawing.Color.Blue
        Me.lblRegistros.Location = New System.Drawing.Point(24, 313)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRegistros.Size = New System.Drawing.Size(495, 15)
        Me.lblRegistros.TabIndex = 0
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Gainsboro
        Me.RectangleShape2.CornerRadius = 20
        Me.RectangleShape2.Location = New System.Drawing.Point(5, 5)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(118, 116)
        '
        'ttInformacion
        '
        Me.ttInformacion.IsBalloon = True
        Me.ttInformacion.ShowAlways = True
        Me.ttInformacion.ToolTipTitle = "Información - Buscar Paciente"
        '
        'cmdModificar
        '
        Me.cmdModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdModificar.BackColor = System.Drawing.Color.Transparent
        Me.cmdModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.FlatAppearance.BorderSize = 0
        Me.cmdModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmdModificar.ForeColor = System.Drawing.Color.Gray
        Me.cmdModificar.Image = CType(resources.GetObject("cmdModificar.Image"), System.Drawing.Image)
        Me.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModificar.Location = New System.Drawing.Point(641, 6)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModificar.Size = New System.Drawing.Size(110, 32)
        Me.cmdModificar.TabIndex = 8
        Me.cmdModificar.Text = "Modificar:"
        Me.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttInformacion.SetToolTip(Me.cmdModificar, "Modificar un paciente registrado")
        Me.cmdModificar.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.Transparent
        Me.cmdEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.FlatAppearance.BorderSize = 0
        Me.cmdEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmdEliminar.ForeColor = System.Drawing.Color.Gray
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEliminar.Location = New System.Drawing.Point(774, 6)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEliminar.Size = New System.Drawing.Size(101, 32)
        Me.cmdEliminar.TabIndex = 108
        Me.cmdEliminar.Text = "Eliminar:"
        Me.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttInformacion.SetToolTip(Me.cmdEliminar, "Modificar un paciente registrado")
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAyuda.BackColor = System.Drawing.Color.Transparent
        Me.cmdAyuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAyuda.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAyuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdAyuda.FlatAppearance.BorderSize = 0
        Me.cmdAyuda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmdAyuda.ForeColor = System.Drawing.Color.White
        Me.cmdAyuda.Image = CType(resources.GetObject("cmdAyuda.Image"), System.Drawing.Image)
        Me.cmdAyuda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAyuda.Location = New System.Drawing.Point(898, 2)
        Me.cmdAyuda.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAyuda.Size = New System.Drawing.Size(49, 48)
        Me.cmdAyuda.TabIndex = 1792
        Me.cmdAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ttInformacion.SetToolTip(Me.cmdAyuda, "Ayuda")
        Me.cmdAyuda.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.ToolTipText = "Modificar datos del paciente"
        Me.DataGridViewImageColumn1.Width = 25
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.ToolTipText = "Consultar"
        Me.DataGridViewImageColumn2.Width = 25
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ToolTipText = "Eliminar paciente"
        Me.DataGridViewImageColumn3.Width = 25
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
        Me.cmdSalir.Location = New System.Drawing.Point(948, 2)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(49, 48)
        Me.cmdSalir.TabIndex = 378
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'pnlFondo
        '
        Me.pnlFondo.BackColor = System.Drawing.Color.Transparent
        Me.pnlFondo.Controls.Add(Me.expPagar)
        Me.pnlFondo.Controls.Add(Me.pnlDare)
        Me.pnlFondo.Controls.Add(Me.cmdAyuda)
        Me.pnlFondo.Controls.Add(Me.cmdSalir)
        Me.pnlFondo.Controls.Add(Me.picDemos)
        Me.pnlFondo.Controls.Add(Me.gpbPreview)
        Me.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFondo.Location = New System.Drawing.Point(0, 0)
        Me.pnlFondo.Name = "pnlFondo"
        Me.pnlFondo.Size = New System.Drawing.Size(1000, 600)
        Me.pnlFondo.TabIndex = 100
        '
        'expPagar
        '
        Me.expPagar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.expPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.expPagar.ButtonImageCollapse = CType(resources.GetObject("expPagar.ButtonImageCollapse"), System.Drawing.Image)
        Me.expPagar.ButtonImageExpand = CType(resources.GetObject("expPagar.ButtonImageExpand"), System.Drawing.Image)
        Me.expPagar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.expPagar.Controls.Add(Me.Label2)
        Me.expPagar.Controls.Add(Me.txtBuscar)
        Me.expPagar.Controls.Add(Me.UcLabelRC11)
        Me.expPagar.Controls.Add(Me.optGrupo)
        Me.expPagar.Controls.Add(Me.optCodigo)
        Me.expPagar.Controls.Add(Me.optEstudiante)
        Me.expPagar.Controls.Add(Me.cmdBuscar)
        Me.expPagar.Controls.Add(Me.picBusqueda)
        Me.expPagar.Controls.Add(Me.Label1)
        Me.expPagar.ExpandButtonAlignment = DevComponents.DotNetBar.eTitleButtonAlignment.Left
        Me.expPagar.ExpandOnTitleClick = True
        Me.expPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.expPagar.Location = New System.Drawing.Point(116, 3)
        Me.expPagar.Name = "expPagar"
        Me.expPagar.Size = New System.Drawing.Size(769, 84)
        Me.expPagar.Style.BackColor1.Color = System.Drawing.Color.White
        Me.expPagar.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.expPagar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expPagar.Style.GradientAngle = 90
        Me.expPagar.StyleMouseDown.ForeColor.Color = System.Drawing.Color.White
        Me.expPagar.StyleMouseOver.ForeColor.Color = System.Drawing.Color.White
        Me.expPagar.TabIndex = 1793
        Me.expPagar.TitleHeight = 40
        Me.expPagar.TitleStyle.BackColor1.Color = System.Drawing.Color.White
        Me.expPagar.TitleStyle.BackColor2.Color = System.Drawing.Color.White
        Me.expPagar.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.expPagar.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expPagar.TitleStyle.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.expPagar.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.expPagar.TitleStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expPagar.TitleStyle.ForeColor.Color = System.Drawing.Color.White
        Me.expPagar.TitleStyleMouseDown.LineAlignment = System.Drawing.StringAlignment.Near
        Me.expPagar.TitleText = "Title Bar"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(657, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1, 31)
        Me.Label2.TabIndex = 1793
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.DimGray
        Me.txtBuscar.Location = New System.Drawing.Point(115, 9)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(526, 22)
        Me.txtBuscar.TabIndex = 1826
        '
        'UcLabelRC11
        '
        Me.UcLabelRC11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC11.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.UcLabelRC11.Location = New System.Drawing.Point(111, 5)
        Me.UcLabelRC11.Name = "UcLabelRC11"
        Me.UcLabelRC11.Size = New System.Drawing.Size(536, 31)
        Me.UcLabelRC11.TabIndex = 1825
        Me.UcLabelRC11.Texthaschanged = False
        '
        'optGrupo
        '
        Me.optGrupo.Appearance = System.Windows.Forms.Appearance.Button
        Me.optGrupo.BackColor = System.Drawing.Color.Transparent
        Me.optGrupo.BackgroundImage = CType(resources.GetObject("optGrupo.BackgroundImage"), System.Drawing.Image)
        Me.optGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.optGrupo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optGrupo.FlatAppearance.BorderSize = 0
        Me.optGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.optGrupo.ForeColor = System.Drawing.Color.Gray
        Me.optGrupo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.optGrupo.Location = New System.Drawing.Point(487, 45)
        Me.optGrupo.Name = "optGrupo"
        Me.optGrupo.Size = New System.Drawing.Size(130, 33)
        Me.optGrupo.TabIndex = 1824
        Me.optGrupo.Text = "      &Grupo"
        Me.optGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.optGrupo.UseVisualStyleBackColor = False
        '
        'optCodigo
        '
        Me.optCodigo.Appearance = System.Windows.Forms.Appearance.Button
        Me.optCodigo.BackColor = System.Drawing.Color.Transparent
        Me.optCodigo.BackgroundImage = CType(resources.GetObject("optCodigo.BackgroundImage"), System.Drawing.Image)
        Me.optCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.optCodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optCodigo.FlatAppearance.BorderSize = 0
        Me.optCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.optCodigo.ForeColor = System.Drawing.Color.Gray
        Me.optCodigo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.optCodigo.Location = New System.Drawing.Point(326, 45)
        Me.optCodigo.Name = "optCodigo"
        Me.optCodigo.Size = New System.Drawing.Size(115, 33)
        Me.optCodigo.TabIndex = 1823
        Me.optCodigo.Text = "          &Código"
        Me.optCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.optCodigo.UseVisualStyleBackColor = False
        '
        'optEstudiante
        '
        Me.optEstudiante.Appearance = System.Windows.Forms.Appearance.Button
        Me.optEstudiante.BackColor = System.Drawing.Color.Transparent
        Me.optEstudiante.BackgroundImage = CType(resources.GetObject("optEstudiante.BackgroundImage"), System.Drawing.Image)
        Me.optEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.optEstudiante.Checked = True
        Me.optEstudiante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optEstudiante.FlatAppearance.BorderSize = 0
        Me.optEstudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optEstudiante.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.optEstudiante.ForeColor = System.Drawing.Color.Gray
        Me.optEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optEstudiante.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.optEstudiante.Location = New System.Drawing.Point(151, 45)
        Me.optEstudiante.Name = "optEstudiante"
        Me.optEstudiante.Size = New System.Drawing.Size(129, 33)
        Me.optEstudiante.TabIndex = 1821
        Me.optEstudiante.TabStop = True
        Me.optEstudiante.Text = "       &Alumno"
        Me.optEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.optEstudiante.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdBuscar.BackColor = System.Drawing.Color.Transparent
        Me.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdBuscar.FlatAppearance.BorderSize = 0
        Me.cmdBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cmdBuscar.Location = New System.Drawing.Point(664, 2)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(43, 34)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'picBusqueda
        '
        Me.picBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.picBusqueda.BackgroundImage = CType(resources.GetObject("picBusqueda.BackgroundImage"), System.Drawing.Image)
        Me.picBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBusqueda.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.picBusqueda.Location = New System.Drawing.Point(68, 1)
        Me.picBusqueda.Name = "picBusqueda"
        Me.picBusqueda.Size = New System.Drawing.Size(37, 37)
        Me.picBusqueda.TabIndex = 530
        Me.picBusqueda.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Label1.Location = New System.Drawing.Point(865, 688)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 297
        Me.Label1.Visible = False
        '
        'pnlDare
        '
        Me.pnlDare.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDare.BackColor = System.Drawing.Color.Transparent
        Me.pnlDare.Controls.Add(Me.pnlSubPanel)
        Me.pnlDare.Controls.Add(Me.picMarcoCentroInf)
        Me.pnlDare.Controls.Add(Me.picMarcoIzqInf)
        Me.pnlDare.Controls.Add(Me.picMarcoDerInf)
        Me.pnlDare.Location = New System.Drawing.Point(0, 82)
        Me.pnlDare.Name = "pnlDare"
        Me.pnlDare.Size = New System.Drawing.Size(1000, 516)
        Me.pnlDare.TabIndex = 112
        '
        'pnlSubPanel
        '
        Me.pnlSubPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSubPanel.BackColor = System.Drawing.Color.White
        Me.pnlSubPanel.Controls.Add(Me.lblTotal)
        Me.pnlSubPanel.Controls.Add(Me.DaRe)
        Me.pnlSubPanel.Controls.Add(Me.lblTotal_)
        Me.pnlSubPanel.Controls.Add(Me.lblPaciente)
        Me.pnlSubPanel.Controls.Add(Me.cmdModificar)
        Me.pnlSubPanel.Controls.Add(Me.cmdEliminar)
        Me.pnlSubPanel.Controls.Add(Me.lblVertical3)
        Me.pnlSubPanel.Controls.Add(Me.lblVertical4)
        Me.pnlSubPanel.Location = New System.Drawing.Point(26, 11)
        Me.pnlSubPanel.Name = "pnlSubPanel"
        Me.pnlSubPanel.Size = New System.Drawing.Size(944, 478)
        Me.pnlSubPanel.TabIndex = 119
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Gray
        Me.lblTotal.Location = New System.Drawing.Point(841, 445)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(74, 31)
        Me.lblTotal.TabIndex = 377
        Me.lblTotal.Text = "9999"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotal.Visible = False
        '
        'DaRe
        '
        Me.DaRe.AllowUserToAddItems = False
        Me.DaRe.AllowUserToDeleteItems = False
        Me.DaRe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DaRe.BackColor = System.Drawing.Color.White
        Me.DaRe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DaRe.ItemHeaderSize = 0
        Me.DaRe.ItemHeaderVisible = False
        '
        'DaRe.ItemTemplate
        '
        Me.DaRe.ItemTemplate.BackColor = System.Drawing.Color.White
        Me.DaRe.ItemTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblCodCarrera)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblGrupo)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblCodGrupo)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblNombre)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblMaterno)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblPaterno)
        Me.DaRe.ItemTemplate.Controls.Add(Me.picPaciente)
        Me.DaRe.ItemTemplate.Controls.Add(Me.Label4)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblCarrera)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblCodigo)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblNombreCompleto)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblCodAlumno)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblCodEspecie)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblFinadoLinea)
        Me.DaRe.ItemTemplate.Controls.Add(Me.picEditar)
        Me.DaRe.ItemTemplate.Margin = New System.Windows.Forms.Padding(10)
        Me.DaRe.ItemTemplate.Size = New System.Drawing.Size(932, 127)
        Me.DaRe.Location = New System.Drawing.Point(2, 42)
        Me.DaRe.Margin = New System.Windows.Forms.Padding(10)
        Me.DaRe.Name = "DaRe"
        Me.DaRe.SelectionColor = System.Drawing.Color.White
        Me.DaRe.Size = New System.Drawing.Size(940, 403)
        Me.DaRe.TabIndex = 7
        '
        'lblCodCarrera
        '
        Me.lblCodCarrera.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCodCarrera.Location = New System.Drawing.Point(644, 107)
        Me.lblCodCarrera.Name = "lblCodCarrera"
        Me.lblCodCarrera.Size = New System.Drawing.Size(68, 19)
        Me.lblCodCarrera.TabIndex = 1649
        Me.lblCodCarrera.Text = "Carrera"
        Me.lblCodCarrera.Visible = False
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblGrupo.ForeColor = System.Drawing.Color.Gray
        Me.lblGrupo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblGrupo.Location = New System.Drawing.Point(111, 79)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(54, 20)
        Me.lblGrupo.TabIndex = 1648
        Me.lblGrupo.Text = "Grupo"
        '
        'lblCodGrupo
        '
        Me.lblCodGrupo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCodGrupo.Location = New System.Drawing.Point(644, 73)
        Me.lblCodGrupo.Name = "lblCodGrupo"
        Me.lblCodGrupo.Size = New System.Drawing.Size(68, 19)
        Me.lblCodGrupo.TabIndex = 1647
        Me.lblCodGrupo.Text = "Cod.Grupo"
        Me.lblCodGrupo.Visible = False
        '
        'lblNombre
        '
        Me.lblNombre.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblNombre.Location = New System.Drawing.Point(644, 54)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 19)
        Me.lblNombre.TabIndex = 1646
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.Visible = False
        '
        'lblMaterno
        '
        Me.lblMaterno.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblMaterno.Location = New System.Drawing.Point(644, 36)
        Me.lblMaterno.Name = "lblMaterno"
        Me.lblMaterno.Size = New System.Drawing.Size(68, 19)
        Me.lblMaterno.TabIndex = 1645
        Me.lblMaterno.Text = "Materno"
        Me.lblMaterno.Visible = False
        '
        'lblPaterno
        '
        Me.lblPaterno.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblPaterno.Location = New System.Drawing.Point(644, 17)
        Me.lblPaterno.Name = "lblPaterno"
        Me.lblPaterno.Size = New System.Drawing.Size(68, 19)
        Me.lblPaterno.TabIndex = 1644
        Me.lblPaterno.Text = "Paterno"
        Me.lblPaterno.Visible = False
        '
        'picPaciente
        '
        Me.picPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picPaciente.Image = CType(resources.GetObject("picPaciente.Image"), System.Drawing.Image)
        Me.picPaciente.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.picPaciente.Location = New System.Drawing.Point(13, 3)
        Me.picPaciente.Name = "picPaciente"
        Me.picPaciente.Size = New System.Drawing.Size(80, 80)
        Me.picPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPaciente.TabIndex = 1638
        Me.picPaciente.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(296, -3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1, 43)
        Me.Label4.TabIndex = 1640
        '
        'lblCarrera
        '
        Me.lblCarrera.BackColor = System.Drawing.Color.Transparent
        Me.lblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCarrera.ForeColor = System.Drawing.Color.Gray
        Me.lblCarrera.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCarrera.Location = New System.Drawing.Point(111, 56)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Size = New System.Drawing.Size(190, 18)
        Me.lblCarrera.TabIndex = 1636
        Me.lblCarrera.Text = "Carrera"
        '
        'lblCodigo
        '
        Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCodigo.ForeColor = System.Drawing.Color.Gray
        Me.lblCodigo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCodigo.Location = New System.Drawing.Point(111, 33)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(190, 20)
        Me.lblCodigo.TabIndex = 1635
        Me.lblCodigo.Text = "Codigo"
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.AllowDrop = True
        Me.lblNombreCompleto.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblNombreCompleto.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblNombreCompleto.Location = New System.Drawing.Point(111, 4)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(190, 27)
        Me.lblNombreCompleto.TabIndex = 1634
        Me.lblNombreCompleto.Text = "Nombre"
        Me.lblNombreCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodAlumno
        '
        Me.lblCodAlumno.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCodAlumno.Location = New System.Drawing.Point(644, -2)
        Me.lblCodAlumno.Name = "lblCodAlumno"
        Me.lblCodAlumno.Size = New System.Drawing.Size(68, 19)
        Me.lblCodAlumno.TabIndex = 1639
        Me.lblCodAlumno.Text = "CodAlumno"
        Me.lblCodAlumno.Visible = False
        '
        'lblCodEspecie
        '
        Me.lblCodEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCodEspecie.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCodEspecie.Location = New System.Drawing.Point(731, -1)
        Me.lblCodEspecie.Name = "lblCodEspecie"
        Me.lblCodEspecie.Size = New System.Drawing.Size(43, 13)
        Me.lblCodEspecie.TabIndex = 1637
        Me.lblCodEspecie.Visible = False
        '
        'lblFinadoLinea
        '
        Me.lblFinadoLinea.BackColor = System.Drawing.Color.Black
        Me.lblFinadoLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFinadoLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinadoLinea.ForeColor = System.Drawing.Color.DimGray
        Me.lblFinadoLinea.Location = New System.Drawing.Point(2, -1)
        Me.lblFinadoLinea.Name = "lblFinadoLinea"
        Me.lblFinadoLinea.Size = New System.Drawing.Size(5, 124)
        Me.lblFinadoLinea.TabIndex = 1633
        Me.lblFinadoLinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFinadoLinea.Visible = False
        '
        'picEditar
        '
        Me.picEditar.BackColor = System.Drawing.Color.Transparent
        Me.picEditar.BackgroundImage = CType(resources.GetObject("picEditar.BackgroundImage"), System.Drawing.Image)
        Me.picEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picEditar.Dock = System.Windows.Forms.DockStyle.Right
        Me.picEditar.Location = New System.Drawing.Point(855, 0)
        Me.picEditar.Name = "picEditar"
        Me.picEditar.Size = New System.Drawing.Size(73, 122)
        Me.picEditar.TabIndex = 28
        Me.picEditar.TabStop = False
        Me.picEditar.Visible = False
        '
        'lblTotal_
        '
        Me.lblTotal_.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal_.AutoSize = True
        Me.lblTotal_.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal_.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal_.ForeColor = System.Drawing.Color.DarkGray
        Me.lblTotal_.Location = New System.Drawing.Point(774, 450)
        Me.lblTotal_.Name = "lblTotal_"
        Me.lblTotal_.Size = New System.Drawing.Size(62, 25)
        Me.lblTotal_.TabIndex = 1610
        Me.lblTotal_.Text = "Total:"
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.BackColor = System.Drawing.Color.Transparent
        Me.lblPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaciente.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPaciente.Location = New System.Drawing.Point(16, 7)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(0, 31)
        Me.lblPaciente.TabIndex = 1617
        '
        'lblVertical3
        '
        Me.lblVertical3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVertical3.BackColor = System.Drawing.Color.Gainsboro
        Me.lblVertical3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVertical3.Location = New System.Drawing.Point(764, 7)
        Me.lblVertical3.Name = "lblVertical3"
        Me.lblVertical3.Size = New System.Drawing.Size(1, 31)
        Me.lblVertical3.TabIndex = 1612
        '
        'lblVertical4
        '
        Me.lblVertical4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVertical4.BackColor = System.Drawing.Color.Gainsboro
        Me.lblVertical4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVertical4.Location = New System.Drawing.Point(635, 7)
        Me.lblVertical4.Name = "lblVertical4"
        Me.lblVertical4.Size = New System.Drawing.Size(1, 31)
        Me.lblVertical4.TabIndex = 1584
        '
        'picMarcoCentroInf
        '
        Me.picMarcoCentroInf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picMarcoCentroInf.BackgroundImage = CType(resources.GetObject("picMarcoCentroInf.BackgroundImage"), System.Drawing.Image)
        Me.picMarcoCentroInf.Location = New System.Drawing.Point(390, 421)
        Me.picMarcoCentroInf.Name = "picMarcoCentroInf"
        Me.picMarcoCentroInf.Size = New System.Drawing.Size(197, 93)
        Me.picMarcoCentroInf.TabIndex = 110
        Me.picMarcoCentroInf.TabStop = False
        '
        'picMarcoIzqInf
        '
        Me.picMarcoIzqInf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picMarcoIzqInf.BackgroundImage = CType(resources.GetObject("picMarcoIzqInf.BackgroundImage"), System.Drawing.Image)
        Me.picMarcoIzqInf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picMarcoIzqInf.Location = New System.Drawing.Point(5, 421)
        Me.picMarcoIzqInf.Name = "picMarcoIzqInf"
        Me.picMarcoIzqInf.Size = New System.Drawing.Size(392, 101)
        Me.picMarcoIzqInf.TabIndex = 118
        Me.picMarcoIzqInf.TabStop = False
        '
        'picMarcoDerInf
        '
        Me.picMarcoDerInf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picMarcoDerInf.BackgroundImage = CType(resources.GetObject("picMarcoDerInf.BackgroundImage"), System.Drawing.Image)
        Me.picMarcoDerInf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picMarcoDerInf.Location = New System.Drawing.Point(582, 421)
        Me.picMarcoDerInf.Name = "picMarcoDerInf"
        Me.picMarcoDerInf.Size = New System.Drawing.Size(417, 98)
        Me.picMarcoDerInf.TabIndex = 117
        Me.picMarcoDerInf.TabStop = False
        '
        'picDemos
        '
        Me.picDemos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDemos.Location = New System.Drawing.Point(40, 17)
        Me.picDemos.Name = "picDemos"
        Me.picDemos.Size = New System.Drawing.Size(63, 54)
        Me.picDemos.TabIndex = 29
        Me.picDemos.TabStop = False
        Me.picDemos.Visible = False
        '
        'gpbPreview
        '
        Me.gpbPreview.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gpbPreview.Controls.Add(Me.pnlPreview)
        Me.gpbPreview.Location = New System.Drawing.Point(26, 107)
        Me.gpbPreview.Name = "gpbPreview"
        Me.gpbPreview.Size = New System.Drawing.Size(944, 467)
        Me.gpbPreview.TabIndex = 533
        Me.gpbPreview.TabStop = False
        Me.gpbPreview.Visible = False
        '
        'pnlPreview
        '
        Me.pnlPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPreview.BackColor = System.Drawing.Color.White
        Me.pnlPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlPreview.Controls.Add(Me.lblPantherDerechos)
        Me.pnlPreview.Controls.Add(Me.lblMarcoInferior)
        Me.pnlPreview.Controls.Add(Me.lblMarcoIzquierdo)
        Me.pnlPreview.Controls.Add(Me.lblMarcoSuperior)
        Me.pnlPreview.Controls.Add(Me.lblMarcoDerecho)
        Me.pnlPreview.Controls.Add(Me.richPaciente)
        Me.pnlPreview.Controls.Add(Me.lblPreviewClinica)
        Me.pnlPreview.Controls.Add(Me.Label8)
        Me.pnlPreview.Controls.Add(Me.lblMensaje)
        Me.pnlPreview.Controls.Add(Me.pnlImagenDeceso)
        Me.pnlPreview.Controls.Add(Me.Uc_PanelDobleBuffer1)
        Me.pnlPreview.Location = New System.Drawing.Point(1, 7)
        Me.pnlPreview.Name = "pnlPreview"
        Me.pnlPreview.Size = New System.Drawing.Size(942, 459)
        Me.pnlPreview.TabIndex = 532
        '
        'lblPantherDerechos
        '
        Me.lblPantherDerechos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPantherDerechos.BackColor = System.Drawing.Color.White
        Me.lblPantherDerechos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lblPantherDerechos.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPantherDerechos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPantherDerechos.Location = New System.Drawing.Point(326, 392)
        Me.lblPantherDerechos.Name = "lblPantherDerechos"
        Me.lblPantherDerechos.Size = New System.Drawing.Size(290, 17)
        Me.lblPantherDerechos.TabIndex = 1615
        Me.lblPantherDerechos.Text = "Panther, todos los derechos reservados"
        Me.lblPantherDerechos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMarcoInferior
        '
        Me.lblMarcoInferior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMarcoInferior.BackColor = System.Drawing.Color.White
        Me.lblMarcoInferior.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarcoInferior.Location = New System.Drawing.Point(245, 241)
        Me.lblMarcoInferior.Name = "lblMarcoInferior"
        Me.lblMarcoInferior.Size = New System.Drawing.Size(452, 1)
        Me.lblMarcoInferior.TabIndex = 1588
        '
        'lblMarcoIzquierdo
        '
        Me.lblMarcoIzquierdo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMarcoIzquierdo.BackColor = System.Drawing.Color.White
        Me.lblMarcoIzquierdo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarcoIzquierdo.Location = New System.Drawing.Point(245, 208)
        Me.lblMarcoIzquierdo.Name = "lblMarcoIzquierdo"
        Me.lblMarcoIzquierdo.Size = New System.Drawing.Size(1, 36)
        Me.lblMarcoIzquierdo.TabIndex = 1587
        '
        'lblMarcoSuperior
        '
        Me.lblMarcoSuperior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMarcoSuperior.BackColor = System.Drawing.Color.White
        Me.lblMarcoSuperior.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarcoSuperior.Location = New System.Drawing.Point(246, 210)
        Me.lblMarcoSuperior.Name = "lblMarcoSuperior"
        Me.lblMarcoSuperior.Size = New System.Drawing.Size(451, 1)
        Me.lblMarcoSuperior.TabIndex = 1586
        '
        'lblMarcoDerecho
        '
        Me.lblMarcoDerecho.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMarcoDerecho.BackColor = System.Drawing.Color.White
        Me.lblMarcoDerecho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarcoDerecho.Location = New System.Drawing.Point(697, 208)
        Me.lblMarcoDerecho.Name = "lblMarcoDerecho"
        Me.lblMarcoDerecho.Size = New System.Drawing.Size(1, 35)
        Me.lblMarcoDerecho.TabIndex = 1585
        '
        'richPaciente
        '
        Me.richPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.richPaciente.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.richPaciente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.richPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.richPaciente.Location = New System.Drawing.Point(245, 210)
        Me.richPaciente.Name = "richPaciente"
        Me.richPaciente.Size = New System.Drawing.Size(453, 32)
        Me.richPaciente.TabIndex = 534
        '
        'lblPreviewClinica
        '
        Me.lblPreviewClinica.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPreviewClinica.BackColor = System.Drawing.Color.White
        Me.lblPreviewClinica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPreviewClinica.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPreviewClinica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPreviewClinica.Location = New System.Drawing.Point(281, 372)
        Me.lblPreviewClinica.Name = "lblPreviewClinica"
        Me.lblPreviewClinica.Size = New System.Drawing.Size(381, 17)
        Me.lblPreviewClinica.TabIndex = 533
        Me.lblPreviewClinica.Text = "CLINICA VETERINARIA"
        Me.lblPreviewClinica.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(39, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(864, 25)
        Me.Label8.TabIndex = 532
        Me.Label8.Text = "Espero que esta etapa pase pronto y vengan tiempos mejores."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMensaje.BackColor = System.Drawing.Color.White
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensaje.ForeColor = System.Drawing.Color.DarkGray
        Me.lblMensaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMensaje.Location = New System.Drawing.Point(2, 252)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(940, 46)
        Me.lblMensaje.TabIndex = 531
        Me.lblMensaje.Text = "Comprendemos que en estas ciscunstacias de tanto dolor los mensajes de condolenci" & _
            "as no son suficientes para que encuentres consuelo."
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlImagenDeceso
        '
        Me.pnlImagenDeceso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlImagenDeceso.BackColor = System.Drawing.Color.White
        Me.pnlImagenDeceso.BackgroundImage = CType(resources.GetObject("pnlImagenDeceso.BackgroundImage"), System.Drawing.Image)
        Me.pnlImagenDeceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlImagenDeceso.Controls.Add(Me.ShapeContainer1)
        Me.pnlImagenDeceso.Location = New System.Drawing.Point(407, 76)
        Me.pnlImagenDeceso.Name = "pnlImagenDeceso"
        Me.pnlImagenDeceso.Size = New System.Drawing.Size(129, 127)
        Me.pnlImagenDeceso.TabIndex = 530
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(129, 127)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Uc_PanelDobleBuffer1
        '
        Me.Uc_PanelDobleBuffer1.BackColor = System.Drawing.Color.White
        Me.Uc_PanelDobleBuffer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Uc_PanelDobleBuffer1.Controls.Add(Me.lblLineHorizontal10)
        Me.Uc_PanelDobleBuffer1.Controls.Add(Me.lblCorreoEmpreza)
        Me.Uc_PanelDobleBuffer1.Controls.Add(Me.lblPara)
        Me.Uc_PanelDobleBuffer1.Controls.Add(Me.lblCorreoPaciente)
        Me.Uc_PanelDobleBuffer1.Controls.Add(Me.lblDe)
        Me.Uc_PanelDobleBuffer1.Controls.Add(Me.cmdCerrarPreview)
        Me.Uc_PanelDobleBuffer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Uc_PanelDobleBuffer1.Location = New System.Drawing.Point(0, 0)
        Me.Uc_PanelDobleBuffer1.Name = "Uc_PanelDobleBuffer1"
        Me.Uc_PanelDobleBuffer1.Size = New System.Drawing.Size(942, 55)
        Me.Uc_PanelDobleBuffer1.TabIndex = 1618
        '
        'lblLineHorizontal10
        '
        Me.lblLineHorizontal10.BackColor = System.Drawing.Color.Gainsboro
        Me.lblLineHorizontal10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLineHorizontal10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLineHorizontal10.ForeColor = System.Drawing.Color.Transparent
        Me.lblLineHorizontal10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLineHorizontal10.Location = New System.Drawing.Point(0, 54)
        Me.lblLineHorizontal10.Name = "lblLineHorizontal10"
        Me.lblLineHorizontal10.Size = New System.Drawing.Size(942, 1)
        Me.lblLineHorizontal10.TabIndex = 1613
        '
        'lblCorreoEmpreza
        '
        Me.lblCorreoEmpreza.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCorreoEmpreza.BackColor = System.Drawing.Color.White
        Me.lblCorreoEmpreza.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblCorreoEmpreza.ForeColor = System.Drawing.Color.Silver
        Me.lblCorreoEmpreza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCorreoEmpreza.Location = New System.Drawing.Point(70, 27)
        Me.lblCorreoEmpreza.Name = "lblCorreoEmpreza"
        Me.lblCorreoEmpreza.Size = New System.Drawing.Size(406, 23)
        Me.lblCorreoEmpreza.TabIndex = 1617
        Me.lblCorreoEmpreza.Text = "raul@panther-one.com"
        '
        'lblPara
        '
        Me.lblPara.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPara.AutoSize = True
        Me.lblPara.BackColor = System.Drawing.Color.White
        Me.lblPara.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblPara.ForeColor = System.Drawing.Color.Gray
        Me.lblPara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPara.Location = New System.Drawing.Point(18, 3)
        Me.lblPara.Name = "lblPara"
        Me.lblPara.Size = New System.Drawing.Size(53, 22)
        Me.lblPara.TabIndex = 1612
        Me.lblPara.Text = "Para:"
        '
        'lblCorreoPaciente
        '
        Me.lblCorreoPaciente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCorreoPaciente.BackColor = System.Drawing.Color.White
        Me.lblCorreoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblCorreoPaciente.ForeColor = System.Drawing.Color.Silver
        Me.lblCorreoPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCorreoPaciente.Location = New System.Drawing.Point(70, 3)
        Me.lblCorreoPaciente.Name = "lblCorreoPaciente"
        Me.lblCorreoPaciente.Size = New System.Drawing.Size(406, 23)
        Me.lblCorreoPaciente.TabIndex = 1614
        Me.lblCorreoPaciente.Text = "raul@panther-one.com"
        '
        'lblDe
        '
        Me.lblDe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDe.AutoSize = True
        Me.lblDe.BackColor = System.Drawing.Color.White
        Me.lblDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblDe.ForeColor = System.Drawing.Color.Gray
        Me.lblDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDe.Location = New System.Drawing.Point(32, 27)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(38, 22)
        Me.lblDe.TabIndex = 1616
        Me.lblDe.Text = "De:"
        '
        'cmdCerrarPreview
        '
        Me.cmdCerrarPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrarPreview.BackColor = System.Drawing.Color.Transparent
        Me.cmdCerrarPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCerrarPreview.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrarPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCerrarPreview.FlatAppearance.BorderSize = 0
        Me.cmdCerrarPreview.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdCerrarPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdCerrarPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdCerrarPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCerrarPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmdCerrarPreview.ForeColor = System.Drawing.Color.DarkGray
        Me.cmdCerrarPreview.Image = CType(resources.GetObject("cmdCerrarPreview.Image"), System.Drawing.Image)
        Me.cmdCerrarPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCerrarPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCerrarPreview.Location = New System.Drawing.Point(846, 1)
        Me.cmdCerrarPreview.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdCerrarPreview.Name = "cmdCerrarPreview"
        Me.cmdCerrarPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCerrarPreview.Size = New System.Drawing.Size(87, 53)
        Me.cmdCerrarPreview.TabIndex = 1589
        Me.cmdCerrarPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCerrarPreview.UseVisualStyleBackColor = False
        '
        'frmBuscarPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlFondo)
        Me.Controls.Add(Me.lblRegistros)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, -4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarPacientes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.TransparencyKey = System.Drawing.Color.White
        Me.pnlFondo.ResumeLayout(False)
        Me.expPagar.ResumeLayout(False)
        Me.expPagar.PerformLayout()
        CType(Me.picBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDare.ResumeLayout(False)
        Me.pnlSubPanel.ResumeLayout(False)
        Me.pnlSubPanel.PerformLayout()
        Me.DaRe.ItemTemplate.ResumeLayout(False)
        Me.DaRe.ItemTemplate.PerformLayout()
        Me.DaRe.ResumeLayout(False)
        CType(Me.picPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMarcoCentroInf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMarcoIzqInf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMarcoDerInf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDemos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbPreview.ResumeLayout(False)
        Me.pnlPreview.ResumeLayout(False)
        Me.pnlImagenDeceso.ResumeLayout(False)
        Me.Uc_PanelDobleBuffer1.ResumeLayout(False)
        Me.Uc_PanelDobleBuffer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ttInformacion As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents picDemos As System.Windows.Forms.PictureBox
    Public WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblTotal_ As System.Windows.Forms.Label
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents DaRe As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents picEditar As System.Windows.Forms.PictureBox
    Public WithEvents cmdModificar As System.Windows.Forms.Button
    Public WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents lblVertical3 As System.Windows.Forms.Label
    Friend WithEvents lblVertical4 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents picMarcoIzqInf As System.Windows.Forms.PictureBox
    Friend WithEvents picMarcoDerInf As System.Windows.Forms.PictureBox
    Friend WithEvents picMarcoCentroInf As System.Windows.Forms.PictureBox
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPreviewClinica As System.Windows.Forms.Label
    Friend WithEvents richPaciente As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents lblMarcoDerecho As System.Windows.Forms.Label
    Friend WithEvents lblMarcoIzquierdo As System.Windows.Forms.Label
    Friend WithEvents lblMarcoSuperior As System.Windows.Forms.Label
    Friend WithEvents lblMarcoInferior As System.Windows.Forms.Label
    Public WithEvents cmdCerrarPreview As System.Windows.Forms.Button
    Friend WithEvents lblLineHorizontal10 As System.Windows.Forms.Label
    Friend WithEvents lblPara As System.Windows.Forms.Label
    Friend WithEvents lblCorreoPaciente As System.Windows.Forms.Label
    Friend WithEvents lblPantherDerechos As System.Windows.Forms.Label
    Friend WithEvents lblDe As System.Windows.Forms.Label
    Friend WithEvents lblCorreoEmpreza As System.Windows.Forms.Label
    Friend WithEvents pnlFondo As System.Windows.Forms.Panel
    Friend WithEvents pnlImagenDeceso As System.Windows.Forms.Panel
    Friend WithEvents pnlDare As System.Windows.Forms.Panel
    Friend WithEvents pnlSubPanel As System.Windows.Forms.Panel
    Friend WithEvents pnlPreview As System.Windows.Forms.Panel
    Friend WithEvents Uc_PanelDobleBuffer1 As System.Windows.Forms.Panel
    Friend WithEvents gpbPreview As System.Windows.Forms.GroupBox
    Friend WithEvents lblFinadoLinea As System.Windows.Forms.Label
    Public WithEvents cmdAyuda As System.Windows.Forms.Button
    Private WithEvents expPagar As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC11 As ControlAsistencias.ucLabelRC
    Friend WithEvents optGrupo As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents optEstudiante As System.Windows.Forms.RadioButton
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents picBusqueda As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picPaciente As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCarrera As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblNombreCompleto As System.Windows.Forms.Label
    Friend WithEvents lblCodAlumno As System.Windows.Forms.Label
    Friend WithEvents lblCodEspecie As System.Windows.Forms.Label
    Friend WithEvents lblMaterno As System.Windows.Forms.Label
    Friend WithEvents lblPaterno As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCodGrupo As System.Windows.Forms.Label
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblCodCarrera As System.Windows.Forms.Label
#End Region
End Class