Option Strict On
Option Explicit On
Imports MySql.Data.MySqlClient
Public Class frmBuscar
    Dim cServ As New cServidor
    Dim bAlumno, bGrupo, bCodigo As Boolean
    Dim daBuscar As New OleDb.OleDbDataAdapter
    Dim dtAlumno As DataTable = New DataTable("CatAlumnos")

    Private Sub sbDesactivarOption()
        bAlumno = False
        bGrupo = False
        bCodigo = False
        optEstudiante.Image = My.Resources.Skins.GE_Option_On
        optCodigo.Image = My.Resources.Skins.GE_Option_On
        optGrupo.Image = My.Resources.Skins.GE_Option_On

    End Sub


    Private Sub sbLlenarDatos()
        Dim sAlumno, sCodigo, sGrupo As String
        Dim sSql As String
        Try
            MyBase.Cursor = Cursors.WaitCursor
            dtAlumno.Clear()
            DaRe.DataSource = Nothing
            DaRe.ItemTemplate.ResumeLayout()
            If bAlumno = True Then
                sAlumno = Trim$(txtBuscar.Text)
                cServ.fnConectar()
                sSql = "SELECT *, concat(vchNombre , ' ' , vchPaterno, ' ', vchMaterno) as vchAlumno " & _
                " FROM softassitence.catalumnos WHERE vchNombre LIKE '" & sAlumno & "%'"

            ElseIf bCodigo = True Then
                sCodigo = Trim$(txtBuscar.Text)
                cServ.fnConectar()
                sSql = "SELECT *, concat(vchNombre , ' ' , vchPaterno, ' ', vchMaterno) as vchAlumno " & _
                " FROM softassitence.catalumnos WHERE vchNombre LIKE '" & sCodigo & "%'"

            ElseIf bGrupo = True Then
                sGrupo = Trim$(txtBuscar.Text)
                cServ.fnConectar()
                sSql = "SELECT *, concat(CA.vchNombre , ' ' , CA.vchPaterno, ' ', CA.vchMaterno) as vchAlumno " & _
                " FROM softassitence.catalumnos CA INNER JOIN " & _
                " softassitence.catgrupos CG ON CG.iCodGrupo= CA.iCodGrupo " & _
                " WHERE vchGrupo LIKE '" & sGrupo & "%'"

            End If

            sbLimpiarDare()
            sbEstablecerDareObjetos()
            DaRe.DataSource = dtAlumno
            lblTotal.Text = CStr(DaRe.ItemCount)
            lblTotal.Visible = True
            cServ.sbDesconectar()
            MyBase.Cursor = Cursors.Arrow
        Catch ex As Exception

        End Try

    End Sub
    Private Sub sbEstablecerDareObjetos()
        Try
            'lblCodAlumno.DataBindings.Add("Text", dtAlumno, "iCodAlumno")
            ''picPaciente.DataBindings.Add("Image", dtAlumno, "Imagen")
            ''picPaciente.BackgroundImageLayout = ImageLayout.Stretch
            'lblNombre.DataBindings.Add("Text", dtAlumno, "vchAlumno")
            'lblCarrera.DataBindings.Add("Text", dtAlumno, "vchCarrera")
            'lblCodigo.DataBindings.Add("Text", dtAlumno, "vchCodigo")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub sbLimpiarDare()
        Try
            'DaRe.DataBindings.Clear()
            'DaRe.DataSource = Nothing
            'lblCodAlumno.DataBindings.Clear()
            'picPaciente.DataBindings.Clear()
            'lblNombre.DataBindings.Clear()
            'lblCodigo.DataBindings.Clear()
            'lblCarrera.DataBindings.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmBuscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bAlumno = True
        optCodigo = New System.Windows.Forms.RadioButton
    End Sub

   
    Private Sub optEstudiante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optEstudiante.Click
        sbDesactivarOption()
        optEstudiante.Checked = True
        bAlumno = True
        optEstudiante.Image = My.Resources.Skins.GE_Option_On
    End Sub

    Private Sub optCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCodigo.Click
        sbDesactivarOption()
        optCodigo.Checked = True
        bCodigo = True
        optCodigo.Image = My.Resources.Skins.GE_Option_On
    End Sub

    Private Sub optGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGrupo.Click
        sbDesactivarOption()
        optGrupo.Checked = True
        bGrupo = True
        optGrupo.Image = My.Resources.Skins.GE_Option_On
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text.Length > 2 Then
            sbLlenarDatos()
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Try
            Me.Hide()
            DaRe.Dispose()
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub
End Class
