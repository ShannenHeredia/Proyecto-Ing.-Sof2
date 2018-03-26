Option Strict Off
Option Explicit On
Imports System
Imports System.Threading
Imports System.Text
Imports System.IO


Friend Class frmPrincipal
    Inherits System.Windows.Forms.Form


    Private Sub MDIForm_Terminate_Renamed()
        Try
            'End
        Catch ex As Exception
            End
        End Try
    End Sub
    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        End
    End Sub

    Private Sub cmdAltaPacienteLive_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles cmdAltaPacienteLive.Click
        sbAlta()
    End Sub
    Private Sub sbAlta()
        Try
            With frmAlta
                .Parent = Me.splPanel
                .TopLevel = False
                .Dock = DockStyle.Fill
                .BringToFront()
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub sbMensaje(ByVal sMensaje As String, ByVal sTitulo As String, ByVal iTipoError As Single, ByVal sTextoOpcional As String)
        pnlTitulo.Visible = True
        pnlTitulo.BringToFront()
        lblTitulo.ForeColor = Color.Black
        lblTitulo.Text = sTitulo
        lblMensaje.Text = sMensaje & " " & sTextoOpcional
        tmrMensaje.Interval = 4000
        tmrMensaje.Enabled = True
        tmrMensaje.Start()
        Select Case iTipoError
            Case piMessagePregunta 'PREGUNTA
                lblTitulo.ForeColor = Color.DimGray
                lblMensaje.ForeColor = Color.DarkGreen
                pnlImagen.BackgroundImage = My.Resources.Skins.GE_Message_Pregunta_60x55
                tmrMensaje.Enabled = False
            Case piMessagePrecaucion 'PRECAUCION
                lblTitulo.ForeColor = Color.DimGray
                lblMensaje.ForeColor = Color.Crimson
                pnlImagen.BackgroundImage = My.Resources.Skins.GE_Message_Precaucion_60x55
                tmrMensaje.Enabled = True
            Case piMessageError 'ERROR
                lblTitulo.ForeColor = Color.DimGray
                lblMensaje.ForeColor = Color.Crimson
                pnlImagen.BackgroundImage = My.Resources.Skins.GE_Message_Error_60x55
                tmrMensaje.Enabled = True
            Case piMessageInfo 'INFORMACION
                lblTitulo.ForeColor = Color.DimGray
                lblMensaje.ForeColor = Color.SteelBlue
                pnlImagen.BackgroundImage = My.Resources.Skins.GE_Message_Informacion_60x55

        End Select

    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sbCargarTemaForma(False)
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        pnlTitulo.Visible = False
    End Sub

    Private Sub tmrMensaje_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMensaje.Tick
        pnlTitulo.Visible = False
        tmrMensaje.Enabled = False
    End Sub

    Private Sub cmdConsultarLive_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles cmdConsultarLive.Click
        sbBusqueda()
    End Sub

    Private Sub sbBusqueda()
        Try
            With frmBuscarPacientes
                .Parent = Me.splPanel
                .TopLevel = False
                .Dock = DockStyle.Fill
                .BringToFront()
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAgendaLive_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles cmdAgendaLive.Click
        sbAsistencia()
    End Sub

    Private Sub sbAsistencia()
        Try
            With frmAsistencias
                .Parent = Me.splPanel
                .TopLevel = False
                ' .Dock = DockStyle.Fill
                .Location = New Point(240, 0)
                .BringToFront()
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdInfos_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles cmdInfos.Click
        sbReportes()
    End Sub

    Private Sub sbReportes()
        Try
            With frmReportes
                .Parent = Me.splPanel
                .TopLevel = False
                ' .Dock = DockStyle.Fill
                .Location = New Point(300, 90)
                .BringToFront()
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdProfesor_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles cmdProfesor.Click
        sbProfesor()
    End Sub

    Private Sub sbProfesor()
        Try
            With frmAltaProfesor
                .Parent = Me.splPanel
                .TopLevel = False
                .Dock = DockStyle.Fill
                '.Location = New Point(240, 0)
                .BringToFront()
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdDivision_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles cmdDivision.Click
        sbDivision()
    End Sub

    Private Sub sbDivision()
        Try
            With frmDivision
                .Parent = Me.splPanel
                .TopLevel = False
                '.Dock = DockStyle.Fill
                .Location = New Point(300, 120)
                .BringToFront()
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCarreras_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles cmdCarreras.Click
        sbCarreras()
    End Sub

    Private Sub sbCarreras()
        Try
            With frmCarreras
                .Parent = Me.splPanel
                .TopLevel = False
                '.Dock = DockStyle.Fill
                .Location = New Point(300, 120)
                .BringToFront()
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class

