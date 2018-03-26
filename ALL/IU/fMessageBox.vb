Public Class fMessageBox
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        pbCancelar = True
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        pbMessageRetorno = False
        pbCancelar = False
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        pbMessageRetorno = True
        pbCancelar = False
        Me.Close()
    End Sub

    Public Sub sbMensaje(ByVal sMensaje As String, ByVal sTitulo As String, ByVal iTipoError As Single, ByVal sTextoOpcional As String)
        Dim sTexttoOpcionalOpt As String
        sTexttoOpcionalOpt = sTextoOpcional

        lblTitulo.Text = sTitulo
        lblMensaje.Text = sMensaje
        Select Case iTipoError
            Case 1 'PREGUNTA
                lblTitulo.ForeColor = Color.DarkGray
                lblMensaje.ForeColor = Color.DarkGray
                pnlImagen.BackgroundImage = My.Resources.Skins.GE_Message_Pregunta_60x55
                recCancelar.Visible = True
                cmdCancelar.Visible = True
                cmdCancelar.BringToFront()
            Case 2 'PRECAUCION
                lblTitulo.ForeColor = Color.DarkGray
                lblMensaje.ForeColor = Color.Crimson
                cmdCancelar.Visible = False
                recCancelar.Visible = False
                pnlImagen.BackgroundImage = My.Resources.Skins.GE_Message_Precaucion_60x55
            Case 3 'ERROR
                lblTitulo.ForeColor = Color.DarkGray
                lblMensaje.ForeColor = Color.Black
                cmdCancelar.Visible = False
                recCancelar.Visible = False
                pnlImagen.BackgroundImage = My.Resources.Skins.GE_Message_Error_60x55
            Case 4 'INFORMACION
                lblTitulo.ForeColor = Color.DarkGray
                lblMensaje.ForeColor = Color.SteelBlue
                cmdCancelar.Visible = False
                recCancelar.Visible = False
                pnlImagen.BackgroundImage = My.Resources.Skins.GE_Message_Informacion_60x55
        End Select
    End Sub

    Private Sub fMessageBox_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Me.Opacity = 0.9
        'Me.BackColor = poColorFuente
    End Sub

    Private Sub fMessageBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbCancelar = False
        pbMessageRetorno = False
    End Sub

    
End Class