<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportes))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.cmdAltaPacienteLive = New DevComponents.DotNetBar.BubbleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label106 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.PageSliderReportes = New DevComponents.DotNetBar.Controls.PageSlider
        Me.pgsFondo1 = New DevComponents.DotNetBar.Controls.PageSliderPage
        Me.cmdSemestral = New System.Windows.Forms.Button
        Me.cmdDia = New System.Windows.Forms.Button
        Me.cmdGrupo = New System.Windows.Forms.Button
        Me.cmdAlumnos = New System.Windows.Forms.Button
        Me.pgsFondo2 = New DevComponents.DotNetBar.Controls.PageSliderPage
        Me.cmdVerReporte = New System.Windows.Forms.Button
        Me.dtFechaIni = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.dtFechaFin = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdAlumnos = New System.Windows.Forms.DataGridView
        Me.colAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Grupo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_NombreAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_CodigoAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Carrera = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colVer = New System.Windows.Forms.DataGridViewImageColumn
        Me.cmdReturn = New System.Windows.Forms.Button
        Me.grdGrupos = New System.Windows.Forms.DataGridView
        Me.coliCodGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coliCodProfesor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colProfesor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCurso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDias = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoraIni = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEditar = New System.Windows.Forms.DataGridViewImageColumn
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PageSliderReportes.SuspendLayout()
        Me.pgsFondo1.SuspendLayout()
        Me.pgsFondo2.SuspendLayout()
        CType(Me.dtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 514)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label106)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cmdSalir)
        Me.Panel2.Controls.Add(Me.PageSliderReportes)
        Me.Panel2.Location = New System.Drawing.Point(15, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(685, 484)
        Me.Panel2.TabIndex = 1
        '
        'Label106
        '
        Me.Label106.BackColor = System.Drawing.Color.LightGray
        Me.Label106.Location = New System.Drawing.Point(1, 58)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(683, 1)
        Me.Label106.TabIndex = 1799
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Helvetica-Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(226, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 41)
        Me.Label5.TabIndex = 1637
        Me.Label5.Text = "Reportes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.cmdSalir.Location = New System.Drawing.Point(625, 2)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(57, 58)
        Me.cmdSalir.TabIndex = 381
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'PageSliderReportes
        '
        Me.PageSliderReportes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PageSliderReportes.AnimationTime = 300
        Me.PageSliderReportes.BackColor = System.Drawing.Color.White
        Me.PageSliderReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PageSliderReportes.Controls.Add(Me.pgsFondo1)
        Me.PageSliderReportes.Controls.Add(Me.pgsFondo2)
        Me.PageSliderReportes.Location = New System.Drawing.Point(3, 65)
        Me.PageSliderReportes.Name = "PageSliderReportes"
        Me.PageSliderReportes.NextPageVisibleMargin = -4
        Me.PageSliderReportes.PageMouseDragEnabled = False
        Me.PageSliderReportes.PageSpacing = 30
        Me.PageSliderReportes.ScrollBarVisibility = DevComponents.DotNetBar.Controls.eScrollBarVisibility.Hidden
        Me.PageSliderReportes.SelectedPage = Me.pgsFondo1
        Me.PageSliderReportes.Size = New System.Drawing.Size(682, 409)
        Me.PageSliderReportes.TabIndex = 1636
        '
        'pgsFondo1
        '
        Me.pgsFondo1.AllowDrop = True
        Me.pgsFondo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pgsFondo1.Controls.Add(Me.cmdSemestral)
        Me.pgsFondo1.Controls.Add(Me.cmdDia)
        Me.pgsFondo1.Controls.Add(Me.cmdGrupo)
        Me.pgsFondo1.Controls.Add(Me.cmdAlumnos)
        Me.pgsFondo1.Location = New System.Drawing.Point(4, 8)
        Me.pgsFondo1.Name = "pgsFondo1"
        Me.pgsFondo1.Size = New System.Drawing.Size(648, 397)
        Me.pgsFondo1.TabIndex = 4
        '
        'cmdSemestral
        '
        Me.cmdSemestral.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSemestral.BackColor = System.Drawing.Color.White
        Me.cmdSemestral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSemestral.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdSemestral.FlatAppearance.BorderSize = 0
        Me.cmdSemestral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdSemestral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdSemestral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSemestral.Font = New System.Drawing.Font("Helvetica-Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSemestral.ForeColor = System.Drawing.Color.DimGray
        Me.cmdSemestral.Image = CType(resources.GetObject("cmdSemestral.Image"), System.Drawing.Image)
        Me.cmdSemestral.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSemestral.Location = New System.Drawing.Point(333, 219)
        Me.cmdSemestral.Name = "cmdSemestral"
        Me.cmdSemestral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSemestral.Size = New System.Drawing.Size(132, 104)
        Me.cmdSemestral.TabIndex = 1637
        Me.cmdSemestral.Text = "Reporte semestral"
        Me.cmdSemestral.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSemestral.UseVisualStyleBackColor = False
        '
        'cmdDia
        '
        Me.cmdDia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdDia.BackColor = System.Drawing.Color.White
        Me.cmdDia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDia.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdDia.FlatAppearance.BorderSize = 0
        Me.cmdDia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDia.Font = New System.Drawing.Font("Helvetica-Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDia.ForeColor = System.Drawing.Color.DimGray
        Me.cmdDia.Image = CType(resources.GetObject("cmdDia.Image"), System.Drawing.Image)
        Me.cmdDia.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDia.Location = New System.Drawing.Point(183, 219)
        Me.cmdDia.Name = "cmdDia"
        Me.cmdDia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDia.Size = New System.Drawing.Size(132, 87)
        Me.cmdDia.TabIndex = 1636
        Me.cmdDia.Text = "Reporte p/dia"
        Me.cmdDia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDia.UseVisualStyleBackColor = False
        '
        'cmdGrupo
        '
        Me.cmdGrupo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdGrupo.BackColor = System.Drawing.Color.White
        Me.cmdGrupo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGrupo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdGrupo.FlatAppearance.BorderSize = 0
        Me.cmdGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGrupo.Font = New System.Drawing.Font("Helvetica-Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrupo.ForeColor = System.Drawing.Color.DimGray
        Me.cmdGrupo.Image = CType(resources.GetObject("cmdGrupo.Image"), System.Drawing.Image)
        Me.cmdGrupo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdGrupo.Location = New System.Drawing.Point(333, 67)
        Me.cmdGrupo.Name = "cmdGrupo"
        Me.cmdGrupo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGrupo.Size = New System.Drawing.Size(132, 87)
        Me.cmdGrupo.TabIndex = 1635
        Me.cmdGrupo.Text = "Grupal"
        Me.cmdGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdGrupo.UseVisualStyleBackColor = False
        '
        'cmdAlumnos
        '
        Me.cmdAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdAlumnos.BackColor = System.Drawing.Color.White
        Me.cmdAlumnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdAlumnos.FlatAppearance.BorderSize = 0
        Me.cmdAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAlumnos.Font = New System.Drawing.Font("Helvetica-Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAlumnos.ForeColor = System.Drawing.Color.DimGray
        Me.cmdAlumnos.Image = CType(resources.GetObject("cmdAlumnos.Image"), System.Drawing.Image)
        Me.cmdAlumnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAlumnos.Location = New System.Drawing.Point(183, 67)
        Me.cmdAlumnos.Name = "cmdAlumnos"
        Me.cmdAlumnos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAlumnos.Size = New System.Drawing.Size(132, 87)
        Me.cmdAlumnos.TabIndex = 1634
        Me.cmdAlumnos.Text = "Alumnos"
        Me.cmdAlumnos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAlumnos.UseVisualStyleBackColor = False
        '
        'pgsFondo2
        '
        Me.pgsFondo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pgsFondo2.Controls.Add(Me.cmdVerReporte)
        Me.pgsFondo2.Controls.Add(Me.dtFechaIni)
        Me.pgsFondo2.Controls.Add(Me.dtFechaFin)
        Me.pgsFondo2.Controls.Add(Me.Label24)
        Me.pgsFondo2.Controls.Add(Me.Label1)
        Me.pgsFondo2.Controls.Add(Me.grdAlumnos)
        Me.pgsFondo2.Controls.Add(Me.cmdReturn)
        Me.pgsFondo2.Controls.Add(Me.grdGrupos)
        Me.pgsFondo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgsFondo2.Location = New System.Drawing.Point(682, 8)
        Me.pgsFondo2.Margin = New System.Windows.Forms.Padding(0)
        Me.pgsFondo2.Name = "pgsFondo2"
        Me.pgsFondo2.Size = New System.Drawing.Size(648, 397)
        Me.pgsFondo2.TabIndex = 5
        '
        'cmdVerReporte
        '
        Me.cmdVerReporte.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdVerReporte.BackColor = System.Drawing.Color.White
        Me.cmdVerReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdVerReporte.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdVerReporte.FlatAppearance.BorderSize = 0
        Me.cmdVerReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdVerReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdVerReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdVerReporte.Font = New System.Drawing.Font("Helvetica-Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerReporte.ForeColor = System.Drawing.Color.DimGray
        Me.cmdVerReporte.Image = CType(resources.GetObject("cmdVerReporte.Image"), System.Drawing.Image)
        Me.cmdVerReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdVerReporte.Location = New System.Drawing.Point(273, 111)
        Me.cmdVerReporte.Name = "cmdVerReporte"
        Me.cmdVerReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdVerReporte.Size = New System.Drawing.Size(132, 63)
        Me.cmdVerReporte.TabIndex = 1646
        Me.cmdVerReporte.Text = "Ver Reporte"
        Me.cmdVerReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdVerReporte.UseVisualStyleBackColor = False
        '
        'dtFechaIni
        '
        Me.dtFechaIni.AllowEmptyState = False
        Me.dtFechaIni.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtFechaIni.AutoOverwrite = False
        Me.dtFechaIni.AutoResolveFreeTextEntries = False
        Me.dtFechaIni.AutoSelectDate = True
        '
        '
        '
        Me.dtFechaIni.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.dtFechaIni.BackgroundStyle.BackColor2 = System.Drawing.Color.White
        Me.dtFechaIni.BackgroundStyle.BackgroundImageAlpha = CType(0, Byte)
        Me.dtFechaIni.BackgroundStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center
        Me.dtFechaIni.BackgroundStyle.BorderColor = System.Drawing.Color.LightGray
        Me.dtFechaIni.BackgroundStyle.BorderColor2 = System.Drawing.Color.LightGray
        Me.dtFechaIni.BackgroundStyle.BorderGradientAngle = 0
        Me.dtFechaIni.BackgroundStyle.BorderLightGradientAngle = 0
        Me.dtFechaIni.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFechaIni.BackgroundStyle.CornerDiameter = 5
        Me.dtFechaIni.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.dtFechaIni.BackgroundStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaIni.BackgroundStyle.PaddingLeft = 5
        Me.dtFechaIni.ButtonDropDown.Image = CType(resources.GetObject("dtFechaIni.ButtonDropDown.Image"), System.Drawing.Image)
        Me.dtFechaIni.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtFechaIni.ButtonDropDown.Visible = True
        Me.dtFechaIni.FocusHighlightColor = System.Drawing.Color.Transparent
        Me.dtFechaIni.Font = New System.Drawing.Font("Helvetica-Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaIni.ForeColor = System.Drawing.Color.Gray
        Me.dtFechaIni.IsPopupCalendarOpen = False
        Me.dtFechaIni.Location = New System.Drawing.Point(163, 14)
        Me.dtFechaIni.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtFechaIni.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFechaIni.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFechaIni.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtFechaIni.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFechaIni.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFechaIni.MonthCalendar.DisplayMonth = New Date(2016, 6, 1, 0, 0, 0, 0)
        Me.dtFechaIni.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtFechaIni.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtFechaIni.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFechaIni.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFechaIni.MonthCalendar.TodayButtonVisible = True
        Me.dtFechaIni.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtFechaIni.Name = "dtFechaIni"
        Me.dtFechaIni.Size = New System.Drawing.Size(147, 31)
        Me.dtFechaIni.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtFechaIni.TabIndex = 1644
        Me.dtFechaIni.Value = New Date(2017, 5, 13, 23, 50, 40, 830)
        Me.dtFechaIni.Visible = False
        '
        'dtFechaFin
        '
        Me.dtFechaFin.AllowEmptyState = False
        Me.dtFechaFin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtFechaFin.AutoOverwrite = False
        Me.dtFechaFin.AutoResolveFreeTextEntries = False
        Me.dtFechaFin.AutoSelectDate = True
        '
        '
        '
        Me.dtFechaFin.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.dtFechaFin.BackgroundStyle.BackColor2 = System.Drawing.Color.White
        Me.dtFechaFin.BackgroundStyle.BackgroundImageAlpha = CType(0, Byte)
        Me.dtFechaFin.BackgroundStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center
        Me.dtFechaFin.BackgroundStyle.BorderColor = System.Drawing.Color.LightGray
        Me.dtFechaFin.BackgroundStyle.BorderColor2 = System.Drawing.Color.LightGray
        Me.dtFechaFin.BackgroundStyle.BorderGradientAngle = 0
        Me.dtFechaFin.BackgroundStyle.BorderLightGradientAngle = 0
        Me.dtFechaFin.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFechaFin.BackgroundStyle.CornerDiameter = 5
        Me.dtFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.dtFechaFin.BackgroundStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaFin.BackgroundStyle.PaddingLeft = 5
        Me.dtFechaFin.ButtonDropDown.Image = CType(resources.GetObject("dtFechaFin.ButtonDropDown.Image"), System.Drawing.Image)
        Me.dtFechaFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtFechaFin.ButtonDropDown.Visible = True
        Me.dtFechaFin.FocusHighlightColor = System.Drawing.Color.Transparent
        Me.dtFechaFin.Font = New System.Drawing.Font("Helvetica-Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaFin.ForeColor = System.Drawing.Color.Gray
        Me.dtFechaFin.IsPopupCalendarOpen = False
        Me.dtFechaFin.Location = New System.Drawing.Point(390, 14)
        Me.dtFechaFin.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtFechaFin.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFechaFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFechaFin.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtFechaFin.MonthCalendar.ClearButtonVisible = True
        Me.dtFechaFin.MonthCalendar.Colors.Day.BackColorGradientAngle = 0
        Me.dtFechaFin.MonthCalendar.Colors.Today.BackColorGradientAngle = 0
        '
        '
        '
        Me.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFechaFin.MonthCalendar.DisplayMonth = New Date(2016, 6, 1, 0, 0, 0, 0)
        Me.dtFechaFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtFechaFin.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtFechaFin.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFechaFin.MonthCalendar.TodayButtonVisible = True
        Me.dtFechaFin.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(147, 31)
        Me.dtFechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtFechaFin.TabIndex = 1645
        Me.dtFechaFin.Value = New Date(2017, 5, 13, 23, 50, 40, 861)
        Me.dtFechaFin.Visible = False
        Me.dtFechaFin.WatermarkEnabled = False
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label24.ForeColor = System.Drawing.Color.Gray
        Me.Label24.Location = New System.Drawing.Point(111, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 20)
        Me.Label24.TabIndex = 1642
        Me.Label24.Text = "Inicio:"
        Me.Label24.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(353, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.TabIndex = 1643
        Me.Label1.Text = "Fin:"
        Me.Label1.Visible = False
        '
        'grdAlumnos
        '
        Me.grdAlumnos.AllowUserToAddRows = False
        Me.grdAlumnos.AllowUserToDeleteRows = False
        Me.grdAlumnos.AllowUserToOrderColumns = True
        Me.grdAlumnos.AllowUserToResizeRows = False
        Me.grdAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAlumnos.BackgroundColor = System.Drawing.Color.White
        Me.grdAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdAlumnos.ColumnHeadersHeight = 40
        Me.grdAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAlumno, Me.col_Grupo, Me.col_NombreAlumno, Me.col_CodigoAlumno, Me.col_Carrera, Me.colVer})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdAlumnos.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdAlumnos.EnableHeadersVisualStyles = False
        Me.grdAlumnos.GridColor = System.Drawing.Color.LightGray
        Me.grdAlumnos.Location = New System.Drawing.Point(53, 67)
        Me.grdAlumnos.MultiSelect = False
        Me.grdAlumnos.Name = "grdAlumnos"
        Me.grdAlumnos.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAlumnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grdAlumnos.RowHeadersVisible = False
        Me.grdAlumnos.RowHeadersWidth = 10
        Me.grdAlumnos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.grdAlumnos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
        Me.grdAlumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdAlumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grdAlumnos.RowTemplate.Height = 40
        Me.grdAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdAlumnos.Size = New System.Drawing.Size(593, 328)
        Me.grdAlumnos.StandardTab = True
        Me.grdAlumnos.TabIndex = 1636
        '
        'colAlumno
        '
        Me.colAlumno.DataPropertyName = "iCodAlumno"
        Me.colAlumno.HeaderText = "Cod.Alumno"
        Me.colAlumno.Name = "colAlumno"
        Me.colAlumno.ReadOnly = True
        Me.colAlumno.Visible = False
        '
        'col_Grupo
        '
        Me.col_Grupo.DataPropertyName = "iCodGrupo"
        Me.col_Grupo.HeaderText = "Cod. Grupo"
        Me.col_Grupo.Name = "col_Grupo"
        Me.col_Grupo.ReadOnly = True
        Me.col_Grupo.Visible = False
        '
        'col_NombreAlumno
        '
        Me.col_NombreAlumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_NombreAlumno.DataPropertyName = "vchAlumno"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.col_NombreAlumno.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_NombreAlumno.HeaderText = "Alumno"
        Me.col_NombreAlumno.Name = "col_NombreAlumno"
        Me.col_NombreAlumno.ReadOnly = True
        '
        'col_CodigoAlumno
        '
        Me.col_CodigoAlumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_CodigoAlumno.DataPropertyName = "vchCodigo"
        Me.col_CodigoAlumno.HeaderText = "Codigo"
        Me.col_CodigoAlumno.Name = "col_CodigoAlumno"
        Me.col_CodigoAlumno.ReadOnly = True
        '
        'col_Carrera
        '
        Me.col_Carrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_Carrera.DataPropertyName = "vchCarrera"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.Format = "D"
        DataGridViewCellStyle5.NullValue = "Sin fecha"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.col_Carrera.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_Carrera.FillWeight = 35.73656!
        Me.col_Carrera.HeaderText = "Carrera"
        Me.col_Carrera.MinimumWidth = 100
        Me.col_Carrera.Name = "col_Carrera"
        Me.col_Carrera.ReadOnly = True
        Me.col_Carrera.Width = 150
        '
        'colVer
        '
        Me.colVer.HeaderText = " "
        Me.colVer.Image = CType(resources.GetObject("colVer.Image"), System.Drawing.Image)
        Me.colVer.Name = "colVer"
        Me.colVer.ReadOnly = True
        Me.colVer.Width = 70
        '
        'cmdReturn
        '
        Me.cmdReturn.BackColor = System.Drawing.Color.White
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReturn.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdReturn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.cmdReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.Color.DimGray
        Me.cmdReturn.Image = CType(resources.GetObject("cmdReturn.Image"), System.Drawing.Image)
        Me.cmdReturn.Location = New System.Drawing.Point(0, 0)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReturn.Size = New System.Drawing.Size(52, 397)
        Me.cmdReturn.TabIndex = 1626
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'grdGrupos
        '
        Me.grdGrupos.AllowUserToAddRows = False
        Me.grdGrupos.AllowUserToDeleteRows = False
        Me.grdGrupos.AllowUserToOrderColumns = True
        Me.grdGrupos.AllowUserToResizeRows = False
        Me.grdGrupos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdGrupos.BackgroundColor = System.Drawing.Color.White
        Me.grdGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdGrupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdGrupos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdGrupos.ColumnHeadersHeight = 40
        Me.grdGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coliCodGrupo, Me.coliCodProfesor, Me.colGrupo, Me.colProfesor, Me.colFechaInicio, Me.colFechaFin, Me.colCurso, Me.colSeccion, Me.colDias, Me.colHoraIni, Me.colHoraFin, Me.colEditar})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdGrupos.DefaultCellStyle = DataGridViewCellStyle13
        Me.grdGrupos.EnableHeadersVisualStyles = False
        Me.grdGrupos.GridColor = System.Drawing.Color.LightGray
        Me.grdGrupos.Location = New System.Drawing.Point(54, 67)
        Me.grdGrupos.MultiSelect = False
        Me.grdGrupos.Name = "grdGrupos"
        Me.grdGrupos.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdGrupos.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.grdGrupos.RowHeadersVisible = False
        Me.grdGrupos.RowHeadersWidth = 10
        Me.grdGrupos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.grdGrupos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
        Me.grdGrupos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdGrupos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grdGrupos.RowTemplate.Height = 40
        Me.grdGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdGrupos.Size = New System.Drawing.Size(593, 328)
        Me.grdGrupos.StandardTab = True
        Me.grdGrupos.TabIndex = 1637
        '
        'coliCodGrupo
        '
        Me.coliCodGrupo.DataPropertyName = "iCodGrupo"
        Me.coliCodGrupo.HeaderText = "Cod. Grupo"
        Me.coliCodGrupo.Name = "coliCodGrupo"
        Me.coliCodGrupo.ReadOnly = True
        Me.coliCodGrupo.Visible = False
        '
        'coliCodProfesor
        '
        Me.coliCodProfesor.DataPropertyName = "iCodProfesor"
        Me.coliCodProfesor.HeaderText = "Cod.Profesor"
        Me.coliCodProfesor.Name = "coliCodProfesor"
        Me.coliCodProfesor.ReadOnly = True
        Me.coliCodProfesor.Visible = False
        '
        'colGrupo
        '
        Me.colGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colGrupo.DataPropertyName = "vchGrupo"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.colGrupo.DefaultCellStyle = DataGridViewCellStyle9
        Me.colGrupo.HeaderText = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.ReadOnly = True
        '
        'colProfesor
        '
        Me.colProfesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colProfesor.DataPropertyName = "vchProfesor"
        Me.colProfesor.HeaderText = "Profesor"
        Me.colProfesor.Name = "colProfesor"
        Me.colProfesor.ReadOnly = True
        Me.colProfesor.Visible = False
        '
        'colFechaInicio
        '
        Me.colFechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colFechaInicio.DataPropertyName = "dtFechaInicio"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle10.Format = "D"
        DataGridViewCellStyle10.NullValue = "Sin fecha"
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.colFechaInicio.DefaultCellStyle = DataGridViewCellStyle10
        Me.colFechaInicio.FillWeight = 35.73656!
        Me.colFechaInicio.HeaderText = "Fecha"
        Me.colFechaInicio.MinimumWidth = 100
        Me.colFechaInicio.Name = "colFechaInicio"
        Me.colFechaInicio.ReadOnly = True
        Me.colFechaInicio.Visible = False
        Me.colFechaInicio.Width = 150
        '
        'colFechaFin
        '
        Me.colFechaFin.DataPropertyName = "dtFechaFin"
        Me.colFechaFin.HeaderText = "dtFechaFin"
        Me.colFechaFin.Name = "colFechaFin"
        Me.colFechaFin.ReadOnly = True
        Me.colFechaFin.Visible = False
        '
        'colCurso
        '
        Me.colCurso.DataPropertyName = "vchCurso"
        Me.colCurso.HeaderText = "Curso"
        Me.colCurso.Name = "colCurso"
        Me.colCurso.ReadOnly = True
        '
        'colSeccion
        '
        Me.colSeccion.DataPropertyName = "vchSeccion"
        Me.colSeccion.HeaderText = "Seccion"
        Me.colSeccion.Name = "colSeccion"
        Me.colSeccion.ReadOnly = True
        '
        'colDias
        '
        Me.colDias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDias.DataPropertyName = "vchDias"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.colDias.DefaultCellStyle = DataGridViewCellStyle11
        Me.colDias.FillWeight = 69.33958!
        Me.colDias.HeaderText = "Dias"
        Me.colDias.MinimumWidth = 80
        Me.colDias.Name = "colDias"
        Me.colDias.ReadOnly = True
        Me.colDias.Visible = False
        '
        'colHoraIni
        '
        Me.colHoraIni.DataPropertyName = "vchHoraIni"
        Me.colHoraIni.HeaderText = "vchHoraIni"
        Me.colHoraIni.Name = "colHoraIni"
        Me.colHoraIni.ReadOnly = True
        Me.colHoraIni.Visible = False
        '
        'colHoraFin
        '
        Me.colHoraFin.DataPropertyName = "vchHoraFin"
        Me.colHoraFin.HeaderText = "vchHoraFin"
        Me.colHoraFin.Name = "colHoraFin"
        Me.colHoraFin.ReadOnly = True
        Me.colHoraFin.Visible = False
        '
        'colEditar
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.NullValue = CType(resources.GetObject("DataGridViewCellStyle12.NullValue"), Object)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.colEditar.DefaultCellStyle = DataGridViewCellStyle12
        Me.colEditar.HeaderText = " "
        Me.colEditar.Image = CType(resources.GetObject("colEditar.Image"), System.Drawing.Image)
        Me.colEditar.Name = "colEditar"
        Me.colEditar.ReadOnly = True
        Me.colEditar.Width = 40
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(715, 514)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PageSliderReportes.ResumeLayout(False)
        Me.pgsFondo1.ResumeLayout(False)
        Me.pgsFondo2.ResumeLayout(False)
        Me.pgsFondo2.PerformLayout()
        CType(Me.dtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAltaPacienteLive As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents PageSliderReportes As DevComponents.DotNetBar.Controls.PageSlider
    Friend WithEvents pgsFondo1 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents pgsFondo2 As DevComponents.DotNetBar.Controls.PageSliderPage
    Public WithEvents cmdReturn As System.Windows.Forms.Button
    Public WithEvents cmdAlumnos As System.Windows.Forms.Button
    Public WithEvents cmdGrupo As System.Windows.Forms.Button
    Friend WithEvents grdAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents colAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Grupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_NombreAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_CodigoAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Carrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVer As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents grdGrupos As System.Windows.Forms.DataGridView
    Friend WithEvents coliCodGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coliCodProfesor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProfesor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraIni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEditar As System.Windows.Forms.DataGridViewImageColumn
    Public WithEvents cmdDia As System.Windows.Forms.Button
    Public WithEvents cmdSemestral As System.Windows.Forms.Button
    Public WithEvents cmdVerReporte As System.Windows.Forms.Button
    Friend WithEvents dtFechaIni As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtFechaFin As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
