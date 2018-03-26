<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptGrupos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptGrupos))
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.lblPorcentaje = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAsist_Totales = New DevExpress.XtraReports.UI.XRLabel
        Me.lblObtenidas = New DevExpress.XtraReports.UI.XRLabel
        Me.lblFaltas = New DevExpress.XtraReports.UI.XRLabel
        Me.lblJustificadas = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAsistencias = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAlumno = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.lblEmpresa = New DevExpress.XtraReports.UI.XRLabel
        Me.lblSeccion = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNRC = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.lblGrupo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape
        Me.lblFaltasReport = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTotalReport = New DevExpress.XtraReports.UI.XRLabel
        Me.lblObtenidasReport = New DevExpress.XtraReports.UI.XRLabel
        Me.lblJustificadasReport = New DevExpress.XtraReports.UI.XRLabel
        Me.Report = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblAlumnoReport = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPorcentaje, Me.lblAsist_Totales, Me.lblObtenidas, Me.lblFaltas, Me.lblJustificadas, Me.lblAsistencias, Me.lblAlumno, Me.XrLine1})
        Me.Detail.Height = 22
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentaje.ForeColor = System.Drawing.Color.Gray
        Me.lblPorcentaje.KeepTogether = True
        Me.lblPorcentaje.Location = New System.Drawing.Point(717, 0)
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
        Me.lblAsist_Totales.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsist_Totales.ForeColor = System.Drawing.Color.Gray
        Me.lblAsist_Totales.KeepTogether = True
        Me.lblAsist_Totales.Location = New System.Drawing.Point(625, 0)
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
        Me.lblObtenidas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObtenidas.ForeColor = System.Drawing.Color.Gray
        Me.lblObtenidas.KeepTogether = True
        Me.lblObtenidas.Location = New System.Drawing.Point(550, 0)
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
        Me.lblFaltas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaltas.ForeColor = System.Drawing.Color.Gray
        Me.lblFaltas.KeepTogether = True
        Me.lblFaltas.Location = New System.Drawing.Point(467, 0)
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
        Me.lblJustificadas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJustificadas.ForeColor = System.Drawing.Color.Gray
        Me.lblJustificadas.KeepTogether = True
        Me.lblJustificadas.Location = New System.Drawing.Point(392, 0)
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
        Me.lblAsistencias.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsistencias.ForeColor = System.Drawing.Color.Gray
        Me.lblAsistencias.KeepTogether = True
        Me.lblAsistencias.Location = New System.Drawing.Point(300, 0)
        Me.lblAsistencias.Name = "lblAsistencias"
        Me.lblAsistencias.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAsistencias.Size = New System.Drawing.Size(85, 15)
        Me.lblAsistencias.StylePriority.UseFont = False
        Me.lblAsistencias.StylePriority.UseForeColor = False
        Me.lblAsistencias.StylePriority.UseTextAlignment = False
        Me.lblAsistencias.Text = "Precio"
        Me.lblAsistencias.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblAlumno
        '
        Me.lblAlumno.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.lblAlumno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumno.ForeColor = System.Drawing.Color.Gray
        Me.lblAlumno.Location = New System.Drawing.Point(0, 0)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAlumno.Size = New System.Drawing.Size(300, 15)
        Me.lblAlumno.StylePriority.UseFont = False
        Me.lblAlumno.StylePriority.UseForeColor = False
        Me.lblAlumno.StylePriority.UseTextAlignment = False
        Me.lblAlumno.Text = "Precio"
        Me.lblAlumno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.BorderColor = System.Drawing.Color.Gray
        Me.XrLine1.BorderWidth = 0
        Me.XrLine1.ForeColor = System.Drawing.Color.Silver
        Me.XrLine1.Location = New System.Drawing.Point(0, 15)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(783, 7)
        Me.XrLine1.StylePriority.UseBorderColor = False
        Me.XrLine1.StylePriority.UseBorderWidth = False
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.picLogo, Me.lblEmpresa, Me.lblSeccion, Me.XrLabel14, Me.XrLabel15, Me.lblNRC, Me.XrLabel6, Me.XrPictureBox4, Me.lblGrupo, Me.XrLabel12, Me.XrShape1, Me.lblFaltasReport, Me.lblTotalReport, Me.lblObtenidasReport, Me.lblJustificadasReport, Me.Report, Me.XrLine2, Me.lblAlumnoReport, Me.XrLabel8})
        Me.PageHeader.Height = 266
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.Color.Gray
        Me.picLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.picLogo.BorderWidth = 0
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(133, 83)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(52, 52)
        Me.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        Me.picLogo.StylePriority.UseBorderColor = False
        Me.picLogo.StylePriority.UseBorders = False
        Me.picLogo.StylePriority.UseBorderWidth = False
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.ForeColor = System.Drawing.Color.Gray
        Me.lblEmpresa.Location = New System.Drawing.Point(50, 42)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEmpresa.Size = New System.Drawing.Size(658, 25)
        Me.lblEmpresa.StylePriority.UseFont = False
        Me.lblEmpresa.StylePriority.UseForeColor = False
        Me.lblEmpresa.StylePriority.UseTextAlignment = False
        Me.lblEmpresa.Text = "Datos del grupo"
        Me.lblEmpresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblSeccion
        '
        Me.lblSeccion.BorderColor = System.Drawing.Color.LightGray
        Me.lblSeccion.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeccion.ForeColor = System.Drawing.Color.DimGray
        Me.lblSeccion.Location = New System.Drawing.Point(267, 171)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblSeccion.Size = New System.Drawing.Size(358, 25)
        Me.lblSeccion.StylePriority.UseBorderColor = False
        Me.lblSeccion.StylePriority.UseBorders = False
        Me.lblSeccion.StylePriority.UseFont = False
        Me.lblSeccion.StylePriority.UseForeColor = False
        Me.lblSeccion.StylePriority.UseTextAlignment = False
        Me.lblSeccion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.Location = New System.Drawing.Point(208, 133)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.Size = New System.Drawing.Size(58, 17)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "NRC"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.ForeColor = System.Drawing.Color.Black
        Me.XrLabel15.Location = New System.Drawing.Point(216, 175)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.Size = New System.Drawing.Size(50, 17)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Seccion"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblNRC
        '
        Me.lblNRC.BorderColor = System.Drawing.Color.LightGray
        Me.lblNRC.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblNRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRC.ForeColor = System.Drawing.Color.DimGray
        Me.lblNRC.Location = New System.Drawing.Point(267, 129)
        Me.lblNRC.Name = "lblNRC"
        Me.lblNRC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNRC.Size = New System.Drawing.Size(358, 25)
        Me.lblNRC.StylePriority.UseBorderColor = False
        Me.lblNRC.StylePriority.UseBorders = False
        Me.lblNRC.StylePriority.UseFont = False
        Me.lblNRC.StylePriority.UseForeColor = False
        Me.lblNRC.StylePriority.UseTextAlignment = False
        Me.lblNRC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.XrLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel6.Location = New System.Drawing.Point(100, 8)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(392, 27)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.Text = "Reporte de asistencias grupal"
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.BorderColor = System.Drawing.Color.Transparent
        Me.XrPictureBox4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox4.BorderWidth = 0
        Me.XrPictureBox4.Image = CType(resources.GetObject("XrPictureBox4.Image"), System.Drawing.Image)
        Me.XrPictureBox4.Location = New System.Drawing.Point(50, 0)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.CenterImage
        Me.XrPictureBox4.StylePriority.UseBorderColor = False
        Me.XrPictureBox4.StylePriority.UseBorders = False
        Me.XrPictureBox4.StylePriority.UseBorderWidth = False
        '
        'lblGrupo
        '
        Me.lblGrupo.BorderColor = System.Drawing.Color.LightGray
        Me.lblGrupo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.ForeColor = System.Drawing.Color.DimGray
        Me.lblGrupo.Location = New System.Drawing.Point(267, 83)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblGrupo.Size = New System.Drawing.Size(358, 25)
        Me.lblGrupo.StylePriority.UseBorderColor = False
        Me.lblGrupo.StylePriority.UseBorders = False
        Me.lblGrupo.StylePriority.UseFont = False
        Me.lblGrupo.StylePriority.UseForeColor = False
        Me.lblGrupo.StylePriority.UseTextAlignment = False
        Me.lblGrupo.Text = "Grupo"
        Me.lblGrupo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.ForeColor = System.Drawing.Color.Black
        Me.XrLabel12.Location = New System.Drawing.Point(210, 88)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(56, 17)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Grupo"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrShape1
        '
        Me.XrShape1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.XrShape1.ForeColor = System.Drawing.Color.LightGray
        Me.XrShape1.Location = New System.Drawing.Point(50, 42)
        Me.XrShape1.Name = "XrShape1"
        Me.XrShape1.Shape = ShapeRectangle1
        Me.XrShape1.Size = New System.Drawing.Size(683, 29)
        '
        'lblFaltasReport
        '
        Me.lblFaltasReport.BackColor = System.Drawing.Color.Transparent
        Me.lblFaltasReport.BorderColor = System.Drawing.Color.Gainsboro
        Me.lblFaltasReport.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblFaltasReport.BorderWidth = 0
        Me.lblFaltasReport.CanGrow = False
        Me.lblFaltasReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFaltasReport.ForeColor = System.Drawing.Color.DimGray
        Me.lblFaltasReport.KeepTogether = True
        Me.lblFaltasReport.Location = New System.Drawing.Point(470, 241)
        Me.lblFaltasReport.Name = "lblFaltasReport"
        Me.lblFaltasReport.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFaltasReport.Size = New System.Drawing.Size(80, 17)
        Me.lblFaltasReport.StylePriority.UseBackColor = False
        Me.lblFaltasReport.StylePriority.UseBorderColor = False
        Me.lblFaltasReport.StylePriority.UseBorders = False
        Me.lblFaltasReport.StylePriority.UseBorderWidth = False
        Me.lblFaltasReport.StylePriority.UseFont = False
        Me.lblFaltasReport.StylePriority.UseForeColor = False
        Me.lblFaltasReport.StylePriority.UseTextAlignment = False
        Me.lblFaltasReport.Text = "Faltas"
        Me.lblFaltasReport.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblTotalReport
        '
        Me.lblTotalReport.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalReport.BorderColor = System.Drawing.Color.Gainsboro
        Me.lblTotalReport.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTotalReport.BorderWidth = 0
        Me.lblTotalReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTotalReport.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalReport.KeepTogether = True
        Me.lblTotalReport.Location = New System.Drawing.Point(627, 241)
        Me.lblTotalReport.Name = "lblTotalReport"
        Me.lblTotalReport.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotalReport.Size = New System.Drawing.Size(88, 17)
        Me.lblTotalReport.StylePriority.UseBackColor = False
        Me.lblTotalReport.StylePriority.UseBorderColor = False
        Me.lblTotalReport.StylePriority.UseBorders = False
        Me.lblTotalReport.StylePriority.UseBorderWidth = False
        Me.lblTotalReport.StylePriority.UseFont = False
        Me.lblTotalReport.StylePriority.UseForeColor = False
        Me.lblTotalReport.StylePriority.UseTextAlignment = False
        Me.lblTotalReport.Text = "Asist. Totales"
        Me.lblTotalReport.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblObtenidasReport
        '
        Me.lblObtenidasReport.BackColor = System.Drawing.Color.Transparent
        Me.lblObtenidasReport.BorderColor = System.Drawing.Color.Gainsboro
        Me.lblObtenidasReport.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblObtenidasReport.BorderWidth = 0
        Me.lblObtenidasReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblObtenidasReport.ForeColor = System.Drawing.Color.DimGray
        Me.lblObtenidasReport.KeepTogether = True
        Me.lblObtenidasReport.Location = New System.Drawing.Point(550, 241)
        Me.lblObtenidasReport.Name = "lblObtenidasReport"
        Me.lblObtenidasReport.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblObtenidasReport.Size = New System.Drawing.Size(77, 17)
        Me.lblObtenidasReport.StylePriority.UseBackColor = False
        Me.lblObtenidasReport.StylePriority.UseBorderColor = False
        Me.lblObtenidasReport.StylePriority.UseBorders = False
        Me.lblObtenidasReport.StylePriority.UseBorderWidth = False
        Me.lblObtenidasReport.StylePriority.UseFont = False
        Me.lblObtenidasReport.StylePriority.UseForeColor = False
        Me.lblObtenidasReport.StylePriority.UseTextAlignment = False
        Me.lblObtenidasReport.Text = "Obtenidas"
        Me.lblObtenidasReport.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblJustificadasReport
        '
        Me.lblJustificadasReport.BackColor = System.Drawing.Color.Transparent
        Me.lblJustificadasReport.BorderColor = System.Drawing.Color.Gainsboro
        Me.lblJustificadasReport.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblJustificadasReport.BorderWidth = 0
        Me.lblJustificadasReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblJustificadasReport.ForeColor = System.Drawing.Color.DimGray
        Me.lblJustificadasReport.KeepTogether = True
        Me.lblJustificadasReport.Location = New System.Drawing.Point(393, 241)
        Me.lblJustificadasReport.Name = "lblJustificadasReport"
        Me.lblJustificadasReport.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblJustificadasReport.Size = New System.Drawing.Size(77, 17)
        Me.lblJustificadasReport.StylePriority.UseBackColor = False
        Me.lblJustificadasReport.StylePriority.UseBorderColor = False
        Me.lblJustificadasReport.StylePriority.UseBorders = False
        Me.lblJustificadasReport.StylePriority.UseBorderWidth = False
        Me.lblJustificadasReport.StylePriority.UseFont = False
        Me.lblJustificadasReport.StylePriority.UseForeColor = False
        Me.lblJustificadasReport.StylePriority.UseTextAlignment = False
        Me.lblJustificadasReport.Text = "Justificadas"
        Me.lblJustificadasReport.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Report
        '
        Me.Report.BackColor = System.Drawing.Color.Transparent
        Me.Report.BorderColor = System.Drawing.Color.Gainsboro
        Me.Report.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Report.BorderWidth = 0
        Me.Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Report.ForeColor = System.Drawing.Color.DimGray
        Me.Report.KeepTogether = True
        Me.Report.Location = New System.Drawing.Point(300, 241)
        Me.Report.Name = "Report"
        Me.Report.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Report.Size = New System.Drawing.Size(85, 17)
        Me.Report.StylePriority.UseBackColor = False
        Me.Report.StylePriority.UseBorderColor = False
        Me.Report.StylePriority.UseBorders = False
        Me.Report.StylePriority.UseBorderWidth = False
        Me.Report.StylePriority.UseFont = False
        Me.Report.StylePriority.UseForeColor = False
        Me.Report.StylePriority.UseTextAlignment = False
        Me.Report.Text = "Asistencias"
        Me.Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine2
        '
        Me.XrLine2.BorderColor = System.Drawing.Color.Gray
        Me.XrLine2.BorderWidth = 0
        Me.XrLine2.ForeColor = System.Drawing.Color.Gray
        Me.XrLine2.Location = New System.Drawing.Point(0, 258)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(783, 8)
        Me.XrLine2.StylePriority.UseBorderColor = False
        Me.XrLine2.StylePriority.UseBorderWidth = False
        Me.XrLine2.StylePriority.UseForeColor = False
        '
        'lblAlumnoReport
        '
        Me.lblAlumnoReport.BackColor = System.Drawing.Color.Transparent
        Me.lblAlumnoReport.BorderColor = System.Drawing.Color.Gainsboro
        Me.lblAlumnoReport.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblAlumnoReport.BorderWidth = 0
        Me.lblAlumnoReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAlumnoReport.ForeColor = System.Drawing.Color.DimGray
        Me.lblAlumnoReport.KeepTogether = True
        Me.lblAlumnoReport.Location = New System.Drawing.Point(0, 241)
        Me.lblAlumnoReport.Name = "lblAlumnoReport"
        Me.lblAlumnoReport.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAlumnoReport.Size = New System.Drawing.Size(300, 17)
        Me.lblAlumnoReport.StylePriority.UseBackColor = False
        Me.lblAlumnoReport.StylePriority.UseBorderColor = False
        Me.lblAlumnoReport.StylePriority.UseBorders = False
        Me.lblAlumnoReport.StylePriority.UseBorderWidth = False
        Me.lblAlumnoReport.StylePriority.UseFont = False
        Me.lblAlumnoReport.StylePriority.UseForeColor = False
        Me.lblAlumnoReport.StylePriority.UseTextAlignment = False
        Me.lblAlumnoReport.Text = "Alumno"
        Me.lblAlumnoReport.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        Me.XrLabel8.Location = New System.Drawing.Point(719, 241)
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
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptGrupos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 50, 50)
        Me.Version = "9.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents lblEmpresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSeccion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNRC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents lblGrupo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents lblFaltasReport As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTotalReport As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblObtenidasReport As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblJustificadasReport As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Report As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblAlumnoReport As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPorcentaje As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAsist_Totales As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblObtenidas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFaltas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblJustificadas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAsistencias As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAlumno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
End Class
