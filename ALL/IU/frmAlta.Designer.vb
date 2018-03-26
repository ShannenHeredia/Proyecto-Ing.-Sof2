<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlta
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlta))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnlPrincipal = New System.Windows.Forms.Panel
        Me.pnlDias = New System.Windows.Forms.Panel
        Me.grdDias = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_FechaInhabil = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn
        Me.dtFechaInhabil = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.Label228 = New System.Windows.Forms.Label
        Me.lblDia = New System.Windows.Forms.Label
        Me.txtDia = New System.Windows.Forms.TextBox
        Me.UcLabelRC11 = New ControlAsistencias.ucLabelRC
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.optAddGroup = New System.Windows.Forms.RadioButton
        Me.optAddAlumns = New System.Windows.Forms.RadioButton
        Me.optDias = New System.Windows.Forms.RadioButton
        Me.optCuenta = New System.Windows.Forms.RadioButton
        Me.optHistoriaClinica = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.pnlAlumnos = New System.Windows.Forms.Panel
        Me.grdAlumnosxGrupo = New System.Windows.Forms.DataGridView
        Me.colAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coEditar = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdAgregarAlumno = New System.Windows.Forms.Button
        Me.grdAlumnos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMostrar = New System.Windows.Forms.DataGridViewImageColumn
        Me.colAgregar = New System.Windows.Forms.DataGridViewImageColumn
        Me.pnlGrupos = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdAddGroup = New System.Windows.Forms.Button
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
        Me.colEliminar = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.cmdAltaPacienteLive = New DevComponents.DotNetBar.BubbleButton
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlDias.SuspendLayout()
        CType(Me.grdDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInhabil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlAlumnos.SuspendLayout()
        CType(Me.grdAlumnosxGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrupos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlPrincipal.Controls.Add(Me.pnlDias)
        Me.pnlPrincipal.Controls.Add(Me.Panel3)
        Me.pnlPrincipal.Controls.Add(Me.Panel1)
        Me.pnlPrincipal.Controls.Add(Me.pnlAlumnos)
        Me.pnlPrincipal.Controls.Add(Me.pnlGrupos)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(1280, 720)
        Me.pnlPrincipal.TabIndex = 0
        '
        'pnlDias
        '
        Me.pnlDias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDias.BackColor = System.Drawing.Color.White
        Me.pnlDias.Controls.Add(Me.grdDias)
        Me.pnlDias.Controls.Add(Me.dtFechaInhabil)
        Me.pnlDias.Controls.Add(Me.Label228)
        Me.pnlDias.Controls.Add(Me.lblDia)
        Me.pnlDias.Controls.Add(Me.txtDia)
        Me.pnlDias.Controls.Add(Me.UcLabelRC11)
        Me.pnlDias.Controls.Add(Me.Label5)
        Me.pnlDias.Controls.Add(Me.cmdAceptar)
        Me.pnlDias.Controls.Add(Me.PictureBox3)
        Me.pnlDias.Controls.Add(Me.Label4)
        Me.pnlDias.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.pnlDias.Location = New System.Drawing.Point(224, 96)
        Me.pnlDias.Name = "pnlDias"
        Me.pnlDias.Size = New System.Drawing.Size(1042, 613)
        Me.pnlDias.TabIndex = 539
        '
        'grdDias
        '
        Me.grdDias.AllowUserToAddRows = False
        Me.grdDias.AllowUserToDeleteRows = False
        Me.grdDias.AllowUserToOrderColumns = True
        Me.grdDias.AllowUserToResizeRows = False
        Me.grdDias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDias.BackgroundColor = System.Drawing.Color.White
        Me.grdDias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdDias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDias.ColumnHeadersHeight = 40
        Me.grdDias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.col_FechaInhabil, Me.DataGridViewImageColumn5})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDias.DefaultCellStyle = DataGridViewCellStyle5
        Me.grdDias.EnableHeadersVisualStyles = False
        Me.grdDias.GridColor = System.Drawing.Color.LightGray
        Me.grdDias.Location = New System.Drawing.Point(2, 303)
        Me.grdDias.MultiSelect = False
        Me.grdDias.Name = "grdDias"
        Me.grdDias.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDias.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdDias.RowHeadersVisible = False
        Me.grdDias.RowHeadersWidth = 10
        Me.grdDias.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.grdDias.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
        Me.grdDias.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdDias.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grdDias.RowTemplate.Height = 40
        Me.grdDias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdDias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDias.Size = New System.Drawing.Size(1038, 304)
        Me.grdDias.StandardTab = True
        Me.grdDias.TabIndex = 1971
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "iCodDia"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Cod.Dia"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "vchDescripcion"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "iDia"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn18.HeaderText = "Dia"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "iMes"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Mes"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "iAnio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Format = "D"
        DataGridViewCellStyle3.NullValue = "Sin fecha"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn20.FillWeight = 35.73656!
        Me.DataGridViewTextBoxColumn20.HeaderText = "iAnio"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        Me.DataGridViewTextBoxColumn20.Width = 150
        '
        'col_FechaInhabil
        '
        Me.col_FechaInhabil.DataPropertyName = "dtFecha"
        Me.col_FechaInhabil.HeaderText = "Fecha"
        Me.col_FechaInhabil.MinimumWidth = 130
        Me.col_FechaInhabil.Name = "col_FechaInhabil"
        Me.col_FechaInhabil.ReadOnly = True
        Me.col_FechaInhabil.Width = 130
        '
        'DataGridViewImageColumn5
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = CType(resources.GetObject("DataGridViewCellStyle4.NullValue"), Object)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewImageColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewImageColumn5.HeaderText = " "
        Me.DataGridViewImageColumn5.Image = CType(resources.GetObject("DataGridViewImageColumn5.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.ReadOnly = True
        Me.DataGridViewImageColumn5.Width = 70
        '
        'dtFechaInhabil
        '
        Me.dtFechaInhabil.AllowEmptyState = False
        Me.dtFechaInhabil.AutoOverwrite = False
        Me.dtFechaInhabil.AutoResolveFreeTextEntries = False
        Me.dtFechaInhabil.AutoSelectDate = True
        '
        '
        '
        Me.dtFechaInhabil.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.dtFechaInhabil.BackgroundStyle.BackColor2 = System.Drawing.Color.White
        Me.dtFechaInhabil.BackgroundStyle.BackgroundImageAlpha = CType(0, Byte)
        Me.dtFechaInhabil.BackgroundStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center
        Me.dtFechaInhabil.BackgroundStyle.BorderColor = System.Drawing.Color.LightGray
        Me.dtFechaInhabil.BackgroundStyle.BorderColor2 = System.Drawing.Color.LightGray
        Me.dtFechaInhabil.BackgroundStyle.BorderGradientAngle = 0
        Me.dtFechaInhabil.BackgroundStyle.BorderLightGradientAngle = 0
        Me.dtFechaInhabil.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFechaInhabil.BackgroundStyle.CornerDiameter = 5
        Me.dtFechaInhabil.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.dtFechaInhabil.BackgroundStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaInhabil.BackgroundStyle.PaddingLeft = 5
        Me.dtFechaInhabil.ButtonDropDown.Image = CType(resources.GetObject("dtFechaInhabil.ButtonDropDown.Image"), System.Drawing.Image)
        Me.dtFechaInhabil.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtFechaInhabil.ButtonDropDown.Visible = True
        Me.dtFechaInhabil.Colors.Highlight = System.Drawing.Color.White
        Me.dtFechaInhabil.Colors.HighlightText = System.Drawing.Color.DodgerBlue
        Me.dtFechaInhabil.FocusHighlightColor = System.Drawing.Color.Transparent
        Me.dtFechaInhabil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaInhabil.ForeColor = System.Drawing.Color.Black
        Me.dtFechaInhabil.IsPopupCalendarOpen = False
        Me.dtFechaInhabil.Location = New System.Drawing.Point(196, 170)
        Me.dtFechaInhabil.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtFechaInhabil.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFechaInhabil.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFechaInhabil.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtFechaInhabil.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtFechaInhabil.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFechaInhabil.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFechaInhabil.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFechaInhabil.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFechaInhabil.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFechaInhabil.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFechaInhabil.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFechaInhabil.MonthCalendar.DisplayMonth = New Date(2016, 6, 1, 0, 0, 0, 0)
        Me.dtFechaInhabil.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtFechaInhabil.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtFechaInhabil.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFechaInhabil.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFechaInhabil.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFechaInhabil.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFechaInhabil.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFechaInhabil.MonthCalendar.TodayButtonVisible = True
        Me.dtFechaInhabil.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtFechaInhabil.Name = "dtFechaInhabil"
        Me.dtFechaInhabil.Size = New System.Drawing.Size(168, 29)
        Me.dtFechaInhabil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtFechaInhabil.TabIndex = 1970
        Me.dtFechaInhabil.Value = New Date(2017, 4, 8, 23, 43, 27, 894)
        '
        'Label228
        '
        Me.Label228.AutoSize = True
        Me.Label228.BackColor = System.Drawing.Color.Transparent
        Me.Label228.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label228.ForeColor = System.Drawing.Color.Gray
        Me.Label228.Location = New System.Drawing.Point(197, 147)
        Me.Label228.Name = "Label228"
        Me.Label228.Size = New System.Drawing.Size(58, 20)
        Me.Label228.TabIndex = 1969
        Me.Label228.Text = "Fecha:"
        Me.Label228.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.BackColor = System.Drawing.Color.Transparent
        Me.lblDia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.ForeColor = System.Drawing.Color.LightCoral
        Me.lblDia.Location = New System.Drawing.Point(204, 98)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(219, 22)
        Me.lblDia.TabIndex = 1966
        Me.lblDia.Text = "Descripcion del dia inhabil"
        Me.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia
        '
        Me.txtDia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtDia.ForeColor = System.Drawing.Color.DimGray
        Me.txtDia.Location = New System.Drawing.Point(196, 99)
        Me.txtDia.Multiline = True
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(651, 22)
        Me.txtDia.TabIndex = 1968
        '
        'UcLabelRC11
        '
        Me.UcLabelRC11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC11.Location = New System.Drawing.Point(194, 94)
        Me.UcLabelRC11.Name = "UcLabelRC11"
        Me.UcLabelRC11.Size = New System.Drawing.Size(655, 31)
        Me.UcLabelRC11.TabIndex = 1967
        Me.UcLabelRC11.Texthaschanged = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(0, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1047, 1)
        Me.Label5.TabIndex = 1965
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
        Me.cmdAceptar.Location = New System.Drawing.Point(438, 223)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(167, 43)
        Me.cmdAceptar.TabIndex = 1763
        Me.cmdAceptar.Text = "&Guardar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(30, 22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 537
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(72, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 31)
        Me.Label4.TabIndex = 536
        Me.Label4.Text = "Dias inhabiles"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SlateGray
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.optAddGroup)
        Me.Panel3.Controls.Add(Me.optAddAlumns)
        Me.Panel3.Controls.Add(Me.optDias)
        Me.Panel3.Controls.Add(Me.optCuenta)
        Me.Panel3.Controls.Add(Me.optHistoriaClinica)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Panel3.ForeColor = System.Drawing.Color.Crimson
        Me.Panel3.Location = New System.Drawing.Point(0, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 640)
        Me.Panel3.TabIndex = 390
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Helvetica-Light", 13.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 22)
        Me.Label1.TabIndex = 535
        Me.Label1.Text = "Seleccione una opcion:"
        '
        'optAddGroup
        '
        Me.optAddGroup.Appearance = System.Windows.Forms.Appearance.Button
        Me.optAddGroup.BackColor = System.Drawing.Color.Transparent
        Me.optAddGroup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optAddGroup.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.optAddGroup.FlatAppearance.BorderSize = 2
        Me.optAddGroup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optAddGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optAddGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAddGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAddGroup.ForeColor = System.Drawing.Color.White
        Me.optAddGroup.Image = CType(resources.GetObject("optAddGroup.Image"), System.Drawing.Image)
        Me.optAddGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optAddGroup.Location = New System.Drawing.Point(1, 78)
        Me.optAddGroup.Name = "optAddGroup"
        Me.optAddGroup.Size = New System.Drawing.Size(207, 54)
        Me.optAddGroup.TabIndex = 568
        Me.optAddGroup.TabStop = True
        Me.optAddGroup.Text = "         Agregar grupo"
        Me.optAddGroup.UseVisualStyleBackColor = False
        '
        'optAddAlumns
        '
        Me.optAddAlumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.optAddAlumns.BackColor = System.Drawing.Color.Transparent
        Me.optAddAlumns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optAddAlumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.optAddAlumns.FlatAppearance.BorderSize = 0
        Me.optAddAlumns.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optAddAlumns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optAddAlumns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optAddAlumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAddAlumns.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAddAlumns.ForeColor = System.Drawing.Color.White
        Me.optAddAlumns.Image = CType(resources.GetObject("optAddAlumns.Image"), System.Drawing.Image)
        Me.optAddAlumns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optAddAlumns.Location = New System.Drawing.Point(0, 132)
        Me.optAddAlumns.Name = "optAddAlumns"
        Me.optAddAlumns.Size = New System.Drawing.Size(209, 54)
        Me.optAddAlumns.TabIndex = 569
        Me.optAddAlumns.TabStop = True
        Me.optAddAlumns.Text = "         Agregar alumnos"
        Me.optAddAlumns.UseVisualStyleBackColor = False
        '
        'optDias
        '
        Me.optDias.Appearance = System.Windows.Forms.Appearance.Button
        Me.optDias.BackColor = System.Drawing.Color.Transparent
        Me.optDias.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.optDias.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optDias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optDias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDias.ForeColor = System.Drawing.Color.White
        Me.optDias.Image = CType(resources.GetObject("optDias.Image"), System.Drawing.Image)
        Me.optDias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optDias.Location = New System.Drawing.Point(0, 186)
        Me.optDias.Name = "optDias"
        Me.optDias.Size = New System.Drawing.Size(209, 54)
        Me.optDias.TabIndex = 571
        Me.optDias.TabStop = True
        Me.optDias.Text = "         Dias Inhabiles"
        Me.optDias.UseVisualStyleBackColor = False
        Me.optDias.Visible = False
        '
        'optCuenta
        '
        Me.optCuenta.Appearance = System.Windows.Forms.Appearance.Button
        Me.optCuenta.BackColor = System.Drawing.Color.Transparent
        Me.optCuenta.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.optCuenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCuenta.ForeColor = System.Drawing.Color.White
        Me.optCuenta.Image = CType(resources.GetObject("optCuenta.Image"), System.Drawing.Image)
        Me.optCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optCuenta.Location = New System.Drawing.Point(0, 276)
        Me.optCuenta.Name = "optCuenta"
        Me.optCuenta.Size = New System.Drawing.Size(209, 46)
        Me.optCuenta.TabIndex = 570
        Me.optCuenta.TabStop = True
        Me.optCuenta.Text = "         Cuenta"
        Me.optCuenta.UseVisualStyleBackColor = False
        Me.optCuenta.Visible = False
        '
        'optHistoriaClinica
        '
        Me.optHistoriaClinica.Appearance = System.Windows.Forms.Appearance.Button
        Me.optHistoriaClinica.BackColor = System.Drawing.Color.Transparent
        Me.optHistoriaClinica.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.optHistoriaClinica.FlatAppearance.BorderSize = 0
        Me.optHistoriaClinica.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optHistoriaClinica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optHistoriaClinica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optHistoriaClinica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optHistoriaClinica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHistoriaClinica.ForeColor = System.Drawing.Color.DarkGray
        Me.optHistoriaClinica.Image = CType(resources.GetObject("optHistoriaClinica.Image"), System.Drawing.Image)
        Me.optHistoriaClinica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optHistoriaClinica.Location = New System.Drawing.Point(-1, 78)
        Me.optHistoriaClinica.Name = "optHistoriaClinica"
        Me.optHistoriaClinica.Size = New System.Drawing.Size(211, 46)
        Me.optHistoriaClinica.TabIndex = 567
        Me.optHistoriaClinica.TabStop = True
        Me.optHistoriaClinica.Text = "            Primera vez"
        Me.optHistoriaClinica.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.cmdSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 80)
        Me.Panel1.TabIndex = 388
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.DimGray
        Me.lblTitulo.Location = New System.Drawing.Point(40, 21)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(209, 31)
        Me.lblTitulo.TabIndex = 534
        Me.lblTitulo.Text = "Panel de control"
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
        Me.cmdSalir.Location = New System.Drawing.Point(1206, 12)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(70, 55)
        Me.cmdSalir.TabIndex = 379
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'pnlAlumnos
        '
        Me.pnlAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAlumnos.BackColor = System.Drawing.Color.White
        Me.pnlAlumnos.Controls.Add(Me.grdAlumnosxGrupo)
        Me.pnlAlumnos.Controls.Add(Me.PictureBox2)
        Me.pnlAlumnos.Controls.Add(Me.Label3)
        Me.pnlAlumnos.Controls.Add(Me.cmdAgregarAlumno)
        Me.pnlAlumnos.Controls.Add(Me.grdAlumnos)
        Me.pnlAlumnos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.pnlAlumnos.Location = New System.Drawing.Point(225, 95)
        Me.pnlAlumnos.Name = "pnlAlumnos"
        Me.pnlAlumnos.Size = New System.Drawing.Size(1042, 613)
        Me.pnlAlumnos.TabIndex = 514
        '
        'grdAlumnosxGrupo
        '
        Me.grdAlumnosxGrupo.AllowUserToAddRows = False
        Me.grdAlumnosxGrupo.AllowUserToDeleteRows = False
        Me.grdAlumnosxGrupo.AllowUserToOrderColumns = True
        Me.grdAlumnosxGrupo.AllowUserToResizeRows = False
        Me.grdAlumnosxGrupo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAlumnosxGrupo.BackgroundColor = System.Drawing.Color.White
        Me.grdAlumnosxGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdAlumnosxGrupo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdAlumnosxGrupo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAlumnosxGrupo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grdAlumnosxGrupo.ColumnHeadersHeight = 40
        Me.grdAlumnosxGrupo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAlumno, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.coEditar, Me.DataGridViewImageColumn3})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdAlumnosxGrupo.DefaultCellStyle = DataGridViewCellStyle11
        Me.grdAlumnosxGrupo.EnableHeadersVisualStyles = False
        Me.grdAlumnosxGrupo.GridColor = System.Drawing.Color.LightGray
        Me.grdAlumnosxGrupo.Location = New System.Drawing.Point(2, 304)
        Me.grdAlumnosxGrupo.MultiSelect = False
        Me.grdAlumnosxGrupo.Name = "grdAlumnosxGrupo"
        Me.grdAlumnosxGrupo.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAlumnosxGrupo.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.grdAlumnosxGrupo.RowHeadersVisible = False
        Me.grdAlumnosxGrupo.RowHeadersWidth = 10
        Me.grdAlumnosxGrupo.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.grdAlumnosxGrupo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
        Me.grdAlumnosxGrupo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdAlumnosxGrupo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grdAlumnosxGrupo.RowTemplate.Height = 40
        Me.grdAlumnosxGrupo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdAlumnosxGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdAlumnosxGrupo.Size = New System.Drawing.Size(1038, 304)
        Me.grdAlumnosxGrupo.StandardTab = True
        Me.grdAlumnosxGrupo.TabIndex = 538
        '
        'colAlumno
        '
        Me.colAlumno.DataPropertyName = "iCodAlumno"
        Me.colAlumno.HeaderText = "Cod.Alumno"
        Me.colAlumno.Name = "colAlumno"
        Me.colAlumno.ReadOnly = True
        Me.colAlumno.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "iCodGrupo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cod. Grupo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "vchAlumno"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn13.HeaderText = "Alumno"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "vchCodigo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "vchCarrera"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle9.Format = "D"
        DataGridViewCellStyle9.NullValue = "Sin fecha"
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn15.FillWeight = 35.73656!
        Me.DataGridViewTextBoxColumn15.HeaderText = "Carrera"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 150
        '
        'coEditar
        '
        Me.coEditar.HeaderText = "coEditar"
        Me.coEditar.Image = CType(resources.GetObject("coEditar.Image"), System.Drawing.Image)
        Me.coEditar.Name = "coEditar"
        Me.coEditar.ReadOnly = True
        Me.coEditar.Visible = False
        Me.coEditar.Width = 70
        '
        'DataGridViewImageColumn3
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.NullValue = CType(resources.GetObject("DataGridViewCellStyle10.NullValue"), Object)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewImageColumn3.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewImageColumn3.HeaderText = " "
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Visible = False
        Me.DataGridViewImageColumn3.Width = 70
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 537
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(72, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 31)
        Me.Label3.TabIndex = 536
        Me.Label3.Text = "Alumnos"
        '
        'cmdAgregarAlumno
        '
        Me.cmdAgregarAlumno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAgregarAlumno.BackColor = System.Drawing.Color.Transparent
        Me.cmdAgregarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdAgregarAlumno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAgregarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmdAgregarAlumno.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmdAgregarAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAgregarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarAlumno.ForeColor = System.Drawing.Color.DimGray
        Me.cmdAgregarAlumno.Image = CType(resources.GetObject("cmdAgregarAlumno.Image"), System.Drawing.Image)
        Me.cmdAgregarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAgregarAlumno.Location = New System.Drawing.Point(912, 17)
        Me.cmdAgregarAlumno.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdAgregarAlumno.Name = "cmdAgregarAlumno"
        Me.cmdAgregarAlumno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAgregarAlumno.Size = New System.Drawing.Size(115, 42)
        Me.cmdAgregarAlumno.TabIndex = 513
        Me.cmdAgregarAlumno.Text = "Agregar"
        Me.cmdAgregarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAgregarAlumno.UseVisualStyleBackColor = False
        Me.cmdAgregarAlumno.Visible = False
        '
        'grdAlumnos
        '
        Me.grdAlumnos.AllowUserToAddRows = False
        Me.grdAlumnos.AllowUserToDeleteRows = False
        Me.grdAlumnos.AllowUserToOrderColumns = True
        Me.grdAlumnos.AllowUserToResizeRows = False
        Me.grdAlumnos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAlumnos.BackgroundColor = System.Drawing.Color.White
        Me.grdAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.grdAlumnos.ColumnHeadersHeight = 40
        Me.grdAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.colMostrar, Me.colAgregar})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdAlumnos.DefaultCellStyle = DataGridViewCellStyle18
        Me.grdAlumnos.EnableHeadersVisualStyles = False
        Me.grdAlumnos.GridColor = System.Drawing.Color.LightGray
        Me.grdAlumnos.Location = New System.Drawing.Point(2, 76)
        Me.grdAlumnos.MultiSelect = False
        Me.grdAlumnos.Name = "grdAlumnos"
        Me.grdAlumnos.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAlumnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.grdAlumnos.RowHeadersVisible = False
        Me.grdAlumnos.RowHeadersWidth = 10
        Me.grdAlumnos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.grdAlumnos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
        Me.grdAlumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdAlumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grdAlumnos.RowTemplate.Height = 40
        Me.grdAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdAlumnos.Size = New System.Drawing.Size(1038, 231)
        Me.grdAlumnos.StandardTab = True
        Me.grdAlumnos.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "iCodGrupo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod. Grupo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "iCodProfesor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cod.Profesor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "vchGrupo"
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn3.HeaderText = "Grupo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "vchProfesor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Profesor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "dtFechaInicio"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle15.Format = "D"
        DataGridViewCellStyle15.NullValue = "Sin fecha"
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn5.FillWeight = 35.73656!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "dtFechaFin"
        Me.DataGridViewTextBoxColumn6.HeaderText = "dtFechaFin"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "vchCurso"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Curso"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 180
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "vchSeccion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Seccion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "vchDias"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn9.FillWeight = 69.33958!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Dias"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "vchHoraIni"
        Me.DataGridViewTextBoxColumn10.HeaderText = "vchHoraIni"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "vchHoraFin"
        Me.DataGridViewTextBoxColumn11.HeaderText = "vchHoraFin"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'colMostrar
        '
        Me.colMostrar.HeaderText = " "
        Me.colMostrar.Image = CType(resources.GetObject("colMostrar.Image"), System.Drawing.Image)
        Me.colMostrar.Name = "colMostrar"
        Me.colMostrar.ReadOnly = True
        Me.colMostrar.Visible = False
        Me.colMostrar.Width = 70
        '
        'colAgregar
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.NullValue = CType(resources.GetObject("DataGridViewCellStyle17.NullValue"), Object)
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.colAgregar.DefaultCellStyle = DataGridViewCellStyle17
        Me.colAgregar.HeaderText = " "
        Me.colAgregar.Image = CType(resources.GetObject("colAgregar.Image"), System.Drawing.Image)
        Me.colAgregar.Name = "colAgregar"
        Me.colAgregar.ReadOnly = True
        Me.colAgregar.Width = 70
        '
        'pnlGrupos
        '
        Me.pnlGrupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGrupos.BackColor = System.Drawing.Color.White
        Me.pnlGrupos.Controls.Add(Me.PictureBox1)
        Me.pnlGrupos.Controls.Add(Me.Label2)
        Me.pnlGrupos.Controls.Add(Me.cmdAddGroup)
        Me.pnlGrupos.Controls.Add(Me.grdGrupos)
        Me.pnlGrupos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.pnlGrupos.Location = New System.Drawing.Point(225, 95)
        Me.pnlGrupos.Name = "pnlGrupos"
        Me.pnlGrupos.Size = New System.Drawing.Size(1042, 613)
        Me.pnlGrupos.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 536
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(71, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 31)
        Me.Label2.TabIndex = 535
        Me.Label2.Text = "Grupos"
        '
        'cmdAddGroup
        '
        Me.cmdAddGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddGroup.BackColor = System.Drawing.Color.Transparent
        Me.cmdAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdAddGroup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAddGroup.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmdAddGroup.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmdAddGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAddGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddGroup.ForeColor = System.Drawing.Color.DimGray
        Me.cmdAddGroup.Image = CType(resources.GetObject("cmdAddGroup.Image"), System.Drawing.Image)
        Me.cmdAddGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAddGroup.Location = New System.Drawing.Point(912, 17)
        Me.cmdAddGroup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdAddGroup.Name = "cmdAddGroup"
        Me.cmdAddGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddGroup.Size = New System.Drawing.Size(115, 42)
        Me.cmdAddGroup.TabIndex = 513
        Me.cmdAddGroup.Text = "Agregar"
        Me.cmdAddGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAddGroup.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdGrupos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.grdGrupos.ColumnHeadersHeight = 40
        Me.grdGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coliCodGrupo, Me.coliCodProfesor, Me.colGrupo, Me.colProfesor, Me.colFechaInicio, Me.colFechaFin, Me.colCurso, Me.colSeccion, Me.colDias, Me.colHoraIni, Me.colHoraFin, Me.colEditar, Me.colEliminar})
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdGrupos.DefaultCellStyle = DataGridViewCellStyle26
        Me.grdGrupos.EnableHeadersVisualStyles = False
        Me.grdGrupos.GridColor = System.Drawing.Color.LightGray
        Me.grdGrupos.Location = New System.Drawing.Point(2, 76)
        Me.grdGrupos.MultiSelect = False
        Me.grdGrupos.Name = "grdGrupos"
        Me.grdGrupos.ReadOnly = True
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdGrupos.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.grdGrupos.RowHeadersVisible = False
        Me.grdGrupos.RowHeadersWidth = 10
        Me.grdGrupos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.grdGrupos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
        Me.grdGrupos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdGrupos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grdGrupos.RowTemplate.Height = 40
        Me.grdGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdGrupos.Size = New System.Drawing.Size(1038, 534)
        Me.grdGrupos.StandardTab = True
        Me.grdGrupos.TabIndex = 3
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
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black
        Me.colGrupo.DefaultCellStyle = DataGridViewCellStyle21
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
        '
        'colFechaInicio
        '
        Me.colFechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colFechaInicio.DataPropertyName = "dtFechaInicio"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle22.Format = "D"
        DataGridViewCellStyle22.NullValue = "Sin fecha"
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black
        Me.colFechaInicio.DefaultCellStyle = DataGridViewCellStyle22
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
        Me.colCurso.Width = 180
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
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black
        Me.colDias.DefaultCellStyle = DataGridViewCellStyle23
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
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.NullValue = CType(resources.GetObject("DataGridViewCellStyle24.NullValue"), Object)
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.colEditar.DefaultCellStyle = DataGridViewCellStyle24
        Me.colEditar.HeaderText = " "
        Me.colEditar.Image = CType(resources.GetObject("colEditar.Image"), System.Drawing.Image)
        Me.colEditar.Name = "colEditar"
        Me.colEditar.ReadOnly = True
        Me.colEditar.Visible = False
        Me.colEditar.Width = 40
        '
        'colEliminar
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.NullValue = CType(resources.GetObject("DataGridViewCellStyle25.NullValue"), Object)
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.colEliminar.DefaultCellStyle = DataGridViewCellStyle25
        Me.colEliminar.HeaderText = " "
        Me.colEliminar.Image = CType(resources.GetObject("colEliminar.Image"), System.Drawing.Image)
        Me.colEliminar.Name = "colEliminar"
        Me.colEliminar.ReadOnly = True
        Me.colEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEliminar.Width = 40
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.NullValue = CType(resources.GetObject("DataGridViewCellStyle28.NullValue"), Object)
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridViewImageColumn1.HeaderText = " "
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Visible = False
        Me.DataGridViewImageColumn1.Width = 40
        '
        'DataGridViewImageColumn2
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.NullValue = CType(resources.GetObject("DataGridViewCellStyle29.NullValue"), Object)
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle29
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
        'frmAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlDias.ResumeLayout(False)
        Me.pnlDias.PerformLayout()
        CType(Me.grdDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInhabil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlAlumnos.ResumeLayout(False)
        Me.pnlAlumnos.PerformLayout()
        CType(Me.grdAlumnosxGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrupos.ResumeLayout(False)
        Me.pnlGrupos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents cmdAltaPacienteLive As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Public WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents pnlGrupos As System.Windows.Forms.Panel
    Friend WithEvents grdGrupos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents optAddGroup As System.Windows.Forms.RadioButton
    Friend WithEvents optAddAlumns As System.Windows.Forms.RadioButton
    Friend WithEvents optDias As System.Windows.Forms.RadioButton
    Friend WithEvents optCuenta As System.Windows.Forms.RadioButton
    Friend WithEvents optHistoriaClinica As System.Windows.Forms.RadioButton
    Public WithEvents cmdAddGroup As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
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
    Friend WithEvents colEliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlAlumnos As System.Windows.Forms.Panel
    Friend WithEvents grdAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Public WithEvents cmdAgregarAlumno As System.Windows.Forms.Button
    Friend WithEvents grdAlumnosxGrupo As System.Windows.Forms.DataGridView
    Friend WithEvents colAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coEditar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMostrar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colAgregar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pnlDias As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDia As System.Windows.Forms.Label
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC11 As ControlAsistencias.ucLabelRC
    Friend WithEvents grdDias As System.Windows.Forms.DataGridView
    Friend WithEvents dtFechaInhabil As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label228 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_FechaInhabil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn5 As System.Windows.Forms.DataGridViewImageColumn

End Class
