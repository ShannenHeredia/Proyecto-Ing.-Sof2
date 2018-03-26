<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaGrupos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaGrupos))
        Me.pnlPrincipal = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cboProfesor = New System.Windows.Forms.ComboBox
        Me.lblCurso = New System.Windows.Forms.Label
        Me.txtCurso = New System.Windows.Forms.TextBox
        Me.UcLabelRC5 = New ControlAsistencias.ucLabelRC
        Me.lblSeccion = New System.Windows.Forms.Label
        Me.txtSeccion = New System.Windows.Forms.TextBox
        Me.UcLabelRC4 = New ControlAsistencias.ucLabelRC
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.dtFechaFin = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtFechaIni = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.Label228 = New System.Windows.Forms.Label
        Me.chkSabado = New System.Windows.Forms.CheckBox
        Me.chkJueves = New System.Windows.Forms.CheckBox
        Me.chkViernes = New System.Windows.Forms.CheckBox
        Me.chkMiercoles = New System.Windows.Forms.CheckBox
        Me.chkMartes = New System.Windows.Forms.CheckBox
        Me.chkLunes = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.cboHoraIni = New System.Windows.Forms.ComboBox
        Me.cboHoraFin = New System.Windows.Forms.ComboBox
        Me.UcLabelRC3 = New ControlAsistencias.ucLabelRC
        Me.UcLabelRC2 = New ControlAsistencias.ucLabelRC
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.UcLabelRC11 = New ControlAsistencias.ucLabelRC
        Me.UcLabelRC1 = New ControlAsistencias.ucLabelRC
        Me.lblProfesor = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAltaPacienteLive = New DevComponents.DotNetBar.BubbleButton
        Me.pnlPrincipal.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlPrincipal.Controls.Add(Me.Panel2)
        Me.pnlPrincipal.Controls.Add(Me.Panel1)
        Me.pnlPrincipal.Location = New System.Drawing.Point(-1, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(732, 698)
        Me.pnlPrincipal.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.cboProfesor)
        Me.Panel2.Controls.Add(Me.lblCurso)
        Me.Panel2.Controls.Add(Me.txtCurso)
        Me.Panel2.Controls.Add(Me.UcLabelRC5)
        Me.Panel2.Controls.Add(Me.lblSeccion)
        Me.Panel2.Controls.Add(Me.txtSeccion)
        Me.Panel2.Controls.Add(Me.UcLabelRC4)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.dtFechaFin)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.dtFechaIni)
        Me.Panel2.Controls.Add(Me.Label228)
        Me.Panel2.Controls.Add(Me.chkSabado)
        Me.Panel2.Controls.Add(Me.chkJueves)
        Me.Panel2.Controls.Add(Me.chkViernes)
        Me.Panel2.Controls.Add(Me.chkMiercoles)
        Me.Panel2.Controls.Add(Me.chkMartes)
        Me.Panel2.Controls.Add(Me.chkLunes)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.cboHoraIni)
        Me.Panel2.Controls.Add(Me.cboHoraFin)
        Me.Panel2.Controls.Add(Me.UcLabelRC3)
        Me.Panel2.Controls.Add(Me.UcLabelRC2)
        Me.Panel2.Controls.Add(Me.lblNombre)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.UcLabelRC11)
        Me.Panel2.Controls.Add(Me.UcLabelRC1)
        Me.Panel2.Controls.Add(Me.lblProfesor)
        Me.Panel2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Panel2.Location = New System.Drawing.Point(2, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 613)
        Me.Panel2.TabIndex = 0
        '
        'cboProfesor
        '
        Me.cboProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.cboProfesor.ForeColor = System.Drawing.Color.DimGray
        Me.cboProfesor.FormattingEnabled = True
        Me.cboProfesor.Location = New System.Drawing.Point(101, 77)
        Me.cboProfesor.Name = "cboProfesor"
        Me.cboProfesor.Size = New System.Drawing.Size(525, 28)
        Me.cboProfesor.TabIndex = 3
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.BackColor = System.Drawing.Color.Transparent
        Me.lblCurso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurso.ForeColor = System.Drawing.Color.LightCoral
        Me.lblCurso.Location = New System.Drawing.Point(105, 134)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(64, 22)
        Me.lblCurso.TabIndex = 6
        Me.lblCurso.Text = "NRC..."
        Me.lblCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCurso
        '
        Me.txtCurso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCurso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCurso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtCurso.ForeColor = System.Drawing.Color.DimGray
        Me.txtCurso.Location = New System.Drawing.Point(99, 134)
        Me.txtCurso.Multiline = True
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(325, 22)
        Me.txtCurso.TabIndex = 7
        '
        'UcLabelRC5
        '
        Me.UcLabelRC5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC5.Location = New System.Drawing.Point(97, 130)
        Me.UcLabelRC5.Name = "UcLabelRC5"
        Me.UcLabelRC5.Size = New System.Drawing.Size(329, 31)
        Me.UcLabelRC5.TabIndex = 8
        Me.UcLabelRC5.Texthaschanged = False
        '
        'lblSeccion
        '
        Me.lblSeccion.AutoSize = True
        Me.lblSeccion.BackColor = System.Drawing.Color.Transparent
        Me.lblSeccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeccion.ForeColor = System.Drawing.Color.LightCoral
        Me.lblSeccion.Location = New System.Drawing.Point(465, 134)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Size = New System.Drawing.Size(89, 22)
        Me.lblSeccion.TabIndex = 9
        Me.lblSeccion.Text = "Seccion..."
        Me.lblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSeccion
        '
        Me.txtSeccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtSeccion.ForeColor = System.Drawing.Color.DimGray
        Me.txtSeccion.Location = New System.Drawing.Point(459, 134)
        Me.txtSeccion.Multiline = True
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New System.Drawing.Size(161, 22)
        Me.txtSeccion.TabIndex = 10
        '
        'UcLabelRC4
        '
        Me.UcLabelRC4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC4.Location = New System.Drawing.Point(457, 130)
        Me.UcLabelRC4.Name = "UcLabelRC4"
        Me.UcLabelRC4.Size = New System.Drawing.Size(165, 31)
        Me.UcLabelRC4.TabIndex = 11
        Me.UcLabelRC4.Texthaschanged = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Helvetica-Light", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(475, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "hrs."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Helvetica-Light", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(285, 495)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "hrs."
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(-3, 190)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(740, 1)
        Me.Label16.TabIndex = 1963
        '
        'dtFechaFin
        '
        Me.dtFechaFin.AllowEmptyState = False
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
        Me.dtFechaFin.Colors.Highlight = System.Drawing.Color.White
        Me.dtFechaFin.Colors.HighlightText = System.Drawing.Color.DodgerBlue
        Me.dtFechaFin.FocusHighlightColor = System.Drawing.Color.Transparent
        Me.dtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaFin.ForeColor = System.Drawing.Color.Black
        Me.dtFechaFin.IsPopupCalendarOpen = False
        Me.dtFechaFin.Location = New System.Drawing.Point(364, 418)
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
        Me.dtFechaFin.Size = New System.Drawing.Size(168, 29)
        Me.dtFechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtFechaFin.TabIndex = 22
        Me.dtFechaFin.Value = New Date(2017, 4, 8, 23, 43, 27, 846)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(365, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Fecha Fin:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtFechaIni
        '
        Me.dtFechaIni.AllowEmptyState = False
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
        Me.dtFechaIni.Colors.Highlight = System.Drawing.Color.White
        Me.dtFechaIni.Colors.HighlightText = System.Drawing.Color.DodgerBlue
        Me.dtFechaIni.FocusHighlightColor = System.Drawing.Color.Transparent
        Me.dtFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaIni.ForeColor = System.Drawing.Color.Black
        Me.dtFechaIni.IsPopupCalendarOpen = False
        Me.dtFechaIni.Location = New System.Drawing.Point(169, 418)
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
        Me.dtFechaIni.Size = New System.Drawing.Size(168, 29)
        Me.dtFechaIni.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtFechaIni.TabIndex = 20
        Me.dtFechaIni.Value = New Date(2017, 4, 8, 23, 43, 27, 894)
        '
        'Label228
        '
        Me.Label228.AutoSize = True
        Me.Label228.BackColor = System.Drawing.Color.Transparent
        Me.Label228.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label228.ForeColor = System.Drawing.Color.Gray
        Me.Label228.Location = New System.Drawing.Point(170, 395)
        Me.Label228.Name = "Label228"
        Me.Label228.Size = New System.Drawing.Size(99, 20)
        Me.Label228.TabIndex = 19
        Me.Label228.Text = "Fecha Inicio:"
        Me.Label228.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkSabado
        '
        Me.chkSabado.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkSabado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkSabado.FlatAppearance.BorderSize = 0
        Me.chkSabado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSabado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.chkSabado.ForeColor = System.Drawing.Color.DimGray
        Me.chkSabado.Image = CType(resources.GetObject("chkSabado.Image"), System.Drawing.Image)
        Me.chkSabado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkSabado.Location = New System.Drawing.Point(447, 285)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(121, 42)
        Me.chkSabado.TabIndex = 17
        Me.chkSabado.Text = "Sabado"
        Me.chkSabado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSabado.UseVisualStyleBackColor = True
        '
        'chkJueves
        '
        Me.chkJueves.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkJueves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkJueves.FlatAppearance.BorderSize = 0
        Me.chkJueves.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkJueves.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.chkJueves.ForeColor = System.Drawing.Color.DimGray
        Me.chkJueves.Image = CType(resources.GetObject("chkJueves.Image"), System.Drawing.Image)
        Me.chkJueves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkJueves.Location = New System.Drawing.Point(153, 285)
        Me.chkJueves.Name = "chkJueves"
        Me.chkJueves.Size = New System.Drawing.Size(121, 42)
        Me.chkJueves.TabIndex = 15
        Me.chkJueves.Text = "Jueves"
        Me.chkJueves.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkJueves.UseVisualStyleBackColor = True
        '
        'chkViernes
        '
        Me.chkViernes.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkViernes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkViernes.FlatAppearance.BorderSize = 0
        Me.chkViernes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkViernes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.chkViernes.ForeColor = System.Drawing.Color.DimGray
        Me.chkViernes.Image = CType(resources.GetObject("chkViernes.Image"), System.Drawing.Image)
        Me.chkViernes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkViernes.Location = New System.Drawing.Point(300, 285)
        Me.chkViernes.Name = "chkViernes"
        Me.chkViernes.Size = New System.Drawing.Size(121, 42)
        Me.chkViernes.TabIndex = 16
        Me.chkViernes.Text = "Viernes"
        Me.chkViernes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkViernes.UseVisualStyleBackColor = True
        '
        'chkMiercoles
        '
        Me.chkMiercoles.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkMiercoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkMiercoles.FlatAppearance.BorderSize = 0
        Me.chkMiercoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMiercoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.chkMiercoles.ForeColor = System.Drawing.Color.DimGray
        Me.chkMiercoles.Image = CType(resources.GetObject("chkMiercoles.Image"), System.Drawing.Image)
        Me.chkMiercoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkMiercoles.Location = New System.Drawing.Point(447, 209)
        Me.chkMiercoles.Name = "chkMiercoles"
        Me.chkMiercoles.Size = New System.Drawing.Size(128, 42)
        Me.chkMiercoles.TabIndex = 14
        Me.chkMiercoles.Text = "Miercoles"
        Me.chkMiercoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMiercoles.UseVisualStyleBackColor = True
        '
        'chkMartes
        '
        Me.chkMartes.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkMartes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkMartes.FlatAppearance.BorderSize = 0
        Me.chkMartes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMartes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.chkMartes.ForeColor = System.Drawing.Color.DimGray
        Me.chkMartes.Image = CType(resources.GetObject("chkMartes.Image"), System.Drawing.Image)
        Me.chkMartes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkMartes.Location = New System.Drawing.Point(300, 209)
        Me.chkMartes.Name = "chkMartes"
        Me.chkMartes.Size = New System.Drawing.Size(121, 42)
        Me.chkMartes.TabIndex = 13
        Me.chkMartes.Text = "Martes"
        Me.chkMartes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMartes.UseVisualStyleBackColor = True
        '
        'chkLunes
        '
        Me.chkLunes.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkLunes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkLunes.FlatAppearance.BorderSize = 0
        Me.chkLunes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkLunes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.chkLunes.ForeColor = System.Drawing.Color.DimGray
        Me.chkLunes.Image = CType(resources.GetObject("chkLunes.Image"), System.Drawing.Image)
        Me.chkLunes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkLunes.Location = New System.Drawing.Point(153, 209)
        Me.chkLunes.Name = "chkLunes"
        Me.chkLunes.Size = New System.Drawing.Size(121, 42)
        Me.chkLunes.TabIndex = 12
        Me.chkLunes.Text = "Lunes"
        Me.chkLunes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLunes.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightCoral
        Me.Label2.Location = New System.Drawing.Point(171, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha y Hora:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Helvetica-Light", 10.0!)
        Me.Label22.ForeColor = System.Drawing.Color.Gray
        Me.Label22.Location = New System.Drawing.Point(171, 468)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 17)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "&Inicia:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Helvetica-Light", 10.0!)
        Me.Label23.ForeColor = System.Drawing.Color.Gray
        Me.Label23.Location = New System.Drawing.Point(361, 468)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 17)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "&Termina:"
        '
        'cboHoraIni
        '
        Me.cboHoraIni.BackColor = System.Drawing.Color.White
        Me.cboHoraIni.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHoraIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboHoraIni.Font = New System.Drawing.Font("Helvetica-Light", 11.0!)
        Me.cboHoraIni.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHoraIni.Items.AddRange(New Object() {"7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00"})
        Me.cboHoraIni.Location = New System.Drawing.Point(174, 489)
        Me.cboHoraIni.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboHoraIni.Name = "cboHoraIni"
        Me.cboHoraIni.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHoraIni.Size = New System.Drawing.Size(104, 26)
        Me.cboHoraIni.TabIndex = 24
        '
        'cboHoraFin
        '
        Me.cboHoraFin.BackColor = System.Drawing.Color.White
        Me.cboHoraFin.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHoraFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboHoraFin.Font = New System.Drawing.Font("Helvetica-Light", 11.0!)
        Me.cboHoraFin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHoraFin.Items.AddRange(New Object() {"7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00"})
        Me.cboHoraFin.Location = New System.Drawing.Point(363, 490)
        Me.cboHoraFin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboHoraFin.Name = "cboHoraFin"
        Me.cboHoraFin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHoraFin.Size = New System.Drawing.Size(104, 26)
        Me.cboHoraFin.TabIndex = 28
        '
        'UcLabelRC3
        '
        Me.UcLabelRC3.Location = New System.Drawing.Point(361, 488)
        Me.UcLabelRC3.Name = "UcLabelRC3"
        Me.UcLabelRC3.Size = New System.Drawing.Size(108, 30)
        Me.UcLabelRC3.TabIndex = 29
        Me.UcLabelRC3.Texthaschanged = False
        '
        'UcLabelRC2
        '
        Me.UcLabelRC2.Location = New System.Drawing.Point(172, 487)
        Me.UcLabelRC2.Name = "UcLabelRC2"
        Me.UcLabelRC2.Size = New System.Drawing.Size(108, 30)
        Me.UcLabelRC2.TabIndex = 25
        Me.UcLabelRC2.Texthaschanged = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.LightCoral
        Me.lblNombre.Location = New System.Drawing.Point(105, 26)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(164, 22)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre de grupo..."
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
        Me.txtNombre.Location = New System.Drawing.Point(99, 27)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(529, 22)
        Me.txtNombre.TabIndex = 2
        '
        'UcLabelRC11
        '
        Me.UcLabelRC11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC11.Location = New System.Drawing.Point(97, 22)
        Me.UcLabelRC11.Name = "UcLabelRC11"
        Me.UcLabelRC11.Size = New System.Drawing.Size(533, 31)
        Me.UcLabelRC11.TabIndex = 1
        Me.UcLabelRC11.Texthaschanged = False
        '
        'UcLabelRC1
        '
        Me.UcLabelRC1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC1.Location = New System.Drawing.Point(97, 76)
        Me.UcLabelRC1.Name = "UcLabelRC1"
        Me.UcLabelRC1.Size = New System.Drawing.Size(533, 31)
        Me.UcLabelRC1.TabIndex = 5
        Me.UcLabelRC1.Texthaschanged = False
        '
        'lblProfesor
        '
        Me.lblProfesor.AutoSize = True
        Me.lblProfesor.BackColor = System.Drawing.Color.Transparent
        Me.lblProfesor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfesor.ForeColor = System.Drawing.Color.LightCoral
        Me.lblProfesor.Location = New System.Drawing.Point(105, 80)
        Me.lblProfesor.Name = "lblProfesor"
        Me.lblProfesor.Size = New System.Drawing.Size(93, 22)
        Me.lblProfesor.TabIndex = 3
        Me.lblProfesor.Text = "Profesor..."
        Me.lblProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
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
        Me.lblTitulo.Size = New System.Drawing.Size(174, 31)
        Me.lblTitulo.TabIndex = 534
        Me.lblTitulo.Text = "Alta de grupo"
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
        'frmAltaGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(730, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAltaGrupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlPrincipal.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblProfesor As System.Windows.Forms.Label
    Friend WithEvents UcLabelRC1 As ControlAsistencias.ucLabelRC
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC11 As ControlAsistencias.ucLabelRC
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents cboHoraIni As System.Windows.Forms.ComboBox
    Public WithEvents cboHoraFin As System.Windows.Forms.ComboBox
    Friend WithEvents UcLabelRC3 As ControlAsistencias.ucLabelRC
    Friend WithEvents UcLabelRC2 As ControlAsistencias.ucLabelRC
    Friend WithEvents chkLunes As System.Windows.Forms.CheckBox
    Friend WithEvents chkSabado As System.Windows.Forms.CheckBox
    Friend WithEvents chkJueves As System.Windows.Forms.CheckBox
    Friend WithEvents chkViernes As System.Windows.Forms.CheckBox
    Friend WithEvents chkMiercoles As System.Windows.Forms.CheckBox
    Friend WithEvents chkMartes As System.Windows.Forms.CheckBox
    Friend WithEvents dtFechaIni As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label228 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFin As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents txtCurso As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC5 As ControlAsistencias.ucLabelRC
    Friend WithEvents lblSeccion As System.Windows.Forms.Label
    Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC4 As ControlAsistencias.ucLabelRC
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboProfesor As System.Windows.Forms.ComboBox

End Class
