Option Strict On
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Public Class frmCarreras
    Dim sNombre, sPaterno, sMaterno, sDivision As String
    Dim cServ As New cServidor
    Private Sub frmAltaGrupos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sbCargarTemaForma(True)
    End Sub

    Private Sub lblNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNombre.Click
        txtNombre.Focus()
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

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Dispose()
        sbCargarTemaForma(False)
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
    End Function
    Private Sub sbEstablecerValores()
        sNombre = Trim$(txtNombre.Text)

        cServ.fnConectar()
        cServ.sbInsertarCarrera(sNombre)
        cServ.sbDesconectar()
        sbLimpiar()
        frmPrincipal.sbMensaje("CARRERA GUARDADA CORRECTAMENTE", "INFO", piMessageInfo, "")
    End Sub

    Private Sub sbLimpiar()
        txtNombre.Text = ""
    End Sub
End Class

