Option Strict On
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.IO


Public Class frmAlumnosVisor
    'Dim bLunes, bMartes, bMiercoles, bJueves, bViernes, bSabado As Boolean
    'Dim sGrupo, sProfesor, sCurso, sSeccion, sDias, sHoraIni, sHoraFin As String
    'Dim dtFechaInicio, dtFechaFinal As Date
    Dim cServ As New cServidor
    Dim dtAlumnos As New DataTable
    Dim daBuscarAlumnos As New MySqlDataAdapter
    Public iCodGrupo As Integer
    Public sGrupoTitle As String
    Dim sAlumno, sPaterno, sMaterno, sCodigo, sCarrera As String
    Dim iCodAlumno, iCodCarrera As Integer
    Public bCapturaManual, bEdicionAlumno As Boolean
#Region "EVENTOS"
    Private Sub lblNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNombre.Click
        txtNombre.Focus()
    End Sub

    Private Sub lblPaterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPaterno.Click
        txtPaterno.Focus()
    End Sub

    Private Sub lblMaterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMaterno.Click
        txtMaterno.Focus()
    End Sub

    Private Sub lblCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCodigo.Click
        txtCodigo.Focus()
    End Sub

    Private Sub lblCarrera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCarrera.Click
        txtCarrera.Focus()
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text = "" Then
            lblNombre.Visible = True
        Else
            lblNombre.Visible = False
        End If
    End Sub

    Private Sub txtPaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaterno.TextChanged
        If txtPaterno.Text = "" Then
            lblPaterno.Visible = True
        Else
            lblPaterno.Visible = False
        End If
    End Sub

    Private Sub txtMaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaterno.TextChanged
        If txtMaterno.Text = "" Then
            lblMaterno.Visible = True
        Else
            lblMaterno.Visible = False
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text = "" Then
            lblCodigo.Visible = True
        Else
            lblCodigo.Visible = False
        End If
    End Sub

    Private Sub txtCarrera_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCarrera.TextChanged
        If txtCarrera.Text = "" Then
            lblCarrera.Visible = True
        Else
            lblCarrera.Visible = False
        End If
    End Sub
#End Region

    Private Sub frmAlumnosVisor_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        sbCargarTemaForma(False)
        Me.Close()
    End Sub

    Private Sub sbCargarCarreras()
        Try
            cServ.fnConectar()
            cServ.sbConsultar_Carreras()
            cboCarreras.Items.Clear()
            While cServ.myReader.Read
                iCodCarrera = CInt(cServ.myReader("iCodCarrera"))
                sCarrera = CStr(cServ.myReader("vchCarrera"))
                cboCarreras.Items.Add(New VB6.ListBoxItem(sCarrera, iCodCarrera))
            End While
            ' cboProfesor.SelectedIndex = 0
            cboCarreras.Text = "Carreras..."
            cServ.sbDesconectar()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmAlumnosVisor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sbCargarTemaForma(True)

        If bEdicionAlumno = True Then
            lblGrupo.Visible = False
            cboGrupo.Visible = False
            sbCargarGrupos()
            iCodGrupo = CInt(lblCodGrupo.Text)
            iCodAlumno = CInt(lblCodAlumno.Text)
            iCodCarrera = CInt(lblCodCarrera.Text)
            expNuevo.Expanded = True
            picExcel.Visible = False
            grdAlumnoImport.Visible = False
            cmdImportar.Visible = False
            cmdAceptar.Visible = False
        ElseIf bEdicionAlumno = False Then
            sbCargarCarreras()
            If bCapturaManual = True Then
                pnlCapturar.Visible = True
                pnlCapturar.BringToFront()
            Else
                picExcel.Visible = False
                lblTitulo.Text = "Grupo: " & sGrupoTitle
                cmdImportar.Visible = False
                cmdAceptar.Visible = False
                expNuevo.Visible = False
                pnlVisor.Visible = True
                pnlVisor.BringToFront()
                sbLlenarAlumnos(iCodGrupo)
            End If
        End If
     
    End Sub

    Private Sub sbLlenarAlumnos(ByVal iCodGrupoTmp As Integer)

        Dim sSql As String
        sSql = "SELECT *, concat(vchNombre , ' ' , vchPaterno, ' ', vchMaterno) as vchAlumno " & _
        " FROM softassitence.catalumnos WHERE iCodGrupo = '" & iCodGrupoTmp & "'"

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

    Private Sub grdAlumnos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAlumnos.CellClick
        Dim iIndice, iCol As Integer

        Try
            If grdAlumnos.CurrentCell IsNot Nothing Then
                iIndice = grdAlumnos.CurrentCell.RowIndex
            End If
            If e.RowIndex >= 0 Then
                iCodAlumno = CInt(grdAlumnos.Rows(iIndice).Cells("colAlumno").Value)
                iCol = e.ColumnIndex
                If iCol = 5 Then

                ElseIf iCol = 6 Then
                    cServ.fnConectar()
                    cServ.sbEliminar_Alumno(iCodAlumno)
                    cServ.sbDesconectar()
                    sbLlenarAlumnos(iCodGrupo)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        If bEdicionAlumno = True Then
            sbCargarTemaForma(True)
            Me.Dispose()
            frmBuscarPacientes.Show()
        Else
            sbCargarTemaForma(False)
            Me.Dispose()
            frmAlta.pnlAlumnos.BringToFront()
            frmAlta.sbLlenarAlumnos()
            frmAlta.Show()
        End If
        
    End Sub

    Private Sub sbObtenerExcel()
        Dim bNulo As Boolean
        Dim iLongitud As Integer
        Dim sArchivo, sNombreFile As String
        With fdlgImportar
            .ReadOnlyChecked = True
            .Filter = "Todos los archivos|*.*|xls|*.xls|xlsx|*.xlsx"
            '.Filter = "Todos los archivos|*.PDF|PDF"
            .FilterIndex = 2
            .FileName = ""
            bNulo = CBool(.ShowDialog())
            iLongitud = .FileName.Length
        End With
        sArchivo = fdlgImportar.FileName
        If sArchivo <> "" Then
            picExcel.Visible = False
            sNombreFile = IO.Path.GetFileNameWithoutExtension(sArchivo)
            GetDataExcel(sArchivo, "Hoja1")
        Else
            grdAlumnoImport.Visible = False
            picExcel.Visible = True
        End If


       
    End Sub

    Private Sub GetDataExcel( _
      ByVal sArchivo As String, ByVal sNombreExcel As String)

        ' Comprobamos los parámetros.
        '
        If ((String.IsNullOrEmpty(sArchivo)) OrElse _
          (String.IsNullOrEmpty(sNombreExcel))) Then _
          Throw New ArgumentNullException()

        ''''**********
        Dim ds As New DataSet
        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        Dim conn As OleDbConnection
        Dim xSheet As String = "Hoja1"
        ' xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
        conn = New OleDbConnection( _
                          "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                          "data source=" & sArchivo & "; " & _
                         "Extended Properties='Excel 8.0;HDR=YES;IMEX=1'")

        Try
            da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

            conn.Open()
            da.Fill(ds, "MyData")
            dt = ds.Tables("MyData")
            grdAlumnoImport.DataSource = ds
            grdAlumnoImport.DataMember = "MyData"
            grdAlumnoImport.Visible = True
            grdAlumnoImport.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            grdAlumnoImport.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            grdAlumnoImport.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            grdAlumnoImport.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            grdAlumnoImport.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


            picExcel.Visible = False
        Catch ex As Exception
            frmPrincipal.sbMensaje("EL ARCHIVO NO TIENE EL FORMATO ESPERADO", "ERROR", piMessageError, "")

        End Try

    End Sub
    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        sbObtenerExcel()
    End Sub

    Private Function fnEstablecerImagen() As String
        Dim vFotoTmp As Bitmap
        Dim ms As New MemoryStream
        vFotoTmp = My.Resources.Skins.GE_Alumno_60
        vFotoTmp.Save(ms, Imaging.ImageFormat.Png)
        Dim iMagenPromotionTmp() As Byte = ms.GetBuffer
        fnEstablecerImagen = Convert.ToBase64String(iMagenPromotionTmp)
        ms.Close()
    End Function

    Private Sub sbGuardarExcel()
        Dim iCont, iFin, iCodAlumno As Integer
        Dim bNulo, bCodigoValido As Boolean
        Dim sBase64 As String
        Try
           
            If grdAlumnoImport.DataSource Is Nothing Then
                Exit Sub
            Else
                sBase64 = fnEstablecerImagen()
                iFin = CInt(grdAlumnoImport.RowCount)
                For iCont = 0 To iFin - 1
                    iCodAlumno = iCodAlumno + 1
                    sAlumno = CStr(grdAlumnoImport.Rows(iCont).Cells(0).Value.ToString.ToUpper)
                    sPaterno = CStr(grdAlumnoImport.Rows(iCont).Cells(1).Value.ToString.ToUpper)
                    sMaterno = CStr(grdAlumnoImport.Rows(iCont).Cells(2).Value.ToString.ToUpper)
                    sCodigo = CStr(grdAlumnoImport.Rows(iCont).Cells(3).Value.ToString.ToUpper)
                    sCarrera = CStr(grdAlumnoImport.Rows(iCont).Cells(4).Value.ToString.ToUpper)
                    cServ.fnConectar()
                    cServ.sbConsultar_Alumno_Existente(sCodigo, iCodGrupo, iCodAlumno, False)
                    If cServ.myReader.Read = True Then
                        bCodigoValido = False
                    Else
                        bCodigoValido = True
                    End If
                    cServ.sbDesconectar()
                    If bCodigoValido = True Then
                        cServ.fnConectar()
                        cServ.sbInsertarAlumno(iCodGrupo, sAlumno, sPaterno, sMaterno, sCodigo, sCarrera, sBase64)
                        cServ.sbDesconectar()
                    End If
                Next
            End If
            frmPrincipal.sbMensaje("REGISTROS GUARDADOS CORRECTAMENTE", "INFO", piMessageInfo, "")
            Me.Close()
            frmAlta.Show()
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        sbGuardarExcel()
    End Sub

    Private Sub expNuevo_ExpandedChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles expNuevo.ExpandedChanged
        If expNuevo.Expanded = True Then
            cmdAceptar.Visible = False
            cmdImportar.Visible = False
        Else
            If bEdicionAlumno = False Then
                cmdImportar.Visible = True
                cmdAceptar.Visible = True
            End If
            
        End If
    End Sub

    Private Sub cmdGuardarAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarAlumno.Click
        Dim bAutorizado As Boolean
        bAutorizado = fnValidarDatos()
        If bAutorizado = True Then
            sbEstablecerValores()
        End If
    End Sub

    Private Sub sbEstablecerValores()
        Dim bNulo As Boolean
        Dim sBase64 As String
        Try
            
            sBase64 = fnEstablecerImagen()
            sAlumno = CStr(Trim$(txtNombre.Text))
            sPaterno = CStr(Trim$(txtPaterno.Text))
            sMaterno = CStr(Trim$(txtMaterno.Text))
            sCodigo = CStr(Trim$(txtCodigo.Text))
            sCarrera = CStr(Trim$(txtCarrera.Text))
            cServ.fnConectar()
            If bEdicionAlumno = True Then
               
                cServ.sbActualizar_DatosAlumno(iCodAlumno, iCodGrupo, sAlumno, sPaterno, sMaterno, sCodigo, sCarrera)
                frmPrincipal.sbMensaje(" ALUMNO ACTUALIZADO CORRECTAMENTE", "INFO", piMessageInfo, "")
                Me.Dispose()
                frmBuscarPacientes.Dispose()
                frmPrincipal.Show()
            Else
                cServ.fnConectar()
                cServ.sbInsertarAlumno(iCodGrupo, sAlumno, sPaterno, sMaterno, sCodigo, sCarrera, sBase64)
                frmPrincipal.sbMensaje("EL ALUMNO FUE GUARDADO CORRECTAMENTE", "INFO", piMessageInfo, "")
                sbLimpiar()
            End If
            cServ.sbDesconectar()
        Catch ex As Exception

        End Try
    End Sub

    Private Function fnValidarDatos() As Boolean
        fnValidarDatos = True
        If Trim$(txtNombre.Text) = "" Then
            frmPrincipal.sbMensaje("CAMPO VACIO", "Error", piMessageError, "")
            txtNombre.Focus()
            fnValidarDatos = False
            Exit Function
        End If
        If Trim$(txtPaterno.Text) = "" Then
            frmPrincipal.sbMensaje("CAMPO VACIO", "ERROR", piMessageError, "")
            txtPaterno.Focus()
            fnValidarDatos = False
            Exit Function
        End If
        If Trim$(txtMaterno.Text) = "" Then
            frmPrincipal.sbMensaje("CAMPO VACIO", "ERROR", piMessageError, "")
            txtMaterno.Focus()
            fnValidarDatos = False
            Exit Function
        End If
        If Trim$(txtCodigo.Text) = "" Then
            frmPrincipal.sbMensaje("CAMPO VACIO", "ERROR", piMessageError, "")
            txtCodigo.Focus()
            fnValidarDatos = False
            Exit Function
        End If
        cServ.fnConectar()
        cServ.sbConsultar_Alumno_Existente(Trim(txtCodigo.Text), iCodGrupo, iCodAlumno, True)
        If cServ.myReader.Read = True Then
            frmPrincipal.sbMensaje("CÓDIGO REPETIDO, FAVOR DE VERIFICAR", "ERROR", piMessageError, "")
            txtCodigo.Focus()
            fnValidarDatos = False
        End If
        cServ.sbDesconectar()
        'If iCodCarrera = 0 Or cboCarreras.Text = "Carreras..." Then
        '    frmPrincipal.sbMensaje("CAMPO VACIO", "ERROR", piMessageError, "")
        '    cboCarreras.Focus()
        '    fnValidarDatos = False
        '    Exit Function
        'End If
    End Function

    Private Sub sbLimpiar()
        txtNombre.Text = ""
        txtPaterno.Text = ""
        txtMaterno.Text = ""
        txtCodigo.Text = ""
        txtCarrera.Text = ""
    End Sub

    Private Sub sbCargarGrupos()
        Try
            Dim sGrupo As String
            cServ.fnConectar()
            cServ.sbConsultar_Grupos()
            cboGrupo.Items.Clear()
            While cServ.myReader.Read
                sGrupo = CStr(cServ.myReader("vchGrupo"))
                iCodGrupo = CInt(cServ.myReader("iCodGrupo"))
                cboGrupo.Items.Add(New VB6.ListBoxItem(sGrupo, iCodGrupo))
            End While
            cboGrupo.SelectedIndex = 0
            cboGrupo.Text = "Profesor"
            cServ.sbDesconectar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        Dim lstboxItem As VB6.ListBoxItem
        ' Dim sGrupo As String
        '.Visible = False
        Try
            lstboxItem = CType(cboGrupo.SelectedItem, VB6.ListBoxItem)
            iCodGrupo = CInt(lstboxItem.ItemData)
            ' sGrupo = CStr(lstboxItem.ItemString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboCarreras_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCarreras.SelectedIndexChanged
        Dim lstboxItem As VB6.ListBoxItem
        ' Dim sGrupo As String
        '.Visible = False
        Try
            lstboxItem = CType(cboCarreras.SelectedItem, VB6.ListBoxItem)
            iCodCarrera = CInt(lstboxItem.ItemData)
            sCarrera = CStr(lstboxItem.ItemString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboCarreras_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCarreras.DropDown
        If bEdicionAlumno = True Then
            sbCargarCarreras()
        End If
    End Sub
End Class

