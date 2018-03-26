<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonas))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.cmdAltaPacienteLive = New DevComponents.DotNetBar.BubbleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label106 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdEmpleado = New System.Windows.Forms.Button
        Me.cmdProveedor = New System.Windows.Forms.Button
        Me.cmdCliente = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewImageColumn1.HeaderText = " "
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Visible = False
        Me.DataGridViewImageColumn1.Width = 40
        '
        'DataGridViewImageColumn2
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = CType(resources.GetObject("DataGridViewCellStyle4.NullValue"), Object)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle4
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
        Me.Panel2.Controls.Add(Me.cmdEmpleado)
        Me.Panel2.Controls.Add(Me.cmdProveedor)
        Me.Panel2.Controls.Add(Me.cmdCliente)
        Me.Panel2.Controls.Add(Me.Label106)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cmdSalir)
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
        'cmdEmpleado
        '
        Me.cmdEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdEmpleado.BackColor = System.Drawing.Color.White
        Me.cmdEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdEmpleado.FlatAppearance.BorderSize = 0
        Me.cmdEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEmpleado.Font = New System.Drawing.Font("Helvetica-Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmpleado.ForeColor = System.Drawing.Color.DimGray
        Me.cmdEmpleado.Image = CType(resources.GetObject("cmdEmpleado.Image"), System.Drawing.Image)
        Me.cmdEmpleado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEmpleado.Location = New System.Drawing.Point(201, 266)
        Me.cmdEmpleado.Name = "cmdEmpleado"
        Me.cmdEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEmpleado.Size = New System.Drawing.Size(132, 87)
        Me.cmdEmpleado.TabIndex = 1802
        Me.cmdEmpleado.Text = "Empleados"
        Me.cmdEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEmpleado.UseVisualStyleBackColor = False
        '
        'cmdProveedor
        '
        Me.cmdProveedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdProveedor.BackColor = System.Drawing.Color.White
        Me.cmdProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdProveedor.FlatAppearance.BorderSize = 0
        Me.cmdProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProveedor.Font = New System.Drawing.Font("Helvetica-Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProveedor.ForeColor = System.Drawing.Color.DimGray
        Me.cmdProveedor.Image = CType(resources.GetObject("cmdProveedor.Image"), System.Drawing.Image)
        Me.cmdProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdProveedor.Location = New System.Drawing.Point(351, 114)
        Me.cmdProveedor.Name = "cmdProveedor"
        Me.cmdProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdProveedor.Size = New System.Drawing.Size(132, 87)
        Me.cmdProveedor.TabIndex = 1801
        Me.cmdProveedor.Text = "Provedores"
        Me.cmdProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdProveedor.UseVisualStyleBackColor = False
        '
        'cmdCliente
        '
        Me.cmdCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCliente.BackColor = System.Drawing.Color.White
        Me.cmdCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCliente.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdCliente.FlatAppearance.BorderSize = 0
        Me.cmdCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCliente.Font = New System.Drawing.Font("Helvetica-Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCliente.ForeColor = System.Drawing.Color.DimGray
        Me.cmdCliente.Image = CType(resources.GetObject("cmdCliente.Image"), System.Drawing.Image)
        Me.cmdCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCliente.Location = New System.Drawing.Point(201, 114)
        Me.cmdCliente.Name = "cmdCliente"
        Me.cmdCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCliente.Size = New System.Drawing.Size(132, 87)
        Me.cmdCliente.TabIndex = 1800
        Me.cmdCliente.Text = "Clientes"
        Me.cmdCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCliente.UseVisualStyleBackColor = False
        '
        'frmPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(715, 514)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPersonas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
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
    Public WithEvents cmdEmpleado As System.Windows.Forms.Button
    Public WithEvents cmdProveedor As System.Windows.Forms.Button
    Public WithEvents cmdCliente As System.Windows.Forms.Button

End Class
