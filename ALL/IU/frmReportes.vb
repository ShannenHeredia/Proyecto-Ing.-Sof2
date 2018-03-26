Option Strict On
Option Explicit On
Imports MySql.Data.MySqlClient
Public Class frmReportes

    'Dim daBuscarGrupos As New MySqlDataAdapter
    ' Dim dtGrupos As New DataTable
    'Dim daBuscarAlumnos As New MySqlDataAdapter
    Dim dtAlumnos As New DataTable
    Dim dtAlumnos2 As New DataTable
    Dim cServ As New cServidor
    Const iASISTENCIA As Integer = 0
    Const iFALTA As Integer = 1

    Private Sub frmAlta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sbCargarTemaForma(True)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Dispose()
        sbCargarTemaForma(False)
        frmPrincipal.Show()
    End Sub

    Private Sub cmdAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlumnos.Click
        sbLlenarAlumnos()
        sbOcultarObjetos()
        PageSliderReportes.SelectedPageIndex = 1
        grdAlumnos.Visible = True
    End Sub

    Private Sub sbLlenarAlumnos()
        cServ.fnConectar()
        cServ.sbConsultar_Alumnos_Todos()
        dtAlumnos = New DataTable
        dtAlumnos.Clear()
        cServ.sbDesconectar()
        cServ.daBuscarGrupos.Fill(dtAlumnos)
        grdAlumnos.AutoGenerateColumns = False
        grdAlumnos.DataSource = dtAlumnos
        cServ.sbDesconectar()
    End Sub

    Private Sub grdAlumnos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAlumnos.CellClick
        Dim iIndice, iCol As Integer
        Dim vchCodigoTmp, vchCarreraTmp, vchNombreTmp As String
     

        Try
            If grdAlumnos.CurrentCell IsNot Nothing Then
                iIndice = grdAlumnos.CurrentCell.RowIndex
            End If
            If e.RowIndex >= 0 Then
                vchNombreTmp = CStr(grdAlumnos.Rows(iIndice).Cells("col_NombreAlumno").Value)
                vchCodigoTmp = CStr(grdAlumnos.Rows(iIndice).Cells("col_CodigoAlumno").Value)
                vchCarreraTmp = CStr(grdAlumnos.Rows(iIndice).Cells("col_Carrera").Value)
                iCol = e.ColumnIndex
                If iCol = 5 Then
                    sbCargarReporteAlumno(vchNombreTmp, vchCodigoTmp, vchCarreraTmp)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub sbCargarReporteAlumno(ByVal vchNombreTmp As String, ByVal vchCodigoTmp As String, ByVal vchCarreraTmp As String)
        Dim rptAlumnos As New rptAlumnos

        Try
            cServ.fnConectar()
            cServ.sbConsultar_Asistencia_Alumno_Reporte(vchCodigoTmp, iASISTENCIA)
            dtAlumnos = New DataTable
            dtAlumnos.Clear()
            cServ.sbDesconectar()
            cServ.daBuscarGrupos.Fill(dtAlumnos)
            rptAlumnos.DataSource = dtAlumnos

            'cServ.fnConectar()
            'cServ.sbConsultar_Asistencia_Alumno_Reporte(vchCodigoTmp, iFALTA)
            'dtAlumnos2 = New DataTable
            'dtAlumnos2.Clear()
            'cServ.sbDesconectar()
            'cServ.daBuscarGrupos2.Fill(dtAlumnos2)
            'rptAlumnos.DataSource = dtAlumnos2
            ' rptAlumnos.DataAdapter = cServ.daBuscarGrupos
            ' rptAlumnos.lblFecha.DataBindings.Add("Text", dtAlumnos, "vchNombreAfi")
            rptAlumnos.lblGrupo.DataBindings.Add("Text", dtAlumnos, "vchGrupo")
            rptAlumnos.lblAsistencias.DataBindings.Add("Text", dtAlumnos, "iAsistencias")
            rptAlumnos.lblJustificadas.DataBindings.Add("Text", dtAlumnos, "iJustificacion")
            rptAlumnos.lblFaltas.DataBindings.Add("Text", dtAlumnos, "iFaltas")
            rptAlumnos.lblObtenidas.DataBindings.Add("Text", dtAlumnos, "iObtenidas")
            rptAlumnos.lblAsist_Totales.DataBindings.Add("Text", dtAlumnos, "iTotal")
            rptAlumnos.lblPorcentaje.DataBindings.Add("Text", dtAlumnos, "iPorcentaje")
            rptAlumnos.lblAlumno.Text = vchNombreTmp
            rptAlumnos.lblCodigo.Text = vchCodigoTmp
            rptAlumnos.lblCarrera.Text = vchCarreraTmp
            rptAlumnos.ShowPreviewDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.Click
        PageSliderReportes.SelectedPageIndex = 0
    End Sub

    Private Sub grdGrupos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGrupos.CellClick
        Dim iIndice, iCol, iCodGrupo As Integer
        Dim sNRC, sSeccion, sGrupo As String
        Try
            If grdGrupos.CurrentCell IsNot Nothing Then
                iIndice = grdGrupos.CurrentCell.RowIndex
            End If
            If e.RowIndex >= 0 Then
                iCodGrupo = CInt(grdGrupos.Rows(iIndice).Cells("coliCodGrupo").Value)
                sGrupo = CStr(grdGrupos.Rows(iIndice).Cells("colGrupo").Value)
                sNRC = CStr(grdGrupos.Rows(iIndice).Cells("colCurso").Value)
                sSeccion = CStr(grdGrupos.Rows(iIndice).Cells("colSeccion").Value)
                iCol = e.ColumnIndex
                If iCol = 11 Then
                    sbCargarReporteGrupo(iCodGrupo, sGrupo, sNRC, sSeccion)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sbCargarReporteGrupo(ByVal iCodGrupoTmp As Integer, ByVal vchGrupoTmp As String, ByVal vchNRCTmp As String, ByVal vchSeccion As String)
        
        Dim rptGrupos As New rptGrupos

        Try
            cServ.fnConectar()
            cServ.sbConsultar_Asistencia_Grupo_Reporte(iCodGrupoTmp, iASISTENCIA)
            dtAlumnos = New DataTable
            dtAlumnos.Clear()
            cServ.sbDesconectar()
            cServ.daBuscarGrupos.Fill(dtAlumnos)
            rptGrupos.DataSource = dtAlumnos

            'cServ.fnConectar()
            'cServ.sbConsultar_Asistencia_Grupo_Reporte(iCodGrupoTmp, iFALTA)
            'dtAlumnos2 = New DataTable
            'dtAlumnos2.Clear()
            'cServ.sbDesconectar()
            'cServ.daBuscarGrupos2.Fill(dtAlumnos2)
            'rptGrupos.DataSource = dtAlumnos2
            ' rptGrupos.DataAdapter = cServ.daBuscarGrupos
            ' rptGrupos.lblFecha.DataBindings.Add("Text", dtAlumnos, "vchNombreAfi")
            rptGrupos.lblAlumno.DataBindings.Add("Text", dtAlumnos, "vchAlumno")
            rptGrupos.lblAsistencias.DataBindings.Add("Text", dtAlumnos, "iAsistencias")
            rptGrupos.lblJustificadas.DataBindings.Add("Text", dtAlumnos, "iJustificacion")
            rptGrupos.lblFaltas.DataBindings.Add("Text", dtAlumnos, "iFaltas")
            rptGrupos.lblObtenidas.DataBindings.Add("Text", dtAlumnos, "iObtenidas")
            rptGrupos.lblAsist_Totales.DataBindings.Add("Text", dtAlumnos, "iTotal")
            rptGrupos.lblPorcentaje.DataBindings.Add("Text", dtAlumnos, "iPorcentaje")
            rptGrupos.lblGrupo.Text = vchGrupoTmp
            rptGrupos.lblNRC.Text = vchNRCTmp
            rptGrupos.lblSeccion.Text = vchSeccion
            rptGrupos.ShowPreviewDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrupo.Click
        sbLlenarGrupos()
        sbOcultarObjetos()
        PageSliderReportes.SelectedPageIndex = 1
        grdGrupos.Visible = True
    End Sub

    Private Sub sbLlenarGrupos()
        cServ.fnConectar()
        cServ.sbConsultar_Grupos_Reportes()
        dtAlumnos = New DataTable
        dtAlumnos.Clear()
        cServ.sbDesconectar()
        cServ.daBuscarGrupos.Fill(dtAlumnos)
        grdGrupos.AutoGenerateColumns = False
        grdGrupos.DataSource = dtAlumnos
        cServ.sbDesconectar()
    End Sub

    Private Sub cmdDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDia.Click
        sbCargarReportexDia()
    End Sub


    Private Sub sbCargarReportexDia()

        Dim rDiario As New rptDiario
        Dim sFecha As String
        Try
            cServ.fnConectar()
            sFecha = Today.Date.ToString("yyyy-MM-dd")
            cServ.sbConsultar_Asistencia_Dia(sFecha)
            dtAlumnos = New DataTable
            dtAlumnos.Clear()
            cServ.sbDesconectar()
            cServ.daBuscarGrupos.Fill(dtAlumnos)
            rDiario.DataSource = dtAlumnos

           
            rDiario.lblGrupo.DataBindings.Add("Text", dtAlumnos, "vchGrupo")
            rDiario.lblFecha.Text = CStr(FormatDateTime(Today.Date, DateFormat.ShortDate))
            rDiario.lblAlumno.DataBindings.Add("Text", dtAlumnos, "vchAlumno")
            rDiario.lblAsistencias.DataBindings.Add("Text", dtAlumnos, "iAsistencias")
            rDiario.lblJustificadas.DataBindings.Add("Text", dtAlumnos, "iJustificacion")
            rDiario.lblFaltas.DataBindings.Add("Text", dtAlumnos, "iFaltas")
            rDiario.lblObtenidas.DataBindings.Add("Text", dtAlumnos, "iObtenidas")
            rDiario.lblAsist_Totales.DataBindings.Add("Text", dtAlumnos, "iTotal")
            rDiario.lblPorcentaje.DataBindings.Add("Text", dtAlumnos, "iPorcentaje")
            rDiario.ShowPreviewDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdSemestral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSemestral.Click
        dtFechaIni.Value = Today.Date
        dtFechaFin.Value = Today.Date.AddDays(+1)
        sbOcultarObjetos()
        PageSliderReportes.SelectedPageIndex = 1
        dtFechaIni.Visible = True
        dtFechaFin.Visible = True
        cmdVerReporte.Visible = True
    End Sub

    Private Sub sbOcultarObjetos()
        grdAlumnos.Visible = False
        grdGrupos.Visible = False
        dtFechaIni.Visible = False
        dtFechaFin.Visible = False
        cmdVerReporte.Visible = False
    End Sub

    Private Sub sbCargarReportexSemestre()

        Dim rSemestral As New rptSemestral
        Dim sFechaIni, sFechaFin As String
        Try
            cServ.fnConectar()
            sFechaIni = dtFechaIni.Value.ToString("yyyy-MM-dd")
            sFechaFin = dtFechaFin.Value.ToString("yyyy-MM-dd")
            cServ.sbConsultar_Asistencia_Semestral(sFechaIni, sFechaFin)
            dtAlumnos = New DataTable
            dtAlumnos.Clear()
            cServ.sbDesconectar()
            cServ.daBuscarGrupos.Fill(dtAlumnos)
            rSemestral.DataSource = dtAlumnos


            ' rSemestral.DataAdapter = cServ.daBuscarGrupos
            rSemestral.lblFechaIni.Text = CStr(FormatDateTime(CDate(sFechaIni), DateFormat.ShortDate))
            rSemestral.lblFechaFin.Text = CStr(FormatDateTime(CDate(sFechaFin), DateFormat.ShortDate))
            rSemestral.lblAlumno.DataBindings.Add("Text", dtAlumnos, "vchAlumno")
            rSemestral.lblGrupo.DataBindings.Add("Text", dtAlumnos, "vchGrupo")
            rSemestral.lblAsistencias.DataBindings.Add("Text", dtAlumnos, "iAsistencias")
            rSemestral.lblJustificadas.DataBindings.Add("Text", dtAlumnos, "iJustificacion")
            rSemestral.lblFaltas.DataBindings.Add("Text", dtAlumnos, "iFaltas")
            rSemestral.lblObtenidas.DataBindings.Add("Text", dtAlumnos, "iObtenidas")
            rSemestral.lblAsist_Totales.DataBindings.Add("Text", dtAlumnos, "iTotal")
            rSemestral.lblPorcentaje.DataBindings.Add("Text", dtAlumnos, "iPorcentaje")
            rSemestral.ShowPreviewDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdVerReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerReporte.Click
        sbCargarReportexSemestre()
    End Sub
End Class
