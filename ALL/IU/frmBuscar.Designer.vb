<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.cmdAltaPacienteLive = New DevComponents.DotNetBar.BubbleButton
        Me.splPanelFondo = New System.Windows.Forms.Panel
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.expPagar = New DevComponents.DotNetBar.ExpandablePanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.UcLabelRC11 = New Panther.ucLabelRC
        Me.optGrupo = New System.Windows.Forms.RadioButton
        Me.optCodigo = New System.Windows.Forms.RadioButton
        Me.optEstudiante = New System.Windows.Forms.RadioButton
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.picBusqueda = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblTotal_ = New System.Windows.Forms.Label
        Me.lblPaciente = New System.Windows.Forms.Label
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.lblVertical3 = New System.Windows.Forms.Label
        Me.lblVertical4 = New System.Windows.Forms.Label
        Me.ItemTemplate = New Microsoft.VisualBasic.PowerPacks.DataRepeaterItem
        Me.lblCodEspecie = New System.Windows.Forms.Label
        Me.lblCodAlumno = New System.Windows.Forms.Label
        Me.lblActivo = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.lblCarrera = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.picEditar = New System.Windows.Forms.PictureBox
        Me.lblCastradoif = New System.Windows.Forms.Label
        Me.lblNoExpediente = New System.Windows.Forms.Label
        Me.lblFinadoLinea = New System.Windows.Forms.Label
        Me.picPaciente = New System.Windows.Forms.PictureBox
        Me.DaRe = New Microsoft.VisualBasic.PowerPacks.DataRepeater
        Me.splPanelFondo.SuspendLayout()
        Me.expPagar.SuspendLayout()
        CType(Me.picBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DaRe.ItemTemplate.SuspendLayout()
        Me.DaRe.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = CType(resources.GetObject("DataGridViewCellStyle1.NullValue"), Object)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewImageColumn1.HeaderText = " "
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Visible = False
        Me.DataGridViewImageColumn1.Width = 40
        '
        'DataGridViewImageColumn2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = CType(resources.GetObject("DataGridViewCellStyle2.NullValue"), Object)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewImageColumn2.HeaderText = " "
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.Width = 40
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
        'splPanelFondo
        '
        Me.splPanelFondo.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.splPanelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.splPanelFondo.Controls.Add(Me.cmdSalir)
        Me.splPanelFondo.Controls.Add(Me.expPagar)
        Me.splPanelFondo.Controls.Add(Me.lblTotal)
        Me.splPanelFondo.Controls.Add(Me.DaRe)
        Me.splPanelFondo.Controls.Add(Me.lblTotal_)
        Me.splPanelFondo.Controls.Add(Me.lblPaciente)
        Me.splPanelFondo.Controls.Add(Me.cmdModificar)
        Me.splPanelFondo.Controls.Add(Me.cmdEliminar)
        Me.splPanelFondo.Controls.Add(Me.lblVertical3)
        Me.splPanelFondo.Controls.Add(Me.lblVertical4)
        Me.splPanelFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splPanelFondo.Location = New System.Drawing.Point(0, 0)
        Me.splPanelFondo.Name = "splPanelFondo"
        Me.splPanelFondo.Size = New System.Drawing.Size(1280, 720)
        Me.splPanelFondo.TabIndex = 9
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
        Me.cmdSalir.Location = New System.Drawing.Point(1229, 2)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(49, 48)
        Me.cmdSalir.TabIndex = 1793
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = False
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
        Me.expPagar.Location = New System.Drawing.Point(256, 2)
        Me.expPagar.Name = "expPagar"
        Me.expPagar.Size = New System.Drawing.Size(769, 84)
        Me.expPagar.Style.BackColor1.Color = System.Drawing.Color.White
        Me.expPagar.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.expPagar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expPagar.Style.GradientAngle = 90
        Me.expPagar.StyleMouseDown.ForeColor.Color = System.Drawing.Color.White
        Me.expPagar.StyleMouseOver.ForeColor.Color = System.Drawing.Color.White
        Me.expPagar.TabIndex = 1792
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
        Me.txtBuscar.Location = New System.Drawing.Point(111, 10)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(532, 22)
        Me.txtBuscar.TabIndex = 1826
        '
        'UcLabelRC11
        '
        Me.UcLabelRC11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC11.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.UcLabelRC11.Location = New System.Drawing.Point(109, 5)
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
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblTotal.ForeColor = System.Drawing.Color.Gray
        Me.lblTotal.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblTotal.Location = New System.Drawing.Point(1196, 683)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(74, 31)
        Me.lblTotal.TabIndex = 1624
        Me.lblTotal.Text = "9999"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotal.Visible = False
        '
        'lblTotal_
        '
        Me.lblTotal_.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal_.AutoSize = True
        Me.lblTotal_.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal_.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblTotal_.ForeColor = System.Drawing.Color.DarkGray
        Me.lblTotal_.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblTotal_.Location = New System.Drawing.Point(1145, 688)
        Me.lblTotal_.Name = "lblTotal_"
        Me.lblTotal_.Size = New System.Drawing.Size(62, 25)
        Me.lblTotal_.TabIndex = 1627
        Me.lblTotal_.Text = "Total:"
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.BackColor = System.Drawing.Color.Transparent
        Me.lblPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblPaciente.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPaciente.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblPaciente.Location = New System.Drawing.Point(23, 96)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(0, 31)
        Me.lblPaciente.TabIndex = 1629
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
        Me.cmdModificar.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cmdModificar.Location = New System.Drawing.Point(1044, 103)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModificar.Size = New System.Drawing.Size(110, 32)
        Me.cmdModificar.TabIndex = 1619
        Me.cmdModificar.Text = "Modificar:"
        Me.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.cmdEliminar.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cmdEliminar.Location = New System.Drawing.Point(1177, 103)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEliminar.Size = New System.Drawing.Size(101, 32)
        Me.cmdEliminar.TabIndex = 1620
        Me.cmdEliminar.Text = "Eliminar:"
        Me.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'lblVertical3
        '
        Me.lblVertical3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVertical3.BackColor = System.Drawing.Color.Gainsboro
        Me.lblVertical3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVertical3.Location = New System.Drawing.Point(1167, 104)
        Me.lblVertical3.Name = "lblVertical3"
        Me.lblVertical3.Size = New System.Drawing.Size(1, 31)
        Me.lblVertical3.TabIndex = 1628
        '
        'lblVertical4
        '
        Me.lblVertical4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVertical4.BackColor = System.Drawing.Color.Gainsboro
        Me.lblVertical4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVertical4.Location = New System.Drawing.Point(1038, 104)
        Me.lblVertical4.Name = "lblVertical4"
        Me.lblVertical4.Size = New System.Drawing.Size(1, 31)
        Me.lblVertical4.TabIndex = 1626
        '
        'ItemTemplate
        '
        Me.ItemTemplate.BackColor = System.Drawing.Color.White
        Me.ItemTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemTemplate.Margin = New System.Windows.Forms.Padding(10)
        Me.ItemTemplate.Size = New System.Drawing.Size(1269, 127)
        '
        'lblCodEspecie
        '
        Me.lblCodEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCodEspecie.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCodEspecie.Location = New System.Drawing.Point(741, 6)
        Me.lblCodEspecie.Name = "lblCodEspecie"
        Me.lblCodEspecie.Size = New System.Drawing.Size(43, 13)
        Me.lblCodEspecie.TabIndex = 30
        Me.lblCodEspecie.Visible = False
        '
        'lblCodAlumno
        '
        Me.lblCodAlumno.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCodAlumno.Location = New System.Drawing.Point(654, -2)
        Me.lblCodAlumno.Name = "lblCodAlumno"
        Me.lblCodAlumno.Size = New System.Drawing.Size(68, 19)
        Me.lblCodAlumno.TabIndex = 36
        Me.lblCodAlumno.Text = "CodAlumno"
        Me.lblCodAlumno.Visible = False
        '
        'lblActivo
        '
        Me.lblActivo.BackColor = System.Drawing.Color.Transparent
        Me.lblActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblActivo.ForeColor = System.Drawing.Color.DarkGray
        Me.lblActivo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblActivo.Location = New System.Drawing.Point(46, 93)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(29, 23)
        Me.lblActivo.TabIndex = 1626
        Me.lblActivo.Visible = False
        '
        'lblNombre
        '
        Me.lblNombre.AllowDrop = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblNombre.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblNombre.Location = New System.Drawing.Point(121, 5)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(190, 26)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigo
        '
        Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCodigo.ForeColor = System.Drawing.Color.Gray
        Me.lblCodigo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCodigo.Location = New System.Drawing.Point(122, 34)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(190, 18)
        Me.lblCodigo.TabIndex = 8
        Me.lblCodigo.Text = "Raza"
        '
        'lblCarrera
        '
        Me.lblCarrera.BackColor = System.Drawing.Color.Transparent
        Me.lblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCarrera.ForeColor = System.Drawing.Color.Gray
        Me.lblCarrera.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCarrera.Location = New System.Drawing.Point(123, 57)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Size = New System.Drawing.Size(190, 18)
        Me.lblCarrera.TabIndex = 18
        Me.lblCarrera.Text = "Color"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(306, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1, 43)
        Me.Label4.TabIndex = 1618
        '
        'picEditar
        '
        Me.picEditar.BackColor = System.Drawing.Color.Transparent
        Me.picEditar.BackgroundImage = CType(resources.GetObject("picEditar.BackgroundImage"), System.Drawing.Image)
        Me.picEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picEditar.Dock = System.Windows.Forms.DockStyle.Right
        Me.picEditar.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.picEditar.Location = New System.Drawing.Point(1192, 0)
        Me.picEditar.Name = "picEditar"
        Me.picEditar.Size = New System.Drawing.Size(73, 122)
        Me.picEditar.TabIndex = 28
        Me.picEditar.TabStop = False
        '
        'lblCastradoif
        '
        Me.lblCastradoif.BackColor = System.Drawing.Color.Transparent
        Me.lblCastradoif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCastradoif.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblCastradoif.ForeColor = System.Drawing.Color.DarkGray
        Me.lblCastradoif.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCastradoif.Location = New System.Drawing.Point(17, 93)
        Me.lblCastradoif.Name = "lblCastradoif"
        Me.lblCastradoif.Size = New System.Drawing.Size(28, 27)
        Me.lblCastradoif.TabIndex = 1628
        Me.lblCastradoif.Visible = False
        '
        'lblNoExpediente
        '
        Me.lblNoExpediente.BackColor = System.Drawing.Color.Transparent
        Me.lblNoExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNoExpediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblNoExpediente.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoExpediente.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblNoExpediente.Location = New System.Drawing.Point(22, 92)
        Me.lblNoExpediente.Name = "lblNoExpediente"
        Me.lblNoExpediente.Size = New System.Drawing.Size(75, 15)
        Me.lblNoExpediente.TabIndex = 1632
        Me.lblNoExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinadoLinea
        '
        Me.lblFinadoLinea.BackColor = System.Drawing.Color.Black
        Me.lblFinadoLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFinadoLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFinadoLinea.ForeColor = System.Drawing.Color.DimGray
        Me.lblFinadoLinea.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblFinadoLinea.Location = New System.Drawing.Point(2, -1)
        Me.lblFinadoLinea.Name = "lblFinadoLinea"
        Me.lblFinadoLinea.Size = New System.Drawing.Size(5, 124)
        Me.lblFinadoLinea.TabIndex = 1633
        Me.lblFinadoLinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFinadoLinea.Visible = False
        '
        'picPaciente
        '
        Me.picPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picPaciente.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.picPaciente.Location = New System.Drawing.Point(23, 10)
        Me.picPaciente.Name = "picPaciente"
        Me.picPaciente.Size = New System.Drawing.Size(80, 80)
        Me.picPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPaciente.TabIndex = 35
        Me.picPaciente.TabStop = False
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
        Me.DaRe.ItemTemplate.Controls.Add(Me.picPaciente)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblFinadoLinea)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblNoExpediente)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblCastradoif)
        Me.DaRe.ItemTemplate.Controls.Add(Me.picEditar)
        Me.DaRe.ItemTemplate.Controls.Add(Me.Label4)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblCarrera)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblCodigo)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblNombre)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblActivo)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblCodAlumno)
        Me.DaRe.ItemTemplate.Controls.Add(Me.lblCodEspecie)
        Me.DaRe.ItemTemplate.Margin = New System.Windows.Forms.Padding(10)
        Me.DaRe.ItemTemplate.Size = New System.Drawing.Size(1269, 127)
        Me.DaRe.Location = New System.Drawing.Point(0, 140)
        Me.DaRe.Margin = New System.Windows.Forms.Padding(10)
        Me.DaRe.Name = "DaRe"
        Me.DaRe.SelectionColor = System.Drawing.Color.White
        Me.DaRe.Size = New System.Drawing.Size(1277, 513)
        Me.DaRe.TabIndex = 1618
        '
        'frmBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.splPanelFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.splPanelFondo.ResumeLayout(False)
        Me.splPanelFondo.PerformLayout()
        Me.expPagar.ResumeLayout(False)
        Me.expPagar.PerformLayout()
        CType(Me.picBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DaRe.ItemTemplate.ResumeLayout(False)
        Me.DaRe.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAltaPacienteLive As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents splPanelFondo As System.Windows.Forms.Panel
    Public WithEvents cmdSalir As System.Windows.Forms.Button
    Private WithEvents expPagar As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC11 As Panther.ucLabelRC
    Friend WithEvents optGrupo As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents optEstudiante As System.Windows.Forms.RadioButton
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents picBusqueda As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotal_ As System.Windows.Forms.Label
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Public WithEvents cmdModificar As System.Windows.Forms.Button
    Public WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents lblVertical3 As System.Windows.Forms.Label
    Friend WithEvents lblVertical4 As System.Windows.Forms.Label
    Friend WithEvents DaRe As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents picPaciente As System.Windows.Forms.PictureBox
    Friend WithEvents lblFinadoLinea As System.Windows.Forms.Label
    Friend WithEvents lblNoExpediente As System.Windows.Forms.Label
    Friend WithEvents lblCastradoif As System.Windows.Forms.Label
    Friend WithEvents picEditar As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCarrera As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblActivo As System.Windows.Forms.Label
    Friend WithEvents lblCodAlumno As System.Windows.Forms.Label
    Friend WithEvents lblCodEspecie As System.Windows.Forms.Label
    Friend WithEvents ItemTemplate As Microsoft.VisualBasic.PowerPacks.DataRepeaterItem

End Class
