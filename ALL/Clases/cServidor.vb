Imports MySql.Data.MySqlClient
Public Class cServidor
    Public MysqlConn As MySqlConnection
    Public xCommand As MySqlCommand
    Public myReader As MySqlDataReader
    Public daBuscarGrupos As New MySqlDataAdapter
    Public daBuscarGrupos2 As New MySqlDataAdapter

    Public Function fnConectar() As Boolean
        Dim sValor, pconsBaseMySql As String
        Try
            pconsBaseMySql = "server=localhost;" _
          & "user id=root;" _
          & "password=POBrian;" _
          & "Port=3306;" _
          & "database=softassitence"
            MysqlConn = New MySqlConnection()
            MysqlConn.ConnectionString = pconsBaseMySql

            MysqlConn.Open()

            fnConectar = True
        Catch ex As Exception
            sValor = ex.Message
            fnConectar = False
        End Try
    End Function

    Public Sub sbDesconectar()
        Dim sValor As String
        Try
            MysqlConn.Close()
            MysqlConn.Dispose()
        Catch ex As Exception
            sValor = ex.Message
        End Try
    End Sub


    Public Sub sbConsultar_Grupos()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT * FROM softassitence.catgrupos "
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
            sbDesconectar()
        End Try
    End Sub

    Public Sub sbConsultar_Grupo_X_Nombre(ByVal vchGrupo As String)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT * FROM softassitence.catgrupos " & _
            "WHERE vchGrupo = '" & vchGrupo & "'"
            myReader = xCommand.ExecuteReader
            ' daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)

        Catch ex As Exception
            sbDesconectar()
        End Try
    End Sub

    Public Sub sbConsultar_Profesores()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT * FROM softassitence.catprofesor"
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_Carreras()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT * FROM softassitence.cat_carreras"
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_Carrera_Existente(ByVal sCarrera As String)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT * FROM softassitence.cat_carreras WHERE vchCarrera = '" & sCarrera & "'"
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_Divisiones()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT * FROM softassitence.cat_division"
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    'Public Sub sbConsultar_UltimoGrupo()
    '    Try
    '        xCommand = New MySqlCommand
    '        xCommand.Connection = MysqlConn
    '        xCommand.CommandText = "SELECT MAX(iCodGrupo) AS iCodGrupo FROM softassitence.catgrupos"
    '        myReader = xCommand.ExecuteReader
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Public Sub sbInsertarGrupo(ByVal iCodGrupo As Integer, ByVal iCodProfesor As Integer, _
       ByVal vchGrupo As String, ByVal vchProfesor As String, ByVal dtFechaIni As Date, ByVal dtFechaFin As Date, _
        ByVal vchCurso As String, ByVal vchSeccion As String, ByVal vchDias As String, ByVal vchHoraIni As String, ByVal vchHoraFin As String)

      
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "INSERT INTO softassitence.catgrupos (iCodProfesor, vchGrupo, " _
          & " vchProfesor, dtFechaInicio, dtFechaFin, vchCurso, vchSeccion, vchDias, vchHoraIni, vchHoraFin) " _
                                     & " VALUES (" & iCodProfesor & ", " _
                                     & "'" & vchGrupo & "', " _
                                     & "'" & vchProfesor & "', " _
                                     & "'" & dtFechaIni.ToString("yyyy/MM/dd") & "', " _
                                     & "'" & dtFechaFin.ToString("yyyy/MM/dd") & "', " _
                                     & "'" & vchCurso & "', " _
                                     & "'" & vchSeccion & "', " _
                                      & "'" & vchDias & "', " _
                                       & "'" & vchHoraIni & "', " _
                                     & "'" & vchHoraFin & "') "

            xCommand.ExecuteNonQuery()
        Catch ex As Exception
            sbDesconectar()
        End Try
    End Sub
    Public Sub sbEliminar_Grupo(ByVal iCodGrupo As Integer)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "DELETE  FROM softassitence.catgrupos where iCodGrupo = " & iCodGrupo & ""
            myReader = xCommand.ExecuteReader
            sbDesconectar()
            fnConectar()
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "DELETE  FROM softassitence.catalumnos where iCodGrupo = " & iCodGrupo & ""
            myReader = xCommand.ExecuteReader
            sbDesconectar()
            fnConectar()
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "DELETE  FROM softassitence.tran_asistencias where iCodGrupo = " & iCodGrupo & ""
            myReader = xCommand.ExecuteReader
            sbDesconectar()
            fnConectar()
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "DELETE  FROM softassitence.rel_asistencias where iCodGrupo = " & iCodGrupo & ""
            myReader = xCommand.ExecuteReader
            sbDesconectar()
            fnConectar()
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "DELETE  FROM softassitence.cat_dias_curso where iCodGrupo = " & iCodGrupo & ""
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbEliminar_Dia_Inhabil(ByVal iCodDia As Integer)
        Try
          
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "DELETE  FROM softassitence.cat_dias_inhabiles where iCodDia = " & iCodDia & ""
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbInsertarDiasCurso(ByVal iCodDia As Integer, ByVal iCodGrupo As Integer, _
       ByVal iDiasLunes As Integer, ByVal iDiasMartes As Integer, ByVal iDiasMiercoles As Integer, _
        ByVal iDiasJueves As Integer, ByVal iDiasViernes As Integer, ByVal iDiasSabado As Integer, ByVal iDiasTotal As Integer)


        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "INSERT INTO softassitence.cat_dias_curso (iCodGrupo, iDiasLunes, " _
          & " iDiasMartes, iDiasMiercoles, iDiasJueves, iDiasViernes, iDiasSabado, iTotalDias) " _
                                     & " VALUES (" & iCodGrupo & ", " _
                                     & "'" & iDiasLunes & "', " _
                                     & "'" & iDiasMartes & "', " _
                                     & "'" & iDiasMiercoles & "', " _
                                     & "'" & iDiasJueves & "', " _
                                     & "'" & iDiasViernes & "', " _
                                      & "'" & iDiasSabado & "', " _
                                     & "'" & iDiasTotal & "') "

            xCommand.ExecuteNonQuery()
        Catch ex As Exception
            sbDesconectar()
        End Try
    End Sub
    Public Sub sbConsultar_iCodUltimoCurso()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT MAX(iCodDia) AS iCodDia FROM softassitence.cat_dias_curso"
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_UltimoGrupo()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT MAX(iCodGrupo) AS iCodGrupo FROM softassitence.catgrupos"
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbEliminar_Alumno(ByVal iCodAlumno As Integer)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "DELETE  FROM softassitence.catalumnos where iCodAlumno = " & iCodAlumno & ""
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbEliminar_AlumnoXCodigo(ByVal vchCodigo As String)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "DELETE  FROM softassitence.rel_asistencias where vchCodigo = '" & vchCodigo & "'"
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_Dias_Inhabiles()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT *, CONCAT(iDia, '/', iMes, '/', iAnio) as dtFecha FROM softassitence.cat_dias_inhabiles"
            myReader = xCommand.ExecuteReader
            daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_Dia_Inhabil(ByVal iDia As Integer, ByVal iMes As Integer, ByVal iAnio As Integer)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT * FROM softassitence.cat_dias_inhabiles " & _
            "WHERE iDia = '" & iDia & "' AND iMes = '" & iMes & "' AND  iAnio = '" & iAnio & "' "
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbInsertarDia_Inhabil(ByVal iDia As Integer, _
     ByVal iMes As Integer, ByVal iAnio As Integer, ByVal vchDescripcion As String)

        fnConectar()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "INSERT INTO softassitence.cat_dias_inhabiles (iDia, " _
          & " iMes, iAnio, vchDescripcion) " _
                                     & " VALUES (" & iDia & ", " _
                                        & "" & iMes & ", " _
                                     & "" & iAnio & ", " _
                                     & "'" & vchDescripcion & "') "
                                   

            '& "" & iCodGrupo & ", " _

            xCommand.ExecuteNonQuery()
        Catch ex As Exception
            sbDesconectar()
        End Try
    End Sub

    Public Sub sbConsultar_Alumno_Existente(ByVal vchCodigo As String, ByVal iCodGrupo As Integer, ByVal iCodAlumno As Integer, ByVal bEdicion As Boolean)
        Try
            Dim sAux As String
            If bEdicion = True Then
                sAux = " AND iCodAlumno <> " & iCodAlumno & ""
            Else
                sAux = ""
            End If

            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT * FROM softassitence.catalumnos " & _
            "WHERE vchCodigo = '" & vchCodigo & "' AND iCodGrupo = " & iCodGrupo & sAux & ""
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub


    Public Sub sbInsertarAlumno(ByVal iCodGrupo As Integer, _
      ByVal vchNombre As String, ByVal vchPaterno As String, ByVal vchMaterno As String, _
       ByVal vchCodigo As String, ByVal sCarrera As String, ByVal sImagen As String)

        fnConectar()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "INSERT INTO softassitence.catalumnos (iCodGrupo, " _
          & " vchNombre, vchPaterno, vchMaterno, vchCodigo, vchCarrera, imgAlumno) " _
                                     & " VALUES (" & iCodGrupo & ", " _
                                        & "'" & vchNombre & "', " _
                                     & "'" & vchPaterno & "', " _
                                     & "'" & vchMaterno & "', " _
                                     & "'" & vchCodigo & "', " _
                                     & "'" & sCarrera & "', " _
                                     & "'" & sImagen & "') "

            '& "" & iCodGrupo & ", " _

            xCommand.ExecuteNonQuery()
        Catch ex As Exception
            sbDesconectar()
        End Try
    End Sub


    Public Sub sbActualizar_DatosAlumno(ByVal iCodAlumno As Integer, ByVal iCodGrupo As Integer, _
                                        ByVal vchNombre As String, ByVal vchPaterno As String, _
                                        ByVal vchMaterno As String, ByVal vchCodigo As String, _
                                        ByVal vchCarrera As String)
        Dim szSql As String
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            szSql = "UPDATE  softassitence.catalumnos SET "
            szSql = szSql & " iCodGrupo = " & iCodGrupo & ", "
            szSql = szSql & " vchNombre = '" & vchNombre & "', "
            szSql = szSql & " vchPaterno = '" & vchPaterno & "', "
            szSql = szSql & " vchMaterno = '" & vchMaterno & "', "
            szSql = szSql & " vchCodigo = '" & vchCodigo & "', "
            szSql = szSql & " vchCarrera = '" & vchCarrera & "' "
            szSql = szSql & " WHERE iCodAlumno = " & iCodAlumno
            xCommand.CommandText = szSql
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_Alumnos_X_Grupo(ByVal iCodGrupoTmp As Integer)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT *, concat (vchNombre, ' ', vchPaterno, ' ', vchMaterno) as vchAlumno " & _
            "FROM softassitence.catalumnos " & _
            "WHERE iCodGrupo = " & iCodGrupoTmp & ""
            myReader = xCommand.ExecuteReader
            daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_iCodUltimoHistorialAsistencia()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT MAX(iCodAsistencias) AS iCodAsistencias FROM softassitence.tran_asistencias"
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_iCodUltimoRelAsistencia()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT MAX(iCodRelAsistencias) AS iCodRelAsistencias FROM softassitence.rel_asistencias"
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_Historial_Asistencias(ByVal iCodGrupoTmp As Integer)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT TA.*, CG.vchGrupo " & _
            "FROM softassitence.tran_asistencias TA INNER JOIN softassitence.catgrupos CG " & _
            "ON CG.iCodGrupo = TA.iCodGrupo " & _
            "WHERE TA.iCodGrupo = " & iCodGrupoTmp & ""
            myReader = xCommand.ExecuteReader
            daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub sbInsertarAsistencia(ByVal iCodAsistencia As Integer, ByVal iCodGrupo As Integer, _
   ByVal dtFecha As Date, ByVal vchHora As String)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "INSERT INTO softassitence.tran_asistencias (iCodAsistencias, iCodGrupo, " _
          & " dtFecha, vchHora) " _
                                     & " VALUES (" & iCodAsistencia & ", " _
                                     & "" & iCodGrupo & ", " _
                                     & "'" & dtFecha.ToString("yyyy/MM/dd") & "' , " _
                                     & "'" & vchHora & "')"

            xCommand.ExecuteNonQuery()
        Catch ex As Exception
            sbDesconectar()
        End Try
    End Sub


    Public Sub sbInsertarRel_Asistencia(ByVal iCodAsistencia As Integer, ByVal iCodGrupo As Integer, _
    ByVal sCodAlumno As String, ByVal tiEstatusAsistencia As Integer, ByVal tiEstatusJustificacion As Integer, ByVal tiEstatusFalta As Integer)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "INSERT INTO softassitence.rel_asistencias (iCodAsistencia, " _
          & " vchCodigo, tiEstatusAsistencia, tiEstatusJustificacion, tiEstatusFalta, iCodGrupo) " _
                                     & " VALUES (" & iCodAsistencia & ", " _
                                     & "'" & sCodAlumno & "', " _
                                     & "" & tiEstatusAsistencia & " , " _
                                     & "" & tiEstatusJustificacion & " , " _
                                      & "" & tiEstatusFalta & " , " _
                                     & "" & iCodGrupo & " ) "

            xCommand.ExecuteNonQuery()
        Catch ex As Exception
            sbDesconectar()
        End Try
    End Sub


    Public Sub sbConsultar_Asistencia_Existente(ByVal iCodAsistenciaTmp As Integer)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = " SELECT RA.*, concat(CA.vchPaterno, ' ', CA.vchMaterno, ' ', CA.vchNombre) As vchAlumno,  " & _
            "CA.vchCodigo, CA.vchCarrera   FROM softassitence.rel_asistencias RA inner join  " & _
            "softassitence.catalumnos CA on CA.vchCodigo=RA.vchCodigo " & _
            "WHERE RA.iCodAsistencia = " & iCodAsistenciaTmp & "  group by RA.iCodRelAsistencias order by CA.vchPaterno"
            myReader = xCommand.ExecuteReader
            daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub sbActualizar_Asistencia(ByVal iCodRelAsistenciaTmp As Integer, ByVal iEstatusAsistencia As Integer, _
                                       ByVal iEstatusJustificacion As Integer, ByVal iEstatusFalta As Integer)
        Dim szSql As String
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            szSql = "UPDATE  softassitence.rel_asistencias SET "
            szSql = szSql & " tiEstatusAsistencia = " & iEstatusAsistencia & ", "
            szSql = szSql & " tiEstatusJustificacion = " & iEstatusJustificacion & ", "
            szSql = szSql & " tiEstatusFalta = " & iEstatusFalta & " "
            szSql = szSql & " WHERE iCodRelAsistencias   = " & iCodRelAsistenciaTmp
            xCommand.CommandText = szSql
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbInsertarProfesor(ByVal vchNombre As String, ByVal vchPaterno As String, _
       ByVal vchMaterno As String, ByVal iCodDivision As Integer)

        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "INSERT INTO softassitence.catprofesor (vchNombre,vchPaterno, vchMaterno, " _
          & " iCodDivision) " _
                                     & " VALUES ('" & vchNombre & "', " _
                                     & "'" & vchPaterno & "', " _
                                     & "'" & vchMaterno & "', " _
                                     & "" & iCodDivision & ") "

            xCommand.ExecuteNonQuery()
        Catch ex As Exception
            sbDesconectar()
        End Try
    End Sub


    Public Sub sbInsertarDivision(ByVal vchNombre As String)

        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "INSERT INTO softassitence.cat_division (Division) " _
                                     & " VALUES ('" & vchNombre & "') "

            xCommand.ExecuteNonQuery()
        Catch ex As Exception
            sbDesconectar()
        End Try
    End Sub

    Public Sub sbInsertarCarrera(ByVal vchNombre As String)

        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "INSERT INTO softassitence.cat_carreras (vchCarrera) " _
                                     & " VALUES ('" & vchNombre & "') "

            xCommand.ExecuteNonQuery()

            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT MAX(iCodCarrera) AS iCodCarrera FROM softassitence.cat_carreras"
            myReader = xCommand.ExecuteReader
        Catch ex As Exception
        End Try
    End Sub
    '''REPORTES

    Public Sub sbConsultar_Alumnos_Todos()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT distinct(CA.vchCodigo), CA.*, concat (CA.vchPaterno, ' ', CA.vchMaterno, ' ', CA.vchNombre) as vchAlumno " & _
            "FROM softassitence.catalumnos CA group by CA.vchCodigo order by CA.vchPaterno "
            '"WHERE iCodGrupo = " & iCodGrupoTmp & ""
            myReader = xCommand.ExecuteReader
            daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_Asistencia_Alumno_Reporte(ByVal vchCodigoTmp As String, ByVal iTipoAsistencia As Integer)
        Try
            Dim sAux As String
            xCommand = New MySqlCommand
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            If iTipoAsistencia = 0 Then
                xCommand.CommandText = "SELECT distinct(CG.vchGrupo) as vchGrupo, " & _
        "sum(RA.tiEstatusAsistencia) as  iAsistencias, " & _
        "sum(RA.tiEstatusJustificacion) as  iJustificacion, " & _
        "sum(RA.tiEstatusJustificacion + RA.tiEstatusAsistencia) as iObtenidas, " & _
        "count(TA.iCodAsistencias) as iTotal, sum(RA.tiEstatusJustificacion + RA.tiEstatusAsistencia) * 100 / count(TA.iCodAsistencias)  as iPorcentaje, " & _
   "sum(RA.tiEstatusFalta) as iFaltas  " & _
   "FROM softassitence.rel_asistencias RA " & _
        "INNER JOIN softassitence.tran_asistencias TA ON TA.iCodAsistencias = RA.iCodAsistencia " & _
        "INNER JOIN softassitence.catgrupos CG ON CG.iCodGrupo = RA.iCodGrupo " & _
        "where RA.vchCodigo = '" & vchCodigoTmp & "' " & _
        "group by RA.iCodGrupo, CG.vchGrupo "

                myReader = xCommand.ExecuteReader
                daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)

                '      ElseIf iTipoAsistencia = 1 Then
                '          xCommand.CommandText = "SELECT distinct(CG.vchGrupo) as vchGrupo, " & _
                '"count(RA.iCodRelAsistencias) as  iFaltas " & _
                '"FROM softassitence.rel_asistencias RA " & _
                '"INNER JOIN softassitence.tran_asistencias TA ON TA.iCodAsistencias = RA.iCodAsistencia  " & _
                '"INNER JOIN softassitence.catgrupos CG ON CG.iCodGrupo = RA.iCodGrupo " & _
                '"where RA.vchCodigo = '" & vchCodigoTmp & "' And RA.tiEstatusAsistencia = 0 And RA.tiEstatusJustificacion = 0 " & _
                '"group by  CG.vchGrupo,RA.iCodGrupo"
                '          myReader = xCommand.ExecuteReader
                '          daBuscarGrupos2 = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Public Sub sbConsultar_Asistencia_Grupo_Reporte(ByVal iCodGrupoTmp As Integer, ByVal iTipoAsistencia As Integer)
        Try
            xCommand = New MySqlCommand
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            If iTipoAsistencia = 0 Then
                xCommand.CommandText = "SELECT concat(CA.vchPaterno, ' ', CA.vchMaterno, ' ', CA.vchNombre) as vchAlumno,  " & _
        "sum(RA.tiEstatusAsistencia) as  iAsistencias, " & _
        "sum(RA.tiEstatusJustificacion) as  iJustificacion, " & _
        "sum(RA.tiEstatusJustificacion + RA.tiEstatusAsistencia) as iObtenidas, " & _
        "count(RA.vchCodigo) as iTotal, sum(RA.tiEstatusJustificacion + RA.tiEstatusAsistencia) * 100 / count(RA.vchCodigo) as iPorcentaje, " & _
         "sum(RA.tiEstatusFalta) as iFaltas  " & _
        "FROM softassitence.rel_asistencias RA " & _
        "INNER JOIN softassitence.tran_asistencias TA ON TA.iCodAsistencias = RA.iCodAsistencia " & _
        "INNER JOIN softassitence.catgrupos CG ON CG.iCodGrupo = RA.iCodGrupo " & _
        "INNER JOIN softassitence.catalumnos CA on CA.vchCodigo=RA.vchCodigo " & _
        "where RA.iCodGrupo = " & iCodGrupoTmp & " and CA.iCodGrupo = " & iCodGrupoTmp & " " & _
        "group by RA.vchCodigo order by CA.vchPaterno "

                myReader = xCommand.ExecuteReader
                daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)

                '      ElseIf iTipoAsistencia = 1 Then
                '          xCommand.CommandText = "SELECT  " & _
                '"count(iCodRelAsistencias) as  iFaltas " & _
                '"FROM softassitence.rel_asistencias " & _
                '"where iCodGrupo = " & iCodGrupoTmp & _
                '" And tiEstatusAsistencia = 0 And tiEstatusJustificacion = 0 " & _
                '"group by vchCodigo"
                '          myReader = xCommand.ExecuteReader
                '          daBuscarGrupos2 = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_Grupos_Reportes()
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT * FROM softassitence.catgrupos "
            myReader = xCommand.ExecuteReader
            daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)
        Catch ex As Exception
            sbDesconectar()
        End Try
    End Sub


    Public Sub sbConsultar_Asistencia_Dia(ByVal dtFecha As String)
        Try
            Dim sAux As String
            xCommand = New MySqlCommand
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT concat(CA.vchPaterno, ' ', CA.vchMaterno, ' ', CA.vchNombre) as vchAlumno,  " & _
       "sum(RA.tiEstatusAsistencia) as  iAsistencias, " & _
       "sum(RA.tiEstatusJustificacion) as  iJustificacion, " & _
       "sum(RA.tiEstatusJustificacion + RA.tiEstatusAsistencia) as iObtenidas, " & _
       "count(RA.vchCodigo) as iTotal, sum(RA.tiEstatusJustificacion + RA.tiEstatusAsistencia) * 100 / count(RA.vchCodigo) as iPorcentaje, " & _
        "sum(RA.tiEstatusFalta) as iFaltas, CG.vchGrupo  " & _
       "FROM softassitence.rel_asistencias RA " & _
       "INNER JOIN softassitence.tran_asistencias TA ON TA.iCodAsistencias = RA.iCodAsistencia " & _
       "INNER JOIN softassitence.catgrupos CG ON CG.iCodGrupo = RA.iCodGrupo " & _
       "INNER JOIN softassitence.catalumnos CA on CA.vchCodigo=RA.vchCodigo " & _
       "where TA.dtFecha = '" & dtFecha & "' " & _
       "group by RA.vchCodigo order by CA.vchPaterno "
            myReader = xCommand.ExecuteReader
            daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)

        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_Asistencia_Semestral(ByVal dtFechaIni As String, ByVal dtFechaFin As String)
        Try
            Dim sAux As String
            xCommand = New MySqlCommand
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT concat(CA.vchPaterno, ' ', CA.vchMaterno, ' ', CA.vchNombre) as vchAlumno,  " & _
       "sum(RA.tiEstatusAsistencia) as  iAsistencias, " & _
       "sum(RA.tiEstatusJustificacion) as  iJustificacion, " & _
       "sum(RA.tiEstatusJustificacion + RA.tiEstatusAsistencia) as iObtenidas, " & _
       "count(RA.vchCodigo) as iTotal, sum(RA.tiEstatusJustificacion + RA.tiEstatusAsistencia) * 100 / count(RA.vchCodigo) as iPorcentaje, " & _
        "sum(RA.tiEstatusFalta) as iFaltas, CG.vchGrupo  " & _
       "FROM softassitence.rel_asistencias RA " & _
       "INNER JOIN softassitence.tran_asistencias TA ON TA.iCodAsistencias = RA.iCodAsistencia " & _
       "INNER JOIN softassitence.catgrupos CG ON CG.iCodGrupo = RA.iCodGrupo " & _
       "INNER JOIN softassitence.catalumnos CA on CA.vchCodigo=RA.vchCodigo " & _
       "where  TA.dtFecha between '" & dtFechaIni & "' AND '" & dtFechaFin & "' " & _
       "group by RA.vchCodigo order by CA.vchPaterno "
            myReader = xCommand.ExecuteReader
            daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)

        Catch ex As Exception
        End Try
    End Sub

    '''Justificacion
    Public Sub sbConsultar_JustificacionLimite(ByVal vchCodigoTmp As String)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT CD.iTotalDias * 20 / 100  as iJusticacionLimite " & _
            " FROM softassitence.rel_asistencias RA inner join	softassitence.cat_dias_curso CD on CD.iCodGrupo=RA.iCodGrupo " & _
            "ON CG.iCodGrupo = TA.iCodGrupo " & _
            " Where RA.vchCodigo = '" & vchCodigoTmp & "'"
            myReader = xCommand.ExecuteReader
            daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbConsultar_JustificacionTotal(ByVal vchCodigoTmp As String)
        Try
            xCommand = New MySqlCommand
            xCommand.Connection = MysqlConn
            xCommand.CommandText = "SELECT sum(RA.tiEstatusJustificacion) * 20 / CD.iTotalDias as iTotalJustificacion " & _
            " FROM softassitence.rel_asistencias RA inner join	softassitence.cat_dias_curso CD on CD.iCodGrupo=RA.iCodGrupo " & _
            "ON CG.iCodGrupo = TA.iCodGrupo " & _
            "  Where RA.vchCodigo = '" & vchCodigoTmp & "'"
            myReader = xCommand.ExecuteReader
            daBuscarGrupos = New MySqlDataAdapter(xCommand.CommandText, MysqlConn)
        Catch ex As Exception
        End Try
    End Sub

End Class
