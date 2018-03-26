Option Strict On
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Public Class frmAltaProfesor
    Dim sNombre, sPaterno, sMaterno, sDivision As String
    Dim iCodDivision As Integer
    Dim cServ As New cServidor
    Private Sub frmAltaGrupos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sbCargarTemaForma(True)
        sbCargarDivisiones()
    End Sub

    Private Sub sbCargarDivisiones()
        Try
            cServ.fnConectar()
            cServ.sbConsultar_Divisiones()
            cboDivision.Items.Clear()
            While cServ.myReader.Read
                sDivision = CStr(cServ.myReader("Division"))
                iCodDivision = CInt(cServ.myReader("iCodDivision"))
                cboDivision.Items.Add(New VB6.ListBoxItem(sDivision, iCodDivision))
            End While
            ' cboProfesor.SelectedIndex = 0
            cboDivision.Text = "División..."
            cServ.sbDesconectar()
        Catch ex As Exception
        End Try
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

    Private Sub cboDivision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDivision.KeyPress, cboDivision.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        ElseIf e.KeyChar = """" Then
            e.Handled = True
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
        'If iCodDivision = 0 Then
        '    frmPrincipal.sbMensaje("CAMPO VACIO", "ERROR", piMessageError, "")
        '    cboDivision.Focus()
        '    fnValidarDatos = False
        '    Exit Function
        'End If
        
    End Function
    Private Sub sbEstablecerValores()
        sNombre = Trim$(txtNombre.Text)
        sPaterno = Trim$(txtPaterno.Text)
        sMaterno = Trim$(txtMaterno.Text)
        iCodDivision = 0
        cServ.fnConectar()
        cServ.sbInsertarProfesor(sNombre, sPaterno, sMaterno, iCodDivision)
        cServ.sbDesconectar()
        sbLimpiar()
        frmPrincipal.sbMensaje("PROFESOR GUARDADO CORRECTAMENTE", "INFO", piMessageInfo, "")
    End Sub

    Private Sub sbLimpiar()
        txtNombre.Text = ""
        txtPaterno.Text = ""
        txtMaterno.Text = ""
        sbCargarDivisiones()
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectedIndexChanged
        Dim lstboxItem As VB6.ListBoxItem
        'lblProfesor.Visible = False
        Try
            lstboxItem = CType(cboDivision.SelectedItem, VB6.ListBoxItem)
            iCodDivision = CInt(lstboxItem.ItemData)
            sDivision = CStr(lstboxItem.ItemString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPaterno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaterno.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        ElseIf e.KeyChar = """" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMaterno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaterno.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        ElseIf e.KeyChar = """" Then
            e.Handled = True
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
End Class

