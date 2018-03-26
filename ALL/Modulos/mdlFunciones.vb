
Module mdlFunciones
    Public Const piMessagePregunta = 1
    Public Const piMessagePrecaucion = 2
    Public Const piMessageError = 3
    Public Const piMessageInfo = 4
    Public pbCancelar As Boolean
    Public pbMessageRetorno As Boolean



    Public Sub sbCargarTemaForma(ByVal bBlurImage As Boolean)
        If bBlurImage = True Then
            frmPrincipal.splPanel.BackgroundImage = My.Resources.Skins.PANTHER_11_B
        Else
            frmPrincipal.splPanel.BackgroundImage = My.Resources.Skins.PANTHER_11
        End If
    End Sub
End Module


