<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrincipal
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        InitializeComponent()
        SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            Static fTerminateCalled As Boolean
            If Not fTerminateCalled Then
                MDIForm_Terminate_Renamed()
                fTerminateCalled = True
            End If
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.ttAgenda = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdNotificacion = New System.Windows.Forms.Label
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.BubbleBarTab2 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.BubbleButton1 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton2 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton3 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton4 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton5 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton6 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton7 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton8 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton9 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton10 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton11 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton12 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton13 = New DevComponents.DotNetBar.BubbleButton
        Me.splPanel2 = New System.Windows.Forms.Panel
        Me.bbDock = New DevComponents.DotNetBar.BubbleBar
        Me.tbLive = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.cmdAltaPacienteLive = New DevComponents.DotNetBar.BubbleButton
        Me.cmdConsultarLive = New DevComponents.DotNetBar.BubbleButton
        Me.cmdAgendaLive = New DevComponents.DotNetBar.BubbleButton
        Me.cmdProfesor = New DevComponents.DotNetBar.BubbleButton
        Me.cmdDivision = New DevComponents.DotNetBar.BubbleButton
        Me.cmdCarreras = New DevComponents.DotNetBar.BubbleButton
        Me.cmdInfos = New DevComponents.DotNetBar.BubbleButton
        Me.tblColorFull = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.cmdAltaPacienteColorFull = New DevComponents.DotNetBar.BubbleButton
        Me.cmdConsultarColorFull = New DevComponents.DotNetBar.BubbleButton
        Me.cmdAgendaColorFull = New DevComponents.DotNetBar.BubbleButton
        Me.cmdEsteticaColorFull = New DevComponents.DotNetBar.BubbleButton
        Me.cmdAlimentoColorFull = New DevComponents.DotNetBar.BubbleButton
        Me.cmdCorreoColorFull = New DevComponents.DotNetBar.BubbleButton
        Me.cmdSkinzColorFull = New DevComponents.DotNetBar.BubbleButton
        Me.cmdPuntoVentaColorFull = New DevComponents.DotNetBar.BubbleButton
        Me.cmdAyuda = New DevComponents.DotNetBar.BubbleButton
        Me.cmdCajaColorFull = New DevComponents.DotNetBar.BubbleButton
        Me.cmdInventariosColorFull = New DevComponents.DotNetBar.BubbleButton
        Me.cmdConfigurarColorFull = New DevComponents.DotNetBar.BubbleButton
        Me.tblBlue = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.cmdAltaPacienteBlue = New DevComponents.DotNetBar.BubbleButton
        Me.cmdConsultarBlue = New DevComponents.DotNetBar.BubbleButton
        Me.cmdAgendaBlue = New DevComponents.DotNetBar.BubbleButton
        Me.cmdEsteticaBlue = New DevComponents.DotNetBar.BubbleButton
        Me.cmdAlimentoBlue = New DevComponents.DotNetBar.BubbleButton
        Me.cmdCorreoBlue = New DevComponents.DotNetBar.BubbleButton
        Me.cmdSkinzBlue = New DevComponents.DotNetBar.BubbleButton
        Me.cmdPuntoVentaBlue = New DevComponents.DotNetBar.BubbleButton
        Me.cmdCajaBlue = New DevComponents.DotNetBar.BubbleButton
        Me.cmdInventariosBlue = New DevComponents.DotNetBar.BubbleButton
        Me.cmdCajaWhite = New DevComponents.DotNetBar.BubbleButton
        Me.cmdConfigurarBlue = New DevComponents.DotNetBar.BubbleButton
        Me.tblFlat = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.cmdAltaPacienteFlat = New DevComponents.DotNetBar.BubbleButton
        Me.cmdConsultarFlat = New DevComponents.DotNetBar.BubbleButton
        Me.cmdAgendaFlat = New DevComponents.DotNetBar.BubbleButton
        Me.cmdEsteticaFlat = New DevComponents.DotNetBar.BubbleButton
        Me.cmdAlimentoFlat = New DevComponents.DotNetBar.BubbleButton
        Me.cmdCorreoFlat = New DevComponents.DotNetBar.BubbleButton
        Me.cmdSkinzFlat = New DevComponents.DotNetBar.BubbleButton
        Me.cmdPuntoVentaFlat = New DevComponents.DotNetBar.BubbleButton
        Me.cmdCajaFlat = New DevComponents.DotNetBar.BubbleButton
        Me.cmdInventariosFlat = New DevComponents.DotNetBar.BubbleButton
        Me.cmdConfigurarFlat = New DevComponents.DotNetBar.BubbleButton
        Me.cmdMin = New System.Windows.Forms.Label
        Me.cmdSalir = New System.Windows.Forms.Label
        Me.lblFechaPrincipal = New System.Windows.Forms.Label
        Me.shpDock = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.btnMedico = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.picFotoMedico = New System.Windows.Forms.PictureBox
        Me.splPanel = New System.Windows.Forms.Panel
        Me.pnlTitulo = New System.Windows.Forms.Panel
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.pnlLogoEnvio = New System.Windows.Forms.Panel
        Me.pnlImagen = New System.Windows.Forms.Panel
        Me.pnlNotificacion = New System.Windows.Forms.Panel
        Me.lblProducto = New System.Windows.Forms.Label
        Me.lblNotificacion = New System.Windows.Forms.Label
        Me.picMail = New System.Windows.Forms.PictureBox
        Me.shpFondo = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.splPanelFondo = New System.Windows.Forms.Panel
        Me.splPanel2.SuspendLayout()
        CType(Me.bbDock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFotoMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splPanel.SuspendLayout()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlNotificacion.SuspendLayout()
        CType(Me.picMail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splPanelFondo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.AllowDrop = True
        resources.ApplyResources(Me.ShapeContainer2, "ShapeContainer2")
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.TabStop = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.AllowDrop = True
        resources.ApplyResources(Me.ShapeContainer3, "ShapeContainer3")
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.TabStop = False
        '
        'ttAgenda
        '
        Me.ttAgenda.BackColor = System.Drawing.Color.LightBlue
        Me.ttAgenda.IsBalloon = True
        '
        'cmdNotificacion
        '
        Me.cmdNotificacion.AllowDrop = True
        resources.ApplyResources(Me.cmdNotificacion, "cmdNotificacion")
        Me.cmdNotificacion.BackColor = System.Drawing.Color.Transparent
        Me.cmdNotificacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNotificacion.ForeColor = System.Drawing.Color.Transparent
        Me.cmdNotificacion.Name = "cmdNotificacion"
        Me.ttAgenda.SetToolTip(Me.cmdNotificacion, resources.GetString("cmdNotificacion.ToolTip"))
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 3000
        '
        'BubbleBarTab2
        '
        Me.BubbleBarTab2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BubbleBarTab2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.BubbleBarTab2.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab2.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab2.Name = "BubbleBarTab2"
        Me.BubbleBarTab2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Green
        resources.ApplyResources(Me.BubbleBarTab2, "BubbleBarTab2")
        Me.BubbleBarTab2.TextColor = System.Drawing.Color.Black
        '
        'BubbleButton1
        '
        Me.BubbleButton1.Image = CType(resources.GetObject("BubbleButton1.Image"), System.Drawing.Image)
        Me.BubbleButton1.ImageLarge = CType(resources.GetObject("BubbleButton1.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton1.Name = "BubbleButton1"
        '
        'BubbleButton2
        '
        Me.BubbleButton2.Image = CType(resources.GetObject("BubbleButton2.Image"), System.Drawing.Image)
        Me.BubbleButton2.ImageLarge = CType(resources.GetObject("BubbleButton2.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton2.Name = "BubbleButton2"
        '
        'BubbleButton3
        '
        Me.BubbleButton3.Image = CType(resources.GetObject("BubbleButton3.Image"), System.Drawing.Image)
        Me.BubbleButton3.ImageLarge = CType(resources.GetObject("BubbleButton3.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton3.Name = "BubbleButton3"
        '
        'BubbleButton4
        '
        Me.BubbleButton4.Image = CType(resources.GetObject("BubbleButton4.Image"), System.Drawing.Image)
        Me.BubbleButton4.ImageLarge = CType(resources.GetObject("BubbleButton4.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton4.Name = "BubbleButton4"
        '
        'BubbleButton5
        '
        Me.BubbleButton5.Image = CType(resources.GetObject("BubbleButton5.Image"), System.Drawing.Image)
        Me.BubbleButton5.ImageLarge = CType(resources.GetObject("BubbleButton5.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton5.Name = "BubbleButton5"
        '
        'BubbleButton6
        '
        Me.BubbleButton6.Image = CType(resources.GetObject("BubbleButton6.Image"), System.Drawing.Image)
        Me.BubbleButton6.ImageLarge = CType(resources.GetObject("BubbleButton6.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton6.Name = "BubbleButton6"
        '
        'BubbleButton7
        '
        Me.BubbleButton7.Image = CType(resources.GetObject("BubbleButton7.Image"), System.Drawing.Image)
        Me.BubbleButton7.ImageLarge = CType(resources.GetObject("BubbleButton7.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton7.Name = "BubbleButton7"
        '
        'BubbleButton8
        '
        Me.BubbleButton8.Image = CType(resources.GetObject("BubbleButton8.Image"), System.Drawing.Image)
        Me.BubbleButton8.ImageLarge = CType(resources.GetObject("BubbleButton8.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton8.Name = "BubbleButton8"
        '
        'BubbleButton9
        '
        Me.BubbleButton9.Image = CType(resources.GetObject("BubbleButton9.Image"), System.Drawing.Image)
        Me.BubbleButton9.ImageLarge = CType(resources.GetObject("BubbleButton9.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton9.Name = "BubbleButton9"
        '
        'BubbleButton10
        '
        Me.BubbleButton10.Image = CType(resources.GetObject("BubbleButton10.Image"), System.Drawing.Image)
        Me.BubbleButton10.ImageLarge = CType(resources.GetObject("BubbleButton10.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton10.Name = "BubbleButton10"
        '
        'BubbleButton11
        '
        Me.BubbleButton11.Image = CType(resources.GetObject("BubbleButton11.Image"), System.Drawing.Image)
        Me.BubbleButton11.ImageLarge = CType(resources.GetObject("BubbleButton11.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton11.Name = "BubbleButton11"
        '
        'BubbleButton12
        '
        Me.BubbleButton12.Image = CType(resources.GetObject("BubbleButton12.Image"), System.Drawing.Image)
        Me.BubbleButton12.ImageLarge = CType(resources.GetObject("BubbleButton12.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton12.Name = "BubbleButton12"
        resources.ApplyResources(Me.BubbleButton12, "BubbleButton12")
        '
        'BubbleButton13
        '
        Me.BubbleButton13.Image = CType(resources.GetObject("BubbleButton13.Image"), System.Drawing.Image)
        Me.BubbleButton13.ImageLarge = CType(resources.GetObject("BubbleButton13.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton13.Name = "BubbleButton13"
        '
        'splPanel2
        '
        Me.splPanel2.BackColor = System.Drawing.Color.LightGray
        Me.splPanel2.Controls.Add(Me.bbDock)
        Me.splPanel2.Controls.Add(Me.cmdMin)
        Me.splPanel2.Controls.Add(Me.cmdSalir)
        Me.splPanel2.Controls.Add(Me.lblFechaPrincipal)
        Me.splPanel2.Controls.Add(Me.cmdNotificacion)
        Me.splPanel2.Controls.Add(Me.shpDock)
        Me.splPanel2.Controls.Add(Me.picFotoMedico)
        resources.ApplyResources(Me.splPanel2, "splPanel2")
        Me.splPanel2.Name = "splPanel2"
        '
        'bbDock
        '
        Me.bbDock.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        resources.ApplyResources(Me.bbDock, "bbDock")
        Me.bbDock.AntiAlias = True
        Me.bbDock.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.bbDock.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.bbDock.BackgroundStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile
        Me.bbDock.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bbDock.BackgroundStyle.BorderGradientAngle = 0
        Me.bbDock.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bbDock.BackgroundStyle.BorderLightGradientAngle = 0
        Me.bbDock.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bbDock.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bbDock.BackgroundStyle.BorderTopColor = System.Drawing.Color.WhiteSmoke
        Me.bbDock.BackgroundStyle.CornerDiameter = 10
        Me.bbDock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.bbDock.BackgroundStyle.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Square
        Me.bbDock.BackgroundStyle.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Square
        Me.bbDock.BackgroundStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.bbDock.BackgroundStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.bbDock.BackgroundStyle.Name = "stlPer"
        Me.bbDock.BackgroundStyle.TextShadowColor = System.Drawing.Color.White
        Me.bbDock.BackgroundStyle.TextTrimming = DevComponents.DotNetBar.eStyleTextTrimming.None
        '
        '
        '
        Me.bbDock.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.bbDock.ButtonBackAreaStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile
        Me.bbDock.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bbDock.ButtonBackAreaStyle.BorderGradientAngle = 0
        Me.bbDock.ButtonBackAreaStyle.BorderLightGradientAngle = 0
        Me.bbDock.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.bbDock.ButtonBackAreaStyle.PaddingBottom = 6
        Me.bbDock.ButtonBackAreaStyle.PaddingLeft = 3
        Me.bbDock.ButtonBackAreaStyle.PaddingRight = 3
        Me.bbDock.ButtonBackAreaStyle.PaddingTop = 30
        Me.bbDock.ButtonBackAreaStyle.TextShadowColor = System.Drawing.Color.White
        Me.bbDock.Cursor = System.Windows.Forms.Cursors.Default
        Me.bbDock.ImageSizeLarge = New System.Drawing.Size(102, 98)
        Me.bbDock.ImageSizeNormal = New System.Drawing.Size(74, 64)
        Me.bbDock.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.bbDock.Name = "bbDock"
        Me.bbDock.SelectedTab = Me.tbLive
        Me.bbDock.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.bbDock.Tabs.Add(Me.tbLive)
        Me.bbDock.Tabs.Add(Me.tblColorFull)
        Me.bbDock.Tabs.Add(Me.tblBlue)
        Me.bbDock.Tabs.Add(Me.tblFlat)
        Me.bbDock.TooltipOutlineColor = System.Drawing.Color.Transparent
        Me.bbDock.TooltipTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'tbLive
        '
        Me.tbLive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.tbLive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.tbLive.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.cmdAltaPacienteLive, Me.cmdConsultarLive, Me.cmdAgendaLive, Me.cmdProfesor, Me.cmdDivision, Me.cmdCarreras, Me.cmdInfos})
        Me.tbLive.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.tbLive.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLive.Name = "tbLive"
        Me.tbLive.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Yellow
        resources.ApplyResources(Me.tbLive, "tbLive")
        Me.tbLive.TextColor = System.Drawing.Color.Black
        '
        'cmdAltaPacienteLive
        '
        Me.cmdAltaPacienteLive.Image = CType(resources.GetObject("cmdAltaPacienteLive.Image"), System.Drawing.Image)
        Me.cmdAltaPacienteLive.ImageLarge = CType(resources.GetObject("cmdAltaPacienteLive.ImageLarge"), System.Drawing.Image)
        Me.cmdAltaPacienteLive.Name = "cmdAltaPacienteLive"
        Me.cmdAltaPacienteLive.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlP
        Me.cmdAltaPacienteLive.Tag = ""
        resources.ApplyResources(Me.cmdAltaPacienteLive, "cmdAltaPacienteLive")
        '
        'cmdConsultarLive
        '
        Me.cmdConsultarLive.Image = CType(resources.GetObject("cmdConsultarLive.Image"), System.Drawing.Image)
        Me.cmdConsultarLive.ImageLarge = CType(resources.GetObject("cmdConsultarLive.ImageLarge"), System.Drawing.Image)
        Me.cmdConsultarLive.Name = "cmdConsultarLive"
        Me.cmdConsultarLive.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlB
        resources.ApplyResources(Me.cmdConsultarLive, "cmdConsultarLive")
        '
        'cmdAgendaLive
        '
        Me.cmdAgendaLive.Image = CType(resources.GetObject("cmdAgendaLive.Image"), System.Drawing.Image)
        Me.cmdAgendaLive.ImageLarge = CType(resources.GetObject("cmdAgendaLive.ImageLarge"), System.Drawing.Image)
        Me.cmdAgendaLive.Name = "cmdAgendaLive"
        Me.cmdAgendaLive.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlA
        resources.ApplyResources(Me.cmdAgendaLive, "cmdAgendaLive")
        '
        'cmdProfesor
        '
        Me.cmdProfesor.Image = CType(resources.GetObject("cmdProfesor.Image"), System.Drawing.Image)
        Me.cmdProfesor.ImageLarge = CType(resources.GetObject("cmdProfesor.ImageLarge"), System.Drawing.Image)
        Me.cmdProfesor.Name = "cmdProfesor"
        Me.cmdProfesor.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlF
        resources.ApplyResources(Me.cmdProfesor, "cmdProfesor")
        '
        'cmdDivision
        '
        Me.cmdDivision.Image = CType(resources.GetObject("cmdDivision.Image"), System.Drawing.Image)
        Me.cmdDivision.ImageLarge = CType(resources.GetObject("cmdDivision.ImageLarge"), System.Drawing.Image)
        Me.cmdDivision.Name = "cmdDivision"
        resources.ApplyResources(Me.cmdDivision, "cmdDivision")
        Me.cmdDivision.Visible = False
        '
        'cmdCarreras
        '
        Me.cmdCarreras.Image = CType(resources.GetObject("cmdCarreras.Image"), System.Drawing.Image)
        Me.cmdCarreras.ImageLarge = CType(resources.GetObject("cmdCarreras.ImageLarge"), System.Drawing.Image)
        Me.cmdCarreras.Name = "cmdCarreras"
        resources.ApplyResources(Me.cmdCarreras, "cmdCarreras")
        Me.cmdCarreras.Visible = False
        '
        'cmdInfos
        '
        Me.cmdInfos.Image = CType(resources.GetObject("cmdInfos.Image"), System.Drawing.Image)
        Me.cmdInfos.ImageLarge = CType(resources.GetObject("cmdInfos.ImageLarge"), System.Drawing.Image)
        Me.cmdInfos.Name = "cmdInfos"
        Me.cmdInfos.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlH
        resources.ApplyResources(Me.cmdInfos, "cmdInfos")
        '
        'tblColorFull
        '
        Me.tblColorFull.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.tblColorFull.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tblColorFull.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.cmdAltaPacienteColorFull, Me.cmdConsultarColorFull, Me.cmdAgendaColorFull, Me.cmdEsteticaColorFull, Me.cmdAlimentoColorFull, Me.cmdCorreoColorFull, Me.cmdSkinzColorFull, Me.cmdPuntoVentaColorFull, Me.cmdAyuda, Me.cmdCajaColorFull, Me.cmdInventariosColorFull, Me.cmdConfigurarColorFull})
        Me.tblColorFull.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.tblColorFull.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblColorFull.Name = "tblColorFull"
        Me.tblColorFull.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        resources.ApplyResources(Me.tblColorFull, "tblColorFull")
        Me.tblColorFull.TextColor = System.Drawing.Color.Black
        '
        'cmdAltaPacienteColorFull
        '
        Me.cmdAltaPacienteColorFull.Image = CType(resources.GetObject("cmdAltaPacienteColorFull.Image"), System.Drawing.Image)
        Me.cmdAltaPacienteColorFull.ImageLarge = CType(resources.GetObject("cmdAltaPacienteColorFull.ImageLarge"), System.Drawing.Image)
        Me.cmdAltaPacienteColorFull.Name = "cmdAltaPacienteColorFull"
        Me.cmdAltaPacienteColorFull.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlP
        resources.ApplyResources(Me.cmdAltaPacienteColorFull, "cmdAltaPacienteColorFull")
        '
        'cmdConsultarColorFull
        '
        Me.cmdConsultarColorFull.Image = CType(resources.GetObject("cmdConsultarColorFull.Image"), System.Drawing.Image)
        Me.cmdConsultarColorFull.ImageLarge = CType(resources.GetObject("cmdConsultarColorFull.ImageLarge"), System.Drawing.Image)
        Me.cmdConsultarColorFull.Name = "cmdConsultarColorFull"
        Me.cmdConsultarColorFull.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlB
        resources.ApplyResources(Me.cmdConsultarColorFull, "cmdConsultarColorFull")
        '
        'cmdAgendaColorFull
        '
        Me.cmdAgendaColorFull.Image = CType(resources.GetObject("cmdAgendaColorFull.Image"), System.Drawing.Image)
        Me.cmdAgendaColorFull.ImageLarge = CType(resources.GetObject("cmdAgendaColorFull.ImageLarge"), System.Drawing.Image)
        Me.cmdAgendaColorFull.Name = "cmdAgendaColorFull"
        Me.cmdAgendaColorFull.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlA
        resources.ApplyResources(Me.cmdAgendaColorFull, "cmdAgendaColorFull")
        '
        'cmdEsteticaColorFull
        '
        Me.cmdEsteticaColorFull.Image = CType(resources.GetObject("cmdEsteticaColorFull.Image"), System.Drawing.Image)
        Me.cmdEsteticaColorFull.ImageLarge = CType(resources.GetObject("cmdEsteticaColorFull.ImageLarge"), System.Drawing.Image)
        Me.cmdEsteticaColorFull.Name = "cmdEsteticaColorFull"
        Me.cmdEsteticaColorFull.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlE
        resources.ApplyResources(Me.cmdEsteticaColorFull, "cmdEsteticaColorFull")
        '
        'cmdAlimentoColorFull
        '
        Me.cmdAlimentoColorFull.Image = CType(resources.GetObject("cmdAlimentoColorFull.Image"), System.Drawing.Image)
        Me.cmdAlimentoColorFull.ImageLarge = CType(resources.GetObject("cmdAlimentoColorFull.ImageLarge"), System.Drawing.Image)
        Me.cmdAlimentoColorFull.Name = "cmdAlimentoColorFull"
        Me.cmdAlimentoColorFull.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlF
        resources.ApplyResources(Me.cmdAlimentoColorFull, "cmdAlimentoColorFull")
        '
        'cmdCorreoColorFull
        '
        Me.cmdCorreoColorFull.Image = CType(resources.GetObject("cmdCorreoColorFull.Image"), System.Drawing.Image)
        Me.cmdCorreoColorFull.ImageLarge = CType(resources.GetObject("cmdCorreoColorFull.ImageLarge"), System.Drawing.Image)
        Me.cmdCorreoColorFull.Name = "cmdCorreoColorFull"
        Me.cmdCorreoColorFull.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlM
        resources.ApplyResources(Me.cmdCorreoColorFull, "cmdCorreoColorFull")
        '
        'cmdSkinzColorFull
        '
        Me.cmdSkinzColorFull.Image = CType(resources.GetObject("cmdSkinzColorFull.Image"), System.Drawing.Image)
        Me.cmdSkinzColorFull.ImageLarge = CType(resources.GetObject("cmdSkinzColorFull.ImageLarge"), System.Drawing.Image)
        Me.cmdSkinzColorFull.Name = "cmdSkinzColorFull"
        Me.cmdSkinzColorFull.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlT
        resources.ApplyResources(Me.cmdSkinzColorFull, "cmdSkinzColorFull")
        '
        'cmdPuntoVentaColorFull
        '
        Me.cmdPuntoVentaColorFull.Image = CType(resources.GetObject("cmdPuntoVentaColorFull.Image"), System.Drawing.Image)
        Me.cmdPuntoVentaColorFull.ImageLarge = CType(resources.GetObject("cmdPuntoVentaColorFull.ImageLarge"), System.Drawing.Image)
        Me.cmdPuntoVentaColorFull.Name = "cmdPuntoVentaColorFull"
        Me.cmdPuntoVentaColorFull.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlP
        resources.ApplyResources(Me.cmdPuntoVentaColorFull, "cmdPuntoVentaColorFull")
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Image = CType(resources.GetObject("cmdAyuda.Image"), System.Drawing.Image)
        Me.cmdAyuda.ImageLarge = CType(resources.GetObject("cmdAyuda.ImageLarge"), System.Drawing.Image)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlH
        resources.ApplyResources(Me.cmdAyuda, "cmdAyuda")
        Me.cmdAyuda.Visible = False
        '
        'cmdCajaColorFull
        '
        Me.cmdCajaColorFull.Image = CType(resources.GetObject("cmdCajaColorFull.Image"), System.Drawing.Image)
        Me.cmdCajaColorFull.ImageLarge = CType(resources.GetObject("cmdCajaColorFull.ImageLarge"), System.Drawing.Image)
        Me.cmdCajaColorFull.Name = "cmdCajaColorFull"
        resources.ApplyResources(Me.cmdCajaColorFull, "cmdCajaColorFull")
        '
        'cmdInventariosColorFull
        '
        Me.cmdInventariosColorFull.Image = CType(resources.GetObject("cmdInventariosColorFull.Image"), System.Drawing.Image)
        Me.cmdInventariosColorFull.ImageLarge = CType(resources.GetObject("cmdInventariosColorFull.ImageLarge"), System.Drawing.Image)
        Me.cmdInventariosColorFull.Name = "cmdInventariosColorFull"
        Me.cmdInventariosColorFull.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlR
        resources.ApplyResources(Me.cmdInventariosColorFull, "cmdInventariosColorFull")
        '
        'cmdConfigurarColorFull
        '
        Me.cmdConfigurarColorFull.Image = CType(resources.GetObject("cmdConfigurarColorFull.Image"), System.Drawing.Image)
        Me.cmdConfigurarColorFull.ImageLarge = CType(resources.GetObject("cmdConfigurarColorFull.ImageLarge"), System.Drawing.Image)
        Me.cmdConfigurarColorFull.Name = "cmdConfigurarColorFull"
        Me.cmdConfigurarColorFull.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlS
        resources.ApplyResources(Me.cmdConfigurarColorFull, "cmdConfigurarColorFull")
        '
        'tblBlue
        '
        Me.tblBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tblBlue.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.tblBlue.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.cmdAltaPacienteBlue, Me.cmdConsultarBlue, Me.cmdAgendaBlue, Me.cmdEsteticaBlue, Me.cmdAlimentoBlue, Me.cmdCorreoBlue, Me.cmdSkinzBlue, Me.cmdPuntoVentaBlue, Me.cmdCajaBlue, Me.cmdInventariosBlue, Me.cmdCajaWhite, Me.cmdConfigurarBlue})
        Me.tblBlue.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.tblBlue.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblBlue.Name = "tblBlue"
        Me.tblBlue.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Green
        resources.ApplyResources(Me.tblBlue, "tblBlue")
        Me.tblBlue.TextColor = System.Drawing.Color.Black
        '
        'cmdAltaPacienteBlue
        '
        Me.cmdAltaPacienteBlue.Image = CType(resources.GetObject("cmdAltaPacienteBlue.Image"), System.Drawing.Image)
        Me.cmdAltaPacienteBlue.ImageLarge = CType(resources.GetObject("cmdAltaPacienteBlue.ImageLarge"), System.Drawing.Image)
        Me.cmdAltaPacienteBlue.Name = "cmdAltaPacienteBlue"
        Me.cmdAltaPacienteBlue.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlP
        resources.ApplyResources(Me.cmdAltaPacienteBlue, "cmdAltaPacienteBlue")
        '
        'cmdConsultarBlue
        '
        Me.cmdConsultarBlue.Image = CType(resources.GetObject("cmdConsultarBlue.Image"), System.Drawing.Image)
        Me.cmdConsultarBlue.ImageLarge = CType(resources.GetObject("cmdConsultarBlue.ImageLarge"), System.Drawing.Image)
        Me.cmdConsultarBlue.Name = "cmdConsultarBlue"
        Me.cmdConsultarBlue.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlB
        resources.ApplyResources(Me.cmdConsultarBlue, "cmdConsultarBlue")
        '
        'cmdAgendaBlue
        '
        Me.cmdAgendaBlue.Image = CType(resources.GetObject("cmdAgendaBlue.Image"), System.Drawing.Image)
        Me.cmdAgendaBlue.ImageLarge = CType(resources.GetObject("cmdAgendaBlue.ImageLarge"), System.Drawing.Image)
        Me.cmdAgendaBlue.Name = "cmdAgendaBlue"
        Me.cmdAgendaBlue.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlA
        resources.ApplyResources(Me.cmdAgendaBlue, "cmdAgendaBlue")
        '
        'cmdEsteticaBlue
        '
        Me.cmdEsteticaBlue.Image = CType(resources.GetObject("cmdEsteticaBlue.Image"), System.Drawing.Image)
        Me.cmdEsteticaBlue.ImageLarge = CType(resources.GetObject("cmdEsteticaBlue.ImageLarge"), System.Drawing.Image)
        Me.cmdEsteticaBlue.Name = "cmdEsteticaBlue"
        Me.cmdEsteticaBlue.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlE
        resources.ApplyResources(Me.cmdEsteticaBlue, "cmdEsteticaBlue")
        '
        'cmdAlimentoBlue
        '
        Me.cmdAlimentoBlue.Image = CType(resources.GetObject("cmdAlimentoBlue.Image"), System.Drawing.Image)
        Me.cmdAlimentoBlue.ImageLarge = CType(resources.GetObject("cmdAlimentoBlue.ImageLarge"), System.Drawing.Image)
        Me.cmdAlimentoBlue.Name = "cmdAlimentoBlue"
        Me.cmdAlimentoBlue.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlF
        resources.ApplyResources(Me.cmdAlimentoBlue, "cmdAlimentoBlue")
        '
        'cmdCorreoBlue
        '
        Me.cmdCorreoBlue.Image = CType(resources.GetObject("cmdCorreoBlue.Image"), System.Drawing.Image)
        Me.cmdCorreoBlue.ImageLarge = CType(resources.GetObject("cmdCorreoBlue.ImageLarge"), System.Drawing.Image)
        Me.cmdCorreoBlue.Name = "cmdCorreoBlue"
        Me.cmdCorreoBlue.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlM
        resources.ApplyResources(Me.cmdCorreoBlue, "cmdCorreoBlue")
        '
        'cmdSkinzBlue
        '
        Me.cmdSkinzBlue.Image = CType(resources.GetObject("cmdSkinzBlue.Image"), System.Drawing.Image)
        Me.cmdSkinzBlue.ImageLarge = CType(resources.GetObject("cmdSkinzBlue.ImageLarge"), System.Drawing.Image)
        Me.cmdSkinzBlue.Name = "cmdSkinzBlue"
        Me.cmdSkinzBlue.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlT
        resources.ApplyResources(Me.cmdSkinzBlue, "cmdSkinzBlue")
        '
        'cmdPuntoVentaBlue
        '
        Me.cmdPuntoVentaBlue.Image = CType(resources.GetObject("cmdPuntoVentaBlue.Image"), System.Drawing.Image)
        Me.cmdPuntoVentaBlue.ImageLarge = CType(resources.GetObject("cmdPuntoVentaBlue.ImageLarge"), System.Drawing.Image)
        Me.cmdPuntoVentaBlue.Name = "cmdPuntoVentaBlue"
        Me.cmdPuntoVentaBlue.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlP
        resources.ApplyResources(Me.cmdPuntoVentaBlue, "cmdPuntoVentaBlue")
        '
        'cmdCajaBlue
        '
        Me.cmdCajaBlue.Image = CType(resources.GetObject("cmdCajaBlue.Image"), System.Drawing.Image)
        Me.cmdCajaBlue.ImageLarge = CType(resources.GetObject("cmdCajaBlue.ImageLarge"), System.Drawing.Image)
        Me.cmdCajaBlue.Name = "cmdCajaBlue"
        resources.ApplyResources(Me.cmdCajaBlue, "cmdCajaBlue")
        '
        'cmdInventariosBlue
        '
        Me.cmdInventariosBlue.Image = CType(resources.GetObject("cmdInventariosBlue.Image"), System.Drawing.Image)
        Me.cmdInventariosBlue.ImageLarge = CType(resources.GetObject("cmdInventariosBlue.ImageLarge"), System.Drawing.Image)
        Me.cmdInventariosBlue.Name = "cmdInventariosBlue"
        Me.cmdInventariosBlue.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlR
        resources.ApplyResources(Me.cmdInventariosBlue, "cmdInventariosBlue")
        '
        'cmdCajaWhite
        '
        Me.cmdCajaWhite.Image = CType(resources.GetObject("cmdCajaWhite.Image"), System.Drawing.Image)
        Me.cmdCajaWhite.ImageLarge = CType(resources.GetObject("cmdCajaWhite.ImageLarge"), System.Drawing.Image)
        Me.cmdCajaWhite.Name = "cmdCajaWhite"
        Me.cmdCajaWhite.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlH
        resources.ApplyResources(Me.cmdCajaWhite, "cmdCajaWhite")
        Me.cmdCajaWhite.Visible = False
        '
        'cmdConfigurarBlue
        '
        Me.cmdConfigurarBlue.Image = CType(resources.GetObject("cmdConfigurarBlue.Image"), System.Drawing.Image)
        Me.cmdConfigurarBlue.ImageLarge = CType(resources.GetObject("cmdConfigurarBlue.ImageLarge"), System.Drawing.Image)
        Me.cmdConfigurarBlue.Name = "cmdConfigurarBlue"
        Me.cmdConfigurarBlue.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlS
        resources.ApplyResources(Me.cmdConfigurarBlue, "cmdConfigurarBlue")
        '
        'tblFlat
        '
        Me.tblFlat.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.tblFlat.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.tblFlat.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.cmdAltaPacienteFlat, Me.cmdConsultarFlat, Me.cmdAgendaFlat, Me.cmdEsteticaFlat, Me.cmdAlimentoFlat, Me.cmdCorreoFlat, Me.cmdSkinzFlat, Me.cmdPuntoVentaFlat, Me.cmdCajaFlat, Me.cmdInventariosFlat, Me.cmdConfigurarFlat})
        Me.tblFlat.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.tblFlat.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblFlat.Name = "tblFlat"
        Me.tblFlat.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Purple
        resources.ApplyResources(Me.tblFlat, "tblFlat")
        Me.tblFlat.TextColor = System.Drawing.Color.Black
        '
        'cmdAltaPacienteFlat
        '
        Me.cmdAltaPacienteFlat.Image = CType(resources.GetObject("cmdAltaPacienteFlat.Image"), System.Drawing.Image)
        Me.cmdAltaPacienteFlat.ImageLarge = CType(resources.GetObject("cmdAltaPacienteFlat.ImageLarge"), System.Drawing.Image)
        Me.cmdAltaPacienteFlat.Name = "cmdAltaPacienteFlat"
        resources.ApplyResources(Me.cmdAltaPacienteFlat, "cmdAltaPacienteFlat")
        '
        'cmdConsultarFlat
        '
        Me.cmdConsultarFlat.Image = CType(resources.GetObject("cmdConsultarFlat.Image"), System.Drawing.Image)
        Me.cmdConsultarFlat.ImageLarge = CType(resources.GetObject("cmdConsultarFlat.ImageLarge"), System.Drawing.Image)
        Me.cmdConsultarFlat.Name = "cmdConsultarFlat"
        resources.ApplyResources(Me.cmdConsultarFlat, "cmdConsultarFlat")
        '
        'cmdAgendaFlat
        '
        Me.cmdAgendaFlat.Image = CType(resources.GetObject("cmdAgendaFlat.Image"), System.Drawing.Image)
        Me.cmdAgendaFlat.ImageLarge = CType(resources.GetObject("cmdAgendaFlat.ImageLarge"), System.Drawing.Image)
        Me.cmdAgendaFlat.Name = "cmdAgendaFlat"
        resources.ApplyResources(Me.cmdAgendaFlat, "cmdAgendaFlat")
        '
        'cmdEsteticaFlat
        '
        Me.cmdEsteticaFlat.Image = CType(resources.GetObject("cmdEsteticaFlat.Image"), System.Drawing.Image)
        Me.cmdEsteticaFlat.ImageLarge = CType(resources.GetObject("cmdEsteticaFlat.ImageLarge"), System.Drawing.Image)
        Me.cmdEsteticaFlat.Name = "cmdEsteticaFlat"
        resources.ApplyResources(Me.cmdEsteticaFlat, "cmdEsteticaFlat")
        '
        'cmdAlimentoFlat
        '
        Me.cmdAlimentoFlat.Image = CType(resources.GetObject("cmdAlimentoFlat.Image"), System.Drawing.Image)
        Me.cmdAlimentoFlat.ImageLarge = CType(resources.GetObject("cmdAlimentoFlat.ImageLarge"), System.Drawing.Image)
        Me.cmdAlimentoFlat.Name = "cmdAlimentoFlat"
        resources.ApplyResources(Me.cmdAlimentoFlat, "cmdAlimentoFlat")
        '
        'cmdCorreoFlat
        '
        Me.cmdCorreoFlat.Image = CType(resources.GetObject("cmdCorreoFlat.Image"), System.Drawing.Image)
        Me.cmdCorreoFlat.ImageLarge = CType(resources.GetObject("cmdCorreoFlat.ImageLarge"), System.Drawing.Image)
        Me.cmdCorreoFlat.Name = "cmdCorreoFlat"
        resources.ApplyResources(Me.cmdCorreoFlat, "cmdCorreoFlat")
        '
        'cmdSkinzFlat
        '
        Me.cmdSkinzFlat.Image = CType(resources.GetObject("cmdSkinzFlat.Image"), System.Drawing.Image)
        Me.cmdSkinzFlat.ImageLarge = CType(resources.GetObject("cmdSkinzFlat.ImageLarge"), System.Drawing.Image)
        Me.cmdSkinzFlat.Name = "cmdSkinzFlat"
        resources.ApplyResources(Me.cmdSkinzFlat, "cmdSkinzFlat")
        '
        'cmdPuntoVentaFlat
        '
        Me.cmdPuntoVentaFlat.Image = CType(resources.GetObject("cmdPuntoVentaFlat.Image"), System.Drawing.Image)
        Me.cmdPuntoVentaFlat.ImageLarge = CType(resources.GetObject("cmdPuntoVentaFlat.ImageLarge"), System.Drawing.Image)
        Me.cmdPuntoVentaFlat.Name = "cmdPuntoVentaFlat"
        resources.ApplyResources(Me.cmdPuntoVentaFlat, "cmdPuntoVentaFlat")
        '
        'cmdCajaFlat
        '
        Me.cmdCajaFlat.Image = CType(resources.GetObject("cmdCajaFlat.Image"), System.Drawing.Image)
        Me.cmdCajaFlat.ImageLarge = CType(resources.GetObject("cmdCajaFlat.ImageLarge"), System.Drawing.Image)
        Me.cmdCajaFlat.Name = "cmdCajaFlat"
        resources.ApplyResources(Me.cmdCajaFlat, "cmdCajaFlat")
        '
        'cmdInventariosFlat
        '
        Me.cmdInventariosFlat.Image = CType(resources.GetObject("cmdInventariosFlat.Image"), System.Drawing.Image)
        Me.cmdInventariosFlat.ImageLarge = CType(resources.GetObject("cmdInventariosFlat.ImageLarge"), System.Drawing.Image)
        Me.cmdInventariosFlat.Name = "cmdInventariosFlat"
        resources.ApplyResources(Me.cmdInventariosFlat, "cmdInventariosFlat")
        '
        'cmdConfigurarFlat
        '
        Me.cmdConfigurarFlat.Image = CType(resources.GetObject("cmdConfigurarFlat.Image"), System.Drawing.Image)
        Me.cmdConfigurarFlat.ImageLarge = CType(resources.GetObject("cmdConfigurarFlat.ImageLarge"), System.Drawing.Image)
        Me.cmdConfigurarFlat.Name = "cmdConfigurarFlat"
        resources.ApplyResources(Me.cmdConfigurarFlat, "cmdConfigurarFlat")
        '
        'cmdMin
        '
        Me.cmdMin.BackColor = System.Drawing.Color.Transparent
        Me.cmdMin.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.cmdMin, "cmdMin")
        Me.cmdMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMin.ForeColor = System.Drawing.Color.White
        Me.cmdMin.Name = "cmdMin"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.Transparent
        Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.cmdSalir, "cmdSalir")
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSalir.ForeColor = System.Drawing.Color.DarkGray
        Me.cmdSalir.Name = "cmdSalir"
        '
        'lblFechaPrincipal
        '
        resources.ApplyResources(Me.lblFechaPrincipal, "lblFechaPrincipal")
        Me.lblFechaPrincipal.ForeColor = System.Drawing.Color.White
        Me.lblFechaPrincipal.Name = "lblFechaPrincipal"
        '
        'shpDock
        '
        resources.ApplyResources(Me.shpDock, "shpDock")
        Me.shpDock.Name = "shpDock"
        Me.shpDock.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.btnMedico})
        Me.shpDock.TabStop = False
        '
        'btnMedico
        '
        resources.ApplyResources(Me.btnMedico, "btnMedico")
        Me.btnMedico.BackColor = System.Drawing.Color.Transparent
        Me.btnMedico.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMedico.Name = "btnMedico"
        '
        'picFotoMedico
        '
        resources.ApplyResources(Me.picFotoMedico, "picFotoMedico")
        Me.picFotoMedico.Name = "picFotoMedico"
        Me.picFotoMedico.TabStop = False
        '
        'splPanel
        '
        Me.splPanel.Controls.Add(Me.pnlTitulo)
        Me.splPanel.Controls.Add(Me.pnlNotificacion)
        Me.splPanel.Controls.Add(Me.shpFondo)
        resources.ApplyResources(Me.splPanel, "splPanel")
        Me.splPanel.Name = "splPanel"
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.Black
        Me.pnlTitulo.Controls.Add(Me.lblMensaje)
        Me.pnlTitulo.Controls.Add(Me.cmdAceptar)
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Controls.Add(Me.pnlLogoEnvio)
        Me.pnlTitulo.Controls.Add(Me.pnlImagen)
        resources.ApplyResources(Me.pnlTitulo, "pnlTitulo")
        Me.pnlTitulo.Name = "pnlTitulo"
        '
        'lblMensaje
        '
        resources.ApplyResources(Me.lblMensaje, "lblMensaje")
        Me.lblMensaje.ForeColor = System.Drawing.Color.White
        Me.lblMensaje.Name = "lblMensaje"
        '
        'cmdAceptar
        '
        resources.ApplyResources(Me.cmdAceptar, "cmdAceptar")
        Me.cmdAceptar.BackColor = System.Drawing.Color.Transparent
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdAceptar.FlatAppearance.BorderSize = 0
        Me.cmdAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAceptar.ForeColor = System.Drawing.Color.White
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Name = "lblTitulo"
        '
        'pnlLogoEnvio
        '
        Me.pnlLogoEnvio.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.pnlLogoEnvio, "pnlLogoEnvio")
        Me.pnlLogoEnvio.Name = "pnlLogoEnvio"
        '
        'pnlImagen
        '
        Me.pnlImagen.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.pnlImagen, "pnlImagen")
        Me.pnlImagen.Name = "pnlImagen"
        '
        'pnlNotificacion
        '
        Me.pnlNotificacion.BackColor = System.Drawing.Color.White
        Me.pnlNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNotificacion.Controls.Add(Me.lblProducto)
        Me.pnlNotificacion.Controls.Add(Me.lblNotificacion)
        Me.pnlNotificacion.Controls.Add(Me.picMail)
        resources.ApplyResources(Me.pnlNotificacion, "pnlNotificacion")
        Me.pnlNotificacion.Name = "pnlNotificacion"
        '
        'lblProducto
        '
        resources.ApplyResources(Me.lblProducto, "lblProducto")
        Me.lblProducto.BackColor = System.Drawing.Color.Transparent
        Me.lblProducto.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblProducto.Name = "lblProducto"
        '
        'lblNotificacion
        '
        resources.ApplyResources(Me.lblNotificacion, "lblNotificacion")
        Me.lblNotificacion.BackColor = System.Drawing.Color.Transparent
        Me.lblNotificacion.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNotificacion.Name = "lblNotificacion"
        '
        'picMail
        '
        resources.ApplyResources(Me.picMail, "picMail")
        Me.picMail.Name = "picMail"
        Me.picMail.TabStop = False
        '
        'shpFondo
        '
        resources.ApplyResources(Me.shpFondo, "shpFondo")
        Me.shpFondo.Name = "shpFondo"
        Me.shpFondo.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.shpFondo.TabStop = False
        '
        'RectangleShape1
        '
        resources.ApplyResources(Me.RectangleShape1, "RectangleShape1")
        Me.RectangleShape1.BackColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape1.Name = "RectangleShape1"
        '
        'splPanelFondo
        '
        Me.splPanelFondo.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        resources.ApplyResources(Me.splPanelFondo, "splPanelFondo")
        Me.splPanelFondo.Controls.Add(Me.splPanel)
        Me.splPanelFondo.Controls.Add(Me.splPanel2)
        Me.splPanelFondo.Name = "splPanelFondo"
        '
        'frmPrincipal
        '
        Me.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me, "$this")
        Me.ControlBox = False
        Me.Controls.Add(Me.splPanelFondo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "frmPrincipal"
        Me.Tag = "0190"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.splPanel2.ResumeLayout(False)
        CType(Me.bbDock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFotoMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splPanel.ResumeLayout(False)
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlNotificacion.ResumeLayout(False)
        Me.pnlNotificacion.PerformLayout()
        CType(Me.picMail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splPanelFondo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ttAgenda As System.Windows.Forms.ToolTip
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents BubbleBarTab2 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents BubbleButton1 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton2 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton3 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton4 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton5 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton6 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton7 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton8 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton9 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton10 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton11 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton12 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton13 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents splPanel2 As System.Windows.Forms.Panel
    Friend WithEvents bbDock As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents tbLive As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents cmdAltaPacienteLive As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdConsultarLive As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdAgendaLive As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdProfesor As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdInfos As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents tblColorFull As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents cmdAltaPacienteColorFull As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdConsultarColorFull As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdAgendaColorFull As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdEsteticaColorFull As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdAlimentoColorFull As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdCorreoColorFull As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdSkinzColorFull As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdPuntoVentaColorFull As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdAyuda As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdCajaColorFull As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdInventariosColorFull As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdConfigurarColorFull As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents tblBlue As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents cmdAltaPacienteBlue As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdConsultarBlue As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdAgendaBlue As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdEsteticaBlue As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdAlimentoBlue As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdCorreoBlue As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdSkinzBlue As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdPuntoVentaBlue As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdCajaBlue As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdInventariosBlue As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdCajaWhite As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdConfigurarBlue As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents tblFlat As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents cmdAltaPacienteFlat As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdConsultarFlat As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdAgendaFlat As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdEsteticaFlat As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdAlimentoFlat As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdCorreoFlat As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdSkinzFlat As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdPuntoVentaFlat As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdCajaFlat As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdInventariosFlat As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdConfigurarFlat As DevComponents.DotNetBar.BubbleButton
    Public WithEvents cmdMin As System.Windows.Forms.Label
    Public WithEvents cmdSalir As System.Windows.Forms.Label
    Friend WithEvents lblFechaPrincipal As System.Windows.Forms.Label
    Friend WithEvents cmdNotificacion As System.Windows.Forms.Label
    Friend WithEvents shpDock As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btnMedico As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents picFotoMedico As System.Windows.Forms.PictureBox
    Friend WithEvents splPanel As System.Windows.Forms.Panel
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pnlLogoEnvio As System.Windows.Forms.Panel
    Friend WithEvents pnlImagen As System.Windows.Forms.Panel
    Friend WithEvents pnlNotificacion As System.Windows.Forms.Panel
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents lblNotificacion As System.Windows.Forms.Label
    Friend WithEvents picMail As System.Windows.Forms.PictureBox
    Friend WithEvents shpFondo As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents splPanelFondo As System.Windows.Forms.Panel
    Friend WithEvents cmdDivision As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents cmdCarreras As DevComponents.DotNetBar.BubbleButton
#End Region
End Class