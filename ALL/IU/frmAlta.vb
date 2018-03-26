Option Strict On
Option Explicit On
Imports MySql.Data.MySqlClient
Public Class frmAlta
    Dim daBuscarGrupos As New MySqlDataAdapter
    Dim dtGrupos As New DataTable
    Dim daBuscarAlumnos As New MySqlDataAdapter
    Dim dtAlumnos As New DataTable
    Dim cServ As New cServidor
    Dim f As New fMessageBox
    Private Sub frmAlta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sbCargarTemaForma(True)
        pnlGrupos.BringToFront()
        pnlGrupos.Visible = True
        sbLlenarGrupos()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Dispose()
        sbCargarTemaForma(False)
        frmPrincipal.Show()
    End Sub
    Public Sub sbLlenarGrupos()

        Dim sSql As String
        sSql = "SELECT * FROM softassitence.catgrupos"

        cServ.fnConectar()
        dtGrupos = New DataTable
        dtGrupos.Clear()
        daBuscarGrupos = New MySqlDataAdapter(sSql, cServ.MysqlConn)
        daBuscarGrupos.Fill(dtGrupos)
        grdGrupos.AutoGenerateColumns = False
        grdGrupos.DataSource = dtGrupos
        cServ.sbDesconectar()
    End Sub
    Public Sub sbLlenarAlumnos()

        Dim sSql As String

        sSql = "SELECT * FROM softassitence.catgrupos"
        cServ.fnConectar()
        dtAlumnos = New DataTable
        dtAlumnos.Clear()
        ' cServ.sbConsultar_Grupos()
        daBuscarAlumnos = New MySqlDataAdapter(sSql, cServ.MysqlConn)
        daBuscarAlumnos.Fill(dtAlumnos)
        grdAlumnos.AutoGenerateColumns = False
        grdAlumnos.DataSource = dtAlumnos
        cServ.sbDesconectar()
    End Sub

    Private Sub cmdAddGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddGroup.Click
        sbAltaGrupo()
    End Sub
    Private Sub sbAltaGrupo()
        Try
            With frmAltaGrupos
                .Parent = frmPrincipal.splPanel
                .WindowState = FormWindowState.Normal
                .TopLevel = False
                .Dock = DockStyle.None
                .Location = New Point(275, 0)
                Me.Hide()
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub optAddGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAddGroup.CheckedChanged
        If optAddGroup.Checked = True Then
            sbDesactivarOption()
            optAddGroup.FlatAppearance.BorderSize = 2
            pnlGrupos.Visible = True
            pnlGrupos.BringToFront()
            sbLlenarGrupos()
        End If
    End Sub
    Private Sub optAddAlumns_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optAddAlumns.CheckedChanged
        If optAddAlumns.Checked = True Then
            sbDesactivarOption()
            optAddAlumns.FlatAppearance.BorderSize = 2
            pnlAlumnos.Visible = True
            pnlAlumnos.BringToFront()
            sbLlenarAlumnos()
        End If
    End Sub

    Private Sub sbDesactivarOption()
        optAddGroup.FlatAppearance.BorderSize = 0
        optAddAlumns.FlatAppearance.BorderSize = 0
        optDias.FlatAppearance.BorderSize = 0
        pnlDias.Visible = False
        pnlAlumnos.Visible = False
        pnlGrupos.Visible = False
    End Sub

    Private Sub grdGrupos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGrupos.CellClick
        Dim iIndice, iCol, iCodGrupo As Integer

        Try
            If grdGrupos.CurrentCell IsNot Nothing Then
                iIndice = grdGrupos.CurrentCell.RowIndex
            End If
            If e.RowIndex >= 0 Then
                iCodGrupo = CInt(grdGrupos.Rows(iIndice).Cells("coliCodGrupo").Value)
                iCol = e.ColumnIndex
                If iCol = 12 Then
                    f.sbMensaje("DESEA ELIMINAR EL GRUPO Y SUS ALUMNOS?, SE PERDERÁN TODOS LOS DATOS DE ASISTENCIA", "PREGUNTA", piMessagePregunta, "")
                    f.ShowDialog()
                    If pbMessageRetorno = True Then
                        cServ.fnConectar()
                        cServ.sbEliminar_Grupo(iCodGrupo)
                        cServ.sbDesconectar()
                    End If
                    sbLlenarGrupos()
                ElseIf iCol = 11 Then

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub grdAlumnos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAlumnos.CellClick
        Dim iIndice, iCol, iCodGrupo As Integer
        Dim sGrupo As String
        Try
            If grdAlumnos.CurrentCell IsNot Nothing Then
                iIndice = grdAlumnos.CurrentCell.RowIndex
            End If
            If e.RowIndex >= 0 Then
                iCodGrupo = CInt(grdAlumnos.Rows(iIndice).Cells(0).Value)
                sGrupo = CStr(grdAlumnos.Rows(iIndice).Cells(2).Value)
                iCol = e.ColumnIndex
                If iCol = 12 Then
                    sbMostrarAlumnos(iCodGrupo, True, sGrupo)
                ElseIf iCol = 11 Then
                    sbMostrarAlumnos(iCodGrupo, False, sGrupo)
                Else
                    sbLlenarAlumnos(iCodGrupo)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sbLlenarAlumnos(ByVal iCodGrupoTmp As Integer)
        Try
            Dim sSql As String
            sSql = "SELECT CA.*, concat(CA.vchPaterno, ' ', CA.vchMaterno, ' ', CA.vchNombre) as vchAlumno " & _
            " FROM softassitence.catalumnos CA  " & _
            "WHERE CA.iCodGrupo = '" & iCodGrupoTmp & "'"

            cServ.fnConectar()
            dtAlumnos = New DataTable
            dtAlumnos.Clear()
            ' cServ.sbConsultar_Grupos()
            daBuscarAlumnos = New MySqlDataAdapter(sSql, cServ.MysqlConn)
            daBuscarAlumnos.Fill(dtAlumnos)
            grdAlumnosxGrupo.AutoGenerateColumns = False
            grdAlumnosxGrupo.DataSource = dtAlumnos
            cServ.sbDesconectar()
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub sbMostrarAlumnos(ByVal iCodGrupoTmp As Integer, ByVal bCaptura As Boolean, ByVal sGrupoTmp As String)
        Try
            With frmAlumnosVisor
                .iCodGrupo = iCodGrupoTmp
                .sGrupoTitle = sGrupoTmp
                .bCapturaManual = bCaptura
                .bEdicionAlumno = False
                .Parent = frmPrincipal.splPanel
                .WindowState = FormWindowState.Maximized
                .TopLevel = False
                .Dock = DockStyle.Fill
                Me.Hide()
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDia.Click
        txtDia.Focus()
    End Sub

    Private Sub txtDia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDia.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        ElseIf e.KeyChar = """" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDia.TextChanged
        If txtDia.Text = "" Then
            lblDia.Visible = True
        Else
            lblDia.Visible = False
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        sbDiaInhabil()
    End Sub

    Private Sub sbDiaInhabil()
        Dim iDia, iMes, iAnio As Integer
        Dim sDia As String
        If txtDia.Text <> "" Then
            sDia = Trim(txtDia.Text)
            iDia = dtFechaInhabil.Value.Day
            iMes = dtFechaInhabil.Value.Month
            iAnio = dtFechaInhabil.Value.Year
            cServ.fnConectar()
            cServ.sbInsertarDia_Inhabil(iDia, iMes, iAnio, sDia)
            cServ.sbDesconectar()
            txtDia.Text = ""
        End If
        sbLlenarDias()
    End Sub

    Private Sub sbLlenarDias()
        cServ.fnConectar()
        cServ.sbConsultar_Dias_Inhabiles()
        dtAlumnos = New DataTable
        dtAlumnos.Clear()
        cServ.sbDesconectar()
        cServ.daBuscarGrupos.Fill(dtAlumnos)
        grdDias.AutoGenerateColumns = False
        grdDias.DataSource = Nothing
        grdDias.DataSource = dtAlumnos
        cServ.sbDesconectar()
    End Sub

    Private Sub optDias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDias.CheckedChanged
        If optDias.Checked = True Then
            sbDesactivarOption()
            optDias.FlatAppearance.BorderSize = 2
            pnlDias.Visible = True
            pnlDias.BringToFront()
            sbLlenarDias()
        End If
    End Sub

    Private Sub grdDias_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDias.CellClick
        Dim iIndice, iCol, iCodDia As Integer
        Try
            If grdAlumnos.CurrentCell IsNot Nothing Then
                iIndice = grdAlumnos.CurrentCell.RowIndex
            End If
            If e.RowIndex >= 0 Then
                iCodDia = CInt(grdDias.Rows(iIndice).Cells(0).Value)
                iCol = e.ColumnIndex
                If iCol = 6 Then
                    cServ.fnConectar()
                    cServ.sbEliminar_Dia_Inhabil(iCodDia)
                    cServ.sbDesconectar()
                End If
            End If
            sbLlenarDias()
        Catch ex As Exception

        End Try
    End Sub
End Class
