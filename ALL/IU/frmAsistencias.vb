'Option Strict On
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Imports MySql.Data.MySqlClient
Public Class frmAsistencias
    Dim cServ As New cServidor
    Dim dtGrupos As New DataTable
    Dim sGrupo, sCodigo As String
    Dim iCodGrupo As Integer
    Dim iCodAlumno As Integer
    Dim iCodAsistencia, iCodRelAsistencia, iEstatusAsistencia, iEstatusJustificacion, iEstatusFalta As Integer
    Dim bHISTORIAL, bEDICION_ASISTENCIA, bASISTENCIA As Boolean

    Private Sub sbCargarGrupos()
      
        Dim bNUlo As Boolean
        Dim _imgList As New ImageList
        Dim imgSize As New Size
        Dim count As Integer = 0
        Try
            lsvGrupos.Items.Clear()
            _imgList.ColorDepth = ColorDepth.Depth32Bit
            imgSize.Width = 90
            imgSize.Height = 80
            lsvGrupos.LargeImageList = _imgList
            cServ.fnConectar()
            cServ.sbConsultar_Grupos()

            While cServ.myReader.Read = True
                bNUlo = cServ.myReader.IsDBNull(0)
                If bNUlo = True Then
                    Exit Sub
                Else
                    iCodGrupo = CInt(cServ.myReader("iCodGrupo"))
                    sGrupo = CStr(cServ.myReader("vchGrupo"))
                    Dim img As New System.Drawing.Bitmap(My.Resources.Skins.GE_Asistencias_80)
                    _imgList.ImageSize = imgSize
                    _imgList.Images.Add(img.Clone)
                    lsvGrupos.Items.Add(sGrupo, count)
                    count += 1
                End If

            End While
            cServ.sbDesconectar()
        Catch ex As Exception

        End Try
     
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        sbCargarTemaForma(False)
        Me.Dispose()
    End Sub

    Private Sub frmAsistencias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sbOcultarPaneles()
        lsvGrupos.Visible = True
        lsvGrupos.BringToFront()
        sbCargarTemaForma(True)
        sbCargarGrupos()
    End Sub

   
    Private Sub sbCargarNuevaAsistencia()
        Try
            Dim bNulo As Boolean
            dtGrupos.Clear()
            cServ.fnConectar()
            cServ.sbConsultar_Alumnos_X_Grupo(iCodGrupo)
            If cServ.myReader.Read = True Then
                bNulo = cServ.myReader.IsDBNull(0)
                If bNulo = False Then
                    dtGrupos = New DataTable
                    cServ.sbDesconectar()
                    cServ.daBuscarGrupos.Fill(dtGrupos)
                    grdAsistencias.AutoGenerateColumns = False
                    grdAsistencias.DataSource = dtGrupos
                    cmdAddAll.Visible = True
                    cmdRemoveAll.Visible = True
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub sbCargarHistorial(ByVal sGrupoTmp As String)
        Try
            Dim bNulo As Boolean
            dtGrupos.Clear()
            cServ.fnConectar()
            cServ.sbConsultar_Grupo_X_Nombre(sGrupoTmp)
            If cServ.myReader.Read = True Then
                bNulo = cServ.myReader.IsDBNull(0)
                If bNulo = True Then
                    Exit Sub
                Else
                    iCodGrupo = CInt(cServ.myReader("iCodGrupo"))
                    cServ.sbDesconectar()
                    cServ.fnConectar()
                    cServ.sbConsultar_Historial_Asistencias(iCodGrupo)
                    If cServ.myReader.Read = True Then
                        bNulo = cServ.myReader.IsDBNull(0)
                        If bNulo = False Then
                            dtGrupos = New DataTable
                            cServ.sbDesconectar()
                            cServ.daBuscarGrupos.Fill(dtGrupos)
                            grdHistorialAsistencias.AutoGenerateColumns = False
                            grdHistorialAsistencias.DataSource = dtGrupos
                        End If
                    End If
                End If
            End If
            cmdRegresar.Visible = True
        Catch ex As Exception

        End Try


    End Sub

    Private Sub grdAsistencias_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAsistencias.CellClick
        Dim iIndice, iFin As Integer
        Dim iCol As Integer
        Try

            If grdAsistencias.CurrentCell IsNot Nothing Then
                iIndice = grdAsistencias.CurrentCell.RowIndex
            Else
                Exit Sub
            End If
            iFin = grdAsistencias.RowCount
            If e.RowIndex >= 0 Then
                iCol = e.ColumnIndex
                If iCol = 9 Then
                    If grdAsistencias.Rows(iIndice).Cells("col_chkAsistencia").Value = True Then
                        'Asistencia
                        grdAsistencias.Rows(iIndice).Cells("col_Asistencia").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35
                        grdAsistencias.Rows(iIndice).Cells("col_chkAsistencia").Value = False
                    ElseIf grdAsistencias.Rows(iIndice).Cells("col_chkAsistencia").Value = False Then
                        'Asistencia
                        grdAsistencias.Rows(iIndice).Cells("col_chkAsistencia").Value = True
                        grdAsistencias.Rows(iIndice).Cells("col_Asistencia").Value = My.Resources.Skins.GE_Checked_On_Flat_35x35
                        'Justificacion
                        grdAsistencias.Rows(iIndice).Cells("col_Justificacion").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35
                        grdAsistencias.Rows(iIndice).Cells("col_chkJustificacion").Value = False
                    End If
                ElseIf iCol = 11 Then
                    If grdAsistencias.Rows(iIndice).Cells("col_chkJustificacion").Value = True Then
                        'Justificacion
                        grdAsistencias.Rows(iIndice).Cells("col_Justificacion").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35
                        grdAsistencias.Rows(iIndice).Cells("col_chkJustificacion").Value = False


                    ElseIf grdAsistencias.Rows(iIndice).Cells("col_chkJustificacion").Value = False Then
                        'Justificacion
                        grdAsistencias.Rows(iIndice).Cells("col_Justificacion").Value = My.Resources.Skins.GE_Checked_On_Flat_35x35
                        grdAsistencias.Rows(iIndice).Cells("col_chkJustificacion").Value = True

                        'Asistencia
                        grdAsistencias.Rows(iIndice).Cells("col_chkAsistencia").Value = False
                        grdAsistencias.Rows(iIndice).Cells("col_Asistencia").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35

                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegresar.Click
        If gpoHistorial.Visible = True = True Then
            sbCargarGrupos()
            sbOcultarPaneles()
            lsvGrupos.Visible = True
            sbCargarGrupos()
            cmdRegresar.Visible = False
        ElseIf gpoListadoAlumnos.Visible = True Then
            sbCargarHistorial(sGrupo)
            sbOcultarPaneles()
            gpoHistorial.Visible = True
        ElseIf gpoAsistenciaUpdate.Visible = True Then
            sbCargarHistorial(sGrupo)
            sbOcultarPaneles()
            gpoHistorial.Visible = True
        End If
       
    End Sub
    Private Sub sbAsistenciaGeneral()
        Dim iCont, iFin As Integer
        iFin = CInt(grdAsistencias.RowCount)
        For iCont = 0 To iFin - 1
            grdAsistencias.Rows(iCont).Cells("col_chkAsistencia").Value = True
            grdAsistencias.Rows(iCont).Cells("col_Asistencia").Value = My.Resources.Skins.GE_Checked_On_Flat_35x35
        Next
    End Sub

    Private Sub sbDeshacerAsistencia()
        Dim iCont, iFin As Integer
        iFin = CInt(grdAsistencias.RowCount)
        For iCont = 0 To iFin - 1
            grdAsistencias.Rows(iCont).Cells("col_chkAsistencia").Value = False
            grdAsistencias.Rows(iCont).Cells("col_Asistencia").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35
            grdAsistencias.Rows(iCont).Cells("col_chkJustificacion").Value = False
            grdAsistencias.Rows(iCont).Cells("col_Justificacion").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35
        Next
    End Sub

    Private Sub cmdAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddAll.Click
        sbAsistenciaGeneral()
    End Sub

    Private Sub cmdRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveAll.Click
        sbDeshacerAsistencia()
    End Sub

    Private Sub lsvGrupos_ItemSelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lsvGrupos.ItemSelectionChanged
        sGrupo = e.Item.Text
        sbOcultarPaneles()
        gpoHistorial.Visible = True
        cmdRegresar.Visible = True
        bHISTORIAL = True
        sbCargarHistorial(sGrupo)
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        sbGuardarAsistencia()
        sbOcultarPaneles()
        gpoHistorial.Visible = True
        sbCargarHistorial(sGrupo)
    End Sub

    Private Function fnObtenerUltimoHistorialAsistencia() As Integer
        Dim bNulo As Boolean
        cServ.fnConectar()
        cServ.sbConsultar_iCodUltimoHistorialAsistencia()
        If cServ.myReader.Read = True Then
            bNulo = cServ.myReader.IsDBNull(0)
            If bNulo = True Then
                fnObtenerUltimoHistorialAsistencia = 0
            Else
                fnObtenerUltimoHistorialAsistencia = CInt(cServ.myReader("iCodAsistencias"))
            End If
        End If
        cServ.sbDesconectar()
    End Function

    Private Function fnObtenerUltimaRelAsistencia() As Integer
        Dim bNulo As Boolean
        cServ.fnConectar()
        cServ.sbConsultar_iCodUltimoRelAsistencia()
        If cServ.myReader.Read = True Then
            bNulo = cServ.myReader.IsDBNull(0)
            If bNulo = True Then
                fnObtenerUltimaRelAsistencia = 0
            Else
                fnObtenerUltimaRelAsistencia = CInt(cServ.myReader("iCodRelAsistencias"))
            End If
        End If
        cServ.sbDesconectar()
    End Function

    Private Sub sbGuardarAsistencia()
        Dim iCont, iFin As Integer
        Dim bJustificaciones As Boolean


        Dim dtFechaAsistencia As Date = Now.ToString("yyyy/MM/dd")
        Dim sHora As String = Date.Now.Hour & ":" & Date.Now.Minute
        iCodAsistencia = fnObtenerUltimoHistorialAsistencia()
        iCodAsistencia = iCodAsistencia + 1
        cServ.fnConectar()
        cServ.sbInsertarAsistencia(iCodAsistencia, iCodGrupo, dtFechaAsistencia, sHora)
        iFin = grdAsistencias.Rows.Count
        iCodRelAsistencia = fnObtenerUltimaRelAsistencia()
        For iCont = 0 To iFin - 1
            iCodRelAsistencia = iCodRelAsistencia + 1
            iCodGrupo = CInt(grdAsistencias.Rows(iCont).Cells("coliCodGrupo").Value)
            iCodAlumno = CInt(grdAsistencias.Rows(iCont).Cells("coliCodAlumno").Value)
            sCodigo = CStr(grdAsistencias.Rows(iCont).Cells("col_Codigo").Value)
            'bJustificaciones = sbValidarJustificacion(sCodigo)
            'If bJustificaciones = True Then

            'End If
            If grdAsistencias.Rows(iCont).Cells("col_chkAsistencia").Value = True Then
                iEstatusAsistencia = 1
                iEstatusJustificacion = 0
                iEstatusFalta = 0
            ElseIf grdAsistencias.Rows(iCont).Cells("col_chkJustificacion").Value = True Then
                iEstatusJustificacion = 1
                iEstatusAsistencia = 0
                iEstatusFalta = 0
            Else
                iEstatusFalta = 1
                iEstatusAsistencia = 0
                iEstatusJustificacion = 0
            End If

          
            cServ.fnConectar()
            cServ.sbInsertarRel_Asistencia(iCodAsistencia, iCodGrupo, sCodigo, iEstatusAsistencia, iEstatusJustificacion, iEstatusFalta)
            cServ.sbDesconectar()
        Next
    End Sub


    Private Function sbValidarJustificacion(ByVal sCodigoTmp As String) As Boolean
        Dim bNulo As Boolean
        Dim iCont, iFin As Integer
        Dim iJustLimite, iJustificacionAlumno As Integer
        sbValidarJustificacion = True
        iFin = grdAsistencias.Rows.Count

        For iCont = 0 To iFin - 1

            If grdAsistencias.Rows(iCont).Cells("col_chkJustificacion").Value = True Then
                cServ.fnConectar()
                cServ.sbConsultar_JustificacionLimite(sCodigoTmp)
                If cServ.myReader.Read = True Then
                    bNulo = cServ.myReader.IsDBNull(0)
                    If bNulo = False Then
                        iJustLimite = cServ.myReader("iJusticacionLimite")
                    Else
                        Exit Function
                    End If
                End If
                cServ.sbDesconectar()

                cServ.fnConectar()
                cServ.sbConsultar_JustificacionTotal(sCodigoTmp)
                If cServ.myReader.Read = True Then
                    bNulo = cServ.myReader.IsDBNull(0)
                    If bNulo = False Then
                        iJustificacionAlumno = cServ.myReader("iTotalJustificacion")
                    Else
                        Exit Function
                    End If
                End If
                cServ.sbDesconectar()
            End If
            If iJustificacionAlumno > iJustLimite Then
                fMessageBox.sbMensaje("EL ALUMNO CON EL CÓDIGO: " & sCodigoTmp & "TIENE EL MAXIMO DE JUSTIFICACIONES PERMITIDAS", "ERROR", piMessageError, "")
                fMessageBox.ShowDialog()
                sbValidarJustificacion = False
                Exit For
            End If

        Next
    End Function

    Private Sub cmdNuevaAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaAsistencia.Click
        sbOcultarPaneles()
        gpoListadoAlumnos.Visible = True
        bASISTENCIA = True
        lblAsistencia.Text = "Asistencia del grupo: " & sGrupo
        sbCargarNuevaAsistencia()
    End Sub
    Private Sub sbOcultarPaneles()
        bASISTENCIA = False
        bEDICION_ASISTENCIA = False
        bHISTORIAL = False
        lsvGrupos.Visible = False
        gpoAsistenciaUpdate.Visible = False
        gpoHistorial.Visible = False
        gpoListadoAlumnos.Visible = False
    End Sub

    Private Sub grdHistorialAsistencias_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdHistorialAsistencias.CellClick
        Dim iIndice, iFin As Integer
        Dim iCol As Integer
        Try

            If grdHistorialAsistencias.CurrentCell IsNot Nothing Then
                iIndice = grdHistorialAsistencias.CurrentCell.RowIndex
            Else
                Exit Sub
            End If
            iFin = grdHistorialAsistencias.RowCount
            If e.RowIndex >= 0 Then
                iCol = e.ColumnIndex
                If iCol = 5 Then
                    iCodAsistencia = CInt(grdHistorialAsistencias.Rows(iIndice).Cells("col_TranAsistencias").Value)
                    iCodGrupo = CInt(grdHistorialAsistencias.Rows(iIndice).Cells("col_TranGrupo").Value)

                    sbCargarAsistenciasUpdate(iCodAsistencia)
                    sbOcultarPaneles()
                    bEDICION_ASISTENCIA = True
                    gpoAsistenciaUpdate.Visible = True

                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub sbCargarAsistenciasUpdate(ByVal iCodAsistenciaTmp As Integer)
        Dim bNulo As Boolean
        Dim iCont, iFin, iEstatusAsistencia, iEstatusJust As Integer
        cServ.fnConectar()
        cServ.sbConsultar_Asistencia_Existente(iCodAsistenciaTmp)
        If cServ.myReader.Read = True Then
            bNulo = cServ.myReader.IsDBNull(0)
            If bNulo = True Then
                Exit Sub
            Else
                dtGrupos = New DataTable
                dtGrupos.Clear()
                cServ.sbDesconectar()
                cServ.daBuscarGrupos.Fill(dtGrupos)
                grdAsistenciaUpdate.AutoGenerateColumns = False
                grdAsistenciaUpdate.DataSource = dtGrupos
                iFin = CInt(grdAsistenciaUpdate.Rows.Count)
                For iCont = 0 To iFin - 1
                    iEstatusAsistencia = CInt(grdAsistenciaUpdate.Rows(iCont).Cells("col_tiEstatusAsistencia").Value)
                    iEstatusJust = CInt(grdAsistenciaUpdate.Rows(iCont).Cells("col_tiEstatusJustificacion").Value)
                    If iEstatusAsistencia = 1 Then
                        grdAsistenciaUpdate.Rows(iCont).Cells("col_Rel_chkAistencia").Value = True
                        grdAsistenciaUpdate.Rows(iCont).Cells("col_Rel_Asistencia").Value = My.Resources.Skins.GE_Checked_On_Flat_35x35
                    ElseIf iEstatusJust = 1 Then
                        grdAsistenciaUpdate.Rows(iCont).Cells("col_Rel_chk_Justificacion").Value = True
                        grdAsistenciaUpdate.Rows(iCont).Cells("col_Rel_Justificacion").Value = My.Resources.Skins.GE_Checked_On_Flat_35x35
                    ElseIf iEstatusAsistencia = 0 And iEstatusJust = 0 Then
                        grdAsistenciaUpdate.Rows(iCont).Cells("col_Rel_chkAistencia").Value = False
                        grdAsistenciaUpdate.Rows(iCont).Cells("col_Rel_Asistencia").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35
                        grdAsistenciaUpdate.Rows(iCont).Cells("col_Rel_chk_Justificacion").Value = False
                        grdAsistenciaUpdate.Rows(iCont).Cells("col_Rel_Justificacion").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35
                    End If
                Next
            End If
        End If
        cServ.sbDesconectar()
    End Sub

    Private Sub grdAsistenciaUpdate_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAsistenciaUpdate.CellClick
        Dim iIndice, iFin As Integer
        Dim iCol As Integer
        Try

            If grdAsistenciaUpdate.CurrentCell IsNot Nothing Then
                iIndice = grdAsistenciaUpdate.CurrentCell.RowIndex
            Else
                Exit Sub
            End If
            iFin = grdAsistenciaUpdate.RowCount
            If e.RowIndex >= 0 Then
                iCol = e.ColumnIndex
                If iCol = 9 Then
                    If grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_chkAistencia").Value = True Then
                        'Asistencia
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_Asistencia").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_chkAistencia").Value = False
                    ElseIf grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_chkAistencia").Value = False Then
                        'Asistencia
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_chkAistencia").Value = True
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_Asistencia").Value = My.Resources.Skins.GE_Checked_On_Flat_35x35
                        'Justificacion
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_Justificacion").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_chk_Justificacion").Value = False
                    End If
                ElseIf iCol = 11 Then
                    If grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_chk_Justificacion").Value = True Then
                        'Justificacion
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_Justificacion").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_chk_Justificacion").Value = False


                    ElseIf grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_chk_Justificacion").Value = False Then
                        'Justificacion
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_Justificacion").Value = My.Resources.Skins.GE_Checked_On_Flat_35x35
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_chk_Justificacion").Value = True

                        'Asistencia
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_chkAistencia").Value = False
                        grdAsistenciaUpdate.Rows(iIndice).Cells("col_Rel_Asistencia").Value = My.Resources.Skins.GE_Checked_Off_Flat_35x35

                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdActualizarAsistencia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdActualizarAsistencia.Click
        sbActualizarAsistencia()
        sbCargarHistorial(sGrupo)
        sbOcultarPaneles()
        gpoHistorial.Visible = True
    End Sub

    Private Sub sbActualizarAsistencia()
        Dim iCont, iFin As Integer

        iFin = grdAsistenciaUpdate.Rows.Count
        For iCont = 0 To iFin - 1
            iCodRelAsistencia = grdAsistenciaUpdate.Rows(iCont).Cells("col_RelAsistencias").Value

            If grdAsistenciaUpdate.Rows(iCont).Cells("col_Rel_chkAistencia").Value = True Then
                iEstatusAsistencia = 1
                iEstatusJustificacion = 0
                iEstatusFalta = 0
            ElseIf grdAsistenciaUpdate.Rows(iCont).Cells("col_Rel_chk_Justificacion").Value = True Then
                iEstatusJustificacion = 1
                iEstatusAsistencia = 0
                iEstatusFalta = 0
            Else
                iEstatusFalta = 1
                iEstatusAsistencia = 0
                iEstatusJustificacion = 0
            End If

            cServ.fnConectar()
            cServ.sbActualizar_Asistencia(iCodRelAsistencia, iEstatusAsistencia, iEstatusJustificacion, iEstatusFalta)
            cServ.sbDesconectar()
        Next
    End Sub

End Class

