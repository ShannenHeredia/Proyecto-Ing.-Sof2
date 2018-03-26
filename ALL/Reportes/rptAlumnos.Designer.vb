<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptAlumnos))
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.lblAsistencias = New DevExpress.XtraReports.UI.XRLabel
        Me.lblJustificadas = New DevExpress.XtraReports.UI.XRLabel
        Me.lblFaltas = New DevExpress.XtraReports.UI.XRLabel
        Me.lblObtenidas = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAsist_Totales = New DevExpress.XtraReports.UI.XRLabel
        Me.lblPorcentaje = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.lblGrupo = New DevExpress.XtraReports.UI.XRLabel
        Me.lblFecha = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAlumno = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCodigo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCarrera = New DevExpress.XtraReports.UI.XRLabel
        Me.lblEmpresa = New DevExpress.XtraReports.UI.XRLabel
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine7 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblAsist_Totales, Me.lblPorcentaje, Me.XrLine1, Me.lblGrupo, Me.XrLine3, Me.lblAsistencias, Me.XrLine4, Me.lblJustificadas, Me.XrLine5, Me.XrLine6, Me.XrLine7, Me.lblFaltas, Me.lblObtenidas, Me.XrLine8})
        Me.Detail.Height = 24
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblAsistencias
        '
        Me.lblAsistencias.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsistencias.ForeColor = System.Drawing.Color.Gray
        Me.lblAsistencias.KeepTogether = True
        Me.lblAsistencias.Location = New System.Drawing.Point(300, 0)
        Me.lblAsistencias.Name = "lblAsistencias"
        Me.lblAsistencias.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAsistencias.Size = New System.Drawing.Size(88, 17)
        Me.lblAsistencias.StylePriority.UseFont = False
        Me.lblAsistencias.StylePriority.UseForeColor = False
        Me.lblAsistencias.StylePriority.UseTextAlignment = False
        Me.lblAsistencias.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblJustificadas
        '
        Me.lblJustificadas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJustificadas.ForeColor = System.Drawing.Color.Gray
        Me.lblJustificadas.KeepTogether = True
        Me.lblJustificadas.Location = New System.Drawing.Point(393, 1)
        Me.lblJustificadas.Name = "lblJustificadas"
        Me.lblJustificadas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblJustificadas.Size = New System.Drawing.Size(77, 15)
        Me.lblJustificadas.StylePriority.UseFont = False
        Me.lblJustificadas.StylePriority.UseForeColor = False
        Me.lblJustificadas.StylePriority.UseTextAlignment = False
        Me.lblJustificadas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblFaltas
        '
        Me.lblFaltas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaltas.ForeColor = System.Drawing.Color.Gray
        Me.lblFaltas.KeepTogether = True
        Me.lblFaltas.Location = New System.Drawing.Point(470, 1)
        Me.lblFaltas.Name = "lblFaltas"
        Me.lblFaltas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFaltas.Size = New System.Drawing.Size(80, 15)
        Me.lblFaltas.StylePriority.UseFont = False
        Me.lblFaltas.StylePriority.UseForeColor = False
        Me.lblFaltas.StylePriority.UseTextAlignment = False
        Me.lblFaltas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblObtenidas
        '
        Me.lblObtenidas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObtenidas.ForeColor = System.Drawing.Color.Gray
        Me.lblObtenidas.KeepTogether = True
        Me.lblObtenidas.Location = New System.Drawing.Point(550, 1)
        Me.lblObtenidas.Name = "lblObtenidas"
        Me.lblObtenidas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblObtenidas.Size = New System.Drawing.Size(77, 15)
        Me.lblObtenidas.StylePriority.UseFont = False
        Me.lblObtenidas.StylePriority.UseForeColor = False
        Me.lblObtenidas.StylePriority.UseTextAlignment = False
        Me.lblObtenidas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblAsist_Totales
        '
        Me.lblAsist_Totales.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsist_Totales.ForeColor = System.Drawing.Color.Gray
        Me.lblAsist_Totales.KeepTogether = True
        Me.lblAsist_Totales.Location = New System.Drawing.Point(627, 1)
        Me.lblAsist_Totales.Name = "lblAsist_Totales"
        Me.lblAsist_Totales.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAsist_Totales.Size = New System.Drawing.Size(88, 15)
        Me.lblAsist_Totales.StylePriority.UseFont = False
        Me.lblAsist_Totales.StylePriority.UseForeColor = False
        Me.lblAsist_Totales.StylePriority.UseTextAlignment = False
        Me.lblAsist_Totales.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentaje.ForeColor = System.Drawing.Color.Gray
        Me.lblPorcentaje.KeepTogether = True
        Me.lblPorcentaje.Location = New System.Drawing.Point(719, 1)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPorcentaje.Size = New System.Drawing.Size(71, 15)
        Me.lblPorcentaje.StylePriority.UseFont = False
        Me.lblPorcentaje.StylePriority.UseForeColor = False
        Me.lblPorcentaje.StylePriority.UseTextAlignment = False
        Me.lblPorcentaje.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.BorderColor = System.Drawing.Color.Gray
        Me.XrLine1.BorderWidth = 0
        Me.XrLine1.ForeColor = System.Drawing.Color.Silver
        Me.XrLine1.Location = New System.Drawing.Point(0, 17)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(790, 7)
        Me.XrLine1.StylePriority.UseBorderColor = False
        Me.XrLine1.StylePriority.UseBorderWidth = False
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'lblGrupo
        '
        Me.lblGrupo.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.lblGrupo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.ForeColor = System.Drawing.Color.Gray
        Me.lblGrupo.Location = New System.Drawing.Point(0, 1)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblGrupo.Size = New System.Drawing.Size(300, 15)
        Me.lblGrupo.StylePriority.UseFont = False
        Me.lblGrupo.StylePriority.UseForeColor = False
        Me.lblGrupo.StylePriority.UseTextAlignment = False
        Me.lblGrupo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Gray
        Me.lblFecha.Location = New System.Drawing.Point(17, 108)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFecha.Size = New System.Drawing.Size(83, 15)
        Me.lblFecha.StylePriority.UseFont = False
        Me.lblFecha.StylePriority.UseForeColor = False
        Me.lblFecha.StylePriority.UseTextAlignment = False
        Me.lblFecha.Text = "Precio"
        Me.lblFecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblFecha.Visible = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.lblAlumno, Me.XrPictureBox4, Me.XrLabel6, Me.lblCodigo, Me.XrLabel15, Me.XrLabel14, Me.lblCarrera, Me.lblEmpresa, Me.picLogo, Me.XrShape1, Me.XrLine2, Me.XrLabel5, Me.XrLabel1, Me.XrLabel4, Me.XrLabel3, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.lblFecha, Me.XrLabel2})
        Me.PageHeader.Height = 267
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.ForeColor = System.Drawing.Color.Black
        Me.XrLabel12.Location = New System.Drawing.Point(225, 92)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(56, 17)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Alumno:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblAlumno
        '
        Me.lblAlumno.BorderColor = System.Drawing.Color.LightGray
        Me.lblAlumno.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumno.ForeColor = System.Drawing.Color.DimGray
        Me.lblAlumno.Location = New System.Drawing.Point(283, 83)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAlumno.Size = New System.Drawing.Size(358, 25)
        Me.lblAlumno.StylePriority.UseBorderColor = False
        Me.lblAlumno.StylePriority.UseBorders = False
        Me.lblAlumno.StylePriority.UseFont = False
        Me.lblAlumno.StylePriority.UseForeColor = False
        Me.lblAlumno.StylePriority.UseTextAlignment = False
        Me.lblAlumno.Text = "ALumno"
        Me.lblAlumno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.BorderColor = System.Drawing.Color.Transparent
        Me.XrPictureBox4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox4.BorderWidth = 0
        Me.XrPictureBox4.Image = CType(resources.GetObject("XrPictureBox4.Image"), System.Drawing.Image)
        Me.XrPictureBox4.Location = New System.Drawing.Point(51, 0)
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
        Me.XrLabel6.Location = New System.Drawing.Point(109, 8)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(392, 27)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.Text = "Reporte de asistencias del alumno"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderColor = System.Drawing.Color.LightGray
        Me.lblCodigo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.DimGray
        Me.lblCodigo.Location = New System.Drawing.Point(283, 125)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCodigo.Size = New System.Drawing.Size(358, 25)
        Me.lblCodigo.StylePriority.UseBorderColor = False
        Me.lblCodigo.StylePriority.UseBorders = False
        Me.lblCodigo.StylePriority.UseFont = False
        Me.lblCodigo.StylePriority.UseForeColor = False
        Me.lblCodigo.StylePriority.UseTextAlignment = False
        Me.lblCodigo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.ForeColor = System.Drawing.Color.Black
        Me.XrLabel15.Location = New System.Drawing.Point(224, 175)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.Size = New System.Drawing.Size(58, 17)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Carrera:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.Location = New System.Drawing.Point(225, 125)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.Size = New System.Drawing.Size(58, 17)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Código:"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblCarrera
        '
        Me.lblCarrera.BorderColor = System.Drawing.Color.LightGray
        Me.lblCarrera.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarrera.ForeColor = System.Drawing.Color.DimGray
        Me.lblCarrera.Location = New System.Drawing.Point(283, 167)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCarrera.Size = New System.Drawing.Size(358, 25)
        Me.lblCarrera.StylePriority.UseBorderColor = False
        Me.lblCarrera.StylePriority.UseBorders = False
        Me.lblCarrera.StylePriority.UseFont = False
        Me.lblCarrera.StylePriority.UseForeColor = False
        Me.lblCarrera.StylePriority.UseTextAlignment = False
        Me.lblCarrera.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.ForeColor = System.Drawing.Color.Gray
        Me.lblEmpresa.Location = New System.Drawing.Point(67, 42)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEmpresa.Size = New System.Drawing.Size(658, 25)
        Me.lblEmpresa.StylePriority.UseFont = False
        Me.lblEmpresa.StylePriority.UseForeColor = False
        Me.lblEmpresa.StylePriority.UseTextAlignment = False
        Me.lblEmpresa.Text = "Datos del Alumno"
        Me.lblEmpresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.Color.Gray
        Me.picLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.picLogo.BorderWidth = 0
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(142, 83)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(63, 63)
        Me.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        Me.picLogo.StylePriority.UseBorderColor = False
        Me.picLogo.StylePriority.UseBorders = False
        Me.picLogo.StylePriority.UseBorderWidth = False
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
        'XrLine2
        '
        Me.XrLine2.BorderColor = System.Drawing.Color.Gray
        Me.XrLine2.BorderWidth = 0
        Me.XrLine2.ForeColor = System.Drawing.Color.Gray
        Me.XrLine2.Location = New System.Drawing.Point(0, 258)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(790, 8)
        Me.XrLine2.StylePriority.UseBorderColor = False
        Me.XrLine2.StylePriority.UseBorderWidth = False
        Me.XrLine2.StylePriority.UseForeColor = False
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
        Me.XrLabel5.Location = New System.Drawing.Point(302, 241)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(85, 17)
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
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.BorderColor = System.Drawing.Color.LightGray
        Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.BorderWidth = 0
        Me.XrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel1.KeepTogether = True
        Me.XrLabel1.Location = New System.Drawing.Point(17, 142)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(83, 17)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Fecha"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel1.Visible = False
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
        Me.XrLabel4.Location = New System.Drawing.Point(393, 241)
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
        Me.XrLabel3.Location = New System.Drawing.Point(550, 241)
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
        Me.XrLabel7.Location = New System.Drawing.Point(627, 241)
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
        Me.XrLabel9.Location = New System.Drawing.Point(470, 241)
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
        Me.XrLabel2.Location = New System.Drawing.Point(0, 241)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(300, 17)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseBorderWidth = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Grupo"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine3
        '
        Me.XrLine3.BorderColor = System.Drawing.Color.Gray
        Me.XrLine3.BorderWidth = 0
        Me.XrLine3.ForeColor = System.Drawing.Color.Silver
        Me.XrLine3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine3.Location = New System.Drawing.Point(300, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(8, 20)
        Me.XrLine3.StylePriority.UseBorderColor = False
        Me.XrLine3.StylePriority.UseBorderWidth = False
        Me.XrLine3.StylePriority.UseForeColor = False
        '
        'XrLine4
        '
        Me.XrLine4.BorderColor = System.Drawing.Color.Gray
        Me.XrLine4.BorderWidth = 0
        Me.XrLine4.ForeColor = System.Drawing.Color.Silver
        Me.XrLine4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine4.Location = New System.Drawing.Point(386, 0)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Size = New System.Drawing.Size(8, 20)
        Me.XrLine4.StylePriority.UseBorderColor = False
        Me.XrLine4.StylePriority.UseBorderWidth = False
        Me.XrLine4.StylePriority.UseForeColor = False
        '
        'XrLine5
        '
        Me.XrLine5.BorderColor = System.Drawing.Color.Gray
        Me.XrLine5.BorderWidth = 0
        Me.XrLine5.ForeColor = System.Drawing.Color.Silver
        Me.XrLine5.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine5.Location = New System.Drawing.Point(471, 0)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Size = New System.Drawing.Size(8, 20)
        Me.XrLine5.StylePriority.UseBorderColor = False
        Me.XrLine5.StylePriority.UseBorderWidth = False
        Me.XrLine5.StylePriority.UseForeColor = False
        '
        'XrLine6
        '
        Me.XrLine6.BorderColor = System.Drawing.Color.Gray
        Me.XrLine6.BorderWidth = 0
        Me.XrLine6.ForeColor = System.Drawing.Color.Silver
        Me.XrLine6.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine6.Location = New System.Drawing.Point(540, 0)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.Size = New System.Drawing.Size(8, 20)
        Me.XrLine6.StylePriority.UseBorderColor = False
        Me.XrLine6.StylePriority.UseBorderWidth = False
        Me.XrLine6.StylePriority.UseForeColor = False
        '
        'XrLine7
        '
        Me.XrLine7.BorderColor = System.Drawing.Color.Gray
        Me.XrLine7.BorderWidth = 0
        Me.XrLine7.ForeColor = System.Drawing.Color.Silver
        Me.XrLine7.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine7.Location = New System.Drawing.Point(618, 0)
        Me.XrLine7.Name = "XrLine7"
        Me.XrLine7.Size = New System.Drawing.Size(8, 20)
        Me.XrLine7.StylePriority.UseBorderColor = False
        Me.XrLine7.StylePriority.UseBorderWidth = False
        Me.XrLine7.StylePriority.UseForeColor = False
        '
        'XrLine8
        '
        Me.XrLine8.BorderColor = System.Drawing.Color.Gray
        Me.XrLine8.BorderWidth = 0
        Me.XrLine8.ForeColor = System.Drawing.Color.Silver
        Me.XrLine8.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine8.Location = New System.Drawing.Point(714, 0)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.Size = New System.Drawing.Size(8, 20)
        Me.XrLine8.StylePriority.UseBorderColor = False
        Me.XrLine8.StylePriority.UseBorderWidth = False
        Me.XrLine8.StylePriority.UseForeColor = False
        '
        'rptAlumnos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 50, 50)
        Me.Version = "9.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAlumno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCodigo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCarrera As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents lblEmpresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAsistencias As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblGrupo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblJustificadas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFaltas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblObtenidas As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAsist_Totales As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPorcentaje As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
End Class
