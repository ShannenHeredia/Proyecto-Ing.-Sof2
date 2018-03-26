<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnosVisor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlumnosVisor))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnlPrincipal = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCodCarrera = New System.Windows.Forms.Label
        Me.lblCodGrupo = New System.Windows.Forms.Label
        Me.lblCodAlumno = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImportar = New System.Windows.Forms.Button
        Me.pnlCapturar = New System.Windows.Forms.Panel
        Me.expNuevo = New DevComponents.DotNetBar.ExpandablePanel
        Me.cboCarreras = New System.Windows.Forms.ComboBox
        Me.picPaciente = New System.Windows.Forms.PictureBox
        Me.cboGrupo = New System.Windows.Forms.ComboBox
        Me.cmdGuardarAlumno = New System.Windows.Forms.Button
        Me.lblCarrera = New System.Windows.Forms.Label
        Me.txtCarrera = New System.Windows.Forms.TextBox
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblPaterno = New System.Windows.Forms.Label
        Me.lblMaterno = New System.Windows.Forms.Label
        Me.txtMaterno = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtPaterno = New System.Windows.Forms.TextBox
        Me.picExcel = New System.Windows.Forms.PictureBox
        Me.grdAlumnoImport = New System.Windows.Forms.DataGridView
        Me.pnlVisor = New System.Windows.Forms.Panel
        Me.grdAlumnos = New System.Windows.Forms.DataGridView
        Me.colAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coEditar = New System.Windows.Forms.DataGridViewImageColumn
        Me.colEliminar = New System.Windows.Forms.DataGridViewImageColumn
        Me.fdlgImportar = New System.Windows.Forms.OpenFileDialog
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.cmdAltaPacienteLive = New DevComponents.DotNetBar.BubbleButton
        Me.lblGrupo = New ControlAsistencias.ucLabelRC
        Me.UcLabelRC4 = New ControlAsistencias.ucLabelRC
        Me.UcLabelRC3 = New ControlAsistencias.ucLabelRC
        Me.UcLabelRC11 = New ControlAsistencias.ucLabelRC
        Me.UcLabelRC1 = New ControlAsistencias.ucLabelRC
        Me.UcLabelRC2 = New ControlAsistencias.ucLabelRC
        Me.pnlPrincipal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlCapturar.SuspendLayout()
        Me.expNuevo.SuspendLayout()
        CType(Me.picPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAlumnoImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVisor.SuspendLayout()
        CType(Me.grdAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlPrincipal.Controls.Add(Me.Panel1)
        Me.pnlPrincipal.Controls.Add(Me.pnlCapturar)
        Me.pnlPrincipal.Controls.Add(Me.pnlVisor)
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(1033, 720)
        Me.pnlPrincipal.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblCodCarrera)
        Me.Panel1.Controls.Add(Me.lblCodGrupo)
        Me.Panel1.Controls.Add(Me.lblCodAlumno)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.cmdSalir)
        Me.Panel1.Controls.Add(Me.cmdImportar)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(929, 80)
        Me.Panel1.TabIndex = 388
        '
        'lblCodCarrera
        '
        Me.lblCodCarrera.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCodCarrera.Location = New System.Drawing.Point(430, 61)
        Me.lblCodCarrera.Name = "lblCodCarrera"
        Me.lblCodCarrera.Size = New System.Drawing.Size(68, 19)
        Me.lblCodCarrera.TabIndex = 1968
        Me.lblCodCarrera.Text = "CodCarrera"
        Me.lblCodCarrera.Visible = False
        '
        'lblCodGrupo
        '
        Me.lblCodGrupo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCodGrupo.Location = New System.Drawing.Point(430, 50)
        Me.lblCodGrupo.Name = "lblCodGrupo"
        Me.lblCodGrupo.Size = New System.Drawing.Size(68, 19)
        Me.lblCodGrupo.TabIndex = 1967
        Me.lblCodGrupo.Text = "CodGrupo"
        Me.lblCodGrupo.Visible = False
        '
        'lblCodAlumno
        '
        Me.lblCodAlumno.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lblCodAlumno.Location = New System.Drawing.Point(430, 31)
        Me.lblCodAlumno.Name = "lblCodAlumno"
        Me.lblCodAlumno.Size = New System.Drawing.Size(68, 19)
        Me.lblCodAlumno.TabIndex = 1966
        Me.lblCodAlumno.Text = "CodAlumno"
        Me.lblCodAlumno.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Location = New System.Drawing.Point(0, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(929, 1)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(780, 12)
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
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.DimGray
        Me.lblTitulo.Location = New System.Drawing.Point(25, 28)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(193, 31)
        Me.lblTitulo.TabIndex = 534
        Me.lblTitulo.Text = "Alta de alumno"
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
        Me.cmdSalir.Location = New System.Drawing.Point(858, 12)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(70, 55)
        Me.cmdSalir.TabIndex = 379
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'cmdImportar
        '
        Me.cmdImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdImportar.BackColor = System.Drawing.Color.White
        Me.cmdImportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdImportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdImportar.FlatAppearance.BorderSize = 0
        Me.cmdImportar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmdImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmdImportar.ForeColor = System.Drawing.Color.DimGray
        Me.cmdImportar.Image = CType(resources.GetObject("cmdImportar.Image"), System.Drawing.Image)
        Me.cmdImportar.Location = New System.Drawing.Point(704, 12)
        Me.cmdImportar.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImportar.Size = New System.Drawing.Size(70, 55)
        Me.cmdImportar.TabIndex = 1965
        Me.cmdImportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdImportar.UseVisualStyleBackColor = False
        '
        'pnlCapturar
        '
        Me.pnlCapturar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCapturar.BackColor = System.Drawing.Color.Transparent
        Me.pnlCapturar.Controls.Add(Me.expNuevo)
        Me.pnlCapturar.Controls.Add(Me.picExcel)
        Me.pnlCapturar.Controls.Add(Me.grdAlumnoImport)
        Me.pnlCapturar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.pnlCapturar.Location = New System.Drawing.Point(1, 82)
        Me.pnlCapturar.Name = "pnlCapturar"
        Me.pnlCapturar.Size = New System.Drawing.Size(929, 613)
        Me.pnlCapturar.TabIndex = 5
        '
        'expNuevo
        '
        Me.expNuevo.ButtonImageCollapse = CType(resources.GetObject("expNuevo.ButtonImageCollapse"), System.Drawing.Image)
        Me.expNuevo.ButtonImageExpand = CType(resources.GetObject("expNuevo.ButtonImageExpand"), System.Drawing.Image)
        Me.expNuevo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.expNuevo.Controls.Add(Me.picPaciente)
        Me.expNuevo.Controls.Add(Me.cboGrupo)
        Me.expNuevo.Controls.Add(Me.lblGrupo)
        Me.expNuevo.Controls.Add(Me.cmdGuardarAlumno)
        Me.expNuevo.Controls.Add(Me.lblCarrera)
        Me.expNuevo.Controls.Add(Me.txtCarrera)
        Me.expNuevo.Controls.Add(Me.UcLabelRC4)
        Me.expNuevo.Controls.Add(Me.lblCodigo)
        Me.expNuevo.Controls.Add(Me.lblNombre)
        Me.expNuevo.Controls.Add(Me.txtCodigo)
        Me.expNuevo.Controls.Add(Me.UcLabelRC3)
        Me.expNuevo.Controls.Add(Me.lblPaterno)
        Me.expNuevo.Controls.Add(Me.lblMaterno)
        Me.expNuevo.Controls.Add(Me.txtMaterno)
        Me.expNuevo.Controls.Add(Me.txtNombre)
        Me.expNuevo.Controls.Add(Me.UcLabelRC11)
        Me.expNuevo.Controls.Add(Me.txtPaterno)
        Me.expNuevo.Controls.Add(Me.UcLabelRC1)
        Me.expNuevo.Controls.Add(Me.UcLabelRC2)
        Me.expNuevo.Controls.Add(Me.cboCarreras)
        Me.expNuevo.Dock = System.Windows.Forms.DockStyle.Top
        Me.expNuevo.Expanded = False
        Me.expNuevo.ExpandedBounds = New System.Drawing.Rectangle(0, 0, 929, 368)
        Me.expNuevo.ExpandOnTitleClick = True
        Me.expNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.expNuevo.Location = New System.Drawing.Point(0, 0)
        Me.expNuevo.Name = "expNuevo"
        Me.expNuevo.Size = New System.Drawing.Size(929, 50)
        Me.expNuevo.Style.BackColor1.Color = System.Drawing.Color.White
        Me.expNuevo.Style.BorderColor.Color = System.Drawing.Color.White
        Me.expNuevo.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.expNuevo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expNuevo.Style.GradientAngle = 90
        Me.expNuevo.TabIndex = 1787
        Me.expNuevo.TitleHeight = 50
        Me.expNuevo.TitleStyle.BackColor1.Color = System.Drawing.Color.White
        Me.expNuevo.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.expNuevo.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expNuevo.TitleStyle.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.expNuevo.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.expNuevo.TitleStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expNuevo.TitleStyle.ForeColor.Color = System.Drawing.Color.Gray
        Me.expNuevo.TitleStyle.GradientAngle = 90
        Me.expNuevo.TitleStyleMouseDown.LineAlignment = System.Drawing.StringAlignment.Near
        Me.expNuevo.TitleText = " Alumno"
        '
        'cboCarreras
        '
        Me.cboCarreras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCarreras.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.cboCarreras.ForeColor = System.Drawing.Color.DimGray
        Me.cboCarreras.FormattingEnabled = True
        Me.cboCarreras.Location = New System.Drawing.Point(422, 287)
        Me.cboCarreras.Name = "cboCarreras"
        Me.cboCarreras.Size = New System.Drawing.Size(399, 28)
        Me.cboCarreras.TabIndex = 1965
        Me.cboCarreras.Visible = False
        '
        'picPaciente
        '
        Me.picPaciente.BackColor = System.Drawing.Color.White
        Me.picPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picPaciente.Image = CType(resources.GetObject("picPaciente.Image"), System.Drawing.Image)
        Me.picPaciente.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.picPaciente.Location = New System.Drawing.Point(31, 61)
        Me.picPaciente.Name = "picPaciente"
        Me.picPaciente.Size = New System.Drawing.Size(80, 80)
        Me.picPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPaciente.TabIndex = 1764
        Me.picPaciente.TabStop = False
        '
        'cboGrupo
        '
        Me.cboGrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupo.BackColor = System.Drawing.Color.White
        Me.cboGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cboGrupo.DropDownHeight = 250
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.cboGrupo.ForeColor = System.Drawing.Color.DimGray
        Me.cboGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboGrupo.IntegralHeight = False
        Me.cboGrupo.Location = New System.Drawing.Point(148, 61)
        Me.cboGrupo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboGrupo.Size = New System.Drawing.Size(673, 28)
        Me.cboGrupo.TabIndex = 1762
        Me.cboGrupo.Visible = False
        '
        'cmdGuardarAlumno
        '
        Me.cmdGuardarAlumno.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdGuardarAlumno.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdGuardarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.cmdGuardarAlumno.FlatAppearance.BorderSize = 0
        Me.cmdGuardarAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdGuardarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdGuardarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardarAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cmdGuardarAlumno.ForeColor = System.Drawing.Color.White
        Me.cmdGuardarAlumno.Location = New System.Drawing.Point(368, 306)
        Me.cmdGuardarAlumno.Name = "cmdGuardarAlumno"
        Me.cmdGuardarAlumno.Size = New System.Drawing.Size(167, 43)
        Me.cmdGuardarAlumno.TabIndex = 1761
        Me.cmdGuardarAlumno.Text = "&Guardar"
        Me.cmdGuardarAlumno.UseVisualStyleBackColor = False
        '
        'lblCarrera
        '
        Me.lblCarrera.AutoSize = True
        Me.lblCarrera.BackColor = System.Drawing.Color.Transparent
        Me.lblCarrera.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarrera.ForeColor = System.Drawing.Color.LightCoral
        Me.lblCarrera.Location = New System.Drawing.Point(429, 265)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Size = New System.Drawing.Size(91, 22)
        Me.lblCarrera.TabIndex = 15
        Me.lblCarrera.Text = "Carrera... "
        Me.lblCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCarrera
        '
        Me.txtCarrera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCarrera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtCarrera.ForeColor = System.Drawing.Color.DimGray
        Me.txtCarrera.Location = New System.Drawing.Point(423, 264)
        Me.txtCarrera.Multiline = True
        Me.txtCarrera.Name = "txtCarrera"
        Me.txtCarrera.Size = New System.Drawing.Size(394, 22)
        Me.txtCarrera.TabIndex = 17
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.LightCoral
        Me.lblCodigo.Location = New System.Drawing.Point(151, 262)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(82, 22)
        Me.lblCodigo.TabIndex = 12
        Me.lblCodigo.Text = "Código..."
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.LightCoral
        Me.lblNombre.Location = New System.Drawing.Point(151, 111)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(180, 22)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre del alumno..."
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtCodigo.ForeColor = System.Drawing.Color.DimGray
        Me.txtCodigo.Location = New System.Drawing.Point(145, 265)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(254, 22)
        Me.txtCodigo.TabIndex = 14
        '
        'lblPaterno
        '
        Me.lblPaterno.AutoSize = True
        Me.lblPaterno.BackColor = System.Drawing.Color.Transparent
        Me.lblPaterno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaterno.ForeColor = System.Drawing.Color.LightCoral
        Me.lblPaterno.Location = New System.Drawing.Point(151, 162)
        Me.lblPaterno.Name = "lblPaterno"
        Me.lblPaterno.Size = New System.Drawing.Size(110, 22)
        Me.lblPaterno.TabIndex = 6
        Me.lblPaterno.Text = "A. Paterno..."
        Me.lblPaterno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaterno
        '
        Me.lblMaterno.AutoSize = True
        Me.lblMaterno.BackColor = System.Drawing.Color.Transparent
        Me.lblMaterno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterno.ForeColor = System.Drawing.Color.LightCoral
        Me.lblMaterno.Location = New System.Drawing.Point(151, 214)
        Me.lblMaterno.Name = "lblMaterno"
        Me.lblMaterno.Size = New System.Drawing.Size(112, 22)
        Me.lblMaterno.TabIndex = 9
        Me.lblMaterno.Text = "A. Materno..."
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
        Me.txtMaterno.Location = New System.Drawing.Point(145, 215)
        Me.txtMaterno.Multiline = True
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(676, 22)
        Me.txtMaterno.TabIndex = 11
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtNombre.ForeColor = System.Drawing.Color.DimGray
        Me.txtNombre.Location = New System.Drawing.Point(145, 112)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(676, 22)
        Me.txtNombre.TabIndex = 5
        '
        'txtPaterno
        '
        Me.txtPaterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtPaterno.ForeColor = System.Drawing.Color.DimGray
        Me.txtPaterno.Location = New System.Drawing.Point(145, 163)
        Me.txtPaterno.Multiline = True
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(676, 22)
        Me.txtPaterno.TabIndex = 8
        '
        'picExcel
        '
        Me.picExcel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picExcel.BackColor = System.Drawing.Color.Transparent
        Me.picExcel.Image = CType(resources.GetObject("picExcel.Image"), System.Drawing.Image)
        Me.picExcel.Location = New System.Drawing.Point(7, 60)
        Me.picExcel.Name = "picExcel"
        Me.picExcel.Size = New System.Drawing.Size(915, 546)
        Me.picExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picExcel.TabIndex = 1791
        Me.picExcel.TabStop = False
        '
        'grdAlumnoImport
        '
        Me.grdAlumnoImport.AllowUserToAddRows = False
        Me.grdAlumnoImport.AllowUserToDeleteRows = False
        Me.grdAlumnoImport.AllowUserToOrderColumns = True
        Me.grdAlumnoImport.AllowUserToResizeRows = False
        Me.grdAlumnoImport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAlumnoImport.BackgroundColor = System.Drawing.Color.White
        Me.grdAlumnoImport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdAlumnoImport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdAlumnoImport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAlumnoImport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grdAlumnoImport.ColumnHeadersHeight = 40
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdAlumnoImport.DefaultCellStyle = DataGridViewCellStyle12
        Me.grdAlumnoImport.EnableHeadersVisualStyles = False
        Me.grdAlumnoImport.GridColor = System.Drawing.Color.LightGray
        Me.grdAlumnoImport.Location = New System.Drawing.Point(7, 60)
        Me.grdAlumnoImport.MultiSelect = False
        Me.grdAlumnoImport.Name = "grdAlumnoImport"
        Me.grdAlumnoImport.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAlumnoImport.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.grdAlumnoImport.RowHeadersVisible = False
        Me.grdAlumnoImport.RowHeadersWidth = 10
        Me.grdAlumnoImport.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.grdAlumnoImport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
        Me.grdAlumnoImport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdAlumnoImport.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grdAlumnoImport.RowTemplate.Height = 40
        Me.grdAlumnoImport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdAlumnoImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdAlumnoImport.Size = New System.Drawing.Size(915, 546)
        Me.grdAlumnoImport.StandardTab = True
        Me.grdAlumnoImport.TabIndex = 1790
        '
        'pnlVisor
        '
        Me.pnlVisor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlVisor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlVisor.BackColor = System.Drawing.Color.Transparent
        Me.pnlVisor.Controls.Add(Me.grdAlumnos)
        Me.pnlVisor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.pnlVisor.Location = New System.Drawing.Point(152, 82)
        Me.pnlVisor.Name = "pnlVisor"
        Me.pnlVisor.Size = New System.Drawing.Size(728, 613)
        Me.pnlVisor.TabIndex = 0
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
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.grdAlumnos.ColumnHeadersHeight = 40
        Me.grdAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAlumno, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.coEditar, Me.colEliminar})
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
        Me.grdAlumnos.Location = New System.Drawing.Point(11, 23)
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
        Me.grdAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdAlumnos.Size = New System.Drawing.Size(714, 534)
        Me.grdAlumnos.StandardTab = True
        Me.grdAlumnos.TabIndex = 4
        '
        'colAlumno
        '
        Me.colAlumno.DataPropertyName = "iCodAlumno"
        Me.colAlumno.HeaderText = "Cod.Alumno"
        Me.colAlumno.Name = "colAlumno"
        Me.colAlumno.ReadOnly = True
        Me.colAlumno.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "iCodGrupo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod. Grupo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "vchAlumno"
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn3.HeaderText = "Alumno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "vchCodigo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "vchCarrera"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle16.Format = "D"
        DataGridViewCellStyle16.NullValue = "Sin fecha"
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn5.FillWeight = 35.73656!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Carrera"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'coEditar
        '
        Me.coEditar.Image = CType(resources.GetObject("coEditar.Image"), System.Drawing.Image)
        Me.coEditar.Name = "coEditar"
        Me.coEditar.ReadOnly = True
        Me.coEditar.Width = 70
        '
        'colEliminar
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.NullValue = CType(resources.GetObject("DataGridViewCellStyle17.NullValue"), Object)
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.colEliminar.DefaultCellStyle = DataGridViewCellStyle17
        Me.colEliminar.HeaderText = " "
        Me.colEliminar.Image = CType(resources.GetObject("colEliminar.Image"), System.Drawing.Image)
        Me.colEliminar.Name = "colEliminar"
        Me.colEliminar.ReadOnly = True
        Me.colEliminar.Width = 70
        '
        'fdlgImportar
        '
        Me.fdlgImportar.FileName = "OpenFileDialog1"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 70
        '
        'DataGridViewImageColumn2
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.NullValue = CType(resources.GetObject("DataGridViewCellStyle20.NullValue"), Object)
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewImageColumn2.HeaderText = " "
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 70
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
        'lblGrupo
        '
        Me.lblGrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGrupo.Location = New System.Drawing.Point(143, 59)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(681, 31)
        Me.lblGrupo.TabIndex = 1763
        Me.lblGrupo.Texthaschanged = False
        Me.lblGrupo.Visible = False
        '
        'UcLabelRC4
        '
        Me.UcLabelRC4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC4.Location = New System.Drawing.Point(418, 260)
        Me.UcLabelRC4.Name = "UcLabelRC4"
        Me.UcLabelRC4.Size = New System.Drawing.Size(405, 31)
        Me.UcLabelRC4.TabIndex = 16
        Me.UcLabelRC4.Texthaschanged = False
        '
        'UcLabelRC3
        '
        Me.UcLabelRC3.Location = New System.Drawing.Point(143, 260)
        Me.UcLabelRC3.Name = "UcLabelRC3"
        Me.UcLabelRC3.Size = New System.Drawing.Size(258, 31)
        Me.UcLabelRC3.TabIndex = 13
        Me.UcLabelRC3.Texthaschanged = False
        '
        'UcLabelRC11
        '
        Me.UcLabelRC11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC11.Location = New System.Drawing.Point(143, 107)
        Me.UcLabelRC11.Name = "UcLabelRC11"
        Me.UcLabelRC11.Size = New System.Drawing.Size(680, 31)
        Me.UcLabelRC11.TabIndex = 4
        Me.UcLabelRC11.Texthaschanged = False
        '
        'UcLabelRC1
        '
        Me.UcLabelRC1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC1.Location = New System.Drawing.Point(143, 158)
        Me.UcLabelRC1.Name = "UcLabelRC1"
        Me.UcLabelRC1.Size = New System.Drawing.Size(680, 31)
        Me.UcLabelRC1.TabIndex = 7
        Me.UcLabelRC1.Texthaschanged = False
        '
        'UcLabelRC2
        '
        Me.UcLabelRC2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelRC2.Location = New System.Drawing.Point(143, 210)
        Me.UcLabelRC2.Name = "UcLabelRC2"
        Me.UcLabelRC2.Size = New System.Drawing.Size(680, 31)
        Me.UcLabelRC2.TabIndex = 10
        Me.UcLabelRC2.Texthaschanged = False
        '
        'frmAlumnosVisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAlumnosVisor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlPrincipal.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlCapturar.ResumeLayout(False)
        Me.expNuevo.ResumeLayout(False)
        Me.expNuevo.PerformLayout()
        CType(Me.picPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAlumnoImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVisor.ResumeLayout(False)
        CType(Me.grdAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents cmdAltaPacienteLive As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Public WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents pnlVisor As System.Windows.Forms.Panel
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grdAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents colAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coEditar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colEliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pnlCapturar As System.Windows.Forms.Panel
    Friend WithEvents lblCarrera As System.Windows.Forms.Label
    Friend WithEvents txtCarrera As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC4 As ControlAsistencias.ucLabelRC
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC3 As ControlAsistencias.ucLabelRC
    Friend WithEvents lblMaterno As System.Windows.Forms.Label
    Friend WithEvents txtMaterno As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC2 As ControlAsistencias.ucLabelRC
    Friend WithEvents lblPaterno As System.Windows.Forms.Label
    Friend WithEvents txtPaterno As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC1 As ControlAsistencias.ucLabelRC
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents UcLabelRC11 As ControlAsistencias.ucLabelRC
    Private WithEvents expNuevo As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents fdlgImportar As System.Windows.Forms.OpenFileDialog
    Public WithEvents cmdImportar As System.Windows.Forms.Button
    Friend WithEvents grdAlumnoImport As System.Windows.Forms.DataGridView
    Friend WithEvents cmdGuardarAlumno As System.Windows.Forms.Button
    Friend WithEvents picExcel As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblCodAlumno As System.Windows.Forms.Label
    Public WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrupo As ControlAsistencias.ucLabelRC
    Friend WithEvents lblCodGrupo As System.Windows.Forms.Label
    Friend WithEvents picPaciente As System.Windows.Forms.PictureBox
    Friend WithEvents lblCodCarrera As System.Windows.Forms.Label
    Friend WithEvents cboCarreras As System.Windows.Forms.ComboBox

End Class
