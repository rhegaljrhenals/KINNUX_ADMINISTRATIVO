Imports System.Data
Imports Microsoft.VisualBasic

Public Class clsTtCalifCartagena

    Private _codigoPais As Integer
    Private _codigoAfiliado As String
    Dim objOperacione As New clsOperacione

    Public Property codigoAfiliado As String
        Get
            Return _codigoAfiliado
        End Get
        Set(ByVal value As String)
            _codigoAfiliado = value
        End Set
    End Property

    Public Property codigoPais As Integer
        Get
            Return _codigoPais
        End Get
        Set(ByVal value As Integer)
            _codigoPais = value
        End Set
    End Property

    Function obtenerDatosCalificacionCartagena() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "ttCalifCartagena.vpcalifcartagena, " & _
        "ttCalifCartagena.vgafilcalifcartagena, " & _
        "ttCalifCartagena.vggencalifcartagena, " & _
        "ttCalifCartagena.vg1califcartagena, " & _
        "ttCalifCartagena.nuevocalifcartagena, " & _
        "ttCalifCartagena.calificadocalifcartagena," & _
        "ttCalifCartagena.cupos, " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.identificacion, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres," & _
        "dbo.TBpais.codigoPais, " & _
        "dbo.TBpais.nombrePais, " & _
        "dbo.TBDpto.codigoDpto, " & _
        "dbo.TBDpto.nombreDpto, " & _
        "dbo.TBMunicipio.codigoMunicipio, " & _
        "dbo.TBMunicipio.nombreMunicipio" & _
        " FROM" & _
        " ttCalifCartagena INNER JOIN" & _
        " dbo.Afiliaciones ON ttCalifCartagena.codigoafiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.TBpais.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.TBpais.codigoPais = dbo.TBMunicipio.idPais AND dbo.TBDpto.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio"
        If Me.codigoPais = 0 Then
            sql = sql & _
                " order by ttCalifCartagena.vggencalifcartagena desc"
        Else
            sql = sql & _
                " where dbo.TBpais.codigoPais=" & Me.codigoPais & _
                " order by ttCalifCartagena.vggencalifcartagena desc"
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDatosCalificacionCancun() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "TTCalifcancun2016.vpcalifcancun, " & _
        "TTCalifcancun2016.vg1califcancun, " & _
        "TTCalifcancun2016.nuevocalifcancun, " & _
        "TTCalifcancun2016.calificadocalifcancun," & _
        "TTCalifcancun2016.cuposcancun, " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.identificacion, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres," & _
        "dbo.TBpais.codigoPais, " & _
        "dbo.TBpais.nombrePais, " & _
        "dbo.TBDpto.codigoDpto, " & _
        "dbo.TBDpto.nombreDpto, " & _
        "dbo.TBMunicipio.codigoMunicipio, " & _
        "dbo.TBMunicipio.nombreMunicipio," & _
        "TTCalifcancun2016.agocancun," & _
        "TTCalifcancun2016.septcalifcancun," & _
        "TTCalifcancun2016.octcalifcancun," & _
        "TTCalifcancun2016.novcalifcancun," & _
        "TTCalifcancun2016.diccalifcancun," & _
        "TTCalifcancun2016.enerocalifcancun" & _
        " FROM" & _
        " TTCalifcancun2016 INNER JOIN" & _
        " dbo.Afiliaciones ON TTCalifcancun2016.codigoafiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.TBpais.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.TBpais.codigoPais = dbo.TBMunicipio.idPais AND dbo.TBDpto.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio"
        If Me.codigoPais = 0 Then
            sql = sql & _
                " order by TTCalifcancun2016.vggencalifcartagena desc"
        Else
            sql = sql & _
                " where dbo.TBpais.codigoPais=" & Me.codigoPais & _
                " order by TTCalifcancun2016.vg1califcancun desc"
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDatosCalificacionCrucero2016() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT        " & _
        "dbo.Afiliaciones.codigoAfiliado, " & _
        "dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "dbo.TBpais.nombrePais," & _
        "dbo.TBDpto.nombreDpto," & _
        "dbo.TBMunicipio.nombreMunicipio," & _
        "dbo.TTCalifCrucero.vpcalifCrucero," & _
        "dbo.TTCalifCrucero.vgafilcalifCrucero," & _
        "dbo.TTCalifCrucero.vggencalifCrucero," & _
        "dbo.TTCalifCrucero.vg1califCrucero," & _
        "dbo.TTCalifCrucero.novcalifcrucero," & _
        "dbo.TTCalifCrucero.diccalifcrucero," & _
        "dbo.TTCalifCrucero.enecalifcrucero," & _
        "dbo.TTCalifCrucero.febcalifcrucero," & _
        "dbo.TTCalifCrucero.marzocalifcrucero," & _
        "dbo.TTCalifCrucero.abrilcalifcrucero," & _
        "dbo.TTCalifCrucero.mayocalifcrucero," & _
        "dbo.TTCalifCrucero.juniocalifcrucero," & _
        "dbo.TTCalifCrucero.juliocalifcrucero," & _
        "dbo.TTCalifCrucero.agostocalifcrucero," & _
        "dbo.TTCalifCrucero.nuevocalifCrucero," & _
        "dbo.TTCalifCrucero.calificadocalifCrucero," & _
        "dbo.TTCalifCrucero.cuposCrucero" & _
        " FROM" & _
        " dbo.TTCalifCrucero INNER JOIN" & _
        " dbo.Afiliaciones ON dbo.TTCalifCrucero.codigoafiliado = dbo.Afiliaciones.codigoAfiliado INNER JOIN" & _
        " dbo.TBpais ON dbo.Afiliaciones.codigoPais = dbo.TBpais.codigoPais INNER JOIN" & _
        " dbo.TBDpto ON dbo.Afiliaciones.codigoPais = dbo.TBDpto.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBDpto.codigoDpto INNER JOIN" & _
        " dbo.TBMunicipio ON dbo.Afiliaciones.codigoPais = dbo.TBMunicipio.idPais AND dbo.Afiliaciones.codigoDpto = dbo.TBMunicipio.idDpto AND " & _
        " dbo.Afiliaciones.codigoCiudad = dbo.TBMunicipio.codigoMunicipio"
        If Me.codigoPais = 0 Then
            sql = sql & _
                " order by TTCalifCrucero.vggencalifCrucero desc"
        Else
            sql = sql & _
                " where dbo.TBpais.codigoPais=" & Me.codigoPais & _
                " order by TTCalifCrucero.vg1califCrucero desc"
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDatosCalificacionBahamas() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT        " & _
        "codigoAfiliado, " & _
        "Pnombre + ' ' + Snombre + ' ' + Papellido + ' ' + Sapellido as nombres, " & _
        "nombreempresa," & _
        "nombreDpto," & _
        "nombreMunicipio," & _
        "vpcalifBahamas," & _
        "vgafilcalifBahamas," & _
        "vggencalifBahamas," & _
        "vg1califBahamas," & _
        "nuevocalifBahamas," & _
        "calificadocalifBahamas," & _
        "cuposBahamas" & _
        " FROM" & _
        " vw_roporteBAHAMAS"
        If Me.codigoPais = 0 Then
            sql = sql & _
                " order by vggencalifBahamas desc"
        Else
            sql = sql & _
                " where idPais=" & Me.codigoPais & _
                " order by vg1califBahamas desc"
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDatosCalificacionpuntacana() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT        " & _
        "codigoAfiliado, " & _
        "Pnombre + ' ' + Snombre + ' ' + Papellido + ' ' + Sapellido as nombres, " & _
        "nombreempresa," & _
        "nombreDpto," & _
        "nombreMunicipio," & _
        "vpcalifpuntacana," & _
        "vgafilcalifpuntacana," & _
        "vggencalifpuntacana," & _
        "vg1califpuntacana," & _
        "ciclospuntacana," & _
        "nuevocalifpuntacana," & _
        "calificadocalifpuntacana," & _
        "cupospuntacana" & _
        " FROM" & _
        " vw_roportepuntacana"
        If Me.codigoPais = 0 Then
            sql = sql & _
                " order by vggencalifpuntacana desc"
        Else
            sql = sql & _
                " where idPais=" & Me.codigoPais & _
                " order by vg1califpuntacana desc"
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDatosCalificacionMexico2019() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT * " & _
        " FROM vw_calificacionMexico2019"
        If Me.codigoPais = 0 Then
            sql = sql & _
                " order by vggencalifmexico desc"
        Else
            sql = sql & _
                " where idPais=" & Me.codigoPais & _
                " order by vggencalifmexico desc"
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDatosCalificacionEuropa2020() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT * " & _
        " FROM vw_calificacionEuropa2020"
        If Me.codigoPais = 0 Then
            sql = sql & _
                " order by idcalifeuropa desc"
        Else
            sql = sql & _
                " where idPais=" & Me.codigoPais & _
                " order by idcalifeuropa desc"
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function


    Function obtenerDatosCalificacionbavaro() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT        " & _
        "codigoAfiliado, " & _
        "Pnombre + ' ' + Snombre + ' ' + Papellido + ' ' + Sapellido as nombres, " & _
        "nombreempresa," & _
        "nombreDpto," & _
        "nombreMunicipio," & _
        "vpcalifbavaro," & _
        "vgafilcalifbavaro," & _
        "vggencalifbavaro," & _
        "vg1califbavaro," & _
        "ciclosbavaro," & _
        "nuevocalifbavaro," & _
        "calificadocalifbavaro," & _
        "cuposbavaro" & _
        " FROM" & _
        " vw_roportebavaro"
        If Me.codigoPais = 0 Then
            sql = sql & _
                " order by vggencalifbavaro desc"
        Else
            sql = sql & _
                " where idPais=" & Me.codigoPais & _
                " order by vg1califbavaro desc"
        End If
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    Function obtenerDetalleAfiliado() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTCalifCancun.idcalifcartagena," & _
        "TTCalifCancun.vpcalifcartagena," & _
        "TTCalifCancun.vgafilcalifcartagena," & _
        "TTCalifCancun.vggencalifcartagena," & _
        "TTCalifCancun.vg1califcartagena," & _
        "TTCalifCancun.nuevocalifcartagena," & _
        "TTCalifCancun.calificadocalifcartagena," & _
        "TTCalifCancun.cupos" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTCalifCancun ON dbo.Afiliaciones.codigoAfiliado = TTCalifCancun.codigoafiliado" & _
        " where" & _
        " dbo.Afiliaciones.codigopatrocinador = " & Me.codigoAfiliado
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' calificacion cancun 2016
    Function obtenerDetalleAfiliadoCancun2016() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido as nombres, " & _
        "TTCalifcancun2016.idcalifcancun," & _
        "TTCalifcancun2016.vpcalifcancun," & _
        "TTCalifcancun2016.vg1califcancun," & _
        "TTCalifcancun2016.nuevocalifcancun," & _
        "TTCalifcancun2016.calificadocalifcancun," & _
        "TTCalifcancun2016.cuposcancun," & _
        "TTCalifcancun2016.agocancun," & _
        "TTCalifcancun2016.septcalifcancun," & _
        "TTCalifcancun2016.octcalifcancun," & _
        "TTCalifcancun2016.novcalifcancun," & _
        "TTCalifcancun2016.diccalifcancun," & _
        "TTCalifcancun2016.enerocalifcancun" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTCalifcancun2016 ON dbo.Afiliaciones.codigoAfiliado = TTCalifcancun2016.codigoafiliado" & _
        " where" & _
        " dbo.Afiliaciones.codigopatrocinador = " & Me.codigoAfiliado
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' calificacion crucero 2016
    Function obtenerDetalleAfiliadoCrucero2016() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "'(' + dbo.Afiliaciones.codigoAfiliado + ') ' + dbo.Afiliaciones.Pnombre + ' ' + dbo.Afiliaciones.Snombre + ' ' + dbo.Afiliaciones.Papellido + ' ' + dbo.Afiliaciones.Sapellido nombres, " & _
        "TTCalifCrucero.vpcalifCrucero," & _
        "TTCalifCrucero.vgafilcalifCrucero," & _
        "TTCalifCrucero.nuevocalifCrucero," & _
        "TTCalifCrucero.cuposCrucero" & _
        " FROM" & _
        " dbo.Afiliaciones INNER JOIN" & _
        " TTCalifCrucero ON dbo.Afiliaciones.codigoAfiliado = TTCalifCrucero.codigoafiliado" & _
        " where dbo.Afiliaciones.codigopatrocinador = " & Me.codigoAfiliado
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' calificacion BAHAMAS 2016
    Function obtenerDetalleAfiliadoBAHAMAS() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "'(' + codigoAfiliado + ') ' + Pnombre + ' ' + Snombre + ' ' + Papellido + ' ' + Sapellido nombres, " & _
        "vpcalifBahamas," & _
        "vgafilcalifBahamas," & _
        "nuevocalifBahamas,calificadoCalifBahamas," & _
        "cuposBahamas" & _
        " FROM" & _
        " vw_roporteBAHAMAS" & _
        " where codigopatrocinador = " & Me.codigoAfiliado
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' calificacion Punta Cana 2017
    Function obtenerDetalleAfiliadopuntacana() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "'(' + codigoAfiliado + ') ' + Pnombre + ' ' + Snombre + ' ' + Papellido + ' ' + Sapellido nombres, " & _
        "vpcalifpuntacana," & _
        "vgafilcalifpuntacana," & _
        "nuevocalifpuntacana,calificadoCalifpuntacana," & _
        "cupospuntacana" & _
        " FROM" & _
        " vw_roportepuntacana" & _
        " where codigopatrocinador = " & Me.codigoAfiliado
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' calificacion europa 2020
    Function obtenerDetalleAfiliadoEuropa2020() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "'(' + codigoAfiliado + ') ' + nombres as nombres, " & _
        "vpcalifeuropa," & _
        "vg1califeuropa," & _
        "vg2califeuropa," & _
        "calificadoCalifeuropa," & _
        "cuposeuropa" & _
        " FROM" & _
        " vw_calificacionEuropa2020" & _
        " where codigopatrocinador = " & Me.codigoAfiliado
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' calificacion mexico 2019
    Function obtenerDetalleAfiliadomexico() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "'(' + codigoAfiliado + ') ' + nombres as nombres, " & _
        "vpcalifmexico," & _
        "vgafilcalifmexico," & _
        "vg2califmexico," & _
        "calificadoCalifmexico," & _
        "cuposmexico" & _
        " FROM" & _
        " vw_calificacionMexico2019" & _
        " where codigopatrocinador = " & Me.codigoAfiliado & _
        " order by vggencalifmexico desc"
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

    ' calificacion Bavaro 2018
    Function obtenerDetalleAfiliadobavaro() As DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "SELECT     " & _
        "'(' + codigoAfiliado + ') ' + Pnombre + ' ' + Snombre + ' ' + Papellido + ' ' + Sapellido nombres, " & _
        "vpcalifbavaro," & _
        "vgafilcalifbavaro," & _
        "vggencalifbavaro," & _
        "nuevocalifbavaro,calificadoCalifbavaro," & _
        "cuposbavaro" & _
        " FROM" & _
        " vw_roportebavaro" & _
        " where codigopatrocinador = " & Me.codigoAfiliado
        With objOperacione
            tabla = .DevuelveDato(sql)
        End With
        Return tabla
    End Function

End Class
