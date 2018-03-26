Option Strict On
Option Explicit On
Imports MySql.Data.MySqlClient
Public Class frmPersonas


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

  
End Class
