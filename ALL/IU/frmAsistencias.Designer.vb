<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsistencias
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsistencias))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnlPrincipal = New System.Windows.Forms.Panel
        Me.pnlTitulo = New System.Windows.Forms.Panel
        Me.cmdRegresar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.gpoListadoAlumnos = New System.Windows.Forms.GroupBox
        Me.lblAsistencia = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.cmdRemoveAll = New System.Windows.Forms.Button
        Me.cmdAddAll = New System.Windows.Forms.Button
        Me.grdAsistencias = New System.Windows.Forms.DataGridView
        Me.coliCodAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coliCodGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Paterno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Materno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Carrera = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_chkAsistencia = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.col_Asistencia = New System.Windows.Forms.DataGridViewImageColumn
        Me.col_chkJustificacion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.col_Justificacion = New System.Windows.Forms.DataGridViewImageColumn
        Me.gpoHistorial = New System.Windows.Forms.GroupBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblHistorial = New System.Windows.Forms.Label
        Me.cmdNuevaAsistencia = New System.Windows.Forms.Button
        Me.grdHistorialAsistencias = New System.Windows.Forms.DataGridView
        Me.col_TranAsistencias = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_TranGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Hora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Grupo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Editar = New System.Windows.Forms.DataGridViewImageColumn
        Me.gpoAsistenciaUpdate = New System.Windows.Forms.GroupBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.cmdActualizarAsistencia = New System.Windows.Forms.Button
        Me.grdAsistenciaUpdate = New System.Windows.Forms.DataGridView
        Me.col_RelAsistencias = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_CodAsistencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_CodAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_RelAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_tiEstatusAsistencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_tiEstatusJustificacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_RelCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_RelCarrera = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Rel_chkAistencia = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.col_Rel_Asistencia = New System.Windows.Forms.DataGridViewImageColumn
        Me.col_Rel_chk_Justificacion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.col_Rel_Justificacion = New System.Windows.Forms.DataGridViewImageColumn
        Me.lsvGrupos = New System.Windows.Forms.ListView
        Me.colMarca = New System.Windows.Forms.ColumnHeader
        Me.cmdAltaPacienteLive = New DevComponents.DotNetBar.BubbleButton
        Me.imgAsistencia = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoListadoAlumnos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grdAsistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoHistorial.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.grdHistorialAsistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoAsistenciaUpdate.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.grdAsistenciaUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlPrincipal.Controls.Add(Me.pnlTitulo)
        Me.pnlPrincipal.Controls.Add(Me.gpoListadoAlumnos)
        Me.pnlPrincipal.Controls.Add(Me.gpoHistorial)
        Me.pnlPrincipal.Controls.Add(Me.gpoAsistenciaUpdate)
        Me.pnlPrincipal.Controls.Add(Me.lsvGrupos)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(900, 720)
        Me.pnlPrincipal.TabIndex = 0
        '
        'pnlTitulo
        '
        Me.pnlTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTitulo.BackColor = System.Drawing.Color.White
        Me.pnlTitulo.Controls.Add(Me.cmdRegresar)
        Me.pnlTitulo.Controls.Add(Me.PictureBox1)
        Me.pnlTitulo.Controls.Add(Me.Label5)
        Me.pnlTitulo.Controls.Add(Me.cmdAceptar)
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Controls.Add(Me.cmdSalir)
        Me.pnlTitulo.Location = New System.Drawing.Point(1, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(897, 80)
        Me.pnlTitulo.TabIndex = 388
        '
        'cmdRegresar
        '
        Me.cmdRegresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRegresar.BackColor = System.Drawing.Color.Transparent
        Me.cmdRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdRegresar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdRegresar.FlatAppearance.BorderSize = 0
        Me.cmdRegresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmdRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdRegresar.ForeColor = System.Drawing.Color.White
        Me.cmdRegresar.Image = CType(resources.GetObject("cmdRegresar.Image"), System.Drawing.Image)
        Me.cmdRegresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRegresar.Location = New System.Drawing.Point(748, 12)
        Me.cmdRegresar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdRegresar.Name = "cmdRegresar"
        Me.cmdRegresar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRegresar.Size = New System.Drawing.Size(70, 55)
        Me.cmdRegresar.TabIndex = 1965
        Me.cmdRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdRegresar.UseVisualStyleBackColor = False
        Me.cmdRegresar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 390
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Location = New System.Drawing.Point(0, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(897, 1)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(756, 12)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(70, 55)
        Me.cmdAceptar.TabIndex = 535
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAceptar.UseVisualStyleBackColor = False
        Me.cmdAceptar.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.DimGray
        Me.lblTitulo.Location = New System.Drawing.Point(103, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(153, 31)
        Me.lblTitulo.TabIndex = 534
        Me.lblTitulo.Text = "Asistencias"
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
        Me.cmdSalir.Location = New System.Drawing.Point(826, 12)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(70, 55)
        Me.cmdSalir.TabIndex = 379
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'gpoListadoAlumnos
        '
        Me.gpoListadoAlumnos.Controls.Add(Me.lblAsistencia)
        Me.gpoListadoAlumnos.Controls.Add(Me.Panel2)
        Me.gpoListadoAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 0.1!)
        Me.gpoListadoAlumnos.Location = New System.Drawing.Point(26, 101)
        Me.gpoListadoAlumnos.Name = "gpoListadoAlumnos"
        Me.gpoListadoAlumnos.Size = New System.Drawing.Size(844, 591)
        Me.gpoListadoAlumnos.TabIndex = 390
        Me.gpoListadoAlumnos.TabStop = False
        '
        'lblAsistencia
        '
        Me.lblAsistencia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAsistencia.AutoSize = True
        Me.lblAsistencia.BackColor = System.Drawing.Color.Transparent
        Me.lblAsistencia.Font = New System.Drawing.Font("Helvetica-Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsistencia.ForeColor = System.Drawing.Color.DimGray
        Me.lblAsistencia.Location = New System.Drawing.Point(16, 22)
        Me.lblAsistencia.Name = "lblAsistencia"
        Me.lblAsistencia.Size = New System.Drawing.Size(257, 28)
        Me.lblAsistencia.TabIndex = 1814
        Me.lblAsistencia.Text = "Historial de asistencias"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cmdGuardar)
        Me.Panel2.Controls.Add(Me.cmdRemoveAll)
        Me.Panel2.Controls.Add(Me.cmdAddAll)
        Me.Panel2.Controls.Add(Me.grdAsistencias)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(838, 584)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Helvetica-Light", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(14, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 1815
        Me.Label1.Text = "Seccion"
        Me.Label1.Visible = False
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdGuardar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.cmdGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardar.Font = New System.Drawing.Font("Helvetica-Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.ForeColor = System.Drawing.Color.White
        Me.cmdGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGuardar.Location = New System.Drawing.Point(351, 520)
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGuardar.Size = New System.Drawing.Size(137, 47)
        Me.cmdGuardar.TabIndex = 1812
        Me.cmdGuardar.Text = "&Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'cmdRemoveAll
        '
        Me.cmdRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemoveAll.BackColor = System.Drawing.Color.White
        Me.cmdRemoveAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdRemoveAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdRemoveAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdRemoveAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdRemoveAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.cmdRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRemoveAll.Font = New System.Drawing.Font("Helvetica-Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemoveAll.ForeColor = System.Drawing.Color.DimGray
        Me.cmdRemoveAll.Image = CType(resources.GetObject("cmdRemoveAll.Image"), System.Drawing.Image)
        Me.cmdRemoveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdRemoveAll.Location = New System.Drawing.Point(690, 14)
        Me.cmdRemoveAll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdRemoveAll.Name = "cmdRemoveAll"
        Me.cmdRemoveAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRemoveAll.Size = New System.Drawing.Size(141, 35)
        Me.cmdRemoveAll.TabIndex = 1811
        Me.cmdRemoveAll.Text = "&Deshacer  "
        Me.cmdRemoveAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRemoveAll.UseVisualStyleBackColor = False
        '
        'cmdAddAll
        '
        Me.cmdAddAll.BackColor = System.Drawing.Color.White
        Me.cmdAddAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAddAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdAddAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdAddAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAddAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.cmdAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddAll.Font = New System.Drawing.Font("Helvetica-Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddAll.ForeColor = System.Drawing.Color.DimGray
        Me.cmdAddAll.Image = CType(resources.GetObject("cmdAddAll.Image"), System.Drawing.Image)
        Me.cmdAddAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAddAll.Location = New System.Drawing.Point(510, 14)
        Me.cmdAddAll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdAddAll.Name = "cmdAddAll"
        Me.cmdAddAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddAll.Size = New System.Drawing.Size(171, 35)
        Me.cmdAddAll.TabIndex = 1810
        Me.cmdAddAll.Text = "&Asistencia general"
        Me.cmdAddAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAddAll.UseVisualStyleBackColor = False
        '
        'grdAsistencias
        '
        Me.grdAsistencias.AllowUserToAddRows = False
        Me.grdAsistencias.AllowUserToDeleteRows = False
        Me.grdAsistencias.AllowUserToOrderColumns = True
        Me.grdAsistencias.AllowUserToResizeRows = False
        Me.grdAsistencias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAsistencias.BackgroundColor = System.Drawing.Color.White
        Me.grdAsistencias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdAsistencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdAsistencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAsistencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdAsistencias.ColumnHeadersHeight = 40
        Me.grdAsistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coliCodAlumno, Me.coliCodGrupo, Me.col_Nombre, Me.col_Paterno, Me.col_Materno, Me.col_NombreCompleto, Me.col_Codigo, Me.col_Carrera, Me.col_chkAsistencia, Me.col_Asistencia, Me.col_chkJustificacion, Me.col_Justificacion})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdAsistencias.DefaultCellStyle = DataGridViewCellStyle5
        Me.grdAsistencias.EnableHeadersVisualStyles = False
        Me.grdAsistencias.GridColor = System.Drawing.Color.LightGray
        Me.grdAsistencias.Location = New System.Drawing.Point(4, 63)
        Me.grdAsistencias.MultiSelect = False
        Me.grdAsistencias.Name = "grdAsistencias"
        Me.grdAsistencias.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAsistencias.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdAsistencias.RowHeadersVisible = False
        Me.grdAsistencias.RowHeadersWidth = 10
        Me.grdAsistencias.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.grdAsistencias.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
        Me.grdAsistencias.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdAsistencias.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grdAsistencias.RowTemplate.Height = 40
        Me.grdAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdAsistencias.Size = New System.Drawing.Size(832, 438)
        Me.grdAsistencias.StandardTab = True
        Me.grdAsistencias.TabIndex = 4
        '
        'coliCodAlumno
        '
        Me.coliCodAlumno.DataPropertyName = "iCodAlumno"
        Me.coliCodAlumno.HeaderText = "Cod. Alumno"
        Me.coliCodAlumno.Name = "coliCodAlumno"
        Me.coliCodAlumno.ReadOnly = True
        Me.coliCodAlumno.Visible = False
        '
        'coliCodGrupo
        '
        Me.coliCodGrupo.DataPropertyName = "iCodGrupo"
        Me.coliCodGrupo.HeaderText = "Cod.Grupo"
        Me.coliCodGrupo.Name = "coliCodGrupo"
        Me.coliCodGrupo.ReadOnly = True
        Me.coliCodGrupo.Visible = False
        '
        'col_Nombre
        '
        Me.col_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_Nombre.DataPropertyName = "vchNombre"
        Me.col_Nombre.HeaderText = "Nombre"
        Me.col_Nombre.Name = "col_Nombre"
        Me.col_Nombre.ReadOnly = True
        Me.col_Nombre.Visible = False
        '
        'col_Paterno
        '
        Me.col_Paterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_Paterno.DataPropertyName = "vchPaterno"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Format = "D"
        DataGridViewCellStyle2.NullValue = "Sin fecha"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.col_Paterno.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_Paterno.FillWeight = 35.73656!
        Me.col_Paterno.HeaderText = "A. Paterno"
        Me.col_Paterno.MinimumWidth = 100
        Me.col_Paterno.Name = "col_Paterno"
        Me.col_Paterno.ReadOnly = True
        Me.col_Paterno.Visible = False
        Me.col_Paterno.Width = 150
        '
        'col_Materno
        '
        Me.col_Materno.DataPropertyName = "vchMaterno"
        Me.col_Materno.HeaderText = "A.Materno"
        Me.col_Materno.Name = "col_Materno"
        Me.col_Materno.ReadOnly = True
        Me.col_Materno.Visible = False
        '
        'col_NombreCompleto
        '
        Me.col_NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_NombreCompleto.DataPropertyName = "vchAlumno"
        Me.col_NombreCompleto.HeaderText = "Alumno"
        Me.col_NombreCompleto.Name = "col_NombreCompleto"
        Me.col_NombreCompleto.ReadOnly = True
        '
        'col_Codigo
        '
        Me.col_Codigo.DataPropertyName = "vchCodigo"
        Me.col_Codigo.HeaderText = "Codigo"
        Me.col_Codigo.Name = "col_Codigo"
        Me.col_Codigo.ReadOnly = True
        Me.col_Codigo.Width = 180
        '
        'col_Carrera
        '
        Me.col_Carrera.DataPropertyName = "vchCarrera"
        Me.col_Carrera.HeaderText = "Carrera"
        Me.col_Carrera.Name = "col_Carrera"
        Me.col_Carrera.ReadOnly = True
        '
        'col_chkAsistencia
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.col_chkAsistencia.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_chkAsistencia.HeaderText = " "
        Me.col_chkAsistencia.Name = "col_chkAsistencia"
        Me.col_chkAsistencia.ReadOnly = True
        Me.col_chkAsistencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_chkAsistencia.Visible = False
        Me.col_chkAsistencia.Width = 40
        '
        'col_Asistencia
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = CType(resources.GetObject("DataGridViewCellStyle4.NullValue"), Object)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.col_Asistencia.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_Asistencia.HeaderText = "Asistencia"
        Me.col_Asistencia.Image = CType(resources.GetObject("col_Asistencia.Image"), System.Drawing.Image)
        Me.col_Asistencia.MinimumWidth = 80
        Me.col_Asistencia.Name = "col_Asistencia"
        Me.col_Asistencia.ReadOnly = True
        Me.col_Asistencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_Asistencia.Width = 80
        '
        'col_chkJustificacion
        '
        Me.col_chkJustificacion.HeaderText = " "
        Me.col_chkJustificacion.Name = "col_chkJustificacion"
        Me.col_chkJustificacion.ReadOnly = True
        Me.col_chkJustificacion.Visible = False
        '
        'col_Justificacion
        '
        Me.col_Justificacion.HeaderText = "Justificacion"
        Me.col_Justificacion.Image = CType(resources.GetObject("col_Justificacion.Image"), System.Drawing.Image)
        Me.col_Justificacion.MinimumWidth = 80
        Me.col_Justificacion.Name = "col_Justificacion"
        Me.col_Justificacion.ReadOnly = True
        Me.col_Justificacion.Width = 80
        '
        'gpoHistorial
        '
        Me.gpoHistorial.Controls.Add(Me.Panel3)
        Me.gpoHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 0.1!)
        Me.gpoHistorial.Location = New System.Drawing.Point(26, 101)
        Me.gpoHistorial.Name = "gpoHistorial"
        Me.gpoHistorial.Size = New System.Drawing.Size(844, 591)
        Me.gpoHistorial.TabIndex = 391
        Me.gpoHistorial.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblHistorial)
        Me.Panel3.Controls.Add(Me.cmdNuevaAsistencia)
        Me.Panel3.Controls.Add(Me.grdHistorialAsistencias)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(838, 584)
        Me.Panel3.TabIndex = 0
        '
        'lblHistorial
        '
        Me.lblHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHistorial.AutoSize = True
        Me.lblHistorial.BackColor = System.Drawing.Color.Transparent
        Me.lblHistorial.Font = New System.Drawing.Font("Helvetica-Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistorial.ForeColor = System.Drawing.Color.DimGray
        Me.lblHistorial.Location = New System.Drawing.Point(13, 14)
        Me.lblHistorial.Name = "lblHistorial"
        Me.lblHistorial.Size = New System.Drawing.Size(257, 28)
        Me.lblHistorial.TabIndex = 1814
        Me.lblHistorial.Text = "Historial de asistencias"
        '
        'cmdNuevaAsistencia
        '
        Me.cmdNuevaAsistencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNuevaAsistencia.BackColor = System.Drawing.Color.Transparent
        Me.cmdNuevaAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdNuevaAsistencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNuevaAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmdNuevaAsistencia.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmdNuevaAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdNuevaAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdNuevaAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNuevaAsistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevaAsistencia.ForeColor = System.Drawing.Color.DimGray
        Me.cmdNuevaAsistencia.Image = CType(resources.GetObject("cmdNuevaAsistencia.Image"), System.Drawing.Image)
        Me.cmdNuevaAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNuevaAsistencia.Location = New System.Drawing.Point(717, 14)
        Me.cmdNuevaAsistencia.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdNuevaAsistencia.Name = "cmdNuevaAsistencia"
        Me.cmdNuevaAsistencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNuevaAsistencia.Size = New System.Drawing.Size(115, 42)
        Me.cmdNuevaAsistencia.TabIndex = 1813
        Me.cmdNuevaAsistencia.Text = "Agregar"
        Me.cmdNuevaAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevaAsistencia.UseVisualStyleBackColor = False
        '
        'grdHistorialAsistencias
        '
        Me.grdHistorialAsistencias.AllowUserToAddRows = False
        Me.grdHistorialAsistencias.AllowUserToDeleteRows = False
        Me.grdHistorialAsistencias.AllowUserToOrderColumns = True
        Me.grdHistorialAsistencias.AllowUserToResizeRows = False
        Me.grdHistorialAsistencias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdHistorialAsistencias.BackgroundColor = System.Drawing.Color.White
        Me.grdHistorialAsistencias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdHistorialAsistencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdHistorialAsistencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdHistorialAsistencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grdHistorialAsistencias.ColumnHeadersHeight = 40
        Me.grdHistorialAsistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_TranAsistencias, Me.col_TranGrupo, Me.col_Fecha, Me.col_Hora, Me.col_Grupo, Me.col_Editar})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdHistorialAsistencias.DefaultCellStyle = DataGridViewCellStyle9
        Me.grdHistorialAsistencias.EnableHeadersVisualStyles = False
        Me.grdHistorialAsistencias.GridColor = System.Drawing.Color.LightGray
        Me.grdHistorialAsistencias.Location = New System.Drawing.Point(4, 63)
        Me.grdHistorialAsistencias.MultiSelect = False
        Me.grdHistorialAsistencias.Name = "grdHistorialAsistencias"
        Me.grdHistorialAsistencias.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdHistorialAsistencias.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grdHistorialAsistencias.RowHeadersVisible = False
        Me.grdHistorialAsistencias.RowHeadersWidth = 10
        Me.grdHistorialAsistencias.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.grdHistorialAsistencias.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
        Me.grdHistorialAsistencias.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdHistorialAsistencias.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grdHistorialAsistencias.RowTemplate.Height = 40
        Me.grdHistorialAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdHistorialAsistencias.Size = New System.Drawing.Size(832, 504)
        Me.grdHistorialAsistencias.StandardTab = True
        Me.grdHistorialAsistencias.TabIndex = 4
        '
        'col_TranAsistencias
        '
        Me.col_TranAsistencias.DataPropertyName = "iCodAsistencias"
        Me.col_TranAsistencias.HeaderText = "Cod. Asistencias"
        Me.col_TranAsistencias.Name = "col_TranAsistencias"
        Me.col_TranAsistencias.ReadOnly = True
        Me.col_TranAsistencias.Visible = False
        '
        'col_TranGrupo
        '
        Me.col_TranGrupo.DataPropertyName = "iCodGrupo"
        Me.col_TranGrupo.HeaderText = "Cod.Grupo"
        Me.col_TranGrupo.Name = "col_TranGrupo"
        Me.col_TranGrupo.ReadOnly = True
        Me.col_TranGrupo.Visible = False
        '
        'col_Fecha
        '
        Me.col_Fecha.DataPropertyName = "dtFecha"
        Me.col_Fecha.HeaderText = "Fecha"
        Me.col_Fecha.MinimumWidth = 110
        Me.col_Fecha.Name = "col_Fecha"
        Me.col_Fecha.ReadOnly = True
        Me.col_Fecha.Width = 110
        '
        'col_Hora
        '
        Me.col_Hora.DataPropertyName = "vchHora"
        Me.col_Hora.HeaderText = "Hora"
        Me.col_Hora.MinimumWidth = 80
        Me.col_Hora.Name = "col_Hora"
        Me.col_Hora.ReadOnly = True
        Me.col_Hora.Width = 80
        '
        'col_Grupo
        '
        Me.col_Grupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_Grupo.DataPropertyName = "vchGrupo"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle8.Format = "D"
        DataGridViewCellStyle8.NullValue = "Sin fecha"
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.col_Grupo.DefaultCellStyle = DataGridViewCellStyle8
        Me.col_Grupo.FillWeight = 35.73656!
        Me.col_Grupo.HeaderText = "Grupo"
        Me.col_Grupo.MinimumWidth = 100
        Me.col_Grupo.Name = "col_Grupo"
        Me.col_Grupo.ReadOnly = True
        '
        'col_Editar
        '
        Me.col_Editar.HeaderText = "Editar"
        Me.col_Editar.Image = CType(resources.GetObject("col_Editar.Image"), System.Drawing.Image)
        Me.col_Editar.MinimumWidth = 80
        Me.col_Editar.Name = "col_Editar"
        Me.col_Editar.ReadOnly = True
        Me.col_Editar.Width = 80
        '
        'gpoAsistenciaUpdate
        '
        Me.gpoAsistenciaUpdate.Controls.Add(Me.Panel4)
        Me.gpoAsistenciaUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 0.1!)
        Me.gpoAsistenciaUpdate.Location = New System.Drawing.Point(26, 101)
        Me.gpoAsistenciaUpdate.Name = "gpoAsistenciaUpdate"
        Me.gpoAsistenciaUpdate.Size = New System.Drawing.Size(844, 591)
        Me.gpoAsistenciaUpdate.TabIndex = 392
        Me.gpoAsistenciaUpdate.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cmdActualizarAsistencia)
        Me.Panel4.Controls.Add(Me.grdAsistenciaUpdate)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(838, 584)
        Me.Panel4.TabIndex = 0
        '
        'cmdActualizarAsistencia
        '
        Me.cmdActualizarAsistencia.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdActualizarAsistencia.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdActualizarAsistencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdActualizarAsistencia.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdActualizarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.cmdActualizarAsistencia.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdActualizarAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdActualizarAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdActualizarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizarAsistencia.Font = New System.Drawing.Font("Helvetica-Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizarAsistencia.ForeColor = System.Drawing.Color.White
        Me.cmdActualizarAsistencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdActualizarAsistencia.Location = New System.Drawing.Point(351, 520)
        Me.cmdActualizarAsistencia.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdActualizarAsistencia.Name = "cmdActualizarAsistencia"
        Me.cmdActualizarAsistencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdActualizarAsistencia.Size = New System.Drawing.Size(137, 47)
        Me.cmdActualizarAsistencia.TabIndex = 1812
        Me.cmdActualizarAsistencia.Text = "&Actualizar"
        Me.cmdActualizarAsistencia.UseVisualStyleBackColor = False
        '
        'grdAsistenciaUpdate
        '
        Me.grdAsistenciaUpdate.AllowUserToAddRows = False
        Me.grdAsistenciaUpdate.AllowUserToDeleteRows = False
        Me.grdAsistenciaUpdate.AllowUserToOrderColumns = True
        Me.grdAsistenciaUpdate.AllowUserToResizeRows = False
        Me.grdAsistenciaUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAsistenciaUpdate.BackgroundColor = System.Drawing.Color.White
        Me.grdAsistenciaUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdAsistenciaUpdate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdAsistenciaUpdate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAsistenciaUpdate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grdAsistenciaUpdate.ColumnHeadersHeight = 40
        Me.grdAsistenciaUpdate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_RelAsistencias, Me.col_CodAsistencia, Me.col_CodAlumno, Me.col_RelAlumno, Me.col_tiEstatusAsistencia, Me.col_tiEstatusJustificacion, Me.col_RelCodigo, Me.col_RelCarrera, Me.col_Rel_chkAistencia, Me.col_Rel_Asistencia, Me.col_Rel_chk_Justificacion, Me.col_Rel_Justificacion})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdAsistenciaUpdate.DefaultCellStyle = DataGridViewCellStyle15
        Me.grdAsistenciaUpdate.EnableHeadersVisualStyles = False
        Me.grdAsistenciaUpdate.GridColor = System.Drawing.Color.LightGray
        Me.grdAsistenciaUpdate.Location = New System.Drawing.Point(4, 52)
        Me.grdAsistenciaUpdate.MultiSelect = False
        Me.grdAsistenciaUpdate.Name = "grdAsistenciaUpdate"
        Me.grdAsistenciaUpdate.ReadOnly = True
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAsistenciaUpdate.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.grdAsistenciaUpdate.RowHeadersVisible = False
        Me.grdAsistenciaUpdate.RowHeadersWidth = 10
        Me.grdAsistenciaUpdate.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.grdAsistenciaUpdate.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
        Me.grdAsistenciaUpdate.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.grdAsistenciaUpdate.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grdAsistenciaUpdate.RowTemplate.Height = 40
        Me.grdAsistenciaUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdAsistenciaUpdate.Size = New System.Drawing.Size(832, 446)
        Me.grdAsistenciaUpdate.StandardTab = True
        Me.grdAsistenciaUpdate.TabIndex = 4
        '
        'col_RelAsistencias
        '
        Me.col_RelAsistencias.DataPropertyName = "iCodRelAsistencias"
        Me.col_RelAsistencias.HeaderText = "Cod.RelAsistencias"
        Me.col_RelAsistencias.Name = "col_RelAsistencias"
        Me.col_RelAsistencias.ReadOnly = True
        Me.col_RelAsistencias.Visible = False
        '
        'col_CodAsistencia
        '
        Me.col_CodAsistencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_CodAsistencia.DataPropertyName = "iCodAsistencia"
        Me.col_CodAsistencia.HeaderText = "Cod.Asistencia"
        Me.col_CodAsistencia.Name = "col_CodAsistencia"
        Me.col_CodAsistencia.ReadOnly = True
        Me.col_CodAsistencia.Visible = False
        '
        'col_CodAlumno
        '
        Me.col_CodAlumno.DataPropertyName = "iCodAlumno"
        Me.col_CodAlumno.HeaderText = "Cod. Alumno"
        Me.col_CodAlumno.Name = "col_CodAlumno"
        Me.col_CodAlumno.ReadOnly = True
        Me.col_CodAlumno.Visible = False
        '
        'col_RelAlumno
        '
        Me.col_RelAlumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_RelAlumno.DataPropertyName = "vchAlumno"
        Me.col_RelAlumno.HeaderText = "Alumno"
        Me.col_RelAlumno.Name = "col_RelAlumno"
        Me.col_RelAlumno.ReadOnly = True
        '
        'col_tiEstatusAsistencia
        '
        Me.col_tiEstatusAsistencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_tiEstatusAsistencia.DataPropertyName = "tiEstatusAsistencia"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle12.Format = "D"
        DataGridViewCellStyle12.NullValue = "Sin fecha"
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.col_tiEstatusAsistencia.DefaultCellStyle = DataGridViewCellStyle12
        Me.col_tiEstatusAsistencia.FillWeight = 35.73656!
        Me.col_tiEstatusAsistencia.HeaderText = "iEstatusAsistencia"
        Me.col_tiEstatusAsistencia.MinimumWidth = 100
        Me.col_tiEstatusAsistencia.Name = "col_tiEstatusAsistencia"
        Me.col_tiEstatusAsistencia.ReadOnly = True
        Me.col_tiEstatusAsistencia.Visible = False
        Me.col_tiEstatusAsistencia.Width = 150
        '
        'col_tiEstatusJustificacion
        '
        Me.col_tiEstatusJustificacion.DataPropertyName = "tiEstatusJustificacion"
        Me.col_tiEstatusJustificacion.HeaderText = "iEstatusJustificacion"
        Me.col_tiEstatusJustificacion.Name = "col_tiEstatusJustificacion"
        Me.col_tiEstatusJustificacion.ReadOnly = True
        Me.col_tiEstatusJustificacion.Visible = False
        '
        'col_RelCodigo
        '
        Me.col_RelCodigo.DataPropertyName = "vchCodigo"
        Me.col_RelCodigo.HeaderText = "Codigo"
        Me.col_RelCodigo.Name = "col_RelCodigo"
        Me.col_RelCodigo.ReadOnly = True
        Me.col_RelCodigo.Width = 180
        '
        'col_RelCarrera
        '
        Me.col_RelCarrera.DataPropertyName = "vchCarrera"
        Me.col_RelCarrera.HeaderText = "Carrera"
        Me.col_RelCarrera.Name = "col_RelCarrera"
        Me.col_RelCarrera.ReadOnly = True
        '
        'col_Rel_chkAistencia
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.NullValue = False
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.col_Rel_chkAistencia.DefaultCellStyle = DataGridViewCellStyle13
        Me.col_Rel_chkAistencia.HeaderText = " "
        Me.col_Rel_chkAistencia.Name = "col_Rel_chkAistencia"
        Me.col_Rel_chkAistencia.ReadOnly = True
        Me.col_Rel_chkAistencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_Rel_chkAistencia.Visible = False
        Me.col_Rel_chkAistencia.Width = 40
        '
        'col_Rel_Asistencia
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.NullValue = CType(resources.GetObject("DataGridViewCellStyle14.NullValue"), Object)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.col_Rel_Asistencia.DefaultCellStyle = DataGridViewCellStyle14
        Me.col_Rel_Asistencia.HeaderText = "Asistencia"
        Me.col_Rel_Asistencia.Image = CType(resources.GetObject("col_Rel_Asistencia.Image"), System.Drawing.Image)
        Me.col_Rel_Asistencia.MinimumWidth = 80
        Me.col_Rel_Asistencia.Name = "col_Rel_Asistencia"
        Me.col_Rel_Asistencia.ReadOnly = True
        Me.col_Rel_Asistencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_Rel_Asistencia.Width = 80
        '
        'col_Rel_chk_Justificacion
        '
        Me.col_Rel_chk_Justificacion.HeaderText = " "
        Me.col_Rel_chk_Justificacion.Name = "col_Rel_chk_Justificacion"
        Me.col_Rel_chk_Justificacion.ReadOnly = True
        Me.col_Rel_chk_Justificacion.Visible = False
        '
        'col_Rel_Justificacion
        '
        Me.col_Rel_Justificacion.HeaderText = "Justificacion"
        Me.col_Rel_Justificacion.Image = CType(resources.GetObject("col_Rel_Justificacion.Image"), System.Drawing.Image)
        Me.col_Rel_Justificacion.MinimumWidth = 80
        Me.col_Rel_Justificacion.Name = "col_Rel_Justificacion"
        Me.col_Rel_Justificacion.ReadOnly = True
        Me.col_Rel_Justificacion.Width = 80
        '
        'lsvGrupos
        '
        Me.lsvGrupos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvGrupos.BackColor = System.Drawing.Color.White
        Me.lsvGrupos.BackgroundImageTiled = True
        Me.lsvGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvGrupos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colMarca})
        Me.lsvGrupos.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lsvGrupos.FullRowSelect = True
        Me.lsvGrupos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lsvGrupos.Location = New System.Drawing.Point(149, 125)
        Me.lsvGrupos.Name = "lsvGrupos"
        Me.lsvGrupos.Size = New System.Drawing.Size(603, 545)
        Me.lsvGrupos.TabIndex = 389
        Me.lsvGrupos.UseCompatibleStateImageBehavior = False
        '
        'colMarca
        '
        Me.colMarca.Width = 120
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
        'imgAsistencia
        '
        Me.imgAsistencia.ImageStream = CType(resources.GetObject("imgAsistencia.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAsistencia.TransparentColor = System.Drawing.Color.Transparent
        Me.imgAsistencia.Images.SetKeyName(0, "GE_Asistencias_80.png")
        '
        'frmAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(900, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAsistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoListadoAlumnos.ResumeLayout(False)
        Me.gpoListadoAlumnos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.grdAsistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoHistorial.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.grdHistorialAsistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoAsistenciaUpdate.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.grdAsistenciaUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents cmdAltaPacienteLive As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Public WithEvents cmdSalir As System.Windows.Forms.Button
    Public WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents imgAsistencia As System.Windows.Forms.ImageList
    Friend WithEvents lsvGrupos As System.Windows.Forms.ListView
    Friend WithEvents colMarca As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gpoListadoAlumnos As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents grdAsistencias As System.Windows.Forms.DataGridView
    Public WithEvents cmdRemoveAll As System.Windows.Forms.Button
    Public WithEvents cmdAddAll As System.Windows.Forms.Button
    Public WithEvents cmdRegresar As System.Windows.Forms.Button
    Public WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents coliCodAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coliCodGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Paterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Materno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_NombreCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Carrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_chkAsistencia As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents col_Asistencia As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents col_chkJustificacion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents col_Justificacion As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents gpoHistorial As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents grdHistorialAsistencias As System.Windows.Forms.DataGridView
    Public WithEvents cmdNuevaAsistencia As System.Windows.Forms.Button
    Friend WithEvents col_TranAsistencias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_TranGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Grupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Editar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents gpoAsistenciaUpdate As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents cmdActualizarAsistencia As System.Windows.Forms.Button
    Friend WithEvents grdAsistenciaUpdate As System.Windows.Forms.DataGridView
    Friend WithEvents col_RelAsistencias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_CodAsistencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_CodAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_RelAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tiEstatusAsistencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tiEstatusJustificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_RelCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_RelCarrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Rel_chkAistencia As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents col_Rel_Asistencia As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents col_Rel_chk_Justificacion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents col_Rel_Justificacion As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblAsistencia As System.Windows.Forms.Label
    Friend WithEvents lblHistorial As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
