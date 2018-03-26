Option Strict On
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Public Class frmAltaGrupos
    Dim bLunes, bMartes, bMiercoles, bJueves, bViernes, bSabado As Boolean
    Dim sGrupo, sProfesor, sCurso, sSeccion, sDias, sHoraIni, sHoraFin As String
    Dim dtFechaInicio, dtFechaFinal As Date
    Dim iCodProfesor, iCodGrupo As Integer
    Dim cServ As New cServidor
    Private Sub frmAltaGrupos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sbCargarTemaForma(True)
        sbCargarProfesores()
        cboHoraIni.SelectedIndex = 0
        cboHoraFin.SelectedIndex = 0
        dtFechaIni.Value = Today.Date
        dtFechaFin.Value = Today.Date.AddDays(+1)
    End Sub

    Private Sub sbCargarProfesores()
        Try
            cServ.fnConectar()
            cServ.sbConsultar_Profesores()
            cboProfesor.Items.Clear()
            While cServ.myReader.Read
                sProfesor = CStr(cServ.myReader("vchNombre")) & " " & CStr(cServ.myReader("vchPaterno"))
                iCodProfesor = CInt(cServ.myReader("iCodProfesor"))
                cboProfesor.Items.Add(New VB6.ListBoxItem(sProfesor, iCodProfesor))
            End While
            ' cboProfesor.SelectedIndex = 0
            cboProfesor.Text = "Profesor"
            cServ.sbDesconectar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkLunes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLunes.CheckedChanged
        If chkLunes.Checked = True Then
            chkLunes.Image = My.Resources.Skins.GE_Checked_On_Flat_35x35
            bLunes = True
        Else
            chkLunes.Image = My.Resources.Skins.GE_Checked_Off_Flat_35x35
            bLunes = False
        End If
    End Sub

    Private Sub chkMartes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMartes.CheckedChanged
        If chkMartes.Checked = True Then
            chkMartes.Image = My.Resources.Skins.GE_Checked_On_Flat_35x35
            bMartes = True
        Else
            chkMartes.Image = My.Resources.Skins.GE_Checked_Off_Flat_35x35
            bMartes = False
        End If
    End Sub

    Private Sub chkMiercoles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMiercoles.CheckedChanged
        If chkMiercoles.Checked = True Then
            chkMiercoles.Image = My.Resources.Skins.GE_Checked_On_Flat_35x35
            bMiercoles = True
        Else
            chkMiercoles.Image = My.Resources.Skins.GE_Checked_Off_Flat_35x35
            bMiercoles = False
        End If
    End Sub

    Private Sub chkJueves_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkJueves.CheckedChanged
        If chkJueves.Checked = True Then
            chkJueves.Image = My.Resources.Skins.GE_Checked_On_Flat_35x35
            bJueves = True
        Else
            chkJueves.Image = My.Resources.Skins.GE_Checked_Off_Flat_35x35
            bJueves = False
        End If
    End Sub

    Private Sub chkViernes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkViernes.CheckedChanged
        If chkViernes.Checked = True Then
            chkViernes.Image = My.Resources.Skins.GE_Checked_On_Flat_35x35
            bViernes = True
        Else
            chkViernes.Image = My.Resources.Skins.GE_Checked_Off_Flat_35x35
            bViernes = False
        End If
    End Sub

    Private Sub chkSabado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSabado.CheckedChanged
        If chkSabado.Checked = True Then
            chkSabado.Image = My.Resources.Skins.GE_Checked_On_Flat_35x35
            bSabado = True
        Else
            chkSabado.Image = My.Resources.Skins.GE_Checked_Off_Flat_35x35
            bSabado = False
        End If
    End Sub

    Private Sub lblNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNombre.Click
        txtNombre.Focus()
    End Sub

    Private Sub lblProfesor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblProfesor.Click
        cboProfesor.Focus()
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        ElseIf e.KeyChar = """" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text = "" Then
            lblNombre.Visible = True
        Else
            lblNombre.Visible = False
        End If

    End Sub

    Private Sub cboProfesor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProfesor.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        ElseIf e.KeyChar = """" Then
            e.Handled = True
        End If
    End Sub

   

    Private Sub cboHoraIni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboHoraIni.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cboHoraFin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboHoraFin.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Dispose()
        sbCargarTemaForma(False)
        frmAlta.pnlGrupos.BringToFront()
        frmAlta.sbLlenarGrupos()
        frmAlta.Show()
    End Sub

    Private Sub lblCurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCurso.Click
        txtCurso.Focus()
    End Sub

    Private Sub txtCurso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCurso.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        ElseIf e.KeyChar = """" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCurso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurso.TextChanged
        If txtCurso.Text = "" Then
            lblCurso.Visible = True
        Else
            lblCurso.Visible = False
        End If

    End Sub

    Private Sub lblSeccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSeccion.Click
        txtSeccion.Focus()
    End Sub

    Private Sub txtSeccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeccion.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        ElseIf e.KeyChar = """" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSeccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeccion.TextChanged
        If txtSeccion.Text = "" Then
            lblSeccion.Visible = True
        Else
            lblSeccion.Visible = False
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        sbGuardar()
    End Sub
    Private Sub sbGuardar()
        Dim bAutorizado As Boolean
        bAutorizado = fnValidarDatos()
        If bAutorizado = True Then
            sbEstablecerValores()
        End If
    End Sub

    Private Function fnValidarDatos() As Boolean
        fnValidarDatos = True
        If Trim$(txtNombre.Text) = "" Then
            frmPrincipal.sbMensaje("CAMPO VACIO", "Error", piMessageError, "")
            txtNombre.Focus()
            fnValidarDatos = False
            Exit Function
        End If
        If Trim$(txtCurso.Text) = "" Then
            frmPrincipal.sbMensaje("CAMPO VACIO", "ERROR", piMessageError, "")
            txtCurso.Focus()
            fnValidarDatos = False
            Exit Function
        End If
        If iCodProfesor = 0 Then
            frmPrincipal.sbMensaje("CAMPO VACIO", "ERROR", piMessageError, "")
            cboProfesor.Focus()
            fnValidarDatos = False
            Exit Function
        End If
        If txtSeccion.Text = "" Then
            frmPrincipal.sbMensaje("CAMPO VACIO", "ERROR", piMessageError, "")
            txtSeccion.Focus()
            fnValidarDatos = False
            Exit Function
        End If
        If dtFechaFin.Value <= dtFechaIni.Value Then
            frmPrincipal.sbMensaje("FECHA DE FIN DEBE SER MAYOR A LA FECHA DE INICIO", "ERROR", piMessageError, "")
            txtSeccion.Focus()
            fnValidarDatos = False
            Exit Function
        End If
        If bLunes = False And bMartes = False And bMiercoles = False And bJueves = False And bViernes = False And bSabado = False Then
            frmPrincipal.sbMensaje("DEBE SELECCIONAR UN HORARIO", "ERROR", piMessageError, "")
            txtSeccion.Focus()
            fnValidarDatos = False
            Exit Function
        End If
        Dim iHoraIni, iHOraFin As Date
        iHOraFin = CDate(cboHoraFin.Text)
        iHoraIni = CDate(cboHoraIni.Text)
        If iHOraFin <= iHoraIni Then
            frmPrincipal.sbMensaje("LA HORA DE FIN DEBE SER MAYOR A A HORA DE INICIO", "ERROR", piMessageError, "")
            txtSeccion.Focus()
            fnValidarDatos = False
            Exit Function
        End If
    End Function
    Private Sub sbEstablecerValores()
        Dim bNulo As Boolean
        Dim sLunes, sMartes, sMiercoles, sJueves, sViernes, sSabado As String
        Dim iMesIni, iDiaIni, iAnioIni, iMesFin, iDiaFin, iAnioFin As Integer
        Dim iDiasLunes, iDiasMartes, iDiasMiercoles, iDiasJueves, iDiasViernes, iDiasSabado As Integer
      
        sGrupo = Trim$(txtNombre.Text)
        sCurso = Trim$(txtCurso.Text)
        sSeccion = Trim$(txtSeccion.Text)
        dtFechaInicio = CDate(FormatDateTime(dtFechaIni.Value, DateFormat.ShortDate))
        dtFechaFinal = CDate(FormatDateTime(dtFechaFin.Value, DateFormat.ShortDate))
        sHoraIni = cboHoraIni.Text
        sHoraFin = cboHoraFin.Text
        iMesIni = dtFechaIni.Value.Month
        iDiaIni = dtFechaIni.Value.Day
        iAnioIni = dtFechaIni.Value.Year
        iMesFin = dtFechaFin.Value.Month
        iDiaFin = dtFechaFin.Value.Day
        iAnioFin = dtFechaFin.Value.Year

        If bLunes = True Then
            iDiasLunes = sbCalcularClases(iDiaIni, iMesIni, iAnioIni, iDiaFin, iMesFin, iAnioFin, "Monday")
            sLunes = "Lunes - "
        Else
            sLunes = ""
        End If

        If bMartes = True Then
            iDiasMartes = sbCalcularClases(iDiaIni, iMesIni, iAnioIni, iDiaFin, iMesFin, iAnioFin, "Tuesday")
            sMartes = "Martes - "
        Else
            sMartes = ""
        End If
       
        If bMiercoles = True Then
            iDiasMiercoles = sbCalcularClases(iDiaIni, iMesIni, iAnioIni, iDiaFin, iMesFin, iAnioFin, "Wednesday")
            sMiercoles = "Miercoles - "
        Else
            sMiercoles = ""
        End If

        If bJueves = True Then
            iDiasJueves = sbCalcularClases(iDiaIni, iMesIni, iAnioIni, iDiaFin, iMesFin, iAnioFin, "Thursday")
            sJueves = "Jueves - "
        Else
            sJueves = ""
        End If
        If bViernes = True Then
            iDiasViernes = sbCalcularClases(iDiaIni, iMesIni, iAnioIni, iDiaFin, iMesFin, iAnioFin, "Friday")
            sViernes = "Viernes - "
        Else
            sViernes = ""
        End If
        If bSabado = True Then
            iDiasSabado = sbCalcularClases(iDiaIni, iMesIni, iAnioIni, iDiaFin, iMesFin, iAnioFin, "Saturday")
            sSabado = "Sabado - "
        Else
            sSabado = ""
        End If
        sDias = sLunes & sMartes & sMiercoles & sJueves & sViernes & sSabado
        cServ.fnConectar()
        cServ.sbInsertarGrupo(iCodGrupo, iCodProfesor, sGrupo, sProfesor, dtFechaFinal, dtFechaInicio, sCurso, sSeccion, sDias, sHoraIni, sHoraFin)
        cServ.sbDesconectar()
        sbInsertarDiasCurso(iCodGrupo, iDiasLunes, iDiasMartes, iDiasMiercoles, iDiasJueves, iDiasViernes, iDiasSabado)
        sbLimpiar()
        frmPrincipal.sbMensaje(sGrupo & " " & "GUARDADO CORRECTAMENTE", "INFO", piMessageInfo, "")
    End Sub

    Private Function fnValidarTodosDiasFestivos() As Boolean
        Dim bNulo As Boolean
        cServ.fnConectar()
        cServ.sbConsultar_Dias_Inhabiles()
        If cServ.myReader.Read = True Then
            bNulo = cServ.myReader.IsDBNull(0)
            If bNulo = False Then
                Return True
            Else
                Return False
            End If
        Else
            cServ.sbDesconectar()
            Return False
        End If

    End Function

    Private Function fnValidarDia(ByVal iDia As Integer, ByVal iMes As Integer, ByVal iAnio As Integer) As Boolean
        Dim bNulo As Boolean
        cServ.fnConectar()
        cServ.sbConsultar_Dia_Inhabil(iDia, iMes, iAnio)
        If cServ.myReader.Read = True Then
            bNulo = cServ.myReader.IsDBNull(0)
            If bNulo = False Then
                cServ.sbDesconectar()
                Return True
            Else
                cServ.sbDesconectar()
                Return False
            End If
        Else
            cServ.sbDesconectar()
            Return False
        End If

    End Function
    Private Function sbCalcularClases(ByVal iDiaIni As Integer, ByVal iMesIni As Integer, ByVal iAnioIni As Integer, ByVal iDiaFin As Integer, ByVal iMesFin As Integer, ByVal iAnioFin As Integer, ByVal sDia As String) As Integer
        Dim cantidad As Integer = 0
        Dim bDiaInhabil, bDiaInhabilExistente As Boolean
        'Dim iTotalDias
        Try
            Dim fechaRef As New Date(iAnioIni, iMesIni, iDiaIni)
            Dim fechaFin As New Date(iAnioFin, iMesFin, iDiaFin)
            Dim dtFechaTmp As Date
            Dim iTotalDias As Long = DateDiff(DateInterval.Weekday, fechaRef, fechaFin)
            bDiaInhabilExistente = fnValidarTodosDiasFestivos()
            Select Case sDia
                Case "Monday"
                    While fechaRef <> fechaFin 'DayOfWeek.Monday
                        If bDiaInhabilExistente = True Then
                            bDiaInhabil = fnValidarDia(fechaRef.Day, fechaRef.Month, fechaRef.Year)
                        Else
                            bDiaInhabil = False
                        End If

                        If bDiaInhabil = False And fechaRef.DayOfWeek = DayOfWeek.Monday Then
                            fechaRef = fechaRef.AddDays(1)
                            cantidad = cantidad + 1
                        Else
                            fechaRef = fechaRef.AddDays(1)
                        End If

                    End While
                Case "Tuesday"
                    While fechaRef <> fechaFin
                        If bDiaInhabilExistente = True Then
                            bDiaInhabil = fnValidarDia(fechaRef.Day, fechaRef.Month, fechaRef.Year)
                        Else
                            bDiaInhabil = False
                        End If
                        If bDiaInhabil = False And fechaRef.DayOfWeek = DayOfWeek.Tuesday Then
                            fechaRef = fechaRef.AddDays(1)
                            cantidad = cantidad + 1
                        Else
                            fechaRef = fechaRef.AddDays(1)
                        End If

                    End While
                Case "Wednesday"
                    While fechaRef <> fechaFin
                        If bDiaInhabilExistente = True Then
                            bDiaInhabil = fnValidarDia(fechaRef.Day, fechaRef.Month, fechaRef.Year)
                        Else
                            bDiaInhabil = False
                        End If
                        If bDiaInhabil = False And fechaRef.DayOfWeek = DayOfWeek.Wednesday Then
                            fechaRef = fechaRef.AddDays(1)
                            cantidad = cantidad + 1
                        Else
                            fechaRef = fechaRef.AddDays(1)
                        End If

                    End While
                Case "Thursday"
                    While fechaRef <> fechaFin
                        If bDiaInhabilExistente = True Then
                            bDiaInhabil = fnValidarDia(fechaRef.Day, fechaRef.Month, fechaRef.Year)
                        Else
                            bDiaInhabil = False
                        End If
                        If bDiaInhabil = False And fechaRef.DayOfWeek = DayOfWeek.Thursday Then
                            fechaRef = fechaRef.AddDays(1)
                            cantidad = cantidad + 1
                        Else
                            fechaRef = fechaRef.AddDays(1)
                        End If

                    End While
                Case "Friday"
                    While fechaRef <> fechaFin
                        If bDiaInhabilExistente = True Then
                            bDiaInhabil = fnValidarDia(fechaRef.Day, fechaRef.Month, fechaRef.Year)
                        Else
                            bDiaInhabil = False
                        End If
                        If bDiaInhabil = False And fechaRef.DayOfWeek = DayOfWeek.Friday Then
                            fechaRef = fechaRef.AddDays(1)
                            cantidad = cantidad + 1
                        Else
                            fechaRef = fechaRef.AddDays(1)
                        End If

                    End While
                Case "Saturday"
                    While fechaRef <> fechaFin
                        If bDiaInhabilExistente = True Then
                            bDiaInhabil = fnValidarDia(fechaRef.Day, fechaRef.Month, fechaRef.Year)
                        Else
                            bDiaInhabil = False
                        End If
                        If bDiaInhabil = False And fechaRef.DayOfWeek = DayOfWeek.Saturday Then
                            fechaRef = fechaRef.AddDays(1)
                            cantidad = cantidad + 1
                        Else
                            fechaRef = fechaRef.AddDays(1)
                        End If

                    End While
            End Select
            'For i As Integer = 0 To CInt(iTotalDias)
            '    dtFechaTmp = fechaRef.AddDays(i * 7)
            '    If dtFechaTmp <= fechaFin Then
            '        cantidad = cantidad + 1
            '    Else
            '        Exit For
            '    End If
            'Next
            Return cantidad
        Catch ex As Exception

        End Try

    End Function
    Private Sub sbLimpiar()
        txtNombre.Text = ""
        txtCurso.Text = ""
        txtSeccion.Text = ""
        chkLunes.Checked = False
        chkMartes.Checked = False
        chkMiercoles.Checked = False
        chkJueves.Checked = False
        chkViernes.Checked = False
        chkSabado.Checked = False
        cboHoraIni.SelectedIndex = 0
        cboHoraFin.SelectedIndex = 0
        dtFechaIni.Value = Today.Date
        dtFechaFin.Value = Today.Date.AddDays(+1)
        sbCargarProfesores()
    End Sub
    Private Sub sbInsertarDiasCurso(ByVal iCodGrupo As Integer, ByVal iDiasLunesTmp As Integer, ByVal iDiasMartesTmp As Integer, ByVal iDiasMiercolesTmp As Integer, ByVal iDiasJuevesTmp As Integer, ByVal iDiasViernesTmp As Integer, ByVal iDiasSabadoTmp As Integer)
        Dim iDiasTotal, iCodDia As Integer
        Dim bNulo As Boolean
        cServ.fnConectar()
        cServ.sbConsultar_UltimoGrupo()
        If cServ.myReader.Read = True Then
            bNulo = cServ.myReader.IsDBNull(0)
            If bNulo = False Then
                iCodGrupo = CInt(cServ.myReader("iCodGrupo"))
            Else
                iCodGrupo = 1
            End If
        Else
            iCodGrupo = 1
        End If

        iDiasTotal = CInt(iDiasLunesTmp + iDiasMartesTmp + iDiasMiercolesTmp + iDiasJuevesTmp + iDiasViernesTmp + iDiasSabadoTmp)
        'cServ.fnConectar()
        'cServ.sbConsultar_iCodUltimoCurso()
        'If cServ.myReader.Read = True Then
        '    bNulo = CBool(cServ.myReader.IsDBNull(0))
        '    If bNulo = True Then
        '        iCodDia = 1
        '    Else
        '        iCodDia = CInt(cServ.myReader("iCodDia"))
        '        iCodDia = iCodDia + 1
        '    End If
        'End If
        'cServ.sbDesconectar()
        cServ.fnConectar()
        cServ.sbInsertarDiasCurso(iCodDia, iCodGrupo, iDiasLunesTmp, iDiasMartesTmp, iDiasMiercolesTmp, iDiasJuevesTmp, iDiasViernesTmp, iDiasSabadoTmp, iDiasTotal)
        cServ.sbDesconectar()
    End Sub

    Private Sub cboProfesor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProfesor.SelectedIndexChanged
        Dim lstboxItem As VB6.ListBoxItem
        lblProfesor.Visible = False
        Try
            lstboxItem = CType(cboProfesor.SelectedItem, VB6.ListBoxItem)
            iCodProfesor = CInt(lstboxItem.ItemData)
            sProfesor = CStr(lstboxItem.ItemString)
        Catch ex As Exception
        End Try
    End Sub
    
End Class

