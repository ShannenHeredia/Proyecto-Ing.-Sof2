<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptSemestral
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSemestral))
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.lblEstatus = New DevExpress.XtraReports.UI.XRLabel
        Me.lblPorcentaje = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAsist_Totales = New DevExpress.XtraReports.UI.XRLabel
        Me.lblObtenidas = New DevExpress.XtraReports.UI.XRLabel
        Me.lblFaltas = New DevExpress.XtraReports.UI.XRLabel
        Me.lblJustificadas = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAsistencias = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAlumno = New DevExpress.XtraReports.UI.XRLabel
        Me.lblGrupo = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape
        Me.lblFechaIni = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblFechaFin = New DevExpress.XtraReports.UI.XRLabel
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel
        Me.lbl2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblEstatus, Me.lblPorcentaje, Me.lblAsist_Totales, Me.lblObtenidas, Me.lblFaltas, Me.lblJustificadas, Me.lblAsistencias, Me.lblAlumno, Me.lblGrupo, Me.XrLine1})
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblEstatus
        '
        Me.lblEstatus.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblEstatus.ForeColor = System.Drawing.Color.Gray
        Me.lblEstatus.KeepTogether = True
        Me.lblEstatus.Location = New System.Drawing.Point(767, 0)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEstatus.Size = New System.Drawing.Size(50, 15)
        Me.lblEstatus.StylePriority.UseFont = False
        Me.lblEstatus.StylePriority.UseForeColor = False
        Me.lblEstatus.StylePriority.UseTextAlignment = False
        Me.lblEstatus.Text = "Precio"
        Me.lblEstatus.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblPorcentaje.ForeColor = System.Drawing.Color.Gray
        Me.lblPorcentaje.KeepTogether = True
        Me.lblPorcentaje.Location = New System.Drawing.Point(692, 0)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPorcentaje.Size = New System.Drawing.Size(71, 15)
        Me.lblPorcentaje.StylePriority.UseFont = False
        Me.lblPorcentaje.StylePriority.UseForeColor = False
        Me.lblPorcentaje.StylePriority.UseTextAlignment = False
        Me.lblPorcentaje.Text = "Precio"
        Me.lblPorcentaje.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblAsist_Totales
        '
        Me.lblAsist_Totales.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblAsist_Totales.ForeColor = System.Drawing.Color.Gray
        Me.lblAsist_Totales.KeepTogether = True
        Me.lblAsist_Totales.Location = New System.Drawing.Point(600, 0)
        Me.lblAsist_Totales.Name = "lblAsist_Totales"
        Me.lblAsist_Totales.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAsist_Totales.Size = New System.Drawing.Size(88, 15)
        Me.lblAsist_Totales.StylePriority.UseFont = False
        Me.lblAsist_Totales.StylePriority.UseForeColor = False
        Me.lblAsist_Totales.StylePriority.UseTextAlignment = False
        Me.lblAsist_Totales.Text = "Precio"
        Me.lblAsist_Totales.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblObtenidas
        '
        Me.lblObtenidas.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblObtenidas.ForeColor = System.Drawing.Color.Gray
        Me.lblObtenidas.KeepTogether = True
        Me.lblObtenidas.Location = New System.Drawing.Point(525, 0)
        Me.lblObtenidas.Name = "lblObtenidas"
        Me.lblObtenidas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblObtenidas.Size = New System.Drawing.Size(77, 15)
        Me.lblObtenidas.StylePriority.UseFont = False
        Me.lblObtenidas.StylePriority.UseForeColor = False
        Me.lblObtenidas.StylePriority.UseTextAlignment = False
        Me.lblObtenidas.Text = "Precio"
        Me.lblObtenidas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblFaltas
        '
        Me.lblFaltas.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblFaltas.ForeColor = System.Drawing.Color.Gray
        Me.lblFaltas.KeepTogether = True
        Me.lblFaltas.Location = New System.Drawing.Point(442, 0)
        Me.lblFaltas.Name = "lblFaltas"
        Me.lblFaltas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFaltas.Size = New System.Drawing.Size(80, 15)
        Me.lblFaltas.StylePriority.UseFont = False
        Me.lblFaltas.StylePriority.UseForeColor = False
        Me.lblFaltas.StylePriority.UseTextAlignment = False
        Me.lblFaltas.Text = "Precio"
        Me.lblFaltas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblJustificadas
        '
        Me.lblJustificadas.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblJustificadas.ForeColor = System.Drawing.Color.Gray
        Me.lblJustificadas.KeepTogether = True
        Me.lblJustificadas.Location = New System.Drawing.Point(367, 0)
        Me.lblJustificadas.Name = "lblJustificadas"
        Me.lblJustificadas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblJustificadas.Size = New System.Drawing.Size(77, 15)
        Me.lblJustificadas.StylePriority.UseFont = False
        Me.lblJustificadas.StylePriority.UseForeColor = False
        Me.lblJustificadas.StylePriority.UseTextAlignment = False
        Me.lblJustificadas.Text = "Precio"
        Me.lblJustificadas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblAsistencias
        '
        Me.lblAsistencias.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblAsistencias.ForeColor = System.Drawing.Color.Gray
        Me.lblAsistencias.KeepTogether = True
        Me.lblAsistencias.Location = New System.Drawing.Point(283, 0)
        Me.lblAsistencias.Name = "lblAsistencias"
        Me.lblAsistencias.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAsistencias.Size = New System.Drawing.Size(78, 15)
        Me.lblAsistencias.StylePriority.UseFont = False
        Me.lblAsistencias.StylePriority.UseForeColor = False
        Me.lblAsistencias.StylePriority.UseTextAlignment = False
        Me.lblAsistencias.Text = "Precio"
        Me.lblAsistencias.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblAlumno
        '
        Me.lblAlumno.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.lblAlumno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblAlumno.ForeColor = System.Drawing.Color.Gray
        Me.lblAlumno.Location = New System.Drawing.Point(0, 0)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAlumno.Size = New System.Drawing.Size(142, 15)
        Me.lblAlumno.StylePriority.UseFont = False
        Me.lblAlumno.StylePriority.UseForeColor = False
        Me.lblAlumno.StylePriority.UseTextAlignment = False
        Me.lblAlumno.Text = "Precio"
        Me.lblAlumno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblGrupo
        '
        Me.lblGrupo.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.lblGrupo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblGrupo.ForeColor = System.Drawing.Color.Gray
        Me.lblGrupo.Location = New System.Drawing.Point(142, 0)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblGrupo.Size = New System.Drawing.Size(142, 15)
        Me.lblGrupo.StylePriority.UseFont = False
        Me.lblGrupo.StylePriority.UseForeColor = False
        Me.lblGrupo.StylePriority.UseTextAlignment = False
        Me.lblGrupo.Text = "Precio"
        Me.lblGrupo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox4, Me.XrLabel6, Me.XrShape1, Me.lblFechaIni, Me.XrLabel12, Me.XrLabel1, Me.lblFechaFin, Me.label1, Me.lbl2, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel7, Me.XrLabel9, Me.XrLabel8, Me.XrLabel2})
        Me.PageHeader.Height = 184
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.BorderColor = System.Drawing.Color.Transparent
        Me.XrPictureBox4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox4.BorderWidth = 0
        Me.XrPictureBox4.Image = CType(resources.GetObject("XrPictureBox4.Image"), System.Drawing.Image)
        Me.XrPictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.CenterImage
        Me.XrPictureBox4.StylePriority.UseBorderColor = False
        Me.XrPictureBox4.StylePriority.UseBorders = False
        Me.XrPictureBox4.StylePriority.UseBorderWidth = False
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.XrLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel6.Location = New System.Drawing.Point(50, 6)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(392, 27)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.Text = "Reporte de asistencias semestral"
        '
        'XrShape1
        '
        Me.XrShape1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.XrShape1.ForeColor = System.Drawing.Color.LightGray
        Me.XrShape1.Location = New System.Drawing.Point(0, 91)
        Me.XrShape1.Name = "XrShape1"
        Me.XrShape1.Shape = ShapeRectangle1
        Me.XrShape1.Size = New System.Drawing.Size(820, 29)
        '
        'lblFechaIni
        '
        Me.lblFechaIni.BorderColor = System.Drawing.SystemColors.ControlText
        Me.lblFechaIni.Font = New System.Drawing.Font("Helvetica-Light", 16.0!)
        Me.lblFechaIni.ForeColor = System.Drawing.Color.DimGray
        Me.lblFechaIni.Location = New System.Drawing.Point(650, 17)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFechaIni.Size = New System.Drawing.Size(167, 17)
        Me.lblFechaIni.StylePriority.UseBorderColor = False
        Me.lblFechaIni.StylePriority.UseFont = False
        Me.lblFechaIni.StylePriority.UseForeColor = False
        Me.lblFechaIni.StylePriority.UseTextAlignment = False
        Me.lblFechaIni.Text = "Fecha"
        Me.lblFechaIni.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.BorderColor = System.Drawing.SystemColors.ControlText
        Me.XrLabel12.Font = New System.Drawing.Font("Helvetica-Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel12.Location = New System.Drawing.Point(567, 0)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(75, 42)
        Me.XrLabel12.StylePriority.UseBorderColor = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Del:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.BorderColor = System.Drawing.SystemColors.ControlText
        Me.XrLabel1.Font = New System.Drawing.Font("Helvetica-Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel1.Location = New System.Drawing.Point(567, 42)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(75, 42)
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Al:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblFechaFin
        '
        Me.lblFechaFin.BorderColor = System.Drawing.SystemColors.ControlText
        Me.lblFechaFin.Font = New System.Drawing.Font("Helvetica-Light", 16.0!)
        Me.lblFechaFin.ForeColor = System.Drawing.Color.DimGray
        Me.lblFechaFin.Location = New System.Drawing.Point(650, 58)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFechaFin.Size = New System.Drawing.Size(167, 17)
        Me.lblFechaFin.StylePriority.UseBorderColor = False
        Me.lblFechaFin.StylePriority.UseFont = False
        Me.lblFechaFin.StylePriority.UseForeColor = False
        Me.lblFechaFin.StylePriority.UseTextAlignment = False
        Me.lblFechaFin.Text = "Fecha"
        Me.lblFechaFin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.BorderColor = System.Drawing.Color.Gainsboro
        Me.label1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label1.BorderWidth = 0
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.label1.ForeColor = System.Drawing.Color.DimGray
        Me.label1.KeepTogether = True
        Me.label1.Location = New System.Drawing.Point(0, 167)
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label1.Size = New System.Drawing.Size(142, 17)
        Me.label1.StylePriority.UseBackColor = False
        Me.label1.StylePriority.UseBorderColor = False
        Me.label1.StylePriority.UseBorders = False
        Me.label1.StylePriority.UseBorderWidth = False
        Me.label1.StylePriority.UseFont = False
        Me.label1.StylePriority.UseForeColor = False
        Me.label1.StylePriority.UseTextAlignment = False
        Me.label1.Text = "Alumno"
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.BorderColor = System.Drawing.Color.Gainsboro
        Me.lbl2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lbl2.BorderWidth = 0
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl2.ForeColor = System.Drawing.Color.DimGray
        Me.lbl2.KeepTogether = True
        Me.lbl2.Location = New System.Drawing.Point(142, 167)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl2.Size = New System.Drawing.Size(142, 17)
        Me.lbl2.StylePriority.UseBackColor = False
        Me.lbl2.StylePriority.UseBorderColor = False
        Me.lbl2.StylePriority.UseBorders = False
        Me.lbl2.StylePriority.UseBorderWidth = False
        Me.lbl2.StylePriority.UseFont = False
        Me.lbl2.StylePriority.UseForeColor = False
        Me.lbl2.StylePriority.UseTextAlignment = False
        Me.lbl2.Text = "Grupo"
        Me.lbl2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrLabel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.BorderWidth = 0
        Me.XrLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.XrLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel5.KeepTogether = True
        Me.XrLabel5.Location = New System.Drawing.Point(283, 167)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(78, 17)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Asistencias"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrLabel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.BorderWidth = 0
        Me.XrLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel4.KeepTogether = True
        Me.XrLabel4.Location = New System.Drawing.Point(367, 167)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(77, 17)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Justificadas"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrLabel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.BorderWidth = 0
        Me.XrLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.XrLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel3.KeepTogether = True
        Me.XrLabel3.Location = New System.Drawing.Point(525, 167)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(77, 17)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Obtenidas"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel7.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrLabel7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.BorderWidth = 0
        Me.XrLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.XrLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel7.KeepTogether = True
        Me.XrLabel7.Location = New System.Drawing.Point(600, 167)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(88, 17)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseBorderWidth = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Asist. Totales"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel9.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrLabel9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.BorderWidth = 0
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.XrLabel9.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel9.KeepTogether = True
        Me.XrLabel9.Location = New System.Drawing.Point(442, 167)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(80, 17)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Faltas"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrLabel8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.BorderWidth = 0
        Me.XrLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.XrLabel8.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel8.KeepTogether = True
        Me.XrLabel8.Location = New System.Drawing.Point(692, 167)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(71, 17)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Porcentaje"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.BorderColor = System.Drawing.Color.Gainsboro
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.BorderWidth = 0
        Me.XrLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.XrLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel2.KeepTogether = True
        Me.XrLabel2.Location = New System.Drawing.Point(767, 167)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(50, 17)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseBorderWidth = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Estado"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.BorderColor = System.Drawing.Color.Gray
        Me.XrLine1.BorderWidth = 0
        Me.XrLine1.ForeColor = System.Drawing.Color.Silver
        Me.XrLine1.Location = New System.Drawing.Point(0, 18)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(819, 7)
        Me.XrLine1.StylePriority.UseBorderColor = False
        Me.XrLine1.StylePriority.UseBorderWidth = False
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'rptSemestral
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(15, 15, 100, 100)
        Me.Version = "9.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents lblFechaIni As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFechaFin As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbl2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblEstatus As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPorcentaje As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAsist_Totales As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblObtenidas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFaltas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblJustificadas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAsistencias As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAlumno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblGrupo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
End Class
