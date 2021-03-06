Option Strict Off
Option Explicit On
Imports System.IO

<System.Runtime.InteropServices.ProgId("clsAfiliado_NET.clsAfiliado")> Public Class clsAfiliado

    Dim comConsultarHistorial As ADODB.Command
    Dim comActualizarHistorial As ADODB.Command
    Dim comBuscaPaciente As ADODB.Command
    Dim comBuscaDetallePaciente As ADODB.Command
    Dim comInsertarPaciente As ADODB.Command
    Dim comInsertarDetallePaciente As ADODB.Command
    Dim comObtenerFolio As ADODB.Command
    Dim comActualizarFolio As ADODB.Command
    Dim comMedico As ADODB.Command
    Dim comRazas As ADODB.Command
    Dim comColor As ADODB.Command
    Dim comEspecies As ADODB.Command
    Dim comCiudad As ADODB.Command
    Dim comActualizarPaciente As ADODB.Command
    Dim comActualizarDetallePaciente As ADODB.Command
    Dim comEliminarPaciente As ADODB.Command
    Dim comAlimentos As ADODB.Command
    Dim comCartilla As ADODB.Command
    Dim comObtenerImagen As ADODB.Command

    'Propiedades de Principales
    Public iCodPaciente As Short

    'Catálogo de Ciudades y Estados
    Public iCodCiudad As Short
    Public vchCatCiudad As String
    Public vchCatEstado As String

    'Propiedades Consulta Externa
    Public vchChip As String
    Public vchNombreP As String
    Public vchPaterno As String
    Public vchMaterno As String
    Public iCodRaza As Integer
    Public iCodColor As Integer
    Public vchRaza As String
    Public vchDescripcionRaza As String
    Public vchNombre As String
    Public vchColor As String
    Public vchDescripcionColor As String
    Public vchTipo As String
    Public vchEstatus As String
    Public vchSexo As String
    Public dtFecNacimiento As String
    Public iCodEstatus As Short
    Public dtFecha As String
    Public vchObservaciones As String
    Public vchMotivo As String
    Public iNumFolio As Integer
    Public iCodFolio As Integer
    Public vchFolio As String
    Public bCastrado As Boolean
    Public iEnvioCloud As Integer
    Public dNoExpediente As Double

    'Propiedades de Detalle Afiliado
    Public vchDireccion As String
    Public vchColonia As String
    Public vchTelefono As String
    Public vchTelefono2 As String
    Public vchCiudad As String
    Public vchEstado As String
    Public vchCP As String
    Public vchAlergia As String
    Public vchTipoSanguineo As String
    Public vchCorreo As String
    Public iCodPropietario As Integer
    Public vchRFC As String
    'Public vchPregunta3 As String

    'Propiedades del Médico
    Dim rs As ADODB.Recordset
    Public iCodMedicoM As Short
    Public vchNombreM As String
    Public vchPaternoM As String
    Public vchMaternoM As String
    Public vchDomicilioM As String
    Public vchColoniaM As String
    Public vchTelefonoM As String
    Public vchCPM As String
    Public vchCiudadM As String
    Public vchEstadoM As String
    Public vchCelularM As String
    Public vchTelRadioM As String
    Public vchPinM As String
    Public vchCedulaM As String
    Public vchUsuario As String
    Public vchPassword As String
    Public iCodResponsable As Short
    Public vchPasswordResp As String
    Public bEstatusM As Boolean
    Public iiConosM As Integer
    Public bMosaicoM As Boolean
    Public bMostrarDock As Boolean
    Public iTipoBarraDock As Short
    Public bLibre As Boolean
    Public bCambiarImagen As Boolean
    Public sProfesion As String
    Public bMedicoResponsable As Boolean
    Public iTipoFondoFast As Integer

    Public bResponsable As Boolean
    Public iTiempoCambiarImagen As Integer
    Public iTipoConfiguracion As Short
    Public vchCorreoM As String
    Public sTiempoCambiarImagen As String
    Public sRutaArchivo As String
    Public sRutaArchivoBlur As String
    Public vchProfesionM As String

    'Propiedades de la Especie
    Public iCodEspecie As Short
    Public vchEspecie As String
    Public vchDescripcionEspecie As String
    Public iEstatus As Short

    'Propiedades de Salida
    Public iFilas As Short
    Public iColumnas As Short
    Public iRetorno As Short
    Public iInicio As Boolean
    Public iFin As Boolean
    Public iLimpio As Boolean
    Public bError As Boolean

    Public bImagen As Byte()
    Public iLongitud As Integer
    Public DT As DataTable
    Public DA As OleDb.OleDbDataAdapter
    Public CMB As OleDb.OleDbCommandBuilder

    Public iTotalVacunas, iTotalDesparasitaciones, iTotalEctos, iTotalAlimentos, iTotalCitas As Integer

    Public iOperacion As Byte
    Public vchValor As String

    'Paciente Activo
    Public bActivo As Boolean

    Public Function comActualizar_Paciente(ByRef iCodPaciente As Integer) As Short
        Dim szSql As String
        Try
            szSql = "UPDATE TranAfiliado SET "
            szSql = szSql & " iCodPaciente = " & CStr(iCodPaciente) & ", "
            szSql = szSql & " vchNombre = '" & vchNombre & "',"
            szSql = szSql & " vchRaza = '" & vchRaza & "',"
            szSql = szSql & " vchColor = '" & vchColor & "',"
            szSql = szSql & " vchSexo = '" & vchSexo & "',"
            szSql = szSql & " dtFecNacimiento = '" & dtFecNacimiento & "',"
            szSql = szSql & " iCodEstatus = " & iCodEstatus & ","
            szSql = szSql & " dtFecha = '" & Today & "', "
            szSql = szSql & " dNoExpediente = '" & dNoExpediente & "'"
            szSql = szSql & " WHERE iCodPaciente = " & CStr(iCodPaciente)

            comActualizarPaciente = New ADODB.Command
            With comActualizarPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With

            rsSysCon = comActualizarPaciente.Execute

            iFilas = rsSysCon.RecordCount

            Exit Function

        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Function

    Public Function comActualizarEstatus_Paciente(ByRef iCodPaciente As Integer) As Short
        Dim szSql As String
        Try
            szSql = "UPDATE TranAfiliado SET "
            szSql = szSql & " iCodPaciente = " & CStr(iCodPaciente) & ", "
            szSql = szSql & " iCodEstatus = " & iCodEstatus & ","
            szSql = szSql & " dtFecha = '" & Today & "'"
            szSql = szSql & " WHERE iCodPaciente = " & CStr(iCodPaciente)

            comActualizarPaciente = New ADODB.Command
            With comActualizarPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With

            rsSysCon = comActualizarPaciente.Execute

            Exit Function

        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Function

    Public Function comActualizarEstatus_Correo(ByRef dtFechaTmp As String, ByVal sFechaFinTmp As String, ByVal iCodPacienteTmp As Integer, ByVal iTipoEnvio As Integer) As Short
        Dim szSql As String
        Dim sDia As String
        sDia = CDate(dtFechaTmp).Day
        Try
            szSql = "UPDATE TranCalendario SET "
            szSql = szSql & " iCodEstado = 1 "
            szSql = szSql & "WHERE iCodPaciente = " & iCodPacienteTmp & " AND CDate(dtFecha) Between CDate('" & dtFechaTmp & "') AND  DateAdd('d', '" & sDia & "', CDate('" & sFechaFinTmp & "')) "
            If iTipoEnvio = 1 Then
                szSql = szSql & "AND iCodServicio <> 7 "
            ElseIf iTipoEnvio = 2 Then
                szSql = szSql & "AND iCodServicio = 7 "
            End If
            comActualizarPaciente = New ADODB.Command
            With comActualizarPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsCorreo = comActualizarPaciente.Execute
            Exit Function

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "FALLO EN ACTUALIZACION DE CORREO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Function

    Public Function comEliminar_Paciente(ByRef iCodPaciente As Integer) As Short
        Dim szSql As String
        Try
            '**************** ELIMINAR VACUNAS *****************************************************
            szSql = "DELETE * FROM TranRegistroVacunas WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente = New ADODB.Command
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR ECTOPARASITOS ***********************************************
            szSql = "DELETE * FROM TranHecto WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR DESPARASITACION *********************************************
            szSql = "DELETE * FROM TranDesparacitacion WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR AGENDA ******************************************************
            szSql = "DELETE * FROM TranCalendario WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR RECETAS ******************************************************
            szSql = "DELETE * FROM TranServicioReceta WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR INFORME MEDICO ***********************************************
            szSql = "DELETE * FROM TranInformeMedico WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR ESTETICAS ****************************************************
            szSql = "DELETE * FROM TranAgendaEstetica WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR ALIMENTOS ****************************************************
            szSql = "DELETE * FROM TranAlimentos WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR EXAMENES *****************************************************
            szSql = "DELETE * FROM TranExamenes WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR HISTORIA CLINICA *********************************************
            szSql = "DELETE * FROM Tran_HC_Ingreso WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            'Antecedentes Familiares
            szSql = "DELETE * FROM Tran_HC_AntecedentesFamiliares WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            'Antecedentes Personales
            szSql = "DELETE * FROM Tran_HC_AntecedentesPersonales WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            'Inmunizaciones
            szSql = "DELETE * FROM Tran_HC_Inmunizaciones WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            'Desarrollo
            szSql = "DELETE * FROM Tran_HC_Desarrollo WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            'Habitacion
            szSql = "DELETE * FROM Tran_HC_Habitacion WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            'ExploracionFisica
            szSql = "DELETE * FROM Tran_HC_ExploracionFisica WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            'Diagnosticos
            szSql = "DELETE * FROM Tran_HC_Diagnosticos WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** STAT GROWTH CHART ********************************************************
            szSql = "DELETE * FROM TranStatGrowthChart_SGC WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            'TranCorreos
            '**************** ELIMINAR CORREOS **********************************************************
            szSql = "DELETE * FROM TranCorreos WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR OTROS SERVICIOS **************************************************
            szSql = "DELETE * FROM TranOtrosServicios WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR CUENTA CLIENTE ***************************************************
            szSql = "DELETE * FROM TranCuentasClientes WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR TranAbonosCuentasClientes ***************************************************
            szSql = "DELETE * FROM TranAbonosCuentasClientes WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR TranCentroNotificaciones ***************************************************
            szSql = "DELETE * FROM TranCentroNotificaciones WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR TranCorreosPromociones ***************************************************
            szSql = "DELETE * FROM TranCorreosPromociones WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR TranDetalleHospitalizacion ***************************************************
            szSql = "DELETE * FROM TranDetalleHospitalizacion WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR TranHospitalizacion ***************************************************
            szSql = "DELETE * FROM TranHospitalizacion WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR TranPension ***************************************************
            szSql = "DELETE * FROM TranPension WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR TranStatGrowthChart ***************************************************
            szSql = "DELETE * FROM TranStatGrowthChart_SGC WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR PROPIETARIO ***************************************************
            szSql = "DELETE * FROM TranDetalleAfiliado WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            '**************** ELIMINAR PACIENTE ******************************************************
            szSql = "DELETE * FROM TranAfiliado WHERE iCodPaciente = " & iCodPaciente
            comEliminarPaciente = New ADODB.Command
            comEliminarPaciente.let_ActiveConnection(cnSysCon)
            comEliminarPaciente.CommandText = szSql
            rsSysCon = comEliminarPaciente.Execute

            comEliminar_Paciente = iRetorno
            Exit Function
        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Function

    Public Function comActualizar_Detalle_Paciente(ByRef iCodPaciente As Integer) As Short
        Dim szSql As String
        Try
            szSql = "SELECT iCodPropietario FROM TranDetalleAfiliado "
            szSql = szSql & " WHERE iCodPaciente = " & CStr(iCodPaciente)

            comActualizarDetallePaciente = New ADODB.Command
            With comActualizarDetallePaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comActualizarDetallePaciente.Execute
            iCodPropietario = rsSysCon.Fields("iCodPropietario").Value

            szSql = "SELECT COUNT(iCodPropietario) as iTotal FROM TranDetalleAfiliado "
            szSql = szSql & " WHERE iCodPropietario = " & iCodPropietario

            comActualizarDetallePaciente = New ADODB.Command
            With comActualizarDetallePaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comActualizarDetallePaciente.Execute

            iFilas = rsSysCon.Fields("iTotal").Value

            If iFilas = 1 Then
                szSql = "UPDATE TranDetalleAfiliado SET"
                szSql = szSql & " vchNombre = '" & vchNombreP & "',"
                szSql = szSql & " vchPaterno = '" & vchPaterno & "',"
                szSql = szSql & " vchMaterno = '" & vchMaterno & "',"
                szSql = szSql & " vchDireccion = '" & vchDireccion & "',"
                szSql = szSql & " vchColonia = '" & vchColonia & "',"
                szSql = szSql & " vchTelefono = '" & vchTelefono & "',"
                szSql = szSql & " vchTelefono2 = '" & vchTelefono2 & "',"
                szSql = szSql & " vchCiudad = '" & vchCiudad & "',"
                szSql = szSql & " vchEstado = '" & vchEstado & "',"
                szSql = szSql & " vchCorreo = '" & vchCorreo & "',"
                szSql = szSql & " vchCP = '" & vchCP & "'"
                szSql = szSql & " WHERE iCodPaciente = " & CStr(iCodPaciente)
            ElseIf iFilas > 1 Then
                szSql = "UPDATE TranDetalleAfiliado SET"
                szSql = szSql & " vchNombre = '" & vchNombreP & "',"
                szSql = szSql & " vchPaterno = '" & vchPaterno & "',"
                szSql = szSql & " vchMaterno = '" & vchMaterno & "',"
                szSql = szSql & " vchDireccion = '" & vchDireccion & "',"
                szSql = szSql & " vchColonia = '" & vchColonia & "',"
                szSql = szSql & " vchTelefono = '" & vchTelefono & "',"
                szSql = szSql & " vchTelefono2 = '" & vchTelefono2 & "',"
                szSql = szSql & " vchCiudad = '" & vchCiudad & "',"
                szSql = szSql & " vchEstado = '" & vchEstado & "',"
                szSql = szSql & " vchCorreo = '" & vchCorreo & "',"
                szSql = szSql & " vchCP = '" & vchCP & "'"
                szSql = szSql & " WHERE iCodPropietario = " & CStr(iCodPropietario)
            End If

            comActualizarDetallePaciente = New ADODB.Command
            With comActualizarDetallePaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comActualizarDetallePaciente.Execute
            Exit Function
        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Function

    Public Function comActualizar_Detalle_Paciente_Propietario(ByRef iCodPropietarioAux As Integer) As Short
        Dim szSql As String
        Try
            szSql = "UPDATE TranDetalleAfiliado SET"
            szSql = szSql & " iCodPaciente = " & CStr(iCodPaciente) & ","
            szSql = szSql & " vchNombre = '" & vchNombreP & "',"
            szSql = szSql & " vchPaterno = '" & vchPaterno & "',"
            szSql = szSql & " vchMaterno = '" & vchMaterno & "',"
            szSql = szSql & " vchDireccion = '" & vchDireccion & "',"
            szSql = szSql & " vchColonia = '" & vchColonia & "',"
            szSql = szSql & " vchTelefono = '" & vchTelefono & "',"
            szSql = szSql & " vchTelefono2 = '" & vchTelefono2 & "',"
            szSql = szSql & " vchCiudad = '" & vchCiudad & "',"
            szSql = szSql & " vchEstado = '" & vchEstado & "',"
            szSql = szSql & " vchCorreo = '" & vchCorreo & "',"
            szSql = szSql & " vchCP = '" & vchCP & "'"
            szSql = szSql & " WHERE iCodPropietario = " & CStr(iCodPropietarioAux)

            comActualizarDetallePaciente = New ADODB.Command
            With comActualizarDetallePaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comActualizarDetallePaciente.Execute
            Exit Function
        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Function

    Public Function comActualizar_Correo_Paciente(ByRef iCodPropietarioAux As Integer) As Short
        Dim szSql As String
        Try
            szSql = "UPDATE TranDetalleAfiliado SET"
            szSql = szSql & " vchCorreo = '" & vchCorreo & "'"
            szSql = szSql & " WHERE iCodPropietario = " & iCodPropietarioAux

            comActualizarDetallePaciente = New ADODB.Command
            With comActualizarDetallePaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comActualizarDetallePaciente.Execute
            Exit Function
        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Function

    Public Function comConsultar_Detalle_Afiliado(ByRef iCodPaciente As Integer) As Short
        Dim szSql As String
        Try
            If iCodPaciente <> 0 Then

                szSql = "SELECT t1.iCodPaciente,"
                szSql = szSql & " t1.vchNombre,"
                szSql = szSql & " t1.vchPaterno,"
                szSql = szSql & " t1.vchMaterno,"
                szSql = szSql & " t1.vchDireccion,"
                szSql = szSql & " t1.vchColonia,"
                szSql = szSql & " t1.vchTelefono,"
                szSql = szSql & " t1.vchCiudad,"
                szSql = szSql & " t1.vchEstado,"
                szSql = szSql & " t1.vchCP"

                szSql = szSql & " FROM TranDetalleAfiliado t1"
                szSql = szSql & " WHERE t1.iCodPaciente = " & iCodPaciente

                comBuscaDetallePaciente = New ADODB.Command
                With comBuscaDetallePaciente
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = szSql
                End With

                rsSysCon = comBuscaDetallePaciente.Execute

                If rsSysCon.BOF And rsSysCon.EOF Then
                    iFilas = 0
                    iRetorno = gCONTINUAR
                Else

                    rsSysCon.MoveFirst()

                    iCodPaciente = rsSysCon.Fields(0).Value
                    vchNombreP = rsSysCon.Fields(1).Value
                    vchPaterno = rsSysCon.Fields(2).Value
                    vchMaterno = rsSysCon.Fields(3).Value
                    vchDireccion = rsSysCon.Fields(4).Value
                    vchColonia = rsSysCon.Fields(5).Value
                    vchTelefono = rsSysCon.Fields(6).Value
                    vchCiudad = rsSysCon.Fields(7).Value
                    vchEstado = rsSysCon.Fields(8).Value
                    vchCP = rsSysCon.Fields(9).Value
                    iRetorno = gEXITO
                End If
                iColumnas = rsSysCon.Fields.Count
                iInicio = rsSysCon.BOF
                iFin = rsSysCon.EOF
            End If
            Exit Function

        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Function

    Public Sub comInsertar_Paciente(ByRef iNumFolioAux As Integer)
        Dim szSql As String
        Try
            szSql = "INSERT INTO TranAfiliado (iCodPaciente, iCodMedico, chCodPaciente, vchNombre, vchRaza, vchSexo, vchColor,"
            szSql = szSql & " dtFecNacimiento, iCodEstatus, dtFecha, Longitud, iCodEspecie, vchObservaciones, bActivo, bCastrado, iEnvioCloud, dNoExpediente) SELECT "
            szSql = szSql & iNumFolioAux & ", "
            szSql = szSql & giCodMedico & ", '"
            szSql = szSql & vchChip & "', '"
            szSql = szSql & vchNombre & "', '"
            szSql = szSql & vchRaza & "', '"
            szSql = szSql & vchSexo & "', '"
            szSql = szSql & vchColor & "', '"
            szSql = szSql & dtFecNacimiento & "', "
            szSql = szSql & iCodEstatus & ", '"
            szSql = szSql & Today & "', "
            szSql = szSql & iLongitud & ", "
            szSql = szSql & iCodEspecie & ", '"
            szSql = szSql & vchObservaciones & "', "
            szSql = szSql & bActivo & ", "
            szSql = szSql & bCastrado & ", "
            szSql = szSql & iEnvioCloud & ", '"
            szSql = szSql & dNoExpediente & "'"

            comInsertarDetallePaciente = New ADODB.Command
            With comInsertarDetallePaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comInsertarDetallePaciente.Execute
            bFoto = False
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(" Error :  " & Err.Description & " no.: " & Err.Number, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            iRetorno = gTERMINAR
        End Try
    End Sub

    Public Sub comInsertar_ImagenPaciente(ByVal sArchivo As String)
        Try
            Dim ms2 As New ADODB.Stream
            Dim rs2 As ADODB.Recordset
            rs2 = New ADODB.Recordset
            ms2.Type = ADODB.StreamTypeEnum.adTypeBinary
            ms2.Open()
            ms2.LoadFromFile(sArchivo)
            rs2.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
            rs2.LockType = ADODB.LockTypeEnum.adLockOptimistic
            rs2.Open("SELECT * FROM TranAfiliado WHERE iCodPaciente = " & iCodPaciente, cnSysCon)
            rs2.Fields("Imagen").Value = ms2.Read
            rs2.Update()
            rs2.Close()
            rs2 = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Public Sub comInsertar_PacienteSF(ByRef iNumFolioAux As Integer)
        Dim szSql As String
        Try
            szSql = "INSERT INTO TranAfiliado (iCodPaciente, iCodMedico, chCodPaciente, vchNombre, vchRaza, vchSexo, vchColor,"
            szSql = szSql & " dtFecNacimiento, iCodEstatus, dtFecha, Longitud, iCodEspecie, vchObservaciones, bActivo, bCastrado) SELECT "
            szSql = szSql & iNumFolioAux & ", "
            szSql = szSql & giCodMedico & ", '"
            szSql = szSql & vchChip & "', '"
            szSql = szSql & vchNombre & "', '"
            szSql = szSql & vchRaza & "', '"
            szSql = szSql & vchSexo & "', '"
            szSql = szSql & vchColor & "', '"
            szSql = szSql & dtFecNacimiento & "', "
            szSql = szSql & iCodEstatus & ", '"
            szSql = szSql & Today & "', "
            szSql = szSql & iLongitud & ", "
            szSql = szSql & iCodEspecie & ", '"
            szSql = szSql & vchObservaciones & "', "
            szSql = szSql & bActivo & ", "
            szSql = szSql & bCastrado & ", '"
            szSql = szSql & dNoExpediente & "'"

            comInsertarDetallePaciente = New ADODB.Command
            With comInsertarDetallePaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comInsertarDetallePaciente.Execute
            bFoto = False
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(" Error :  " & Err.Description & " no.: " & Err.Number, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            iRetorno = gTERMINAR
        End Try
    End Sub

    Public Sub comInsertar_Detalle_Paciente(ByRef iCodPacienteAux As Integer)
        Dim szSql As String
        Try
            szSql = "INSERT INTO TranDetalleAfiliado (iCodPaciente, vchNombre, vchPaterno, vchMaterno, vchDireccion,"
            szSql = szSql & " vchColonia, vchTelefono, vchTelefono2, vchCiudad, vchEstado, vchCP, vchCorreo, iCodPropietario,vchRFC) SELECT "
            szSql = szSql & CInt(iCodPacienteAux) & ", '"
            szSql = szSql & vchNombreP & "', '"
            szSql = szSql & vchPaterno & "', '"
            szSql = szSql & vchMaterno & "', '"
            szSql = szSql & vchDireccion & "', '"
            szSql = szSql & vchColonia & "', '"
            szSql = szSql & vchTelefono & "', '"
            szSql = szSql & vchTelefono2 & "', '"
            szSql = szSql & vchCiudad & "', '"
            szSql = szSql & vchEstado & "', '"
            szSql = szSql & vchCP & "', '"
            szSql = szSql & vchCorreo & "', "
            szSql = szSql & CInt(iCodPropietario) & ", '"
            szSql = szSql & vchRFC & "'"

            comInsertarDetallePaciente = New ADODB.Command
            With comInsertarDetallePaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comInsertarDetallePaciente.Execute
            bFoto = False
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(" Error :  " & Err.Description & " no.: " & Err.Number, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            iRetorno = gTERMINAR
        End Try
    End Sub

    Sub comBuscar_Paciente(ByRef sNombre As String, ByRef sRaza As Object, ByRef sColor As String, ByRef iCodPaciente As Integer, ByRef iCodEspecie As Short, ByRef chCodPacienteAux As String)
        Try
            comBuscaPaciente = New ADODB.Command
            'Todos
            If iCodPaciente = 0 Then
                With comBuscaPaciente
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM TranAfiliado " & " WHERE iCodPaciente > 0 AND vchNombre LIKE '" & sNombre & "%' AND vchRaza LIKE '" & sRaza & "%' AND vchColor LIKE '" & sColor & "%'" & " AND iCodEspecie = " & iCodEspecie
                End With
            End If
            'iCodPaciente
            If iCodPaciente <> 0 Then
                With comBuscaPaciente
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM TranAfiliado WHERE iCodPaciente = " & iCodPaciente
                End With
            End If
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Paciente_Color(ByRef sColor As String)
        Try
            comBuscaPaciente = New ADODB.Command
            'Todos
            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT * FROM TranAfiliado " & " WHERE vchColor LIKE '" & sColor & "'"
            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Paciente_Especie(ByRef iCodEspecie As Short)
        Try
            comBuscaPaciente = New ADODB.Command
            'Todos
            If iCodEspecie <> 0 Then
                With comBuscaPaciente
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM TranAfiliado " & " WHERE iCodEspecie = " & iCodEspecie
                End With
            End If

            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Paciente_Raza(ByRef iCodEspecie As Short)
        Try
            comBuscaPaciente = New ADODB.Command
            'Todos
            If iCodEspecie <> 0 Then
                With comBuscaPaciente
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM TranAfiliado " & " WHERE iCodEspecie = " & iCodEspecie & " AND vchRaza LIKE '" & vchRaza & "'"
                End With
            End If

            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function comBuscar_Paciente_Con_Correo_Cita() As Boolean
        Try
            Dim pdtFechaCorreoBefore, pdtFechaCorreoNex As Date
            pdtFechaCorreoBefore = pdtFechaCorreo.AddDays(-30)
            pdtFechaCorreoNex = pdtFechaCorreo.AddDays(+5)

            comBuscaPaciente = New ADODB.Command
            'Todos

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT * FROM TRANCORREOS " & _
                               " WHERE iCodPaciente = " & piCodPaciente & _
                               " AND DATEDIFF('d', dtFecha, '" & Date.Parse(pdtFechaCorreoBefore).Date & "') AND DATEDIFF('d', dtFecha, '" & Date.Parse(pdtFechaCorreoNex).Date & "')"

            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            If iFilas > 0 Then
                comBuscar_Paciente_Con_Correo_Cita = True
            Else
                comBuscar_Paciente_Con_Correo_Cita = False
            End If

            Exit Function
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Sub comBuscar_Paciente_Correo(ByVal iTipoEnvio As Integer)
        Try
            comBuscaPaciente = New ADODB.Command
            'Todos

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TC.dtFecha, TC.iCodServicio, TC.vchServicio, TC.vchTipoMotivo, TC.vchHora, TA.vchNombre , TA.vchRaza, TDA.vchNombre + ' ' + TDA.vchPaterno As vchNombrePropietario, TDA.vchCorreo, Now()  As dtFechaEnvio, TC.iCodCalendario, TDA.vchNombre As vchNombrePro, TDA.vchPaterno, TDA.vchTelefono, TC.iCodEstado, TA.vchSexo " & _
                               " FROM ((TranAfiliado TA " & _
                               " INNER JOIN TranCalendario TC ON TC.iCodPaciente = TA.iCodPaciente) " & _
                               " INNER JOIN TranDetalleAfiliado TDA ON TDA.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE TA.iCodPaciente = " & iCodPaciente & " AND (Len(TDA.vchCorreo) > 5) AND TC.iCodEstado = 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(pdtFechaCorreo).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(pdtFechaCorreo).Date & "') >= 0 "
                If iTipoEnvio = 1 Then

                    .CommandText = .CommandText & "AND TC.iCodServicio <> 7 "
                ElseIf iTipoEnvio = 2 Then
                    .CommandText = .CommandText & "AND TC.iCodServicio = 7 "
                End If
                .CommandText = .CommandText & "ORDER BY TA.iCodPaciente"

            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comCount_Buscar_Paciente_Correo(ByVal iTipoEnvio As Integer)
        Try
            comBuscaPaciente = New ADODB.Command
            'Todos

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT DISTINCT(TA.iCodPaciente) As iCodPaciente " & _
                               " FROM ((TranAfiliado TA " & _
                               " INNER JOIN TranCalendario TC ON TC.iCodPaciente = TA.iCodPaciente) " & _
                               " INNER JOIN TranDetalleAfiliado TDA ON TDA.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE(Len(TDA.vchCorreo) > 5) AND TC.iCodEstado = 0 " & _
                               " AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(pdtFechaCorreo).Date & "')<= 0 " & _
                               " AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(pdtFechaCorreo).Date & "') >= 0 " & _
                               " AND TA.bActivo = True "
                If iTipoEnvio = 1 Then
                    .CommandText = .CommandText & "AND TC.iCodServicio <> 7"
                ElseIf iTipoEnvio = 2 Then
                    .CommandText = .CommandText & "AND TC.iCodServicio = 7"
                End If
            End With
            rsSysCon2 = comBuscaPaciente.Execute
            iFilas = rsSysCon2.RecordCount

            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comCount_Paciente_CorreoSabado(ByVal iTipoEnvio As Integer)
        Try
            Dim pdtFechaCorreoNew As Date
            pdtFechaCorreoNew = pdtFechaCorreo.AddDays(1)
            comBuscaPaciente = New ADODB.Command
            'Todos

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT DISTINCT(TA.iCodPaciente) As iCodPaciente " & _
                               " FROM ((TranAfiliado TA " & _
                               " INNER JOIN TranCalendario TC ON TC.iCodPaciente = TA.iCodPaciente) " & _
                               " INNER JOIN TranDetalleAfiliado TDA ON TDA.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE(Len(TDA.vchCorreo) > 5) AND TC.iCodEstado = 0 " & _
                               " AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(pdtFechaCorreo).Date & "')<= 0 " & _
                               " AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(pdtFechaCorreoNew).Date & "') >= 0 " & _
                               " AND TA.bActivo = True "
                If iTipoEnvio = 1 Then
                    .CommandText = .CommandText & "AND TC.iCodServicio <> 7"
                ElseIf iTipoEnvio = 2 Then
                    .CommandText = .CommandText & "AND TC.iCodServicio = 7"
                End If
            End With
            rsSysCon2 = comBuscaPaciente.Execute
            iFilas = rsSysCon2.RecordCount

            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Correo_Todos_Clientes()
        Try
            comBuscaPaciente = New ADODB.Command
            'Todos

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.vchNombre , TA.vchRaza, TDA.vchNombre + ' ' + TDA.vchPaterno As vchNombrePropietario, TDA.vchNombre As vchNombrePro, TDA.vchCorreo, TDA.vchTelefono, TA.vchSexo " & _
                               " FROM (TranAfiliado TA " & _
                               " INNER JOIN TranDetalleAfiliado TDA ON TDA.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE(Len(TDA.vchCorreo) > 5)" & _
                               " ORDER BY TDA.iCodPaciente "

            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount

            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Correo_Todos_Clientes_Grupos()
        Try
            comBuscaPaciente = New ADODB.Command
            'Todos

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT distinct(TDA.vchCorreo) As vchCorreo " & _
                               " FROM (TranAfiliado TA " & _
                               " INNER JOIN TranDetalleAfiliado TDA ON TDA.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE(Len(TDA.vchCorreo) > 5)" & _
                               " ORDER BY TDA.vchCorreo"

            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Correo_Todos_Clientes_Total()
        Try
            comBuscaPaciente = New ADODB.Command
            'Todos
            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT COUNT(vchCorreo) As iTotal" & _
                               " FROM TranDetalleAfiliado " & _
                               " WHERE (Len(vchCorreo) > 5)"

            End With
            rsSysCon = comBuscaPaciente.Execute

            iFilas = rsSysCon.Fields("iTotal").Value
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Correo_Cliente()
        Try
            comBuscaPaciente = New ADODB.Command
            'Todos

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.vchNombre , TA.vchRaza, TDA.vchNombre + ' ' + TDA.vchPaterno As vchNombrePropietario, TDA.vchCorreo, TDA.vchTelefono, TA.vchSexo " & _
                               " FROM (TranAfiliado TA " & _
                               " INNER JOIN TranDetalleAfiliado TDA ON TDA.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE(Len(TDA.vchCorreo) > 5)" & _
                               " ORDER BY TDA.iCodPaciente "

            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount

            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Paciente_CorreoSabado(ByVal iTipoEnvio As Integer)
        Try
            Dim pdtFechaCorreoNew As Date
            pdtFechaCorreoNew = pdtFechaCorreo.AddDays(1)
            comBuscaPaciente = New ADODB.Command
            'Todos

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TC.dtFecha, TC.iCodServicio, TC.vchServicio, TC.vchTipoMotivo, TC.vchHora, TA.iCodPaciente, TA.vchNombre , TA.vchRaza, TDA.vchNombre + ' ' + TDA.vchPaterno As vchNombrePropietario, TDA.vchCorreo, Now()  As dtFechaEnvio, TC.iCodCalendario, TDA.vchNombre As vchNombrePro, TDA.vchPaterno, TDA.vchTelefono, TC.iCodEstado, TA.vchSexo " & _
                               " FROM ((TranAfiliado TA " & _
                               " INNER JOIN TranCalendario TC ON TC.iCodPaciente = TA.iCodPaciente) " & _
                               " INNER JOIN TranDetalleAfiliado TDA ON TDA.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE TA.iCodPaciente = " & iCodPaciente & " AND (Len(TDA.vchCorreo) > 5) AND TC.iCodEstado = 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(pdtFechaCorreo).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(pdtFechaCorreoNew).Date & "') >= 0 "
                If iTipoEnvio = 1 Then
                    .CommandText = .CommandText & "AND TC.iCodServicio <> 7"
                ElseIf iTipoEnvio = 2 Then
                    .CommandText = .CommandText & "AND TC.iCodServicio = 7"
                End If
                .CommandText = .CommandText & " ORDER BY TC.dtFecha "

            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount

            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Paciente_CorreoData(ByVal dtFechaIni As Date, ByVal dtFechaFin As Date)
        Try
            DareTable = New Data.DataTable
            DareAdapter = Nothing
            DareCommand = Nothing
            DareCommand = New OleDb.OleDbCommand

            With DareCommand
                .Connection = CN
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno as vchNombrePropie, TD.vchTelefono, TD.vchTelefono2, TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TC.vchServicio, TC.vchTipoMotivo, TC.iCodServicio, FORMAT(TC.dtFecha, 'DD MMM YY') As dtFecha" & _
                               " FROM ((TRANAFILIADO TA " & _
                               " INNER JOIN TranCalendario TC ON TC.iCodPaciente = TA.iCodPaciente) " & _
                               " INNER JOIN TranDetalleAfiliado TD ON TD.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE(Len(TD.vchCorreo) > 5) AND TC.iCodEstado = 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaFin).Date & "') >= 0 AND TA.bActivo = True " & _
                               " ORDER BY TC.dtFecha "

            End With
            DareAdapter = New OleDb.OleDbDataAdapter(DareCommand.CommandText, CN)
            DareAdapter.Fill(DareTable)
            DareBinSou.DataSource = DareTable
            frmCorreos.DaRe.DataSource = DareBinSou
            iFilas = DareBinSou.Count
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Paciente_CorreoDataSabado(ByVal dtFechaIni As Date, ByVal dtFechaFin As Date)
        Try
            Dim pdtFechaCorreoNew As Date
            pdtFechaCorreoNew = pdtFechaCorreo.AddDays(1)
            comBuscaPaciente = New ADODB.Command

            DareTable = New Data.DataTable
            DareAdapter = Nothing
            DareCommand = Nothing
            DareCommand = New OleDb.OleDbCommand

            With DareCommand
                .Connection = CN
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno as vchNombrePropie, TD.vchTelefono, TD.vchTelefono2, TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TC.vchServicio, TC.vchTipoMotivo, TC.iCodServicio, FORMAT(TC.dtFecha, 'DD MMM YY') As dtFecha " & _
                               " FROM ((TRANAFILIADO TA " & _
                               " INNER JOIN TranCalendario TC ON TC.iCodPaciente = TA.iCodPaciente) " & _
                               " INNER JOIN TranDetalleAfiliado TD ON TD.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE(Len(TD.vchCorreo) > 5) AND TC.iCodEstado = 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(pdtFechaCorreoNew).Date & "') >= 0 AND TA.bActivo = True " & _
                               " ORDER BY TC.dtFecha "

            End With
            DareAdapter = New OleDb.OleDbDataAdapter(DareCommand.CommandText, CN)
            DareAdapter.Fill(DareTable)
            DareBinSou.DataSource = DareTable
            frmCorreos.DaRe.DataSource = DareBinSou
            iFilas = DareBinSou.Count
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_CorreosEnviados(ByVal dtFechaIni As Date, ByVal dtFechaFin As Date)
        Try
            DareTable = New Data.DataTable
            DareAdapter = Nothing
            DareCommand = Nothing
            DareCommand = New OleDb.OleDbCommand

            With DareCommand
                .Connection = CN
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TC.vchPaciente AS vchNombreAfi, TC.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TC.vchNombre + ' ' + TC.vchPaterno + ' ' as vchNombrePropie, TC.vchTelefono, TA.iCodEspecie, " & _
                               " TA.iCodEstatus, TC.vchCorreo, TA.vchObservaciones, TC.vchNombre, TC.vchPaterno, TC.vchServicio, TC.vchDescripcionServicio As vchTipoServicio, TC.iCodServicio, FORMAT(TC.dtFecha, 'DD MMM YY') As dtFecha, FORMAT(TC.dtFechaEnvio, 'DD MMM YY') As dtFechaEnvio " & _
                               " FROM (TRANCORREOS TC " & _
                               " INNER JOIN TRANAFILIADO TA ON TC.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaFin).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "') >= 0 " & _
                               " ORDER BY TC.dtFecha "

            End With
            DareAdapter = New OleDb.OleDbDataAdapter(DareCommand.CommandText, CN)
            DareAdapter.Fill(DareTable)
            DareBinSou.DataSource = DareTable
            frmCorreos.DaRe.DataSource = DareBinSou
            iFilas = DareBinSou.Count
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_CorreosEnviadosSabado(ByVal dtFechaIni As Date, ByVal dtFechaFin As Date)
        Try
            Dim pdtFechaCorreoNew As Date
            pdtFechaCorreoNew = pdtFechaCorreo.AddDays(1)

            DareTable = New Data.DataTable
            DareAdapter = Nothing
            DareCommand = Nothing
            DareCommand = New OleDb.OleDbCommand

            With DareCommand
                .Connection = CN
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TC.vchPaciente AS vchNombreAfi, TC.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TC.vchNombre + ' ' + TC.vchPaterno + ' ' as vchNombrePropie, TC.vchTelefono, TA.iCodEspecie, " & _
                               " TA.iCodEstatus, TC.vchCorreo, TA.vchObservaciones, TC.vchNombre, TC.vchPaterno, TC.vchServicio, TC.vchDescripcionServicio As vchTipoServicio, TC.iCodServicio, FORMAT(TC.dtFecha, 'DD MMM YY') As dtFecha, FORMAT(TC.dtFechaEnvio, 'DD MMM YY') As dtFechaEnvio " & _
                               " FROM (TRANCORREOS TC " & _
                               " INNER JOIN TRANAFILIADO TA ON TC.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(pdtFechaCorreoNew).Date & "') >= 0 " & _
                               " ORDER BY TC.dtFecha "

            End With
            DareAdapter = New OleDb.OleDbDataAdapter(DareCommand.CommandText, CN)
            DareAdapter.Fill(DareTable)
            DareBinSou.DataSource = DareTable
            frmCorreos.DaRe.DataSource = DareBinSou
            iFilas = DareBinSou.Count
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Citas(ByVal dtFechaIni As Date, ByVal dtFechaFin As Date, ByVal vchNombreTmp As String, ByVal vchPropietarioTmp As String)
        Try
            comBuscaPaciente = New ADODB.Command
            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno + ' ' as vchNombrePropie, TD.vchTelefono, TA.iCodEspecie, " & _
                               " TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TC.vchServicio, TC.vchTipoMotivo, TC.iCodServicio, TC.dtFecha, TD.vchDireccion, TD.vchColonia, TD.vchTelefono2, TC.iCodCalendario, TC.vchHora, TC.dtFechaFin " & _
                               " FROM ((TRANCALENDARIO TC " & _
                               " INNER JOIN TRANAFILIADO TA ON TC.iCodPaciente = TA.iCodPaciente) " & _
                               " INNER JOIN TranDetalleAfiliado TD ON TD.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaFin).Date & "') >= 0 AND TA.vchNombre LIKE '" & vchNombreTmp & "%' AND TD.vchNombre LIKE '" & vchPropietarioTmp & "%'" & _
                               " ORDER BY TC.dtFecha "

            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Citas_Agenda(ByVal dtFechaIni As Date, ByVal dtFechaFin As Date, ByVal vchNombreTmp As String, ByVal vchPropietarioTmp As String)
        Try
            comBuscaPaciente = New ADODB.Command
            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno + ' ' as vchNombrePropie, TD.vchTelefono, TA.iCodEspecie, " & _
                               " TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TC.vchServicio, TC.vchTipoMotivo, TC.iCodServicio, TC.dtFecha, TD.vchDireccion, TD.vchColonia, TD.vchTelefono2, TC.iCodCalendario, TC.vchHora, TC.dtFechaFin, TD.iCodPropietario, TA.bActivo " & _
                               " FROM ((TRANCALENDARIO TC " & _
                               " INNER JOIN TRANAFILIADO TA ON TC.iCodPaciente = TA.iCodPaciente) " & _
                               " INNER JOIN TranDetalleAfiliado TD ON TD.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaFin).Date & "') >= 0 AND TA.vchNombre LIKE '" & vchNombreTmp & "%' AND TD.vchNombre LIKE '" & vchPropietarioTmp & "%'" & _
                               " ORDER BY TC.dtFecha "

            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Citas_Agenda_Dare(ByVal dtFechaIni As Date, ByVal dtFechaFin As Date, ByVal vchNombreTmp As String, ByVal vchPropietarioTmp As String)
        Try
            DareTable = New Data.DataTable
            DareAdapter = Nothing
            DareCommand = Nothing
            DareCommand = New OleDb.OleDbCommand

            With DareCommand
                .Connection = CN
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno + ' ' as vchNombrePropie, TD.vchTelefono, TA.iCodEspecie, " & _
                               " TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TC.vchServicio, TC.vchTipoMotivo, TC.iCodServicio, TC.dtFecha, TD.vchDireccion, TD.vchColonia, TD.vchTelefono2, TC.iCodCalendario, TC.vchHora, TC.dtFechaFin, TD.iCodPropietario, TA.bActivo " & _
                               " FROM ((TRANCALENDARIO TC " & _
                               " INNER JOIN TRANAFILIADO TA ON TC.iCodPaciente = TA.iCodPaciente) " & _
                               " INNER JOIN TranDetalleAfiliado TD ON TD.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaFin).Date & "') >= 0 AND TA.vchNombre LIKE '" & vchNombreTmp & "%' AND TD.vchNombre LIKE '" & vchPropietarioTmp & "%'" & _
                               " ORDER BY TC.dtFecha "

            End With
            DareAdapter = New OleDb.OleDbDataAdapter(DareCommand.CommandText, CN)
            DareAdapter.Fill(DareTable)
            DareBinSou.DataSource = DareTable
            frmAgenda.DaRe.DataSource = DareBinSou
            iFilas = DareBinSou.Count
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub comBuscar_PacienteAddGrid(ByRef sNombre As String, ByRef sPaterno As String, ByVal sNombrePro As String)
        Try
            comBuscaPaciente = New ADODB.Command

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno As vchNombrePropie, TD.vchTelefono, TD.vchTelefono2, TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.iCodPropietario" & _
                                 " FROM TRANAFILIADO TA " & _
                                 " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                                 " WHERE TA.vchNombre LIKE '" & sNombre & "%' AND TD.vchPaterno LIKE '" & sPaterno & "%' AND TD.vchNombre LIKE '" & sNombrePro & "%' ORDER BY TD.iCodPropietario"
            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub comBuscar_Pacientes_Propietarios(ByVal iCodPropietarioAux As Integer)
        Try
            comBuscaPaciente = New ADODB.Command

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, " & _
                                "TD.vchNombre + ' ' + TD.vchPaterno As vchNombrePropie, TD.vchTelefono, TD.vchTelefono2, TA.iCodEspecie, TD.vchDireccion, " & _
                                "TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.iCodPropietario " & _
                                "FROM TRANAFILIADO TA " & _
                                "INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                                "WHERE(TD.iCodPropietario = " & iCodPropietarioAux & ")"
            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function comBuscar_Pacientes_Total_Familia(ByVal iCodPropietarioAux As Integer) As Integer
        Try
            comBuscaPaciente = New ADODB.Command

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT COUNT(iCodPropietario) As iCodTotalFamilia" & _
                                " FROM TRANDETALLEAFILIADO  WHERE iCodPropietario = " & iCodPropietarioAux
            End With
            rsSysCon2 = comBuscaPaciente.Execute

            If rsSysCon2.EOF = False Then
                comBuscar_Pacientes_Total_Familia = rsSysCon2.Fields("iCodTotalFamilia").Value
            Else
                comBuscar_Pacientes_Total_Familia = 0
            End If
            Exit Function
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub comBuscar_CitasInfografica_Totales(ByVal dtFechaIni As Date, ByVal dtFechaFin As Date, ByVal vchNombreTmp As String, ByVal vchPropietarioTmp As String)
        Try
            comBuscaPaciente = New ADODB.Command
            comBuscaPaciente.let_ActiveConnection(cnSysCon)
            comBuscaPaciente.CommandText = "SELECT COUNT(TC.iCodServicio) As iTotalVacunas FROM ((TRANCALENDARIO TC " & _
                               " INNER JOIN TRANAFILIADO TA ON TC.iCodPaciente = TA.iCodPaciente) INNER JOIN TranDetalleAfiliado TD ON TD.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaFin).Date & "') >= 0 " & _
                               " AND TC.iCodServicio = 1 AND TA.vchNombre LIKE '" & vchNombreTmp & "%' AND TD.vchNombre LIKE '" & vchPropietarioTmp & "%'"
            rsSysCon2 = comBuscaPaciente.Execute
            iTotalVacunas = rsSysCon2.Fields("iTotalVacunas").Value

            comBuscaPaciente.CommandText = "SELECT COUNT(TC.iCodServicio) As iTotalDesparasitaciones FROM ((TRANCALENDARIO TC " & _
                               " INNER JOIN TRANAFILIADO TA ON TC.iCodPaciente = TA.iCodPaciente) INNER JOIN TranDetalleAfiliado TD ON TD.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaFin).Date & "') >= 0 " & _
                               " AND TC.iCodServicio = 2 AND TA.vchNombre LIKE '" & vchNombreTmp & "%' AND TD.vchNombre LIKE '" & vchPropietarioTmp & "%'"
            rsSysCon2 = comBuscaPaciente.Execute
            iTotalDesparasitaciones = rsSysCon2.Fields("iTotalDesparasitaciones").Value


            comBuscaPaciente.CommandText = "SELECT COUNT(TC.iCodServicio) As iTotalEctos FROM ((TRANCALENDARIO TC " & _
                               " INNER JOIN TRANAFILIADO TA ON TC.iCodPaciente = TA.iCodPaciente) INNER JOIN TranDetalleAfiliado TD ON TD.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaFin).Date & "') >= 0 " & _
                               " AND TC.iCodServicio = 3 AND TA.vchNombre LIKE '" & vchNombreTmp & "%' AND TD.vchNombre LIKE '" & vchPropietarioTmp & "%'"
            rsSysCon2 = comBuscaPaciente.Execute
            iTotalEctos = rsSysCon2.Fields("iTotalEctos").Value

            comBuscaPaciente.CommandText = "SELECT COUNT(TC.iCodServicio) As iTotalCitas FROM ((TRANCALENDARIO TC " & _
                               " INNER JOIN TRANAFILIADO TA ON TC.iCodPaciente = TA.iCodPaciente) INNER JOIN TranDetalleAfiliado TD ON TD.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaFin).Date & "') >= 0 " & _
                               " AND TC.iCodServicio = 4 AND TA.vchNombre LIKE '" & vchNombreTmp & "%' AND TD.vchNombre LIKE '" & vchPropietarioTmp & "%'"
            rsSysCon2 = comBuscaPaciente.Execute
            iTotalCitas = rsSysCon2.Fields("iTotalCitas").Value

            comBuscaPaciente.CommandText = "SELECT COUNT(TC.iCodServicio) As iTotalAlimentos FROM ((TRANCALENDARIO TC " & _
                               " INNER JOIN TRANAFILIADO TA ON TC.iCodPaciente = TA.iCodPaciente) INNER JOIN TranDetalleAfiliado TD ON TD.iCodPaciente = TA.iCodPaciente) " & _
                               " WHERE DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaIni).Date & "')<= 0 AND DATEDIFF('d', TC.dtFecha, '" & Date.Parse(dtFechaFin).Date & "') >= 0 " & _
                               " AND TC.iCodServicio = 5 AND TA.vchNombre LIKE '" & vchNombreTmp & "%' AND TD.vchNombre LIKE '" & vchPropietarioTmp & "%'"
            rsSysCon2 = comBuscaPaciente.Execute
            iTotalAlimentos = rsSysCon2.Fields("iTotalAlimentos").Value

            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_PacienteGrid(ByRef sNombre As String, ByRef sRaza As String)
        Try
            comBuscaPaciente = New ADODB.Command

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.vchTelefono, TD.vchTelefono2,TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.iCodPropietario, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno As vchNombreCompleto " & _
                               " FROM TRANAFILIADO TA " & _
                               " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                               " WHERE TA.vchNombre LIKE '" & sNombre & "%' AND TA.vchRaza LIKE '" & sRaza & "%'"

                '            .CommandText = "SELECT iCodPaciente, Imagen, vchNombre, vchRaza, vchSexo, vchColor, dtFecNacimiento FROM TranAfiliado " & " WHERE vchNombre LIKE '" & sNombre & "%' AND vchRaza LIKE '" & sRaza & "%'"
            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_PacienteUsuarioGrid(ByRef sNombre As String, ByRef sRaza As String, ByVal sNombrePro As String)
        Try
            comBuscaPaciente = New ADODB.Command

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.vchTelefono, TD.vchTelefono2,TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.iCodPropietario, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno As vchNombreCompleto " & _
                               " FROM TRANAFILIADO TA " & _
                               " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                               " WHERE TA.vchNombre LIKE '" & sNombre & "%' AND TA.vchRaza LIKE '" & sRaza & "%' AND TD.vchNombre LIKE '" & sNombrePro & "%' ORDER BY TD.iCodPropietario"
            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_PacienteGrid_Con_Mail(ByRef sNombre As String, ByRef sRaza As String, ByVal sCorreo As String, ByVal iCodEspecieTmp As Integer, ByVal bEspecieActivo As Boolean)
        Try
            Dim sAux As String
            If bEspecieActivo = True Then
                sAux = " AND TA.iCodEspecie LIKE '" & iCodEspecieTmp & "%'"
            Else
                sAux = ""
            End If
            comBuscaPaciente = New ADODB.Command
            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.iCodEspecie AS iCodEspecie, TA.Imagen, TA.vchNombre AS vchNombreAfi, " & _
                "TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.vchTelefono, " & _
                "TD.vchTelefono2,TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, " & _
                "TA.vchObservaciones, TD.iCodPropietario, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno As vchNombreCompleto " & _
                " FROM TRANAFILIADO TA " & _
                " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                " WHERE TA.vchNombre LIKE '" & sNombre & "%' AND TA.vchRaza LIKE '" & sRaza & "%' " & _
                " AND LEN(TD.vchCorreo) > 5 AND TD.vchCorreo LIKE '" & LCase(sCorreo) & "%'  " & sAux & " " & _
                " AND TA.bActivo = " & True & "" & _
                " ORDER BY TD.vchCorreo"

            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("∞Error N˙mero: (" & Err.Number & ") Descripci€n: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub comBuscar_PacienteGrid_Con_Mail_Grupo(ByRef sNombre As String, ByRef sRaza As String, ByVal sCorreo As String)
        Try
            comBuscaPaciente = New ADODB.Command
            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = " SELECT distinct(TD.vchCorreo) As vchCorreo  " & _
                               " FROM TRANAFILIADO TA " & _
                               " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                               " WHERE TA.vchNombre LIKE '" & sNombre & "%' AND TA.vchRaza LIKE '" & sRaza & "%' AND LEN(TD.vchCorreo) > 5 AND TD.vchCorreo LIKE '" & LCase(sCorreo) & "%'  ORDER BY TD.vchCorreo"
            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_PacienteExpediente(ByVal iCodPacienteTmp As Integer)
        Try
            comBuscaPaciente = New ADODB.Command
            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' +  TD.vchPaterno as vchNombrePropie, TD.vchTelefono, TD.vchTelefono2, TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.iCodPropietario, TA.bActivo, TA.bCastrado, TA.chCodPaciente" & _
                               " FROM TRANAFILIADO TA " & _
                               " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                               " WHERE TA.iCodPaciente = " & iCodPacienteTmp

            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'TODO Revisar esta opción
    Public Function comBuscar_PacienteExistente() As Boolean
        Try
            comBuscaPaciente = New ADODB.Command
            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno As vchNombrePropie, TD.vchTelefono, TD.vchTelefono2, TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TA.dtFecha " & _
                               " FROM TRANAFILIADO TA " & _
                               " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                               " WHERE TA.vchNombre = '" & vchNombre & "'" & _
                               " AND TA.vchRaza = '" & vchRaza & "'" & _
                               " AND TA.bActivo = TRUE" & _
                               " AND TD.vchTelefono = '" & vchTelefono & "'"
            End With
            rsSysCon2 = comBuscaPaciente.Execute
            iFilas = rsSysCon2.RecordCount
            If iFilas > 0 Then
                comBuscar_PacienteExistente = True
            Else
                comBuscar_PacienteExistente = False
            End If
            Exit Function
        Catch ex As Exception
            'MessageBox.Show("°Error N˙mero: (" & Err.Number & ") DescripciÛn: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Sub comBuscar_PacienteData(ByRef sNombre As String, ByRef sRaza As String, ByVal sNombrePro As String)
        Try
            DareTable = New Data.DataTable
            DareAdapter = Nothing
            DareCommand = Nothing
            DareCommand = New OleDb.OleDbCommand

            With DareCommand
                .Connection = CN
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno as vchNombrePropie, TD.vchTelefono, TD.vchTelefono2, TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.iCodPropietario, TA.bActivo, TA.bCastrado, TA.chCodPaciente, TA.dNoExpediente " & _
                               " FROM TRANAFILIADO TA " & _
                               " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                               " WHERE TA.vchNombre LIKE '" & sNombre & "%' AND TA.vchRaza LIKE '" & sRaza & "%' AND TD.vchNombre LIKE '" & sNombrePro & "%' AND TA.iCodPaciente > 0 ORDER BY TD.iCodPropietario"

            End With
            DareAdapter = New OleDb.OleDbDataAdapter(DareCommand.CommandText, CN)
            DareAdapter.Fill(DareTable)
            DareBinSou.Filter = Nothing
            DareBinSou.DataSource = DareTable
            frmBuscarPacientes.DaRe.DataSource = DareBinSou
            iFilas = DareBinSou.Count
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_NoExpedienteData(ByRef dNoExpedienteTmp As Long)
        Try
            DareTable = New Data.DataTable
            DareAdapter = Nothing
            DareCommand = Nothing
            DareCommand = New OleDb.OleDbCommand

            With DareCommand
                .Connection = CN
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno as vchNombrePropie, TD.vchTelefono, TD.vchTelefono2, TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.iCodPropietario, TA.bActivo, TA.bCastrado, TA.chCodPaciente, TA.dNoExpediente " & _
                               " FROM TRANAFILIADO TA " & _
                               " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                               " WHERE TA.dNoExpediente LIKE '" & dNoExpedienteTmp & "%' ORDER BY TA.dNoExpediente "

            End With
            DareAdapter = New OleDb.OleDbDataAdapter(DareCommand.CommandText, CN)
            DareAdapter.Fill(DareTable)
            DareBinSou.Filter = Nothing
            DareBinSou.DataSource = DareTable
            frmBuscarPacientes.DaRe.DataSource = DareBinSou
            iFilas = DareBinSou.Count
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_PacienteFinadoData(ByRef sNombre As String, ByRef sRaza As String, ByVal sNombrePro As String)
        Try
            DareTable = New Data.DataTable
            DareAdapter = Nothing
            DareCommand = Nothing
            DareCommand = New OleDb.OleDbCommand

            With DareCommand
                .Connection = CN
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno as vchNombrePropie, TD.vchTelefono, TD.vchTelefono2, TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.iCodPropietario, TA.bActivo, TA.bCastrado, TA.chCodPaciente, TA.dNoExpediente " & _
                               " FROM TRANAFILIADO TA " & _
                               " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                               " WHERE TA.vchNombre LIKE '" & sNombre & "%' AND TA.vchRaza LIKE '" & sRaza & "%' AND TD.vchNombre LIKE '" & sNombrePro & "%' AND TA.iCodPaciente > 0 AND TA.bActivo = 0 ORDER BY TD.iCodPropietario"

            End With
            DareAdapter = New OleDb.OleDbDataAdapter(DareCommand.CommandText, CN)
            DareAdapter.Fill(DareTable)
            DareBinSou.Filter = Nothing
            DareBinSou.DataSource = DareTable
            frmBuscarPacientes.DaRe.DataSource = DareBinSou
            iFilas = DareBinSou.Count
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_PropietarioData(ByRef sNombre As String, ByRef sPaterno As String, ByVal sNombrePro As String)
        Try
            DareTable = New Data.DataTable
            DareAdapter = Nothing
            DareCommand = Nothing
            DareCommand = New OleDb.OleDbCommand

            With DareCommand
                .Connection = CN
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno as vchNombrePropie, TD.vchTelefono, TD.vchTelefono2, TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.iCodPropietario, TA.chCodPaciente, TA.bCastrado, TA.bActivo, TA.chCodPaciente, TA.dNoExpediente " & _
                                " FROM TRANAFILIADO TA " & _
                                " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                                " WHERE TD.vchNombre LIKE '" & sNombre & "%' AND TD.vchPaterno LIKE '" & sPaterno & "%' AND TA.iCodPaciente > 0 ORDER BY TA.vchNombre"

            End With
            DareAdapter = New OleDb.OleDbDataAdapter(DareCommand.CommandText, CN)
            DareAdapter.Fill(DareTable)
            DareBinSou.Filter = Nothing
            DareBinSou.DataSource = DareTable
            frmBuscarPacientes.DaRe.DataSource = DareBinSou
            iFilas = DareBinSou.Count
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_PropietarioGrid(ByRef sNombre As String, ByRef sPaterno As String)
        Try
            comBuscaPaciente = New ADODB.Command

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.vchTelefono, TD.vchTelefono2,TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.iCodPropietario, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno As vchNombreCompleto " & _
                                " FROM TRANAFILIADO TA " & _
                                " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                                " WHERE TD.vchNombre LIKE '" & sNombre & "%' AND TD.vchPaterno LIKE '" & sPaterno & "%'"
            End With

            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'TODO Integracion 001
    Sub comBuscar_ClienteGrid(ByRef sNombre As String, ByRef sPaterno As String)
        Try
            comBuscaPaciente = New ADODB.Command

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = " SELECT DISTINCT(TD.iCodPropietario) , TD.vchNombre,  TD.vchPaterno, TD.vchDireccion, TD.vchColonia, TD.vchCP, TD.vchTelefono, TD.vchCorreo, TA.vchNombre AS vchNombreAfi " & _
                                " FROM TRANAFILIADO TA " & _
                                " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                                " WHERE TD.vchNombre LIKE '" & sNombre & "%' AND TD.vchPaterno LIKE '" & sPaterno & "%' ORDER BY vchPaterno"
                '                                " FROM TRANDETALLEAFILIADO " & _
                '                                " WHERE vchNombre LIKE '" & sNombre & "%' AND vchPaterno LIKE '" & sPaterno & "%' ORDER BY vchPaterno"

            End With

            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_PacientesDelClienteGrid(ByVal iCodPropietarioTmp As Integer)
        Try
            comBuscaPaciente = New ADODB.Command

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.vchTelefono, TD.vchTelefono2,TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.iCodPropietario, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno As vchNombreCompleto " & _
                                " FROM TRANAFILIADO TA " & _
                                " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                                " WHERE iCodPropietario = " & iCodPropietarioTmp
            End With

            rsSysCon2 = comBuscaPaciente.Execute
            iFilas = rsSysCon2.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_PacientesDelClienteSoloPacientesGrid(ByVal iCodPropietarioTmp As Integer)
        Try
            comBuscaPaciente = New ADODB.Command

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.vchTelefono, TD.vchTelefono2,TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.iCodPropietario, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno As vchNombreCompleto, TA.bActivo, TA.bCastrado, TA.dNoExpediente " & _
                                " FROM TRANAFILIADO TA " & _
                                " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                                " WHERE iCodPropietario = " & iCodPropietarioTmp
            End With

            rsSysCon2 = comBuscaPaciente.Execute
            iFilas = rsSysCon2.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_PropietarioTelefonoGrid(ByRef sTelefono As String)
        Try
            comBuscaPaciente = New ADODB.Command

            With comBuscaPaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.vchTelefono, TD.vchTelefono2,TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.iCodPropietario, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno As vchNombreCompleto " & _
                                " FROM TRANAFILIADO TA " & _
                                " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                                " WHERE TA.iCodPaciente > 0 AND TD.vchTelefono LIKE '" & sTelefono & "%'"
            End With
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_Correo_TelefonoData(ByRef sCorreo As String, ByRef sTelefono As String)
        Try
            DareTable = New Data.DataTable
            DareAdapter = Nothing
            DareCommand = Nothing
            DareCommand = New OleDb.OleDbCommand

            'comBuscaPaciente = New ADODB.Command

            With DareCommand
                .Connection = CN
                .CommandText = "SELECT TA.iCodPaciente, TA.Imagen, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TD.vchNombre + ' ' + TD.vchPaterno + ' ' + TD.vchMaterno as vchNombrePropie, TD.vchTelefono, TD.vchTelefono2, TA.iCodEspecie, TD.vchDireccion, TD.vchColonia, TD.vchCP, TA.iCodEstatus, TD.vchCorreo, TA.vchObservaciones, TD.vchNombre, TD.vchPaterno, TD.vchMaterno, TD.iCodPropietario, TA.chCodPaciente, TA.bCastrado, TA.bActivo " & _
                " FROM TRANAFILIADO TA " & _
                " INNER JOIN TRANDETALLEAFILIADO TD ON TD.iCodPaciente = TA.iCodPaciente " & _
                " WHERE TD.vchCorreo LIKE '" & sCorreo & "%' AND TD.vchTelefono LIKE '" & sTelefono & "%' ORDER BY TD.vchCorreo"
            End With
            DareAdapter = New OleDb.OleDbDataAdapter(DareCommand.CommandText, CN)
            DareAdapter.Fill(DareTable)
            DareBinSou.Filter = Nothing
            DareBinSou.DataSource = DareTable
            frmBuscarPacientes.DaRe.DataSource = DareBinSou
            iFilas = DareBinSou.Count
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comActualizar_NumFolio(ByRef iCodFolio As Integer, ByRef iNumFolioAux As Integer)
        Try
            iNumFolioAux = iNumFolioAux + 1
            comActualizarFolio = New ADODB.Command
            With comActualizarFolio
                .let_ActiveConnection(cnSysCon)
                .CommandText = "UPDATE TranFolio SET iNumFolio = " & iNumFolioAux & " WHERE iCodFolio = " & iCodFolio
            End With
            rsSysCon = comActualizarFolio.Execute

        Catch ex As Exception
            'MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub comInsertar_Medico(ByRef iCodMedico As Short)
        Dim szSql As String
        Try
            szSql = "INSERT INTO CatMedico (iCodEmpresa, iCodMedico, vchNombre ,vchPaterno, vchMaterno, "
            szSql = szSql & "vchDomicilio, vchColonia, vchTelefono, "
            szSql = szSql & "vchCP, vchCiudad, vchEstado, vchCelular, vchTelRadio, "
            szSql = szSql & "vchPin, vchCedula, vchUsuario, vchPassword, iCodResponsable, "
            szSql = szSql & "vchPasswordResp, bEstatus, iiConos, bMosaico, bMostrarDock, vchCorreo, vchRutaArchivo, "
            szSql = szSql & "vchRutaArchivoBlur, vchProfesion, iTipoBarraDock, iTiempoCambiarImagen, "
            szSql = szSql & "iTipoConfiguracion, sTiempoCambiarImagen) SELECT "
            szSql = szSql & piCodEmpresa & ", "
            szSql = szSql & iCodMedico & ", '"
            szSql = szSql & vchNombreM & "', '"
            szSql = szSql & vchPaternoM & "', '"
            szSql = szSql & vchMaternoM & "', '"
            szSql = szSql & vchDomicilioM & "', '"
            szSql = szSql & vchColoniaM & "', '"
            szSql = szSql & vchTelefonoM & "', '"
            szSql = szSql & vchCPM & "', '"
            szSql = szSql & vchCiudadM & "', '"
            szSql = szSql & vchEstadoM & "', '"
            szSql = szSql & vchCelularM & "', '"
            szSql = szSql & vchTelRadioM & "', '"
            szSql = szSql & vchPinM & "', '"
            szSql = szSql & vchCedulaM & "', '"
            szSql = szSql & vchUsuario & "', '"
            szSql = szSql & vchPassword & "', "
            szSql = szSql & iCodResponsable & ", '"
            szSql = szSql & vchPasswordResp & "', "
            szSql = szSql & bEstatusM & ", "
            szSql = szSql & iiConosM & ", "
            szSql = szSql & bMosaicoM & ", "
            szSql = szSql & bMostrarDock & ", '"
            szSql = szSql & vchCorreoM & "', '"
            szSql = szSql & sRutaArchivo & "', '"
            szSql = szSql & sRutaArchivoBlur & "', '"
            szSql = szSql & vchProfesionM & "', "
            szSql = szSql & iTipoBarraDock & ", "
            szSql = szSql & iTiempoCambiarImagen & ", "
            szSql = szSql & iTipoConfiguracion & ", '"
            szSql = szSql & sTiempoCambiarImagen & "'"

            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsMedico = comMedico.Execute
            Exit Sub
        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Sub

    Public Sub comInsertar_Medico_Configuracion(ByRef iCodMedico As Short)
        Dim szSql As String
        Try
            szSql = "INSERT INTO CatMedico (iCodEmpresa, iCodMedico, vchNombre ,vchPaterno, vchMaterno, "
            szSql = szSql & "vchDomicilio, vchColonia, vchTelefono, "
            szSql = szSql & "vchCP, vchCiudad, vchEstado, vchCelular, vchTelRadio, "
            szSql = szSql & "vchPin, vchCedula, vchUsuario, vchPassword, iCodResponsable, "
            szSql = szSql & "vchPasswordResp, bEstatus, iiConos, bMosaico, bMostrarDock, bCambiarImagen, vchProfesion, bMedicoResponsable, iTipoFondoFast,  "
            szSql = szSql & "vchCorreo, vchRutaArchivo, vchRutaArchivoBlur, iTipoBarraDock, iTiempoCambiarImagen, "
            szSql = szSql & "iTipoConfiguracion, sTiempoCambiarImagen) SELECT "
            szSql = szSql & piCodEmpresa & ", "
            szSql = szSql & iCodMedico & ", '"
            szSql = szSql & vchNombreM & "', '"
            szSql = szSql & vchPaternoM & "', '"
            szSql = szSql & vchMaternoM & "', '"
            szSql = szSql & vchDomicilioM & "', '"
            szSql = szSql & vchColoniaM & "', '"
            szSql = szSql & vchTelefonoM & "', '"
            szSql = szSql & vchCPM & "', '"
            szSql = szSql & vchCiudadM & "', '"
            szSql = szSql & vchEstadoM & "', '"
            szSql = szSql & vchCelularM & "', '"
            szSql = szSql & vchTelRadioM & "', '"
            szSql = szSql & vchPinM & "', '"
            szSql = szSql & vchCedulaM & "', '"
            szSql = szSql & vchUsuario & "', '"
            szSql = szSql & vchPassword & "', "
            szSql = szSql & iCodResponsable & ", '"
            szSql = szSql & vchPasswordResp & "', "
            szSql = szSql & bEstatusM & ", "
            szSql = szSql & iiConosM & ", "
            szSql = szSql & bMosaicoM & ", "
            szSql = szSql & bMostrarDock & ", "
            szSql = szSql & bCambiarImagen & ", '"
            szSql = szSql & sProfesion & "', "
            szSql = szSql & bMedicoResponsable & ", "
            szSql = szSql & iTipoFondoFast & ", '"
            szSql = szSql & vchCorreoM & "', '"
            szSql = szSql & sRutaArchivo & "', '"
            szSql = szSql & sRutaArchivoBlur & "', "
            szSql = szSql & iTipoBarraDock & ", "
            szSql = szSql & iTiempoCambiarImagen & ", "
            szSql = szSql & iTipoConfiguracion & ", '"
            szSql = szSql & sTiempoCambiarImagen & "'"

            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsMedico = comMedico.Execute
            Exit Sub
        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Sub


    Public Sub comActualizar_Medico(ByRef iCodMedico As Short)
        Dim szSql As String
        Try
            szSql = "UPDATE CatMedico SET "
            szSql = szSql & " iCodEmpresa = " & piCodEmpresa & ", "
            szSql = szSql & " iCodMedico = " & CStr(iCodMedico) & ", "
            szSql = szSql & " vchNombre = '" & vchNombreM & "',"
            szSql = szSql & " vchPaterno = '" & vchPaternoM & "',"
            szSql = szSql & " vchMaterno = '" & vchMaternoM & "',"
            szSql = szSql & " vchDomicilio = '" & vchDomicilioM & "',"
            szSql = szSql & " vchColonia = '" & vchColoniaM & "',"
            szSql = szSql & " vchTelefono = '" & vchTelefonoM & "',"
            szSql = szSql & " vchCP = '" & vchCPM & "',"
            szSql = szSql & " vchCiudad = '" & vchCiudadM & "',"
            szSql = szSql & " vchEstado = '" & vchEstadoM & "',"
            szSql = szSql & " vchCelular = '" & vchCelularM & "',"
            szSql = szSql & " vchTelRadio = '" & vchTelRadioM & "',"
            szSql = szSql & " vchPin = '" & vchPinM & "',"
            szSql = szSql & " vchCedula = '" & vchCedulaM & "',"
            szSql = szSql & " vchUsuario = '" & vchUsuario & "',"
            szSql = szSql & " vchPassword = '" & vchPassword & "',"
            szSql = szSql & " vchCorreo = '" & vchCorreoM & "',"
            szSql = szSql & " vchProfesion = '" & vchProfesionM & "'"

            szSql = szSql & " WHERE iCodMedico = " & CStr(iCodMedico)

            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsMedico = comMedico.Execute
            Exit Sub
        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Sub

    Public Sub comInsertar_Medico_Foto(ByVal iMagenFotoMedico() As Byte, ByVal iMagenPerfil() As Byte)
        Dim TmpRow As DataRow

        DA = New OleDb.OleDbDataAdapter("Select * from CatMedico where iCodMedico = 0", CN)
        DT = New DataTable
        DA.Fill(DT)
        CMB = New OleDb.OleDbCommandBuilder(DA)
        Try
            If iCodResponsable = 1 Then
                comActualizarResponsable()
            End If
            TmpRow = DT.NewRow
            TmpRow("iCodMedico") = iCodMedicoM
            TmpRow("vchNombre") = vchNombreM
            TmpRow("vchPaterno") = vchPaternoM
            TmpRow("vchMaterno") = vchMaternoM
            TmpRow("vchDomicilio") = vchDomicilioM
            TmpRow("vchColonia") = vchColoniaM
            TmpRow("vchTelefono") = vchTelefonoM
            TmpRow("vchCP") = vchCPM
            TmpRow("vchCiudad") = vchCiudadM
            TmpRow("vchEstado") = vchEstadoM
            TmpRow("vchCelular") = vchCelularM
            TmpRow("vchTelRadio") = vchTelRadioM
            TmpRow("vchPin") = vchPinM
            TmpRow("vchCedula") = vchCedulaM
            TmpRow("vchUsuario") = vchUsuario
            TmpRow("vchPassword") = vchPassword
            TmpRow("iCodResponsable") = iCodResponsable
            TmpRow("vchPasswordResp") = vchPasswordResp
            TmpRow("bEstatus") = bEstatusM
            TmpRow("iiConos") = iiConosM
            TmpRow("bMosaico") = bMosaicoM
            TmpRow("imgFoto") = iMagenFotoMedico
            TmpRow("imgPerfil") = iMagenPerfil
            TmpRow("bMostrarDock") = True
            TmpRow("iTipoBarraDock") = 17
            TmpRow("bCambiarImagen") = False
            TmpRow("iTiempoCambiarImagen") = 60000
            TmpRow("iTipoConfiguracion") = 3
            TmpRow("sTiempoCambiarImagen") = "1 Minuto"
            TmpRow("vchCorreo") = vchCorreoM
            TmpRow("vchRutaArchivo") = sRuta & "\Skins\Large\All\PANTHER_30.jpg"
            TmpRow("vchRutaArchivoBlur") = sRuta & "\Skins\Large\Blur\PANTHER_30.jpg"
            TmpRow("vchProfesion") = vchProfesionM
            TmpRow("bMedicoResponsable") = bResponsable
            TmpRow("iTipoFondoFast") = 0
            TmpRow("iEnvioCloud") = 0
            TmpRow("dNoTransaccionCloud") = 0

            DT.Rows.Add(TmpRow)
            DA.InsertCommand = CMB.GetInsertCommand
            DA.Update(DT)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub comInsertar_Medico_SinFoto(ByRef iNumFolioAux As Integer)
        Dim szSql As String
        Try
            szSql = "INSERT INTO CatMedico (iCodMedico, vchNombre ,vchPaterno, vchMaterno,"
            szSql = szSql & " vchDomicilio, vchColonia, vchTelefono,"
            szSql = szSql & " vchCP, vchCiudad, vchEstado, vchCelular, vchTelRadio, vchPin, vchCedula, vchUsuario, vchPassword, bEstatus, iiConos, bMosaico, vchCorreo, vchProfesion) SELECT "
            szSql = szSql & iCodMedicoM & ", '"
            szSql = szSql & vchNombreM & "', '"
            szSql = szSql & vchPaternoM & "', '"
            szSql = szSql & vchMaternoM & "', '"
            szSql = szSql & vchDomicilioM & "', '"
            szSql = szSql & vchColoniaM & "', '"
            szSql = szSql & vchTelefonoM & "', '"
            szSql = szSql & vchCPM & "', '"
            szSql = szSql & vchCiudadM & "', '"
            szSql = szSql & vchEstadoM & "', '"
            szSql = szSql & vchCelularM & "', '"
            szSql = szSql & vchTelRadioM & "', '"
            szSql = szSql & vchPinM & "', '"
            szSql = szSql & vchCedulaM & "', '"
            szSql = szSql & vchUsuario & "', '"
            szSql = szSql & vchPassword & "', "
            szSql = szSql & bEstatusM & ", "
            szSql = szSql & iiConosM & ", "
            szSql = szSql & bMosaicoM & ", '"
            szSql = szSql & vchCorreoM & "', '"
            szSql = szSql & vchProfesionM & "'"

            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsMedico = comMedico.Execute
            Exit Sub
        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Sub

    Public Function comConsultar_Medico(ByRef iCodMedico As Integer) As Short
        Dim szSql As String
        Try
            If iCodMedico <> 0 Then
                szSql = "SELECT * FROM CatMedico WHERE iCodMedico = " & iCodMedico
                comMedico = New ADODB.Command
                With comMedico
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = szSql
                End With

                rsMedico = comMedico.Execute

                If rsMedico.EOF = True Then
                    rsMedico.Close()
                    iRetorno = gTERMINAR
                    comConsultar_Medico = 0
                    Exit Function
                End If
                rsMedico.MoveFirst()

                iCodMedicoM = rsMedico.Fields("iCodMedico").Value
                vchNombreM = rsMedico.Fields("vchNombre").Value
                vchPaternoM = rsMedico.Fields("vchPaterno").Value
                vchMaternoM = rsMedico.Fields("vchMaterno").Value
                vchDomicilioM = rsMedico.Fields("vchDomicilio").Value
                vchColoniaM = rsMedico.Fields("vchColonia").Value
                vchCPM = rsMedico.Fields("vchCP").Value
                vchTelefonoM = rsMedico.Fields("vchTelefono").Value
                vchCiudadM = rsMedico.Fields("vchCiudad").Value
                vchEstadoM = rsMedico.Fields("vchEstado").Value
                vchCedulaM = rsMedico.Fields("vchCedula").Value
                vchCelularM = rsMedico.Fields("vchCelular").Value
                vchTelRadioM = rsMedico.Fields("vchTelRadio").Value
                vchPinM = rsMedico.Fields("vchPin").Value
                vchUsuario = rsMedico.Fields("vchUsuario").Value
                vchPassword = rsMedico.Fields("vchPassword").Value
                vchProfesionM = rsMedico.Fields("vchProfesion").Value
                iCodResponsable = rsMedico.Fields("iCodResponsable").Value
                pbMostrarDock = rsMedico.Fields("bMostrarDock").Value
                piTipoBarraDock = rsMedico.Fields("iTipoBarraDock").Value
                bCambiarImagen = rsMedico.Fields("bCambiarImagen").Value
                iTiempoCambiarImagen = rsMedico.Fields("iTiempoCambiarImagen").Value
                iTipoConfiguracion = rsMedico.Fields("iTipoConfiguracion").Value
                vchCorreoM = rsMedico.Fields("vchCorreo").Value
                piiConos = rsMedico.Fields("iiConos").Value
                psRutaSkinsArchivoActual = rsMedico.Fields("vchRutaArchivo").Value
                psRutaSkinsArchivoActualBlur = rsMedico.Fields("vchRutaArchivoBlur").Value
                vchCorreoM = rsMedico.Fields("vchCorreo").Value
                piTipoFondoFast = rsMedico.Fields("iTipoFondoFast").Value
                bResponsable = rsMedico.Fields("bMedicoResponsable").Value

                'iCodResponsable = rsSysCon.Fields("iCodResponsable").Value
                'pbMostrarDock = rsSysCon.Fields("bMostrarDock").Value
                'piTipoBarraDock = rsSysCon.Fields("iTipoBarraDock").Value
                'bCambiarImagen = rsSysCon.Fields("bCambiarImagen").Value
                'iTiempoCambiarImagen = rsSysCon.Fields("iTiempoCambiarImagen").Value
                'iTipoConfiguracion = rsSysCon.Fields("iTipoConfiguracion").Value
                'vchCorreoM = rsSysCon.Fields("vchCorreo").Value
                'piiConos = rsSysCon.Fields("iiConos").Value
                'psRutaSkinsArchivoActual = rsSysCon.Fields("vchRutaArchivo").Value
                'psRutaSkinsArchivoActualBlur = rsSysCon.Fields("vchRutaArchivoBlur").Value
                'vchCorreoM = rsSysCon.Fields("vchCorreo").Value
                'piTipoFondoFast = rsSysCon.Fields("iTipoFondoFast").Value
                'bResponsable = rsSysCon.Fields("bMedicoResponsable").Value

                pbSkin_CambiarImagen = bCambiarImagen
                piSkin_TiempoCambiarImagen = iTiempoCambiarImagen
                piSkin_TipoConfiguracion = iTipoConfiguracion

                iRetorno = gEXITO
                iColumnas = rsMedico.Fields.Count
                iInicio = rsMedico.BOF
                iFin = rsMedico.EOF
                comConsultar_Medico = 1
            End If
            Exit Function
        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Function

    Public Function comConsultar_CatMedicos() As Short
        Dim szSql As String
        Try
            szSql = "SELECT * FROM CatMedico "
            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsMedico = comMedico.Execute

            If rsMedico.EOF = True Then
                rsMedico.Close()
                iRetorno = gTERMINAR
                comConsultar_CatMedicos = 0
                Exit Function
            End If
            rsMedico.MoveFirst()
            iInicio = rsMedico.BOF
            iFin = rsMedico.EOF
            iFilas = rsMedico.RecordCount
            comConsultar_CatMedicos = 1

            Exit Function
        Catch ex As Exception
            iRetorno = gTERMINAR
            comConsultar_CatMedicos = 0
        End Try
    End Function

    Public Function comConsultar_Usuario(ByRef vchUsuarioTmp As String) As Short
        Dim szSql As String
        Try
            If vchUsuarioTmp <> "" Then
                szSql = "SELECT * FROM CatMedico WHERE vchUsuario = '" & vchUsuarioTmp & "'"

                comMedico = New ADODB.Command
                With comMedico
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = szSql
                End With

                rsMedico = comMedico.Execute

                If rsMedico.EOF = True Then
                    rsMedico.Close()
                    iRetorno = gTERMINAR
                    comConsultar_Usuario = 0
                    Exit Function
                End If
                rsMedico.MoveFirst()

                iCodMedicoM = rsMedico.Fields("iCodMedico").Value
                vchNombreM = rsMedico.Fields("vchNombre").Value
                vchPaternoM = rsMedico.Fields("vchPaterno").Value
                vchMaternoM = rsMedico.Fields("vchMaterno").Value
                vchDomicilioM = rsMedico.Fields("vchDomicilio").Value
                vchColoniaM = rsMedico.Fields("vchColonia").Value
                vchCPM = rsMedico.Fields("vchCP").Value
                vchTelefonoM = rsMedico.Fields("vchTelefono").Value
                vchCiudadM = rsMedico.Fields("vchCiudad").Value
                vchEstadoM = rsMedico.Fields("vchEstado").Value
                vchCedulaM = rsMedico.Fields("vchCedula").Value
                vchCelularM = rsMedico.Fields("vchCelular").Value
                vchTelRadioM = rsMedico.Fields("vchTelRadio").Value
                vchPinM = rsMedico.Fields("vchPin").Value
                vchUsuario = rsMedico.Fields("vchUsuario").Value
                vchPassword = rsMedico.Fields("vchPassword").Value

                iRetorno = gEXITO
                iColumnas = rsMedico.Fields.Count
                iInicio = rsMedico.BOF
                iFin = rsMedico.EOF
                comConsultar_Usuario = 1
            End If
            Exit Function
        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Function

    Public Function comConsultar_Especies(ByRef vchEspecieAux As String, ByRef iCodEspecie As Short) As Short
        Try
            comEspecies = New ADODB.Command
            If vchEspecieAux = "" And iCodEspecie = 0 Then
                With comEspecies
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatEspecies ORDER BY iCodEspecie"
                End With
            ElseIf vchEspecieAux <> "" Then
                With comEspecies
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatEspecies WHERE vchEspecie LIKE '" & vchEspecieAux & "'"
                End With
            ElseIf iCodEspecie <> 0 Then
                With comEspecies
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatEspecies WHERE iCodEspecie = " & iCodEspecie & " ORDER BY iCodEspecie"
                End With
            End If
            rsSysCon = comEspecies.Execute
            iFilas = rsSysCon.RecordCount
            comConsultar_Especies = iRetorno
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function comConsultar_Razas(ByRef vchRazaAux As String, ByRef iCodEspecie As Short) As Short
        Try
            comRazas = New ADODB.Command
            If vchRazaAux = "" And iCodEspecie <> 0 Then
                With comRazas
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatRazas WHERE iCodEspecie = " & iCodEspecie & " ORDER BY vchRaza"
                End With
            ElseIf vchRazaAux <> "" And iCodEspecie <> 0 Then
                With comRazas
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatRazas WHERE vchRaza LIKE '" & vchRazaAux & "' AND iCodEspecie = " & iCodEspecie & " ORDER BY vchRaza"
                End With
            ElseIf vchRazaAux <> "" Then
                With comRazas
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatRazas WHERE vchRaza LIKE '" & vchRazaAux & "' ORDER BY vchRaza"
                End With
            ElseIf iCodEspecie = 0 Then
                With comRazas
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatRazas WHERE iCodEspecie > 2 ORDER BY vchRaza"
                End With
            End If

            rsSysCon = comRazas.Execute

            iFilas = rsSysCon.RecordCount
            If rsSysCon.EOF = False Then
                rsSysCon.MoveFirst()
            End If
            If iFilas > 0 Then
                piCodEspecie = rsSysCon.Fields("iCodEspecie").Value
                piCodRaza = rsSysCon.Fields("iCodRaza").Value
                psRaza = rsSysCon.Fields("vchRaza").Value
            End If
            comConsultar_Razas = iRetorno
            Exit Function
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function comConsultar_Color(Optional ByRef vchColorAux As String = "") As Short
        Try
            comColor = New ADODB.Command
            If vchColorAux = "" Then
                With comColor
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatColor ORDER BY vchColor"
                End With
            Else
                With comColor
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatColor WHERE vchColor LIKE '" & vchColorAux & "' ORDER BY vchColor"
                End With
            End If
            rsSysCon = comColor.Execute

            iFilas = rsSysCon.RecordCount
            comConsultar_Color = iRetorno

        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub comInsertar_Raza(ByRef iNumFolioAux As Integer, ByVal bInsertarTipo As Boolean)
        Dim szSql As String
        Dim bImagen As Bitmap
        Try
            szSql = "INSERT INTO CatRazas (iCodRaza ,vchRaza, vchDescripcion, iCodEspecie)"
            szSql = szSql & " SELECT "
            szSql = szSql & iNumFolioAux & ", '"
            szSql = szSql & vchRaza & "', '"
            szSql = szSql & vchDescripcionRaza & "', "
            szSql = szSql & iCodEspecie
            comRazas = New ADODB.Command
            With comRazas
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comRazas.Execute

            Dim msFotoH As New MemoryStream
            Dim msFotoM As New MemoryStream
            Dim rs = New ADODB.Recordset
            rs = New ADODB.Recordset
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic
            rs.Open("SELECT * FROM CatRazas WHERE iCodRaza = " & iNumFolioAux & "", cnSysCon)
            If bInsertarTipo = True Then
                frmCatalogos.picPersonMacho.Image.Save(msFotoM, frmCatalogos.picPersonMacho.Image.RawFormat)
            Else
                bImagen = My.RecursosSkins.Skins.PO_AltaPac_Sin_Imagen_M_82x82
                bImagen.Save(msFotoM, bImagen.RawFormat)
            End If
            Dim iMagenMacho() As Byte = msFotoM.GetBuffer
            msFotoM.Close()
            rs.Fields("imgMacho").Value = iMagenMacho
            If bInsertarTipo = True Then
                frmCatalogos.picPersonHembra.Image.Save(msFotoH, frmCatalogos.picPersonHembra.Image.RawFormat)
            Else
                bImagen = My.RecursosSkins.Skins.PO_AltaPac_Sin_Imagen_H_82x82
                bImagen.Save(msFotoH, bImagen.RawFormat)
            End If
            Dim iMagenHembra() As Byte = msFotoH.GetBuffer
            msFotoH.Close()
            rs.Fields("imgHembra").Value = iMagenHembra
            rs.Update()
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("°Error N˙mero: (" & Err.Number & ") DescripciÛn: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub comActualizar_Raza(ByRef iNumFolioAux As Integer)
        Dim szSql As String
        Try
            szSql = "UPDATE CatRazas SET "
            szSql = szSql & " vchRaza = '" & vchRaza & "', "
            szSql = szSql & " vchDescripcion = '" & vchDescripcionRaza & "'"
            szSql = szSql & " WHERE iCodRaza = " & CStr(iCodRaza)


            comRazas = New ADODB.Command
            With comRazas
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comRazas.Execute
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function comEliminar_Raza(ByRef iCodRaza As Integer) As Short
        Dim szSql As String
        Try
            szSql = "DELETE * FROM CatRazas "
            szSql = szSql & "WHERE iCodRaza = " & CStr(iCodRaza)

            comRazas = New ADODB.Command
            With comRazas
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comRazas.Execute
            comEliminar_Raza = iRetorno
            Exit Function
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function comEliminar_Color(ByRef iCodColor As Integer) As Short
        Dim szSql As String
        Try
            szSql = "DELETE FROM CatColor "
            szSql = szSql & "WHERE iCodColor = " & CStr(iCodColor)

            comColor = New ADODB.Command
            With comColor
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With

            rsSysCon = comColor.Execute
            comEliminar_Color = iRetorno
            Exit Function

        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub comActualizar_Color(ByRef iNumFolioAux As Integer)
        Dim szSql As String
        Try
            szSql = "UPDATE CatColor SET "
            szSql = szSql & " iCodColor = " & CInt(iCodColor) & ", "
            szSql = szSql & " vchColor = '" & vchColor & "', "
            szSql = szSql & " vchDescripcion = '" & vchDescripcionColor & "'"
            szSql = szSql & " WHERE iCodColor = " & CStr(iCodColor)

            comColor = New ADODB.Command
            With comColor
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comColor.Execute
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub comInsertar_Color(ByRef iNumFolioAux As Integer)
        Dim szSql As String
        Try
            szSql = "INSERT INTO CatColor (iCodColor ,vchColor, vchDescripcion)"
            szSql = szSql & " SELECT "
            szSql = szSql & iNumFolioAux & ", '"
            szSql = szSql & vchColor & "', '.'"

            comColor = New ADODB.Command
            With comColor
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comColor.Execute
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function comConsultar_Medicos() As Short

        Dim szSql As String
        Try
            szSql = "SELECT * FROM CatMedico WHERE bEstatus = -1 ORDER BY iCodMedico"

            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With

            rsSysCon = comMedico.Execute

            If rsSysCon.RecordCount > 0 Then
                rsSysCon.MoveFirst()
                iCodMedicoM = rsSysCon.Fields("iCodMedico").Value
                giCodMedico = iCodMedicoM
                vchNombreM = rsSysCon.Fields("vchNombre").Value
                vchPaternoM = rsSysCon.Fields("vchPaterno").Value
                vchMaternoM = rsSysCon.Fields("vchMaterno").Value
                vchDomicilioM = rsSysCon.Fields("vchDomicilio").Value
                vchColoniaM = rsSysCon.Fields("vchColonia").Value
                vchCPM = rsSysCon.Fields("vchCP").Value
                vchTelefonoM = rsSysCon.Fields("vchTelefono").Value
                vchCiudadM = rsSysCon.Fields("vchCiudad").Value
                vchEstadoM = rsSysCon.Fields("vchEstado").Value
                vchCedulaM = rsSysCon.Fields("vchCedula").Value
                vchCelularM = rsSysCon.Fields("vchCelular").Value
                vchTelRadioM = rsSysCon.Fields("vchTelRadio").Value
                vchPinM = rsSysCon.Fields("vchPin").Value
                vchUsuario = rsSysCon.Fields("vchUsuario").Value
                vchPassword = rsSysCon.Fields("vchPassword").Value
                iCodResponsable = rsSysCon.Fields("iCodResponsable").Value
                pbMostrarDock = rsSysCon.Fields("bMostrarDock").Value
                piTipoBarraDock = rsSysCon.Fields("iTipoBarraDock").Value
                bCambiarImagen = rsSysCon.Fields("bCambiarImagen").Value
                iTiempoCambiarImagen = rsSysCon.Fields("iTiempoCambiarImagen").Value
                iTipoConfiguracion = rsSysCon.Fields("iTipoConfiguracion").Value
                vchCorreoM = rsSysCon.Fields("vchCorreo").Value
                piiConos = rsSysCon.Fields("iiConos").Value
                psRutaSkinsArchivoActual = rsSysCon.Fields("vchRutaArchivo").Value
                psRutaSkinsArchivoActualBlur = rsSysCon.Fields("vchRutaArchivoBlur").Value
                vchCorreoM = rsSysCon.Fields("vchCorreo").Value
                piTipoFondoFast = rsSysCon.Fields("iTipoFondoFast").Value
                bResponsable = rsSysCon.Fields("bMedicoResponsable").Value
                pbSkin_CambiarImagen = bCambiarImagen
                piSkin_TiempoCambiarImagen = iTiempoCambiarImagen
                piSkin_TipoConfiguracion = iTipoConfiguracion

            End If
            iRetorno = gEXITO
            iColumnas = rsSysCon.Fields.Count
            iInicio = rsSysCon.BOF
            iFin = rsSysCon.EOF
            iFilas = rsSysCon.RecordCount
            Exit Function

        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function comConsultar_Medico_Usuario(ByRef vchUsuario As String) As Short
        Dim szSql As String
        Try
            szSql = "SELECT * FROM CatMedico "
            szSql = szSql & " WHERE vchUsuario LIKE '" & vchUsuario & "'"

            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsMedico = comMedico.Execute
            If rsMedico.EOF = True Then
                rsMedico.Close()
                iRetorno = gTERMINAR
                Exit Function
            End If
            rsMedico.MoveFirst()
            iCodMedicoM = rsMedico.Fields("iCodMedico").Value
            vchNombreM = rsMedico.Fields("vchNombre").Value
            vchPaternoM = rsMedico.Fields("vchPaterno").Value
            vchMaternoM = rsMedico.Fields("vchMaterno").Value
            vchDomicilioM = rsMedico.Fields("vchDomicilio").Value
            vchColoniaM = rsMedico.Fields("vchColonia").Value
            vchCPM = rsMedico.Fields("vchCP").Value
            vchTelefonoM = rsMedico.Fields("vchTelefono").Value
            vchCiudadM = rsMedico.Fields("vchCiudad").Value
            vchEstadoM = rsMedico.Fields("vchEstado").Value
            vchCedulaM = rsMedico.Fields("vchCedula").Value
            vchCelularM = rsMedico.Fields("vchCelular").Value
            vchTelRadioM = rsMedico.Fields("vchTelRadio").Value
            vchPinM = rsMedico.Fields("vchPin").Value
            vchUsuario = rsMedico.Fields("vchUsuario").Value
            vchPassword = rsMedico.Fields("vchPassword").Value
            piiConos = rsMedico.Fields("iiConos").Value
            pbMosaico = rsMedico.Fields("bMosaico").Value
            piCodMedicoResponsable = rsMedico.Fields("iCodResponsable").Value
            vchCorreoM = rsMedico.Fields("vchCorreo").Value


            iRetorno = gEXITO
            iColumnas = rsMedico.Fields.Count
            iInicio = rsMedico.BOF
            iFin = rsMedico.EOF
            Exit Function

        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function comConsultar_Medico_Perfil_Foto() As Bitmap
        Dim szSql As String
        Dim bNulo As Boolean
        'Dim msFoto As New MemoryStream
        Try
            szSql = "SELECT * FROM CatMedico "
            szSql = szSql & " WHERE iCodMedico LIKE '" & piCodMedicoPerfil & "'"

            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsMedico = comMedico.Execute
            If rsMedico.EOF = True Then
                rsMedico.Close()
                iRetorno = gTERMINAR
                piiConos = piCONO_COLORFULL
                pbMosaico = False
                If psPRODUCTO = pcPRODUCTO_PANTHER Then
                    comConsultar_Medico_Perfil_Foto = My.RecursosSkins.Skins.PO_Panther_14_Start_958x541
                    Exit Function
                ElseIf psPRODUCTO = pcPRODUCTO_SEAL Then
                    comConsultar_Medico_Perfil_Foto = My.RecursosSkins.Skins.KA_Kangaroo_Start_1200_683
                    Exit Function
                End If
            End If
            iFilas = rsMedico.RecordCount
            rsMedico.MoveFirst()
            iCodMedicoM = rsMedico.Fields("iCodMedico").Value
            piiConos = rsMedico.Fields("iiConos").Value
            pbMosaico = rsMedico.Fields("bMosaico").Value
            psUSUARIO = rsMedico.Fields("vchUsuario").Value
            psNOMBREMVZ = rsMedico.Fields("vchNombre").Value & " " & rsMedico.Fields("vchPaterno").Value & " " & rsMedico.Fields("vchMaterno").Value
            psDireccionMVZ = rsMedico.Fields("vchDomicilio").Value
            psCelularMVZ = rsMedico.Fields("vchCelular").Value
            pbMostrarDock = rsMedico.Fields("bMostrarDock").Value
            piTipoBarraDock = rsMedico.Fields("iTipoBarraDock").Value
            piTipoFondoFast = rsMedico.Fields("iTipoFondoFast").Value
            bNulo = IsDBNull(rsMedico.Fields("imgPerfil").Value)
            bNulo = IsDBNull(rsMedico.Fields("imgPerfilBlur").Value)
            bNulo = IsDBNull(rsMedico.Fields("bCambiarImagen").Value)
            bNulo = IsDBNull(rsMedico.Fields("iTiempoCambiarImagen").Value)
            bNulo = IsDBNull(rsMedico.Fields("iTipoConfiguracion").Value)
            pbSkin_CambiarImagen = rsMedico.Fields("bCambiarImagen").Value
            piSkin_TiempoCambiarImagen = rsMedico.Fields("iTiempoCambiarImagen").Value
            piSkin_TipoConfiguracion = rsMedico.Fields("iTipoConfiguracion").Value
            psSkin_TiempoCambiarImagen = rsMedico.Fields("sTiempoCambiarImagen").Value
            psRutaSkinsArchivoActual = rsMedico.Fields("vchRutaArchivo").Value
            psRutaSkinsArchivoActualBlur = rsMedico.Fields("vchRutaArchivoBlur").Value

            If piSkin_TipoConfiguracion = piSKIN_PANTHER Then
                frmPrincipal.tmrWallPaper.Interval = piSkin_TiempoCambiarImagen
                frmPrincipal.tmrWallPaper.Enabled = True
                'sbCambiarWallPapers(False)
            ElseIf piSkin_TipoConfiguracion = piSKIN_IMAGEN_PANTHER Then
                pbSkin_CambiarImagen = False
                frmPrincipal.tmrWallPaper.Enabled = False
                Exit Function
            ElseIf piSkin_TipoConfiguracion = piSKIN_IMAGEN_USUARIO_PERSONAL Then
                Dim imgPerfilBits As Byte() = CType(rsMedico.Fields("imgPerfil").Value, Byte())
                Dim memorybits As New System.IO.MemoryStream(imgPerfilBits)
                Dim bitmap As New Bitmap(memorybits)
                comConsultar_Medico_Perfil_Foto = bitmap

                'psRutaSkinsArchivoActual = Image.FromFile(psRutaSkinsArchivoActual)
                'frmPrincipal.tmrWallPaper.Enabled = False
                'Exit Function
            End If
            If bNulo = True Then
                If psPRODUCTO = pcPRODUCTO_PANTHER Then
                    iiConosM = 1
                    comConsultar_Medico_Perfil_Foto = My.RecursosSkins.Skins.PO_Panther_14_Start_958x541
                    bMosaicoM = False
                    bError = False
                    Exit Function
                ElseIf psPRODUCTO = pcPRODUCTO_SEAL Then
                    iiConosM = 1
                    comConsultar_Medico_Perfil_Foto = My.RecursosSkins.Skins.KA_Kangaroo_Start_1200_683
                    bMosaicoM = False
                    bError = False
                    Exit Function
                End If
            End If
        Catch ex As Exception
            If psPRODUCTO = pcPRODUCTO_PANTHER Then
                comConsultar_Medico_Perfil_Foto = My.RecursosSkins.Skins.PO_Panther_14_Start_958x541
                bMosaicoM = False
                iiConosM = 1
                bError = True
            ElseIf psPRODUCTO = pcPRODUCTO_SEAL Then
                comConsultar_Medico_Perfil_Foto = My.RecursosSkins.Skins.KA_Kangaroo_Start_1200_683
                bMosaicoM = False
                iiConosM = 1
                bError = True
            End If
        End Try
    End Function

    Public Function comConsultar_Medico_Perfil_Foto_Blur() As Bitmap
        Dim szSql As String
        Dim bNulo As Boolean
        'Dim msFoto As New MemoryStream
        Try
            szSql = "SELECT * FROM CatMedico "
            szSql = szSql & " WHERE iCodMedico LIKE '" & piCodMedicoPerfil & "'"

            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsMedico = comMedico.Execute

            If rsMedico.EOF = True Then
                rsMedico.Close()
                iRetorno = gTERMINAR
                piiConos = piCONO_COLORFULL
                pbMosaico = False
                If psPRODUCTO = pcPRODUCTO_PANTHER Then
                    comConsultar_Medico_Perfil_Foto_Blur = My.RecursosSkins.Skins.PO_Panther_14_Start_958x541
                    Exit Function
                ElseIf psPRODUCTO = pcPRODUCTO_SEAL Then
                    comConsultar_Medico_Perfil_Foto_Blur = My.RecursosSkins.Skins.KA_Kangaroo_Start_1200_683
                    Exit Function
                End If
            End If
            iFilas = rsMedico.RecordCount

            rsMedico.MoveFirst()
            iCodMedicoM = rsMedico.Fields("iCodMedico").Value
            piiConos = rsMedico.Fields("iiConos").Value
            pbMosaico = rsMedico.Fields("bMosaico").Value

            'psUSUARIO = rsMedico.Fields("vchUsuario").Value
            'psNOMBREMVZ = rsMedico.Fields("vchNombre").Value & " " & rsMedico.Fields("vchPaterno").Value & " " & rsMedico.Fields("vchMaterno").Value
            'psDireccionMVZ = rsMedico.Fields("vchDomicilio").Value
            'psCelularMVZ = rsMedico.Fields("vchCelular").Value
            pbMostrarDock = rsMedico.Fields("bMostrarDock").Value
            piTipoBarraDock = rsMedico.Fields("iTipoBarraDock").Value
            'bNulo = IsDBNull(rsMedico.Fields("imgPerfil").Value)
            bNulo = IsDBNull(rsMedico.Fields("imgPerfilBlur").Value)
            If bNulo = False Then
                Dim imgPerfilBits As Byte() = CType(rsMedico.Fields("imgPerfilBlur").Value, Byte())
                Dim memorybits As New System.IO.MemoryStream(imgPerfilBits)
                Dim bitmap As New Bitmap(memorybits)
                'picturebox1.Image = bitmap
                comConsultar_Medico_Perfil_Foto_Blur = bitmap
            Else
                iiConosM = 1
                bMosaicoM = False
                If psPRODUCTO = pcPRODUCTO_PANTHER Then
                    comConsultar_Medico_Perfil_Foto_Blur = My.RecursosSkins.Skins.PO_Panther_14_Start_958x541
                    Exit Function
                ElseIf psPRODUCTO = pcPRODUCTO_SEAL Then
                    comConsultar_Medico_Perfil_Foto_Blur = My.RecursosSkins.Skins.KA_Kangaroo_Start_1200_683
                    Exit Function
                End If
            End If
            bError = False
        Catch ex As Exception
            If psPRODUCTO = pcPRODUCTO_PANTHER Then
                comConsultar_Medico_Perfil_Foto_Blur = My.RecursosSkins.Skins.PO_Panther_14_Start_958x541

            ElseIf psPRODUCTO = pcPRODUCTO_SEAL Then
                comConsultar_Medico_Perfil_Foto_Blur = My.RecursosSkins.Skins.KA_Kangaroo_Start_1200_683
            End If
            bMosaicoM = False
            iiConosM = 1
            bError = True
        End Try
    End Function

    Public Function comEliminar_Especie(ByRef iCodEspecie As Integer) As Short
        Dim szSql As String
        Try
            szSql = "DELETE * FROM CatEspecies "
            szSql = szSql & "WHERE iCodEspecie = " & CStr(iCodEspecie)
            comEspecies = New ADODB.Command
            With comEspecies
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comEspecies.Execute
            comEliminar_Especie = iRetorno
            Exit Function
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub comInsertar_Especies(ByRef iNumFolioAux As Integer)
        Dim szSql As String
        Try
            szSql = "INSERT INTO CatEspecies (iCodEspecie ,vchEspecie, vchDescripcion)"
            szSql = szSql & " SELECT "
            szSql = szSql & iNumFolioAux & ", '"
            szSql = szSql & vchEspecie & "', '"
            szSql = szSql & vchDescripcionEspecie & "'"

            comEspecies = New ADODB.Command
            With comEspecies
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comEspecies.Execute
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub comActualizar_Especie(ByRef iNumFolioAux As Integer)
        Dim szSql As String
        Try
            szSql = "UPDATE CatEspecies SET "
            szSql = szSql & " iCodEspecie = " & CInt(iCodEspecie) & ", "
            szSql = szSql & " vchEspecie = '" & vchEspecie & "', "
            szSql = szSql & " vchDescripcion = '" & vchDescripcionEspecie & "'"
            szSql = szSql & " WHERE iCodEspecie = " & CStr(iCodEspecie)

            comEspecies = New ADODB.Command
            With comEspecies
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comEspecies.Execute
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function comEliminar_Medico(ByRef iCodMedico As Short) As Short
        Dim szSql As String
        Try
            szSql = "DELETE * FROM CatMedico "
            szSql = szSql & "WHERE iCodMedico = " & CStr(iCodMedico)

            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comMedico.Execute
            comEliminar_Medico = iRetorno
            Exit Function

        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub comActualizar_Ciudad(ByRef iNumFolioAux As Integer)
        Dim szSql As String
        Try
            szSql = "UPDATE CatCiudad SET "
            szSql = szSql & " iCodCiudad = " & CInt(iCodCiudad) & ", "
            szSql = szSql & " vchCiudad = '" & vchCatCiudad & "', "
            szSql = szSql & " vchEstado = '" & vchCatEstado & "'"
            szSql = szSql & " WHERE iCodCiudad = " & CStr(iCodCiudad)

            comCiudad = New ADODB.Command
            With comCiudad
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comCiudad.Execute
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub comInsertar_Ciudad(ByRef iNumFolioAux As Integer)
        Dim szSql As String
        Try
            szSql = "INSERT INTO CatCiudad (iCodCiudad ,vchCiudad, vchEstado)"
            szSql = szSql & " SELECT "
            szSql = szSql & iNumFolioAux & ", '"
            szSql = szSql & vchCatCiudad & "', '"
            szSql = szSql & vchCatEstado & "'"

            comCiudad = New ADODB.Command
            With comCiudad
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comCiudad.Execute

            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function comConsultar_Ciudad(ByRef vchCiudadAux As String, ByRef iCodCiudad As Short) As Short
        Try
            comCiudad = New ADODB.Command
            If vchCiudadAux = "" And iCodCiudad = 0 Then
                With comCiudad
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatCiudad ORDER BY vchCiudad"
                End With
            ElseIf vchCiudadAux = "" And iCodCiudad <> 0 Then
                With comCiudad
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatCiudad WHERE iCodCiudad LIKE '" & iCodCiudad & "%' ORDER BY iCodCiudad"
                End With
            ElseIf vchCiudadAux <> "" Then
                With comCiudad
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM CatCiudad WHERE vchCiudad LIKE '" & vchCiudadAux & "%' ORDER BY vchCiudad"
                End With
            End If
            rsSysCon = comCiudad.Execute
            iFilas = rsSysCon.RecordCount
            comConsultar_Ciudad = iRetorno
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function comEliminar_Ciudad(ByRef iCodCiudad As Integer) As Short
        Dim szSql As String
        Try
            szSql = "DELETE * FROM CatCiudad "
            szSql = szSql & "WHERE iCodCiudad = " & CStr(iCodCiudad)

            comCiudad = New ADODB.Command
            With comCiudad
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With

            rsSysCon = comCiudad.Execute
            comEliminar_Ciudad = iRetorno
            Exit Function

        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Sub comObtener_NumFolio(ByRef iCodFolio As Integer)
        Try
            comObtenerFolio = New ADODB.Command
            With comObtenerFolio
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT iCodFolio, iNumFolio, vchDescripcion FROM TranFolio WHERE iCodFolio = " & iCodFolio
            End With
            rsSysCon = comObtenerFolio.Execute

        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function comConsultar_MedicoResp() As Short
        Dim szSql As String
        Dim bNulo As Boolean
        Try
            szSql = "SELECT iCodMedico,"
            szSql = szSql & " vchNombre,"
            szSql = szSql & " vchPaterno,"
            szSql = szSql & " vchMaterno,"
            szSql = szSql & " vchTelefono,"
            szSql = szSql & " vchUsuario,"
            szSql = szSql & " vchPassword,"
            szSql = szSql & " iCodResponsable,"
            szSql = szSql & " vchPasswordResp, "
            szSql = szSql & " vchCorreo, "
            szSql = szSql & " vchCedula "
            szSql = szSql & " FROM CatMedico "

            szSql = szSql & " WHERE iCodResponsable = 1"

            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With

            rsMedico = comMedico.Execute

            If rsMedico.EOF = True Then
                iFin = rsMedico.EOF
                rsMedico.Close()
                iRetorno = gTERMINAR
                Exit Function
            End If
            rsMedico.MoveFirst()

            iCodMedicoM = rsMedico.Fields(0).Value
            piCodMedicoResponsable = iCodMedicoM
            vchNombreM = rsMedico.Fields("vchNombre").Value
            vchPaternoM = rsMedico.Fields("vchPaterno").Value
            vchMaternoM = rsMedico.Fields("vchMaterno").Value
            vchTelefonoM = rsMedico.Fields("vchTelefono").Value
            vchUsuario = rsMedico.Fields("vchUsuario").Value
            vchPassword = rsMedico.Fields("vchPassword").Value
            bNulo = IsDBNull(rsMedico.Fields("vchPasswordResp").Value)
            vchCedulaM = rsMedico.Fields("vchCedula").Value
            If bNulo = True Then
                vchPasswordResp = "."
            Else
                vchPasswordResp = rsMedico.Fields("vchPasswordResp").Value
            End If
            psMedicoResponsable = vchNombreM & " " & vchPaternoM & " " & vchMaternoM
            iRetorno = gEXITO
            iColumnas = rsMedico.Fields.Count
            iInicio = rsMedico.BOF
            iFin = rsMedico.EOF
            Exit Function

        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub comActualizar_MedicoResp(ByRef iCodMedico As Short)
        Dim szSql As String
        Dim sPassword As String
        Try
            If bLibre = False Then
                szSql = "UPDATE CatMedico SET iCodResponsable = 0"
                comMedico = New ADODB.Command
                With comMedico
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = szSql
                End With
                rsMedico = comMedico.Execute

                szSql = "UPDATE CatMedico SET vchPasswordResp = '.'"
                comMedico.CommandText = szSql
                rsMedico = comMedico.Execute

                szSql = "SELECT vchPassword FROM CatMedico WHERE iCodMedico = " & iCodMedico & ""

                comMedico.CommandText = szSql
                rsMedico = comMedico.Execute

                sPassword = rsMedico.Fields("vchPassword").Value

                szSql = "UPDATE CatMedico SET "
                szSql = szSql & " iCodResponsable = 1, "
                szSql = szSql & " vchPasswordResp = '" & sPassword & "'"
                szSql = szSql & "WHERE iCodMedico = " & iCodMedico
                comMedico.CommandText = szSql
                rsMedico = comMedico.Execute
            End If


            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub comBuscar_PacienteID(ByRef iCodPacienteTmp As Integer)
        Try
            comBuscaPaciente = New ADODB.Command
            'Todos
            If iCodPacienteTmp > 0 Then
                With comBuscaPaciente
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM TranAfiliado WHERE iCodPaciente = " & iCodPacienteTmp
                End With
            End If
            rsSysCon = comBuscaPaciente.Execute
            iFilas = rsSysCon.RecordCount
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function comConsultar_Vacunas_Paciente() As Short
        Try
            comColor = New ADODB.Command
            With comColor
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT * FROM TranRegistroVacunas WHERE iCodPaciente =" & iCodPaciente & " ORDER BY sFecha DESC"
            End With

            rsSysCon = comColor.Execute

            iFilas = rsSysCon.RecordCount
            comConsultar_Vacunas_Paciente = iRetorno

        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function comConsultar_Vacunas(ByRef vchVacunasAux As String) As Short
        Try
            comColor = New ADODB.Command
            If vchVacunasAux = "" Then
                With comColor
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM TranRegistroVacunas ORDER BY iCodVacuna"
                End With
            Else
                With comColor
                    .let_ActiveConnection(cnSysCon)
                    .CommandText = "SELECT * FROM TranRegistroVacunas WHERE iCodVacuna LIKE '" & vchVacunasAux & "%' ORDER BY iCodVacuna"
                End With
            End If

            rsSysCon = comColor.Execute

            iFilas = rsSysCon.RecordCount
            comConsultar_Vacunas = iRetorno

        Catch ex As Exception
            MessageBox.Show("¡Error Número: (" & Err.Number & ") Descripción: (" & Err.Description & ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function comConsultar_Correo_Paciente(ByRef iCodPaciente As Integer) As Short
        Dim szSql As String
        Try
            szSql = "SELECT * FROM TranDetalleAfiliado "
            szSql = szSql & " WHERE iCodPaciente = " & iCodPaciente

            comActualizarDetallePaciente = New ADODB.Command
            With comActualizarDetallePaciente
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With

            rsSysCon = comActualizarDetallePaciente.Execute
            iFilas = rsSysCon.RecordCount

        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Function

    Public Sub comLimpiar_disCartilla()
        Dim szSql As String
        Try
            szSql = " UPDATE disCartillaVac SET " & _
                    " sVacunaAplicada = '', " & _
                    " vchDescripcion = '', " & _
                    " sNumeroLote = '', " & _
                    " sFecha = '', " & _
                    " sFechaCaducidad = '', " & _
                    " sCampoCalca = '', " & _
                    " sProximaVacuna = '', " & _
                    " sFechaProgramada = ''"

            comCartilla = New ADODB.Command
            With comCartilla
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comCartilla.Execute

            szSql = " UPDATE disCartillaDesp SET " & _
                    " sProductoAplicado = '', " & _
                    " sFecha = '', " & _
                    " sObservaciones = '', " & _
                    " sFechaProxima = ''"

            comCartilla = New ADODB.Command
            With comCartilla
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comCartilla.Execute
            Exit Sub
        Catch
            'iRetorno = gTERMINAR
        End Try
    End Sub

    Public Sub comConsultarImagenTranAfiliado()
        Dim szSql As String
        Try
            szSql = "SELECT * FROM TranAfiliado WHERE iCodpaciente = " & iCodPaciente & ""
            comObtenerImagen = New ADODB.Command
            With comObtenerImagen
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon4 = comObtenerImagen.Execute
        Catch ex As Exception
        End Try
    End Sub

    Public Sub comActualizarEstadoTranAfiliado()
        Dim szSql As String
        Try
            szSql = "UPDATE TranAfiliado SET bActivo = " & bActivo & " WHERE iCodpaciente = " & iCodPaciente & ""
            comObtenerImagen = New ADODB.Command
            With comObtenerImagen
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comObtenerImagen.Execute
        Catch ex As Exception
        End Try
    End Sub

    Public Sub comActualizarResponsable()
        Dim szSql As String
        Try
            szSql = "UPDATE CatMedico SET iCodResponsable = 0"
            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon2 = comMedico.Execute

            szSql = "UPDATE CatMedico SET vchPasswordResp = '.'"
            comMedico.CommandText = szSql
            rsSysCon2 = comMedico.Execute
        Catch ex As Exception
        End Try
    End Sub

    Public Sub fActualizarDatos_CF(ByRef iCodMedicoTmp As Integer)
        Dim msFoto As New MemoryStream
        Dim szSql As String
        Dim iMedicoResp As Integer
        Try
            szSql = "Select * from CatMedico where iCodMedico = " & iCodMedicoTmp & ""
            comObtenerImagen = New ADODB.Command
            With comObtenerImagen
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comObtenerImagen.Execute
            frmAltaMedico.picPerson.BackgroundImage.Save(msFoto, frmAltaMedico.picPerson.BackgroundImage.RawFormat)
            Dim iMagenFotoMedico() As Byte = msFoto.GetBuffer
            msFoto.Close()
            iMedicoResp = rsSysCon2.Fields("iCodMedico").Value
            If iCodResponsable = 1 Then
                comActualizarResponsable()
                szSql = "UPDATE CatMedico SET"
                szSql = szSql & " vchNombre = '" & vchNombreM & "', "
                szSql = szSql & " vchPaterno = '" & vchPaternoM & "', "
                szSql = szSql & " vchMaterno = '" & vchMaternoM & "', "
                szSql = szSql & " vchColonia = '" & vchColoniaM & "', "
                szSql = szSql & " vchTelefono = '" & vchTelefonoM & "', "
                szSql = szSql & " vchCP = '" & vchCPM & "', "
                szSql = szSql & " vchCelular = '" & vchCelularM & "', "
                szSql = szSql & " vchTelRadio = '" & vchTelRadioM & "', "
                szSql = szSql & " vchCedula = '" & vchCedulaM & "', "
                szSql = szSql & " vchUsuario = '" & vchUsuario & "', "
                szSql = szSql & " vchPassword = '" & vchPassword & "', "
                szSql = szSql & " vchCorreo = '" & vchCorreoM & "', "
                szSql = szSql & " bEstatus = " & bEstatusM & ", "
                szSql = szSql & " iCodResponsable = " & iCodResponsable & ", "
                szSql = szSql & " vchPasswordResp = '" & vchPassword & "', "
                szSql = szSql & " vchProfesion = '" & vchProfesionM & "', "
                szSql = szSql & " bMedicoResponsable = " & bResponsable
                szSql = szSql & " WHERE iCodMedico = " & iCodMedicoTmp
                comMedico.CommandText = szSql
                rsSysCon = comMedico.Execute
            ElseIf iCodResponsable = 0 Then
                szSql = "UPDATE CatMedico SET"
                szSql = szSql & " vchNombre = '" & vchNombreM & "', "
                szSql = szSql & " vchPaterno = '" & vchPaternoM & "', "
                szSql = szSql & " vchMaterno = '" & vchMaternoM & "', "
                szSql = szSql & " vchDomicilio = '" & vchDomicilioM & "', "
                szSql = szSql & " vchColonia = '" & vchColoniaM & "', "
                szSql = szSql & " vchTelefono = '" & vchTelefonoM & "', "
                szSql = szSql & " vchCP = '" & vchCPM & "', "
                szSql = szSql & " vchCelular = '" & vchCelularM & "', "
                szSql = szSql & " vchTelRadio = '" & vchTelRadioM & "', "
                szSql = szSql & " vchCedula = '" & vchCedulaM & "', "
                szSql = szSql & " vchUsuario = '" & vchUsuario & "', "
                szSql = szSql & " vchPassword = '" & vchPassword & "', "
                szSql = szSql & " vchCorreo = '" & vchCorreoM & "', "
                szSql = szSql & " bEstatus = " & bEstatusM & ", "
                szSql = szSql & " vchProfesion = '" & vchProfesionM & "', "
                szSql = szSql & " bMedicoResponsable = " & bResponsable
                szSql = szSql & " WHERE iCodMedico = " & iCodMedicoTmp
                comMedico.CommandText = szSql
                rsSysCon = comMedico.Execute
            End If
        Catch ex As Exception
            frmAltaMedico.bFalla = True
        End Try
    End Sub

    Public Sub fActualizarDatos_SF(ByRef iCodMedicoTmp As Integer)
        Dim szSql As String
        Dim iMedicoResp As Integer
        Try
            szSql = "Select * from CatMedico where iCodMedico = " & iCodMedicoTmp & ""
            comObtenerImagen = New ADODB.Command
            With comObtenerImagen
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon = comObtenerImagen.Execute
            If iCodResponsable = 1 Then
                iMedicoResp = rsSysCon2.Fields("iCodMedico").Value
                comActualizarResponsable()
                szSql = "UPDATE CatMedico SET "
                szSql = szSql & " vchNombre = '" & vchNombreM & "', "
                szSql = szSql & " vchPaterno = '" & vchPaternoM & "', "
                szSql = szSql & " vchMaterno = '" & vchMaternoM & "', "
                szSql = szSql & " vchDomicilio = '" & vchDomicilioM & "', "
                szSql = szSql & " vchColonia = '" & vchColoniaM & "', "
                szSql = szSql & " vchTelefono = '" & vchTelefonoM & "', "
                szSql = szSql & " vchCP = '" & vchCPM & "', "
                szSql = szSql & " vchCelular = '" & vchCelularM & "', "
                szSql = szSql & " vchTelRadio = '" & vchTelRadioM & "', "
                szSql = szSql & " vchCedula = '" & vchCedulaM & "', "
                szSql = szSql & " vchUsuario = '" & vchUsuario & "', "
                szSql = szSql & " vchPassword = '" & vchPassword & "', "
                szSql = szSql & " vchCorreo = '" & vchCorreoM & "', "
                szSql = szSql & " bEstatus = " & bEstatusM & ", "
                szSql = szSql & " iCodResponsable = " & iCodResponsable & ", "
                szSql = szSql & " vchPasswordResp = '" & vchPassword & "', "
                szSql = szSql & " vchProfesion = '" & vchProfesionM & "', "
                szSql = szSql & " bMedicoResponsable = " & bResponsable
                szSql = szSql & " WHERE iCodMedico = " & iCodMedicoTmp
                'comMedico.CommandText = szSql
                rsSysCon = comMedico.Execute

                If piCodMedicoPerfil <> iCodMedicoTmp Then
                    pbiCodMedicoResponsable = False
                Else
                    pbiCodMedicoResponsable = True
                End If
                piCodMedicoResponsable = iCodMedicoTmp
            ElseIf iCodResponsable = 0 Then
                szSql = "UPDATE CatMedico SET "
                szSql = szSql & " vchNombre = '" & vchNombreM & "', "
                szSql = szSql & " vchPaterno = '" & vchPaternoM & "', "
                szSql = szSql & " vchMaterno = '" & vchMaternoM & "', "
                szSql = szSql & " vchDomicilio = '" & vchDomicilioM & "', "
                szSql = szSql & " vchColonia = '" & vchColoniaM & "', "
                szSql = szSql & " vchTelefono = '" & vchTelefonoM & "', "
                szSql = szSql & " vchCP = '" & vchCPM & "', "
                szSql = szSql & " vchCelular = '" & vchCelularM & "', "
                szSql = szSql & " vchTelRadio = '" & vchTelRadioM & "', "
                szSql = szSql & " vchCedula = '" & vchCedulaM & "', "
                szSql = szSql & " vchUsuario = '" & vchUsuario & "', "
                szSql = szSql & " vchPassword = '" & vchPassword & "', "
                szSql = szSql & " vchCorreo = '" & vchCorreoM & "', "
                szSql = szSql & " bEstatus = " & bEstatusM & ", "
                szSql = szSql & " vchProfesion = '" & vchProfesionM & "', "
                szSql = szSql & " bMedicoResponsable = " & bResponsable
                szSql = szSql & " WHERE iCodMedico = " & iCodMedicoTmp
            End If
            comMedico.CommandText = szSql
            rsSysCon = comMedico.Execute
        Catch ex As Exception
            frmAltaMedico.bFalla = True
        End Try
    End Sub

    Public Sub sbMedicoResponsable()
        Try
            Dim szSql As String
            szSql = "Select iCodMedico from CatMedico where iCodResponsable = 1"
            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsSysCon2 = comMedico.Execute
        Catch ex As Exception
        End Try
    End Sub

    Public Function comConsultar_MedicoResponsable()
        Dim szSql As String
        Try
            szSql = "SELECT * FROM CatMedico WHERE iCodResponsable = 1"
            comMedico = New ADODB.Command
            With comMedico
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSql
            End With
            rsMedico = comMedico.Execute

            If rsMedico.RecordCount > 0 Then
                iCodMedicoM = rsMedico.Fields("iCodMedico").Value
                vchNombreM = rsMedico.Fields("vchNombre").Value
                vchPaternoM = rsMedico.Fields("vchPaterno").Value
                vchMaternoM = rsMedico.Fields("vchMaterno").Value
                vchDomicilioM = rsMedico.Fields("vchDomicilio").Value
                vchColoniaM = rsMedico.Fields("vchColonia").Value
                vchCPM = rsMedico.Fields("vchCP").Value
                vchTelefonoM = rsMedico.Fields("vchTelefono").Value
                vchCiudadM = rsMedico.Fields("vchCiudad").Value
                vchEstadoM = rsMedico.Fields("vchEstado").Value
                vchCedulaM = rsMedico.Fields("vchCedula").Value
                vchCelularM = rsMedico.Fields("vchCelular").Value
                vchTelRadioM = rsMedico.Fields("vchTelRadio").Value
                vchPinM = rsMedico.Fields("vchPin").Value
                vchUsuario = rsMedico.Fields("vchUsuario").Value
                vchPassword = rsMedico.Fields("vchPassword").Value
                vchCorreoM = rsMedico.Fields("vchCorreo").Value
                vchPasswordResp = rsMedico.Fields("vchPasswordResp").Value
                iFilas = rsMedico.RecordCount
            End If



        Catch ex As Exception
            iRetorno = gTERMINAR
        End Try
    End Function

    Public Function comBuscarEspecie(ByVal szSqlTmp As String) As Integer
        Try
            comRazas = New ADODB.Command
            With comRazas
                .let_ActiveConnection(cnSysCon)
                .CommandText = szSqlTmp
            End With
            rsSysCon = comRazas.Execute
            iFilas = rsSysCon.RecordCount
            If iFilas > 0 Then
                comBuscarEspecie = rsSysCon.Fields("iCodEspecie").Value
            Else
                comBuscarEspecie = 0
            End If
        Catch ex As Exception
            comBuscarEspecie = 0
        End Try
    End Function

    Public Sub comConsultarImageneRaza(ByVal sRazaTmp As String)
        comRazas = New ADODB.Command
        If sRazaTmp <> "" Then
            With comRazas
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT * FROM CatRazas WHERE vchRaza = '" & sRazaTmp & "' AND iCodEspecie = " & iCodEspecie & ""
            End With

        Else
            With comRazas
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT * FROM CatRazas WHERE vchRaza = '" & sRazaTmp & "%' AND iCodEspecie = " & iCodEspecie & ""
            End With
        End If
        rsSysCon = comRazas.Execute
        iFilas = rsSysCon.RecordCount
    End Sub

    Public Sub comConsultarImagenesAvatars(ByVal sEspecieTmp As String)
        Try
            comRazas = New ADODB.Command
            With comRazas
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT * FROM CatEspeciesRazas WHERE vchEspecie LIKE '" & sEspecieTmp & "'" '"SELECT * FROM CatRazas WHERE iCodEspecie = " & iCodEspecie & " AND tiEstatusAvatar = true"
            End With
            rsSysCon2 = comRazas.Execute
            iFilas = rsSysCon2.RecordCount
        Catch ex As Exception
        End Try
    End Sub

    Public Sub comConsultarImagenAvatar(ByVal iCodRazaTmp As Integer)
        comRazas = New ADODB.Command
        With comRazas
            .let_ActiveConnection(cnSysCon)
            .CommandText = "SELECT * FROM CatEspeciesRazas WHERE iCodRaza = " & iCodRazaTmp
        End With
        rsSysCon = comRazas.Execute
        iFilas = rsSysCon.RecordCount
    End Sub

    ''' <summary>
    '''  Actualizar la mascota con cambio de propietario
    ''' IG
    ''' V15
    ''' </summary>
    ''' <param name="iCodPacienteTmp"></param>
    ''' <param name="iCodPropietarioTmp"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function comActualizarCambioMascota(ByVal iCodPacienteTmp As Integer, ByVal iCodPropietarioTmp As Integer) As Integer
        Dim szSql As String
        Dim iCodPacienteTemporal As Integer
        Try
            If iCodPacienteTmp = iCodPropietarioTmp Then
                comActualizarDetallePaciente = New ADODB.Command
                szSql = "SELECT TOP 1 iCodPaciente As iCodPacienteTemporal FROM TranDetalleAfiliado WHERE iCodPropietario = " & iCodPropietarioTmp & " AND iCodPaciente <> " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                iFilas = rsSysCon.RecordCount
                If iFilas > 0 Then
                    iCodPacienteTemporal = rsSysCon.Fields("iCodPacienteTemporal").Value
                    comActualizarCambioMascota = iCodPacienteTemporal
                Else
                    comActualizarCambioMascota = iCodPacienteTemporal
                    Exit Function
                End If

                szSql = "UPDATE TranDetalleAfiliado SET iCodPropietario = " & iCodPacienteTemporal & " WHERE iCodPropietario = " & iCodPropietarioTmp & " AND iCodPaciente <> " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'ABONOS
                szSql = "UPDATE TranAbonosCuentasClientes SET iCodPropietario = " & iCodPacienteTemporal & " WHERE iCodPropietario = " & iCodPropietarioTmp & " AND iCodPaciente <> " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'CUENTAS CLIENTES
                szSql = "UPDATE TranCuentasClientes SET iCodPropietario = " & iCodPacienteTemporal & " WHERE iCodPropietario = " & iCodPropietarioTmp & " AND iCodPaciente <> " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'CORTES
                szSql = "UPDATE TranCorteCuentaCliente SET iCodPropietario = " & iCodPacienteTemporal & " WHERE iCodPropietario = " & iCodPropietarioTmp & " AND iCodPaciente <> " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'AGENDA ESTETICA
                szSql = "UPDATE TranAgendaEstetica SET iCodPropietario = " & iCodPacienteTemporal & " WHERE iCodPropietario = " & iCodPropietarioTmp & " AND iCodPaciente <> " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'HOSPITALIZACION
                szSql = "UPDATE TranHospitalizacion SET iCodPropietario = " & iCodPacienteTemporal & " WHERE iCodPropietario = " & iCodPropietarioTmp & " AND iCodPaciente <> " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'DETALLE HOSPITALIZACION
                szSql = "UPDATE TranDetalleHospitalizacion SET iCodPropietario = " & iCodPacienteTemporal & " WHERE iCodPropietario = " & iCodPropietarioTmp & " AND iCodPaciente <> " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'MIGRACION
                szSql = "UPDATE TranMigracion SET iCodPropietario = " & iCodPacienteTemporal & " WHERE iCodPropietario = " & iCodPropietarioTmp & " AND iCodPaciente <> " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'PENSION
                szSql = "UPDATE TranPension SET iCodPropietario = " & iCodPacienteTemporal & " WHERE iCodPropietario = " & iCodPropietarioTmp & " AND iCodPaciente <> " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

            ElseIf iCodPacienteTmp <> iCodPropietarioTmp Then

                comActualizarDetallePaciente = New ADODB.Command

                szSql = "UPDATE TranDetalleAfiliado SET iCodPropietario = " & iCodPacienteTmp & " WHERE iCodPaciente =  " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'ABONOS
                szSql = "UPDATE TranAbonosCuentasClientes SET iCodPropietario = " & iCodPacienteTmp & " WHERE iCodPaciente =  " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'CUENTAS CLIENTES
                szSql = "UPDATE TranCuentasClientes SET iCodPropietario = " & iCodPacienteTmp & " WHERE iCodPaciente =  " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'CORTES
                szSql = "UPDATE TranCorteCuentaCliente SET iCodPropietario = " & iCodPacienteTmp & " WHERE iCodPaciente =  " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'AGENDA ESTETICA
                szSql = "UPDATE TranAgendaEstetica SET iCodPropietario = " & iCodPacienteTmp & " WHERE iCodPaciente =  " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'HOSPITALIZACION
                szSql = "UPDATE TranHospitalizacion SET iCodPropietario = " & iCodPacienteTmp & " WHERE iCodPaciente =  " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'DETALLE HOSPITALIZACION
                szSql = "UPDATE TranDetalleHospitalizacion SET iCodPropietario = " & iCodPacienteTmp & " WHERE iCodPaciente =  " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'MIGRACION
                szSql = "UPDATE TranMigracion SET iCodPropietario = " & iCodPacienteTmp & " WHERE iCodPaciente =  " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                'PENSION
                szSql = "UPDATE TranPension SET iCodPropietario = " & iCodPacienteTmp & " WHERE iCodPaciente =  " & iCodPacienteTmp
                comActualizarDetallePaciente.let_ActiveConnection(cnSysCon)
                comActualizarDetallePaciente.CommandText = szSql
                rsSysCon = comActualizarDetallePaciente.Execute

                comActualizarCambioMascota = iCodPacienteTmp
            End If
        Catch ex As Exception
            frmAltaMedico.bFalla = True
        End Try
    End Function

    ''' <summary>
    ''' Consultar Especies por correo
    ''' BB
    ''' V15
    ''' </summary>
    ''' <param name="iCodEspecieTmp"></param>
    ''' <remarks></remarks>
    ''' 

    Public Sub sbConsultarRazas_Especies_Mail(ByVal sRaza As String)
        Try
            comRazas = New ADODB.Command
            With comRazas
                .let_ActiveConnection(cnSysCon)
                .CommandText = "SELECT TA.iCodPaciente, TA.vchNombre AS vchNombreAfi, TA.vchRaza, TA.iCodEstatus, TA.iCodEspecie, TA.Imagen, " & _
                " TA.vchSexo, TA.vchColor, TA.dtFecNacimiento, TDA.vchCorreo, CE.vchEspecie," & _
                " TDA.vchNombre, TDA.vchPaterno, TDA.vchMaterno, TDA.vchTelefono, " & _
                " TDA.vchDireccion, TDA.vchColonia, TDA.vchCP," & _
                " TDA.vchNombre + ' ' + TDA.vchPaterno + ' ' + TDA.vchMaterno As vchNombreCompleto " & _
                " FROM ((TranAfiliado TA INNER JOIN CatEspecies CE ON CE.iCodEspecie= TA.iCodEspecie) " & _
                " INNER JOIN TranDetalleAfiliado TDA ON TDA.iCodPaciente= TA.iCodPaciente)" & _
                " WHERE TA.vchRaza LIKE '" & sRaza & "%'  And (Len(TDA.vchCorreo) > 5) " & _
                  " AND TA.bActivo = " & True & ""
            End With
            rsSysCon = comRazas.Execute
            iFilas = rsSysCon.RecordCount
        Catch ex As Exception
        End Try

    End Sub
End Class