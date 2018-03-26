'Option Strict On
Option Explicit On

Imports System
Imports System.IO

Imports MySql.Data.MySqlClient

Friend Class frmBuscarPacientes
    Inherits System.Windows.Forms.Form
    Dim cServ As New cServidor
    Dim bAlumno, bGrupo, bCodigo, bTodos As Boolean
    Dim daBuscar As New MySql.Data.MySqlClient.MySqlDataAdapter
    Dim dtAlumno As DataTable = New DataTable("CatAlumnos")
    Dim iCodAlumno, iCodGrupo, iCodCarrera As Integer
    Dim sAlumno, sPaterno, sMaterno, sCodigo, sCarrera, sGrupo As String


    Private Sub sbDesactivarOption()
        bAlumno = False
        bGrupo = False
        bCodigo = False
        optEstudiante.Checked = False
        optCodigo.Checked = False
        optGrupo.Checked = False
        optEstudiante.BackgroundImage = My.Resources.Skins.GE_Option_On
        optCodigo.BackgroundImage = My.Resources.Skins.GE_Option_On
        optGrupo.BackgroundImage = My.Resources.Skins.GE_Option_On

    End Sub

    Private Sub sbLlenarDatos()
        Dim sAlumno, sCodigo, sGrupo As String
        Dim sSql, sBase As String
        ' Dim iCont, iFin As Integer
        Try
            MyBase.Cursor = Cursors.WaitCursor
            dtAlumno.Clear()
            DaRe.DataSource = Nothing
            DaRe.ItemTemplate.ResumeLayout()
            If bAlumno = True Then
                sAlumno = Trim$(txtBuscar.Text)
                cServ.fnConectar()
                sSql = "SELECT CA.*, CG.vchGrupo, concat(CA.vchNombre , ' ' , CA.vchPaterno, ' ', CA.vchMaterno) as vchAlumno " & _
                " FROM softassitence.catalumnos CA INNER JOIN softassitence.catgrupos CG ON CG.iCodGrupo = CA.iCodGrupo " & _
                "WHERE vchNombre LIKE '" & sAlumno & "%'"

            ElseIf bCodigo = True Then
                sCodigo = Trim$(txtBuscar.Text)
                cServ.fnConectar()
                sSql = "SELECT *, CG.vchGrupo, concat(CA.vchNombre , ' ' , CA.vchPaterno, ' ', CA.vchMaterno) as vchAlumno " & _
                " FROM softassitence.catalumnos CA INNER JOIN softassitence.catgrupos CG ON CG.iCodGrupo = CA.iCodGrupo " & _
                " WHERE vchCodigo LIKE '" & sCodigo & "%'"

            ElseIf bGrupo = True Then
                sGrupo = Trim$(txtBuscar.Text)
                cServ.fnConectar()
                sSql = "SELECT *, CG.vchGrupo, concat(CA.vchNombre , ' ' , CA.vchPaterno, ' ', CA.vchMaterno) as vchAlumno " & _
                " FROM softassitence.catalumnos CA INNER JOIN " & _
                " softassitence.catgrupos CG ON CG.iCodGrupo= CA.iCodGrupo " & _
                " WHERE vchGrupo LIKE '" & sGrupo & "%'"
            ElseIf bTodos = True Then
                cServ.fnConectar()
                sSql = "SELECT *, CG.vchGrupo, concat(CA.vchNombre , ' ' , CA.vchPaterno, ' ', CA.vchMaterno) as vchAlumno " & _
               " FROM softassitence.catalumnos CA INNER JOIN " & _
               " softassitence.catgrupos CG ON CG.iCodGrupo = CA.iCodGrupo "
            End If

            dtAlumno = New DataTable
            daBuscar = New MySqlDataAdapter(sSql, cServ.MysqlConn)
            daBuscar.Fill(dtAlumno)
            sbLimpiarDare()
            sbEstablecerDareObjetos()
            DaRe.DataSource = dtAlumno
            lblTotal.Text = CStr(DaRe.ItemCount)
            lblTotal.Visible = True
            cServ.sbDesconectar()
            MyBase.Cursor = Cursors.Arrow
            'Dim bNulo As Boolean
            'Dim row As DataRow = dtAlumno.Rows(dtAlumno.Rows.Count - 1)
            'iFin = dtAlumno.Rows.Count
            'For iCont = 0 To iFin - 1
            '    bNulo = IsDBNull(dtAlumno.Rows(iCont).Item("imgAlumno"))
            '    If bNulo = False Then
            '        sBase = CStr(row("imgAlumno"))
            '        Dim Byte64() As Byte = Convert.FromBase64String(sBase)
            '        Dim ms As New MemoryStream(Byte64)
            '        dtAlumno.Rows(iCont).Item("imgAlumno") = Byte64
            '        ' Dim bImagen As New Bitmap(ms)
            '        ' picPaciente.Image = Image.FromStream(ms)

            '    End If
            'Next
            ' picPaciente.Visible

        Catch ex As Exception

        End Try

    End Sub
    Private Sub sbEstablecerDareObjetos()
        Try
            lblCodAlumno.DataBindings.Add("Text", dtAlumno, "iCodAlumno")
            lblCodGrupo.DataBindings.Add("Text", dtAlumno, "iCodGrupo")
            lblGrupo.DataBindings.Add("Text", dtAlumno, "vchGrupo")
            ' picPaciente.DataBindings.Add("Image", dtAlumno, "imgAlumno")
            'picPaciente.BackgroundImageLayout = ImageLayout.Stretch
            lblNombre.DataBindings.Add("Text", dtAlumno, "vchNombre")
            lblPaterno.DataBindings.Add("Text", dtAlumno, "vchPaterno")
            lblMaterno.DataBindings.Add("Text", dtAlumno, "vchMaterno")
            lblNombreCompleto.DataBindings.Add("Text", dtAlumno, "vchAlumno")
            lblCarrera.DataBindings.Add("Text", dtAlumno, "vchCarrera")
            lblCodigo.DataBindings.Add("Text", dtAlumno, "vchCodigo")
            lblCodCarrera.DataBindings.Add("Text", dtAlumno, "iCodCarrera")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub sbLimpiarDare()
        Try
            DaRe.DataBindings.Clear()
            DaRe.DataSource = Nothing
            lblCodAlumno.DataBindings.Clear()
            lblCodGrupo.DataBindings.Clear()
            lblCodGrupo.DataBindings.Clear()
            lblGrupo.DataBindings.Clear()
            lblNombre.DataBindings.Clear()
            lblPaterno.DataBindings.Clear()
            lblMaterno.DataBindings.Clear()
            picPaciente.DataBindings.Clear()
            lblNombreCompleto.DataBindings.Clear()
            lblCodigo.DataBindings.Clear()
            lblCarrera.DataBindings.Clear()
            lblCodCarrera.DataBindings.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmBuscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bAlumno = True
        'optCodigo = New System.Windows.Forms.RadioButton
        txtBuscar.Focus()
    End Sub


    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text.Length > 1 Then
            sbLlenarDatos()
        Else
            sbLimpiarDare()

        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Try
            Me.Hide()
            'DaRe.Dispose()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub optGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGrupo.CheckedChanged
        If optGrupo.Checked = True Then
            bGrupo = True
            sbLimpiarDare()
            txtBuscar.Text = ""
            txtBuscar.Focus()
            optGrupo.BackgroundImage = My.Resources.Skins.GE_Option_On
            optEstudiante.BackgroundImage = My.Resources.Skins.GE_Option_Off
            optCodigo.BackgroundImage = My.Resources.Skins.GE_Option_Off
        Else
            bGrupo = False
            optGrupo.BackgroundImage = My.Resources.Skins.GE_Option_Off
        End If
    End Sub

    Private Sub optEstudiante_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optEstudiante.CheckedChanged
        If optEstudiante.Checked = True Then
            bAlumno = True
            sbLimpiarDare()
            txtBuscar.Text = ""
            txtBuscar.Focus()
            optEstudiante.BackgroundImage = My.Resources.Skins.GE_Option_On
            optCodigo.BackgroundImage = My.Resources.Skins.GE_Option_Off
            optGrupo.BackgroundImage = My.Resources.Skins.GE_Option_Off
        Else
            bAlumno = False
            optEstudiante.BackgroundImage = My.Resources.Skins.GE_Option_Off
        End If
    End Sub

    Private Sub optCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCodigo.CheckedChanged
        If optCodigo.Checked = True Then
            bCodigo = True
            sbLimpiarDare()
            txtBuscar.Text = ""
            txtBuscar.Focus()
            optCodigo.BackgroundImage = My.Resources.Skins.GE_Option_On
            optEstudiante.BackgroundImage = My.Resources.Skins.GE_Option_Off
            optGrupo.BackgroundImage = My.Resources.Skins.GE_Option_Off
        Else
            bCodigo = False
            optCodigo.BackgroundImage = My.Resources.Skins.GE_Option_Off
        End If

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        sbCargarEdicion()
    End Sub

    Private Sub sbCargarEdicion()
        Try
            With DaRe
                iCodAlumno = CInt(.CurrentItem.Controls("lblCodAlumno").Text)
                iCodGrupo = CInt(.CurrentItem.Controls("lblCodGrupo").Text)
                sGrupo = .CurrentItem.Controls("lblGrupo").Text
                sAlumno = .CurrentItem.Controls("lblNombre").Text
                sPaterno = .CurrentItem.Controls("lblPaterno").Text
                sMaterno = .CurrentItem.Controls("lblMaterno").Text
                sCodigo = .CurrentItem.Controls("lblCodigo").Text
                sCarrera = .CurrentItem.Controls("lblCarrera").Text
                'iCodCarrera = .CurrentItem.Controls("lblCodCarrera").Text

            End With
            With frmAlumnosVisor
                .TopLevel = False
                .Parent = frmPrincipal.splPanel
                .Dock = DockStyle.Fill
                .lblCodAlumno.Text = CStr(iCodAlumno)
                .lblCodGrupo.Text = CStr(iCodGrupo)
                .lblCodCarrera.Text = CStr(iCodCarrera)
                .cboGrupo.Text = CStr(sGrupo)
                .txtNombre.Text = CStr(sAlumno)
                .txtPaterno.Text = CStr(sPaterno)
                .txtMaterno.Text = CStr(sMaterno)
                .txtCodigo.Text = CStr(sCodigo)
                .txtCarrera.Text = CStr(sCarrera)
                .bEdicionAlumno = True
            End With
            Me.Hide()
            frmAlumnosVisor.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DaRe_ItemTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaRe.ItemTemplate.Click
        Try
            Dim iCont As Integer
            iCont = DaRe.ItemCount
            If iCont > 0 Then
                cmdModificar.Enabled = True
                cmdEliminar.Enabled = True
                iCodAlumno = CInt(DaRe.CurrentItem.Controls("lblCodAlumno").Text)
                sCodigo = CStr(DaRe.CurrentItem.Controls("lblCodigo").Text)
                DaRe.CurrentItem.BackColor = Color.WhiteSmoke
            Else
                cmdModificar.Enabled = False
                cmdEliminar.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        bAlumno = False
        bCodigo = False
        bGrupo = False
        bTodos = True
        sbLlenarDatos()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If iCodAlumno <> 0 Then
            fMessageBox.sbMensaje("DESEA ELIMINAR EL ALUMNO?, SE PERDERÁN TODOS LOS DATOS DE ASISTENCIA", "PREGUNTA", piMessagePregunta, "")
            fMessageBox.ShowDialog()
            If pbMessageRetorno = True Then
                cServ.fnConectar()
                cServ.sbEliminar_Alumno(iCodAlumno)
                cServ.sbDesconectar()
                cServ.fnConectar()
                cServ.sbEliminar_AlumnoXCodigo(sCodigo)
                cServ.sbDesconectar()
                bAlumno = False
                bCodigo = False
                bGrupo = False
                bTodos = True
                sbLlenarDatos()
                txtBuscar.Text = ""
            End If
        End If
      
    End Sub
End Class